using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.Entities
{
    class User
    {
        private string tendangnhap;
        private string matkhau;
        private int manhomuser;
        private NhanVien manhanvien;
        private string email;
        private string dienthoai;
        List<ChucNang> dsChucNang;

       
        public User()
        {
           
        }


        //kiem tra quyen chuc namg
        public bool KiemTraQuyen(string tenchucnang)
        {
            foreach (ChucNang item in dsChucNang)
            {
                if (item.tenchucnang.Equals(tenchucnang))
                {
                    return true;
                }
            }
            return false;
        }


        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public int Manhomuser
        {
            get { return manhomuser; }
            set { manhomuser = value; }
        }

        internal NhanVien Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }

        internal List<ChucNang> DsChucNang
        {
            get { return dsChucNang; }
            set { dsChucNang = value; }
        }

    }
}
