    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyNhomQuanCao
{
    public partial class NhomQuangCao_ThemMoi : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";//lấy id của nhóm quảng cáo cần chỉnh sửa
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                HienThiThongTin(id);
            }
        }
        private void HienThiThongTin(string id)
        {
            if (thaotac == "chinhsua")
            {
                btThemMoi.Text = "Chỉnh Sửa";
                cbThemNhieuNhom.Visible = false;

                DataTable dt = new DataTable();
                dt = Qlwebdoctin.Qldoctin.Add_Code.Database.NhomQuanCao.Thongtin_Nhomquangcao_by_id(id);
                if (dt.Rows.Count > 0)
                {
                    tbTenNhomQC.Text = dt.Rows[0]["TenNhomQuanCao"].ToString();
                    tbViTriQC.Text = dt.Rows[0]["ViTriQuanCao"].ToString();
                    ltrAnhDaiDien.Text = "<img class='anhDaiDien'src='/pic/anhquangcao/" + dt.Rows[0]["AnhDaiDien"] + @"'/>";
                    hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhDaiDien"].ToString();
                    tbThuTu.Text = dt.Rows[0]["ThuTu"].ToString();
                    
                }
            }

            else
            {
                btThemMoi.Text = "Thêm Mới";
                cbThemNhieuNhom.Visible = true;
            }

        }
        protected void btThemMoi_Click(object sender, EventArgs e)
        {
            if (thaotac == "themmoi")
            {
                if (flAnhDaiDien.FileContent.Length > 0)
                {
                    if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                    {
                        flAnhDaiDien.SaveAs(Server.MapPath("pic/anhquangcao/") + flAnhDaiDien.FileName);
                    }
                }
                //else ltrThongBao.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


                Qlwebdoctin.Qldoctin.Add_Code.Database.NhomQuanCao.Nhomquangcao_Inser(tbTenNhomQC.Text, tbViTriQC.Text, flAnhDaiDien.FileName, tbThuTu.Text);
                ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo danh mục: " + tbTenNhomQC.Text + "</div>";

                if (cbThemNhieuNhom.Checked)
                {
                    //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                    ResetControl();
                }

                else
                {
                    //đẩy trang về trang danh sách các damnh mục đã tạo

                    Response.Redirect("Admin.aspx?modul=quangcao&modulphu=nhomquangcao");
                }
            }
            else
            {
                string tenAnhDaiDien = "";

                if (flAnhDaiDien.FileContent.Length > 0)
                {
                    if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                    {
                        flAnhDaiDien.SaveAs(Server.MapPath("pic/anhquangcao/") + flAnhDaiDien.FileName);
                        tenAnhDaiDien = flAnhDaiDien.FileName;

                        // viết đoạn code xóa ảnh đại diện cũ tại đây - tạm thời chưa viết
                    }
                }

                if (tenAnhDaiDien == "")
                {
                    tenAnhDaiDien = hdTenAnhDaiDienCu.Value;
                }

                Qlwebdoctin.Qldoctin.Add_Code.Database.NhomQuanCao.Nhomquangcao_Update(id, tbTenNhomQC.Text, tbViTriQC.Text,flAnhDaiDien.FileName,tbThuTu.Text);

                //đẩy trang về trang danh sách các damnh mục đã tạo
                Response.Redirect("Admin.aspx?modul=quangcao&modulphu=nhomquangcao");

            }

        }
        private void ResetControl()
        {
            tbTenNhomQC.Text = "";
            tbViTriQC.Text = "";
            tbThuTu.Text = "";

        }
        protected void btHuy_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}