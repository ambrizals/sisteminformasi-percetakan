Imports MySql.Data.MySqlClient
Module Globals
    'Iniate App Path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory
    End Function
    'DB Config
    Public Server_Host As String
    Public Server_User As String
    Public Server_Password As String
    Public Server_Database As String

    Sub alamat()
        Server_Host = My.Settings.dbServer
        Server_User = My.Settings.dbUser
        Server_Password = My.Settings.dbPassowrd
        Server_Database = My.Settings.dbName
    End Sub

    'Create Connection
    Dim con As New ClsKoneksi

    'Server Status
    Public str_status As Integer
    Sub Koneksi()
        Try
            con.OpenConn()
            str_status = 1
            con.CloseConn()
        Catch ex As Exception
            str_status = 0
        End Try
    End Sub

    'User Information
    Public kry_id, kry_lvl, kry_name, kry_username, kry_password, kry_alamat, kry_telp As String

End Module
