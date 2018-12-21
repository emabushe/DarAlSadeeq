<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="Guidance.aspx.cs" Inherits="DarAlSadeeq.ar.Guidance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main block9 no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">إرشادات للطفل</asp:Label>
    </div>
    <div class="content-inner">
        <div id="subjectsContainer" class="subjectsContainer SongStories">
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <div style="float: right; width: 180px; text-align: center">
                        <table width="180px">
                            <tr>
                                <td align="center" style="padding-top: 20px;">
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Pic")%>' Width="100" Height="100" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center"><a href='<%# "GuidanceList.aspx?sid=" + Eval("ID")%>' style="font-size: large"><%#Eval("Type")%></a>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
        SelectCommand="SELECT [ID], [Type], [Pic] FROM [Ershad]"></asp:SqlDataSource>
    </div>
</asp:Content>
