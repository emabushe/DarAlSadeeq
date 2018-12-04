Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class ChangeYourLife
    Public Shared con As SqlConnection = DA.con
    Public Shared Function ChangeYourLifeList(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListHayatak"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ChangeYourLifeList = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function

    Public Shared Function ChangeYourLifeView(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_LifeSubject"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID

        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ChangeYourLifeView = dt

        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
End Class
