Public Class FormKaryawan
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

    Private Sub FormKaryawan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Connect()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        txt_namakaryawan.Clear()
        txt_passwordkaryawan.Clear()
        txt_userkaryawan.Clear()
        rtf_alamat.Clear()
        txt_telepon.Clear()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If str_status > 0 Then
            MsgBox("Data tersimpan", MsgBoxStyle.Information, "Sukses")
        Else
            MsgBox("Koneksi terputus, silahkan lakukan reconnect terlebih dahulu", MsgBoxStyle.Critical, "Connection Error")
        End If
    End Sub

    Private Sub BtnReconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReconnect.Click
        Connect()
    End Sub
End Class