Imports System.IO
Imports System.Data
Partial Class admin_DeleteTalent
    Inherits System.Web.UI.Page

    Protected Sub btn_Delete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        Dim DT As DataTable = New DataTable
        DT = Admin.GetTalent(DrpDwnTalent.SelectedValue)
        File.Delete(Server.MapPath(DT.Rows(0).Item("StudentPic").ToString))
        File.Delete(Server.MapPath(DT.Rows(0).Item("TalentPic").ToString))
        Dim Result As Boolean = Admin.DeleteTalent(DrpDwnTalent.SelectedValue)

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
