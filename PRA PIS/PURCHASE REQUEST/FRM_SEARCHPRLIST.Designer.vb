<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_SEARCHPRLIST
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GB_PRLIST = New System.Windows.Forms.GroupBox()
        Me.DGV_PRLIST = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnPrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SPM4_PURCHASELISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LBL_TOTALNOOFPR = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_PRLISTSTATUS = New System.Windows.Forms.ComboBox()
        Me.PBICONSEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_SEARCHPR = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSEARCH = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SPM4PURCHASELISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PNL = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.TblV1_HRISDIVISIONTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter()
        Me.TblV1_HRISDEPARTMENTTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter()
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.TblV1_HRISEMPLOYEEDATATableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter()
        Me.APNL_REQUEST_STATUS = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewDetails = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SPM4PURCHASEREQUESTSTATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_APNL_CLOSE = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.TblM4_PURCHASEREQUESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_PURCHASEREQUESTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.SPM4_PURCHASELISTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_PURCHASELISTTableAdapter()
        Me.SPM4_PURCHASEREQUEST_STATUSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_PURCHASEREQUEST_STATUSTableAdapter()
        Me.GB_PRLIST.SuspendLayout()
        CType(Me.DGV_PRLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PURCHASELISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4PURCHASELISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APNL_REQUEST_STATUS.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SPM4_PURCHASEREQUEST_STATUSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4PURCHASEREQUESTSTATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_PRLIST
        '
        Me.GB_PRLIST.BackColor = System.Drawing.SystemColors.Window
        Me.GB_PRLIST.Controls.Add(Me.DGV_PRLIST)
        Me.GB_PRLIST.Controls.Add(Me.GroupBox4)
        Me.GB_PRLIST.Controls.Add(Me.GroupBox5)
        Me.GB_PRLIST.Controls.Add(Me.GroupBox3)
        Me.GB_PRLIST.Controls.Add(Me.Label6)
        Me.GB_PRLIST.Controls.Add(Me.Label5)
        Me.GB_PRLIST.Controls.Add(Me.CB_PRLISTSTATUS)
        Me.GB_PRLIST.Controls.Add(Me.PBICONSEARCH)
        Me.GB_PRLIST.Controls.Add(Me.WTXT_SEARCHPR)
        Me.GB_PRLIST.Controls.Add(Me.ShapeContainer2)
        Me.GB_PRLIST.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GB_PRLIST.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_PRLIST.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GB_PRLIST.Location = New System.Drawing.Point(5, 35)
        Me.GB_PRLIST.Name = "GB_PRLIST"
        Me.GB_PRLIST.Size = New System.Drawing.Size(1085, 621)
        Me.GB_PRLIST.TabIndex = 1403
        Me.GB_PRLIST.TabStop = False
        '
        'DGV_PRLIST
        '
        Me.DGV_PRLIST.AllowUserToAddRows = False
        Me.DGV_PRLIST.AllowUserToDeleteRows = False
        Me.DGV_PRLIST.AllowUserToResizeColumns = False
        Me.DGV_PRLIST.AllowUserToResizeRows = False
        Me.DGV_PRLIST.AutoGenerateColumns = False
        Me.DGV_PRLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PRLIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.btnView, Me.btnPrint})
        Me.DGV_PRLIST.DataSource = Me.SPM4_PURCHASELISTBindingSource
        Me.DGV_PRLIST.Location = New System.Drawing.Point(196, 68)
        Me.DGV_PRLIST.Name = "DGV_PRLIST"
        Me.DGV_PRLIST.ReadOnly = True
        Me.DGV_PRLIST.RowHeadersVisible = False
        Me.DGV_PRLIST.Size = New System.Drawing.Size(880, 492)
        Me.DGV_PRLIST.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Status of Ongoing PR"
        Me.DataGridViewTextBoxColumn4.HeaderText = ""
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 20
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PR_STATUS"
        Me.DataGridViewTextBoxColumn5.HeaderText = ""
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 20
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PR_PRNO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PR No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Remarks/Purpose"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Remarks/Purpose"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnView
        '
        Me.btnView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.btnView.HeaderText = ""
        Me.btnView.Name = "btnView"
        Me.btnView.ReadOnly = True
        Me.btnView.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnView.Text = "View"
        Me.btnView.UseColumnTextForButtonValue = True
        Me.btnView.Width = 60
        '
        'btnPrint
        '
        Me.btnPrint.HeaderText = ""
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ReadOnly = True
        Me.btnPrint.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseColumnTextForButtonValue = True
        Me.btnPrint.Width = 60
        '
        'SPM4_PURCHASELISTBindingSource
        '
        Me.SPM4_PURCHASELISTBindingSource.DataMember = "SPM4_PURCHASELIST"
        Me.SPM4_PURCHASELISTBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.LBL_TOTALNOOFPR)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(196, 566)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(266, 45)
        Me.GroupBox4.TabIndex = 1466
        Me.GroupBox4.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(166, 19)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Total No. of Records :"
        '
        'LBL_TOTALNOOFPR
        '
        Me.LBL_TOTALNOOFPR.AutoSize = True
        Me.LBL_TOTALNOOFPR.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TOTALNOOFPR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_TOTALNOOFPR.Location = New System.Drawing.Point(172, 14)
        Me.LBL_TOTALNOOFPR.Name = "LBL_TOTALNOOFPR"
        Me.LBL_TOTALNOOFPR.Size = New System.Drawing.Size(21, 23)
        Me.LBL_TOTALNOOFPR.TabIndex = 5
        Me.LBL_TOTALNOOFPR.Text = "0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Panel13)
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Panel11)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Panel12)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Panel10)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Panel9)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Panel6)
        Me.GroupBox5.Controls.Add(Me.Panel7)
        Me.GroupBox5.Controls.Add(Me.Panel8)
        Me.GroupBox5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(9, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(181, 376)
        Me.GroupBox5.TabIndex = 1465
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Status for on-going PR"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(31, 346)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 16)
        Me.Label23.TabIndex = 1466
        Me.Label23.Text = "Pending"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.DimGray
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel13.Location = New System.Drawing.Point(8, 341)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(20, 29)
        Me.Panel13.TabIndex = 1465
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_subdirectory_arrow_right_black_18dp
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(9, 237)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 29)
        Me.PictureBox2.TabIndex = 1464
        Me.PictureBox2.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(44, 255)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 16)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "B. Delivered"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(30, 312)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 16)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Canceled PO"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Location = New System.Drawing.Point(8, 306)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(20, 29)
        Me.Panel11.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(30, 277)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 16)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "For Proofing"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Location = New System.Drawing.Point(8, 271)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(20, 29)
        Me.Panel12.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(42, 236)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 16)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "A. For Delivery"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(29, 211)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 16)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "PO/Contract Issued"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Blue
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Location = New System.Drawing.Point(8, 205)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(20, 29)
        Me.Panel10.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(30, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Awarded"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Location = New System.Drawing.Point(8, 170)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(20, 29)
        Me.Panel9.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(28, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "BAC Resolution Issued"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(8, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(20, 29)
        Me.Panel1.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(31, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 16)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "For BAC Agenda"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(29, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "For Evaluation"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(30, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Posted"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MediumOrchid
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(8, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(20, 29)
        Me.Panel6.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Location = New System.Drawing.Point(8, 30)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(20, 29)
        Me.Panel7.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Location = New System.Drawing.Point(8, 65)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(20, 29)
        Me.Panel8.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Panel5)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 398)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(181, 216)
        Me.GroupBox3.TabIndex = 1464
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status of encoded PR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(28, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pending"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(8, 126)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(20, 29)
        Me.Panel5.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(31, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cancel PR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(29, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "For Revision"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(30, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Accepted"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(8, 94)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(20, 29)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(8, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(20, 29)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(8, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(20, 29)
        Me.Panel2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(5, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 1411
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(881, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 1410
        Me.Label5.Text = "Filter By: Status"
        '
        'CB_PRLISTSTATUS
        '
        Me.CB_PRLISTSTATUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PRLISTSTATUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_PRLISTSTATUS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PRLISTSTATUS.FormattingEnabled = True
        Me.CB_PRLISTSTATUS.Items.AddRange(New Object() {"ACCEPTED", "REVISION", "CANCELED", "PENDING", "ALL"})
        Me.CB_PRLISTSTATUS.Location = New System.Drawing.Point(884, 25)
        Me.CB_PRLISTSTATUS.Name = "CB_PRLISTSTATUS"
        Me.CB_PRLISTSTATUS.Size = New System.Drawing.Size(185, 23)
        Me.CB_PRLISTSTATUS.TabIndex = 1409
        '
        'PBICONSEARCH
        '
        Me.PBICONSEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PBICONSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBICONSEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBICONSEARCH.InitialImage = Nothing
        Me.PBICONSEARCH.Location = New System.Drawing.Point(827, 23)
        Me.PBICONSEARCH.Name = "PBICONSEARCH"
        Me.PBICONSEARCH.Size = New System.Drawing.Size(32, 24)
        Me.PBICONSEARCH.TabIndex = 1408
        Me.PBICONSEARCH.TabStop = False
        '
        'WTXT_SEARCHPR
        '
        Me.WTXT_SEARCHPR.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SEARCHPR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCHPR.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCHPR.ForeColor = System.Drawing.Color.Black
        Me.WTXT_SEARCHPR.Location = New System.Drawing.Point(209, 23)
        Me.WTXT_SEARCHPR.Name = "WTXT_SEARCHPR"
        Me.WTXT_SEARCHPR.Size = New System.Drawing.Size(615, 26)
        Me.WTXT_SEARCHPR.TabIndex = 0
        Me.WTXT_SEARCHPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SEARCHPR.Watermark = "Search PR No."
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RECT_PRSEARCH})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1079, 601)
        Me.ShapeContainer2.TabIndex = 5
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 15
        Me.RectangleShape2.Location = New System.Drawing.Point(866, 2)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(210, 33)
        '
        'RECT_PRSEARCH
        '
        Me.RECT_PRSEARCH.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSEARCH.BorderWidth = 2
        Me.RECT_PRSEARCH.CornerRadius = 15
        Me.RECT_PRSEARCH.Location = New System.Drawing.Point(192, 2)
        Me.RECT_PRSEARCH.Name = "RECT_PRSEARCH"
        Me.RECT_PRSEARCH.Size = New System.Drawing.Size(671, 33)
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1095, 42)
        Me.PNL.TabIndex = 1404
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(10, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(314, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "P U R C H A S E  R E Q U E S T  L I S T"
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(1061, 6)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'TblV1_HRISDIVISIONTableAdapter
        '
        Me.TblV1_HRISDIVISIONTableAdapter.ClearBeforeFill = True
        '
        'TblV1_HRISDEPARTMENTTableAdapter
        '
        Me.TblV1_HRISDEPARTMENTTableAdapter.ClearBeforeFill = True
        '
        'DS_TABLES
        '
        Me.DS_TABLES.DataSetName = "DS_TABLES"
        Me.DS_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblV1_HRISEMPLOYEEDATATableAdapter
        '
        Me.TblV1_HRISEMPLOYEEDATATableAdapter.ClearBeforeFill = True
        '
        'APNL_REQUEST_STATUS
        '
        Me.APNL_REQUEST_STATUS.BackColor = System.Drawing.Color.White
        Me.APNL_REQUEST_STATUS.Controls.Add(Me.GroupBox2)
        Me.APNL_REQUEST_STATUS.Controls.Add(Me.BTN_APNL_CLOSE)
        Me.APNL_REQUEST_STATUS.Controls.Add(Me.Panel15)
        Me.APNL_REQUEST_STATUS.Location = New System.Drawing.Point(1095, 42)
        Me.APNL_REQUEST_STATUS.Name = "APNL_REQUEST_STATUS"
        Me.APNL_REQUEST_STATUS.Size = New System.Drawing.Size(415, 615)
        Me.APNL_REQUEST_STATUS.TabIndex = 1405
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SPM4_PURCHASEREQUEST_STATUSDataGridView)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 562)
        Me.GroupBox2.TabIndex = 1407
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Purchase Request Status"
        '
        'SPM4_PURCHASEREQUEST_STATUSDataGridView
        '
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.AllowUserToAddRows = False
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.AllowUserToDeleteRows = False
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.AllowUserToResizeColumns = False
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.AllowUserToResizeRows = False
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.AutoGenerateColumns = False
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.btnViewDetails})
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.DataSource = Me.SPM4PURCHASEREQUESTSTATUSBindingSource
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.Location = New System.Drawing.Point(6, 21)
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.Name = "SPM4_PURCHASEREQUEST_STATUSDataGridView"
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.ReadOnly = True
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.RowHeadersVisible = False
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.Size = New System.Drawing.Size(357, 532)
        Me.SPM4_PURCHASEREQUEST_STATUSDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn6.HeaderText = ""
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 20
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date Created"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Time Created"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnViewDetails
        '
        Me.btnViewDetails.HeaderText = ""
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.ReadOnly = True
        Me.btnViewDetails.Text = "View Details"
        Me.btnViewDetails.UseColumnTextForButtonValue = True
        '
        'SPM4PURCHASEREQUESTSTATUSBindingSource
        '
        Me.SPM4PURCHASEREQUESTSTATUSBindingSource.DataMember = "SPM4_PURCHASEREQUEST_STATUS"
        Me.SPM4PURCHASEREQUESTSTATUSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'BTN_APNL_CLOSE
        '
        Me.BTN_APNL_CLOSE.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BTN_APNL_CLOSE.Location = New System.Drawing.Point(-1, -1)
        Me.BTN_APNL_CLOSE.Name = "BTN_APNL_CLOSE"
        Me.BTN_APNL_CLOSE.Size = New System.Drawing.Size(30, 616)
        Me.BTN_APNL_CLOSE.TabIndex = 0
        Me.BTN_APNL_CLOSE.Text = ">>"
        Me.BTN_APNL_CLOSE.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(415, 35)
        Me.Panel15.TabIndex = 1405
        '
        'TblM4_PURCHASEREQUESTBindingSource
        '
        Me.TblM4_PURCHASEREQUESTBindingSource.DataMember = "tblM4_PURCHASEREQUEST"
        Me.TblM4_PURCHASEREQUESTBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_PURCHASEREQUESTTableAdapter
        '
        Me.TblM4_PURCHASEREQUESTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBLG3_COMPANY_INFOTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_DELIVER_RECEIPT_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_DELIVERY_RECEIPTTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_INVOICE_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_INVOICETableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_PRIMARY_SIGNATORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_BUSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_DVTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_PARTICULARTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORY_TYPETableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORY1TableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_UNITSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_CATEGORY1TableAdapter = Nothing
        '  Me.TableAdapterManager.tblM4_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_ITEMBRAND1TableAdapter = Nothing
        '   Me.TableAdapterManager.tblM4_ITEMBRANDTableAdapter = Nothing
        'Me.TableAdapterManager.tblM4_ITEMS_DEFLOCATIONTableAdapter = Nothing
        'Me.TableAdapterManager.tblM4_ITEMS_LOCATIONTableAdapter = Nothing
        '  Me.TableAdapterManager.tblM4_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CANCELEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_POSTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_PROVIDERTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_REVISIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUESTTableAdapter = Me.TblM4_PURCHASEREQUESTTableAdapter
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SPM4_PURCHASELISTTableAdapter
        '
        Me.SPM4_PURCHASELISTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_PURCHASEREQUEST_STATUSTableAdapter
        '
        Me.SPM4_PURCHASEREQUEST_STATUSTableAdapter.ClearBeforeFill = True
        '
        'FRM_SEARCHPRLIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1095, 660)
        Me.Controls.Add(Me.APNL_REQUEST_STATUS)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.GB_PRLIST)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_SEARCHPRLIST"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_SEARCHPRLIST"
        Me.GB_PRLIST.ResumeLayout(False)
        Me.GB_PRLIST.PerformLayout()
        CType(Me.DGV_PRLIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PURCHASELISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4PURCHASELISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APNL_REQUEST_STATUS.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.SPM4_PURCHASEREQUEST_STATUSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4PURCHASEREQUESTSTATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_PRLIST As GroupBox
    Friend WithEvents PBICONSEARCH As PictureBox
    Friend WithEvents WTXT_SEARCHPR As WatermarkTextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSEARCH As PowerPacks.RectangleShape
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_PRLISTSTATUS As ComboBox
    Friend WithEvents PNL As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_CLOSE As Button
    '  Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DSPROPERTYDB_TABLESTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TblM4_PURCHASEREQUESTBindingSource As BindingSource
    Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TblV1_HRISDIVISIONTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter
    Friend WithEvents TblV1_HRISDEPARTMENTTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TblV1_HRISEMPLOYEEDATATableAdapter As DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents LBL_TOTALNOOFPR As Label
    Friend WithEvents APNL_VALIDATEPR As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_PR_ITEMLIST As DataGridView
    Friend WithEvents Panel23 As Panel
    Friend WithEvents LLBL_INVENTORY_ENCODING_HEADER As Label
    Friend WithEvents BTN_CLOSE_VALIDATEPR_MINI_CLOSE As Button
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents dateCreated As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewButtonColumn
    Friend WithEvents SPM4PURCHASELISTBindingSource As BindingSource
    Friend WithEvents SPM4_PURCHASELISTTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_PURCHASELISTTableAdapter
    Friend WithEvents SPM4_PURCHASELISTBindingSource As BindingSource
    Friend WithEvents DGV_PRLIST As DataGridView
    Friend WithEvents APNL_REQUEST_STATUS As Panel
    Friend WithEvents BTN_APNL_CLOSE As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents SPM4PURCHASEREQUESTSTATUSBindingSource As BindingSource
    Friend WithEvents SPM4_PURCHASEREQUEST_STATUSTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_PURCHASEREQUEST_STATUSTableAdapter
    Friend WithEvents SPM4_PURCHASEREQUEST_STATUSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btnViewDetails As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents btnView As DataGridViewButtonColumn
    Friend WithEvents btnPrint As DataGridViewButtonColumn
End Class
