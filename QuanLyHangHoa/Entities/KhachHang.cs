using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.Entities
{
    class KhachHang
    {
        private string maKH;
        private string tenKH;
        private string dienThoai;
        private string email;
        private string diaChi;


        public KhachHang(string maKH, string tenKH, string dienThoai, string email, string diaChi)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.dienThoai = dienThoai;
            this.email = email;
            this.diaChi = diaChi;
        }

        public KhachHang() { }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
    }
}
