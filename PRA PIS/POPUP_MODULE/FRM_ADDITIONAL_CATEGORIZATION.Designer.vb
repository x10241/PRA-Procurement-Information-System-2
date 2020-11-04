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
        Me.LBL_ADDITIONAL_CATEGORIZATION = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_CATEGORIZATION_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.GRP_CATEGORY = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WTXT_GRP_CAT_NAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_CATEGORY_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_BRAND = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WTXT_GRP_BRAND_BRANDNAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_BRAND_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_SUB_CATEGORY_ADMIN = New System.Windows.Forms.GroupBox()
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CB_SUB_CATEGORY_CATEGORYNAME = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_SUBCATEGORY_CATEGORYNAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_SUB_CATEGORY_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TblM4_INVENTORY_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter()
        Me.TblM4_INVENTORY_ITEMBRANDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter()
        Me.GRP_CATEGORY_ADMIN = New System.Windows.Forms.GroupBox()
        Me.CB_CATEGORY_SUPPLY_TYPE = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_BRAND_ADMIN = New System.Windows.Forms.GroupBox()
        Me.CB_BRAND_SUPPLY_TYPE = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WTXT_BRAND_ADMIN_BRAND_NAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TblM4_INVENTORY_TYPETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_TYPETableAdapter()
        Me.GRP_SUB_CATEGORY = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_GRP_SUB_CAT_NAME = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.WTXT_GRP_SUB_SUBCAT_NAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SpM4_ITEM_CATEGORY_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_CATEGORY_CODE_GENERATORTableAdapter()
        Me.SpM4_ITEM_BRAND_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_BRAND_CODE_GENERATORTableAdapter()
        Me.SpM4_ITEM_SUB_CATEGORY_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_SUB_CATEGORY_CODE_GENERATORTableAdapter()
        Me.GRP_SIZE = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.WTXT_GRP_SIZE = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer7 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_COLOR = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.WTXT_GRP_COLOR = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer8 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_LENGTH = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WTXT_GRP_LENGTH = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer9 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_OTHER_DESC = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.WTXT_GRP_OTHER_DESC = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer10 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TBLM4_INV_ITEMS_LENG_MAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_LENG_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_LENG_MAINTableAdapter()
        Me.TBLM4_INV_ITEMS_OTHERS_MAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter()
        Me.GRP_ITEM_NAME = New System.Windows.Forms.GroupBox()
        Me.CB_INV_CAT = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CB_INV_SC = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYSUBCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.WTXT_ITEM_NAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer11 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TBLM4_INV_ITEMS_NAME_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_NAME_MAINTableAdapter()
        Me.TBLM4_INV_ITEMS_NAME_MAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter()
        Me.TBLM4_INV_ITEMS_COLOR_MAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_SIZE_MAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter()
        Me.SPM4_ITEM_COLOR_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_COLOR_CODE_GENERATORTableAdapter()
        Me.SPM4_ITEM_COLOR_CODE_GENERATORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_LENG_CODE_GENERATORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_LENG_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_LENG_CODE_GENERATORTableAdapter()
        Me.SPM4_ITEM_NAME_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_NAME_CODE_GENERATORTableAdapter()
        Me.SPM4_ITEM_NAME_CODE_GENERATORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_OTHERS_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_OTHERS_CODE_GENERATORTableAdapter()
        Me.SPM4_ITEM_OTHERS_CODE_GENERATORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_SIZE_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_SIZE_CODE_GENERATORTableAdapter()
        Me.SPM4_ITEM_SIZE_CODE_GENERATORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKtblM4INVENTORYITEMStblM4INVENTORYITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter()
        Me.PNL.SuspendLayout()
        Me.GRP_CATEGORY.SuspendLayout()
        Me.GRP_BRAND.SuspendLayout()
        Me.GRP_SUB_CATEGORY_ADMIN.SuspendLayout()
        CType(Me.TblM4INVENTORYTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_CATEGORY_ADMIN.SuspendLayout()
        Me.GRP_BRAND_ADMIN.SuspendLayout()
        Me.GRP_SUB_CATEGORY.SuspendLayout()
        Me.GRP_SIZE.SuspendLayout()
        Me.GRP_COLOR.SuspendLayout()
        Me.GRP_LENGTH.SuspendLayout()
        Me.GRP_OTHER_DESC.SuspendLayout()
        CType(Me.TBLM4_INV_ITEMS_LENG_MAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_OTHERS_MAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_ITEM_NAME.SuspendLayout()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_NAME_MAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_COLOR_MAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_SIZE_MAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_COLOR_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_LENG_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_NAME_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_OTHERS_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_SIZE_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblM4INVENTORYITEMStblM4INVENTORYITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_SAVE.Location = New System.Drawing.Point(287, 194)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(92, 32)
        Me.BTN_SAVE.TabIndex = 1409
        Me.BTN_SAVE.Text = "SAVE"
        Me.BTN_SAVE.UseVisualStyleBackColor = True
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4905, 11)
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
        Me.PNL.Controls.Add(Me.BTN_CATEGORIZATION_CLOSE)
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
        'BTN_CATEGORIZATION_CLOSE
        '
        Me.BTN_CATEGORIZATION_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CATEGORIZATION_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CATEGORIZATION_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CATEGORIZATION_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CATEGORIZATION_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CATEGORIZATION_CLOSE.Location = New System.Drawing.Point(352, 9)
        Me.BTN_CATEGORIZATION_CLOSE.Name = "BTN_CATEGORIZATION_CLOSE"
        Me.BTN_CATEGORIZATION_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_CATEGORIZATION_CLOSE.TabIndex = 17
        Me.BTN_CATEGORIZATION_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CATEGORIZATION_CLOSE.UseVisualStyleBackColor = True
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4858, 10)
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
        Me.GRP_CATEGORY.Controls.Add(Me.WTXT_GRP_CAT_NAME)
        Me.GRP_CATEGORY.Controls.Add(Me.ShapeContainer2)
        Me.GRP_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_CATEGORY.Location = New System.Drawing.Point(10, 51)
        Me.GRP_CATEGORY.Name = "GRP_CATEGORY"
        Me.GRP_CATEGORY.Size = New System.Drawing.Size(369, 137)
        Me.GRP_CATEGORY.TabIndex = 1442
        Me.GRP_CATEGORY.TabStop = False
        Me.GRP_CATEGORY.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 19)
        Me.Label1.TabIndex = 1430
        Me.Label1.Text = "Category Name"
        '
        'WTXT_GRP_CAT_NAME
        '
        Me.WTXT_GRP_CAT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_GRP_CAT_NAME.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_GRP_CAT_NAME.Location = New System.Drawing.Point(13, 65)
        Me.WTXT_GRP_CAT_NAME.MaxLength = 120
        Me.WTXT_GRP_CAT_NAME.Name = "WTXT_GRP_CAT_NAME"
        Me.WTXT_GRP_CAT_NAME.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_GRP_CAT_NAME.TabIndex = 1428
        Me.WTXT_GRP_CAT_NAME.Watermark = Nothing
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_CATEGORY_NAME})
        Me.ShapeContainer2.Size = New System.Drawing.Size(363, 111)
        Me.ShapeContainer2.TabIndex = 1429
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_CATEGORY_NAME
        '
        Me.RECT_CATEGORY_NAME.BorderColor = System.Drawing.Color.Gray
        Me.RECT_CATEGORY_NAME.BorderWidth = 2
        Me.RECT_CATEGORY_NAME.CornerRadius = 5
        Me.RECT_CATEGORY_NAME.Location = New System.Drawing.Point(5, 36)
        Me.RECT_CATEGORY_NAME.Name = "RECT_CATEGORY_NAME"
        Me.RECT_CATEGORY_NAME.Size = New System.Drawing.Size(348, 34)
        '
        'GRP_BRAND
        '
        Me.GRP_BRAND.Controls.Add(Me.Label7)
        Me.GRP_BRAND.Controls.Add(Me.WTXT_GRP_BRAND_BRANDNAME)
        Me.GRP_BRAND.Controls.Add(Me.ShapeContainer4)
        Me.GRP_BRAND.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_BRAND.Location = New System.Drawing.Point(10, 51)
        Me.GRP_BRAND.Name = "GRP_BRAND"
        Me.GRP_BRAND.Size = New System.Drawing.Size(369, 137)
        Me.GRP_BRAND.TabIndex = 1446
        Me.GRP_BRAND.TabStop = False
        Me.GRP_BRAND.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 1430
        Me.Label7.Text = "Brand Name"
        '
        'WTXT_GRP_BRAND_BRANDNAME
        '
        Me.WTXT_GRP_BRAND_BRANDNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_GRP_BRAND_BRANDNAME.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_GRP_BRAND_BRANDNAME.Location = New System.Drawing.Point(16, 62)
        Me.WTXT_GRP_BRAND_BRANDNAME.MaxLength = 120
        Me.WTXT_GRP_BRAND_BRANDNAME.Name = "WTXT_GRP_BRAND_BRANDNAME"
        Me.WTXT_GRP_BRAND_BRANDNAME.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_GRP_BRAND_BRANDNAME.TabIndex = 1428
        Me.WTXT_GRP_BRAND_BRANDNAME.Watermark = Nothing
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_BRAND_NAME})
        Me.ShapeContainer4.Size = New System.Drawing.Size(363, 111)
        Me.ShapeContainer4.TabIndex = 1429
        Me.ShapeContainer4.TabStop = False
        '
        'RECT_BRAND_NAME
        '
        Me.RECT_BRAND_NAME.BorderColor = System.Drawing.Color.Gray
        Me.RECT_BRAND_NAME.BorderWidth = 2
        Me.RECT_BRAND_NAME.CornerRadius = 5
        Me.RECT_BRAND_NAME.Location = New System.Drawing.Point(8, 33)
        Me.RECT_BRAND_NAME.Name = "RECT_BRAND_NAME"
        Me.RECT_BRAND_NAME.Size = New System.Drawing.Size(348, 32)
        '
        'GRP_SUB_CATEGORY_ADMIN
        '
        Me.GRP_SUB_CATEGORY_ADMIN.Controls.Add(Me.CB_SUB_CATEGORY_SUPPLY_TYPE)
        Me.GRP_SUB_CATEGORY_ADMIN.Controls.Add(Me.Label9)
        Me.GRP_SUB_CATEGORY_ADMIN.Controls.Add(Me.CB_SUB_CATEGORY_CATEGORYNAME)
        Me.GRP_SUB_CATEGORY_ADMIN.Controls.Add(Me.Label5)
        Me.GRP_SUB_CATEGORY_ADMIN.Controls.Add(Me.Label4)
        Me.GRP_SUB_CATEGORY_ADMIN.Controls.Add(Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME)
        Me.GRP_SUB_CATEGORY_ADMIN.Controls.Add(Me.ShapeContainer3)
        Me.GRP_SUB_CATEGORY_ADMIN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_SUB_CATEGORY_ADMIN.Location = New System.Drawing.Point(10, 336)
        Me.GRP_SUB_CATEGORY_ADMIN.Name = "GRP_SUB_CATEGORY_ADMIN"
        Me.GRP_SUB_CATEGORY_ADMIN.Size = New System.Drawing.Size(375, 195)
        Me.GRP_SUB_CATEGORY_ADMIN.TabIndex = 1447
        Me.GRP_SUB_CATEGORY_ADMIN.TabStop = False
        Me.GRP_SUB_CATEGORY_ADMIN.Visible = False
        '
        'CB_SUB_CATEGORY_SUPPLY_TYPE
        '
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.DataSource = Me.TblM4INVENTORYTYPEBindingSource
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.DisplayMember = "INV_DESC"
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.FormattingEnabled = True
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.Location = New System.Drawing.Point(16, 50)
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.Name = "CB_SUB_CATEGORY_SUPPLY_TYPE"
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.Size = New System.Drawing.Size(339, 27)
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.TabIndex = 1465
        Me.CB_SUB_CATEGORY_SUPPLY_TYPE.ValueMember = "INV_CODE"
        '
        'TblM4INVENTORYTYPEBindingSource
        '
        Me.TblM4INVENTORYTYPEBindingSource.DataMember = "tblM4_INVENTORY_TYPE"
        Me.TblM4INVENTORYTYPEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 19)
        Me.Label9.TabIndex = 1452
        Me.Label9.Text = "Supply Type"
        '
        'CB_SUB_CATEGORY_CATEGORYNAME
        '
        Me.CB_SUB_CATEGORY_CATEGORYNAME.DataSource = Me.TblM4INVENTORYCATEGORYBindingSource
        Me.CB_SUB_CATEGORY_CATEGORYNAME.DisplayMember = "CAT_NAME"
        Me.CB_SUB_CATEGORY_CATEGORYNAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SUB_CATEGORY_CATEGORYNAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_SUB_CATEGORY_CATEGORYNAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_SUB_CATEGORY_CATEGORYNAME.FormattingEnabled = True
        Me.CB_SUB_CATEGORY_CATEGORYNAME.Location = New System.Drawing.Point(16, 103)
        Me.CB_SUB_CATEGORY_CATEGORYNAME.Name = "CB_SUB_CATEGORY_CATEGORYNAME"
        Me.CB_SUB_CATEGORY_CATEGORYNAME.Size = New System.Drawing.Size(339, 27)
        Me.CB_SUB_CATEGORY_CATEGORYNAME.TabIndex = 1445
        Me.CB_SUB_CATEGORY_CATEGORYNAME.ValueMember = "CAT_CODE"
        '
        'TblM4INVENTORYCATEGORYBindingSource
        '
        Me.TblM4INVENTORYCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_CATEGORY"
        Me.TblM4INVENTORYCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 1445
        Me.Label5.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 19)
        Me.Label4.TabIndex = 1430
        Me.Label4.Text = "Sub Category Name"
        '
        'WTXT_SUB_CATEGORY_SUBCATEGORY_NAME
        '
        Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.Location = New System.Drawing.Point(16, 157)
        Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.MaxLength = 120
        Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.Name = "WTXT_SUB_CATEGORY_SUBCATEGORY_NAME"
        Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.TabIndex = 1428
        Me.WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.Watermark = Nothing
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RECT_SUBCATEGORY_CATEGORYNAME, Me.RECT_SUB_CATEGORY_NAME})
        Me.ShapeContainer3.Size = New System.Drawing.Size(369, 169)
        Me.ShapeContainer3.TabIndex = 1429
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Location = New System.Drawing.Point(8, 23)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(348, 33)
        '
        'RECT_SUBCATEGORY_CATEGORYNAME
        '
        Me.RECT_SUBCATEGORY_CATEGORYNAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_SUBCATEGORY_CATEGORYNAME.BorderWidth = 2
        Me.RECT_SUBCATEGORY_CATEGORYNAME.CornerRadius = 5
        Me.RECT_SUBCATEGORY_CATEGORYNAME.Location = New System.Drawing.Point(8, 77)
        Me.RECT_SUBCATEGORY_CATEGORYNAME.Name = "RECT_SUBCATEGORY_CATEGORYNAME"
        Me.RECT_SUBCATEGORY_CATEGORYNAME.Size = New System.Drawing.Size(348, 33)
        '
        'RECT_SUB_CATEGORY_NAME
        '
        Me.RECT_SUB_CATEGORY_NAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_SUB_CATEGORY_NAME.BorderWidth = 2
        Me.RECT_SUB_CATEGORY_NAME.CornerRadius = 5
        Me.RECT_SUB_CATEGORY_NAME.Location = New System.Drawing.Point(8, 127)
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
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Me.TblM4_INVENTORY_CATEGORYTableAdapter
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Me.TblM4_INVENTORY_ITEMBRANDTableAdapter
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMSTableAdapter = Nothing
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
        'TblM4_INVENTORY_SUB_CATEGORYBindingSource
        '
        Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource.DataMember = "tblM4_INVENTORY_SUB_CATEGORY"
        Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_SUB_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'GRP_CATEGORY_ADMIN
        '
        Me.GRP_CATEGORY_ADMIN.Controls.Add(Me.CB_CATEGORY_SUPPLY_TYPE)
        Me.GRP_CATEGORY_ADMIN.Controls.Add(Me.Label3)
        Me.GRP_CATEGORY_ADMIN.Controls.Add(Me.Label2)
        Me.GRP_CATEGORY_ADMIN.Controls.Add(Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN)
        Me.GRP_CATEGORY_ADMIN.Controls.Add(Me.ShapeContainer1)
        Me.GRP_CATEGORY_ADMIN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_CATEGORY_ADMIN.Location = New System.Drawing.Point(391, 336)
        Me.GRP_CATEGORY_ADMIN.Name = "GRP_CATEGORY_ADMIN"
        Me.GRP_CATEGORY_ADMIN.Size = New System.Drawing.Size(375, 195)
        Me.GRP_CATEGORY_ADMIN.TabIndex = 1448
        Me.GRP_CATEGORY_ADMIN.TabStop = False
        Me.GRP_CATEGORY_ADMIN.Visible = False
        '
        'CB_CATEGORY_SUPPLY_TYPE
        '
        Me.CB_CATEGORY_SUPPLY_TYPE.DataSource = Me.TblM4INVENTORYTYPEBindingSource
        Me.CB_CATEGORY_SUPPLY_TYPE.DisplayMember = "INV_DESC"
        Me.CB_CATEGORY_SUPPLY_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CATEGORY_SUPPLY_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_CATEGORY_SUPPLY_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_CATEGORY_SUPPLY_TYPE.FormattingEnabled = True
        Me.CB_CATEGORY_SUPPLY_TYPE.Location = New System.Drawing.Point(17, 43)
        Me.CB_CATEGORY_SUPPLY_TYPE.Name = "CB_CATEGORY_SUPPLY_TYPE"
        Me.CB_CATEGORY_SUPPLY_TYPE.Size = New System.Drawing.Size(339, 27)
        Me.CB_CATEGORY_SUPPLY_TYPE.TabIndex = 1465
        Me.CB_CATEGORY_SUPPLY_TYPE.ValueMember = "INV_CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 1449
        Me.Label3.Text = "Supply Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 19)
        Me.Label2.TabIndex = 1430
        Me.Label2.Text = "Category Name"
        '
        'WTXT_CATEGORY_CATEGORY_NAME_ADMIN
        '
        Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN.Location = New System.Drawing.Point(16, 91)
        Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN.MaxLength = 120
        Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN.Name = "WTXT_CATEGORY_CATEGORY_NAME_ADMIN"
        Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN.TabIndex = 1428
        Me.WTXT_CATEGORY_CATEGORY_NAME_ADMIN.Watermark = Nothing
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(369, 169)
        Me.ShapeContainer1.TabIndex = 1429
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(9, 16)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(348, 32)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 62)
        Me.RectangleShape1.Name = "RECT_CATEGORY_NAME"
        Me.RectangleShape1.Size = New System.Drawing.Size(348, 32)
        '
        'GRP_BRAND_ADMIN
        '
        Me.GRP_BRAND_ADMIN.Controls.Add(Me.CB_BRAND_SUPPLY_TYPE)
        Me.GRP_BRAND_ADMIN.Controls.Add(Me.Label8)
        Me.GRP_BRAND_ADMIN.Controls.Add(Me.Label6)
        Me.GRP_BRAND_ADMIN.Controls.Add(Me.WTXT_BRAND_ADMIN_BRAND_NAME)
        Me.GRP_BRAND_ADMIN.Controls.Add(Me.ShapeContainer5)
        Me.GRP_BRAND_ADMIN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_BRAND_ADMIN.Location = New System.Drawing.Point(781, 336)
        Me.GRP_BRAND_ADMIN.Name = "GRP_BRAND_ADMIN"
        Me.GRP_BRAND_ADMIN.Size = New System.Drawing.Size(375, 195)
        Me.GRP_BRAND_ADMIN.TabIndex = 1449
        Me.GRP_BRAND_ADMIN.TabStop = False
        Me.GRP_BRAND_ADMIN.Visible = False
        '
        'CB_BRAND_SUPPLY_TYPE
        '
        Me.CB_BRAND_SUPPLY_TYPE.DataSource = Me.TblM4INVENTORYTYPEBindingSource
        Me.CB_BRAND_SUPPLY_TYPE.DisplayMember = "INV_DESC"
        Me.CB_BRAND_SUPPLY_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_BRAND_SUPPLY_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_BRAND_SUPPLY_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_BRAND_SUPPLY_TYPE.FormattingEnabled = True
        Me.CB_BRAND_SUPPLY_TYPE.Location = New System.Drawing.Point(16, 76)
        Me.CB_BRAND_SUPPLY_TYPE.Name = "CB_BRAND_SUPPLY_TYPE"
        Me.CB_BRAND_SUPPLY_TYPE.Size = New System.Drawing.Size(339, 27)
        Me.CB_BRAND_SUPPLY_TYPE.TabIndex = 1464
        Me.CB_BRAND_SUPPLY_TYPE.ValueMember = "INV_CODE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 19)
        Me.Label8.TabIndex = 1451
        Me.Label8.Text = "Supply Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 1430
        Me.Label6.Text = "Brand Name"
        '
        'WTXT_BRAND_ADMIN_BRAND_NAME
        '
        Me.WTXT_BRAND_ADMIN_BRAND_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_BRAND_ADMIN_BRAND_NAME.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_BRAND_ADMIN_BRAND_NAME.Location = New System.Drawing.Point(16, 132)
        Me.WTXT_BRAND_ADMIN_BRAND_NAME.MaxLength = 120
        Me.WTXT_BRAND_ADMIN_BRAND_NAME.Name = "WTXT_BRAND_ADMIN_BRAND_NAME"
        Me.WTXT_BRAND_ADMIN_BRAND_NAME.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_BRAND_ADMIN_BRAND_NAME.TabIndex = 1428
        Me.WTXT_BRAND_ADMIN_BRAND_NAME.Watermark = Nothing
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3})
        Me.ShapeContainer5.Size = New System.Drawing.Size(369, 169)
        Me.ShapeContainer5.TabIndex = 1429
        Me.ShapeContainer5.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(8, 50)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(348, 32)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(8, 102)
        Me.RectangleShape3.Name = "RECT_BRAND_NAME"
        Me.RectangleShape3.Size = New System.Drawing.Size(348, 32)
        '
        'TblM4_INVENTORY_TYPETableAdapter
        '
        Me.TblM4_INVENTORY_TYPETableAdapter.ClearBeforeFill = True
        '
        'GRP_SUB_CATEGORY
        '
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.Label12)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.CB_GRP_SUB_CAT_NAME)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.Label11)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.WTXT_GRP_SUB_SUBCAT_NAME)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.ShapeContainer6)
        Me.GRP_SUB_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_SUB_CATEGORY.Location = New System.Drawing.Point(10, 51)
        Me.GRP_SUB_CATEGORY.Name = "GRP_SUB_CATEGORY"
        Me.GRP_SUB_CATEGORY.Size = New System.Drawing.Size(369, 137)
        Me.GRP_SUB_CATEGORY.TabIndex = 1450
        Me.GRP_SUB_CATEGORY.TabStop = False
        Me.GRP_SUB_CATEGORY.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 19)
        Me.Label12.TabIndex = 1430
        Me.Label12.Text = "Sub Category Name"
        '
        'CB_GRP_SUB_CAT_NAME
        '
        Me.CB_GRP_SUB_CAT_NAME.DataSource = Me.TblM4INVENTORYCATEGORYBindingSource
        Me.CB_GRP_SUB_CAT_NAME.DisplayMember = "CAT_NAME"
        Me.CB_GRP_SUB_CAT_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_GRP_SUB_CAT_NAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_GRP_SUB_CAT_NAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_GRP_SUB_CAT_NAME.FormattingEnabled = True
        Me.CB_GRP_SUB_CAT_NAME.Location = New System.Drawing.Point(16, 40)
        Me.CB_GRP_SUB_CAT_NAME.Name = "CB_GRP_SUB_CAT_NAME"
        Me.CB_GRP_SUB_CAT_NAME.Size = New System.Drawing.Size(339, 29)
        Me.CB_GRP_SUB_CAT_NAME.TabIndex = 1445
        Me.CB_GRP_SUB_CAT_NAME.ValueMember = "CAT_CODE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 19)
        Me.Label11.TabIndex = 1445
        Me.Label11.Text = "Category Name"
        '
        'WTXT_GRP_SUB_SUBCAT_NAME
        '
        Me.WTXT_GRP_SUB_SUBCAT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_GRP_SUB_SUBCAT_NAME.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_GRP_SUB_SUBCAT_NAME.Location = New System.Drawing.Point(16, 92)
        Me.WTXT_GRP_SUB_SUBCAT_NAME.MaxLength = 120
        Me.WTXT_GRP_SUB_SUBCAT_NAME.Name = "WTXT_GRP_SUB_SUBCAT_NAME"
        Me.WTXT_GRP_SUB_SUBCAT_NAME.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_GRP_SUB_SUBCAT_NAME.TabIndex = 1428
        Me.WTXT_GRP_SUB_SUBCAT_NAME.Watermark = Nothing
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape7, Me.RectangleShape8})
        Me.ShapeContainer6.Size = New System.Drawing.Size(363, 111)
        Me.ShapeContainer6.TabIndex = 1429
        Me.ShapeContainer6.TabStop = False
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape7.BorderWidth = 2
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(8, 13)
        Me.RectangleShape7.Name = "RECT_SUBCATEGORY_CATEGORYNAME"
        Me.RectangleShape7.Size = New System.Drawing.Size(348, 33)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape8.BorderWidth = 2
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.Location = New System.Drawing.Point(8, 63)
        Me.RectangleShape8.Name = "RECT_SUB_CATEGORY_NAME"
        Me.RectangleShape8.Size = New System.Drawing.Size(348, 33)
        '
        'SpM4_ITEM_CATEGORY_CODE_GENERATORTableAdapter
        '
        Me.SpM4_ITEM_CATEGORY_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'SpM4_ITEM_BRAND_CODE_GENERATORTableAdapter
        '
        Me.SpM4_ITEM_BRAND_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'SpM4_ITEM_SUB_CATEGORY_CODE_GENERATORTableAdapter
        '
        Me.SpM4_ITEM_SUB_CATEGORY_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'GRP_SIZE
        '
        Me.GRP_SIZE.Controls.Add(Me.Label10)
        Me.GRP_SIZE.Controls.Add(Me.WTXT_GRP_SIZE)
        Me.GRP_SIZE.Controls.Add(Me.ShapeContainer7)
        Me.GRP_SIZE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_SIZE.Location = New System.Drawing.Point(10, 51)
        Me.GRP_SIZE.Name = "GRP_SIZE"
        Me.GRP_SIZE.Size = New System.Drawing.Size(369, 137)
        Me.GRP_SIZE.TabIndex = 1451
        Me.GRP_SIZE.TabStop = False
        Me.GRP_SIZE.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 19)
        Me.Label10.TabIndex = 1430
        Me.Label10.Text = "Size"
        '
        'WTXT_GRP_SIZE
        '
        Me.WTXT_GRP_SIZE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_GRP_SIZE.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_GRP_SIZE.Location = New System.Drawing.Point(16, 62)
        Me.WTXT_GRP_SIZE.MaxLength = 120
        Me.WTXT_GRP_SIZE.Name = "WTXT_GRP_SIZE"
        Me.WTXT_GRP_SIZE.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_GRP_SIZE.TabIndex = 1428
        Me.WTXT_GRP_SIZE.Watermark = Nothing
        '
        'ShapeContainer7
        '
        Me.ShapeContainer7.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer7.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer7.Name = "ShapeContainer7"
        Me.ShapeContainer7.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape6})
        Me.ShapeContainer7.Size = New System.Drawing.Size(363, 111)
        Me.ShapeContainer7.TabIndex = 1429
        Me.ShapeContainer7.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.CornerRadius = 5
        Me.RectangleShape6.Location = New System.Drawing.Point(8, 33)
        Me.RectangleShape6.Name = "RECT_BRAND_NAME"
        Me.RectangleShape6.Size = New System.Drawing.Size(348, 32)
        '
        'GRP_COLOR
        '
        Me.GRP_COLOR.Controls.Add(Me.Label13)
        Me.GRP_COLOR.Controls.Add(Me.WTXT_GRP_COLOR)
        Me.GRP_COLOR.Controls.Add(Me.ShapeContainer8)
        Me.GRP_COLOR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_COLOR.Location = New System.Drawing.Point(10, 51)
        Me.GRP_COLOR.Name = "GRP_COLOR"
        Me.GRP_COLOR.Size = New System.Drawing.Size(369, 137)
        Me.GRP_COLOR.TabIndex = 1452
        Me.GRP_COLOR.TabStop = False
        Me.GRP_COLOR.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 19)
        Me.Label13.TabIndex = 1430
        Me.Label13.Text = "Color"
        '
        'WTXT_GRP_COLOR
        '
        Me.WTXT_GRP_COLOR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_GRP_COLOR.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_GRP_COLOR.Location = New System.Drawing.Point(16, 61)
        Me.WTXT_GRP_COLOR.MaxLength = 120
        Me.WTXT_GRP_COLOR.Name = "WTXT_GRP_COLOR"
        Me.WTXT_GRP_COLOR.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_GRP_COLOR.TabIndex = 1428
        Me.WTXT_GRP_COLOR.Watermark = Nothing
        '
        'ShapeContainer8
        '
        Me.ShapeContainer8.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer8.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer8.Name = "ShapeContainer8"
        Me.ShapeContainer8.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape9})
        Me.ShapeContainer8.Size = New System.Drawing.Size(363, 111)
        Me.ShapeContainer8.TabIndex = 1429
        Me.ShapeContainer8.TabStop = False
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape9.BorderWidth = 2
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.Location = New System.Drawing.Point(8, 33)
        Me.RectangleShape9.Name = "RECT_BRAND_NAME"
        Me.RectangleShape9.Size = New System.Drawing.Size(348, 32)
        '
        'GRP_LENGTH
        '
        Me.GRP_LENGTH.Controls.Add(Me.Label14)
        Me.GRP_LENGTH.Controls.Add(Me.WTXT_GRP_LENGTH)
        Me.GRP_LENGTH.Controls.Add(Me.ShapeContainer9)
        Me.GRP_LENGTH.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_LENGTH.Location = New System.Drawing.Point(10, 51)
        Me.GRP_LENGTH.Name = "GRP_LENGTH"
        Me.GRP_LENGTH.Size = New System.Drawing.Size(369, 137)
        Me.GRP_LENGTH.TabIndex = 1453
        Me.GRP_LENGTH.TabStop = False
        Me.GRP_LENGTH.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 19)
        Me.Label14.TabIndex = 1430
        Me.Label14.Text = "Length"
        '
        'WTXT_GRP_LENGTH
        '
        Me.WTXT_GRP_LENGTH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_GRP_LENGTH.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_GRP_LENGTH.Location = New System.Drawing.Point(16, 61)
        Me.WTXT_GRP_LENGTH.MaxLength = 120
        Me.WTXT_GRP_LENGTH.Name = "WTXT_GRP_LENGTH"
        Me.WTXT_GRP_LENGTH.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_GRP_LENGTH.TabIndex = 1428
        Me.WTXT_GRP_LENGTH.Watermark = Nothing
        '
        'ShapeContainer9
        '
        Me.ShapeContainer9.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer9.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer9.Name = "ShapeContainer9"
        Me.ShapeContainer9.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape10})
        Me.ShapeContainer9.Size = New System.Drawing.Size(363, 111)
        Me.ShapeContainer9.TabIndex = 1429
        Me.ShapeContainer9.TabStop = False
        '
        'RectangleShape10
        '
        Me.RectangleShape10.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape10.BorderWidth = 2
        Me.RectangleShape10.CornerRadius = 5
        Me.RectangleShape10.Location = New System.Drawing.Point(8, 33)
        Me.RectangleShape10.Name = "RECT_BRAND_NAME"
        Me.RectangleShape10.Size = New System.Drawing.Size(348, 32)
        '
        'GRP_OTHER_DESC
        '
        Me.GRP_OTHER_DESC.Controls.Add(Me.Label15)
        Me.GRP_OTHER_DESC.Controls.Add(Me.WTXT_GRP_OTHER_DESC)
        Me.GRP_OTHER_DESC.Controls.Add(Me.ShapeContainer10)
        Me.GRP_OTHER_DESC.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_OTHER_DESC.Location = New System.Drawing.Point(10, 51)
        Me.GRP_OTHER_DESC.Name = "GRP_OTHER_DESC"
        Me.GRP_OTHER_DESC.Size = New System.Drawing.Size(369, 137)
        Me.GRP_OTHER_DESC.TabIndex = 1454
        Me.GRP_OTHER_DESC.TabStop = False
        Me.GRP_OTHER_DESC.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 19)
        Me.Label15.TabIndex = 1430
        Me.Label15.Text = "Other Description"
        '
        'WTXT_GRP_OTHER_DESC
        '
        Me.WTXT_GRP_OTHER_DESC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_GRP_OTHER_DESC.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_GRP_OTHER_DESC.Location = New System.Drawing.Point(16, 61)
        Me.WTXT_GRP_OTHER_DESC.MaxLength = 120
        Me.WTXT_GRP_OTHER_DESC.Name = "WTXT_GRP_OTHER_DESC"
        Me.WTXT_GRP_OTHER_DESC.Size = New System.Drawing.Size(339, 24)
        Me.WTXT_GRP_OTHER_DESC.TabIndex = 1428
        Me.WTXT_GRP_OTHER_DESC.Watermark = Nothing
        '
        'ShapeContainer10
        '
        Me.ShapeContainer10.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer10.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer10.Name = "ShapeContainer10"
        Me.ShapeContainer10.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape11})
        Me.ShapeContainer10.Size = New System.Drawing.Size(363, 111)
        Me.ShapeContainer10.TabIndex = 1429
        Me.ShapeContainer10.TabStop = False
        '
        'RectangleShape11
        '
        Me.RectangleShape11.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape11.BorderWidth = 2
        Me.RectangleShape11.CornerRadius = 5
        Me.RectangleShape11.Location = New System.Drawing.Point(8, 33)
        Me.RectangleShape11.Name = "RECT_BRAND_NAME"
        Me.RectangleShape11.Size = New System.Drawing.Size(348, 32)
        '
        'TBLM4_INV_ITEMS_LENG_MAINBindingSource
        '
        Me.TBLM4_INV_ITEMS_LENG_MAINBindingSource.DataMember = "TBLM4_INV_ITEMS_LENG_MAIN"
        Me.TBLM4_INV_ITEMS_LENG_MAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_LENG_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_LENG_MAINTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_OTHERS_MAINBindingSource
        '
        Me.TBLM4_INV_ITEMS_OTHERS_MAINBindingSource.DataMember = "TBLM4_INV_ITEMS_OTHERS_MAIN"
        Me.TBLM4_INV_ITEMS_OTHERS_MAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter.ClearBeforeFill = True
        '
        'GRP_ITEM_NAME
        '
        Me.GRP_ITEM_NAME.Controls.Add(Me.CB_INV_CAT)
        Me.GRP_ITEM_NAME.Controls.Add(Me.Label18)
        Me.GRP_ITEM_NAME.Controls.Add(Me.CB_INV_SC)
        Me.GRP_ITEM_NAME.Controls.Add(Me.Label17)
        Me.GRP_ITEM_NAME.Controls.Add(Me.Label16)
        Me.GRP_ITEM_NAME.Controls.Add(Me.WTXT_ITEM_NAME)
        Me.GRP_ITEM_NAME.Controls.Add(Me.ShapeContainer11)
        Me.GRP_ITEM_NAME.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_ITEM_NAME.Location = New System.Drawing.Point(10, 51)
        Me.GRP_ITEM_NAME.Name = "GRP_ITEM_NAME"
        Me.GRP_ITEM_NAME.Size = New System.Drawing.Size(369, 140)
        Me.GRP_ITEM_NAME.TabIndex = 1455
        Me.GRP_ITEM_NAME.TabStop = False
        Me.GRP_ITEM_NAME.Visible = False
        '
        'CB_INV_CAT
        '
        Me.CB_INV_CAT.DataSource = Me.TblM4INVENTORYCATEGORYBindingSource
        Me.CB_INV_CAT.DisplayMember = "CAT_NAME"
        Me.CB_INV_CAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_CAT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_CAT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_CAT.FormattingEnabled = True
        Me.CB_INV_CAT.Location = New System.Drawing.Point(17, 26)
        Me.CB_INV_CAT.Name = "CB_INV_CAT"
        Me.CB_INV_CAT.Size = New System.Drawing.Size(339, 25)
        Me.CB_INV_CAT.TabIndex = 1457
        Me.CB_INV_CAT.ValueMember = "CAT_CODE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(22, 10)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 1457
        Me.Label18.Text = "Category"
        '
        'CB_INV_SC
        '
        Me.CB_INV_SC.DataSource = Me.TblM4INVENTORYSUBCATEGORYBindingSource
        Me.CB_INV_SC.DisplayMember = "SC_SUBCATEGORY_NAME"
        Me.CB_INV_SC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_SC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_SC.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_SC.FormattingEnabled = True
        Me.CB_INV_SC.Location = New System.Drawing.Point(17, 69)
        Me.CB_INV_SC.Name = "CB_INV_SC"
        Me.CB_INV_SC.Size = New System.Drawing.Size(339, 25)
        Me.CB_INV_SC.TabIndex = 1456
        Me.CB_INV_SC.ValueMember = "SC_NO"
        '
        'TblM4INVENTORYSUBCATEGORYBindingSource
        '
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_SUB_CATEGORY"
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 16)
        Me.Label17.TabIndex = 1431
        Me.Label17.Text = "Sub category"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 16)
        Me.Label16.TabIndex = 1430
        Me.Label16.Text = "Item Name"
        '
        'WTXT_ITEM_NAME
        '
        Me.WTXT_ITEM_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_NAME.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_NAME.Location = New System.Drawing.Point(16, 114)
        Me.WTXT_ITEM_NAME.MaxLength = 120
        Me.WTXT_ITEM_NAME.Name = "WTXT_ITEM_NAME"
        Me.WTXT_ITEM_NAME.Size = New System.Drawing.Size(339, 16)
        Me.WTXT_ITEM_NAME.TabIndex = 1428
        Me.WTXT_ITEM_NAME.Watermark = Nothing
        '
        'ShapeContainer11
        '
        Me.ShapeContainer11.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer11.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer11.Name = "ShapeContainer11"
        Me.ShapeContainer11.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape14, Me.RectangleShape13, Me.RectangleShape12})
        Me.ShapeContainer11.Size = New System.Drawing.Size(363, 114)
        Me.ShapeContainer11.TabIndex = 1429
        Me.ShapeContainer11.TabStop = False
        '
        'RectangleShape14
        '
        Me.RectangleShape14.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape14.BorderWidth = 2
        Me.RectangleShape14.CornerRadius = 5
        Me.RectangleShape14.Location = New System.Drawing.Point(7, 1)
        Me.RectangleShape14.Name = "RectangleShape14"
        Me.RectangleShape14.Size = New System.Drawing.Size(348, 28)
        '
        'RectangleShape13
        '
        Me.RectangleShape13.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape13.BorderWidth = 2
        Me.RectangleShape13.CornerRadius = 5
        Me.RectangleShape13.Location = New System.Drawing.Point(7, 44)
        Me.RectangleShape13.Name = "RectangleShape13"
        Me.RectangleShape13.Size = New System.Drawing.Size(348, 28)
        '
        'RectangleShape12
        '
        Me.RectangleShape12.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape12.BorderWidth = 2
        Me.RectangleShape12.CornerRadius = 5
        Me.RectangleShape12.Location = New System.Drawing.Point(8, 85)
        Me.RectangleShape12.Name = "RECT_BRAND_NAME"
        Me.RectangleShape12.Size = New System.Drawing.Size(348, 26)
        '
        'TBLM4_INV_ITEMS_NAME_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_NAME_MAINTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_NAME_MAINBindingSource
        '
        Me.TBLM4_INV_ITEMS_NAME_MAINBindingSource.DataMember = "TBLM4_INV_ITEMS_NAME_MAIN"
        Me.TBLM4_INV_ITEMS_NAME_MAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_COLOR_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_COLOR_MAINBindingSource
        '
        Me.TBLM4_INV_ITEMS_COLOR_MAINBindingSource.DataMember = "TBLM4_INV_ITEMS_COLOR_MAIN"
        Me.TBLM4_INV_ITEMS_COLOR_MAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_SIZE_MAINBindingSource
        '
        Me.TBLM4_INV_ITEMS_SIZE_MAINBindingSource.DataMember = "TBLM4_INV_ITEMS_SIZE_MAIN"
        Me.TBLM4_INV_ITEMS_SIZE_MAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_SIZE_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_COLOR_CODE_GENERATORTableAdapter
        '
        Me.SPM4_ITEM_COLOR_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_COLOR_CODE_GENERATORBindingSource
        '
        Me.SPM4_ITEM_COLOR_CODE_GENERATORBindingSource.DataMember = "SPM4_ITEM_COLOR_CODE_GENERATOR"
        '
        'SPM4_ITEM_LENG_CODE_GENERATORBindingSource
        '
        Me.SPM4_ITEM_LENG_CODE_GENERATORBindingSource.DataMember = "SPM4_ITEM_LENG_CODE_GENERATOR"
        '
        'SPM4_ITEM_LENG_CODE_GENERATORTableAdapter
        '
        Me.SPM4_ITEM_LENG_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_NAME_CODE_GENERATORTableAdapter
        '
        Me.SPM4_ITEM_NAME_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_NAME_CODE_GENERATORBindingSource
        '
        Me.SPM4_ITEM_NAME_CODE_GENERATORBindingSource.DataMember = "SPM4_ITEM_NAME_CODE_GENERATOR"
        '
        'SPM4_ITEM_OTHERS_CODE_GENERATORTableAdapter
        '
        Me.SPM4_ITEM_OTHERS_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_OTHERS_CODE_GENERATORBindingSource
        '
        Me.SPM4_ITEM_OTHERS_CODE_GENERATORBindingSource.DataMember = "SPM4_ITEM_OTHERS_CODE_GENERATOR"
        '
        'SPM4_ITEM_SIZE_CODE_GENERATORTableAdapter
        '
        Me.SPM4_ITEM_SIZE_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_SIZE_CODE_GENERATORBindingSource
        '
        Me.SPM4_ITEM_SIZE_CODE_GENERATORBindingSource.DataMember = "SPM4_ITEM_SIZE_CODE_GENERATOR"
        '
        'FKtblM4INVENTORYITEMStblM4INVENTORYITEMSBindingSource
        '
        Me.FKtblM4INVENTORYITEMStblM4INVENTORYITEMSBindingSource.DataMember = "FK_tblM4_INVENTORY_ITEMS_tblM4_INVENTORY_ITEMS"
        Me.FKtblM4INVENTORYITEMStblM4INVENTORYITEMSBindingSource.DataSource = Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource
        '
        'TblM4_INVENTORY_ITEMSTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMSTableAdapter.ClearBeforeFill = True
        '
        'FRM_ADDITIONAL_CATEGORIZATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(388, 234)
        Me.Controls.Add(Me.GRP_ITEM_NAME)
        Me.Controls.Add(Me.GRP_OTHER_DESC)
        Me.Controls.Add(Me.GRP_LENGTH)
        Me.Controls.Add(Me.GRP_COLOR)
        Me.Controls.Add(Me.GRP_SIZE)
        Me.Controls.Add(Me.GRP_SUB_CATEGORY)
        Me.Controls.Add(Me.GRP_BRAND_ADMIN)
        Me.Controls.Add(Me.GRP_CATEGORY_ADMIN)
        Me.Controls.Add(Me.GRP_SUB_CATEGORY_ADMIN)
        Me.Controls.Add(Me.GRP_BRAND)
        Me.Controls.Add(Me.GRP_CATEGORY)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_ADDITIONAL_CATEGORIZATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.GRP_CATEGORY.ResumeLayout(False)
        Me.GRP_CATEGORY.PerformLayout()
        Me.GRP_BRAND.ResumeLayout(False)
        Me.GRP_BRAND.PerformLayout()
        Me.GRP_SUB_CATEGORY_ADMIN.ResumeLayout(False)
        Me.GRP_SUB_CATEGORY_ADMIN.PerformLayout()
        CType(Me.TblM4INVENTORYTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_CATEGORY_ADMIN.ResumeLayout(False)
        Me.GRP_CATEGORY_ADMIN.PerformLayout()
        Me.GRP_BRAND_ADMIN.ResumeLayout(False)
        Me.GRP_BRAND_ADMIN.PerformLayout()
        Me.GRP_SUB_CATEGORY.ResumeLayout(False)
        Me.GRP_SUB_CATEGORY.PerformLayout()
        Me.GRP_SIZE.ResumeLayout(False)
        Me.GRP_SIZE.PerformLayout()
        Me.GRP_COLOR.ResumeLayout(False)
        Me.GRP_COLOR.PerformLayout()
        Me.GRP_LENGTH.ResumeLayout(False)
        Me.GRP_LENGTH.PerformLayout()
        Me.GRP_OTHER_DESC.ResumeLayout(False)
        Me.GRP_OTHER_DESC.PerformLayout()
        CType(Me.TBLM4_INV_ITEMS_LENG_MAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_OTHERS_MAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_ITEM_NAME.ResumeLayout(False)
        Me.GRP_ITEM_NAME.PerformLayout()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_NAME_MAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_COLOR_MAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_SIZE_MAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_COLOR_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_LENG_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_NAME_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_OTHERS_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_SIZE_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblM4INVENTORYITEMStblM4INVENTORYITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents LBL_ADDITIONAL_CATEGORIZATION As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents GRP_CATEGORY As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WTXT_GRP_CAT_NAME As WatermarkTextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_CATEGORY_NAME As PowerPacks.RectangleShape
    Friend WithEvents GRP_BRAND As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents WTXT_GRP_BRAND_BRANDNAME As WatermarkTextBox
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_BRAND_NAME As PowerPacks.RectangleShape
    Friend WithEvents GRP_SUB_CATEGORY_ADMIN As GroupBox
    Friend WithEvents CB_SUB_CATEGORY_CATEGORYNAME As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents WTXT_SUB_CATEGORY_SUBCATEGORY_NAME As WatermarkTextBox
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
    Friend WithEvents GRP_CATEGORY_ADMIN As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WTXT_CATEGORY_CATEGORY_NAME_ADMIN As WatermarkTextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents GRP_BRAND_ADMIN As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents WTXT_BRAND_ADMIN_BRAND_NAME As WatermarkTextBox
    Friend WithEvents ShapeContainer5 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents CB_CATEGORY_SUPPLY_TYPE As ComboBox
    Friend WithEvents CB_BRAND_SUPPLY_TYPE As ComboBox
    Friend WithEvents TblM4INVENTORYTYPEBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_TYPETableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_TYPETableAdapter
    Friend WithEvents CB_SUB_CATEGORY_SUPPLY_TYPE As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents GRP_SUB_CATEGORY As GroupBox
    Friend WithEvents CB_GRP_SUB_CAT_NAME As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents WTXT_GRP_SUB_SUBCAT_NAME As WatermarkTextBox
    Friend WithEvents ShapeContainer6 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents SpM4_ITEM_CATEGORY_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_CATEGORY_CODE_GENERATORTableAdapter
    Friend WithEvents SpM4_ITEM_BRAND_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_BRAND_CODE_GENERATORTableAdapter
    Friend WithEvents SpM4_ITEM_SUB_CATEGORY_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_SUB_CATEGORY_CODE_GENERATORTableAdapter
    Friend WithEvents GRP_SIZE As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents WTXT_GRP_SIZE As WatermarkTextBox
    Friend WithEvents ShapeContainer7 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents GRP_COLOR As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents WTXT_GRP_COLOR As WatermarkTextBox
    Friend WithEvents ShapeContainer8 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents BTN_CATEGORIZATION_CLOSE As Button
    Friend WithEvents GRP_LENGTH As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents WTXT_GRP_LENGTH As WatermarkTextBox
    Friend WithEvents ShapeContainer9 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape10 As PowerPacks.RectangleShape
    Friend WithEvents GRP_OTHER_DESC As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents WTXT_GRP_OTHER_DESC As WatermarkTextBox
    Friend WithEvents ShapeContainer10 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape11 As PowerPacks.RectangleShape
    Friend WithEvents TBLM4_INV_ITEMS_LENG_MAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_LENG_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_LENG_MAINTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_OTHERS_MAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter
    Friend WithEvents GRP_ITEM_NAME As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents WTXT_ITEM_NAME As WatermarkTextBox
    Friend WithEvents ShapeContainer11 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape12 As PowerPacks.RectangleShape
    Friend WithEvents TBLM4_INV_ITEMS_NAME_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_NAME_MAINTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_NAME_MAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_COLOR_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_COLOR_MAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_SIZE_MAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_SIZE_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter
    Friend WithEvents SPM4_ITEM_COLOR_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_COLOR_CODE_GENERATORTableAdapter
    Friend WithEvents SPM4_ITEM_COLOR_CODE_GENERATORBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_LENG_CODE_GENERATORBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_LENG_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_LENG_CODE_GENERATORTableAdapter
    Friend WithEvents SPM4_ITEM_NAME_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_NAME_CODE_GENERATORTableAdapter
    Friend WithEvents SPM4_ITEM_NAME_CODE_GENERATORBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_OTHERS_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_OTHERS_CODE_GENERATORTableAdapter
    Friend WithEvents SPM4_ITEM_OTHERS_CODE_GENERATORBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_SIZE_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_SIZE_CODE_GENERATORTableAdapter
    Friend WithEvents SPM4_ITEM_SIZE_CODE_GENERATORBindingSource As BindingSource
    Friend WithEvents CB_INV_SC As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents RectangleShape13 As PowerPacks.RectangleShape
    Friend WithEvents FKtblM4INVENTORYITEMStblM4INVENTORYITEMSBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter
    Friend WithEvents TblM4INVENTORYSUBCATEGORYBindingSource As BindingSource
    Friend WithEvents CB_INV_CAT As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents RectangleShape14 As PowerPacks.RectangleShape
End Class
