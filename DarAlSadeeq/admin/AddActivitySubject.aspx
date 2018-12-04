<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master"
    AutoEventWireup="false" CodeFile="AddActivitySubject.aspx.vb" Inherits="admin_AddActivitySubject" ValidateRequest="false"%>

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
            <ul class="box">
                <li id="submenu-active"><a href="AddActivitySubject.aspx">إضافة موضوع</a></li>
                <li><a href="DeleteActivitySub.aspx">حذف موضوع</a></li>
                <li><a href="AddActivityType.aspx">إضافة تصنيف </a></li>
                <li><a href="DeleteActivityType.aspx">حذف تصنيف </a></li>
            </ul>
        </div>
        <!-- /aside -->
        <hr class="noscreen" />
        <!-- Content (Right Column) -->
        <div id="content" class="box">
    
            <table width="99%">
                <tr>
                    <td colspan="2">
                        <p class=" msg info">
                            إضافة موضوع للأنشطة</p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            التصنيف
                        </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnClasses" runat="server" Width="25%" DataSourceID="SqlDataSource1"
                            DataTextField="Type" DataValueField="ID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                            SelectCommand="SELECT * FROM [Activity]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إسم الموضوع
                        </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="50%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                            ErrorMessage="يجب إدخال قيمة"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            Youtube?</p>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                            RepeatDirection="Horizontal" AutoPostBack="True">
                            <asp:ListItem Value="1">Yes</asp:ListItem>
                            <asp:ListItem Value="0">No</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <asp:Panel ID="Youtube" runat="server" Visible="False">
                    <tr>
                        <td style="width: 111px">
                            <p>
                                Youtube Embed Link</p>
                        </td>
                        <td>
                            <asp:TextBox ID="txtYoutube" runat="server" Width="60%"></asp:TextBox>
                        </td>
                    </tr>
                </asp:Panel>
                <asp:Panel ID="Editor" runat="server" Visible="False">
                    <tr>
                        <td style="width: 111px">
                            <p>
                                النص</p>
                        </td>
                        <td>
                            <cc2:HtmlEditor ID="HtmlEditor1" runat="server" Width="700px" Height="500px" />
                        </td>
                    </tr>
                </asp:Panel>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="تمت الإضافة بنجاح" Visible="false"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                    </td>
                    <td>
                        <asp:Button ID="btn_save" runat="server" Text="حفظ" Width="60px" />&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
            </table>
         
        </div>
        <hr class="noscreen" />
        <!-- Footer -->
        <div id="footer" class="box">
        </div>
        <!-- /footer -->
    </div>
</asp:Content>
