Imports System.Data.OleDb
Imports System.Data
Public Class FormJobList
    Dim tbl_pending, tbl_proses, tbl_finish As DataTable
    Dim proses As New ClsKoneksi
    Dim query As String

    Sub load_tblpending()
        tbl_pending = proses.ExecuteQuery("select orderid as 'ID Order', orderconsumer as 'Nama Customer', orderstatus as 'Status' from pesanan where orderstatus = 'PENDING'")
        DG_Pending.DataSource = tbl_pending
        DG_Pending.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Pending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Pending.Columns(0).Width = 100
        DG_Pending.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Pending.Columns(2).Width = 100

        job_pending.Text = "Pending (" + DG_Pending.RowCount.ToString + ")"
    End Sub

    Sub load_tblproses()
        tbl_proses = proses.ExecuteQuery("select orderid as 'ID Order', orderconsumer as 'Nama Customer', orderstatus as 'Status' from pesanan where orderstatus = 'PROSES'")
        DG_Proses.DataSource = tbl_proses
        DG_Proses.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Proses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Proses.Columns(0).Width = 100
        DG_Proses.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Proses.Columns(2).Width = 100

        job_process.Text = "Proses (" + DG_Proses.RowCount.ToString + ")"
    End Sub

    Sub load_tblfinish()
        tbl_finish = proses.ExecuteQuery("select orderid as 'ID Order', orderconsumer as 'Nama Customer', orderstatus as 'Status' from pesanan where orderstatus = 'FINISH'")
        DG_Finish.DataSource = tbl_finish
        DG_Finish.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Finish.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Finish.Columns(0).Width = 100
        DG_Finish.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Finish.Columns(2).Width = 100

        job_finish.Text = "Finish (" + DG_Finish.RowCount.ToString + ")"
    End Sub
    Sub load_tabel()
        load_tblpending()
        load_tblproses()
        load_tblfinish()
    End Sub

    Private Sub FormJobList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        load_tabel()
    End Sub

    Private Sub DG_Pending_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Pending.DoubleClick
        FormJobpendingPanel.ShowDialog()
    End Sub

    Private Sub DG_Proses_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Proses.DoubleClick
        FormProsesjobPanel.ShowDialog()
    End Sub

    Private Sub Btn_CariPending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CariPending.Click
        tbl_pending = proses.ExecuteQuery("select orderid as 'ID Order', orderconsumer as 'Nama Customer', orderstatus as 'Status' from pesanan where (orderstatus = 'PENDING') & (orderconsumer like '%" + txt_pendingcari.Text + "%')")
        DG_Pending.DataSource = tbl_pending
        DG_Pending.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Pending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Pending.Columns(0).Width = 100
        DG_Pending.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Pending.Columns(2).Width = 100

        job_pending.Text = "Pending (" + DG_Pending.RowCount.ToString + ")"
    End Sub

    Private Sub Btn_ProsesCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ProsesCari.Click
        tbl_proses = proses.ExecuteQuery("select orderid as 'ID Order', orderconsumer as 'Nama Customer', orderstatus as 'Status' from pesanan where (orderstatus = 'PROSES') & (orderconsumer like '%" + txt_prosescari.Text + "%')")
        DG_Proses.DataSource = tbl_proses
        DG_Proses.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Proses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Proses.Columns(0).Width = 100
        DG_Proses.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Proses.Columns(2).Width = 100

        job_process.Text = "Proses (" + DG_Proses.RowCount.ToString + ")"
    End Sub


    Private Sub Btn_FinishCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_FinishCari.Click
        tbl_finish = proses.ExecuteQuery("select orderid as 'ID Order', orderconsumer as 'Nama Customer', orderstatus as 'Status' from pesanan where (orderstatus = 'FINISH') & (orderconsumer like '%" + txt_finishcari.Text + "%')")
        DG_Finish.DataSource = tbl_finish
        DG_Finish.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Finish.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Finish.Columns(0).Width = 100
        DG_Finish.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Finish.Columns(2).Width = 100

        job_finish.Text = "Finish (" + DG_Finish.RowCount.ToString + ")"
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        load_tabel()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Close()
    End Sub
End Class
