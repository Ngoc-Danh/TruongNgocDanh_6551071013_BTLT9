using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DaNgoai.Models;
using Serilog;

namespace QL_DaNgoai
{
    public partial class FormChuyenDi : Form
    {
        private static readonly HttpClient _httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(8)
        };

        private int? _selectedMaChuyen = null;
        private string _currentLang = "vi"; // "vi" hoặc "en"
        private readonly string _settingsFilePath;

        // Model dữ liệu thời tiết
        public class GeocodingResponse
        {
            public List<GeoResult>? results { get; set; }
        }

        public class GeoResult
        {
            public string name { get; set; } = string.Empty;
            public double latitude { get; set; }
            public double longitude { get; set; }
        }

        public class WeatherResponse
        {
            public DailyData? daily { get; set; }
        }

        public class DailyData
        {
            public List<string> time { get; set; } = new();
            public List<int> weather_code { get; set; } = new();
            public List<double> temperature_2m_max { get; set; } = new();
            public List<double> temperature_2m_min { get; set; } = new();
            public List<int> precipitation_probability_max { get; set; } = new();
        }

        public class UserSettings
        {
            public string Language { get; set; } = "vi";
        }

        public FormChuyenDi()
        {
            InitializeComponent();
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appDir = Path.Combine(localAppData, "QL_DaNgoai");
            if (!Directory.Exists(appDir)) Directory.CreateDirectory(appDir);
            _settingsFilePath = Path.Combine(appDir, "usersettings.json");
        }

        private void FormChuyenDi_Load(object sender, EventArgs e)
        {
            LoadUserSettings();

            dgvChuyenDi.CellFormatting += DgvChuyenDi_CellFormatting;

            dtpNgayDi.Value = DateTime.Today;
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today.AddDays(30);

            cboPhuongTien.SelectedIndex = 0;

            LoadData();
        }

        private void LoadUserSettings()
        {
            try
            {
                if (File.Exists(_settingsFilePath))
                {
                    string json = File.ReadAllText(_settingsFilePath);
                    var settings = JsonSerializer.Deserialize<UserSettings>(json);
                    if (settings != null && !string.IsNullOrEmpty(settings.Language))
                    {
                        _currentLang = settings.Language;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Không thể đọc usersettings.json, sử dụng mặc định vi.");
            }

            cboNgonNgu.SelectedIndex = _currentLang == "en" ? 1 : 0;
            ApplyLanguage(_currentLang);
        }

        private void SaveUserSettings()
        {
            try
            {
                var settings = new UserSettings { Language = _currentLang };
                string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_settingsFilePath, json);
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Không thể lưu usersettings.json");
            }
        }

        private void cboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newLang = cboNgonNgu.SelectedIndex == 1 ? "en" : "vi";
            if (newLang != _currentLang)
            {
                _currentLang = newLang;
                SaveUserSettings();
                ApplyLanguage(_currentLang);
                dgvChuyenDi.Refresh();
            }
        }

