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

        public bool ThemPhieuXuatTransaction(PhieuXuat phieuxuat, DataTable dtDSMatHang)
        {
            return dataAccessHelper.ThemPhieuXuat(phieuxuat, dtDSMatHang);
        }
    }
}
