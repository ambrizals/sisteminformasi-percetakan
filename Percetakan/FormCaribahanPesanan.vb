Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data


Public Class FormCaribahanPesanan
    Dim kode_bahan, search_name, search_condition, search_d As String
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
    Sub Kondisi_Pencarian()
        If txt_namabahan.TextLength > 0 Then
            search_name = "(bahanname like '%" + txt_namabahan.Text + "%')"
        End If
    End Sub

    Private Sub FormGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Load_DataBahan()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        FormAddGudang.ShowDialog()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Kondisi_Pencarian()
        list_bahan = proses.ExecuteQuery("SELECT bahanid AS 'Kode Bahan', bahanname AS 'Nama Bahan', bahanstock AS 'Stok Bahan', bahanunit AS 'Satuan Unit' FROM bahan where " + search_name + "")
        DG_Bahan.DataSource = list_bahan
        DG_Bahan.Columns(0).Width = 100
        DG_Bahan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Bahan.Columns(2).Width = 150
        DG_Bahan.Columns(3).Width = 150
    End Sub


    Public Sub DG_Bahan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Bahan.DoubleClick
        FormPesanan.kode_pesan = DG_Bahan.SelectedCells(0).Value
        FormPesanan.txt_bahan.Text = DG_Bahan.SelectedCells(1).Value
        Me.Close()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Load_DataBahan()
    End Sub
End Class