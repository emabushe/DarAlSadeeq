<%@ Page Title="" Language="VB" MasterPageFile="~/admin/MasterPage_admin.master" AutoEventWireup="false" CodeFile="DeleteKGMaterial.aspx.vb" Inherits="admin_DeleteKGMaterial" %>

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
        <li ><a href="AddLearn.aspx">إضافة مادة تعليمية</a></li>
                <li id="submenu-active"><a href="DeleteLearn.aspx">حذف  مادة تعليمية</a></li>
                <li><a href="AddKGSubject.aspx"> إضافة موضوع </a></li>
                <li><a href="DeleteKGSubject.aspx"> حذف موضوع </a></li>
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
                           حذف مادة تعليمية من  رياض الأطفال</p>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            الصف </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnClasses" runat="server" Width="25%" 
                            DataSourceID="SqlDataSource1" DataTextField="ClassNameAR" 
                            DataValueField="ClassID" AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [Class] where ClassNameAR  LIKE 'KG%'"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            المادة التعليمية </p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrpDwnSubjects" runat="server" Width="25%" 
                            DataSourceID="SqlDataSource2" DataTextField="SubjectNameAR" 
                            DataValueField="SubjectID" AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT * FROM [Subject]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td style="width: 111px">
                        <p>
                            إسم المادة التعليمية</p>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" 
                            DataSourceID="SqlDataSource3" DataTextField="MaterialTitle" 
                            DataValueField="MaterialID" AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>" 
                            SelectCommand="SELECT [MaterialID], [MaterialTitle] FROM [Materials] WHERE (([ClassID] = @ClassID) AND ([SubjectID] = @SubjectID))">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DrpDwnClasses" Name="ClassID" 
                                    PropertyName="SelectedValue" Type="Int32" />
                                <asp:ControlParameter ControlID="DrpDwnSubjects" Name="SubjectID" 
                                    PropertyName="SelectedValue" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        
                    </td>
                </tr>
           
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="تمت  عملية الحذف بنجاح" 
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

