<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietTinTuc.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Display.TinTuc.ChiTietTinTuc" %>
<link href="../../../../css/trangchitiettin.css" rel="stylesheet" />
<div id="NewDetail">
    <div class="title"><h1><asp:Literal ID="ltrTieuDeTin" runat="server"></asp:Literal></h1></div>
    <div class="tool">
        <div class="date">Ngày đăng: <asp:Literal ID="ltrNgayDang" runat="server"></asp:Literal></div>
        <div class="view">Lượt xem: <asp:Literal ID="ltrLuotXem" runat="server"></asp:Literal></div>               
        <div class="cb"><!----></div>
    </div>
    <div class="contentview TextSize thongTinChiTietTinTuc">
        <asp:Literal ID="ltrNoiDungChiTiet" runat="server"></asp:Literal>
    </div>
    <div class="contentview ">
        <h3>Xem Thêm Các Tin Khác</h3>
        <div class="title"><h1><asp:Literal ID="ltrTinTucKhac" runat="server"></asp:Literal></h1></div>
      <div class="cb"></div> 
</div>
    </div>
