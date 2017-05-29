<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.BtnKaryawan = New System.Windows.Forms.Button()
        Me.BtnJoblist = New System.Windows.Forms.Button()
        Me.BtnGudang = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnLaporan = New System.Windows.Forms.Button()
        Me.BtnPesanan = New System.Windows.Forms.Button()
        Me.lbl_constatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_reconnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_datetime = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnKaryawan
        '
        Me.BtnKaryawan.AutoSize = True
        Me.BtnKaryawan.Location = New System.Drawing.Point(12, 12)
        Me.BtnKaryawan.Name = "BtnKaryawan"
        Me.BtnKaryawan.Size = New System.Drawing.Size(150, 97)
        Me.BtnKaryawan.TabIndex = 0
        Me.BtnKaryawan.Text = "Karyawan"
        Me.BtnKaryawan.UseVisualStyleBackColor = True
        '
        'BtnJoblist
        '
        Me.BtnJoblist.AutoSize = True
        Me.BtnJoblist.Location = New System.Drawing.Point(179, 12)
        Me.BtnJoblist.Name = "BtnJoblist"
        Me.BtnJoblist.Size = New System.Drawing.Size(150, 97)
        Me.BtnJoblist.TabIndex = 1
        Me.BtnJoblist.Text = "Job List"
        Me.BtnJoblist.UseVisualStyleBackColor = True
        '
        'BtnGudang
        '
        Me.BtnGudang.AutoSize = True
        Me.BtnGudang.Location = New System.Drawing.Point(347, 12)
        Me.BtnGudang.Name = "BtnGudang"
        Me.BtnGudang.Size = New System.Drawing.Size(150, 97)
        Me.BtnGudang.TabIndex = 2
        Me.BtnGudang.Text = "Gudang"
        Me.BtnGudang.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.AutoSize = True
        Me.BtnLogout.Location = New System.Drawing.Point(348, 119)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(150, 97)
        Me.BtnLogout.TabIndex = 5
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnLaporan
        '
        Me.BtnLaporan.AutoSize = True
        Me.BtnLaporan.Location = New System.Drawing.Point(180, 119)
        Me.BtnLaporan.Name = "BtnLaporan"
        Me.BtnLaporan.Size = New System.Drawing.Size(150, 97)
        Me.BtnLaporan.TabIndex = 4
        Me.BtnLaporan.Text = "Laporan"
        Me.BtnLaporan.UseVisualStyleBackColor = True
        '
        'BtnPesanan
        '
        Me.BtnPesanan.AutoSize = True
        Me.BtnPesanan.Location = New System.Drawing.Point(13, 119)
        Me.BtnPesanan.Name = "BtnPesanan"
        Me.BtnPesanan.Size = New System.Drawing.Size(150, 97)
        Me.BtnPesanan.TabIndex = 3
        Me.BtnPesanan.Text = "Pesanan"
        Me.BtnPesanan.UseVisualStyleBackColor = True
        '
        'lbl_constatus
        '
        Me.lbl_constatus.AutoSize = True
        Me.lbl_constatus.ForeColor = System.Drawing.Color.Red
        Me.lbl_constatus.Location = New System.Drawing.Point(93, 236)
        Me.lbl_constatus.Name = "lbl_constatus"
        Me.lbl_constatus.Size = New System.Drawing.Size(25, 13)
        Me.lbl_constatus.TabIndex = 12
        Me.lbl_constatus.Text = "Null"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Status Koneksi :"
        '
        'btn_reconnect
        '
        Me.btn_reconnect.Location = New System.Drawing.Point(393, 231)
        Me.btn_reconnect.Name = "btn_reconnect"
        Me.btn_reconnect.Size = New System.Drawing.Size(104, 23)
        Me.btn_reconnect.TabIndex = 13
        Me.btn_reconnect.Text = "Reset Koneksi"
        Me.btn_reconnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 14
        '
        'lbl_datetime
        '
        Me.lbl_datetime.AutoSize = True
        Me.lbl_datetime.Location = New System.Drawing.Point(177, 236)
        Me.lbl_datetime.Name = "lbl_datetime"
        Me.lbl_datetime.Size = New System.Drawing.Size(77, 13)
        Me.lbl_datetime.TabIndex = 15
        Me.lbl_datetime.Text = "Null Date Time"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(283, 231)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(104, 23)
        Me.BtnExit.TabIndex = 16
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(511, 260)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.lbl_datetime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_reconnect)
        Me.Controls.Add(Me.lbl_constatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnLaporan)
        Me.Controls.Add(Me.BtnPesanan)
        Me.Controls.Add(Me.BtnGudang)
        Me.Controls.Add(Me.BtnJoblist)
        Me.Controls.Add(Me.BtnKaryawan)
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnKaryawan As System.Windows.Forms.Button
    Friend WithEvents BtnJoblist As System.Windows.Forms.Button
    Friend WithEvents BtnGudang As System.Windows.Forms.Button
    Friend WithEvents BtnLogout As System.Windows.Forms.Button
    Friend WithEvents BtnLaporan As System.Windows.Forms.Button
    Friend WithEvents BtnPesanan As System.Windows.Forms.Button
    Friend WithEvents lbl_constatus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_reconnect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_datetime As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
End Class
