Partial Class admin_AddSong
    Inherits System.Web.UI.Page
    Protected Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim Result As Boolean = Admin.InsertSongStory(txtName.Text, "~/images/" & UploaderLogo.FileName, txtWebsite.Text)
        UploaderLogo.SaveAs(Server.MapPath("~/images/") & UploaderLogo.FileName)
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
