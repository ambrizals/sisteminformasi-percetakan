Public Class LaporanKehadiran

    Private Sub Btn_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Filter.Click
        CrystalReportViewer1.SelectionFormula = "{absensi1.absensiDATE} >= date('" & Format(dt_awal.Value, "dd/MM/yyyy") & "') and {absensi1.absensiDATE} <= date('" & Format(dt_akhir.Value, "dd/MM/yyyy") & "')"
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub dt_akhir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_akhir.ValueChanged
        If dt_akhir.Value < Today Then
            MsgBox("Pilih tanggal lebih dari tanggal sekarang", MsgBoxStyle.Information, "Info")
            dt_akhir.Value = Today
        End If
    End Sub

    Private Sub LaporanKehadiran_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dt_awal.Value = Today
    End Sub
End Class