using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Display.TinTuc
{
    public partial class DanhSachCacTinTuc : System.Web.UI.UserControl
    {
        private string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];

            if (!IsPostBack)
            {
                ltrNhomTinTuc.Text = LayTheLoaiTinTuc();
            }
        }
        #region Lấy nhóm và các sản phẩm
        private string LayTheLoaiTinTuc()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_ID(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += "<div class='tintucnoibat'>";
                s += @"
                  <a class='title-line' href='/Default.aspx?modul=tintuc&modulphu=danhsachtintuc&id=" + dt.Rows[i]["IDTL"] + @"' title='" + dt.Rows[i]["TenTL"] + @"'>
                  <h3>" + dt.Rows[i]["TenTL"] + @"</h3>
                  </a>
                   ";
                s += "<div>";
                s += LayTatCaDanhSachTinTucTheoTheLoai(dt.Rows[i]["IDTL"].ToString());
                s += "</div>";
                s += "<div style='clear:both'></div>";
                s += "</div>";
            }

            return s;
        }

        private string LayTatCaDanhSachTinTucTheoTheLoai(string IDTL)
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.select_Tin_IDTL_tatca(IDTL);

            string link = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                link = "Default.aspx?modul=tintuc&modulphu=chitiettintuc&id=" + dt.Rows[i]["IDTin"];

                s += @"
                  <div class='itemtintuc'>
                  <div class='khungAnh'>
                  <a class='khungAnhCrop' href='" + link + @"'>
                 <img class='imganh' src='/pic/anhtintuc/" + dt.Rows[i]["Hinh"] + @"' alt='" + dt.Rows[i]["TieuDe"] + @"' />
                </a>
                </div>
                <div class='itemContent'>
                 <a href='" + link + @"' class='title' title='" + dt.Rows[i]["TieuDe"] + @"'>
                 " + dt.Rows[i]["TieuDe"] + @"
                </a>
                <span class=''><span class='view'>" + dt.Rows[i]["SoLanXem"] + @"</span><span class='date'>" + ((DateTime)dt.Rows[i]["NgayDang"]).ToString("dd/MM/yyyy") + @"</span></span>
                <div class='desc'>
               " + dt.Rows[i]["MoTa"] + @"
               </div>
                <div class='tar'><a href='" + link + @"' class='detail'>Xem chi tiết</a></div>
               </div>
               <div class='cb'><!----></div>
                </div>
                 ";
                
                
            }
            return s;
        }

        #endregion
    }
}