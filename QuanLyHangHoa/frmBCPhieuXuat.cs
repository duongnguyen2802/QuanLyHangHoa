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

namespace QuanLyHangHoa
{
    public partial class frmBCPhieuXuat : Office2007Form
    {
        public frmBCPhieuXuat()
        {
            InitializeComponent();
        }
        public string maphieuxuat = string.Empty;

        PhieuXuatDAO phieuXuatDAO = new PhieuXuatDAO();

        private void frmBCPhieuXuat_Load(object sender, EventArgs e)
        {
            DataTable dtPhieuXuatKho = phieuXuatDAO.LayTatCaPhieuXuatChoBaoCao(maphieuxuat);
            DataRow dr = dtPhieuXuatKho.Rows[0];
            DateTime dtNgayNXuat = Convert.ToDateTime(dr["ngayxuat"]);
            rptPhieuXuatKho rtphieu = new rptPhieuXuatKho();
            rtphieu.SetDataSource(dtPhieuXuatKho);
            float pTongTien = 0F;
            foreach (DataRow item in dtPhieuXuatKho.Rows)
            {
                pTongTien = int.Parse(item["soluong"].ToString()) * float.Parse(item["dongia"].ToString());
            }
            decimal moneyvalue = Convert.ToDecimal(pTongTien);
            rtphieu.SetParameterValue("tienvietbangchu", VNCurrency.ToString(moneyvalue));
            string moneyValue = String.Format("{0:C}", moneyvalue);

            rtphieu.SetParameterValue("pTongTien", moneyValue.Replace("$", ""));

            string pChuoiNgayThangNam = "Ngày " + dtNgayNXuat.Day + " tháng " + dtNgayNXuat.Month + " năm " + dtNgayNXuat.Year;
            rtphieu.SetParameterValue("ngaythang", pChuoiNgayThangNam);


            rtphieu.SetParameterValue("TenKH", dr["TenKH"].ToString());
            rtphieu.SetParameterValue("diachi", dr["diachi"].ToString());
            rtphieu.SetParameterValue("maphieuxuat", maphieuxuat);
            rtphieu.SetParameterValue("dienthoai", dr["dienthoai"].ToString());
            this.crystalReportViewerPhieuXuat.ReportSource = rtphieu;
        }
    }
}
