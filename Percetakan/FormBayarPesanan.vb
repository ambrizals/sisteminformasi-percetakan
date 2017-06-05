Public Class FormBayarPesanan
    Dim sisa, downpayment As Double
    Sub Clear()
        txt_totalpesanan.Clear()
        txt_sisabayar.Clear()
        txt_jumlahbayar.Clear()
        cb_metode.SelectedIndex = -1
        cb_metode.Text = "<Pilih Metode Bayar>"
    End Sub

    Private Sub FormBayarPesanan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txt_totalpesanan.Text = FormPesanan.lbl_grandtotal.Text.Remove(0, 3)
    End Sub
    Private Sub cb_metode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_metode.SelectedIndexChanged
        If cb_metode.SelectedIndex = 1 Then
            downpayment = Val(txt_totalpesanan.Text * 0.5)
            txt_jumlahbayar.Text = Val(downpayment)
            sisa = Val(txt_totalpesanan.Text - txt_jumlahbayar.Text)
            txt_sisabayar.Text = Val(sisa)
        End If
    End Sub

    Private Sub txt_jumlahbayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_jumlahbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If cb_metode.SelectedIndex = 0 Then
                sisa = Val(txt_totalpesanan.Text - txt_jumlahbayar.Text)
                txt_sisabayar.Text = Val(sisa)
            Else
                sisa = Val(txt_totalpesanan.Text - txt_jumlahbayar.Text)
                txt_sisabayar.Text = Val(sisa)
            End If
        End If
    End Sub

    Private Sub BtnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKembali.Click
        Clear()
        Me.Close()
    End Sub

    Private Sub BtnBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBayar.Click
        If cb_metode.SelectedIndex = 0 Then
            If sisa > 0 Then
                MsgBox("Sisa pembayaran harus bernilai 0 jika ingin menggunakan metode pembayaran ini", MsgBoxStyle.Information, "Info")
            Else
                ''Query taruh disini
            End If
        Else
            If sisa > 0 Then
                ''Query taruh disini
            Else
                MsgBox("Sisa pembayaran harus bernilai lebih dari 0 jika ingin menggunakan metode pembayaran ini", MsgBoxStyle.Information, "Info")
            End If
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
End Class