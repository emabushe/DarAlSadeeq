<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeFile="Partners.aspx.cs" Inherits="DarAlSadeeq.ar.Partners" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
        SelectCommand="SELECT * FROM [HandMake]"></asp:SqlDataSource>
    <div id="divTitle" runat="server" class="block-main generalTab no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">شركاؤنا</asp:Label>
    </div>
    <div class="content-inner">
        <div id="subjectsContainer" class="subjectsContainer SongStories">
            <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource2">
                <ItemTemplate>
                    <div style="float: right; width: 200px; padding-top: 20px; text-align: center" align="center">
                        <table width="200px">
                            <tr>
                                <td align="center">
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("PartnerPic")%>' Width="100"
                                        Height="97" />
                                </td>
                            </tr>
                            <tr>
                                <td style="padding: 5px; text-align: center">
                                    <a href='<%#Eval("PartnerURL")%>' style="font-size: large; font-family: Calibri; text-decoration: none;"
                                        target="_blank">
                                        <%# Eval("PartnerName")%></a>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                SelectCommand="SELECT * FROM [Partners]"></asp:SqlDataSource>
        </div>
    </div>
     
</asp:Content>
