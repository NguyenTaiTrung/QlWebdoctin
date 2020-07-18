using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Qlwebdoctin.Qldoctin.Add_Code.Database
{
    public class TaiKhoanNguoiDung
    {
        public static void delete_tknguoidung(string MaTK)
        {
            OleDbCommand cmd = new OleDbCommand("delete_tknguoidung");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTK", MaTK);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void insert_tknguoidung(string TenNguoiDung, string SDT, string DiaChi, string Email, string MatKhau)
        {
            OleDbCommand cmd = new OleDbCommand("insert_tknguoidung");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNguoiDung", TenNguoiDung);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void update_tknguoidung(string MaTK, string TenNguoiDung, string SDT, string DiaChi, string Email, string MatKhau)
        {
            OleDbCommand cmd = new OleDbCommand("update_tknguoidung");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTK", MaTK);
            cmd.Parameters.AddWithValue("@TenNguoiDung", TenNguoiDung);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable selectall_tknguoidung()
        {
            OleDbCommand cmd = new OleDbCommand("selectall_tknguoidung");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable Thongtin_NguoiDung_by_email(string Email)
        {
            OleDbCommand cmd = new OleDbCommand("Thongtin_NguoiDung_by_email");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", Email);
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable Thongtin_NguoiDung_by_MaTK(string MaTK)
        {
            OleDbCommand cmd = new OleDbCommand("Thongtin_NguoiDung_by_MaTK");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTK", MaTK);
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable Thongtin_NguoiDung_by_email_matkhau(string Email, string MatKhau)
        {
            OleDbCommand cmd = new OleDbCommand("Thongtin_NguoiDung_by_email_matkhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            return SQlDatabase.GetData(cmd);
        }
    }
}