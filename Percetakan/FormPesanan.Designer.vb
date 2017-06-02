<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPesanan
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_nomorteleponcust = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_tanggal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_namacustomer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_karyawanname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_kodepesanan = New System.Windows.Forms.TextBox()
        Me.DG_ListBuatPesan = New System.Windows.Forms.DataGridView()
        Me.Task_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_taskid = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnBahanSearch = New System.Windows.Forms.Button()
        Me.txt_bahan = New System.Windows.Forms.TextBox()
        Me.txt_deskripsi = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnBayar = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_ListPesanan = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.txt_ordersearch = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DG_ListBuatPesan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DG_ListPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(791, 521)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(783, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Buat Pesanan"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DG_ListBuatPesan, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel10, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel13, 0, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.91416!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.08584!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(777, 489)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel9, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel8, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(771, 87)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.txt_nomorteleponcust, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(4, 60)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 1
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(378, 23)
        Me.TableLayoutPanel9.TabIndex = 4
        '
        'txt_nomorteleponcust
        '
        Me.txt_nomorteleponcust.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_nomorteleponcust.Location = New System.Drawing.Point(192, 3)
        Me.txt_nomorteleponcust.Name = "txt_nomorteleponcust"
        Me.txt_nomorteleponcust.Size = New System.Drawing.Size(183, 20)
        Me.txt_nomorteleponcust.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nomor Telepon :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_tanggal, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.Label7, 0, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(389, 32)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(378, 21)
        Me.TableLayoutPanel8.TabIndex = 3
        '
        'lbl_tanggal
        '
        Me.lbl_tanggal.AutoSize = True
        Me.lbl_tanggal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_tanggal.Location = New System.Drawing.Point(192, 0)
        Me.lbl_tanggal.Name = "lbl_tanggal"
        Me.lbl_tanggal.Size = New System.Drawing.Size(183, 21)
        Me.lbl_tanggal.TabIndex = 1
        Me.lbl_tanggal.Text = "Null Date"
        Me.lbl_tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tanggal :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.txt_namacustomer, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(4, 32)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(378, 21)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'txt_namacustomer
        '
        Me.txt_namacustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_namacustomer.Location = New System.Drawing.Point(192, 3)
        Me.txt_namacustomer.Name = "txt_namacustomer"
        Me.txt_namacustomer.Size = New System.Drawing.Size(183, 20)
        Me.txt_namacustomer.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nama Customer"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_karyawanname, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(389, 4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(378, 21)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'lbl_karyawanname
        '
        Me.lbl_karyawanname.AutoSize = True
        Me.lbl_karyawanname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_karyawanname.Location = New System.Drawing.Point(192, 0)
        Me.lbl_karyawanname.Name = "lbl_karyawanname"
        Me.lbl_karyawanname.Size = New System.Drawing.Size(183, 21)
        Me.lbl_karyawanname.TabIndex = 1
        Me.lbl_karyawanname.Text = "Null Name"
        Me.lbl_karyawanname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Karyawan :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txt_kodepesanan, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(378, 21)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Kode Pesanan"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_kodepesanan
        '
        Me.txt_kodepesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_kodepesanan.Location = New System.Drawing.Point(192, 3)
        Me.txt_kodepesanan.Name = "txt_kodepesanan"
        Me.txt_kodepesanan.Size = New System.Drawing.Size(183, 20)
        Me.txt_kodepesanan.TabIndex = 1
        '
        'DG_ListBuatPesan
        '
        Me.DG_ListBuatPesan.AllowUserToOrderColumns = True
        Me.DG_ListBuatPesan.AllowUserToResizeColumns = False
        Me.DG_ListBuatPesan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ListBuatPesan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Task_ID, Me.Bahan, Me.Deskripsi, Me.Qty, Me.Harga, Me.Total})
        Me.DG_ListBuatPesan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_ListBuatPesan.Location = New System.Drawing.Point(3, 236)
        Me.DG_ListBuatPesan.Name = "DG_ListBuatPesan"
        Me.DG_ListBuatPesan.RowHeadersVisible = False
        Me.DG_ListBuatPesan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_ListBuatPesan.Size = New System.Drawing.Size(771, 174)
        Me.DG_ListBuatPesan.TabIndex = 2
        '
        'Task_ID
        '
        Me.Task_ID.HeaderText = "Task ID"
        Me.Task_ID.Name = "Task_ID"
        Me.Task_ID.ReadOnly = True
        '
        'Bahan
        '
        Me.Bahan.FillWeight = 15.46391!
        Me.Bahan.HeaderText = "Bahan"
        Me.Bahan.Name = "Bahan"
        Me.Bahan.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bahan.Width = 150
        '
        'Deskripsi
        '
        Me.Deskripsi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Deskripsi.FillWeight = 15.46391!
        Me.Deskripsi.HeaderText = "Deskripsi"
        Me.Deskripsi.Name = "Deskripsi"
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 50
        '
        'Harga
        '
        Me.Harga.FillWeight = 269.0722!
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66667!))
        Me.TableLayoutPanel10.Controls.Add(Me.BtnTambah, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel11, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 96)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.8806!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.1194!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(771, 134)
        Me.TableLayoutPanel10.TabIndex = 3
        '
        'BtnTambah
        '
        Me.BtnTambah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnTambah.Location = New System.Drawing.Point(3, 102)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(765, 29)
        Me.BtnTambah.TabIndex = 0
        Me.BtnTambah.Text = "Masukkan Ke Daftar"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel11.ColumnCount = 6
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.98361!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.01639!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.Label12, 5, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label11, 4, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label10, 3, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label9, 2, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.txt_taskid, 0, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.TableLayoutPanel12, 1, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.txt_deskripsi, 2, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.txt_qty, 3, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.txt_harga, 4, 1)
        Me.TableLayoutPanel11.Controls.Add(Me.txt_total, 5, 1)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 2
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.21053!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.78947!))
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(765, 93)
        Me.TableLayoutPanel11.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(652, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 30)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Total"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(552, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 30)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Harga"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(500, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 30)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Qty"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(234, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(259, 30)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Deskripsi"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(98, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 30)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Bahan"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(4, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 30)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Task ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_taskid
        '
        Me.txt_taskid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_taskid.Location = New System.Drawing.Point(4, 35)
        Me.txt_taskid.Multiline = True
        Me.txt_taskid.Name = "txt_taskid"
        Me.txt_taskid.ReadOnly = True
        Me.txt_taskid.Size = New System.Drawing.Size(87, 54)
        Me.txt_taskid.TabIndex = 6
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.ColumnCount = 1
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.BtnBahanSearch, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_bahan, 0, 0)
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(98, 35)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 2
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.65217!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.34783!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(129, 54)
        Me.TableLayoutPanel12.TabIndex = 7
        '
        'BtnBahanSearch
        '
        Me.BtnBahanSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBahanSearch.Location = New System.Drawing.Point(3, 27)
        Me.BtnBahanSearch.Name = "BtnBahanSearch"
        Me.BtnBahanSearch.Size = New System.Drawing.Size(123, 24)
        Me.BtnBahanSearch.TabIndex = 0
        Me.BtnBahanSearch.Text = "Cari Bahan"
        Me.BtnBahanSearch.UseVisualStyleBackColor = True
        '
        'txt_bahan
        '
        Me.txt_bahan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_bahan.Location = New System.Drawing.Point(3, 3)
        Me.txt_bahan.Name = "txt_bahan"
        Me.txt_bahan.Size = New System.Drawing.Size(123, 20)
        Me.txt_bahan.TabIndex = 1
        '
        'txt_deskripsi
        '
        Me.txt_deskripsi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_deskripsi.Location = New System.Drawing.Point(234, 35)
        Me.txt_deskripsi.Multiline = True
        Me.txt_deskripsi.Name = "txt_deskripsi"
        Me.txt_deskripsi.Size = New System.Drawing.Size(259, 54)
        Me.txt_deskripsi.TabIndex = 8
        '
        'txt_qty
        '
        Me.txt_qty.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_qty.Location = New System.Drawing.Point(500, 35)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(45, 20)
        Me.txt_qty.TabIndex = 9
        '
        'txt_harga
        '
        Me.txt_harga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_harga.Location = New System.Drawing.Point(552, 35)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(93, 20)
        Me.txt_harga.TabIndex = 10
        '
        'txt_total
        '
        Me.txt_total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_total.Location = New System.Drawing.Point(652, 35)
        Me.txt_total.Multiline = True
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(109, 54)
        Me.txt_total.TabIndex = 11
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 5
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.36111!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.63889!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.BtnBayar, 2, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.BtnCancel, 3, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.BtnKembali, 4, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.Label14, 1, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 416)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(771, 70)
        Me.TableLayoutPanel13.TabIndex = 4
        '
        'BtnBayar
        '
        Me.BtnBayar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnBayar.Location = New System.Drawing.Point(264, 3)
        Me.BtnBayar.Name = "BtnBayar"
        Me.BtnBayar.Size = New System.Drawing.Size(153, 64)
        Me.BtnBayar.TabIndex = 0
        Me.BtnBayar.Text = "Bayar"
        Me.BtnBayar.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCancel.Location = New System.Drawing.Point(423, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(167, 64)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnKembali.Location = New System.Drawing.Point(596, 3)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(172, 64)
        Me.BtnKembali.TabIndex = 2
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 70)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Grand Total"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(113, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 70)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Rp. xxx.xxx.xxx"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(783, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cari Pesanan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DG_ListPesanan, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(777, 489)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DG_ListPesanan
        '
        Me.DG_ListPesanan.AllowUserToAddRows = False
        Me.DG_ListPesanan.AllowUserToDeleteRows = False
        Me.DG_ListPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ListPesanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_ListPesanan.Location = New System.Drawing.Point(3, 64)
        Me.DG_ListPesanan.Name = "DG_ListPesanan"
        Me.DG_ListPesanan.ReadOnly = True
        Me.DG_ListPesanan.Size = New System.Drawing.Size(771, 422)
        Me.DG_ListPesanan.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.49689!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.50311!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnCari, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_ordersearch, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(771, 55)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cari Kode Pesanan :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnCari
        '
        Me.BtnCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCari.Location = New System.Drawing.Point(636, 3)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(132, 49)
        Me.BtnCari.TabIndex = 2
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'txt_ordersearch
        '
        Me.txt_ordersearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ordersearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ordersearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_ordersearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.txt_ordersearch.Location = New System.Drawing.Point(132, 3)
        Me.txt_ordersearch.Name = "txt_ordersearch"
        Me.txt_ordersearch.Size = New System.Drawing.Size(498, 32)
        Me.txt_ordersearch.TabIndex = 1
        '
        'FormPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "FormPesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesanan"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.DG_ListBuatPesan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel13.ResumeLayout(False)
        Me.TableLayoutPanel13.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DG_ListPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DG_ListPesanan As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ordersearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_tanggal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_namacustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_karyawanname As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_kodepesanan As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel9 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_nomorteleponcust As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DG_ListBuatPesan As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel10 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Task_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bahan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deskripsi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_taskid As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel12 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnBahanSearch As System.Windows.Forms.Button
    Friend WithEvents txt_bahan As System.Windows.Forms.TextBox
    Friend WithEvents txt_deskripsi As System.Windows.Forms.TextBox
    Friend WithEvents txt_harga As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel13 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BtnBayar As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnKembali As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
End Class
