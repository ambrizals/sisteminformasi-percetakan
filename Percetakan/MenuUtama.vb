Public Class MenuUtama
    Dim proses As New ClsKoneksi
    Dim query As String
    Dim absen_date, absen_status As String
    Sub Connect()
        Koneksi()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.Green
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
        End If
    End Sub
    Sub ReconfigDB()
        Koneksi()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.Green
            MsgBox("Pengaturan berhasil diterapkan", MsgBoxStyle.Information, "Info")
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
            MsgBox("Pengaturan Gagal diterapkan, pastikan server telah online dan konfigurasi yang di masukkan telah benar", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Sub ReconectDB()
        Koneksi()
        If str_status > 0 Then
            lbl_constatus.Text = "Terhubung"
            lbl_constatus.ForeColor = Color.Green
        Else
            lbl_constatus.Text = "Terputus"
            lbl_constatus.ForeColor = Color.Red
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Sub Privilage_User()
        If kry_lvl = "OPERATOR" Then
            BtnPesanan.Enabled = False
            BtnKaryawan.Enabled = False
            BtnAbsensi.Enabled = False
            BtnSimpanPengumuman.Enabled = False
            BtnSimpanPengumuman.Visible = False
            rtf_pengumuman.ReadOnly = True
        ElseIf kry_lvl = "KASIR" Then
            BtnKaryawan.Enabled = False
            BtnGudang.Enabled = False
            BtnSimpanPengumuman.Enabled = False
            BtnSimpanPengumuman.Visible = False
            rtf_pengumuman.ReadOnly = True
        End If
    End Sub
    Sub ambil_pengumuman()
        Try
            proses.OpenConn()
            query = ("SELECT * FROM pengaturan WHERE pengaturanName = 'pengumuman'")
            proses.Cmd.Connection = proses.Cn
            proses.Cmd.CommandText = query
            proses.Da.SelectCommand = proses.Cmd
            proses.read = proses.Cmd.ExecuteReader()
            proses.read.Read()
            If proses.read.HasRows Then
                rtf_pengumuman.Text = proses.read("pengaturanIsi")
            End If
            proses.CloseConn()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub absensi()
        Dim tgl As Date = Today
        Dim tm As Date = TimeOfDay
        Dim tanggal_now As String = Format(tgl, "yyyy-MM-dd").ToString
        Dim time_now As String = Format(tm, "HH:mm:ss").ToString
        proses.OpenConn()
        Try
            query = ("SELECT * FROM cuti WHERE ((CURDATE() >= cutiMulai) & (CURDATE() <= cutiAkhir)) AND (karyawanID = '" + kry_id + "')")
            proses.Cmd.Connection = proses.Cn
            proses.Cmd.CommandText = query
            proses.Da.SelectCommand = proses.Cmd
            proses.read = proses.Cmd.ExecuteReader()
            If proses.read.HasRows Then
                MsgBox("Anda sedang cuti. program akan keluar secara otomatis", MsgBoxStyle.Information, "Info")
                Me.Close()
            Else
                proses.OpenConn()
                query = ("SELECT * FROM absensi WHERE (absensiDATE = CURDATE()) AND (karyawanID = '" + kry_id + "')")
                proses.Cmd.Connection = proses.Cn
                proses.Cmd.CommandText = query
                proses.Da.SelectCommand = proses.Cmd
                proses.read = proses.Cmd.ExecuteReader()
                If proses.read.HasRows Then
                    'Nothing here
                Else
                    Try
                        query = ("INSERT INTO absensi (karyawanID, absensiDATE, absensiTIME, absensiSTATUS) VALUES ('" + kry_id + "', '" + tanggal_now + "', '" + time_now + "', 'Masuk')")
                        proses.ExecuteNonQuery(query)
                        MsgBox("Absen otomatis telah dilakukan")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                proses.CloseConn()
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " + vbCr + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        proses.CloseConn()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Hide()
        Login.Close()
    End Sub

    Private Sub BtnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        Logout()
        Me.Hide()
        Login.Show()
    End Sub


    Private Sub BtnReconnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnReconnect.Click
        ReconectDB()
    End Sub

    Private Sub MenuUtama_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Login.Close()
    End Sub

    Private Sub MenuUtama_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ambil_pengumuman()
        absensi()
        Privilage_User()
        Connect()
    End Sub
    Private Sub BtnKaryawan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKaryawan.Click
        'Try
        If str_status > 0 Then
            proses.OpenConn()
            FormKaryawan.ShowDialog()
            proses.CloseConn()
        Else
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            str_status = 0
        End If
        'Catch ex As Exception
        'MsgBox("Terjadi kesalahan, hubungi administrator untuk info lebih lanjut \n" + ex.Message, MsgBoxStyle.Critical, "Connection Error")
        'Connect()
        'End Try
    End Sub
    Private Sub BtnPesanan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPesanan.Click
        'Try
        If str_status > 0 Then
            proses.OpenConn()
            FormPesanan.ShowDialog()
            proses.CloseConn()
        Else
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            str_status = 0
        End If
        'Catch ex As Exception
        'MsgBox("Terjadi kesalahan, hubungi administrator untuk info lebih lanjut" + ex.Message, MsgBoxStyle.Critical, "Connection Error")
        'Connect()
        'End Try
    End Sub
    Private Sub BtnJobList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJobList.Click
        'Try
        If str_status > 0 Then
            proses.OpenConn()
            FormJobList.ShowDialog()
            proses.CloseConn()
        Else
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            str_status = 0
        End If
        'Catch ex As Exception
        'MsgBox("Terjadi kesalahan, hubungi administrator untuk info lebih lanjut" + ex.Message, MsgBoxStyle.Critical, "Connection Error")
        'Connect()
        'End Try
    End Sub
    Private Sub BtnAbsensi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbsensi.Click
        'Try
        If str_status > 0 Then
            proses.OpenConn()
            FormAbsensi.ShowDialog()
            proses.CloseConn()
        Else
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            str_status = 0
        End If
        'Catch ex As Exception
        ' MsgBox("Terjadi kesalahan, hubungi administrator untuk info lebih lanjut" + ex.Message, MsgBoxStyle.Critical, "Connection Error")
        'Connect()
        'End Try
    End Sub

    Private Sub BtnGudang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGudang.Click
        'Try
        If str_status > 0 Then
            proses.OpenConn()
            FormGudang.ShowDialog()
            proses.CloseConn()
        Else
            MsgBox("Gagal terhubung ke server", MsgBoxStyle.Critical, "Connection Error")
            str_status = 0
        End If
        'Catch ex As Exception
        'MsgBox("Terjadi kesalahan, hubungi administrator untuk info lebih lanjut " + vbCr + ex.Message, MsgBoxStyle.Critical, "Connection Error")
        'Connect()
        'End Try
    End Sub


    Private Sub BtnSimpanPengumuman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpanPengumuman.Click
        Try
            query = "UPDATE pengaturan SET pengaturanIsi = '" + rtf_pengumuman.Text + "' WHERE pengaturanName = 'pengumuman'"
            proses.ExecuteNonQuery(query)
            MsgBox("Pengumuman telah disimpan", MsgBoxStyle.Information, "Info")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan : " + vbCr + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ServerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServerToolStripMenuItem.Click
        FormConfig.ShowDialog()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub JobListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JobListToolStripMenuItem.Click
        FormLaporanProsesPekerjaan.ShowDialog()
    End Sub

    Private Sub DaftarKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarKaryawanToolStripMenuItem.Click
        FormDataKaryawan.ShowDialog()
    End Sub

    Private Sub DaftarHadirKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarHadirKaryawanToolStripMenuItem.Click
        LaporanKehadiran.ShowDialog()
    End Sub
End Class
