using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTheLoai
{
    public partial class TheLoaiLoadControl : System.Web.UI.UserControl
    {
        private string thaotac = "null";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            switch (thaotac)
            {
                case "themmoi":
                case "chinhsua":
                    plLoadControl.Controls.Add(LoadControl("TheLoai_ThemMoiControl.ascx"));
                    break;
                
                

                case "HienThi":
                    plLoadControl.Controls.Add(LoadControl("TheLoai_HienThiControl.ascx"));
                    break;
                default:
                    plLoadControl.Controls.Add(LoadControl("TheLoai_HienThiControl.ascx"));
                    break;
            }
        }
    }
}