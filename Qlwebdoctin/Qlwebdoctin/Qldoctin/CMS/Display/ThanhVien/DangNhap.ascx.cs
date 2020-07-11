using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Display.ThanhVien
{
    public partial class DangNhap : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtDangNhap_Click(object sender, EventArgs e)
        {
            //kiểm tra database có tên đăng nhập và mật khẩu này không?=>có=>xác nhận đăng nhập thành công
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TaiKhoanNguoiDung.Thongtin_NguoiDung_by_email_matkhau(txtEmail.Text,
                Qlwebdoctin.Qldoctin.Add_Code.Database.MaHoa.MaHoaMD5(txtMatKhau.Text));

            if (dt.Rows.Count > 0)
            {
                //Đăng nhập thành công --> Lưu giá trị vào session để đánh dấu đăng nhập thành công
                Session["NguoiDung"] = "1"; //Thể hiện đã đăng nhập thành công

                //Gán thêm thông tin tài khoản đã đăng nhập
                Session["MaTK"] = dt.Rows[0]["MaTK"];
                Session["TenNguoiDung"] = dt.Rows[0]["TenNguoiDung"];
                Session["SDT"] = dt.Rows[0]["SDT"];
                Session["DiaChi"] = dt.Rows[0]["DiaChi"];
                Session["Email"] = dt.Rows[0]["Email"];

                Response.Redirect("/Default.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Tên đăng nhập hoặc mật khẩu không chính xác!');", true);
            }
        }
    }
}