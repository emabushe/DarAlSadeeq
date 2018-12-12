Imports Microsoft.VisualBasic
Imports System.Data
Public Class General
    'Public Shared con As New Data.SqlClient.SqlConnection("Server=WALEED-LAPTOP\SQLEXPRESS;Database=Dar_Alsadiq;User ID=sa;Password=sa!;Trusted_Connection=False;")
    Public Shared con As New Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("Dar_AlsadiqConnectionString").ConnectionString)
    Private Shared Sub OpenConnection()
        If con.State = Data.ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Public Shared Function ListSchools() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListSchools"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListSchools = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListProducts() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListProducts"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListProducts = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetPage(ByVal PageCode As String) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetPage"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@PageCode", Data.SqlDbType.NVarChar, 50, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, PageCode))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetPage = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListPages() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListPages"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListPages = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListKitchen() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListKitchen"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListKitchen = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function UpdatePage(ByVal PageID As Integer, ByVal Body As String) As Boolean
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_UpdatePage"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add("@PageID", SqlDbType.Int).Value = PageID
        cmd.Parameters.Add("@PageBody", SqlDbType.NVarChar).Value = Body
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
    Public Shared Function Login(ByVal UserName As String, ByVal Password As String) As Integer
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_Login"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@UserName", Data.SqlDbType.NVarChar, 50, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, UserName))
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@UserPassword", Data.SqlDbType.NVarChar, 50, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, Password))
        OpenConnection()
        Dim UserID As Object = cmd.ExecuteScalar
        con.Close()
        cmd.Dispose()
        If UserID Is Nothing Then
            Return -1
        Else
            Return UserID
        End If
    End Function
    Public Shared Function GetUser(ByVal UserID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetUser"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@UserID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, UserID))
        OpenConnection()
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetUser = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListSubjectClass(ByVal ClassID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListSubjectClass"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListSubjectClass = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListLife(ByVal LifeID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListLife"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, LifeID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListLife = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListChild(ByVal ChildID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListChild"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ChildID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListChild = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListMaterails(ByVal ClassSubjectID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListMaterails"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassSubjectID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListMaterails = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ViewMaterails(ByVal ClassSubjectID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ViewMaterails"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassSubjectID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ViewMaterails = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ViewDemos(ByVal ClassSubjectID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ViewDemos"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassSubjectID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ViewDemos = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ViewLearnMaterails(ByVal ClassSubjectID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ViewLearnMaterails"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassSubjectID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassSubjectID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ViewLearnMaterails = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ViewTeacherMaterails(ByVal SubjectID As Integer, ByVal ClassID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ViewTeacherMaterails"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@SubjectID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, SubjectID))
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ViewTeacherMaterails = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListTeachers(ByVal ClassID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListTeachers"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListTeachers = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListLinks(ByVal LinkTypeID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListLinks"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@LinkTypeID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, LinkTypeID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListLinks = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function TeacherMaterials(ByVal FileID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_TeacherMaterials"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@FileID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, FileID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        TeacherMaterials = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListTemplates() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListTemplates"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListTemplates = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListGames(ByVal ClassSubjectID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListGames"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ClassSubjectID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ClassSubjectID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListGames = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListErshad(ByVal ErshadID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListErshad"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ErshadID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ErshadID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListErshad = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListActivity(ByVal ActivityID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListActivity"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ActivityID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ActivityID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListActivity = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListHandMake(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListHandMake"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListHandMake = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListHayatak(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListHayatak"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListHayatak = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function Ershad(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_Ershad"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        Ershad = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function HandMake(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_HandMake"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        HandMake = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function LifeSubject(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_LifeSubject"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        LifeSubject = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ListLinkGames(ByVal GameTypeID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ListLinkGames"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@GameTypeID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, GameTypeID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        ListLinkGames = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function Activity(ByVal ID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_Activity"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@ActivityID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, ID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        Activity = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetMaterial(ByVal MaterialID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetMaterial"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@MaterialID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, MaterialID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetMaterial = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function GetSongStory() As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetSongStory"
        cmd.CommandType = Data.CommandType.StoredProcedure
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetSongStory = dt
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
    Public Shared Function GetTeacher(ByVal FileID As Integer) As Data.DataTable
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_GetTeacher"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@FileID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, FileID))
        Dim dt As New Data.DataTable
        Dim da As New Data.SqlClient.SqlDataAdapter(cmd)
        da.Fill(dt)
        GetTeacher = dt
        cmd.Dispose()
        dt.Dispose()
        da.Dispose()
    End Function
    Public Shared Function ChangePassword(ByVal UserID As Integer, ByVal Email As String, ByVal NewPassword As String) As Boolean
        Dim cmd As New Data.SqlClient.SqlCommand
        cmd.Connection = con
        cmd.CommandText = "ES_ChangePassword"
        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@UserID", Data.SqlDbType.Int, 0, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, UserID))
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@UserEmail", Data.SqlDbType.NVarChar, 50, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, Email))
        cmd.Parameters.Add(New Data.SqlClient.SqlParameter("@NewPassword", Data.SqlDbType.NVarChar, 50, Data.ParameterDirection.Input, True, 0, 0, "", Data.DataRowVersion.Default, NewPassword))
        OpenConnection()
        Dim i As Integer = cmd.ExecuteNonQuery()
        If i = 0 Then
            ChangePassword = False
        Else
            ChangePassword = True
        End If
        con.Close()
        cmd.Dispose()
    End Function
End Class
