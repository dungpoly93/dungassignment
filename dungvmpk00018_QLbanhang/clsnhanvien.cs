using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungvmpk00018_QLbanhang
{
    class clsnhanvien
    { 
        public string Manv { get; set; }
        public string Tennv { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string Gioitinh { get; set; }
        public string Chucvu{ get; set; }
        

  
     public clsnhanvien()
        {

        }
  
        
        
        public clsnhanvien(string manv, string tennv, string diachi, string sdt, string gioitinh, string chucvu)
        {
            Manv = manv;
            Tennv = tennv;
            Diachi = diachi;
            SDT = sdt;
            Gioitinh = gioitinh;
            Chucvu = chucvu;
        
         
        }

        //public clsnhanvien()
        //{
        //    // TODO: Complete member initialization
        //}

    }
}
