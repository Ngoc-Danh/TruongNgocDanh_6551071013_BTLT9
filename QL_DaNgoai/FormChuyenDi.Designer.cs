namespace QL_DaNgoai
{
    partial class FormChuyenDi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblNgonNgu = new System.Windows.Forms.Label();
            this.cboNgonNgu = new System.Windows.Forms.ComboBox();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lblTenChuyen = new System.Windows.Forms.Label();
            this.txtTenChuyen = new System.Windows.Forms.TextBox();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.nudSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblNganSach = new System.Windows.Forms.Label();
            this.nudNganSach = new System.Windows.Forms.NumericUpDown();
            this.lblPhuongTien = new System.Windows.Forms.Label();
            this.cboPhuongTien = new System.Windows.Forms.ComboBox();
            this.chkDaHoanThanh = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.gbThoiTiet = new System.Windows.Forms.GroupBox();
            this.btnXemThoiTiet = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.lblTieuDeThoiTiet = new System.Windows.Forms.Label();
            this.lblIconThoiTiet = new System.Windows.Forms.Label();
            this.lblMoTaThoiTiet = new System.Windows.Forms.Label();
            this.lblNhietDo = new System.Windows.Forms.Label();
            this.lblKhaNangMua = new System.Windows.Forms.Label();
            this.pnlCanhBao = new System.Windows.Forms.Panel();
            this.lblCanhBao = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.chkChuaHoanThanh = new System.Windows.Forms.CheckBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.dgvChuyenDi = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNganSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhuongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoanThanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNganSach)).BeginInit();
            this.gbThoiTiet.SuspendLayout();
            this.pnlCanhBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(12, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(217, 21);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Kế hoạch dã ngoại cuối tuần";
            // 
            // lblNgonNgu
            // 
            this.lblNgonNgu.AutoSize = true;
            this.lblNgonNgu.Location = new System.Drawing.Point(740, 15);
            this.lblNgonNgu.Name = "lblNgonNgu";
            this.lblNgonNgu.Size = new System.Drawing.Size(65, 15);
            this.lblNgonNgu.TabIndex = 1;
            this.lblNgonNgu.Text = "Ngôn ngữ:";
            // 
            // cboNgonNgu
            // 
            this.cboNgonNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgonNgu.FormattingEnabled = true;
            this.cboNgonNgu.Items.AddRange(new object[] {
            "Tiếng Việt",
            "English"});
            this.cboNgonNgu.Location = new System.Drawing.Point(815, 12);
            this.cboNgonNgu.Name = "cboNgonNgu";
            this.cboNgonNgu.Size = new System.Drawing.Size(120, 23);
            this.cboNgonNgu.TabIndex = 2;
            this.cboNgonNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgonNgu_SelectedIndexChanged);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.btnLamMoi);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.chkDaHoanThanh);
            this.gbThongTin.Controls.Add(this.cboPhuongTien);
            this.gbThongTin.Controls.Add(this.lblPhuongTien);
            this.gbThongTin.Controls.Add(this.nudNganSach);
            this.gbThongTin.Controls.Add(this.lblNganSach);
            this.gbThongTin.Controls.Add(this.nudSoNguoi);
            this.gbThongTin.Controls.Add(this.lblSoNguoi);
            this.gbThongTin.Controls.Add(this.dtpNgayDi);
            this.gbThongTin.Controls.Add(this.lblNgayDi);
            this.gbThongTin.Controls.Add(this.txtDiaDiem);
            this.gbThongTin.Controls.Add(this.lblDiaDiem);
            this.gbThongTin.Controls.Add(this.txtTenChuyen);
            this.gbThongTin.Controls.Add(this.lblTenChuyen);
            this.gbThongTin.Location = new System.Drawing.Point(12, 45);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(530, 220);
            this.gbThongTin.TabIndex = 3;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin chuyến đi";
            // 
            // lblTenChuyen
            // 
            this.lblTenChuyen.AutoSize = true;
            this.lblTenChuyen.Location = new System.Drawing.Point(15, 25);
            this.lblTenChuyen.Name = "lblTenChuyen";
            this.lblTenChuyen.Size = new System.Drawing.Size(71, 15);
            this.lblTenChuyen.TabIndex = 0;
            this.lblTenChuyen.Text = "Tên chuyến:";
            // 
            // txtTenChuyen
            // 
            this.txtTenChuyen.Location = new System.Drawing.Point(95, 22);
            this.txtTenChuyen.Name = "txtTenChuyen";
            this.txtTenChuyen.Size = new System.Drawing.Size(415, 23);
            this.txtTenChuyen.TabIndex = 1;
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(15, 55);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(57, 15);
            this.lblDiaDiem.TabIndex = 2;
            this.lblDiaDiem.Text = "Địa điểm:";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(95, 52);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(415, 23);
            this.txtDiaDiem.TabIndex = 3;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(15, 85);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(51, 15);
            this.lblNgayDi.TabIndex = 4;
            this.lblNgayDi.Text = "Ngày đi:";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(95, 82);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(140, 23);
            this.dtpNgayDi.TabIndex = 5;
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(15, 115);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(57, 15);
            this.lblSoNguoi.TabIndex = 6;
            this.lblSoNguoi.Text = "Số người:";
            // 
            // nudSoNguoi
            // 
            this.nudSoNguoi.Location = new System.Drawing.Point(95, 112);
            this.nudSoNguoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoNguoi.Name = "nudSoNguoi";
            this.nudSoNguoi.Size = new System.Drawing.Size(140, 23);
            this.nudSoNguoi.TabIndex = 7;
            this.nudSoNguoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNganSach
            // 
            this.lblNganSach.AutoSize = true;
            this.lblNganSach.Location = new System.Drawing.Point(260, 85);
            this.lblNganSach.Name = "lblNganSach";
            this.lblNganSach.Size = new System.Drawing.Size(66, 15);
            this.lblNganSach.TabIndex = 8;
            this.lblNganSach.Text = "Ngân sách:";
            // 
            // nudNganSach
            // 
            this.nudNganSach.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNganSach.Location = new System.Drawing.Point(340, 82);
            this.nudNganSach.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudNganSach.Name = "nudNganSach";
            this.nudNganSach.Size = new System.Drawing.Size(170, 23);
            this.nudNganSach.TabIndex = 9;
            this.nudNganSach.ThousandsSeparator = true;
            // 
            // lblPhuongTien
            // 
            this.lblPhuongTien.AutoSize = true;
            this.lblPhuongTien.Location = new System.Drawing.Point(260, 115);
            this.lblPhuongTien.Name = "lblPhuongTien";
            this.lblPhuongTien.Size = new System.Drawing.Size(76, 15);
            this.lblPhuongTien.TabIndex = 10;
            this.lblPhuongTien.Text = "Phương tiện:";
            // 
            // cboPhuongTien
            // 
            this.cboPhuongTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongTien.FormattingEnabled = true;
            this.cboPhuongTien.Items.AddRange(new object[] {
            "Xe máy",
            "Ô tô",
            "Xe khách",
            "Tàu hỏa"});
            this.cboPhuongTien.Location = new System.Drawing.Point(340, 112);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Size = new System.Drawing.Size(170, 23);
            this.cboPhuongTien.TabIndex = 11;
            // 
            // chkDaHoanThanh
            // 
            this.chkDaHoanThanh.AutoSize = true;
            this.chkDaHoanThanh.Location = new System.Drawing.Point(95, 145);
            this.chkDaHoanThanh.Name = "chkDaHoanThanh";
            this.chkDaHoanThanh.Size = new System.Drawing.Size(104, 19);
            this.chkDaHoanThanh.TabIndex = 12;
            this.chkDaHoanThanh.Text = "Đã hoàn thành";
            this.chkDaHoanThanh.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(95, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 32);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(200, 175);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 32);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(305, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 32);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(410, 175);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // gbThoiTiet
            // 
            this.gbThoiTiet.Controls.Add(this.pnlCanhBao);
            this.gbThoiTiet.Controls.Add(this.lblKhaNangMua);
            this.gbThoiTiet.Controls.Add(this.lblNhietDo);
            this.gbThoiTiet.Controls.Add(this.lblMoTaThoiTiet);
            this.gbThoiTiet.Controls.Add(this.lblIconThoiTiet);
            this.gbThoiTiet.Controls.Add(this.lblTieuDeThoiTiet);
            this.gbThoiTiet.Controls.Add(this.pbLoading);
            this.gbThoiTiet.Controls.Add(this.btnXemThoiTiet);
            this.gbThoiTiet.Location = new System.Drawing.Point(555, 45);
            this.gbThoiTiet.Name = "gbThoiTiet";
            this.gbThoiTiet.Size = new System.Drawing.Size(380, 220);
            this.gbThoiTiet.TabIndex = 4;
            this.gbThoiTiet.TabStop = false;
            // 
            // btnXemThoiTiet
            // 
            this.btnXemThoiTiet.Location = new System.Drawing.Point(15, 15);
            this.btnXemThoiTiet.Name = "btnXemThoiTiet";
            this.btnXemThoiTiet.Size = new System.Drawing.Size(110, 26);
            this.btnXemThoiTiet.TabIndex = 0;
            this.btnXemThoiTiet.Text = "Xem thời tiết";
            this.btnXemThoiTiet.UseVisualStyleBackColor = true;
            this.btnXemThoiTiet.Click += new System.EventHandler(this.btnXemThoiTiet_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(135, 18);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(230, 20);
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbLoading.TabIndex = 1;
            this.pbLoading.Visible = false;
            // 
            // lblTieuDeThoiTiet
            // 
            this.lblTieuDeThoiTiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDeThoiTiet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTieuDeThoiTiet.Location = new System.Drawing.Point(15, 48);
            this.lblTieuDeThoiTiet.Name = "lblTieuDeThoiTiet";
            this.lblTieuDeThoiTiet.Size = new System.Drawing.Size(350, 20);
            this.lblTieuDeThoiTiet.TabIndex = 2;
            this.lblTieuDeThoiTiet.Text = "Dự báo thời tiết: Chưa có dữ liệu";
            // 
            // lblIconThoiTiet
            // 
            this.lblIconThoiTiet.Font = new System.Drawing.Font("Segoe UI Emoji", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIconThoiTiet.Location = new System.Drawing.Point(20, 72);
            this.lblIconThoiTiet.Name = "lblIconThoiTiet";
            this.lblIconThoiTiet.Size = new System.Drawing.Size(65, 55);
            this.lblIconThoiTiet.TabIndex = 3;
            this.lblIconThoiTiet.Text = "☀️";
            this.lblIconThoiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoTaThoiTiet
            // 
            this.lblMoTaThoiTiet.AutoSize = true;
            this.lblMoTaThoiTiet.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoTaThoiTiet.Location = new System.Drawing.Point(95, 75);
            this.lblMoTaThoiTiet.Name = "lblMoTaThoiTiet";
            this.lblMoTaThoiTiet.Size = new System.Drawing.Size(79, 20);
            this.lblMoTaThoiTiet.TabIndex = 4;
            this.lblMoTaThoiTiet.Text = "Trời quang";
            // 
            // lblNhietDo
            // 
            this.lblNhietDo.AutoSize = true;
            this.lblNhietDo.Location = new System.Drawing.Point(95, 100);
            this.lblNhietDo.Name = "lblNhietDo";
            this.lblNhietDo.Size = new System.Drawing.Size(125, 15);
            this.lblNhietDo.TabIndex = 5;
            this.lblNhietDo.Text = "Nhiệt độ: --°C - --°C";
            // 
            // lblKhaNangMua
            // 
            this.lblKhaNangMua.AutoSize = true;
            this.lblKhaNangMua.Location = new System.Drawing.Point(95, 120);
            this.lblKhaNangMua.Name = "lblKhaNangMua";
            this.lblKhaNangMua.Size = new System.Drawing.Size(105, 15);
            this.lblKhaNangMua.TabIndex = 6;
            this.lblKhaNangMua.Text = "Khả năng mưa: --%";
            // 
            // pnlCanhBao
            // 
            this.pnlCanhBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(186)))));
            this.pnlCanhBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanhBao.Controls.Add(this.lblCanhBao);
            this.pnlCanhBao.Location = new System.Drawing.Point(15, 160);
            this.pnlCanhBao.Name = "pnlCanhBao";
            this.pnlCanhBao.Size = new System.Drawing.Size(350, 48);
            this.pnlCanhBao.TabIndex = 7;
            this.pnlCanhBao.Visible = false;
            // 
            // lblCanhBao
            // 
            this.lblCanhBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCanhBao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanhBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.lblCanhBao.Location = new System.Drawing.Point(0, 0);
            this.lblCanhBao.Name = "lblCanhBao";
            this.lblCanhBao.Padding = new System.Windows.Forms.Padding(5);
            this.lblCanhBao.Size = new System.Drawing.Size(348, 46);
            this.lblCanhBao.TabIndex = 0;
            this.lblCanhBao.Text = "⚠️ Nên mang áo mưa hoặc cân nhắc dời lịch";
            this.lblCanhBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(12, 280);
            this.txtTim.Name = "txtTim";
            this.txtTim.PlaceholderText = "Tìm địa điểm...";
            this.txtTim.Size = new System.Drawing.Size(180, 23);
            this.txtTim.TabIndex = 5;
            // 
            // chkChuaHoanThanh
            // 
            this.chkChuaHoanThanh.AutoSize = true;
            this.chkChuaHoanThanh.Location = new System.Drawing.Point(205, 282);
            this.chkChuaHoanThanh.Name = "chkChuaHoanThanh";
            this.chkChuaHoanThanh.Size = new System.Drawing.Size(182, 19);
            this.chkChuaHoanThanh.TabIndex = 6;
            this.chkChuaHoanThanh.Text = "Chỉ hiện chuyến chưa hoàn thành";
            this.chkChuaHoanThanh.UseVisualStyleBackColor = true;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(400, 284);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(23, 15);
            this.lblTuNgay.TabIndex = 7;
            this.lblTuNgay.Text = "Từ:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(430, 280);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(110, 23);
            this.dtpTuNgay.TabIndex = 8;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(550, 284);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(31, 15);
            this.lblDenNgay.TabIndex = 9;
            this.lblDenNgay.Text = "Đến:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(585, 280);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(110, 23);
            this.dtpDenNgay.TabIndex = 10;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(710, 278);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 27);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Location = new System.Drawing.Point(795, 278);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(80, 27);
            this.btnBoLoc.TabIndex = 12;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = true;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);
            // 
            // dgvChuyenDi
            // 
            this.dgvChuyenDi.AllowUserToAddRows = false;
            this.dgvChuyenDi.AllowUserToDeleteRows = false;
            this.dgvChuyenDi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenDi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenDi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTenChuyen,
            this.colDiaDiem,
            this.colNgayDi,
            this.colSoNguoi,
            this.colNganSach,
            this.colPhuongTien,
            this.colHoanThanh});
            this.dgvChuyenDi.Location = new System.Drawing.Point(12, 315);
            this.dgvChuyenDi.MultiSelect = false;
            this.dgvChuyenDi.Name = "dgvChuyenDi";
            this.dgvChuyenDi.ReadOnly = true;
            this.dgvChuyenDi.RowHeadersVisible = false;
            this.dgvChuyenDi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenDi.Size = new System.Drawing.Size(923, 260);
            this.dgvChuyenDi.TabIndex = 13;
            this.dgvChuyenDi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenDi_CellClick);
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "MaChuyen";
            this.colMa.FillWeight = 40F;
            this.colMa.HeaderText = "Mã";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            // 
            // colTenChuyen
            // 
            this.colTenChuyen.DataPropertyName = "TenChuyen";
            this.colTenChuyen.FillWeight = 120F;
            this.colTenChuyen.HeaderText = "Tên chuyến";
            this.colTenChuyen.Name = "colTenChuyen";
            this.colTenChuyen.ReadOnly = true;
            // 
            // colDiaDiem
            // 
            this.colDiaDiem.DataPropertyName = "DiaDiem";
            this.colDiaDiem.FillWeight = 80F;
            this.colDiaDiem.HeaderText = "Địa điểm";
            this.colDiaDiem.Name = "colDiaDiem";
            this.colDiaDiem.ReadOnly = true;
            // 
            // colNgayDi
            // 
            this.colNgayDi.DataPropertyName = "NgayDi";
            this.colNgayDi.FillWeight = 70F;
            this.colNgayDi.HeaderText = "Ngày đi";
            this.colNgayDi.Name = "colNgayDi";
            this.colNgayDi.ReadOnly = true;
            // 
            // colSoNguoi
            // 
            this.colSoNguoi.DataPropertyName = "SoNguoi";
            this.colSoNguoi.FillWeight = 50F;
            this.colSoNguoi.HeaderText = "Số người";
            this.colSoNguoi.Name = "colSoNguoi";
            this.colSoNguoi.ReadOnly = true;
            // 
            // colNganSach
            // 
            this.colNganSach.DataPropertyName = "NganSach";
            this.colNganSach.FillWeight = 75F;
            this.colNganSach.HeaderText = "Ngân sách";
            this.colNganSach.Name = "colNganSach";
            this.colNganSach.ReadOnly = true;
            // 
            // colPhuongTien
            // 
            this.colPhuongTien.DataPropertyName = "PhuongTien";
            this.colPhuongTien.FillWeight = 70F;
            this.colPhuongTien.HeaderText = "Phương tiện";
            this.colPhuongTien.Name = "colPhuongTien";
            this.colPhuongTien.ReadOnly = true;
            // 
            // colHoanThanh
            // 
            this.colHoanThanh.DataPropertyName = "DaHoanThanh";
            this.colHoanThanh.FillWeight = 65F;
            this.colHoanThanh.HeaderText = "Hoàn thành";
            this.colHoanThanh.Name = "colHoanThanh";
            this.colHoanThanh.ReadOnly = true;
            // 
            // FormChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 587);
            this.Controls.Add(this.dgvChuyenDi);
            this.Controls.Add(this.btnBoLoc);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.chkChuaHoanThanh);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.gbThoiTiet);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.cboNgonNgu);
            this.Controls.Add(this.lblNgonNgu);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormChuyenDi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kế hoạch dã ngoại";
            this.Load += new System.EventHandler(this.FormChuyenDi_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNganSach)).EndInit();
            this.gbThoiTiet.ResumeLayout(false);
            this.gbThoiTiet.PerformLayout();
            this.pnlCanhBao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenDi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblNgonNgu;
        private System.Windows.Forms.ComboBox cboNgonNgu;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblTenChuyen;
        private System.Windows.Forms.TextBox txtTenChuyen;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.NumericUpDown nudSoNguoi;
        private System.Windows.Forms.Label lblNganSach;
        private System.Windows.Forms.NumericUpDown nudNganSach;
        private System.Windows.Forms.Label lblPhuongTien;
        private System.Windows.Forms.ComboBox cboPhuongTien;
        private System.Windows.Forms.CheckBox chkDaHoanThanh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox gbThoiTiet;
        private System.Windows.Forms.Button btnXemThoiTiet;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Label lblTieuDeThoiTiet;
        private System.Windows.Forms.Label lblIconThoiTiet;
        private System.Windows.Forms.Label lblMoTaThoiTiet;
        private System.Windows.Forms.Label lblNhietDo;
        private System.Windows.Forms.Label lblKhaNangMua;
        private System.Windows.Forms.Panel pnlCanhBao;
        private System.Windows.Forms.Label lblCanhBao;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.CheckBox chkChuaHoanThanh;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.DataGridView dgvChuyenDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNganSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhuongTien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colHoanThanh;
    }
}
