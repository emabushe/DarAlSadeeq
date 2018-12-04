Imports System.Data
Imports System.IO
Partial Class admin_DeleteActivityType
    Inherits System.Web.UI.Page

    Protected Sub btn_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Dim DT As DataTable = New DataTable
        DT = Admin.GetActivityPic(DrpDwnType.SelectedValue)
        File.Delete(Server.MapPath(DT.Rows(0).Item("Pic").ToString))
        Dim Result As Boolean = Admin.DeleteActivity(DrpDwnType.SelectedValue)
        If Result Then
            Label1.ForeColor = Drawing.Color.Green
            Label1.Visible = True
        Else
            Label1.ForeColor = Drawing.Color.Red
            Label1.Visible = True
            Label1.Text = "خطأ في عملية الحذف"
        End If
    End Sub

End Class
