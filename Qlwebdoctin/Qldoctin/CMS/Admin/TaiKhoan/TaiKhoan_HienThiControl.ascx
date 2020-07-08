<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaiKhoan_HienThiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.TaiKhoan.TaiKhoan_HienThiControl" %>
<div class="head">
    Các Tài Khoản Đã Tạo 
    <div class="fr tar">
        <a class="themmoi" href="/Admin.aspx?modul=taikhoan&modulphu=danhsachtaikhoan&thaotac=themmoi">Thêm Mới</a>
    </div>
</div>
<div class="khungchuabang">
   <table class="tbTheLoai">
       <tr>
           <th class="cottendangnhap">Tên Đăng Nhập</th>
           <th class="cotemail">Email</th>
           <th class="cotdiachi">Địa Chỉ</th>
            <th class="cothoten">Họ Tên</th>
            <th class="cotngaysinh">Ngày Sinh</th>
            <th class="cotgioitinh">Giới Tính</th>
            <th class="cotcongcu">Công Cụ</th>
       </tr>
       <asp:Literal ID="ltrtaikhoan" runat="server"></asp:Literal>
   </table>
</div>
<script type="text/javascript">
    function XoaTaiKhoan(TenDangNhap) {
        if (confirm("Bạn chắc chắn muốn xóa tài khoản này")) {
            //Viết code xóa màu tại đây

            $.post("Qldoctin/CMS/Admin/TaiKhoan/Ajax/TaiKhoan.aspx",
                {
                    "ThaoTac": "XoaTaiKhoan",
                    "TenDangNhap": TenDangNhap
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#madong_" + TenDangNhap).slideUp();

                    }

                    else {
                        alert(data);
                    }
                });
        }
    }
</script>