namespace QuanLyHangHoa
{
    partial class frmNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grboxMatHang = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHangNhap = new System.Windows.Forms.DataGridView();
            this.mamathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLoaiHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhieuNhap = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.grboxMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxMatHang
            // 
            this.grboxMatHang.Controls.Add(this.btnXuatHang);
            this.grboxMatHang.Controls.Add(this.btnLamMoi);
            this.grboxMatHang.Controls.Add(this.btnThem);
            this.grboxMatHang.Controls.Add(this.dgvHangNhap);
            this.grboxMatHang.Controls.Add(this.txtTenHang);
            this.grboxMatHang.Controls.Add(this.label5);
            this.grboxMatHang.Controls.Add(this.txtGia);
            this.grboxMatHang.Controls.Add(this.label6);
            this.grboxMatHang.Controls.Add(this.txtSoLuong);
            this.grboxMatHang.Controls.Add(this.label4);
            this.grboxMatHang.Controls.Add(this.txtMaHang);
            this.grboxMatHang.Controls.Add(this.label2);
            this.grboxMatHang.Controls.Add(this.cboNhaCungCap);
            this.grboxMatHang.Controls.Add(this.label3);
            this.grboxMatHang.Controls.Add(this.cboLoaiHang);
            this.grboxMatHang.Controls.Add(this.label1);
            this.grboxMatHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grboxMatHang.Location = new System.Drawing.Point(0, 167);
            this.grboxMatHang.Name = "grboxMatHang";
            this.grboxMatHang.Size = new System.Drawing.Size(718, 337);
            this.grboxMatHang.TabIndex = 0;
            this.grboxMatHang.TabStop = false;
            this.grboxMatHang.Text = "Thông tin mặt hàng";
            this.grboxMatHang.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(185, 131);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(86, 131);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHangNhap
            // 
            this.dgvHangNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamathang,
            this.tenmathang,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.dgvHangNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHangNhap.Location = new System.Drawing.Point(3, 176);
            this.dgvHangNhap.Name = "dgvHangNhap";
            this.dgvHangNhap.Size = new System.Drawing.Size(712, 158);
            this.dgvHangNhap.TabIndex = 4;
            // 
            // mamathang
            // 
            this.mamathang.DataPropertyName = "mamathang";
            this.mamathang.HeaderText = "Mã mặt hàng";
            this.mamathang.Name = "mamathang";
            // 
            // tenmathang
            // 
            this.tenmathang.DataPropertyName = "tenmathang";
            this.tenmathang.HeaderText = "Tên mặt hàng";
            this.tenmathang.Name = "tenmathang";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(414, 64);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(200, 20);
            this.txtTenHang.TabIndex = 3;
            this.txtTenHang.TextChanged += new System.EventHandler(this.txtTenHang_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên hàng";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(414, 94);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(200, 20);
            this.txtGia.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(86, 94);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(174, 20);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Location = new System.Drawing.Point(86, 61);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(174, 20);
            this.txtMaHang.TabIndex = 3;
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hàng";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(415, 30);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(200, 21);
            this.cboNhaCungCap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà cung cấp";
            // 
            // cboLoaiHang
            // 
            this.cboLoaiHang.FormattingEnabled = true;
            this.cboLoaiHang.Location = new System.Drawing.Point(86, 30);
            this.cboLoaiHang.Name = "cboLoaiHang";
            this.cboLoaiHang.Size = new System.Drawing.Size(174, 21);
            this.cboLoaiHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại hàng";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Location = new System.Drawing.Point(412, 34);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(200, 20);
            this.dtNgayNhap.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày nhập";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(83, 67);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(174, 20);
            this.txtNhanVien.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtNgayNhap);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPhieuNhap);
            this.groupBox2.Controls.Add(this.txtNhanVien);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Location = new System.Drawing.Point(3, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mã phiếu";
            // 
            // txtPhieuNhap
            // 
            this.txtPhieuNhap.Enabled = false;
            this.txtPhieuNhap.Location = new System.Drawing.Point(83, 31);
            this.txtPhieuNhap.Name = "txtPhieuNhap";
            this.txtPhieuNhap.Size = new System.Drawing.Size(174, 20);
            this.txtPhieuNhap.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(411, 70);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 20);
            this.txtGhiChu.TabIndex = 3;
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Location = new System.Drawing.Point(287, 131);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(75, 23);
            this.btnXuatHang.TabIndex = 7;
            this.btnXuatHang.Text = "Nhập hàng";
            this.btnXuatHang.UseVisualStyleBackColor = true;
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grboxMatHang);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhapHang";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.grboxMatHang.ResumeLayout(false);
            this.grboxMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grboxMatHang;
        private System.Windows.Forms.DataGridView dgvHangNhap;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLoaiHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhieuNhap;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Button btnXuatHang;
    }
}