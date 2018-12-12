Partial Class ar_ContactUs
    Inherits System.Web.UI.Page
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtBody.Text = "" Or txtEmail.Text = "" Or txtName.Text = "" Or txtSubject.Text = "" Then
            MsgBox("الرجاء تعبئة جميع الحقول", , "Required Fields!")
        Else
            Dim From As String = txtEmail.Text
            Dim body As String = "Name: " + txtName.Text + "<br/>" + "Subject: " + txtSubject.Text + "<br/>" + txtBody.Text
            Dim Receipient As String = "info@daralsadeeq.com"
            Dim Result As Boolean = Mail.SendEmail(From, Receipient, body)
            If Result Then
                lblResult.Visible = True
                lblResult.Text = "تم الإرسال بنجاح"
            Else
                lblResult.Visible = True
                lblResult.Text = "حاول مرة أخرى"
            End If
        End If
    End Sub
End Class
