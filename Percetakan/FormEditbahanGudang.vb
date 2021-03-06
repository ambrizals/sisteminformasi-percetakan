﻿Imports MySql.Data.MySqlClient
Public Class FormEditbahanGudang
    Dim proses As New ClsKoneksi
    Dim bahanid, bahanname, sql, stockq As String
    Dim stock, bahanstock, bahantambah, bahanharga As Double
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
            bahanharga = mydata("BAHANHARGA")
        End If
        proses.CloseConn()
    End Sub
    Sub clear()
        txt_kodebahan.Clear()
        txt_namabahan.Clear()
    End Sub

    Private Sub FormEditbahanGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ambil_data()
        Me.Text = "Ubah Data Bahan : " + bahanname
        txt_kodebahan.Text = bahanid
        txt_namabahan.Text = bahanname
        txt_harga.Text = Val(bahanharga)
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Dim tanggal As String
        Dim tgl As Date = Today
        Dim tm As Date = TimeOfDay
        tanggal = Format(tgl, "yyyy-MM-dd").ToString + " " + Format(tm, "HH:mm:ss").ToString
        Try
            sql = "UPDATE bahan SET BAHANNAME='" + txt_namabahan.Text + "', BAHANHARGA = '" + txt_harga.Text + "' WHERE BAHANID='" + txt_kodebahan.Text + "'"
            proses.ExecuteNonQuery(sql)
            sql = "INSERT INTO log_bahan (KARYAWANID, BAHANID, MEMASUKKANDATE, MEMASUKKANSTATUS) VALUES ('" + kry_id + "', '" + txt_kodebahan.Text + "', '" + tanggal + "', 'UBAH BAHAN')"
            proses.ExecuteNonQuery(sql)
            MsgBox("Data bahan telah diubah", MsgBoxStyle.Information, "Sukses")
            clear()
            FormGudang.Load_DataBahan()
            Me.Close()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan, silahkan periksa koneksi atau hubungi administrator" + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Close()
    End Sub
End Class