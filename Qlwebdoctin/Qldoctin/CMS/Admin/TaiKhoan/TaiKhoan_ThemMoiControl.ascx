<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaiKhoan_ThemMoiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.TaiKhoan.TaiKhoan_ThemMoiControl" %>
<div class="head"> Thêm mới, chỉnh sửa tài khoản</div>
<div class="formthemmoi">
    <asp:Literal ID="ltfthongbao" runat="server"></asp:Literal>
    <div class="thongtin">
        <div class="tentruong">
            Chọn Quyền
        </div>
        <div class="onhap">
            <asp:DropDownList ID="ddlquyen" runat="server"></asp:DropDownList>
        </div>
        </div>
    
       <div class="thongtin">

         <div class="tentruong">
            Tên Đăng Nhập
        </div>
        <div class="onhap">
            <asp:TextBox ID="txttendangnhap" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" 
                ControlToValidate="txttendangnhap" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ></asp:RequiredFieldValidator>
        </div>
           </div>
     <div class="thongtin">
     <div class="tentruong">
            Mật Khẩu
        </div>
        <div class="onhap">
            <asp:HiddenField ID="hdmatkhaucu" runat="server" />
            <asp:TextBox ID="txtmatkhau" runat="server" TextMode="Password" Width="50%"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" 
                ControlToValidate="txtmatkhau" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ></asp:RequiredFieldValidator>
        </div>
           </div>
     <div class="thongtin">
     <div class="tentruong">
            Email Đăng Kí
        </div>
        <div class="onhap">
            <asp:TextBox ID="txtemail" runat="server" ></asp:TextBox>
        </div>
           </div>
    <div class="thongtin">
     <div class="tentruong">
            Địa Chỉ
        </div>
        <div class="onhap">
            <asp:TextBox ID="txtdiachi" runat="server" ></asp:TextBox>
        </div>
           </div>
     <div class="thongtin">
     <div class="tentruong">
            Tên Đầy Đủ
        </div>
        <div class="onhap">
            <asp:TextBox ID="txttendaydu" runat="server" ></asp:TextBox>
        </div>
           </div>
     <div class="thongtin">
     <div class="tentruong">
            Câu Hỏi Bảo Mật
        </div>
        <div class="onhap">
            <asp:TextBox ID="txtcauhoibaomat" runat="server" ></asp:TextBox>
        </div>
           </div>
    <div class="thongtin">
     <div class="tentruong">
            Ngày Sinh
        </div>
        <div class="onhap">
            <asp:TextBox ID="txtngaysinh" runat="server" ></asp:TextBox>
        </div>
           </div>
    <div class="thongtin">
     <div class="tentruong">
           Giới Tính
        </div>
        <div class="onhap">
            <asp:DropDownList ID="ddlgioitinh" runat="server">
                <asp:ListItem Text="Nam" Value="Nam"></asp:ListItem>
                <asp:ListItem Text="Nữ" Value="Nữ"></asp:ListItem>
                <asp:ListItem Text="Khác" Value="Khác"></asp:ListItem>

            </asp:DropDownList>
        </div>
           </div>
     
    <div class="thongtin">
         <div class="tentruong">
           &nbsp;
        </div>
        <div class="onhap">
            <asp:CheckBox ID="cbthemnhieutheloai" runat="server" Text="Tiếu tục tài khoản khác sau khi tạo tài khoản này"/>
        </div>
    </div>
    <div class="thongtin">
        <div class="tentruong">&nbsp;</div>
          <div class="onhap">
              <asp:Button ID="btnthemmoi" runat="server" Text="Thêm Mới" CssClass="btnthemmoi" OnClick="btnthemmoi_Click" />
              <asp:Button ID="bnthuy" runat="server" Text="Hủy" CssClass="btnhuy" OnClick="bnthuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>