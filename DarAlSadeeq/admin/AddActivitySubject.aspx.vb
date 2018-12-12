Partial Class admin_AddActivitySubject
    Inherits System.Web.UI.Page
    Protected Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim str As String = ""
        If txtYoutube.Text <> Nothing Then
            str = txtYoutube.Text
        ElseIf HtmlEditor1.Text <> Nothing Then
            str = HtmlEditor1.Text
        End If
        Dim Result As Boolean = Admin.InsertActivitySubject(Trim(txtName.Text), str, DrpDwnClasses.SelectedValue)
        If Result Then
            Label1.ForeColor = Drawing.Color.Green
            Label1.Visible = True
        Else
            Label1.ForeColor = Drawing.Color.Red
            Label1.Visible = True
            Label1.Text = "خطأ في عملية الإدخال"
        End If
    End Sub
    Protected Sub RadioButtonList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        If RadioButtonList1.SelectedIndex = 0 Then
            Youtube.Visible = True
            Editor.Visible = False
            HtmlEditor1.Text = ""
        ElseIf RadioButtonList1.SelectedIndex = 1 Then
            Editor.Visible = True
            Youtube.Visible = False
            txtYoutube.Text = ""
        End If
    End Sub
End Class
