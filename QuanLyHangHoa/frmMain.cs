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
    }
}
