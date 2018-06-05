namespace QuanLyHangHoa
{
    partial class frmMain
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
            this.mainMenutrip = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenutrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenutrip
            // 
            this.mainMenutrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanly});
            this.mainMenutrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenutrip.Name = "mainMenutrip";
            this.mainMenutrip.Size = new System.Drawing.Size(698, 24);
            this.mainMenutrip.TabIndex = 0;
            this.mainMenutrip.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangKy,
            this.mnuDoiMatKhau,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(152, 22);
            this.mnuDangNhap.Text = "Đăng nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangKy
            // 
            this.mnuDangKy.Name = "mnuDangKy";
            this.mnuDangKy.Size = new System.Drawing.Size(152, 22);
            this.mnuDangKy.Text = "Đăng ký";
            this.mnuDangKy.Click += new System.EventHandler(this.mnuDangKy_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(152, 22);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(152, 22);
            this.mnuThoat.Text = "Thoát";
            // 
            // mnuQuanly
            // 
            this.mnuQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyHangHoa,
            this.mnuQuanLyNhaCungCap,
            this.mnuQuanLyKhachHang,
            this.mnuQLHangHoa,
            this.mnuQuanLyNhanVien});
            this.mnuQuanly.Name = "mnuQuanly";
            this.mnuQuanly.Size = new System.Drawing.Size(60, 20);
            this.mnuQuanly.Text = "Quản lý";
            // 
            // mnuQuanLyHangHoa
            // 
            this.mnuQuanLyHangHoa.Name = "mnuQuanLyHangHoa";
            this.mnuQuanLyHangHoa.Size = new System.Drawing.Size(203, 22);
            this.mnuQuanLyHangHoa.Text = "Quản lý nhóm hàng hóa";
            this.mnuQuanLyHangHoa.Click += new System.EventHandler(this.mnuQuanLyHangHoa_Click);
            // 
            // mnuQuanLyNhaCungCap
            // 
            this.mnuQuanLyNhaCungCap.Name = "mnuQuanLyNhaCungCap";
            this.mnuQuanLyNhaCungCap.Size = new System.Drawing.Size(203, 22);
            this.mnuQuanLyNhaCungCap.Text = "Quản lý nhà cung cấp";
            this.mnuQuanLyNhaCungCap.Click += new System.EventHandler(this.mnuQuanLyNhaCungCap_Click);
            // 
            // mnuQuanLyKhachHang
            // 
            this.mnuQuanLyKhachHang.Name = "mnuQuanLyKhachHang";
            this.mnuQuanLyKhachHang.Size = new System.Drawing.Size(203, 22);
            this.mnuQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.mnuQuanLyKhachHang.Click += new System.EventHandler(this.mnuQuanLyKhachHang_Click);
            // 
            // mnuQLHangHoa
            // 
            this.mnuQLHangHoa.Name = "mnuQLHangHoa";
            this.mnuQLHangHoa.Size = new System.Drawing.Size(203, 22);
            this.mnuQLHangHoa.Text = "Quán lý Hàng hóa";
            this.mnuQLHangHoa.Click += new System.EventHandler(this.mnuQLHangHoa_Click);
            // 
            // mnuQuanLyNhanVien
            // 
            this.mnuQuanLyNhanVien.Name = "mnuQuanLyNhanVien";
            this.mnuQuanLyNhanVien.Size = new System.Drawing.Size(203, 22);
            this.mnuQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.mnuQuanLyNhanVien.Click += new System.EventHandler(this.mnuQuanLyNhanVien_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 360);
            this.Controls.Add(this.mainMenutrip);
            this.MainMenuStrip = this.mainMenutrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ HÀNG HÓA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainMenutrip.ResumeLayout(false);
            this.mainMenutrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenutrip;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangKy;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanly;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyNhanVien;
    }
}