<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Tin_HienThiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTin.Tin_HienThiControl" %>
<div class="head">
    Các Tin Tức Đã Tạo 
    <div class="fr tar">
        <a class="themmoi" href="/Admin.aspx?modul=tin&modulphu=danhsachtin&thaotac=themmoi">Thêm Mới</a>
    </div>
    <div class="cb"></div>
</div>
<div class="khungchuabangtin">
    <table class="tbTintuc">
        <tr>
            <th class="cotma">Mã Tin Tức</th>
            <th class="cottieude">Tiêu Đề</th>
            <th class="cothinh">Hình</th>
            <th class="cotngaydang">Ngày Đăng</th>
            <th class="cotidtheloi">ID Thể Loại</th>
            <th class="cotsolanxem">Số Lần Xem</th>
            <th class="cotmota">Mô tả</th>
            <th class="cotcongcu">Công Cụ</th>
        </tr>
        <asp:Literal ID="ltftintuc" runat="server"></asp:Literal>
        
         
    </table>
</div>
<script type="text/javascript">
    function XoaTinTuc(IDTin) {
        if (confirm("Bạn muốn xóa tin tức này?")) {
            //Code sử lý xóa

            $.post("Qldoctin/CMS/Admin/Tin/QuanLyTin/Ajax/TinTuc.aspx",
                {
                    "ThaoTac": "XoaTinTuc",
                    "IDTin": IDTin
                },
                function (data, status) {
                    //alert("Data:" + data + "\n Status :" + status);
                    if (data == 1) {//thực hiện thành công ẩn dòng vừa được xóa đi
                        $("#madong_" + IDTin).slideUp();
                    }


                
                });
    }
        }
 
    
</script>
