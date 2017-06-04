﻿Imports MySql.Data.MySqlClient
Public Class FormEditbahanGudang
    Dim proses As New ClsKoneksi
    Dim bahanid, bahanname, bahanunit, sql, stockq As String
    Dim stock, bahanstock, bahantambah As Double
    Sub ambil_data()
        Dim Selected_add As String
        Selected_add = FormGudang.DG_Bahan.SelectedCells(0).Value
        proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "Select * From bahan where bahanid = '" + Selected_add + "'"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()
        mydata.Read()
        If (mydata.HasRows) Then
            bahanid = mydata("BAHANID")
            bahanname = mydata("BAHANNAME")
            bahanstock = mydata("BAHANSTOCK")
            bahanunit = mydata("BAHANUNIT")
        End If
        proses.CloseConn()
    End Sub
    Sub clear()
        txt_kodebahan.Clear()
        txt_namabahan.Clear()
        nm_stock.Value = 0
        cb_unit.SelectedIndex = -1
        cb_unit.Text = "Pilih Satuan"
    End Sub

    Private Sub FormEditbahanGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ambil_data()
        Me.Text = "Ubah Data Bahan : " + bahanname
        txt_kodebahan.Text = bahanid
        txt_namabahan.Text = bahanname
        nm_stock.Value = bahanstock
        If bahanunit = "Meter" Then
            cb_unit.SelectedIndex = 0
        ElseIf bahanunit = "Unit" Then
            cb_unit.SelectedIndex = 1
        End If
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        sql = "UPDATE bahan SET BAHANNAME='" + txt_namabahan.Text + "', BAHANUNIT='" + cb_unit.SelectedItem.ToString + "' WHERE BAHANID='" + txt_kodebahan.Text + "'"
        proses.ExecuteNonQuery(sql)
        MsgBox("Data bahan telah diubah", MsgBoxStyle.Information, "Sukses")
        clear()
        FormGudang.Load_DataBahan()
        Me.Close()
    End Sub
End Class