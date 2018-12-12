<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="UpdateAboutUs.aspx.vb" Inherits="admin_UpdateAboutUs" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="Winthusiasm.HtmlEditor" Namespace="Winthusiasm.HtmlEditor"
    TagPrefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="cols" class="box">
        <!-- Aside (Left Column) -->
        <div id="aside" class="box">
            <div class="padding box">
                <!-- Logo (Max. width = 200px) -->
                <p id="logo">
                    <a href="#">
                        <img src="design/Dar_Logo.PNG" alt="Our logo" title="Visit Site" /></a></p>
                <!-- Search -->
                <form action="#" method="get" id="search">
                </form>
                <!-- Create a new project -->
            </div>
            <!-- /padding -->
        </div>
        <!-- /aside -->
        <hr class="noscreen" />
        <!-- Content (Right Column) -->
        <div id="content" class="box">
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
            <table width="99%">
                <tr>
                    <td colspan="2">
                        <p class=" msg info">
                            تحديث من نحن</p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px; height: 60px;">
                        <p>
                            العنوان </p>
                    </td>
                    <td style="height: 60px">
                        <asp:DropDownList ID="DrpDwnID" runat="server" Width="25%" AutoPostBack="True">
                            <asp:ListItem Value="0">اختر عنوان</asp:ListItem>
                            <asp:ListItem Value="2">دار الصديق</asp:ListItem>
                            <asp:ListItem Value="3">أقسام الوقع</asp:ListItem>
                            <asp:ListItem Value="4">تعريف السلسلة</asp:ListItem>
                            <asp:ListItem Value="5">إصداراتنا</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                              النص</p>
                    </td>
                    <td>
                         <cc2:HtmlEditor ID="HtmlEditor1" runat="server" Width="700px" Height="500px" />
                        </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="تم التعديل بنجاح" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                    </td>
                    <td>
                        <asp:Button ID="btn_save" runat="server" Text="حفظ" width= "60px"/>&nbsp;&nbsp;&nbsp;
                        </td>
                </tr>
            </table>
            </ContentTemplate>
                </asp:UpdatePanel>
        </div>
        <hr class="noscreen" />
        <!-- Footer -->
        <div id="footer" class="box">
        </div>
        <!-- /footer -->
    </div>
</asp:Content>

