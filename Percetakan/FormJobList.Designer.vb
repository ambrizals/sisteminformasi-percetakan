<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJobList
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.job_pending = New System.Windows.Forms.TabPage()
        Me.job_process = New System.Windows.Forms.TabPage()
        Me.job_finish = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 63)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 496)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 48)
        Me.Panel2.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.job_pending)
        Me.TabControl1.Controls.Add(Me.job_process)
        Me.TabControl1.Controls.Add(Me.job_finish)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(752, 433)
        Me.TabControl1.TabIndex = 2
        '
        'job_pending
        '
        Me.job_pending.Location = New System.Drawing.Point(4, 22)
        Me.job_pending.Name = "job_pending"
        Me.job_pending.Padding = New System.Windows.Forms.Padding(3)
        Me.job_pending.Size = New System.Drawing.Size(744, 309)
        Me.job_pending.TabIndex = 0
        Me.job_pending.Text = "Pending (0)"
        Me.job_pending.UseVisualStyleBackColor = True
        '
        'job_process
        '
        Me.job_process.Location = New System.Drawing.Point(4, 22)
        Me.job_process.Name = "job_process"
        Me.job_process.Padding = New System.Windows.Forms.Padding(3)
        Me.job_process.Size = New System.Drawing.Size(744, 309)
        Me.job_process.TabIndex = 1
        Me.job_process.Text = "Process (0)"
        Me.job_process.UseVisualStyleBackColor = True
        '
        'job_finish
        '
        Me.job_finish.Location = New System.Drawing.Point(4, 22)
        Me.job_finish.Name = "job_finish"
        Me.job_finish.Size = New System.Drawing.Size(744, 407)
        Me.job_finish.TabIndex = 2
        Me.job_finish.Text = "Finish (0)"
        Me.job_finish.UseVisualStyleBackColor = True
        '
        'FormJobList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 544)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormJobList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job List"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents job_pending As System.Windows.Forms.TabPage
    Friend WithEvents job_process As System.Windows.Forms.TabPage
    Friend WithEvents job_finish As System.Windows.Forms.TabPage
End Class
