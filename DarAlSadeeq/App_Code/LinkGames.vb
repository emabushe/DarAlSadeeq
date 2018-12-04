Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class LinkGames
    Public Shared con As SqlConnection = DA.con
    Public Shared Function ListLinkGames(ByVal GameTypeID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListLinkGames"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@GameTypeID", SqlDbType.Int).Value = GameTypeID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListLinkGames = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
End Class
