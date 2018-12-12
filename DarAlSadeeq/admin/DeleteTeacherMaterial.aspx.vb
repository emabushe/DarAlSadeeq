Imports System.Data
Imports System.IO
Partial Class admin_DeleteTeacherMaterial
    Inherits System.Web.UI.Page
    Protected Sub btn_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Dim DT As DataTable = New DataTable
        DT = Admin.GetTeacherFileName(DropDownList1.SelectedValue)
        File.Delete(Server.MapPath("~/Teacher/") & DT.Rows(0).Item("FileName").ToString)
        Dim Result As Boolean = Admin.DeleteTeacherMaterial(DropDownList1.SelectedValue)
        File.Delete(Server.MapPath("~/Teacher/") & DropDownList1.SelectedItem.Text)
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
