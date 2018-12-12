Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Guidance
    Public Shared con As SqlConnection = DA.con
    Public Shared Function ListErshad(ByVal ErshadID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListErshad"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ErshadID", SqlDbType.Int).Value = ErshadID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListErshad = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetGuidance(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_Ershad"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetGuidance = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
End Class
