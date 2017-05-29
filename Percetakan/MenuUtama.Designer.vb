<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UbahProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsensiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarHadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarTidakHadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_constatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnReconnect = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnKaryawan = New System.Windows.Forms.Button()
        Me.BtnJobList = New System.Windows.Forms.Button()
        Me.BtnGudang = New System.Windows.Forms.Button()
        Me.BtnPesanan = New System.Windows.Forms.Button()
        Me.BtnLaporan = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UbahProfilToolStripMenuItem, Me.AbsensiToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(473, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UbahProfilToolStripMenuItem
        '
        Me.UbahProfilToolStripMenuItem.Name = "UbahProfilToolStripMenuItem"
        Me.UbahProfilToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.UbahProfilToolStripMenuItem.Text = "Ubah Profil"
        '
        'AbsensiToolStripMenuItem
        '
        Me.AbsensiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarHadirToolStripMenuItem, Me.DaftarTidakHadirToolStripMenuItem})
        Me.AbsensiToolStripMenuItem.Name = "AbsensiToolStripMenuItem"
        Me.AbsensiToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AbsensiToolStripMenuItem.Text = "Absensi"
        '
        'DaftarHadirToolStripMenuItem
        '
        Me.DaftarHadirToolStripMenuItem.Name = "DaftarHadirToolStripMenuItem"
        Me.DaftarHadirToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DaftarHadirToolStripMenuItem.Text = "Daftar Hadir"
        '
        'DaftarTidakHadirToolStripMenuItem
        '
        Me.DaftarTidakHadirToolStripMenuItem.Name = "DaftarTidakHadirToolStripMenuItem"
        Me.DaftarTidakHadirToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DaftarTidakHadirToolStripMenuItem.Text = "Daftar Tidak Hadir"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 334)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(473, 57)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_constatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 51)
        Me.Panel1.TabIndex = 0
        '
        'lbl_constatus
        '
        Me.lbl_constatus.AutoSize = True
        Me.lbl_constatus.Location = New System.Drawing.Point(99, 21)
        Me.lbl_constatus.Name = "lbl_constatus"
        Me.lbl_constatus.Size = New System.Drawing.Size(25, 13)
        Me.lbl_constatus.TabIndex = 1
        Me.lbl_constatus.Text = "Null"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Status Koneksi :"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(217, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 51)
        Me.Panel3.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnReconnect, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnLogout, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnKeluar, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(247, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BtnReconnect
        '
        Me.BtnReconnect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReconnect.Location = New System.Drawing.Point(176, 3)
        Me.BtnReconnect.Name = "BtnReconnect"
        Me.BtnReconnect.Size = New System.Drawing.Size(68, 39)
        Me.BtnReconnect.TabIndex = 5
        Me.BtnReconnect.Text = "Reconnect"
        Me.BtnReconnect.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLogout.Location = New System.Drawing.Point(88, 3)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(82, 39)
        Me.BtnLogout.TabIndex = 4
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnKeluar.Location = New System.Drawing.Point(3, 3)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(79, 39)
        Me.BtnKeluar.TabIndex = 3
        Me.BtnKeluar.Text = "Exit"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 310)
        Me.Panel2.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.92389!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.09514!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.19239!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnKaryawan, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnJobList, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnGudang, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnPesanan, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnLaporan, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Button6, 2, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(473, 310)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'BtnKaryawan
        '
        Me.BtnKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnKaryawan.Location = New System.Drawing.Point(3, 3)
        Me.BtnKaryawan.Name = "BtnKaryawan"
        Me.BtnKaryawan.Size = New System.Drawing.Size(144, 149)
        Me.BtnKaryawan.TabIndex = 0
        Me.BtnKaryawan.Text = "Karyawan"
        Me.BtnKaryawan.UseVisualStyleBackColor = True
        '
        'BtnJobList
        '
        Me.BtnJobList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnJobList.Location = New System.Drawing.Point(153, 3)
        Me.BtnJobList.Name = "BtnJobList"
        Me.BtnJobList.Size = New System.Drawing.Size(159, 149)
        Me.BtnJobList.TabIndex = 1
        Me.BtnJobList.Text = "Joblist"
        Me.BtnJobList.UseVisualStyleBackColor = True
        '
        'BtnGudang
        '
        Me.BtnGudang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnGudang.Location = New System.Drawing.Point(318, 3)
        Me.BtnGudang.Name = "BtnGudang"
        Me.BtnGudang.Size = New System.Drawing.Size(152, 149)
        Me.BtnGudang.TabIndex = 2
        Me.BtnGudang.Text = "Gudang"
        Me.BtnGudang.UseVisualStyleBackColor = True
        '
        'BtnPesanan
        '
        Me.BtnPesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPesanan.Location = New System.Drawing.Point(3, 158)
        Me.BtnPesanan.Name = "BtnPesanan"
        Me.BtnPesanan.Size = New System.Drawing.Size(144, 149)
        Me.BtnPesanan.TabIndex = 3
        Me.BtnPesanan.Text = "Pesanan"
        Me.BtnPesanan.UseVisualStyleBackColor = True
        '
        'BtnLaporan
        '
        Me.BtnLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLaporan.Location = New System.Drawing.Point(153, 158)
        Me.BtnLaporan.Name = "BtnLaporan"
        Me.BtnLaporan.Size = New System.Drawing.Size(159, 149)
        Me.BtnLaporan.TabIndex = 4
        Me.BtnLaporan.Text = "Laporan"
        Me.BtnLaporan.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.Location = New System.Drawing.Point(318, 158)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(152, 149)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 391)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_constatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnReconnect As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnKaryawan As System.Windows.Forms.Button
    Friend WithEvents BtnJobList As System.Windows.Forms.Button
    Friend WithEvents BtnGudang As System.Windows.Forms.Button
    Friend WithEvents BtnPesanan As System.Windows.Forms.Button
    Friend WithEvents BtnLaporan As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents UbahProfilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsensiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarHadirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarTidakHadirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
