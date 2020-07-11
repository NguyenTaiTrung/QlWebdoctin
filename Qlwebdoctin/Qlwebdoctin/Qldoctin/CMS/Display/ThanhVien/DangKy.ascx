<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DangKy.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Display.ThanhVien.DangKy"  %>
<link href="../../../../css/dang-ky.css" rel="stylesheet" />
<div class="title-gioithieu">
    <h1>TẠO TÀI KHOẢN</h1>
</div>
<div class="userbox">

    <div id="create_customer">
        <input name="form_type" type="hidden" value="create_customer">
        <input name="utf8" type="hidden" value="✓">

        <div id="first_name" class="clearfix">
            <div class="label-fname"></div>
            <asp:TextBox ID="txtHoTen" runat="server" CssClass="text" placeholder="Họ tên"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtHoTen" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div  class="clearfix">
            <div class="label-lname"></div>
            <asp:TextBox ID="txtSoDienThoai" runat="server" CssClass="text" placeholder="Số điện thoại"></asp:TextBox>
        </div>
        <div  class="clearfix">
            <div class="label-lname"></div>
            <asp:TextBox ID="txtDiaChi" runat="server" CssClass="text" placeholder="Địa chỉ"></asp:TextBox>
        </div>

        <div id="email" class="clearfix">
            <div class="label-email"></div>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="text" placeholder="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
            <div style="clear:both"></div>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="<div style='color:red;padding:3px 0'>Email sai định dạng</div>" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>

        <div  class="clearfix">
            <div class="label-pass"></div>
            <asp:TextBox ID="txtMatKhau" runat="server" CssClass="password text" placeholder="Mật khẩu" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtMatKhau" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        
        <div  class="clearfix">
            <div class="label-pass"></div>
            <asp:TextBox ID="txtNhapLaiMatKhau" runat="server" CssClass="password text" placeholder="Nhập lại mật khẩu" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="<div style='color:red;padding:3px 0'>Nhập lại mật khẩu không trùng khớp</div>" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtNhapLaiMatKhau" ControlToCompare="txtMatKhau"></asp:CompareValidator>
        </div>

        <div class="action_bottom">
            <asp:LinkButton ID="lbtDangKy" CssClass="btn" runat="server" OnClick="lbtDangKy_Click" >Đăng ký</asp:LinkButton>
        </div>
        <div class="req_pass">
            <a class="come-back" href="/">Quay về</a>
        </div>

    </div>
</div>