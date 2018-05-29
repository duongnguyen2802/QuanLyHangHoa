using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.Entities
{
    class HangHoa
    {
        private string mamathang;
        private string tenmathang;
        private int soluong;
        private float dongia;
        private DateTime ngaysanxuat;
        private DateTime ngayhethan;
        private string tinhtrang;
        private NhomHangHoa manhomhanghoa;
        private NhaCungCap manhacungcap;

        public HangHoa()
        {
 
        }


        public string Mamathang
        {
            get { return mamathang; }
            set { mamathang = value; }
        }

        public string Tenmathang
        {
            get { return tenmathang; }
            set { tenmathang = value; }
        }
        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public float Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public DateTime Ngaysanxuat
        {
            get { return ngaysanxuat; }
            set { ngaysanxuat = value; }
        }

        public string Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        public DateTime Ngayhethan
        {
            get { return ngayhethan; }
            set { ngayhethan = value; }
        }
        internal NhomHangHoa Manhomhanghoa
        {
            get { return manhomhanghoa; }
            set { manhomhanghoa = value; }
        }
        internal NhaCungCap Manhacungcap
        {
            get { return manhacungcap; }
            set { manhacungcap = value; }
        }
    }
}
