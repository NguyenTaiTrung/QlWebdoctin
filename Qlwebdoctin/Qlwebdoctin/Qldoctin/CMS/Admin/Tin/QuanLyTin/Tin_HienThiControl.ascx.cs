using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTin
{
    public partial class Tin_HienThiControl : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                LayDanhSachTinTuc();
            }
        }
        private void LayDanhSachTinTuc()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.select_Tin();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltftintuc.Text += @"
            <tr id='madong_" + dt.Rows[i]["IDTin"] + @"'>
            <td class='cotma'>" + dt.Rows[i]["IDTin"] + @"</td>
            <td class='cottieude'>" + dt.Rows[i]["TieuDe"] + @"</td>
            <td class='cothinh'>
             <img class='hinhdaidien' src='/pic/anhtintuc/" + dt.Rows[i]["Hinh"] + @"'/>
             <img class='hinhdaidienhover' src='/pic/anhtintuc/" + dt.Rows[i]["Hinh"] + @"'/>
             </td>
            <td class='cotngaydang'>" + dt.Rows[i]["NgayDang"] + @"</td>
            <td class='cotidtheloi'>" + dt.Rows[i]["IDTL"] + @"</td>
            <td class='cotsolanxem'>" + dt.Rows[i]["SoLanXem"] + @"</td>
            <td class='cotmota'>" + dt.Rows[i]["MoTa"] + @"</td>
            <td class='cotcongcu'>
                <a href='/Admin.aspx?modul=tin&modulphu=danhsachtin&thaotac=chinhsua&id=" + dt.Rows[i]["IDTin"] + @"' class='sua' title='Sửa'></a>
                <a href='javascript:XoaTinTuc(" + dt.Rows[i]["IDTin"] + @")' class='xoa' title='Xóa'></a>
             </td>
        </tr>";
            }
        }
       
               
            
        
    }
}