using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QL_NhaTro.Models;
using Serilog;

namespace QL_NhaTro
{
    public partial class FormKhachThue : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10)
        };

        private int? _selectedMaKhach = null;
        private List<ProvinceItem> _provinces = new();
        private bool _isLoadingWards = false;

        public class ProvinceItem
        {
            public int code { get; set; }
            public string name { get; set; } = string.Empty;
            public override string ToString() => name;
        }

        public class ProvinceDetail
        {
            public int code { get; set; }
            public string name { get; set; } = string.Empty;
            public List<WardItem> wards { get; set; } = new();
        }

        public class WardItem
        {
            public int code { get; set; }
            public string name { get; set; } = string.Empty;
            public override string ToString() => name;
        }

        public class KhachThueDisplay
        {
            public int MaKhach { get; set; }
            public string HoTen { get; set; } = string.Empty;
            public string GioiTinh { get; set; } = string.Empty;
            public DateOnly NgaySinh { get; set; }
            public string SoDienThoai { get; set; } = string.Empty;
            public int MaPhong { get; set; }
            public string TenPhong { get; set; } = string.Empty;
            public decimal GiaThue { get; set; }
            public int MaTinh { get; set; }
            public string TenTinh { get; set; } = string.Empty;
            public int MaPhuongXa { get; set; }
            public string TenPhuongXa { get; set; } = string.Empty;
            public string QueQuan => $"{TenPhuongXa} - {TenTinh}";
            public bool DaDangKyTamTru { get; set; }
        }

        public FormKhachThue()
        {
            InitializeComponent();
        }

        private async void FormKhachThue_Load(object sender, EventArgs e)
        {
            try
            {
                dgvKhachThue.CellFormatting += DgvKhachThue_CellFormatting;
                LoadRoomComboBox();
                LoadFilterRooms();
                await LoadProvincesAsync();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi khởi chạy FormKhachThue");
                MessageBox.Show("Đã xảy ra lỗi khi tải ứng dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvKhachThue_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string colName = dgvKhachThue.Columns[e.ColumnIndex].Name;
            if (colName == "colGiaThue" && (e.Value is decimal || e.Value is double || e.Value is int))
            {
                e.Value = string.Format(new CultureInfo("vi-VN"), "{0:N0} đ", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void LoadRoomComboBox()
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                var rooms = db.PhongTros.OrderBy(p => p.TenPhong).ToList();
                cboPhong.DataSource = rooms.Select(p => new
                {
                    p.MaPhong,
                    DisplayName = $"{p.TenPhong} - {p.GiaThue.ToString("N0", new CultureInfo("vi-VN"))} đ ({p.TinhTrang})"
                }).ToList();
                cboPhong.DisplayMember = "DisplayName";
                cboPhong.ValueMember = "MaPhong";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp danh sách phòng");
            }
        }

        private void LoadFilterRooms()
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                var rooms = db.PhongTros.OrderBy(p => p.TenPhong).Select(p => p.TenPhong).ToList();
                cboLocPhong.Items.Clear();
                cboLocPhong.Items.Add("Tất cả");
                foreach (var r in rooms) cboLocPhong.Items.Add(r);
                cboLocPhong.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp phòng lọc");
            }
        }

        private async Task LoadProvincesAsync()
        {
            cboTinh.Enabled = false;
            lblStatus.Text = "Đang tải danh sách tỉnh/thành từ provinces.open-api.vn...";

            try
            {
                string json = await _httpClient.GetStringAsync("https://provinces.open-api.vn/api/v2/");
                var list = JsonSerializer.Deserialize<List<ProvinceItem>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                if (list != null && list.Count > 0)
                {
                    _provinces = list;
                    cboTinh.DataSource = new BindingSource(_provinces, null);
                    cboTinh.DisplayMember = "name";
                    cboTinh.ValueMember = "code";

                    // Load filter province combo
                    cboLocTinh.Items.Clear();
                    cboLocTinh.Items.Add("Tất cả");
                    foreach (var p in _provinces) cboLocTinh.Items.Add(p.name);
                    cboLocTinh.SelectedIndex = 0;

                    lblStatus.Text = $"Đã tải {_provinces.Count} tỉnh/thành từ provinces.open-api.vn";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException)
            {
                Log.Warning(ex, "Không thể kết nối đến API provinces.open-api.vn");
                lblStatus.Text = "Không có kết nối mạng. Cho phép nhập tay quê quán.";
                MessageBox.Show("Không tải được danh sách địa chỉ, vui lòng kiểm tra mạng. Bạn có thể tự gõ tên Tỉnh/Thành và Phường/Xã.", "Thông báo mạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTinh.DropDownStyle = ComboBoxStyle.DropDown;
                cboPhuongXa.DropDownStyle = ComboBoxStyle.DropDown;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi phân tích cú pháp API tỉnh thành");
            }
            finally
            {
                cboTinh.Enabled = true;
            }
        }

        private async void cboTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingWards || cboTinh.SelectedValue == null) return;

            if (cboTinh.SelectedValue is int code)
            {
                await LoadWardsAsync(code);
            }
        }

        private async Task LoadWardsAsync(int provinceCode)
        {
            _isLoadingWards = true;
            cboPhuongXa.Enabled = false;
            cboPhuongXa.Text = "Đang tải…";

            try
            {
                string json = await _httpClient.GetStringAsync($"https://provinces.open-api.vn/api/v2/p/{provinceCode}?depth=2");
                var detail = JsonSerializer.Deserialize<ProvinceDetail>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                if (detail != null && detail.wards != null)
                {
                    cboPhuongXa.DataSource = new BindingSource(detail.wards, null);
                    cboPhuongXa.DisplayMember = "name";
                    cboPhuongXa.ValueMember = "code";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException)
            {
                Log.Warning(ex, "Không thể kết nối API phường xã cho tỉnh code={Code}", provinceCode);
                cboPhuongXa.DataSource = null;
                cboPhuongXa.Text = string.Empty;
                MessageBox.Show("Không tải được danh sách phường/xã, vui lòng kiểm tra mạng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi phân tích phường xã");
            }
            finally
            {
                cboPhuongXa.Enabled = true;
                _isLoadingWards = false;
            }
        }

        private void LoadData()
        {
            try
            {
                using var db = AppConfig.CreateDbContext();

                var query = db.KhachThues.Include(k => k.MaPhongNavigation).AsQueryable();

                string kw = txtTimKiem.Text.Trim();
                if (!string.IsNullOrEmpty(kw))
                {
                    query = query.Where(k => k.HoTen.Contains(kw) || k.SoDienThoai.Contains(kw));
                }

                string locPhong = cboLocPhong.SelectedItem?.ToString() ?? "Tất cả";
                if (locPhong != "Tất cả")
                {
                    query = query.Where(k => k.MaPhongNavigation.TenPhong == locPhong);
                }

                string locTinh = cboLocTinh.SelectedItem?.ToString() ?? "Tất cả";
                if (locTinh != "Tất cả")
                {
                    query = query.Where(k => k.TenTinh == locTinh);
                }

                var list = query.OrderBy(k => k.MaPhongNavigation.TenPhong).ThenBy(k => k.HoTen)
                    .Select(k => new KhachThueDisplay
                    {
                        MaKhach = k.MaKhach,
                        HoTen = k.HoTen,
                        GioiTinh = k.GioiTinh,
                        NgaySinh = k.NgaySinh,
                        SoDienThoai = k.SoDienThoai,
                        MaPhong = k.MaPhong,
                        TenPhong = k.MaPhongNavigation.TenPhong,
                        GiaThue = k.MaPhongNavigation.GiaThue,
                        MaTinh = k.MaTinh,
                        TenTinh = k.TenTinh,
                        MaPhuongXa = k.MaPhuongXa,
                        TenPhuongXa = k.TenPhuongXa,
                        DaDangKyTamTru = k.DaDangKyTamTru
                    }).ToList();

                dgvKhachThue.DataSource = list;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi truy vấn CSDL khi nạp danh sách khách thuê");
                MessageBox.Show("Đã xảy ra lỗi khi truy vấn cơ sở dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKhachThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvKhachThue.Rows[e.RowIndex].DataBoundItem is KhachThueDisplay item)
            {
                _selectedMaKhach = item.MaKhach;
                txtHoTen.Text = item.HoTen;
                if (item.GioiTinh == "Nữ") rbNu.Checked = true; else rbNam.Checked = true;
                dtpNgaySinh.Value = item.NgaySinh.ToDateTime(TimeOnly.MinValue);
                txtSoDienThoai.Text = item.SoDienThoai;
                cboPhong.SelectedValue = item.MaPhong;
                chkTamTru.Checked = item.DaDangKyTamTru;

                // Chọn tỉnh
                if (item.MaTinh > 0)
                {
                    cboTinh.SelectedValue = item.MaTinh;
                }
                else
                {
                    cboTinh.Text = item.TenTinh;
                }

                cboPhuongXa.Text = item.TenPhuongXa;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using var db = AppConfig.CreateDbContext();

                int maPhong = (int)cboPhong.SelectedValue!;
                int maTinh = cboTinh.SelectedValue is int tc ? tc : 0;
                string tenTinh = cboTinh.Text.Trim();
                int maPhuong = cboPhuongXa.SelectedValue is int wc ? wc : 0;
                string tenPhuong = cboPhuongXa.Text.Trim();

                var khach = new KhachThue
                {
                    HoTen = txtHoTen.Text.Trim(),
                    GioiTinh = rbNu.Checked ? "Nữ" : "Nam",
                    NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value.Date),
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    MaPhong = maPhong,
                    MaTinh = maTinh,
                    TenTinh = tenTinh,
                    MaPhuongXa = maPhuong,
                    TenPhuongXa = tenPhuong,
                    DaDangKyTamTru = chkTamTru.Checked
                };

                db.KhachThues.Add(khach);

                // Cập nhật trạng thái phòng thành "Đang thuê"
                var phong = db.PhongTros.Find(maPhong);
                if (phong != null)
                {
                    phong.TinhTrang = "Đang thuê";
                }

                db.SaveChanges();

                Log.Information("Thêm khách thuê thành công: MaKhach={MaKhach}, HoTen={HoTen}, Phong={MaPhong}", khach.MaKhach, khach.HoTen, maPhong);
                MessageBox.Show("Thêm khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadRoomComboBox();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi thêm khách thuê vào CSDL");
                MessageBox.Show("Đã xảy ra lỗi khi thêm khách thuê vào CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaKhach == null)
            {
                MessageBox.Show("Vui lòng chọn khách thuê cần sửa từ danh sách!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            try
            {
                using var db = AppConfig.CreateDbContext();
                var khach = db.KhachThues.Find(_selectedMaKhach.Value);
                if (khach == null)
                {
                    MessageBox.Show("Không tìm thấy khách thuê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int oldMaPhong = khach.MaPhong;
                int newMaPhong = (int)cboPhong.SelectedValue!;

                khach.HoTen = txtHoTen.Text.Trim();
                khach.GioiTinh = rbNu.Checked ? "Nữ" : "Nam";
                khach.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value.Date);
                khach.SoDienThoai = txtSoDienThoai.Text.Trim();
                khach.MaPhong = newMaPhong;
                khach.MaTinh = cboTinh.SelectedValue is int tc ? tc : 0;
                khach.TenTinh = cboTinh.Text.Trim();
                khach.MaPhuongXa = cboPhuongXa.SelectedValue is int wc ? wc : 0;
                khach.TenPhuongXa = cboPhuongXa.Text.Trim();
                khach.DaDangKyTamTru = chkTamTru.Checked;

                // Nếu đổi phòng:
                if (oldMaPhong != newMaPhong)
                {
                    var newPhong = db.PhongTros.Find(newMaPhong);
                    if (newPhong != null) newPhong.TinhTrang = "Đang thuê";

                    // Kiểm tra phòng cũ còn khách nào không
                    bool hasOtherTenants = db.KhachThues.Any(k => k.MaPhong == oldMaPhong && k.MaKhach != khach.MaKhach);
                    if (!hasOtherTenants)
                    {
                        var oldPhong = db.PhongTros.Find(oldMaPhong);
                        if (oldPhong != null) oldPhong.TinhTrang = "Trống";
                    }
                }

                db.SaveChanges();

                Log.Information("Cập nhật khách thuê thành công: MaKhach={MaKhach}", khach.MaKhach);
                MessageBox.Show("Cập nhật khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadRoomComboBox();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi cập nhật khách thuê MaKhach={MaKhach}", _selectedMaKhach);
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật thông tin khách thuê.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaKhach == null)
            {
                MessageBox.Show("Vui lòng chọn khách thuê cần xóa từ danh sách!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa khách thuê này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes) return;

            try
            {
                using var db = AppConfig.CreateDbContext();
                var khach = db.KhachThues.Find(_selectedMaKhach.Value);
                if (khach != null)
                {
                    int maPhong = khach.MaPhong;
                    int maKhach = khach.MaKhach;
                    db.KhachThues.Remove(khach);
                    db.SaveChanges();

                    // Kiểm tra phòng còn ai không, nếu không còn ai thì chuyển về "Trống"
                    bool hasTenants = db.KhachThues.Any(k => k.MaPhong == maPhong);
                    if (!hasTenants)
                    {
                        var phong = db.PhongTros.Find(maPhong);
                        if (phong != null)
                        {
                            phong.TinhTrang = "Trống";
                            db.SaveChanges();
                        }
                    }

                    Log.Information("Xóa khách thuê thành công: MaKhach={MaKhach}", maKhach);
                    MessageBox.Show("Đã xóa khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetForm();
                LoadRoomComboBox();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi xóa khách thuê MaKhach={MaKhach}", _selectedMaKhach);
                MessageBox.Show("Đã xảy ra lỗi khi xóa khách thuê.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocPhong.SelectedIndex = 0;
            cboLocTinh.SelectedIndex = 0;
            LoadData();
        }

        private void btnGayLoiThu_Click(object sender, EventArgs e)
        {
            // Task 7: Thêm một nút ẩn "Gây lỗi thử" để kiểm tra xử lý lỗi toàn cục
            throw new InvalidOperationException("Đây là ngoại lệ thử nghiệm để kiểm tra tính năng xử lý lỗi toàn cục!");
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách thuê!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return false;
            }

            if (cboPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng trọ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhong.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboTinh.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Tỉnh/Thành!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTinh.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cboPhuongXa.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Phường/Xã!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhuongXa.Focus();
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            _selectedMaKhach = null;
            txtHoTen.Clear();
            rbNam.Checked = true;
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            txtSoDienThoai.Clear();
            chkTamTru.Checked = false;
            txtHoTen.Focus();
        }
    }
}
