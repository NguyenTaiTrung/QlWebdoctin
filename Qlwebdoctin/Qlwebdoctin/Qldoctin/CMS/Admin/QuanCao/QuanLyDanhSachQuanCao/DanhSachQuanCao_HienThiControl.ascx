<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachQuanCao_HienThiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyDanhSachQuanCao.DanhSachQuanCao_HienThiControl" %>
<div class="head">
    Danh Sách Các Quảng Cáo Đã Tạo. 
    <div class="fr tar">
     <a class="themmoi" href="/Admin.aspx?modul=quangcao&modulphu=danhsachquangcao&thaotac=themmoi">Thêm Mới</a>
    </div>
        <div class="cb"></div>
</div>
<div class="khungchuabang">
   <table class="tbTintuc">
       <tr>
           <th class="cotma">Mã</th>
           <th class="cottieude">Tên quảng cáo</th>
           <th class="cothinh">Ảnh quảng cáo</th>
           <th class="cotidtheloi">Thứ tự</th>
           <th class="cotcongcu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrQuangCao" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function XoaQuangCao(MaQC) {
        if (confirm("Bạn chắc chắn muốn xóa quảng cáo này")) {
            //Viết code xóa danh mục tại đây

            $.post("Qldoctin/CMS/Admin/QuanCao/QuanLyDanhSachQuanCao/Ajax/QuangCao.aspx",
                {
                    "ThaoTac": "XoaQuangCao",
                    "MaQC": MaQC
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#madong_" + MaQC).slideUp();

                    }
                });
        }
    }
</script>