        private void ApplyLanguage(string lang)
        {
            bool isVi = lang == "vi";

            this.Text = isVi ? "Kế hoạch dã ngoại" : "Picnic Planner";
            lblHeader.Text = isVi ? "Kế hoạch dã ngoại cuối tuần" : "Weekend Picnic Planner";
            lblNgonNgu.Text = isVi ? "Ngôn ngữ:" : "Language:";

            gbThongTin.Text = isVi ? "Thông tin chuyến đi" : "Trip Information";
            lblTenChuyen.Text = isVi ? "Tên chuyến:" : "Trip Name:";
            lblDiaDiem.Text = isVi ? "Địa điểm:" : "Location:";
            lblNgayDi.Text = isVi ? "Ngày đi:" : "Date:";
            lblSoNguoi.Text = isVi ? "Số người:" : "Members:";
            lblNganSach.Text = isVi ? "Ngân sách:" : "Budget:";
            lblPhuongTien.Text = isVi ? "Phương tiện:" : "Transport:";
            chkDaHoanThanh.Text = isVi ? "Đã hoàn thành" : "Completed";

            btnThem.Text = isVi ? "Thêm" : "Add";
            btnSua.Text = isVi ? "Sửa" : "Edit";
            btnXoa.Text = isVi ? "Xóa" : "Delete";
            btnLamMoi.Text = isVi ? "Làm mới" : "Refresh";

            gbThoiTiet.Text = isVi ? "Dự báo thời tiết" : "Weather Forecast";
            btnXemThoiTiet.Text = isVi ? "Xem thời tiết" : "Check Weather";

            txtTim.PlaceholderText = isVi ? "Tìm địa điểm..." : "Search destination...";
            chkChuaHoanThanh.Text = isVi ? "Chỉ hiện chuyến chưa hoàn thành" : "Incomplete trips only";
            lblTuNgay.Text = isVi ? "Từ:" : "From:";
            lblDenNgay.Text = isVi ? "Đến:" : "To:";
            btnTim.Text = isVi ? "Tìm" : "Filter";
            btnBoLoc.Text = isVi ? "Bỏ lọc" : "Clear";

            // Grid columns
            colMa.HeaderText = isVi ? "Mã" : "ID";
            colTenChuyen.HeaderText = isVi ? "Tên chuyến" : "Trip Name";
            colDiaDiem.HeaderText = isVi ? "Địa điểm" : "Destination";
            colNgayDi.HeaderText = isVi ? "Ngày đi" : "Date";
            colSoNguoi.HeaderText = isVi ? "Số người" : "People";
            colNganSach.HeaderText = isVi ? "Ngân sách" : "Budget";
            colPhuongTien.HeaderText = isVi ? "Phương tiện" : "Transport";
            colHoanThanh.HeaderText = isVi ? "Hoàn thành" : "Done";

            dtpNgayDi.CustomFormat = isVi ? "dd/MM/yyyy" : "MM/dd/yyyy";
            dtpTuNgay.CustomFormat = isVi ? "dd/MM/yyyy" : "MM/dd/yyyy";
            dtpDenNgay.CustomFormat = isVi ? "dd/MM/yyyy" : "MM/dd/yyyy";
        }

        private void DgvChuyenDi_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string colName = dgvChuyenDi.Columns[e.ColumnIndex].Name;
            var culture = new CultureInfo(_currentLang == "vi" ? "vi-VN" : "en-US");

