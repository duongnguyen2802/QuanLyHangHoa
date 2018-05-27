using QuanLyHangHoa.DataAcessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyHangHoa.DAO;

namespace QuanLyHangHoa
{
    public partial class frmKhachHang : Form
    {

        DataAccessHelper dataAccessHelper = new DataAccessHelper();
        KhacHangDAO KhacHangDAO = new KhacHangDAO();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!this.KiemTraDuLieuTextbox())
            {
                MessageBox.Show("Không để trống dữ liệu!", "Thông báo");
                return;
            }
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
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LayTatCaKhachHang();
                this.LamMoi();
                this.getMaxMaKH();

            }
            else
            {
                MessageBox.Show("Thêm khách thất bại!", "Thông báo");
            }


        }
        private void getMaxMaKH()
        {
            txtMaKH.Text = KhacHangDAO.getMaKH();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            //khong cho thay doi kich thuoc form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // không cho nhập mã khách hàng
            txtMaKH.Enabled = false;
            this.LayTatCaKhachHang();
            this.getMaxMaKH();
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
            this.getMaxMaKH();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //txtMaKH.Enabled = true;
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

        private bool KiemTraDuLieuTextbox()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (!item.Name.Equals(txtEmail.Name) && string.IsNullOrEmpty(item.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!this.KiemTraDuLieuTextbox())
            {
                MessageBox.Show("Không để trống dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlUpdate = "UPDATE khachhang set TenKH = @TenKH, DiaChi= @DiaChi, DienThoai = @DienThoai, Email = @Email WHERE MaKH = @MaKH ";
            //string sqlInsert = "INSERT INTO khachhang values(@MaKH,@TenKH,@DiaChi,@DienThoai,@Email)";

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
            bool kiemtra = dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sqlUpdate, parameters, values);
            if (kiemtra)
            {
                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LayTatCaKhachHang();
                this.LamMoi();
                this.getMaxMaKH();

            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {

                string sqlDelete = "DELETE FROM  khachhang where MaKH = @MaKH ";
                //string sqlInsert = "INSERT INTO khachhang values(@MaKH,@TenKH,@DiaChi,@DienThoai,@Email)";

                List<string> parameters = new List<string>();
                List<object> values = new List<object>();

                //khoi tao tham so va gia tri
                parameters.Add("MaKH");
                values.Add(txtMaKH.Text);

                bool kiemtra = dataAccessHelper.ThuThiCauLenhInsertOrUpdateOrDelete(sqlDelete, parameters, values);
                if (kiemtra)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LayTatCaKhachHang();
                    this.LamMoi();
                    this.getMaxMaKH();

                }
                else
                {
                    MessageBox.Show("Xóa nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //không cho nhập chữ vào số điện thoại
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("Chỉ nhập số!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
