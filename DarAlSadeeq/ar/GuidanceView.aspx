<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="GuidanceView.aspx.cs" Inherits="DarAlSadeeq.ar.GuidanceView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main block9 no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">إرشادات للطفل</asp:Label>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-inner">
                <div id="Div1" class="subjectsContainer material" runat="server">
                    <table width="180px">
                        <tr>
                            <td align="center">
                                <asp:Image ID="ImgGuidance" runat="server" onclick="location.href='Guidance.aspx" Width="85" Height="85" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center">
                                <a id="GuidanceType" runat="server" style="font-size: large" href="Guidance.aspx"></a>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="subjectsContainer" class="subjectsContainer material" runat="server">
                    <asp:Label ID="lblGuidanceTitle" runat="server" Font-Size="16"></asp:Label>
                </div>
                <div id="materials" class="subjectsContainer materialsList" runat="server">
                    <asp:Label ID="lblBody" runat="server" Text="لا يوجد مواد لعرضها" Visible="false"></asp:Label>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <div style="padding-right: 20px; padding-top: 10px;">
                                <%# Eval("SubBody")%>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
