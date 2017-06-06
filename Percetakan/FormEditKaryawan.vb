Imports System.Data.OleDb
Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormEditKaryawan
    Public error_empty As Integer
    Public query As String
    Public proses As New ClsKoneksi
    Public list_karyawan As DataTable

    Public jabatan As String
    Public sql As String
    Public kode_karyawan, jabatan_karyawan, nama_karyawan, user_karyawan, password_karyawan, alamat_karyawan, telepon_karyawan As String

    Sub ambil_data()
        Dim kd_karyawan
        kd_karyawan = FormKaryawan.DG_ListKaryawan.SelectedCells(0).Value
        proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "Select * From Karyawan where karyawanid = '" + kd_karyawan + "'"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()
        mydata.Read()
        If (mydata.HasRows) Then
            kode_karyawan = mydata("KARYAWANID")
            jabatan_karyawan = mydata("LEVELID")
            nama_karyawan = mydata("KARYAWANNAME")
            user_karyawan = mydata("KARYAWANUSERNAME")
            password_karyawan = mydata("KARYAWANPASSWORD")
            alamat_karyawan = mydata("KARYAWANALAMAT")
            telepon_karyawan = mydata("KARYAWANTELP")
        End If
        proses.CloseConn()

    End Sub

    Private Sub FormEditKaryawan_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        kode_karyawan = ""
        reset()
    End Sub
    Private Sub FormKaryawan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ambil_data()
        Me.Text = "Ubah Karyawan : " + nama_karyawan
        txt_idkaryawan.Text = kode_karyawan
        txt_namakaryawan.Text = nama_karyawan
        txt_userkaryawan.Text = user_karyawan
        txt_passwordkaryawan.Text = password_karyawan
        rtf_alamat.Text = alamat_karyawan
        txt_telepon.Text = telepon_karyawan

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
        jabatan = "null"
    End Sub
    Private Sub cb_validdata_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_validdata.Click
        validation_empty()
        If error_empty > 0 Then
            MsgBox("Data belum terisi", MsgBoxStyle.Critical, "Error")
            cb_validdata.Checked = False
        Else
            cb_validdata.Checked = True
            BtnSave.Enabled = True
        End If
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
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            sql = "UPDATE karyawan SET LEVELID = '" + jabatan + "' , KARYAWANNAME = '" + txt_namakaryawan.Text + "' , KARYAWANUSERNAME = '" + txt_userkaryawan.Text + "' , KARYAWANPASSWORD = '" + txt_passwordkaryawan.Text + "' , KARYAWANALAMAT = '" + rtf_alamat.Text + "' , KARYAWANTELP = '" + txt_telepon.Text + "' WHERE KARYAWANID = '" + kode_karyawan + "'"
            proses.ExecuteNonQuery(sql)
            MsgBox("Data tersimpan", MsgBoxStyle.Information, "Sukses")
            FormKaryawan.Load_DataKaryawan()
            reset()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan, silahkan periksa koneksi atau hubungi administrator", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        reset()
    End Sub

End Class