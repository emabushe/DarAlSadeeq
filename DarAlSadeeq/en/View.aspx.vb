Partial Class ar_View
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.QueryString("mid").ToString = "" Then
            lblBody.Visible = True
        Else
            Dim MaterialID As Integer = Request.QueryString("mid")
            If Session("IsGame") = "Yes" Then
                Dim dt2 As Data.DataTable = Worksheets.GetGame(MaterialID)
                lblMaterialTitle.Text = dt2.Rows(0).Item("TitleEn").ToString
                Me.Title = "Dar Al-Sadeeq :: " & dt2.Rows(0).Item("TitleEn").ToString
                aClassName.InnerText = dt2.Rows(0).Item("ClassNameEN")
                aClassName.HRef = "WorkSheets.aspx?CID=" & dt2.Rows(0).Item("ClassID")
                ImgSubject.ImageUrl = dt2.Rows(0).Item("SubjectPic")
                aSubjectName.HRef = "WorkSheetsMaterial.aspx?sid=" & dt2.Rows(0).Item("ClassSubjectID")
                aSubjectName.InnerText = dt2.Rows(0).Item("SubjectNameEN")
                classDiv.Style("background") = dt2.Rows(0).Item("DivBg")
            Else
                Dim dt As Data.DataTable = Worksheets.GetMaterial(MaterialID)
                If dt.Rows.Count = 0 Then
                    lblBody.Visible = True
                Else
                    lblMaterialTitle.Text = dt.Rows(0).Item("TitleEn").ToString
                    Me.Title = "Dar Al-Sadeeq :: " & dt.Rows(0).Item("TitleEn").ToString
                    aClassName.InnerText = dt.Rows(0).Item("ClassNameEN")
                    aClassName.HRef = "WorkSheets.aspx?CID=" & dt.Rows(0).Item("ClassID")
                    ImgSubject.ImageUrl = dt.Rows(0).Item("SubjectPic")
                    aSubjectName.HRef = "WorkSheetsMaterial.aspx?sid=" & dt.Rows(0).Item("ClassSubjectID")
                    aSubjectName.InnerText = dt.Rows(0).Item("SubjectNameEN")
                    classDiv.Style("background") = dt.Rows(0).Item("DivBg")
                End If
            End If
        End If
    End Sub
    Protected Function GetFileName() As String
        If Request.QueryString("mid").ToString = "" Then
            Response.Redirect("WorkSheets.aspx")
        End If
        Dim MaterialID As Integer = Request.QueryString("mid")
        If Session("IsGame") = "Yes" Then
            Dim DT2 As Data.DataTable = Worksheets.GetGame(MaterialID)
            lblMaterialTitle.Text = DT2.Rows(0).Item("TitleEn").ToString
            Me.Title = DT2.Rows(0).Item("TitleEn").ToString
            Return DT2.Rows(0).Item("MaterialFile").ToString
        Else
            Dim dt As Data.DataTable = Worksheets.GetMaterial(MaterialID)
            lblMaterialTitle.Text = dt.Rows(0).Item("TitleEn").ToString
            Me.Title = dt.Rows(0).Item("TitleEn").ToString
            Return dt.Rows(0).Item("MaterialFile").ToString
        End If
    End Function
End Class
