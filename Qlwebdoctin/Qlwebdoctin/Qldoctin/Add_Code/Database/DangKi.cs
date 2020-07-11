using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Qlwebdoctin.Qldoctin.Add_Code.Database
{
    public class DangKi
    {
        public static DataTable select_TaiKhoan()
        {
            OleDbCommand cmd = new OleDbCommand("select_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQlDatabase.GetData(cmd);
        }
        public static void delete_DangKi(String TenDangNhap)
        {
            OleDbCommand cmd = new OleDbCommand("delete_DangKi");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void TaiKhoan_insert(String TenDangNhap, String MatKhau, String EmailDK, String DiaChiDK,
            String TenDayDu,String NgaySinh,String GioiTinh, String MaQuyen)
        {
            OleDbCommand cmd = new OleDbCommand("insert_DangKi");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@EmailDK", EmailDK);
            cmd.Parameters.AddWithValue("@DiaChiDK  ", DiaChiDK);
            cmd.Parameters.AddWithValue("@TenDayDu", TenDayDu);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh); 
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void TaiKhoan_update(String TenDangNhap , String MatKhau, String EmailDK, String DiaChiDK,String TenDayDu,
            String NgaySinh,String GioiTinh,String MaQuyen)
        {
            OleDbCommand cmd = new OleDbCommand("update_TaiKhoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            cmd.Parameters.AddWithValue("@EmailDK", EmailDK);
            cmd.Parameters.AddWithValue("@DiaChiDK", DiaChiDK);
            cmd.Parameters.AddWithValue("@TenDayDu", TenDayDu);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable select_TaiKhoan_ID(String TenDangNhap)
        {
            OleDbCommand cmd = new OleDbCommand("select_TaiKhoan_ID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable select_TaiKhoan_ID_MatKhau(String TenDangNhap,String MatKhau)
        {
            OleDbCommand cmd = new OleDbCommand("select_TaiKhoan_ID_MK");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            return SQlDatabase.GetData(cmd);
        }
    }
}