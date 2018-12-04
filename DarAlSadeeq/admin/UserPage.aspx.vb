
Partial Class admin_UserPage
    Inherits System.Web.UI.Page

    Protected Sub ImgBtnSave_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtnSave.Click
        Dim UserID As Integer = Session("UserID")
        If txtOldPassword.Text = Session("Password").ToString Then
            Dim Result As Boolean = General.ChangePassword(UserID, txtEmail.Text, txtConfirmPassword.Text)
            If Result Then
                lblResult.Text = "تمت عملية التعديل بنجاح"
            Else
                lblResult.Text = "خطأ في الإدخال الرجاء المحاولة مرة أخرى"
            End If
        Else
            lblCheckPassword.Visible = True
        End If
    End Sub

    Protected Sub ImgBtnClear_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgBtnClear.Click
        txtConfirmPassword.Text = ""
        txtEmail.Text = ""
        txtNewPassword.Text = ""
        txtOldPassword.Text = ""
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("UserID") <> Nothing Then
            txtName.Text = Session("FullName").ToString
            txtEmail.Text = Session("Email").ToString
        Else
            Response.Redirect("Login.aspx")
        End If

    End Sub
End Class
