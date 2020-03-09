<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ADDITIONAL_CATEGORIZATION
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
        Me.BTN_SAVE = New System.Windows.Forms.Button()
        Me.DGV_CLOSE = New System.Windows.Forms.Button()
        Me.LBL_ADDITIONAL_CATEGORIZATION = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.GRP_CATEGORY = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WTXT_CATEGORY_NAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_CATEGORY_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_BRANDS = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WTXT_BRANDNAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_BRAND_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_SUB_CATEGORY = New System.Windows.Forms.GroupBox()
        Me.CB_CATEGORYNAME = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WTXT_SUBCATEGORY_NAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_SUBCATEGORY_CATEGORYNAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_SUB_CATEGORY_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TblM4_INVENTORY_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter()
        Me.TblM4_INVENTORY_ITEMBRANDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter()
        Me.PNL.SuspendLayout()
        Me.GRP_CATEGORY.SuspendLayout()
        Me.GRP_BRANDS.SuspendLayout()
        Me.GRP_SUB_CATEGORY.SuspendLayout()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_SAVE.Location = New System.Drawing.Point(95, 219)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(92, 32)
        Me.BTN_SAVE.TabIndex = 1409
        Me.BTN_SAVE.Text = "SAVE"
        Me.BTN_SAVE.UseVisualStyleBackColor = True
        '
        'DGV_CLOSE
        '
        Me.DGV_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.DGV_CLOSE.FlatAppearance.BorderSize = 5
        Me.DGV_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.DGV_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DGV_CLOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.DGV_CLOSE.Location = New System.Drawing.Point(196, 219)
        Me.DGV_CLOSE.Name = "DGV_CLOSE"
        Me.DGV_CLOSE.Size = New System.Drawing.Size(90, 32)
        Me.DGV_CLOSE.TabIndex = 1410
        Me.DGV_CLOSE.Text = "CLOSE"
        Me.DGV_CLOSE.UseVisualStyleBackColor = True
        '
        'LBL_ADDITIONAL_CATEGORIZATION
        '
        Me.LBL_ADDITIONAL_CATEGORIZATION.AutoSize = True
        Me.LBL_ADDITIONAL_CATEGORIZATION.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ADDITIONAL_CATEGORIZATION.ForeColor = System.Drawing.Color.White
        Me.LBL_ADDITIONAL_CATEGORIZATION.Location = New System.Drawing.Point(9, 9)
        Me.LBL_ADDITIONAL_CATEGORIZATION.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBL_ADDITIONAL_CATEGORIZATION.Name = "LBL_ADDITIONAL_CATEGORIZATION"
        Me.LBL_ADDITIONAL_CATEGORIZATION.Size = New System.Drawing.Size(0, 23)
        Me.LBL_ADDITIONAL_CATEGORIZATION.TabIndex = 8
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4117, 11)
        Me.BTN_Minimize.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_Minimize.Name = "BTN_Minimize"
        Me.BTN_Minimize.Size = New System.Drawing.Size(47, 45)
        Me.BTN_Minimize.TabIndex = 7
        Me.BTN_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Minimize.UseVisualStyleBackColor = False
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.LBL_ADDITIONAL_CATEGORIZATION)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(388, 50)
        Me.PNL.TabIndex = 1412
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4070, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'GRP_CATEGORY
        '
        Me.GRP_CATEGORY.Controls.Add(Me.Label1)
        Me.GRP_CATEGORY.Controls.Add(Me.WTXT_CATEGORY_NAME)
        Me.GRP_CATEGORY.Controls.Add(Me.ShapeContainer2)
        Me.GRP_CATEGORY.Enabled = False
        Me.GRP_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_CATEGORY.Location = New System.Drawing.Point(8, 54)
        Me.GRP_CATEGORY.Name = "GRP_CATEGORY"
        Me.GRP_CATEGORY.Size = New System.Drawing.Size(375, 111)
        Me.GRP_CATEGORY.TabIndex = 1442
        Me.GRP_CATEGORY.TabStop = False
        Me.GRP_CATEGORY.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 19)
        Me.Label1.TabIndex = 1430
        Me.Label1.Text = "Category Name"
        '
        'WTXT_CATEGORY_NAME
        '
        Me.WTXT_CATEGORY_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_CATEGORY_NAME.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_CATEGORY_NAME.Location = New System.Drawing.Point(16, 63)
        Me.WTXT_CATEGORY_NAME.MaxLength = 120
        Me.WTXT_CATEGORY_NAME.Name = "WTXT_CATEGORY_NAME"
        Me.WTXT_CATEGORY_NAME.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_CATEGORY_NAME.TabIndex = 1428
        Me.WTXT_CATEGORY_NAME.Watermark = Nothing
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_CATEGORY_NAME})
        Me.ShapeContainer2.Size = New System.Drawing.Size(369, 85)
        Me.ShapeContainer2.TabIndex = 1429
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_CATEGORY_NAME
        '
        Me.RECT_CATEGORY_NAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_CATEGORY_NAME.BorderWidth = 2
        Me.RECT_CATEGORY_NAME.CornerRadius = 5
        Me.RECT_CATEGORY_NAME.Location = New System.Drawing.Point(8, 35)
        Me.RECT_CATEGORY_NAME.Name = "RECT_CATEGORY_NAME"
        Me.RECT_CATEGORY_NAME.Size = New System.Drawing.Size(348, 32)
        '
        'GRP_BRANDS
        '
        Me.GRP_BRANDS.Controls.Add(Me.Label7)
        Me.GRP_BRANDS.Controls.Add(Me.WTXT_BRANDNAME)
        Me.GRP_BRANDS.Controls.Add(Me.ShapeContainer4)
        Me.GRP_BRANDS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_BRANDS.Location = New System.Drawing.Point(8, 54)
        Me.GRP_BRANDS.Name = "GRP_BRANDS"
        Me.GRP_BRANDS.Size = New System.Drawing.Size(375, 123)
        Me.GRP_BRANDS.TabIndex = 1446
        Me.GRP_BRANDS.TabStop = False
        Me.GRP_BRANDS.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 1430
        Me.Label7.Text = "Brand Name"
        '
        'WTXT_BRANDNAME
        '
        Me.WTXT_BRANDNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_BRANDNAME.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_BRANDNAME.Location = New System.Drawing.Point(16, 63)
        Me.WTXT_BRANDNAME.MaxLength = 120
        Me.WTXT_BRANDNAME.Name = "WTXT_BRANDNAME"
        Me.WTXT_BRANDNAME.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_BRANDNAME.TabIndex = 1428
        Me.WTXT_BRANDNAME.Watermark = Nothing
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_BRAND_NAME})
        Me.ShapeContainer4.Size = New System.Drawing.Size(369, 97)
        Me.ShapeContainer4.TabIndex = 1429
        Me.ShapeContainer4.TabStop = False
        '
        'RECT_BRAND_NAME
        '
        Me.RECT_BRAND_NAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_BRAND_NAME.BorderWidth = 2
        Me.RECT_BRAND_NAME.CornerRadius = 5
        Me.RECT_BRAND_NAME.Location = New System.Drawing.Point(8, 35)
        Me.RECT_BRAND_NAME.Name = "RECT_BRAND_NAME"
        Me.RECT_BRAND_NAME.Size = New System.Drawing.Size(348, 32)
        '
        'GRP_SUB_CATEGORY
        '
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.CB_CATEGORYNAME)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.Label5)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.Label4)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.WTXT_SUBCATEGORY_NAME)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.ShapeContainer3)
        Me.GRP_SUB_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_SUB_CATEGORY.Location = New System.Drawing.Point(8, 54)
        Me.GRP_SUB_CATEGORY.Name = "GRP_SUB_CATEGORY"
        Me.GRP_SUB_CATEGORY.Size = New System.Drawing.Size(375, 159)
        Me.GRP_SUB_CATEGORY.TabIndex = 1447
        Me.GRP_SUB_CATEGORY.TabStop = False
        Me.GRP_SUB_CATEGORY.Visible = False
        '
        'CB_CATEGORYNAME
        '
        Me.CB_CATEGORYNAME.DataSource = Me.TblM4INVENTORYCATEGORYBindingSource
        Me.CB_CATEGORYNAME.DisplayMember = "CAT_NAME"
        Me.CB_CATEGORYNAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CATEGORYNAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_CATEGORYNAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_CATEGORYNAME.FormattingEnabled = True
        Me.CB_CATEGORYNAME.Location = New System.Drawing.Point(16, 55)
        Me.CB_CATEGORYNAME.Name = "CB_CATEGORYNAME"
        Me.CB_CATEGORYNAME.Size = New System.Drawing.Size(339, 27)
        Me.CB_CATEGORYNAME.TabIndex = 1445
        Me.CB_CATEGORYNAME.ValueMember = "CAT_CODE"
        '
        'TblM4INVENTORYCATEGORYBindingSource
        '
        Me.TblM4INVENTORYCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_CATEGORY"
        Me.TblM4INVENTORYCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 19)
        Me.Label5.TabIndex = 1445
        Me.Label5.Text = "Category Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 19)
        Me.Label4.TabIndex = 1430
        Me.Label4.Text = "Sub Category Name"
        '
        'WTXT_SUBCATEGORY_NAME
        '
        Me.WTXT_SUBCATEGORY_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SUBCATEGORY_NAME.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SUBCATEGORY_NAME.Location = New System.Drawing.Point(16, 116)
        Me.WTXT_SUBCATEGORY_NAME.MaxLength = 120
        Me.WTXT_SUBCATEGORY_NAME.Name = "WTXT_SUBCATEGORY_NAME"
        Me.WTXT_SUBCATEGORY_NAME.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_SUBCATEGORY_NAME.TabIndex = 1428
        Me.WTXT_SUBCATEGORY_NAME.Watermark = Nothing
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_SUBCATEGORY_CATEGORYNAME, Me.RECT_SUB_CATEGORY_NAME})
        Me.ShapeContainer3.Size = New System.Drawing.Size(369, 133)
        Me.ShapeContainer3.TabIndex = 1429
        Me.ShapeContainer3.TabStop = False
        '
        'RECT_SUBCATEGORY_CATEGORYNAME
        '
        Me.RECT_SUBCATEGORY_CATEGORYNAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_SUBCATEGORY_CATEGORYNAME.BorderWidth = 2
        Me.RECT_SUBCATEGORY_CATEGORYNAME.CornerRadius = 5
        Me.RECT_SUBCATEGORY_CATEGORYNAME.Location = New System.Drawing.Point(8, 28)
        Me.RECT_SUBCATEGORY_CATEGORYNAME.Name = "RECT_SUBCATEGORY_CATEGORYNAME"
        Me.RECT_SUBCATEGORY_CATEGORYNAME.Size = New System.Drawing.Size(348, 33)
        '
        'RECT_SUB_CATEGORY_NAME
        '
        Me.RECT_SUB_CATEGORY_NAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_SUB_CATEGORY_NAME.BorderWidth = 2
        Me.RECT_SUB_CATEGORY_NAME.CornerRadius = 5
        Me.RECT_SUB_CATEGORY_NAME.Location = New System.Drawing.Point(8, 88)
        Me.RECT_SUB_CATEGORY_NAME.Name = "RECT_SUB_CATEGORY_NAME"
        Me.RECT_SUB_CATEGORY_NAME.Size = New System.Drawing.Size(348, 33)
        '
        'TblM4_INVENTORY_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMBRANDBindingSource
        '
        Me.TblM4_INVENTORY_ITEMBRANDBindingSource.DataMember = "tblM4_INVENTORY_ITEMBRAND"
        Me.TblM4_INVENTORY_ITEMBRANDBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_ITEMBRANDTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Me.TblM4_INVENTORY_CATEGORYTableAdapter
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Me.TblM4_INVENTORY_ITEMBRANDTableAdapter
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
        'TblM4_INVENTORY_SUB_CATEGORYBindingSource
        '
        Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource.DataMember = "tblM4_INVENTORY_SUB_CATEGORY"
        Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_SUB_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'FRM_ADDITIONAL_CATEGORIZATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(388, 265)
        Me.Controls.Add(Me.GRP_SUB_CATEGORY)
        Me.Controls.Add(Me.GRP_BRANDS)
        Me.Controls.Add(Me.GRP_CATEGORY)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.DGV_CLOSE)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_ADDITIONAL_CATEGORIZATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ADDITIONAL_CATEGORIZATION"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.GRP_CATEGORY.ResumeLayout(False)
        Me.GRP_CATEGORY.PerformLayout()
        Me.GRP_BRANDS.ResumeLayout(False)
        Me.GRP_BRANDS.PerformLayout()
        Me.GRP_SUB_CATEGORY.ResumeLayout(False)
        Me.GRP_SUB_CATEGORY.PerformLayout()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents DGV_CLOSE As Button
    Friend WithEvents LBL_ADDITIONAL_CATEGORIZATION As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents GRP_CATEGORY As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WTXT_CATEGORY_NAME As WatermarkTextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_CATEGORY_NAME As PowerPacks.RectangleShape
    Friend WithEvents GRP_BRANDS As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents WTXT_BRANDNAME As WatermarkTextBox
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_BRAND_NAME As PowerPacks.RectangleShape
    Friend WithEvents GRP_SUB_CATEGORY As GroupBox
    Friend WithEvents CB_CATEGORYNAME As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents WTXT_SUBCATEGORY_NAME As WatermarkTextBox
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_SUBCATEGORY_CATEGORYNAME As PowerPacks.RectangleShape
    Friend WithEvents RECT_SUB_CATEGORY_NAME As PowerPacks.RectangleShape
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TblM4INVENTORYCATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter
    Friend WithEvents TblM4_INVENTORY_ITEMBRANDBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMBRANDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents TblM4_INVENTORY_SUB_CATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_SUB_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter
End Class
