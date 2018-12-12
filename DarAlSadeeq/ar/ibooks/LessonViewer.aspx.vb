Partial Class ar_ibooks_LessonViewer
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ibLessonID As Integer = Request.QueryString("ibLessonID")
            Dim DT As Data.DataTable = ibGeneral.ListibLessons(ibLessonID)
            If DT.Rows.Count <> 0 Then
                Me.Title = "دار الصديق :: " & DT.Rows(0).Item("ibClassNameAr") & " - " & DT.Rows(0).Item("ibBookNameAR")
                'ibClassName.InnerText = DT.Rows(0).Item("ibClassNameAr")
                'ibClassName.HRef = "BooksShelf.aspx?ibClassID=" & DT.Rows(0).Item("ibClassID")
                ibBookName.InnerText = DT.Rows(0).Item("ibBookNameAr")
                'classDiv.Style("background") = DT.Rows(0).Item("ibClassBGColor")
                'lblLessonTitle.Text = DT.Rows(0).Item("ibLessonNameAr")
            End If
            If ibLessonID = Nothing Then
                lblBody.Visible = True
            End If
        End If
    End Sub
End Class
