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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(92, 13)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(180, 20)
        Me.txtusername.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(92, 37)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(180, 20)
        Me.txtpassword.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(16, 107)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(256, 23)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(16, 137)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(81, 23)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reconnect"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(103, 137)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 23)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'cb_saveuser
        '
        Me.cb_saveuser.AutoSize = True
        Me.cb_saveuser.Location = New System.Drawing.Point(16, 63)
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
        Me.cb_saveuserpass.Location = New System.Drawing.Point(16, 84)
        Me.cb_saveuserpass.Name = "cb_saveuserpass"
        Me.cb_saveuserpass.Size = New System.Drawing.Size(110, 17)
        Me.cb_saveuserpass.TabIndex = 8
        Me.cb_saveuserpass.Text = "Simpan Password"
        Me.cb_saveuserpass.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Status Koneksi :"
        '
        'lbl_constatus
        '
        Me.lbl_constatus.AutoSize = True
        Me.lbl_constatus.ForeColor = System.Drawing.Color.Red
        Me.lbl_constatus.Location = New System.Drawing.Point(100, 173)
        Me.lbl_constatus.Name = "lbl_constatus"
        Me.lbl_constatus.Size = New System.Drawing.Size(25, 13)
        Me.lbl_constatus.TabIndex = 10
        Me.lbl_constatus.Text = "Null"
        '
        'BtnConfig
        '
        Me.BtnConfig.Location = New System.Drawing.Point(189, 136)
        Me.BtnConfig.Name = "BtnConfig"
        Me.BtnConfig.Size = New System.Drawing.Size(83, 23)
        Me.BtnConfig.TabIndex = 11
        Me.BtnConfig.Text = "Config"
        Me.BtnConfig.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 202)
        Me.Controls.Add(Me.BtnConfig)
        Me.Controls.Add(Me.lbl_constatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_saveuserpass)
        Me.Controls.Add(Me.cb_saveuser)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
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

End Class
