<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NhomQuanCao_HienThiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyNhomQuanCao.NhomQuanCao_HienThiControl" %>
<div class="head">
    Các Tin Tức Đã Tạo 
    <div class="fr tar">
        <a class="themmoi" href="/Admin.aspx?modul=quangcao&modulphu=nhomquangcao&thaotac=themmoi">Thêm Mới</a>
    </div>
    <div class="cb"></div>
</div>
<div class="khungchuabangtin">
    <table class="tbTintuc">
        <tr>
            <th class="cotma">Mã </th>
            <th class="cottieude">Tên Nhóm Quảng Cáo</th>
            <th class="cotngaydang">Vị Trí Quảng Cáo</th>
            <th class="cothinh">Ảnh Đại Diện</th>
            <th class="cotidtheloi">Thứ Tự</th>
            <th class="cotcongcu">Công Cụ</th>
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

