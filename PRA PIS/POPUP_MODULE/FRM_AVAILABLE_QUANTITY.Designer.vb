<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_AVAILABLE_QUANTITY
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
        Me.BTN_ADD_ITEM = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WTXT_AVAILABLE_QUANTITY = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WTXT_QUANTITY_FOR_DISTRIBUTION = New System.Windows.Forms.TextBox()
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.TblV1_HRISDIVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblV1_HRISDIVISIONTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_TABLESTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_DIVISION = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_AVAILABLE_QTY_BRAND = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_AVAILABLE_QTY_CATEGORY = New PRA_PIS.WatermarkTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_CANCEL = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_DIVISION, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_ADD_ITEM
        '
        Me.BTN_ADD_ITEM.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ADD_ITEM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_ADD_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ADD_ITEM.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ADD_ITEM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ADD_ITEM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BTN_ADD_ITEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADD_ITEM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD_ITEM.ForeColor = System.Drawing.Color.White
        Me.BTN_ADD_ITEM.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_ADD_ITEM.Location = New System.Drawing.Point(294, 463)
        Me.BTN_ADD_ITEM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_ADD_ITEM.Name = "BTN_ADD_ITEM"
        Me.BTN_ADD_ITEM.Size = New System.Drawing.Size(173, 43)
        Me.BTN_ADD_ITEM.TabIndex = 1491
        Me.BTN_ADD_ITEM.Text = "Add Item"
        Me.BTN_ADD_ITEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ADD_ITEM.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WTXT_AVAILABLE_QUANTITY)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(469, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 136)
        Me.GroupBox1.TabIndex = 1494
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Available Quantity"
        '
        'WTXT_AVAILABLE_QUANTITY
        '
        Me.WTXT_AVAILABLE_QUANTITY.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WTXT_AVAILABLE_QUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_AVAILABLE_QUANTITY.Font = New System.Drawing.Font("Century Gothic", 65.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_AVAILABLE_QUANTITY.Location = New System.Drawing.Point(7, 23)
        Me.WTXT_AVAILABLE_QUANTITY.Name = "WTXT_AVAILABLE_QUANTITY"
        Me.WTXT_AVAILABLE_QUANTITY.ReadOnly = True
        Me.WTXT_AVAILABLE_QUANTITY.Size = New System.Drawing.Size(409, 107)
        Me.WTXT_AVAILABLE_QUANTITY.TabIndex = 1
        Me.WTXT_AVAILABLE_QUANTITY.Text = "0"
        Me.WTXT_AVAILABLE_QUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.WTXT_QUANTITY_FOR_DISTRIBUTION)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(1030, 500)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 135)
        Me.GroupBox2.TabIndex = 1495
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quantity for Distribution"
        '
        'WTXT_QUANTITY_FOR_DISTRIBUTION
        '
        Me.WTXT_QUANTITY_FOR_DISTRIBUTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_QUANTITY_FOR_DISTRIBUTION.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold)
        Me.WTXT_QUANTITY_FOR_DISTRIBUTION.Location = New System.Drawing.Point(5, 37)
        Me.WTXT_QUANTITY_FOR_DISTRIBUTION.Name = "WTXT_QUANTITY_FOR_DISTRIBUTION"
        Me.WTXT_QUANTITY_FOR_DISTRIBUTION.Size = New System.Drawing.Size(209, 79)
        Me.WTXT_QUANTITY_FOR_DISTRIBUTION.TabIndex = 0
        Me.WTXT_QUANTITY_FOR_DISTRIBUTION.Text = "0"
        Me.WTXT_QUANTITY_FOR_DISTRIBUTION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DS_TABLES
        '
        Me.DS_TABLES.DataSetName = "DS_TABLES"
        Me.DS_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblV1_HRISDIVISIONBindingSource
        '
        Me.TblV1_HRISDIVISIONBindingSource.DataMember = "tblV1_HRISDIVISION"
        Me.TblV1_HRISDIVISIONBindingSource.DataSource = Me.DS_TABLES
        '
        'TblV1_HRISDIVISIONTableAdapter
        '
        Me.TblV1_HRISDIVISIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblV1_DEFPRADEPARTMENTSTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_DEFPRADIVISIONTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_HRISDEPARTMENTTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_HRISDIVISIONTableAdapter = Me.TblV1_HRISDIVISIONTableAdapter
        Me.TableAdapterManager.tblV1_HRISEMPLOYEEDATATableAdapter = Nothing
        Me.TableAdapterManager.tblV1_USERACCOUNTLOGSTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_USERACCOUNTTableAdapter = Nothing
        Me.TableAdapterManager.tblV2_ACCOUNTCODETableAdapter = Nothing
        Me.TableAdapterManager.tblV2_UsersAccountTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_TABLESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DGV_DIVISION)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 453)
        Me.Panel1.TabIndex = 1498
        '
        'DGV_DIVISION
        '
        Me.DGV_DIVISION.AllowUserToAddRows = False
        Me.DGV_DIVISION.AllowUserToDeleteRows = False
        Me.DGV_DIVISION.AllowUserToResizeColumns = False
        Me.DGV_DIVISION.AllowUserToResizeRows = False
        Me.DGV_DIVISION.AutoGenerateColumns = False
        Me.DGV_DIVISION.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_DIVISION.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_DIVISION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DIVISION.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DGV_DIVISION.DataSource = Me.TblV1_HRISDIVISIONBindingSource
        Me.DGV_DIVISION.Location = New System.Drawing.Point(8, 8)
        Me.DGV_DIVISION.Name = "DGV_DIVISION"
        Me.DGV_DIVISION.RowHeadersVisible = False
        Me.DGV_DIVISION.Size = New System.Drawing.Size(419, 438)
        Me.DGV_DIVISION.TabIndex = 1502
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IS_CHECKED"
        Me.DataGridViewCheckBoxColumn1.FillWeight = 96.82883!
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Include"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HDIV_DIVISION"
        Me.DataGridViewTextBoxColumn4.FillWeight = 75.18933!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Division"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn7.FillWeight = 127.9818!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HDIVS_CODE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "HDIVS_CODE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "HDPT_CODE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "HDPT_CODE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.WTXT_AVAILABLE_QTY_ITEM_DESC)
        Me.GroupBox3.Controls.Add(Me.WTXT_AVAILABLE_QTY_BRAND)
        Me.GroupBox3.Controls.Add(Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY)
        Me.GroupBox3.Controls.Add(Me.WTXT_AVAILABLE_QTY_CATEGORY)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(433, -2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 293)
        Me.GroupBox3.TabIndex = 1502
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item Info"
        '
        'WTXT_AVAILABLE_QTY_ITEM_DESC
        '
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.BackColor = System.Drawing.Color.White
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.Enabled = False
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.Location = New System.Drawing.Point(174, 201)
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.MaxLength = 15
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.Multiline = True
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.Name = "WTXT_AVAILABLE_QTY_ITEM_DESC"
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.ReadOnly = True
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.Size = New System.Drawing.Size(260, 60)
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.TabIndex = 1504
        Me.WTXT_AVAILABLE_QTY_ITEM_DESC.Watermark = Nothing
        '
        'WTXT_AVAILABLE_QTY_BRAND
        '
        Me.WTXT_AVAILABLE_QTY_BRAND.BackColor = System.Drawing.Color.White
        Me.WTXT_AVAILABLE_QTY_BRAND.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_AVAILABLE_QTY_BRAND.Enabled = False
        Me.WTXT_AVAILABLE_QTY_BRAND.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_AVAILABLE_QTY_BRAND.Location = New System.Drawing.Point(175, 143)
        Me.WTXT_AVAILABLE_QTY_BRAND.MaxLength = 15
        Me.WTXT_AVAILABLE_QTY_BRAND.Name = "WTXT_AVAILABLE_QTY_BRAND"
        Me.WTXT_AVAILABLE_QTY_BRAND.ReadOnly = True
        Me.WTXT_AVAILABLE_QTY_BRAND.Size = New System.Drawing.Size(260, 24)
        Me.WTXT_AVAILABLE_QTY_BRAND.TabIndex = 1504
        Me.WTXT_AVAILABLE_QTY_BRAND.Watermark = Nothing
        '
        'WTXT_AVAILABLE_QTY_SUB_CATEGORY
        '
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.BackColor = System.Drawing.Color.White
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.Enabled = False
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.Location = New System.Drawing.Point(174, 92)
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.MaxLength = 15
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.Name = "WTXT_AVAILABLE_QTY_SUB_CATEGORY"
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.ReadOnly = True
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.Size = New System.Drawing.Size(260, 24)
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.TabIndex = 1504
        Me.WTXT_AVAILABLE_QTY_SUB_CATEGORY.Watermark = Nothing
        '
        'WTXT_AVAILABLE_QTY_CATEGORY
        '
        Me.WTXT_AVAILABLE_QTY_CATEGORY.BackColor = System.Drawing.Color.White
        Me.WTXT_AVAILABLE_QTY_CATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_AVAILABLE_QTY_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_AVAILABLE_QTY_CATEGORY.Location = New System.Drawing.Point(174, 41)
        Me.WTXT_AVAILABLE_QTY_CATEGORY.MaxLength = 15
        Me.WTXT_AVAILABLE_QTY_CATEGORY.Name = "WTXT_AVAILABLE_QTY_CATEGORY"
        Me.WTXT_AVAILABLE_QTY_CATEGORY.ReadOnly = True
        Me.WTXT_AVAILABLE_QTY_CATEGORY.Size = New System.Drawing.Size(260, 24)
        Me.WTXT_AVAILABLE_QTY_CATEGORY.TabIndex = 1503
        Me.WTXT_AVAILABLE_QTY_CATEGORY.Watermark = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 1498
        Me.Label1.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 21)
        Me.Label3.TabIndex = 1501
        Me.Label3.Text = "Item Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 1499
        Me.Label2.Text = "Sub Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 21)
        Me.Label4.TabIndex = 1500
        Me.Label4.Text = "Brand"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1, Me.RectangleShape8})
        Me.ShapeContainer1.Size = New System.Drawing.Size(480, 273)
        Me.ShapeContainer1.TabIndex = 1507
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.CornerRadius = 12
        Me.RectangleShape3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape3.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(164, 176)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(273, 75)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 12
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(164, 118)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(273, 38)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 12
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(164, 67)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(273, 38)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape8.BorderWidth = 2
        Me.RectangleShape8.CornerRadius = 12
        Me.RectangleShape8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape8.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape8.Location = New System.Drawing.Point(164, 16)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(273, 39)
        '
        'BTN_CANCEL
        '
        Me.BTN_CANCEL.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_CANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_CANCEL.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_CANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BTN_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CANCEL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CANCEL.ForeColor = System.Drawing.Color.White
        Me.BTN_CANCEL.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_CANCEL.Location = New System.Drawing.Point(473, 463)
        Me.BTN_CANCEL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_CANCEL.Name = "BTN_CANCEL"
        Me.BTN_CANCEL.Size = New System.Drawing.Size(173, 43)
        Me.BTN_CANCEL.TabIndex = 1499
        Me.BTN_CANCEL.Text = "Cancel"
        Me.BTN_CANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CANCEL.UseVisualStyleBackColor = False
        '
        'FRM_AVAILABLE_QUANTITY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(946, 512)
        Me.Controls.Add(Me.BTN_CANCEL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_ADD_ITEM)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_AVAILABLE_QUANTITY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_AVAILABLE_QUANTITY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_DIVISION, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_ADD_ITEM As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents WTXT_AVAILABLE_QUANTITY As TextBox
    Friend WithEvents WTXT_QUANTITY_FOR_DISTRIBUTION As TextBox
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TblV1_HRISDIVISIONBindingSource As BindingSource
    Friend WithEvents TblV1_HRISDIVISIONTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter
    Friend WithEvents TableAdapterManager As DS_TABLESTableAdapters.TableAdapterManager
    Friend WithEvents TblV1_HRISDIVISIONDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_CANCEL As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents WTXT_AVAILABLE_QTY_CATEGORY As WatermarkTextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_AVAILABLE_QTY_ITEM_DESC As WatermarkTextBox
    Friend WithEvents WTXT_AVAILABLE_QTY_BRAND As WatermarkTextBox
    Friend WithEvents WTXT_AVAILABLE_QTY_SUB_CATEGORY As WatermarkTextBox
    Friend WithEvents DGV_DIVISION As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
