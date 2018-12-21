<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="DarAlSadeeq.ar.AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main generalTab no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">من نحن</asp:Label>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-inner">
                <div class="classes-container teacher">
                    <asp:HiddenField ID="HD" runat="server" />
                    <div class="block-classes" onclick="viewSubjects();return ClickServerSide('about1');"
                        style="margin-right: 10px;">
                        <span>دار الصديق</span>
                    </div>
                    <div class="block-classes blockKG2" onclick="viewSubjects();return ClickServerSide('about2');">
                        <span>اقسام الموقع</span>
                    </div>
                    <div class="block-classes block1st" onclick="viewSubjects();return ClickServerSide('about3');">
                        <span>تعريف السلسلة</span>
                    </div>
                    <div class="block-classes block2nd" onclick="viewSubjects();return ClickServerSide('about4');">
                        <span>دورات تدريبية</span>
                    </div>
                    <asp:Button runat="server" ID="btnServerSide" Text="null" OnClick="btnServerSide_Click"
                        CssClass="hidden" />
                </div>
                <div id="subjectsArrow" class="subjectsArrow" runat="server">
                </div>
                <div id="subjectsContainer" class="subjectsContainer teacher" runat="server">
                    <asp:Label ID="lblBody" runat="server" Text=""></asp:Label>
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
