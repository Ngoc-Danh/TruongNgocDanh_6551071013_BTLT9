namespace QL_TraSua
{
    partial class FormThucDon
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
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.nudGiaBan = new System.Windows.Forms.NumericUpDown();
            this.chkDangBan = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTimTen = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.lblLocDM = new System.Windows.Forms.Label();
            this.cboLocDM = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBoLoc = new System.Windows.Forms.Button();
            this.dgvMonUong = new System.Windows.Forms.DataGridView();
            this.colMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDangBan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).BeginInit();
            this.gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonUong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.btnLamMoi);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.chkDangBan);
            this.gbThongTin.Controls.Add(this.nudGiaBan);
            this.gbThongTin.Controls.Add(this.lblGiaBan);
            this.gbThongTin.Controls.Add(this.cboDanhMuc);
            this.gbThongTin.Controls.Add(this.lblDanhMuc);
            this.gbThongTin.Controls.Add(this.txtTenMon);
            this.gbThongTin.Controls.Add(this.lblTenMon);
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(340, 240);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin món uống";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(15, 30);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(56, 15);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Tên món:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(85, 27);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(235, 23);
            this.txtTenMon.TabIndex = 1;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(15, 70);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(65, 15);
            this.lblDanhMuc.TabIndex = 2;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(85, 67);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(235, 23);
            this.cboDanhMuc.TabIndex = 3;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(15, 110);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(50, 15);
            this.lblGiaBan.TabIndex = 4;
            this.lblGiaBan.Text = "Giá bán:";
            // 
            // nudGiaBan
            // 
            this.nudGiaBan.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGiaBan.Location = new System.Drawing.Point(85, 107);
            this.nudGiaBan.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudGiaBan.Name = "nudGiaBan";
            this.nudGiaBan.Size = new System.Drawing.Size(235, 23);
            this.nudGiaBan.TabIndex = 5;
            this.nudGiaBan.ThousandsSeparator = true;
            // 
            // chkDangBan
            // 
            this.chkDangBan.AutoSize = true;
            this.chkDangBan.Checked = true;
            this.chkDangBan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDangBan.Location = new System.Drawing.Point(85, 145);
            this.chkDangBan.Name = "chkDangBan";
            this.chkDangBan.Size = new System.Drawing.Size(77, 19);
            this.chkDangBan.TabIndex = 6;
            this.chkDangBan.Text = "Đang bán";
            this.chkDangBan.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 30);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(95, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(70, 30);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(175, 185);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 30);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(255, 185);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(70, 30);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // gbTimKiem
            // 
            this.gbTimKiem.Controls.Add(this.btnBoLoc);
            this.gbTimKiem.Controls.Add(this.btnTim);
            this.gbTimKiem.Controls.Add(this.cboLocDM);
            this.gbTimKiem.Controls.Add(this.lblLocDM);
            this.gbTimKiem.Controls.Add(this.txtTimTen);
            this.gbTimKiem.Controls.Add(this.lblTimTen);
            this.gbTimKiem.Location = new System.Drawing.Point(365, 12);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(430, 90);
            this.gbTimKiem.TabIndex = 1;
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm kiếm và Lọc";
            // 
            // lblTimTen
            // 
            this.lblTimTen.AutoSize = true;
            this.lblTimTen.Location = new System.Drawing.Point(15, 27);
            this.lblTimTen.Name = "lblTimTen";
            this.lblTimTen.Size = new System.Drawing.Size(56, 15);
            this.lblTimTen.TabIndex = 0;
            this.lblTimTen.Text = "Tên món:";
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(75, 24);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.PlaceholderText = "Nhập tên món...";
            this.txtTimTen.Size = new System.Drawing.Size(180, 23);
            this.txtTimTen.TabIndex = 1;
            // 
            // lblLocDM
            // 
            this.lblLocDM.AutoSize = true;
            this.lblLocDM.Location = new System.Drawing.Point(15, 57);
            this.lblLocDM.Name = "lblLocDM";
            this.lblLocDM.Size = new System.Drawing.Size(55, 15);
            this.lblLocDM.TabIndex = 2;
            this.lblLocDM.Text = "D.mục:";
            // 
            // cboLocDM
            // 
            this.cboLocDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocDM.FormattingEnabled = true;
            this.cboLocDM.Location = new System.Drawing.Point(75, 54);
            this.cboLocDM.Name = "cboLocDM";
            this.cboLocDM.Size = new System.Drawing.Size(180, 23);
            this.cboLocDM.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(275, 23);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(65, 25);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Location = new System.Drawing.Point(350, 23);
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(65, 25);
            this.btnBoLoc.TabIndex = 5;
            this.btnBoLoc.Text = "Bỏ lọc";
            this.btnBoLoc.UseVisualStyleBackColor = true;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);
            // 
            // dgvMonUong
            // 
            this.dgvMonUong.AllowUserToAddRows = false;
            this.dgvMonUong.AllowUserToDeleteRows = false;
            this.dgvMonUong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMon,
            this.colTenMon,
            this.colTenDM,
            this.colGiaBan,
            this.colDangBan});
            this.dgvMonUong.Location = new System.Drawing.Point(365, 110);
            this.dgvMonUong.MultiSelect = false;
            this.dgvMonUong.Name = "dgvMonUong";
            this.dgvMonUong.ReadOnly = true;
            this.dgvMonUong.RowHeadersVisible = false;
            this.dgvMonUong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonUong.Size = new System.Drawing.Size(430, 340);
            this.dgvMonUong.TabIndex = 2;
            this.dgvMonUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonUong_CellClick);
            // 
            // colMaMon
            // 
            this.colMaMon.DataPropertyName = "MaMon";
            this.colMaMon.FillWeight = 40F;
            this.colMaMon.HeaderText = "Mã";
            this.colMaMon.Name = "colMaMon";
            this.colMaMon.ReadOnly = true;
            // 
            // colTenMon
            // 
            this.colTenMon.DataPropertyName = "TenMon";
            this.colTenMon.FillWeight = 120F;
            this.colTenMon.HeaderText = "Tên món";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            // 
            // colTenDM
            // 
            this.colTenDM.DataPropertyName = "TenDM";
            this.colTenDM.FillWeight = 80F;
            this.colTenDM.HeaderText = "Danh mục";
            this.colTenDM.Name = "colTenDM";
            this.colTenDM.ReadOnly = true;
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.FillWeight = 70F;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.ReadOnly = true;
            // 
            // colDangBan
            // 
            this.colDangBan.DataPropertyName = "DangBan";
            this.colDangBan.FillWeight = 50F;
            this.colDangBan.HeaderText = "Đang bán";
            this.colDangBan.Name = "colDangBan";
            this.colDangBan.ReadOnly = true;
            // 
            // FormThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 462);
            this.Controls.Add(this.dgvMonUong);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý thực đơn món uống";
            this.Load += new System.EventHandler(this.FormThucDon_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaBan)).EndInit();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonUong)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.NumericUpDown nudGiaBan;
        private System.Windows.Forms.CheckBox chkDangBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.Label lblTimTen;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.Label lblLocDM;
        private System.Windows.Forms.ComboBox cboLocDM;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoLoc;
        private System.Windows.Forms.DataGridView dgvMonUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDangBan;
    }
}
