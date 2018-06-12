using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyHangHoa.DAO;
using QuanLyHangHoa.Entities;
namespace QuanLyHangHoa
{
    public partial class frmDangNhapDB : Office2007Form
    {
        public frmDangNhapDB()
        {
            InitializeComponent();
        }



        private void frmDangNhapDB_Load(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;
        }
        UserDAO userDAO = new UserDAO();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTruyCap.Text))
            {
                MessageBox.Show("Nhập tên truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            User user = new User();
            user.Tendangnhap = txtTenTruyCap.Text.Trim();
            user.Matkhau = txtMatKhau.Text.Trim();

            frmMainDB.UserLogin1 = userDAO.LayUserTheoTenDangNhapVaMK(user);
            if (frmMainDB.UserLogin1 == null)
            {
                lblThongBao.Visible = true;
                lblThongBao.Text = "Sai thông tin tài khoản";
                txtTenTruyCap.Focus();
            }
            else
            {
                //chuyen form
                lblThongBao.Visible = true;
                lblThongBao.Text = "Đăng nhập thành công";
                //đóng form hiện tại
                this.Close();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBoxEx.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok.Equals(DialogResult.Yes))
            {
                // frmMain.huy = true;
                this.Close();
                //đóng toàn bộ ứng dụng
                Application.Exit();
            }
        }
    }
}
