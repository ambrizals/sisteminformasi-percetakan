Public Class MenuUtama
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

    Private Sub BtnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Hide()
        Login.Close()
    End Sub

    Private Sub BtnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
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
        Connect()
    End Sub


    Private Sub BtnKaryawan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKaryawan.Click
        Try
            If str_status > 0 Then
                conn.Open()
                FormKaryawan.ShowDialog()
                conn.Close()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub

    Private Sub BtnGudang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnGudang.Click
        Try
            If str_status > 0 Then
                conn.Open()
                FormGudang.ShowDialog()
                conn.Close()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub

    Private Sub BtnJobList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnJobList.Click
        Try
            If str_status > 0 Then
                conn.Open()
                FormGudang.ShowDialog()
                conn.Close()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub

    Private Sub BtnPesanan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPesanan.Click
        Try
            If str_status > 0 Then
                conn.Open()
                FormPesanan.ShowDialog()
                conn.Close()
            Else
                MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
                str_status = 0
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            Connect()
        End Try
    End Sub

    Private Sub BtnLaporan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLaporan.Click
        Try
            If str_status > 0 Then
                conn.Open()
                FormLaporan.ShowDialog()
                conn.Close()
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