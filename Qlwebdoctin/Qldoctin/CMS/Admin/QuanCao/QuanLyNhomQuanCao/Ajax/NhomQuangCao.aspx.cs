using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyNhomQuanCao.Ajax
{
    public partial class NhomQuangCao : System.Web.UI.Page
    {
        private string thaotac = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
            if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
            {
                //Đã đăng nhâp

            }
            else
            {
                //chưa đăng nhập--->return để dừng không cho thực hiện các câu lẹnh ở dưới
                return;

            }
            if (Request.Params["ThaoTac"] != null)
            {
                thaotac = Request.Params["thaotac"];
            }
            switch (thaotac)
            {
                case "XoaNhomQuangCao":
                    XoaNhomQuangCao();
                    break;

            }
        }
        private void XoaNhomQuangCao()
        {
            string Ma = "";
            if (Request.Params["Ma"] != null)
            {
                Ma = Request.Params["Ma"];

                //Thực hiện code xóa
                //B1: Xóa ảnh đại diện đã lưu trên server - tạm b
                //B2: Xóa dữ liệu trên sqlserver
               Qlwebdoctin.Qldoctin.Add_Code.Database.NhomQuanCao.Nhomquangcao_Delete(Ma);

                // Trả về thông báo 1 thực hiện thành công 2 thực hiện không thành công
                Response.Write("1");
            }
        }
    }
}