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
    public partial class FormHoaDon : Form
    {
        private bool _filterByDate = true;

        public class HoaDonDisplay
        {
            public int MaHD { get; set; }
            public DateTime NgayLap { get; set; }
            public string HinhThucTT { get; set; } = string.Empty;
            public decimal TongTien { get; set; }
        }

        public class ChiTietDisplay
        {
            public string TenMon { get; set; } = string.Empty;
            public int SoLy { get; set; }
            public decimal DonGia { get; set; }
            public decimal ThanhTien => SoLy * DonGia;
        }

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            dtpNgay.Value = DateTime.Today;
            dgvHoaDon.CellFormatting += DgvHoaDon_CellFormatting;
            dgvChiTiet.CellFormatting += DgvChiTiet_CellFormatting;
            LoadInvoices();
        }

        private void DgvHoaDon_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            string col = dgvHoaDon.Columns[e.ColumnIndex].Name;
            if (col == "colNgayLap" && e.Value is DateTime dt)
            {
                e.Value = dt.ToString("dd/MM/yyyy HH:mm");
                e.FormattingApplied = true;
            }
            else if (col == "colTongTien" && (e.Value is decimal || e.Value is double || e.Value is int))
            {
                e.Value = string.Format(new CultureInfo("vi-VN"), "{0:N0} đ", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void DgvChiTiet_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            string col = dgvChiTiet.Columns[e.ColumnIndex].Name;
            if ((col == "colDonGiaCT" || col == "colThanhTienCT") && (e.Value is decimal || e.Value is double || e.Value is int))
            {
                e.Value = string.Format(new CultureInfo("vi-VN"), "{0:N0} đ", e.Value);
                e.FormattingApplied = true;
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            _filterByDate = true;
            LoadInvoices();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            _filterByDate = !_filterByDate;
            btnLoc.Text = _filterByDate ? "Xem tất cả" : "Lọc theo ngày";
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                var query = db.HoaDons.AsQueryable();

                if (_filterByDate)
                {
                    DateTime start = dtpNgay.Value.Date;
                    DateTime end = start.AddDays(1);
                    query = query.Where(h => h.NgayLap >= start && h.NgayLap < end);
                }

                var list = query.OrderByDescending(h => h.NgayLap)
                    .Select(h => new HoaDonDisplay
                    {
                        MaHD = h.MaHd,
                        NgayLap = h.NgayLap,
                        HinhThucTT = h.HinhThucTt,
                        TongTien = h.TongTien
                    }).ToList();

                dgvHoaDon.DataSource = list;

                decimal revenue = list.Sum(h => h.TongTien);
                lblDoanhThu.Text = _filterByDate
                    ? $"Doanh thu ngày {dtpNgay.Value:dd/MM/yyyy}: {revenue:N0} đ"
                    : $"Tổng doanh thu: {revenue:N0} đ";

                if (list.Count > 0)
                {
                    LoadInvoiceDetails(list[0].MaHD);
                }
                else
                {
                    dgvChiTiet.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi khi nạp danh sách hóa đơn");
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvHoaDon.Rows[e.RowIndex].DataBoundItem is HoaDonDisplay item)
            {
                LoadInvoiceDetails(item.MaHD);
            }
        }

        private void LoadInvoiceDetails(int maHD)
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                var details = db.ChiTietHoaDons
                    .Where(c => c.MaHd == maHD)
                    .Include(c => c.MaMonNavigation)
                    .Select(c => new ChiTietDisplay
                    {
                        TenMon = c.MaMonNavigation.TenMon,
                        SoLy = c.SoLy,
                        DonGia = c.DonGia
                    }).ToList();

                dgvChiTiet.DataSource = details;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi nạp chi tiết hóa đơn MaHD={MaHD}", maHD);
            }
        }
    }
}
