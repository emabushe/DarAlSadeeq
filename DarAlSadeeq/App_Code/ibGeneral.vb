Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class ibGeneral
    Public Shared con As SqlConnection = DA.con
    Public Shared Function ListibBooks(ByVal ibClassID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ListibBooks"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ibClassID", SqlDbType.Int).Value = ibClassID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListibBooks = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListibLessons(ByVal ibBookID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ListibLessons"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ibBookID", SqlDbType.Int).Value = ibBookID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListibLessons = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetQuestion(ByVal ibLessonID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "GetQuestion"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ibLessonID", SqlDbType.Int).Value = ibLessonID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetQuestion = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
End Class
