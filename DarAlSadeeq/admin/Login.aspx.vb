Partial Class admin_Login
    Inherits System.Web.UI.Page
    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnLogin.Click
        Dim userID As Integer = General.Login(txtUserName.Text.Trim, txtPassword.Text.Trim)
        If userID <> -1 Then
            Dim DT As Data.DataTable = General.GetUser(userID)
            If DT.Rows(0).Item("UserType").ToString = "1" Then
                Session("UserID") = userID
                Session("FullName") = DT.Rows(0).Item("FullName")
                Session("Email") = DT.Rows(0).Item("UserEmail")
                Session("Password") = DT.Rows(0).Item("UserPassword")
                Session("UserType") = "1"
                Response.Redirect("ManageContent.aspx")
            Else
                Label1.Visible = True
                Label1.Text = "أنت غير مخول لدخول هذه القسم"
            End If
        Else
            Label1.Visible = True
        End If
    End Sub
End Class
