<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WorkSheets.aspx.vb" Inherits="ar_WorkSheets" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <title>Dar Al-Sadeeq :: Work Sheets</title>
    <!-- Styles Start-->
    <link rel="stylesheet" type="text/css" href="../style/reset-min.css" />
    <link rel="stylesheet" type="text/css" href="../style/style.css" />
    <link rel="stylesheet" type="text/css" href="../style/pages.css" />
    <!-- Styles End-->
    <!-- Script Start-->
    <script type="text/javascript" language="javascript" src="../javascript/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" language="javascript" src="../javascript/javascript.js"></script>
    <script type="text/javascript">
        function ClickServerSide(ClassID) {
            document.getElementById("<%=HD.ClientID %>").value = ClassID;
            document.getElementById("<%=btnServerSide.ClientID %>").click();
        }
    </script>
    <!-- Script End-->
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
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
                        <div class="block-main block2" onclick="nextFrame()">
                            <span id="workSheetsTab">Work Sheets</span></div>
                        <div class="block-main block3" onclick="location.href='Teacher.aspx'">
                            <span id="teachTab">Teacher</span></div>
                        <div class="block-main block4 no-margin" onclick="location.href='SongStories.aspx'">
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
                        <div class="block-main block10 clear-block" onclick="location.href='Talents.aspx'">
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
                                <div class="block-main workSheets no-margin" onclick="prevFrame()">
                                    <span>Work Sheets</span></div>
                                <h1>
                                    <div class="classes-container">
                                        <asp:HiddenField ID="HD" runat="server" />
                                        <div class="block-classes" onclick="viewSubjects();return ClickServerSide(1);" style="margin-right: 10px;">
                                            <span>KG1</span></div>
                                        <div class="block-classes blockKG2" onclick="viewSubjects();return ClickServerSide(2);">
                                            <span>KG2</span></div>
                                        <div class="block-classes block1st" onclick="viewSubjects();return ClickServerSide(3);">
                                            <span>1st Grade</span></div>
                                        <div class="block-classes block2nd" onclick="viewSubjects();return ClickServerSide(4);">
                                            <span>Second</span></div>
                                        <div class="block-classes block3rd" onclick="viewSubjects();return ClickServerSide(5);" style="margin-right: 10px;">
                                            <span>3rd</span></div>
                                        <div class="block-classes blockEnGrammar" onclick="viewSubjects();return ClickServerSide(6);">
                                            <span>Grammar</span></div>
                                               <div class="block-classes blockFrGames" onclick="viewSubjects();return ClickServerSide(11);">
                                            <span>French Games</span></div>
                                            <div class="block-classes blockEnGames" onclick="viewSubjects();return ClickServerSide(12);">
                                            <span>English Games</span></div>
                                            <div class="block-classes blockMathGames" onclick="viewSubjects();return ClickServerSide(13);" style="margin-right: 10px;">
                                            <span>Math Games</span></div>
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
                                                                <asp:Image ID="ImgSubject" runat="server" ImageUrl='<%#Eval("SubjectPic")%>'/>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="padding: 5px; text-align: center">
                                                                <a href='<%# "WorkSheetsMaterial.aspx?sid=" + Eval("ClassSubjectID").tostring%>' style="font-size: large">
                                                                    <%#Eval("SubjectNameEN")%></a>
                                                            </td>
                                                        </tr>
                                                    </table>
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
