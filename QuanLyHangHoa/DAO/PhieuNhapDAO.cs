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
    }
}
