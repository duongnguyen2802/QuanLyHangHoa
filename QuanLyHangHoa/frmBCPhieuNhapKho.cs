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
    public partial class frmBCPhieuNhapKho : Form
    {
        public frmBCPhieuNhapKho()
        {
            InitializeComponent();
        }
        public string maphieunhap = string.Empty;
        public frmBCPhieuNhapKho(string maphieunhap)
        {
            this.maphieunhap = maphieunhap;
        }
        PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        private void frmBCPhieuNhapKho_Load(object sender, EventArgs e)
        {
           
            DataTable dtPhieuNhapKho = phieuNhapDAO.LayPhieuNhapChoBaoCao(maphieunhap);
            DataRow dr = dtPhieuNhapKho.Rows[0];
            DateTime dtNgayNhap = Convert.ToDateTime(dr["ngaynhap"]);
            rptPhieuNhap rtphieu = new rptPhieuNhap();
            rtphieu.SetDataSource(dtPhieuNhapKho);
            float pTongTien = 0F;
            foreach (DataRow item in dtPhieuNhapKho.Rows)
            {
                pTongTien = int.Parse(item["soluong"].ToString()) * float.Parse(item["dongia"].ToString());
            }
            decimal moneyvalue = Convert.ToDecimal(pTongTien);
            rtphieu.SetParameterValue("pTienBangChu", VNCurrency.ToString(moneyvalue));
            string moneyValue = String.Format("{0:C}", moneyvalue);

            rtphieu.SetParameterValue("pTongTien", moneyValue.Replace("$",""));

            string pChuoiNgayThangNam = "Ngày " + dtNgayNhap.Day + " tháng " + dtNgayNhap.Month + " năm " + dtNgayNhap.Year;
            rtphieu.SetParameterValue("pChuoiNgayThangNam", pChuoiNgayThangNam);
            rtphieu.SetParameterValue("pNhaCungCap", dr["tennhacungcap"].ToString());
            rtphieu.SetParameterValue("pDiaChi", dr["diachi"].ToString());
            rtphieu.SetParameterValue("pSoPhieu", maphieunhap);
            rtphieu.SetParameterValue("pDienThoai", dr["dienthoai"].ToString());
            this.crystalReportViewer1.ReportSource = rtphieu;

         

        }

        private void crystalReportViewerNhapKho_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtPhieuNhapKho = phieuNhapDAO.LayPhieuNhapChoBaoCao(maphieunhap);
            DataRow dr = dtPhieuNhapKho.Rows[0];
            DateTime dtNgayNhap = Convert.ToDateTime(dr["ngaynhap"]);
            rptPhieuNhap rtphieu = new rptPhieuNhap();
            rtphieu.SetDataSource(dtPhieuNhapKho);
            string pChuoiNgayThangNam = "Ngày " + dtNgayNhap.Day + " tháng " + dtNgayNhap.Month + " năm " + dtNgayNhap.Year;
            rtphieu.SetParameterValue("pChuoiNgayThangNam", pChuoiNgayThangNam);
            rtphieu.SetParameterValue("pNhaCungCap", dr["tennhacungcap"].ToString());
            rtphieu.SetParameterValue("pDiaChi", dr["diachi"].ToString());
            rtphieu.SetParameterValue("pSoPhieu", maphieunhap);
            rtphieu.SetParameterValue("pDienThoai", dr["dienthoai"].ToString());
            this.crystalReportViewer1.ReportSource = rtphieu;

        }
    }
}
