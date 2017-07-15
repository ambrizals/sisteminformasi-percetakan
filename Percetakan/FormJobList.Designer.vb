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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJobList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tab_job = New System.Windows.Forms.TabControl()
        Me.job_pending = New System.Windows.Forms.TabPage()
        Me.DG_Pending = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pendingcari = New System.Windows.Forms.TextBox()
        Me.Btn_CariPending = New System.Windows.Forms.Button()
        Me.job_process = New System.Windows.Forms.TabPage()
        Me.DG_Proses = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_prosescari = New System.Windows.Forms.TextBox()
        Me.Btn_ProsesCari = New System.Windows.Forms.Button()
        Me.job_finish = New System.Windows.Forms.TabPage()
        Me.DG_Finish = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_finishcari = New System.Windows.Forms.TextBox()
        Me.Btn_FinishCari = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_job.SuspendLayout()
        Me.job_pending.SuspendLayout()
        CType(Me.DG_Pending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.job_process.SuspendLayout()
        CType(Me.DG_Proses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.job_finish.SuspendLayout()
        CType(Me.DG_Finish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 63)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(732, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "X"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(300, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 51)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(352, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 35)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "JOB LIST"
        '
        'tab_job
        '
        Me.tab_job.Controls.Add(Me.job_pending)
        Me.tab_job.Controls.Add(Me.job_process)
        Me.tab_job.Controls.Add(Me.job_finish)
        Me.tab_job.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_job.Location = New System.Drawing.Point(0, 63)
        Me.tab_job.Name = "tab_job"
        Me.tab_job.SelectedIndex = 0
        Me.tab_job.Size = New System.Drawing.Size(752, 418)
        Me.tab_job.TabIndex = 2
        '
        'job_pending
        '
        Me.job_pending.Controls.Add(Me.DG_Pending)
        Me.job_pending.Controls.Add(Me.TableLayoutPanel1)
        Me.job_pending.Location = New System.Drawing.Point(4, 22)
        Me.job_pending.Name = "job_pending"
        Me.job_pending.Padding = New System.Windows.Forms.Padding(3)
        Me.job_pending.Size = New System.Drawing.Size(744, 392)
        Me.job_pending.TabIndex = 0
        Me.job_pending.Text = "Pending (0)"
        Me.job_pending.UseVisualStyleBackColor = True
        '
        'DG_Pending
        '
        Me.DG_Pending.AllowUserToAddRows = False
        Me.DG_Pending.AllowUserToDeleteRows = False
        Me.DG_Pending.AllowUserToResizeColumns = False
        Me.DG_Pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Pending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Pending.Location = New System.Drawing.Point(3, 30)
        Me.DG_Pending.Name = "DG_Pending"
        Me.DG_Pending.ReadOnly = True
        Me.DG_Pending.RowHeadersVisible = False
        Me.DG_Pending.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Pending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Pending.Size = New System.Drawing.Size(738, 359)
        Me.DG_Pending.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.99163!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.00837!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_pendingcari, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_CariPending, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(738, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari ID Job :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_pendingcari
        '
        Me.txt_pendingcari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_pendingcari.Location = New System.Drawing.Point(107, 3)
        Me.txt_pendingcari.Name = "txt_pendingcari"
        Me.txt_pendingcari.Size = New System.Drawing.Size(470, 20)
        Me.txt_pendingcari.TabIndex = 1
        '
        'Btn_CariPending
        '
        Me.Btn_CariPending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_CariPending.Location = New System.Drawing.Point(583, 3)
        Me.Btn_CariPending.Name = "Btn_CariPending"
        Me.Btn_CariPending.Size = New System.Drawing.Size(152, 21)
        Me.Btn_CariPending.TabIndex = 2
        Me.Btn_CariPending.Text = "Cari"
        Me.Btn_CariPending.UseVisualStyleBackColor = True
        '
        'job_process
        '
        Me.job_process.Controls.Add(Me.DG_Proses)
        Me.job_process.Controls.Add(Me.TableLayoutPanel2)
        Me.job_process.Location = New System.Drawing.Point(4, 22)
        Me.job_process.Name = "job_process"
        Me.job_process.Padding = New System.Windows.Forms.Padding(3)
        Me.job_process.Size = New System.Drawing.Size(744, 392)
        Me.job_process.TabIndex = 1
        Me.job_process.Text = "Process (0)"
        Me.job_process.UseVisualStyleBackColor = True
        '
        'DG_Proses
        '
        Me.DG_Proses.AllowUserToAddRows = False
        Me.DG_Proses.AllowUserToDeleteRows = False
        Me.DG_Proses.AllowUserToResizeColumns = False
        Me.DG_Proses.AllowUserToResizeRows = False
        Me.DG_Proses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Proses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Proses.Location = New System.Drawing.Point(3, 31)
        Me.DG_Proses.Name = "DG_Proses"
        Me.DG_Proses.RowHeadersVisible = False
        Me.DG_Proses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Proses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Proses.Size = New System.Drawing.Size(738, 358)
        Me.DG_Proses.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.41004!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.58996!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_prosescari, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_ProsesCari, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(738, 28)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cari ID Job :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_prosescari
        '
        Me.txt_prosescari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_prosescari.Location = New System.Drawing.Point(113, 3)
        Me.txt_prosescari.Name = "txt_prosescari"
        Me.txt_prosescari.Size = New System.Drawing.Size(485, 20)
        Me.txt_prosescari.TabIndex = 1
        '
        'Btn_ProsesCari
        '
        Me.Btn_ProsesCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_ProsesCari.Location = New System.Drawing.Point(604, 3)
        Me.Btn_ProsesCari.Name = "Btn_ProsesCari"
        Me.Btn_ProsesCari.Size = New System.Drawing.Size(131, 22)
        Me.Btn_ProsesCari.TabIndex = 2
        Me.Btn_ProsesCari.Text = "Cari"
        Me.Btn_ProsesCari.UseVisualStyleBackColor = True
        '
        'job_finish
        '
        Me.job_finish.Controls.Add(Me.DG_Finish)
        Me.job_finish.Controls.Add(Me.TableLayoutPanel3)
        Me.job_finish.Location = New System.Drawing.Point(4, 22)
        Me.job_finish.Name = "job_finish"
        Me.job_finish.Size = New System.Drawing.Size(744, 392)
        Me.job_finish.TabIndex = 2
        Me.job_finish.Text = "Finish (0)"
        Me.job_finish.UseVisualStyleBackColor = True
        '
        'DG_Finish
        '
        Me.DG_Finish.AllowUserToAddRows = False
        Me.DG_Finish.AllowUserToDeleteRows = False
        Me.DG_Finish.AllowUserToResizeColumns = False
        Me.DG_Finish.AllowUserToResizeRows = False
        Me.DG_Finish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Finish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_Finish.Location = New System.Drawing.Point(0, 29)
        Me.DG_Finish.Name = "DG_Finish"
        Me.DG_Finish.RowHeadersVisible = False
        Me.DG_Finish.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DG_Finish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Finish.Size = New System.Drawing.Size(744, 363)
        Me.DG_Finish.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.3527!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.6473!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_finishcari, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Btn_FinishCari, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(744, 29)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cari ID Job :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_finishcari
        '
        Me.txt_finishcari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_finishcari.Location = New System.Drawing.Point(96, 3)
        Me.txt_finishcari.Name = "txt_finishcari"
        Me.txt_finishcari.Size = New System.Drawing.Size(511, 20)
        Me.txt_finishcari.TabIndex = 1
        '
        'Btn_FinishCari
        '
        Me.Btn_FinishCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_FinishCari.Location = New System.Drawing.Point(613, 3)
        Me.Btn_FinishCari.Name = "Btn_FinishCari"
        Me.Btn_FinishCari.Size = New System.Drawing.Size(128, 23)
        Me.Btn_FinishCari.TabIndex = 2
        Me.Btn_FinishCari.Text = "Cari"
        Me.Btn_FinishCari.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_refresh)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 481)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 63)
        Me.Panel2.TabIndex = 1
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(624, 16)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(116, 35)
        Me.btn_refresh.TabIndex = 0
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'FormJobList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(752, 544)
        Me.Controls.Add(Me.tab_job)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormJobList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_job.ResumeLayout(False)
        Me.job_pending.ResumeLayout(False)
        CType(Me.DG_Pending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.job_process.ResumeLayout(False)
        CType(Me.DG_Proses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.job_finish.ResumeLayout(False)
        CType(Me.DG_Finish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tab_job As System.Windows.Forms.TabControl
    Friend WithEvents job_process As System.Windows.Forms.TabPage
    Friend WithEvents job_finish As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DG_Proses As System.Windows.Forms.DataGridView
    Friend WithEvents DG_Finish As System.Windows.Forms.DataGridView
    Friend WithEvents job_pending As System.Windows.Forms.TabPage
    Friend WithEvents DG_Pending As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_pendingcari As System.Windows.Forms.TextBox
    Friend WithEvents Btn_CariPending As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_prosescari As System.Windows.Forms.TextBox
    Friend WithEvents Btn_ProsesCari As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_finishcari As System.Windows.Forms.TextBox
    Friend WithEvents Btn_FinishCari As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
