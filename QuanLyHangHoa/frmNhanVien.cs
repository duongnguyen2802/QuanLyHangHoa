using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyHangHoa.Entities;
using QuanLyHangHoa.DAO;
using QuanLyHangHoa.DataAcessLayer;
namespace QuanLyHangHoa
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private string maloainhanvien = string.Empty;
        private DataTable dtLoaiNhanVien = null;
        LoaiNhanVienDAO loaiNhanVienDAO = new LoaiNhanVienDAO();
        DataAccessHelper dataAccessHelper = new DataAccessHelper();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        private bool isCellClick = false;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dtLoaiNhanVien = loaiNhanVienDAO.LayLoaiNhanVien();
            cboLoaiNhanVien.DisplayMember = "tenloainhanvien";
            cboLoaiNhanVien.ValueMember = "tiento";
            cboLoaiNhanVien.DataSource = dtLoaiNhanVien;

            dgvNhanVien.DataSource = nhanVienDAO.LayTatCaNhanVien();
        }

        private void cboLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lay ma loai nhan vien 
            maloainhanvien = dtLoaiNhanVien.Rows[cboLoaiNhanVien.SelectedIndex]["maloainhanvien"].ToString();

            //khi cell click vào datagridview không tăng mã tự động
            if (!this.isCellClick)
            {
                SinhMaNVTuDong();
            }
            //sau khi thực hiện cell click gán trở lại biến
            this.isCellClick = false;
        }

        private void SinhMaNVTuDong()
        {
            // sinh ma nhan vien tu dong theo nhom 
            string sql = "select manhanvien from nhanvien where manhanvien like '" + cboLoaiNhanVien.SelectedValue.ToString() + "%'";
            txtMaNhanVien.Text = dataAccessHelper.getMaKH(sql, cboLoaiNhanVien.SelectedValue.ToString(), 8);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra dữ liệu nhập vào textbox
            if (!this.KiemTraDuLieu()) return;

            NhanVien nhanvien = new NhanVien();
            LoaiNhanVien loainhanvien = new LoaiNhanVien();
            loainhanvien.Maloainhanvien = maloainhanvien;
            nhanvien.Manhanvien = txtMaNhanVien.Text;
            nhanvien.Tennhanvien = txtTenNhanVien.Text;
            nhanvien.Dienthoai = txtDienThoai.Text;
            nhanvien.Diachi = txtDiaChi.Text;
            nhanvien.Email = txtEmail.Text;
            nhanvien.MaLoaiNhanvien = loainhanvien;

            bool kiemtra = nhanVienDAO.Them(nhanvien);
            string chuoithongbao = "Thêm dữ liệu thất bại!";
            if (kiemtra)
            {
                chuoithongbao = "Thêm dữ liệu thành công!";
                this.LamMoi();
            }
            MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvNhanVien.DataSource = nhanVienDAO.LayTatCaNhanVien();
        }

        private void LamMoi()
        {
            //khởi tạo dữ liệu và xóa dữ liệu trong textbox
            foreach (Control item in this.Controls)
            {
                if (item is TextBox) item.Text = string.Empty;
            }
            dtLoaiNhanVien = loaiNhanVienDAO.LayLoaiNhanVien();
            cboLoaiNhanVien.DisplayMember = "tenloainhanvien";
            cboLoaiNhanVien.ValueMember = "tiento";

            this.SinhMaNVTuDong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //kiểm tra dữ liêu nhập vào
            if (!this.KiemTraDuLieu()) return;

            NhanVien nhanvien = new NhanVien();
            LoaiNhanVien loainhanvien = new LoaiNhanVien();
            loainhanvien.Maloainhanvien = maloainhanvien;
            nhanvien.Manhanvien = txtMaNhanVien.Text;
            nhanvien.Tennhanvien = txtTenNhanVien.Text;
            nhanvien.Dienthoai = txtDienThoai.Text;
            nhanvien.Diachi = txtDiaChi.Text;
            nhanvien.Email = txtEmail.Text;
            nhanvien.MaLoaiNhanvien = loainhanvien;

            bool kiemtra = nhanVienDAO.Sua(nhanvien);
            string chuoithongbao = "Cập nhật dữ liệu thất bại!";
            if (kiemtra)
            {
                chuoithongbao = "Cập nhật dữ liệu thành công!";
                this.LamMoi();
            }
            MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvNhanVien.DataSource = nhanVienDAO.LayTatCaNhanVien();


        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.LamMoi();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.isCellClick = true;
            txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells["manhanvien"].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells["tenhannhan"].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["diahchi"].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells["email"].Value.ToString();
            txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells["dienthoai"].Value.ToString();

            string maloainv = dgvNhanVien.CurrentRow.Cells["loainhanvien"].Value.ToString();

            for (int i = 0; i < dtLoaiNhanVien.Rows.Count; i++)
            {
                if (dtLoaiNhanVien.Rows[i]["maloainhanvien"].ToString().Equals(maloainv))
                {
                    cboLoaiNhanVien.SelectedIndex = i;
                    break;
                }
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn Nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacnhan = MessageBox.Show("Bạn có muốn xóa " + txtTenNhanVien.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.Yes)
            {
                NhanVien nhanvien = new NhanVien();
                //gán dữ liệu vào đối tượng
                //thêm nhóm hàng hóa vào db
                nhanvien.Manhanvien = txtMaNhanVien.Text;
                bool kiemtra = nhanVienDAO.Xoa(nhanvien);
                string chuoithongbao = "Xóa dữ liệu thất bại";
                if (kiemtra)
                {
                    chuoithongbao = "Xóa dữ liệu thành công!";
                    this.LamMoi();
                }
                MessageBox.Show(chuoithongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Hiển thị toàn bộ nhân viên lên datagridview
                dgvNhanVien.DataSource = nhanVienDAO.LayTatCaNhanVien();

            }
        }

        private bool KiemTraDuLieu()
        {
            bool kiemtra = true;
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Tên nhân viên không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhân viên hàng hóa
                txtTenNhanVien.Focus();

              return false;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhân viên hàng hóa
                txtDiaChi.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhân viên hàng hóa
                txtDienThoai.Focus();

                return false;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email không để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //đưa con trỏ về textbox tên nhân viên hàng hóa
                txtEmail.Focus();

                return false;
            }

            return kiemtra;
            

        }
    }
}
