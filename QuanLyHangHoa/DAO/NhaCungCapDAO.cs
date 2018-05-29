using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyHangHoa.DataAcessLayer;
using System.Data;
using QuanLyHangHoa.Entities;

namespace QuanLyHangHoa.DAO
{
    class NhaCungCapDAO
    {
        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        public DataTable LayDanhSachNhaCC()
        {
            return dataAccessHelper.GetData("select * from nhacungcap");
        }
        //
        public bool ThemNhaCC(NhaCungCap nhacungcap)
        {
            string sql = "insert into nhacungcap(tennhacungcap,diachi,email,dienthoai) values(@tennhacungcap,@diachi,@email,@dienthoai)";
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("tennhacungcap");
            values.Add(nhacungcap.Tennhacungcap);

            parameters.Add("diachi");
            values.Add(nhacungcap.Diachi);

            parameters.Add("email");
            values.Add(nhacungcap.Email);

            parameters.Add("dienthoai");
            values.Add(nhacungcap.Dienthoai);


            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql, parameters, values);
        }



        public bool SuaNhaCC(NhaCungCap nhacungcap)
        {
            string sql = "update nhacungcap set tennhacungcap =@tennhacungcap ,diachi = @diachi,email =@email,dienthoai= @dienthoai where manhacungcap = @manhacungcap";
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("manhacungcap");
            values.Add(nhacungcap.Manhacungcap);
            parameters.Add("tennhacungcap");
            values.Add(nhacungcap.Tennhacungcap);
            parameters.Add("diachi");
            values.Add(nhacungcap.Diachi);
            parameters.Add("email");
            values.Add(nhacungcap.Email);
            parameters.Add("dienthoai");
            values.Add(nhacungcap.Dienthoai);
            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql, parameters, values);
        }

        //delete  from tennhacungcap where manhacungcap = 1;

        public bool XoaNhaCC(NhaCungCap nhacungcap)
        {
            string sql = "delete  from nhacungcap where manhacungcap = @manhacungcap";
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("manhacungcap");
            values.Add(nhacungcap.Manhacungcap);
            
            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql, parameters, values);
        }

    }
}
