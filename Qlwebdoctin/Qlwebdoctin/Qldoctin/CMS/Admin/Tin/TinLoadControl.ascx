<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TinLoadControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.Tin.TinLoadControl" %>
<div class="container">
     <div style="clear:both;height:20px"></div>
       <div class="cottrai">
           <div class="head"> Quản lý </div>
         <ul>
           <li><a class="<%=DanhDau("tin","theloai","") %>" href="Admin.aspx?modul=tin&modulphu=theloai">Danh Sách Thể Loại</a></li>
           <li><a class="<%=DanhDau("tin","danhsachtin","") %>" href="Admin.aspx?modul=tin&modulphu=danhsachtin">Danh Sách Tin</a></li>
        </ul>
           <div class="head"> Thêm mới </div>
         <ul>
           <li><a class="<%=DanhDau("tin","theloai","themmoi") %>" href="Admin.aspx?modul=tin&modulphu=theloai&thaotac=themmoi">Danh Sách Thể Loại</a></li>
           <li><a class="<%=DanhDau("tin","danhsachtin","themmoi") %>" href="Admin.aspx?modul=tin&modulphu=danhsachtin&thaotac=themmoi">Danh Sách Tin </a></li>
        </ul>
      </div>

      <div class="cotphai">
        <asp:PlaceHolder ID="plTinLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
</div>