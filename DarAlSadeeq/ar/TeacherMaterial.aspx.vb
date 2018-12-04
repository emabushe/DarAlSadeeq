
Partial Class ar_TeacherMaterial
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
     
        If Not IsPostBack Then
            Dim ClassID As Integer = Request.QueryString("CID")
            Dim SubjectID As Integer = Request.QueryString("sid")
            Dim DT As Data.DataTable = Teacher.TeacherMaterials(ClassID, SubjectID)

            If DT.Rows.Count <> 0 Then
                Me.Title = "دار الصديق :: " & DT.Rows(0).Item("ClassNameAR") & " - " & DT.Rows(0).Item("SubjectNameAR")
                aClassName.InnerText = DT.Rows(0).Item("ClassNameAR")
                aClassName.HRef = "Teacher.aspx?CID=" & DT.Rows(0).Item("ClassID")
                ImgSubject.ImageUrl = DT.Rows(0).Item("SubjectPic")
                aSubjectName.InnerText = DT.Rows(0).Item("SubjectNameAR")
                classDiv.Style("background") = DT.Rows(0).Item("DivBg")
                Repeater1.DataSource = DT
                Repeater1.DataBind()

            Else
                lblBody.Visible = True
            End If

        End If
    End Sub
    Protected Sub Repeater1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles Repeater1.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim dv As Data.DataRowView = e.Item.DataItem
            If e.Item.DataItem("FileType").ToString.ToUpper = "PDF" Then
                DirectCast(e.Item.FindControl("link1"), HtmlAnchor).HRef = "../Teacher/" & e.Item.DataItem("FileName").ToString
                DirectCast(e.Item.FindControl("link1"), HtmlAnchor).Target = "_blank"
            Else
                DirectCast(e.Item.FindControl("link1"), HtmlAnchor).HRef = "ViewTeacher.aspx?mid=" & e.Item.DataItem("FileID").ToString
            End If
        End If
    End Sub
End Class
