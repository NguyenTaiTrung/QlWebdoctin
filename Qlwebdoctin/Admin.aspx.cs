using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
            if(Session["DangNhap"]!=null &&Session["DangNhap"].ToString()=="1")
            {
                //Đã đăng nhâp

            }    
            else
            {
                //chưa đăng nhập
                Response.Redirect("/Login.aspx");

            }
            if (!IsPostBack)
            {
                ltrtendangnhap.Text = Session["TenDangNhap"].ToString();
            }

        }
        protected string DanhDau(string tenModul)
        {
            string s = "";

            string modul = ""; //Biến lưu giá trị của querstring modul
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];
            if (tenModul == modul)
                s = "current";

            return s;
        }

        protected void lbtdangxuat_Click(object sender, EventArgs e)
        {
            //Xóa các session đã lưu và đẩy về trang login
            Session["DangNhap"] = "";
            Session["TenDangNhap"] = "";
            Response.Redirect("/Login.aspx");
        }
    }
}