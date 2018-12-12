Partial Class ar_AboutUs
    Inherits System.Web.UI.Page
    Private Sub BindBody(ByVal PageCode As String)
        Dim DT As Data.DataTable = AboutUs.GetAboutUs(PageCode)
        Me.Title = "دار الصديق :: " & DT.Rows(0).Item("PageTitle").ToString
        lblBody.Text = DT.Rows(0).Item("PageBody").ToString
    End Sub
    Protected Sub btnServerSide_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnServerSide.Click
        Page.FindControl("subjectsContainer").Visible = True
        Page.FindControl("subjectsArrow").Visible = True
        BindBody(HD.Value)
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindBody("about1")
    End Sub
End Class
