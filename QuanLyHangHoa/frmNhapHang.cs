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
    public partial class frmNhapHang : Form
    {

        public frmNhapHang()
        {
            InitializeComponent();
        }
        HangHoaDAO hangHoaDAO = new HangHoaDAO();
        NhomHangHoaDAO nhomHangHoaDAO = new NhomHangHoaDAO();
        NhaCungCapDAO nhaCungCapDAO = new NhaCungCapDAO();
        LoaiNhanVienDAO loaiNhanVienDAO = new LoaiNhanVienDAO();
        PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();

        private DataTable dtHanghoa;
        private DataTable dtNhomhanghoa;
        private DataTable dtNhaCung;


        private DataTable dtHangNhap;
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
            if(frmMain.UserLogin1 != null)
            {
                txtNhanVien.Text = frmMain.UserLogin1.Manhanvien.Tennhanvien;

            }
            
            //formate datetime picker
            dtNgayNhap.Format = DateTimePickerFormat.Custom;
            dtNgayNhap.CustomFormat = "dd-MM-yyyy";


            txtPhieuNhap.Text = phieuNhapDAO.SinhMaPhieuNhap();

            //create datatable hang nhap
            dtHangNhap = new DataTable();
            dtHangNhap.Columns.Add("mamathang", typeof(String));
            dtHangNhap.Columns.Add("tenmathang", typeof(String));
            dtHangNhap.Columns.Add("soluong", typeof(String));
            dtHangNhap.Columns.Add("dongia", typeof(String));
            dtHangNhap.Columns.Add("thanhtien", typeof(String));
            dgvHangNhap.DataSource = dtHangNhap;

            dtHanghoa = hangHoaDAO.LayDanhSachMatHang();
            dtNhomhanghoa = nhomHangHoaDAO.LayTatCaNhomHangHoa();
            dtNhaCung = nhaCungCapDAO.LayDanhSachNhaCC();

            cboLoaiHang.DisplayMember = "tennhomhanghoa";
            cboLoaiHang.ValueMember = "manhomhanghoa";
            cboLoaiHang.DataSource = dtNhomhanghoa;


            cboNhaCungCap.DisplayMember = "tennhacungcap";
            cboNhaCungCap.ValueMember = "manhacungcap";
            cboNhaCungCap.DataSource = dtNhaCung;


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
            foreach (DataRow item in dtHangNhap.Rows)
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
            DataRow dr = dtHangNhap.NewRow();
            dr["mamathang"] = txtMaHang.Text;
            dr["tenmathang"] = txtTenHang.Text;
            dr["soluong"] = txtSoLuong.Text;
            dr["dongia"] = txtGia.Text;
            dr["thanhtien"] = Convert.ToInt32(txtSoLuong.Text) * Convert.ToSingle(txtGia.Text);
            dtHangNhap.Rows.Add(dr);

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtPhieuNhap.Text = phieuNhapDAO.SinhMaPhieuNhap();
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
            PhieuNhap phieunhap = new PhieuNhap();
            phieunhap.maphieunhap = txtPhieuNhap.Text;
            phieunhap.ngaynhap = dtNgayNhap.Value;
            phieunhap.manhanvien = frmMain.UserLogin1.Manhanvien.Manhanvien;
            phieunhap.ghichu = txtGhiChu.Text;

           bool kt =  phieuNhapDAO.ThemPhieuNhapTransaction(phieunhap, dtHangNhap);
           if (kt)
           {
               this.LamMoi();
               if (dtHangNhap != null)
               {
                   dtHangNhap.Clear();
               }
           }

        }




    }
}
