Partial Class ar_Talents
    Inherits System.Web.UI.Page
    Protected Sub Repeater1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles Repeater1.ItemDataBound
        Dim img As ImageButton
        Dim img_Talent As Image
        img = CType(e.Item.FindControl("ImageButton1"), ImageButton)
        img_Talent = CType(e.Item.FindControl("Img_Talent"), Image)
    End Sub
End Class
