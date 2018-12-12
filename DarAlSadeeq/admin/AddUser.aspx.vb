Partial Class admin_AddUser
    Inherits System.Web.UI.Page
    Dim Result As Boolean = False
    Protected Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Result = Admin.CheckUser(Trim(txtUserName.Text))
        If Result Then
            lblAvailablity.ForeColor = Drawing.Color.Red
            lblAvailablity.Text = "إسم المستخدم غير متوفر"
        Else
            Dim InsertResult As Boolean = Admin.InsertUser(Trim(txtName.Text), Trim(txtEmail.Text), Trim(txtUserName.Text), DrpDwnUserType.SelectedValue, DrpDwnSchool.SelectedValue)
            If InsertResult Then
                Label1.ForeColor = Drawing.Color.Green
                Label1.Visible = True
            Else
                Label1.ForeColor = Drawing.Color.Red
                Label1.Visible = True
                Label1.Text = "خطأ في عملية الإدخال"
            End If
        End If
    End Sub
    Protected Sub btnAvailablity_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAvailablity.Click
        Result = Admin.CheckUser(Trim(txtUserName.Text))
        If Result Then
            lblAvailablity.ForeColor = Drawing.Color.Red
            lblAvailablity.Text = "إسم المستخدم غير متوفر"
        Else
            lblAvailablity.ForeColor = Drawing.Color.Green
            lblAvailablity.Text = "يسمح إستخدام هذا الإسم"
        End If
    End Sub
End Class
