using QuanLyHangHoa.DataAcessLayer;
using QuanLyHangHoa.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.DAO
{
    class PhieuXuatDAO
    {
        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        public string SinhMaPhieuXuat()
        {
            string sql = "select maphieuxuat from phieuxuat";
            return dataAccessHelper.getMaKH(sql, "PX", 8);

        }

        public DataTable LayTatCaPhieuXuat()
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append(" select px.*,nv.tenhannhan,kh.TenKH from phieuxuat px ");
            sbSQL.Append(" join nhanvien nv on nv.manhanvien = px.manhanvien");
            sbSQL.Append(" join khachhang kh on kh.MaKH = px.MaKH");
            return dataAccessHelper.GetData(sbSQL.ToString());
        }

        public bool ThemPhieuXuatTransaction(PhieuXuat phieuxuat, DataTable dtDSMatHang)
        {
            return dataAccessHelper.ThemPhieuXuat(phieuxuat, dtDSMatHang);
        }

        public DataTable LayTatCaPhieuXuatChoBaoCao(string maphieuxuat)
        {
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append(" select px.*, nv.tenhannhan,kh.TenKH,kh.DiaChi, kh.DienThoai,hh.tenmathang,ctpx.mamathang,ctpx.soluong,ctpx.dongia from phieuxuat px ");
            sbSQL.Append(" join chitietphieuxuat ctpx on px.maphieuxuat = ctpx.maphieuxuat");
            sbSQL.Append(" join nhanvien nv on nv.manhanvien = px.manhanvien");
            sbSQL.Append(" join khachhang kh on kh.MaKH = px.MaKH");
            sbSQL.Append(" join hanghoa hh on hh.mamathang = ctpx.mamathang");
            sbSQL.Append(" where px.maphieuxuat = '"+maphieuxuat+"' ");

            return dataAccessHelper.GetData(sbSQL.ToString());
        }


    }
}
