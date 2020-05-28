<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_LOCATION
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_SELECTION_CLOSE = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.LLBL_INVENTORY_VIEW_REPORT = New System.Windows.Forms.LinkLabel()
        Me.DGV_ITEMS_LIST = New System.Windows.Forms.DataGridView()
        Me.SPM4ITEMSLOCATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.DGV_ITEMS_LOCATION = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignItemsLocationDataGridViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_CUSTOM = New PRA_PIS.DS_CUSTOM()
        Me.SPM4ITEMSINLOCATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_CANCEL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_ALL_PLUS = New System.Windows.Forms.Button()
        Me.BTN_ONE_PLUS = New System.Windows.Forms.Button()
        Me.BTN_ONE_MINUS = New System.Windows.Forms.Button()
        Me.BTN_ALL_MINUS = New System.Windows.Forms.Button()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_LIST_PREFERRED_ITEMS = New PRA_PIS.WatermarkTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WTXT_LIST_ITEM_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_ASSIGN_ITEM_LOCATION = New System.Windows.Forms.Button()
        Me.BTN_LOCATION_LIST = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CB_LOC_DEFAULT_LOC = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.BTN_LOC_DONE = New System.Windows.Forms.Button()
        Me.PNL_LOCATION_MAIN = New System.Windows.Forms.Panel()
        Me.CHK_SHOW_ALL_ITEMS = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SpM4_ITEMS_LOCATIONTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEMS_LOCATIONTableAdapter()
        Me.TblM4ITEMSDEFLOCATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4ITEMSLOCATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4INVENTORYDGVLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TblM4ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_INVENTORYDGVLISTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_INVENTORYDGVLISTTableAdapter()
        Me.SpM4_ITEMS_IN_LOCATIONTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEMS_IN_LOCATIONTableAdapter()
        Me.TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter()
        Me.TblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter()
        Me.ItemsLocationDataGridViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNL.SuspendLayout()
        CType(Me.DGV_ITEMS_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4ITEMSLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ITEMS_LOCATION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignItemsLocationDataGridViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4ITEMSINLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_LOCATION_MAIN.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4ITEMSDEFLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4ITEMSLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4INVENTORYDGVLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsLocationDataGridViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PNL.Size = New System.Drawing.Size(1107, 42)
        Me.PNL.TabIndex = 1413
        '
        'BTN_SELECTION_CLOSE
        '
        Me.BTN_SELECTION_CLOSE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_SELECTION_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_SELECTION_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_SELECTION_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SELECTION_CLOSE.Location = New System.Drawing.Point(1074, 8)
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
        Me.Label39.Size = New System.Drawing.Size(141, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "L O C A T I O N"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3398, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3351, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'LLBL_INVENTORY_VIEW_REPORT
        '
        Me.LLBL_INVENTORY_VIEW_REPORT.AutoSize = True
        Me.LLBL_INVENTORY_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENTORY_VIEW_REPORT.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_INVENTORY_VIEW_REPORT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_VIEW_REPORT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENTORY_VIEW_REPORT.LinkColor = System.Drawing.Color.Black
        Me.LLBL_INVENTORY_VIEW_REPORT.Location = New System.Drawing.Point(13, 11)
        Me.LLBL_INVENTORY_VIEW_REPORT.Name = "LLBL_INVENTORY_VIEW_REPORT"
        Me.LLBL_INVENTORY_VIEW_REPORT.Size = New System.Drawing.Size(76, 18)
        Me.LLBL_INVENTORY_VIEW_REPORT.TabIndex = 1454
        Me.LLBL_INVENTORY_VIEW_REPORT.TabStop = True
        Me.LLBL_INVENTORY_VIEW_REPORT.Text = "Location:"
        '
        'DGV_ITEMS_LIST
        '
        Me.DGV_ITEMS_LIST.AllowUserToAddRows = False
        Me.DGV_ITEMS_LIST.AllowUserToDeleteRows = False
        Me.DGV_ITEMS_LIST.AllowUserToResizeColumns = False
        Me.DGV_ITEMS_LIST.AllowUserToResizeRows = False
        Me.DGV_ITEMS_LIST.AutoGenerateColumns = False
        Me.DGV_ITEMS_LIST.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ITEMS_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ITEMS_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEMS_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.SubCategoryDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.SerialNoDataGridViewTextBoxColumn, Me.ItemDescriptionDataGridViewTextBoxColumn})
        Me.DGV_ITEMS_LIST.DataSource = Me.ItemsLocationDataGridViewBindingSource
        Me.DGV_ITEMS_LIST.Location = New System.Drawing.Point(10, 96)
        Me.DGV_ITEMS_LIST.Name = "DGV_ITEMS_LIST"
        Me.DGV_ITEMS_LIST.ReadOnly = True
        Me.DGV_ITEMS_LIST.RowHeadersVisible = False
        Me.DGV_ITEMS_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEMS_LIST.Size = New System.Drawing.Size(498, 408)
        Me.DGV_ITEMS_LIST.TabIndex = 1456
        '
        'SPM4ITEMSLOCATIONBindingSource
        '
        Me.SPM4ITEMSLOCATIONBindingSource.DataMember = "SPM4_ITEMS_LOCATION"
        Me.SPM4ITEMSLOCATIONBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGV_ITEMS_LOCATION
        '
        Me.DGV_ITEMS_LOCATION.AllowUserToAddRows = False
        Me.DGV_ITEMS_LOCATION.AllowUserToDeleteRows = False
        Me.DGV_ITEMS_LOCATION.AllowUserToResizeColumns = False
        Me.DGV_ITEMS_LOCATION.AllowUserToResizeRows = False
        Me.DGV_ITEMS_LOCATION.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ITEMS_LOCATION.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ITEMS_LOCATION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEMS_LOCATION.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.Category, Me.SubCategory, Me.Brand, Me.Serial, Me.ItemDescription})
        Me.DGV_ITEMS_LOCATION.Location = New System.Drawing.Point(580, 96)
        Me.DGV_ITEMS_LOCATION.Name = "DGV_ITEMS_LOCATION"
        Me.DGV_ITEMS_LOCATION.ReadOnly = True
        Me.DGV_ITEMS_LOCATION.RowHeadersVisible = False
        Me.DGV_ITEMS_LOCATION.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEMS_LOCATION.Size = New System.Drawing.Size(516, 408)
        Me.DGV_ITEMS_LOCATION.TabIndex = 1458
        '
        'ItemCode
        '
        Me.ItemCode.DataPropertyName = "ItemCode"
        Me.ItemCode.HeaderText = "Item Code"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        '
        'Category
        '
        Me.Category.DataPropertyName = "Category"
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'SubCategory
        '
        Me.SubCategory.DataPropertyName = "SubCategory"
        Me.SubCategory.HeaderText = "Sub Category"
        Me.SubCategory.Name = "SubCategory"
        Me.SubCategory.ReadOnly = True
        '
        'Brand
        '
        Me.Brand.DataPropertyName = "Brand"
        Me.Brand.HeaderText = "Brand/Provider"
        Me.Brand.Name = "Brand"
        Me.Brand.ReadOnly = True
        '
        'Serial
        '
        Me.Serial.DataPropertyName = "SerialNo"
        Me.Serial.HeaderText = "Serial No."
        Me.Serial.Name = "Serial"
        Me.Serial.ReadOnly = True
        '
        'ItemDescription
        '
        Me.ItemDescription.DataPropertyName = "ItemDescription"
        Me.ItemDescription.HeaderText = "Item Description"
        Me.ItemDescription.Name = "ItemDescription"
        Me.ItemDescription.ReadOnly = True
        '
        'AssignItemsLocationDataGridViewBindingSource
        '
        Me.AssignItemsLocationDataGridViewBindingSource.DataMember = "AssignItemsLocationDataGridView"
        Me.AssignItemsLocationDataGridViewBindingSource.DataSource = Me.DS_CUSTOM
        '
        'DS_CUSTOM
        '
        Me.DS_CUSTOM.DataSetName = "DS_CUSTOM"
        Me.DS_CUSTOM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPM4ITEMSINLOCATIONBindingSource
        '
        Me.SPM4ITEMSINLOCATIONBindingSource.DataMember = "SPM4_ITEMS_IN_LOCATION"
        Me.SPM4ITEMSINLOCATIONBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape4.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape4.Location = New System.Drawing.Point(1002, 508)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(86, 45)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(92, 5)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(298, 29)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(580, 59)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(513, 33)
        '
        'RECT_PRCANCELEDIT
        '
        Me.RECT_PRCANCELEDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRCANCELEDIT.CornerRadius = 5
        Me.RECT_PRCANCELEDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRCANCELEDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRCANCELEDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(10, 59)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(497, 33)
        '
        'RECT_INVENTORY_CANCEL
        '
        Me.RECT_INVENTORY_CANCEL.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_CANCEL.BorderWidth = 2
        Me.RECT_INVENTORY_CANCEL.CornerRadius = 5
        Me.RECT_INVENTORY_CANCEL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_CANCEL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_CANCEL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_CANCEL.Location = New System.Drawing.Point(170, 6)
        Me.RECT_INVENTORY_CANCEL.Name = "RECT_INVENTORY_CANCEL"
        Me.RECT_INVENTORY_CANCEL.Size = New System.Drawing.Size(131, 44)
        '
        'BTN_ALL_PLUS
        '
        Me.BTN_ALL_PLUS.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_ALL_PLUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BTN_ALL_PLUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ALL_PLUS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ALL_PLUS.Location = New System.Drawing.Point(521, 195)
        Me.BTN_ALL_PLUS.Name = "BTN_ALL_PLUS"
        Me.BTN_ALL_PLUS.Size = New System.Drawing.Size(46, 39)
        Me.BTN_ALL_PLUS.TabIndex = 1460
        Me.BTN_ALL_PLUS.Text = ">>"
        Me.BTN_ALL_PLUS.UseVisualStyleBackColor = True
        '
        'BTN_ONE_PLUS
        '
        Me.BTN_ONE_PLUS.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_ONE_PLUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BTN_ONE_PLUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ONE_PLUS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ONE_PLUS.Location = New System.Drawing.Point(521, 240)
        Me.BTN_ONE_PLUS.Name = "BTN_ONE_PLUS"
        Me.BTN_ONE_PLUS.Size = New System.Drawing.Size(46, 39)
        Me.BTN_ONE_PLUS.TabIndex = 1461
        Me.BTN_ONE_PLUS.Text = ">"
        Me.BTN_ONE_PLUS.UseVisualStyleBackColor = True
        '
        'BTN_ONE_MINUS
        '
        Me.BTN_ONE_MINUS.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_ONE_MINUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BTN_ONE_MINUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ONE_MINUS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ONE_MINUS.Location = New System.Drawing.Point(521, 285)
        Me.BTN_ONE_MINUS.Name = "BTN_ONE_MINUS"
        Me.BTN_ONE_MINUS.Size = New System.Drawing.Size(46, 39)
        Me.BTN_ONE_MINUS.TabIndex = 1462
        Me.BTN_ONE_MINUS.Text = "<"
        Me.BTN_ONE_MINUS.UseVisualStyleBackColor = True
        '
        'BTN_ALL_MINUS
        '
        Me.BTN_ALL_MINUS.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_ALL_MINUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BTN_ALL_MINUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ALL_MINUS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ALL_MINUS.Location = New System.Drawing.Point(521, 330)
        Me.BTN_ALL_MINUS.Name = "BTN_ALL_MINUS"
        Me.BTN_ALL_MINUS.Size = New System.Drawing.Size(46, 39)
        Me.BTN_ALL_MINUS.TabIndex = 1463
        Me.BTN_ALL_MINUS.Text = "<<"
        Me.BTN_ALL_MINUS.UseVisualStyleBackColor = True
        '
        'PB_INVENTORY_SEARCH
        '
        Me.PB_INVENTORY_SEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PB_INVENTORY_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_SEARCH.Location = New System.Drawing.Point(15, 62)
        Me.PB_INVENTORY_SEARCH.Name = "PB_INVENTORY_SEARCH"
        Me.PB_INVENTORY_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_SEARCH.TabIndex = 1465
        Me.PB_INVENTORY_SEARCH.TabStop = False
        '
        'WTXT_LIST_PREFERRED_ITEMS
        '
        Me.WTXT_LIST_PREFERRED_ITEMS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_LIST_PREFERRED_ITEMS.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.WTXT_LIST_PREFERRED_ITEMS.ForeColor = System.Drawing.Color.Black
        Me.WTXT_LIST_PREFERRED_ITEMS.Location = New System.Drawing.Point(621, 64)
        Me.WTXT_LIST_PREFERRED_ITEMS.MaxLength = 15
        Me.WTXT_LIST_PREFERRED_ITEMS.Name = "WTXT_LIST_PREFERRED_ITEMS"
        Me.WTXT_LIST_PREFERRED_ITEMS.Size = New System.Drawing.Size(432, 24)
        Me.WTXT_LIST_PREFERRED_ITEMS.TabIndex = 1466
        Me.WTXT_LIST_PREFERRED_ITEMS.Watermark = "Search Item Code, Serial No., Item Description"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(585, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox2.TabIndex = 1467
        Me.PictureBox2.TabStop = False
        '
        'WTXT_LIST_ITEM_SEARCH
        '
        Me.WTXT_LIST_ITEM_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_LIST_ITEM_SEARCH.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.WTXT_LIST_ITEM_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.WTXT_LIST_ITEM_SEARCH.Location = New System.Drawing.Point(50, 64)
        Me.WTXT_LIST_ITEM_SEARCH.MaxLength = 15
        Me.WTXT_LIST_ITEM_SEARCH.Name = "WTXT_LIST_ITEM_SEARCH"
        Me.WTXT_LIST_ITEM_SEARCH.Size = New System.Drawing.Size(417, 24)
        Me.WTXT_LIST_ITEM_SEARCH.TabIndex = 1468
        Me.WTXT_LIST_ITEM_SEARCH.Watermark = "Search Item Code, Serial No., Item Description"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BTN_ASSIGN_ITEM_LOCATION)
        Me.Panel1.Controls.Add(Me.BTN_LOCATION_LIST)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(3, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1101, 58)
        Me.Panel1.TabIndex = 1470
        '
        'BTN_ASSIGN_ITEM_LOCATION
        '
        Me.BTN_ASSIGN_ITEM_LOCATION.BackColor = System.Drawing.Color.White
        Me.BTN_ASSIGN_ITEM_LOCATION.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ASSIGN_ITEM_LOCATION.FlatAppearance.BorderSize = 0
        Me.BTN_ASSIGN_ITEM_LOCATION.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ASSIGN_ITEM_LOCATION.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ASSIGN_ITEM_LOCATION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ASSIGN_ITEM_LOCATION.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ASSIGN_ITEM_LOCATION.Image = Global.PRA_PIS.My.Resources.Resources.outline_event_note_black_18dp
        Me.BTN_ASSIGN_ITEM_LOCATION.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BTN_ASSIGN_ITEM_LOCATION.Location = New System.Drawing.Point(19, 8)
        Me.BTN_ASSIGN_ITEM_LOCATION.Name = "BTN_ASSIGN_ITEM_LOCATION"
        Me.BTN_ASSIGN_ITEM_LOCATION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ASSIGN_ITEM_LOCATION.Size = New System.Drawing.Size(146, 41)
        Me.BTN_ASSIGN_ITEM_LOCATION.TabIndex = 1475
        Me.BTN_ASSIGN_ITEM_LOCATION.Text = "ASSIGN ITEM'S LOCATION"
        Me.BTN_ASSIGN_ITEM_LOCATION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ASSIGN_ITEM_LOCATION.UseVisualStyleBackColor = False
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
        Me.BTN_LOCATION_LIST.Image = Global.PRA_PIS.My.Resources.Resources.outline_list_alt_black_18dp
        Me.BTN_LOCATION_LIST.Location = New System.Drawing.Point(172, 8)
        Me.BTN_LOCATION_LIST.Name = "BTN_LOCATION_LIST"
        Me.BTN_LOCATION_LIST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_LOCATION_LIST.Size = New System.Drawing.Size(128, 41)
        Me.BTN_LOCATION_LIST.TabIndex = 1472
        Me.BTN_LOCATION_LIST.Text = "LOCATION LIST"
        Me.BTN_LOCATION_LIST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_LOCATION_LIST.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape6, Me.RECT_INVENTORY_CANCEL})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1099, 56)
        Me.ShapeContainer2.TabIndex = 1470
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.CornerRadius = 5
        Me.RectangleShape6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape6.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape6.Location = New System.Drawing.Point(17, 6)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(149, 44)
        '
        'CB_LOC_DEFAULT_LOC
        '
        Me.CB_LOC_DEFAULT_LOC.DataSource = Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource
        Me.CB_LOC_DEFAULT_LOC.DisplayMember = "LOC_NAME"
        Me.CB_LOC_DEFAULT_LOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_LOC_DEFAULT_LOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_LOC_DEFAULT_LOC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_LOC_DEFAULT_LOC.FormattingEnabled = True
        Me.CB_LOC_DEFAULT_LOC.Location = New System.Drawing.Point(96, 8)
        Me.CB_LOC_DEFAULT_LOC.Name = "CB_LOC_DEFAULT_LOC"
        Me.CB_LOC_DEFAULT_LOC.Size = New System.Drawing.Size(291, 24)
        Me.CB_LOC_DEFAULT_LOC.TabIndex = 0
        Me.CB_LOC_DEFAULT_LOC.ValueMember = "LOC_LOCATION_ID"
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
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(13, 32)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 18)
        Me.LinkLabel1.TabIndex = 1471
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Item List:"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel2.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(582, 32)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(210, 18)
        Me.LinkLabel2.TabIndex = 1472
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Preferred items in Location :"
        '
        'BTN_LOC_DONE
        '
        Me.BTN_LOC_DONE.BackColor = System.Drawing.Color.White
        Me.BTN_LOC_DONE.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_LOC_DONE.FlatAppearance.BorderSize = 0
        Me.BTN_LOC_DONE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_LOC_DONE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_LOC_DONE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_LOC_DONE.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LOC_DONE.Image = Global.PRA_PIS.My.Resources.Resources.outline_assignment_turned_in_black_18dp
        Me.BTN_LOC_DONE.Location = New System.Drawing.Point(1004, 510)
        Me.BTN_LOC_DONE.Name = "BTN_LOC_DONE"
        Me.BTN_LOC_DONE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_LOC_DONE.Size = New System.Drawing.Size(83, 42)
        Me.BTN_LOC_DONE.TabIndex = 1474
        Me.BTN_LOC_DONE.Text = "SAVE"
        Me.BTN_LOC_DONE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_LOC_DONE.UseVisualStyleBackColor = False
        '
        'PNL_LOCATION_MAIN
        '
        Me.PNL_LOCATION_MAIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.CHK_SHOW_ALL_ITEMS)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.PictureBox3)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.PictureBox1)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.BTN_LOC_DONE)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.LinkLabel2)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.PictureBox2)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.WTXT_LIST_ITEM_SEARCH)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.DGV_ITEMS_LOCATION)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.BTN_ALL_PLUS)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.BTN_ONE_PLUS)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.BTN_ONE_MINUS)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.BTN_ALL_MINUS)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.CB_LOC_DEFAULT_LOC)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.DGV_ITEMS_LIST)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.LLBL_INVENTORY_VIEW_REPORT)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.LinkLabel1)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.WTXT_LIST_PREFERRED_ITEMS)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.PNL_LOCATION_MAIN.Controls.Add(Me.ShapeContainer3)
        Me.PNL_LOCATION_MAIN.Enabled = False
        Me.PNL_LOCATION_MAIN.Location = New System.Drawing.Point(3, 104)
        Me.PNL_LOCATION_MAIN.Name = "PNL_LOCATION_MAIN"
        Me.PNL_LOCATION_MAIN.Size = New System.Drawing.Size(1101, 559)
        Me.PNL_LOCATION_MAIN.TabIndex = 1475
        '
        'CHK_SHOW_ALL_ITEMS
        '
        Me.CHK_SHOW_ALL_ITEMS.AutoSize = True
        Me.CHK_SHOW_ALL_ITEMS.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SHOW_ALL_ITEMS.Location = New System.Drawing.Point(12, 510)
        Me.CHK_SHOW_ALL_ITEMS.Name = "CHK_SHOW_ALL_ITEMS"
        Me.CHK_SHOW_ALL_ITEMS.Size = New System.Drawing.Size(116, 20)
        Me.CHK_SHOW_ALL_ITEMS.TabIndex = 1478
        Me.CHK_SHOW_ALL_ITEMS.Text = "Show all items"
        Me.CHK_SHOW_ALL_ITEMS.UseVisualStyleBackColor = True
        Me.CHK_SHOW_ALL_ITEMS.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(473, 62)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox3.TabIndex = 1477
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1059, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox1.TabIndex = 1476
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape1, Me.RectangleShape2, Me.RECT_PRCANCELEDIT})
        Me.ShapeContainer3.Size = New System.Drawing.Size(1099, 557)
        Me.ShapeContainer3.TabIndex = 1472
        Me.ShapeContainer3.TabStop = False
        '
        'SpM4_ITEMS_LOCATIONTableAdapter
        '
        Me.SpM4_ITEMS_LOCATIONTableAdapter.ClearBeforeFill = True
        '
        'SPM4INVENTORYDGVLISTBindingSource
        '
        Me.SPM4INVENTORYDGVLISTBindingSource.DataMember = "SPM4_INVENTORYDGVLIST"
        Me.SPM4INVENTORYDGVLISTBindingSource.DataSource = Me.DS_PROPERTYDB
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
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = Nothing
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
        'SPM4_INVENTORYDGVLISTTableAdapter
        '
        Me.SPM4_INVENTORYDGVLISTTableAdapter.ClearBeforeFill = True
        '
        'SpM4_ITEMS_IN_LOCATIONTableAdapter
        '
        Me.SpM4_ITEMS_IN_LOCATIONTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMS_LOCATIONTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMS_LOCATIONTableAdapter.ClearBeforeFill = True
        '
        'ItemsLocationDataGridViewBindingSource
        '
        Me.ItemsLocationDataGridViewBindingSource.DataMember = "ItemsLocationDataGridView"
        Me.ItemsLocationDataGridViewBindingSource.DataSource = Me.DS_CUSTOM
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode"
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
        Me.SubCategoryDataGridViewTextBoxColumn.DataPropertyName = "SubCategory"
        Me.SubCategoryDataGridViewTextBoxColumn.HeaderText = "SubCategory"
        Me.SubCategoryDataGridViewTextBoxColumn.Name = "SubCategoryDataGridViewTextBoxColumn"
        Me.SubCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        Me.BrandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerialNoDataGridViewTextBoxColumn
        '
        Me.SerialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo"
        Me.SerialNoDataGridViewTextBoxColumn.HeaderText = "SerialNo"
        Me.SerialNoDataGridViewTextBoxColumn.Name = "SerialNoDataGridViewTextBoxColumn"
        Me.SerialNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDescriptionDataGridViewTextBoxColumn
        '
        Me.ItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription"
        Me.ItemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription"
        Me.ItemDescriptionDataGridViewTextBoxColumn.Name = "ItemDescriptionDataGridViewTextBoxColumn"
        Me.ItemDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FRM_LOCATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1107, 666)
        Me.Controls.Add(Me.PNL_LOCATION_MAIN)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_LOCATION"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_LOCATION"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DGV_ITEMS_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4ITEMSLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ITEMS_LOCATION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignItemsLocationDataGridViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4ITEMSINLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TblM4INVENTORYITEMSDEFLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_LOCATION_MAIN.ResumeLayout(False)
        Me.PNL_LOCATION_MAIN.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4ITEMSDEFLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4ITEMSLOCATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4INVENTORYDGVLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsLocationDataGridViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_SELECTION_CLOSE As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents LLBL_INVENTORY_VIEW_REPORT As LinkLabel
    Friend WithEvents DGV_ITEMS_LIST As DataGridView
    Friend WithEvents DGV_ITEMS_LOCATION As DataGridView
    Friend WithEvents BTN_ALL_PLUS As Button
    Friend WithEvents BTN_ONE_PLUS As Button
    Friend WithEvents BTN_ONE_MINUS As Button
    Friend WithEvents BTN_ALL_MINUS As Button
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents WTXT_LIST_PREFERRED_ITEMS As WatermarkTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents WTXT_LIST_ITEM_SEARCH As WatermarkTextBox
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TblM4ITEMSLOCATIONBindingSource As BindingSource
    Friend WithEvents TblM4ITEMSDEFLOCATIONBindingSource As BindingSource
    '   Friend WithEvents TblM4_ITEMS_DEFLOCATIONTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_ITEMS_DEFLOCATIONTableAdapter
    Friend WithEvents RECT_INVENTORY_CANCEL As PowerPacks.RectangleShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents CB_LOC_DEFAULT_LOC As ComboBox
    '  Friend WithEvents TblM4_ITEMS_DEFLOCATIONBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents BTN_LOCATION_LIST As Button
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents BTN_LOC_DONE As Button
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents BTN_ASSIGN_ITEM_LOCATION As Button
    Friend WithEvents TblM4ITEMSBindingSource As BindingSource
    '   Friend WithEvents TblM4_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_ITEMSTableAdapter
    Friend WithEvents SPM4INVENTORYDGVLISTBindingSource As BindingSource
    Friend WithEvents SPM4_INVENTORYDGVLISTTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_INVENTORYDGVLISTTableAdapter
    Friend WithEvents PNL_LOCATION_MAIN As Panel
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CHK_SHOW_ALL_ITEMS As CheckBox
    Friend WithEvents SPM4ITEMSLOCATIONBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents PropertyNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpM4_ITEMS_LOCATIONTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEMS_LOCATIONTableAdapter
    Friend WithEvents SPM4ITEMSINLOCATIONBindingSource As BindingSource
    Friend WithEvents PropertyNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SpM4_ITEMS_IN_LOCATIONTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEMS_IN_LOCATIONTableAdapter
    Friend WithEvents TblM4INVENTORYITEMSDEFLOCATIONBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter
    Friend WithEvents TblM4_INVENTORY_ITEMS_LOCATIONTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter
    Friend WithEvents DS_CUSTOM As DS_CUSTOM
    Friend WithEvents AssignItemsLocationDataGridViewBindingSource As BindingSource
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents SubCategory As DataGridViewTextBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
    Friend WithEvents Serial As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerialNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemsLocationDataGridViewBindingSource As BindingSource
End Class
