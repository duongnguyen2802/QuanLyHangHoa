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
using QuanLyHangHoa.DataAcessLayer;


namespace QuanLyHangHoa
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        DataAccessHelper dataAccessHelper = new DataAccessHelper();
        UserDAO userDAO = new UserDAO();
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            //lay danh sach nhan vien vao combobox
            cboNhanVien.DisplayMember = "tenhannhan";
            cboNhanVien.ValueMember = "manhanvien";
            cboNhanVien.DataSource = nhanVienDAO.LayTatCaNhanVien();

            cboNhomTaiKhoan.DisplayMember = "tennhom";
            cboNhomTaiKhoan.ValueMember = "manhom";
            cboNhomTaiKhoan.DataSource = dataAccessHelper.GetData("select * from nhomuser");

            //lay danh danh nhan user vao datagridview
            dgUser.DataSource = userDAO.LayDanhSachUser();

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            this.LamMoi();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //insert into user values(tendangnhap= @tendangnhap, matkhau =@matkhau, manhomuser =@manhomuser, manhanvien=@manhanvien, email =@email, dienthoai=@dienthoai)
            //kiem tra mat khau co trung khop hay khong
            if (!txtMatKhau.Text.Equals(txtNhapLaiMatKhau.Text))
            {
                //thong bao mat khau khong khop nhau
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhapLaiMatKhau.Focus();
                return;
            }

            if (userDAO.KiemTraUserTonTai(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Focus();
                //thông báo tên đăng nhập đã tồn tại
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                User user = new User();
                NhanVien nhanvien = new NhanVien();
                user.Tendangnhap = txtTenDangNhap.Text;
                user.Matkhau = txtMatKhau.Text;
                user.Email = txtEmail.Text;
                user.Dienthoai = txtDienThoai.Text;
                user.Manhomuser = Convert.ToInt32(cboNhomTaiKhoan.SelectedValue.ToString());
                nhanvien.Manhanvien = cboNhanVien.SelectedValue.ToString();
                user.Manhanvien = nhanvien;


                bool kiemtra = userDAO.Them(user);
                string chuoithongbao = "Thêm dữ liệu hóa thành công!";
                if (!kiemtra)
                {
                    chuoithongbao = "Thêm dữ liệu hóa thất bại";
                    this.LamMoi();
                }
                MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //hiển thị danh sách nhóm hàng hóa lên datagridview
                dgUser.DataSource = userDAO.LayDanhSachUser();


            }
        }

        private void LamMoi()
        {
            //lay danh sach nhan vien vao combobox
            cboNhanVien.DisplayMember = "tenhannhan";
            cboNhanVien.ValueMember = "manhanvien";
            cboNhanVien.DataSource = nhanVienDAO.LayTatCaNhanVien();

            cboNhomTaiKhoan.DisplayMember = "tennhom";
            cboNhomTaiKhoan.ValueMember = "manhom";
            cboNhomTaiKhoan.DataSource = dataAccessHelper.GetData("select * from nhomuser");


            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
        private string maNV = string.Empty;
        private int maNUser = -1;
        private void dgUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDangNhap.Text = dgUser.CurrentRow.Cells["tendangnhap"].Value.ToString();
            txtMatKhau.Text = dgUser.CurrentRow.Cells["matkhau"].Value.ToString();
            txtNhapLaiMatKhau.Text = dgUser.CurrentRow.Cells["matkhau"].Value.ToString();
            if (dgUser.CurrentRow.Cells["email"].Value != null)
            {
                txtEmail.Text = dgUser.CurrentRow.Cells["email"].Value.ToString();
            }
            if (dgUser.CurrentRow.Cells["dienthoai"].Value != null)
            {
                txtDienThoai.Text = dgUser.CurrentRow.Cells["dienthoai"].Value.ToString();
            }


            maNV = dgUser.CurrentRow.Cells["manhanvien"].Value.ToString();
            maNUser = Convert.ToInt32(dgUser.CurrentRow.Cells["manhomuser"].Value.ToString());
            DataTable dtnv = nhanVienDAO.LayTatCaNhanVien();
            for (int i = 0; i < dtnv.Rows.Count; i++)
            {
                if (dtnv.Rows[i]["manhanvien"].Equals(maNV))
                {
                    cboNhanVien.SelectedIndex = i;
                    break;
                }
            }




            DataTable dtnhomuser = dataAccessHelper.GetData("select * from nhomuser");
            for (int i = 0; i < dtnhomuser.Rows.Count; i++)
            {
                if (dtnhomuser.Rows[i]["manhom"].Equals(maNUser))
                {
                    cboNhomTaiKhoan.SelectedIndex = i;
                    break;
                }
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //insert into user values(tendangnhap= @tendangnhap, matkhau =@matkhau, manhomuser =@manhomuser, manhanvien=@manhanvien, email =@email, dienthoai=@dienthoai)
            //kiem tra mat khau co trung khop hay khong
            if (!txtMatKhau.Text.Equals(txtNhapLaiMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //thong bao mat khau khong khop nhau
                txtNhapLaiMatKhau.Focus();
                return;
            }

            if (!userDAO.KiemTraUserTonTai(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Focus();

                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               

                User user = new User();
                NhanVien nhanvien = new NhanVien();
                user.Tendangnhap = txtTenDangNhap.Text;
                user.Matkhau = txtMatKhau.Text;
                user.Email = txtEmail.Text;
                user.Dienthoai = txtDienThoai.Text;
                user.Manhomuser = Convert.ToInt32(cboNhomTaiKhoan.SelectedValue.ToString());
                nhanvien.Manhanvien = cboNhanVien.SelectedValue.ToString();
                user.Manhanvien = nhanvien;


                bool kiemtra = userDAO.Sua(user);
                string chuoithongbao = "Cập nhật dữ liệu hóa thành công!";
                if (!kiemtra)
                {
                    chuoithongbao = "Cập nhật dữ liệu hóa thất bại";
                    this.LamMoi();
                }
                MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //hiển thị danh sách nhóm hàng hóa lên datagridview
                dgUser.DataSource = userDAO.LayDanhSachUser();


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Chọn tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Bạn có muốn xóa tài khoản " + txtTenDangNhap.Text + "không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.No) return;
                User user = new User();
                user.Tendangnhap = txtTenDangNhap.Text;

                bool kiemtra = userDAO.Xoa(user);
                string chuoithongbao = "Xóa dữ liệu hóa thành công!";
                if (!kiemtra)
                {
                    chuoithongbao = "Xóa dữ liệu hóa thất bại";
                    this.LamMoi();
                }
                MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //hiển thị danh sách nhóm hàng hóa lên datagridview
                dgUser.DataSource = userDAO.LayDanhSachUser();
            }
        }
    }
}
