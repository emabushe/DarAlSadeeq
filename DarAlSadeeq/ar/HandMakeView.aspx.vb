﻿Partial Class ar_HandMakeView
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ID As Integer = Request.QueryString("mid")
            Dim DT As Data.DataTable = HandMake.GetHandMake(ID)
            If DT.Rows.Count > 0 Then
                Me.Title = "دار الصديق ::" & DT.Rows(0).Item("Type") & " - " & DT.Rows(0).Item("HandMakeSub")
                ImgHandMake.ImageUrl = DT.Rows(0).Item("Pic")
                HandMakeType.InnerText = DT.Rows(0).Item("Type")
                HandMakeType.HRef = "HandMakeList.aspx?sid=" & DT.Rows(0).Item("HandMakeID")
                lblGuidanceTitle.Text = DT.Rows(0).Item("HandMakeSub")
                Repeater1.DataSource = DT
                Repeater1.DataBind()
            Else
                lblBody.Visible = True
            End If
        End If
    End Sub
End Class