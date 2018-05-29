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
    public partial class frmDangNhap2 : Form
    {
        public frmDangNhap2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hòa cá vàng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dương điên", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

     
       

        
    }
}
