using MySql.Data.MySqlClient;
using QuanLyHangHoa.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.DataAcessLayer
{
    class DataAccessHelper
    {
        private MySqlConnection connection;
        private string server; //địa chỉ server
        private string database; // tên db
        private string uid; // username
        private string password; // 
        private string connectionString; // chuổi kết nối tới db
        public DataAccessHelper()
        {
            server = "localhost";
            database = "quanlyhanghoa2";
            uid = "root";
            password = "123456";
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// open connection to database
        /// </summary>
        /// <returns>true: kết nối thành công db/ false: kết nối ngược lại</returns>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                //switch (ex.Number)
                //{
                //    case 0:
                //        MessageBox.Show("Cannot connect to server.  Contact administrator");
                //        break;

                //    case 1045:
                //        MessageBox.Show("Invalid username/password, please try again");
                //        break;
                //}
                return false;
            }
        }


        /// <summary>
        /// connect to database
        /// </summary>
        /// <returns>true/false</returns>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Thực hiện câu lệnh select
        /// </summary>
        /// <param name="sqlSelect">câu lệnh sql select</param>
        /// <returns></returns>
        public DataTable GetData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlSelect, connection);
            mySqlDataAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetDataWithParam(string sqlSelect, List<string> parameters, List<object> values)
        {
            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlSelect, connection);
                for (int i = 0; i < parameters.Count; i++)
                {
                    MySqlParameter p = new MySqlParameter(parameters[i], values[i]);
                    cmd.Parameters.Add(p);
                }
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                mySqlDataAdapter.Fill(dt);
                //close connection
                this.CloseConnection();
            }
            return dt;
        }




        public bool ThuThiCauLenhInsertOrUpdateOrDelete(string sql, List<string> parameters, List<object> values)
        {
            bool kiemtra = false;
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                for (int i = 0; i < parameters.Count; i++)
                {
                    MySqlParameter p = new MySqlParameter(parameters[i], values[i]);
                    cmd.Parameters.Add(p);
                }
                //Execute command
                kiemtra = cmd.ExecuteNonQuery() > 0;

                //close connection
                this.CloseConnection();
            }

            return kiemtra;
        }


        public bool ThuThiCauLenhInsertOrUpdateOrDeleteTransaction(string sql, List<string> parameters, List<object> values)
        {
            bool kiemtra = false;
            if (this.OpenConnection() == true)
            {
                MySqlTransaction mySqlTransaction = connection.BeginTransaction();
                try
                {

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        MySqlParameter p = new MySqlParameter(parameters[i], values[i]);
                        cmd.Parameters.Add(p);
                    }
                    //Execute command
                    kiemtra = cmd.ExecuteNonQuery() > 0;
                    mySqlTransaction.Commit();
                }
                catch (Exception)
                {
                    mySqlTransaction.Rollback();
                }
                finally
                {
                    //close connection
                    this.CloseConnection();
                }
            }

            return kiemtra;
        }

        public bool ThemPhieuNhap(PhieuNhap phieunhap, DataTable dtDSMatHang)
        {
            bool kiemtra = false;
            StringBuilder sqlChitiet = new StringBuilder();
            sqlChitiet.Append(" insert into chitietphieunhap(maphieunhap, soluong, dongia, mamathang) ");
            sqlChitiet.Append("   values(@maphieunhap, @soluong, @dongia, @mamathang) ");
            List<string> parametersChiTiet = new List<string>();
            parametersChiTiet.Add("maphieunhap");
            parametersChiTiet.Add("soluong");
            parametersChiTiet.Add("dongia");
            parametersChiTiet.Add("mamathang");


            StringBuilder sqlPhieuNhap = new StringBuilder();
            sqlPhieuNhap.Append(" insert into phieunhap (maphieunhap, ngaynhap, manhanvien, ghichu) ");
            sqlPhieuNhap.Append(" values(@maphieunhap, @ngaynhap, @manhanvien, @ghichu) ");
            List<string> parametersPhieuNhap = new List<string>();
            List<object> valuesPhieuNhap = new List<object>();

            parametersPhieuNhap.Add("maphieunhap");
            valuesPhieuNhap.Add(phieunhap.maphieunhap);

            parametersPhieuNhap.Add("ngaynhap");
            valuesPhieuNhap.Add(phieunhap.ngaynhap);

            parametersPhieuNhap.Add("manhanvien");
            valuesPhieuNhap.Add(phieunhap.manhanvien);


            parametersPhieuNhap.Add("ghichu");
            valuesPhieuNhap.Add(phieunhap.ghichu);

            if (this.OpenConnection() == true)
            {
                MySqlTransaction mySqlTransaction = connection.BeginTransaction();
                try
                {

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmdPhieuNhap = new MySqlCommand(sqlPhieuNhap.ToString(), connection);
                    for (int i = 0; i < parametersPhieuNhap.Count; i++)
                    {
                        MySqlParameter p = new MySqlParameter(parametersPhieuNhap[i], valuesPhieuNhap[i]);
                        cmdPhieuNhap.Parameters.Add(p);
                    }
                    //Execute command
                    kiemtra = cmdPhieuNhap.ExecuteNonQuery() > 0;
                    if (kiemtra == false)
                    {
                        mySqlTransaction.Rollback();
                        return false;
                    }


                    foreach (DataRow dr in dtDSMatHang.Rows)
                    {              
                        List<object> valuesChiTiet= new List<object>();
                        valuesChiTiet.Add(phieunhap.maphieunhap);
                        valuesChiTiet.Add(dr["soluong"].ToString());
                        valuesChiTiet.Add(dr["dongia"].ToString());
                        valuesChiTiet.Add(dr["mamathang"].ToString());

                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmdChiTiet = new MySqlCommand(sqlChitiet.ToString(), connection);
                        for (int i = 0; i < parametersChiTiet.Count; i++)
                        {
                            MySqlParameter p = new MySqlParameter(parametersChiTiet[i], valuesChiTiet[i]);
                            cmdChiTiet.Parameters.Add(p);
                        }
                        //Execute command
                        kiemtra = cmdChiTiet.ExecuteNonQuery() > 0;
                        if (kiemtra == false)
                        {
                            mySqlTransaction.Rollback();
                            return false;
                        }
                        //update sô lượng tồn kho trong bảng hàng hoa
                        //create command and assign the query and connection from the constructor
                        string sqlTonKho = "update hanghoa set soluong = soluong + " + dr["soluong"].ToString() + " where mamathang = '" + dr["mamathang"].ToString() + "'";
                        MySqlCommand cmdUpdateTonKho = new MySqlCommand(sqlTonKho, connection);
                        kiemtra = cmdUpdateTonKho.ExecuteNonQuery() > 0;
                        if (kiemtra == false)
                        {
                            mySqlTransaction.Rollback();
                            return false;
                        }

                    }

                    mySqlTransaction.Commit();
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                    mySqlTransaction.Rollback();
                }
                finally
                {
                    //close connection
                    this.CloseConnection();
                }
            }

            return kiemtra;
        }

        public bool ThemPhieuXuat(PhieuXuat phieuxuat, DataTable dtDSMatHang)
        {
            bool kiemtra = false;
            StringBuilder sqlChitiet = new StringBuilder();
            sqlChitiet.Append(" insert into chitietphieuxuat(maphieuxuat, mamathang, soluong, dongia) ");
            sqlChitiet.Append("  values(@maphieuxuat, @mamathang, @soluong, @dongia) ");
            List<string> parametersChiTiet = new List<string>();
            parametersChiTiet.Add("maphieuxuat");
            parametersChiTiet.Add("soluong");
            parametersChiTiet.Add("dongia");
            parametersChiTiet.Add("mamathang");


            StringBuilder sqlPhieuNhap = new StringBuilder();
            sqlPhieuNhap.Append(" insert into phieuxuat(maphieuxuat, ngayxuat, manhanvien, MaKH, ghichu) ");
            sqlPhieuNhap.Append(" values(@maphieuxuat, @ngayxuat, @manhanvien, @MaKH, @ghichu) ");
            List<string> parametersPhieuXuat = new List<string>();
            List<object> valuesPhieuXuat = new List<object>();

            parametersPhieuXuat.Add("maphieuxuat");
            valuesPhieuXuat.Add(phieuxuat.maphieuxuat);

            parametersPhieuXuat.Add("ngayxuat");
            valuesPhieuXuat.Add(phieuxuat.ngayxuat);

            parametersPhieuXuat.Add("manhanvien");
            valuesPhieuXuat.Add(phieuxuat.manhanvien);
            parametersPhieuXuat.Add("MaKH");
            valuesPhieuXuat.Add(phieuxuat.MaKH);

            parametersPhieuXuat.Add("ghichu");
            valuesPhieuXuat.Add(phieuxuat.ghichu);


            if (this.OpenConnection() == true)
            {
                MySqlTransaction mySqlTransaction = connection.BeginTransaction();
                try
                {

                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmdPhieuNhap = new MySqlCommand(sqlPhieuNhap.ToString(), connection);
                    for (int i = 0; i < parametersPhieuXuat.Count; i++)
                    {
                        MySqlParameter p = new MySqlParameter(parametersPhieuXuat[i], valuesPhieuXuat[i]);
                        cmdPhieuNhap.Parameters.Add(p);
                    }
                    //Execute command
                    kiemtra = cmdPhieuNhap.ExecuteNonQuery() > 0;
                    if (kiemtra == false)
                    {
                        mySqlTransaction.Rollback();
                        return false;
                    }


                    foreach (DataRow dr in dtDSMatHang.Rows)
                    {
                        List<object> valuesChiTiet = new List<object>();
                        valuesChiTiet.Add(phieuxuat.maphieuxuat);
                        valuesChiTiet.Add(dr["soluong"].ToString());
                        valuesChiTiet.Add(dr["dongia"].ToString());
                        valuesChiTiet.Add(dr["mamathang"].ToString());

                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmdChiTiet = new MySqlCommand(sqlChitiet.ToString(), connection);
                        for (int i = 0; i < parametersChiTiet.Count; i++)
                        {
                            MySqlParameter p = new MySqlParameter(parametersChiTiet[i], valuesChiTiet[i]);
                            cmdChiTiet.Parameters.Add(p);
                        }
                        //Execute command
                        kiemtra = cmdChiTiet.ExecuteNonQuery() > 0;
                        if (kiemtra == false)
                        {
                            mySqlTransaction.Rollback();
                            return false;
                        }
                        //update sô lượng tồn kho trong bảng hàng hoa
                        //create command and assign the query and connection from the constructor
                        string sqlTonKho = "update hanghoa set soluong = soluong - " + dr["soluong"].ToString() + " where mamathang = '" + dr["mamathang"].ToString() + "'";
                        MySqlCommand cmdUpdateTonKho = new MySqlCommand(sqlTonKho, connection);
                        kiemtra = cmdUpdateTonKho.ExecuteNonQuery() > 0;
                        if (kiemtra == false)
                        {
                            mySqlTransaction.Rollback();
                            return false;
                        }

                    }

                    mySqlTransaction.Commit();
                }
                catch (Exception ex)
                {
                    string a = ex.ToString();
                    mySqlTransaction.Rollback();
                }
                finally
                {
                    //close connection
                    this.CloseConnection();
                }
            }

            return kiemtra;
        }


        public void Insert()
        {
            string query = "insert into sinhvien.monhoc values('');";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlParameter p = new MySqlParameter();
                //Execute command
                cmd.ExecuteNonQuery();
                //close connection
                this.CloseConnection();
            }
        }


        public string getMaKH(string sql, string tiento, int dodaiMa)
        {
            string ma = string.Empty;
            DataTable dt = this.GetData(sql);
            if (dt == null || dt.Rows.Count == 0)
            {
                ma = ma.PadLeft(dodaiMa - tiento.Length - 1, '0');
                ma = tiento + ma + "1";
                return ma;
            }
            int max = 0;
            foreach (DataRow item in dt.Rows)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item[0].ToString());
                ma = sb.Replace(tiento, "").ToString().Trim();
                int temp = Convert.ToInt32(ma);
                if (temp > max) max = temp;
                if (max > 0)
                {

                    ma = Convert.ToString(max + 1);
                    ma = ma.PadLeft(dodaiMa - tiento.Length, '0');
                    ma = tiento + ma;
                }
            }

            return ma;



        }

        //check null

    }
}
