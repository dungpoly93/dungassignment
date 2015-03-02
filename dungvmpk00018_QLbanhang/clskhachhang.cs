using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungvmpk00018_QLbanhang
{
    class clskhachhang
    {
         public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
       

  public clskhachhang()
        {

        }
  
        
        
        public clskhachhang(string makh, string tenkh, string diachi, string sdt)
        {
            MaKH = makh;
            TenKH = tenkh;
            Diachi = diachi;
            SDT = sdt;
           
        
    }
}
}