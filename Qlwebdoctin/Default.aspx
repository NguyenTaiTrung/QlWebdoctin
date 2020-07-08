<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Qlwebdoctin.Default" %>

<%@ Register Src="~/Qldoctin/CMS/Display/DisplayLoadControl.ascx" TagPrefix="uc1" TagName="DisplayLoadControl" %>
<%@ Register Src="~/Qldoctin/CMS/Admin/AdminControl.ascx" TagPrefix="uc1" TagName="AdminControl" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="menuchinh">
              <div class="container">
                  <ul>
                  
                  <li><a href="Default.aspx?modul=tintuc" title="TinTuc">Tin Tức</a></li>
                  <li><a href="Default.aspx?modul=thanhvien" title="ThanhVien">Thành Viên</a></li>
                 
              </ul>
              </div>
          </div>
            <uc1:DisplayLoadControl runat="server" id="DisplayLoadControl" /> 
        </div>
    </form>
</body>
</html>
