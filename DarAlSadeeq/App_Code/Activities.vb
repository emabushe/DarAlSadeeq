Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class Activities
    Public Shared con As SqlConnection = DA.con
    Public Shared Function ListActivity(ByVal ActivityID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListActivity"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ActivityID", SqlDbType.Int).Value = ActivityID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListActivity = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetActivity(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_Activity"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ActivityID", SqlDbType.Int).Value = ID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetActivity = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
End Class
