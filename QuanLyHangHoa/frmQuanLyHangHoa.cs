using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyHangHoa.DAO;
using QuanLyHangHoa.Entities;

namespace QuanLyHangHoa
{
    public partial class frmQuanLyHangHoa : Form
    {
        public frmQuanLyHangHoa()
        {
            InitializeComponent();
        }
        NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
        NhomHangHoaDAO nhomHangHoaDAO = new NhomHangHoaDAO();
        HangHoaDAO hangHoaDAO = new HangHoaDAO();

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void getMaxMaHangHoa()
        {
            txtMaMatHang.Text = hangHoaDAO.getMaHangHoa();
        }
        private void frmQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            //load danh sách nhà cung cấp vào combobox
            cboNhaCungCap.DisplayMember = "tennhacungcap";
            cboNhaCungCap.ValueMember = "manhacungcap";
            cboNhaCungCap.DataSource = nhaCungCapDAO.LayDanhSachNhaCC();

            //load danh sach nhom hang 
            cboNhomHangHoa.DisplayMember = "tennhomhanghoa";
            cboNhomHangHoa.ValueMember = "manhomhanghoa";
            cboNhomHangHoa.DataSource = nhomHangHoaDAO.LayTatCaNhomHangHoa();

            // Set the Format type and the CustomFormat string.
            datePickerNgaySX.Format = DateTimePickerFormat.Custom;
            datePickerNgaySX.CustomFormat = "dd-MM-yyyy";


            datePickerHetHan.Format = DateTimePickerFormat.Custom;
            datePickerHetHan.CustomFormat = "dd-MM-yyyy";

            dgvHangHoa.DataSource = hangHoaDAO.LayDanhSachMatHang();


