Imports MySql.Data.MySqlClient

Public Class MainForm
    Dim proses As New ClsKoneksi
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory
    End Function
    Sub check_koneksi()
        list_status.Items.Add("Menghubungkan ke server.....")
        Try
            proses.OpenConn()
            list_status.Items.Add("Koneksi Terhubung.")
            proses.CloseConn()
        Catch ex As Exception
            list_status.Items.Add("Tidak dapat terhubung ke server.")
        End Try
    End Sub
    Private Sub btn_checkkoneksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_checkkoneksi.Click
        check_koneksi()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        list_status.Items.Add("Mempersiapkan informasi database......")
        check_koneksi()
    End Sub

    Private Sub BtnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfig.Click
        ConfigForm.ShowDialog()
    End Sub

    Private Sub BtnInstallDB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInstallDB1.Click
        list_status.Items.Add("Melakukan pemasangan database.....")
        If MsgBox("PERINGATAN !" + vbCr + "Aksi ini akan menghapus seluruh database yang telah terpasang, pastikan database telah di backup" + vbCr + "Ingin melakukan pemasangan database", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            Dim con As String = "server=" + My.Settings.db_server + ";user=" + My.Settings.db_user + ";pwd=" + My.Settings.db_password + ";"
            Dim file As String = App_Path() + "percetakan_db.sql"
            Dim conn As MySqlConnection = New MySqlConnection(con)
            Dim cmd As MySqlCommand = New MySqlCommand()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            cmd.Connection = conn
            conn.Open()
            mb.ImportFromFile(file)
            MsgBox("Data telah di import!" + vbCr + "Harap langsung melakukan login dengan" + vbCr + "Username : Administrator & Password : admin", MsgBoxStyle.Information, "Info")
            list_status.Items.Add("Pemasangan database berhasil.")
            conn.Close()
            check_koneksi()
        Else
            MsgBox("Aksi dibatalkan !", MsgBoxStyle.Information, "Info")
            list_status.Items.Add("Pemasangan database dibatalkan.")
        End If
    End Sub

    Private Sub BtnInstallDB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInstallDB2.Click
        list_status.Items.Add("Melakukan pemasangan database.....")
        If MsgBox("PERINGATAN !" + vbCr + "Aksi ini akan menghapus seluruh database yang telah terpasang, pastikan database telah di backup" + vbCr + "Ingin melakukan pemasangan database", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            Dim con As String = "server=" + My.Settings.db_server + ";user=" + My.Settings.db_user + ";pwd=" + My.Settings.db_password + ";"
            Dim file As String = App_Path() + "percetakan_db_plusdata.sql"
            Dim conn As MySqlConnection = New MySqlConnection(con)
            Dim cmd As MySqlCommand = New MySqlCommand()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            cmd.Connection = conn
            conn.Open()
            mb.ImportFromFile(file)
            MsgBox("Data telah di import!" + vbCr + "Harap langsung melakukan login dengan" + vbCr + "Username : Administrator & Password : admin", MsgBoxStyle.Information, "Info")
            list_status.Items.Add("Pemasangan database berhasil.")
            conn.Close()
            check_koneksi()
        Else
            MsgBox("Aksi dibatalkan !", MsgBoxStyle.Information, "Info")
            list_status.Items.Add("Pemasangan database dibatalkan.")
        End If
    End Sub

    Private Sub BtnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackup.Click
        list_status.Items.Add("Melakukan backup database.....")
        If MsgBox("PERINGATAN !" + vbCr + "Ingin melakukan backup ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            save_backup.ShowDialog()
            If save_backup.FileName.ToString = "" Then
                MsgBox("Aksi dibatalkan !", MsgBoxStyle.Information, "Info")
                list_status.Items.Add("Backup database dibatalkan.")
                save_backup.FileName = ""
                check_koneksi()
            Else
                Dim con As String = "server=" + My.Settings.db_server + ";user=" + My.Settings.db_user + ";pwd=" + My.Settings.db_password + ";database=" + My.Settings.db_dbname + ";"
                Dim file As String = save_backup.FileName.ToString
                Dim conn As MySqlConnection = New MySqlConnection(con)
                Dim cmd As MySqlCommand = New MySqlCommand()
                Dim mb As MySqlBackup = New MySqlBackup(cmd)
                cmd.Connection = conn
                conn.Open()
                mb.ExportToFile(file)
                MsgBox("Data telah backup terdapat pada : " + save_backup.FileName.ToString, MsgBoxStyle.Information, "Info")
                list_status.Items.Add("Backup database berhasil.")
                save_backup.FileName = ""
                conn.Close()
            End If
        Else
            MsgBox("Aksi dibatalkan !", MsgBoxStyle.Information, "Info")
            list_status.Items.Add("Backup database dibatalkan.")
            check_koneksi()
        End If
    End Sub

    Private Sub BtnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestore.Click
        browse_backup.ShowDialog()
        list_status.Items.Add("Melakukan restore database.....")
        If MsgBox("PERINGATAN !" + vbCr + "Aksi ini akan menimpa seluruh database yang telah terpasang, pastikan database telah di backup" + vbCr + "Ingin melakukan restore database", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            Dim con As String = "server=" + My.Settings.db_server + ";user=" + My.Settings.db_user + ";pwd=" + My.Settings.db_password + ";"
            Dim file As String = browse_backup.FileName.ToString
            Dim conn As MySqlConnection = New MySqlConnection(con)
            Dim cmd As MySqlCommand = New MySqlCommand()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            cmd.Connection = conn
            conn.Open()
            mb.ImportFromFile(file)
            MsgBox("Database telah di restore", MsgBoxStyle.Information, "Info")
            list_status.Items.Add("Restore database berhasil.")
            conn.Close()
            check_koneksi()
        Else
            MsgBox("Aksi dibatalkan !", MsgBoxStyle.Information, "Info")
            list_status.Items.Add("Restore database dibatalkan.")
            check_koneksi()
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class

Public Class ClsKoneksi
    Public SQL As String
    Public Cn As New MySqlConnection
    Public Cmd As New MySql.Data.MySqlClient.MySqlCommand
    Public Da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Public Ds As New DataSet
    Public Dt As DataTable
    Public read As MySql.Data.MySqlClient.MySqlDataReader
    Public command As New MySqlCommand

    Public Function OpenConn() As Boolean
        Cn = New MySqlConnection("server=" + My.Settings.db_server + ";" _
            & "user id=" + My.Settings.db_user + ";" _
            & "password=" + My.Settings.db_password + ";" _
            & "database=" + My.Settings.db_dbname + "")
        Cn.Open()
        If Cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub
    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed")
            Return Nothing
            Exit Function
        End If
        Cmd = New MySql.Data.MySqlClient.MySqlCommand(Query, Cn)
        Da = New MySql.Data.MySqlClient.MySqlDataAdapter
        Da.SelectCommand = Cmd
        Ds = New Data.DataSet
        Da.Fill(Ds)
        Dt = Ds.Tables(0)
        Return Dt
        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing
        CloseConn()
    End Function
    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed..!!")
            Exit Sub
        End If
        Cmd = New MySql.Data.MySqlClient.MySqlCommand
        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Query
        Cmd.ExecuteNonQuery()
        Cmd = Nothing
        CloseConn()
    End Sub
End Class

