Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Data.OleDb
Imports System.Data

Public Class FormFinishing
    Dim proses As New ClsKoneksi
    Dim tbl_daftar As DataTable

    Sub load_data()
        tbl_daftar = proses.ExecuteQuery("SELECT * FROM FINISHING")
        DG_Daftar.DataSource = tbl_daftar

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub FormFinishing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        load_data()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        load_data()
    End Sub
End Class