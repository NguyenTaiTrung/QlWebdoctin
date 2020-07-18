using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.TaiKhoan
{
    public partial class TaiKhoan_ThemMoiControl : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (!IsPostBack)
            {

                LayQuyenDangNhap();
                HienThiThongTin(id);
            }
        }
        private void HienThiThongTin(string id)
        {
            if (thaotac == "chinhsua")
                 {
                btnthemmoi.Text = "Chỉnh Sửa";
                cbthemnhieutheloai.Visible = false;
                txttendangnhap.Enabled = false;

                DataTable dt = new DataTable();
                dt = Qlwebdoctin.Qldoctin.Add_Code.Database.DangKi.select_TaiKhoan_ID(id);
                if (dt.Rows.Count > 0)
                {
                    ddlquyen.SelectedValue = dt.Rows[0]["MaQuyen"].ToString();
                    txttendangnhap.Text = dt.Rows[0]["TenDangNhap"].ToString();
                    txtemail.Text = dt.Rows[0]["EmailDK"].ToString();
                    txtdiachi.Text = dt.Rows[0]["DiaChiDK"].ToString();
                    txttendaydu.Text = dt.Rows[0]["TenDayDu"].ToString();
                    txtngaysinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                    ddlgioitinh.SelectedValue = dt.Rows[0]["GioiTinh"].ToString();
                    hdmatkhaucu.Value = dt.Rows[0]["MatKhau"].ToString();
                    RequiredFieldValidator2.Visible = false;  

                }
            }
            else
            {
                btnthemmoi.Text = "Thêm Mới";
                cbthemnhieutheloai.Visible = true;
            }
        }
        private void LayQuyenDangNhap()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.Quyen.select_Quyen();
            ddlquyen.Items.Clear();
          
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlquyen.Items.Add(new ListItem(dt.Rows[i]["TenQuyen"].ToString(), dt.Rows[i]["MaQuyen"].ToString()));
                
            }

        }
        

        protected void btnthemmoi_Click(object sender, EventArgs e)
        {
            if (thaotac == "themmoi")
            {
                //Mã hóa mật khẩu
                string matkhau =Qlwebdoctin.Qldoctin.Add_Code.Database.MaHoa.MaHoaMD5(txtmatkhau.Text);

                Qlwebdoctin.Qldoctin.Add_Code.Database.DangKi.TaiKhoan_insert(txttendangnhap.Text, matkhau, txtemail.Text, txtdiachi.Text, txttendaydu.Text, txtngaysinh.Text, ddlgioitinh.SelectedValue,ddlquyen.SelectedValue);
                ltfthongbao.Text = "<div class='thongbaotaothanhcong'>Đã tạo thành công:" + txttendangnhap.Text + "</div>";
                if (cbthemnhieutheloai.Checked)
                {
                    ResetControl();
                }
                else
                {
                    Response.Redirect("/Admin.aspx?modul=taikhoan");
                }
            }
            else
            {

                //Mã hóa mật khẩu
                string matkhau = "";
                if(txtmatkhau.Text!="")
                {
                    matkhau = Qlwebdoctin.Qldoctin.Add_Code.Database.MaHoa.MaHoaMD5(txtmatkhau.Text);
                }

                else 
                {
                    //trường hợp không nhập mật khẩu thì lấy lại mật khẩu cũ
                    matkhau = Qlwebdoctin.Qldoctin.Add_Code.Database.MaHoa.MaHoaMD5(hdmatkhaucu.Value);
                }
                    
                Qlwebdoctin.Qldoctin.Add_Code.Database.DangKi.TaiKhoan_update(txttendangnhap.Text, matkhau, txtemail.Text, txtdiachi.Text, txttendaydu.Text, txtngaysinh.Text, ddlgioitinh.SelectedValue, ddlquyen.SelectedValue); 
                Response.Redirect("/Admin.aspx?modul=taikhoan");
            }
        }

        private void ResetControl()
        {
            txttendangnhap.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
            txtcauhoibaomat.Text = "";
            txtmatkhau.Text = "";
            txtngaysinh.Text = "";
            txttendaydu.Text = "";
        }

        protected void bnthuy_Click(object sender, EventArgs e)
        {
        //    ResetControl();
        }
    }
}