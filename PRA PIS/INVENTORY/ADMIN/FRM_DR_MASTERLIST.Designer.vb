<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DR_MASTERLIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DR_MASTERLIST))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SPM4_ITEM_DR_LISTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_DR_LISTTableAdapter()
        Me.LLBL_GEN_REP_DR_ML = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PB_GEN_REP_DR_ML = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_GEN_REP_DR_ML = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.SPM4_ITEM_DR_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CREATEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREATEDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMTOTALCOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMUNITCOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMUNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMQUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DRIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PB_ITEM_STOCK_SEARCH = New System.Windows.Forms.PictureBox()
        Me.PB_DR_CLEAR_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_DR_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.DGV_DR_ML = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GBOX_SETTINGS = New System.Windows.Forms.GroupBox()
        Me.LLBL_RECORDSFOUND = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_ITEM_STOCK = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_INVENTORY_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.TableAdapterManager = New PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager()
        Me.Panel2.SuspendLayout()
        CType(Me.PB_GEN_REP_DR_ML, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_DR_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_DR_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_DR_ML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GBOX_SETTINGS.SuspendLayout()
        Me.PNL.SuspendLayout()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPM4_ITEM_DR_LISTTableAdapter
        '
        Me.SPM4_ITEM_DR_LISTTableAdapter.ClearBeforeFill = True
        '
        'LLBL_GEN_REP_DR_ML
        '
        Me.LLBL_GEN_REP_DR_ML.AutoSize = True
        Me.LLBL_GEN_REP_DR_ML.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_GEN_REP_DR_ML.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_GEN_REP_DR_ML.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_GEN_REP_DR_ML.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_GEN_REP_DR_ML.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_GEN_REP_DR_ML.Location = New System.Drawing.Point(878, 19)
        Me.LLBL_GEN_REP_DR_ML.Name = "LLBL_GEN_REP_DR_ML"
        Me.LLBL_GEN_REP_DR_ML.Size = New System.Drawing.Size(158, 19)
        Me.LLBL_GEN_REP_DR_ML.TabIndex = 1461
        Me.LLBL_GEN_REP_DR_ML.TabStop = True
        Me.LLBL_GEN_REP_DR_ML.Text = "GENERATE REPORT"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LLBL_GEN_REP_DR_ML)
        Me.Panel2.Controls.Add(Me.PB_GEN_REP_DR_ML)
        Me.Panel2.Controls.Add(Me.ShapeContainer2)
        Me.Panel2.Location = New System.Drawing.Point(4, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1058, 55)
        Me.Panel2.TabIndex = 1415
        '
        'PB_GEN_REP_DR_ML
        '
        Me.PB_GEN_REP_DR_ML.BackgroundImage = CType(resources.GetObject("PB_GEN_REP_DR_ML.BackgroundImage"), System.Drawing.Image)
        Me.PB_GEN_REP_DR_ML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_GEN_REP_DR_ML.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_GEN_REP_DR_ML.InitialImage = Nothing
        Me.PB_GEN_REP_DR_ML.Location = New System.Drawing.Point(840, 12)
        Me.PB_GEN_REP_DR_ML.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_GEN_REP_DR_ML.Name = "PB_GEN_REP_DR_ML"
        Me.PB_GEN_REP_DR_ML.Size = New System.Drawing.Size(37, 34)
        Me.PB_GEN_REP_DR_ML.TabIndex = 1462
        Me.PB_GEN_REP_DR_ML.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_GEN_REP_DR_ML})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1058, 55)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_GEN_REP_DR_ML
        '
        Me.RECT_GEN_REP_DR_ML.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_GEN_REP_DR_ML.BorderWidth = 2
        Me.RECT_GEN_REP_DR_ML.CornerRadius = 19
        Me.RECT_GEN_REP_DR_ML.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_GEN_REP_DR_ML.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_GEN_REP_DR_ML.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_GEN_REP_DR_ML.Location = New System.Drawing.Point(824, 8)
        Me.RECT_GEN_REP_DR_ML.Name = "RECT_GEN_REP_DR_ML"
        Me.RECT_GEN_REP_DR_ML.Size = New System.Drawing.Size(221, 40)
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPM4_ITEM_DR_LISTBindingSource
        '
        Me.SPM4_ITEM_DR_LISTBindingSource.DataMember = "SPM4_ITEM_DR_LIST"
        Me.SPM4_ITEM_DR_LISTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'CREATEDBYDataGridViewTextBoxColumn
        '
        Me.CREATEDBYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CREATEDBYDataGridViewTextBoxColumn.DataPropertyName = "CREATED_BY"
        Me.CREATEDBYDataGridViewTextBoxColumn.HeaderText = "Encoded by"
        Me.CREATEDBYDataGridViewTextBoxColumn.Name = "CREATEDBYDataGridViewTextBoxColumn"
        Me.CREATEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.CREATEDBYDataGridViewTextBoxColumn.Width = 140
        '
        'CREATEDDATEDataGridViewTextBoxColumn
        '
        Me.CREATEDDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CREATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATED_DATE"
        Me.CREATEDDATEDataGridViewTextBoxColumn.HeaderText = "Date Created"
        Me.CREATEDDATEDataGridViewTextBoxColumn.Name = "CREATEDDATEDataGridViewTextBoxColumn"
        Me.CREATEDDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CREATEDDATEDataGridViewTextBoxColumn.Width = 80
        '
        'ITEMTOTALCOSTDataGridViewTextBoxColumn
        '
        Me.ITEMTOTALCOSTDataGridViewTextBoxColumn.DataPropertyName = "ITEM_TOTAL_COST"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ITEMTOTALCOSTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ITEMTOTALCOSTDataGridViewTextBoxColumn.HeaderText = "Total Cost"
        Me.ITEMTOTALCOSTDataGridViewTextBoxColumn.Name = "ITEMTOTALCOSTDataGridViewTextBoxColumn"
        Me.ITEMTOTALCOSTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMUNITCOSTDataGridViewTextBoxColumn
        '
        Me.ITEMUNITCOSTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEMUNITCOSTDataGridViewTextBoxColumn.DataPropertyName = "ITEM_UNIT_COST"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ITEMUNITCOSTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ITEMUNITCOSTDataGridViewTextBoxColumn.HeaderText = "Unit Cost"
        Me.ITEMUNITCOSTDataGridViewTextBoxColumn.Name = "ITEMUNITCOSTDataGridViewTextBoxColumn"
        Me.ITEMUNITCOSTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMUNITDataGridViewTextBoxColumn
        '
        Me.ITEMUNITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEMUNITDataGridViewTextBoxColumn.DataPropertyName = "ITEM_UNIT"
        Me.ITEMUNITDataGridViewTextBoxColumn.HeaderText = "Unit Type"
        Me.ITEMUNITDataGridViewTextBoxColumn.Name = "ITEMUNITDataGridViewTextBoxColumn"
        Me.ITEMUNITDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMUNITDataGridViewTextBoxColumn.Width = 70
        '
        'ITEMQUANTITYDataGridViewTextBoxColumn
        '
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "ITEM_QUANTITY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.Name = "ITEMQUANTITYDataGridViewTextBoxColumn"
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.Width = 70
        '
        'FULLDESCDataGridViewTextBoxColumn
        '
        Me.FULLDESCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FULLDESCDataGridViewTextBoxColumn.DataPropertyName = "FULLDESC"
        Me.FULLDESCDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.FULLDESCDataGridViewTextBoxColumn.Name = "FULLDESCDataGridViewTextBoxColumn"
        Me.FULLDESCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMCODEDataGridViewTextBoxColumn
        '
        Me.ITEMCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEMCODEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.HeaderText = "Item Code"
        Me.ITEMCODEDataGridViewTextBoxColumn.Name = "ITEMCODEDataGridViewTextBoxColumn"
        Me.ITEMCODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMCODEDataGridViewTextBoxColumn.Width = 140
        '
        'DRNODataGridViewTextBoxColumn
        '
        Me.DRNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DRNODataGridViewTextBoxColumn.DataPropertyName = "DR_NO"
        Me.DRNODataGridViewTextBoxColumn.HeaderText = "DR No."
        Me.DRNODataGridViewTextBoxColumn.Name = "DRNODataGridViewTextBoxColumn"
        Me.DRNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'DRIDDataGridViewTextBoxColumn
        '
        Me.DRIDDataGridViewTextBoxColumn.DataPropertyName = "DR_ID"
        Me.DRIDDataGridViewTextBoxColumn.HeaderText = "DR_ID"
        Me.DRIDDataGridViewTextBoxColumn.Name = "DRIDDataGridViewTextBoxColumn"
        Me.DRIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DRIDDataGridViewTextBoxColumn.Visible = False
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
        Me.WTXT_DR_SEARCH.Watermark = "Search Item Description, DR NO."
        '
        'DGV_DR_ML
        '
        Me.DGV_DR_ML.AllowUserToAddRows = False
        Me.DGV_DR_ML.AllowUserToDeleteRows = False
        Me.DGV_DR_ML.AllowUserToResizeColumns = False
        Me.DGV_DR_ML.AllowUserToResizeRows = False
        Me.DGV_DR_ML.AutoGenerateColumns = False
        Me.DGV_DR_ML.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_DR_ML.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_DR_ML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DR_ML.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DRIDDataGridViewTextBoxColumn, Me.DRNODataGridViewTextBoxColumn, Me.ITEMCODEDataGridViewTextBoxColumn, Me.FULLDESCDataGridViewTextBoxColumn, Me.ITEMQUANTITYDataGridViewTextBoxColumn, Me.ITEMUNITDataGridViewTextBoxColumn, Me.ITEMUNITCOSTDataGridViewTextBoxColumn, Me.ITEMTOTALCOSTDataGridViewTextBoxColumn, Me.CREATEDDATEDataGridViewTextBoxColumn, Me.CREATEDBYDataGridViewTextBoxColumn})
        Me.DGV_DR_ML.DataSource = Me.SPM4_ITEM_DR_LISTBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_DR_ML.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_DR_ML.Location = New System.Drawing.Point(5, 55)
        Me.DGV_DR_ML.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_DR_ML.MultiSelect = False
        Me.DGV_DR_ML.Name = "DGV_DR_ML"
        Me.DGV_DR_ML.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_DR_ML.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_DR_ML.RowHeadersVisible = False
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray
        Me.DGV_DR_ML.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_DR_ML.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_DR_ML.Size = New System.Drawing.Size(1048, 538)
        Me.DGV_DR_ML.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GBOX_SETTINGS)
        Me.Panel1.Controls.Add(Me.PB_ITEM_STOCK_SEARCH)
        Me.Panel1.Controls.Add(Me.PB_DR_CLEAR_SEARCH)
        Me.Panel1.Controls.Add(Me.WTXT_DR_SEARCH)
        Me.Panel1.Controls.Add(Me.DGV_DR_ML)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(4, 116)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1058, 668)
        Me.Panel1.TabIndex = 1414
        '
        'GBOX_SETTINGS
        '
        Me.GBOX_SETTINGS.Controls.Add(Me.LLBL_RECORDSFOUND)
        Me.GBOX_SETTINGS.Controls.Add(Me.LinkLabel1)
        Me.GBOX_SETTINGS.Location = New System.Drawing.Point(6, 596)
        Me.GBOX_SETTINGS.Name = "GBOX_SETTINGS"
        Me.GBOX_SETTINGS.Size = New System.Drawing.Size(313, 50)
        Me.GBOX_SETTINGS.TabIndex = 1444
        Me.GBOX_SETTINGS.TabStop = False
        '
        'LLBL_RECORDSFOUND
        '
        Me.LLBL_RECORDSFOUND.AutoSize = True
        Me.LLBL_RECORDSFOUND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_RECORDSFOUND.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_RECORDSFOUND.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_RECORDSFOUND.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_RECORDSFOUND.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_RECORDSFOUND.Location = New System.Drawing.Point(265, 19)
        Me.LLBL_RECORDSFOUND.Name = "LLBL_RECORDSFOUND"
        Me.LLBL_RECORDSFOUND.Size = New System.Drawing.Size(19, 19)
        Me.LLBL_RECORDSFOUND.TabIndex = 1441
        Me.LLBL_RECORDSFOUND.TabStop = True
        Me.LLBL_RECORDSFOUND.Text = "0"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.Location = New System.Drawing.Point(7, 19)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(238, 19)
        Me.LinkLabel1.TabIndex = 1440
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Total No. of Records Found :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_ITEM_STOCK})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1058, 668)
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
        'BTN_INVENTORY_CLOSE
        '
        Me.BTN_INVENTORY_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INVENTORY_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_CLOSE.Location = New System.Drawing.Point(1025, 12)
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
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(372, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "D e l i v e r y  R e c e i p t  M a s t e r l i s t"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-10386, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-10339, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
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
        Me.PNL.Size = New System.Drawing.Size(1066, 49)
        Me.PNL.TabIndex = 1413
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FRM_DR_MASTERLIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1066, 788)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_DR_MASTERLIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_DR_MASTERLIST"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PB_GEN_REP_DR_ML, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_DR_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_DR_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_DR_ML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GBOX_SETTINGS.ResumeLayout(False)
        Me.GBOX_SETTINGS.PerformLayout()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SPM4_ITEM_DR_LISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_DR_LISTTableAdapter
    Friend WithEvents LLBL_GEN_REP_DR_ML As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PB_GEN_REP_DR_ML As PictureBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_GEN_REP_DR_ML As PowerPacks.RectangleShape
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SPM4_ITEM_DR_LISTBindingSource As BindingSource
    Friend WithEvents CREATEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CREATEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMTOTALCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUNITCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUNITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMQUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FULLDESCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DRIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PB_ITEM_STOCK_SEARCH As PictureBox
    Friend WithEvents PB_DR_CLEAR_SEARCH As PictureBox
    Friend WithEvents WTXT_DR_SEARCH As WatermarkTextBox
    Friend WithEvents DGV_DR_ML As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_ITEM_STOCK As PowerPacks.RectangleShape
    Friend WithEvents BTN_INVENTORY_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL As Panel
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents TableAdapterManager As DS_VIEWSTableAdapters.TableAdapterManager
    Friend WithEvents GBOX_SETTINGS As GroupBox
    Friend WithEvents LLBL_RECORDSFOUND As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
