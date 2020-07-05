using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTin.Ajax
{
    public partial class TinTuc : System.Web.UI.Page
    {
        private string thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["ThaoTac"] != null)
            {
                thaotac = Request.Params["thaotac"];
            }
            switch (thaotac)
            {
                case "XoaTinTuc":
                    XoaTinTuc();
                    break;

            }
        }
        private void XoaTinTuc()
        {
            string IDTin = "";
            if (Request.Params["IDTin"] != null)
            {
                IDTin = Request.Params["IDTin"];
                //Thực hiện code xóa
                Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.Tin_delete(IDTin);
                //Trả về thông báo 1 thực hiện thành công ,2 ko thành công
                Response.Write("1");
            }
        }
    }
}