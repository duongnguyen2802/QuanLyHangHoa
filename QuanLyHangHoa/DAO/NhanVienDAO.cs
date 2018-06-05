using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyHangHoa.DataAcessLayer;
using QuanLyHangHoa.Entities;
using System.Data;

namespace QuanLyHangHoa.DAO
{
    class NhanVienDAO
    {
        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        public bool Them(NhanVien nhanvien)
        {
            string sql = "insert into nhanvien values(@manhanvien, @tenhannhan, @maloainhanvien, @diahchi, @dienthoai, @email)";
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("manhanvien");
            values.Add(nhanvien.Manhanvien);

            parameters.Add("tenhannhan");
            values.Add(nhanvien.Tennhanvien);

            parameters.Add("maloainhanvien");
            values.Add(nhanvien.MaLoaiNhanvien.Maloainhanvien);

            parameters.Add("diahchi");
            values.Add(nhanvien.Diachi);

            parameters.Add("dienthoai");
            values.Add(nhanvien.Dienthoai);

            parameters.Add("email");
            values.Add(nhanvien.Email);


            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql, parameters, values);
        }

        public bool Sua(NhanVien nhanvien)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" update nhanvien set  ");
            sql.Append(" tenhannhan= @tenhannhan, maloainhanvien =@maloainhanvien, diahchi = @diahchi, dienthoai=@dienthoai, email =@email ");
            sql.Append(" where manhanvien =@manhanvien ");
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("manhanvien");
            values.Add(nhanvien.Manhanvien);

            parameters.Add("tenhannhan");
            values.Add(nhanvien.Tennhanvien);

            parameters.Add("maloainhanvien");
            values.Add(nhanvien.MaLoaiNhanvien.Maloainhanvien);

            parameters.Add("diahchi");
            values.Add(nhanvien.Diachi);

            parameters.Add("dienthoai");
            values.Add(nhanvien.Dienthoai);

            parameters.Add("email");
            values.Add(nhanvien.Email);
            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql.ToString(), parameters, values);
        }


        public bool Xoa(NhanVien nhanvien)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" delete from nhanvien where manhanvien =@manhanvien ");

            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("manhanvien");
            values.Add(nhanvien.Manhanvien);
            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sql.ToString(), parameters, values);
        }


        public DataTable LayTatCaNhanVien()
        {
            string sql = "select  nv.*, lnv.tenloainhanvien from nhanvien nv join loainhanvien lnv on nv.maloainhanvien = lnv.maloainhanvien";
            return dataAccessHelper.GetData(sql);
        }

        public DataTable LayTatCaNhanVienTheoMa(string manhanvien)
        {
            string sql = "select * from nhanvien  where manhanvien = '"+manhanvien+"'";
            return dataAccessHelper.GetData(sql);
        }
       


    }
}
