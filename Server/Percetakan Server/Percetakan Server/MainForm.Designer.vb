<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BtnConfig = New System.Windows.Forms.Button()
        Me.BtnInstallDB1 = New System.Windows.Forms.Button()
        Me.BtnInstallDB2 = New System.Windows.Forms.Button()
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.BtnRestore = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.list_status = New System.Windows.Forms.ListBox()
        Me.btn_checkkoneksi = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.browse_backup = New System.Windows.Forms.OpenFileDialog()
        Me.save_backup = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnConfig
        '
        Me.BtnConfig.BackColor = System.Drawing.SystemColors.Window
        Me.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConfig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfig.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnConfig.Location = New System.Drawing.Point(330, 57)
        Me.BtnConfig.Name = "BtnConfig"
        Me.BtnConfig.Size = New System.Drawing.Size(184, 51)
        Me.BtnConfig.TabIndex = 0
        Me.BtnConfig.Text = "Pengaturan Server"
        Me.BtnConfig.UseVisualStyleBackColor = False
        '
        'BtnInstallDB1
        '
        Me.BtnInstallDB1.BackColor = System.Drawing.SystemColors.Window
        Me.BtnInstallDB1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInstallDB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInstallDB1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnInstallDB1.Location = New System.Drawing.Point(330, 114)
        Me.BtnInstallDB1.Name = "BtnInstallDB1"
        Me.BtnInstallDB1.Size = New System.Drawing.Size(184, 51)
        Me.BtnInstallDB1.TabIndex = 1
        Me.BtnInstallDB1.Text = "Pasang Database Default"
        Me.BtnInstallDB1.UseVisualStyleBackColor = False
        '
        'BtnInstallDB2
        '
        Me.BtnInstallDB2.BackColor = System.Drawing.SystemColors.Window
        Me.BtnInstallDB2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInstallDB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInstallDB2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnInstallDB2.Location = New System.Drawing.Point(330, 171)
        Me.BtnInstallDB2.Name = "BtnInstallDB2"
        Me.BtnInstallDB2.Size = New System.Drawing.Size(184, 51)
        Me.BtnInstallDB2.TabIndex = 2
        Me.BtnInstallDB2.Text = "Pasang Database Default + Contoh Data"
        Me.BtnInstallDB2.UseVisualStyleBackColor = False
        '
        'BtnBackup
        '
        Me.BtnBackup.BackColor = System.Drawing.SystemColors.Window
        Me.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackup.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnBackup.Location = New System.Drawing.Point(330, 228)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Size = New System.Drawing.Size(184, 51)
        Me.BtnBackup.TabIndex = 3
        Me.BtnBackup.Text = "Backup Database"
        Me.BtnBackup.UseVisualStyleBackColor = False
        '
        'BtnRestore
        '
        Me.BtnRestore.BackColor = System.Drawing.SystemColors.Window
        Me.BtnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestore.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnRestore.Location = New System.Drawing.Point(330, 285)
        Me.BtnRestore.Name = "BtnRestore"
        Me.BtnRestore.Size = New System.Drawing.Size(184, 51)
        Me.BtnRestore.TabIndex = 4
        Me.BtnRestore.Text = "Restore Database"
        Me.BtnRestore.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.list_status)
        Me.GroupBox1.Controls.Add(Me.btn_checkkoneksi)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 360)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status Server :"
        '
        'list_status
        '
        Me.list_status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_status.FormattingEnabled = True
        Me.list_status.Location = New System.Drawing.Point(3, 39)
        Me.list_status.Name = "list_status"
        Me.list_status.Size = New System.Drawing.Size(306, 318)
        Me.list_status.TabIndex = 6
        '
        'btn_checkkoneksi
        '
        Me.btn_checkkoneksi.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_checkkoneksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_checkkoneksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_checkkoneksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkkoneksi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_checkkoneksi.Location = New System.Drawing.Point(3, 16)
        Me.btn_checkkoneksi.Name = "btn_checkkoneksi"
        Me.btn_checkkoneksi.Size = New System.Drawing.Size(306, 23)
        Me.btn_checkkoneksi.TabIndex = 7
        Me.btn_checkkoneksi.Text = "Check Koneksi"
        Me.btn_checkkoneksi.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 72)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Default User :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password : admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username : Administrator"
        '
        'browse_backup
        '
        Me.browse_backup.FileName = "backup.sql"
        '
        'save_backup
        '
        Me.save_backup.Filter = "SQL File (*.sql)|*.sql|All files (*.*)|*.*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(500, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(69, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(273, 33)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Server Percetakan"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(15, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 46)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(526, 422)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnRestore)
        Me.Controls.Add(Me.BtnBackup)
        Me.Controls.Add(Me.BtnInstallDB2)
        Me.Controls.Add(Me.BtnInstallDB1)
        Me.Controls.Add(Me.BtnConfig)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Server Percetakan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnConfig As System.Windows.Forms.Button
    Friend WithEvents BtnInstallDB1 As System.Windows.Forms.Button
    Friend WithEvents BtnInstallDB2 As System.Windows.Forms.Button
    Friend WithEvents BtnBackup As System.Windows.Forms.Button
    Friend WithEvents BtnRestore As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents list_status As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_checkkoneksi As System.Windows.Forms.Button
    Friend WithEvents browse_backup As System.Windows.Forms.OpenFileDialog
    Friend WithEvents save_backup As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
