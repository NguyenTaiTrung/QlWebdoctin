using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTheLoai
{
    public partial class TheLoai_ThemMoiControl : System.Web.UI.UserControl
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
             
                LayIDTheLoai();
                HienThiThongTin(id);
            }
        }
        private void HienThiThongTin(string id)
        {
            if (thaotac =="chinhsua")
            {
                btnthemmoi.Text = "Chỉnh Sửa";
                cbthemnhieutheloai.Visible = false;
                
                DataTable dt = new DataTable();
                dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_ID(id);
                if (dt.Rows.Count > 0) 
                {
                    ddlIDTheLoai.SelectedValue = dt.Rows[0]["MaTLCha"].ToString();
                    txttentheloai.Text = dt.Rows[0]["TenTL"].ToString();
                    txtthutu.Text = dt.Rows[0]["ThuTu"].ToString();
                }
            }
            else
            {
                btnthemmoi.Text ="Thêm Mới";
                cbthemnhieutheloai.Visible = true;
            }
        }
        private void LayIDTheLoai()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_MaTLCha("0");
            ddlIDTheLoai.Items.Clear();
            ddlIDTheLoai.Items.Add(new ListItem("Danh Mục Thể Loại", "0"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlIDTheLoai.Items.Add(new ListItem(dt.Rows[i]["TenTL"].ToString(), dt.Rows[i]["IDTL"].ToString()));
                LayTheLoaiCon(dt.Rows[i]["IDTL"].ToString(),"___");
            }

        }
        private void LayTheLoaiCon(String MaTLCha,String khoangcanh)
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_MaTLCha(MaTLCha);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlIDTheLoai.Items.Add(new ListItem(khoangcanh+ dt.Rows[i]["TenTL"].ToString(), dt.Rows[i]["IDTL"].ToString()));
                LayTheLoaiCon(dt.Rows[i]["IDTL"].ToString(),khoangcanh+"___");
            }

        }

        protected void btnthemmoi_Click(object sender, EventArgs e)
        {
           if(thaotac == "themmoi")
            {
                Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.TheLoai_insert(txttentheloai.Text, txtthutu.Text, ddlIDTheLoai.SelectedValue, "");
                ltfthongbao.Text = "<div class='thongbaotaothanhcong'>Đã tạo thể loại:" + txttentheloai.Text + "</div>";
                if (cbthemnhieutheloai.Checked)
                {
                    ResetControl();
                }
                else
                {
                    Response.Redirect("/Admin.aspx?modul=tin&modulphu=theloai");
                }
            }
            else
            {
                Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.TheLoai_update(id,txttentheloai.Text,txtthutu.Text, ddlIDTheLoai.SelectedValue);

                Response.Redirect("/Admin.aspx?modul=tin&modulphu=theloai");
            }
        }

        private void ResetControl()
        {
            txttentheloai.Text = "";
            txtthutu.Text = "";
        }

        protected void bnthuy_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}