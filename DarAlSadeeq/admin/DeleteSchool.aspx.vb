Imports System.IO
Imports System.Data
Partial Class admin_DeleteSchool
    Inherits System.Web.UI.Page
    Protected Sub btn_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Dim DT As DataTable = New DataTable
        DT = Admin.GetSchoolLogo(DropDownList1.SelectedValue)
        File.Delete(Server.MapPath("~/images/") & DT.Rows(0).Item("SchoolLogo").ToString)
        Dim Result As Boolean = Admin.DeleteSchool(DropDownList1.SelectedValue)
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
