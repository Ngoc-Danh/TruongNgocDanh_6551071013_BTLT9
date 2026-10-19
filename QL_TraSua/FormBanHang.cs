using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QL_TraSua.Models;
using Serilog;

namespace QL_TraSua
{
    public partial class FormBanHang : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10)
        };

        private readonly BindingList<CartItem> _cart = new();
        private string _currentPaymentMethod = "Tiền mặt";
        private string _lastTransferContent = string.Empty;

        public class CartItem
        {
            public int MaMon { get; set; }
            public string TenMon { get; set; } = string.Empty;
            public int SoLy { get; set; }
            public decimal DonGia { get; set; }
            public decimal ThanhTien => SoLy * DonGia;
        }

        public class MonUongItem
        {
            public int MaMon { get; set; }
            public string TenMon { get; set; } = string.Empty;
            public decimal GiaBan { get; set; }
            public override string ToString() => $"{TenMon} - {GiaBan.ToString("N0", new CultureInfo("vi-VN"))} đ";
        }

        public FormBanHang()
        {
            InitializeComponent();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            dgvGioHang.AutoGenerateColumns = false;
            dgvGioHang.DataSource = _cart;
            dgvGioHang.CellFormatting += DgvGioHang_CellFormatting;

            LoadPaymentAccountInfo();
            LoadCategories();
        }

        private void DgvGioHang_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            string colName = dgvGioHang.Columns[e.ColumnIndex].Name;
            if ((colName == "colDonGia" || colName == "colThanhTien") && (e.Value is decimal || e.Value is double || e.Value is int))
            {
                e.Value = string.Format(new CultureInfo("vi-VN"), "{0:N0} đ", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void LoadPaymentAccountInfo()
        {
            var p = AppConfig.Settings.Payment;
            lblInfoTK.Text = $"Chủ TK: {p.AccountName}\nNgân hàng: {p.TenNganHang}\nSTK: {MaskAccountNo(p.AccountNo)}";
        }

        private static string MaskAccountNo(string acc)
        {
            if (string.IsNullOrEmpty(acc) || acc.Length <= 4) return acc;
            return new string('*', acc.Length - 4) + acc.Substring(acc.Length - 4);
        }

        private void LoadCategories()
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                var categories = db.DanhMucMons.OrderBy(d => d.MaDm).ToList();
                cboDanhMuc.DataSource = new BindingSource(categories, null);
                cboDanhMuc.DisplayMember = "TenDm";
                cboDanhMuc.ValueMember = "MaDm";

                if (categories.Count > 0)
                {
                    LoadDrinkList(categories[0].MaDm);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp danh mục");
            }
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedValue is int maDM)
            {
                LoadDrinkList(maDM);
            }
        }

        private void LoadDrinkList(int maDM)
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                var drinks = db.MonUongs
                    .Where(m => m.MaDm == maDM && m.DangBan)
                    .OrderBy(m => m.TenMon)
                    .Select(m => new MonUongItem
                    {
                        MaMon = m.MaMon,
                        TenMon = m.TenMon,
                        GiaBan = m.GiaBan
                    }).ToList();

                lbMonUong.DataSource = drinks;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi nạp danh sách món uống");
            }
        }

        private void btnThemVaoDon_Click(object sender, EventArgs e)
        {
            if (lbMonUong.SelectedItem is not MonUongItem selected)
            {
                MessageBox.Show("Vui lòng chọn món uống từ danh sách!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qty = (int)nudSoLy.Value;
            var existing = _cart.FirstOrDefault(c => c.MaMon == selected.MaMon);
            if (existing != null)
            {
                existing.SoLy += qty;
                _cart.ResetBindings();
            }
            else
            {
                _cart.Add(new CartItem
                {
                    MaMon = selected.MaMon,
                    TenMon = selected.TenMon,
                    SoLy = qty,
                    DonGia = selected.GiaBan
                });
            }

            nudSoLy.Value = 1;
            UpdateTotal();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow?.DataBoundItem is CartItem item)
            {
                _cart.Remove(item);
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            decimal total = _cart.Sum(c => c.ThanhTien);
            lblTongTien.Text = $"Tổng tiền: {total:N0} đ";
            lblSoTienQR.Text = $"Số tiền: {total:N0} đ";

            if (pbVietQR.Image != null)
            {
                // Khi giỏ hàng thay đổi thì xóa mã QR cũ để tránh lệch tiền
                pbVietQR.Image.Dispose();
                pbVietQR.Image = null;
                lblNoiDungQR.Text = "Nội dung: --";
            }
        }

        private async void btnThanhToanCK_Click(object sender, EventArgs e)
        {
            decimal tongTien = _cart.Sum(c => c.ThanhTien);
            if (tongTien <= 0)
            {
                MessageBox.Show("Đơn hàng đang trống. Vui lòng thêm món trước khi thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentPaymentMethod = "Chuyển khoản";
            btnThanhToanCK.Enabled = false;

            try
            {
                var p = AppConfig.Settings.Payment;

                // Tạo mã nội dung chuyển khoản
                int nextId = GetNextInvoiceId();
                string noiDung = $"TRASUA HD{nextId}";
                _lastTransferContent = noiDung;

                // Log Information khi tạo QR (không log full STK theo task 7)
                Log.Information("Tạo mã QR chuyển khoản: MaHD={MaHD}, Số tiền={SoTien}", nextId, tongTien);

                // Tạo URL VietQR
                string encodedNoiDung = Uri.EscapeDataString(noiDung);
                string encodedAccName = Uri.EscapeDataString(p.AccountName);
                string url = $"https://img.vietqr.io/image/{p.BankId}-{p.AccountNo}-{p.Template}.png?amount={(long)tongTien}&addInfo={encodedNoiDung}&accountName={encodedAccName}";

                // Tải ảnh qua HttpClient
                byte[] imgBytes = await _httpClient.GetByteArrayAsync(url);
                using var ms = new MemoryStream(imgBytes);

                if (pbVietQR.Image != null)
                {
                    pbVietQR.Image.Dispose();
                }
                pbVietQR.Image = Image.FromStream(ms);

                lblInfoTK.Text = $"Chủ TK: {p.AccountName}\nNgân hàng: {p.TenNganHang}\nSTK: {p.AccountNo}";
                lblSoTienQR.Text = $"Số tiền: {tongTien:N0} đ";
                lblNoiDungQR.Text = $"Nội dung: {noiDung}";
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException)
            {
                Log.Error(ex, "Tải ảnh VietQR thất bại do sự cố mạng.");
                var p = AppConfig.Settings.Payment;
                lblInfoTK.Text = $"Chủ TK: {p.AccountName}\nNgân hàng: {p.TenNganHang}\nSTK: {p.AccountNo}";
                lblNoiDungQR.Text = $"Nội dung: {_lastTransferContent}";
                MessageBox.Show("Không thể tải ảnh QR do mất kết nối mạng.\nKhách có thể chuyển khoản thủ công theo thông tin hiển thị bên dưới, hoặc bấm [Tiền mặt] để đổi hình thức.", "Lỗi mạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi xử lý tạo VietQR");
                MessageBox.Show("Đã xảy ra lỗi khi tạo mã QR.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnThanhToanCK.Enabled = true;
            }
        }

        private void btnTienMat_Click(object sender, EventArgs e)
        {
            decimal tongTien = _cart.Sum(c => c.ThanhTien);
            if (tongTien <= 0)
            {
                MessageBox.Show("Đơn hàng đang trống. Vui lòng thêm món trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _currentPaymentMethod = "Tiền mặt";
            if (pbVietQR.Image != null)
            {
                pbVietQR.Image.Dispose();
                pbVietQR.Image = null;
            }
            lblNoiDungQR.Text = "Hình thức: Tiền mặt";

            var confirm = MessageBox.Show($"Xác nhận thanh toán TIỀN MẶT số tiền: {tongTien:N0} đ?", "Xác nhận thu tiền mặt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                SaveInvoice(hinhThuc: "Tiền mặt");
            }
        }

        private void btnDaNhanTien_Click(object sender, EventArgs e)
        {
            decimal tongTien = _cart.Sum(c => c.ThanhTien);
            if (tongTien <= 0)
            {
                MessageBox.Show("Đơn hàng đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Thu ngân đã kiểm tra tin nhắn ngân hàng và xác nhận nhận đủ {tongTien:N0} đ?", "Xác nhận đã nhận tiền chuyển khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                SaveInvoice(hinhThuc: _currentPaymentMethod);
            }
        }

        private void SaveInvoice(string hinhThuc)
        {
            try
            {
                decimal tongTien = _cart.Sum(c => c.ThanhTien);

                using var db = AppConfig.CreateDbContext();

                var hd = new HoaDon
                {
                    NgayLap = DateTime.Now,
                    TongTien = tongTien,
                    HinhThucTt = hinhThuc,
                    DaThanhToan = true
                };

                // Lưu HoaDon và ChiTietHoaDon trong cùng 1 lần SaveChanges
                foreach (var item in _cart)
                {
                    hd.ChiTietHoaDons.Add(new ChiTietHoaDon
                    {
                        MaMon = item.MaMon,
                        SoLy = item.SoLy,
                        DonGia = item.DonGia
                    });
                }

                db.HoaDons.Add(hd);
                db.SaveChanges();

                Log.Information("Lưu hóa đơn thành công: MaHD={MaHD}, HinhThuc={HinhThuc}, TongTien={TongTien}", hd.MaHd, hinhThuc, tongTien);
                MessageBox.Show($"Thanh toán thành công hóa đơn #{hd.MaHd}!\nTổng tiền: {tongTien:N0} đ\nHình thức: {hinhThuc}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Dọn dẹp giỏ hàng
                _cart.Clear();
                UpdateTotal();
                if (pbVietQR.Image != null)
                {
                    pbVietQR.Image.Dispose();
                    pbVietQR.Image = null;
                }
                lblNoiDungQR.Text = "Nội dung: --";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi lưu hóa đơn vào CSDL");
                MessageBox.Show("Đã xảy ra lỗi khi lưu hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetNextInvoiceId()
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                int max = db.HoaDons.Max(h => (int?)h.MaHd) ?? 1000;
                return max + 1;
            }
            catch
            {
                return new Random().Next(1001, 9999);
            }
        }

        private void btnMoThucDon_Click(object sender, EventArgs e)
        {
            using var f = new FormThucDon();
            f.ShowDialog(this);
            // Nạp lại danh mục và món sau khi đóng form quản lý thực đơn
            LoadCategories();
        }

        private void btnMoHoaDon_Click(object sender, EventArgs e)
        {
            using var f = new FormHoaDon();
            f.ShowDialog(this);
        }
    }
}
