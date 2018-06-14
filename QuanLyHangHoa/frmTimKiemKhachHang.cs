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
    public partial class frmTimKiemKhachHang : Office2007Form
    {
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }
        KhacHangDAO khachhangDAO = new KhacHangDAO();
        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khachhangDAO.LayTatCaKhachHang();
        }
    }
}
