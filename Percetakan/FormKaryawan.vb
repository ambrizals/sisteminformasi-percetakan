Imports System.Data.OleDb
Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormKaryawan
    Public error_empty As Integer
    Public query As String
    Public proses As New ClsKoneksi
    Public list_karyawan As DataTable

    Public jabatan As String
    Public sql As String

    Sub Load_DataKaryawan()
        list_karyawan = proses.ExecuteQuery("SELECT karyawan.karyawanid AS 'ID Karyawan',jabatan.levelname AS 'Jabatan',karyawan.karyawanname AS 'Nama Karyawan', karyawan.karyawanusername AS 'Username' FROM karyawan INNER JOIN jabatan ON (karyawan.levelid = jabatan.levelid)")
        DG_ListKaryawan.DataSource = list_karyawan
        DG_ListKaryawan.Columns(0).Width = 120
        DG_ListKaryawan.Columns(1).Width = 100
        DG_ListKaryawan.Columns(2).Width = 245
        DG_ListKaryawan.Columns(3).Width = 200

        proses.OpenConn()

        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT karyawan.karyawanid AS 'ID Karyawan',jabatan.levelname AS 'Jabatan',karyawan.karyawanname AS 'Nama Karyawan', karyawan.karyawanusername AS 'Username' FROM karyawan INNER JOIN jabatan ON (karyawan.levelid = jabatan.levelid)"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()
        Dim karyawancount As Integer
        Dim karyawan_kode As String
        karyawancount = 0
        If (mydata.HasRows) Then
            While (mydata.Read)
                karyawancount = karyawancount + 1
            End While
        End If
        lbl_karyawancount.Text = Val(karyawancount)
        karyawan_kode = Val(karyawancount + 1)
        txt_idkaryawan.Text = "KRY-" + karyawan_kode
        proses.CloseConn()
    End Sub
    Sub Search_Karyawan()
        list_karyawan = proses.ExecuteQuery("SELECT karyawan.karyawanid AS 'ID Karyawan',jabatan.levelname AS 'Jabatan',karyawan.karyawanname AS 'Nama Karyawan', karyawan.karyawanusername AS 'Username' FROM karyawan INNER JOIN jabatan ON (karyawan.levelid = jabatan.levelid) WHERE karyawan.karyawanname LIKE '%" + txt_carikaryawan.Text + "%'")
        DG_ListKaryawan.DataSource = list_karyawan
        DG_ListKaryawan.Columns(0).Width = 120
        DG_ListKaryawan.Columns(1).Width = 100
        DG_ListKaryawan.Columns(2).Width = 245
        DG_ListKaryawan.Columns(3).Width = 200
    End Sub

    Private Sub FormKaryawan_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        reset()
    End Sub

    Private Sub FormKaryawan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Load_DataKaryawan()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Sub validation_empty()
        Dim er_empty As Integer
        If (txt_namakaryawan.TextLength = 0) Then
            If (txt_userkaryawan.TextLength = 0) Then
                If (txt_passwordkaryawan.TextLength = 0) Then
                    If (rtf_alamat.TextLength = 0) Then
                        If (txt_telepon.TextLength = 0) Then
                            er_empty = 1
                        End If
                    End If
                End If
            End If
        Else
            er_empty = 0
        End If
        error_empty = er_empty
    End Sub

    Sub reset()
        txt_namakaryawan.Clear()
        txt_passwordkaryawan.Clear()
        txt_userkaryawan.Clear()
        rtf_alamat.Clear()
        txt_telepon.Clear()
        cb_jabatan.SelectedIndex = -1
        rtf_deskripsi.Clear()
        cb_validdata.Checked = False
        cb_interviewcheck.Checked = False
        cb_rulesconfirm.Checked = False
        jabatan = "null"
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        reset()
    End Sub
    Private Sub cb_jabatan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_jabatan.SelectedIndexChanged
        If cb_jabatan.SelectedIndex = 0 Then
            rtf_deskripsi.Text = "Admin memiliki seluruh kontrol terhadap aplikasi ini"
            jabatan = "JBT-001"
        ElseIf cb_jabatan.SelectedIndex = 1 Then
            rtf_deskripsi.Text = "Operator hanya dapat mengontrol Job List dan Gudang. Silahkan hubungi admin atau kasir jika ingin mengubah data yang di cekal"
            jabatan = "JBT-002"
        ElseIf cb_jabatan.SelectedIndex = 2 Then
            rtf_deskripsi.Text = "Kasir hanya dapat mengontrol pesanan, job list, dan laporan. Silahkan hubungi admin atau operator jika ingin mengubah data yang di cekal"
            jabatan = "JBT-003"
        End If
    End Sub

    Private Sub cb_validdata_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_validdata.Click
        validation_empty()
        If error_empty > 0 Then
            MsgBox("Data belum terisi", MsgBoxStyle.Critical, "Error")
            cb_validdata.Checked = False
        Else
            cb_validdata.Checked = True
        End If
    End Sub

    Private Sub cb_rulesconfirm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_rulesconfirm.Click
        If cb_validdata.Checked = True Then
            If cb_interviewcheck.Checked = True Then
                If cb_rulesconfirm.Checked = True Then
                    BtnSave.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If str_status > 0 Then
            Try
                sql = "INSERT INTO karyawan (KARYAWANID, LEVELID, KARYAWANNAME, KARYAWANUSERNAME, KARYAWANPASSWORD, KARYAWANALAMAT, KARYAWANTELP) VALUES ('" + txt_idkaryawan.Text + "', '" + jabatan + "', '" + txt_namakaryawan.Text + "', '" + txt_userkaryawan.Text + "', '" + txt_passwordkaryawan.Text + "', '" + rtf_alamat.Text + "', '" + txt_telepon.Text + "')"
                proses.ExecuteNonQuery(sql)
                MsgBox("Data tersimpan", MsgBoxStyle.Information, "Sukses")
                reset()
                Load_DataKaryawan()
            Catch ex As Exception
                MsgBox("Terjadi Kesalahan, silahkan periksa koneksi atau hubungi administrator", MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MsgBox("Koneksi terputus, silahkan lakukan reconnect terlebih dahulu", MsgBoxStyle.Critical, "Connection Error")
        End If
    End Sub

    Private Sub btn_carikaryawan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carikaryawan.Click
        Search_Karyawan()
    End Sub


    Private Sub DG_ListKaryawan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_ListKaryawan.DoubleClick
        FormEditKaryawan.ShowDialog()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Me.Close()

    End Sub
End Class