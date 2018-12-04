
Partial Class MasterPage_admin
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserID") = Nothing And Session("UserType") <> "1" Then

            Response.Redirect("Login.aspx")

        End If
    End Sub

    Protected Sub logout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles logout.Click
        Session.Remove("UserID")
        Session.Remove("IsTeacher")
        Response.Redirect("Login.aspx")
    End Sub
End Class

