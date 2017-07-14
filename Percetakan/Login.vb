Imports System.IO
Imports System
Imports MySql.Data.MySqlClient
Public Class Login
    Dim proses As New ClsKoneksi
    Dim opt_us, opt_ps As Integer
    Dim opte_us, opte_ps, query As String
    Sub Connect()
        Koneksi()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.WhiteSmoke
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
        End If
    End Sub
    Sub ReconfigDB()
        Koneksi()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.WhiteSmoke
            MsgBox("Pengaturan berhasil diterapkan", MsgBoxStyle.Information, "Info")
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
            MsgBox("Pengaturan Gagal diterapkan, pastikan server telah online dan konfigurasi yang di masukkan telah benar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Sub ReconectDB()
        Koneksi()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.WhiteSmoke
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Sub reset()
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusername.Focus()
    End Sub
    Sub save_info()
        If (cb_saveuser.Checked = True) And (cb_saveuserpass.Checked) = True Then
            'None
        ElseIf (cb_saveuser.Checked) = True And (cb_saveuserpass.Checked) = False Then
            txtpassword.Text = ""
            txtusername.Focus()
        Else
            txtusername.Text = ""
            txtpassword.Text = ""
        End If
    End Sub
    Sub get_saveoption()
        opt_us = My.Settings.opt_usersave
        opt_ps = My.Settings.opt_passsave
        opte_us = My.Settings.opte_usersave
        opte_ps = My.Settings.opte_passsave
        If opt_us > 0 Then
            txtusername.Text = opte_us
            cb_saveuser.Checked = True
            txtpassword.Focus()
        End If
        If opt_ps > 0 Then
            txtpassword.Text = opte_ps
            cb_saveuserpass.Checked = True
            BtnLogin.Focus()
        End If
    End Sub
    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Try
            If str_status > 0 Then
                proses.OpenConn()
                Dim myadapter As New MySqlDataAdapter
                query = ("SELECT * FROM karyawan where karyawanusername='" + Trim(txtusername.Text) + "' And karyawanpassword='" + Trim(txtpassword.Text) + "'")
                proses.Cmd.Connection = proses.Cn
                proses.Cmd.CommandText = query
                proses.Da.SelectCommand = proses.Cmd
                proses.read = proses.Cmd.ExecuteReader()
                If txtusername.Text.Count = 0 Then
                    MsgBox("Masukkan Username !", MsgBoxStyle.Information, "Info")
                ElseIf txtpassword.Text.Count = 0 Then
                    MsgBox("Masukkan Password !", MsgBoxStyle.Information, "Info")
                Else
                    If proses.read.HasRows = 0 Then
                        MsgBox("Username atau password ada yang salah!", MsgBoxStyle.Exclamation,
                    "Error Login")
                        Call reset()

                    Else
                        proses.read.Read()
                        kry_id = proses.read("KARYAWANID")
                        kry_lvl = proses.read("LEVELID")
                        kry_name = proses.read("KARYAWANNAME")
                        kry_username = proses.read("KARYAWANUSERNAME")
                        kry_password = proses.read("KARYAWANPASSWORD")
                        kry_alamat = proses.read("KARYAWANALAMAT")
                        kry_telp = proses.read("KARYAWANTELP")
                        MsgBox("Login Berhasil", MsgBoxStyle.Information, "Info")
                        If cb_saveuser.Checked = True Then
                            My.Settings.opt_usersave = 1
                            My.Settings.opte_usersave = txtusername.Text
                        Else
                            My.Settings.opt_usersave = 0
                            My.Settings.opte_passsave = ""
                        End If
                        If cb_saveuserpass.Checked = True Then
                            My.Settings.opt_passsave = 1
                            My.Settings.opte_passsave = txtpassword.Text
                        Else
                            My.Settings.opt_passsave = 0
                            My.Settings.opte_passsave = ""
                        End If
                        Call save_info()
                        MenuUtama.Show()
                        Me.Hide()
                    End If
                End If

                proses.CloseConn()
            Else
                MsgBox("Tidak dapat terhubung ke server, silahkan reset terlebih dahulu", MsgBoxStyle.Critical, "Connection Error")

            End If

        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lvl_versi.Text = InfoAplikasi.Default.Versi.ToString
        get_saveoption()
        Connect()

    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        ReconectDB()
    End Sub

    Private Sub cb_saveuser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_saveuser.CheckedChanged
        If cb_saveuser.Checked = False Then
            cb_saveuserpass.Enabled = False
            cb_saveuserpass.Checked = False
        ElseIf cb_saveuser.Checked = True Then
            cb_saveuserpass.Enabled = True
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If MsgBox("Apakah ingin menutup aplikasi ini ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfig.Click
        FormConfig.ShowDialog()
    End Sub
End Class