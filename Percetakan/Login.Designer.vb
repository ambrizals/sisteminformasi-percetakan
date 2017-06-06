<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.cb_saveuser = New System.Windows.Forms.CheckBox()
        Me.cb_saveuserpass = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_constatus = New System.Windows.Forms.Label()
        Me.BtnConfig = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(88, 100)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(180, 20)
        Me.txtusername.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(88, 124)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(180, 20)
        Me.txtpassword.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.SystemColors.Menu
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLogin.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnLogin.Location = New System.Drawing.Point(12, 194)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(256, 60)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnReset.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnReset.Location = New System.Drawing.Point(12, 260)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(123, 40)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reconnect"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCancel.Location = New System.Drawing.Point(236, 12)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(39, 23)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "X"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'cb_saveuser
        '
        Me.cb_saveuser.AutoSize = True
        Me.cb_saveuser.Location = New System.Drawing.Point(12, 150)
        Me.cb_saveuser.Name = "cb_saveuser"
        Me.cb_saveuser.Size = New System.Drawing.Size(112, 17)
        Me.cb_saveuser.TabIndex = 7
        Me.cb_saveuser.Text = "Simpan Username"
        Me.cb_saveuser.UseVisualStyleBackColor = True
        '
        'cb_saveuserpass
        '
        Me.cb_saveuserpass.AutoSize = True
        Me.cb_saveuserpass.Enabled = False
        Me.cb_saveuserpass.Location = New System.Drawing.Point(12, 171)
        Me.cb_saveuserpass.Name = "cb_saveuserpass"
        Me.cb_saveuserpass.Size = New System.Drawing.Size(110, 17)
        Me.cb_saveuserpass.TabIndex = 8
        Me.cb_saveuserpass.Text = "Simpan Password"
        Me.cb_saveuserpass.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Status Koneksi :"
        '
        'lbl_constatus
        '
        Me.lbl_constatus.AutoSize = True
        Me.lbl_constatus.ForeColor = System.Drawing.Color.Red
        Me.lbl_constatus.Location = New System.Drawing.Point(101, 18)
        Me.lbl_constatus.Name = "lbl_constatus"
        Me.lbl_constatus.Size = New System.Drawing.Size(25, 13)
        Me.lbl_constatus.TabIndex = 10
        Me.lbl_constatus.Text = "Null"
        '
        'BtnConfig
        '
        Me.BtnConfig.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnConfig.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnConfig.Location = New System.Drawing.Point(141, 260)
        Me.BtnConfig.Name = "BtnConfig"
        Me.BtnConfig.Size = New System.Drawing.Size(127, 40)
        Me.BtnConfig.TabIndex = 11
        Me.BtnConfig.Text = "Config"
        Me.BtnConfig.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_constatus)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Location = New System.Drawing.Point(0, 313)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(293, 49)
        Me.Panel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(88, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 40)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "LOGIN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(289, 360)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnConfig)
        Me.Controls.Add(Me.cb_saveuserpass)
        Me.Controls.Add(Me.cb_saveuser)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents cb_saveuser As System.Windows.Forms.CheckBox
    Friend WithEvents cb_saveuserpass As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_constatus As System.Windows.Forms.Label
    Friend WithEvents BtnConfig As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
