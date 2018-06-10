using QuanLyHangHoa.DataAcessLayer;
using QuanLyHangHoa.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.DAO
{
    class PhieuNhapDAO
    {
        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        public string SinhMaPhieuNhap()
        {
            string sql = "select maphieunhap from phieunhap";
            return dataAccessHelper.getMaKH(sql, "PN", 8);

        }

        public bool ThemPhieuNhapTransaction(PhieuNhap phieunhap, DataTable dtDSMatHang)
        {
            return dataAccessHelper.ThemPhieuNhap(phieunhap, dtDSMatHang);
        }

        public DataTable LayPhieuNhapChoBaoCao(string maphieunhap)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append(" select pn.*,nv.tenhannhan,ctpn.machitietphieu,ctpn.mamathang,ctpn.soluong,ctpn.dongia,hh.tenmathang, ncc.tennhacungcap, ncc.diachi,ncc.dienthoai from phieunhap pn    ");
            sbSQL.Append(" join nhanvien nv on pn.manhanvien = nv.manhanvien ");
            sbSQL.Append(" join chitietphieunhap ctpn on ctpn.maphieunhap = pn.maphieunhap ");
            sbSQL.Append(" join hanghoa hh on hh.mamathang = ctpn.mamathang ");
            sbSQL.Append(" join nhacungcap ncc on ncc.manhacungcap = hh.manhacungcap ");
            sbSQL.Append(" where pn.maphieunhap = '" + maphieunhap + "'");
            return dataAccessHelper.GetData(sbSQL.ToString());
        }

        public DataTable LayDanhSachPhieuNhap()
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append(" select pn.*,nv.tenhannhan from phieunhap pn  ");
            sbSQL.Append(" join nhanvien nv on pn.manhanvien = nv.manhanvien ");
            return dataAccessHelper.GetData(sbSQL.ToString());
        }
    }
}
