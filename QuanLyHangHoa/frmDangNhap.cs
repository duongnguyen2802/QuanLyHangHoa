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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        UserDAO userDAO = new UserDAO();
        private void btDangNhap_Click(object sender, EventArgs e)
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

            frmMain.UserLogin1 = userDAO.LayUserTheoTenDangNhapVaMK(user);



        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
