 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Qlwebdoctin.Default" %>
<%@ Register Src="~/Qldoctin/CMS/Display/DisplayLoadControl.ascx" TagPrefix="uc1" TagName="DisplayLoadControl" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Website đọc tin </title>
    <link href="css/tranghienthi.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <!--đầu trang-->
    <div id="dautrang">
        <div class="contener">
            <div id="logo">
                <div id="logochu">
                    <asp:Literal ID="ltrLogo" runat="server"></asp:Literal>
                </div>
                <div id="logoanh">
                    <asp:Literal ID="ltrBanner" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </div>
    <!--menu đầu trang-->
    <div id="menudautrang">
        <div class="contener">
            <div id="menutrai">
                <ul class="menungang">
                    <asp:Literal ID="ltfMenu" runat="server"></asp:Literal>
                </ul>
            </div>
            <div id="dangnhap">
                <asp:PlaceHolder ID="plChuaDangNhap" runat="server">
                    <ul>
                        <li class="dangnhap1">/<a href="Default.aspx?modul=thanhvien&modulphu=dangky">Đăng ký</a></li>
                        <li class="dangnhap2"><a href="Default.aspx?modul=thanhvien&modulphu=dangnhap">Đăng nhập</a></li>
                    </ul>
                </asp:PlaceHolder>
                
                <asp:PlaceHolder ID="plDaDangNhap" runat="server" Visible="False">
                    <ul>
                       <li class="dangnhap1">/<asp:LinkButton ID="lbtDangXuat" runat="server" CausesValidation="False" OnClick="lbtDangXuat_Click" >Đăng xuất</asp:LinkButton></li>
                        <li class="dangnhap2"><asp:Literal ID="ltrNguoiDung" runat="server"></asp:Literal></li>
                    </ul>
                </asp:PlaceHolder>
            </div>
        </div>
    </div>

    <!--thanh tìm kiếm -->
    <div id="timkiem">
        <div class="contener">
                <div class="timkiemphai">
                    <div class="otimkiem">
                        <div class="search">
                            <div id="searchForm">
                                <input type="text" class="key" placeholder="Từ khóa tìm kiếm" name="pr_name" value="<%=tukhoa %>" id="keysearch" onkeydown="CheckPostSearch(event)"/>
                                <a href="javascript://" onclick="PostSearch()" class="submit">&nbsp;</a>
                            </div>
                            
                            <script type="text/javascript">
                                function CheckPostSearch(e) {
                                    if (e.keyCode === 13) {
                                        PostSearch();

                                        e.preventDefault();
                                    }
                                }

                                function PostSearch() {
                                    $("#keysearch").show().focus();
                                    if ($("#keysearch").val() !== "")
                                        window.location = "/Default.aspx?modul=tintuc&modulphu=timkiem&tukhoa=" + $("#keysearch").val();
                                }
                            </script>
                        </div>           
                    </div>  
                </div> 
        </div>
    </div>

    <!--thân trang-->
    <div id="thantrang">
        <div class="contener">
            <div id="trangtrai">
                 <asp:PlaceHolder ID="plDanhMucTinTuc" runat="server" Visible="true">
                    <div id="danhmuc">
                        <div class="daumuc"><a>DANH MỤC TIN TỨC</a></div>
                        <div class="ditmuc">
                            <ul>
                                <asp:Literal ID="ltrDMTinTuc" runat="server"></asp:Literal>
                            </ul>
                        </div>   
                    </div>
                      </asp:PlaceHolder>
                </div>
            <div id="trangphai">
                <uc1:DisplayLoadControl runat="server" ID="DisplayLoadControl" />
            </div>
        </div>
    </div>

    <!--chân trang-->
     <div id="footer">
        <div class="contener">
            <div class=" menufoter">
                <p>©2016 Copyright by Trung99</p>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
