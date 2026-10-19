namespace QL_ChiTieu
{
    partial class FormChiTieu
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
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.lblNgayChi = new System.Windows.Forms.Label();
            this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblLoaiChi = new System.Windows.Forms.Label();
            this.cboLoaiChi = new System.Windows.Forms.ComboBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.nudSoTien = new System.Windows.Forms.NumericUpDown();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimNoiDung = new System.Windows.Forms.Label();
            this.txtTimNoiDung = new System.Windows.Forms.TextBox();
            this.lblLocLoaiChi = new System.Windows.Forms.Label();
            this.cboLocLoaiChi = new System.Windows.Forms.ComboBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvChiTieu = new System.Windows.Forms.DataGridView();
            this.colMaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongChi = new System.Windows.Forms.Label();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).BeginInit();
            this.gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.btnLamMoi);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.txtGhiChu);
            this.gbThongTin.Controls.Add(this.lblGhiChu);
            this.gbThongTin.Controls.Add(this.nudSoTien);
            this.gbThongTin.Controls.Add(this.lblSoTien);
            this.gbThongTin.Controls.Add(this.cboLoaiChi);
            this.gbThongTin.Controls.Add(this.lblLoaiChi);
            this.gbThongTin.Controls.Add(this.txtNoiDung);
            this.gbThongTin.Controls.Add(this.lblNoiDung);
            this.gbThongTin.Controls.Add(this.dtpNgayChi);
            this.gbThongTin.Controls.Add(this.lblNgayChi);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(430, 200);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin khoản chi";
            // 
            // lblNgayChi
            // 
            this.lblNgayChi.AutoSize = true;
            this.lblNgayChi.Location = new System.Drawing.Point(15, 25);
            this.lblNgayChi.Name = "lblNgayChi";
            this.lblNgayChi.Size = new System.Drawing.Size(57, 15);
            this.lblNgayChi.TabIndex = 0;
            this.lblNgayChi.Text = "Ngày chi:";
            // 
            // dtpNgayChi
            // 
            this.dtpNgayChi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayChi.Location = new System.Drawing.Point(80, 22);
            this.dtpNgayChi.Name = "dtpNgayChi";
            this.dtpNgayChi.Size = new System.Drawing.Size(120, 23);
            this.dtpNgayChi.TabIndex = 1;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(15, 55);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(60, 15);
            this.lblNoiDung.TabIndex = 2;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(80, 52);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(120, 23);
            this.txtNoiDung.TabIndex = 3;
            // 
            // lblLoaiChi
            // 
            this.lblLoaiChi.AutoSize = true;
            this.lblLoaiChi.Location = new System.Drawing.Point(215, 25);
            this.lblLoaiChi.Name = "lblLoaiChi";
            this.lblLoaiChi.Size = new System.Drawing.Size(52, 15);
            this.lblLoaiChi.TabIndex = 4;
            this.lblLoaiChi.Text = "Loại chi:";
            // 
            // cboLoaiChi
            // 
            this.cboLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiChi.FormattingEnabled = true;
            this.cboLoaiChi.Items.AddRange(new object[] {
            "Ăn uống",
            "Đi lại",
            "Học tập",
            "Giải trí",
            "Khác"});
            this.cboLoaiChi.Location = new System.Drawing.Point(280, 22);
            this.cboLoaiChi.Name = "cboLoaiChi";
            this.cboLoaiChi.Size = new System.Drawing.Size(135, 23);
            this.cboLoaiChi.TabIndex = 5;
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(215, 55);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(46, 15);
            this.lblSoTien.TabIndex = 6;
            this.lblSoTien.Text = "Số tiền:";
            // 
            // nudSoTien
            // 
            this.nudSoTien.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoTien.Location = new System.Drawing.Point(280, 52);
            this.nudSoTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSoTien.Name = "nudSoTien";
            this.nudSoTien.Size = new System.Drawing.Size(135, 23);
            this.nudSoTien.TabIndex = 7;
            this.nudSoTien.ThousandsSeparator = true;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(15, 85);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(51, 15);
            this.lblGhiChu.TabIndex = 8;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(80, 82);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(335, 60);
            this.txtGhiChu.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(80, 155);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(165, 155);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(250, 155);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(335, 155);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoi.TabIndex = 13;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btnTim);
            this.gbTimKiem.Controls.Add(this.dtpDenNgay);
            this.gbTimKiem.Controls.Add(this.lblDenNgay);
            this.gbTimKiem.Controls.Add(this.dtpTuNgay);
            this.gbTimKiem.Controls.Add(this.lblTuNgay);
            this.gbTimKiem.Controls.Add(this.cboLocLoaiChi);
            this.gbTimKiem.Controls.Add(this.lblLocLoaiChi);
            this.gbTimKiem.Controls.Add(this.txtTimNoiDung);
            this.gbTimKiem.Controls.Add(this.lblTimNoiDung);
            this.gbTimKiem.Location = new System.Drawing.Point(455, 12);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(365, 200);
            this.gbTimKiem.TabIndex = 1;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm";
            // 
            // lblTimNoiDung
            // 
            this.lblTimNoiDung.AutoSize = true;
            this.lblTimNoiDung.Location = new System.Drawing.Point(15, 25);
            this.lblTimNoiDung.Name = "lblTimNoiDung";
            this.lblTimNoiDung.Size = new System.Drawing.Size(60, 15);
            this.lblTimNoiDung.TabIndex = 0;
            this.lblTimNoiDung.Text = "Nội dung:";
            // 
            // txtTimNoiDung
            // 
            this.txtTimNoiDung.Location = new System.Drawing.Point(85, 22);
            this.txtTimNoiDung.Name = "txtTimNoiDung";
            this.txtTimNoiDung.PlaceholderText = "Nhập nội dung...";
            this.txtTimNoiDung.Size = new System.Drawing.Size(260, 23);
            this.txtTimNoiDung.TabIndex = 1;
            // 
            // lblLocLoaiChi
            // 
            this.lblLocLoaiChi.AutoSize = true;
            this.lblLocLoaiChi.Location = new System.Drawing.Point(15, 60);
            this.lblLocLoaiChi.Name = "lblLocLoaiChi";
            this.lblLocLoaiChi.Size = new System.Drawing.Size(52, 15);
            this.lblLocLoaiChi.TabIndex = 2;
            this.lblLocLoaiChi.Text = "Loại chi:";
            // 
            // cboLocLoaiChi
            // 
            this.cboLocLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoaiChi.FormattingEnabled = true;
            this.cboLocLoaiChi.Items.AddRange(new object[] {
            "Tất cả",
            "Ăn uống",
            "Đi lại",
            "Học tập",
            "Giải trí",
            "Khác"});
            this.cboLocLoaiChi.Location = new System.Drawing.Point(85, 57);
            this.cboLocLoaiChi.Name = "cboLocLoaiChi";
            this.cboLocLoaiChi.Size = new System.Drawing.Size(260, 23);
            this.cboLocLoaiChi.TabIndex = 3;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(15, 95);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(52, 15);
            this.lblTuNgay.TabIndex = 4;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(85, 92);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 23);
            this.dtpTuNgay.TabIndex = 5;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(15, 128);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(60, 15);
            this.lblDenNgay.TabIndex = 6;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(85, 125);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(120, 23);
            this.dtpDenNgay.TabIndex = 7;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(235, 105);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(110, 40);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvChiTieu
            // 
            this.dgvChiTieu.AllowUserToAddRows = false;
            this.dgvChiTieu.AllowUserToDeleteRows = false;
            this.dgvChiTieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCT,
            this.colNgayChi,
            this.colNoiDung,
            this.colLoaiChi,
            this.colSoTien,
            this.colGhiChu});
            this.dgvChiTieu.Location = new System.Drawing.Point(12, 225);
            this.dgvChiTieu.MultiSelect = false;
            this.dgvChiTieu.Name = "dgvChiTieu";
            this.dgvChiTieu.ReadOnly = true;
            this.dgvChiTieu.RowHeadersVisible = false;
            this.dgvChiTieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTieu.Size = new System.Drawing.Size(808, 260);
            this.dgvChiTieu.TabIndex = 2;
            this.dgvChiTieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTieu_CellClick);
            // 
            // colMaCT
            // 
            this.colMaCT.DataPropertyName = "MaCt";
            this.colMaCT.FillWeight = 40F;
            this.colMaCT.HeaderText = "Mã";
            this.colMaCT.Name = "colMaCT";
            this.colMaCT.ReadOnly = true;
            // 
            // colNgayChi
            // 
            this.colNgayChi.DataPropertyName = "NgayChi";
            this.colNgayChi.FillWeight = 70F;
            this.colNgayChi.HeaderText = "Ngày chi";
            this.colNgayChi.Name = "colNgayChi";
            this.colNgayChi.ReadOnly = true;
            // 
            // colNoiDung
            // 
            this.colNoiDung.DataPropertyName = "NoiDung";
            this.colNoiDung.FillWeight = 110F;
            this.colNoiDung.HeaderText = "Nội dung";
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.ReadOnly = true;
            // 
            // colLoaiChi
            // 
            this.colLoaiChi.DataPropertyName = "LoaiChi";
            this.colLoaiChi.FillWeight = 70F;
            this.colLoaiChi.HeaderText = "Loại chi";
            this.colLoaiChi.Name = "colLoaiChi";
            this.colLoaiChi.ReadOnly = true;
            // 
            // colSoTien
            // 
            this.colSoTien.DataPropertyName = "SoTien";
            this.colSoTien.FillWeight = 70F;
            this.colSoTien.HeaderText = "Số tiền";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.FillWeight = 110F;
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // lblTongChi
            // 
            this.lblTongChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongChi.ForeColor = System.Drawing.Color.Red;
            this.lblTongChi.Location = new System.Drawing.Point(400, 495);
            this.lblTongChi.Name = "lblTongChi";
            this.lblTongChi.Size = new System.Drawing.Size(420, 25);
            this.lblTongChi.TabIndex = 3;
            this.lblTongChi.Text = "Tổng chi: 0 đ";
            this.lblTongChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 531);
            this.Controls.Add(this.lblTongChi);
            this.Controls.Add(this.dgvChiTieu);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormChiTieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sổ chi tiêu cá nhân";
            this.Load += new System.EventHandler(this.FormChiTieu_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTien)).EndInit();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTieu)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblNgayChi;
        private System.Windows.Forms.DateTimePicker dtpNgayChi;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblLoaiChi;
        private System.Windows.Forms.ComboBox cboLoaiChi;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.NumericUpDown nudSoTien;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Label lblTimNoiDung;
        private System.Windows.Forms.TextBox txtTimNoiDung;
        private System.Windows.Forms.Label lblLocLoaiChi;
        private System.Windows.Forms.ComboBox cboLocLoaiChi;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.Label lblTongChi;
    }
}
