<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TheLoai_HienThiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTheLoai.TheLoai_HienThiControl" %>
<div class="head">
    Các Danh Mục Đã Tạo 
    <div class="fr tar">
        <a class="themmoi" href="/Admin.aspx?modul=tin&modulphu=theloai&thaotac=themmoi">Thêm Mới</a>
    </div>
    <div class="cb"></div>
</div>
<div class="khungchuabang">
    <table class="tbTheLoai">
        <tr>
            <th class="cotma">Mã Thể Loại</th>
            <th class="cotten">Tên Thể Loại</th>
            <th class="cotthutu">Thứ Tự</th>
            <th class="cotcongcu">Công Cụ</th>
        </tr>
        <asp:Literal ID="ltftheloai" runat="server"></asp:Literal>
        
         
    </table>
</div>
<script type="text/javascript">
    function XoaTheLoai(IDTL) {
        if (confirm("Bạn muốn xóa thể loại này?")) {
            //Code sử lý xóa

            $.post("Qldoctin/CMS/Admin/Tin/QuanLyTheLoai/Ajax/TheLoai.aspx",
                {
                    "ThaoTac": "XoaTheLoai",
                    "IDTL": IDTL
                },
                function (data, status) {
                    //alert("Data:" + data + "\n Status :" + status);
                    if (data == 1) {//thực hiện thành công ẩn dòng vừa được xóa đi
                        $("#madong_" + IDTL).slideUp();
                    }


                
                });
    }
        }
 
    
</script>