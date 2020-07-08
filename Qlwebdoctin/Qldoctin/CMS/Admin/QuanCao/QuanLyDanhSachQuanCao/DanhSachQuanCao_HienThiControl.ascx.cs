using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyDanhSachQuanCao
{
    public partial class DanhSachQuanCao_HienThiControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LayQuangCao();
        }
        private void LayQuangCao()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.QuanCao.Thongtin_Quangcao();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrQuangCao.Text += @"
        <tr id='madong_" + dt.Rows[i]["MaQC"] + @"'>
               <td class='cotma'>" + dt.Rows[i]["MaQC"] + @"</td>
               <td class='cottieude'>" + dt.Rows[i]["TenQuanCao"] + @"</td>
               <td class='cothinh'>
                 <img class='hinhdaidien'src='/pic/QuangCao/" + dt.Rows[i]["AnhQuanCao"] + @"'/>
                 <img class='hinhdaidienhover'src='/pic/QuangCao/" + dt.Rows[i]["AnhQuanCao"] + @"'/>
               </td>
               <td class='cotidtheloi'>" + dt.Rows[i]["ThuTucQC"] + @"</td>
               <td class='cotcongcu'>
                   <a href='Admin.aspx?modul=quangcao&modulphu=danhsachquancao&thaotac=chinhsua&id=" + dt.Rows[i]["MaQC"] + @"' class='sua' title='Sửa'></a>
                   <a href='javascript:XoaQuangCao(" + dt.Rows[i]["MaQC"] + @")' class='xoa' title='Xóa'></a>
               </td>
        </tr>
";
            }

        }
    }
    

}