<%@ Page Title="" Language="VB" MasterPageFile="~/ar/ibooks/ibooks_Master.master"
    AutoEventWireup="false" CodeFile="Lessons.aspx.vb" Inherits="ar_ibooks_Lessons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentClassContainer" runat="Server">
    <div class="classes-container material">
        <div id="classDiv" runat="server" class="block-classes" style="margin-right: 10px;">
            <span><a id="aClassName" runat="server" style="color: #FFF;"></a></span>
        </div>
    </div>
    <div id="subjectsContainer" class="subjectsContainer material" runat="server">
        <table width="180px">
            <tr>
                <td style="padding: 25px; text-align: center">
                    <a id="ibBookName" runat="server" style="font-size: large" onclick="viewMaterials()">
                    </a>
                </td>
            </tr>
        </table>
    </div>
    <div id="materials" class="subjectsContainer materialsList" runat="server">
        <asp:Label ID="lblBody" runat="server" Text="لا يوجد مواد لعرضها" Visible="false"></asp:Label>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li><a href='<%# "LessonViewer.aspx?ibLessonID=" + Eval("ibLessonID").tostring%>' id="link1" runat="server">
                    <%#Eval("ibLessonNameAr")%></a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
