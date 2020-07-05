using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;

namespace Qlwebdoctin.Qldoctin.Add_Code.Database
{
    public class TheLoai
    {
        public static DataTable selectall_TheLoai()
        {
            OleDbCommand cmd = new OleDbCommand("selectall_theloai");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQlDatabase.GetData(cmd);
        }
        public static void TheLoai_insert(String TenTL,String ThuTu,String MaTLCha,String ret)
        {
            OleDbCommand cmd = new OleDbCommand("theloai_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTin", TenTL);
            cmd.Parameters.AddWithValue("@TieuD", ThuTu);
            cmd.Parameters.AddWithValue("@Hinh", MaTLCha);
            cmd.Parameters.AddWithValue("@NgayDang", ret);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable ThongTinTL_ID(String IDTL )
        {
            OleDbCommand cmd = new OleDbCommand("selectid_TheLoai");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTL", IDTL);
            return SQlDatabase.GetData(cmd);
        }
        public static void TheLoai_update(String IDTL,String TenTL,String ThuTu,String MaTLCha)
        {
            OleDbCommand cmd = new OleDbCommand("update_TheLoai");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTL", IDTL);
            cmd.Parameters.AddWithValue("@TenTL", TenTL);
            cmd.Parameters.AddWithValue("@ThuTu", ThuTu);
            cmd.Parameters.AddWithValue("@MaTLCha", MaTLCha);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void TheLoai_delete(String IDTL)
        {
            OleDbCommand cmd = new OleDbCommand("delete_TheLoai");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTL", IDTL);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable ThongTinTL_MaTLCha(String MaTLCha)
        {
            OleDbCommand cmd = new OleDbCommand("select_MaTLCha_TheLoai");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTLCha", MaTLCha);
            return SQlDatabase.GetData(cmd);
        }
    }
}