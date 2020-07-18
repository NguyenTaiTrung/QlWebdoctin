using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTin
{
    public partial class Tin_ThemMoiControl : System.Web.UI.UserControl
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
             if (thaotac == "chinhsua")
             {
                btnthemmoi.Text = "Chỉnh Sửa";
                cbthemnhieutheloai.Visible = false;

                DataTable dt = new DataTable();
                dt = Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.select_Tin_ID(id);
                if (dt.Rows.Count > 0)
                {

                    ddlIDTin.SelectedValue = dt.Rows[0]["IDTin"].ToString();
                    txttieude.Text = dt.Rows[0]["TieuDe"].ToString();
                    ltfanhdaidien.Text = "<img class='hinhdaidien' src='/pic/anhtintuc/" + dt.Rows[0]["Hinh"] + @"'>";
                    hdanhdaidiencu.Value = dt.Rows[0]["Hinh"].ToString();
                    txtngaytao.Text = dt.Rows[0]["NgayDang"].ToString();
                    txtnoidung.Text = dt.Rows[0]["NoiDung"].ToString();
                    txtmota.Text = dt.Rows[0]["MoTa"].ToString();
                }
            }
            else
             {
                 btnthemmoi.Text = "Thêm Mới";
                 cbthemnhieutheloai.Visible = true;
                 txtngaytao.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
             }
         }
        private void LayIDTheLoai()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_MaTLCha("0");
            ddlIDTin.Items.Clear();
           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlIDTin.Items.Add(new ListItem(dt.Rows[i]["TenTL"].ToString(), dt.Rows[i]["IDTL"].ToString()));
                LayTheLoaiCon(dt.Rows[i]["IDTL"].ToString(), "___");
            }

        }
        private void LayTheLoaiCon(String MaTLCha, String khoangcanh)
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.TheLoai.ThongTinTL_MaTLCha(MaTLCha);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlIDTin.Items.Add(new ListItem(khoangcanh + dt.Rows[i]["TenTL"].ToString(), dt.Rows[i]["IDTL"].ToString()));
                LayTheLoaiCon(dt.Rows[i]["IDTL"].ToString(), khoangcanh + "___");
            }

        }

        protected void btnthemmoi_Click(object sender, EventArgs e)
        {
             if (thaotac == "themmoi")
                  {

                if (flanhdaidien.FileContent.Length > 0)
                {
                    if (flanhdaidien.FileName.EndsWith(".jpeg") || flanhdaidien.FileName.EndsWith(".jpg") || flanhdaidien.FileName.EndsWith(".png") || flanhdaidien.FileName.EndsWith(".gif"))
                    {
                        flanhdaidien.SaveAs(Server.MapPath("pic/anhtintuc/")+ flanhdaidien.FileName);
                    }
                }

                Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.Tin_insert(txttieude.Text, flanhdaidien.FileName, txtngaytao.Text, txtnoidung.Text, ddlIDTin.SelectedValue,txtmota.Text,"");
              
                      ltfthongbao.Text = "<div class='thongbaotaothanhcong'>Đã tạo Tin:" + txttieude.Text + "</div>";
                      if (cbthemnhieutheloai.Checked)
                      {
                          ResetControl();
                      }
                      else
                      {
                          Response.Redirect("/Admin.aspx?modul=tin&modulphu=danhsachtin");
                      }
                  }
            else
            {
                string tenhinhdaidien = "";
                if (flanhdaidien.FileContent.Length > 0)
                {
                    if (flanhdaidien.FileName.EndsWith(".jpeg") || flanhdaidien.FileName.EndsWith(".jpg") || flanhdaidien.FileName.EndsWith(".png") || flanhdaidien.FileName.EndsWith(".gif"))
                    {
                        flanhdaidien.SaveAs(Server.MapPath("pic/anhtintuc/") + flanhdaidien.FileName);
                        tenhinhdaidien = flanhdaidien.FileName;
                    }
                }
                if (tenhinhdaidien == "")
                {
                    tenhinhdaidien = hdanhdaidiencu.Value;
                }
                Qlwebdoctin.Qldoctin.Add_Code.Database.Tin.Tin_update(id, txttieude.Text, tenhinhdaidien, txtngaytao.Text, txtnoidung.Text, ddlIDTin.SelectedValue, txtmota.Text);
                Response.Redirect("/Admin.aspx?modul=tin&modulphu=danhsachtin");
            }
        }

        private void ResetControl()
        {
             txttieude.Text = "";
             txtnoidung.Text = "";
             txtngaytao.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
             txtmota.Text = "";
        }

        protected void bnthuy_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}