Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient


Public Class HandMake
    Public Shared con As SqlConnection = DA.con

    Public Shared Function ListHandMake(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListHandMake"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListHandMake = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function

    Public Shared Function GetHandMake(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_HandMake"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetHandMake = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function

End Class
