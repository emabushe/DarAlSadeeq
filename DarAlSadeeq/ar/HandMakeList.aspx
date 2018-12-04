<%@ Page Language="VB" AutoEventWireup="false" CodeFile="HandMakeList.aspx.vb" Inherits="ar_HandMakeList" %>

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
    <title>دار الصديق :: أصنع بيدي</title>
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
    <div class="site-container">
        <div class="clouds-container">
            <div class="userBox">
                <ul>
                    <li><a href="#" id="registerTab">الإشتراكات</a></li>
                    <li><a href="#" id="loginTab">تسجيل الدخول</a></li>
                </ul>
            </div>
            <div class="enlanguage">
                <ul>
                    <li><a href="#" onclick="toEn(window.location);">English</a></li>
                </ul>
            </div>
            <div id="everythingInside" class="everything-inside">
                <div id="page1" style="display: none;">
                    <div class="blocks-container">
                        <div class="block-main" onclick="location.href='ibooks.aspx'">
                            <span id="eBooksTab">الكتب الإلكترونية</span></div>
                        <div class="block-main block2" onclick="location.href='WorkSheets.aspx'">
                            <span id="workSheetsTab">أوراق عمل</span></div>
                        <div class="block-main block3" onclick="location.href='Teacher.aspx'">
                            <span id="teachTab">للمعلم</span></div>
                        <div class="block-main block4 no-margin" onclick="location.href='SongStories.aspx'">
                            <span id="songStoriesTab">أغاني وقصص</span></div>
                        <div class="block-main block5" onclick="location.href='LinkGames.aspx'">
                            <span id="gamesTab">ألعاب</span></div>
                        <div class="block-main block6" onclick="location.href='Activities.aspx'">
                            <span id="activitiesTab">أنشطة</span></div>
                        <div class="block-main block7" onclick="location.href='Guidance.aspx'">
                            <span id="guidanceTab">إرشادات للطفل</span></div>
                        <div class="block-main block8" onclick="location.href='HandMake.aspx'">
                            <span id="handMakeTab">أصنع بيدي</span></div>
                        <div class="block-main block9" onclick="location.href='ChangeYourLife.aspx'">
                            <span id="changeYourLifeTab">غير حياتك</span></div>
                        <div class="block-main block10 clear-block" onclick="location.href='Talents.aspx'">
                            <span id="talentsTab">مواهب</span></div>
                        <div class="logo-img">
                        </div>
                        <div class="footerDiv">
                            <ul>
                                <li><a href="Partners.aspx" id="partnersTab">شركاؤنا</a> * <a href="Schools.aspx"
                                    id="schoolsTab">مدارسنا </a></li>
                                <li style="padding-top: 10px"><a href="AboutUs.aspx" id="aboutUsTab">من نحن</a> * <a
                                    href="ContactUs.aspx" id="contactUsTab">إتصل بنا</a></li></ul>
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
                          <div class="block-main handMake no-margin" onclick="prevFrameNotSubjects();">
                            <span>أصنع بيدي</span></div>
                            <h1>
                                <div id="subjectsContainer" class="subjectsContainer material" runat="server" onclick="location.href='HandMake.aspx">
                                    <table width="180px">
                                        <tr>
                                            <td align="center">
                                                <asp:Image ID="ImgSubject" runat="server" 
                                                    Width="85" Height="85" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: center">
                                                <a id="aHandMakeName" runat="server" style="font-size: large" href="HandMake.aspx">
                                                </a>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <div id="materials" class="subjectsContainer materialsList" runat="server">
                                    <asp:Label ID="lblBody" runat="server" Text="لا يوجد مواد لعرضها" Visible="false"></asp:Label>
                                    <asp:Repeater ID="Repeater1" runat="server">
                                        <ItemTemplate>
                                            <li><a href='<%# "HandMakeView.aspx?mid=" + Eval("ID").tostring%>' id="link1" runat="server">
                                                <%# Eval("HandMakeSub")%></a>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </h1>
                            <div class="logo-img">
                            </div>
                             <div class="footerDiv">
                                    <ul>
                                        <li><a href="Partners.aspx" id="A1">شركاؤنا</a> * <a href="Schools.aspx" id="A2">مدارسنا
                                        </a></li>
                                        <li style="padding-top: 10px"><a href="AboutUs.aspx" id="a3">من نحن</a> * <a href="ContactUs.aspx"
                                            id="A4">إتصل بنا</a></li></ul>
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
