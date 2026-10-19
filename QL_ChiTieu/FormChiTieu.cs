using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QL_ChiTieu.Models;
using Serilog;

namespace QL_ChiTieu
{
    public partial class FormChiTieu : Form
    {
        private int? _selectedMaCT = null;

        public FormChiTieu()
        {
            InitializeComponent();
        }

        private void FormChiTieu_Load(object sender, EventArgs e)
        {
            try
            {
                cboLoaiChi.SelectedIndex = 0;
                cboLocLoaiChi.SelectedIndex = 0; 

                dtpNgayChi.Value = DateTime.Today;
                dtpNgayChi.MaxDate = DateTime.Today;

               
                dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dtpDenNgay.Value = DateTime.Today;

                dgvChiTieu.CellFormatting += DgvChiTieu_CellFormatting;

                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi khởi động FormChiTieu");
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu ban đầu. Vui lòng kiểm tra kết nối CSDL.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvChiTieu_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string colName = dgvChiTieu.Columns[e.ColumnIndex].Name;
            if (colName == "colMaCT" && e.Value is int id)
            {
                e.Value = id.ToString("D3");
                e.FormattingApplied = true;
            }
            else if (colName == "colNgayChi" && e.Value is DateOnly d)
            {
                e.Value = d.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
            else if (colName == "colNgayChi" && e.Value is DateTime dt)
            {
                e.Value = dt.ToString("dd/MM/yyyy");
                e.FormattingApplied = true;
            }
            else if (colName == "colSoTien" && (e.Value is decimal || e.Value is double || e.Value is int))
            {
                e.Value = string.Format(new CultureInfo("vi-VN"), "{0:N0}", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void LoadData()
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                var query = db.ChiTieus.AsQueryable();

                // Lọc theo nội dung
                string keyword = txtTimNoiDung.Text.Trim();
                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(x => x.NoiDung.Contains(keyword));
                }

                // Lọc theo loại chi
                string loaiChi = cboLocLoaiChi.SelectedItem?.ToString() ?? "Tất cả";
                if (loaiChi != "Tất cả")
                {
                    query = query.Where(x => x.LoaiChi == loaiChi);
                }

                // Lọc theo khoảng ngày
                var tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
                var denNgay = DateOnly.FromDateTime(dtpDenNgay.Value.Date);
                query = query.Where(x => x.NgayChi >= tuNgay && x.NgayChi <= denNgay);

                var list = query.OrderByDescending(x => x.NgayChi).ThenByDescending(x => x.MaCt).ToList();
                dgvChiTieu.DataSource = list;

                // Tính tổng chi
                decimal tongChi = list.Sum(x => x.SoTien);
                lblTongChi.Text = $"Tổng chi: {tongChi.ToString("N0", new CultureInfo("vi-VN"))} đ";
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi truy vấn CSDL trong LoadData");
                MessageBox.Show("Không thể tải danh sách chi tiêu. Vui lòng thử lại sau.", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChiTieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvChiTieu.Rows[e.RowIndex].DataBoundItem is ChiTieu item)
            {
                _selectedMaCT = item.MaCt;
                dtpNgayChi.Value = item.NgayChi.ToDateTime(TimeOnly.MinValue);
                txtNoiDung.Text = item.NoiDung;
                cboLoaiChi.SelectedItem = item.LoaiChi;
                nudSoTien.Value = item.SoTien;
                txtGhiChu.Text = item.GhiChu ?? string.Empty;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using var db = AppConfig.CreateDbContext();
                var item = new ChiTieu
                {
                    NgayChi = DateOnly.FromDateTime(dtpNgayChi.Value.Date),
                    NoiDung = txtNoiDung.Text.Trim(),
                    LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? "Khác",
                    SoTien = nudSoTien.Value,
                    GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim()
                };

                db.ChiTieus.Add(item);
                db.SaveChanges();

                Log.Information("Thêm khoản chi thành công: MaCT={MaCT}, Số tiền={SoTien}", item.MaCt, item.SoTien);
                MessageBox.Show("Thêm khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi thêm khoản chi vào CSDL");
                MessageBox.Show("Đã xảy ra lỗi khi thêm dữ liệu vào CSDL. Vui lòng thử lại.", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaCT == null)
            {
                MessageBox.Show("Vui lòng chọn khoản chi cần sửa từ danh sách!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                using var db = AppConfig.CreateDbContext();
                var item = db.ChiTieus.Find(_selectedMaCT.Value);
                if (item == null)
                {
                    MessageBox.Show("Không tìm thấy khoản chi cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                item.NgayChi = DateOnly.FromDateTime(dtpNgayChi.Value.Date);
                item.NoiDung = txtNoiDung.Text.Trim();
                item.LoaiChi = cboLoaiChi.SelectedItem?.ToString() ?? "Khác";
                item.SoTien = nudSoTien.Value;
                item.GhiChu = string.IsNullOrWhiteSpace(txtGhiChu.Text) ? null : txtGhiChu.Text.Trim();

                db.SaveChanges();

                Log.Information("Sửa khoản chi thành công: MaCT={MaCT}, Số tiền={SoTien}", item.MaCt, item.SoTien);
                MessageBox.Show("Cập nhật khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi sửa khoản chi MaCT={MaCT}", _selectedMaCT);
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật CSDL. Vui lòng thử lại.", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaCT == null)
            {
                MessageBox.Show("Vui lòng chọn khoản chi cần xóa từ danh sách!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa khoản chi [Mã: {_selectedMaCT:D3}]?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes) return;

            try
            {
                using var db = AppConfig.CreateDbContext();
                var item = db.ChiTieus.Find(_selectedMaCT.Value);
                if (item != null)
                {
                    int ma = item.MaCt;
                    db.ChiTieus.Remove(item);
                    db.SaveChanges();

                    Log.Information("Xóa khoản chi thành công: MaCT={MaCT}", ma);
                    MessageBox.Show("Đã xóa khoản chi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi xóa khoản chi MaCT={MaCT}", _selectedMaCT);
                MessageBox.Show("Đã xảy ra lỗi khi xóa khoản chi trong CSDL.", "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            txtTimNoiDung.Clear();
            cboLocLoaiChi.SelectedIndex = 0;
            dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpDenNgay.Value = DateTime.Today;
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Nội dung chi tiêu không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoiDung.Focus();
                return false;
            }

            if (nudSoTien.Value <= 0)
            {
                MessageBox.Show("Số tiền chi tiêu phải lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoTien.Focus();
                return false;
            }

            if (dtpNgayChi.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày chi không được lớn hơn ngày hiện tại!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayChi.Focus();
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            _selectedMaCT = null;
            dtpNgayChi.Value = DateTime.Today;
            txtNoiDung.Clear();
            cboLoaiChi.SelectedIndex = 0;
            nudSoTien.Value = 0;
            txtGhiChu.Clear();
            txtNoiDung.Focus();
        }
    }
}
