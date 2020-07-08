using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Display
{
    public partial class DisplayLoadControl : System.Web.UI.UserControl
    {
        private string modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["modul"] != "")
                modul = Request.QueryString["modul"];
            switch (modul)
            {
                case "tintuc":
                    plLoadControl.Controls.Add(LoadControl("TinTuc/TinTucLoadControl.ascx"));
                    break;
                case "thanhvien":
                    plLoadControl.Controls.Add(LoadControl("ThanhVien/ThanhVienLoadControl.ascx"));
                    break;
                default:
                    plLoadControl.Controls.Add(LoadControl("TrangChu/TrangChuLoadControl.ascx"));
                    break;
            }
        }
    }
}