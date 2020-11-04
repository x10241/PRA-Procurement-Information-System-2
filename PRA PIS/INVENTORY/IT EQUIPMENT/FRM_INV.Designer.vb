<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_INV
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_INV))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableAdapterManager = New PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager()
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INVENTORY_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PB_ITEM_STOCK_SEARCH = New System.Windows.Forms.PictureBox()
        Me.PB_DR_CLEAR_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_INV_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.DGV_INV_LIST = New System.Windows.Forms.DataGridView()
        Me.INVIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVDDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVDIRECTORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVTOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVDQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVDPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMTINNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMCONTACTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMFAXNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMEMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMDIRECTORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALAMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VWG3INVOICELISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_ITEM_STOCK = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.VWG3_INVOICE_LISTTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWG3_INVOICE_LISTTableAdapter()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_DR_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_INV_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWG3INVOICELISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1067, 49)
        Me.PNL.TabIndex = 1410
        '
        'BTN_INVENTORY_CLOSE
        '
        Me.BTN_INVENTORY_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INVENTORY_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_CLOSE.Location = New System.Drawing.Point(1029, 13)
        Me.BTN_INVENTORY_CLOSE.Name = "BTN_INVENTORY_CLOSE"
        Me.BTN_INVENTORY_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INVENTORY_CLOSE.TabIndex = 16
        Me.BTN_INVENTORY_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(15, 14)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(288, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "S a l e s  I n v o i c e  D e t a i l s"
        '
        'BTN_Minimize
        '
        Me.BTN_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Minimize.BackColor = System.Drawing.Color.DarkCyan
        Me.BTN_Minimize.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_Minimize.FlatAppearance.BorderSize = 3
        Me.BTN_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Minimize.Location = New System.Drawing.Point(-10385, 11)
        Me.BTN_Minimize.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_Minimize.Name = "BTN_Minimize"
        Me.BTN_Minimize.Size = New System.Drawing.Size(47, 45)
        Me.BTN_Minimize.TabIndex = 7
        Me.BTN_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Minimize.UseVisualStyleBackColor = False
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-10338, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PB_ITEM_STOCK_SEARCH)
        Me.Panel1.Controls.Add(Me.PB_DR_CLEAR_SEARCH)
        Me.Panel1.Controls.Add(Me.WTXT_INV_SEARCH)
        Me.Panel1.Controls.Add(Me.DGV_INV_LIST)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(4, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1058, 341)
        Me.Panel1.TabIndex = 1411
        '
        'PB_ITEM_STOCK_SEARCH
        '
        Me.PB_ITEM_STOCK_SEARCH.BackgroundImage = CType(resources.GetObject("PB_ITEM_STOCK_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_ITEM_STOCK_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_ITEM_STOCK_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ITEM_STOCK_SEARCH.InitialImage = Nothing
        Me.PB_ITEM_STOCK_SEARCH.Location = New System.Drawing.Point(17, 10)
        Me.PB_ITEM_STOCK_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_ITEM_STOCK_SEARCH.Name = "PB_ITEM_STOCK_SEARCH"
        Me.PB_ITEM_STOCK_SEARCH.Size = New System.Drawing.Size(37, 34)
        Me.PB_ITEM_STOCK_SEARCH.TabIndex = 1441
        Me.PB_ITEM_STOCK_SEARCH.TabStop = False
        '
        'PB_DR_CLEAR_SEARCH
        '
        Me.PB_DR_CLEAR_SEARCH.BackgroundImage = CType(resources.GetObject("PB_DR_CLEAR_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_DR_CLEAR_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_DR_CLEAR_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_DR_CLEAR_SEARCH.InitialImage = Nothing
        Me.PB_DR_CLEAR_SEARCH.Location = New System.Drawing.Point(1004, 10)
        Me.PB_DR_CLEAR_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_DR_CLEAR_SEARCH.Name = "PB_DR_CLEAR_SEARCH"
        Me.PB_DR_CLEAR_SEARCH.Size = New System.Drawing.Size(37, 34)
        Me.PB_DR_CLEAR_SEARCH.TabIndex = 1443
        Me.PB_DR_CLEAR_SEARCH.TabStop = False
        Me.PB_DR_CLEAR_SEARCH.Visible = False
        '
        'WTXT_INV_SEARCH
        '
        Me.WTXT_INV_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INV_SEARCH.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_INV_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.WTXT_INV_SEARCH.Location = New System.Drawing.Point(59, 15)
        Me.WTXT_INV_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_INV_SEARCH.MaxLength = 300
        Me.WTXT_INV_SEARCH.Name = "WTXT_INV_SEARCH"
        Me.WTXT_INV_SEARCH.Size = New System.Drawing.Size(941, 25)
        Me.WTXT_INV_SEARCH.TabIndex = 1442
        Me.WTXT_INV_SEARCH.Watermark = "Search Invoice No., Particulars, Company Name"
        '
        'DGV_INV_LIST
        '
        Me.DGV_INV_LIST.AllowUserToAddRows = False
        Me.DGV_INV_LIST.AllowUserToDeleteRows = False
        Me.DGV_INV_LIST.AllowUserToResizeRows = False
        Me.DGV_INV_LIST.AutoGenerateColumns = False
        Me.DGV_INV_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_INV_LIST.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_INV_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_INV_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_INV_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.INVIDDataGridViewTextBoxColumn, Me.INVNODataGridViewTextBoxColumn, Me.INVDATEDataGridViewTextBoxColumn, Me.INVDDESCRIPTIONDataGridViewTextBoxColumn, Me.INVDIRECTORYDataGridViewTextBoxColumn, Me.INVTOTALDataGridViewTextBoxColumn, Me.INVDIDDataGridViewTextBoxColumn, Me.INVDQTYDataGridViewTextBoxColumn, Me.INVDPRICEDataGridViewTextBoxColumn, Me.UNNODataGridViewTextBoxColumn, Me.UNDESCRIPTIONDataGridViewTextBoxColumn, Me.COMTINNUMBERDataGridViewTextBoxColumn, Me.COMCOMPANYNAMEDataGridViewTextBoxColumn, Me.COMADDRESSDataGridViewTextBoxColumn, Me.COMCONTACTNODataGridViewTextBoxColumn, Me.COMFAXNODataGridViewTextBoxColumn, Me.COMEMAILDataGridViewTextBoxColumn, Me.COMDIRECTORYDataGridViewTextBoxColumn, Me.COMSTATUSDataGridViewTextBoxColumn, Me.TOTALAMOUNTDataGridViewTextBoxColumn})
        Me.DGV_INV_LIST.DataSource = Me.VWG3INVOICELISTBindingSource
        Me.DGV_INV_LIST.Location = New System.Drawing.Point(5, 55)
        Me.DGV_INV_LIST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_INV_LIST.MultiSelect = False
        Me.DGV_INV_LIST.Name = "DGV_INV_LIST"
        Me.DGV_INV_LIST.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_INV_LIST.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_INV_LIST.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        Me.DGV_INV_LIST.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_INV_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_INV_LIST.Size = New System.Drawing.Size(1048, 277)
        Me.DGV_INV_LIST.TabIndex = 0
        '
        'INVIDDataGridViewTextBoxColumn
        '
        Me.INVIDDataGridViewTextBoxColumn.DataPropertyName = "INV_ID"
        Me.INVIDDataGridViewTextBoxColumn.HeaderText = "INV_ID"
        Me.INVIDDataGridViewTextBoxColumn.Name = "INVIDDataGridViewTextBoxColumn"
        Me.INVIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.INVIDDataGridViewTextBoxColumn.Visible = False
        '
        'INVNODataGridViewTextBoxColumn
        '
        Me.INVNODataGridViewTextBoxColumn.DataPropertyName = "INV_NO"
        Me.INVNODataGridViewTextBoxColumn.HeaderText = "Invoice No."
        Me.INVNODataGridViewTextBoxColumn.Name = "INVNODataGridViewTextBoxColumn"
        Me.INVNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'INVDATEDataGridViewTextBoxColumn
        '
        Me.INVDATEDataGridViewTextBoxColumn.DataPropertyName = "INV_DATE"
        Me.INVDATEDataGridViewTextBoxColumn.HeaderText = "Date Delivered"
        Me.INVDATEDataGridViewTextBoxColumn.Name = "INVDATEDataGridViewTextBoxColumn"
        Me.INVDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INVDDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.INVDDESCRIPTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.INVDDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "INVD_DESCRIPTION"
        Me.INVDDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.INVDDESCRIPTIONDataGridViewTextBoxColumn.Name = "INVDDESCRIPTIONDataGridViewTextBoxColumn"
        Me.INVDDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INVDIRECTORYDataGridViewTextBoxColumn
        '
        Me.INVDIRECTORYDataGridViewTextBoxColumn.DataPropertyName = "INV_DIRECTORY"
        Me.INVDIRECTORYDataGridViewTextBoxColumn.HeaderText = "INV_DIRECTORY"
        Me.INVDIRECTORYDataGridViewTextBoxColumn.Name = "INVDIRECTORYDataGridViewTextBoxColumn"
        Me.INVDIRECTORYDataGridViewTextBoxColumn.ReadOnly = True
        Me.INVDIRECTORYDataGridViewTextBoxColumn.Visible = False
        '
        'INVTOTALDataGridViewTextBoxColumn
        '
        Me.INVTOTALDataGridViewTextBoxColumn.DataPropertyName = "INV_TOTAL"
        Me.INVTOTALDataGridViewTextBoxColumn.HeaderText = "INV_TOTAL"
        Me.INVTOTALDataGridViewTextBoxColumn.Name = "INVTOTALDataGridViewTextBoxColumn"
        Me.INVTOTALDataGridViewTextBoxColumn.ReadOnly = True
        Me.INVTOTALDataGridViewTextBoxColumn.Visible = False
        '
        'INVDIDDataGridViewTextBoxColumn
        '
        Me.INVDIDDataGridViewTextBoxColumn.DataPropertyName = "INVD_ID"
        Me.INVDIDDataGridViewTextBoxColumn.HeaderText = "INVD_ID"
        Me.INVDIDDataGridViewTextBoxColumn.Name = "INVDIDDataGridViewTextBoxColumn"
        Me.INVDIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.INVDIDDataGridViewTextBoxColumn.Visible = False
        '
        'INVDQTYDataGridViewTextBoxColumn
        '
        Me.INVDQTYDataGridViewTextBoxColumn.DataPropertyName = "INVD_QTY"
        Me.INVDQTYDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.INVDQTYDataGridViewTextBoxColumn.Name = "INVDQTYDataGridViewTextBoxColumn"
        Me.INVDQTYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INVDPRICEDataGridViewTextBoxColumn
        '
        Me.INVDPRICEDataGridViewTextBoxColumn.DataPropertyName = "INVD_PRICE"
        Me.INVDPRICEDataGridViewTextBoxColumn.HeaderText = "INVD_PRICE"
        Me.INVDPRICEDataGridViewTextBoxColumn.Name = "INVDPRICEDataGridViewTextBoxColumn"
        Me.INVDPRICEDataGridViewTextBoxColumn.ReadOnly = True
        Me.INVDPRICEDataGridViewTextBoxColumn.Visible = False
        '
        'UNNODataGridViewTextBoxColumn
        '
        Me.UNNODataGridViewTextBoxColumn.DataPropertyName = "UN_NO"
        Me.UNNODataGridViewTextBoxColumn.HeaderText = "UN_NO"
        Me.UNNODataGridViewTextBoxColumn.Name = "UNNODataGridViewTextBoxColumn"
        Me.UNNODataGridViewTextBoxColumn.ReadOnly = True
        Me.UNNODataGridViewTextBoxColumn.Visible = False
        '
        'UNDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "UN_DESCRIPTION"
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Unit Type"
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.Name = "UNDESCRIPTIONDataGridViewTextBoxColumn"
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'COMTINNUMBERDataGridViewTextBoxColumn
        '
        Me.COMTINNUMBERDataGridViewTextBoxColumn.DataPropertyName = "COM_TIN_NUMBER"
        Me.COMTINNUMBERDataGridViewTextBoxColumn.HeaderText = "Tin No."
        Me.COMTINNUMBERDataGridViewTextBoxColumn.Name = "COMTINNUMBERDataGridViewTextBoxColumn"
        Me.COMTINNUMBERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'COMCOMPANYNAMEDataGridViewTextBoxColumn
        '
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.DataPropertyName = "COM_COMPANY_NAME"
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.HeaderText = "Company Name"
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.Name = "COMCOMPANYNAMEDataGridViewTextBoxColumn"
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.Width = 200
        '
        'COMADDRESSDataGridViewTextBoxColumn
        '
        Me.COMADDRESSDataGridViewTextBoxColumn.DataPropertyName = "COM_ADDRESS"
        Me.COMADDRESSDataGridViewTextBoxColumn.HeaderText = "COM_ADDRESS"
        Me.COMADDRESSDataGridViewTextBoxColumn.Name = "COMADDRESSDataGridViewTextBoxColumn"
        Me.COMADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        Me.COMADDRESSDataGridViewTextBoxColumn.Visible = False
        '
        'COMCONTACTNODataGridViewTextBoxColumn
        '
        Me.COMCONTACTNODataGridViewTextBoxColumn.DataPropertyName = "COM_CONTACT_NO"
        Me.COMCONTACTNODataGridViewTextBoxColumn.HeaderText = "COM_CONTACT_NO"
        Me.COMCONTACTNODataGridViewTextBoxColumn.Name = "COMCONTACTNODataGridViewTextBoxColumn"
        Me.COMCONTACTNODataGridViewTextBoxColumn.ReadOnly = True
        Me.COMCONTACTNODataGridViewTextBoxColumn.Visible = False
        '
        'COMFAXNODataGridViewTextBoxColumn
        '
        Me.COMFAXNODataGridViewTextBoxColumn.DataPropertyName = "COM_FAX_NO"
        Me.COMFAXNODataGridViewTextBoxColumn.HeaderText = "COM_FAX_NO"
        Me.COMFAXNODataGridViewTextBoxColumn.Name = "COMFAXNODataGridViewTextBoxColumn"
        Me.COMFAXNODataGridViewTextBoxColumn.ReadOnly = True
        Me.COMFAXNODataGridViewTextBoxColumn.Visible = False
        '
        'COMEMAILDataGridViewTextBoxColumn
        '
        Me.COMEMAILDataGridViewTextBoxColumn.DataPropertyName = "COM_EMAIL"
        Me.COMEMAILDataGridViewTextBoxColumn.HeaderText = "COM_EMAIL"
        Me.COMEMAILDataGridViewTextBoxColumn.Name = "COMEMAILDataGridViewTextBoxColumn"
        Me.COMEMAILDataGridViewTextBoxColumn.ReadOnly = True
        Me.COMEMAILDataGridViewTextBoxColumn.Visible = False
        '
        'COMDIRECTORYDataGridViewTextBoxColumn
        '
        Me.COMDIRECTORYDataGridViewTextBoxColumn.DataPropertyName = "COM_DIRECTORY"
        Me.COMDIRECTORYDataGridViewTextBoxColumn.HeaderText = "COM_DIRECTORY"
        Me.COMDIRECTORYDataGridViewTextBoxColumn.Name = "COMDIRECTORYDataGridViewTextBoxColumn"
        Me.COMDIRECTORYDataGridViewTextBoxColumn.ReadOnly = True
        Me.COMDIRECTORYDataGridViewTextBoxColumn.Visible = False
        '
        'COMSTATUSDataGridViewTextBoxColumn
        '
        Me.COMSTATUSDataGridViewTextBoxColumn.DataPropertyName = "COM_STATUS"
        Me.COMSTATUSDataGridViewTextBoxColumn.HeaderText = "COM_STATUS"
        Me.COMSTATUSDataGridViewTextBoxColumn.Name = "COMSTATUSDataGridViewTextBoxColumn"
        Me.COMSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.COMSTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'TOTALAMOUNTDataGridViewTextBoxColumn
        '
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_AMOUNT"
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.HeaderText = "TOTAL_AMOUNT"
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.Name = "TOTALAMOUNTDataGridViewTextBoxColumn"
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.Visible = False
        '
        'VWG3INVOICELISTBindingSource
        '
        Me.VWG3INVOICELISTBindingSource.DataMember = "VWG3_INVOICE_LIST"
        Me.VWG3INVOICELISTBindingSource.DataSource = Me.DS_VIEWS
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_ITEM_STOCK})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1056, 339)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RECT_ITEM_STOCK
        '
        Me.RECT_ITEM_STOCK.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ITEM_STOCK.BorderWidth = 2
        Me.RECT_ITEM_STOCK.CornerRadius = 19
        Me.RECT_ITEM_STOCK.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_ITEM_STOCK.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_ITEM_STOCK.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_ITEM_STOCK.Location = New System.Drawing.Point(4, 7)
        Me.RECT_ITEM_STOCK.Name = "RECT_ITEM_STOCK"
        Me.RECT_ITEM_STOCK.Size = New System.Drawing.Size(1049, 39)
        '
        'VWG3_INVOICE_LISTTableAdapter
        '
        Me.VWG3_INVOICE_LISTTableAdapter.ClearBeforeFill = True
        '
        'FRM_INV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 404)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_INV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_INV"
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_DR_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_INV_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWG3INVOICELISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableAdapterManager As DS_VIEWSTableAdapters.TableAdapterManager
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_INVENTORY_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PB_ITEM_STOCK_SEARCH As PictureBox
    Friend WithEvents PB_DR_CLEAR_SEARCH As PictureBox
    Friend WithEvents WTXT_INV_SEARCH As WatermarkTextBox
    Friend WithEvents DGV_INV_LIST As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_ITEM_STOCK As PowerPacks.RectangleShape
    Friend WithEvents VWG3INVOICELISTBindingSource As BindingSource
    Friend WithEvents VWG3_INVOICE_LISTTableAdapter As DS_VIEWSTableAdapters.VWG3_INVOICE_LISTTableAdapter
    Friend WithEvents INVIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVDDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVDIRECTORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVTOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVDIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVDQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVDPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMTINNUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMCOMPANYNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMCONTACTNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMFAXNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMEMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMDIRECTORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALAMOUNTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
