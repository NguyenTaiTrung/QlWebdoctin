using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ltbdangnhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có tên đăng nhập và mật khẩu đúng như này không nếu có xác nhận đăng nhập
            DataTable dt = Qlwebdoctin.Qldoctin.Add_Code.Database.DangKi.select_TaiKhoan_ID_MatKhau(txttendangnhap.Text, 
                Qlwebdoctin.Qldoctin.Add_Code.Database.MaHoa.MaHoaMD5(txtmatkhau.Text));
            if (dt.Rows.Count > 0)
            {
                //Đăng nhập thành công--->Lưu giá trị vào sesssion 
                Session["DangNhap"] = "1";
                //Gán thêm thông tin tài khoản đã đăng nhập
                Session["TenDangNhap"] = dt.Rows[0]["TenDangNhap"];
                Response.Redirect("Admin.aspx");
            }
            else
            {
                ltrThongbao.Text = "<div class='thongbao'>Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng!</div>";
                
            }    

        }
    }
}