using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using QuanLyHangHoa.DAO;
using QuanLyHangHoa.Entities;
using System.Windows.Forms;
using System.Collections.Specialized;



namespace QuanLyHangHoa
{
    public partial class frmXuatHang : Form
    {

        public frmXuatHang()
        {
            InitializeComponent();
        }
        HangHoaDAO hangHoaDAO = new HangHoaDAO();
        NhomHangHoaDAO nhomHangHoaDAO = new NhomHangHoaDAO();
        NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
        LoaiNhanVienDAO loaiNhanVienDAO = new LoaiNhanVienDAO();
        //PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        PhieuXuatDAO phieuXuatDAO = new PhieuXuatDAO();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        KhacHangDAO khacHangDAO = new KhacHangDAO();

        private DataTable dtHanghoa;
        private DataTable dtNhomhanghoa;
        private DataTable dtNhaCung;


        private DataTable dtXuat;
        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtHanghoa.Rows.Count; i++)
            {
                if (dtHanghoa.Rows[i]["mamathang"].ToString().Equals(txtMaHang.Text))
                {
                    for (int j = 0; j < dtNhomhanghoa.Rows.Count; j++)
                    {
                        if (dtHanghoa.Rows[i]["manhomhanghoa"].ToString().Equals(dtNhomhanghoa.Rows[j]["manhomhanghoa"].ToString()))
                        {
                            cboLoaiHang.SelectedIndex = j;
                        }
                    }

                    for (int j = 0; j < dtNhomhanghoa.Rows.Count; j++)
                    {
                        if (dtHanghoa.Rows[i]["manhacungcap"].ToString().Equals(dtNhaCung.Rows[j]["manhacungcap"].ToString()))
                        {
                            cboNhaCungCap.SelectedIndex = j;
                        }
                    }
                }


            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            if (frmMainDB.UserLogin1 != null)
            {
                txtNhanVien.Text = frmMainDB.UserLogin1.Manhanvien.Tennhanvien;

            }
            
            //formate datetime picker
            dtNgayNhap.Format = DateTimePickerFormat.Custom;
            dtNgayNhap.CustomFormat = "dd-MM-yyyy";

            txtMaPhieuXuat.Text = phieuXuatDAO.SinhMaPhieuXuat();

            //create datatable hang nhap
            dtXuat = new DataTable();
            dtXuat.Columns.Add("mamathang", typeof(String));
            dtXuat.Columns.Add("tenmathang", typeof(String));
            dtXuat.Columns.Add("soluong", typeof(String));
            dtXuat.Columns.Add("dongia", typeof(String));
            dtXuat.Columns.Add("thanhtien", typeof(String));
            dgvHangNhap.DataSource = dtXuat;

            dtHanghoa = hangHoaDAO.LayDanhSachMatHang();
            dtNhomhanghoa = nhomHangHoaDAO.LayTatCaNhomHangHoa();
            dtNhaCung = nhaCungCapDAO.LayDanhSachNhaCC();

            cboLoaiHang.DisplayMember = "tennhomhanghoa";
            cboLoaiHang.ValueMember = "manhomhanghoa";
            cboLoaiHang.DataSource = dtNhomhanghoa;


            cboNhaCungCap.DisplayMember = "tennhacungcap";
            cboNhaCungCap.ValueMember = "manhacungcap";
            cboNhaCungCap.DataSource = dtNhaCung;

            //lấy danh sách khách hàng
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.DataSource = khacHangDAO.LayTatCaKhachHang();



            AutoCompleteStringCollection sourceMaHang = new AutoCompleteStringCollection();
            foreach (DataRow datarow in dtHanghoa.Rows)
            {
                sourceMaHang.Add(datarow["mamathang"].ToString());
            }
            txtMaHang.AutoCompleteCustomSource = sourceMaHang;
            txtMaHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaHang.AutoCompleteSource = AutoCompleteSource.CustomSource;


            AutoCompleteStringCollection sourceTenHang = new AutoCompleteStringCollection();
            foreach (DataRow datarow in dtHanghoa.Rows)
            {
                sourceTenHang.Add(datarow["tenmathang"].ToString());
            }
            txtTenHang.AutoCompleteCustomSource = sourceTenHang;
            txtTenHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenHang.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            foreach (DataRow datarow in dtHanghoa.Rows)
            {
                if (datarow["tenmathang"].ToString().Equals(txtTenHang.Text))
                {
                    txtMaHang.Text = datarow["mamathang"].ToString();
                    txtGia.Text = datarow["dongia"].ToString();
                    break;
                }
                else
                {
                    txtMaHang.Text = string.Empty;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHang.Text))
            {
                MessageBox.Show("Mã hàng không đẻ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtTenHang.Text))
            {
                MessageBox.Show("Tên mặt hàng không đẻ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Số lượng không đẻ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Giá không đẻ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool tontai = false;
            foreach (DataRow item in dtXuat.Rows)
            {
                if (item["mamathang"].Equals(txtMaHang.Text))
                {
                    tontai = true; break;
                }
            }
            if (tontai)
            {
                MessageBox.Show("Mặt hàng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            //kiểm tra số lượng hàng tồn kho
            DataTable dtHangTemp = hangHoaDAO.LayHangHoaTheoMa(txtMaHang.Text);
            if (dtHangTemp != null && dtHanghoa.Rows.Count > 0)
            {
                int soluong = Convert.ToInt32(dtHangTemp.Rows[0]["soluong"]);
                if (soluong < Convert.ToInt32(txtSoLuong.Text))
                {
                    MessageBox.Show("Số lượng tồn kho không đủ. Hiện tại còn !" + soluong + "  sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }


            DataRow dr = dtXuat.NewRow();
            dr["mamathang"] = txtMaHang.Text;
            dr["tenmathang"] = txtTenHang.Text;
            dr["soluong"] = txtSoLuong.Text;
            dr["dongia"] = txtGia.Text;
            dr["thanhtien"] = Convert.ToInt32(txtSoLuong.Text) * Convert.ToSingle(txtGia.Text);
            dtXuat.Rows.Add(dr);

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaPhieuXuat.Text = phieuXuatDAO.SinhMaPhieuXuat();
            foreach (Control item in this.grboxMatHang.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }

            dtHanghoa = hangHoaDAO.LayDanhSachMatHang();
            dtNhomhanghoa = nhomHangHoaDAO.LayTatCaNhomHangHoa();
            dtNhaCung = nhaCungCapDAO.LayDanhSachNhaCC();

            cboLoaiHang.DisplayMember = "tennhomhanghoa";
            cboLoaiHang.ValueMember = "manhomhanghoa";
            cboLoaiHang.DataSource = dtNhomhanghoa;


            cboNhaCungCap.DisplayMember = "tennhacungcap";
            cboNhaCungCap.ValueMember = "manhacungcap";
            cboNhaCungCap.DataSource = dtNhaCung;
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            if (dtXuat == null || dtXuat.Rows.Count == 0)
            {
                MessageBox.Show("Vui tạo danh sách mặt hàng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
          


            PhieuXuat phieuxuat = new PhieuXuat();
            phieuxuat.maphieuxuat = txtMaPhieuXuat.Text;
            phieuxuat.ngayxuat = dtNgayNhap.Value;
            phieuxuat.manhanvien = frmMainDB.UserLogin1.Manhanvien.Manhanvien;
            phieuxuat.ghichu = txtGhiChu.Text;
            phieuxuat.MaKH = cboKhachHang.SelectedValue.ToString();


           bool kt =  phieuXuatDAO.ThemPhieuXuatTransaction(phieuxuat, dtXuat);
           if (kt)
           {
               MessageBox.Show("Xuất hàng thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
               this.LamMoi();
               if (dtXuat != null)
               {
                   dtXuat.Clear();
               }
           }
           else
           {
               MessageBox.Show("Xuất hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

        }

        private int currentrowindex = -1;
        private void dgvHangNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            currentrowindex = e.RowIndex;
            txtMaHang.Text = dgvHangNhap.CurrentRow.Cells["mamathang"].Value.ToString();
            txtTenHang.Text = dgvHangNhap.CurrentRow.Cells["tenmathang"].Value.ToString();
            txtSoLuong.Text = dgvHangNhap.CurrentRow.Cells["soluong"].Value.ToString();
            txtGia.Text = dgvHangNhap.CurrentRow.Cells["dongia"].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(currentrowindex != -1)
            {
               // dtHangNhap.Rows[currentrowindex]["mamathang"] = txtMaHang.Text;
                dtXuat.Rows[currentrowindex]["tenmathang"] = txtTenHang.Text;
                dtXuat.Rows[currentrowindex]["soluong"] = txtSoLuong.Text;
                dtXuat.Rows[currentrowindex]["dongia"] = txtGia.Text;
                dtXuat.Rows[currentrowindex]["thanhtien"] = int.Parse(txtSoLuong.Text) * float.Parse(txtGia.Text);
                this.LamMoi();
            }
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentrowindex != -1)
            {
                DialogResult confirm = MessageBox.Show("Bạn có muốn xóa mã hàng  "+ txtMaHang.Text,"Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    dtXuat.Rows.RemoveAt(currentrowindex);
                    this.LamMoi();
                }
            }
        }




    }
}
