Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data

Public Class FormProsesjobPanel
    Dim proses As New ClsKoneksi
    Dim kode_order, sql As String
    Dim list_job As DataTable
    Private Sub ambil_data()
        kode_order = FormJobList.DG_Proses.SelectedCells(0).Value.ToString
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

    Private Sub DG_DaftarJob_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DG_DaftarJob.CellFormatting
        Me.DG_DaftarJob.Rows(e.RowIndex).Cells(e.ColumnIndex).ToolTipText = "Klik dua kali untuk mengubah status menjadi selesai."
    End Sub

    Private Sub DG_DaftarJob_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_DaftarJob.DoubleClick
        If DG_DaftarJob.SelectedCells(4).Value.ToString = "FINISH" Then
            MsgBox("Tidak dapat memproses job yang telah selesai", MsgBoxStyle.Information, "Info")
        Else
            If MsgBox("Apakah job ini telah selesai ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
                Try
                    sql = "UPDATE TASKLIST SET TASKSTATUS = 'FINISH' WHERE TASKID = '" + DG_DaftarJob.SelectedCells(0).Value.ToString + "' "
                    proses.ExecuteNonQuery(sql)
                    MsgBox("Job telah selesai", MsgBoxStyle.Information, "Info")
                    ambil_data()
                Catch ex As Exception
                    MsgBox("Terjadi Kesalahan : " + vbCr + ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            Else
                MsgBox("Tindakan dibatalkan", MsgBoxStyle.Information, "Info")
            End If
        End If
    End Sub
End Class