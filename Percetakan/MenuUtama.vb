Public Class MenuUtama
    Dim proses As New ClsKoneksi
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
            MsgBox("Pengaturan Gagal diterapkan, pastikan server telah online dan konfigurasi yang di masukkan telah benar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Sub ReconectDB()
        Koneksi()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.Green
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Sub Privilage_User()
        If kry_lvl = "JBT-002" Then
            BtnPesanan.Enabled = False
            BtnKaryawan.Enabled = False
            BtnLaporan.Enabled = False
        ElseIf kry_lvl = "JBT-003" Then
            BtnKaryawan.Enabled = False
            BtnGudang.Enabled = False
        End If
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Hide()
        Login.Close()
    End Sub

    Private Sub BtnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        Logout()
        Me.Hide()
        Login.Show()
    End Sub


    Private Sub BtnReconnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnReconnect.Click
        ReconectDB()
    End Sub

    Private Sub MenuUtama_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Login.Close()
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Privilage_User()
        Connect()
    End Sub
    Private Sub BtnKaryawan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKaryawan.Click
        Try
            If str_status > 0 Then
                proses.OpenConn()
                FormKaryawan.Show()
                proses.CloseConn()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub
    Private Sub BtnJobList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJobList.Click
        Try
            If str_status > 0 Then
                proses.OpenConn()
                FormJobList.ShowDialog()
                proses.CloseConn()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub
    Private Sub BtnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaporan.Click
        Try
            If str_status > 0 Then
                proses.OpenConn()
                FormLaporan.ShowDialog()
                proses.CloseConn()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub

    Private Sub BtnGudang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGudang.Click
        Try
            If str_status > 0 Then
                proses.OpenConn()
                FormGudang.ShowDialog()
                proses.CloseConn()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub

    Private Sub BtnPesanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPesanan.Click
        Try
            If str_status > 0 Then
                proses.OpenConn()
                FormPesanan.ShowDialog()
                proses.CloseConn()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub
End Class
