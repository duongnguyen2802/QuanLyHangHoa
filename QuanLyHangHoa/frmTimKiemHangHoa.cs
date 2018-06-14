using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.WinForms;
using QuanLyHangHoa.DAO;
namespace QuanLyHangHoa
{
    public partial class frmTimKiemHangHoa : Office2007Form
    {
        public frmTimKiemHangHoa()
        {
            InitializeComponent();
        }
        HangHoaDAO hangHoaDAO = new HangHoaDAO();
        private void frmTimKiemHangHoa_Load(object sender, EventArgs e)
        {
            radioMaHangHoa.Checked = true;
            cboName.DisplayMember = "mamathang";
            cboName.DataSource = hangHoaDAO.LayDanhSachMatHang();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = hangHoaDAO.LayDanhSachMatHang();
            if (radioMaHangHoa.Checked)
            {
                dgvHangHoa.DataSource = hangHoaDAO.LayHangHoaTheoMaHoaTen(cboName.Text, true);
            }
            if (radioTenHangHoa.Checked)
            {
                dgvHangHoa.DataSource = hangHoaDAO.LayHangHoaTheoMaHoaTen(cboName.SelectedValue.ToString(), true);
            }
        }

        private void radioMaHangHoa_CheckedChanged(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = hangHoaDAO.LayDanhSachMatHang();
            cboName.DisplayMember = "mamathang";
            cboName.DataSource = hangHoaDAO.LayDanhSachMatHang();
        }

        private void radioTenHangHoa_CheckedChanged(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = hangHoaDAO.LayDanhSachMatHang();
            cboName.DisplayMember = "tenmathang";
            cboName.ValueMember = "mamathang";
            cboName.DataSource = hangHoaDAO.LayDanhSachMatHang();
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = hangHoaDAO.LayDanhSachMatHang();
            for (int i = dgvHangHoa.Rows.Count -2 ; i >= 0; i--)
            {
                
                if (radioMaHangHoa.Checked)
                {
                    if (!dgvHangHoa.Rows[i].Cells["mamathang"].Value.ToString().Equals(cboName.Text))
                    {
                        dgvHangHoa.Rows.RemoveAt(i);
                    }
                }
                else if (radioTenHangHoa.Checked)
                {
                    if (!dgvHangHoa.Rows[i].Cells["tenmathang"].Value.ToString().Contains(cboName.Text))
                    {
                        dgvHangHoa.Rows.RemoveAt(i);
                    }
                }
            }
          
        }
    }
}