            this.getMaxMaHangHoa();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMatHang.Text))
            {
                MessageBox.Show("Mã mặt hàng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtTenMatHang.Focus();
                this.getMaxMaHangHoa();
                return;
            }

            if (string.IsNullOrEmpty(txtTenMatHang.Text))
            {
                MessageBox.Show("Tên mặt không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtTenMatHang.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Số Lượng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtSoLuong.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Số Lượng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtDonGia.Focus();
                return;
            }

            HangHoa hanghoa = new HangHoa();
            NhaCungCap nhacungcap = new NhaCungCap();
            NhomHangHoa nhomhanghoa = new NhomHangHoa();
            hanghoa.Mamathang =txtMaMatHang.Text;
            hanghoa.Tenmathang = txtTenMatHang.Text;
            hanghoa.Dongia = Convert.ToSingle(txtDonGia.Text);
            hanghoa.Soluong = Convert.ToInt32(txtSoLuong.Text);
           
            nhacungcap.Manhacungcap = Convert.ToInt32(cboNhaCungCap.SelectedValue.ToString());
            hanghoa.Manhacungcap = nhacungcap;

            string a = cboNhomHangHoa.SelectedValue.ToString();

            nhomhanghoa.Manhomhanghoa = Convert.ToInt32(cboNhomHangHoa.SelectedValue.ToString());
            hanghoa.Manhomhanghoa = nhomhanghoa;

            hanghoa.Ngaysanxuat = datePickerNgaySX.Value;
            hanghoa.Ngayhethan = datePickerHetHan.Value;

             bool kiemtra = hangHoaDAO.ThemMatHang(hanghoa);
             string chuoithongbao = "Thêm dữ liệu hóa thành công!";
             if (!kiemtra)
             {
                 chuoithongbao = "Thêm dữ liệu hóa thất bại";
                 this.LamMoi();
             }
             MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

             //hiển thị danh sách nhóm hàng hóa lên datagridview
             dgvHangHoa.DataSource = hangHoaDAO.LayDanhSachMatHang();

        }

        private void LamMoi()
        {
            txtTenMatHang.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            datePickerHetHan.Value = DateTime.Now;
            datePickerNgaySX.Value = DateTime.Now;

            //load danh sách nhà cung cấp vào combobox
            cboNhaCungCap.DisplayMember = "tennhacungcap";
            cboNhaCungCap.ValueMember = "manhacungcap";
            cboNhaCungCap.DataSource = nhaCungCapDAO.LayDanhSachNhaCC();

            //load danh sach nhom hang 
            cboNhomHangHoa.DisplayMember = "tennhomhanghoa";
            cboNhomHangHoa.ValueMember = "manhomhanghoa";
            cboNhomHangHoa.DataSource = nhomHangHoaDAO.LayTatCaNhomHangHoa();

            
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMatHang.Text = dgvHangHoa.CurrentRow.Cells["mamathang"].Value.ToString();
            txtTenMatHang.Text = dgvHangHoa.CurrentRow.Cells["tenmathang"].Value.ToString();
            txtSoLuong.Text = dgvHangHoa.CurrentRow.Cells["soluong"].Value.ToString();
            txtDonGia.Text = dgvHangHoa.CurrentRow.Cells["dongia"].Value.ToString();

            if (dgvHangHoa.CurrentRow.Cells["ngaysanxuat"].Value != null)
            {
                datePickerNgaySX.Text = dgvHangHoa.CurrentRow.Cells["ngaysanxuat"].Value.ToString();
            }
            if (dgvHangHoa.CurrentRow.Cells["ngayhethan"].Value != null)
            {
                datePickerHetHan.Text = dgvHangHoa.CurrentRow.Cells["ngayhethan"].Value.ToString();
            }

           DataTable dtnhaCungCap = nhaCungCapDAO.LayDanhSachNhaCC();
           for (int i = 0; i < dtnhaCungCap.Rows.Count; i++)
           {

               if (dtnhaCungCap.Rows[i]["manhacungcap"].ToString().Equals(dgvHangHoa.CurrentRow.Cells["manhacungcap"].Value.ToString()))
               {
                   cboNhaCungCap.SelectedIndex = i;
                   break;
               }
           }


           DataTable dtnhanhomhanghoa = nhomHangHoaDAO.LayTatCaNhomHangHoa();
           for (int i = 0; i < dtnhanhomhanghoa.Rows.Count; i++)
           {
               if (dtnhanhomhanghoa.Rows[i]["manhomhanghoa"].ToString().Equals(dgvHangHoa.CurrentRow.Cells["manhomhanghoa"].Value.ToString()))
               {
                   cboNhomHangHoa.SelectedIndex =i;
                   break;
               }
           }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            //không cho nhập chữ
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("Chỉ nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMatHang.Text))
            {
                MessageBox.Show("Mã mặt hàng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtTenMatHang.Focus();
                this.getMaxMaHangHoa();
                return;
            }

            if (string.IsNullOrEmpty(txtTenMatHang.Text))
            {
                MessageBox.Show("Tên mặt không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtTenMatHang.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Số Lượng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtSoLuong.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Số Lượng không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtDonGia.Focus();
                return;
            }


            HangHoa hanghoa = new HangHoa();
            NhaCungCap nhacungcap = new NhaCungCap();
            NhomHangHoa nhomhanghoa = new NhomHangHoa();
            hanghoa.Mamathang = txtMaMatHang.Text;
            hanghoa.Tenmathang = txtTenMatHang.Text;
            hanghoa.Dongia = Convert.ToSingle(txtDonGia.Text);
            hanghoa.Soluong = Convert.ToInt32(txtSoLuong.Text);

            nhacungcap.Manhacungcap = Convert.ToInt32(cboNhaCungCap.SelectedValue.ToString());
            hanghoa.Manhacungcap = nhacungcap;

           
            nhomhanghoa.Manhomhanghoa = Convert.ToInt32(cboNhomHangHoa.SelectedValue.ToString());
            hanghoa.Manhomhanghoa = nhomhanghoa;

            hanghoa.Ngaysanxuat = datePickerNgaySX.Value;
            hanghoa.Ngayhethan = datePickerHetHan.Value;

            bool kiemtra = hangHoaDAO.SuamMatHang(hanghoa);
            string chuoithongbao = "Cập nhật dữ liệu hóa thành công!";
            if (!kiemtra)
            {
                chuoithongbao = "Cập nhật dữ liệu hóa thất bại";
                this.LamMoi();
            }
            MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //hiển thị danh sách nhóm hàng hóa lên datagridview
            dgvHangHoa.DataSource = hangHoaDAO.LayDanhSachMatHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaMatHang.Text))
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacnhan = MessageBox.Show("Bạn có muốn xóa " + txtTenMatHang.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes)
            {

                HangHoa hanghoa = new HangHoa();
                //gán dữ liệu vào đối tượng
                //thêm nhóm hàng hóa vào db
                hanghoa.Mamathang = txtMaMatHang.Text;
                bool kiemtra = hangHoaDAO.XoaMatHang(hanghoa);
                string chuoithongbao = "Xóa dữ liệu thành công!";
                if (!kiemtra)
                {
                    chuoithongbao = "Xóa dữ liệu thất bại";
                  
                }
                MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LamMoi();
                //hiển thị danh sách nhóm hàng hóa lên datagridview
                //hiển thị danh sách nhóm hàng hóa lên datagridview
                dgvHangHoa.DataSource = hangHoaDAO.LayDanhSachMatHang();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.LamMoi();
            this.getMaxMaHangHoa();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("Chỉ nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtDonGia.Text)) return;
            //decimal value = 0.00M;
            //StringBuilder sb = new StringBuilder(txtDonGia.Text);
            //value = Convert.ToDecimal(sb.Replace("$", "").ToString().Trim());
            //txtDonGia.Text = value.ToString("C").Replace("$", "");
            //txtDonGia.SelectionStart = txtDonGia.Text.Length + 1;
        }
    }
}
