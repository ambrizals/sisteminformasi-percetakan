Imports MySql.Data.MySqlClient

Public Class FormAddGudang
    Dim proses As New ClsKoneksi
    Dim kd_bahan, sql As String

    Sub load_adddata()
        proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT * FROM bahan"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()
        Dim bahancount As Integer
        Dim bahan_str As String
        bahancount = 0
        If (mydata.HasRows) Then
            While (mydata.Read)
                bahancount = bahancount + 1
            End While
        End If
        bahan_str = Val(bahancount + 1)
        txt_kodebahan.Text = "BHN - " + bahan_str
        proses.CloseConn()
    End Sub
    Sub Clear()
        txt_kodebahan.Clear()
        txt_namabahan.Clear()
        txt_harga.Clear()
    End Sub

    Private Sub FormAddGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        load_adddata()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Try
            sql = "INSERT INTO bahan (BAHANID, BAHANNAME, BAHANHARGA) VALUES ('" + txt_kodebahan.Text + "', '" + txt_namabahan.Text + "', '" + txt_harga.Text + "')"
            proses.ExecuteNonQuery(sql)
            MsgBox("Data tersimpan", MsgBoxStyle.Information, "Sukses")
            sql = "INSERT INTO log_bahan (KARYAWANID, BAHANID, MEMASUKKANDATE, MEMASUKKANSTATUS) VALUES ('" + kry_id + "', '" + txt_kodebahan.Text + "', '" + tanggal + "', 'TAMBAH BAHAN')"
            proses.ExecuteNonQuery(sql)
            Clear()
            FormGudang.Load_DataBahan()
            Me.Close()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan, silahkan periksa koneksi atau hubungi administrator" + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click

    End Sub
    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        kd_bahan = ""
        Me.Hide()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Me.Close()
    End Sub
End Class