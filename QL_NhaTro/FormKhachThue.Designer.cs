namespace QL_NhaTro
{
    partial class FormKhachThue
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.gbGioiTinh = new System.Windows.Forms.GroupBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblTinhThanh = new System.Windows.Forms.Label();
            this.cboTinh = new System.Windows.Forms.ComboBox();
            this.lblPhuongXa = new System.Windows.Forms.Label();
            this.cboPhuongXa = new System.Windows.Forms.ComboBox();
            this.chkTamTru = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnGayLoiThu = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblLocPhong = new System.Windows.Forms.Label();
            this.cboLocPhong = new System.Windows.Forms.ComboBox();
            this.lblLocTinh = new System.Windows.Forms.Label();
            this.cboLocTinh = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.dgvKhachThue = new System.Windows.Forms.DataGridView();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamTru = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbThongTin.SuspendLayout();
            this.gbGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachThue)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.btnGayLoiThu);
            this.gbThongTin.Controls.Add(this.btnLamMoi);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.chkTamTru);
            this.gbThongTin.Controls.Add(this.cboPhuongXa);
            this.gbThongTin.Controls.Add(this.lblPhuongXa);
            this.gbThongTin.Controls.Add(this.cboTinh);
            this.gbThongTin.Controls.Add(this.lblTinhThanh);
            this.gbThongTin.Controls.Add(this.cboPhong);
            this.gbThongTin.Controls.Add(this.lblPhong);
            this.gbThongTin.Controls.Add(this.txtSoDienThoai);
            this.gbThongTin.Controls.Add(this.lblSoDienThoai);
            this.gbThongTin.Controls.Add(this.dtpNgaySinh);
            this.gbThongTin.Controls.Add(this.lblNgaySinh);
            this.gbThongTin.Controls.Add(this.gbGioiTinh);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.lblHoTen);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(320, 500);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin khách thuê";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(10, 28);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(90, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(215, 23);
            this.txtHoTen.TabIndex = 1;
            // 
            // gbGioiTinh
            // 
            this.gbGioiTinh.Controls.Add(this.rbNu);
            this.gbGioiTinh.Controls.Add(this.rbNam);
            this.gbGioiTinh.Location = new System.Drawing.Point(90, 55);
            this.gbGioiTinh.Name = "gbGioiTinh";
            this.gbGioiTinh.Size = new System.Drawing.Size(215, 45);
            this.gbGioiTinh.TabIndex = 2;
            this.gbGioiTinh.TabStop = false;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(20, 18);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(51, 19);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(110, 18);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(41, 19);
            this.rbNu.TabIndex = 1;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(10, 115);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(63, 15);
            this.lblNgaySinh.TabIndex = 3;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(90, 110);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(215, 23);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(10, 150);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(79, 15);
            this.lblSoDienThoai.TabIndex = 5;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(90, 147);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(215, 23);
            this.txtSoDienThoai.TabIndex = 6;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(10, 185);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(45, 15);
            this.lblPhong.TabIndex = 7;
            this.lblPhong.Text = "Phòng:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(90, 182);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(215, 23);
            this.cboPhong.TabIndex = 8;
            // 
            // lblTinhThanh
            // 
            this.lblTinhThanh.AutoSize = true;
            this.lblTinhThanh.Location = new System.Drawing.Point(10, 220);
            this.lblTinhThanh.Name = "lblTinhThanh";
            this.lblTinhThanh.Size = new System.Drawing.Size(70, 15);
            this.lblTinhThanh.TabIndex = 9;
            this.lblTinhThanh.Text = "Tỉnh/Thành:";
            // 
            // cboTinh
            // 
            this.cboTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinh.FormattingEnabled = true;
            this.cboTinh.Location = new System.Drawing.Point(90, 217);
            this.cboTinh.Name = "cboTinh";
            this.cboTinh.Size = new System.Drawing.Size(215, 23);
            this.cboTinh.TabIndex = 10;
            this.cboTinh.SelectedIndexChanged += new System.EventHandler(this.cboTinh_SelectedIndexChanged);
            // 
            // lblPhuongXa
            // 
            this.lblPhuongXa.AutoSize = true;
            this.lblPhuongXa.Location = new System.Drawing.Point(10, 255);
            this.lblPhuongXa.Name = "lblPhuongXa";
            this.lblPhuongXa.Size = new System.Drawing.Size(71, 15);
            this.lblPhuongXa.TabIndex = 11;
            this.lblPhuongXa.Text = "Phường/Xã:";
            // 
            // cboPhuongXa
            // 
            this.cboPhuongXa.FormattingEnabled = true;
            this.cboPhuongXa.Location = new System.Drawing.Point(90, 252);
            this.cboPhuongXa.Name = "cboPhuongXa";
            this.cboPhuongXa.Size = new System.Drawing.Size(215, 23);
            this.cboPhuongXa.TabIndex = 12;
            // 
            // chkTamTru
            // 
            this.chkTamTru.AutoSize = true;
            this.chkTamTru.Location = new System.Drawing.Point(90, 290);
            this.chkTamTru.Name = "chkTamTru";
            this.chkTamTru.Size = new System.Drawing.Size(134, 19);
            this.chkTamTru.TabIndex = 13;
            this.chkTamTru.Text = "Đã đăng ký tạm trú";
            this.chkTamTru.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 330);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 30);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(85, 330);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 30);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(160, 330);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 30);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(235, 330);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnGayLoiThu
            // 
            this.btnGayLoiThu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGayLoiThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGayLoiThu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGayLoiThu.ForeColor = System.Drawing.Color.DarkGray;
            this.btnGayLoiThu.Location = new System.Drawing.Point(10, 465);
            this.btnGayLoiThu.Name = "btnGayLoiThu";
            this.btnGayLoiThu.Size = new System.Drawing.Size(300, 24);
            this.btnGayLoiThu.TabIndex = 18;
            this.btnGayLoiThu.Text = "Gây lỗi thử (Test Exception)";
            this.btnGayLoiThu.UseVisualStyleBackColor = false;
            this.btnGayLoiThu.Click += new System.EventHandler(this.btnGayLoiThu_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(345, 18);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Tìm theo tên hoặc SĐT";
            this.txtTimKiem.Size = new System.Drawing.Size(180, 23);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblLocPhong
            // 
            this.lblLocPhong.AutoSize = true;
            this.lblLocPhong.Location = new System.Drawing.Point(535, 21);
            this.lblLocPhong.Name = "lblLocPhong";
            this.lblLocPhong.Size = new System.Drawing.Size(45, 15);
            this.lblLocPhong.TabIndex = 2;
            this.lblLocPhong.Text = "Phòng:";
            // 
            // cboLocPhong
            // 
            this.cboLocPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocPhong.FormattingEnabled = true;
            this.cboLocPhong.Location = new System.Drawing.Point(585, 18);
            this.cboLocPhong.Name = "cboLocPhong";
            this.cboLocPhong.Size = new System.Drawing.Size(90, 23);
            this.cboLocPhong.TabIndex = 3;
            // 
            // lblLocTinh
            // 
            this.lblLocTinh.AutoSize = true;
            this.lblLocTinh.Location = new System.Drawing.Point(685, 21);
            this.lblLocTinh.Name = "lblLocTinh";
            this.lblLocTinh.Size = new System.Drawing.Size(33, 15);
            this.lblLocTinh.TabIndex = 4;
            this.lblLocTinh.Text = "Tỉnh:";
            // 
            // cboLocTinh
            // 
            this.cboLocTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTinh.FormattingEnabled = true;
            this.cboLocTinh.Location = new System.Drawing.Point(725, 18);
            this.cboLocTinh.Name = "cboLocTinh";
            this.cboLocTinh.Size = new System.Drawing.Size(120, 23);
            this.cboLocTinh.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(855, 17);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(65, 25);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Location = new System.Drawing.Point(925, 17);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(65, 25);
            this.btnBoLoc.TabIndex = 7;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = true;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);
            // 
            // dgvKhachThue
            // 
            this.dgvKhachThue.AllowUserToAddRows = false;
            this.dgvKhachThue.AllowUserToDeleteRows = false;
            this.dgvKhachThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHoTen,
            this.colSDT,
            this.colPhong,
            this.colGiaThue,
            this.colQueQuan,
            this.colTamTru});
            this.dgvKhachThue.Location = new System.Drawing.Point(345, 55);
            this.dgvKhachThue.MultiSelect = false;
            this.dgvKhachThue.Name = "dgvKhachThue";
            this.dgvKhachThue.ReadOnly = true;
            this.dgvKhachThue.RowHeadersVisible = false;
            this.dgvKhachThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachThue.Size = new System.Drawing.Size(645, 457);
            this.dgvKhachThue.TabIndex = 8;
            this.dgvKhachThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachThue_CellClick);
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.FillWeight = 85F;
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SoDienThoai";
            this.colSDT.FillWeight = 65F;
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            // 
            // colPhong
            // 
            this.colPhong.DataPropertyName = "TenPhong";
            this.colPhong.FillWeight = 45F;
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            // 
            // colGiaThue
            // 
            this.colGiaThue.DataPropertyName = "GiaThue";
            this.colGiaThue.FillWeight = 65F;
            this.colGiaThue.HeaderText = "Giá thuê";
            this.colGiaThue.Name = "colGiaThue";
            this.colGiaThue.ReadOnly = true;
            // 
            // colQueQuan
            // 
            this.colQueQuan.DataPropertyName = "QueQuan";
            this.colQueQuan.FillWeight = 110F;
            this.colQueQuan.HeaderText = "Quê quán";
            this.colQueQuan.Name = "colQueQuan";
            this.colQueQuan.ReadOnly = true;
            // 
            // colTamTru
            // 
            this.colTamTru.DataPropertyName = "DaDangKyTamTru";
            this.colTamTru.FillWeight = 45F;
            this.colTamTru.HeaderText = "Tạm trú";
            this.colTamTru.Name = "colTamTru";
            this.colTamTru.ReadOnly = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 529);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1002, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 17);
            this.lblStatus.Text = "Sẵn sàng";
            // 
            // FormKhachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 551);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dgvKhachThue);
            this.Controls.Add(this.btnBoLoc);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cboLocTinh);
            this.Controls.Add(this.lblLocTinh);
            this.Controls.Add(this.cboLocPhong);
            this.Controls.Add(this.lblLocPhong);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.gbThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormKhachThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà trọ - Khách thuê";
            this.Load += new System.EventHandler(this.FormKhachThue_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbGioiTinh.ResumeLayout(false);
            this.gbGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachThue)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox gbGioiTinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblTinhThanh;
        private System.Windows.Forms.ComboBox cboTinh;
        private System.Windows.Forms.Label lblPhuongXa;
        private System.Windows.Forms.ComboBox cboPhuongXa;
        private System.Windows.Forms.CheckBox chkTamTru;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnGayLoiThu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblLocPhong;
        private System.Windows.Forms.ComboBox cboLocPhong;
        private System.Windows.Forms.Label lblLocTinh;
        private System.Windows.Forms.ComboBox cboLocTinh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.DataGridView dgvKhachThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQueQuan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTamTru;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}
