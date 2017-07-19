Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data
Public Class FormJobpendingPanel
    Dim proses As New ClsKoneksi
    Dim kode_order, sql, kode_bahan As String
    Dim list_job As DataTable
    Dim loncat As Integer

    Private Sub ambil_data()
        kode_order = FormJobList.DG_Pending.SelectedCells(0).Value.ToString
        sql = "select tasklist.taskid as 'ID Job', bahan.bahanname as 'Bahan', tasklist.taskname as 'Deskripsi', tasklist.taskqty as 'Qty', tasklist.taskstatus as 'Status' from tasklist inner join bahan on (tasklist.bahanid = bahan.bahanid) where (orderid = '" + kode_order + "') & (NOT(taskstatus = 'CANCEL')) & (not(taskstatus = 'FINISH')) "
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

    Private Sub FormJobpendingPanel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ambil_data()
        ambil_info_pesanan()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        Dim tanggal As String
        Dim tgl As Date = Today
        Dim tm As Date = TimeOfDay
        tanggal = Format(tgl, "yyyy-MM-dd").ToString + " " + Format(tm, "HH:mm:ss").ToString
        If MsgBox("Apakah ingin memproses pesanan ini ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            ''Kode disini
            For Me.loncat = 0 To DG_DaftarJob.Rows.Count - 1
                Try
                    sql = "UPDATE TASKLIST SET TASKSTATUS = 'PROSES' WHERE TASKID = '" + DG_DaftarJob.Rows(loncat).Cells(0).Value.ToString + "'"
                    proses.ExecuteNonQuery(sql)
                    sql = "INSERT INTO `log_joblist` (`KARYAWANID`, `TASKID`, `PROSESDATE`, `PROSESSTATUS`) VALUES ('" + kry_id + "', '" + DG_DaftarJob.Rows(loncat).Cells(0).Value.ToString + "', '" + tanggal + "', 'ITEM PESANAN DIPROSES')"
                    proses.ExecuteNonQuery(sql)
                Catch ex As Exception
                    MsgBox("Terjadi Kesalahan " + vbCr + ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            Next

            Try
                sql = "UPDATE pesanan SET ORDERSTATUS='PROSES' WHERE ORDERID='" + kode_order + "'"
                proses.ExecuteNonQuery(sql)
                sql = "INSERT INTO `log_pesanan` (`karyawanID`, `orderID`, `logDate`, `logStatus`) VALUES ('" + kry_id + "', '" + lbl_nomorpesanan.Text + "', '" + tanggal + "', 'MEMPROSES PESANAN')"
                proses.ExecuteNonQuery(sql)
                MsgBox("Pesanan telah diproses, pastikan proses telah berjalan", MsgBoxStyle.Information, "Info")
                FormJobList.load_tabel()
                Me.Close()
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan " + vbCr + ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Pesanan tidak diproses", MsgBoxStyle.Information, "Info")
        End If
    End Sub
End Class