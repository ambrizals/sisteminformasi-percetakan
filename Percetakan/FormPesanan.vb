﻿Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data

Public Class FormPesanan
    Public kode_pesan, kode_bahan, qty_sisa, sql As String
    Public prefix_kode_pesan, row_total As Integer
    Public ord_qty, ord_harga, ord_total, ord_bayar As Double
    Dim proses As New ClsKoneksi

    Private Sub Ambil_Kode()
        proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "select * from pesanan"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()
        Dim pesanancount As Integer
        Dim bk As String
        pesanancount = 0
        If (mydata.HasRows) Then
            While (mydata.Read)
                pesanancount = pesanancount + 1
            End While
        End If
        bk = Val(pesanancount)
        bk = Val(pesanancount + 1)
        txt_kodepesanan.Text = "ORD-" + bk
        txt_kodepesanan.ReadOnly = True
        proses.CloseConn()
    End Sub
    Sub reset()
        'Hapus semua data di form
        txt_namacustomer.Clear()
        txt_nomorteleponcust.Clear()
        txt_bahan.Clear()
        txt_deskripsi.Clear()
        txt_qty.Clear()
        txt_harga.Clear()
        DG_ListBuatPesan.Rows.Clear()
        lbl_grandtotal.Text = "Rp. 0"
        Ambil_Kode()
    End Sub
    Sub proses_pesanan()
        Dim kd_tsk As String
        Dim loncat As Integer
        Dim tanggal As String
        Dim tgl As Date = Today
        Dim tm As Date = TimeOfDay
        tanggal = Format(tgl, "yyyy-MM-dd").ToString + " " + Format(tm, "HH:mm:ss").ToString
        Try
            sql = "INSERT INTO pesanan (ORDERID, ORDERCONSUMER, ORDERCONSUMERTELP, ORDERSTATUS, ORDERTOTAL, ORDERBAYAR) VALUES ('" + txt_kodepesanan.Text + "',  '" + txt_namacustomer.Text + "', '" + txt_nomorteleponcust.Text + "', 'PENDING', '" + lbl_grandtotal.Text.Remove(0, 3) + "', '" + ord_bayar.ToString + "')"
            proses.ExecuteNonQuery(sql)
            Try
                sql = "insert into log_pesanan values ('" + kry_id + "','" + txt_kodepesanan.Text + "','" + tanggal + "','MEMBUAT PESANAN')"
                proses.ExecuteNonQuery(sql)

            Catch ex As Exception
                MsgBox("Terjadi Kesalahan" + vbCr + ex.Message, MsgBoxStyle.Information, "Error Message")
            End Try
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan" + vbCr + ex.Message, MsgBoxStyle.Information, "Error Message")
        End Try
        Try
            loncat = 0
            For loncat = 0 To DG_ListBuatPesan.RowCount - 1
                kd_tsk = txt_kodepesanan.Text + "-TLT-" + loncat.ToString
                sql = "INSERT INTO tasklist (TASKID, BAHANID, ORDERID, TASKNAME, TASKQTY, TASKPRICE, TASKSTATUS) VALUES ('" + kd_tsk + "', '" + DG_ListBuatPesan.Rows(loncat).Cells(0).Value.ToString + "', '" + txt_kodepesanan.Text + "', '" + DG_ListBuatPesan.Rows(loncat).Cells(2).Value.ToString + "', '" + DG_ListBuatPesan.Rows(loncat).Cells(3).Value.ToString + "', '" + DG_ListBuatPesan.Rows(loncat).Cells(5).Value.ToString + "', 'PENDING')"
                proses.ExecuteNonQuery(sql)
                sql = "INSERT INTO `percetakan`.`log_joblist` (`KARYAWANID`, `TASKID`, `PROSESDATE`, `PROSESSTATUS`) VALUES ('" + kry_id + "', '" + kd_tsk + "', '" + tanggal + "', 'ITEM PESANAN DIBUAT')"
                proses.ExecuteNonQuery(sql)
            Next
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan" + vbCr + ex.Message, MsgBoxStyle.Information, "Error Message")
        End Try
        MsgBox(txt_kodepesanan.Text)
        FormStruk.CrystalReportViewer1.SelectionFormula = "{pesanan1.ORDERID} like '" + txt_kodepesanan.Text + "'"
        FormStruk.CrystalReportViewer1.RefreshReport()
        FormStruk.CrystalReportViewer1.PrintReport()
        MsgBox("Transaksi Sukses", MsgBoxStyle.Information, "Info")
        reset()
    End Sub
    Sub baca_pesanan()
        Dim tbl_pesanan As DataTable
        tbl_pesanan = proses.ExecuteQuery("select orderid as 'ID Order', orderconsumer as 'Nama Customer', orderstatus as 'Status' from pesanan")
        DG_ListPesanan.DataSource = tbl_pesanan
        DG_ListPesanan.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_ListPesanan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_ListPesanan.Columns(0).Width = 100
        DG_ListPesanan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_ListPesanan.Columns(2).Width = 100
    End Sub

    Private Sub FormPesanan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DG_ListBuatPesan.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_ListBuatPesan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Ambil_Kode()
        lbl_karyawanname.Text = kry_name
        lbl_tanggal.Text = Today
        baca_pesanan()

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
                    DG_ListBuatPesan.Rows.Add(kode_bahan, txt_bahan.Text, txt_deskripsi.Text, txt_qty.Text, txt_harga.Text, ord_total)
                    lbl_grandtotal.Text = "Rp." + (Val(lbl_grandtotal.Text.Remove(0, 3)) + ord_total).ToString
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
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                If Not DG_ListBuatPesan.SelectedCells(0).Value = "" Then
                    DG_ListBuatPesan.ContextMenuStrip = cms_editpesannow
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HapusPesananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusPesananToolStripMenuItem.Click
        Dim row As DataGridViewRow
        lbl_grandtotal.Text = "Rp." + (Val(lbl_grandtotal.Text.Remove(0, 3)) - DG_ListBuatPesan.SelectedCells(5).Value).ToString
        For Each row In DG_ListBuatPesan.SelectedRows
            DG_ListBuatPesan.Rows.Remove(row)
        Next
    End Sub


    Private Sub UbahDaftarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahDaftarToolStripMenuItem.Click
        If txt_bahan.TextLength > 0 Then
            MsgBox("Selesaikan input pesanan terlebih dahulu", MsgBoxStyle.Critical, "Error")
        ElseIf txt_deskripsi.TextLength > 0 Then
            MsgBox("Selesaikan input pesanan terlebih dahulu", MsgBoxStyle.Critical, "Error")
        ElseIf txt_qty.TextLength > 0 Then
            MsgBox("Selesaikan input pesanan terlebih dahulu", MsgBoxStyle.Critical, "Error")
        ElseIf txt_harga.TextLength > 0 Then
            MsgBox("Selesaikan input pesanan terlebih dahulu", MsgBoxStyle.Critical, "Error")
        Else
            lbl_grandtotal.Text = "Rp." + (Val(lbl_grandtotal.Text.Remove(0, 3)) - DG_ListBuatPesan.SelectedCells(5).Value).ToString
            txt_bahan.Text = DG_ListBuatPesan.SelectedCells(1).Value
            kode_bahan = DG_ListBuatPesan.SelectedCells(0).Value
            txt_deskripsi.Text = DG_ListBuatPesan.SelectedCells(2).Value
            txt_qty.Text = DG_ListBuatPesan.SelectedCells(3).Value
            txt_harga.Text = DG_ListBuatPesan.SelectedCells(4).Value
            Dim row As DataGridViewRow
            For Each row In DG_ListBuatPesan.SelectedRows
                DG_ListBuatPesan.Rows.Remove(row)
            Next
        End If
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

    Private Sub BtnBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBayar.Click
        If DG_ListBuatPesan.RowCount = 0 Then
            MsgBox("Tidak dapat melakukan proses pada pesanan kosong", MsgBoxStyle.Critical, "Error")
            If txt_bahan.TextLength > 0 Then
                MsgBox("Selesaikan input pesanan terlebih dahulu", MsgBoxStyle.Critical, "Error")
                If txt_deskripsi.TextLength > 0 Then
                    MsgBox("Selesaikan input pesanan terlebih dahulu", MsgBoxStyle.Critical, "Error")
                    If txt_qty.TextLength > 0 Then
                        MsgBox("Selesaikan input pesanan terlebih dahulu", MsgBoxStyle.Critical, "Error")
                        If txt_harga.TextLength > 0 Then
                            MsgBox("Selesaikan input pesanan terlebih dahulu", MsgBoxStyle.Critical, "Error")
                        End If
                    End If
                End If
            End If
        Else
            FormBayarPesanan.ShowDialog()
        End If

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        baca_pesanan()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Dim tbl_pesanan As DataTable
        tbl_pesanan = proses.ExecuteQuery("select orderid as 'ID Order', orderconsumer as 'Nama Customer', orderstatus as 'Status' from pesanan where orderconsumer like '%" + txt_ordersearch.Text + "%'")
        DG_ListPesanan.DataSource = tbl_pesanan
        DG_ListPesanan.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_ListPesanan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_ListPesanan.Columns(0).Width = 100
        DG_ListPesanan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_ListPesanan.Columns(2).Width = 100
    End Sub

    Private Sub DG_ListPesanan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ListPesanan.DoubleClick
        FormPesananDetail.ShowDialog()
    End Sub
End Class