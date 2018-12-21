<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="ContentViewer.aspx.cs" Inherits="DarAlSadeeq.ar.ContentViewer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">دار الصديق</asp:Label>
    </div>
    <div class="content-inner">
        <div class="row" style="margin-top: 10px">
        <div id="divPagesContent" runat="server">
            <div class="flipbook-viewport">
                <div class="container">
                    <div class="flipbook">
                        <asp:Repeater ID="rptPages" runat="server">
                            <ItemTemplate>
                                <div style="background-image: url('<%# Eval("PagePath")%>'); width: 300px; height: 500px"></div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
        <div id="divPDFContent" runat="server">
                 <embed id="pdfViewer" runat="server" width="600" height="500" alt="pdf" pluginspage="http://www.adobe.com/products/acrobat/readstep2.html">
            </embed>
        </div>
    </div>
    </div>
    <script type="text/javascript">
        function loadApp() {
            // Create the flipbook
            $('.flipbook').turn({
                // Width
                width: 700,
                // Height
                height: 500,
                // Elevation
                elevation: 20,
                // Enable gradients
                gradients: true,
                // Auto center this flipbook
                autoCenter: false,
                direction: 'rtl'
            });
        }
        // Load the HTML4 version if there's not CSS transform
        yepnope({
            test: Modernizr.csstransforms,
            yep: ['../javascript/turn.js'],
            nope: ['../javascript/turn.html4.min.js'],
            both: ['../style/basic.css'],
            complete: loadApp
        });
    </script>
</asp:Content>
