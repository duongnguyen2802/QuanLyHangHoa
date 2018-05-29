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
    public partial class frmQuanLyNhaCungCap : Form
    {
        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
        private void frmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = nhaCungCapDAO.LayDanhSachNhaCC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text)) 
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtTenNCC.Focus();
                return;
            }


            if (string.IsNullOrEmpty(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng số điện thoại nhà cung cấp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Email nhà cung cấp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }

            NhaCungCap nhacungcap = new NhaCungCap();
            nhacungcap.Tennhacungcap = txtTenNCC.Text;
            nhacungcap.Diachi = txtDiaChi.Text;
            nhacungcap.Dienthoai = txtDienThoai.Text;
            nhacungcap.Email = txtEmail.Text;


            bool kiemtra = nhaCungCapDAO.ThemNhaCC(nhacungcap);

            string chuoithongbao = "Thêm dữ liệu thành công!";
            if (!kiemtra)
            {
                chuoithongbao = "Thêm dữ liệu thất bại";
                this.LamMoi();
            }
            MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //hiển thị danh sách nhóm hàng hóa lên datagridview
            dgvNhaCC.DataSource = nhaCungCapDAO.LayDanhSachNhaCC();
        }

        private void LamMoi()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvNhaCC.CurrentRow.Cells["manhacungcap"].Value.ToString();
            txtTenNCC.Text = dgvNhaCC.CurrentRow.Cells["tennhacungcap"].Value.ToString();
            txtDiaChi.Text = dgvNhaCC.CurrentRow.Cells["diachi"].Value.ToString();
            txtDienThoai.Text = dgvNhaCC.CurrentRow.Cells["dienthoai"].Value.ToString();
            txtEmail.Text = dgvNhaCC.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.LamMoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNCC.Focus();
                return;
            }


            if (string.IsNullOrEmpty(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng số điện thoại nhà cung cấp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Email nhà cung cấp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }


            NhaCungCap nhacungcap = new NhaCungCap();
            nhacungcap.Manhacungcap = Convert.ToInt32(txtMaNCC.Text);
            nhacungcap.Tennhacungcap = txtTenNCC.Text;
            nhacungcap.Diachi = txtDiaChi.Text;
            nhacungcap.Dienthoai = txtDienThoai.Text;
            nhacungcap.Email = txtEmail.Text;


            bool kiemtra = nhaCungCapDAO.SuaNhaCC(nhacungcap);

            string chuoithongbao = "Sửa dữ liệu thành công!";
            if (!kiemtra)
            {
                chuoithongbao = "Sửa dữ liệu thất bại";
                this.LamMoi();
            }
            MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //hiển thị danh sách nhóm hàng hóa lên datagridview
            dgvNhaCC.DataSource = nhaCungCapDAO.LayDanhSachNhaCC();
        }

        private void btnXoas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacnhan = MessageBox.Show("Bạn có muốn xóa " + txtTenNCC.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes)
            {
                NhaCungCap nhacungcap = new NhaCungCap();
                nhacungcap.Manhacungcap = Convert.ToInt32(txtMaNCC.Text);

                bool kiemtra = nhaCungCapDAO.XoaNhaCC(nhacungcap);
                string chuoithongbao = "Xóa dữ liệu thành công!";
                if (!kiemtra)
                {
                    chuoithongbao = "Xóa dữ liệu thất bại";
                    this.LamMoi();
                }
                MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //hiển thị danh sách nhóm hàng hóa lên datagridview
                dgvNhaCC.DataSource = nhaCungCapDAO.LayDanhSachNhaCC();
            }
        }
    }
}
