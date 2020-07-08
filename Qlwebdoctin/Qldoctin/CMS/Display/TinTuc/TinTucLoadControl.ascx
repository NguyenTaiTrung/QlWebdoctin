<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TinTucLoadControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Display.TinTuc.TinTucLoadControl" %>
<ul>
                   <li><a href="Default.aspx?modul=tintuc" title="TinTuc">Tin Tức</a></li>
                   <li><a href="Default.aspx?modul=tintuc&modulphu=danhsachtintuc" title="TinTuc">Danh Sách Tin Tức</a></li>
                   <li><a href="Default.aspx?modul=tintuc&modulphu=chitiettintuc" title="TinTuc">Chi Tiết Tin Tức</a></li>
                 
              </ul>

<asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
