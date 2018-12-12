<%@ Page Title="" Language="VB" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="false" CodeFile="Subscriptions.aspx.vb" Inherits="ar_Subscriptions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="block-main no-margin" onclick="prevFrame()" style="position: absolute;">
        <span>الإشتراكات</span>
    </div>
    <div class="content-inner">
        <div class="row">
            <span>شرح مختصر عن الاشتراكات</span>
        </div>
        <div class="row">
            <div class="col-md-10 no-padding sm-m-t-10 sm-text-center">
                <table class="table table-responsive" style="text-align: right;">
                    <tr>
                        <td><span>نوع الإشتراك</span></td>
                        <td>
                            <asp:DropDownList ID="subType" runat="server">
                                <asp:ListItem Value="1">فردي</asp:ListItem>
                                <asp:ListItem Value="2">مدرسة</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td><span>الإسم</span></td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><span>المستوى</span></td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><span>البلد</span></td>
                        <td>
                            <asp:DropDownList ID="drpCountries" runat="server">
                                <asp:ListItem>الأردن</asp:ListItem>
                                <asp:ListItem>الإمارات</asp:ListItem>
                                <asp:ListItem>السعودية</asp:ListItem>
                                <asp:ListItem>الجزائر</asp:ListItem>
                                <asp:ListItem>لبنان</asp:ListItem>
                                <asp:ListItem>البحرين</asp:ListItem>
                                <asp:ListItem>ليبيا</asp:ListItem>
                                <asp:ListItem>المغرب</asp:ListItem>
                                <asp:ListItem>سوريا</asp:ListItem>
                                <asp:ListItem>مصر</asp:ListItem>
                                <asp:ListItem>عمان</asp:ListItem>
                                <asp:ListItem>العراق</asp:ListItem>
                                <asp:ListItem>تونس</asp:ListItem>
                                <asp:ListItem>فلسطين</asp:ListItem>
                                <asp:ListItem>قطر</asp:ListItem>
                                <asp:ListItem>الكويت</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td><span>البريد الاليكتروني</span></td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><span>مدة الإشتراك</span></td>
                        <td>
                            <asp:DropDownList ID="drpsubTerm" runat="server">
                                <asp:ListItem Value="1">1 شهر @ $9.99</asp:ListItem>
                                <asp:ListItem Value="3">3 شهر @ $16.99</asp:ListItem>
                                <asp:ListItem Value="6">6 شهر @ $49.99</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnSubmit" runat="server" Text="اشترك"></asp:Button></td>
                    </tr>
                    <tr>
                        <td colspan="2"><span>
                            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></span></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>

