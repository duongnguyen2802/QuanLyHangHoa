using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyHangHoa.DataAcessLayer;
using System.Data;
using QuanLyHangHoa.Entities;

namespace QuanLyHangHoa.DAO
{
    class HangHoaDAO
    {
        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        public DataTable LayDanhSachMatHang()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select mamathang, tenmathang, soluong, dongia, ngaysanxuat, ngayhethan, tinhtrang, nhomhanghoa.tennhomhanghoa ,nhacungcap.tennhacungcap,nhacungcap.manhacungcap,nhomhanghoa.manhomhanghoa  ");
            sb.Append(" from hanghoa ");
            sb.Append(" join nhacungcap on hanghoa.manhacungcap = nhacungcap.manhacungcap ");
            sb.Append(" join nhomhanghoa on hanghoa.manhomhanghoa = nhomhanghoa.manhomhanghoa ");
            return dataAccessHelper.GetData(sb.ToString());
        }

        public string getMaHangHoa()
        {
            string sql = "select mamathang from hanghoa";
            return dataAccessHelper.getMaKH(sql, "MH", 8);

        }

        public bool ThemMatHang(HangHoa hanghoa)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("insert into hanghoa (mamathang, tenmathang, soluong, dongia, ngaysanxuat, ngayhethan, manhomhanghoa, manhacungcap)");
            sb.Append("values(@mamathang, @tenmathang, @soluong, @dongia, @ngaysanxuat, @ngayhethan, @manhomhanghoa, @manhacungcap)");
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("mamathang");
            values.Add(hanghoa.Mamathang);

            parameters.Add("tenmathang");
            values.Add(hanghoa.Tenmathang);

            parameters.Add("soluong");
            values.Add(hanghoa.Soluong);

            parameters.Add("dongia");
            values.Add(hanghoa.Dongia);

            parameters.Add("ngaysanxuat");
            values.Add(hanghoa.Ngaysanxuat);

            parameters.Add("ngayhethan");
            values.Add(hanghoa.Ngayhethan);

            parameters.Add("manhomhanghoa");
            values.Add(hanghoa.Manhomhanghoa.Manhomhanghoa);

            parameters.Add("manhacungcap");
            values.Add(hanghoa.Manhacungcap.Manhacungcap);

           return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sb.ToString(), parameters, values);
          
        }


        public bool SuamMatHang(HangHoa hanghoa)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" update hanghoa  ");
            sb.Append(" set tenmathang =@tenmathang  ,soluong = @soluong , dongia= @dongia , ngaysanxuat = @ngaysanxuat, ngayhethan = @ngayhethan , manhomhanghoa = @manhomhanghoa, manhacungcap = @manhacungcap ");
            sb.Append(" where  mamathang = @mamathang ");
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("mamathang");
            values.Add(hanghoa.Mamathang);

            parameters.Add("tenmathang");
            values.Add(hanghoa.Tenmathang);

            parameters.Add("soluong");
            values.Add(hanghoa.Soluong);

            parameters.Add("dongia");
            values.Add(hanghoa.Dongia);

            parameters.Add("ngaysanxuat");
            values.Add(hanghoa.Ngaysanxuat);

            parameters.Add("ngayhethan");
            values.Add(hanghoa.Ngayhethan);

            parameters.Add("manhomhanghoa");
            values.Add(hanghoa.Manhomhanghoa.Manhomhanghoa);

            parameters.Add("manhacungcap");
            values.Add(hanghoa.Manhacungcap.Manhacungcap);

            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sb.ToString(), parameters, values);

        }

        public bool XoaMatHang(HangHoa hanghoa)
        {
            string sql = "delete from hanghoa where  mamathang = @mamathang";
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("mamathang");
            values.Add(hanghoa.Mamathang);
            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql, parameters, values);
        }

    }
}
