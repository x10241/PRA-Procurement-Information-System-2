<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ITEM_REQ_ENC
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
        Me.BTN_ITEM_REQ_ENC_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.GRP_ITEMINFO = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WTXT_ITEM_DESCRIPTION = New PRA_PIS.WatermarkTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WTXT_QUANTITY = New PRA_PIS.WatermarkTextBox()
        Me.CB_UNIT_TYPE = New System.Windows.Forms.ComboBox()
        Me.TBLG3_UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.LLBL_CLOSE = New System.Windows.Forms.LinkLabel()
        Me.LLBL_SAVE_ADD_ITEM = New System.Windows.Forms.LinkLabel()
        Me.PBOX_PRNOQRCODE = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_ITEM_DESCRIPTION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_QUANTITY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape15 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TblM4_INVENTORY_ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TBLG3_UNITSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter()
        Me.BTN_ADD_ITEM = New System.Windows.Forms.Button()
        Me.BTN_ITEM_REQ_ENC_CANCEL = New System.Windows.Forms.Button()
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.VWM4_ITEM_LISTTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter()
        Me.VWM4_ITEM_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMSTableAdapter()
        Me.TBLM4_INV_ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PNL.SuspendLayout()
        Me.GRP_ITEMINFO.SuspendLayout()
        CType(Me.TBLG3_UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_ITEM_REQ_ENC_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(566, 49)
        Me.PNL.TabIndex = 1408
        '
        'BTN_ITEM_REQ_ENC_CLOSE
        '
        Me.BTN_ITEM_REQ_ENC_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_ITEM_REQ_ENC_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ITEM_REQ_ENC_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_ITEM_REQ_ENC_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_ITEM_REQ_ENC_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ITEM_REQ_ENC_CLOSE.Location = New System.Drawing.Point(516, 10)
        Me.BTN_ITEM_REQ_ENC_CLOSE.Name = "BTN_ITEM_REQ_ENC_CLOSE"
        Me.BTN_ITEM_REQ_ENC_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_ITEM_REQ_ENC_CLOSE.TabIndex = 16
        Me.BTN_ITEM_REQ_ENC_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ITEM_REQ_ENC_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(12, 14)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(225, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "I t e m  R e q u i s i t i o n"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-11241, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-11194, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'GRP_ITEMINFO
        '
        Me.GRP_ITEMINFO.BackColor = System.Drawing.SystemColors.Window
        Me.GRP_ITEMINFO.Controls.Add(Me.Label3)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label1)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label7)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_ITEM_DESCRIPTION)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label4)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label2)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_QUANTITY)
        Me.GRP_ITEMINFO.Controls.Add(Me.CB_UNIT_TYPE)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_CLOSE)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_SAVE_ADD_ITEM)
        Me.GRP_ITEMINFO.Controls.Add(Me.PBOX_PRNOQRCODE)
        Me.GRP_ITEMINFO.Controls.Add(Me.ShapeContainer3)
        Me.GRP_ITEMINFO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRP_ITEMINFO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GRP_ITEMINFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GRP_ITEMINFO.Location = New System.Drawing.Point(10, 57)
        Me.GRP_ITEMINFO.Name = "GRP_ITEMINFO"
        Me.GRP_ITEMINFO.Size = New System.Drawing.Size(549, 133)
        Me.GRP_ITEMINFO.TabIndex = 1444
        Me.GRP_ITEMINFO.TabStop = False
        Me.GRP_ITEMINFO.Text = "Item Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(526, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 16)
        Me.Label3.TabIndex = 1496
        Me.Label3.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(292, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 16)
        Me.Label1.TabIndex = 1495
        Me.Label1.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(15, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 17)
        Me.Label7.TabIndex = 1437
        Me.Label7.Text = "Item Description"
        '
        'WTXT_ITEM_DESCRIPTION
        '
        Me.WTXT_ITEM_DESCRIPTION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WTXT_ITEM_DESCRIPTION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.WTXT_ITEM_DESCRIPTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_DESCRIPTION.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_DESCRIPTION.Location = New System.Drawing.Point(14, 90)
        Me.WTXT_ITEM_DESCRIPTION.Name = "WTXT_ITEM_DESCRIPTION"
        Me.WTXT_ITEM_DESCRIPTION.Size = New System.Drawing.Size(521, 26)
        Me.WTXT_ITEM_DESCRIPTION.TabIndex = 1491
        Me.WTXT_ITEM_DESCRIPTION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ITEM_DESCRIPTION.Watermark = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(173, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 1494
        Me.Label4.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(15, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 1493
        Me.Label2.Text = "Unit type"
        '
        'WTXT_QUANTITY
        '
        Me.WTXT_QUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_QUANTITY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_QUANTITY.Location = New System.Drawing.Point(171, 47)
        Me.WTXT_QUANTITY.Name = "WTXT_QUANTITY"
        Me.WTXT_QUANTITY.Size = New System.Drawing.Size(130, 21)
        Me.WTXT_QUANTITY.TabIndex = 1492
        Me.WTXT_QUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_QUANTITY.Watermark = ""
        '
        'CB_UNIT_TYPE
        '
        Me.CB_UNIT_TYPE.DataSource = Me.TBLG3_UNITSBindingSource
        Me.CB_UNIT_TYPE.DisplayMember = "UN_DESCRIPTION"
        Me.CB_UNIT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_UNIT_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_UNIT_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_UNIT_TYPE.FormattingEnabled = True
        Me.CB_UNIT_TYPE.Location = New System.Drawing.Point(11, 44)
        Me.CB_UNIT_TYPE.Name = "CB_UNIT_TYPE"
        Me.CB_UNIT_TYPE.Size = New System.Drawing.Size(146, 27)
        Me.CB_UNIT_TYPE.TabIndex = 1491
        Me.CB_UNIT_TYPE.ValueMember = "UN_NO"
        '
        'TBLG3_UNITSBindingSource
        '
        Me.TBLG3_UNITSBindingSource.DataMember = "TBLG3_UNITS"
        Me.TBLG3_UNITSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LLBL_CLOSE
        '
        Me.LLBL_CLOSE.AutoSize = True
        Me.LLBL_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_CLOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_CLOSE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_CLOSE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_CLOSE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_CLOSE.Location = New System.Drawing.Point(454, 606)
        Me.LLBL_CLOSE.Name = "LLBL_CLOSE"
        Me.LLBL_CLOSE.Size = New System.Drawing.Size(61, 19)
        Me.LLBL_CLOSE.TabIndex = 1464
        Me.LLBL_CLOSE.TabStop = True
        Me.LLBL_CLOSE.Text = "CLOSE"
        '
        'LLBL_SAVE_ADD_ITEM
        '
        Me.LLBL_SAVE_ADD_ITEM.AutoSize = True
        Me.LLBL_SAVE_ADD_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_SAVE_ADD_ITEM.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_SAVE_ADD_ITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE_ADD_ITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_SAVE_ADD_ITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE_ADD_ITEM.Location = New System.Drawing.Point(393, 606)
        Me.LLBL_SAVE_ADD_ITEM.Name = "LLBL_SAVE_ADD_ITEM"
        Me.LLBL_SAVE_ADD_ITEM.Size = New System.Drawing.Size(46, 19)
        Me.LLBL_SAVE_ADD_ITEM.TabIndex = 1463
        Me.LLBL_SAVE_ADD_ITEM.TabStop = True
        Me.LLBL_SAVE_ADD_ITEM.Text = "ADD"
        '
        'PBOX_PRNOQRCODE
        '
        Me.PBOX_PRNOQRCODE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBOX_PRNOQRCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBOX_PRNOQRCODE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBOX_PRNOQRCODE.Location = New System.Drawing.Point(1504, 55)
        Me.PBOX_PRNOQRCODE.Name = "PBOX_PRNOQRCODE"
        Me.PBOX_PRNOQRCODE.Size = New System.Drawing.Size(145, 145)
        Me.PBOX_PRNOQRCODE.TabIndex = 0
        Me.PBOX_PRNOQRCODE.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_ITEM_DESCRIPTION, Me.RECT_QUANTITY, Me.RectangleShape3, Me.RectangleShape15, Me.RectangleShape14})
        Me.ShapeContainer3.Size = New System.Drawing.Size(543, 111)
        Me.ShapeContainer3.TabIndex = 1
        Me.ShapeContainer3.TabStop = False
        '
        'RECT_ITEM_DESCRIPTION
        '
        Me.RECT_ITEM_DESCRIPTION.BorderColor = System.Drawing.Color.Gray
        Me.RECT_ITEM_DESCRIPTION.CornerRadius = 5
        Me.RECT_ITEM_DESCRIPTION.Location = New System.Drawing.Point(4, 66)
        Me.RECT_ITEM_DESCRIPTION.Name = "RECT_ITEM_DESCRIPTION"
        Me.RECT_ITEM_DESCRIPTION.Size = New System.Drawing.Size(533, 35)
        '
        'RECT_QUANTITY
        '
        Me.RECT_QUANTITY.BorderColor = System.Drawing.Color.Gray
        Me.RECT_QUANTITY.CornerRadius = 5
        Me.RECT_QUANTITY.Location = New System.Drawing.Point(162, 21)
        Me.RECT_QUANTITY.Name = "RECT_QUANTITY"
        Me.RECT_QUANTITY.Size = New System.Drawing.Size(142, 33)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(4, 21)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(153, 33)
        '
        'RectangleShape15
        '
        Me.RectangleShape15.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape15.BorderWidth = 2
        Me.RectangleShape15.CornerRadius = 19
        Me.RectangleShape15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape15.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape15.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape15.Location = New System.Drawing.Point(447, 576)
        Me.RectangleShape15.Name = "RectangleShape15"
        Me.RectangleShape15.Size = New System.Drawing.Size(67, 39)
        '
        'RectangleShape14
        '
        Me.RectangleShape14.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape14.BorderWidth = 2
        Me.RectangleShape14.CornerRadius = 19
        Me.RectangleShape14.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape14.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape14.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape14.Location = New System.Drawing.Point(382, 576)
        Me.RectangleShape14.Name = "RectangleShape14"
        Me.RectangleShape14.Size = New System.Drawing.Size(62, 39)
        '
        'TblM4_INVENTORY_ITEMSBindingSource
        '
        Me.TblM4_INVENTORY_ITEMSBindingSource.DataMember = "tblM4_INVENTORY_ITEMS"
        Me.TblM4_INVENTORY_ITEMSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_ITEMSTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TBLM4_INV_DIST_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_DR_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_COLORTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENG_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENGTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAME_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAMETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMSTableAdapter = Me.TblM4_INVENTORY_ITEMSTableAdapter
        Me.TableAdapterManager.TBLM4_INVENTORY_REQUISITIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_SUB_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_TYPETableAdapter = Nothing
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
        'TBLG3_UNITSTableAdapter
        '
        Me.TBLG3_UNITSTableAdapter.ClearBeforeFill = True
        '
        'BTN_ADD_ITEM
        '
        Me.BTN_ADD_ITEM.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD_ITEM.Location = New System.Drawing.Point(353, 196)
        Me.BTN_ADD_ITEM.Name = "BTN_ADD_ITEM"
        Me.BTN_ADD_ITEM.Size = New System.Drawing.Size(99, 33)
        Me.BTN_ADD_ITEM.TabIndex = 1541
        Me.BTN_ADD_ITEM.Text = "ADD ITEM"
        Me.BTN_ADD_ITEM.UseVisualStyleBackColor = True
        '
        'BTN_ITEM_REQ_ENC_CANCEL
        '
        Me.BTN_ITEM_REQ_ENC_CANCEL.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ITEM_REQ_ENC_CANCEL.Location = New System.Drawing.Point(458, 196)
        Me.BTN_ITEM_REQ_ENC_CANCEL.Name = "BTN_ITEM_REQ_ENC_CANCEL"
        Me.BTN_ITEM_REQ_ENC_CANCEL.Size = New System.Drawing.Size(101, 33)
        Me.BTN_ITEM_REQ_ENC_CANCEL.TabIndex = 1542
        Me.BTN_ITEM_REQ_ENC_CANCEL.Text = "CANCEL"
        Me.BTN_ITEM_REQ_ENC_CANCEL.UseVisualStyleBackColor = True
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VWM4_ITEM_LISTTableAdapter
        '
        Me.VWM4_ITEM_LISTTableAdapter.ClearBeforeFill = True
        '
        'VWM4_ITEM_LISTBindingSource
        '
        Me.VWM4_ITEM_LISTBindingSource.DataMember = "VWM4_ITEM_LIST"
        Me.VWM4_ITEM_LISTBindingSource.DataSource = Me.DS_VIEWS
        '
        'TBLM4_INV_ITEMSTableAdapter
        '
        Me.TBLM4_INV_ITEMSTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMSBindingSource
        '
        Me.TBLM4_INV_ITEMSBindingSource.DataMember = "TBLM4_INV_ITEMS"
        Me.TBLM4_INV_ITEMSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'FRM_ITEM_REQ_ENC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(566, 251)
        Me.Controls.Add(Me.BTN_ITEM_REQ_ENC_CANCEL)
        Me.Controls.Add(Me.BTN_ADD_ITEM)
        Me.Controls.Add(Me.GRP_ITEMINFO)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_ITEM_REQ_ENC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ITEM_REQ_ENC"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.GRP_ITEMINFO.ResumeLayout(False)
        Me.GRP_ITEMINFO.PerformLayout()
        CType(Me.TBLG3_UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_ITEM_REQ_ENC_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents GRP_ITEMINFO As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WTXT_QUANTITY As WatermarkTextBox
    Friend WithEvents CB_UNIT_TYPE As ComboBox
    Friend WithEvents LLBL_CLOSE As LinkLabel
    Friend WithEvents LLBL_SAVE_ADD_ITEM As LinkLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents PBOX_PRNOQRCODE As PictureBox
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_QUANTITY As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RECT_ITEM_DESCRIPTION As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape15 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape14 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_ITEM_DESCRIPTION As WatermarkTextBox
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblM4_INVENTORY_ITEMSBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents TBLG3_UNITSBindingSource As BindingSource
    Friend WithEvents TBLG3_UNITSTableAdapter As DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter
    Friend WithEvents BTN_ADD_ITEM As Button
    Friend WithEvents BTN_ITEM_REQ_ENC_CANCEL As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents VWM4_ITEM_LISTTableAdapter As DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter
    Friend WithEvents VWM4_ITEM_LISTBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMSTableAdapter
    Friend WithEvents TBLM4_INV_ITEMSBindingSource As BindingSource
End Class
