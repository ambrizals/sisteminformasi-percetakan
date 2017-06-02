<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditbahanGudang
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.cb_unit = New System.Windows.Forms.ComboBox()
        Me.nm_stock = New System.Windows.Forms.NumericUpDown()
        Me.txt_namabahan = New System.Windows.Forms.TextBox()
        Me.txt_kodebahan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nm_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtnBatal, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSimpan, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 118)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(303, 28)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'BtnBatal
        '
        Me.BtnBatal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBatal.Location = New System.Drawing.Point(154, 3)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(146, 22)
        Me.BtnBatal.TabIndex = 3
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSimpan.Location = New System.Drawing.Point(3, 3)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(145, 22)
        Me.BtnSimpan.TabIndex = 0
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'cb_unit
        '
        Me.cb_unit.FormattingEnabled = True
        Me.cb_unit.Items.AddRange(New Object() {"Meter", "Unit"})
        Me.cb_unit.Location = New System.Drawing.Point(210, 81)
        Me.cb_unit.Name = "cb_unit"
        Me.cb_unit.Size = New System.Drawing.Size(107, 21)
        Me.cb_unit.TabIndex = 15
        Me.cb_unit.Text = "Pilih Satuan"
        '
        'nm_stock
        '
        Me.nm_stock.Location = New System.Drawing.Point(92, 82)
        Me.nm_stock.Name = "nm_stock"
        Me.nm_stock.ReadOnly = True
        Me.nm_stock.Size = New System.Drawing.Size(112, 20)
        Me.nm_stock.TabIndex = 14
        '
        'txt_namabahan
        '
        Me.txt_namabahan.Location = New System.Drawing.Point(92, 46)
        Me.txt_namabahan.Name = "txt_namabahan"
        Me.txt_namabahan.Size = New System.Drawing.Size(225, 20)
        Me.txt_namabahan.TabIndex = 13
        '
        'txt_kodebahan
        '
        Me.txt_kodebahan.Location = New System.Drawing.Point(92, 12)
        Me.txt_kodebahan.Name = "txt_kodebahan"
        Me.txt_kodebahan.ReadOnly = True
        Me.txt_kodebahan.Size = New System.Drawing.Size(225, 20)
        Me.txt_kodebahan.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Stock Bahan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nama Bahan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kode Bahan :"
        '
        'FormEditbahanGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 154)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.cb_unit)
        Me.Controls.Add(Me.nm_stock)
        Me.Controls.Add(Me.txt_namabahan)
        Me.Controls.Add(Me.txt_kodebahan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditbahanGudang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubah Data Bahan :"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nm_stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents cb_unit As System.Windows.Forms.ComboBox
    Friend WithEvents nm_stock As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_namabahan As System.Windows.Forms.TextBox
    Friend WithEvents txt_kodebahan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
