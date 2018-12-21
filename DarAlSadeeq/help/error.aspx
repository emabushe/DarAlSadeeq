<%@ Page Language="VB" AutoEventWireup="false" CodeFile="error.aspx.vb" Inherits="help_error" %>

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
    <title>Dar Al-Sadeeq :: Error!!</title>
    <!-- Styles Start-->
    <link rel="stylesheet" type="text/css" href="../style/reset-min.css" />
    <link rel="stylesheet" type="text/css" href="../style/style.css" />
    <link rel="stylesheet" type="text/css" href="../style/pages.css" />
    <!-- Styles End-->
    <!-- Script Start-->
    <script type="text/javascript" language="javascript" src="../javascript/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" language="javascript" src="../javascript/javascript.js"></script>
    <!-- Script End-->
    <script type="text/JavaScript">
        setTimeout("location.href = 'http://www.daralsadeeq.com';", 10000);
        /***** Timer ****/
        var count = 8;
        var counter = setInterval(timer, 1000); //1000 will  run it every 1 second
        function timer() {
            count = count - 1;
            if (count <= 0) {
                clearInterval(counter);
                return;
            }
            if (count !== null) {
                document.getElementById("timer").innerHTML = count; // watch for spelling
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <div class="site-container">
            <div class="clouds-container">
                <div id="everythingInside" class="everything-inside">
                    <div id="page2">
                        <div class="error">
                            <div id="subjectsContainer" class="subjectsContainer SongStories" style="display: block;">
                                <img src="../images/error.png" / alt="ERROR"/><br />
                                <span>This page looks like moved! you will be redirected to homepage in</span><br />
                                <span>هذه الصفحة تبدو أن تم نقلها، سيتم تحولك للصفحة الرئيسية خلال</span>
                                <span id="timer">
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                <div>
                    © 2009-<script type="text/javascript">                           var mdate = new Date(); document.write(mdate.getFullYear());</script>All
                content is copyrighted for Dar Al-Sadeeq publication and distribution and their
                respective publishers. Powered by <a href="http://www.shkhaidem.com" target="_blank">Shkhaidem</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
