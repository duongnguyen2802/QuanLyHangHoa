using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyHangHoa.Entities;
namespace QuanLyHangHoa
{
    public partial class frmMainDB : Office2007RibbonForm
    {
        public frmMainDB()
        {
            InitializeComponent();
        }

        private static User UserLogin;

        internal static User UserLogin1
        {
            get { return UserLogin; }
            set { UserLogin = value; }
        }
        private int landangnhap = 1;
        private void frmMainDB_Load(object sender, EventArgs e)
        {
            //frmDangNhap frm = new frmDangNhap();
            //frm.ShowDialog();       
            lblTenDangNhapHienTai.Visible = false;
            if (landangnhap < 2)
            {
                frmDangNhapDB dangnhap = new frmDangNhapDB();
                dangnhap.ShowDialog();
            }
           


            if (UserLogin1 != null)
            {
                lblTenDangNhapHienTai.Visible = true;
                lblTenDangNhapHienTai.Text = "Chúc " + UserLogin.Manhanvien.Tennhanvien + " một ngày làm việc vui vẻ";

                //đăng nhập thành công ẩn chức nắng đăng nhập
                tsbtnDangNhap.Enabled = false;

                //kiem tra phan quyen
                switch (UserLogin1.Manhomuser)
                {
                    //giam doc
                    case 1:
                        {
                            tsbtnDangKy.Enabled = true;
                            tsbtnQuanLyHangHoa.Enabled = true;
                            tsbtnKhachHang.Enabled = true;
                            tsbtnNhanVien.Enabled = true;
                            tsbtNhaCungCap.Enabled = true;
                            tsbtnNhomHangHoa.Enabled = true;
                            tsbtnNhapHang.Enabled = true;
                            tsbtnXuatHang.Enabled = true;
                            tsbtnQuanLyPhieuNhap.Enabled = true;
                            tsbtnQuanLyPhieuXuat.Enabled = true;
                            break;
                        }
                    //thu kho
                    case 2:
                        {
                            tsbtnDangKy.Enabled = false;
                            //tsbtnQuanLyHangHoa.Visible = false;
                            tsbtnKhachHang.Enabled = false;
                            tsbtnNhanVien.Enabled = false;
                            tsbtNhaCungCap.Enabled = false;
                            break;
                        }
                        //nhanvien kinh doanh
                    case 3:
                        {
                            tsbtnDangKy.Enabled = false;
                            tsbtnQuanLyHangHoa.Enabled = false;
                            tsbtnKhachHang.Enabled = false;
                            tsbtnNhanVien.Enabled = false;
                            tsbtNhaCungCap.Enabled = false;
                            tsbtnNhomHangHoa.Enabled = false;
                            tsbtnNhapHang.Enabled = false;
                            tsbtnXuatHang.Enabled = false;
                            tsbtnQuanLyPhieuNhap.Enabled = false;
                            tsbtnQuanLyPhieuXuat.Enabled = false;
                            break;
                        }
                        //giám đốc 
                    default: break;
                }
                landangnhap++;


            }




        }


        //Hàm kiểm tra nếu form đã xuất hiện,khi click vao form đó lần 2 sẽ không xuất hiện nữa
        private bool IsShow(string name)
        {
            bool ok = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }

