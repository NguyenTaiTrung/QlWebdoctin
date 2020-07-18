using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Display.TinTuc
{
    public partial class ChiTietTinTuc : System.Web.UI.UserControl
    {
        private string id = "";
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
           

            if (!IsPostBack)
            {
                LayChiTietTinTuc(id);
               ltrTinTucKhac.Text= LayTinTucKhac();
            }
                
        }

        private string LayTinTucKhac()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.select_Tin_IDTL_ngaunhien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                s += @"
                  <a class='title' href='/Default.aspx?modul=tintuc&modulphu=chitiettintuc&id=" + dt.Rows[i]["IDTin"] + @"' title='" + dt.Rows[i]["TieuDe"] + @"'>
                  <h5>" + dt.Rows[i]["TieuDe"] + @"</h5>
                  </a>
                   ";
                
            }

            return s;
        }

        private void LayChiTietTinTuc(string id)
        {
            CapNhatLuotXemTin(id);

            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.select_Tin_ID(id);
            if (dt.Rows.Count > 0)
            {
                ltrTieuDeTin.Text = dt.Rows[0]["TieuDe"].ToString();
                ltrNgayDang.Text = ((DateTime)dt.Rows[0]["NgayDang"]).ToString("dd/MM/yyyy");
                ltrLuotXem.Text = dt.Rows[0]["SoLanXem"].ToString();
                ltrNoiDungChiTiet.Text = dt.Rows[0]["NoiDung"].ToString();
            }
        }

        private void CapNhatLuotXemTin(string id)
        {
            Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.CapNhatLuotXem(id);
        }

    }
}