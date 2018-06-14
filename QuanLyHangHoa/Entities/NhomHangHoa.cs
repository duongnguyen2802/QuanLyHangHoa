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
        private string code;

        
        public NhomHangHoa()
        {
 
        }

        public NhomHangHoa(int manhomhanghoa, string tennhomhanghoa, string code)
        {
            this.manhomhanghoa = manhomhanghoa;
            this.tennhomhanghoa = tennhomhanghoa;
            this.code = code;
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
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

    }
}
