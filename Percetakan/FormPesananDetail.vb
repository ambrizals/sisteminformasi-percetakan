﻿Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data

Public Class FormPesananDetail
    Dim proses As New ClsKoneksi
    Dim kode_order, sql, bahan_name As String
    Dim list_job As DataTable
    Dim hitung_stock As Integer

    Private Sub ambil_data()
        kode_order = FormPesanan.DG_ListPesanan.SelectedCells(0).Value.ToString
        sql = "select tasklist.taskid as 'ID Job', bahan.bahanname as 'Bahan', tasklist.taskname as 'Deskripsi', tasklist.taskqty as 'Qty', tasklist.taskprice as 'Harga', tasklist.taskstatus as 'Status' from tasklist inner join bahan on (tasklist.bahanid = bahan.bahanid) where orderid = '" + kode_order + "' "
        list_job = proses.ExecuteQuery(sql)
        DG_DaftarJob.DataSource = list_job
        DG_DaftarJob.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_DaftarJob.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_DaftarJob.Columns(0).Width = 100
        DG_DaftarJob.Columns(1).Width = 100
        DG_DaftarJob.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_DaftarJob.Columns(3).Width = 100
        DG_DaftarJob.Columns(4).Width = 100
        DG_DaftarJob.Columns(5).Width = 100
    End Sub

    Private Sub ambil_info_pesanan()
        proses.OpenConn()
        sql = "SELECT pesanan.orderid,karyawan.karyawanname,pesanan.orderconsumer,pesanan.orderconsumertelp,pesanan.orderstatus,pesanan.ordertotal,pesanan.orderbayar FROM PESANAN INNER JOIN log_pesanan ON (log_pesanan.orderID = pesanan.orderID) AND log_pesanan.logStatus = 'Membuat Pesanan' INNER JOIN karyawan ON (log_pesanan.karyawanID = karyawan.karyawanID) WHERE pesanan.orderid = '" + kode_order + "'"
        proses.command.Connection = proses.Cn
        proses.command.CommandText = sql
        proses.Da.SelectCommand = proses.command
        proses.read = proses.command.ExecuteReader()
        If proses.read.HasRows Then
            proses.read.Read()
            lbl_nomorpesanan.Text = proses.read("ORDERID")
            lbl_namacust.Text = proses.read("ORDERCONSUMER")
            Me.Text = "Info Pesanan : " + proses.read("ORDERCONSUMER")
            lbl_nomortelpcust.Text = proses.read("ORDERCONSUMERTELP")
            lbl_pesanancreateby.Text = proses.read("KARYAWANNAME")
            lbl_pesananstatus.Text = proses.read("ORDERSTATUS")
            lbl_totalbayarpesanan.Text = proses.read("ORDERTOTAL")
            lbl_terbayarpesanan.Text = proses.read("ORDERBAYAR")
            If Val(lbl_totalbayarpesanan.Text - lbl_terbayarpesanan.Text) = 0 Then
                lbl_statusbayarpesanan.Text = "Cash"
            Else
                lbl_statusbayarpesanan.Text = "Down Payment"
            End If
        End If
        proses.CloseConn()
    End Sub
    Private Sub FormProsesjobPanel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ambil_data()
        ambil_info_pesanan()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Dim tanggal As String
        Dim tgl As Date = Today
        Dim tm As Date = TimeOfDay
        tanggal = Format(tgl, "yyyy-MM-dd").ToString + " " + Format(tm, "HH:mm:ss").ToString
        Dim loncat, itemstatus As Integer
        If lbl_pesananstatus.Text = "PESANAN DIBATALKAN" Then
            MsgBox("Pesanan sudah dibatalkan", MsgBoxStyle.Information, "Info")
        ElseIf lbl_pesananstatus.Text = "FINISH" Then
            MsgBox("Pesanan yang sudah selesai tidak bisa dibatalkan", MsgBoxStyle.Information, "Info")
        Else
            If MsgBox("Pastikan customer telah mengkonfirmasi pembatalan pesanan ini, ingin membatalkan pesanan ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
                For loncat = 0 To DG_DaftarJob.Rows.Count - 1
                    itemstatus = 0
                    If DG_DaftarJob.Rows(loncat).Cells(4).Value.ToString = "FINISH" Then
                        itemstatus = itemstatus
                    ElseIf DG_DaftarJob.Rows(loncat).Cells(4).Value.ToString = "PROSES" Then
                        itemstatus = itemstatus
                    Else
                        itemstatus = itemstatus + 1
                    End If
                Next
                If itemstatus = DG_DaftarJob.Rows.Count Then
                    For loncat = 0 To DG_DaftarJob.Rows.Count - 1
                        sql = "UPDATE TASKLIST SET TASKSTATUS = 'CANCEL' WHERE TASKID='" + DG_DaftarJob.Rows(loncat).Cells(0).Value.ToString + "'"
                        proses.ExecuteNonQuery(sql)
                        sql = "INSERT INTO log_joblist (`KARYAWANID`, `TASKID`, `PROSESDATE`, `PROSESSTATUS`) VALUES ('" + kry_id + "', '" + DG_DaftarJob.Rows(loncat).Cells(0).Value.ToString + "', '" + tanggal + "', 'MEMBATALKAN ITEM PESANAN')"
                        proses.ExecuteNonQuery(sql)
                    Next
                    sql = "UPDATE PESANAN SET ORDERSTATUS = 'PESANAN DIBATALKAN' WHERE ORDERID = '" + kode_order + "' "
                    proses.ExecuteNonQuery(sql)
                    sql = "insert into log_pesanan values('" + kry_id + "','" + lbl_nomorpesanan.Text + "','" + tanggal + "','MEMBATALKAN PESANAN')"
                    proses.ExecuteNonQuery(sql)
                    MsgBox("Pesanan berhasil dibatalkan", MsgBoxStyle.Information, "Info")
                    FormPesanan.baca_pesanan()
                    Me.Close()
                Else
                    MsgBox("Terdapat pesanan yang telah selesai atau diproses", MsgBoxStyle.Information, "Info")
                End If
            Else
                MsgBox("Aksi dibatalkan", MsgBoxStyle.Information, "Info")
            End If
        End If
    End Sub


    Private Sub PesananDibatalkanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesananDibatalkanToolStripMenuItem.Click
        If MsgBox("Ingin membatalkan item dari pesanan ini ?", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "Konfirmasi") = MsgBoxResult.Ok Then
            If DG_DaftarJob.SelectedCells(5).Value.ToString = "CANCEL" Then
                MsgBox("Pesanan telah dibatalkan", MsgBoxStyle.Information, "Info")
            ElseIf DG_DaftarJob.SelectedCells(5).Value.ToString = "FINISH" Then
                MsgBox("Pesanan telah diselesaikan", MsgBoxStyle.Information, "Info")
            ElseIf DG_DaftarJob.SelectedCells(5).Value.ToString = "PROSES" Then
                MsgBox("Pesanan sedang diproses, harap hubungi operator untuk melakukan mengubah status ke pending.", MsgBoxStyle.Information, "Info")
            ElseIf DG_DaftarJob.SelectedCells(5).Value.ToString = "PENDING" Then
                sql = "UPDATE TASKLIST SET TASKSTATUS = 'CANCEL' WHERE TASKID = '" + DG_DaftarJob.SelectedCells(0).Value.ToString + "'"
                proses.ExecuteNonQuery(sql)
                MsgBox("Pesanan telah dibatalkan", MsgBoxStyle.Information, "Info")
                ambil_data()
            Else
                MsgBox("Terjadi kesalahan, harap hubungi administrator", MsgBoxStyle.Information, "Error")
            End If
        Else
            MsgBox("Aksi dibatalkan", MsgBoxStyle.Information, "Info")
        End If
    End Sub

    Private Sub BtnAmbil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAmbil.Click
        Dim tanggal As String
        Dim tgl As Date = Today
        Dim tm As Date = TimeOfDay
        Dim loncat, index_status As Integer
        index_status = 0
        For loncat = 0 To DG_DaftarJob.RowCount - 1
            If DG_DaftarJob.Rows(loncat).Cells(5).Value.ToString = "FINISH" Then
                index_status = index_status + 1
                MsgBox(index_status.ToString)
            End If
        Next
        tanggal = Format(tgl, "yyyy-MM-dd").ToString + " " + Format(tm, "HH:mm:ss").ToString
        If index_status = DG_DaftarJob.RowCount Then
            If lbl_statusbayarpesanan.Text = "Down Payment" Then
                MsgBox("Terdapat sisa pembayaran yang belum dibayarkan, apakah ingin melakukan pelunasan sebesar Rp." + Val(lbl_totalbayarpesanan.Text - lbl_terbayarpesanan.Text).ToString + " ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Konfirmasi")
                sql = "UPDATE `percetakan`.`pesanan` SET `ORDERSTATUS` = 'TRANSAKSI DITUTUP' , `ORDERBAYAR` = '" + lbl_totalbayarpesanan.Text + "' WHERE `ORDERID` = '" + lbl_nomorpesanan.Text + "'"
                proses.ExecuteNonQuery(sql)
                sql = "insert into log_pesanan values ('" + kry_id + "','" + lbl_nomorpesanan.Text + "','" + tanggal + "','MENUTUP TRANSAKSI')"
                proses.ExecuteNonQuery(sql)
                MsgBox("Pesanan telah di selesaikan dan lunas", MsgBoxStyle.Information, "Info")
                FormPesanan.baca_pesanan()
                Me.Close()
            ElseIf lbl_statusbayarpesanan.Text = "Cash" Then
                sql = "UPDATE `percetakan`.`pesanan` SET `ORDERSTATUS` = 'TRANSAKSI DITUTUP' WHERE `ORDERID` = '" + lbl_nomorpesanan.Text + "'"
                proses.ExecuteNonQuery(sql)
                sql = "insert into log_pesanan values ('" + kry_id + "','" + lbl_nomorpesanan.Text + "','" + tanggal + "','MENUTUP TRANSAKSI')"
                proses.ExecuteNonQuery(sql)
                MsgBox("Pesanan telah di selesaikan", MsgBoxStyle.Information, "Info")
                FormPesanan.baca_pesanan()
                Me.Close()
            End If
        ElseIf lbl_pesananstatus.Text = "PESANANAN DIBATALKAN" Or lbl_pesananstatus.Text = "TRANSAKSI DITUTUP" Then
            MsgBox("Pesanan telah dibatalkan atau telah ditutup", MsgBoxStyle.Information, "Info")
        Else
            MsgBox("Pesanan sedang diproses", MsgBoxStyle.Information, "Info")
        End If
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub Btn_CetakStruk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CetakStruk.Click
        Try
            FormStruk.CrystalReportViewer1.SelectionFormula = "{pesanan1.ORDERID} like '" + lbl_nomorpesanan.Text + "'"
            FormStruk.CrystalReportViewer1.RefreshReport()
            FormStruk.CrystalReportViewer1.PrintReport()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan" + vbCr + ex.Message, MsgBoxStyle.Information, "Error Message")
        End Try
    End Sub
End Class