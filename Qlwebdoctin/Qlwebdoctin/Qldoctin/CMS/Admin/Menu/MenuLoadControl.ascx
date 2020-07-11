<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuLoadControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.Menu.MenuLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cottrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a class="<%=DanhDau("menu","danhsachmenu","") %>" href="Admin.aspx?modul=menu&modulphu=danhsachmenu">Danh sách Menu</a></li>
        </ul>
        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a class="<%=DanhDau("menu","danhsachmenu","themmoi") %>" href="Admin.aspx?modul=menu&modulphu=danhsachmenu&thaotac=themmoi">Danh sách Menu</a></li>            
        </ul>
    </div>
    <div class="cotphai">
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>