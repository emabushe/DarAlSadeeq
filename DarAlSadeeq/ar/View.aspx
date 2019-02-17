<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="DarAlSadeeq.ar.View" %>

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
                                <asp:Image ID="ImgSubject" runat="server" Width="100" Height="70" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 5px; text-align: center">
                                <a id="aSubjectName" runat="server" style="font-size: large"></a>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="Div1" class="subjectsContainer material" runat="server">
                    <asp:Label ID="lblMaterialTitle" runat="server" CssClass="materialTitle"></asp:Label>
                </div>
                <div id="materials" class="subjectsContainer materialsList" runat="server">
                    <asp:Label ID="lblBody" runat="server" Text="لا يوجد مواد لعرضها" Visible="false"></asp:Label>
                    <div id="divFlashContent" runat="server">
                        <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=8,0,0,0">
                            <param name="wmode" value="transparent">
                            <embed  wmode="transparent" title="Dar Al-Sadeeq" id="flashViewer" runat="server" quality="high"
                                pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash" 
                                style="width: 600px;height: 400px;margin-right: 15%;"
                                type="application/x-shockwave-flash" />
                        </object>
                    </div>
                    <div id="divPDFContent" runat="server">
                        <div class="row" style="margin:10px">
                            <a class="btn btn-default btn-md" href="" runat="server" id="pdfURL" target="_blank">
                                <i class="fa fa-search-plus "></i>تكبير الكتاب</a>
                            <button type="button" class="btn btn-default btn-md" onclick="goBack()">
                                <i class="fa fa-chevron-circle-left "></i>رجوع</button>
                        </div>
                        <embed id="pdfViewer" runat="server" width="800" height="500" alt="pdf" pluginspage="http://www.adobe.com/products/acrobat/readstep2.html" />
                    </div>
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
