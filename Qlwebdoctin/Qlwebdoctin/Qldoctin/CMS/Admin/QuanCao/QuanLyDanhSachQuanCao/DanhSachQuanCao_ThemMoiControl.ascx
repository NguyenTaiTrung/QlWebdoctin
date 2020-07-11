<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachQuanCao_ThemMoiControl.ascx.cs" Inherits="Qlwebdoctin.Qldoctin.CMS.Admin.QuanCao.QuanLyDanhSachQuanCao.DanhSachQuanCao_ThemMoiControl" %>
<div class="head">
    Thêm mới, chỉnh sửa quảng cáo
</div>
<div class="formthemmoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongtin">
        <div class="tentruong">Chọn nhóm quảng cáo</div>
        <div class="onhap"><asp:DropDownList ID="ddlDanhMucCha" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongtin">
        <div class="tentruong">Tên quảng cáo</div>
        <div class="onhap">            
            <asp:TextBox ID="tbTen" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTen" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongtin">
        <div class="tentruong">Ảnh Đại Diện</div>
        <div class="onhap">
            <div>
                <asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
                <asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAnhDaiDien" runat="server" />
        </div>
    </div> 
    <div class="thongtin">
        <div class="tentruong">Liên kết</div>
        <div class="onhap">            
            <asp:TextBox ID="tbLienKet" runat="server"></asp:TextBox>
        </div>
    </div>
    
    <div class="thongtin">
        <div class="tentruong">Thứ tự</div>
        <div class="onhap">
            <asp:TextBox ID="tbThuTu" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Thứ tự phải nhập kiểu số" ControlToValidate="tbThuTu" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(\d)*" ForeColor="Red"  ></asp:RegularExpressionValidator>
        </div>
    </div>  
   
    <div class="thongtin">
        <div class="tentruong">&nbsp;</div>
        <div class="onhap"><asp:CheckBox ID="cbThemNhieuDanhMuc" runat="server" Text="Tạo thêm tin khác sau khi tạo tin này"/></div>
    </div>
    <div class="thongtin">
        <div class="tentruong">&nbsp;</div>
        <div class="onhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>