<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Qlwebdoctin.Admin" %>

<%@ Register Src="~/Qldoctin/CMS/Admin/AdminControl.ascx" TagPrefix="uc1" TagName="AdminControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang Quản Trị WebSite</title>
    <link href="Qldoctin/CMS/Admin/css/StyleSheet1.css" rel="stylesheet" />
    <script src="Qldoctin/CMS/Admin/Js/jquery-3.5.1.min.js"></script>
</head>
<body>
   <form id="form1" runat="server">
            <div>
            <div id ="header">
                <div class="container">
                  <div class="logo">
                     <a> <img src="pic/logo/emdep.jpg" /></a>
                  </div>
                  <div class="accountMenu">
                    Xin chào :<asp:Literal ID="ltrtendangnhap" runat="server"></asp:Literal>! <asp:LinkButton ID="lbtdangxuat" runat="server" OnClick="lbtdangxuat_Click">
                        Đăng Xuất</asp:LinkButton>
                  </div>
                </div>
            </div>

          <div class="menuchinh">
              <div class="container">
                  <ul>
                  
                  <li><a class="<%=DanhDau("tin") %>" href="Admin.aspx?modul=tin" title="Tin">Tin Tức</a></li>
                   <li><a class="<%=DanhDau("quangcao") %>" href="Admin.aspx?modul=quangcao" title="QuanCao">Quản Cáo</a></li>
                  <li><a class="<%=DanhDau("taikhoan") %>" href="Admin.aspx?modul=taikhoan" title="Tài khoản">Tài Khoản</a></li>
                  <li><a class="<%=DanhDau("menu") %>" href="Admin.aspx?modul=menu" title="Menu">Menu</a></li>
              </ul>
              </div>
          </div>
                <uc1:AdminControl runat="server" id="AdminControl" />
       </div>
    </form>
</body>
</html>
