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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.nm_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Bahan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Bahan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stock Bahan :"
        '
        'txt_kodebahan
        '
        Me.txt_kodebahan.Location = New System.Drawing.Point(96, 72)
        Me.txt_kodebahan.Name = "txt_kodebahan"
        Me.txt_kodebahan.ReadOnly = True
        Me.txt_kodebahan.Size = New System.Drawing.Size(225, 20)
        Me.txt_kodebahan.TabIndex = 0
        '
        'txt_namabahan
        '
        Me.txt_namabahan.Location = New System.Drawing.Point(96, 106)
        Me.txt_namabahan.Name = "txt_namabahan"
        Me.txt_namabahan.Size = New System.Drawing.Size(225, 20)
        Me.txt_namabahan.TabIndex = 1
        '
        'nm_stock
        '
        Me.nm_stock.Location = New System.Drawing.Point(96, 142)
        Me.nm_stock.Name = "nm_stock"
        Me.nm_stock.Size = New System.Drawing.Size(225, 20)
        Me.nm_stock.TabIndex = 2
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 222)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(303, 28)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnSimpan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSimpan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSimpan.Location = New System.Drawing.Point(3, 3)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(95, 22)
        Me.BtnSimpan.TabIndex = 5
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnReset.Location = New System.Drawing.Point(104, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(95, 22)
        Me.BtnReset.TabIndex = 6
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnBatal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBatal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBatal.Location = New System.Drawing.Point(205, 3)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(95, 22)
        Me.BtnBatal.TabIndex = 7
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(96, 177)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(225, 20)
        Me.txt_harga.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Harga Bahan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(252, 35)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "INPUT BAHAN BARU"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(324, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "X"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormAddGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(341, 279)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_harga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.nm_stock)
        Me.Controls.Add(Me.txt_namabahan)
        Me.Controls.Add(Me.txt_kodebahan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents txt_harga As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
