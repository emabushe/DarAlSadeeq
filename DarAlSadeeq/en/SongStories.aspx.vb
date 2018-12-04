
Partial Class ar_SongsStories
    Inherits System.Web.UI.Page

    Protected Sub RepeaterItems_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterItems.ItemDataBound
        If Not IsPostBack Then
            Dim img As ImageButton
            img = CType(e.Item.FindControl("ImgItem"), ImageButton)
        End If
     
    End Sub
End Class
