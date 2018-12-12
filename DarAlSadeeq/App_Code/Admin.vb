Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Admin
    Public Shared con As New Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("Dar_AlsadiqConnectionString").ConnectionString)
    Dim cmd As SqlCommand
    Private Shared Sub OpenConnection()
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Public Shared Function InsertSubjectClass(ByVal ClassID As Integer, ByVal SubjectID As Integer) As Integer
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertSubjectClass"
        cmd.Parameters.Add("@ClassSubjectID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return cmd.Parameters("@ClassSubjectID").Value
            End If
        Catch ex As Exception
            Return 0
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertSchool(ByVal SchoolName As String, ByVal SchoolWebsite As String, ByVal SchoolLogo As String, ByVal IsWebSchool As Integer, ByVal IsBooksSchool As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertSchool"
        cmd.Parameters.Add("@SchoolID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@SchoolNameAR", SqlDbType.NVarChar).Value = SchoolName
        cmd.Parameters.Add("@SchoolURL", SqlDbType.NVarChar).Value = SchoolWebsite
        cmd.Parameters.Add("@SchoolLogo", SqlDbType.NVarChar).Value = SchoolLogo
        cmd.Parameters.Add("@IsWeb", SqlDbType.Bit).Value = IsWebSchool
        cmd.Parameters.Add("@IsBooks", SqlDbType.Bit).Value = IsBooksSchool
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function CheckUser(ByVal UserName As String) As Boolean
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_CheckUser"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@UserName", Data.SqlDbType.NVarChar, 50, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, UserName))
        OpenConnection()
        Dim UserID As Object = cmd.ExecuteScalar
        con.Close()
        cmd.Dispose()
        If UserID Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function InsertUser(ByVal FullName As String, ByVal UserEmail As String, ByVal UserName As String, ByVal UserType As Integer, ByVal SchoolID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertUser"
        cmd.Parameters.Add("@UserID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = FullName
        cmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar).Value = UserEmail
        cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName
        cmd.Parameters.Add("@UserType", SqlDbType.Int).Value = UserType
        cmd.Parameters.Add("@SchoolID", SqlDbType.Int).Value = SchoolID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertActivitySubject(ByVal ActivitySub As String, ByVal Body As String, ByVal ActivityID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertActivitySubject"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ActivitySub", SqlDbType.NVarChar).Value = ActivitySub
        cmd.Parameters.Add("@ActivityBody", SqlDbType.NVarChar).Value = Body
        cmd.Parameters.Add("@ActivityID", SqlDbType.Int).Value = ActivityID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertHandMakeSubject(ByVal ErshadSub As String, ByVal SubBody As String, ByVal ErshadID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertHandMakeSubject"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ErshadSub", SqlDbType.NVarChar).Value = ErshadSub
        cmd.Parameters.Add("@SubBody", SqlDbType.NVarChar).Value = SubBody
        cmd.Parameters.Add("@ErshadID", SqlDbType.Int).Value = ErshadID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertMaterials(ByVal SubjectClassID As Integer, ByVal ClassID As Integer, ByVal SubjectID As Integer, ByVal MaterialTitle As String, ByVal MaterialFile As String, ByVal ClassNameAr As String, ByVal SubjectNameAr As String, ByVal FileType As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertMaterials"
        cmd.Parameters.Add("@MaterialID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID
        cmd.Parameters.Add("@ClassSubjectID", SqlDbType.Int).Value = SubjectClassID
        cmd.Parameters.Add("@MaterialTitle", SqlDbType.NVarChar).Value = MaterialTitle
        cmd.Parameters.Add("@MaterialFile", SqlDbType.NVarChar).Value = MaterialFile
        cmd.Parameters.Add("@ClassNameAr", SqlDbType.NVarChar).Value = ClassNameAr
        cmd.Parameters.Add("@SubjectNameAr", SqlDbType.NVarChar).Value = SubjectNameAr
        cmd.Parameters.Add("@FileType", SqlDbType.NVarChar).Value = FileType
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertDemos(ByVal ClassID As Integer, ByVal SubjectID As Integer, ByVal MaterialTitle As String, ByVal MaterialFile As String, ByVal ClassNameAr As String, ByVal SubjectNameAr As String, ByVal FileType As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertDemos"
        cmd.Parameters.Add("@DemoID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID
        cmd.Parameters.Add("@DemoTitle", SqlDbType.NVarChar).Value = MaterialTitle
        cmd.Parameters.Add("@DemoFile", SqlDbType.NVarChar).Value = MaterialFile
        cmd.Parameters.Add("@ClassNameAr", SqlDbType.NVarChar).Value = ClassNameAr
        cmd.Parameters.Add("@SubjectNameAr", SqlDbType.NVarChar).Value = SubjectNameAr
        cmd.Parameters.Add("@FileType", SqlDbType.NVarChar).Value = FileType
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertDemoMaterials(ByVal SubjectClassID As Integer, ByVal ClassID As Integer, ByVal SubjectID As Integer, ByVal MaterialTitle As String, ByVal MaterialFile As String, ByVal ClassNameAr As String, ByVal SubjectNameAr As String, ByVal FileType As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertDemoMaterials"
        cmd.Parameters.Add("@MaterialID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID
        cmd.Parameters.Add("@ClassSubjectID", SqlDbType.Int).Value = SubjectClassID
        cmd.Parameters.Add("@MaterialTitle", SqlDbType.NVarChar).Value = MaterialTitle
        cmd.Parameters.Add("@MaterialFile", SqlDbType.NVarChar).Value = MaterialFile
        cmd.Parameters.Add("@ClassNameAr", SqlDbType.NVarChar).Value = ClassNameAr
        cmd.Parameters.Add("@SubjectNameAr", SqlDbType.NVarChar).Value = SubjectNameAr
        cmd.Parameters.Add("@FileType", SqlDbType.NVarChar).Value = FileType
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function MakeDemo(ByVal MaterialID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_MakeDemo"
        cmd.Parameters.Add("@MaterialID", SqlDbType.Int).Value = MaterialID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertTeacherMaterials(ByVal SubjectClassID As Integer, ByVal ClassID As Integer, ByVal SubjectID As Integer, ByVal MaterialTitle As String, ByVal MaterialFile As String, ByVal ClassNameAr As String, ByVal SubjectNameAr As String, ByVal FileType As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertTeacherMaterials"
        cmd.Parameters.Add("@FileID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID
        cmd.Parameters.Add("@ClassSubjectID", SqlDbType.Int).Value = SubjectClassID
        cmd.Parameters.Add("@FileTitle", SqlDbType.NVarChar).Value = MaterialTitle
        cmd.Parameters.Add("@FileName", SqlDbType.NVarChar).Value = MaterialFile
        cmd.Parameters.Add("@ClassNameAr", SqlDbType.NVarChar).Value = ClassNameAr
        cmd.Parameters.Add("@SubjectNameAr", SqlDbType.NVarChar).Value = SubjectNameAr
        cmd.Parameters.Add("@FileType", SqlDbType.NVarChar).Value = FileType
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function CheckSubjectClassID(ByVal ClassID As Integer, ByVal SubjectID As Integer) As Integer
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_CheckSubjectClassID"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassID))
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@SubjectID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, SubjectID))
        OpenConnection()
        Dim Result As Object = cmd.ExecuteScalar
        Dim ResultInt As Integer = Result
        If ResultInt < 1 Then
            InsertSubjectClass(ClassID, SubjectID)
        Else
            cmd.CommandText = "ES_GetSubjectClassID"
            Dim dt As New Data.DataTable
            Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim SCID As Integer = dt.Rows(0).Item("ClassSubjectID")
            con.Close()
            cmd.Dispose()
            Return SCID
        End If
    End Function
    Public Shared Function CheckSubjectClassIDDemo(ByVal ClassID As Integer, ByVal SubjectID As Integer) As Integer
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_CheckSubjectClassIDDemo"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassID))
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@SubjectID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, SubjectID))
        OpenConnection()
        Dim Result As Object = cmd.ExecuteScalar
        Dim ResultInt As Integer = Result
        If ResultInt < 1 Then
            InsertSubjectClass(ClassID, SubjectID)
        Else
            cmd.CommandText = "ES_GetSubjectClassID"
            Dim dt As New Data.DataTable
            Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim SCID As Integer = dt.Rows(0).Item("ClassSubjectID")
            con.Close()
            cmd.Dispose()
            Return SCID
        End If
    End Function
    Public Shared Function DeleteMaterial(ByVal MaterialID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteLearn"
        cmd.Parameters.Add("@MaterialID", SqlDbType.Int).Value = MaterialID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteTeacherMaterial(ByVal FileID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteTeacherFile"
        cmd.Parameters.Add("@FileID", SqlDbType.Int).Value = FileID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertChild(ByVal Title As String, ByVal Body As String, ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertErshadSubject"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title
        cmd.Parameters.Add("@Body", SqlDbType.NVarChar).Value = Body
        cmd.Parameters.Add("@ErshadID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertCLass(ByVal ClassNameAr As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertClass"
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ClassNameAr", SqlDbType.NVarChar).Value = ClassNameAr
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertDemoCLass(ByVal ClassNameAr As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertDemoClass"
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ClassNameAr", SqlDbType.NVarChar).Value = ClassNameAr
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertLinkType(ByVal LinkType As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertLinkType"
        cmd.Parameters.Add("@LinkTypeID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@LinkType", SqlDbType.NVarChar).Value = LinkType
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertLinkGameType(ByVal LinkType As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertLinkGameType"
        cmd.Parameters.Add("@TypeID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@LinkType", SqlDbType.NVarChar).Value = LinkType
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertLife(ByVal LifeName As String, ByVal LifeBody As String, ByVal LifeTypeID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertLife"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = LifeName
        cmd.Parameters.Add("@Body", SqlDbType.NVarChar).Value = LifeBody
        cmd.Parameters.Add("@LifeTypeID", SqlDbType.Int).Value = LifeTypeID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertLink(ByVal LinkTitle As String, ByVal LinkURL As String, ByVal LinkTypeID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertLink"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@LinkTitle", SqlDbType.NVarChar).Value = LinkTitle
        cmd.Parameters.Add("@LinkURL", SqlDbType.NVarChar).Value = LinkURL
        cmd.Parameters.Add("@LinkTypeID", SqlDbType.Int).Value = LinkTypeID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertLinkGame(ByVal LinkTitle As String, ByVal LinkURL As String, ByVal LinkTypeID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertLinksGame"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@GameTitle", SqlDbType.NVarChar).Value = LinkTitle
        cmd.Parameters.Add("@GameURL", SqlDbType.NVarChar).Value = LinkURL
        cmd.Parameters.Add("@GameTypeID", SqlDbType.Int).Value = LinkTypeID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertGameClass(ByVal ClassNameAr As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertGameClass"
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ClassNameAr", SqlDbType.NVarChar).Value = ClassNameAr
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteClass(ByVal ClassID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteClass"
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteDemoClass(ByVal ClassID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteDemoClass"
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteAd(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteAd"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeletePartner(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeletePartner"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteSongStory(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteSongStory"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteLinkType(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteLinkType"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteLinkGameType(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteLinkGameType"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteDemo(ByVal DemoID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteDemo"
        cmd.Parameters.Add("@DemoID", SqlDbType.Int).Value = DemoID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteLife(ByVal LifeID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteLife"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = LifeID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteChild(ByVal ChildID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteChild"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ChildID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteErshadSub(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteErshadSub"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteHandMakeSub(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteHandMakeSub"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteLink(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeletLink"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteLinkGame(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeletLinkGame"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteActivitySub(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteActivitySub"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertSubject(ByVal SubjectNameAr As String, ByVal SubjectPic As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertSubject"
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@SubjectNameAR", SqlDbType.NVarChar).Value = SubjectNameAr
        cmd.Parameters.Add("@SubjectPic", SqlDbType.NVarChar).Value = SubjectPic
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertDemoSubject(ByVal SubjectNameAr As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertDemoSubject"
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@SubjectNameAR", SqlDbType.NVarChar).Value = SubjectNameAr
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertErshadType(ByVal Type As String, ByVal Pic As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertErshadType"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type
        cmd.Parameters.Add("@Pic", SqlDbType.NVarChar).Value = Pic
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertHandMakeType(ByVal Type As String, ByVal Pic As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertHandMakeType"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type
        cmd.Parameters.Add("@Pic", SqlDbType.NVarChar).Value = Pic
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertLifeType(ByVal Type As String, ByVal Pic As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertLifeType"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type
        cmd.Parameters.Add("@Pic", SqlDbType.NVarChar).Value = Pic
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertActivityType(ByVal Type As String, ByVal Pic As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertActivityType"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type
        cmd.Parameters.Add("@Pic", SqlDbType.NVarChar).Value = Pic
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertGameSubject(ByVal SubjectNameAr As String, ByVal SubjectPic As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertGameSubject"
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@SubjectNameAR", SqlDbType.NVarChar).Value = SubjectNameAr
        cmd.Parameters.Add("@SubjectPic", SqlDbType.NVarChar).Value = SubjectPic
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteSubject(ByVal SubjectID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteSubject"
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteDemoSubject(ByVal SubjectID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteDemoSubject"
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteErshad(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteErshad"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteLifeType(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteLifeType"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteHandMake(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteHandMake"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteActivity(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteActivity"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function CheckFileName() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_CheckFileName"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        CheckFileName = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function CheckFileNameDemo() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_CheckFileNameDemos"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        CheckFileNameDemo = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function CheckTeacherFileName() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_CheckTeacherFileName"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        CheckTeacherFileName = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function CheckGameName() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_CheckGameName"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        CheckGameName = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetGameName(ByVal GameID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetGameName"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@GameID", SqlDbType.Int).Value = GameID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetGameName = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetPageBody(ByVal PageID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetPageBody"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@PageID", SqlDbType.Int).Value = PageID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetPageBody = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetTalent(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetTalent"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetTalent = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetGameSubject(ByVal SubjectID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetGameSubject"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetGameSubject = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetErshadPic(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetErshadPic"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetErshadPic = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetActivityPic(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetActivityPic"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetActivityPic = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetAdPic(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetAdPic"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetAdPic = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetPartnerPic(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetPartnerPic"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetPartnerPic = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetSchoolLogo(ByVal SchoolID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetSchoolLogo"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@SchoolID", SqlDbType.Int).Value = SchoolID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetSchoolLogo = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetFileName(ByVal MaterialID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetFileName"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@MaterialID", SqlDbType.Int).Value = MaterialID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetFileName = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetTeacherFileName(ByVal FileID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetTeacherFileName"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@FileID", SqlDbType.Int).Value = FileID
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetTeacherFileName = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function InsertGames(ByVal SubjectClassID As Integer, ByVal Title As String, ByVal GameFile As String, ByVal ClassID As Integer, ByVal SubjectID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertGames"
        cmd.Parameters.Add("@GameID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@ClassSubjectID", SqlDbType.Int).Value = SubjectClassID
        cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title
        cmd.Parameters.Add("@GameFile", SqlDbType.NVarChar).Value = GameFile
        cmd.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID
        cmd.Parameters.Add("@SubjectID", SqlDbType.Int).Value = SubjectID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertTalent(ByVal Name As String, ByVal Age As Integer, ByVal School As String, ByVal Hobbies As String, ByVal TalentPic As String, ByVal StudentPic As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertTalent"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name
        cmd.Parameters.Add("@Age", SqlDbType.Int).Value = Age
        cmd.Parameters.Add("@School", SqlDbType.NVarChar).Value = School
        cmd.Parameters.Add("@Hobbies", SqlDbType.NVarChar).Value = Hobbies
        cmd.Parameters.Add("@TalentPic", SqlDbType.NVarChar).Value = TalentPic
        cmd.Parameters.Add("@StudentPic", SqlDbType.NVarChar).Value = StudentPic
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertAd(ByVal Title As String, ByVal Logo As String, ByVal AdPic As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertAd"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title
        cmd.Parameters.Add("@Logo", SqlDbType.NVarChar).Value = Logo
        cmd.Parameters.Add("@AdPic", SqlDbType.NVarChar).Value = AdPic
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertPartner(ByVal Title As String, ByVal Logo As String, ByVal Website As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertPartner"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title
        cmd.Parameters.Add("@Logo", SqlDbType.NVarChar).Value = Logo
        cmd.Parameters.Add("@URL", SqlDbType.NVarChar).Value = Website
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function InsertSongStory(ByVal Title As String, ByVal Logo As String, ByVal Website As String) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "ES_InsertSongStory"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output
        cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = Title
        cmd.Parameters.Add("@Logo", SqlDbType.NVarChar).Value = Logo
        cmd.Parameters.Add("@URL", SqlDbType.NVarChar).Value = Website
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteGame(ByVal GameID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteGame"
        cmd.Parameters.Add("@GameID", SqlDbType.Int).Value = GameID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteTalent(ByVal ID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeletTalent"
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteSchool(ByVal SchoolID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteSchool"
        cmd.Parameters.Add("@SchoolID", SqlDbType.Int).Value = SchoolID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
    Public Shared Function DeleteUser(ByVal UserID As Integer) As Boolean
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_DeleteUser"
        cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                cmd.ExecuteNonQuery()
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Function
End Class
