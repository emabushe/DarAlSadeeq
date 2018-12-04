﻿<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="DeleteLink.aspx.vb" Inherits="admin_DeleteLink" %>
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
       <li ><a href="AddLink.aspx">إضافة موقع مجاني</a></li>
                <li id="submenu-active"><a href="DeleteLink.aspx">حذف موقع مجاني</a></li>
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
                           حذف  موضوع إرشاد </p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إسم التصنيف </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnType" runat="server" DataTextField="LinkType" 
                            DataValueField="LinkTypeID" AutoPostBack="True" 
                            DataSourceID="SqlDataSource1">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [LinksTypes]"></asp:SqlDataSource>
                    </td>
                </tr>
           
           <tr>
                    <td style="width: 111px">
                        <p>
                            عنوان الموقع</p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="LinkTitle" 
                            DataValueField="LinkID" AutoPostBack="True" DataSourceID="SqlDataSource2">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [Links] WHERE ([LinkTypeID] = @LinkTypeID)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DrpDwnType" Name="LinkTypeID" 
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
