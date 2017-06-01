<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditKaryawan
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cb_validdata = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rtf_deskripsi = New System.Windows.Forms.RichTextBox()
        Me.cb_jabatan = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_telepon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rtf_alamat = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_passwordkaryawan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_userkaryawan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_namakaryawan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_idkaryawan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cb_validdata)
        Me.GroupBox4.Location = New System.Drawing.Point(374, 185)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(298, 138)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kualifikasi"
        '
        'cb_validdata
        '
        Me.cb_validdata.AutoSize = True
        Me.cb_validdata.Location = New System.Drawing.Point(15, 24)
        Me.cb_validdata.Name = "cb_validdata"
        Me.cb_validdata.Size = New System.Drawing.Size(172, 17)
        Me.cb_validdata.TabIndex = 0
        Me.cb_validdata.Text = "Data yang diberikan telah valid"
        Me.cb_validdata.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtf_deskripsi)
        Me.GroupBox3.Controls.Add(Me.cb_jabatan)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(374, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 167)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "User Privilage"
        '
        'rtf_deskripsi
        '
        Me.rtf_deskripsi.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rtf_deskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtf_deskripsi.Location = New System.Drawing.Point(15, 61)
        Me.rtf_deskripsi.Name = "rtf_deskripsi"
        Me.rtf_deskripsi.ReadOnly = True
        Me.rtf_deskripsi.Size = New System.Drawing.Size(270, 88)
        Me.rtf_deskripsi.TabIndex = 35
        Me.rtf_deskripsi.Text = ""
        '
        'cb_jabatan
        '
        Me.cb_jabatan.FormattingEnabled = True
        Me.cb_jabatan.Items.AddRange(New Object() {"Admin", "Operator", "Kasir"})
        Me.cb_jabatan.Location = New System.Drawing.Point(116, 25)
        Me.cb_jabatan.Name = "cb_jabatan"
        Me.cb_jabatan.Size = New System.Drawing.Size(169, 21)
        Me.cb_jabatan.TabIndex = 34
        Me.cb_jabatan.Text = "Pilih Jabatan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Jabatan Karyawan :"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(522, 329)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(150, 23)
        Me.BtnReset.TabIndex = 33
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_telepon)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.rtf_alamat)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 167)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Biodata"
        '
        'txt_telepon
        '
        Me.txt_telepon.Location = New System.Drawing.Point(116, 129)
        Me.txt_telepon.Name = "txt_telepon"
        Me.txt_telepon.Size = New System.Drawing.Size(216, 20)
        Me.txt_telepon.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Telp Karyawan :"
        '
        'rtf_alamat
        '
        Me.rtf_alamat.Location = New System.Drawing.Point(116, 25)
        Me.rtf_alamat.Name = "rtf_alamat"
        Me.rtf_alamat.Size = New System.Drawing.Size(216, 88)
        Me.rtf_alamat.TabIndex = 1
        Me.rtf_alamat.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Alamat Karyawan :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_passwordkaryawan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_userkaryawan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_namakaryawan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_idkaryawan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 167)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Info"
        '
        'txt_passwordkaryawan
        '
        Me.txt_passwordkaryawan.Location = New System.Drawing.Point(120, 129)
        Me.txt_passwordkaryawan.Name = "txt_passwordkaryawan"
        Me.txt_passwordkaryawan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_passwordkaryawan.Size = New System.Drawing.Size(212, 20)
        Me.txt_passwordkaryawan.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Pass Karyawan :"
        '
        'txt_userkaryawan
        '
        Me.txt_userkaryawan.Location = New System.Drawing.Point(120, 93)
        Me.txt_userkaryawan.Name = "txt_userkaryawan"
        Me.txt_userkaryawan.Size = New System.Drawing.Size(212, 20)
        Me.txt_userkaryawan.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "User Karyawan :"
        '
        'txt_namakaryawan
        '
        Me.txt_namakaryawan.Location = New System.Drawing.Point(120, 57)
        Me.txt_namakaryawan.Name = "txt_namakaryawan"
        Me.txt_namakaryawan.Size = New System.Drawing.Size(212, 20)
        Me.txt_namakaryawan.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nama Karyawan :"
        '
        'txt_idkaryawan
        '
        Me.txt_idkaryawan.Location = New System.Drawing.Point(120, 21)
        Me.txt_idkaryawan.Name = "txt_idkaryawan"
        Me.txt_idkaryawan.ReadOnly = True
        Me.txt_idkaryawan.Size = New System.Drawing.Size(212, 20)
        Me.txt_idkaryawan.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ID Karyawan :"
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(374, 329)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(141, 23)
        Me.BtnSave.TabIndex = 36
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'FormEditKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 361)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karyawan"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_validdata As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rtf_deskripsi As System.Windows.Forms.RichTextBox
    Friend WithEvents cb_jabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_telepon As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rtf_alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_passwordkaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_userkaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_namakaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_idkaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
