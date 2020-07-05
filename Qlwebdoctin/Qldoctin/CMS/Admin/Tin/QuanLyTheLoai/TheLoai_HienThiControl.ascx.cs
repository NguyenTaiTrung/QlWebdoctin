using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTheLoai
{
    public partial class TheLoai_HienThiControl : System.Web.UI.UserControl
    {
        string maTLCha = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["maTLCha"] != null)
            {
                maTLCha = Request.QueryString["maTLCha"];
            }
            if (!IsPostBack)
            {
                LayDanhSachTheLoai();
            }
        }
        private void LayDanhSachTheLoai()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_MaTLCha(maTLCha);
            for (int i= 0 ;i < dt.Rows.Count; i++)
            {
                ltftheloai.Text += @"
         <tr id='madong_" + dt.Rows[i]["IDTL"] + @"'>
            <td class='cotma'>" + dt.Rows[i]["IDTL"] + @"</td>
            <td class='cotten'>" + dt.Rows[i]["TenTL"] + @"</td>
            <td class='cotthutu'>" + dt.Rows[i]["ThuTu"] + @"</td>
            <td class='cotcongcu'>";
                if (CoTheLoaiCon(dt.Rows[i]["IDTL"].ToString()))
                
                    ltftheloai.Text += @"
<a href='/Admin.aspx?modul=tin&modulphu=theloai&maTLCha=" + dt.Rows[i]["IDTL"] + @"' class='theloaicon' title='Xem thể loại con'></a>
";
                
                ltftheloai.Text+=@"
                
                <a href='/Admin.aspx?modul=tin&modulphu=theloai&thaotac=chinhsua&id=" + dt.Rows[i]["IDTL"] + @"' class='sua' title='Sửa'></a>
                <a href='javascript:XoaTheLoai("+dt.Rows[i]["IDTL"]+@")' class='xoa' title='Xóa'></a>
            </td>
        </tr>";
            }
            
        }
        //Phương thức kiểm tra xem thể loại có thể loại con hay không
        bool CoTheLoaiCon(string MaTLCha)
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_MaTLCha(MaTLCha);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}