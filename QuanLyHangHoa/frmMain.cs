using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyHangHoa.Entities;
namespace QuanLyHangHoa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private static User UserLogin;

        internal static User UserLogin1
        {
            get { return frmMain.UserLogin; }
            set { frmMain.UserLogin = value; }
        }

        private void mndangnhap_Click_1(object sender, EventArgs e)
        {

        }

        private void mnDoiMatKhau_Click_1(object sender, EventArgs e)
        {

        }

        private void mnThoat_Click(object sender, EventArgs e)
        {

        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.ShowDialog();
        }

        private void mnuQuanLyHangHoa_Click(object sender, EventArgs e)
        {
            frmNhomHangHoa nhomhanghoa = new frmNhomHangHoa();
            nhomhanghoa.ShowDialog();
        }

        private void mnuQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            frmQuanLyNhaCungCap nhacungcap = new frmQuanLyNhaCungCap();
            nhacungcap.ShowDialog();
        }

        private void mnuQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang khachang = new frmKhachHang();
            khachang.ShowDialog();
        }

        private void mnuQLHangHoa_Click(object sender, EventArgs e)
        {
            frmQuanLyHangHoa quanlyhanghoa = new frmQuanLyHangHoa();
            quanlyhanghoa.ShowDialog();
        }

        private void mnuQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien quanlynhanvien = new frmNhanVien();
            quanlynhanvien.ShowDialog();
        }

        private void mnuDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dangky = new frmDangKy();
            dangky.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.ShowDialog();
            if (UserLogin != null)
            {
               // KiemTraQuyen();
            }
            else
            {
                //khong dang nhap thoat phan mem
                this.Close();
            }
        }

        public void KiemTraQuyen()
        {
            foreach (ToolStripMenuItem item in this.mainMenutrip.Items)
            {
                foreach (ToolStripItem menucap2 in item.DropDown.Items)
                {
                   // string namecon = col.Name;
                    if (!UserLogin.KiemTraQuyen(menucap2.Name))
                    {
                        menucap2.Enabled = false;
                    }
                }
               

            }
        }

        private void mnuNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang nhaphang = new frmNhapHang();
            nhaphang.ShowDialog();
        }

        private void mnuXuatHang_Click(object sender, EventArgs e)
        {
            frmXuatHang xuatHang = new frmXuatHang();
            xuatHang.ShowDialog();
        }
    }
}
