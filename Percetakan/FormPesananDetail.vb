Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data

Public Class FormPesananDetail
    Dim proses As New ClsKoneksi
    Dim kode_order, sql As String
    Dim list_job As DataTable
    Dim loncat As Integer
    Private Sub ambil_data()
        kode_order = FormPesanan.DG_ListPesanan.SelectedCells(0).Value.ToString
        sql = "select tasklist.taskid as 'ID Job', bahan.bahanname as 'Bahan', tasklist.taskname as 'Deskripsi', tasklist.taskqty as 'Qty', tasklist.taskstatus as 'Status' from tasklist inner join bahan on (tasklist.bahanid = bahan.bahanid) where orderid = '" + kode_order + "' "
        list_job = proses.ExecuteQuery(sql)
        DG_DaftarJob.DataSource = list_job
        DG_DaftarJob.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_DaftarJob.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_DaftarJob.Columns(0).Width = 100
        DG_DaftarJob.Columns(1).Width = 100
        DG_DaftarJob.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_DaftarJob.Columns(3).Width = 100
        DG_DaftarJob.Columns(4).Width = 100
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
        If lbl_pesananstatus.Text = "PESANAN DIBATALKAN" Then
            MsgBox("Pesanan sudah dibatalkan", MsgBoxStyle.Information, "Info")
        ElseIf lbl_pesananstatus.Text = "FINISH" Then
            MsgBox("Pesanan yang sudah selesai tidak bisa dibatalkan", MsgBoxStyle.Information, "Info")
        Else
            If MsgBox("Pastikan customer telah mengkonfirmasi pembatalan pesanan ini, ingin membatalkan pesanan ?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
                For Me.loncat = 0 To DG_DaftarJob.Rows.Count - 1
                    sql = "UPDATE TASKLIST SET TASKSTATUS = 'CANCEL' WHERE TASKID='" + DG_DaftarJob.Rows(loncat).Cells(0).Value.ToString + "'"
                    proses.ExecuteNonQuery(sql)
                Next
                sql = "UPDATE PESANAN SET ORDERSTATUS = 'PESANAN DIBATALKAN' WHERE ORDERID = '" + kode_order + "' "
                proses.ExecuteNonQuery(sql)
                MsgBox("Pesanan berhasil dibatalkan", MsgBoxStyle.Information, "Info")
                FormPesanan.baca_pesanan()
                Me.Close()
            Else
                MsgBox("Aksi dibatalkan", MsgBoxStyle.Information, "Info")
            End If
        End If
    End Sub

    Private Sub DG_DaftarJob_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DG_DaftarJob.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            DG_DaftarJob.ContextMenuStrip = ContextMenuStrip1
        End If
    End Sub

    Private Sub BatalkanPesananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalkanPesananToolStripMenuItem.Click
        If MsgBox("Batalkan item dari pesanan ini ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            sql = "UPDATE TASKLIST SET TASKSTATUS = 'CANCEL' WHERE TASKID = '" + DG_DaftarJob.SelectedCells(0).Value.ToString + "'"
            proses.ExecuteNonQuery(sql)
            Try
                sql = "insert into log_pesanan values ('" + kry_id + "','" + lbl_nomorpesanan.Text + "','" + tanggal + "','Membatalkan item : " + DG_DaftarJob.SelectedCells(0).Value.ToString + "')"
                proses.ExecuteNonQuery(sql)
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan" + vbCr + ex.Message, MsgBoxStyle.Information, "Error Message")
            End Try
            MsgBox("Berhasil membatalkan item dari pesanan", MsgBoxStyle.Information, "Info")
        Else
            MsgBox("Aksi dibatalkan", MsgBoxStyle.Information, "Info")
        End If
    End Sub
End Class