'Import module
Imports MySql.Data.MySqlClient
Public Class Login
    Sub Connect()
        Koneksi()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.Green
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
        End If
    End Sub
    Sub ReconfigDB()
        Koneksi()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.Green
            MsgBox("Pengaturan berhasil diterapkan", MsgBoxStyle.Information, "Info")
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
            MsgBox("Pengaturan Gagal diterapkan, pastikan konfigurasi yang di masukkan telah benar", MsgBoxStyle.Critical, "Error")
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
    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Try
            If str_status > 0 Then
                conn.Open()
                Dim myadapter As New MySqlDataAdapter
                Dim sqlquery = "SELECT karyawanusername,karyawanpassword FROM karyawan where karyawanusername='" +
    Trim(txtusername.Text) + "' And karyawanpassword='" + Trim(txtpassword.Text) + "'"
                Dim mycommand As New MySqlCommand
                mycommand.Connection = conn
                mycommand.CommandText = sqlquery
                myadapter.SelectCommand = mycommand
                Dim mydata As MySqlDataReader
                mydata = mycommand.ExecuteReader()
                If txtusername.Text.Count = 0 Then
                    MsgBox("Masukkan Username !", MsgBoxStyle.Information, "Info")
                ElseIf txtpassword.Text.Count = 0 Then
                    MsgBox("Masukkan Password !", MsgBoxStyle.Information, "Info")
                Else
                    If mydata.HasRows = 0 Then
                        MsgBox("Username atau password ada yang salah!", MsgBoxStyle.Exclamation,
                    "Error Login")
                        Call reset()

                    Else
                        MsgBox("Login Berhasil", MsgBoxStyle.Information, "Info")
                        Call save_info()
                        MenuUtama.Show()
                        Me.Hide()
                    End If
                End If
                conn.Close()
            Else
                MsgBox("Tidak dapat terhubung ke server, silahkan reset terlebih dahulu", MsgBoxStyle.Critical, "Connection Error")

            End If

        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Connect()

    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        Connect()
    End Sub

    Private Sub cb_saveuser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_saveuser.CheckedChanged
        If cb_saveuser.Checked = False Then
            cb_saveuserpass.Enabled = False
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