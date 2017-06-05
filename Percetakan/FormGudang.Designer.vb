<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGudang
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGudang))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.txt_namabahan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_condition = New System.Windows.Forms.ComboBox()
        Me.DG_Bahan = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_bahancount = New System.Windows.Forms.Label()
        Me.cms_dgbahan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TambahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DG_Bahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.cms_dgbahan.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.36893!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.63107!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCari, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_namabahan, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cb_condition, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 62)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(722, 29)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'BtnCari
        '
        Me.BtnCari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCari.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCari.Location = New System.Drawing.Point(566, 3)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(153, 23)
        Me.BtnCari.TabIndex = 4
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = False
        '
        'txt_namabahan
        '
        Me.txt_namabahan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_namabahan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_namabahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_namabahan.Location = New System.Drawing.Point(120, 3)
        Me.txt_namabahan.Name = "txt_namabahan"
        Me.txt_namabahan.Size = New System.Drawing.Size(275, 26)
        Me.txt_namabahan.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari Bahan :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cb_condition
        '
        Me.cb_condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cb_condition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_condition.FormattingEnabled = True
        Me.cb_condition.Items.AddRange(New Object() {"Tersedia", "Tidak Tersedia"})
        Me.cb_condition.Location = New System.Drawing.Point(401, 3)
        Me.cb_condition.Name = "cb_condition"
        Me.cb_condition.Size = New System.Drawing.Size(159, 26)
        Me.cb_condition.TabIndex = 3
        Me.cb_condition.Text = "<Pilih Ketersediaan>"
        '
        'DG_Bahan
        '
        Me.DG_Bahan.AllowUserToAddRows = False
        Me.DG_Bahan.AllowUserToDeleteRows = False
        Me.DG_Bahan.AllowUserToResizeColumns = False
        Me.DG_Bahan.AllowUserToResizeRows = False
        Me.DG_Bahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Bahan.Location = New System.Drawing.Point(0, 97)
        Me.DG_Bahan.MultiSelect = False
        Me.DG_Bahan.Name = "DG_Bahan"
        Me.DG_Bahan.ReadOnly = True
        Me.DG_Bahan.RowHeadersVisible = False
        Me.DG_Bahan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Bahan.Size = New System.Drawing.Size(722, 400)
        Me.DG_Bahan.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnRefresh, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnTambah, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_bahancount, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 500)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(722, 40)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRefresh.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRefresh.Location = New System.Drawing.Point(571, 8)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(8)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(143, 24)
        Me.BtnRefresh.TabIndex = 4
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnTambah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTambah.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnTambah.Location = New System.Drawing.Point(382, 8)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(8)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(173, 24)
        Me.BtnTambah.TabIndex = 3
        Me.BtnTambah.Text = "Tambah Bahan"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jumlah Bahan :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_bahancount
        '
        Me.lbl_bahancount.AutoSize = True
        Me.lbl_bahancount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_bahancount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_bahancount.Location = New System.Drawing.Point(190, 0)
        Me.lbl_bahancount.Name = "lbl_bahancount"
        Me.lbl_bahancount.Size = New System.Drawing.Size(181, 40)
        Me.lbl_bahancount.TabIndex = 1
        Me.lbl_bahancount.Text = "Null Count"
        Me.lbl_bahancount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cms_dgbahan
        '
        Me.cms_dgbahan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahToolStripMenuItem, Me.UbahToolStripMenuItem})
        Me.cms_dgbahan.Name = "ContextMenuStrip1"
        Me.cms_dgbahan.Size = New System.Drawing.Size(151, 48)
        '
        'TambahToolStripMenuItem
        '
        Me.TambahToolStripMenuItem.Name = "TambahToolStripMenuItem"
        Me.TambahToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TambahToolStripMenuItem.Text = "Tambah Stock"
        '
        'UbahToolStripMenuItem
        '
        Me.UbahToolStripMenuItem.Name = "UbahToolStripMenuItem"
        Me.UbahToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UbahToolStripMenuItem.Text = "Ubah Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(68, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "GUDANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(700, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "X"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 47)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FormGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(722, 540)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DG_Bahan)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGudang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gudang"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DG_Bahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.cms_dgbahan.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_namabahan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_Bahan As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_bahancount As System.Windows.Forms.Label
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents cb_condition As System.Windows.Forms.ComboBox
    Friend WithEvents cms_dgbahan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TambahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UbahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
