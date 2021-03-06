﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Talents.aspx.vb" Inherits="ar_Talents" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');
  ga('create', 'UA-26594561-10', 'auto');
  ga('send', 'pageview');
</script>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta http-equiv="content-language" content="enss" />
    <title>Dar Al-Sadeeq :: Talents</title>
    <!-- Styles Start-->
    <link rel="stylesheet" type="text/css" href="../style/reset-min.css" />
    <link rel="stylesheet" type="text/css" href="../style/style.css" />
    <link rel="stylesheet" type="text/css" href="../style/pages.css" />
    <!-- Styles End-->
    <!-- Script Start-->
    <script type="text/javascript" language="javascript" src="../javascript/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" language="javascript" src="../javascript/javascript.js"></script>
    <!-- Script End-->
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
        SelectCommand="SELECT * FROM [Talents]"></asp:SqlDataSource>
    <div class="site-container">
        <div class="clouds-container">
               <div class="userBox">
                <ul>
                    <li><a href="#" id="registerTab">Register</a></li>
                    <li><a href="#" id="loginTab">Login</a></li>
                </ul>
            </div>
            <div class="arlanguage">
                <ul>
                    <li><a href="#" onclick="toAr(window.location);">عربي</a></li>
                </ul>
            </div>
            <div id="everythingInside" class="everything-inside">
                <div id="page1" style="display: none;">
                    <div class="blocks-container">
                        <div class="block-main" onclick="location.href='ibooks.aspx'">
                            <span id="eBooksTab">Interactive Books</span></div>
                        <div class="block-main block2" onclick="location.href='WorkSheets.aspx'">
                            <span id="workSheetsTab">Work Sheets</span></div>
                        <div class="block-main block3" onclick="location.href='Teacher.aspx'">
                            <span id="teachTab">Teacher</span></div>
                        <div class="block-main block4 no-margin" onclick="nextFrame()'">
                            <span id="songStoriesTab">Songs & Stories</span></div>
                        <div class="block-main block5" onclick="location.href='LinkGames.aspx'">
                            <span id="gamesTab">Games</span></div>
                        <div class="block-main block6" onclick="location.href='Activities.aspx'">
                            <span id="activitiesTab">Activities</span></div>
                        <div class="block-main block7" onclick="location.href='Guidance.aspx'">
                            <span id="guidanceTab">Tips for Kids</span></div>
                        <div class="block-main block8" onclick="location.href='HandMake.aspx'">
                            <span id="handMakeTab">Artcraft</span></div>
                        <div class="block-main block9" onclick="location.href='ChangeYourLife.aspx'">
                            <span id="changeYourLifeTab">Change Your Life</span></div>
                        <div class="block-main block10 clear-block" onclick="nextFrame()">
                            <span id="talentsTab">Talents</span></div>
                        <div class="logo-img en">
                        </div>
                        <div class="footerDiv">
                            <ul>
                                <li><a href="Partners.aspx" id="partnersTab">Partners</a> * <a href="Schools.aspx"
                                    id="schoolsTab">Schools </a></li>
                                <li style="padding-top: 10px"><a href="AboutUs.aspx" id="aboutUsTab">About Us</a> * <a
                                    href="ContactUs.aspx" id="contactUsTab">Contact Us</a></li></ul>
                        </div>
                        <div class="smIcons">
                            <a href="http://www.facebook.com/daralsadeeq" class="fb" target="_blank"></a><a href="http://www.youtube.com/daralsadeeq"
                                class="youtube" target="_blank"></a>
                        </div>
                    </div>
                </div>
                <div id="page2">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                    <div class="blocks-container">
                        <div class="block-main talents no-margin" onclick="prevFrameNotSubjects();">
                            <span>Talents</span></div>
                        <h1>
                            <div id="subjectsContainer" class="subjectsContainer SongStories">
                                <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                                    <ItemTemplate>
                                        <div style="width: 661px; height: 173px; float: right; background-image: url(../images/Talent.PNG)">
                                            <div style="width: 100%; height: 17px; float: right">
                                            </div>
                                            <div style="width: 30px; height: 156px; float: right">
                                            </div>
                                            <div style="width: 120px; height: 120px; float: right">
                                                <asp:ImageButton ID="ImageButton1" runat="server" Height="100%" Width="100%" ImageUrl='<%#Eval("StudentPic") %>'
                                                    AccessKey="1" CssClass="talentsPic" />
                                                <cc1:ModalPopupExtender ID="ModalPopupExtender13" runat="server" TargetControlID="ImageButton1"
                                                    PopupControlID="Panel12" OkControlID="" CancelControlID="ImageButton13" BackgroundCssClass="modalBackground"
                                                    DynamicServicePath="" Enabled="True" />
                                                <asp:Panel ID="Panel12" runat="server" Style="display: none; width: auto; background-color: White;
                                                    border-width: 2px; border-color: Black; border-style: solid; padding: 5px;z-index: 10001;
                                                        left: 457.5px; top: 143.5px;">
                                                    <div style="text-align: right;">
                                                        <asp:ImageButton ID="ImageButton13" Text="Cancel" runat="server" ImageUrl="~/images/close.JPG" /></div>
                                                    <asp:Image ID="Img_Talent" runat="server" ImageUrl='<%#Eval("TalentPic") %>' />
                                                </asp:Panel>
                                            </div>
                                            <div style="width: 110px; height: 125px; float: right">
                                            </div>
                                            <div style="width: 190px; height: 125px; float: right; text-align: right">
                                                <div class="talentsInfo">
                                                    <asp:Label ID="lbl_title" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                                                </div>
                                                <div class="talentsInfo">
                                                    <asp:Label ID="lbl_description" runat="server" Text='<%#Eval("Age") %>'></asp:Label>
                                                </div>
                                                <div class="talentsInfo">
                                                    <asp:Label ID="lbl_School" runat="server" Text='<%#Eval("School") %>'></asp:Label></div>
                                                <div class="talentsInfo">
                                                    <asp:Label ID="lbl_Hobbies" runat="server" Text='<%#Eval("Hobbies") %>'></asp:Label>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </h1>
                        <div class="logo-img en">
                        </div>
                         <div class="footerDiv">
                            <ul>
                                <li><a href="Partners.aspx" id="A1">Partners</a> * <a href="Schools.aspx"
                                    id="A2">Schools </a></li>
                                <li style="padding-top: 10px"><a href="AboutUs.aspx" id="a3">About Us</a> * <a
                                    href="ContactUs.aspx" id="A4">Contact Us</a></li></ul>
                        </div>
                                <div class="smIcons">
                                    <a href="http://www.facebook.com/daralsadeeq" class="fb" target="_blank"></a><a href="http://www.youtube.com/daralsadeeq"
                                        class="youtube" target="_blank"></a>
                                </div>
                    </div>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <div class="main-footer">
                © 2009-<script type="text/javascript">                           var mdate = new Date(); document.write(mdate.getFullYear());</script>All
                content is copyrighted for Dar Al-Sadeeq publication and distribution and their
                respective publishers. Powered by <a href="http://www.shkhaidem.com" target="_blank">
                    Shkhaidem</a></div>
        </div>
    </div>
    </form>
</body>
</html>
