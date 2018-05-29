using QuanLyHangHoa.DataAcessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class frmnhapdang : Form
    {
        public frmnhapdang()
        {
            InitializeComponent();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            //string tendangnhap =txtdangnhap.Text;
            //MessageBox.Show("xin chào "+tendangnhap,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dgvdangnhap.DataSource = dataAccessHelper.GetData(" select * from dangnhap");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string madangnhap = txtmadangnhap.Text;
            MessageBox.Show("xin chào Hòa xinh đẹp " + madangnhap, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void txtdangnhap_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnthemmoi_Click_1(object sender, EventArgs e)
        {
            txtdangnhap.Text = "abc";
        }

        private void btnabc_Click(object sender, EventArgs e)
        {
            //nhớ
            DataAccessHelper dataAccessHelper = new DataAccessHelper();
            //câu lệnh select cần thực hiện
            string sql = "select * from dangnhap";
            // gán dữ liệu cho datagridview   dgvabc.DataSource
            //thực thi câu lệnh select của sql lấy về bảng dữ liệu dataAccessHelper.GetData(sql);
            //
            dgvabc.DataSource = dataAccessHelper.GetData(sql);
            
        }

     
      
        

        

        
    }
}
