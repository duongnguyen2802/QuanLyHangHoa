namespace QuanLyHangHoa
{
    partial class frmQuanLyHangHoa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.datePickerNgaySX = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datePickerHetHan = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboNhomHangHoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.mamathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhomhanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhomhanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "QUẢN LÝ  HÀNG HÓA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã mặt hàng";
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Enabled = false;
            this.txtMaMatHang.Location = new System.Drawing.Point(104, 64);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(121, 20);
            this.txtMaMatHang.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên mặt hàng";
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(332, 64);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(179, 20);
            this.txtTenMatHang.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(104, 135);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuong.TabIndex = 10;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đơn giá";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(104, 94);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(121, 20);
            this.txtDonGia.TabIndex = 10;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // datePickerNgaySX
            // 
            this.datePickerNgaySX.CustomFormat = "dd/MM/YYYY";
            this.datePickerNgaySX.Location = new System.Drawing.Point(332, 135);
            this.datePickerNgaySX.Name = "datePickerNgaySX";
            this.datePickerNgaySX.Size = new System.Drawing.Size(179, 20);
            this.datePickerNgaySX.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày sản xuất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày hết hạn";
            // 
            // datePickerHetHan
            // 
            this.datePickerHetHan.Location = new System.Drawing.Point(633, 135);
            this.datePickerHetHan.Name = "datePickerHetHan";
            this.datePickerHetHan.Size = new System.Drawing.Size(141, 20);
            this.datePickerHetHan.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nhà cung cấp";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(332, 95);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(179, 21);
            this.cboNhaCungCap.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nhóm hàng hóa";
            // 
            // cboNhomHangHoa
            // 
            this.cboNhomHangHoa.FormattingEnabled = true;
            this.cboNhomHangHoa.Location = new System.Drawing.Point(633, 97);
            this.cboNhomHangHoa.Name = "cboNhomHangHoa";
            this.cboNhomHangHoa.Size = new System.Drawing.Size(141, 21);
            this.cboNhomHangHoa.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(228, 183);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(330, 183);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(436, 183);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Location = new System.Drawing.Point(544, 183);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamathang,
            this.tenmathang,
            this.soluong,
            this.dongia,
            this.ngaysanxuat,
            this.ngayhethan,
            this.tinhtrang,
            this.tennhomhanghoa,
            this.tennhacungcap,
            this.manhomhanghoa,
            this.manhacungcap,
            this.donvitinh});
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 229);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(800, 175);
            this.dgvHangHoa.TabIndex = 16;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đơn vị tính";
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Items.AddRange(new object[] {
            "Cái",
            "Thùng",
            "Hộp",
            "Gói"});
            this.cboDonViTinh.Location = new System.Drawing.Point(633, 63);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(141, 21);
            this.cboDonViTinh.TabIndex = 13;
            // 
            // mamathang
            // 
            this.mamathang.DataPropertyName = "mamathang";
            this.mamathang.HeaderText = "Mã hàng";
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
            // ngaysanxuat
            // 
            this.ngaysanxuat.DataPropertyName = "ngaysanxuat";
            this.ngaysanxuat.HeaderText = "Ngày sản xuất";
            this.ngaysanxuat.Name = "ngaysanxuat";
            // 
            // ngayhethan
            // 
            this.ngayhethan.DataPropertyName = "ngayhethan";
            this.ngayhethan.HeaderText = "Ngày hết hạn";
            this.ngayhethan.Name = "ngayhethan";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Visible = false;
            // 
            // tennhomhanghoa
            // 
            this.tennhomhanghoa.DataPropertyName = "tennhomhanghoa";
            this.tennhomhanghoa.HeaderText = "Nhóm hàng";
            this.tennhomhanghoa.Name = "tennhomhanghoa";
            // 
            // tennhacungcap
            // 
            this.tennhacungcap.DataPropertyName = "tennhacungcap";
            this.tennhacungcap.HeaderText = "Nhà cung cấp";
            this.tennhacungcap.Name = "tennhacungcap";
            // 
            // manhomhanghoa
            // 
            this.manhomhanghoa.DataPropertyName = "manhomhanghoa";
            this.manhomhanghoa.HeaderText = "manhomhanghoa";
            this.manhomhanghoa.Name = "manhomhanghoa";
            this.manhomhanghoa.Visible = false;
            // 
            // manhacungcap
            // 
            this.manhacungcap.DataPropertyName = "manhacungcap";
            this.manhacungcap.HeaderText = "manhacungcap";
            this.manhacungcap.Name = "manhacungcap";
            this.manhacungcap.Visible = false;
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn vị tính";
            this.donvitinh.Name = "donvitinh";
            // 
            // frmQuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboDonViTinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboNhomHangHoa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboNhaCungCap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datePickerHetHan);
            this.Controls.Add(this.datePickerNgaySX);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenMatHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaMatHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "frmQuanLyHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HÀNG HÓA";
            this.Load += new System.EventHandler(this.frmQuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DateTimePicker datePickerNgaySX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePickerHetHan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboNhomHangHoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhomhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhomhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
    }
}