<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Qlwebdoctin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang đăng nhập vào hệ thống website</title>
    <link href="Qldoctin/CMS/Admin/css/cssLogin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="formdangnhap">
         <div class="head"> Đăng Nhập Hệ Thống</div>
             <div class="controls">
                  <div class="row">
              <div class="left">
                  Tên Đăng Nhập
              </div>
              <div class="right">
                  <asp:TextBox ID="txttendangnhap" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ErrorMessage="*" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" 
                      ControlToValidate="txttendangnhap"></asp:RequiredFieldValidator>
              </div>
                  </div>
                  
              <div class="row">
              <div class="left">
                  Mật Khẩu
              </div>
              <div class="right">
                  <asp:TextBox ID="txtmatkhau" runat="server" TextMode="Password" ></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ErrorMessage="*" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" 
                      ControlToValidate="txtmatkhau"></asp:RequiredFieldValidator>
              </div>
          </div>
              <div class="row">
              <div class="left">
                  &nbsp
              </div>
              <div class="right">
                  <asp:LinkButton ID="ltbdangnhap" runat="server" CssClass="btndangnhap" OnClick="ltbdangnhap_Click">Đăng Nhập</asp:LinkButton>
              </div>
          </div>
                 <asp:Literal ID="ltrThongbao" runat="server"></asp:Literal>
             <div></div>
             </div>
         
        </div>
    </form>
</body>
</html>
