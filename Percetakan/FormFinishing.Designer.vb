<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFinishing
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.DG_Daftar = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DG_Daftar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btncari)
        Me.Panel1.Controls.Add(Me.txtcari)
        Me.Panel1.Controls.Add(Me.label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 91)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(602, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "X"
        '
        'btncari
        '
        Me.btncari.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncari.Location = New System.Drawing.Point(473, 57)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(142, 23)
        Me.btncari.TabIndex = 2
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = False
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(12, 60)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(455, 20)
        Me.txtcari.TabIndex = 1
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label.Location = New System.Drawing.Point(251, 9)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(142, 33)
        Me.label.TabIndex = 0
        Me.label.Text = "Finishing"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btntambah)
        Me.Panel2.Controls.Add(Me.btnkembali)
        Me.Panel2.Controls.Add(Me.btnrefresh)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 290)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 100)
        Me.Panel2.TabIndex = 1
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btntambah.Location = New System.Drawing.Point(105, 65)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(116, 23)
        Me.btntambah.TabIndex = 2
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnkembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnkembali.Location = New System.Drawing.Point(417, 65)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(116, 23)
        Me.btnkembali.TabIndex = 1
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrefresh.Location = New System.Drawing.Point(266, 65)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(116, 23)
        Me.btnrefresh.TabIndex = 0
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'DG_Daftar
        '
        Me.DG_Daftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Daftar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Daftar.Location = New System.Drawing.Point(0, 91)
        Me.DG_Daftar.Name = "DG_Daftar"
        Me.DG_Daftar.Size = New System.Drawing.Size(626, 199)
        Me.DG_Daftar.TabIndex = 2
        '
        'FormFinishing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 390)
        Me.Controls.Add(Me.DG_Daftar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormFinishing"
        Me.Text = "FormFinishing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DG_Daftar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DG_Daftar As System.Windows.Forms.DataGridView
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
