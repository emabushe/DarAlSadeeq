
Partial Class ar_WorkSheets
    Inherits System.Web.UI.Page
    Public Sub getSubjects(ByVal ClassID As Integer)
        RepeaterSubjects.DataSource = Worksheets.ListSubjects(ClassID)
        RepeaterSubjects.DataBind()
    End Sub

    Protected Sub btnServerSide_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnServerSide.Click
        Page.FindControl("subjectsContainer").Visible = True
        Page.FindControl("subjectsArrow").Visible = True
        getSubjects(HD.Value)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("IsGame") = ""
        Dim ClassID As Integer = Request.QueryString("CID")
        If ClassID <> Nothing Then
            Page.FindControl("subjectsContainer").Visible = True
            Page.FindControl("subjectsArrow").Visible = True
            getSubjects(ClassID)

        Else
            Page.FindControl("subjectsContainer").Visible = False
            Page.FindControl("subjectsArrow").Visible = False
        End If


    End Sub
End Class
