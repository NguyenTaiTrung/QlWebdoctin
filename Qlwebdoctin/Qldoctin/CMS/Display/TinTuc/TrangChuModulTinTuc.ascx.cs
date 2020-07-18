using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Display.TinTuc
{
    public partial class TrangChuModulTinTuc : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltrNhomTin.Text = LayDanhMucTinTuc();
            }
        }
        #region Lấy danh mục tin và các tin tức bên trong
        private string LayDanhMucTinTuc()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_MaTLCha("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                s += @"
           <div class='baonewinde'>
           <a class='titlehead' href='/Default.aspx?modul=tintuc&modulphu=danhsachtintuc&id=" + dt.Rows[i]["IDTL"] + @"' title='" + dt.Rows[i]["TenTL"] + @"'>
          <span class='ten'>" + dt.Rows[i]["TenTL"] + @"</span>
          </a>
            <div class='cb'></div>
              <div class='list'>
        " + LayDanhSachTinTucTheoDanhMuc(dt.Rows[i]["IDTL"].ToString()) + @"
             </div>
             </div>

            ";

            }

            return s;
        }

        private string LayDanhSachTinTucTheoDanhMuc(string IDTL)
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.select_Tin_IDTL(IDTL);

            string link = "";
            if (dt.Rows.Count > 0)
            {
                //Hiện ra tin đầu tiên, có ảnh đại diện 
                link = "Default.aspx?modul=tintuc&modulphu=chitiettintuc&id=" + dt.Rows[0]["IDTin"];
                s += @"
               <div class='box1'>
               <div class='khungAnh'>
               <a class='nentren' href='" + link + @"'></a>
               <a class='khungAnhCrop' href='" + link + @"'>
               <img class='imgmuctin' src='/pic/anhtintuc/" + dt.Rows[0]["Hinh"] + @"' alt='" + dt.Rows[0]["TieuDe"] + @"' />
                </a>
                 </div>
                <a class='title' href='" + link + @"' title='" + dt.Rows[0]["TieuDe"] + @"'>" + dt.Rows[0]["TieuDe"] + @"</a>
                  <span class=''><span class='view'>" + dt.Rows[0]["SoLanXem"] + @"</span><span class='date'>" + ((DateTime)dt.Rows[0]["NgayDang"]).ToString("dd/MM/yyyy") + @"</span></span>
               <div class='desc'>" + dt.Rows[0]["Mota"] + @"</div>
               <a class='detail' href='" + link + @"' title='" + dt.Rows[0]["TieuDe"] + @"'>Xem thêm</a>

               <div class='cb'></div>
               </div>
                ";
                //Hiện ra các tin khác
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    link = "Default.aspx?modul=tintuc&modulphu=chitiettintuc&id=" + dt.Rows[i]["IDTin"];

                    s += @"
                      <a class='title1' href='" + link + @"' title='" + dt.Rows[i]["TieuDe"] + @"'>
                      " + dt.Rows[i]["TieuDe"] + @"
                       <span>(" + ((DateTime)dt.Rows[i]["NgayDang"]).ToString("dd/MM/yyyy") + @")</span>
                        </a>
                        ";
                }
            }
            return s;
        }

        #endregion
    }
}