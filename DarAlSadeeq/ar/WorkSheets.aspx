<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="WorkSheets.aspx.cs" Inherits="DarAlSadeeq.ar.WorkSheets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main workSheets no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">أوراق عمل</asp:Label>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-inner">
                <div class="classes-container">
                    <asp:HiddenField ID="HD" runat="server" />
                    <div class="block-classes" onclick="viewSubjects();return ClickServerSide(1);" style="margin-right: 10px;">
                        <span>KG1</span>
                    </div>
                    <div class="block-classes blockKG2" onclick="viewSubjects();return ClickServerSide(2);">
                        <span>KG2</span>
                    </div>
                    <div class="block-classes block1st" onclick="viewSubjects();return ClickServerSide(3);">
                        <span>الصف الأول</span>
                    </div>
                    <div class="block-classes block2nd" onclick="viewSubjects();return ClickServerSide(4);">
                        <span>الصف الثاني</span>
                    </div>
                    <div class="block-classes block3rd" onclick="viewSubjects();return ClickServerSide(5);" style="margin-right: 10px;">
                        <span>الصف الثالث</span>
                    </div>
                    <div class="block-classes blockEnGrammar" onclick="viewSubjects();return ClickServerSide(6);">
                        <span>إنجليزي قواعد</span>
                    </div>
                    <asp:Button runat="server" ID="btnServerSide" Text="null" OnClick="btnServerSide_Click"
                        CssClass="hidden" />
                </div>
                <div id="subjectsArrow" class="subjectsArrow" runat="server">
                </div>
                <div id="subjectsContainer" class="subjectsContainer" runat="server">
                    <asp:Repeater ID="RepeaterSubjects" runat="server">
                        <ItemTemplate>
                            <div style="float: right; width: 180px; padding: 5px; text-align: center">
                                <table width="180px">
                                    <tr>
                                        <td align="center">
                                            <asp:Image ID="ImgSubject" runat="server" ImageUrl='<%#Eval("SubjectPic")%>' />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="padding: 5px; text-align: center">
                                            <a href='<%# "WorkSheetsMaterial.aspx?sid=" + Eval("ClassSubjectID")
%>'
                                                style="font-size: large">
                                                <%#Eval("SubjectNameAR")%></a>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <script type="text/javascript">
        function ClickServerSide(ClassID) {
            document.getElementById("<%=HD.ClientID %>").value = ClassID;
            document.getElementById("<%=btnServerSide.ClientID %>").click();
        }
    </script>
</asp:Content>
