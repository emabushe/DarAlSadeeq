﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ar/MasterPage.master" AutoEventWireup="true" CodeBehind="ContentViewer.aspx.cs" Inherits="DarAlSadeeq.ar.ContentViewer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divTitle" runat="server" class="block-main no-margin" onclick="prevFrame()" style="position: absolute;">
        <asp:Label ID="lblSectionTitle" runat="server">دار الصديق</asp:Label>
    </div>
    <div class="content-inner">
        <div class="row" style="margin-top: 5px; width: 90%;">
            <div id="divPagesContent" runat="server">
                <div class="row">
                    <button type="button" class="btn btn-default btn-md" onclick="goBack()">
                        <i class="fa fa-chevron-circle-left "></i>رجوع</button>
                </div>
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
                <div class="row">
                    <a class="btn btn-default btn-md" href="" runat="server" id="pdfURL" target="_blank">
                        <i class="fa fa-search-plus "></i>تكبير الكتاب</a>
                    <button type="button" class="btn btn-default btn-md" onclick="goBack()">
                        <i class="fa fa-chevron-circle-left "></i>رجوع</button>
                </div>
                <embed id="pdfViewer" runat="server" width="600" height="500" alt="pdf" pluginspage="http://www.adobe.com/products/acrobat/readstep2.html" />
            </div>
             <div id="divFlashContent" runat="server">
                <div class="row">
                    <button type="button" class="btn btn-default btn-md" onclick="goBack()">
                        <i class="fa fa-chevron-circle-left "></i>رجوع</button>
                </div>
                <embed id="flashViewer" runat="server" width="600" height="500" alt="FLASH"  pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash"  />
            </div>
            <div id="divHTMLContent" runat="server">
                <div class="row">
                    <a class="btn btn-default btn-md" href="" runat="server" id="ebookURL" target="_blank">
                        <i class="fa fa-search-plus "></i>تكبير</a>
                    <button type="button" class="btn btn-default btn-md" onclick="goBack()">
                        <i class="fa fa-chevron-circle-left "></i>رجوع</button>
                </div>
                <iframe id="htmlViewer" runat="server" width="600" height="500"></iframe>
            </div>
            <div id="divImageContent" runat="server">
                <div class="row">
                    <button type="button" class="btn btn-default btn-md" onclick="goBack()">
                        <i class="fa fa-chevron-circle-left "></i>رجوع</button>
                    <div class="row">
                        <div class="text-center">
                            <asp:Label runat="server" ID="lblTitle"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2"></div>
                        <div class="col-md-8">
                            <asp:Image runat="server" ID="imgContent" Style="width: 75%" />
                        </div>
                        <div class="col-md-2"></div>
                    </div>
                    <div class="row" style="margin: 10px;">
                        <div class="col-md-12">
                            <asp:Label runat="server" ID="lblDescription" Style="font-size: 12pt;"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <div id="divYoutubeContent" runat="server">
                <div class="row">
                    <button type="button" class="btn btn-default btn-md" onclick="goBack()">
                        <i class="fa fa-chevron-circle-left "></i>رجوع</button>
                </div>
                <div runat="server" id="divYoutube"></div>
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
    <script>
        function goBack() {
            window.history.back();
        }
    </script>
</asp:Content>
