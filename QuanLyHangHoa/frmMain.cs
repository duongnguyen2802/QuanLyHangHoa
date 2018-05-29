using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
