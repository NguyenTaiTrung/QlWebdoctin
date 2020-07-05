using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin
{
    public partial class AdminControl : System.Web.UI.UserControl
    {
        private string modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Request.QueryString["modul"] != "")
                modul = Request.QueryString["modul"];
            switch (modul)
            {
                case "tin":
                    pladminloadcontrol.Controls.Add(LoadControl("Tin/TinLoadControl.ascx"));
                    break;
                case "taikhoan":
                    pladminloadcontrol.Controls.Add(LoadControl("TaiKhoan/TaiKhoanLoadControl.ascx"));
                    break;
                case "menu":
                    pladminloadcontrol.Controls.Add(LoadControl("Menu/MenuLoadControl.ascx"));
                    break;
            }
        }
    }
}