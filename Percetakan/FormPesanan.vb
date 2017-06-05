Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data

Public Class FormPesanan
    Public kode_pesan, kode_bahan As String
    Public prefix_kode_pesan As Integer
    Public ord_qty, ord_harga, ord_total As Double
    Dim proses As New ClsKoneksi

    Sub Ambil_Kode()
        proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "select * from pesanan"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()
        Dim bahancount As Integer
        Dim bk As String
        bahancount = 0
        If (mydata.HasRows) Then
            While (mydata.Read)
                bahancount = bahancount + 1
            End While
        End If
        bk = Val(bahancount)
        bk = Val(bahancount + 1)
        txt_kodepesanan.Text = "ORD-" + bk
        txt_kodepesanan.ReadOnly = True
        proses.CloseConn()
    End Sub
    Sub reset()
        txt_namacustomer.Clear()
        txt_nomorteleponcust.Clear()
        txt_bahan.Clear()
        txt_deskripsi.Clear()
        txt_qty.Clear()
        txt_harga.Clear()
        DG_ListBuatPesan.Rows.Clear()
        lbl_grandtotal.Text = "Rp. 0"
    End Sub

    Private Sub FormPesanan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Ambil_Kode()
        lbl_karyawanname.Text = kry_name
        lbl_tanggal.Text = Date.Now
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If txt_bahan.TextLength = 0 Then
            MsgBox("Bahan belum dipilih", MsgBoxStyle.Information, "Error Missing Required Data")
        Else
            If txt_deskripsi.TextLength = 0 Then
                MsgBox("Deskripsi Wajib Di isi", MsgBoxStyle.Exclamation, "Error Missing Required Data")
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
        End If
    End Sub


    Private Sub BtnBahanSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBahanSearch.Click
        If txt_namacustomer.TextLength = 0 Then
            MsgBox("Isi nama customer terlebih dahulu !", MsgBoxStyle.Information, "Error")
        Else
            If txt_nomorteleponcust.TextLength = 0 Then
                MsgBox("Isi nomor telepon terlebih dahulu !", MsgBoxStyle.Information, "Error")
            Else
                FormCaribahanPesanan.ShowDialog()
            End If
        End If
    End Sub

    Private Sub DG_ListBuatPesan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DG_ListBuatPesan.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Not DG_ListBuatPesan.SelectedCells(0).Value = "" Then
                DG_ListBuatPesan.ContextMenuStrip = cms_editpesannow
            End If
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

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If MsgBox("Seluruh data yang di input akan di reset, apakah ingin membatalkan ?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Konfirmasi") = MsgBoxResult.Ok Then
            reset()
        End If
    End Sub

    Private Sub BtnKembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKembali.Click
        If MsgBox("Seluruh data yang di input akan di reset, apakah ingin kembali ?", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Konfirmasi") = MsgBoxResult.Ok Then
            reset()
            Me.Close()
        End If
    End Sub
End Class