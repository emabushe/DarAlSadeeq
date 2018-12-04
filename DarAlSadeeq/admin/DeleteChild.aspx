<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="DeleteChild.aspx.vb" Inherits="admin_DeleteChild" %>
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
               <li ><a href="AddChild.aspx">إضافة موضوع</a></li>
                <li id="submenu-active"><a href="DeleteChild.aspx">حذف  موضوع</a></li>
                 <li><a href="AddErshadType.aspx"> إضافة تصنيف </a></li>
                <li><a href="DeleteErshadType.aspx"> حذف تصنيف </a></li>
            </ul>
        </div>
        <!-- /aside -->
        <hr class="noscreen" />
        <!-- Content (Right Column) -->
        <div id="content" class="box">
       <%--  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>--%>
            <table width="99%">
                <tr>
                    <td colspan="2">
                        <p class=" msg info">
                           حذف  موضوع أين أنت من طفلك </p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إسم التصنيف </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" 
                            DataTextField="Type" DataValueField="ID" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إسم الموضوع </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwn" runat="server" DataSourceID="SqlDataSource3" 
                            DataTextField="ErshadSub" DataValueField="ID">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [ErshadSubjects] WHERE ([ErshadID] = @ErshadID)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownList1" Name="ErshadID" 
                                    PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [Ershad]"></asp:SqlDataSource>
                    </td>
                </tr>
           
           
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="تمت  عملية حذف الصف بنجاح" 
                            Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                    </td>
                    <td>
                        <asp:Button ID="btn_Delete" runat="server" Text="حذف" width= "60px"/>&nbsp;&nbsp;&nbsp;
                        
                    </td>
                </tr>
            </table>
<%--
            </ContentTemplate>
                </asp:UpdatePanel>--%>
        </div>
        <hr class="noscreen" />
        <!-- Footer -->
        <div id="footer" class="box">
        </div>
        <!-- /footer -->
    </div>
</asp:Content>
