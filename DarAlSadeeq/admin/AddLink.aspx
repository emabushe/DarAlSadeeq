<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="AddLink.aspx.vb" Inherits="admin_AddLink" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
                     <li id="submenu-active"><a href="AddLink.aspx">إضافة موقع مجاني</a></li>
                <li ><a href="DeleteLink.aspx">حذف موقع مجاني</a></li>
                <li ><a href="AddLinkType.aspx">إضافة تصنيف</a></li>
                <li><a href="DeleteLinkType.aspx">  حذف تصنيف</a></li>
               
            </ul>
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
                            إضافة موقع مجاني جديد</p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            نوع الموقع</p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnType" runat="server" DataSourceID="SqlDataSource1" 
                            DataTextField="LinkType" DataValueField="LinkTypeID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [LinksTypes]"></asp:SqlDataSource>
                    </td>
                </tr>
           <tr>
                    <td>
                    <p>
                            إسم الموقع</p>
                    </td>
                    <td>
                        
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtName" ErrorMessage="يجب إدخال قيمة"></asp:RequiredFieldValidator>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                    <p>
                            رابط الموقع</p>
                    </td>
                    <td>
                       
                        <asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtURL" ErrorMessage="يجب إدخال قيمة"></asp:RequiredFieldValidator>
                       
                    </td>
                </tr>
           
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="تمت  عملية إضافة الصف بنجاح" 
                            Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                    </td>
                    <td>
                        <asp:Button ID="btn_Delete" runat="server" Text="حفظ" width= "60px"/>&nbsp;&nbsp;&nbsp;
                        
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

