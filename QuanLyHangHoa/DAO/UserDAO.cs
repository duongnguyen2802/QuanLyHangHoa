using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyHangHoa.Entities;
using QuanLyHangHoa.DataAcessLayer;
using System.Data;


namespace QuanLyHangHoa.DAO
{
    class UserDAO
    {
        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        public DataTable LayDanhSachUser()
        {
            return dataAccessHelper.GetData("select us.*,nus.tennhom from user us join nhomuser nus on us.manhomuser = nus.manhom");
        }

        public bool Them(User user)
        {
            // string sql = "insert into user values(tendangnhap= @tendangnhap, matkhau =@matkhau, manhomuser =@manhomuser, manhanvien=@manhanvien, email =@email, dienthoai=@dienthoai)";
            StringBuilder sb = new StringBuilder();
            sb.Append(" insert into user(tendangnhap, matkhau, manhomuser, manhanvien, email, dienthoai) values ");
            sb.Append("(@tendangnhap, @matkhau, @manhomuser, @manhanvien, @email, @dienthoai)");
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("tendangnhap");
            values.Add(user.Tendangnhap);

            parameters.Add("matkhau");
            values.Add(user.Matkhau);

            parameters.Add("manhomuser");
            values.Add(user.Manhomuser);

            parameters.Add("manhanvien");
            values.Add(user.Manhanvien.Manhanvien);

            parameters.Add("email");
            values.Add(user.Email);

            parameters.Add("dienthoai");
            values.Add(user.Dienthoai);

            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sb.ToString(), parameters, values);

        }


        public bool KiemTraUserTonTai(string tendangnhap)
        {
            string sql = "select * from user where tendangnhap = '" + tendangnhap + "'";
            return dataAccessHelper.GetData(sql).Rows.Count > 0;
        }


        public bool Sua(User user)
        {
            // string sql = "insert into user values(tendangnhap= @tendangnhap, matkhau =@matkhau, manhomuser =@manhomuser, manhanvien=@manhanvien, email =@email, dienthoai=@dienthoai)";
            StringBuilder sb = new StringBuilder();
            sb.Append(" update user set matkhau =@matkhau, manhomuser =@manhomuser, manhanvien=@manhanvien, email =@email, dienthoai=@dienthoai ");
            sb.Append(" where tendangnhap= @tendangnhap ");
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("tendangnhap");
            values.Add(user.Tendangnhap);

            parameters.Add("matkhau");
            values.Add(user.Matkhau);

            parameters.Add("manhomuser");
            values.Add(user.Manhomuser);

            parameters.Add("manhanvien");
            values.Add(user.Manhanvien.Manhanvien);

            parameters.Add("email");
            values.Add(user.Email);

            parameters.Add("dienthoai");
            values.Add(user.Dienthoai);

            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sb.ToString(), parameters, values);

        }


        public bool Xoa(User user)
        {
            // string sql = "insert into user values(tendangnhap= @tendangnhap, matkhau =@matkhau, manhomuser =@manhomuser, manhanvien=@manhanvien, email =@email, dienthoai=@dienthoai)";
            StringBuilder sb = new StringBuilder();
            sb.Append("delete from user ");
            sb.Append(" where tendangnhap= @tendangnhap ");
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();
            //khoi tao tham so va gia tri
            parameters.Add("tendangnhap");
            values.Add(user.Tendangnhap);

            return dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sb.ToString(), parameters, values);
        }

        public User LayUserTheoTenDangNhapVaMK(User user)
        {
            User objReturnUser = new User();
            string sql = " select * from user where tendangnhap = @tendangnhap and matkhau = @matkhau";
            List<string> parameters = new List<string>();
            List<object> values = new List<object>();
            //khoi tao tham so va gia tri
            parameters.Add("tendangnhap");
            values.Add(user.Tendangnhap);

            parameters.Add("matkhau");
            values.Add(user.Matkhau);
            DataTable dtUserChucNang = dataAccessHelper.GetDataWithParam(sql, parameters, values);
            if (dtUserChucNang.Rows.Count > 0)
            {
                user.Tendangnhap = dtUserChucNang.Rows[0]["tendangnhap"].ToString();
                user.Matkhau = dtUserChucNang.Rows[0]["matkhau"].ToString();
                user.Manhomuser = int.Parse(dtUserChucNang.Rows[0]["manhomuser"].ToString());
                user.Email = dtUserChucNang.Rows[0]["email"] == null ? string.Empty : dtUserChucNang.Rows[0]["email"].ToString();
                user.Dienthoai = dtUserChucNang.Rows[0]["dienthoai"] == null ? string.Empty : dtUserChucNang.Rows[0]["dienthoai"].ToString();


                objReturnUser.Tendangnhap = dtUserChucNang.Rows[0]["tendangnhap"].ToString();
                objReturnUser.Matkhau = dtUserChucNang.Rows[0]["matkhau"].ToString();
                objReturnUser.Manhomuser = int.Parse(dtUserChucNang.Rows[0]["manhomuser"].ToString());
                objReturnUser.Email = dtUserChucNang.Rows[0]["email"] == null ? string.Empty : dtUserChucNang.Rows[0]["email"].ToString();
                objReturnUser.Dienthoai = dtUserChucNang.Rows[0]["dienthoai"] == null ? string.Empty : dtUserChucNang.Rows[0]["dienthoai"].ToString();
                
              
            }
            else
            {
                //nếu đăng nhập sai trả về user null
                
                return null;
            }

            //đăng nhập thành công thì lấy danh sách chức năng của user được phép sử dụng
            if (dtUserChucNang.Rows.Count > 0)
            {
                StringBuilder sbSql = new StringBuilder();
                sbSql.Append(" select us.*, cn.*,nv.* from user us ");
                sbSql.Append(" join nhomuser nus on us.manhomuser = nus.manhom  ");
                sbSql.Append(" join nhomuserchucnang nuschucnag on nus.manhom = nuschucnag.manhomuser ");
                sbSql.Append(" join chucnang cn on nuschucnag.machucnang = cn.machucnang ");
                sbSql.Append(" join nhanvien nv on nv.manhanvien = us.manhanvien ");
                sbSql.Append(" where us.tendangnhap = @tendangnhap ");

                //xóa tham số và giá trị matkhau  để dùng lại list
                parameters.RemoveAt(1);
                values.RemoveAt(1);

                DataTable dtChucNang = dataAccessHelper.GetDataWithParam(sbSql.ToString(), parameters, values);
                List<ChucNang> lsChucNang = new List<ChucNang>();
                NhanVien nhanvien = new NhanVien();
                foreach (DataRow item in dtChucNang.Rows)
                {
                    ChucNang chucnang = new ChucNang();
                    chucnang.machucnang = Convert.ToInt32(item["machucnang"].ToString());
                    chucnang.loaichucnang = item["loaichucnang"].ToString();
                    chucnang.tenchucnang = item["tenchucnang"].ToString();
                    chucnang.mota = item["mota"].ToString();
                    lsChucNang.Add(chucnang);

                    nhanvien.Manhanvien = item["manhanvien"].ToString();
                    nhanvien.Tennhanvien = item["tenhannhan"].ToString();
                   
                    
                }

                objReturnUser.Manhanvien = nhanvien;
                objReturnUser.DsChucNang = lsChucNang;

            }


            return objReturnUser;

        }
    }
}
