using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace dungvmpk00018_QLbanhang
{
    class DBConnection
    {
        static string sqlConnectionString = "Data Source = DELL-PC ; Database = QLbanhang; Integrated Security = True";

        //Hàm thực thi câu truy vấn SQL không trả về bảng, chẳng hạn: DELETE, INSERT, UPDATE
        public static int ThucThiTruyVanDeleteInsertUpdate(string cauTruyVan)
        {
            int ketqua = 0;

            //Tạo kết nối
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            conn.Open(); //Mở kết nối

            //Lệnh thực thi truy vấn
            SqlCommand command = new SqlCommand(cauTruyVan, conn);

            //Thực thi truy vấn và thông báo kết quả thành công hay không (Thành công là 1, <= 0 là ko)
            ketqua = command.ExecuteNonQuery();

            conn.Close(); //Đóng kết nối

            return ketqua;
        }

        public static DataTable ThucThiTruyVanSelect(string CauTruyVanSelect)
        {
            DataTable dt = new DataTable();

            //Tạo kết nối tới SQL Server
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            //Mở kết nối
            conn.Open();
            //Tạo lệnh thực thi truy vấn
            SqlCommand command = new SqlCommand(CauTruyVanSelect, conn);

            //Tạo bộ dữ liệu
            DataSet ds = new DataSet();

            SqlDataAdapter sqlDAdapter = new SqlDataAdapter();

            sqlDAdapter.SelectCommand = command;
            sqlDAdapter.Fill(ds);

            dt = ds.Tables[0];

            //Đóng kết nối
            conn.Close();

            return dt;
        }

        public static DataTable GetAllSanPham()
        {
            //TẠO CÂU TRUY VẤN LẤY TẤT CẢ CÁC  SẢN PHẨM TRONG CSDL
            string strQuery = "	select * from sanpham";

            //TẠO BẢNG DỮ LIỆU ĐỂ LƯU TRỮ KẾT QUẢ TỪ TRUY VẤN
            DataTable dt = new DataTable();

            //THỰC THI TRUY VẤN VÀ LƯU VÀO BẢNG DỮ LIỆU ĐÃ TẠO
            dt = DBConnection.ThucThiTruyVanSelect(strQuery);

            return dt; //TRẢ VỀ BẢNG DỮ LIỆU
        }
      
    }
}
