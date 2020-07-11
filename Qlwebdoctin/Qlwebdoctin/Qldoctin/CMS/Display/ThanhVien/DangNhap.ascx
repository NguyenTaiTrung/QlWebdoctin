<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Display.ThanhVien.DangNhap" %>
<link href="../../../../css/dang-ky.css" rel="stylesheet" />
<div class="title-gioithieu">
    <h1>ĐĂNG NHẬP</h1>
</div>
<div class="userbox">

    <div id="create_customer">
        <input name="form_type" type="hidden" value="create_customer">
        <input name="utf8" type="hidden" value="✓">

        <div id="email" class="clearfix">
            <div class="label-email"></div>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="text" placeholder="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
            <div style="clear:both"></div>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="<div style='color:red;padding:3px 0'>Email sai định dạng</div>" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>

        <div id="password" class="clearfix">
            <div class="label-pass"></div>
            <asp:TextBox ID="txtMatKhau" runat="server" CssClass="password text" placeholder="Mật khẩu" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" SetFocusOnError="True" Display="Dynamic" ControlToValidate="txtMatKhau" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        
        <div class="action_bottom">
            <asp:LinkButton ID="lbtDangNhap" CssClass="btn" runat="server" OnClick="lbtDangNhap_Click"  >Đăng nhập</asp:LinkButton>
        </div>
        <div class="req_pass">
            <a class="come-back" href="/">Quay về</a>
        </div>

    </div>
</div>