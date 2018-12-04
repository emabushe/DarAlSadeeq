
Partial Class ar_GuidanceView
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ID As Integer = Request.QueryString("mid")
            Dim DT As Data.DataTable = Guidance.GetGuidance(ID)

            If DT.Rows.Count > 0 Then
                Me.Title = "Dar Al-Sadeeq ::" & DT.Rows(0).Item("Type") & " - " & DT.Rows(0).Item("ErshadSub")
                ImgGuidance.ImageUrl = DT.Rows(0).Item("Pic")
                GuidanceType.InnerText = DT.Rows(0).Item("Type")
                GuidanceType.HRef = "GuidanceList.aspx?sid=" & DT.Rows(0).Item("ErshadID")

                lblGuidanceTitle.Text = DT.Rows(0).Item("ErshadSub")

                Repeater1.DataSource = DT
                Repeater1.DataBind()
            Else
                lblBody.Visible = True
            End If

        End If
    End Sub
End Class
