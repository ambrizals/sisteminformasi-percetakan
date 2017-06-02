Public Class FormPesanan
    Public kode_pesan, kode_bahan As String
    Public row_pesan, prefix_kode_pesan As Integer
    Public ord_qty, ord_harga, ord_total As Integer

    Private Sub FormPesanan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_karyawanname.Text = kry_name
        lbl_tanggal.Text = Date.Now
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        With DG_ListBuatPesan
            .Rows.Insert(.NewRowIndex, txt_taskid.Text, txt_bahan.Text, txt_deskripsi.Text, txt_qty.Text, txt_harga.Text, txt_total.Text)
        End With
        txt_taskid.Clear()
        txt_bahan.Clear()
        txt_deskripsi.Clear()
        txt_qty.Clear()
        txt_harga.Clear()
        txt_total.Clear()
    End Sub

    Private Sub txt_qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_qty.KeyPress
        ord_qty = Val(txt_qty.Text)
    End Sub

    Private Sub txt_harga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_harga.KeyPress
        ord_harga = Val(txt_harga.Text)
        ord_total = ord_qty * ord_harga
        txt_total.Text = ord_total.ToString
    End Sub

    Private Sub BtnBahanSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBahanSearch.Click
        FormCaribahanPesanan.ShowDialog()
    End Sub

    Private Sub DG_ListBuatPesan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_ListBuatPesan.CellClick
        Me.ContextMenuStrip = Me.ContextMenuStrip1
    End Sub
End Class