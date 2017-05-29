Option Explicit On
Imports MySql.Data.MySqlClient
Imports System.IO
Module Globals
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory
    End Function
    Public conn As MySqlConnection
    Public str_status As Integer

    'DB Config
    Public Server_Host As String
    Public Server_User As String
    Public Server_Password As String
    Public Server_Database As String
    Sub Koneksi()
        Server_Host = My.Settings.dbServer
        Server_User = My.Settings.dbUser
        Server_Password = My.Settings.dbPassowrd
        Server_Database = My.Settings.dbName
        Dim Server_QueryInfo As String = "Server=" + Trim(Server_Host) + "; user id=" + Trim(Server_User) + "; password=" + Trim(Server_Password) + "; database=" + Trim(Server_Database) + ""
        conn = New MySqlConnection(Server_QueryInfo)
        Try
            conn.Open()
            str_status = 1
            conn.Close()
        Catch ex As Exception
            str_status = 0
        End Try
    End Sub

End Module
