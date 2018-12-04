<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="AddUser.aspx.vb" Inherits="admin_AddUser" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
                <li id="submenu-active"><a href="AddUser.aspx">إضافة مستخدم  </a></li>
                <li ><a href="DeleteUser.aspx">حذف مستخدم  </a></li>
              
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
                            إضافة مستخدم للموقع</p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            الإسم الكامل</p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="50%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtName" ErrorMessage="يجب إدخال قيمة" 
                            ValidationGroup="Group1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            البريد الإلكتروني </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="50%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtEmail" ErrorMessage="يجب إدخال قيمة" 
                            ValidationGroup="Group1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
              
                <tr>
                    <td style="width: 111px">
                        <p>
                            المدرسة </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnSchool" runat="server" 
                            DataSourceID="SqlDataSource1" DataTextField="SchoolNameAR" 
                            DataValueField="SchoolID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [Schools] WHERE ([IsWebSchool] = 1)">
                           
                        </asp:SqlDataSource>
                        
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            نوع المستخدم</p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnUserType" runat="server" 
                            DataSourceID="SqlDataSource2" DataTextField="Type" DataValueField="UserTypID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [UsersTypes]"></asp:SqlDataSource>
                    </td>
                </tr>
                   <tr>
                    <td style="width: 111px">
                        <p>
                            إسم المستخدم</p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        <asp:Button ID="btnAvailablity" runat="server" Text="تحقق من توفره" 
                            ValidationGroup="Group2" />
                        <asp:Label ID="lblAvailablity" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" 
                            Text="تمت الإضافة بنجاح, كلمة السر &quot;123456&quot;" Visible="False"></asp:Label>
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

