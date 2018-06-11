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
    public partial class frmQuanLyPhieuNhap : Form
    {
        public frmQuanLyPhieuNhap()
        {
            InitializeComponent();
        }
        PhieuNhapDAO phieuNhapDAO = new PhieuNhapDAO();
        NhanVienDAO nhanvienDAO = new NhanVienDAO();
        DataTable dtPhieuNhap = null;
        private void frmQuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            //formate datetime picker
            datePickerNgayLap.Format = DateTimePickerFormat.Custom;
            datePickerNgayLap.CustomFormat = "dd-MM-yyyy";
            dtPhieuNhap = phieuNhapDAO.LayDanhSachPhieuNhap();
            dgvPhieuNhap.DataSource = dtPhieuNhap;
            cboNguoiLap.DisplayMember = "tenhannhan";
            cboNguoiLap.ValueMember = "manhanvien";
            cboNguoiLap.DataSource = nhanvienDAO.LayTatCaNhanVien();


            AutoCompleteStringCollection sourcePhieuNhap = new AutoCompleteStringCollection();
            foreach (DataRow datarow in dtPhieuNhap.Rows)
            {
                sourcePhieuNhap.Add(datarow["maphieunhap"].ToString());
            }
            txtMaPhieu.AutoCompleteCustomSource = sourcePhieuNhap;
            txtMaPhieu.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaPhieu.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieu.Text = dgvPhieuNhap.CurrentRow.Cells["maphieunhap"].Value.ToString();
            datePickerNgayLap.Value = Convert.ToDateTime(dgvPhieuNhap.CurrentRow.Cells["ngaynhap"].Value);
            DataTable dtnhanvien = phieuNhapDAO.LayDanhSachPhieuNhap();
            for (int i = 0; i < dtnhanvien.Rows.Count; i++)
            {
                if (dtnhanvien.Rows[i]["manhanvien"].ToString().Equals(dgvPhieuNhap.CurrentRow.Cells["manhanvien"].Value.ToString()))
                {
                    cboNguoiLap.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {

            }
            else
            {
                frmBCPhieuNhapKho phieunhapkho = new frmBCPhieuNhapKho();
                phieunhapkho.maphieunhap = txtMaPhieu.Text;
                phieunhapkho.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
