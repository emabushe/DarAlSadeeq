
Partial Class admin_AddLinkGame
    Inherits System.Web.UI.Page

    Protected Sub btn_Save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim Result As Boolean = Admin.InsertLinkGame(Trim(txtName.Text), Trim(txtURL.Text), DrpDwnType.SelectedValue)
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
