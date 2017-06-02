<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddGudang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_kodebahan = New System.Windows.Forms.TextBox()
        Me.txt_namabahan = New System.Windows.Forms.TextBox()
        Me.nm_stock = New System.Windows.Forms.NumericUpDown()
        Me.cb_unit = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        CType(Me.nm_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Bahan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Bahan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stock Bahan :"
        '
        'txt_kodebahan
        '
        Me.txt_kodebahan.Location = New System.Drawing.Point(96, 12)
        Me.txt_kodebahan.Name = "txt_kodebahan"
        Me.txt_kodebahan.ReadOnly = True
        Me.txt_kodebahan.Size = New System.Drawing.Size(225, 20)
        Me.txt_kodebahan.TabIndex = 4
        '
        'txt_namabahan
        '
        Me.txt_namabahan.Location = New System.Drawing.Point(96, 46)
        Me.txt_namabahan.Name = "txt_namabahan"
        Me.txt_namabahan.Size = New System.Drawing.Size(225, 20)
        Me.txt_namabahan.TabIndex = 5
        '
        'nm_stock
        '
        Me.nm_stock.Location = New System.Drawing.Point(96, 82)
        Me.nm_stock.Name = "nm_stock"
        Me.nm_stock.Size = New System.Drawing.Size(112, 20)
        Me.nm_stock.TabIndex = 6
        '
        'cb_unit
        '
        Me.cb_unit.FormattingEnabled = True
        Me.cb_unit.Items.AddRange(New Object() {"Meter", "Unit"})
        Me.cb_unit.Location = New System.Drawing.Point(214, 81)
        Me.cb_unit.Name = "cb_unit"
        Me.cb_unit.Size = New System.Drawing.Size(107, 21)
        Me.cb_unit.TabIndex = 7
        Me.cb_unit.Text = "Pilih Satuan"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSimpan, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnReset, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnBatal, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 118)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(303, 28)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSimpan.Location = New System.Drawing.Point(3, 3)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(95, 22)
        Me.BtnSimpan.TabIndex = 0
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReset.Location = New System.Drawing.Point(104, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(95, 22)
        Me.BtnReset.TabIndex = 1
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBatal.Location = New System.Drawing.Point(205, 3)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(95, 22)
        Me.BtnBatal.TabIndex = 2
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'FormAddGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 176)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cb_unit)
        Me.Controls.Add(Me.nm_stock)
        Me.Controls.Add(Me.txt_namabahan)
        Me.Controls.Add(Me.txt_kodebahan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormAddGudang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Bahan"
        CType(Me.nm_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_kodebahan As System.Windows.Forms.TextBox
    Friend WithEvents txt_namabahan As System.Windows.Forms.TextBox
    Friend WithEvents nm_stock As System.Windows.Forms.NumericUpDown
    Friend WithEvents cb_unit As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
End Class
