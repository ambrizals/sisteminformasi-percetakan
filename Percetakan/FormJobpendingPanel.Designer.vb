<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJobpendingPanel
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_statusbayarpesanan = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_terbayarpesanan = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_totalbayarpesanan = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_pesananstatus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_pesanancreateby = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_nomortelpcust = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_namacust = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_nomorpesanan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_DaftarJob = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DG_DaftarJob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 66)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 470)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 49)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnCancel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnProses, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(396, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(328, 49)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCancel.Location = New System.Drawing.Point(167, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(158, 43)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnProses
        '
        Me.BtnProses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnProses.Location = New System.Drawing.Point(3, 3)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(158, 43)
        Me.BtnProses.TabIndex = 1
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_DaftarJob, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 66)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.41708!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.58292!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(724, 404)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(718, 129)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(362, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informasi Pesanan :"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_statusbayarpesanan, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label15, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_terbayarpesanan, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label13, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_totalbayarpesanan, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_pesananstatus, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(347, 104)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'lbl_statusbayarpesanan
        '
        Me.lbl_statusbayarpesanan.AutoSize = True
        Me.lbl_statusbayarpesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_statusbayarpesanan.Location = New System.Drawing.Point(176, 78)
        Me.lbl_statusbayarpesanan.Name = "lbl_statusbayarpesanan"
        Me.lbl_statusbayarpesanan.Size = New System.Drawing.Size(168, 26)
        Me.lbl_statusbayarpesanan.TabIndex = 7
        Me.lbl_statusbayarpesanan.Text = "Null Data"
        Me.lbl_statusbayarpesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Location = New System.Drawing.Point(3, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(167, 26)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Status Pembayaran :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_terbayarpesanan
        '
        Me.lbl_terbayarpesanan.AutoSize = True
        Me.lbl_terbayarpesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_terbayarpesanan.Location = New System.Drawing.Point(176, 52)
        Me.lbl_terbayarpesanan.Name = "lbl_terbayarpesanan"
        Me.lbl_terbayarpesanan.Size = New System.Drawing.Size(168, 26)
        Me.lbl_terbayarpesanan.TabIndex = 5
        Me.lbl_terbayarpesanan.Text = "Null Data"
        Me.lbl_terbayarpesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(3, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(167, 26)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Jumlah terbayar :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_totalbayarpesanan
        '
        Me.lbl_totalbayarpesanan.AutoSize = True
        Me.lbl_totalbayarpesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_totalbayarpesanan.Location = New System.Drawing.Point(176, 26)
        Me.lbl_totalbayarpesanan.Name = "lbl_totalbayarpesanan"
        Me.lbl_totalbayarpesanan.Size = New System.Drawing.Size(168, 26)
        Me.lbl_totalbayarpesanan.TabIndex = 3
        Me.lbl_totalbayarpesanan.Text = "Null Data"
        Me.lbl_totalbayarpesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 26)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Total Pembayaran :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_pesananstatus
        '
        Me.lbl_pesananstatus.AutoSize = True
        Me.lbl_pesananstatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_pesananstatus.Location = New System.Drawing.Point(176, 0)
        Me.lbl_pesananstatus.Name = "lbl_pesananstatus"
        Me.lbl_pesananstatus.Size = New System.Drawing.Size(168, 26)
        Me.lbl_pesananstatus.TabIndex = 1
        Me.lbl_pesananstatus.Text = "Null Data"
        Me.lbl_pesananstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 26)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Order Status :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pemesan :"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_pesanancreateby, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_nomortelpcust, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_namacust, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_nomorpesanan, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(347, 104)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'lbl_pesanancreateby
        '
        Me.lbl_pesanancreateby.AutoSize = True
        Me.lbl_pesanancreateby.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_pesanancreateby.Location = New System.Drawing.Point(176, 78)
        Me.lbl_pesanancreateby.Name = "lbl_pesanancreateby"
        Me.lbl_pesanancreateby.Size = New System.Drawing.Size(168, 26)
        Me.lbl_pesanancreateby.TabIndex = 7
        Me.lbl_pesanancreateby.Text = "Null Data"
        Me.lbl_pesanancreateby.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Pesanan Diterbitkan oleh :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nomortelpcust
        '
        Me.lbl_nomortelpcust.AutoSize = True
        Me.lbl_nomortelpcust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_nomortelpcust.Location = New System.Drawing.Point(176, 52)
        Me.lbl_nomortelpcust.Name = "lbl_nomortelpcust"
        Me.lbl_nomortelpcust.Size = New System.Drawing.Size(168, 26)
        Me.lbl_nomortelpcust.TabIndex = 5
        Me.lbl_nomortelpcust.Text = "Null Data"
        Me.lbl_nomortelpcust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nomor Telepon Pelanggan :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_namacust
        '
        Me.lbl_namacust.AutoSize = True
        Me.lbl_namacust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_namacust.Location = New System.Drawing.Point(176, 26)
        Me.lbl_namacust.Name = "lbl_namacust"
        Me.lbl_namacust.Size = New System.Drawing.Size(168, 26)
        Me.lbl_namacust.TabIndex = 3
        Me.lbl_namacust.Text = "Null Data"
        Me.lbl_namacust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pelanggan :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nomorpesanan
        '
        Me.lbl_nomorpesanan.AutoSize = True
        Me.lbl_nomorpesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_nomorpesanan.Location = New System.Drawing.Point(176, 0)
        Me.lbl_nomorpesanan.Name = "lbl_nomorpesanan"
        Me.lbl_nomorpesanan.Size = New System.Drawing.Size(168, 26)
        Me.lbl_nomorpesanan.TabIndex = 1
        Me.lbl_nomorpesanan.Text = "Null Data"
        Me.lbl_nomorpesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Pesanan :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DG_DaftarJob
        '
        Me.DG_DaftarJob.AllowUserToAddRows = False
        Me.DG_DaftarJob.AllowUserToDeleteRows = False
        Me.DG_DaftarJob.AllowUserToResizeColumns = False
        Me.DG_DaftarJob.AllowUserToResizeRows = False
        Me.DG_DaftarJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_DaftarJob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_DaftarJob.Location = New System.Drawing.Point(3, 138)
        Me.DG_DaftarJob.MultiSelect = False
        Me.DG_DaftarJob.Name = "DG_DaftarJob"
        Me.DG_DaftarJob.ReadOnly = True
        Me.DG_DaftarJob.RowHeadersVisible = False
        Me.DG_DaftarJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_DaftarJob.Size = New System.Drawing.Size(718, 263)
        Me.DG_DaftarJob.TabIndex = 1
        '
        'FormJobpendingPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 519)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormJobpendingPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesanan :"
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DG_DaftarJob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_DaftarJob As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_pesanancreateby As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_nomortelpcust As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_namacust As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_nomorpesanan As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_statusbayarpesanan As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_terbayarpesanan As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_totalbayarpesanan As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_pesananstatus As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
