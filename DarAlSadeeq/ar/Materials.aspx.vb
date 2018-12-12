Partial Class ar_Materials
    Inherits System.Web.UI.Page

    Private Sub ar_Materials_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim SectionID As Integer = Request.QueryString("section")
            Dim LevelID As Integer = Request.QueryString("level")
            Dim CategoryID As Integer = Request.QueryString("category")
            Dim PartID As Integer = Request.QueryString("part")
            Dim Content As Integer = Request.QueryString("content")
            ' Dim DT As Data.DataTable = Activities.ListActivity(ActivityID)
            'If DT.Rows.Count <> 0 Then
            '    Me.Title = "دار الصديق :: " & DT.Rows(0).Item("Type")
            '    ImgSubject.ImageUrl = DT.Rows(0).Item("Pic")
            '    aActivitytName.InnerText = DT.Rows(0).Item("Type")
            '    Repeater1.DataSource = DT
            '    Repeater1.DataBind()
            'Else
            '    lblBody.Visible = True
            'End If
        End If
    End Sub
End Class
