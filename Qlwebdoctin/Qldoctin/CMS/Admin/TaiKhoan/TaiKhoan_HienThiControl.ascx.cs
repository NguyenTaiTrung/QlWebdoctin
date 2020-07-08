using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.TaiKhoan
{
    public partial class TaiKhoan_HienThiControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LayTaiKhoan();

        }
        private void LayTaiKhoan()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.DangKi.select_TaiKhoan();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrtaikhoan.Text += @"
           <tr id='madong_"+dt.Rows[i]["TenDangNhap"] + @"'>
           <td class='cottendangnhap'>" + dt.Rows[i]["TenDangNhap"]+ @"</td>
           <td class='cotemail'>" + dt.Rows[i]["EmailDK"] + @"</td>
           <td class='cotdiachi'>" + dt.Rows[i]["DiaChiDK"] + @"</td>
            <td class='cothoten'>" + dt.Rows[i]["TenDayDu"] + @"</td>
            <td class='cotngaysinh'>" + dt.Rows[i]["NgaySinh"] + @"</td>
            <td class='cotgioitinh'>" + dt.Rows[i]["GioiTinh"] + @"</td>
            <td class='cotcongcu'>
                <a href='/Admin.aspx?modul=taikhoan&modulphu=danhsachtaikhoan&thaotac=chinhsua&id=" + dt.Rows[i]["TenDangNhap"] + @"' class='sua' title='Sửa'></a>
                <a href=javascript:XoaTaiKhoan('" + dt.Rows[i]["TenDangNhap"] + @"') class='xoa' title='Xóa'></a>
            </td>
            </tr>";

            }
        }
    }
}