Imports System.Data

Partial Class admin_AddLearn
    Inherits System.Web.UI.Page

    Protected Sub btn_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim DT As DataTable = New DataTable
        DT = Admin.CheckFileName()
        Dim Check As Boolean = True
        Dim strFileName As String = UploaderMatFile.FileName.ToString
        Dim strExtention As String = strFileName.Substring(strFileName.Length - 3)
        For index = 0 To DT.Rows.Count - 1

            If DT.Rows(index).Item("MaterialFile").ToString = Trim(UploaderMatFile.FileName).ToString Then
                Check = False
            End If
        Next

        If Check Then
            Dim SubjectClassID As Integer = Admin.CheckSubjectClassID(Trim(DrpDwnClasses.SelectedValue), Trim(DrpDwnSubjects.SelectedValue))
            Dim Result As Boolean = Admin.InsertMaterials(SubjectClassID, Trim(DrpDwnClasses.SelectedValue), Trim(DrpDwnSubjects.SelectedValue), Trim(txtMaterialName.Text), Trim(UploaderMatFile.FileName), Trim(DrpDwnClasses.SelectedItem.Text), Trim(DrpDwnSubjects.SelectedItem.Text), strExtention)
            UploaderMatFile.SaveAs(Server.MapPath("~/Materials/") & UploaderMatFile.FileName)
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
