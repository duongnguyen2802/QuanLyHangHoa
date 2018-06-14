namespace QuanLyHangHoa
{
    partial class frmTimKiemHangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHangHoa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblName = new DevComponents.DotNetBar.LabelX();
            this.cboName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.radioMaHangHoa = new System.Windows.Forms.RadioButton();
            this.radioTenHangHoa = new System.Windows.Forms.RadioButton();
            this.mamathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmathang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhethan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhomhanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamathang,
            this.tenmathang,
            this.soluong,
            this.dongia,
            this.ngaysanxuat,
            this.ngayhethan,
            this.tinhtrang,
            this.manhomhanghoa,
            this.manhacungcap,
            this.donvitinh});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangHoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHangHoa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 207);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(614, 140);
            this.dgvHangHoa.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(71, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Mã hàng";
            // 
            // cboName
            // 
            this.cboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboName.DisplayMember = "Text";
            this.cboName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboName.FormattingEnabled = true;
            this.cboName.ItemHeight = 18;
            this.cboName.Location = new System.Drawing.Point(152, 84);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(249, 24);
            this.cboName.TabIndex = 2;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimKiem.Location = new System.Drawing.Point(421, 85);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // radioMaHangHoa
            // 
            this.radioMaHangHoa.AutoSize = true;
            this.radioMaHangHoa.Checked = true;
            this.radioMaHangHoa.Location = new System.Drawing.Point(152, 124);
            this.radioMaHangHoa.Name = "radioMaHangHoa";
            this.radioMaHangHoa.Size = new System.Drawing.Size(88, 17);
            this.radioMaHangHoa.TabIndex = 4;
            this.radioMaHangHoa.TabStop = true;
            this.radioMaHangHoa.Text = "Mã hàng hóa";
            this.radioMaHangHoa.UseVisualStyleBackColor = true;
            this.radioMaHangHoa.CheckedChanged += new System.EventHandler(this.radioMaHangHoa_CheckedChanged);
            // 
            // radioTenHangHoa
            // 
            this.radioTenHangHoa.AutoSize = true;
            this.radioTenHangHoa.Location = new System.Drawing.Point(263, 124);
            this.radioTenHangHoa.Name = "radioTenHangHoa";
            this.radioTenHangHoa.Size = new System.Drawing.Size(92, 17);
            this.radioTenHangHoa.TabIndex = 5;
            this.radioTenHangHoa.TabStop = true;
            this.radioTenHangHoa.Text = "Tên hàng hóa";
            this.radioTenHangHoa.UseVisualStyleBackColor = true;
            this.radioTenHangHoa.CheckedChanged += new System.EventHandler(this.radioTenHangHoa_CheckedChanged);
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
            this.ngaysanxuat.HeaderText = "Ngày sản xuât";
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
            this.donvitinh.Visible = false;
            // 
            // frmTimKiemHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 347);
            this.Controls.Add(this.radioTenHangHoa);
            this.Controls.Add(this.radioMaHangHoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvHangHoa);
            this.DoubleBuffered = true;
            this.Name = "frmTimKiemHangHoa";
            this.Text = "TÌM KIẾM HÀNG HÓA";
            this.Load += new System.EventHandler(this.frmTimKiemHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHangHoa;
        private DevComponents.DotNetBar.LabelX lblName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboName;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private System.Windows.Forms.RadioButton radioMaHangHoa;
        private System.Windows.Forms.RadioButton radioTenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysanxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhomhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
    }
}