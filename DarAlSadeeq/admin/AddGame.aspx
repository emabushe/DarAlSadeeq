<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="AddGame.aspx.vb" Inherits="admin_AddGame" %>
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
                <li id="submenu-active"><a href="AddGame.aspx">إضافة لعبة</a></li>
                <li ><a href="DeleteGame.aspx">حذف  لعبة</a></li>
                <li><a href="AddGameClass.aspx"> إضافة تصنيف </a></li>
                <li><a href="DeleteGameClass.aspx"> حذف تصنيف </a></li>
                <li><a href="AddGameSubject.aspx"> إضافة موضوع </a></li>
                <li><a href="DeleteGameSubject.aspx"> حذف موضوع </a></li>
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
                            إضافة  لعبة إلى تعلم والعب</p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            التصنيف </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnClasses" runat="server" Width="25%" 
                            DataSourceID="SqlDataSource1" DataTextField="ClassNameAR" 
                            DataValueField="ClassID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [Class] WHERE ([IsGame] = 1)">
                           
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            الموضوع </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnSubjects" runat="server" Width="25%" 
                            DataSourceID="SqlDataSource2" DataTextField="SubjectNameAR" 
                            DataValueField="SubjectID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [Subject] WHERE ([IsGame] = 1)">
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إسم  اللعبة</p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtGameName" runat="server"  Width="50%"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtGameName" ErrorMessage="يجب إدخال قيمة"></asp:RequiredFieldValidator>
                        
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إختر ملف </p>
                    </td>
                    <td>
                        <asp:FileUpload ID="UploaderMatFile" runat="server" />
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="UploaderMatFile" ErrorMessage="يجب إختيار ملف"></asp:RequiredFieldValidator>
                        
                        <asp:TextBox ID="txtFileCheck" runat="server" BorderWidth="0px" ForeColor="Red" 
                            ReadOnly="True" Visible="False">هذا الملف موجود مسبقاً</asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                       
                    </td>
                    <td>
                        
                    </td>
                </tr>
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
                        <asp:Button ID="btn_save" runat="server" Text="حفظ" width= "60px"/>&nbsp;&nbsp;&nbsp;
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
