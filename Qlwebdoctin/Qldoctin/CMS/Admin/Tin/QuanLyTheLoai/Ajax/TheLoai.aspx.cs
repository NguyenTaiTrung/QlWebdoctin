using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTheLoai.Ajax
{
    public partial class TheLoai : System.Web.UI.Page
    {
        private string thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cần code kiểm tra đăng nhập sau đó mới thực hiện các thao tác ở dưới
            if(Request.Params["ThaoTac"] != null)
            {
                thaotac = Request.Params["thaotac"];
            }
            switch(thaotac) {
                case "XoaTheLoai":
                    XoaTheLoai();
                    break;

            }
        }
        private void XoaTheLoai()
        {
            string IDTL = "";
            if (Request.Params["IDTL"] != null)
            {
                IDTL = Request.Params["IDTL"];
                //Thực hiện code xóa
                Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.TheLoai_delete(IDTL);
                //Trả về thông báo 1 thực hiện thành công ,2 ko thành công
                Response.Write("1");
            }
                
            
           
           
        }
    }
}