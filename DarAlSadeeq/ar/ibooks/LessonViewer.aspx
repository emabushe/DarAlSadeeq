<%@ Page Title="" Language="VB" MasterPageFile="~/ar/ibooks/ibooks_Master.master"
    AutoEventWireup="false" CodeFile="LessonViewer.aspx.vb" Inherits="ar_ibooks_LessonViewer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentClassContainer" runat="Server">
    <div id="subjectsContainer" class="subjectsContainer material" runat="server" style="height: 42px; width: 240px;">
        <table width="250px">
            <tr>
                <td style="padding: 11px; text-align: center">
                    <a id="ibBookName" runat="server" style="font-size: large"></a>
                </td>
            </tr>
        </table>
    </div>
    <div id="materials" class="subjectsContainer materialsList" runat="server" style="width: 100%; height:520px;">
        <asp:Label ID="lblBody" runat="server" Text="لا يوجد مواد لعرضها" Visible="false"></asp:Label>
        <iframe src="Level2/P2/L1/story_html5.html" width="670px" height="490px" style="border-width: 0px;" id="LsnFrame" runat="server"></iframe>
    </div>
</asp:Content>
