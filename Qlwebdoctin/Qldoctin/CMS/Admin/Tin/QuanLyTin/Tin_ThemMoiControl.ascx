<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Tin_ThemMoiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTin.Tin_ThemMoiControl" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="head"> Thêm mới, chỉnh sửa tin</div>
<div class="formthemmoi">
    <asp:Literal ID="ltfthongbao" runat="server"></asp:Literal>
    <div class="thongtin">
        <div class="tentruong">
            Chọn Thể Loại
        </div>
        <div class="onhap">
            <asp:DropDownList ID="ddlIDTin" runat="server"></asp:DropDownList>
        </div>
        </div>
    
       <div class="thongtin">
         <div class="tentruong">
            Tiêu Đề Tin
        </div>
        <div class="onhap">
            <asp:TextBox ID="txttieude" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" 
                ControlToValidate="txttieude" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ></asp:RequiredFieldValidator>
        </div>
           </div>
     <div class="thongtin">

         <div class="tentruong">
            Ảnh Đại Diện
        </div>
        <div class="onhap">
            <asp:HiddenField ID="hdanhdaidiencu" runat="server" />
            <asp:Literal ID="ltfanhdaidien" runat="server"></asp:Literal>
            </div>
         <asp:FileUpload ID="flanhdaidien" runat="server" />
        </div>
     <div class="thongtin">
         <div class="tentruong">
            Ngày Tạo
        </div>
        <div class="onhap">
            <asp:TextBox ID="txtngaytao" runat="server"></asp:TextBox>
        </div>
         </div>
         <div class="thongtin">
         <div class="tentruong">
            Nội Dung
        </div>
        <div class="onhap">
            <CKEditor:CKEditorControl ID="txtnoidung" runat="server"  FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>
        </div>
             </div>
             <div class="thongtin">
         <div class="tentruong">
            Mô Tả
        </div>
        <div class="onhap">
            <%--<asp:TextBox ID="txtmota"  runat="server" TextMode="MultiLine" Height="150px" width="50%" ></asp:TextBox>--%>
            <CKEditor:CKEditorControl ID="txtmota" runat="server"  FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>
        </div>
                 </div>
    <div class="thongtin">
         <div class="tentruong">
           &nbsp;
        </div>
        <div class="onhap">
            <asp:CheckBox ID="cbthemnhieutheloai" runat="server" Text="Tiếu tục tạo tin khác sau khi tạo thể loại này"/>
        </div>
    </div>
    <div class="thongtin">
        <div class="tentruong">&nbsp;</div>
          <div class="onhap">
              <asp:Button ID="btnthemmoi" runat="server" Text="Thêm Mới" CssClass="btnthemmoi" OnClick="btnthemmoi_Click" />
              <asp:Button ID="bnthuy" runat="server" Text="Hủy" CssClass="btnhuy" OnClick="bnthuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>