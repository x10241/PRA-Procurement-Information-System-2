<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_LOCATION_LIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LOCATION_LIST))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_SELECTION_CLOSE = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CMB_DEFLOCATION = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_LOCATION_LIST = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_CANCEL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_LIST_PREFERRED_ITEMS = New PRA_PIS.WatermarkTextBox()
        Me.DGV_LOCATION_LIST = New System.Windows.Forms.DataGridView()
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter()
        Me.SPM4ITEMSINLOCATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEMS_IN_LOCATIONTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEMS_IN_LOCATIONTableAdapter()
        Me.LocationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandProviderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_LOCATION_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4ITEMSINLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_SELECTION_CLOSE)
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(857, 42)
        Me.PNL.TabIndex = 1414
        '
        'BTN_SELECTION_CLOSE
        '
        Me.BTN_SELECTION_CLOSE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_SELECTION_CLOSE.BackgroundImage = CType(resources.GetObject("BTN_SELECTION_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_SELECTION_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_SELECTION_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SELECTION_CLOSE.Location = New System.Drawing.Point(824, 8)
        Me.BTN_SELECTION_CLOSE.Name = "BTN_SELECTION_CLOSE"
        Me.BTN_SELECTION_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_SELECTION_CLOSE.TabIndex = 17
        Me.BTN_SELECTION_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_SELECTION_CLOSE.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(12, 11)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(202, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "L O C A T I O N  L I S T "
        '
        'BTN_Minimize
        '
        Me.BTN_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Minimize.BackColor = System.Drawing.Color.DarkCyan
        Me.BTN_Minimize.BackgroundImage = CType(resources.GetObject("BTN_Minimize.BackgroundImage"), System.Drawing.Image)
        Me.BTN_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_Minimize.FlatAppearance.BorderSize = 3
        Me.BTN_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3648, 11)
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
        Me.BTN_CLOSE.BackgroundImage = CType(resources.GetObject("BTN_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3601, 10)
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
        Me.Panel1.Controls.Add(Me.CMB_DEFLOCATION)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BTN_LOCATION_LIST)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(2, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 58)
        Me.Panel1.TabIndex = 1471
        '
        'CMB_DEFLOCATION
        '
        Me.CMB_DEFLOCATION.DataSource = Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource
        Me.CMB_DEFLOCATION.DisplayMember = "LOC_NAME"
        Me.CMB_DEFLOCATION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_DEFLOCATION.Location = New System.Drawing.Point(16, 20)
        Me.CMB_DEFLOCATION.Name = "CMB_DEFLOCATION"
        Me.CMB_DEFLOCATION.Size = New System.Drawing.Size(204, 21)
        Me.CMB_DEFLOCATION.TabIndex = 0
        Me.CMB_DEFLOCATION.ValueMember = "LOC_LOCATION_ID"
        '
        'TblM4INVENTORYITEMSDEFLOCATIONBindingSource
        '
        Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource.DataMember = "tblM4_INVENTORY_ITEMS_DEFLOCATION"
        Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 1474
        Me.Label1.Text = "Location"
        '
        'BTN_LOCATION_LIST
        '
        Me.BTN_LOCATION_LIST.BackColor = System.Drawing.Color.White
        Me.BTN_LOCATION_LIST.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_LOCATION_LIST.FlatAppearance.BorderSize = 0
        Me.BTN_LOCATION_LIST.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_LOCATION_LIST.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_LOCATION_LIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_LOCATION_LIST.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_LOCATION_LIST.Image = CType(resources.GetObject("BTN_LOCATION_LIST.Image"), System.Drawing.Image)
        Me.BTN_LOCATION_LIST.Location = New System.Drawing.Point(712, 8)
        Me.BTN_LOCATION_LIST.Name = "BTN_LOCATION_LIST"
        Me.BTN_LOCATION_LIST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_LOCATION_LIST.Size = New System.Drawing.Size(128, 41)
        Me.BTN_LOCATION_LIST.TabIndex = 1472
        Me.BTN_LOCATION_LIST.Text = "GENERATE REPORT"
        Me.BTN_LOCATION_LIST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_LOCATION_LIST.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.AutoScroll = True
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RECT_INVENTORY_CANCEL})
        Me.ShapeContainer2.Size = New System.Drawing.Size(849, 56)
        Me.ShapeContainer2.TabIndex = 1470
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(13, 16)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(210, 28)
        '
        'RECT_INVENTORY_CANCEL
        '
        Me.RECT_INVENTORY_CANCEL.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_CANCEL.BorderWidth = 2
        Me.RECT_INVENTORY_CANCEL.CornerRadius = 5
        Me.RECT_INVENTORY_CANCEL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_CANCEL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_CANCEL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_CANCEL.Location = New System.Drawing.Point(710, 6)
        Me.RECT_INVENTORY_CANCEL.Name = "RECT_INVENTORY_CANCEL"
        Me.RECT_INVENTORY_CANCEL.Size = New System.Drawing.Size(131, 44)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.Panel2.Controls.Add(Me.WTXT_LIST_PREFERRED_ITEMS)
        Me.Panel2.Controls.Add(Me.DGV_LOCATION_LIST)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(2, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(851, 412)
        Me.Panel2.TabIndex = 1472
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(806, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox1.TabIndex = 1477
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PB_INVENTORY_SEARCH
        '
        Me.PB_INVENTORY_SEARCH.BackgroundImage = CType(resources.GetObject("PB_INVENTORY_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_INVENTORY_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_SEARCH.Location = New System.Drawing.Point(11, 8)
        Me.PB_INVENTORY_SEARCH.Name = "PB_INVENTORY_SEARCH"
        Me.PB_INVENTORY_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_SEARCH.TabIndex = 1468
        Me.PB_INVENTORY_SEARCH.TabStop = False
        '
        'WTXT_LIST_PREFERRED_ITEMS
        '
        Me.WTXT_LIST_PREFERRED_ITEMS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_LIST_PREFERRED_ITEMS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_LIST_PREFERRED_ITEMS.ForeColor = System.Drawing.Color.Black
        Me.WTXT_LIST_PREFERRED_ITEMS.Location = New System.Drawing.Point(46, 12)
        Me.WTXT_LIST_PREFERRED_ITEMS.MaxLength = 15
        Me.WTXT_LIST_PREFERRED_ITEMS.Name = "WTXT_LIST_PREFERRED_ITEMS"
        Me.WTXT_LIST_PREFERRED_ITEMS.Size = New System.Drawing.Size(749, 20)
        Me.WTXT_LIST_PREFERRED_ITEMS.TabIndex = 1467
        Me.WTXT_LIST_PREFERRED_ITEMS.Watermark = "Search Item Code, Category, Sub Category, Brand/Provider, Serial No., Item Descri" &
    "ption"
        '
        'DGV_LOCATION_LIST
        '
        Me.DGV_LOCATION_LIST.AllowUserToAddRows = False
        Me.DGV_LOCATION_LIST.AllowUserToDeleteRows = False
        Me.DGV_LOCATION_LIST.AllowUserToResizeColumns = False
        Me.DGV_LOCATION_LIST.AllowUserToResizeRows = False
        Me.DGV_LOCATION_LIST.AutoGenerateColumns = False
        Me.DGV_LOCATION_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_LOCATION_LIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_LOCATION_LIST.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_LOCATION_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_LOCATION_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_LOCATION_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocationNameDataGridViewTextBoxColumn, Me.ItemCodeDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.SubCategoryDataGridViewTextBoxColumn, Me.BrandProviderDataGridViewTextBoxColumn, Me.SerialNoDataGridViewTextBoxColumn, Me.ItemDescriptionDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1})
        Me.DGV_LOCATION_LIST.DataSource = Me.SPM4ITEMSINLOCATIONBindingSource
        Me.DGV_LOCATION_LIST.Location = New System.Drawing.Point(3, 43)
        Me.DGV_LOCATION_LIST.Name = "DGV_LOCATION_LIST"
        Me.DGV_LOCATION_LIST.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_LOCATION_LIST.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_LOCATION_LIST.RowHeadersVisible = False
        Me.DGV_LOCATION_LIST.Size = New System.Drawing.Size(843, 364)
        Me.DGV_LOCATION_LIST.TabIndex = 0
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRCANCELEDIT})
        Me.ShapeContainer1.Size = New System.Drawing.Size(849, 410)
        Me.ShapeContainer1.TabIndex = 1468
        Me.ShapeContainer1.TabStop = False
        '
        'RECT_PRCANCELEDIT
        '
        Me.RECT_PRCANCELEDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRCANCELEDIT.CornerRadius = 5
        Me.RECT_PRCANCELEDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRCANCELEDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRCANCELEDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(3, 5)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(841, 33)
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_SUB_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CANCELEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_POSTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_PROVIDERTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_REVISIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUESTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter.ClearBeforeFill = True
        '
        'SPM4ITEMSINLOCATIONBindingSource
        '
        Me.SPM4ITEMSINLOCATIONBindingSource.DataMember = "SPM4_ITEMS_IN_LOCATION"
        Me.SPM4ITEMSINLOCATIONBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_ITEMS_IN_LOCATIONTableAdapter
        '
        Me.SPM4_ITEMS_IN_LOCATIONTableAdapter.ClearBeforeFill = True
        '
        'LocationNameDataGridViewTextBoxColumn
        '
        Me.LocationNameDataGridViewTextBoxColumn.DataPropertyName = "Location Name"
        Me.LocationNameDataGridViewTextBoxColumn.HeaderText = "Location Name"
        Me.LocationNameDataGridViewTextBoxColumn.Name = "LocationNameDataGridViewTextBoxColumn"
        Me.LocationNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "Item Code"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "Item Code"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        Me.ItemCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubCategoryDataGridViewTextBoxColumn
        '
        Me.SubCategoryDataGridViewTextBoxColumn.DataPropertyName = "Sub Category"
        Me.SubCategoryDataGridViewTextBoxColumn.HeaderText = "Sub Category"
        Me.SubCategoryDataGridViewTextBoxColumn.Name = "SubCategoryDataGridViewTextBoxColumn"
        Me.SubCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BrandProviderDataGridViewTextBoxColumn
        '
        Me.BrandProviderDataGridViewTextBoxColumn.DataPropertyName = "Brand/Provider"
        Me.BrandProviderDataGridViewTextBoxColumn.HeaderText = "Brand/Provider"
        Me.BrandProviderDataGridViewTextBoxColumn.Name = "BrandProviderDataGridViewTextBoxColumn"
        Me.BrandProviderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerialNoDataGridViewTextBoxColumn
        '
        Me.SerialNoDataGridViewTextBoxColumn.DataPropertyName = "Serial No_"
        Me.SerialNoDataGridViewTextBoxColumn.HeaderText = "Serial No."
        Me.SerialNoDataGridViewTextBoxColumn.Name = "SerialNoDataGridViewTextBoxColumn"
        Me.SerialNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDescriptionDataGridViewTextBoxColumn
        '
        Me.ItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Item Description"
        Me.ItemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.ItemDescriptionDataGridViewTextBoxColumn.Name = "ItemDescriptionDataGridViewTextBoxColumn"
        Me.ItemDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Acquisition Amount"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Acquisition Amount"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FRM_LOCATION_LIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(857, 518)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_LOCATION_LIST"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_LOCATION_LIST"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_LOCATION_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4ITEMSINLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_SELECTION_CLOSE As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_LOCATION_LIST As Button
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_INVENTORY_CANCEL As PowerPacks.RectangleShape
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV_LOCATION_LIST As DataGridView
    Friend WithEvents WTXT_LIST_PREFERRED_ITEMS As WatermarkTextBox
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LOCNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PropertyNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents Label1 As Label
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    ' Friend WithEvents TblM4_ITEMS_DEFLOCATIONBindingSource As BindingSource
    'Friend WithEvents TblM4_ITEMS_DEFLOCATIONTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_ITEMS_DEFLOCATIONTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents CMB_DEFLOCATION As ComboBox
    Friend WithEvents TblM4INVENTORYITEMSDEFLOCATIONBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter
    Friend WithEvents AcquisitionAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandProviderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerialNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SPM4ITEMSINLOCATIONBindingSource As BindingSource
    Friend WithEvents SPM4_ITEMS_IN_LOCATIONTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEMS_IN_LOCATIONTableAdapter
End Class
