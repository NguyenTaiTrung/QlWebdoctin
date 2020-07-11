using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Qlwebdoctin.Qldoctin.Add_Code.Database
{
    public class QuanCao
    {
        public static void Quangcao_Delete(string MaQC)
        {
            OleDbCommand cmd = new OleDbCommand("delete_quancao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaQC", MaQC);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void Quangcao_Inser(string TenQuanCao, string LoaiQuanCao, string AnhQuanCao,
            string LienKet, string ThuTucQC, string Ma)
        {
            OleDbCommand cmd = new OleDbCommand("insert_quancao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenQC", TenQuanCao);
            cmd.Parameters.AddWithValue("@LoaiQC", LoaiQuanCao);
            cmd.Parameters.AddWithValue("@AnhQC", AnhQuanCao);
            cmd.Parameters.AddWithValue("@LienKet", LienKet);
            cmd.Parameters.AddWithValue("@ThuTucQC", ThuTucQC);
            cmd.Parameters.AddWithValue("@Ma", Ma);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void Quangcao_Update(string MaQC, string TenQuanCao, string LoaiQuanCao, string AnhQuanCao, string LienKet, string ThuTucQC, string Ma)
        {
            OleDbCommand cmd = new OleDbCommand("update_quancao");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaQC", MaQC);
            cmd.Parameters.AddWithValue("@TenQC", TenQuanCao);
            cmd.Parameters.AddWithValue("@LoaiQC", LoaiQuanCao);
            cmd.Parameters.AddWithValue("@AnhQC", AnhQuanCao);
            cmd.Parameters.AddWithValue("@LienKet", LienKet);
            cmd.Parameters.AddWithValue("@ThuTucQC", ThuTucQC);

            cmd.Parameters.AddWithValue("@Ma", Ma);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable Thongtin_Quangcao()
        {
            OleDbCommand cmd = new OleDbCommand("selectall_quancao");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable Thongtin_Quangcao_by_id(string MaQC)
        {
            OleDbCommand cmd = new OleDbCommand("select_quancao_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaQC", MaQC);
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable Thongtin_Quangcao_by_nhomquangcaoid(string Ma)
        {
            OleDbCommand cmd = new OleDbCommand("select_quancao_manhomqc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ManhomQC", Ma);
            return SQlDatabase.GetData(cmd);
        }


    }
}