Imports System.IO
Imports System.Data
Partial Class admin_DeleteLearn
    Inherits System.Web.UI.Page

    Protected Sub btn_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Dim DT As DataTable = New DataTable
        DT = Admin.GetFileName(DropDownList1.SelectedValue)
        File.Delete(Server.MapPath("~/Materials/") & DT.Rows(0).Item("MaterialFile").ToString)
        Dim Result As Boolean = Admin.DeleteMaterial(DropDownList1.SelectedValue)
        File.Delete(Server.MapPath("~/Materials/") & DropDownList1.SelectedItem.Text)
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
