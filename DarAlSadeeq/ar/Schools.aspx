<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeFile="Schools.aspx.cs" Inherits="DarAlSadeeq.ar.Schools" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
        SelectCommand="SELECT [SchoolNameAR], [SchoolURL], [SchoolLogo] FROM [Schools] Where (IsBooksSchool = 1) ORDER BY [SchoolLogo] DESC"></asp:SqlDataSource>
    <div id="divTitle" runat="server" class="block-main generalTab no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">مدارسنا</asp:Label>
    </div>
    <div class="content-inner">
        <div id="subjectsContainer" class="subjectsContainer SongStories">
            <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <div style="float: right; width: 200px; padding-top: 20px; text-align: center" align="center">
                        <table width="200px">
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("SchoolLogo")%>' Width="100"
                                        Height="97" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding: 5px; text-align: center">
                                    <a href='<%#Eval("SchoolURL")%>' style="font-size: large; text-decoration: none;"
                                        target="_blank">
                                        <%# Eval("SchoolNameAR")%></a>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

    </div>
</asp:Content>
