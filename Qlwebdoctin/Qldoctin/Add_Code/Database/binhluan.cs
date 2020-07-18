using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Qlwebdoctin.Qldoctin.Add_Code.Database
{
    public class binhluan
    {
        public static DataTable select_binhluan_ID(String IDTin)
        {
            OleDbCommand cmd = new OleDbCommand("select_TaiKhoan_ID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTin", IDTin);
            return SQlDatabase.GetData(cmd);
        }
        public static void binhluan_insert(String Name, String NoiDung, String NgayDang, String IDTin)

        {
            OleDbCommand cmd = new OleDbCommand("insert_DangKi");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@NoiDung", NoiDung);
            cmd.Parameters.AddWithValue("@NgayDang", NgayDang);
            cmd.Parameters.AddWithValue("@IDTin  ", IDTin);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
    }
}