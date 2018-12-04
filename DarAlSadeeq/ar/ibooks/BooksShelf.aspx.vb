
Partial Class ar_ibooks_BooksShelf
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim ibClassID As Integer = Request.QueryString("ibClassID")
            If ibClassID <> 0 Then
                Dim DT As Data.DataTable = ibGeneral.ListibBooks(ibClassID)

                If DT.Rows.Count <> 0 Then
                    Me.Title = "دار الصديق :: " & DT.Rows(0).Item("ibClassNameAR")

                    RepeateribBooks.DataSource = DT
                    RepeateribBooks.DataBind()
                End If
            Else


            End If


        End If

    End Sub
End Class
