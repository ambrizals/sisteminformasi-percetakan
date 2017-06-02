Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data

Public Class FormGudang
    Public kode_bahan As String
    Dim proses As New ClsKoneksi
    Dim list_bahan As DataTable
    Sub Load_DataBahan()
        list_bahan = proses.ExecuteQuery("SELECT bahanid AS 'Kode Bahan', bahanname AS 'Nama Bahan', bahanstock AS 'Stok Bahan', bahanunit AS 'Satuan Unit' FROM bahan")
        DG_Bahan.DataSource = list_bahan
        DG_Bahan.Columns(0).Width = 100
        DG_Bahan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Bahan.Columns(2).Width = 150
        DG_Bahan.Columns(3).Width = 150

        proses.OpenConn()

        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT bahanid AS 'Kode Bahan', bahanname AS 'Nama Bahan', bahanstock AS 'Stok Bahan', bahanunit AS 'Satuan Unit' FROM bahan"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()
        Dim bahancount As Integer
        bahancount = 0
        If (mydata.HasRows) Then
            While (mydata.Read)
                bahancount = bahancount + 1
            End While
        End If
        lbl_bahancount.Text = Val(bahancount)
        proses.CloseConn()
    End Sub

    Private Sub FormGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Load_DataBahan()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        FormAddGudang.ShowDialog()
    End Sub
End Class