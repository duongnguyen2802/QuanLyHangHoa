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
    public partial class frmKhachHang : Form
    {

        DataAccessHelper dataAccessHelper = new DataAccessHelper();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO khachhang values(@MaKH,@TenKH,@DiaChi,@DienThoai,@Email)";

            List<string> parameters = new List<string>();
            List<object> values = new List<object>();

            //khoi tao tham so va gia tri
            parameters.Add("MaKH");
            values.Add(txtMaKH.Text);

            parameters.Add("TenKH");
            values.Add(txtTenKH.Text);

            parameters.Add("DiaChi");
            values.Add(txtDiaChi.Text);

            parameters.Add("DienThoai");
            values.Add(txtDienThoai.Text);

            parameters.Add("Email");
            values.Add(txtEmail.Text);

            bool kiemtra = dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sqlInsert, parameters, values);
            if (kiemtra)
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                this.LayTatCaKhachHang();

            }
            else
            {
                MessageBox.Show("Thêm khách thất bại!", "Thông báo");
            }


        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // không cho nhập mã khách hàng
            txtMaKH.Enabled = false;
            this.LayTatCaKhachHang();
        }

        private void LayTatCaKhachHang()
        {
            String sql = "select * from khachhang";
            dgvKhachHang.DataSource = dataAccessHelper.GetData(sql);
        }

        private void LamMoi()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) item.Text = String.Empty;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            this.LamMoi();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Enabled = false;
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.CurrentRow.Cells["dienthoai"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["diachi"].Value.ToString();
            txtEmail.Text = dgvKhachHang.CurrentRow.Cells["email"].Value.ToString(); 
        }


    }
}
