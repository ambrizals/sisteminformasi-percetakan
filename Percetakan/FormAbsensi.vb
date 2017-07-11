Imports System.Data.OleDb
Imports System.Data
Imports MySql.Data.MySqlClient
Public Class FormAbsensi
    Dim proses As New ClsKoneksi
    Dim tbl_absen, tblcuti As DataTable
    Sub ambil_data()
        tbl_absen = proses.ExecuteQuery("SELECT karyawan.KARYAWANNAME as 'Nama Karyawan', absensi.absensiDATE as 'Tanggal Absen', absensi.absensiTIME as 'Waktu Absen', absensi.absensiSTATUS as 'Status' from absensi INNER JOIN karyawan on (absensi.karyawanID = karyawan.KARYAWANID) where absensi.absensiDATE = curdate();")
        DG_Absensi.DataSource = tbl_absen
        DG_Absensi.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tblcuti = proses.ExecuteQuery("SELECT karyawan.KARYAWANNAME AS 'Nama Karyawan', cuti.cutiAlasan AS 'Alasan', cuti.cutiMulai AS 'Mulai Cuti', cuti.CutiAkhir AS 'Akhir Cuti' FROM cuti INNER JOIN karyawan ON (cuti.KaryawanID = karyawan.karyawanID) WHERE (CURDATE() >= cutiMulai) & (CURDATE() <= cutiAkhir)")
        DG_Cuti.DataSource = tblcuti
        DG_Cuti.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub BtnCuti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCuti.Click
        FormAbsenTambahcuti.ShowDialog()
    End Sub

    Private Sub FormAbsensi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ambil_data()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        ambil_data()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub
End Class