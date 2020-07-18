<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NhomQuangCao_HienThi.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyNhomQuanCao.NhomQuangCao_HienThi" %>
<div class="head">
    Các nhóm quảng cáo đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=quangcao&modulphu=nhomquangcao&thaotac=themmoi">Thêm mới </a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbNhomQuangCao">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên nhóm quảng cáo</th>
           <th class="cotViTri">Vị trí quảng cáo</th>
           <th class="cotAnh">Ảnh đại diện</th>
           <th class="cotThuTu">Thứ tự</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrNhomQuangCao" runat="server"></asp:Literal>
   </table>
</div>
<script type="text/javascript">
    function XoaNhomQuangCao(Ma) {
        if (confirm("Bạn muốn xóa nhóm quảng cáo này?")) {
            //Code sử lý xóa

            $.post("Qldoctin/CMS/Admin/QuanCao/QuanLyNhomQuanCao/Ajax/NhomQuangCao.aspx",
                {
                    "ThaoTac": "XoaNhomQuangCao",
                    "Ma": Ma
                },
                function (data, status) {
                    //alert("Data:" + data + "\n Status :" + status);
                    if (data == 1) {//thực hiện thành công ẩn dòng vừa được xóa đi
                        $("#madong_" + Ma).slideUp();
                    }


                
                });
    }
        }
 
    
</script>