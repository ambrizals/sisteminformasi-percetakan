<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbsenTambahcuti
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
        Me.dt_mulai = New System.Windows.Forms.DateTimePicker()
        Me.dt_akhir = New System.Windows.Forms.DateTimePicker()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_alasancuti = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mulai Tanggal :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sampai Tanggal :"
        '
        'dt_mulai
        '
        Me.dt_mulai.Location = New System.Drawing.Point(131, 60)
        Me.dt_mulai.Name = "dt_mulai"
        Me.dt_mulai.Size = New System.Drawing.Size(200, 20)
        Me.dt_mulai.TabIndex = 2
        Me.dt_mulai.Value = New Date(2017, 6, 10, 0, 0, 0, 0)
        '
        'dt_akhir
        '
        Me.dt_akhir.Location = New System.Drawing.Point(131, 97)
        Me.dt_akhir.Name = "dt_akhir"
        Me.dt_akhir.Size = New System.Drawing.Size(200, 20)
        Me.dt_akhir.TabIndex = 3
        Me.dt_akhir.Value = New Date(2017, 6, 10, 0, 0, 0, 0)
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(26, 137)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(143, 23)
        Me.BtnSimpan.TabIndex = 4
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(175, 137)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(156, 23)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Batal"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Alasan Cuti :"
        '
        'txt_alasancuti
        '
        Me.txt_alasancuti.Location = New System.Drawing.Point(131, 24)
        Me.txt_alasancuti.Name = "txt_alasancuti"
        Me.txt_alasancuti.Size = New System.Drawing.Size(200, 20)
        Me.txt_alasancuti.TabIndex = 7
        '
        'FormAbsenTambahcuti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 174)
        Me.Controls.Add(Me.txt_alasancuti)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.dt_akhir)
        Me.Controls.Add(Me.dt_mulai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormAbsenTambahcuti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buat Rencana Cuti"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_mulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_akhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_alasancuti As System.Windows.Forms.TextBox
End Class
