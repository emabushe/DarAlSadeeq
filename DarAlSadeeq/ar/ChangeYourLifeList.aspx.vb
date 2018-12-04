﻿
Partial Class ar_ChangeYourLifeList
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ID As Integer = Request.QueryString("sid")
            Dim DT As Data.DataTable = ChangeYourLife.ChangeYourLifeList(ID)

            If DT.Rows.Count > 0 Then
                Me.Title = "دار الصديق :: " & DT.Rows(0).Item("Type")
                ImgSubject.ImageUrl = DT.Rows(0).Item("Pic")
                aChangeYourLifeName.InnerText = DT.Rows(0).Item("Type")
                Repeater1.DataSource = DT
                Repeater1.DataBind()
            Else
                lblBody.Visible = True
            End If

        End If


    End Sub

    Protected Sub Repeater1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles Repeater1.ItemDataBound

        DirectCast(e.Item.FindControl("link1"), HtmlAnchor).HRef = "ChangeYourLifeView.aspx?mid=" & e.Item.DataItem("ID").ToString
    End Sub
End Class
