Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Teacher
    Public Shared con As SqlConnection = DA.con
    Public Shared Function ListTeachers(ByVal ClassID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListTeachers"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListTeachers = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function

    Public Shared Function TeacherMaterials(ByVal ClassID As Integer, ByVal SubjectID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_TeacherMaterials"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        TeacherMaterials = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
End Class
