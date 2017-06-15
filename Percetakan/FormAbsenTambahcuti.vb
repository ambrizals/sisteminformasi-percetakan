Public Class FormAbsenTambahcuti
    Dim mulai, akhir As Date
    Dim tanggal_mulai, tanggal_akhir, query As String
    Dim proses As New ClsKoneksi
    Sub clear()
        txt_alasancuti.Clear()
    End Sub
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        mulai = dt_mulai.Value
        akhir = dt_akhir.Value
        If txt_alasancuti.TextLength = 0 Then
            MsgBox("Masukkan alasan cuti", MsgBoxStyle.Exclamation, "Info")
        Else
            tanggal_mulai = Format(mulai, "yyyy-MM-dd")
            tanggal_akhir = Format(akhir, "yyyy-MM-dd")
            If MsgBox("Cuti akan dimulai dari " + tanggal_mulai.ToString + " sampai " + tanggal_akhir.ToString, MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Info") = MsgBoxResult.Ok Then
                Try
                    query = "INSERT INTO cuti (karyawanID, cutiAlasan, cutiMulai, cutiAkhir) VALUES ('" + kry_id + "','" + txt_alasancuti.Text + "', '" + tanggal_mulai + "', '" + tanggal_akhir + "')"
                    proses.ExecuteNonQuery(query)
                    MsgBox("Data tersimpan", MsgBoxStyle.Information, "Info")
                    clear()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Terjadi Kesalahan" + vbCr + ex.Message, MsgBoxStyle.Information, "Error Message")
                End Try
            End If
        End If
    End Sub

    Private Sub FormAbsenTambahcuti_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dt_mulai.Value = Today.Date.ToString
    End Sub
End Class