<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuanCaoLoadControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanCaoLoadControl" %>
<div class="container">
     <div style="clear:both;height:20px"></div>
       <div class="cottrai">
           <div class="head"> Quản lý </div>
         <ul>
           <li><a class="<%=DanhDau("quangcao","nhomquangcao","") %>" href="Admin.aspx?modul=quangcao&modulphu=nhomquangcao">Nhóm Quản Cáo</a></li>
           <li><a class="<%=DanhDau("quangcao","danhsachquangcao","") %>" href="Admin.aspx?modul=quangcao&modulphu=danhsachquangcao">Danh Sách Quản Cao</a></li>
        </ul>
           <div class="head"> Thêm mới </div>
         <ul>
           <li><a class="<%=DanhDau("quangcao","nhomquangcao","themmoi") %>" href="Admin.aspx?modul=quangcao&modulphu=nhomquangcao&thaotac=themmoi">Nhóm Quản Cáo</a></li>
           <li><a class="<%=DanhDau("quangcao","danhsachquangcao","themmoi") %>" href="Admin.aspx?modul=quangcao&modulphu=danhsachquangcao&thaotac=themmoi">Danh Sách Quản Cáo </a></li>
        </ul>
      </div>

      <div class="cotphai">
        <asp:PlaceHolder ID="plQuanCaoLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
</div>