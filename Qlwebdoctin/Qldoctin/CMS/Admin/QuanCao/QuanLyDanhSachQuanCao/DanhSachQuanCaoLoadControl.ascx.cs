﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyDanhSachQuanCao
{
    public partial class DanhSachQuanCaoLoadControl : System.Web.UI.UserControl
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

                    plLoadControl.Controls.Add(LoadControl("DanhSachQuanCao_ThemMoiControl.ascx"));
                    break;
                case "hienthi":
                    plLoadControl.Controls.Add(LoadControl("DanhSachQuanCao_HienThiControl.ascx"));
                    break;
                default:
                    plLoadControl.Controls.Add(LoadControl("DanhSachQuanCao_HienThiControl.ascx"));
                    break;
            }
        }
    }
}