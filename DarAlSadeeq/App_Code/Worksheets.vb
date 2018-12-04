Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Worksheets
    Public Shared con As SqlConnection = DA.con
    Public Shared Function ListSubjects(ByVal ClassID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListSubjectClass"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListSubjects = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListGames(ByVal ClassSubjectID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListGames"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ClassSubjectID", SqlDbType.Int).Value = ClassSubjectID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListGames = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function

    Public Shared Function GetGame(ByVal GameID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetGame"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@GameID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, GameID))

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetGame = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ViewLearnMaterails(ByVal ClassSubjectID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ViewLearnMaterails"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ClassSubjectID", SqlDbType.Int).Value = ClassSubjectID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ViewLearnMaterails = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetMaterial(ByVal MaterialID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetMaterial"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@MaterialID", SqlDbType.Int).Value = MaterialID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetMaterial = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
End Class
