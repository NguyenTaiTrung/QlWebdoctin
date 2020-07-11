using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.TaiKhoan.Ajax
{
    public partial class TaiKhoan : System.Web.UI.Page
    {
        private string thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["ThaoTac"] != null)
            {
                thaotac = Request.Params["ThaoTac"];
            }
            switch (thaotac)
            {
                case "XoaTaiKhoan":
                    XoaTaiKhoan();
                    break;

            }
        }
        private void XoaTaiKhoan()
        {
            string TenDangNhap = "";
            if (Request.Params["TenDangNhap"] != null)
            {
                TenDangNhap = Request.Params["TenDangNhap"];
                if(TenDangNhap.ToLower()!="admin")//chỉ cho xóa tài khoản không phải admin
                {
                    //Thực hiện code xóa
                    Qlwebdoctin.Qldoctin.Add_Code.Database.DangKi.delete_DangKi(TenDangNhap);
                    //Trả về thông báo 1 thực hiện thành công ,2 ko thành công
                    Response.Write("1");
                }
                else
                {
                    Response.Write("Không được xóa tài khoản admin");
                }
            }
        }
    }
}