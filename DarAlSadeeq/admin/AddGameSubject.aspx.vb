
Partial Class admin_AddGameSubject
    Inherits System.Web.UI.Page

    Protected Sub btn_Save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim strName As String = UploaderMatFile.FileName
        Dim Result As Boolean = Admin.InsertGameSubject(Trim(txtSubjectName.Text), "~/images/" + strName)
        UploaderMatFile.SaveAs(Server.MapPath("~/images/") + strName)
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
