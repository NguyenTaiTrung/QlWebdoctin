 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected string tukhoa = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Kiểm tra đăng nhập
            if(Session["NguoiDung"]!=null && Session["NguoiDung"].ToString()=="1")
            {
                //Đã đăng nhập
                plDaDangNhap.Visible = true;
                plChuaDangNhap.Visible = false;
                if(Session["NguoiDung"] != null) 
                {
                    ltrNguoiDung.Text = Session["TenNguoiDung"].ToString();
                }
              
            }else
            {
                //Chưa đăng nhập
                plDaDangNhap.Visible = false;
                plChuaDangNhap.Visible = true;
            }


            //Nếu là modul tin thì hiện danh mục tin các modul khác thì hiện trang chủ
            
            if (!IsPostBack)
            {
                ltrLogo.Text = LayLogo();
                ltrBanner.Text = LayBanner();
                ltfMenu.Text = LayMenu();
                ltrDMTinTuc.Text = LayDanhMucTinTuc();
            }
        }
        private string LayDanhMucTinTuc()
        {

            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_MaTLCha("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                s += @"<li class='menu1'><a href='/Default.aspx?modul=tintuc&modulphu=danhsachtintuc&id=" + dt.Rows[i]["IDTL"] + @"
               ' title='" + dt.Rows[i]["TenTL"] + @"'>" + dt.Rows[i]["TenTL"] + @"</a></li>";
            }
            return s;
        }
        private string LayMenu()
        {

            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.MN.Thongtin_Menu_by_MaMenuCha("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string lienKet = dt.Rows[i]["LienKet"].ToString();
                if (lienKet == "")
                    lienKet = "#";

                s += @"<li class='menu2'> <a href='" + lienKet + @"' title='" + dt.Rows[i]["TenMenu"] + @"'>" + dt.Rows[i]["TenMenu"] + @"</a></li>";
            }
            return s;
        }

        private string LayBanner()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.NhomQuanCao.Thongtin_Nhomquangcao_by_vitriqc("banner");
            if (dt.Rows.Count > 0)
            {
                s = LayAnhBanner(dt.Rows[0]["Ma"].ToString());
            }

            return s;
        }

        private string LayAnhBanner(string Ma)
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.QuanCao.Thongtin_Quangcao_by_nhomquangcaoid(Ma);
            if (dt.Rows.Count > 0)
            {
                string lienket = dt.Rows[0]["LienKet"].ToString();
                if (lienket == "")
                {
                    lienket = "#";
                }
                s += @"
                       <a href='" + lienket + @"' title='" + dt.Rows[0]["TenQuanCao"] + @"'>
                         <img src='/pic/QuangCao/" + dt.Rows[0]["AnhQuanCao"] + @"' alt='" + dt.Rows[0]["TenQuanCao"] + @"'>
                       <a/>";
            }
            return s;
        }

        private string LayLogo()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.NhomQuanCao.Thongtin_Nhomquangcao_by_vitriqc("logo");
            //Nếu tồn tại vị trí nhóm quản caos --> lấy ra tin quản cáo trong nhóm đó
            if (dt.Rows.Count > 0)
            {
                //gọi tới hàm lấy ảnh quảng cáo theo id nhóm quảng cáo
                s = LayAnhLogo(dt.Rows[0]["Ma"].ToString());
            }
            return s;
        }

        private string LayAnhLogo(string Ma)
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.QuanCao.Thongtin_Quangcao_by_nhomquangcaoid(Ma);
            if (dt.Rows.Count > 0)
            {
                string lienket = dt.Rows[0]["LienKet"].ToString();
                if (lienket == "")
                {
                    lienket = "#";
                }
                s += @"
                       <a href='" + lienket + @"' title='" + dt.Rows[0]["TenQuanCao"] + @"'>
                         <img src='/pic/QuangCao/" + dt.Rows[0]["AnhQuanCao"] + @"' alt='" + dt.Rows[0]["TenQuanCao"] + @"'>
                       <a/>";
            }
            return s;
        }

        protected void lbtDangXuat_Click(object sender, EventArgs e)
        {
            //Xóa các session
            Session["NguoiDung"] = null;

            //Gán thêm thông tin tài khoản đã đăng nhập
            Session["MaTK"] = null;
            Session["TenNguoiDung"] = null;
            Session["SDT"] = null;
            Session["DiaChi"] = null;
            Session["Email"] = null;

            Response.Redirect("/Default.aspx");
        }
    }
}