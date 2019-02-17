<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="WorkSheetsMaterial.aspx.cs" Inherits="DarAlSadeeq.ar.WorkSheetsMaterial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main workSheets no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">أوراق عمل</asp:Label>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-inner">
                <div class="classes-container material">
                    <asp:HiddenField ID="HD" runat="server" />
                    <div id="classDiv" runat="server" class="block-classes"
                        style="margin-right: 10px;">
                        <span><a id="aClassName" runat="server" style="color: #FFF;"></a></span>
                    </div>
                </div>
                <div id="subjectsContainer" class="subjectsContainer material" runat="server">
                    <table width="180px">
                        <tr>
                            <td align="center">
                                <asp:Image ID="ImgSubject" runat="server" onclick="viewMaterials()" Width="100" Height="70" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 5px; text-align: center">
                                <a id="aSubjectName" runat="server" style="font-size: large" onclick="viewMaterials()"></a>
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
                            <li><a href='<%# "view.aspx?mid=" + Eval("MaterialID")%>' id="link1" runat="server">
                                <%#Eval("MaterialTitle")%></a>
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
