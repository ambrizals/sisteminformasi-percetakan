Imports System.Data.OleDb
Imports System.Data
Public Class FormJobList
    Dim tbl_joblist As DataTable
    Dim proses As New ClsKoneksi
    Sub Load_Tabel()
        tbl_joblist = proses.ExecuteQuery("Select * from tasklist")
        DG_JobList.DataSource = tbl_joblist

    End Sub

    Private Sub FormJobList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Load_Tabel()
    End Sub
End Class