<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="admin_Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ADMIN ONLY!!</title>
    <link href="../css/Style.css" type="text/css" rel="Stylesheet" />
</head>
<body bgcolor="#A3CDFF">
    <form id="form1" runat="server">
   <div align="center"> <table width="100%" cellpadding="0" cellspacing="0" align="center">
                    <tr>
                        <td>
                            <table cellpadding="0" cellspacing="0" width="330" style="font-size: 24px;" align="center">
                                <tr>
                                    <td style="padding-right: 10px; text-align: right;">
                                        Username:
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-image: url(../images/txt.png); background-repeat: no-repeat;
                                        padding-right: 10px; padding-left: 8px;">
                                        <asp:TextBox ID="txtUserName" runat="server" CssClass="loginTextBox"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-right: 10px; text-align: right;">
                                        Password:
                                    </td>
                                </tr>
                                <tr>
                                    <td style="background-image: url(../images/txt.png); padding-right: 10px; padding-left: 8px;">
                                        <asp:TextBox ID="txtPassword" runat="server" CssClass="loginTextBox" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="padding-top: 10px; text-align: left; padding-left: 5px;">
                                        <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="~/images/btnLogin.png" />
                                        <br />
                                        <asp:Label ID="Label1" runat="server" Text="Username or password is not available" ForeColor="Red" Visible="false" ></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                    </tr>
                </table>
                </div>
    </form>
</body>
</html>
