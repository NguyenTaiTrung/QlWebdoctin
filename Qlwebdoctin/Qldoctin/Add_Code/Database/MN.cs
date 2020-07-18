using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Qlwebdoctin.Qldoctin.Add_Code.Database
{
    public class MN
    {
        public static void Menu_Delete(String mamenu)
        {
            OleDbCommand cmd = new OleDbCommand("menu_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void Menu_Inser(String tenmenu, String lienket, String mamenucha, String thutumenu, String ret)
        {
            OleDbCommand cmd = new OleDbCommand("menu_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@mamenucha", mamenucha);
            cmd.Parameters.AddWithValue("@thutumenu", thutumenu);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static void Menu_Update(String mamenu, String tenmenu, String lienket, String mamenucha, String thutumenu)
        {
            OleDbCommand cmd = new OleDbCommand("menu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@mamenucha", mamenucha);
            cmd.Parameters.AddWithValue("@thutumenu", thutumenu);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable Thongtin_Menu()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQlDatabase.GetData(cmd);

        }
        public static DataTable Thongtin_Menu_by_id(String MaMenu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMenu", MaMenu);
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable Thongtin_Menu_by_MaMenuCha(String MaMenuCha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_by_mamenucha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMenuCha", MaMenuCha);
            return SQlDatabase.GetData(cmd);
        }
    }
}