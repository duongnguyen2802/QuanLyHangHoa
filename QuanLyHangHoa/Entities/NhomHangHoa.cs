using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.Entities
{
    class NhomHangHoa
    {
        private int manhomhanghoa;
        private string tennhomhanghoa;
        public NhomHangHoa()
        {
 
        }

        public NhomHangHoa(int manhomhanghoa, string tennhomhanghoa)
        {
            this.manhomhanghoa = manhomhanghoa;
            this.tennhomhanghoa = tennhomhanghoa;
        }

        public int Manhomhanghoa
        {
            get { return manhomhanghoa; }
            set { manhomhanghoa = value; }
        }


        public string Tennhomhanghoa
        {
            get { return tennhomhanghoa; }
            set { tennhomhanghoa = value; }
        }

    }
}
