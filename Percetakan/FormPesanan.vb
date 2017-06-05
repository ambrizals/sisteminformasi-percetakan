Public Class FormPesanan
    Public kode_pesan, kode_bahan As String
    Public prefix_kode_pesan As Integer
    Public ord_qty, ord_harga, ord_total As Double

    Private Sub FormPesanan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_karyawanname.Text = kry_name
        lbl_tanggal.Text = Date.Now
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If txt_bahan.TextLength = 0 Then
            MsgBox("Bahan belum dipilih", MsgBoxStyle.Information, "Error Missing Required Data")
        Else
            If txt_qty.TextLength = 0 Then
                MsgBox("Qty belum terisi", MsgBoxStyle.Information, "Error Missing Required Data")
            Else
                ord_total = Val(txt_qty.Text) * Val(txt_harga.Text)
                With DG_ListBuatPesan
                    .Rows.Insert(.NewRowIndex, txt_bahan.Text, txt_deskripsi.Text, txt_qty.Text, txt_harga.Text, ord_total)
                End With
                lbl_grandtotal.Text = "Rp." + (Val(lbl_grandtotal.Text) + ord_total).ToString
                txt_bahan.Clear()
                txt_deskripsi.Clear()
                txt_qty.Clear()
                txt_harga.Clear()
            End If
        End If
    End Sub


    Private Sub BtnBahanSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBahanSearch.Click
        FormCaribahanPesanan.ShowDialog()
    End Sub

    Private Sub DG_ListBuatPesan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DG_ListBuatPesan.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            DG_ListBuatPesan.ContextMenuStrip = cms_editpesannow
        End If
    End Sub
    Private Sub HapusPesananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusPesananToolStripMenuItem.Click
        Dim row As DataGridViewRow
        For Each row In DG_ListBuatPesan.SelectedRows
            DG_ListBuatPesan.Rows.Remove(row)
        Next
    End Sub


    Private Sub UbahDaftarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahDaftarToolStripMenuItem.Click
        txt_bahan.Text = DG_ListBuatPesan.SelectedCells(0).Value
        txt_deskripsi.Text = DG_ListBuatPesan.SelectedCells(1).Value
        txt_qty.Text = DG_ListBuatPesan.SelectedCells(2).Value
        txt_harga.Text = DG_ListBuatPesan.SelectedCells(3).Value
        Dim row As DataGridViewRow
        For Each row In DG_ListBuatPesan.SelectedRows
            DG_ListBuatPesan.Rows.Remove(row)
        Next
    End Sub
End Class