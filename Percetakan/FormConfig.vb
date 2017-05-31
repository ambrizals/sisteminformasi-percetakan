Public Class FormConfig
    Dim db As New ClsKoneksi
    Private Sub FormConfig_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TxtHost.Text = Trim(Server_Host)
        TxtUser.Text = Trim(Server_User)
        TxtPassword.Text = Trim(Server_Password)
        TxtDatabase.Text = Trim(Server_Database)
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If MsgBox("Kesalahan konfigurasi dapat membuat tidak terhubung ke server dan membuat aplikasi tidak bekerja, ingin mengubah ?", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "Konfirmasi") = MsgBoxResult.Ok Then
            My.Settings.dbServer = TxtHost.Text
            My.Settings.dbUser = TxtUser.Text
            My.Settings.dbPassowrd = TxtPassword.Text
            My.Settings.dbName = TxtDatabase.Text
            Me.Close()
            Login.ReconfigDB()
        End If
    End Sub
End Class