using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyDanhSachQuanCao
{
    public partial class DanhSachQuanCao_ThemMoiControl : System.Web.UI.UserControl
    {
        private string thaotac = "";
        private string id = "";//lấy id của tin tức cần chỉnh sửa
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];
            if (!IsPostBack)
            {

                LayNhom();

                HienThiThongTin(id);
            }
        }
        private void HienThiThongTin(string id)
        {
            if (thaotac == "chinhsua")
            {
                btThemMoi.Text = "Chỉnh Sửa";
                cbThemNhieuDanhMuc.Visible = false;

                DataTable dt = new DataTable();
                dt = Qlwebdoctin.Qldoctin.Add_Code.Database.QuanCao.Thongtin_Quangcao_by_id(id);
                if (dt.Rows.Count > 0)
                {
                    ddlDanhMucCha.SelectedValue = dt.Rows[0]["MaQC"].ToString();
                    tbTen.Text = dt.Rows[0]["TenQuanCao"].ToString();
                    tbLienKet.Text = dt.Rows[0]["LienKet"].ToString();
                    tbThuTu.Text = dt.Rows[0]["ThuTucQC"].ToString();
                    ltrAnhDaiDien.Text = "<img class='hinhdaidien'src='/pic/anhquangcao/" + dt.Rows[0]["AnhQuanCao"] + @"'/>";
                    hdTenAnhDaiDienCu.Value = dt.Rows[0]["AnhQuanCao"].ToString();
                }
            }

            else
            {
                btThemMoi.Text = "Thêm Mới";
                cbThemNhieuDanhMuc.Visible = true;
            }

        }

        private void LayNhom()
        {
            DataTable dt = new DataTable();
            dt = Qlwebdoctin.Qldoctin.Add_Code.Database.NhomQuanCao.Thongtin_Nhomquangcao();
            ddlDanhMucCha.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddlDanhMucCha.Items.Add(new ListItem(dt.Rows[i]["TenNhomQuanCao"].ToString(), dt.Rows[i]["Ma"].ToString()));
                //dt.Rows[i]["AnhDaiDien"].ToString(), dt.Rows[i]["ThuTu"].ToString(), dt.Rows[i]["SoSPHienThi"].ToString()
            }
        }
        protected void btThemMoi_Click(object sender, EventArgs e)
        {
            if (thaotac == "themmoi")
            {
                #region code nút thêm mới

                if (flAnhDaiDien.FileContent.Length > 0)
                {
                    if (flAnhDaiDien.FileName.EndsWith(".jpeg") || flAnhDaiDien.FileName.EndsWith(".jpg") || flAnhDaiDien.FileName.EndsWith(".png") || flAnhDaiDien.FileName.EndsWith(".gif"))
                    {
                        flAnhDaiDien.SaveAs(Server.MapPath("pic/anhquangcao/") + flAnhDaiDien.FileName);
                    }
                }
                //else ltrThongBao.Text = "Nhập sai hoặc thiếu thông tin! Mời nhập lại";


                Qlwebdoctin.Qldoctin.Add_Code.Database.QuanCao.Quangcao_Inser(
                    tbTen.Text, "", flAnhDaiDien.FileName,
                    tbLienKet.Text, tbThuTu.Text, ddlDanhMucCha.SelectedValue);
                ltrThongBao.Text = "<div class='thongBaoTaoThanhCong' style='color:#ff006e;font-size:16px;padding-bottom:20px;text-align:center;font-weight:bold'>Đã tạo quảng cáo mới</div>";

                if (cbThemNhieuDanhMuc.Checked)
                {
                    //viết code xử lý xóa mục đã nhập để người dùng nhập danh mục tiếp theo
                    ResetControl();
                }

                else
                {
                    //đẩy trang về trang danh sách các damnh mục đã tạo

                    Response.Redirect("Admin.aspx?modul=quangcao&modulphu=danhsachquangcao");
                }
                #endregion
            }
            else
            {
                #region code nút chỉnh sửa
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

                Qlwebdoctin.Qldoctin.Add_Code.Database.QuanCao.Quangcao_Update(
                    id, tbTen.Text, "", tenAnhDaiDien,
                    tbLienKet.Text, tbThuTu.Text, ddlDanhMucCha.SelectedValue);

                //đẩy trang về trang danh sách các damnh mục đã tạo
                Response.Redirect("Admin.aspx?modul=quangcao&modulphu=danhsachquangcao");

                #endregion
            }
        }

        private void ResetControl()
        {
            tbTen.Text = "";
            tbThuTu.Text = "";
            tbLienKet.Text = "";
        }
        protected void btHuy_Click(object sender, EventArgs e)
        {
            ResetControl();
        }
    }
}