using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungvmpk00018_QLbanhang
{
    class clssanpham
    {
        
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int Soluong { get; set; }
        public int Gia { get; set; }
        public string Tenloai { get; set; }






        public clssanpham(string masp, string tensp, int soluong, int gia, string tenloai)
        {
            MaSP = masp;
            TenSP = tensp;
            Soluong = soluong;
            Gia = gia;
            Tenloai = tenloai;

        }
         
    }
}
