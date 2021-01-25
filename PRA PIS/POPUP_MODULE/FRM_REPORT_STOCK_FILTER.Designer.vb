<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_REPORT_STOCK_FILTER
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
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INVENTORY_REPORT_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WTXT_POSITION = New PRA_PIS.WatermarkTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_SORT_BY = New System.Windows.Forms.ComboBox()
        Me.CB_ITEM_ORDER = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_MONTH = New System.Windows.Forms.ComboBox()
        Me.SPM4ITEMSTOCKMASTERLISTRPTDT1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CB_YEAR = New System.Windows.Forms.ComboBox()
        Me.SPM4ITEMSTOCKMASTERLISTRPTDTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WTXT_APPROVED_BY = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_COUNT_BY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TableAdapterManager = New PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager()
        Me.DS_PRAJO_DATABASE = New PRA_PIS.DS_PRAJO_DATABASE()
        Me.BTN_VIEW_REPORT = New System.Windows.Forms.Button()
        Me.SPM4_PDS_LISTTableAdapter = New PRA_PIS.DS_PRAJO_DATABASETableAdapters.SPM4_PDS_LISTTableAdapter()
        Me.SPM4_PDS_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_STOCKMASTERLIST_RPT_DTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKMASTERLIST_RPT_DTTableAdapter()
        Me.SPM4_ITEM_STOCKMASTERLIST_RPT_DT1TableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKMASTERLIST_RPT_DT1TableAdapter()
        Me.PNL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SPM4ITEMSTOCKMASTERLISTRPTDT1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4ITEMSTOCKMASTERLISTRPTDTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PRAJO_DATABASE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PDS_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_REPORT_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(417, 47)
        Me.PNL.TabIndex = 1462
        '
        'BTN_INVENTORY_REPORT_CLOSE
        '
        Me.BTN_INVENTORY_REPORT_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INVENTORY_REPORT_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INVENTORY_REPORT_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_REPORT_CLOSE.Location = New System.Drawing.Point(374, 7)
        Me.BTN_INVENTORY_REPORT_CLOSE.Name = "BTN_INVENTORY_REPORT_CLOSE"
        Me.BTN_INVENTORY_REPORT_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INVENTORY_REPORT_CLOSE.TabIndex = 10
        Me.BTN_INVENTORY_REPORT_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_REPORT_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(12, 14)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(0, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4669, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4622, 10)
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
        Me.Panel1.Controls.Add(Me.WTXT_POSITION)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CB_SORT_BY)
        Me.Panel1.Controls.Add(Me.CB_ITEM_ORDER)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CB_MONTH)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.CB_YEAR)
        Me.Panel1.Controls.Add(Me.WTXT_APPROVED_BY)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(4, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 182)
        Me.Panel1.TabIndex = 1463
        '
        'WTXT_POSITION
        '
        Me.WTXT_POSITION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WTXT_POSITION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.WTXT_POSITION.BackColor = System.Drawing.Color.White
        Me.WTXT_POSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_POSITION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_POSITION.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_POSITION.ForeColor = System.Drawing.Color.Black
        Me.WTXT_POSITION.Location = New System.Drawing.Point(12, 148)
        Me.WTXT_POSITION.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_POSITION.MaxLength = 300
        Me.WTXT_POSITION.Name = "WTXT_POSITION"
        Me.WTXT_POSITION.ReadOnly = True
        Me.WTXT_POSITION.Size = New System.Drawing.Size(381, 19)
        Me.WTXT_POSITION.TabIndex = 1536
        Me.WTXT_POSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_POSITION.Watermark = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(17, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 1549
        Me.Label3.Text = "Position:"
        '
        'CB_SORT_BY
        '
        Me.CB_SORT_BY.DisplayMember = "UN_DESCRIPTION"
        Me.CB_SORT_BY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SORT_BY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_SORT_BY.FormattingEnabled = True
        Me.CB_SORT_BY.Items.AddRange(New Object() {"Ascending", "Descending"})
        Me.CB_SORT_BY.Location = New System.Drawing.Point(211, 65)
        Me.CB_SORT_BY.Name = "CB_SORT_BY"
        Me.CB_SORT_BY.Size = New System.Drawing.Size(180, 21)
        Me.CB_SORT_BY.TabIndex = 1548
        Me.CB_SORT_BY.ValueMember = "UN_NO"
        '
        'CB_ITEM_ORDER
        '
        Me.CB_ITEM_ORDER.DisplayMember = "UN_DESCRIPTION"
        Me.CB_ITEM_ORDER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ITEM_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ITEM_ORDER.FormattingEnabled = True
        Me.CB_ITEM_ORDER.Items.AddRange(New Object() {"Item description", "Remaining stock"})
        Me.CB_ITEM_ORDER.Location = New System.Drawing.Point(13, 64)
        Me.CB_ITEM_ORDER.Name = "CB_ITEM_ORDER"
        Me.CB_ITEM_ORDER.Size = New System.Drawing.Size(185, 21)
        Me.CB_ITEM_ORDER.TabIndex = 1545
        Me.CB_ITEM_ORDER.ValueMember = "UN_NO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(17, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 1548
        Me.Label2.Text = "Order by"
        '
        'CB_MONTH
        '
        Me.CB_MONTH.DataSource = Me.SPM4ITEMSTOCKMASTERLISTRPTDT1BindingSource
        Me.CB_MONTH.DisplayMember = "COL"
        Me.CB_MONTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MONTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_MONTH.FormattingEnabled = True
        Me.CB_MONTH.Location = New System.Drawing.Point(211, 21)
        Me.CB_MONTH.Name = "CB_MONTH"
        Me.CB_MONTH.Size = New System.Drawing.Size(180, 21)
        Me.CB_MONTH.TabIndex = 1547
        Me.CB_MONTH.ValueMember = "YR_CODE"
        '
        'SPM4ITEMSTOCKMASTERLISTRPTDT1BindingSource
        '
        Me.SPM4ITEMSTOCKMASTERLISTRPTDT1BindingSource.DataMember = "SPM4_ITEM_STOCKMASTERLIST_RPT_DT1"
        Me.SPM4ITEMSTOCKMASTERLISTRPTDT1BindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(16, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 1534
        Me.Label8.Text = "Approved by:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(218, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 1546
        Me.Label1.Text = "Month"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(17, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 17)
        Me.Label15.TabIndex = 1545
        Me.Label15.Text = "Year"
        '
        'CB_YEAR
        '
        Me.CB_YEAR.DataSource = Me.SPM4ITEMSTOCKMASTERLISTRPTDTBindingSource
        Me.CB_YEAR.DisplayMember = "COL"
        Me.CB_YEAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_YEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_YEAR.FormattingEnabled = True
        Me.CB_YEAR.Location = New System.Drawing.Point(13, 21)
        Me.CB_YEAR.Name = "CB_YEAR"
        Me.CB_YEAR.Size = New System.Drawing.Size(185, 21)
        Me.CB_YEAR.TabIndex = 1544
        Me.CB_YEAR.ValueMember = "YR_CODE"
        '
        'SPM4ITEMSTOCKMASTERLISTRPTDTBindingSource
        '
        Me.SPM4ITEMSTOCKMASTERLISTRPTDTBindingSource.DataMember = "SPM4_ITEM_STOCKMASTERLIST_RPT_DT"
        Me.SPM4ITEMSTOCKMASTERLISTRPTDTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'WTXT_APPROVED_BY
        '
        Me.WTXT_APPROVED_BY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WTXT_APPROVED_BY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.WTXT_APPROVED_BY.BackColor = System.Drawing.Color.White
        Me.WTXT_APPROVED_BY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_APPROVED_BY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_APPROVED_BY.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_APPROVED_BY.ForeColor = System.Drawing.Color.Black
        Me.WTXT_APPROVED_BY.Location = New System.Drawing.Point(12, 109)
        Me.WTXT_APPROVED_BY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_APPROVED_BY.MaxLength = 300
        Me.WTXT_APPROVED_BY.Name = "WTXT_APPROVED_BY"
        Me.WTXT_APPROVED_BY.Size = New System.Drawing.Size(381, 19)
        Me.WTXT_APPROVED_BY.TabIndex = 1535
        Me.WTXT_APPROVED_BY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_APPROVED_BY.Watermark = ""
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1, Me.RectangleShape8, Me.RECT_COUNT_BY})
        Me.ShapeContainer1.Size = New System.Drawing.Size(406, 180)
        Me.ShapeContainer1.TabIndex = 1537
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(8, 142)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(388, 28)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(205, 60)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(190, 29)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(9, 59)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(192, 29)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(206, 16)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(190, 29)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.Location = New System.Drawing.Point(8, 16)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(194, 29)
        '
        'RECT_COUNT_BY
        '
        Me.RECT_COUNT_BY.BorderColor = System.Drawing.Color.Gray
        Me.RECT_COUNT_BY.CornerRadius = 5
        Me.RECT_COUNT_BY.Location = New System.Drawing.Point(8, 103)
        Me.RECT_COUNT_BY.Name = "RECT_COUNT_BY"
        Me.RECT_COUNT_BY.Size = New System.Drawing.Size(388, 28)
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DS_PRAJO_DATABASE
        '
        Me.DS_PRAJO_DATABASE.DataSetName = "DS_PRAJO_DATABASE"
        Me.DS_PRAJO_DATABASE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTN_VIEW_REPORT
        '
        Me.BTN_VIEW_REPORT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_VIEW_REPORT.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTN_VIEW_REPORT.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_VIEW_REPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_VIEW_REPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_VIEW_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VIEW_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VIEW_REPORT.Image = Global.PRA_PIS.My.Resources.Resources.outline_assignment_black_18dp
        Me.BTN_VIEW_REPORT.Location = New System.Drawing.Point(0, 239)
        Me.BTN_VIEW_REPORT.Name = "BTN_VIEW_REPORT"
        Me.BTN_VIEW_REPORT.Size = New System.Drawing.Size(417, 47)
        Me.BTN_VIEW_REPORT.TabIndex = 1464
        Me.BTN_VIEW_REPORT.Text = "VIEW REPORT"
        Me.BTN_VIEW_REPORT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_VIEW_REPORT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_VIEW_REPORT.UseVisualStyleBackColor = False
        '
        'SPM4_PDS_LISTTableAdapter
        '
        Me.SPM4_PDS_LISTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_PDS_LISTBindingSource
        '
        Me.SPM4_PDS_LISTBindingSource.DataMember = "SPM4_PDS_LIST"
        Me.SPM4_PDS_LISTBindingSource.DataSource = Me.DS_PRAJO_DATABASE
        '
        'SPM4_ITEM_STOCKMASTERLIST_RPT_DTTableAdapter
        '
        Me.SPM4_ITEM_STOCKMASTERLIST_RPT_DTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_STOCKMASTERLIST_RPT_DT1TableAdapter
        '
        Me.SPM4_ITEM_STOCKMASTERLIST_RPT_DT1TableAdapter.ClearBeforeFill = True
        '
        'FRM_REPORT_STOCK_FILTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(417, 286)
        Me.Controls.Add(Me.BTN_VIEW_REPORT)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_REPORT_STOCK_FILTER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_REPORT_STOCK_FILTER"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SPM4ITEMSTOCKMASTERLISTRPTDT1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4ITEMSTOCKMASTERLISTRPTDTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PRAJO_DATABASE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PDS_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_INVENTORY_REPORT_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents WTXT_APPROVED_BY As WatermarkTextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_COUNT_BY As PowerPacks.RectangleShape
    Friend WithEvents CB_YEAR As ComboBox
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents CB_MONTH As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_ITEM_ORDER As ComboBox
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents TableAdapterManager As DS_VIEWSTableAdapters.TableAdapterManager
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents DS_PRAJO_DATABASE As DS_PRAJO_DATABASE
    Friend WithEvents BTN_VIEW_REPORT As Button
    Friend WithEvents CB_SORT_BY As ComboBox
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents Label3 As Label
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_POSITION As WatermarkTextBox
    Friend WithEvents SPM4_PDS_LISTTableAdapter As DS_PRAJO_DATABASETableAdapters.SPM4_PDS_LISTTableAdapter
    Friend WithEvents SPM4_PDS_LISTBindingSource As BindingSource
    Friend WithEvents SPM4ITEMSTOCKMASTERLISTRPTDTBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_STOCKMASTERLIST_RPT_DTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKMASTERLIST_RPT_DTTableAdapter
    Friend WithEvents SPM4ITEMSTOCKMASTERLISTRPTDT1BindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_STOCKMASTERLIST_RPT_DT1TableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKMASTERLIST_RPT_DT1TableAdapter
End Class
