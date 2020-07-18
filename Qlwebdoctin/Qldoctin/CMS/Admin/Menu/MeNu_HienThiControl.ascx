<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MeNu_HienThiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.Menu.MeNu_HienThiControl" %>
<div class="head">
    Các Menu đã tạo. 
    <div class="fr ter"><a class="themmoi" href="/Admin.aspx?modul=menu&modulphu=danhsachmenu&thaotac=themmoi">Thêm mới</a></div>
    <div class="cb"></div>
</div>
<div class="khungchuabang">
   <table class="tbTheLoai">
       <tr>
           <th class="cotma">Mã</th>
           <th class="cothoten">Tên menu</th>
           <th class="cotthutu">Thứ tự</th>
           <th class="cotcongcu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrMenu" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function XoaMenu(MaMenu) {
        if (confirm("Bạn chắc chắn muốn xóa menu này")) {
            //Viết code xóa danh mục tại đây

            $.post("Qldoctin/CMS/Admin/Menu/Ajax/Menu.aspx",
                {
                    "ThaoTac": "XoaMenu",
                    "MaMenu": MaMenu
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#madong_" + MaMenu).slideUp();

                    }
                });
        }
    }
</script>