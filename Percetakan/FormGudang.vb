Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data


Public Class FormGudang
    Dim kode_bahan, search_name, search_condition, search_d As String
    Dim proses As New ClsKoneksi
    Dim list_bahan As DataTable
    Sub Load_DataBahan()
        list_bahan = proses.ExecuteQuery("SELECT bahan.bahanid AS 'Kode Bahan', bahan.bahanname AS 'Nama Bahan', bahan.bahanstock AS 'Stok Bahan', bahan.bahanunit AS 'Satuan Unit', bahan.BAHANHARGA AS 'Harga Bahan' FROM bahan INNER JOIN log_bahan ON (BAHAN.BAHANID = LOG_BAHAN.BAHANID) ORDER BY log_bahan.MEMASUKKANDATE")
        DG_Bahan.DataSource = list_bahan
        DG_Bahan.Columns(0).Width = 60
        DG_Bahan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Bahan.Columns(2).Width = 120
        DG_Bahan.Columns(3).Width = 120
        DG_Bahan.Columns(4).Width = 100

        proses.OpenConn()

        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT bahan.bahanid AS 'Kode Bahan', bahan.bahanname AS 'Nama Bahan', bahan.bahanstock AS 'Stok Bahan', bahan.bahanunit AS 'Satuan Unit', bahan.BAHANHARGA AS 'Harga Bahan' FROM bahan INNER JOIN log_bahan ON (BAHAN.BAHANID = LOG_BAHAN.BAHANID) ORDER BY log_bahan.MEMASUKKANDATE"
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
            search_name = "(bahanname like '%" + txt_namabahan.Text + "%') and"
        End If

        If cb_condition.SelectedIndex = 0 Then
            search_condition = "(bahanstock > 0)"
        ElseIf cb_condition.SelectedIndex = 1 Then
            search_condition = "(bahanstock = 0)"
        End If
    End Sub

    Private Sub FormGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Load_DataBahan()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        FormAddGudang.ShowDialog()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Kondisi_Pencarian()
        list_bahan = proses.ExecuteQuery("SELECT bahanid AS 'Kode Bahan', bahanname AS 'Nama Bahan', bahanstock AS 'Stok Bahan', bahanunit AS 'Satuan Unit' FROM bahan where " + search_name + search_d + search_condition + "")
        DG_Bahan.DataSource = list_bahan
        DG_Bahan.Columns(0).Width = 100
        DG_Bahan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Bahan.Columns(2).Width = 150
        DG_Bahan.Columns(3).Width = 150
    End Sub


    Public Sub DG_Bahan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Bahan.DoubleClick
        FormAddstockGudang.ShowDialog()
    End Sub

    Private Sub DG_Bahan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Bahan.CellClick
        ContextMenuStrip = cms_dgbahan
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        FormAddstockGudang.ShowDialog()
    End Sub

    Private Sub UbahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahToolStripMenuItem.Click
        FormEditbahanGudang.ShowDialog()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Load_DataBahan()
        cb_condition.SelectedIndex = -1
        cb_condition.Text = "<Pilih Ketersediaan>"
    End Sub
End Class