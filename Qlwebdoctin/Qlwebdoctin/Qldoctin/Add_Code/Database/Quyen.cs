using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Qlwebdoctin.Qldoctin.Add_Code.Database
{
    public class Quyen
    {
        public static DataTable select_Quyen()
        {
            OleDbCommand cmd = new OleDbCommand("select_Quyen");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQlDatabase.GetData(cmd);
        }
    }
}