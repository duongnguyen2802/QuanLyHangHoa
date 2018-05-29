using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyHangHoa.Entities
{
    class NhaCungCap
    {
        private int manhacungcap;
        private string tennhacungcap;
        private string diachi;
        private string dienthoai;
        private string email;

        public NhaCungCap()
        { 

        }

        public NhaCungCap(int manhacungcap, string tennhacungcap, string diachi, string dienthoai, string email)
        {
            this.manhacungcap = manhacungcap;
            this.tennhacungcap = tennhacungcap;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.email = email;
        }

        public int Manhacungcap
        {
            get { return manhacungcap; }
            set { manhacungcap = value; }
        }
        public string Tennhacungcap
        {
            get { return tennhacungcap; }
            set { tennhacungcap = value; }
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
