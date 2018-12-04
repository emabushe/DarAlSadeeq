<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ContactUs.aspx.vb" Inherits="ar_ContactUs" %>

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
    <title>دار الصديق :: إتصل بنا</title>
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
                    <div class="blocks-container">
                        <div class="block-main generalTab no-margin" onclick="prevFrameNotSubjects();">
                            <span style="color: #79471D">إتصل بنا</span></div>
                        <h1>
                            <div id="subjectsContainer" class="subjectsContainer SongStories" style="display: block;">
                                <table>
                                    <tr>
                                        <td style="padding-left: 15px;">
                                            <iframe width="250" height="250" frameborder="0" scrolling="no" marginheight="0"
                                                marginwidth="0" src="http://maps.google.com/maps?q=31.978597,35.902011&amp;num=1&amp;t=h&amp;vpsrc=6&amp;doflg=ptk&amp;ie=UTF8&amp;ll=31.978522,35.902162&amp;spn=0.010921,0.012875&amp;z=15&amp;output=embed">
                                            </iframe>
                                            <br />
                                            <small><a href="http://maps.google.com/maps?q=31.978597,35.902011&amp;num=1&amp;t=h&amp;vpsrc=6&amp;doflg=ptk&amp;ie=UTF8&amp;ll=31.978522,35.902162&amp;spn=0.010921,0.012875&amp;z=15&amp;source=embed"
                                                style="color: #0000FF; text-align: left"></a></small>
                                        </td>
                                        <td>
                                            <div class="contactForm">
                                                <table width="100%">
                                                    <tr class="spaceUnder">
                                                        <td>
                                                            الإسم:
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtName" runat="server" Width="250"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr class="spaceUnder">
                                                        <td>
                                                            الإيميل:
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtEmail" runat="server" Width="250"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr class="spaceUnder">
                                                        <td>
                                                            الموضوع:
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtSubject" runat="server" Width="250"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr class="spaceUnder">
                                                        <td>
                                                            الرسالة:
                                                        </td>
                                                        <td>
                                                            <asp:TextBox ID="txtBody" runat="server" Width="250" TextMode="MultiLine" Height="200"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr class="spaceUnder">
                                                        <td>
                                                        </td>
                                                        <td style="text-align: center;">
                                                            <asp:Button ID="Button1" runat="server" Text="إرسال" Width="70" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="2">
                                                            <asp:Label ID="lblResult" runat="server" Visible="False"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <span class="contactInfo" style="direction:rtl;">تلفون: +962 6 5656404/5</br> فاكس: +962 6 5656402</br> ص .ب
                                                641 عمان 11941 الأردن</br> info@daralsadeeq.com</br></span>
                                        </td>
                                    </tr>
                                </table>
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
                </div>
                <div class="pop-bg" id="login" style="display: none;">
                    <div class="pop-content">
                        <div class="closebtn" title="Close" id="closebtn" onclick="closePopUp()">
                        </div>
                        <h1>
                            Hello World!</h1>
                        <p>
                            This is a neat little trick to get a modal popup dialog box in your web pages without
                            disturbing the user experience or dsitracting them with popup windows or new tabs...
                        </p>
                        <p>
                            The <strong>popup dialog</strong> uses javascript (jQuery) and CSS to create a modal
                            dialog that will retain focus over the parent window until it is closed. The trick
                            is simple. We use block-elements (divs) to create the dialog window. The CSS rules
                            for <em>position</em>, <em>float</em>, <em>top</em>, <em>left</em>/<em>right</em>,
                            and <em>opacity</em> (or CSS3 transparency) allows us to create a semi-transparent
                            div over the entire page, thereby creating the illusion of modalness. The other
                            div then takes focus over the center of the window.
                        </p>
                        <img src="http://sheriframadan.com/examples/uploadz/4W6Xs.jpg" width="200" height="252">
                        <p>
                            We can also retain content view control over the modal dialog with the <em>overflow</em>
                            CSS property. This means no matter what we place inside of our dialog window the
                            content will remain inside of the defined bounds even if scrolling becomes necessary
                            within the div.
                        </p>
                    </div>
                </div>
            </div>
            <div class="main-footer">
                © 2009-<script type="text/javascript">                           var mdate = new Date(); document.write(mdate.getFullYear());</script>All
                content is copyrighted for Dar Al-Sadeeq publication and distribution and their
                respective publishers. Powered by <a href="http://www.shkhaidem.com" target="_blank">
                    Shkhaidem</a></div>
        </div>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
        SelectCommand="SELECT * FROM [Songs]"></asp:SqlDataSource>
    </form>
</body>
</html>
