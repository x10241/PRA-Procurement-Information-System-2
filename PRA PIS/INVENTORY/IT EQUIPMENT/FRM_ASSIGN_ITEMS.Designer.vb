<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ASSIGN_ITEMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ASSIGN_ITEMS))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_SELECTION_CLOSE = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_ASSIGN_ITEM = New System.Windows.Forms.Button()
        Me.BTN_GENERATE_REPORT = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_CANCEL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_SEARCH_ASS_ITEM = New PRA_PIS.WatermarkTextBox()
        Me.DGV_ASSIGN_ITEMS_LIST = New System.Windows.Forms.DataGridView()
        Me.ITEMCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMSERIALNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMUNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMUNITCOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMQUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACCOORIGINATEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACCOREMARKSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACCOASSIGNEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEAPPOINTEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASSIORIGINATEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMARKSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASSIASSIGNEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEASSIGNEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTN_REASSIGN = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.VWM4_ITEM_ASSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.VWM4_ITEM_ASSTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_ITEM_ASSTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LLBL_TOT_REC = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.PNL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ASSIGN_ITEMS_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_ITEM_ASSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
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
        Me.PNL.Size = New System.Drawing.Size(1119, 42)
        Me.PNL.TabIndex = 1415
        '
        'BTN_SELECTION_CLOSE
        '
        Me.BTN_SELECTION_CLOSE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_SELECTION_CLOSE.BackgroundImage = CType(resources.GetObject("BTN_SELECTION_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_SELECTION_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_SELECTION_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SELECTION_CLOSE.Location = New System.Drawing.Point(1086, 8)
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
        Me.Label39.Size = New System.Drawing.Size(240, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "A S S I G N  I T E M S  L I S T"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3386, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3339, 10)
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
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BTN_ASSIGN_ITEM)
        Me.Panel1.Controls.Add(Me.BTN_GENERATE_REPORT)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(1, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1117, 58)
        Me.Panel1.TabIndex = 1473
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = Global.PRA_PIS.My.Resources.Resources.outline_low_priority_black_18dp
        Me.Button1.Location = New System.Drawing.Point(139, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(122, 41)
        Me.Button1.TabIndex = 1474
        Me.Button1.Text = "RE-ASSIGN ITEM"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTN_ASSIGN_ITEM
        '
        Me.BTN_ASSIGN_ITEM.BackColor = System.Drawing.Color.White
        Me.BTN_ASSIGN_ITEM.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ASSIGN_ITEM.FlatAppearance.BorderSize = 0
        Me.BTN_ASSIGN_ITEM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ASSIGN_ITEM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ASSIGN_ITEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ASSIGN_ITEM.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_ASSIGN_ITEM.Image = Global.PRA_PIS.My.Resources.Resources.outline_post_add_black_18dp
        Me.BTN_ASSIGN_ITEM.Location = New System.Drawing.Point(13, 6)
        Me.BTN_ASSIGN_ITEM.Name = "BTN_ASSIGN_ITEM"
        Me.BTN_ASSIGN_ITEM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ASSIGN_ITEM.Size = New System.Drawing.Size(116, 41)
        Me.BTN_ASSIGN_ITEM.TabIndex = 1473
        Me.BTN_ASSIGN_ITEM.Text = "ASSIGN ITEM"
        Me.BTN_ASSIGN_ITEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ASSIGN_ITEM.UseVisualStyleBackColor = False
        '
        'BTN_GENERATE_REPORT
        '
        Me.BTN_GENERATE_REPORT.BackColor = System.Drawing.Color.White
        Me.BTN_GENERATE_REPORT.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GENERATE_REPORT.FlatAppearance.BorderSize = 0
        Me.BTN_GENERATE_REPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_GENERATE_REPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GENERATE_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GENERATE_REPORT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_GENERATE_REPORT.Image = CType(resources.GetObject("BTN_GENERATE_REPORT.Image"), System.Drawing.Image)
        Me.BTN_GENERATE_REPORT.Location = New System.Drawing.Point(980, 8)
        Me.BTN_GENERATE_REPORT.Name = "BTN_GENERATE_REPORT"
        Me.BTN_GENERATE_REPORT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_GENERATE_REPORT.Size = New System.Drawing.Size(128, 41)
        Me.BTN_GENERATE_REPORT.TabIndex = 1472
        Me.BTN_GENERATE_REPORT.Text = "GENERATE REPORT"
        Me.BTN_GENERATE_REPORT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_GENERATE_REPORT.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.AutoScroll = True
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1, Me.RECT_INVENTORY_CANCEL})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1115, 56)
        Me.ShapeContainer2.TabIndex = 1470
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(137, 3)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(124, 44)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(12, 3)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(117, 45)
        '
        'RECT_INVENTORY_CANCEL
        '
        Me.RECT_INVENTORY_CANCEL.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_CANCEL.BorderWidth = 2
        Me.RECT_INVENTORY_CANCEL.CornerRadius = 5
        Me.RECT_INVENTORY_CANCEL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_CANCEL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_CANCEL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_CANCEL.Location = New System.Drawing.Point(978, 6)
        Me.RECT_INVENTORY_CANCEL.Name = "RECT_INVENTORY_CANCEL"
        Me.RECT_INVENTORY_CANCEL.Size = New System.Drawing.Size(131, 44)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.Panel2.Controls.Add(Me.WTXT_SEARCH_ASS_ITEM)
        Me.Panel2.Controls.Add(Me.DGV_ASSIGN_ITEMS_LIST)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(1, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1117, 449)
        Me.Panel2.TabIndex = 1474
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(1076, 8)
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
        'WTXT_SEARCH_ASS_ITEM
        '
        Me.WTXT_SEARCH_ASS_ITEM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCH_ASS_ITEM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCH_ASS_ITEM.ForeColor = System.Drawing.Color.Black
        Me.WTXT_SEARCH_ASS_ITEM.Location = New System.Drawing.Point(46, 12)
        Me.WTXT_SEARCH_ASS_ITEM.MaxLength = 15
        Me.WTXT_SEARCH_ASS_ITEM.Name = "WTXT_SEARCH_ASS_ITEM"
        Me.WTXT_SEARCH_ASS_ITEM.Size = New System.Drawing.Size(1024, 20)
        Me.WTXT_SEARCH_ASS_ITEM.TabIndex = 1467
        Me.WTXT_SEARCH_ASS_ITEM.Watermark = "Search Item Code, Item Description, Serial No., Assign Person"
        '
        'DGV_ASSIGN_ITEMS_LIST
        '
        Me.DGV_ASSIGN_ITEMS_LIST.AllowUserToAddRows = False
        Me.DGV_ASSIGN_ITEMS_LIST.AllowUserToDeleteRows = False
        Me.DGV_ASSIGN_ITEMS_LIST.AllowUserToResizeColumns = False
        Me.DGV_ASSIGN_ITEMS_LIST.AllowUserToResizeRows = False
        Me.DGV_ASSIGN_ITEMS_LIST.AutoGenerateColumns = False
        Me.DGV_ASSIGN_ITEMS_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ASSIGN_ITEMS_LIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_ASSIGN_ITEMS_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_ASSIGN_ITEMS_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ASSIGN_ITEMS_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCODEDataGridViewTextBoxColumn, Me.ITEMSERIALNODataGridViewTextBoxColumn, Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn, Me.ITEMUNITDataGridViewTextBoxColumn, Me.ITEMUNITCOSTDataGridViewTextBoxColumn, Me.ITEMQUANTITYDataGridViewTextBoxColumn, Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn, Me.ITEMCREATEDDATEDataGridViewTextBoxColumn, Me.FULLNAMEDataGridViewTextBoxColumn, Me.EMPNODataGridViewTextBoxColumn, Me.ACCOORIGINATEDDataGridViewTextBoxColumn, Me.ACCOREMARKSDataGridViewTextBoxColumn, Me.ACCOASSIGNEDBYDataGridViewTextBoxColumn, Me.DATEAPPOINTEDDataGridViewTextBoxColumn, Me.ASSIORIGINATEDDataGridViewTextBoxColumn, Me.REMARKSDataGridViewTextBoxColumn, Me.ASSIASSIGNEDBYDataGridViewTextBoxColumn, Me.DATEASSIGNEDDataGridViewTextBoxColumn, Me.BTN_REASSIGN})
        Me.DGV_ASSIGN_ITEMS_LIST.DataSource = Me.VWM4_ITEM_ASSBindingSource
        Me.DGV_ASSIGN_ITEMS_LIST.Location = New System.Drawing.Point(3, 43)
        Me.DGV_ASSIGN_ITEMS_LIST.Name = "DGV_ASSIGN_ITEMS_LIST"
        Me.DGV_ASSIGN_ITEMS_LIST.ReadOnly = True
        Me.DGV_ASSIGN_ITEMS_LIST.RowHeadersVisible = False
        Me.DGV_ASSIGN_ITEMS_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ASSIGN_ITEMS_LIST.Size = New System.Drawing.Size(1109, 401)
        Me.DGV_ASSIGN_ITEMS_LIST.TabIndex = 0
        '
        'ITEMCODEDataGridViewTextBoxColumn
        '
        Me.ITEMCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEMCODEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.HeaderText = "Item Code"
        Me.ITEMCODEDataGridViewTextBoxColumn.Name = "ITEMCODEDataGridViewTextBoxColumn"
        Me.ITEMCODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMCODEDataGridViewTextBoxColumn.Width = 110
        '
        'ITEMSERIALNODataGridViewTextBoxColumn
        '
        Me.ITEMSERIALNODataGridViewTextBoxColumn.DataPropertyName = "ITEM_SERIAL_NO"
        Me.ITEMSERIALNODataGridViewTextBoxColumn.HeaderText = "Serial No."
        Me.ITEMSERIALNODataGridViewTextBoxColumn.Name = "ITEMSERIALNODataGridViewTextBoxColumn"
        Me.ITEMSERIALNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "ITEM_DESCRIPTION"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.Name = "ITEMDESCRIPTIONDataGridViewTextBoxColumn"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMUNITDataGridViewTextBoxColumn
        '
        Me.ITEMUNITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEMUNITDataGridViewTextBoxColumn.DataPropertyName = "ITEM_UNIT"
        Me.ITEMUNITDataGridViewTextBoxColumn.HeaderText = "Unit"
        Me.ITEMUNITDataGridViewTextBoxColumn.Name = "ITEMUNITDataGridViewTextBoxColumn"
        Me.ITEMUNITDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMUNITDataGridViewTextBoxColumn.Width = 60
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
        Me.ITEMUNITCOSTDataGridViewTextBoxColumn.Width = 130
        '
        'ITEMQUANTITYDataGridViewTextBoxColumn
        '
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "ITEM_QUANTITY"
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.Name = "ITEMQUANTITYDataGridViewTextBoxColumn"
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.Visible = False
        '
        'ITEMDATEAQUISITIONDataGridViewTextBoxColumn
        '
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.DataPropertyName = "ITEM_DATE_AQUISITION"
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.HeaderText = "Date Aquisition"
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.Name = "ITEMDATEAQUISITIONDataGridViewTextBoxColumn"
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.Width = 115
        '
        'ITEMCREATEDDATEDataGridViewTextBoxColumn
        '
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CREATED_DATE"
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.HeaderText = "Date Encoded"
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.Name = "ITEMCREATEDDATEDataGridViewTextBoxColumn"
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.Width = 115
        '
        'FULLNAMEDataGridViewTextBoxColumn
        '
        Me.FULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "FULLNAME"
        Me.FULLNAMEDataGridViewTextBoxColumn.HeaderText = "Assign Person"
        Me.FULLNAMEDataGridViewTextBoxColumn.Name = "FULLNAMEDataGridViewTextBoxColumn"
        Me.FULLNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPNODataGridViewTextBoxColumn
        '
        Me.EMPNODataGridViewTextBoxColumn.DataPropertyName = "EMP_NO"
        Me.EMPNODataGridViewTextBoxColumn.HeaderText = "EMP_NO"
        Me.EMPNODataGridViewTextBoxColumn.Name = "EMPNODataGridViewTextBoxColumn"
        Me.EMPNODataGridViewTextBoxColumn.ReadOnly = True
        Me.EMPNODataGridViewTextBoxColumn.Visible = False
        '
        'ACCOORIGINATEDDataGridViewTextBoxColumn
        '
        Me.ACCOORIGINATEDDataGridViewTextBoxColumn.DataPropertyName = "ACCO_ORIGINATED"
        Me.ACCOORIGINATEDDataGridViewTextBoxColumn.HeaderText = "ACCO_ORIGINATED"
        Me.ACCOORIGINATEDDataGridViewTextBoxColumn.Name = "ACCOORIGINATEDDataGridViewTextBoxColumn"
        Me.ACCOORIGINATEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ACCOORIGINATEDDataGridViewTextBoxColumn.Visible = False
        '
        'ACCOREMARKSDataGridViewTextBoxColumn
        '
        Me.ACCOREMARKSDataGridViewTextBoxColumn.DataPropertyName = "ACCO_REMARKS"
        Me.ACCOREMARKSDataGridViewTextBoxColumn.HeaderText = "ACCO_REMARKS"
        Me.ACCOREMARKSDataGridViewTextBoxColumn.Name = "ACCOREMARKSDataGridViewTextBoxColumn"
        Me.ACCOREMARKSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ACCOREMARKSDataGridViewTextBoxColumn.Visible = False
        '
        'ACCOASSIGNEDBYDataGridViewTextBoxColumn
        '
        Me.ACCOASSIGNEDBYDataGridViewTextBoxColumn.DataPropertyName = "ACCO_ASSIGNED_BY"
        Me.ACCOASSIGNEDBYDataGridViewTextBoxColumn.HeaderText = "ACCO_ASSIGNED_BY"
        Me.ACCOASSIGNEDBYDataGridViewTextBoxColumn.Name = "ACCOASSIGNEDBYDataGridViewTextBoxColumn"
        Me.ACCOASSIGNEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.ACCOASSIGNEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'DATEAPPOINTEDDataGridViewTextBoxColumn
        '
        Me.DATEAPPOINTEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_APPOINTED"
        Me.DATEAPPOINTEDDataGridViewTextBoxColumn.HeaderText = "DATE_APPOINTED"
        Me.DATEAPPOINTEDDataGridViewTextBoxColumn.Name = "DATEAPPOINTEDDataGridViewTextBoxColumn"
        Me.DATEAPPOINTEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DATEAPPOINTEDDataGridViewTextBoxColumn.Visible = False
        '
        'ASSIORIGINATEDDataGridViewTextBoxColumn
        '
        Me.ASSIORIGINATEDDataGridViewTextBoxColumn.DataPropertyName = "ASSI_ORIGINATED"
        Me.ASSIORIGINATEDDataGridViewTextBoxColumn.HeaderText = "ASSI_ORIGINATED"
        Me.ASSIORIGINATEDDataGridViewTextBoxColumn.Name = "ASSIORIGINATEDDataGridViewTextBoxColumn"
        Me.ASSIORIGINATEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ASSIORIGINATEDDataGridViewTextBoxColumn.Visible = False
        '
        'REMARKSDataGridViewTextBoxColumn
        '
        Me.REMARKSDataGridViewTextBoxColumn.DataPropertyName = "REMARKS"
        Me.REMARKSDataGridViewTextBoxColumn.HeaderText = "REMARKS"
        Me.REMARKSDataGridViewTextBoxColumn.Name = "REMARKSDataGridViewTextBoxColumn"
        Me.REMARKSDataGridViewTextBoxColumn.ReadOnly = True
        Me.REMARKSDataGridViewTextBoxColumn.Visible = False
        '
        'ASSIASSIGNEDBYDataGridViewTextBoxColumn
        '
        Me.ASSIASSIGNEDBYDataGridViewTextBoxColumn.DataPropertyName = "ASSI_ASSIGNED_BY"
        Me.ASSIASSIGNEDBYDataGridViewTextBoxColumn.HeaderText = "ASSI_ASSIGNED_BY"
        Me.ASSIASSIGNEDBYDataGridViewTextBoxColumn.Name = "ASSIASSIGNEDBYDataGridViewTextBoxColumn"
        Me.ASSIASSIGNEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.ASSIASSIGNEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'DATEASSIGNEDDataGridViewTextBoxColumn
        '
        Me.DATEASSIGNEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_ASSIGNED"
        Me.DATEASSIGNEDDataGridViewTextBoxColumn.HeaderText = "DATE_ASSIGNED"
        Me.DATEASSIGNEDDataGridViewTextBoxColumn.Name = "DATEASSIGNEDDataGridViewTextBoxColumn"
        Me.DATEASSIGNEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DATEASSIGNEDDataGridViewTextBoxColumn.Visible = False
        '
        'BTN_REASSIGN
        '
        Me.BTN_REASSIGN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.BTN_REASSIGN.HeaderText = "Action"
        Me.BTN_REASSIGN.Name = "BTN_REASSIGN"
        Me.BTN_REASSIGN.ReadOnly = True
        Me.BTN_REASSIGN.Text = "reassign item"
        Me.BTN_REASSIGN.UseColumnTextForButtonValue = True
        Me.BTN_REASSIGN.Width = 90
        '
        'VWM4_ITEM_ASSBindingSource
        '
        Me.VWM4_ITEM_ASSBindingSource.DataMember = "VWM4_ITEM_ASS"
        Me.VWM4_ITEM_ASSBindingSource.DataSource = Me.DS_VIEWS
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRCANCELEDIT})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1115, 447)
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
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(1108, 33)
        '
        'VWM4_ITEM_ASSTableAdapter
        '
        Me.VWM4_ITEM_ASSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LLBL_TOT_REC)
        Me.GroupBox7.Controls.Add(Me.LinkLabel7)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 553)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(313, 50)
        Me.GroupBox7.TabIndex = 1475
        Me.GroupBox7.TabStop = False
        '
        'LLBL_TOT_REC
        '
        Me.LLBL_TOT_REC.AutoSize = True
        Me.LLBL_TOT_REC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_TOT_REC.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_TOT_REC.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_TOT_REC.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_TOT_REC.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_TOT_REC.Location = New System.Drawing.Point(265, 19)
        Me.LLBL_TOT_REC.Name = "LLBL_TOT_REC"
        Me.LLBL_TOT_REC.Size = New System.Drawing.Size(19, 19)
        Me.LLBL_TOT_REC.TabIndex = 1441
        Me.LLBL_TOT_REC.TabStop = True
        Me.LLBL_TOT_REC.Text = "0"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel7.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel7.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel7.Location = New System.Drawing.Point(7, 19)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(238, 19)
        Me.LinkLabel7.TabIndex = 1440
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Total No. of Records Found :"
        '
        'FRM_ASSIGN_ITEMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1119, 607)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_ASSIGN_ITEMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ASSIGN_ITEMS"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ASSIGN_ITEMS_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_ITEM_ASSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_SELECTION_CLOSE As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_GENERATE_REPORT As Button
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_INVENTORY_CANCEL As PowerPacks.RectangleShape
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents WTXT_SEARCH_ASS_ITEM As WatermarkTextBox
    Friend WithEvents DGV_ASSIGN_ITEMS_LIST As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents BTN_ASSIGN_ITEM As Button
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents VWM4_ITEM_ASSBindingSource As BindingSource
    Friend WithEvents VWM4_ITEM_ASSTableAdapter As DS_VIEWSTableAdapters.VWM4_ITEM_ASSTableAdapter
    Friend WithEvents TableAdapterManager As DS_VIEWSTableAdapters.TableAdapterManager
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMSERIALNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUNITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUNITCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMQUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDATEAQUISITIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCREATEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FULLNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACCOORIGINATEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACCOREMARKSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ACCOASSIGNEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEAPPOINTEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATECREATEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ASSIORIGINATEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REMARKSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ASSIASSIGNEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEASSIGNEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BTN_REASSIGN As DataGridViewButtonColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents LLBL_TOT_REC As LinkLabel
    Friend WithEvents LinkLabel7 As LinkLabel
End Class
