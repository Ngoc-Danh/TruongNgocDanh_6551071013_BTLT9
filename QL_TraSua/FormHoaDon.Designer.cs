namespace QL_TraSua
{
    partial class FormHoaDon
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblLocNgay = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colTenMonCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLyCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTienCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.gbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.gbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblDoanhThu);
            this.pnlTop.Controls.Add(this.btnLoc);
            this.pnlTop.Controls.Add(this.dtpNgay);
            this.pnlTop.Controls.Add(this.lblLocNgay);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(884, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // lblLocNgay
            // 
            this.lblLocNgay.AutoSize = true;
            this.lblLocNgay.Location = new System.Drawing.Point(15, 18);
            this.lblLocNgay.Name = "lblLocNgay";
            this.lblLocNgay.Size = new System.Drawing.Size(63, 15);
            this.lblLocNgay.TabIndex = 0;
            this.lblLocNgay.Text = "Chọn ngày:";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(85, 14);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(120, 23);
            this.dtpNgay.TabIndex = 1;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(215, 13);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 25);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "Xem tất cả";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblDoanhThu.Location = new System.Drawing.Point(450, 13);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(420, 25);
            this.lblDoanhThu.TabIndex = 3;
            this.lblDoanhThu.Text = "Doanh thu ngày: 0 đ";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.Location = new System.Drawing.Point(0, 50);
            this.splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.gbHoaDon);
            this.splMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.gbChiTiet);
            this.splMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splMain.Size = new System.Drawing.Size(884, 461);
            this.splMain.SplitterDistance = 450;
            this.splMain.TabIndex = 1;
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.Controls.Add(this.dgvHoaDon);
            this.gbHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHoaDon.Location = new System.Drawing.Point(10, 10);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Size = new System.Drawing.Size(430, 441);
            this.gbHoaDon.TabIndex = 0;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colNgayLap,
            this.colHinhThuc,
            this.colTongTien});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 19);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(424, 419);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.FillWeight = 45F;
            this.colMaHD.HeaderText = "Mã HD";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "NgayLap";
            this.colNgayLap.FillWeight = 85F;
            this.colNgayLap.HeaderText = "Giờ lập";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            // 
            // colHinhThuc
            // 
            this.colHinhThuc.DataPropertyName = "HinhThucTT";
            this.colHinhThuc.FillWeight = 75F;
            this.colHinhThuc.HeaderText = "Hình thức";
            this.colHinhThuc.Name = "colHinhThuc";
            this.colHinhThuc.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.FillWeight = 75F;
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // gbChiTiet
            // 
            this.gbChiTiet.Controls.Add(this.dgvChiTiet);
            this.gbChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChiTiet.Location = new System.Drawing.Point(10, 10);
            this.gbChiTiet.Name = "gbChiTiet";
            this.gbChiTiet.Size = new System.Drawing.Size(410, 441);
            this.gbChiTiet.TabIndex = 0;
            this.gbChiTiet.TabStop = false;
            this.gbChiTiet.Text = "Chi tiết món";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenMonCT,
            this.colSoLyCT,
            this.colDonGiaCT,
            this.colThanhTienCT});
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(3, 19);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(404, 419);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // colTenMonCT
            // 
            this.colTenMonCT.DataPropertyName = "TenMon";
            this.colTenMonCT.FillWeight = 110F;
            this.colTenMonCT.HeaderText = "Tên món";
            this.colTenMonCT.Name = "colTenMonCT";
            this.colTenMonCT.ReadOnly = true;
            // 
            // colSoLyCT
            // 
            this.colSoLyCT.DataPropertyName = "SoLy";
            this.colSoLyCT.FillWeight = 40F;
            this.colSoLyCT.HeaderText = "SL";
            this.colSoLyCT.Name = "colSoLyCT";
            this.colSoLyCT.ReadOnly = true;
            // 
            // colDonGiaCT
            // 
            this.colDonGiaCT.DataPropertyName = "DonGia";
            this.colDonGiaCT.FillWeight = 65F;
            this.colDonGiaCT.HeaderText = "Đơn giá";
            this.colDonGiaCT.Name = "colDonGiaCT";
            this.colDonGiaCT.ReadOnly = true;
            // 
            // colThanhTienCT
            // 
            this.colThanhTienCT.DataPropertyName = "ThanhTien";
            this.colThanhTienCT.FillWeight = 75F;
            this.colThanhTienCT.HeaderText = "Thành tiền";
            this.colThanhTienCT.Name = "colThanhTienCT";
            this.colThanhTienCT.ReadOnly = true;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splMain);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách hóa đơn & Doanh thu";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.gbHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.gbChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblLocNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.GroupBox gbHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox gbChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMonCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLyCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTienCT;
    }
}