        private void tsbtnNhanVien_Click(object sender, EventArgs e)
        {


            if (!IsShow("frmNhanVien"))
            {
                frmNhanVien NV = new frmNhanVien();
                NV.StartPosition = FormStartPosition.CenterScreen;
                NV.MdiParent = this;
                NV.Show();
            }
            else
            {
                foreach (Form frmNhanVien in this.MdiChildren)
                {
                    if (frmNhanVien.Name == "frmNhanVien")
                    {
                        frmNhanVien.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnKhachHang_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmKhachHang"))
            {
                frmKhachHang NV = new frmKhachHang();
                NV.StartPosition = FormStartPosition.CenterScreen;
                NV.MdiParent = this;
                NV.Show();
            }
            else
            {
                foreach (Form frmKhachHang in this.MdiChildren)
                {
                    if (frmKhachHang.Name == "frmKhachHang")
                    {
                        frmKhachHang.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtNhaCungCap_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmKhachHang"))
            {
                frmQuanLyNhaCungCap nhacungcap = new frmQuanLyNhaCungCap();
                nhacungcap.StartPosition = FormStartPosition.CenterScreen;
                nhacungcap.MdiParent = this;
                nhacungcap.Show();
            }
            else
            {
                foreach (Form frmQuanLyNhaCungCap in this.MdiChildren)
                {
                    if (frmQuanLyNhaCungCap.Name == "frmKhachHang")
                    {
                        frmQuanLyNhaCungCap.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnNhomHangHoa_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmNhomHangHoa"))
            {
                frmNhomHangHoa nhomhanghoa = new frmNhomHangHoa();
                nhomhanghoa.StartPosition = FormStartPosition.CenterScreen;
                nhomhanghoa.MdiParent = this;
                nhomhanghoa.Show();
            }
            else
            {
                foreach (Form frmNhomHangHoa in this.MdiChildren)
                {
                    if (frmNhomHangHoa.Name == "frmNhomHangHoa")
                    {
                        frmNhomHangHoa.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnQuanLyHangHoa_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmQuanLyHangHoa"))
            {
                frmQuanLyHangHoa hanghoa = new frmQuanLyHangHoa();
                hanghoa.StartPosition = FormStartPosition.CenterScreen;
                hanghoa.MdiParent = this;
                hanghoa.Show();
            }
            else
            {
                foreach (Form frmQuanLyHangHoa in this.MdiChildren)
                {
                    if (frmQuanLyHangHoa.Name == "frmNhomHangHoa")
                    {
                        frmQuanLyHangHoa.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnNhapHang_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmNhapHang"))
            {
                frmNhapHang nhaphang = new frmNhapHang();
                nhaphang.StartPosition = FormStartPosition.CenterScreen;
                nhaphang.MdiParent = this;
                nhaphang.Show();
            }
            else
            {
                foreach (Form frmNhapHang in this.MdiChildren)
                {
                    if (frmNhapHang.Name == "frmNhapHang")
                    {
                        frmNhapHang.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnXuatHang_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmXuatHang"))
            {
                frmXuatHang xuathang = new frmXuatHang();
                xuathang.StartPosition = FormStartPosition.CenterScreen;
                xuathang.MdiParent = this;
                xuathang.Show();
            }
            else
            {
                foreach (Form frmXuatHang in this.MdiChildren)
                {
                    if (frmXuatHang.Name == "frmXuatHang")
                    {
                        frmXuatHang.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnQuanLyPhieuNhap_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmQuanLyPhieuNhap"))
            {
                frmQuanLyPhieuNhap phieunhap = new frmQuanLyPhieuNhap();
                phieunhap.StartPosition = FormStartPosition.CenterScreen;
                phieunhap.MdiParent = this;
                phieunhap.Show();
            }
            else
            {
                foreach (Form frmQuanLyPhieuNhap in this.MdiChildren)
                {
                    if (frmQuanLyPhieuNhap.Name == "frmQuanLyPhieuNhap")
                    {
                        frmQuanLyPhieuNhap.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnQuanLyPhieuXuat_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmQuanLyPhieuXuat"))
            {
                frmQuanLyPhieuXuat phieuxuat = new frmQuanLyPhieuXuat();
                phieuxuat.StartPosition = FormStartPosition.CenterScreen;
                phieuxuat.MdiParent = this;
                phieuxuat.Show();
            }
            else
            {
                foreach (Form frmQuanLyPhieuXuat in this.MdiChildren)
                {
                    if (frmQuanLyPhieuXuat.Name == "frmQuanLyPhieuXuat")
                    {
                        frmQuanLyPhieuXuat.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnDangKy_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmDangKy"))
            {
                frmDangKy dangky = new frmDangKy();
                dangky.StartPosition = FormStartPosition.CenterScreen;
                dangky.MdiParent = this;
                dangky.Show();
            }
            else
            {
                foreach (Form frmDangKy in this.MdiChildren)
                {
                    if (frmDangKy.Name == "frmDangKy")
                    {
                        frmDangKy.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có muốn đăng xuất tài khoản?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                UserLogin = null;
                lblTenDangNhapHienTai.Visible = false;
                frmDangNhapDB dangnhap = new frmDangNhapDB();
                dangnhap.ShowDialog();
                frmMainDB_Load(sender, e);
                lblTenDangNhapHienTai.Visible = true;
            }
          
        }

        private void tsbtnSearchHangHoa_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmTimKiemHangHoa"))
            {
                frmTimKiemHangHoa frmTimKiemHangHoa = new frmTimKiemHangHoa();
                frmTimKiemHangHoa.StartPosition = FormStartPosition.CenterScreen;
                frmTimKiemHangHoa.MdiParent = this;
                frmTimKiemHangHoa.Show();
            }
            else
            {
                foreach (Form frmTimKiemHangHoa in this.MdiChildren)
                {
                    if (frmTimKiemHangHoa.Name == "frmTimKiemHangHoa")
                    {
                        frmTimKiemHangHoa.Activate();
                        break;
                    }

                }
            }
        }

        private void tsbtnSearchKhachHang_Click(object sender, EventArgs e)
        {
            if (!IsShow("frmTimKiemKhachHang"))
            {
                frmTimKiemKhachHang frmTimKiemKhachHang = new frmTimKiemKhachHang();
                frmTimKiemKhachHang.StartPosition = FormStartPosition.CenterScreen;
                frmTimKiemKhachHang.MdiParent = this;
                frmTimKiemKhachHang.Show();
            }
            else
            {
                foreach (Form frmTimKiemKhachHang in this.MdiChildren)
                {
                    if (frmTimKiemKhachHang.Name == "frmTimKiemKhachHang")
                    {
                        frmTimKiemKhachHang.Activate();
                        break;
                    }

                }
            }
        }

    }
}
