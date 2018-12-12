Partial Class ar_LinkGamesList
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ID As Integer = Request.QueryString("sid")
            Dim DT As Data.DataTable = LinkGames.ListLinkGames(ID)
            If DT.Rows.Count <> 0 Then
                Me.Title = "دار الصديق :: " & DT.Rows(0).Item("GameType")
                ImgSubject.ImageUrl = DT.Rows(0).Item("Pic")
                aActivitytName.InnerText = DT.Rows(0).Item("GameType")
                Repeater1.DataSource = DT
                Repeater1.DataBind()
            Else
                lblBody.Visible = True
            End If
        End If
    End Sub
End Class
