using MySql.Data.MySqlClient;
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
            database = "quanlyhanghoa";
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


        public DataTable GetData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlSelect, connection);
            mySqlDataAdapter.Fill(dt);
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
                    MySqlParameter p = new MySqlParameter(parameters[i],values[i]);
                    cmd.Parameters.Add(p);
                }
                //Execute command
               kiemtra =  cmd.ExecuteNonQuery() > 0;

                //close connection
                this.CloseConnection();
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
            }

            foreach (DataRow item in dt.Rows)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item[0].ToString());
                ma = sb.Replace(tiento, "").ToString().Trim();
                int temp = Convert.ToInt32(ma);
                if (temp > 0)
                {

                    ma = Convert.ToString(temp + 1);
                    ma = ma.PadLeft(dodaiMa - tiento.Length, '0');
                    ma = tiento + ma;
                }
            }

            return ma;



        }

        //check null

    }
}
