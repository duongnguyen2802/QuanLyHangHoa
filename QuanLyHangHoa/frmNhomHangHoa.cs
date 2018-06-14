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
    public partial class frmNhomHangHoa : Form
    {
        public frmNhomHangHoa()
        {
            InitializeComponent();
        }
        NhomHangHoaDAO nhomhanghoaDAO = new NhomHangHoaDAO();
        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra dữ liệu null

            //nếu không nhập tên nhóm hàng hóa thì thông báo nhập lại
            if (string.IsNullOrEmpty(txtTenNhom.Text))
            {
                MessageBox.Show("Tên nhóm hàng hóa không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtTenNhom.Focus();

                return;
            }
            else
            {
                bool kt = false;
                //kiem tra ton tai code
                foreach (DataGridViewRow item in dgvNhomHangHoa.Rows)
                {
                    if (item.Cells["code"].Value.ToString().Equals(txtCode.Text))
                    {
                        kt = true; break;
                    }
                }

                if (kt)
                {
                    MessageBox.Show("Mã nhóm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                NhomHangHoa nhomhanghoa = new NhomHangHoa();
                //gán tên hàng hóa từ textbox vào đối tượng nhomhanghoa
                nhomhanghoa.Tennhomhanghoa = txtTenNhom.Text;
                nhomhanghoa.Code = txtCode.Text;
                //thêm nhóm hàng hóa vào db
                bool kiemtra = nhomhanghoaDAO.ThemNhomHangHoa(nhomhanghoa);

                string chuoithongbao = "Thêm nhóm hàng hóa thành công!";
                if (!kiemtra)
                {
                    chuoithongbao = "Thêm nhóm hàng hóa thất bại";
                    this.LamMoi();
                }
                MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //hiển thị danh sách nhóm hàng hóa lên datagridview
                dgvNhomHangHoa.DataSource = nhomhanghoaDAO.LayTatCaNhomHangHoa();

            }
        }

        private void frmNhomHangHoa_Load(object sender, EventArgs e)
        {
            dgvNhomHangHoa.DataSource = nhomhanghoaDAO.LayTatCaNhomHangHoa();
        }

        private void LamMoi()
        {
            txtMaNhom.Text = string.Empty;
            txtTenNhom.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtCode.Enabled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.LamMoi();
        }

        private void dgvNhomHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhom.Text = dgvNhomHangHoa.CurrentRow.Cells["manhomhanghoa"].Value.ToString();
            txtTenNhom.Text = dgvNhomHangHoa.CurrentRow.Cells["tennhomhanghoa"].Value.ToString();
            txtCode.Text = dgvNhomHangHoa.CurrentRow.Cells["code"].Value.ToString();

            txtCode.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhom.Text))
            {
                MessageBox.Show("Tên nhóm hàng hóa không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhóm hàng hóa
                txtTenNhom.Focus();

                return;
            }

            NhomHangHoa nhomhanghoa = new NhomHangHoa();
            nhomhanghoa.Manhomhanghoa =  Convert.ToInt32(txtMaNhom.Text);
            nhomhanghoa.Tennhomhanghoa = txtTenNhom.Text;
            //gán dữ liệu vào đối tượng
            //thêm nhóm hàng hóa vào db
            bool kiemtra = nhomhanghoaDAO.CapNhatNhomHangHoa(nhomhanghoa);
            string chuoithongbao = "Cập nhật dữ liệu thành công!";
            if (!kiemtra)
            {
                chuoithongbao = "Cập nhật dữ liệu thất bại";
                this.LamMoi();
            }
            MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //hiển thị danh sách nhóm hàng hóa lên datagridview
            dgvNhomHangHoa.DataSource = nhomhanghoaDAO.LayTatCaNhomHangHoa();
        }

        private void btnXoas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhom.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacnhan = MessageBox.Show("Bạn có muốn xóa " + txtTenNhom.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes)
            {

                NhomHangHoa nhomhanghoa = new NhomHangHoa();
                //gán dữ liệu vào đối tượng
                //thêm nhóm hàng hóa vào db
                nhomhanghoa.Manhomhanghoa = Convert.ToInt32(txtMaNhom.Text);
                bool kiemtra = nhomhanghoaDAO.XoaNhomHangHoa(nhomhanghoa);
                string chuoithongbao = "Xóa dữ liệu thành công!";
                if (!kiemtra)
                {
                    chuoithongbao = "Xóa dữ liệu thất bại";
                    this.LamMoi();
                }
                MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //hiển thị danh sách nhóm hàng hóa lên datagridview
                dgvNhomHangHoa.DataSource = nhomhanghoaDAO.LayTatCaNhomHangHoa();
            }
        }


    }
}
