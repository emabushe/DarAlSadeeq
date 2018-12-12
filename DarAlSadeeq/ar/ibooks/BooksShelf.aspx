<%@ Page Title="" Language="VB" MasterPageFile="~/ar/ibooks/ibooks_Master.master"
    AutoEventWireup="false" CodeFile="BooksShelf.aspx.vb" Inherits="ar_ibooks_BooksShelf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentClassContainer" runat="Server">
    <div class="classes-container" style="background: url(../../images/Bookshelf.png);">
        <asp:Repeater ID="RepeateribBooks" runat="server">
            <ItemTemplate>
                <div style="float: right; width: 180px; padding: 5px; text-align: center; padding-top:24px;">
                    <table width="180px">
                        <tr>
                            <td align="center">
                                <asp:Image ID="ImgibBook" runat="server" ImageUrl='<%#Eval("ibBookIcon")%>' />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 5px; text-align: center">
                                <a href='<%# "Lessons.aspx?ibBookID=" + Eval("ibBookID").tostring%>'
                                    style="font-size: large;color:rgb(196, 218, 172);">
                                    <%# Eval("ibBookNameAR")%></a>
                            </td>
                        </tr>
                    </table>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
