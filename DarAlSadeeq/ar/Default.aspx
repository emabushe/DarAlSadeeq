<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="ar_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <script>
        (function (i, s, o, g, r, a, m) {
        i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
            (i[r].q = i[r].q || []).push(arguments)
        }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');
        ga('create', 'UA-26594561-10', 'auto');
        ga('send', 'pageview');
    </script>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta http-equiv="content-language" content="en" />
    <title>دار الصديق للنشر والتوزيع</title>
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
                <div class="content-container">
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
                        <div id="page1">
                            <div class="blocks-container">
                                <div class="block-main" onclick="location.href='OurProducts.aspx'">
                                    <span id="gamesTab">إنتجاتنا</span>
                                </div>
                                <div class="block-main block2" onclick="location.href='ibooks.aspx'">
                                    <span id="eBooksTab">المنهاج الإلكتروني</span>
                                </div>
                                <div class="block-main block3" onclick="location.href='Stories.aspx?Level=1'">
                                    <span id="storiesTab">منهاج المستوى الأول</span>
                                </div>
                                <div class="block-main block4" onclick="location.href='Books.aspx'">
                                    <span>الكتب المطبوعة</span>
                                </div>
                                <div class="block-main block5" onclick="location.href='Stories.aspx'">
                                    <span>القصص</span>
                                </div>
                                <div class="block-main block6" onclick="location.href='WorkSheets.aspx'">
                                    <span id="workSheetsTab">أوراق عمل</span>
                                </div>
                                <div class="block-main block7" onclick="location.href='Teacher.aspx'">
                                    <span id="teachTab">للمعلم</span>
                                </div>
                                <div class="block-main block8 no-margin" onclick="location.href='SongStories.aspx'">
                                    <span id="songStoriesTab">فيديوهات</span>
                                </div>
                                <div class="block-main block9" onclick="location.href='Guidance.aspx'">
                                    <span id="guidanceTab">إرشادات للطفل والأسرة</span>
                                </div>
                                <div class="block-main block10 clear-block" onclick="location.href='ChangeYourLife.aspx'">
                                    <span id="changeYourLifeTab">غير حياتك</span>
                                </div>
                                <div class="logo-img">
                                </div>
                                <div class="footerDiv">
                                    <ul>
                                        <li><a href="Partners.aspx" id="partnersTab">شركاؤنا</a> * <a href="Schools.aspx"
                                            id="schoolsTab">مدارسنا </a></li>
                                        <li style="padding-top: 10px"><a href="AboutUs.aspx" id="aboutUsTab">من نحن</a> * <a
                                            href="ContactUs.aspx" id="contactUsTab">إتصل بنا</a></li>
                                    </ul>
                                </div>
                                <div class="smIcons">
                                    <a href="http://www.facebook.com/daralsadeeq" class="fb" target="_blank"></a><a href="http://www.youtube.com/daralsadeeq"
                                        class="youtube" target="_blank"></a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="main-footer">
                        © 2009-<script type="text/javascript">                           var mdate = new Date(); document.write(mdate.getFullYear());</script>All
                content is copyrighted for Dar Al-Sadeeq publication and distribution and their
                respective publishers. Powered by <a href="http://www.shkhaidem.com" target="_blank">Shkhaidem</a>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
