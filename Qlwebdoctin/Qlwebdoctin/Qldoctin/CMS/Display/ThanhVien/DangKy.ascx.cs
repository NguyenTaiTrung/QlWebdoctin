using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Display.ThanhVien
{
    public partial class DangKy : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void lbtDangKy_Click(object sender, EventArgs e)
        {
            //Kiểm Tra nếu chưa có ai đăng kí email này thì mới cho thực hiện
            if (DaTonTaiEmail(txtEmail.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Email này đã được đăng ký. Bạn vui lòng điền email khác để đăng ký.');", true);
            }
            else
            {
                string matkhau = Qlwebdoctin.Qldoctin.Add_Code.Database.MaHoa.MaHoaMD5(txtMatKhau.Text);
                //Thực hiện thêm mới tài khoản người dùng
                Qlwebdoctin.Qldoctin.Add_Code.Database.TaiKhoanNguoiDung.insert_tknguoidung(txtHoTen.Text, txtSoDienThoai.Text, txtDiaChi.Text, txtEmail.Text, matkhau);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "", "alert('Đã đăng ký tài khoản khách hàng thành công. Bạn có thể đăng nhập với email và mật khẩu vừa tạo.');location.href='/Default.aspx?modul=thanhvien&modulphu=dangnhap';", true);
            }
        }
        private bool DaTonTaiEmail(string email)
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TaiKhoanNguoiDung.Thongtin_NguoiDung_by_email(email);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
    
}