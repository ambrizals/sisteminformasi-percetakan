﻿Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data


Public Class FormGudang
    Dim kode_bahan, search_name, search_condition, search_and, search_q As String
    Dim proses As New ClsKoneksi
    Dim list_bahan As DataTable
    Sub Load_DataBahan()
        list_bahan = proses.ExecuteQuery("SELECT bahan.bahanid AS 'Kode Bahan', bahan.bahanname AS 'Nama Bahan', bahan.bahanstock AS 'Stok Bahan', bahan.bahanunit AS 'Satuan Unit', concat('Rp.',bahan.BAHANHARGA) AS 'Harga Bahan' FROM bahan")
        DG_Bahan.DataSource = list_bahan
        DG_Bahan.Columns(0).Width = 60
        DG_Bahan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Bahan.Columns(2).Width = 120
        DG_Bahan.Columns(3).Width = 120
        DG_Bahan.Columns(4).Width = 100

        proses.OpenConn()

        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT bahan.bahanid AS 'Kode Bahan', bahan.bahanname AS 'Nama Bahan', bahan.bahanstock AS 'Stok Bahan', bahan.bahanunit AS 'Satuan Unit', bahan.BAHANHARGA AS 'Harga Bahan' FROM bahan"
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

        If cb_condition.SelectedIndex = 0 Then
            search_condition = "(bahanstock > 0)"
        ElseIf cb_condition.SelectedIndex = 1 Then
            search_condition = "(bahanstock = 0)"
        End If
    End Sub

    Private Sub FormGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tanggal_Load()
        Load_DataBahan()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If kry_lvl = "JBT-001" Then
            FormAddGudang.ShowDialog()
        Else
            MsgBox("Anda tidak memiliki akses untuk menambah bahan", MsgBoxStyle.Critical, "Error Permission Denied")
        End If

    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Kondisi_Pencarian()
        If (txt_namabahan.TextLength > 0) And (cb_condition.SelectedIndex > -1) Then
            search_q = "SELECT bahanid AS 'Kode Bahan', bahanname AS 'Nama Bahan', bahanstock AS 'Stok Bahan', bahanunit AS 'Satuan Unit' FROM bahan where (bahanname like '%" + txt_namabahan.Text + "%') and " + search_condition + ""
        ElseIf (txt_namabahan.TextLength = 0) And (cb_condition.SelectedIndex > -1) Then
            search_q = "SELECT bahanid AS 'Kode Bahan', bahanname AS 'Nama Bahan', bahanstock AS 'Stok Bahan', bahanunit AS 'Satuan Unit' FROM bahan where " + search_condition + ""
        ElseIf (txt_namabahan.TextLength > 0) And (cb_condition.SelectedIndex = -1) Then
            search_q = "SELECT bahanid AS 'Kode Bahan', bahanname AS 'Nama Bahan', bahanstock AS 'Stok Bahan', bahanunit AS 'Satuan Unit' FROM bahan where (bahanname like '%" + txt_namabahan.Text + "%')"
        Else
            search_q = "SELECT bahan.bahanid AS 'Kode Bahan', bahan.bahanname AS 'Nama Bahan', bahan.bahanstock AS 'Stok Bahan', bahan.bahanunit AS 'Satuan Unit', concat('Rp.',bahan.BAHANHARGA) AS 'Harga Bahan' FROM bahan CROSS JOIN log_bahan ON (BAHAN.BAHANID = LOG_BAHAN.BAHANID) ORDER BY log_bahan.MEMASUKKANDATE"
        End If
        list_bahan = proses.ExecuteQuery(search_q)
        DG_Bahan.DataSource = list_bahan
        DG_Bahan.Columns(0).Width = 100
        DG_Bahan.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DG_Bahan.Columns(2).Width = 150
        DG_Bahan.Columns(3).Width = 150
    End Sub


    Public Sub DG_Bahan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Bahan.DoubleClick
        FormAddstockGudang.ShowDialog()
    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        FormAddstockGudang.ShowDialog()
    End Sub

    Private Sub UbahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahToolStripMenuItem.Click
        If kry_lvl = "JBT-001" Then
            FormEditbahanGudang.ShowDialog()
        Else
            MsgBox("Anda tidak memiliki akses untuk mengubah data bahan", MsgBoxStyle.Critical, "Error Permission Denied")
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Load_DataBahan()
        cb_condition.SelectedIndex = -1
        cb_condition.Text = "<Pilih Ketersediaan>"
    End Sub

    Private Sub DG_Bahan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DG_Bahan.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            DG_Bahan.ContextMenuStrip = cms_dgbahan
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class