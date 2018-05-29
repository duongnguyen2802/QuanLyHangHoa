namespace QuanLyHangHoa
{
    partial class frmNhomHangHoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoas = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvNhomHangHoa = new System.Windows.Forms.DataGridView();
            this.manhomhanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhomhanghoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm ";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Enabled = false;
            this.txtMaNhom.Location = new System.Drawing.Point(130, 57);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(232, 20);
            this.txtMaNhom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhóm";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(130, 91);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(232, 20);
            this.txtTenNhom.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(128, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(230, 142);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoas
            // 
            this.btnXoas.Location = new System.Drawing.Point(336, 142);
            this.btnXoas.Name = "btnXoas";
            this.btnXoas.Size = new System.Drawing.Size(75, 23);
            this.btnXoas.TabIndex = 4;
            this.btnXoas.Text = "Xóa";
            this.btnXoas.UseVisualStyleBackColor = true;
            this.btnXoas.Click += new System.EventHandler(this.btnXoas_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(432, 142);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvNhomHangHoa
            // 
            this.dgvNhomHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhomhanghoa,
            this.tennhomhanghoa});
            this.dgvNhomHangHoa.Location = new System.Drawing.Point(1, 195);
            this.dgvNhomHangHoa.Name = "dgvNhomHangHoa";
            this.dgvNhomHangHoa.Size = new System.Drawing.Size(540, 109);
            this.dgvNhomHangHoa.TabIndex = 6;
            this.dgvNhomHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomHangHoa_CellClick);
            // 
            // manhomhanghoa
            // 
            this.manhomhanghoa.DataPropertyName = "manhomhanghoa";
            this.manhomhanghoa.HeaderText = "Mã nhóm";
            this.manhomhanghoa.Name = "manhomhanghoa";
            // 
            // tennhomhanghoa
            // 
            this.tennhomhanghoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennhomhanghoa.DataPropertyName = "tennhomhanghoa";
            this.tennhomhanghoa.HeaderText = "Tên nhóm hàng hóa";
            this.tennhomhanghoa.Name = "tennhomhanghoa";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(541, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "QUẢN LÝ NHÓM HÀNG HÓA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmNhomHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 301);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvNhomHangHoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoas);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.label1);
            this.Name = "frmNhomHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhóm hàng hóa";
            this.Load += new System.EventHandler(this.frmNhomHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoas;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvNhomHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhomhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhomhanghoa;
        private System.Windows.Forms.Label label3;
    }
}