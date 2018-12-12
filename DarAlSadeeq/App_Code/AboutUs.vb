Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class AboutUs
    Public Shared con As SqlConnection = DA.con
    Public Shared Function GetAboutUs(ByVal PageCode As String) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetPage"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@PageCode", SqlDbType.NVarChar).Value = PageCode
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetAboutUs = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
End Class
