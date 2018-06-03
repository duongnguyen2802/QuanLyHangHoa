using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyHangHoa.DataAcessLayer;
using QuanLyHangHoa.Entities;
using System.Data;
namespace QuanLyHangHoa.DAO
{
    class LoaiNhanVienDAO
    {
        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        public DataTable LayLoaiNhanVien()
        {
            string sql = "SELECT * FROM loainhanvien";
            return dataAccessHelper.GetData(sql);
        }
    }
}