            if (colName == "colNgayDi")
            {
                if (e.Value is DateOnly d)
                {
                    e.Value = d.ToString(_currentLang == "vi" ? "dd/MM/yyyy" : "MM/dd/yyyy");
                    e.FormattingApplied = true;
                }
                else if (e.Value is DateTime dt)
                {
                    e.Value = dt.ToString(_currentLang == "vi" ? "dd/MM/yyyy" : "MM/dd/yyyy");
                    e.FormattingApplied = true;
                }
            }
            else if (colName == "colNganSach" && (e.Value is decimal || e.Value is double || e.Value is int))
            {
                e.Value = string.Format(culture, "{0:N0} " + (_currentLang == "vi" ? "đ" : "VND"), e.Value);
                e.FormattingApplied = true;
            }
        }

        private void LoadData()
        {
            try
            {
                using var db = AppConfig.CreateDbContext();
                var query = db.ChuyenDis.AsQueryable();

                string kw = txtTim.Text.Trim();
                if (!string.IsNullOrEmpty(kw))
                {
                    query = query.Where(c => c.TenChuyen.Contains(kw) || c.DiaDiem.Contains(kw));
                }

                if (chkChuaHoanThanh.Checked)
                {
                    query = query.Where(c => !c.DaHoanThanh);
                }

                var tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
                var denNgay = DateOnly.FromDateTime(dtpDenNgay.Value.Date);
                query = query.Where(c => c.NgayDi >= tuNgay && c.NgayDi <= denNgay);

                var list = query.OrderBy(c => c.NgayDi).ToList();
                dgvChuyenDi.DataSource = list;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi truy vấn CSDL danh sách chuyến đi");
                MessageBox.Show(_currentLang == "vi" ? "Lỗi truy vấn CSDL." : "Database query error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChuyenDi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvChuyenDi.Rows[e.RowIndex].DataBoundItem is ChuyenDi item)
            {
                _selectedMaChuyen = item.MaChuyen;
                txtTenChuyen.Text = item.TenChuyen;
                txtDiaDiem.Text = item.DiaDiem;
                dtpNgayDi.Value = item.NgayDi.ToDateTime(TimeOnly.MinValue);
                nudSoNguoi.Value = item.SoNguoi;
                nudNganSach.Value = item.NganSach;
                cboPhuongTien.SelectedItem = item.PhuongTien;
                chkDaHoanThanh.Checked = item.DaHoanThanh;

                // Tự động kiểm tra thời tiết cho dòng được chọn
                _ = FetchWeatherAsync(item.DiaDiem, item.NgayDi);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(isNew: true)) return;

            try
            {
                using var db = AppConfig.CreateDbContext();
                var chuyen = new ChuyenDi
                {
                    TenChuyen = txtTenChuyen.Text.Trim(),
                    DiaDiem = txtDiaDiem.Text.Trim(),
                    NgayDi = DateOnly.FromDateTime(dtpNgayDi.Value.Date),
                    SoNguoi = (int)nudSoNguoi.Value,
                    NganSach = nudNganSach.Value,
                    PhuongTien = cboPhuongTien.SelectedItem?.ToString() ?? "Xe máy",
                    DaHoanThanh = chkDaHoanThanh.Checked
                };

                db.ChuyenDis.Add(chuyen);
                db.SaveChanges();

                Log.Information("Thêm chuyến đi: MaChuyen={MaChuyen}, Ten={Ten}", chuyen.MaChuyen, chuyen.TenChuyen);
                MessageBox.Show(_currentLang == "vi" ? "Thêm chuyến đi thành công!" : "Trip added successfully!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi thêm chuyến đi vào CSDL");
                MessageBox.Show(_currentLang == "vi" ? "Lỗi lưu dữ liệu." : "Failed to save trip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaChuyen == null)
            {
                MessageBox.Show(_currentLang == "vi" ? "Vui lòng chọn chuyến đi cần sửa!" : "Please select a trip to edit!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(isNew: false)) return;

            try
            {
                using var db = AppConfig.CreateDbContext();
                var chuyen = db.ChuyenDis.Find(_selectedMaChuyen.Value);
                if (chuyen == null) return;

                chuyen.TenChuyen = txtTenChuyen.Text.Trim();
                chuyen.DiaDiem = txtDiaDiem.Text.Trim();
                chuyen.NgayDi = DateOnly.FromDateTime(dtpNgayDi.Value.Date);
                chuyen.SoNguoi = (int)nudSoNguoi.Value;
                chuyen.NganSach = nudNganSach.Value;
                chuyen.PhuongTien = cboPhuongTien.SelectedItem?.ToString() ?? "Xe máy";
                chuyen.DaHoanThanh = chkDaHoanThanh.Checked;

                db.SaveChanges();

                Log.Information("Cập nhật chuyến đi: MaChuyen={MaChuyen}", chuyen.MaChuyen);
                MessageBox.Show(_currentLang == "vi" ? "Cập nhật thành công!" : "Updated successfully!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi sửa chuyến đi MaChuyen={MaChuyen}", _selectedMaChuyen);
                MessageBox.Show(_currentLang == "vi" ? "Lỗi cập nhật CSDL." : "Database update error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaChuyen == null)
            {
                MessageBox.Show(_currentLang == "vi" ? "Vui lòng chọn chuyến đi cần xóa!" : "Please select a trip to delete!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                _currentLang == "vi" ? "Bạn có chắc chắn muốn xóa chuyến đi này?" : "Are you sure you want to delete this trip?",
                _currentLang == "vi" ? "Xác nhận xóa" : "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var db = AppConfig.CreateDbContext();
                var chuyen = db.ChuyenDis.Find(_selectedMaChuyen.Value);
                if (chuyen != null)
                {
                    int id = chuyen.MaChuyen;
                    db.ChuyenDis.Remove(chuyen);
                    db.SaveChanges();

                    Log.Information("Xóa chuyến đi: MaChuyen={MaChuyen}", id);
                    MessageBox.Show(_currentLang == "vi" ? "Đã xóa chuyến đi!" : "Trip deleted!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetForm();
                LoadData();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi xóa chuyến đi MaChuyen={MaChuyen}", _selectedMaChuyen);
                MessageBox.Show(_currentLang == "vi" ? "Lỗi xóa trong CSDL." : "Database deletion error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtTim.Clear();
            chkChuaHoanThanh.Checked = false;
            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today.AddDays(30);
            LoadData();
        }

        private async void btnXemThoiTiet_Click(object sender, EventArgs e)
        {
            string diaDiem = txtDiaDiem.Text.Trim();
            if (string.IsNullOrEmpty(diaDiem))
            {
                MessageBox.Show(_currentLang == "vi" ? "Vui lòng nhập địa điểm cần tra cứu thời tiết!" : "Please enter a destination to check weather!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaDiem.Focus();
                return;
            }

            DateOnly ngayDi = DateOnly.FromDateTime(dtpNgayDi.Value.Date);
            await FetchWeatherAsync(diaDiem, ngayDi);
        }

        private async Task FetchWeatherAsync(string diaDiem, DateOnly ngayDi)
        {
            btnXemThoiTiet.Enabled = false;
            pbLoading.Visible = true;
            pnlCanhBao.Visible = false;

            try
            {
                bool isVi = _currentLang == "vi";
                lblTieuDeThoiTiet.Text = isVi
                    ? $"Dự báo thời tiết ngày {ngayDi:dd/MM/yyyy} - {diaDiem}"
                    : $"Weather forecast for {ngayDi:MM/dd/yyyy} - {diaDiem}";

                // Kiểm tra nếu ngày đi quá 16 ngày
                int daysDiff = (ngayDi.ToDateTime(TimeOnly.MinValue) - DateTime.Today).Days;
                if (daysDiff < 0 || daysDiff >= 16)
                {
                    lblMoTaThoiTiet.Text = isVi ? "Chưa có dữ liệu dự báo" : "No forecast data available";
                    lblNhietDo.Text = isVi ? "Nhiệt độ: --" : "Temperature: --";
                    lblKhaNangMua.Text = isVi ? "Khả năng mưa: --" : "Precipitation probability: --";
                    lblIconThoiTiet.Text = "❓";
                    return;
                }

                // Bước 1: Geocoding
                GeoResult? geo = await GetCoordinatesAsync(diaDiem);
                if (geo == null)
                {
                    // Thử với tên không dấu
                    string noAccents = RemoveAccents(diaDiem);
                    if (noAccents != diaDiem)
                    {
                        geo = await GetCoordinatesAsync(noAccents);
                    }
                }

                if (geo == null)
                {
                    lblMoTaThoiTiet.Text = isVi ? "Không tìm thấy địa danh" : "Destination not found";
                    lblIconThoiTiet.Text = "🔍";
                    MessageBox.Show(
                        isVi ? $"Không tìm thấy địa danh \"{diaDiem}\". Bạn hãy thử nhập tên không dấu (ví dụ: \"{RemoveAccents(diaDiem)}\")." : $"Destination \"{diaDiem}\" not found. Try entering without accents.",
                        isVi ? "Gợi ý" : "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Bước 2: Forecast
                string forecastUrl = $"https://api.open-meteo.com/v1/forecast?latitude={geo.latitude.ToString(CultureInfo.InvariantCulture)}&longitude={geo.longitude.ToString(CultureInfo.InvariantCulture)}&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max&timezone=auto&forecast_days=16";
                string jsonForecast = await _httpClient.GetStringAsync(forecastUrl);
                var forecast = JsonSerializer.Deserialize<WeatherResponse>(jsonForecast, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (forecast?.daily?.time == null)
                {
                    lblMoTaThoiTiet.Text = isVi ? "Không có dữ liệu thời tiết" : "No weather data";
                    return;
                }

                string targetDateStr = ngayDi.ToString("yyyy-MM-dd");
                int index = forecast.daily.time.IndexOf(targetDateStr);
                if (index < 0)
                {
                    lblMoTaThoiTiet.Text = isVi ? "Chưa có dữ liệu dự báo" : "No forecast data available";
                    return;
                }

                int code = forecast.daily.weather_code[index];
                double tempMax = forecast.daily.temperature_2m_max[index];
                double tempMin = forecast.daily.temperature_2m_min[index];
                int rainProb = forecast.daily.precipitation_probability_max[index];

                // Giải mã thời tiết
                var (descVi, descEn, icon) = DecodeWeather(code);
                lblMoTaThoiTiet.Text = isVi ? descVi : descEn;
                lblIconThoiTiet.Text = icon;
                lblNhietDo.Text = isVi ? $"Nhiệt độ: {tempMin:F0}°C - {tempMax:F0}°C" : $"Temperature: {tempMin:F0}°C - {tempMax:F0}°C";
                lblKhaNangMua.Text = isVi ? $"Khả năng mưa: {rainProb}%" : $"Rain chance: {rainProb}%";

                // Cảnh báo nếu xác suất mưa >= 60%
                if (rainProb >= 60)
                {
                    pnlCanhBao.Visible = true;
                    lblCanhBao.Text = isVi
                        ? "⚠️ Nên mang áo mưa hoặc cân nhắc dời lịch"
                        : "⚠️ Bring a raincoat or consider rescheduling";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is TaskCanceledException)
            {
                Log.Warning(ex, "Lỗi kết nối thời tiết cho địa điểm {DiaDiem}", diaDiem);
                MessageBox.Show(
                    _currentLang == "vi" ? "Không thể kết nối đến máy chủ dự báo thời tiết. Vui lòng kiểm tra kết nối mạng." : "Unable to connect to weather server. Please check your internet connection.",
                    _currentLang == "vi" ? "Lỗi mạng" : "Network error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Lỗi phân tích dự báo thời tiết");
            }
            finally
            {
                btnXemThoiTiet.Enabled = true;
                pbLoading.Visible = false;
            }
        }

        private async Task<GeoResult?> GetCoordinatesAsync(string name)
        {
            try
            {
                string url = $"https://geocoding-api.open-meteo.com/v1/search?name={Uri.EscapeDataString(name)}&count=1&language=vi";
                string json = await _httpClient.GetStringAsync(url);
                var geo = JsonSerializer.Deserialize<GeocodingResponse>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return geo?.results?.FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        private (string vi, string en, string icon) DecodeWeather(int code)
        {
            return code switch
            {
                0 => ("Trời quang", "Clear sky", "☀️"),
                1 => ("Hầu như không mây", "Mainly clear", "🌤️"),
                2 => ("Có mây rải rác", "Partly cloudy", "⛅"),
                3 => ("Trời nhiều mây", "Overcast", "☁️"),
                45 or 48 => ("Sương mù", "Foggy", "🌫️"),
                >= 51 and <= 67 => ("Mưa rào nhẹ", "Light rain", "🌧️"),
                >= 80 and <= 82 => ("Mưa to", "Rain showers", "🌧️"),
                >= 95 and <= 99 => ("Mưa dông", "Thunderstorm", "⛈️"),
                _ => ("Thời tiết thay đổi", "Variable", "🌤️")
            };
        }

        private static string RemoveAccents(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;
            var normalized = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (char c in normalized)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().Normalize(NormalizationForm.FormC).Replace('đ', 'd').Replace('Đ', 'D');
        }

        private bool ValidateInputs(bool isNew)
        {
            bool isVi = _currentLang == "vi";

            if (string.IsNullOrWhiteSpace(txtTenChuyen.Text))
            {
                MessageBox.Show(isVi ? "Vui lòng nhập tên chuyến đi!" : "Please enter trip name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenChuyen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaDiem.Text))
            {
                MessageBox.Show(isVi ? "Vui lòng nhập địa điểm!" : "Please enter destination!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaDiem.Focus();
                return false;
            }

            if (isNew && dtpNgayDi.Value.Date < DateTime.Today)
            {
                MessageBox.Show(isVi ? "Ngày đi không được nhỏ hơn ngày hôm nay khi thêm mới!" : "Departure date cannot be in the past!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayDi.Focus();
                return false;
            }

            if (nudSoNguoi.Value < 1)
            {
                MessageBox.Show(isVi ? "Số người tham gia phải >= 1!" : "Number of people must be at least 1!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudSoNguoi.Focus();
                return false;
            }

            if (nudNganSach.Value < 0)
            {
                MessageBox.Show(isVi ? "Ngân sách không được âm!" : "Budget cannot be negative!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudNganSach.Focus();
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            _selectedMaChuyen = null;
            txtTenChuyen.Clear();
            txtDiaDiem.Clear();
            dtpNgayDi.Value = DateTime.Today;
            nudSoNguoi.Value = 1;
            nudNganSach.Value = 0;
            cboPhuongTien.SelectedIndex = 0;
            chkDaHoanThanh.Checked = false;
            pnlCanhBao.Visible = false;
            lblTieuDeThoiTiet.Text = _currentLang == "vi" ? "Dự báo thời tiết: Chưa có dữ liệu" : "Weather forecast: No data";
            lblMoTaThoiTiet.Text = _currentLang == "vi" ? "Trời quang" : "Clear sky";
            lblNhietDo.Text = _currentLang == "vi" ? "Nhiệt độ: --°C - --°C" : "Temperature: --°C - --°C";
            lblKhaNangMua.Text = _currentLang == "vi" ? "Khả năng mưa: --%" : "Rain chance: --%";
            lblIconThoiTiet.Text = "☀️";
            txtTenChuyen.Focus();
        }
    }
}
