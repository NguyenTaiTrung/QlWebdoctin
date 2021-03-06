﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;

namespace Qlwebdoctin.Qldoctin.Add_Code.Database
{
    public class Tin
    {
        /// <summary>
        /// Phương Thức Xóa Tin theo Mã Tin Truyền Vào
        /// </summary>
        /// <param name="IDTin"></param>
        public static void Tin_delete(String IDTin)
        {
            OleDbCommand cmd = new OleDbCommand("delete_tin");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTin", IDTin);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        /// <summary>
        /// Phương thức thêm tin mới
        /// </summary>
        /// <param name="IDTin"></param>
        /// <param name="TieuDe"></param>
        /// <param name="Hinh"></param>
        /// <param name="NgayDang"></param>
        /// <param name="IDuser"></param>
        /// <param name="NoiDung"></param>
        /// <param name="IDTL"></param>
        /// <param name="SoLanXem"></param>
        /// <param name="Mota"></param>
        /// <param name="ret"></param>
        public static void Tin_insert(String TieuDe, String Hinh, String NgayDang,
            String NoiDung, String IDTL, String Mota, String ret)
        {
            OleDbCommand cmd = new OleDbCommand("insert_tintuc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TieuD", TieuDe);
            cmd.Parameters.AddWithValue("@Hinh", Hinh);
            cmd.Parameters.AddWithValue("@NgayDang", NgayDang);
            cmd.Parameters.AddWithValue("@NoiDung", NoiDung);
            
            cmd.Parameters.AddWithValue("@IDTL ", IDTL);
            cmd.Parameters.AddWithValue("@Mota", Mota);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        /// <summary>
        /// Cập nhật sản phẩm
        /// </summary>
        /// <param name="IDTin"></param>
        /// <param name="TieuDe"></param>
        /// <param name="Hinh"></param>
        /// <param name="NgayDang"></param>
        /// <param name="IDuser"></param>
        /// <param name="NoiDung"></param>
        /// <param name="IDTL"></param>
        /// <param name="SoLanXem"></param>
        /// <param name="Mota"></param>
        public static void Tin_update(String IDTin, String TieuDe, String Hinh, String NgayDang,
            String NoiDung, String IDTL, String Mota)
        {
            OleDbCommand cmd = new OleDbCommand("update_tin");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTin", IDTin);
            cmd.Parameters.AddWithValue("@TieuD", TieuDe);
            cmd.Parameters.AddWithValue("@Hinh", Hinh);
            cmd.Parameters.AddWithValue("@NgayDang", NgayDang);
            cmd.Parameters.AddWithValue("@NoiDung", NoiDung);
            cmd.Parameters.AddWithValue("@IDTL ", IDTL);
            cmd.Parameters.AddWithValue("@Mota", Mota);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable select_Tin()
        {
            OleDbCommand cmd = new OleDbCommand("select_tin");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable select_Tin_ID(String IDTin)
        {
            OleDbCommand cmd = new OleDbCommand("select_Tin_ID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTin", IDTin);
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable select_Tin_Home ()
        {
            OleDbCommand cmd = new OleDbCommand("selecthome_chitiet");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable select_Tin_IDTL(String IDTL)
        {
            OleDbCommand cmd = new OleDbCommand("select_tintuc_IDTL");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTL", IDTL);
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable select_Tin_IDTL_tatca(String IDTL)
        {
            OleDbCommand cmd = new OleDbCommand("select_tintuc_IDTL_tatca");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTL", IDTL);
            return SQlDatabase.GetData(cmd);
        }
        public static void CapNhatLuotXem(String IDTin)
        {
            OleDbCommand cmd = new OleDbCommand("capnhatluotxem");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTin", IDTin);
            SQlDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable select_Tin_IDTL_ngaunhien()
        {
            OleDbCommand cmd = new OleDbCommand("selectngaunhien_tintuc");
            cmd.CommandType = CommandType.StoredProcedure;
           
            return SQlDatabase.GetData(cmd);
        }
        public static DataTable Thongtin_Tin_by_tukhoa(string tukhoa)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_by_tukhoa");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", tukhoa);
            return SQlDatabase.GetData(cmd);
        }

    }
}