<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_SETTINGS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_SETTINGS))
        Me.DGV_MAINTENANCE_LIST = New System.Windows.Forms.DataGridView()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INMA_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INMA_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSAVENEW = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.GBOX_SETTINGS = New System.Windows.Forms.GroupBox()
        Me.LLBL_RECORDSFOUND = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CB_MAINTENANCE_SELECTION = New System.Windows.Forms.ComboBox()
        Me.LLBL_MAINTENANCE_NEW = New System.Windows.Forms.LinkLabel()
        Me.PB_MAINTENANCE_NEW = New System.Windows.Forms.PictureBox()
        Me.GRP_CATEGORY = New System.Windows.Forms.GroupBox()
        Me.RGB_CATEGORY_INACTIVE = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RGB_CATEGORY_ACTIVE = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WTXT_CATEGORY_NAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_CATEGORY_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LLBL_MAINTENANCE_EDIT = New System.Windows.Forms.LinkLabel()
        Me.PB_MAINTENANCE_EDIT = New System.Windows.Forms.PictureBox()
        Me.PB_MAINTENANCE_CANCEL = New System.Windows.Forms.PictureBox()
        Me.LLBL_MAINTENANCE_CANCEL = New System.Windows.Forms.LinkLabel()
        Me.GRP_SUB_CATEGORY = New System.Windows.Forms.GroupBox()
        Me.BTN_ADD_CATEGORY = New System.Windows.Forms.Button()
        Me.CB_CATEGORYNAME = New System.Windows.Forms.ComboBox()
        Me.TblM4_INVENTORY_CATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RGB_SUB_CATEGORY_INACTIVE = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RGB_SUB_CATEGORY_ACTIVE = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WTXT_SUBCATEGORY_NAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_SUBCATEGORY_CATEGORYNAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_SUB_CATEGORY_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_BRANDS = New System.Windows.Forms.GroupBox()
        Me.RGB_BRANDS_INACTIVE = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RGB_BRANDS_ACTIVE = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WTXT_BRANDNAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_BRAND_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LLBL_MAINTENANCE_SAVE = New System.Windows.Forms.LinkLabel()
        Me.PB_MAINTENANCE_SAVE = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SCCODETextBox = New System.Windows.Forms.TextBox()
        Me.SPM4_SC_CODE_GENERATORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.BRCODETextBox = New System.Windows.Forms.TextBox()
        Me.SPM4_BR_CODE_GENERATORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PB_MAINTENANCE_CLEAR = New System.Windows.Forms.PictureBox()
        Me.WTXT_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TblM4_INVENTORY_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter()
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter()
        Me.TblM4_INVENTORY_ITEMBRANDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_CATEGORY1TableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORY1TableAdapter()
        Me.TblM4_INVENTORY_CATEGORY1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMBRAND1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMBRAND1TableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRAND1TableAdapter()
        Me.TblM4_CATEGORY_AND_SUBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_CATEGORY_AND_SUBTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_CATEGORY_AND_SUBTableAdapter()
        Me.TableAdapterManager1 = New PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager()
        Me.SPM4_BR_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_BR_CODE_GENERATORTableAdapter()
        Me.SPM4_SC_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_SC_CODE_GENERATORTableAdapter()
        CType(Me.DGV_MAINTENANCE_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBOX_SETTINGS.SuspendLayout()
        CType(Me.PB_MAINTENANCE_NEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_CATEGORY.SuspendLayout()
        CType(Me.PB_MAINTENANCE_EDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_MAINTENANCE_CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_SUB_CATEGORY.SuspendLayout()
        CType(Me.TblM4_INVENTORY_CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_BRANDS.SuspendLayout()
        CType(Me.PB_MAINTENANCE_SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SPM4_SC_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_BR_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_MAINTENANCE_CLEAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_CATEGORY1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMBRAND1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_CATEGORY_AND_SUBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_MAINTENANCE_LIST
        '
        Me.DGV_MAINTENANCE_LIST.AllowUserToAddRows = False
        Me.DGV_MAINTENANCE_LIST.AllowUserToDeleteRows = False
        Me.DGV_MAINTENANCE_LIST.AllowUserToResizeColumns = False
        Me.DGV_MAINTENANCE_LIST.AllowUserToResizeRows = False
        Me.DGV_MAINTENANCE_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_MAINTENANCE_LIST.BackgroundColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_MAINTENANCE_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_MAINTENANCE_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_MAINTENANCE_LIST.Location = New System.Drawing.Point(391, 54)
        Me.DGV_MAINTENANCE_LIST.MultiSelect = False
        Me.DGV_MAINTENANCE_LIST.Name = "DGV_MAINTENANCE_LIST"
        Me.DGV_MAINTENANCE_LIST.ReadOnly = True
        Me.DGV_MAINTENANCE_LIST.RowHeadersVisible = False
        Me.DGV_MAINTENANCE_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_MAINTENANCE_LIST.Size = New System.Drawing.Size(680, 425)
        Me.DGV_MAINTENANCE_LIST.TabIndex = 0
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_INMA_MINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_INMA_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1096, 49)
        Me.PNL.TabIndex = 1404
        '
        'BTN_INMA_MINIMIZE
        '
        Me.BTN_INMA_MINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INMA_MINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_INMA_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_INMA_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INMA_MINIMIZE.Location = New System.Drawing.Point(1018, 8)
        Me.BTN_INMA_MINIMIZE.Name = "BTN_INMA_MINIMIZE"
        Me.BTN_INMA_MINIMIZE.Size = New System.Drawing.Size(28, 28)
        Me.BTN_INMA_MINIMIZE.TabIndex = 11
        Me.BTN_INMA_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INMA_MINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_INMA_CLOSE
        '
        Me.BTN_INMA_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INMA_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INMA_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INMA_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INMA_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INMA_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INMA_CLOSE.Location = New System.Drawing.Point(1053, 7)
        Me.BTN_INMA_CLOSE.Name = "BTN_INMA_CLOSE"
        Me.BTN_INMA_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INMA_CLOSE.TabIndex = 10
        Me.BTN_INMA_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INMA_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(12, 14)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(353, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "I n v e n t o r y   C a t e g o r i z a t i o n"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3990, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3943, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRCANCELEDIT, Me.RectangleShape2, Me.RECT_PRSAVENEW, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1096, 660)
        Me.ShapeContainer1.TabIndex = 1436
        Me.ShapeContainer1.TabStop = False
        '
        'RECT_PRCANCELEDIT
        '
        Me.RECT_PRCANCELEDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRCANCELEDIT.BorderWidth = 2
        Me.RECT_PRCANCELEDIT.CornerRadius = 19
        Me.RECT_PRCANCELEDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRCANCELEDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRCANCELEDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(222, 55)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(121, 39)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 19
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(115, 55)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(103, 39)
        '
        'RECT_PRSAVENEW
        '
        Me.RECT_PRSAVENEW.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRSAVENEW.BorderWidth = 2
        Me.RECT_PRSAVENEW.CornerRadius = 19
        Me.RECT_PRSAVENEW.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRSAVENEW.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRSAVENEW.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRSAVENEW.Location = New System.Drawing.Point(7, 55)
        Me.RECT_PRSAVENEW.Name = "RECT_PRSAVENEW"
        Me.RECT_PRSAVENEW.Size = New System.Drawing.Size(103, 39)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(815, 60)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(267, 34)
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GBOX_SETTINGS
        '
        Me.GBOX_SETTINGS.Controls.Add(Me.LLBL_RECORDSFOUND)
        Me.GBOX_SETTINGS.Controls.Add(Me.LinkLabel1)
        Me.GBOX_SETTINGS.Location = New System.Drawing.Point(391, 485)
        Me.GBOX_SETTINGS.Name = "GBOX_SETTINGS"
        Me.GBOX_SETTINGS.Size = New System.Drawing.Size(348, 50)
        Me.GBOX_SETTINGS.TabIndex = 1437
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
        Me.LLBL_RECORDSFOUND.Location = New System.Drawing.Point(283, 19)
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
        'CB_MAINTENANCE_SELECTION
        '
        Me.CB_MAINTENANCE_SELECTION.DisplayMember = "UN_DESCRIPTION"
        Me.CB_MAINTENANCE_SELECTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MAINTENANCE_SELECTION.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_MAINTENANCE_SELECTION.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_MAINTENANCE_SELECTION.FormattingEnabled = True
        Me.CB_MAINTENANCE_SELECTION.Items.AddRange(New Object() {"Sub Category", "Brands"})
        Me.CB_MAINTENANCE_SELECTION.Location = New System.Drawing.Point(820, 64)
        Me.CB_MAINTENANCE_SELECTION.Name = "CB_MAINTENANCE_SELECTION"
        Me.CB_MAINTENANCE_SELECTION.Size = New System.Drawing.Size(258, 27)
        Me.CB_MAINTENANCE_SELECTION.TabIndex = 1438
        Me.CB_MAINTENANCE_SELECTION.ValueMember = "UN_DESCRIPTION"
        '
        'LLBL_MAINTENANCE_NEW
        '
        Me.LLBL_MAINTENANCE_NEW.AutoSize = True
        Me.LLBL_MAINTENANCE_NEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_MAINTENANCE_NEW.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_MAINTENANCE_NEW.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_MAINTENANCE_NEW.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_MAINTENANCE_NEW.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_MAINTENANCE_NEW.Location = New System.Drawing.Point(54, 65)
        Me.LLBL_MAINTENANCE_NEW.Name = "LLBL_MAINTENANCE_NEW"
        Me.LLBL_MAINTENANCE_NEW.Size = New System.Drawing.Size(46, 19)
        Me.LLBL_MAINTENANCE_NEW.TabIndex = 1439
        Me.LLBL_MAINTENANCE_NEW.TabStop = True
        Me.LLBL_MAINTENANCE_NEW.Text = "NEW"
        Me.LLBL_MAINTENANCE_NEW.Visible = False
        '
        'PB_MAINTENANCE_NEW
        '
        Me.PB_MAINTENANCE_NEW.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_post_add_black_18dp
        Me.PB_MAINTENANCE_NEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_MAINTENANCE_NEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_MAINTENANCE_NEW.InitialImage = Nothing
        Me.PB_MAINTENANCE_NEW.Location = New System.Drawing.Point(19, 61)
        Me.PB_MAINTENANCE_NEW.Name = "PB_MAINTENANCE_NEW"
        Me.PB_MAINTENANCE_NEW.Size = New System.Drawing.Size(32, 28)
        Me.PB_MAINTENANCE_NEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_MAINTENANCE_NEW.TabIndex = 1440
        Me.PB_MAINTENANCE_NEW.TabStop = False
        Me.PB_MAINTENANCE_NEW.Visible = False
        '
        'GRP_CATEGORY
        '
        Me.GRP_CATEGORY.Controls.Add(Me.RGB_CATEGORY_INACTIVE)
        Me.GRP_CATEGORY.Controls.Add(Me.Label2)
        Me.GRP_CATEGORY.Controls.Add(Me.RGB_CATEGORY_ACTIVE)
        Me.GRP_CATEGORY.Controls.Add(Me.Label1)
        Me.GRP_CATEGORY.Controls.Add(Me.WTXT_CATEGORY_NAME)
        Me.GRP_CATEGORY.Controls.Add(Me.ShapeContainer2)
        Me.GRP_CATEGORY.Enabled = False
        Me.GRP_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_CATEGORY.Location = New System.Drawing.Point(12, 257)
        Me.GRP_CATEGORY.Name = "GRP_CATEGORY"
        Me.GRP_CATEGORY.Size = New System.Drawing.Size(375, 183)
        Me.GRP_CATEGORY.TabIndex = 1441
        Me.GRP_CATEGORY.TabStop = False
        Me.GRP_CATEGORY.Text = "Category"
        Me.GRP_CATEGORY.Visible = False
        '
        'RGB_CATEGORY_INACTIVE
        '
        Me.RGB_CATEGORY_INACTIVE.AutoSize = True
        Me.RGB_CATEGORY_INACTIVE.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RGB_CATEGORY_INACTIVE.Location = New System.Drawing.Point(141, 125)
        Me.RGB_CATEGORY_INACTIVE.Name = "RGB_CATEGORY_INACTIVE"
        Me.RGB_CATEGORY_INACTIVE.Size = New System.Drawing.Size(94, 25)
        Me.RGB_CATEGORY_INACTIVE.TabIndex = 1433
        Me.RGB_CATEGORY_INACTIVE.TabStop = True
        Me.RGB_CATEGORY_INACTIVE.Text = "Inactive"
        Me.RGB_CATEGORY_INACTIVE.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 1432
        Me.Label2.Text = "Status"
        '
        'RGB_CATEGORY_ACTIVE
        '
        Me.RGB_CATEGORY_ACTIVE.AutoSize = True
        Me.RGB_CATEGORY_ACTIVE.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RGB_CATEGORY_ACTIVE.Location = New System.Drawing.Point(38, 125)
        Me.RGB_CATEGORY_ACTIVE.Name = "RGB_CATEGORY_ACTIVE"
        Me.RGB_CATEGORY_ACTIVE.Size = New System.Drawing.Size(81, 25)
        Me.RGB_CATEGORY_ACTIVE.TabIndex = 1431
        Me.RGB_CATEGORY_ACTIVE.TabStop = True
        Me.RGB_CATEGORY_ACTIVE.Text = "Active"
        Me.RGB_CATEGORY_ACTIVE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 42)
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
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RECT_CATEGORY_NAME})
        Me.ShapeContainer2.Size = New System.Drawing.Size(369, 157)
        Me.ShapeContainer2.TabIndex = 1429
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(8, 98)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(249, 32)
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
        'LLBL_MAINTENANCE_EDIT
        '
        Me.LLBL_MAINTENANCE_EDIT.ActiveLinkColor = System.Drawing.Color.Red
        Me.LLBL_MAINTENANCE_EDIT.AutoSize = True
        Me.LLBL_MAINTENANCE_EDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_MAINTENANCE_EDIT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_MAINTENANCE_EDIT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_MAINTENANCE_EDIT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_MAINTENANCE_EDIT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_MAINTENANCE_EDIT.Location = New System.Drawing.Point(167, 65)
        Me.LLBL_MAINTENANCE_EDIT.Name = "LLBL_MAINTENANCE_EDIT"
        Me.LLBL_MAINTENANCE_EDIT.Size = New System.Drawing.Size(42, 19)
        Me.LLBL_MAINTENANCE_EDIT.TabIndex = 1443
        Me.LLBL_MAINTENANCE_EDIT.TabStop = True
        Me.LLBL_MAINTENANCE_EDIT.Text = "EDIT"
        '
        'PB_MAINTENANCE_EDIT
        '
        Me.PB_MAINTENANCE_EDIT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_edit_black_24dp
        Me.PB_MAINTENANCE_EDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_MAINTENANCE_EDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_MAINTENANCE_EDIT.InitialImage = Nothing
        Me.PB_MAINTENANCE_EDIT.Location = New System.Drawing.Point(129, 61)
        Me.PB_MAINTENANCE_EDIT.Name = "PB_MAINTENANCE_EDIT"
        Me.PB_MAINTENANCE_EDIT.Size = New System.Drawing.Size(32, 28)
        Me.PB_MAINTENANCE_EDIT.TabIndex = 1442
        Me.PB_MAINTENANCE_EDIT.TabStop = False
        '
        'PB_MAINTENANCE_CANCEL
        '
        Me.PB_MAINTENANCE_CANCEL.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.PB_MAINTENANCE_CANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_MAINTENANCE_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_MAINTENANCE_CANCEL.Enabled = False
        Me.PB_MAINTENANCE_CANCEL.InitialImage = Nothing
        Me.PB_MAINTENANCE_CANCEL.Location = New System.Drawing.Point(232, 62)
        Me.PB_MAINTENANCE_CANCEL.Name = "PB_MAINTENANCE_CANCEL"
        Me.PB_MAINTENANCE_CANCEL.Size = New System.Drawing.Size(32, 28)
        Me.PB_MAINTENANCE_CANCEL.TabIndex = 1422
        Me.PB_MAINTENANCE_CANCEL.TabStop = False
        '
        'LLBL_MAINTENANCE_CANCEL
        '
        Me.LLBL_MAINTENANCE_CANCEL.ActiveLinkColor = System.Drawing.Color.Red
        Me.LLBL_MAINTENANCE_CANCEL.AutoSize = True
        Me.LLBL_MAINTENANCE_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_MAINTENANCE_CANCEL.Enabled = False
        Me.LLBL_MAINTENANCE_CANCEL.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_MAINTENANCE_CANCEL.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_MAINTENANCE_CANCEL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_MAINTENANCE_CANCEL.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_MAINTENANCE_CANCEL.Location = New System.Drawing.Point(262, 66)
        Me.LLBL_MAINTENANCE_CANCEL.Name = "LLBL_MAINTENANCE_CANCEL"
        Me.LLBL_MAINTENANCE_CANCEL.Size = New System.Drawing.Size(77, 19)
        Me.LLBL_MAINTENANCE_CANCEL.TabIndex = 1421
        Me.LLBL_MAINTENANCE_CANCEL.TabStop = True
        Me.LLBL_MAINTENANCE_CANCEL.Text = "CANCEL"
        '
        'GRP_SUB_CATEGORY
        '
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.BTN_ADD_CATEGORY)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.CB_CATEGORYNAME)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.Label5)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.RGB_SUB_CATEGORY_INACTIVE)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.Label3)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.RGB_SUB_CATEGORY_ACTIVE)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.Label4)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.WTXT_SUBCATEGORY_NAME)
        Me.GRP_SUB_CATEGORY.Controls.Add(Me.ShapeContainer3)
        Me.GRP_SUB_CATEGORY.Enabled = False
        Me.GRP_SUB_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_SUB_CATEGORY.Location = New System.Drawing.Point(8, 3)
        Me.GRP_SUB_CATEGORY.Name = "GRP_SUB_CATEGORY"
        Me.GRP_SUB_CATEGORY.Size = New System.Drawing.Size(375, 233)
        Me.GRP_SUB_CATEGORY.TabIndex = 1444
        Me.GRP_SUB_CATEGORY.TabStop = False
        Me.GRP_SUB_CATEGORY.Text = "Sub Category"
        Me.GRP_SUB_CATEGORY.Visible = False
        '
        'BTN_ADD_CATEGORY
        '
        Me.BTN_ADD_CATEGORY.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_ADD_CATEGORY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ADD_CATEGORY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ADD_CATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_ADD_CATEGORY.FlatAppearance.BorderSize = 0
        Me.BTN_ADD_CATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ADD_CATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_ADD_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADD_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD_CATEGORY.Location = New System.Drawing.Point(334, 56)
        Me.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY"
        Me.BTN_ADD_CATEGORY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ADD_CATEGORY.Size = New System.Drawing.Size(24, 24)
        Me.BTN_ADD_CATEGORY.TabIndex = 1461
        Me.BTN_ADD_CATEGORY.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_ADD_CATEGORY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ADD_CATEGORY.UseVisualStyleBackColor = True
        '
        'CB_CATEGORYNAME
        '
        Me.CB_CATEGORYNAME.DataSource = Me.TblM4_INVENTORY_CATEGORYBindingSource
        Me.CB_CATEGORYNAME.DisplayMember = "CAT_NAME"
        Me.CB_CATEGORYNAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CATEGORYNAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_CATEGORYNAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_CATEGORYNAME.FormattingEnabled = True
        Me.CB_CATEGORYNAME.Location = New System.Drawing.Point(16, 55)
        Me.CB_CATEGORYNAME.Name = "CB_CATEGORYNAME"
        Me.CB_CATEGORYNAME.Size = New System.Drawing.Size(308, 27)
        Me.CB_CATEGORYNAME.TabIndex = 1445
        Me.CB_CATEGORYNAME.ValueMember = "CAT_CODE"
        '
        'TblM4_INVENTORY_CATEGORYBindingSource
        '
        Me.TblM4_INVENTORY_CATEGORYBindingSource.DataMember = "tblM4_INVENTORY_CATEGORY"
        Me.TblM4_INVENTORY_CATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
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
        'RGB_SUB_CATEGORY_INACTIVE
        '
        Me.RGB_SUB_CATEGORY_INACTIVE.AutoSize = True
        Me.RGB_SUB_CATEGORY_INACTIVE.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RGB_SUB_CATEGORY_INACTIVE.Location = New System.Drawing.Point(141, 184)
        Me.RGB_SUB_CATEGORY_INACTIVE.Name = "RGB_SUB_CATEGORY_INACTIVE"
        Me.RGB_SUB_CATEGORY_INACTIVE.Size = New System.Drawing.Size(94, 25)
        Me.RGB_SUB_CATEGORY_INACTIVE.TabIndex = 1433
        Me.RGB_SUB_CATEGORY_INACTIVE.TabStop = True
        Me.RGB_SUB_CATEGORY_INACTIVE.Text = "Inactive"
        Me.RGB_SUB_CATEGORY_INACTIVE.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 1432
        Me.Label3.Text = "Status"
        '
        'RGB_SUB_CATEGORY_ACTIVE
        '
        Me.RGB_SUB_CATEGORY_ACTIVE.AutoSize = True
        Me.RGB_SUB_CATEGORY_ACTIVE.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RGB_SUB_CATEGORY_ACTIVE.Location = New System.Drawing.Point(38, 184)
        Me.RGB_SUB_CATEGORY_ACTIVE.Name = "RGB_SUB_CATEGORY_ACTIVE"
        Me.RGB_SUB_CATEGORY_ACTIVE.Size = New System.Drawing.Size(81, 25)
        Me.RGB_SUB_CATEGORY_ACTIVE.TabIndex = 1431
        Me.RGB_SUB_CATEGORY_ACTIVE.TabStop = True
        Me.RGB_SUB_CATEGORY_ACTIVE.Text = "Active"
        Me.RGB_SUB_CATEGORY_ACTIVE.UseVisualStyleBackColor = True
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
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_SUBCATEGORY_CATEGORYNAME, Me.RectangleShape4, Me.RECT_SUB_CATEGORY_NAME})
        Me.ShapeContainer3.Size = New System.Drawing.Size(369, 207)
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
        Me.RECT_SUBCATEGORY_CATEGORYNAME.Size = New System.Drawing.Size(318, 33)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(8, 157)
        Me.RectangleShape4.Name = "RectangleShape3"
        Me.RectangleShape4.Size = New System.Drawing.Size(249, 32)
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
        'GRP_BRANDS
        '
        Me.GRP_BRANDS.Controls.Add(Me.RGB_BRANDS_INACTIVE)
        Me.GRP_BRANDS.Controls.Add(Me.Label6)
        Me.GRP_BRANDS.Controls.Add(Me.RGB_BRANDS_ACTIVE)
        Me.GRP_BRANDS.Controls.Add(Me.Label7)
        Me.GRP_BRANDS.Controls.Add(Me.WTXT_BRANDNAME)
        Me.GRP_BRANDS.Controls.Add(Me.ShapeContainer4)
        Me.GRP_BRANDS.Enabled = False
        Me.GRP_BRANDS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_BRANDS.Location = New System.Drawing.Point(8, 3)
        Me.GRP_BRANDS.Name = "GRP_BRANDS"
        Me.GRP_BRANDS.Size = New System.Drawing.Size(375, 183)
        Me.GRP_BRANDS.TabIndex = 1445
        Me.GRP_BRANDS.TabStop = False
        Me.GRP_BRANDS.Text = "Brands"
        Me.GRP_BRANDS.Visible = False
        '
        'RGB_BRANDS_INACTIVE
        '
        Me.RGB_BRANDS_INACTIVE.AutoSize = True
        Me.RGB_BRANDS_INACTIVE.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RGB_BRANDS_INACTIVE.Location = New System.Drawing.Point(141, 125)
        Me.RGB_BRANDS_INACTIVE.Name = "RGB_BRANDS_INACTIVE"
        Me.RGB_BRANDS_INACTIVE.Size = New System.Drawing.Size(94, 25)
        Me.RGB_BRANDS_INACTIVE.TabIndex = 1433
        Me.RGB_BRANDS_INACTIVE.TabStop = True
        Me.RGB_BRANDS_INACTIVE.Text = "Inactive"
        Me.RGB_BRANDS_INACTIVE.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 19)
        Me.Label6.TabIndex = 1432
        Me.Label6.Text = "Status"
        '
        'RGB_BRANDS_ACTIVE
        '
        Me.RGB_BRANDS_ACTIVE.AutoSize = True
        Me.RGB_BRANDS_ACTIVE.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.RGB_BRANDS_ACTIVE.Location = New System.Drawing.Point(38, 125)
        Me.RGB_BRANDS_ACTIVE.Name = "RGB_BRANDS_ACTIVE"
        Me.RGB_BRANDS_ACTIVE.Size = New System.Drawing.Size(81, 25)
        Me.RGB_BRANDS_ACTIVE.TabIndex = 1431
        Me.RGB_BRANDS_ACTIVE.TabStop = True
        Me.RGB_BRANDS_ACTIVE.Text = "Active"
        Me.RGB_BRANDS_ACTIVE.UseVisualStyleBackColor = True
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
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape7, Me.RECT_BRAND_NAME})
        Me.ShapeContainer4.Size = New System.Drawing.Size(369, 157)
        Me.ShapeContainer4.TabIndex = 1429
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape7.BorderWidth = 2
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(8, 98)
        Me.RectangleShape7.Name = "RectangleShape3"
        Me.RectangleShape7.Size = New System.Drawing.Size(249, 32)
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
        'LLBL_MAINTENANCE_SAVE
        '
        Me.LLBL_MAINTENANCE_SAVE.ActiveLinkColor = System.Drawing.Color.Red
        Me.LLBL_MAINTENANCE_SAVE.AutoSize = True
        Me.LLBL_MAINTENANCE_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_MAINTENANCE_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_MAINTENANCE_SAVE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_MAINTENANCE_SAVE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_MAINTENANCE_SAVE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_MAINTENANCE_SAVE.Location = New System.Drawing.Point(54, 65)
        Me.LLBL_MAINTENANCE_SAVE.Name = "LLBL_MAINTENANCE_SAVE"
        Me.LLBL_MAINTENANCE_SAVE.Size = New System.Drawing.Size(52, 19)
        Me.LLBL_MAINTENANCE_SAVE.TabIndex = 1446
        Me.LLBL_MAINTENANCE_SAVE.TabStop = True
        Me.LLBL_MAINTENANCE_SAVE.Text = "SAVE"
        Me.LLBL_MAINTENANCE_SAVE.Visible = False
        '
        'PB_MAINTENANCE_SAVE
        '
        Me.PB_MAINTENANCE_SAVE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.baseline_save_black_18dp
        Me.PB_MAINTENANCE_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_MAINTENANCE_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_MAINTENANCE_SAVE.InitialImage = Nothing
        Me.PB_MAINTENANCE_SAVE.Location = New System.Drawing.Point(19, 61)
        Me.PB_MAINTENANCE_SAVE.Name = "PB_MAINTENANCE_SAVE"
        Me.PB_MAINTENANCE_SAVE.Size = New System.Drawing.Size(32, 28)
        Me.PB_MAINTENANCE_SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_MAINTENANCE_SAVE.TabIndex = 1447
        Me.PB_MAINTENANCE_SAVE.TabStop = False
        Me.PB_MAINTENANCE_SAVE.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GRP_BRANDS)
        Me.Panel1.Controls.Add(Me.SCCODETextBox)
        Me.Panel1.Controls.Add(Me.BRCODETextBox)
        Me.Panel1.Controls.Add(Me.GRP_CATEGORY)
        Me.Panel1.Controls.Add(Me.PB_MAINTENANCE_CLEAR)
        Me.Panel1.Controls.Add(Me.WTXT_SEARCH)
        Me.Panel1.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.Panel1.Controls.Add(Me.GRP_SUB_CATEGORY)
        Me.Panel1.Controls.Add(Me.DGV_MAINTENANCE_LIST)
        Me.Panel1.Controls.Add(Me.GBOX_SETTINGS)
        Me.Panel1.Controls.Add(Me.ShapeContainer5)
        Me.Panel1.Location = New System.Drawing.Point(7, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 546)
        Me.Panel1.TabIndex = 1448
        '
        'SCCODETextBox
        '
        Me.SCCODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4_SC_CODE_GENERATORBindingSource, "SCCODE", True))
        Me.SCCODETextBox.Location = New System.Drawing.Point(3, 497)
        Me.SCCODETextBox.Name = "SCCODETextBox"
        Me.SCCODETextBox.Size = New System.Drawing.Size(100, 20)
        Me.SCCODETextBox.TabIndex = 1
        Me.SCCODETextBox.Visible = False
        '
        'SPM4_SC_CODE_GENERATORBindingSource
        '
        Me.SPM4_SC_CODE_GENERATORBindingSource.DataMember = "SPM4_SC_CODE_GENERATOR"
        Me.SPM4_SC_CODE_GENERATORBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BRCODETextBox
        '
        Me.BRCODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4_BR_CODE_GENERATORBindingSource, "BRCODE", True))
        Me.BRCODETextBox.Location = New System.Drawing.Point(3, 523)
        Me.BRCODETextBox.Name = "BRCODETextBox"
        Me.BRCODETextBox.Size = New System.Drawing.Size(100, 20)
        Me.BRCODETextBox.TabIndex = 1
        Me.BRCODETextBox.Visible = False
        '
        'SPM4_BR_CODE_GENERATORBindingSource
        '
        Me.SPM4_BR_CODE_GENERATORBindingSource.DataMember = "SPM4_BR_CODE_GENERATOR"
        Me.SPM4_BR_CODE_GENERATORBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'PB_MAINTENANCE_CLEAR
        '
        Me.PB_MAINTENANCE_CLEAR.BackgroundImage = CType(resources.GetObject("PB_MAINTENANCE_CLEAR.BackgroundImage"), System.Drawing.Image)
        Me.PB_MAINTENANCE_CLEAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_MAINTENANCE_CLEAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_MAINTENANCE_CLEAR.InitialImage = Nothing
        Me.PB_MAINTENANCE_CLEAR.Location = New System.Drawing.Point(1037, 16)
        Me.PB_MAINTENANCE_CLEAR.Name = "PB_MAINTENANCE_CLEAR"
        Me.PB_MAINTENANCE_CLEAR.Size = New System.Drawing.Size(32, 28)
        Me.PB_MAINTENANCE_CLEAR.TabIndex = 1478
        Me.PB_MAINTENANCE_CLEAR.TabStop = False
        Me.PB_MAINTENANCE_CLEAR.Visible = False
        '
        'WTXT_SEARCH
        '
        Me.WTXT_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCH.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.WTXT_SEARCH.Location = New System.Drawing.Point(431, 20)
        Me.WTXT_SEARCH.MaxLength = 15
        Me.WTXT_SEARCH.Name = "WTXT_SEARCH"
        Me.WTXT_SEARCH.Size = New System.Drawing.Size(602, 20)
        Me.WTXT_SEARCH.TabIndex = 1468
        Me.WTXT_SEARCH.Watermark = ""
        '
        'PB_INVENTORY_SEARCH
        '
        Me.PB_INVENTORY_SEARCH.BackgroundImage = CType(resources.GetObject("PB_INVENTORY_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_INVENTORY_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_SEARCH.Location = New System.Drawing.Point(395, 16)
        Me.PB_INVENTORY_SEARCH.Name = "PB_INVENTORY_SEARCH"
        Me.PB_INVENTORY_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_SEARCH.TabIndex = 1469
        Me.PB_INVENTORY_SEARCH.TabStop = False
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.AutoScroll = True
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5})
        Me.ShapeContainer5.Size = New System.Drawing.Size(1080, 546)
        Me.ShapeContainer5.TabIndex = 1446
        Me.ShapeContainer5.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape5.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(390, 13)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(682, 33)
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
        Me.TableAdapterManager.tblM4_INVENTORY_SUB_CATEGORYTableAdapter = Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter
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
        'TblM4_INVENTORY_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMBRANDTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMBRANDBindingSource
        '
        Me.TblM4_INVENTORY_ITEMBRANDBindingSource.DataMember = "tblM4_INVENTORY_ITEMBRAND"
        Me.TblM4_INVENTORY_ITEMBRANDBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_CATEGORY1TableAdapter
        '
        Me.TblM4_INVENTORY_CATEGORY1TableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_CATEGORY1BindingSource
        '
        Me.TblM4_INVENTORY_CATEGORY1BindingSource.DataMember = "tblM4_INVENTORY_CATEGORY1"
        Me.TblM4_INVENTORY_CATEGORY1BindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_ITEMBRAND1BindingSource
        '
        Me.TblM4_INVENTORY_ITEMBRAND1BindingSource.DataMember = "tblM4_INVENTORY_ITEMBRAND1"
        Me.TblM4_INVENTORY_ITEMBRAND1BindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_ITEMBRAND1TableAdapter
        '
        Me.TblM4_INVENTORY_ITEMBRAND1TableAdapter.ClearBeforeFill = True
        '
        'TblM4_CATEGORY_AND_SUBBindingSource
        '
        Me.TblM4_CATEGORY_AND_SUBBindingSource.DataMember = "tblM4_CATEGORY_AND_SUB"
        Me.TblM4_CATEGORY_AND_SUBBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_CATEGORY_AND_SUBTableAdapter
        '
        Me.TblM4_CATEGORY_AND_SUBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.A_CLOSEPROGRAMTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SPM4_BR_CODE_GENERATORTableAdapter
        '
        Me.SPM4_BR_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'SPM4_SC_CODE_GENERATORTableAdapter
        '
        Me.SPM4_SC_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'FRM_SETTINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1096, 660)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PB_MAINTENANCE_SAVE)
        Me.Controls.Add(Me.LLBL_MAINTENANCE_SAVE)
        Me.Controls.Add(Me.PB_MAINTENANCE_CANCEL)
        Me.Controls.Add(Me.LLBL_MAINTENANCE_CANCEL)
        Me.Controls.Add(Me.LLBL_MAINTENANCE_EDIT)
        Me.Controls.Add(Me.PB_MAINTENANCE_EDIT)
        Me.Controls.Add(Me.PB_MAINTENANCE_NEW)
        Me.Controls.Add(Me.LLBL_MAINTENANCE_NEW)
        Me.Controls.Add(Me.CB_MAINTENANCE_SELECTION)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_SETTINGS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FRM_SETTINGS2"
        CType(Me.DGV_MAINTENANCE_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBOX_SETTINGS.ResumeLayout(False)
        Me.GBOX_SETTINGS.PerformLayout()
        CType(Me.PB_MAINTENANCE_NEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_CATEGORY.ResumeLayout(False)
        Me.GRP_CATEGORY.PerformLayout()
        CType(Me.PB_MAINTENANCE_EDIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_MAINTENANCE_CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_SUB_CATEGORY.ResumeLayout(False)
        Me.GRP_SUB_CATEGORY.PerformLayout()
        CType(Me.TblM4_INVENTORY_CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_BRANDS.ResumeLayout(False)
        Me.GRP_BRANDS.PerformLayout()
        CType(Me.PB_MAINTENANCE_SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SPM4_SC_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_BR_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_MAINTENANCE_CLEAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_SUB_CATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_CATEGORY1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMBRAND1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_CATEGORY_AND_SUBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_MAINTENANCE_LIST As DataGridView
    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_INMA_MINIMIZE As Button
    Friend WithEvents BTN_INMA_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents GBOX_SETTINGS As GroupBox
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents CB_MAINTENANCE_SELECTION As ComboBox
    Friend WithEvents LLBL_MAINTENANCE_NEW As LinkLabel
    Friend WithEvents PB_MAINTENANCE_NEW As PictureBox
    Friend WithEvents RECT_PRSAVENEW As PowerPacks.RectangleShape
    Friend WithEvents LLBL_RECORDSFOUND As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents GRP_CATEGORY As GroupBox
    Friend WithEvents LLBL_MAINTENANCE_EDIT As LinkLabel
    Friend WithEvents PB_MAINTENANCE_EDIT As PictureBox
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents PB_MAINTENANCE_CANCEL As PictureBox
    Friend WithEvents LLBL_MAINTENANCE_CANCEL As LinkLabel
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents WTXT_CATEGORY_NAME As WatermarkTextBox
    Friend WithEvents RGB_CATEGORY_INACTIVE As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents RGB_CATEGORY_ACTIVE As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RECT_CATEGORY_NAME As PowerPacks.RectangleShape
    Friend WithEvents GRP_SUB_CATEGORY As GroupBox
    Friend WithEvents RGB_SUB_CATEGORY_INACTIVE As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents RGB_SUB_CATEGORY_ACTIVE As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents WTXT_SUBCATEGORY_NAME As WatermarkTextBox
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RECT_SUB_CATEGORY_NAME As PowerPacks.RectangleShape
    Friend WithEvents RECT_SUBCATEGORY_CATEGORYNAME As PowerPacks.RectangleShape
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_CATEGORYNAME As ComboBox
    Friend WithEvents GRP_BRANDS As GroupBox
    Friend WithEvents RGB_BRANDS_INACTIVE As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents RGB_BRANDS_ACTIVE As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents WTXT_BRANDNAME As WatermarkTextBox
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents RECT_BRAND_NAME As PowerPacks.RectangleShape
    '    Friend WithEvents TblM4CATEGORYBindingSource As BindingSource
    '   Friend WithEvents TblM4_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_CATEGORYTableAdapter
    Friend WithEvents LLBL_MAINTENANCE_SAVE As LinkLabel
    Friend WithEvents PB_MAINTENANCE_SAVE As PictureBox
    '  Friend WithEvents TblM4_SUB_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_SUB_CATEGORYTableAdapter
    ' Friend WithEvents TblM4_ITEMBRANDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_ITEMBRANDTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShapeContainer5 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents WTXT_SEARCH As WatermarkTextBox
    Friend WithEvents PB_MAINTENANCE_CLEAR As PictureBox
    Friend WithEvents TblM4_INVENTORY_SUB_CATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_SUB_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents TblM4_INVENTORY_ITEMBRANDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter
    Friend WithEvents TblM4_INVENTORY_ITEMBRANDBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_CATEGORY1TableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORY1TableAdapter
    Friend WithEvents TblM4_INVENTORY_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter
    Friend WithEvents TblM4_INVENTORY_CATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_CATEGORY1BindingSource As BindingSource

    Friend WithEvents TblM4_INVENTORY_ITEMBRAND1BindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMBRAND1TableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRAND1TableAdapter
    Friend WithEvents TblM4_CATEGORY_AND_SUBBindingSource As BindingSource
    Friend WithEvents TblM4_CATEGORY_AND_SUBTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_CATEGORY_AND_SUBTableAdapter
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents TableAdapterManager1 As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents SPM4_BR_CODE_GENERATORBindingSource As BindingSource
    Friend WithEvents SPM4_BR_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_BR_CODE_GENERATORTableAdapter
    Friend WithEvents BRCODETextBox As TextBox
    Friend WithEvents SPM4_SC_CODE_GENERATORBindingSource As BindingSource
    Friend WithEvents SPM4_SC_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_SC_CODE_GENERATORTableAdapter
    Friend WithEvents SCCODETextBox As TextBox
    Friend WithEvents BTN_ADD_CATEGORY As Button
End Class
