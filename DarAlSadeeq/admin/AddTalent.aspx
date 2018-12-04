<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="AddTalent.aspx.vb" Inherits="admin_AddTalent" %>
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
                <li id="submenu-active"><a href="AddTalent.aspx">إضافة موهبة</a></li>
                <li ><a href="DeleteTalent.aspx">حذف  موهبة</a></li>
              
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
                            إضافة  موهبة</p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إسم الطالب </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtName" ErrorMessage="يجب إدخال قيمة"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                   <tr>
                    <td style="width: 111px">
                        <p>
                            صورة الطالب </p>
                    </td>
                    <td>
                        <asp:FileUpload ID="UploaderStdPic" runat="server" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="UploaderStdPic" ErrorMessage="يجب إختيار ملف"></asp:RequiredFieldValidator>
                       </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            العمر </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server" Width="5%"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="txtAge" ErrorMessage="يجب إدخال قيمة"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="TypeValidator" runat="server" 
                            ControlToValidate="txtAge" ErrorMessage="CompareValidator" 
                            Operator="DataTypeCheck" Type="Integer">يجب إدخال رقم صحيح</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                              المدرسة</p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSchool" runat="server"  Width="30%"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtSchool" ErrorMessage="يجب إدخال قيمة"></asp:RequiredFieldValidator>
                        
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                             المواهب </p>
                    </td>
                    <td>
                        <asp:TextBox ID="txtTalents" runat="server" Width="30%"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="txtTalents" ErrorMessage="يجب إدخال قيمة"></asp:RequiredFieldValidator>
                        
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                             صورة الموهبة </p>
                    </td>
                    <td>
                        
                        <asp:FileUpload ID="UploaderTalentPic" runat="server" />
                        
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