<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBayarPesanan
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
        Me.txt_totalpesanan = New System.Windows.Forms.TextBox()
        Me.cb_metode = New System.Windows.Forms.ComboBox()
        Me.txt_jumlahbayar = New System.Windows.Forms.TextBox()
        Me.BtnBayar = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.txt_sisabayar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Pesanan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Metode Bayar :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Bayar :"
        '
        'txt_totalpesanan
        '
        Me.txt_totalpesanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalpesanan.Location = New System.Drawing.Point(147, 13)
        Me.txt_totalpesanan.Name = "txt_totalpesanan"
        Me.txt_totalpesanan.ReadOnly = True
        Me.txt_totalpesanan.Size = New System.Drawing.Size(233, 26)
        Me.txt_totalpesanan.TabIndex = 3
        '
        'cb_metode
        '
        Me.cb_metode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_metode.FormattingEnabled = True
        Me.cb_metode.Items.AddRange(New Object() {"Cash", "Down Payment"})
        Me.cb_metode.Location = New System.Drawing.Point(147, 51)
        Me.cb_metode.Name = "cb_metode"
        Me.cb_metode.Size = New System.Drawing.Size(233, 28)
        Me.cb_metode.TabIndex = 4
        Me.cb_metode.Text = "<Pilih Metode Bayar>"
        '
        'txt_jumlahbayar
        '
        Me.txt_jumlahbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jumlahbayar.Location = New System.Drawing.Point(147, 90)
        Me.txt_jumlahbayar.Name = "txt_jumlahbayar"
        Me.txt_jumlahbayar.Size = New System.Drawing.Size(233, 26)
        Me.txt_jumlahbayar.TabIndex = 5
        '
        'BtnBayar
        '
        Me.BtnBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBayar.Location = New System.Drawing.Point(16, 175)
        Me.BtnBayar.Name = "BtnBayar"
        Me.BtnBayar.Size = New System.Drawing.Size(180, 43)
        Me.BtnBayar.TabIndex = 6
        Me.BtnBayar.Text = "Bayar"
        Me.BtnBayar.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.Location = New System.Drawing.Point(202, 175)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(178, 43)
        Me.BtnKembali.TabIndex = 7
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'txt_sisabayar
        '
        Me.txt_sisabayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sisabayar.Location = New System.Drawing.Point(147, 130)
        Me.txt_sisabayar.Name = "txt_sisabayar"
        Me.txt_sisabayar.ReadOnly = True
        Me.txt_sisabayar.Size = New System.Drawing.Size(233, 26)
        Me.txt_sisabayar.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sisa Bayar :"
        '
        'FormBayarPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 244)
        Me.Controls.Add(Me.txt_sisabayar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnBayar)
        Me.Controls.Add(Me.txt_jumlahbayar)
        Me.Controls.Add(Me.cb_metode)
        Me.Controls.Add(Me.txt_totalpesanan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormBayarPesanan"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bayar Pesanan :"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_totalpesanan As System.Windows.Forms.TextBox
    Friend WithEvents cb_metode As System.Windows.Forms.ComboBox
    Friend WithEvents txt_jumlahbayar As System.Windows.Forms.TextBox
    Friend WithEvents BtnBayar As System.Windows.Forms.Button
    Friend WithEvents BtnKembali As System.Windows.Forms.Button
    Friend WithEvents txt_sisabayar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
