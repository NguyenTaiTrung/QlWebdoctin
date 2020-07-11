using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.Menu
{
    public partial class MeNu_HienThiControl : System.Web.UI.UserControl
    {
        string mamenucha = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["mamenucha"] != null)
                mamenucha = Request.QueryString["mamenucha"];
            if (!IsPostBack)
                LayMenu();
        }
        private void LayMenu()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.MN.Thongtin_Menu_by_MaMenuCha(mamenucha);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrMenu.Text += @"
          
           <tr id='madong_" + dt.Rows[i]["MaMenu"] + @"'>
               <td class='cotma'>" + dt.Rows[i]["MaMenu"] + @"</td>
               <td class='cothoten'>" + dt.Rows[i]["TenMenu"] + @"</td>
               <td class='cotthutu'>" + dt.Rows[i]["ThuTuMenu"] + @"</td>
               <td class='cotcongcu'>";
                if (CoMenuCon(dt.Rows[i]["MaMenu"].ToString()))
                    ltrMenu.Text += @"<a href='Admin.aspx?modul=menu&modulphu=danhsachmenu&mamenucha=" + dt.Rows[i]["MaMenu"] + @"' class='theloaicon' title='Xem menu con'></a>";
                ltrMenu.Text += @"
               <a href='Admin.aspx?modul=menu&modulphu=danhsachmenu&thaotac=chinhsua&id=" + dt.Rows[i]["MaMenu"] + @"' class='sua' title='Sửa'></a>
               <a href='javascript:XoaMenu(" + dt.Rows[i]["MaMenu"] + @")' class='xoa' title='Xóa'></a>
               </td>
           </tr>
";
            }

        }

        //Hàm kiểm tra danh mục có danh mục con hay ko
        bool CoMenuCon(string MaMenuCha)
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.MN.Thongtin_Menu_by_MaMenuCha(MaMenuCha);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}