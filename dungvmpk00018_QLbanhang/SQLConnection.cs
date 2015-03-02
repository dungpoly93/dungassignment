using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungvmpk00018_QLbanhang
{
    class SQLConnection
    {
        public static string chuoiketnoi = "Data Source = MRDUNG-PC; database = QL_banhang; Integrated Security=True";

        public static int executeNonquery(string strQuery)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            SqlCommand command = new SqlCommand(strQuery, conn);
            int resuit = command.ExecuteNonQuery();
            conn.Close();
            return resuit;
        }
        public static DataTable executeQuery(string strQuery)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            SqlCommand command = new SqlCommand(strQuery, conn);
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(ds);
            conn.Close();
            return ds.Tables[0];
        }
       
        public static DataTable loadsp()
        {
            string strQuery = "Select * from sanpham";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static DataTable loadnhanvien()
        {
            string strQuery = "Select * from nhanvien";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static DataTable loadchucvu()    
        {
            string strQuery = "Select * from chucvu";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static string laychucvu(string machucvu)
        {
            string strQuery = "Select TenCV from chucvu where MaCV='"  +machucvu+"'";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt.Rows[0].ItemArray[0].ToString();
        }
        public static string laytenloaisp(string maloaisp)
        {
            string strQuery = "Select Tenloai from phanloai where Maloai='" + maloaisp + "'";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt.Rows[0].ItemArray[0].ToString();
        }
        public static void themnhanvien(string MaNV, string TenNV, string Diachi, string SDT, string Gioitinh, string Chucvu)
        {
            string strQuery = "set dateformat dmy insert into nhanvien(MaNV, TenNV, Diachi, SDT, Gioitinh, MaCV) values('" + MaNV + "',N'" + TenNV + "',N'" + Diachi + "','" + SDT + "',N'" + Gioitinh + "',N'" + Chucvu + "')";
            SQLConnection.executeNonquery(strQuery);
        }
          public static void themsp(string MaSP, string TenSP, int Soluong, int Giaban, string Tenloai)
        {
            string strQuery = "set dateformat dmy insert into sanpham(MaSP, TenSP, Soluong, Giaban, Maloai) values('" + MaSP + "',N'" + TenSP + "','" + Soluong + "','" + Giaban + "',N'" + Tenloai + "')";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void sua(string MaNV, string TenNV, string Diachi, string SDT, string Gioitinh, string Chucvu)
        {
            string strQuery = "set dateformat dmy Update nhanvien set MaNV = '" + MaNV + "',TenNV = N'" + TenNV + "', Diachi = N'" + Diachi + "', SDT = '" + SDT + "', Gioitinh = N'" + Gioitinh + "', MaCV = '" + Chucvu + "' where MaNV = '" + MaNV + "'";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void suasp(string MaSP, string TenSP, string Soluong, string Giaban, string Tenloai)
        {
            string strQuery = "set dateformat dmy Update sanpham set MaSP = '" + MaSP + "',TenSP = N'" + TenSP + "', Soluong = '" + Soluong + "', Giaban = '" + Giaban + "', Maloai = '" + Tenloai + "' where MaSP = '" + MaSP + "'";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void xoa(string manv)
        {
            string strQuery = "delete from nhanvien where MaNV = '" + manv + "'";
            SQLConnection.executeNonquery(strQuery);
        }
        public static void xoasp(string MaSP)
        {
            string strQuery = "delete from sanpham where MaSP = '" + MaSP + "'";
            SQLConnection.executeNonquery(strQuery);
        }
        public static void themkhachhang(string makh, string tenkh, string diachi, string sdt)
        {
            string strQuery = "set dateformat dmy insert into khachhang(MaKH, TenKH, Diachi, SDT) values('" + makh + "',N'" + tenkh + "',N'" + diachi + "','" + sdt + "')";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void xoakhachhang(string makh)
        {
            string strQuery = "delete from khachhang where MaKH = '" + makh + "'";
            SQLConnection.executeNonquery(strQuery);
        }
        public static DataTable loadkhachhang()
        {
            string strQuery = "Select * from khachhang";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static void suakh(string Makh, string Tenkh, string Diachi, string SDT)
        {
            string strQuery = "set dateformat dmy Update khachhang set MaKH = '" + Makh + "',TenKH = N'" + Tenkh + "', Diachi = N'" + Diachi + "', SDT = '" + SDT + "' where MaKH = '" + Makh + "'";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void themloaisp(string maloaisp, string tenloaisp)
        {
            string strQuery = "set dateformat dmy insert into phanloai(Maloai, Tenloai) values('" + maloaisp + "',N'" + tenloaisp + "')";
            SQLConnection.executeNonquery(strQuery);

        }
        public static DataTable loadloaisp()
        {
            string strQuery = "Select * from phanloai";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static void sualoaisp(string Maloai, string Tenloai)
        {
            string strQuery = "set dateformat dmy Update phanloai set Maloai = '" + Maloai + "',Tenloai = N'" + Tenloai + "' where Maloai = '" + Maloai + "'";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void xoaloaisp(string maloai)
        {
            string strQuery = "delete from phanloai where Maloai = '" + maloai + "'";
            SQLConnection.executeNonquery(strQuery);
        }
        public static DataTable KTDangNhap(string username, string password)
        {
            string query = "select * from nhanvien Where Taikhoan = '" + username + "' and Matkhau ='" + password + "'";
            DataTable dt = SQLConnection.executeQuery(query);
            return dt;
        }
        public static DataTable laynv()
        {
            string strQuery = "select TenNV, MaCV, Hesoluong, Luongcoban from nhanvien";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static DataTable TimTheoHoTen(string Hoten)
        {
            string strQuery = "Select * from nhanvien where TenNV like N'%" + Hoten + "%'";
            DataTable dt = SQLConnection.executeQuery(strQuery);

            return dt;
        }
        public static DataTable Timtheotenkh(string Hoten)
        {
            string strQuery = "Select * from khachhang where TenKH like N'%" + Hoten + "%'";
            DataTable dt = SQLConnection.executeQuery(strQuery);

            return dt;
        }
        public static DataTable Timtheotensp(string Hoten)
        {
            string strQuery = "Select * from sanpham where TenSP like N'%" + Hoten + "%'";
            DataTable dt = SQLConnection.executeQuery(strQuery);

            return dt;
        }
        //public static DataTable tim(string tennv)
        //{
        //    string query = "SELECT * FROM nhanvien WHERE TenNV LIKE '%" + tennv + "%';";
        //    DataTable dt = SQLConnection.executeQuery(query);
        //    return dt;
        //}
        public static void themhd(string mahd, DateTime ngaylaphd, int tongtien)
        {
            string strQuery = "set dateformat dmy insert into hoadon(Mahoadon, Ngaylaphoadon, Tongtien) values('" + mahd + "','" + ngaylaphd + "','" + tongtien + "')";
            SQLConnection.executeNonquery(strQuery);

        }
        public static void xoahd(string mahd)
        {
            string strQuery = "delete from hoadon where Mahoadon = '" + mahd + "'";
            SQLConnection.executeNonquery(strQuery);
        }
        public static DataTable loadhd()
        {
            string strQuery = "Select * from hoadon";
            DataTable dt = SQLConnection.executeQuery(strQuery);
            return dt;
        }
        public static void suahd1(string mahd, DateTime ngaylaphd, int tongtien,string mahoadon)
        {
            string strQuery = "set dateformat dmy Update hoadon set Mahoadon = '" + mahd + "',Ngaylaphoadon = '" + ngaylaphd + "',  Tongtien = '" + tongtien + "' where Mahoadon = '" + mahoadon + "'";
            SQLConnection.executeNonquery(strQuery);

        }
    }
}
