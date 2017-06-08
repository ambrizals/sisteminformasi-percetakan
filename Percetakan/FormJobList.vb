Imports System.Data.OleDb
Imports System.Data
Public Class FormJobList
    Dim tbl_pending, tbl_proses, tbl_finish As DataTable
    Dim proses As New ClsKoneksi
    Dim query As String

    Sub load_tblpending()
        tbl_pending = proses.ExecuteQuery("SELECT tasklist.taskid AS 'ID Task', bahan.bahanname AS 'Bahan', tasklist.orderid AS 'ID Order', tasklist.taskname AS 'Deskripsi', tasklist.taskqty AS 'Qty', tasklist.taskstatus AS 'Status' FROM tasklist INNER JOIN bahan ON (tasklist.bahanid = bahan.bahanid) WHERE tasklist.taskstatus = 'Pending'")
        DG_Pending.DataSource = tbl_pending
        DG_Pending.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Pending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Pending.Columns(0).Width = 80
        DG_Pending.Columns(1).Width = 100
        DG_Pending.Columns(2).Width = 80
        DG_Pending.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Pending.Columns(4).Width = 50
        DG_Pending.Columns(5).Width = 100

        job_pending.Text = "Pending (" + DG_Pending.RowCount.ToString + ")"
    End Sub

    Sub load_tblproses()
        tbl_proses = proses.ExecuteQuery("SELECT tasklist.taskid AS 'ID Task', bahan.bahanname AS 'Bahan', tasklist.orderid AS 'ID Order', tasklist.taskname AS 'Deskripsi', tasklist.taskqty AS 'Qty', tasklist.taskstatus AS 'Status' FROM tasklist INNER JOIN bahan ON (tasklist.bahanid = bahan.bahanid) WHERE tasklist.taskstatus = 'Proses'")
        DG_Proses.DataSource = tbl_proses
        DG_Proses.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Proses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Proses.Columns(0).Width = 80
        DG_Proses.Columns(1).Width = 100
        DG_Proses.Columns(2).Width = 80
        DG_Proses.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Proses.Columns(4).Width = 50
        DG_Proses.Columns(5).Width = 100

        job_process.Text = "Proses (" + DG_Proses.RowCount.ToString + ")"
    End Sub

    Sub load_tblfinish()
        tbl_finish = proses.ExecuteQuery("SELECT tasklist.taskid AS 'ID Task', bahan.bahanname AS 'Bahan', tasklist.orderid AS 'ID Order', tasklist.taskname AS 'Deskripsi', tasklist.taskqty AS 'Qty', tasklist.taskstatus AS 'Status' FROM tasklist INNER JOIN bahan ON (tasklist.bahanid = bahan.bahanid) WHERE tasklist.taskstatus = 'Finish'")
        DG_Finish.DataSource = tbl_finish
        DG_Finish.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Finish.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Finish.Columns(0).Width = 80
        DG_Finish.Columns(1).Width = 100
        DG_Finish.Columns(2).Width = 80
        DG_Finish.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Finish.Columns(4).Width = 50
        DG_Finish.Columns(5).Width = 100

        job_finish.Text = "Proses (" + DG_Finish.RowCount.ToString + ")"
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
        If MsgBox("Ingin melakukan proses pada pesanan ini ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            Try
                query = "UPDATE tasklist SET TASKSTATUS = 'Proses' WHERE TASKID = '" + DG_Pending.SelectedCells(0).Value.ToString + "'"
                proses.ExecuteNonQuery(query)
                MsgBox("Status pesanan dirubah", MsgBoxStyle.Information, "Info")
                load_tabel()
                job_process.Focus()
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan : " + vbCr + ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Pesanan tidak diproses", MsgBoxStyle.Information, "Info")
        End If
    End Sub

    Private Sub DG_Proses_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Proses.DoubleClick
        If MsgBox("Apakah pesanan ini telah diproses ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            Try
                query = "UPDATE tasklist SET TASKSTATUS = 'Finish' WHERE TASKID = '" + DG_Proses.SelectedCells(0).Value.ToString + "'"
                proses.ExecuteNonQuery(query)
                MsgBox("Status pesanan dirubah", MsgBoxStyle.Information, "Info")
                load_tabel()
                job_finish.Focus()
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan : " + vbCr + ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Pesanan tidak diproses", MsgBoxStyle.Information, "Info")
        End If
    End Sub

    Private Sub Btn_CariPending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CariPending.Click
        tbl_pending = proses.ExecuteQuery("SELECT tasklist.taskid AS 'ID Task', bahan.bahanname AS 'Bahan', tasklist.orderid AS 'ID Order', tasklist.taskname AS 'Deskripsi', tasklist.taskqty AS 'Qty', tasklist.taskstatus AS 'Status' FROM tasklist INNER JOIN bahan ON (tasklist.bahanid = bahan.bahanid) WHERE (tasklist.taskstatus = 'Pending') and (tasklist.taskid = '" + txt_pendingcari.Text + "')")
        DG_Pending.DataSource = tbl_pending
        DG_Pending.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Pending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Pending.Columns(0).Width = 80
        DG_Pending.Columns(1).Width = 100
        DG_Pending.Columns(2).Width = 80
        DG_Pending.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Pending.Columns(4).Width = 50
        DG_Pending.Columns(5).Width = 100

        job_pending.Text = "Pending (" + DG_Pending.RowCount.ToString + ")"
    End Sub

    Private Sub Btn_ProsesCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ProsesCari.Click
        tbl_proses = proses.ExecuteQuery("SELECT tasklist.taskid AS 'ID Task', bahan.bahanname AS 'Bahan', tasklist.orderid AS 'ID Order', tasklist.taskname AS 'Deskripsi', tasklist.taskqty AS 'Qty', tasklist.taskstatus AS 'Status' FROM tasklist INNER JOIN bahan ON (tasklist.bahanid = bahan.bahanid) WHERE (tasklist.taskstatus = 'Proses') AND (tasklist.taskid = '" + txt_prosescari.Text + "')")
        DG_Proses.DataSource = tbl_proses
        DG_Proses.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Proses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Proses.Columns(0).Width = 80
        DG_Proses.Columns(1).Width = 100
        DG_Proses.Columns(2).Width = 80
        DG_Proses.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Proses.Columns(4).Width = 50
        DG_Proses.Columns(5).Width = 100

        job_process.Text = "Proses (" + DG_Proses.RowCount.ToString + ")"
    End Sub


    Private Sub Btn_FinishCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_FinishCari.Click
        tbl_finish = proses.ExecuteQuery("SELECT tasklist.taskid AS 'ID Task', bahan.bahanname AS 'Bahan', tasklist.orderid AS 'ID Order', tasklist.taskname AS 'Deskripsi', tasklist.taskqty AS 'Qty', tasklist.taskstatus AS 'Status' FROM tasklist INNER JOIN bahan ON (tasklist.bahanid = bahan.bahanid) WHERE (tasklist.taskstatus = 'Finish') and (tasklist.taskid = '" + txt_finishcari.Text + "')")
        DG_Finish.DataSource = tbl_finish
        DG_Finish.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DG_Finish.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_Finish.Columns(0).Width = 80
        DG_Finish.Columns(1).Width = 100
        DG_Finish.Columns(2).Width = 80
        DG_Finish.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Finish.Columns(4).Width = 50
        DG_Finish.Columns(5).Width = 100

        job_finish.Text = "Proses (" + DG_Finish.RowCount.ToString + ")"
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        load_tabel()
    End Sub
End Class