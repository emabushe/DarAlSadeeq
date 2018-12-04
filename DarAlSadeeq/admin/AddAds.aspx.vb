
Partial Class admin_AddAds
    Inherits System.Web.UI.Page

    Protected Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim Result As Boolean = Admin.InsertAd(txtName.Text, "~/Ads/" & UploaderLogo.FileName, "~/Ads/" & UploaderAdPic.FileName)
        UploaderLogo.SaveAs(Server.MapPath("~/Ads/") & UploaderLogo.FileName)
        UploaderAdPic.SaveAs(Server.MapPath("~/Ads/") & UploaderAdPic.FileName)
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
