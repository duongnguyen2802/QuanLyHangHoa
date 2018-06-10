using CrystalDecisions.CrystalReports.Engine;
using QuanLyHangHoa.DAO;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        LoaiNhanVienDAO nhanvien = new LoaiNhanVienDAO();
        private string maphieunhap = "PN000001";
        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable dtPhieuNhapKho = phieuNhapDAO.LayPhieuNhapChoBaoCao(maphieunhap);
            //DataRow dr = dtPhieuNhapKho.Rows[0];
            //DateTime dtNgayNhap = Convert.ToDateTime(dr["ngaynhap"].ToString());

            //rpt.SetDataSource(nhanvien.LayLoaiNhanVien());
            //this.crystalReportViewer1.ReportSource = rpt;

            //rtphieu.SetParameterValue("pNgay", dtNgayNhap.Day);
            //rtphieu.SetParameterValue("pThang", dtNgayNhap.Month);
            //rtphieu.SetParameterValue("pNam", dtNgayNhap.Year);
            //rtphieu.SetParameterValue("pNhaCungCap", dr["tennhacungcap"].ToString());
            //rtphieu.SetParameterValue("pDiaChi", dr["diachi"].ToString());
            //rtphieu.SetParameterValue("pDienThoai", dr["dienthoai"].ToString());
            DataTable dt = new DataTable();
            dt.Columns.Add("maloainhanvien", typeof(string));
            dt.Columns.Add("tenloainhanvien", typeof(string));
            dt.Columns.Add("tiento", typeof(string));

            DataRow dr = dt.NewRow();
            dr["maloainhanvien"] = "1";
            dr["tenloainhanvien"] = "abc";
            dr["tiento"] = "tiento";
            dt.Rows.Add(dr);
            //dt.Rows.Add(dr);

            ReportDocument myReport = new ReportDocument();
            // myReport.Load(@".\CrystalReport1.rpt");

            CrystalReport1 cpt1 = new CrystalReport1();
            
           // DataTable dt = nhanvien.LayLoaiNhanVien();
           cpt1.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cpt1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtPhieuNhapKho = phieuNhapDAO.LayPhieuNhapChoBaoCao(maphieunhap);
            DataRow dr = dtPhieuNhapKho.Rows[0];
            DateTime dtNgayNhap = Convert.ToDateTime(dr["ngaynhap"]);
            rptPhieuNhap rtphieu = new rptPhieuNhap();
            rtphieu.SetDataSource(dtPhieuNhapKho);
            string pChuoiNgayThangNam = "Ngày " +  dtNgayNhap.Day + " tháng "+ dtNgayNhap.Month + " năm "+ dtNgayNhap.Year;
            rtphieu.SetParameterValue("pChuoiNgayThangNam", pChuoiNgayThangNam);
            rtphieu.SetParameterValue("pNhaCungCap",dr["tennhacungcap"].ToString());
            rtphieu.SetParameterValue("pDiaChi", dr["diachi"].ToString());
            rtphieu.SetParameterValue("pSoPhieu", maphieunhap);
            rtphieu.SetParameterValue("pDienThoai", dr["dienthoai"].ToString());
            this.crystalReportViewer1.ReportSource = rtphieu;
        }
    }
}
