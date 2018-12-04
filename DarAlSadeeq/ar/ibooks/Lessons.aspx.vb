
Partial Class ar_ibooks_Lessons
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ibBookID As Integer = Request.QueryString("ibBookID")
           
            Dim DT As Data.DataTable = ibGeneral.ListibLessons(ibBookID)

                If DT.Rows.Count <> 0 Then
                Me.Title = "دار الصديق :: " & DT.Rows(0).Item("ibClassNameAr") & " - " & DT.Rows(0).Item("ibBookNameAR")
                aClassName.InnerText = DT.Rows(0).Item("ibClassNameAr")
                aClassName.HRef = "BooksShelf.aspx?ibClassID=" & DT.Rows(0).Item("ibClassID")
                ibBookName.InnerText = DT.Rows(0).Item("ibBookNameAr")
                classDiv.Style("background") = DT.Rows(0).Item("ibClassBGColor")
                    Repeater1.DataSource = DT
                    Repeater1.DataBind()
                End If




            If ibBookID = Nothing Then
                lblBody.Visible = True
            End If

        End If
    End Sub
End Class
