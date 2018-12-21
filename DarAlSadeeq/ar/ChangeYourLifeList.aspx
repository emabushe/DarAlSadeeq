<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="ChangeYourLifeList.aspx.cs" Inherits="DarAlSadeeq.ar.ChangeYourLifeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main block10 no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">غير حياتك</asp:Label>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-inner">
                <div id="subjectsContainer" class="subjectsContainer material" runat="server" onclick="location.href='ChangeYourLife.aspx">
                    <table width="180px">
                        <tr>
                            <td align="center">
                                <asp:Image ID="ImgSubject" runat="server"
                                    Width="85" Height="85" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center">
                                <a id="aChangeYourLifeName" runat="server" style="font-size: large" href="ChangeYourLife.aspx"></a>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="materials" class="subjectsContainer materialsList" runat="server">
                    <asp:Label ID="lblBody" runat="server" Text="لا يوجد مواد لعرضها" Visible="false"></asp:Label>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <li><a href='<%# "ChangeYourLifeView.aspx?mid=" + Eval("ID")%>' id="link1" runat="server">
                                <%# Eval("Title")%></a>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
