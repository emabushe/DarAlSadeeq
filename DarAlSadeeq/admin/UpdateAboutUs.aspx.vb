Imports System.Data
Partial Class admin_UpdateAboutUs
    Inherits System.Web.UI.Page

    Protected Sub DrpDwnID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DrpDwnID.SelectedIndexChanged
        Dim DT As DataTable = New DataTable
        DT = Admin.GetPageBody(DrpDwnID.SelectedValue)
        Dim Body As String = DT.Rows(0).Item("PageBody").ToString
        HtmlEditor1.Text = Body
    End Sub

    Protected Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim Result As Boolean = General.UpdatePage(DrpDwnID.SelectedValue, HtmlEditor1.Text)
        If Result Then
            Label1.ForeColor = Drawing.Color.Green
            Label1.Text = "تم التعديل بنجاح"
            Label1.Visible = True
        Else
            Label1.ForeColor = Drawing.Color.Red
            Label1.Visible = True
            Label1.Text = "خطأ في عملية التعديل"
        End If
    End Sub
End Class
