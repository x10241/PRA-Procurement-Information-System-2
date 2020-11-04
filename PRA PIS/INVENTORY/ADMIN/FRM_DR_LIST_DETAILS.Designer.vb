<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DR_LIST_DETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DR_LIST_DETAILS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INVENTORY_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PB_ITEM_STOCK_SEARCH = New System.Windows.Forms.PictureBox()
        Me.PB_DR_CLEAR_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_DR_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.DGV_STOCK_LIST = New System.Windows.Forms.DataGridView()
        Me.DRNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRDELIVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRRECEIVEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRDDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRDQUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRDSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMTINNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMCONTACTNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMFAXNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMEMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMDIRECTORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRDWARANTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VWG3_DR_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_ITEM_STOCK = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TableAdapterManager = New PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager()
        Me.VWG3_DR_LISTTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWG3_DR_LISTTableAdapter()
        Me.PNL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_DR_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_STOCK_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWG3_DR_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PNL.TabIndex = 1408
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
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(333, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "D e l i v e r y  R e c e i p t  D e t a i l s"
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
        Me.Panel1.Controls.Add(Me.WTXT_DR_SEARCH)
        Me.Panel1.Controls.Add(Me.DGV_STOCK_LIST)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(4, 55)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1058, 281)
        Me.Panel1.TabIndex = 1409
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
        'WTXT_DR_SEARCH
        '
        Me.WTXT_DR_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DR_SEARCH.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DR_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.WTXT_DR_SEARCH.Location = New System.Drawing.Point(59, 15)
        Me.WTXT_DR_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_DR_SEARCH.MaxLength = 300
        Me.WTXT_DR_SEARCH.Name = "WTXT_DR_SEARCH"
        Me.WTXT_DR_SEARCH.Size = New System.Drawing.Size(941, 25)
        Me.WTXT_DR_SEARCH.TabIndex = 1442
        Me.WTXT_DR_SEARCH.Watermark = "Search DR NO."
        '
        'DGV_STOCK_LIST
        '
        Me.DGV_STOCK_LIST.AllowUserToAddRows = False
        Me.DGV_STOCK_LIST.AllowUserToDeleteRows = False
        Me.DGV_STOCK_LIST.AllowUserToResizeColumns = False
        Me.DGV_STOCK_LIST.AllowUserToResizeRows = False
        Me.DGV_STOCK_LIST.AutoGenerateColumns = False
        Me.DGV_STOCK_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_STOCK_LIST.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_STOCK_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_STOCK_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_STOCK_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DRNODataGridViewTextBoxColumn, Me.DRDELIVERDataGridViewTextBoxColumn, Me.DRRECEIVEDBYDataGridViewTextBoxColumn, Me.DRSTATUSDataGridViewTextBoxColumn, Me.DRDIDDataGridViewTextBoxColumn, Me.DRDDESCRIPTIONDataGridViewTextBoxColumn, Me.DRDQUANTITYDataGridViewTextBoxColumn, Me.UNDESCRIPTIONDataGridViewTextBoxColumn, Me.DRDSTATUSDataGridViewTextBoxColumn, Me.COMTINNUMBERDataGridViewTextBoxColumn, Me.COMCOMPANYNAMEDataGridViewTextBoxColumn, Me.COMADDRESSDataGridViewTextBoxColumn, Me.COMCONTACTNODataGridViewTextBoxColumn, Me.COMFAXNODataGridViewTextBoxColumn, Me.COMEMAILDataGridViewTextBoxColumn, Me.COMDIRECTORYDataGridViewTextBoxColumn, Me.COMSTATUSDataGridViewTextBoxColumn, Me.UNNODataGridViewTextBoxColumn, Me.INVIDDataGridViewTextBoxColumn, Me.DRDWARANTYDataGridViewTextBoxColumn, Me.DRIDDataGridViewTextBoxColumn})
        Me.DGV_STOCK_LIST.DataSource = Me.VWG3_DR_LISTBindingSource
        Me.DGV_STOCK_LIST.Location = New System.Drawing.Point(5, 55)
        Me.DGV_STOCK_LIST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_STOCK_LIST.MultiSelect = False
        Me.DGV_STOCK_LIST.Name = "DGV_STOCK_LIST"
        Me.DGV_STOCK_LIST.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_STOCK_LIST.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_STOCK_LIST.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        Me.DGV_STOCK_LIST.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_STOCK_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_STOCK_LIST.Size = New System.Drawing.Size(1048, 222)
        Me.DGV_STOCK_LIST.TabIndex = 0
        '
        'DRNODataGridViewTextBoxColumn
        '
        Me.DRNODataGridViewTextBoxColumn.DataPropertyName = "DR_NO"
        Me.DRNODataGridViewTextBoxColumn.HeaderText = "DR No."
        Me.DRNODataGridViewTextBoxColumn.Name = "DRNODataGridViewTextBoxColumn"
        Me.DRNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'DRDELIVERDataGridViewTextBoxColumn
        '
        Me.DRDELIVERDataGridViewTextBoxColumn.DataPropertyName = "DR_DELIVER"
        Me.DRDELIVERDataGridViewTextBoxColumn.HeaderText = "Date Delivered"
        Me.DRDELIVERDataGridViewTextBoxColumn.Name = "DRDELIVERDataGridViewTextBoxColumn"
        Me.DRDELIVERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DRRECEIVEDBYDataGridViewTextBoxColumn
        '
        Me.DRRECEIVEDBYDataGridViewTextBoxColumn.DataPropertyName = "DR_RECEIVED_BY"
        Me.DRRECEIVEDBYDataGridViewTextBoxColumn.HeaderText = "DR_RECEIVED_BY"
        Me.DRRECEIVEDBYDataGridViewTextBoxColumn.Name = "DRRECEIVEDBYDataGridViewTextBoxColumn"
        Me.DRRECEIVEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.DRRECEIVEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'DRSTATUSDataGridViewTextBoxColumn
        '
        Me.DRSTATUSDataGridViewTextBoxColumn.DataPropertyName = "DR_STATUS"
        Me.DRSTATUSDataGridViewTextBoxColumn.HeaderText = "DR_STATUS"
        Me.DRSTATUSDataGridViewTextBoxColumn.Name = "DRSTATUSDataGridViewTextBoxColumn"
        Me.DRSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.DRSTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'DRDIDDataGridViewTextBoxColumn
        '
        Me.DRDIDDataGridViewTextBoxColumn.DataPropertyName = "DRD_ID"
        Me.DRDIDDataGridViewTextBoxColumn.HeaderText = "DRD_ID"
        Me.DRDIDDataGridViewTextBoxColumn.Name = "DRDIDDataGridViewTextBoxColumn"
        Me.DRDIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DRDIDDataGridViewTextBoxColumn.Visible = False
        '
        'DRDDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.DRDDESCRIPTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DRDDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DRD_DESCRIPTION"
        Me.DRDDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.DRDDESCRIPTIONDataGridViewTextBoxColumn.Name = "DRDDESCRIPTIONDataGridViewTextBoxColumn"
        Me.DRDDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DRDQUANTITYDataGridViewTextBoxColumn
        '
        Me.DRDQUANTITYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DRDQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "DRD_QUANTITY"
        Me.DRDQUANTITYDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.DRDQUANTITYDataGridViewTextBoxColumn.Name = "DRDQUANTITYDataGridViewTextBoxColumn"
        Me.DRDQUANTITYDataGridViewTextBoxColumn.ReadOnly = True
        Me.DRDQUANTITYDataGridViewTextBoxColumn.Width = 70
        '
        'UNDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "UN_DESCRIPTION"
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Unit Type"
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.Name = "UNDESCRIPTIONDataGridViewTextBoxColumn"
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.UNDESCRIPTIONDataGridViewTextBoxColumn.Width = 80
        '
        'DRDSTATUSDataGridViewTextBoxColumn
        '
        Me.DRDSTATUSDataGridViewTextBoxColumn.DataPropertyName = "DRD_STATUS"
        Me.DRDSTATUSDataGridViewTextBoxColumn.HeaderText = "DRD_STATUS"
        Me.DRDSTATUSDataGridViewTextBoxColumn.Name = "DRDSTATUSDataGridViewTextBoxColumn"
        Me.DRDSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.DRDSTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'COMTINNUMBERDataGridViewTextBoxColumn
        '
        Me.COMTINNUMBERDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.COMTINNUMBERDataGridViewTextBoxColumn.DataPropertyName = "COM_TIN_NUMBER"
        Me.COMTINNUMBERDataGridViewTextBoxColumn.HeaderText = "Tin No."
        Me.COMTINNUMBERDataGridViewTextBoxColumn.Name = "COMTINNUMBERDataGridViewTextBoxColumn"
        Me.COMTINNUMBERDataGridViewTextBoxColumn.ReadOnly = True
        Me.COMTINNUMBERDataGridViewTextBoxColumn.Width = 110
        '
        'COMCOMPANYNAMEDataGridViewTextBoxColumn
        '
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.DataPropertyName = "COM_COMPANY_NAME"
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.HeaderText = "Company Name"
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.Name = "COMCOMPANYNAMEDataGridViewTextBoxColumn"
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.COMCOMPANYNAMEDataGridViewTextBoxColumn.Width = 190
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
        'UNNODataGridViewTextBoxColumn
        '
        Me.UNNODataGridViewTextBoxColumn.DataPropertyName = "UN_NO"
        Me.UNNODataGridViewTextBoxColumn.HeaderText = "UN_NO"
        Me.UNNODataGridViewTextBoxColumn.Name = "UNNODataGridViewTextBoxColumn"
        Me.UNNODataGridViewTextBoxColumn.ReadOnly = True
        Me.UNNODataGridViewTextBoxColumn.Visible = False
        '
        'INVIDDataGridViewTextBoxColumn
        '
        Me.INVIDDataGridViewTextBoxColumn.DataPropertyName = "INV_ID"
        Me.INVIDDataGridViewTextBoxColumn.HeaderText = "INV_ID"
        Me.INVIDDataGridViewTextBoxColumn.Name = "INVIDDataGridViewTextBoxColumn"
        Me.INVIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.INVIDDataGridViewTextBoxColumn.Visible = False
        '
        'DRDWARANTYDataGridViewTextBoxColumn
        '
        Me.DRDWARANTYDataGridViewTextBoxColumn.DataPropertyName = "DRD_WARANTY"
        Me.DRDWARANTYDataGridViewTextBoxColumn.HeaderText = "DRD_WARANTY"
        Me.DRDWARANTYDataGridViewTextBoxColumn.Name = "DRDWARANTYDataGridViewTextBoxColumn"
        Me.DRDWARANTYDataGridViewTextBoxColumn.ReadOnly = True
        Me.DRDWARANTYDataGridViewTextBoxColumn.Visible = False
        '
        'DRIDDataGridViewTextBoxColumn
        '
        Me.DRIDDataGridViewTextBoxColumn.DataPropertyName = "DR_ID"
        Me.DRIDDataGridViewTextBoxColumn.HeaderText = "DR_ID"
        Me.DRIDDataGridViewTextBoxColumn.Name = "DRIDDataGridViewTextBoxColumn"
        Me.DRIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DRIDDataGridViewTextBoxColumn.Visible = False
        '
        'VWG3_DR_LISTBindingSource
        '
        Me.VWG3_DR_LISTBindingSource.DataMember = "VWG3_DR_LIST"
        Me.VWG3_DR_LISTBindingSource.DataSource = Me.DS_VIEWS
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_ITEM_STOCK})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1056, 279)
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VWG3_DR_LISTTableAdapter
        '
        Me.VWG3_DR_LISTTableAdapter.ClearBeforeFill = True
        '
        'FRM_DR_LIST_DETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 342)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_DR_LIST_DETAILS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_DR_LIST"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_DR_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_STOCK_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWG3_DR_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_INVENTORY_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PB_ITEM_STOCK_SEARCH As PictureBox
    Friend WithEvents PB_DR_CLEAR_SEARCH As PictureBox
    Friend WithEvents WTXT_DR_SEARCH As WatermarkTextBox
    Friend WithEvents DGV_STOCK_LIST As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_ITEM_STOCK As PowerPacks.RectangleShape
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents VWG3_DR_LISTBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_VIEWSTableAdapters.TableAdapterManager
    Friend WithEvents VWG3_DR_LISTTableAdapter As DS_VIEWSTableAdapters.VWG3_DR_LISTTableAdapter
    Friend WithEvents DRNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRDELIVERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRRECEIVEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRDIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRDDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRDQUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRDSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMTINNUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMCOMPANYNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMCONTACTNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMFAXNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMEMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMDIRECTORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INVIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRDWARANTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
