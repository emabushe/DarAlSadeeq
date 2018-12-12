Imports System.Data
Partial Class admin_AddGame
    Inherits System.Web.UI.Page
    Protected Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        txtFileCheck.Visible = False
        Dim DT As DataTable = New DataTable
        DT = Admin.CheckGameName()
        Dim Check As Boolean = True
        For index = 0 To DT.Rows.Count - 1
            If DT.Rows(index).Item("GameFile").ToString = Trim(UploaderMatFile.FileName).ToString Then
                Check = False
            End If
        Next
        If Check Then
            Dim SubjectClassID As Integer = Admin.CheckSubjectClassID(Trim(DrpDwnClasses.SelectedValue), Trim(DrpDwnSubjects.SelectedValue))
            Dim Result As Boolean = Admin.InsertGames(SubjectClassID, Trim(txtGameName.Text), Trim(UploaderMatFile.FileName), Trim(DrpDwnClasses.SelectedValue), Trim(DrpDwnSubjects.SelectedValue))
            UploaderMatFile.SaveAs(Server.MapPath("~/Games/") & UploaderMatFile.FileName)
            If Result Then
                Label1.ForeColor = Drawing.Color.Green
                Label1.Visible = True
            Else
                Label1.ForeColor = Drawing.Color.Red
                Label1.Visible = True
                Label1.Text = "خطأ في عملية الإدخال"
            End If
        Else
            txtFileCheck.Visible = True
        End If
    End Sub
End Class
