using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyHangHoa.DataAcessLayer;
using System.Data;
namespace QuanLyHangHoa.DAO
{
    class KhacHangDAO
    {
        DataAccessHelper dataAccessHelper = new DataAccessHelper();


        public string getMaKH()
        {
           string sql = "select MaKH from khachhang";
           return dataAccessHelper.getMaKH(sql, "KH", 8);

        }

        public DataTable LayTatCaKhachHang()
        {
            String sql = "select * from khachhang";
            return dataAccessHelper.GetData(sql);
        }
    }
}
