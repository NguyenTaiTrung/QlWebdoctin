using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Qlwebdoctin.Qldoctin.Add_Code.Database
{
    public class NhomQuanCao
    {
        public static void Nhomquangcao_Delete(string Ma)
        {
            OleDbCommand cmd = new OleDbCommand("delect_nhomquc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ma", Ma);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void Nhomquangcao_Inser(string TenNhomQuanCao, string ViTriQuanCao, string AnhDaiDien, string ThuTu)
        {
            OleDbCommand cmd = new OleDbCommand("insert_nhomqc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNhomQC", TenNhomQuanCao);
            cmd.Parameters.AddWithValue("@ViTriQC", ViTriQuanCao);
            cmd.Parameters.AddWithValue("@AnhDaiDien", AnhDaiDien);
            cmd.Parameters.AddWithValue("@ThuTuNhomQC", ThuTu);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void Nhomquangcao_Update(string Ma, string TenNhomQuanCao, string ViTriQuanCao, string AnhDaiDien, string ThuTu)
        {
            OleDbCommand cmd = new OleDbCommand("update_nhomqc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ma", Ma);
            cmd.Parameters.AddWithValue("@TenNhomQC", TenNhomQuanCao);
            cmd.Parameters.AddWithValue("@ViTriQC", ViTriQuanCao);
            cmd.Parameters.AddWithValue("@AnhDaiDien", AnhDaiDien);
            cmd.Parameters.AddWithValue("@ThuTuNhomQC", ThuTu);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable Thongtin_Nhomquangcao()
        {
            OleDbCommand cmd = new OleDbCommand("selectall_nhomqc");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable Thongtin_Nhomquangcao_by_id(string Ma)
        {
            OleDbCommand cmd = new OleDbCommand("select_nhomqc_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomQuangCaoID", Ma);
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable Thongtin_Nhomquangcao_by_vitriqc(string ViTriQC)
        {
            OleDbCommand cmd = new OleDbCommand("select_nhomqc_vitri");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ViTriQC", ViTriQC);
            return SQlDatabase.GetData(cmd);
        }
    }
}