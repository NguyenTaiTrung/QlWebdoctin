using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyNhomQuanCao
{
    public partial class NhomQuangCao_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LayNhomQuangCao();
        }

        private void LayNhomQuangCao()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.NhomQuanCao.Thongtin_Nhomquangcao();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrNhomQuangCao.Text += @"
           <tr id='madong_" + dt.Rows[i]["Ma"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["Ma"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["TenNhomQuanCao"] + @"</td>
           <td class='cotViTri'>" + dt.Rows[i]["ViTriQuanCao"] + @" </td>
           <td class='cotAnh'>
          
          <img class='anhDaiDien' src='/pic/anhquangcao/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
           <img class='anhDaiDienHover' src='/pic/anhquangcao/" + dt.Rows[i]["AnhDaiDien"] + @"'/>
           </td>
           <td class='cotThuTu'>" + dt.Rows[i]["ThuTu"] + @"</td>
           <td class='cotCongCu'>
               <a href='Admin.aspx?modul=quangcao&modulphu=nhomquangcao&thaotac=chinhsua&id=" + dt.Rows[i]["Ma"] + @"' class='sua' title='Sửa'></a>
               <a href='javascript:XoaNhomQuangCao(" + dt.Rows[i]["Ma"] + @")' class='xoa' title='Xóa'></a>
           </td>
</tr>
";
            }
        }
    }
}