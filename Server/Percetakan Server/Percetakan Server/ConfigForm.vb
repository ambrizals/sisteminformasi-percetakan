Public Class ConfigForm
    Private Sub ConfigForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_host.Text = My.Settings.db_server
        txt_username.Text = My.Settings.db_user
        txt_password.Text = My.Settings.db_password
        txt_database.Text = My.Settings.db_dbname
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Try
            My.Settings.db_server = txt_host.Text
            My.Settings.db_user = txt_username.Text
            My.Settings.db_password = txt_password.Text
            My.Settings.db_dbname = txt_database.Text
            MsgBox("Data berhasil di simpan !", MsgBoxStyle.Information, "Berhasil")
            MainForm.list_status.Items.Add("Mengambil informasi pengaturan baru....")
            MainForm.check_koneksi()
            Me.Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " + vbCr + "Error Info : " + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
End Class