using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QL_TraSua.Models;
using Serilog;

namespace QL_TraSua
{
    public partial class FormThucDon : Form
    {
        private int? _selectedMaMon = null;

        public class MonUongDisplay
        {
            public int MaMon { get; set; }
            public string TenMon { get; set; } = string.Empty;
            public int MaDM { get; set; }
            public string TenDM { get; set; } = string.Empty;
            public decimal GiaBan { get; set; }
            public bool DangBan { get; set; }
        }

        public FormThucDon()
        {
            InitializeComponent();
        }

        private void FormThucDon_Load(object sender, EventArgs e)
        {
            dgvMonUong.CellFormatting += DgvMonUong_CellFormatting;
            LoadCategories();
            LoadData();
        }

        private void DgvMonUong_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string colName = dgvMonUong.Columns[e.ColumnIndex].Name;
            if (colName == "colGiaBan" && (e.Value is decimal || e.Value is double || e.Value is int))
            {
                e.Value = string.Format(new CultureInfo("vi-VN"), "{0:N0} đ", e.Value);
                e.FormattingApplied = true;
            }
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

                cboLocDM.Items.Clear();
                cboLocDM.Items.Add("Tất cả danh mục");
                foreach (var c in categories) cboLocDM.Items.Add(c.TenDm);
                cboLocDM.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp danh mục món");
            }
        }

        public void LoadData()
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                var query = db.MonUongs.Include(m => m.MaDmNavigation).AsQueryable();

                string kw = txtTimTen.Text.Trim();
                if (!string.IsNullOrEmpty(kw))
                {
                    query = query.Where(m => m.TenMon.Contains(kw));
                }

                string locDM = cboLocDM.SelectedItem?.ToString() ?? "Tất cả danh mục";
                if (locDM != "Tất cả danh mục")
                {
                    query = query.Where(m => m.MaDmNavigation.TenDm == locDM);
                }

                var list = query.OrderBy(m => m.MaDm).ThenBy(m => m.TenMon)
                    .Select(m => new MonUongDisplay
                    {
                        MaMon = m.MaMon,
                        TenMon = m.TenMon,
                        MaDM = m.MaDm,
                        TenDM = m.MaDmNavigation.TenDm,
                        GiaBan = m.GiaBan,
                        DangBan = m.DangBan
                    }).ToList();

                dgvMonUong.DataSource = list;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi nạp thực đơn");
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMonUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvMonUong.Rows[e.RowIndex].DataBoundItem is MonUongDisplay item)
            {
                _selectedMaMon = item.MaMon;
                txtTenMon.Text = item.TenMon;
                cboDanhMuc.SelectedValue = item.MaDM;
                nudGiaBan.Value = item.GiaBan;
                chkDangBan.Checked = item.DangBan;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMon.Focus();
                return;
            }

            if (cboDanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục món!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = AppConfig.CreateDbContext();
                var mon = new MonUong
                {
                    TenMon = txtTenMon.Text.Trim(),
                    MaDm = (int)cboDanhMuc.SelectedValue,
                    GiaBan = nudGiaBan.Value,
                    DangBan = chkDangBan.Checked
                };

                db.MonUongs.Add(mon);
                db.SaveChanges();

                Log.Information("Thêm món: MaMon={MaMon}, TenMon={TenMon}", mon.MaMon, mon.TenMon);
                MessageBox.Show("Thêm món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi thêm món vào CSDL");
                MessageBox.Show("Đã xảy ra lỗi khi thêm món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaMon == null)
            {
                MessageBox.Show("Vui lòng chọn món cần sửa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = AppConfig.CreateDbContext();
                var mon = db.MonUongs.Find(_selectedMaMon.Value);
                if (mon == null) return;

                mon.TenMon = txtTenMon.Text.Trim();
                mon.MaDm = (int)cboDanhMuc.SelectedValue!;
                mon.GiaBan = nudGiaBan.Value;
                mon.DangBan = chkDangBan.Checked;

                db.SaveChanges();

                Log.Information("Cập nhật món: MaMon={MaMon}", mon.MaMon);
                MessageBox.Show("Cập nhật món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi cập nhật món MaMon={MaMon}", _selectedMaMon);
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaMon == null)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using var db = AppConfig.CreateDbContext();
                var mon = db.MonUongs.Find(_selectedMaMon.Value);
                if (mon != null)
                {
                    // Kiểm tra xem món đã nằm trong chi tiết hóa đơn nào chưa
                    bool hasInvoiceDetails = db.ChiTietHoaDons.Any(c => c.MaMon == mon.MaMon);
                    if (hasInvoiceDetails)
                    {
                        var opt = MessageBox.Show("Món này đã tồn tại trong lịch sử hóa đơn nên không thể xóa hoàn toàn. Bạn có muốn chuyển trạng thái thành [Ngừng bán] không?", "Lưu ý ràng buộc CSDL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (opt == DialogResult.Yes)
                        {
                            mon.DangBan = false;
                            db.SaveChanges();
                            MessageBox.Show("Đã chuyển trạng thái món sang [Ngừng bán].", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        int id = mon.MaMon;
                        db.MonUongs.Remove(mon);
                        db.SaveChanges();
                        Log.Information("Xóa món: MaMon={MaMon}", id);
                        MessageBox.Show("Đã xóa món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi xóa món MaMon={MaMon}", _selectedMaMon);
                MessageBox.Show("Đã xảy ra lỗi khi xóa món.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtTimTen.Clear();
            cboLocDM.SelectedIndex = 0;
            LoadData();
        }

        private void ResetForm()
        {
            _selectedMaMon = null;
            txtTenMon.Clear();
            nudGiaBan.Value = 0;
            chkDangBan.Checked = true;
            if (cboDanhMuc.Items.Count > 0) cboDanhMuc.SelectedIndex = 0;
            txtTenMon.Focus();
        }
    }
}
