namespace QL_TraSua
{
    partial class FormBanHang
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnMoHoaDon = new System.Windows.Forms.Button();
            this.btnMoThucDon = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbChonMon = new System.Windows.Forms.GroupBox();
            this.btnThemVaoDon = new System.Windows.Forms.Button();
            this.nudSoLy = new System.Windows.Forms.NumericUpDown();
            this.lblSoLy = new System.Windows.Forms.Label();
            this.lbMonUong = new System.Windows.Forms.ListBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.gbDonHienTai = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThanhToan = new System.Windows.Forms.GroupBox();
            this.btnDaNhanTien = new System.Windows.Forms.Button();
            this.lblNoiDungQR = new System.Windows.Forms.Label();
            this.lblSoTienQR = new System.Windows.Forms.Label();
            this.lblInfoTK = new System.Windows.Forms.Label();
            this.pbVietQR = new System.Windows.Forms.PictureBox();
            this.btnTienMat = new System.Windows.Forms.Button();
            this.btnThanhToanCK = new System.Windows.Forms.Button();
            this.pnlNav.SuspendLayout();
            this.gbChonMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLy)).BeginInit();
            this.gbDonHienTai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.gbThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVietQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlNav.Controls.Add(this.btnMoHoaDon);
            this.pnlNav.Controls.Add(this.btnMoThucDon);
            this.pnlNav.Controls.Add(this.lblTitle);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(984, 45);
            this.pnlNav.TabIndex = 0;
            // 
            // btnMoHoaDon
            // 
            this.btnMoHoaDon.Location = new System.Drawing.Point(825, 8);
            this.btnMoHoaDon.Name = "btnMoHoaDon";
            this.btnMoHoaDon.Size = new System.Drawing.Size(145, 30);
            this.btnMoHoaDon.TabIndex = 2;
            this.btnMoHoaDon.Text = "📋 Lịch sử hóa đơn";
            this.btnMoHoaDon.UseVisualStyleBackColor = true;
            this.btnMoHoaDon.Click += new System.EventHandler(this.btnMoHoaDon_Click);
            // 
            // btnMoThucDon
            // 
            this.btnMoThucDon.Location = new System.Drawing.Point(670, 8);
            this.btnMoThucDon.Name = "btnMoThucDon";
            this.btnMoThucDon.Size = new System.Drawing.Size(145, 30);
            this.btnMoThucDon.TabIndex = 1;
            this.btnMoThucDon.Text = "🧋 Quản lý thực đơn";
            this.btnMoThucDon.UseVisualStyleBackColor = true;
            this.btnMoThucDon.Click += new System.EventHandler(this.btnMoThucDon_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bán hàng - Quán trà sữa";
            // 
            // gbChonMon
            // 
            this.gbChonMon.Controls.Add(this.btnThemVaoDon);
            this.gbChonMon.Controls.Add(this.nudSoLy);
            this.gbChonMon.Controls.Add(this.lblSoLy);
            this.gbChonMon.Controls.Add(this.lbMonUong);
            this.gbChonMon.Controls.Add(this.cboDanhMuc);
            this.gbChonMon.Controls.Add(this.lblDanhMuc);
            this.gbChonMon.Location = new System.Drawing.Point(12, 55);
            this.gbChonMon.Name = "gbChonMon";
            this.gbChonMon.Size = new System.Drawing.Size(260, 480);
            this.gbChonMon.TabIndex = 1;
            this.gbChonMon.TabStop = false;
            this.gbChonMon.Text = "Chọn món";
            // 
            // btnThemVaoDon
            // 
            this.btnThemVaoDon.Location = new System.Drawing.Point(15, 435);
            this.btnThemVaoDon.Name = "btnThemVaoDon";
            this.btnThemVaoDon.Size = new System.Drawing.Size(230, 32);
            this.btnThemVaoDon.TabIndex = 5;
            this.btnThemVaoDon.Text = "Thêm vào đơn";
            this.btnThemVaoDon.UseVisualStyleBackColor = true;
            this.btnThemVaoDon.Click += new System.EventHandler(this.btnThemVaoDon_Click);
            // 
            // nudSoLy
            // 
            this.nudSoLy.Location = new System.Drawing.Point(80, 400);
            this.nudSoLy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLy.Name = "nudSoLy";
            this.nudSoLy.Size = new System.Drawing.Size(80, 23);
            this.nudSoLy.TabIndex = 4;
            this.nudSoLy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLy
            // 
            this.lblSoLy.AutoSize = true;
            this.lblSoLy.Location = new System.Drawing.Point(15, 402);
            this.lblSoLy.Name = "lblSoLy:";
            this.lblSoLy.Size = new System.Drawing.Size(39, 15);
            this.lblSoLy.TabIndex = 3;
            this.lblSoLy.Text = "Số ly:";
            // 
            // lbMonUong
            // 
            this.lbMonUong.FormattingEnabled = true;
            this.lbMonUong.ItemHeight = 15;
            this.lbMonUong.Location = new System.Drawing.Point(15, 80);
            this.lbMonUong.Name = "lbMonUong";
            this.lbMonUong.Size = new System.Drawing.Size(230, 304);
            this.lbMonUong.TabIndex = 2;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(15, 45);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(230, 23);
            this.cboDanhMuc.TabIndex = 1;
            this.cboDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cboDanhMuc_SelectedIndexChanged);
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(15, 25);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(65, 15);
            this.lblDanhMuc.TabIndex = 0;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // gbDonHienTai
            // 
            this.gbDonHienTai.Controls.Add(this.lblTongTien);
            this.gbDonHienTai.Controls.Add(this.btnXoaDong);
            this.gbDonHienTai.Controls.Add(this.dgvGioHang);
            this.gbDonHienTai.Location = new System.Drawing.Point(285, 55);
            this.gbDonHienTai.Name = "gbDonHienTai";
            this.gbDonHienTai.Size = new System.Drawing.Size(380, 480);
            this.gbDonHienTai.TabIndex = 2;
            this.gbDonHienTai.TabStop = false;
            this.gbDonHienTai.Text = "Đơn hiện tại";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.ForeColor = System.Drawing.Color.Black;
            this.lblTongTien.Location = new System.Drawing.Point(10, 435);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(360, 32);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng tiền: 0 đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoaDong
            // 
            this.btnXoaDong.Location = new System.Drawing.Point(140, 395);
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.Size = new System.Drawing.Size(100, 30);
            this.btnXoaDong.TabIndex = 1;
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.UseVisualStyleBackColor = true;
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenMon,
            this.colSoLy,
            this.colDonGia,
            this.colThanhTien});
            this.dgvGioHang.Location = new System.Drawing.Point(10, 25);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(360, 360);
            this.dgvGioHang.TabIndex = 0;
            // 
            // colTenMon
            // 
            this.colTenMon.DataPropertyName = "TenMon";
            this.colTenMon.FillWeight = 110F;
            this.colTenMon.HeaderText = "Tên món";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            // 
            // colSoLy
            // 
            this.colSoLy.DataPropertyName = "SoLy";
            this.colSoLy.FillWeight = 35F;
            this.colSoLy.HeaderText = "SL";
            this.colSoLy.Name = "colSoLy";
            this.colSoLy.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.FillWeight = 65F;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.FillWeight = 75F;
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // gbThanhToan
            // 
            this.gbThanhToan.Controls.Add(this.btnDaNhanTien);
            this.gbThanhToan.Controls.Add(this.lblNoiDungQR);
            this.gbThanhToan.Controls.Add(this.lblSoTienQR);
            this.gbThanhToan.Controls.Add(this.lblInfoTK);
            this.gbThanhToan.Controls.Add(this.pbVietQR);
            this.gbThanhToan.Controls.Add(this.btnTienMat);
            this.gbThanhToan.Controls.Add(this.btnThanhToanCK);
            this.gbThanhToan.Location = new System.Drawing.Point(680, 55);
            this.gbThanhToan.Name = "gbThanhToan";
            this.gbThanhToan.Size = new System.Drawing.Size(290, 480);
            this.gbThanhToan.TabIndex = 3;
            this.gbThanhToan.TabStop = false;
            this.gbThanhToan.Text = "Thanh toán";
            // 
            // btnDaNhanTien
            // 
            this.btnDaNhanTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDaNhanTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaNhanTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDaNhanTien.ForeColor = System.Drawing.Color.White;
            this.btnDaNhanTien.Location = new System.Drawing.Point(20, 435);
            this.btnDaNhanTien.Name = "btnDaNhanTien";
            this.btnDaNhanTien.Size = new System.Drawing.Size(250, 35);
            this.btnDaNhanTien.TabIndex = 6;
            this.btnDaNhanTien.Text = "Đã nhận tiền";
            this.btnDaNhanTien.UseVisualStyleBackColor = false;
            this.btnDaNhanTien.Click += new System.EventHandler(this.btnDaNhanTien_Click);
            // 
            // lblNoiDungQR
            // 
            this.lblNoiDungQR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoiDungQR.Location = new System.Drawing.Point(20, 405);
            this.lblNoiDungQR.Name = "lblNoiDungQR";
            this.lblNoiDungQR.Size = new System.Drawing.Size(250, 20);
            this.lblNoiDungQR.TabIndex = 5;
            this.lblNoiDungQR.Text = "Nội dung: --";
            this.lblNoiDungQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoTienQR
            // 
            this.lblSoTienQR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoTienQR.Location = new System.Drawing.Point(20, 385);
            this.lblSoTienQR.Name = "lblSoTienQR";
            this.lblSoTienQR.Size = new System.Drawing.Size(250, 20);
            this.lblSoTienQR.TabIndex = 4;
            this.lblSoTienQR.Text = "Số tiền: 0 đ";
            this.lblSoTienQR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoTK
            // 
            this.lblInfoTK.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfoTK.Location = new System.Drawing.Point(20, 320);
            this.lblInfoTK.Name = "lblInfoTK";
            this.lblInfoTK.Size = new System.Drawing.Size(250, 60);
            this.lblInfoTK.TabIndex = 3;
            this.lblInfoTK.Text = "Chủ TK: QUAN TRA SUA\nNgân hàng: VIETCOMBANK\nSTK: 1234567890";
            this.lblInfoTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbVietQR
            // 
            this.pbVietQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVietQR.Location = new System.Drawing.Point(40, 105);
            this.pbVietQR.Name = "pbVietQR";
            this.pbVietQR.Size = new System.Drawing.Size(210, 210);
            this.pbVietQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVietQR.TabIndex = 2;
            this.pbVietQR.TabStop = false;
            // 
            // btnTienMat
            // 
            this.btnTienMat.Location = new System.Drawing.Point(20, 65);
            this.btnTienMat.Name = "btnTienMat";
            this.btnTienMat.Size = new System.Drawing.Size(250, 32);
            this.btnTienMat.TabIndex = 1;
            this.btnTienMat.Text = "Tiền mặt";
            this.btnTienMat.UseVisualStyleBackColor = true;
            this.btnTienMat.Click += new System.EventHandler(this.btnTienMat_Click);
            // 
            // btnThanhToanCK
            // 
            this.btnThanhToanCK.Location = new System.Drawing.Point(20, 25);
            this.btnThanhToanCK.Name = "btnThanhToanCK";
            this.btnThanhToanCK.Size = new System.Drawing.Size(250, 32);
            this.btnThanhToanCK.TabIndex = 0;
            this.btnThanhToanCK.Text = "Thanh toán chuyển khoản";
            this.btnThanhToanCK.UseVisualStyleBackColor = true;
            this.btnThanhToanCK.Click += new System.EventHandler(this.btnThanhToanCK_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 551);
            this.Controls.Add(this.gbThanhToan);
            this.Controls.Add(this.gbDonHienTai);
            this.Controls.Add(this.gbChonMon);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng - Quán trà sữa";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.gbChonMon.ResumeLayout(false);
            this.gbChonMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLy)).EndInit();
            this.gbDonHienTai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.gbThanhToan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVietQR)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMoHoaDon;
        private System.Windows.Forms.Button btnMoThucDon;
        private System.Windows.Forms.GroupBox gbChonMon;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.ListBox lbMonUong;
        private System.Windows.Forms.Label lblSoLy;
        private System.Windows.Forms.NumericUpDown nudSoLy;
        private System.Windows.Forms.Button btnThemVaoDon;
        private System.Windows.Forms.GroupBox gbDonHienTai;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.GroupBox gbThanhToan;
        private System.Windows.Forms.Button btnThanhToanCK;
        private System.Windows.Forms.Button btnTienMat;
        private System.Windows.Forms.PictureBox pbVietQR;
        private System.Windows.Forms.Label lblInfoTK;
        private System.Windows.Forms.Label lblSoTienQR;
        private System.Windows.Forms.Label lblNoiDungQR;
        private System.Windows.Forms.Button btnDaNhanTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}
