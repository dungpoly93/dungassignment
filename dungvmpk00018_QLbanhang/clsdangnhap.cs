using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungvmpk00018_QLbanhang
{
    public class clsdangnhap
    {
         public string Tendangnhap { get; set; }
        public string HoTen { get; set; }
        public string Matkhau { get; set; }
        public string Chucvu { get; set; }
      
        public clsdangnhap()
        {

        }

        public clsdangnhap(string tendangnhap, string hoTen, string matkhau,string chucvu)
        {
            Tendangnhap = tendangnhap;
            HoTen = hoTen;
            Matkhau = matkhau;
            Chucvu = chucvu;
        }
    }
}
