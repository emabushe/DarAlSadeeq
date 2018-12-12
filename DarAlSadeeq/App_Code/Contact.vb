Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class Mail
    Public Shared Function SendEmail(ByVal Sender As String, ByVal Receipient As String, ByVal Body As String) As Boolean
        Dim mailServerName As String = "SMTP.webhost4life.com"
        Dim message As MailMessage = New MailMessage(Sender, "info@daralsadeeq.com", "Website Feedback", Body)
        message.IsBodyHtml = True
        Dim emailClient As New SmtpClient(mailServerName)
        emailClient.Host = mailServerName
        emailClient.Port = 587
        emailClient.Credentials = New System.Net.NetworkCredential("info@daralsadeeq.com", "123456789")
        Try
            emailClient.Send(message)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
