
Partial Class ar_HandMakeList
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ID As Integer = Request.QueryString("sid")
            Dim DT As Data.DataTable = HandMake.ListHandMake(ID)

            If DT.Rows.Count > 0 Then
                Me.Title = "Dar Al-Sadeeq :: " & DT.Rows(0).Item("Type")
                ImgSubject.ImageUrl = DT.Rows(0).Item("Pic")
                aHandMakeName.InnerText = DT.Rows(0).Item("Type")
                Repeater1.DataSource = DT
                Repeater1.DataBind()
            Else
                lblBody.Visible = True
            End If

        End If


    End Sub

    Protected Sub Repeater1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles Repeater1.ItemDataBound

        DirectCast(e.Item.FindControl("link1"), HtmlAnchor).HRef = "HandMakeView.aspx?mid=" & e.Item.DataItem("ID").ToString
    End Sub
End Class
