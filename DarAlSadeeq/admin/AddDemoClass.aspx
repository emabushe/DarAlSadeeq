<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="AddDemoClass.aspx.vb" Inherits="admin_AddDemoClass" %>

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
                <li ><a href="AddDemo.aspx">إضافة ورقة عمل</a></li>
                <li ><a href="DeleteDemo.aspx">حذف ورقة عمل</a></li>
                <li id="submenu-active" ><a href="AddDemoClass.aspx">إضافة صف</a></li>
                <li><a href="DeleteDemoClass.aspx">  حذف صف</a></li>
                <li><a href="AddDemoSubject.aspx"> إضافة مادة </a></li>
                <li><a href="DeleteDemoSubject.aspx"> حذف مادة </a></li>
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
                           إضافة صف جديد</p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إسم الصف </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtClassName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtClassName" ErrorMessage="يجب إدخال الإسم"></asp:RequiredFieldValidator>
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

