<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="GuidanceList.aspx.cs" Inherits="DarAlSadeeq.ar.GuidanceList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main block9 no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">إرشادات للطفل</asp:Label>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-inner">
                <div id="subjectsContainer" class="subjectsContainer material" runat="server" onclick="location.href='Guidance.aspx">
                    <table width="180px">
                        <tr>
                            <td align="center">
                                <asp:Image ID="ImgSubject" runat="server"
                                    Width="85" Height="85" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center">
                                <a id="aGuidanceName" runat="server" style="font-size: large" href="Guidance.aspx"></a>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="divBack" class="subjectsContainer material" runat="server">
                    <button type="button" class="btn btn-default btn-lg" onclick="goBack()" style="margin: 20%;">
                        <i class="fa fa-chevron-circle-left "></i>رجوع</button>
                </div>
                <div id="materials" class="subjectsContainer materialsList" runat="server">
                    <asp:Label ID="lblBody" runat="server" Text="لا يوجد مواد لعرضها" Visible="false"></asp:Label>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <li><a href='<%# "GuidanceView.aspx?mid=" + Eval("ID")%>' id="link1" runat="server">
                                <%# Eval("ErshadSub")%></a>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
      <script>
        function goBack() {
            window.history.back();
        }
    </script>
</asp:Content>
