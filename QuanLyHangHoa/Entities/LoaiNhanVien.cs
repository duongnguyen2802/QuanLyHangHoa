using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.Entities
{
    class LoaiNhanVien
    {
        private string maloainhanvien;
        private string tenloainhanvien;
        private string tiento;
        public LoaiNhanVien()
        {

        }

     

        public string Tiento
        {
            get { return tiento; }
            set { tiento = value; }
        }
        public string Tenloainhanvien
        {
            get { return tenloainhanvien; }
            set { tenloainhanvien = value; }
        }
        public string Maloainhanvien
        {
            get { return maloainhanvien; }
            set { maloainhanvien = value; }
        }

        
    }
}
