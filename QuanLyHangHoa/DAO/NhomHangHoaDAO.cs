using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QuanLyHangHoa.DataAcessLayer;
using QuanLyHangHoa.Entities;

namespace QuanLyHangHoa.DAO
{
    class NhomHangHoaDAO
    {
        DataAccessHelper dataAccessHelper = new DataAccessHelper();
        public DataTable LayTatCaNhomHangHoa()
        {
            
            return dataAccessHelper.GetData("select * from nhomhanghoa");
        }

       
        public bool ThemNhomHangHoa(NhomHangHoa nhomhanghoa)
        {
            string sql = "insert into nhomhanghoa(tennhomhanghoa) values(@tennhomhanghoa)";
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

             //khoi tao tham so va gia tri
            parameters.Add("tennhomhanghoa");
            values.Add(nhomhanghoa.Tennhomhanghoa);
            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql, parameters, values);
        }


        public bool CapNhatNhomHangHoa(NhomHangHoa nhomhanghoa)
        {
            string sql = "update nhomhanghoa set tennhomhanghoa = @tennhomhanghoa where manhomhanghoa = @manhomhanghoa";
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri

            parameters.Add("manhomhanghoa");
            values.Add(nhomhanghoa.Manhomhanghoa);

            parameters.Add("tennhomhanghoa");
            values.Add(nhomhanghoa.Tennhomhanghoa);

            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql, parameters, values);
        }



        public bool XoaNhomHangHoa(NhomHangHoa nhomhanghoa)
        {
            string sql = "delete  from nhomhanghoa where manhomhanghoa = @manhomhanghoa";
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("manhomhanghoa");
            values.Add(nhomhanghoa.Manhomhanghoa);

            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql, parameters, values);
        }
    }
}
