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

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub MenuUtama_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Connect()
        lbl_datetime.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub BtnKaryawan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKaryawan.Click
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

    Private Sub BtnJobList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJoblist.Click
        Try
            If str_status > 0 Then
                conn.Open()
                FormJobList.ShowDialog()
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

    Private Sub BtnGudang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGudang.Click
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

    Private Sub BtnPesanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPesanan.Click
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

    Private Sub BtnLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLaporan.Click
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

    Private Sub btn_reconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reconnect.Click
        Connect()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Hide()
        Login.Close()
    End Sub
End Class