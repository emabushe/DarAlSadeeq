
Partial Class ar_ActivityView
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ID As Integer = Request.QueryString("mid")
            Dim DT As Data.DataTable = Activities.GetActivity(ID)

            If DT.Rows.Count > 0 Then
                Me.Title = "Dar Al-Sadeeq::" & DT.Rows(0).Item("Type") & " - " & DT.Rows(0).Item("ActivitySub")
                ImgActivity.ImageUrl = DT.Rows(0).Item("Pic")
                ActivityType.InnerText = DT.Rows(0).Item("Type")
                ActivityType.HRef = "Activity.aspx?sid=" & DT.Rows(0).Item("ActivityID")

                lblActivityTitle.Text = DT.Rows(0).Item("ActivitySub")

                Repeater1.DataSource = DT
                Repeater1.DataBind()
            Else
                lblBody.Visible = True
            End If

        End If
    End Sub
End Class
