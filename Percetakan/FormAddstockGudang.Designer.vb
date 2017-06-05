<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddstockGudang
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
        Me.nm_stock = New System.Windows.Forms.NumericUpDown()
        Me.txt_namabahan = New System.Windows.Forms.TextBox()
        Me.txt_kodebahan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_stoksekarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_unit1 = New System.Windows.Forms.Label()
        Me.lbl_unit2 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        CType(Me.nm_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nm_stock
        '
        Me.nm_stock.Location = New System.Drawing.Point(108, 115)
        Me.nm_stock.Name = "nm_stock"
        Me.nm_stock.Size = New System.Drawing.Size(125, 20)
        Me.nm_stock.TabIndex = 13
        '
        'txt_namabahan
        '
        Me.txt_namabahan.Location = New System.Drawing.Point(108, 46)
        Me.txt_namabahan.Name = "txt_namabahan"
        Me.txt_namabahan.ReadOnly = True
        Me.txt_namabahan.Size = New System.Drawing.Size(207, 20)
        Me.txt_namabahan.TabIndex = 12
        '
        'txt_kodebahan
        '
        Me.txt_kodebahan.Location = New System.Drawing.Point(108, 12)
        Me.txt_kodebahan.Name = "txt_kodebahan"
        Me.txt_kodebahan.ReadOnly = True
        Me.txt_kodebahan.Size = New System.Drawing.Size(207, 20)
        Me.txt_kodebahan.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tambahan Stok :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama Bahan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Kode Bahan :"
        '
        'txt_stoksekarang
        '
        Me.txt_stoksekarang.Location = New System.Drawing.Point(108, 79)
        Me.txt_stoksekarang.Name = "txt_stoksekarang"
        Me.txt_stoksekarang.ReadOnly = True
        Me.txt_stoksekarang.Size = New System.Drawing.Size(125, 20)
        Me.txt_stoksekarang.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Stok Sekarang :"
        '
        'lbl_unit1
        '
        Me.lbl_unit1.AutoSize = True
        Me.lbl_unit1.Location = New System.Drawing.Point(240, 83)
        Me.lbl_unit1.Name = "lbl_unit1"
        Me.lbl_unit1.Size = New System.Drawing.Size(55, 13)
        Me.lbl_unit1.TabIndex = 16
        Me.lbl_unit1.Text = "/ Null Unit"
        '
        'lbl_unit2
        '
        Me.lbl_unit2.AutoSize = True
        Me.lbl_unit2.Location = New System.Drawing.Point(241, 119)
        Me.lbl_unit2.Name = "lbl_unit2"
        Me.lbl_unit2.Size = New System.Drawing.Size(55, 13)
        Me.lbl_unit2.TabIndex = 17
        Me.lbl_unit2.Text = "/ Null Unit"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(12, 148)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(142, 23)
        Me.BtnTambah.TabIndex = 18
        Me.BtnTambah.Text = "Tambah Stock"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(173, 148)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(142, 23)
        Me.BtnCancel.TabIndex = 19
        Me.BtnCancel.Text = "Kembali"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormAddstockGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(323, 183)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.lbl_unit2)
        Me.Controls.Add(Me.lbl_unit1)
        Me.Controls.Add(Me.txt_stoksekarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nm_stock)
        Me.Controls.Add(Me.txt_namabahan)
        Me.Controls.Add(Me.txt_kodebahan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAddstockGudang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Stock"
        CType(Me.nm_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nm_stock As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_namabahan As System.Windows.Forms.TextBox
    Friend WithEvents txt_kodebahan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_stoksekarang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_unit1 As System.Windows.Forms.Label
    Friend WithEvents lbl_unit2 As System.Windows.Forms.Label
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
