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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_constatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnReconnect = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Sidebar_Row = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnKaryawan = New System.Windows.Forms.Button()
        Me.BtnJobList = New System.Windows.Forms.Button()
        Me.BtnAbsensi = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPesanan = New System.Windows.Forms.Button()
        Me.BtnGudang = New System.Windows.Forms.Button()
        Me.Sidebar_Kanan = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rtf_pengumuman = New System.Windows.Forms.RichTextBox()
        Me.BtnSimpanPengumuman = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaftarHadirKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JobListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Sidebar_Row.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Sidebar_Kanan.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 555)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(807, 57)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.lbl_constatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 51)
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
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(369, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(435, 51)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(429, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BtnReconnect
        '
        Me.BtnReconnect.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnReconnect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReconnect.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReconnect.Location = New System.Drawing.Point(304, 3)
        Me.BtnReconnect.Name = "BtnReconnect"
        Me.BtnReconnect.Size = New System.Drawing.Size(122, 39)
        Me.BtnReconnect.TabIndex = 5
        Me.BtnReconnect.Text = "Reconnect"
        Me.BtnReconnect.UseVisualStyleBackColor = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogout.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLogout.Location = New System.Drawing.Point(151, 3)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(147, 39)
        Me.BtnLogout.TabIndex = 4
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'BtnKeluar
        '
        Me.BtnKeluar.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnKeluar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnKeluar.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKeluar.Location = New System.Drawing.Point(3, 3)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(142, 39)
        Me.BtnKeluar.TabIndex = 3
        Me.BtnKeluar.Text = "Exit"
        Me.BtnKeluar.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 98)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Sidebar_Row)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SplitContainer1.Panel2.Controls.Add(Me.Sidebar_Kanan)
        Me.SplitContainer1.Size = New System.Drawing.Size(807, 457)
        Me.SplitContainer1.SplitterDistance = 325
        Me.SplitContainer1.TabIndex = 3
        '
        'Sidebar_Row
        '
        Me.Sidebar_Row.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Sidebar_Row.ColumnCount = 1
        Me.Sidebar_Row.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Sidebar_Row.Controls.Add(Me.GroupBox1, 0, 0)
        Me.Sidebar_Row.Controls.Add(Me.GroupBox2, 0, 1)
        Me.Sidebar_Row.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sidebar_Row.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar_Row.Name = "Sidebar_Row"
        Me.Sidebar_Row.RowCount = 2
        Me.Sidebar_Row.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.54923!))
        Me.Sidebar_Row.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.45077!))
        Me.Sidebar_Row.Size = New System.Drawing.Size(325, 457)
        Me.Sidebar_Row.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administrasi"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnKaryawan, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnJobList, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnAbsensi, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(313, 237)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'BtnKaryawan
        '
        Me.BtnKaryawan.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnKaryawan.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKaryawan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnKaryawan.Image = CType(resources.GetObject("BtnKaryawan.Image"), System.Drawing.Image)
        Me.BtnKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKaryawan.Location = New System.Drawing.Point(3, 3)
        Me.BtnKaryawan.Name = "BtnKaryawan"
        Me.BtnKaryawan.Size = New System.Drawing.Size(307, 73)
        Me.BtnKaryawan.TabIndex = 0
        Me.BtnKaryawan.Text = "Karyawan"
        Me.BtnKaryawan.UseVisualStyleBackColor = False
        '
        'BtnJobList
        '
        Me.BtnJobList.AutoEllipsis = True
        Me.BtnJobList.BackColor = System.Drawing.Color.Salmon
        Me.BtnJobList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnJobList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJobList.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnJobList.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnJobList.Image = CType(resources.GetObject("BtnJobList.Image"), System.Drawing.Image)
        Me.BtnJobList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnJobList.Location = New System.Drawing.Point(3, 82)
        Me.BtnJobList.Name = "BtnJobList"
        Me.BtnJobList.Size = New System.Drawing.Size(307, 73)
        Me.BtnJobList.TabIndex = 1
        Me.BtnJobList.Text = "Job List"
        Me.BtnJobList.UseVisualStyleBackColor = False
        '
        'BtnAbsensi
        '
        Me.BtnAbsensi.BackColor = System.Drawing.Color.SaddleBrown
        Me.BtnAbsensi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAbsensi.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbsensi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnAbsensi.Image = CType(resources.GetObject("BtnAbsensi.Image"), System.Drawing.Image)
        Me.BtnAbsensi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAbsensi.Location = New System.Drawing.Point(3, 161)
        Me.BtnAbsensi.Name = "BtnAbsensi"
        Me.BtnAbsensi.Size = New System.Drawing.Size(307, 73)
        Me.BtnAbsensi.TabIndex = 2
        Me.BtnAbsensi.Text = "Absensi"
        Me.BtnAbsensi.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 189)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.BtnPesanan, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnGudang, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(313, 170)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'BtnPesanan
        '
        Me.BtnPesanan.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnPesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPesanan.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesanan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesanan.Image = CType(resources.GetObject("BtnPesanan.Image"), System.Drawing.Image)
        Me.BtnPesanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPesanan.Location = New System.Drawing.Point(3, 88)
        Me.BtnPesanan.Name = "BtnPesanan"
        Me.BtnPesanan.Size = New System.Drawing.Size(307, 79)
        Me.BtnPesanan.TabIndex = 2
        Me.BtnPesanan.Text = "Pesanan"
        Me.BtnPesanan.UseVisualStyleBackColor = False
        '
        'BtnGudang
        '
        Me.BtnGudang.BackColor = System.Drawing.Color.MediumVioletRed
        Me.BtnGudang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnGudang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnGudang.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGudang.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGudang.Image = CType(resources.GetObject("BtnGudang.Image"), System.Drawing.Image)
        Me.BtnGudang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGudang.Location = New System.Drawing.Point(3, 3)
        Me.BtnGudang.Name = "BtnGudang"
        Me.BtnGudang.Size = New System.Drawing.Size(307, 79)
        Me.BtnGudang.TabIndex = 0
        Me.BtnGudang.Text = "Daftar Bahan"
        Me.BtnGudang.UseVisualStyleBackColor = False
        '
        'Sidebar_Kanan
        '
        Me.Sidebar_Kanan.ColumnCount = 1
        Me.Sidebar_Kanan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Sidebar_Kanan.Controls.Add(Me.GroupBox4, 0, 1)
        Me.Sidebar_Kanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sidebar_Kanan.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar_Kanan.Name = "Sidebar_Kanan"
        Me.Sidebar_Kanan.RowCount = 2
        Me.Sidebar_Kanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.12991!))
        Me.Sidebar_Kanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.87009!))
        Me.Sidebar_Kanan.Size = New System.Drawing.Size(478, 457)
        Me.Sidebar_Kanan.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rtf_pengumuman)
        Me.GroupBox4.Controls.Add(Me.BtnSimpanPengumuman)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 218)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(472, 236)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pengumuman :"
        '
        'rtf_pengumuman
        '
        Me.rtf_pengumuman.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtf_pengumuman.Location = New System.Drawing.Point(3, 16)
        Me.rtf_pengumuman.Name = "rtf_pengumuman"
        Me.rtf_pengumuman.Size = New System.Drawing.Size(466, 184)
        Me.rtf_pengumuman.TabIndex = 0
        Me.rtf_pengumuman.Text = ""
        '
        'BtnSimpanPengumuman
        '
        Me.BtnSimpanPengumuman.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSimpanPengumuman.Location = New System.Drawing.Point(3, 200)
        Me.BtnSimpanPengumuman.Name = "BtnSimpanPengumuman"
        Me.BtnSimpanPengumuman.Size = New System.Drawing.Size(466, 33)
        Me.BtnSimpanPengumuman.TabIndex = 1
        Me.BtnSimpanPengumuman.Text = "Simpan Pengumuman"
        Me.BtnSimpanPengumuman.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.20155!))
        Me.TableLayoutPanel5.Controls.Add(Me.MenuStrip1, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel9, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(807, 95)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengaturanToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 54)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(807, 41)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(80, 37)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ServerToolStripMenuItem.Text = "Server"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KaryawanToolStripMenuItem, Me.JobListToolStripMenuItem, Me.PesananToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 37)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaftarKaryawanToolStripMenuItem, Me.DaftarHadirKaryawanToolStripMenuItem})
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KaryawanToolStripMenuItem.Text = "Karyawan"
        '
        'DaftarKaryawanToolStripMenuItem
        '
        Me.DaftarKaryawanToolStripMenuItem.Name = "DaftarKaryawanToolStripMenuItem"
        Me.DaftarKaryawanToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.DaftarKaryawanToolStripMenuItem.Text = "Laporan Data Karyawan"
        '
        'DaftarHadirKaryawanToolStripMenuItem
        '
        Me.DaftarHadirKaryawanToolStripMenuItem.Name = "DaftarHadirKaryawanToolStripMenuItem"
        Me.DaftarHadirKaryawanToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.DaftarHadirKaryawanToolStripMenuItem.Text = "Laporan Kehadiran Karyawan"
        '
        'JobListToolStripMenuItem
        '
        Me.JobListToolStripMenuItem.Name = "JobListToolStripMenuItem"
        Me.JobListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JobListToolStripMenuItem.Text = "Job List"
        '
        'PesananToolStripMenuItem
        '
        Me.PesananToolStripMenuItem.Name = "PesananToolStripMenuItem"
        Me.PesananToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PesananToolStripMenuItem.Text = "Pesanan"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 37)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 3
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel9.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Panel4, 2, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(801, 48)
        Me.TableLayoutPanel9.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(270, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 48)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MENU"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 42)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnMin)
        Me.Panel4.Controls.Add(Me.BtnClose)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(537, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(261, 42)
        Me.Panel4.TabIndex = 4
        '
        'BtnMin
        '
        Me.BtnMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.Location = New System.Drawing.Point(194, 9)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(28, 23)
        Me.BtnMin.TabIndex = 1
        Me.BtnMin.Text = "-"
        Me.BtnMin.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Location = New System.Drawing.Point(228, 9)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(28, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(807, 612)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Sidebar_Row.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Sidebar_Kanan.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_constatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnReconnect As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Sidebar_Row As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnGudang As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PengaturanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnKaryawan As System.Windows.Forms.Button
    Friend WithEvents BtnJobList As System.Windows.Forms.Button
    Friend WithEvents BtnAbsensi As System.Windows.Forms.Button
    Friend WithEvents Sidebar_Kanan As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSimpanPengumuman As System.Windows.Forms.Button
    Friend WithEvents rtf_pengumuman As System.Windows.Forms.RichTextBox
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaftarHadirKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JobListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnMin As System.Windows.Forms.Button
    Friend WithEvents BtnPesanan As System.Windows.Forms.Button
End Class
