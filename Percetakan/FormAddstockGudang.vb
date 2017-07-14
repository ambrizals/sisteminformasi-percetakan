Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data
Public Class FormAddstockGudang
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
        txt_stoksekarang.Clear
        lbl_unit1.Text = bahanunit
        lbl_unit2.Text = bahanunit
        nm_stock.Value = 0
    End Sub

    Private Sub FormAddstockGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ambil_data()
        txt_kodebahan.Text = bahanid
        txt_namabahan.Text = bahanname
        txt_stoksekarang.Text = Val(bahanstock)
        lbl_unit1.Text = bahanunit
        lbl_unit2.Text = bahanunit
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        bahantambah = nm_stock.Value
        stock = bahantambah + bahanstock
        stockq = Val(stock)
        sql = "UPDATE bahan SET BAHANSTOCK ='" + stockq + "' WHERE BAHANID = '" + bahanid + "'"
        proses.ExecuteNonQuery(sql)
        sql = "INSERT INTO log_bahan (KARYAWANID, BAHANID, MEMASUKKANDATE, MEMASUKKANSTATUS) VALUES ('" + kry_id + "', '" + txt_kodebahan.Text + "', '" + tanggal + "', 'TAMBAH STOCK')"
        proses.ExecuteNonQuery(sql)
        MsgBox("Stock Telah ditambah", MsgBoxStyle.Information, "Sukses")
        clear()
        FormGudang.Load_DataBahan()
        Me.Close()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
End Class