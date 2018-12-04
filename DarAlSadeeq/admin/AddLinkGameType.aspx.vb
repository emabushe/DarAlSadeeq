
Partial Class admin_AddLinkGameType
    Inherits System.Web.UI.Page

    Protected Sub btn_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Dim Result As Boolean = Admin.InsertLinkGameType(Trim(txtClassName.Text))
        If Result Then
            Label1.ForeColor = Drawing.Color.Green
            Label1.Visible = True
        Else
            Label1.ForeColor = Drawing.Color.Red
            Label1.Visible = True
            Label1.Text = "خطأ في عملية الإدخال"
        End If
    End Sub
End Class
