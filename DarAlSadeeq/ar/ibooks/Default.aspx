<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="ar_ibooks_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <script type="text/javascript">
        var _gaq = _gaq || [];
        _gaq.push(['_setAccount', 'UA-26594561-2']);
        _gaq.push(['_setDomainName', '.daralsadeeq.com']);
        _gaq.push(['_trackPageview']);
        (function () {
            var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
            ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
            var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
        })();
    </script>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta http-equiv="content-language" content="enss" />
    <title>دار الصديق :: أوراق عمل</title>
    <!-- Styles Start-->
    <link rel="stylesheet" type="text/css" href="../../style/reset-min.css" />
    <link rel="stylesheet" type="text/css" href="../../style/style.css" />
    <link rel="stylesheet" type="text/css" href="../../style/pages.css" />
    <link rel="stylesheet" type="text/css" href="../../style/ibooks.css" />
    <!-- Styles End-->
    <!-- Script Start-->
    <script type="text/javascript" language="javascript" src="../../javascript/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" language="javascript" src="../../javascript/javascript.js"></script>
    <%--<script type="text/javascript">
        function ClickServerSide(ClassID) {
            document.getElementById("<%=HD.ClientID %>").value = ClassID;
            document.getElementById("<%=btnServerSide.ClientID %>").click();
        }
    </script>--%>
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
                <div id="page1" >
                    <div class="blocks-container">
                        <div class="block-main no-margin" onclick="prevFrame()" style="position:absolute;">
                            <span>الكتب الإلكترونية</span></div>
                        <h1>
                            <div class="classes-container" style="height: 110px;">
                                <asp:Repeater ID="RptClasses" runat="server" DataSourceID="SqlDataSourceibClasses">
                                    <ItemTemplate>
                                        <div class='<%# Eval("ibClassStyle")%>' onclick="location.href='BooksShelf.aspx?ibClassID=<%# Eval("ibClassID")%>'">
                                            <span id="eBooksTab">
                                                <%# Eval("ibClassNameAr")%></span></div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <asp:SqlDataSource ID="SqlDataSourceibClasses" runat="server" ConnectionString="<%$ ConnectionStrings:Dar_AlsadiqConnectionString %>"
                                    SelectCommand="SELECT * FROM [ibClasses] ORDER BY [ibClassSeq]"></asp:SqlDataSource>
                            </div>
                        </h1>
                        <div class="logo-img">
                        </div>
                        <div class="footerDiv">
                            <ul>
                                <li><a href="Partners.aspx" id="A5">شركاؤنا</a> * <a href="Schools.aspx" id="A6">مدارسنا
                                </a></li>
                                <li style="padding-top: 10px"><a href="AboutUs.aspx" id="a7">من نحن</a> * <a href="ContactUs.aspx"
                                    id="A8">إتصل بنا</a></li></ul>
                        </div>
                        <div class="smIcons">
                            <a href="http://www.facebook.com/daralsadeeq" class="fb" target="_blank"></a><a href="http://www.youtube.com/daralsadeeq"
                                class="youtube" target="_blank"></a>
                        </div>
                    </div>
                </div>
                <div id="page2" style="display: none;">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <div class="blocks-container">
                              <div class="block-main no-margin" onclick="prevFrame()" style="position:absolute;">
                            <span>الكتب الإلكترونية</span></div>
                                <h1>
                                    <div class="classes-container">
                                        <asp:HiddenField ID="HD" runat="server" />
                                        <div class="block-classes" onclick="viewSubjects();return ClickServerSide(1);" style="margin-right: 10px;">
                                            <span>KG1</span></div>
                                        <div class="block-classes blockKG2" onclick="viewSubjects();return ClickServerSide(2);">
                                            <span>KG2</span></div>
                                        <div class="block-classes block1st" onclick="viewSubjects();return ClickServerSide(3);">
                                            <span>الصف الأول</span></div>
                                        <div class="block-classes block2nd" onclick="viewSubjects();return ClickServerSide(4);">
                                            <span>الصف الثاني</span></div>
                                        <div class="block-classes block3rd" onclick="viewSubjects();return ClickServerSide(5);" style="margin-right: 10px;">
                                            <span>الصف الثالث</span></div>
                                        <div class="block-classes blockEnGrammar" onclick="viewSubjects();return ClickServerSide(6);">
                                            <span>إنجليزي قواعد</span></div>
                                            <div class="block-classes blockFrGames" onclick="viewSubjects();return ClickServerSide(11);">
                                            <span>ألعاب فرنسي</span></div>
                                            <div class="block-classes blockEnGames" onclick="viewSubjects();return ClickServerSide(12);">
                                            <span>ألعاب إنجليزي</span></div>
                                            <div class="block-classes blockMathGames" onclick="viewSubjects();return ClickServerSide(13);" style="margin-right: 10px;">
                                            <span>ألعاب رياضيات</span></div>
                                       <%-- <asp:Button runat="server" ID="btnServerSide" Text="null" OnClick="btnServerSide_Click"
                                            CssClass="hidden" />--%>
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
                                                                    <%#Eval("SubjectNameAR")%></a>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </div>
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
            <div>
                © 2009-<script type="text/javascript">                           var mdate = new Date(); document.write(mdate.getFullYear());</script>All
                content is copyrighted for Dar Al-Sadeeq publication and distribution and their
                respective publishers. Powered by <a href="http://www.shkhaidem.com" target="_blank">
                    Shkhaidem</a></div>
        </div>
    </div>
    </form>
</body>
</html>
