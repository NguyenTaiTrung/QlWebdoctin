<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TaiKhoanLoadControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.TaiKhoan.TaiKhoanLoadControl" %>

<div class="container">
     <div style="clear:both;height:20px"></div>
       <div class="cottrai">
           <div class="head"> Quản lý </div>
         <ul>
           <li><a class="<%=DanhDau("taikhoan","danhsachtaikhoan","") %>" href="Admin.aspx?modul=taikhoan&modulphu=danhsachtaikhoan">Danh Sách Tài Khoản</a></li>
          
        </ul>
           <div class="head"> Thêm mới </div>
         <ul>
           <li><a class="<%=DanhDau("taikhoan","danhsachtaikhoan","themmoi") %>" href="Admin.aspx?modul=taikhoan&modulphu=danhsachtaikhoan&thaotac=themmoi">Danh Sách Tài Khoản</a></li>
           
        </ul>
      </div>

      <div class="cotphai">
        <asp:PlaceHolder ID="plTaiKhoanLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>
</div>