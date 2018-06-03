using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.Entities
{
    class NhanVien
    {
        private string manhanvien;
        private string tennhanvien;
        private LoaiNhanVien maLoaiNhanvien;
        private string diachi;
        private string dienthoai;
        private string email;
        public NhanVien() { }
        public string Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }
        public string Tennhanvien
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }

        internal LoaiNhanVien MaLoaiNhanvien
        {
            get { return maLoaiNhanvien; }
            set { maLoaiNhanvien = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
