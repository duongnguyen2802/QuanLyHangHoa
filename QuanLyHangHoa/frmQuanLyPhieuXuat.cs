using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.WinForms;
using QuanLyHangHoa.DAO;

namespace QuanLyHangHoa
{
    public partial class frmQuanLyPhieuXuat : Office2007Form
    {
        public frmQuanLyPhieuXuat()
        {
            InitializeComponent();
        }


        PhieuXuatDAO phieuXuatDAO = new PhieuXuatDAO();
        NhanVienDAO nhanVienDAO = new NhanVienDAO();
        KhacHangDAO khacHangDAO = new KhacHangDAO();
        DataTable dtPhieuXuat = null;
        DataTable dtNhanVien = null;
        DataTable dtKhachHang = null;
        private void frmQuanLyPhieuXuat_Load(object sender, EventArgs e)
        {

            dtNgayXuat.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            dtNgayXuat.CustomFormat = "dd/MM/yyyy";

            cboMaNhanVien.DisplayMember = "tenhannhan";
            cboMaNhanVien.ValueMember = "manhanvien";
            dtNhanVien = nhanVienDAO.LayTatCaNhanVien();
            cboMaNhanVien.DataSource = dtNhanVien;

            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.DataSource = khacHangDAO.LayTatCaKhachHang();
            dtKhachHang = phieuXuatDAO.LayTatCaPhieuXuat();
            dtPhieuXuat = dtKhachHang;
            dgvPhieuXuat.DataSource = dtPhieuXuat;



            AutoCompleteStringCollection sourcePhieuXuat = new AutoCompleteStringCollection();
            foreach (DataRow datarow in dtPhieuXuat.Rows)
            {
                sourcePhieuXuat.Add(datarow["maphieuxuat"].ToString());
            }
            txtMaPhieu.AutoCompleteCustomSource = sourcePhieuXuat;
            txtMaPhieu.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaPhieu.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieu.Text = dgvPhieuXuat.CurrentRow.Cells["maphieuxuat"].Value.ToString();
            dtNgayXuat.Value = Convert.ToDateTime(dgvPhieuXuat.CurrentRow.Cells["ngayxuat"].Value);

            for (int i = 0; i < dtNhanVien.Rows.Count; i++)
            {
                string manhanvien = dgvPhieuXuat.CurrentRow.Cells["manhanvien"].Value.ToString();
                if (dtNhanVien.Rows[i]["manhanvien"].Equals(manhanvien))
                {
                    cboMaNhanVien.SelectedIndex = i;
                    break;
                }
            }


            for (int i = 0; i < dtKhachHang.Rows.Count; i++)
            {
                string makh = dgvPhieuXuat.CurrentRow.Cells["MaKH"].Value.ToString();
                if (dtKhachHang.Rows[i]["MaKH"].Equals(makh))
                {
                    cboKhachHang.SelectedIndex = i;
                    break;
                }
            }


        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu cần in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmBCPhieuXuat phieuxuatkho = new frmBCPhieuXuat();
                phieuxuatkho.maphieuxuat = txtMaPhieu.Text;
                phieuxuatkho.ShowDialog();
            }
        }
    }
}
