using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTin
{
    public partial class TinLoadControl : System.Web.UI.UserControl
    {
        private string thaotac = "null";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            switch (thaotac)
            {
                case "chinhsua":
                case "themmoi":

                    plLoadControl.Controls.Add(LoadControl("Tin_ThemMoiControl.ascx"));
                    break;
                case "hienthi":
                    plLoadControl.Controls.Add(LoadControl("Tin_HienThiControl.ascx"));
                    break;
                default:
                    plLoadControl.Controls.Add(LoadControl("Tin_HienThiControl.ascx"));
                    break;
            }
        }
    }
}