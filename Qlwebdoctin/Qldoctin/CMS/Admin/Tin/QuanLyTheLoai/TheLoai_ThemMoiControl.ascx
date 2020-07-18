<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TheLoai_ThemMoiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.Tin.QuanLyTheLoai.TheLoai_ThemMoiControl" %>
<div class="head"> Thêm mới, chỉnh sửa thể loại</div>
<div class="formthemmoi">
    <asp:Literal ID="ltfthongbao" runat="server"></asp:Literal>
    <div class="thongtin">
        <div class="tentruong">
            ID Thể Loại
        </div>
        <div class="onhap">
            <asp:DropDownList ID="ddlIDTheLoai" runat="server"></asp:DropDownList>
        </div>
        </div>
    
       <div class="thongtin">

         <div class="tentruong">
            Tên Thể Loại
        </div>
        <div class="onhap">
            <asp:TextBox ID="txttentheloai" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" 
                ControlToValidate="txttentheloai" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ></asp:RequiredFieldValidator>
        </div>
           </div>
     <div class="thongtin">

         <div class="tentruong">
            Thứ Tự
        </div>
        <div class="onhap">
            <asp:TextBox ID="txtthutu" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="Thứ tự phải nhập kiểu số" ControlToValidate="txtthutu" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red" ></asp:RegularExpressionValidator>
            </div>
        </div>
    <div class="thongtin">
         <div class="tentruong">
           &nbsp;
        </div>
        <div class="onhap">
            <asp:CheckBox ID="cbthemnhieutheloai" runat="server" Text="Tiếu tục tạo thể loại khác sau khi tạo thể loại này"/>
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