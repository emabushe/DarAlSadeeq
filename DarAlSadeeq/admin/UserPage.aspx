<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="UserPage.aspx.vb" Inherits="admin_UserPage" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
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
                           معلوماتي الشخصية </p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 500px">
                         <table width="100%">
        <tr>
            <td style="text-align: right; padding-right: 30px; font-size: 26px; border-bottom-style: solid;
                border-bottom-width: 2px; border-bottom-color: #0d4475; height: 45px;">
                 &nbsp;</td>
            <td  style="text-align: left; padding-right: 30px; font-size: 26px; border-bottom-style: solid;
                border-bottom-width: 2px; border-bottom-color: #0d4475; height: 45px;">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="lblName" runat="server" Text="الإسم" ForeColor="#009900" Font-Size="Large"></asp:Label>
            </td>
           <td align="right">
               <asp:TextBox ID="txtName" runat="server" ForeColor="#FF6600" Font-Size="Large" 
                   ReadOnly="True" Enabled="False"></asp:TextBox>
            </td>
              <td align="right">
            </td>
        </tr>
            <tr>
            <td align="left">
              <asp:Label ID="lblEmail" runat="server" Text="البريد الإلكتروني" ForeColor="#009900" Font-Size="Large"></asp:Label>  
            </td>
           <td align="right">
                <asp:TextBox ID="txtEmail" runat="server" ForeColor="#FF6600" Font-Size="Large"></asp:TextBox>
            </td>
               <td align="right">
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                       ControlToValidate="txtEmail" ErrorMessage="بريد إلكتروني خاطئ" 
                       ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
            <tr>
            <td align="left">
                <asp:Label ID="lblOldPassword" runat="server" Text="كلمة السر القديمة" ForeColor="#009900" Font-Size="Large"></asp:Label>
            </td>
           <td align="right">
                <asp:TextBox ID="txtOldPassword" runat="server" ForeColor="#FF6600"  TextMode="Password" Font-Size="Large"></asp:TextBox>
            </td>
               <td align="right">
                   <asp:Label ID="lblCheckPassword" runat="server" ForeColor="Red" 
                       Text="كلمة السر خاطئة" Visible="False"></asp:Label>
            </td>
        </tr>
            <tr>
            <td align="left">
                <asp:Label ID="lblNewPassword" runat="server" Text="كلمة السر الجديدة" ForeColor="#009900" Font-Size="Large"></asp:Label>
            </td>
           <td align="right">
                <asp:TextBox ID="txtNewPassword" runat="server" ForeColor="#FF6600"  TextMode="Password" Font-Size="Large"></asp:TextBox>
            </td>
               <td align="right">
            </td>
        </tr>
            <tr>
            <td align="left">
               <asp:Label ID="lblConfirmPassword" runat="server" Text="تأكيد كلمة السر الجديدة" ForeColor="#009900" Font-Size="Large"></asp:Label> 
            </td>
           <td align="right">
                <asp:TextBox ID="txtConfirmPassword" runat="server" ForeColor="#FF6600"  TextMode="Password" Font-Size="Large"></asp:TextBox>
            </td>
               <td align="right">
                   <asp:CompareValidator ID="CompareValidator1" runat="server" 
                       ControlToCompare="txtNewPassword" ControlToValidate="txtConfirmPassword" 
                       ErrorMessage="تأكد من كلمة السر الجديدة"></asp:CompareValidator>
            </td>
        </tr>
          <tr><td colspan="3">
                  <asp:Label ID="lblResult" runat="server"></asp:Label></td></tr>
              <tr>
            <td align="right">
                <asp:ImageButton ID="ImgBtnSave" runat="server"  ImageUrl="~/images/save.PNG" />
            </td>
           <td align="left">
                <asp:ImageButton ID="ImgBtnClear" runat="server" ImageUrl="~/images/clear.PNG" />
            </td>
               <td align="right">
            </td>
        </tr>
    </table>
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

