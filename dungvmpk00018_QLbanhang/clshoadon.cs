using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungvmpk00018_QLbanhang
{
    class clshoadon
    {
        public string MaHD { get; set; }
        public DateTime NgaylapHD { get; set; }
        public int Tongtien { get; set; }
      
       

  public clshoadon()
        {

        }
  
        
        
        public clshoadon(string mahd, DateTime ngaylaphd, int tongtien)
        {
            MaHD = mahd;
           NgaylapHD=ngaylaphd;
            Tongtien=tongtien;
           
        
    }
}
    }

