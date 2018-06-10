using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyHangHoa.DAO;

namespace QuanLyHangHoa
{
    public partial class frmQuanLyPhieuNhap : Form
    {
        public frmQuanLyPhieuNhap()
        {
            InitializeComponent();
        }
        PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        private void frmQuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = phieuNhapDAO.LayDanhSachPhieuNhap();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieu.Text = dgvPhieuNhap.CurrentRow.Cells["maphieunhap"].Value.ToString();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {

            }
            else
            {
                frmBCPhieuNhapKho phieunhapkho = new frmBCPhieuNhapKho();
                phieunhapkho.maphieunhap = txtMaPhieu.Text;
                phieunhapkho.ShowDialog();
            }
        }

       
    }
}
