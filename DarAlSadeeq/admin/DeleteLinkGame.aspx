<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="DeleteLinkGame.aspx.vb" Inherits="admin_DeleteLinkGame" %>

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
     <li ><a href="AddLinkGame.aspx">إضافة لعبة</a></li>
                <li id="submenu-active"><a href="DeleteLinkGame.aspx">حذف  لعبة</a></li>
                <li ><a href="AddLinkGameType.aspx">إضافة تصنيف</a></li>
                <li><a href="DeleteLinkGameType.aspx">  حذف تصنيف</a></li>
               
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
                           حذف  لعبة </p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إسم التصنيف </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnType" runat="server" DataTextField="GameType" 
                            DataValueField="TypeID" AutoPostBack="True" 
                            DataSourceID="SqlDataSource1">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [LinksGamesTypes]"></asp:SqlDataSource>
                    </td>
                </tr>
           
           <tr>
                    <td style="width: 111px">
                        <p>
                            إسم اللعبة</p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="GameTitle" 
                            DataValueField="ID" AutoPostBack="True" DataSourceID="SqlDataSource2">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [LinksGames] WHERE ([GameTypeID] = @TypeID)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DrpDwnType" Name="TypeID" 
                                    PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="تمت  عملية حذف بنجاح" 
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

