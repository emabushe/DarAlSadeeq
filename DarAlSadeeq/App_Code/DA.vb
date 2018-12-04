Imports Microsoft.VisualBasic

Public Class DA
    Public Shared con As New Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("Dar_AlsadiqConnectionString").ConnectionString)

    Private Shared Sub OpenConnection()
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
End Class
