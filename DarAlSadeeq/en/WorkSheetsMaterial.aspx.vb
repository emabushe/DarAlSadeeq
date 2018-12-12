Partial Class ar_WorkSheetsMaterial
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim subjectID As Integer = Request.QueryString("sid")
            If subjectID = 86 Or subjectID = 87 Or subjectID = 88 Or subjectID = 89 Or subjectID = 90 Or subjectID = 91 Or subjectID = 92 Or subjectID = 93 Or subjectID = 94 Or subjectID = 95 Or subjectID = 96 Or subjectID = 97 Or subjectID = 100 Or subjectID = 101 Or subjectID = 102 Or subjectID = 103 Or subjectID = 107 Then
                Dim DT2 As Data.DataTable = Worksheets.ListGames(subjectID)
                Session("IsGame") = "Yes"
                If DT2.Rows.Count <> 0 Then
                    Me.Title = "Dar Al-Sadeeq :: " & DT2.Rows(0).Item("ClassNameEN") & " - " & DT2.Rows(0).Item("SubjectNameEN")
                    aClassName.InnerText = DT2.Rows(0).Item("ClassNameEN")
                    aClassName.HRef = "WorkSheets.aspx?CID=" & DT2.Rows(0).Item("ClassID")
                    ImgSubject.ImageUrl = DT2.Rows(0).Item("SubjectPic")
                    aSubjectName.InnerText = DT2.Rows(0).Item("SubjectNameEN")
                    classDiv.Style("background") = DT2.Rows(0).Item("DivBg")
                    Repeater1.DataSource = DT2
                    Repeater1.DataBind()
                Else
                    Dim DT As Data.DataTable = Worksheets.ViewLearnMaterails(subjectID)
                    If DT.Rows.Count <> 0 Then
                        Me.Title = "دار الصديق :: " & DT.Rows(0).Item("ClassNameAr") & " - " & DT.Rows(0).Item("SubjectNameAr")
                        aClassName.InnerText = DT.Rows(0).Item("ClassNameAr")
                        aClassName.HRef = "WorkSheets.aspx?CID=" & DT.Rows(0).Item("ClassID")
                        ImgSubject.ImageUrl = DT.Rows(0).Item("SubjectPic")
                        aSubjectName.InnerText = DT.Rows(0).Item("SubjectNameAr")
                        classDiv.Style("background") = DT.Rows(0).Item("DivBg")
                        Repeater1.DataSource = DT
                        Repeater1.DataBind()
                    End If
                End If
            ElseIf subjectID = Nothing Then
                lblBody.Visible = True
            End If
        End If
    End Sub
    Protected Sub Repeater1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles Repeater1.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim dv As Data.DataRowView = e.Item.DataItem
            If e.Item.DataItem("FileType").ToString.ToUpper = "PDF" Then
                DirectCast(e.Item.FindControl("link1"), HtmlAnchor).HRef = "../Materials/" & e.Item.DataItem("MaterialFile").ToString
                DirectCast(e.Item.FindControl("link1"), HtmlAnchor).Target = "_blank"
            Else
                DirectCast(e.Item.FindControl("link1"), HtmlAnchor).HRef = "view.aspx?mid=" & e.Item.DataItem("MaterialID").ToString
            End If
        End If
    End Sub
End Class
