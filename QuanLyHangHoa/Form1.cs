using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyHangHoa.DataAcessLayer;

namespace QuanLyHangHoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataAccessHelper dataAccessHelper = new DataAccessHelper();
        private void Form1_Load(object sender, EventArgs e)
        {
            String sql = "select * from khachhang";
            dgvHangHoa.DataSource = dataAccessHelper.GetData(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
