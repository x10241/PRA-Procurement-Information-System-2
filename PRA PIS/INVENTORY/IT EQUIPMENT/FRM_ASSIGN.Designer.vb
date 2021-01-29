<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ASSIGN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ASSIGN))
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_SELECTION_CLOSE = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PNL_BOTTOM = New System.Windows.Forms.Panel()
        Me.LLBL_ITEMS_ASSIGN_COUNT = New System.Windows.Forms.Label()
        Me.BTN_ASSIGN_SAVE = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LLBL_ITEM_DETAILS_COUNT = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.WTXT_ASS_PERSON_REMARKS = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WTXT_ASS_PERSON_DIVISION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ASS_PERSON_DEPARTMENT = New PRA_PIS.WatermarkTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WTXT_ASS_PERSON_EMP_NO = New PRA_PIS.WatermarkTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WTXT_ASS_PERSON_NAME = New PRA_PIS.WatermarkTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_ASS_DIVISION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ASS_DEPARTMENT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ASS_POSITION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ASS_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GB_REMARKS = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.WTXT_DATE_APPOINTED = New PRA_PIS.WatermarkTextBox()
        Me.SPM4CURRENTDATETIMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.WTXT_ACC_REMARKS = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GB_ITEMDETAILS = New System.Windows.Forms.GroupBox()
        Me.TblM4_INVENTORY_ITEMS1DataGridView = New System.Windows.Forms.DataGridView()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAcquisitionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsDataGridViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_CUSTOM = New PRA_PIS.DS_CUSTOM()
        Me.WTXT_SEARCH_ASSIGN_ITEM = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SEARCH_ITEM_DETAIL = New PRA_PIS.WatermarkTextBox()
        Me.BTN_ALL_PLUS = New System.Windows.Forms.Button()
        Me.BTN_ONE_PLUS = New System.Windows.Forms.Button()
        Me.BTN_ONE_MINUS = New System.Windows.Forms.Button()
        Me.BTN_ALL_MINUS = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.DGV_ASSIGN_ITEMS = New System.Windows.Forms.DataGridView()
        Me.ItemCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitTypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCostDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAcquisitionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssignItemsDataGridViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GB_ITEM_DETAILS = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WTXT_ACC_EMP_DIVISION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ACC_EMP_DEPARTMENT = New PRA_PIS.WatermarkTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WTXT_ACC_EMP_NO = New PRA_PIS.WatermarkTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WTXT_ACC_EMP_NAME = New PRA_PIS.WatermarkTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_ACCT_DIVISION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ACCT_DEPARTMENT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ACCT_POSITION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ACCT_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.VWM4_ITEM_ASS_IDGVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VWM4_ITEM_ASS_IDGVTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_ITEM_ASS_IDGVTableAdapter()
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.TblM4_INVENTORY_ASSIGN_PERSONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter()
        Me.TblM4_INVENTORY_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TblM4_INVENTORY_ACCOUNTABLE_OFFICERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_CURRENTDATETIMETableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_CURRENTDATETIMETableAdapter()
        Me.TblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter()
        Me.SpM4_PHY_C_CODETableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_PHY_C_CODETableAdapter()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PNL.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PNL_BOTTOM.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GB_REMARKS.SuspendLayout()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_ITEMDETAILS.SuspendLayout()
        CType(Me.TblM4_INVENTORY_ITEMS1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsDataGridViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ASSIGN_ITEMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignItemsDataGridViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_ITEM_DETAILS.SuspendLayout()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_ITEM_ASS_IDGVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ACCOUNTABLE_OFFICERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PNL.Size = New System.Drawing.Size(1105, 42)
        Me.PNL.TabIndex = 1414
        '
        'BTN_SELECTION_CLOSE
        '
        Me.BTN_SELECTION_CLOSE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_SELECTION_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_SELECTION_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_SELECTION_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SELECTION_CLOSE.Location = New System.Drawing.Point(1072, 8)
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
        Me.Label39.Size = New System.Drawing.Size(104, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "A S S I G N"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3400, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3353, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PNL_BOTTOM)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GB_REMARKS)
        Me.Panel2.Controls.Add(Me.GB_ITEMDETAILS)
        Me.Panel2.Controls.Add(Me.GB_ITEM_DETAILS)
        Me.Panel2.Location = New System.Drawing.Point(4, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1098, 669)
        Me.Panel2.TabIndex = 1473
        '
        'PNL_BOTTOM
        '
        Me.PNL_BOTTOM.Controls.Add(Me.LLBL_ITEMS_ASSIGN_COUNT)
        Me.PNL_BOTTOM.Controls.Add(Me.BTN_ASSIGN_SAVE)
        Me.PNL_BOTTOM.Controls.Add(Me.Label13)
        Me.PNL_BOTTOM.Controls.Add(Me.Label12)
        Me.PNL_BOTTOM.Controls.Add(Me.LLBL_ITEM_DETAILS_COUNT)
        Me.PNL_BOTTOM.Location = New System.Drawing.Point(6, 619)
        Me.PNL_BOTTOM.Name = "PNL_BOTTOM"
        Me.PNL_BOTTOM.Size = New System.Drawing.Size(1083, 37)
        Me.PNL_BOTTOM.TabIndex = 1483
        '
        'LLBL_ITEMS_ASSIGN_COUNT
        '
        Me.LLBL_ITEMS_ASSIGN_COUNT.AutoSize = True
        Me.LLBL_ITEMS_ASSIGN_COUNT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_ITEMS_ASSIGN_COUNT.Location = New System.Drawing.Point(669, 9)
        Me.LLBL_ITEMS_ASSIGN_COUNT.Name = "LLBL_ITEMS_ASSIGN_COUNT"
        Me.LLBL_ITEMS_ASSIGN_COUNT.Size = New System.Drawing.Size(15, 16)
        Me.LLBL_ITEMS_ASSIGN_COUNT.TabIndex = 1493
        Me.LLBL_ITEMS_ASSIGN_COUNT.Text = "0"
        '
        'BTN_ASSIGN_SAVE
        '
        Me.BTN_ASSIGN_SAVE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_ASSIGN_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_ASSIGN_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ASSIGN_SAVE.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_ASSIGN_SAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ASSIGN_SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ASSIGN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ASSIGN_SAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ASSIGN_SAVE.ForeColor = System.Drawing.Color.Black
        Me.BTN_ASSIGN_SAVE.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_ASSIGN_SAVE.Location = New System.Drawing.Point(979, 3)
        Me.BTN_ASSIGN_SAVE.Name = "BTN_ASSIGN_SAVE"
        Me.BTN_ASSIGN_SAVE.Size = New System.Drawing.Size(95, 29)
        Me.BTN_ASSIGN_SAVE.TabIndex = 1484
        Me.BTN_ASSIGN_SAVE.Text = "Save"
        Me.BTN_ASSIGN_SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ASSIGN_SAVE.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(575, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 1492
        Me.Label13.Text = "No. of Items:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 1490
        Me.Label12.Text = "No. of Items:"
        '
        'LLBL_ITEM_DETAILS_COUNT
        '
        Me.LLBL_ITEM_DETAILS_COUNT.AutoSize = True
        Me.LLBL_ITEM_DETAILS_COUNT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_ITEM_DETAILS_COUNT.Location = New System.Drawing.Point(98, 9)
        Me.LLBL_ITEM_DETAILS_COUNT.Name = "LLBL_ITEM_DETAILS_COUNT"
        Me.LLBL_ITEM_DETAILS_COUNT.Size = New System.Drawing.Size(15, 16)
        Me.LLBL_ITEM_DETAILS_COUNT.TabIndex = 1491
        Me.LLBL_ITEM_DETAILS_COUNT.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.WTXT_ASS_PERSON_REMARKS)
        Me.GroupBox2.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(720, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 80)
        Me.GroupBox2.TabIndex = 1482
        Me.GroupBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 1482
        Me.Label9.Text = "Remarks"
        '
        'WTXT_ASS_PERSON_REMARKS
        '
        Me.WTXT_ASS_PERSON_REMARKS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ASS_PERSON_REMARKS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ASS_PERSON_REMARKS.Location = New System.Drawing.Point(14, 31)
        Me.WTXT_ASS_PERSON_REMARKS.Multiline = True
        Me.WTXT_ASS_PERSON_REMARKS.Name = "WTXT_ASS_PERSON_REMARKS"
        Me.WTXT_ASS_PERSON_REMARKS.Size = New System.Drawing.Size(344, 35)
        Me.WTXT_ASS_PERSON_REMARKS.TabIndex = 0
        Me.WTXT_ASS_PERSON_REMARKS.Watermark = Nothing
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape6})
        Me.ShapeContainer2.Size = New System.Drawing.Size(364, 58)
        Me.ShapeContainer2.TabIndex = 1480
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape6.CornerRadius = 5
        Me.RectangleShape6.Location = New System.Drawing.Point(6, 5)
        Me.RectangleShape6.Name = "RECT_PRAPPCODE"
        Me.RectangleShape6.Size = New System.Drawing.Size(353, 45)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.WTXT_ASS_PERSON_DIVISION)
        Me.GroupBox1.Controls.Add(Me.WTXT_ASS_PERSON_DEPARTMENT)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.WTXT_ASS_PERSON_EMP_NO)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.WTXT_ASS_PERSON_NAME)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer5)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(7, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 103)
        Me.GroupBox1.TabIndex = 1481
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assign person to use"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(397, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 1484
        Me.Label5.Text = "Division"
        '
        'WTXT_ASS_PERSON_DIVISION
        '
        Me.WTXT_ASS_PERSON_DIVISION.BackColor = System.Drawing.Color.White
        Me.WTXT_ASS_PERSON_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ASS_PERSON_DIVISION.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ASS_PERSON_DIVISION.Location = New System.Drawing.Point(388, 74)
        Me.WTXT_ASS_PERSON_DIVISION.Name = "WTXT_ASS_PERSON_DIVISION"
        Me.WTXT_ASS_PERSON_DIVISION.ReadOnly = True
        Me.WTXT_ASS_PERSON_DIVISION.Size = New System.Drawing.Size(305, 14)
        Me.WTXT_ASS_PERSON_DIVISION.TabIndex = 3
        Me.WTXT_ASS_PERSON_DIVISION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ASS_PERSON_DIVISION.Watermark = Nothing
        '
        'WTXT_ASS_PERSON_DEPARTMENT
        '
        Me.WTXT_ASS_PERSON_DEPARTMENT.BackColor = System.Drawing.Color.White
        Me.WTXT_ASS_PERSON_DEPARTMENT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ASS_PERSON_DEPARTMENT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ASS_PERSON_DEPARTMENT.Location = New System.Drawing.Point(9, 74)
        Me.WTXT_ASS_PERSON_DEPARTMENT.Name = "WTXT_ASS_PERSON_DEPARTMENT"
        Me.WTXT_ASS_PERSON_DEPARTMENT.ReadOnly = True
        Me.WTXT_ASS_PERSON_DEPARTMENT.Size = New System.Drawing.Size(361, 14)
        Me.WTXT_ASS_PERSON_DEPARTMENT.TabIndex = 1
        Me.WTXT_ASS_PERSON_DEPARTMENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ASS_PERSON_DEPARTMENT.Watermark = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 1482
        Me.Label6.Text = "Department"
        '
        'WTXT_ASS_PERSON_EMP_NO
        '
        Me.WTXT_ASS_PERSON_EMP_NO.BackColor = System.Drawing.Color.White
        Me.WTXT_ASS_PERSON_EMP_NO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ASS_PERSON_EMP_NO.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ASS_PERSON_EMP_NO.Location = New System.Drawing.Point(388, 34)
        Me.WTXT_ASS_PERSON_EMP_NO.Name = "WTXT_ASS_PERSON_EMP_NO"
        Me.WTXT_ASS_PERSON_EMP_NO.ReadOnly = True
        Me.WTXT_ASS_PERSON_EMP_NO.Size = New System.Drawing.Size(305, 14)
        Me.WTXT_ASS_PERSON_EMP_NO.TabIndex = 2
        Me.WTXT_ASS_PERSON_EMP_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ASS_PERSON_EMP_NO.Watermark = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(397, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 1481
        Me.Label7.Text = "Employee No."
        '
        'WTXT_ASS_PERSON_NAME
        '
        Me.WTXT_ASS_PERSON_NAME.BackColor = System.Drawing.Color.White
        Me.WTXT_ASS_PERSON_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ASS_PERSON_NAME.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ASS_PERSON_NAME.Location = New System.Drawing.Point(9, 34)
        Me.WTXT_ASS_PERSON_NAME.Name = "WTXT_ASS_PERSON_NAME"
        Me.WTXT_ASS_PERSON_NAME.ReadOnly = True
        Me.WTXT_ASS_PERSON_NAME.Size = New System.Drawing.Size(361, 14)
        Me.WTXT_ASS_PERSON_NAME.TabIndex = 0
        Me.WTXT_ASS_PERSON_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ASS_PERSON_NAME.Watermark = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 1479
        Me.Label8.Text = "Name"
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_ASS_DIVISION, Me.RECT_ASS_DEPARTMENT, Me.RECT_ASS_POSITION, Me.RECT_ASS_NAME})
        Me.ShapeContainer5.Size = New System.Drawing.Size(703, 81)
        Me.ShapeContainer5.TabIndex = 1480
        Me.ShapeContainer5.TabStop = False
        '
        'RECT_ASS_DIVISION
        '
        Me.RECT_ASS_DIVISION.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ASS_DIVISION.CornerRadius = 5
        Me.RECT_ASS_DIVISION.Location = New System.Drawing.Point(379, 49)
        Me.RECT_ASS_DIVISION.Name = "RECT_ASS_DIVISION"
        Me.RECT_ASS_DIVISION.Size = New System.Drawing.Size(315, 24)
        '
        'RECT_ASS_DEPARTMENT
        '
        Me.RECT_ASS_DEPARTMENT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ASS_DEPARTMENT.CornerRadius = 5
        Me.RECT_ASS_DEPARTMENT.Location = New System.Drawing.Point(1, 49)
        Me.RECT_ASS_DEPARTMENT.Name = "RECT_ASS_DEPARTMENT"
        Me.RECT_ASS_DEPARTMENT.Size = New System.Drawing.Size(373, 24)
        '
        'RECT_ASS_POSITION
        '
        Me.RECT_ASS_POSITION.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ASS_POSITION.CornerRadius = 5
        Me.RECT_ASS_POSITION.Location = New System.Drawing.Point(379, 9)
        Me.RECT_ASS_POSITION.Name = "RECT_ASS_POSITION"
        Me.RECT_ASS_POSITION.Size = New System.Drawing.Size(315, 24)
        '
        'RECT_ASS_NAME
        '
        Me.RECT_ASS_NAME.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ASS_NAME.CornerRadius = 5
        Me.RECT_ASS_NAME.Location = New System.Drawing.Point(1, 9)
        Me.RECT_ASS_NAME.Name = "RECT_ASS_NAME"
        Me.RECT_ASS_NAME.Size = New System.Drawing.Size(372, 24)
        '
        'GB_REMARKS
        '
        Me.GB_REMARKS.Controls.Add(Me.Label11)
        Me.GB_REMARKS.Controls.Add(Me.WTXT_DATE_APPOINTED)
        Me.GB_REMARKS.Controls.Add(Me.Label10)
        Me.GB_REMARKS.Controls.Add(Me.WTXT_ACC_REMARKS)
        Me.GB_REMARKS.Controls.Add(Me.ShapeContainer3)
        Me.GB_REMARKS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GB_REMARKS.ForeColor = System.Drawing.Color.DimGray
        Me.GB_REMARKS.Location = New System.Drawing.Point(720, 0)
        Me.GB_REMARKS.Name = "GB_REMARKS"
        Me.GB_REMARKS.Size = New System.Drawing.Size(370, 121)
        Me.GB_REMARKS.TabIndex = 1479
        Me.GB_REMARKS.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 1485
        Me.Label11.Text = "Date Appointed"
        '
        'WTXT_DATE_APPOINTED
        '
        Me.WTXT_DATE_APPOINTED.BackColor = System.Drawing.Color.White
        Me.WTXT_DATE_APPOINTED.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DATE_APPOINTED.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4CURRENTDATETIMEBindingSource, "datenowFormatted", True))
        Me.WTXT_DATE_APPOINTED.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DATE_APPOINTED.Location = New System.Drawing.Point(17, 30)
        Me.WTXT_DATE_APPOINTED.Name = "WTXT_DATE_APPOINTED"
        Me.WTXT_DATE_APPOINTED.Size = New System.Drawing.Size(190, 20)
        Me.WTXT_DATE_APPOINTED.TabIndex = 1484
        Me.WTXT_DATE_APPOINTED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_DATE_APPOINTED.Watermark = "MM/DD/YYYY"
        '
        'SPM4CURRENTDATETIMEBindingSource
        '
        Me.SPM4CURRENTDATETIMEBindingSource.DataMember = "SPM4_CURRENTDATETIME"
        Me.SPM4CURRENTDATETIMEBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 1483
        Me.Label10.Text = "Remarks"
        '
        'WTXT_ACC_REMARKS
        '
        Me.WTXT_ACC_REMARKS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ACC_REMARKS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ACC_REMARKS.Location = New System.Drawing.Point(15, 76)
        Me.WTXT_ACC_REMARKS.Multiline = True
        Me.WTXT_ACC_REMARKS.Name = "WTXT_ACC_REMARKS"
        Me.WTXT_ACC_REMARKS.Size = New System.Drawing.Size(344, 29)
        Me.WTXT_ACC_REMARKS.TabIndex = 0
        Me.WTXT_ACC_REMARKS.Watermark = Nothing
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape7, Me.RectangleShape9})
        Me.ShapeContainer3.Size = New System.Drawing.Size(364, 99)
        Me.ShapeContainer3.TabIndex = 1480
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(8, 5)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(200, 30)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.Location = New System.Drawing.Point(7, 45)
        Me.RectangleShape9.Name = "RECT_PRAPPCODE"
        Me.RectangleShape9.Size = New System.Drawing.Size(350, 49)
        '
        'GB_ITEMDETAILS
        '
        Me.GB_ITEMDETAILS.Controls.Add(Me.TblM4_INVENTORY_ITEMS1DataGridView)
        Me.GB_ITEMDETAILS.Controls.Add(Me.WTXT_SEARCH_ASSIGN_ITEM)
        Me.GB_ITEMDETAILS.Controls.Add(Me.WTXT_SEARCH_ITEM_DETAIL)
        Me.GB_ITEMDETAILS.Controls.Add(Me.BTN_ALL_PLUS)
        Me.GB_ITEMDETAILS.Controls.Add(Me.BTN_ONE_PLUS)
        Me.GB_ITEMDETAILS.Controls.Add(Me.BTN_ONE_MINUS)
        Me.GB_ITEMDETAILS.Controls.Add(Me.BTN_ALL_MINUS)
        Me.GB_ITEMDETAILS.Controls.Add(Me.PictureBox3)
        Me.GB_ITEMDETAILS.Controls.Add(Me.PictureBox2)
        Me.GB_ITEMDETAILS.Controls.Add(Me.PictureBox1)
        Me.GB_ITEMDETAILS.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.GB_ITEMDETAILS.Controls.Add(Me.DGV_ASSIGN_ITEMS)
        Me.GB_ITEMDETAILS.Controls.Add(Me.ShapeContainer4)
        Me.GB_ITEMDETAILS.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GB_ITEMDETAILS.ForeColor = System.Drawing.Color.DimGray
        Me.GB_ITEMDETAILS.Location = New System.Drawing.Point(7, 210)
        Me.GB_ITEMDETAILS.Name = "GB_ITEMDETAILS"
        Me.GB_ITEMDETAILS.Size = New System.Drawing.Size(1083, 406)
        Me.GB_ITEMDETAILS.TabIndex = 1478
        Me.GB_ITEMDETAILS.TabStop = False
        Me.GB_ITEMDETAILS.Text = "Items Detail"
        '
        'TblM4_INVENTORY_ITEMS1DataGridView
        '
        Me.TblM4_INVENTORY_ITEMS1DataGridView.AllowUserToAddRows = False
        Me.TblM4_INVENTORY_ITEMS1DataGridView.AllowUserToDeleteRows = False
        Me.TblM4_INVENTORY_ITEMS1DataGridView.AllowUserToResizeRows = False
        Me.TblM4_INVENTORY_ITEMS1DataGridView.AutoGenerateColumns = False
        Me.TblM4_INVENTORY_ITEMS1DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.TblM4_INVENTORY_ITEMS1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblM4_INVENTORY_ITEMS1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn, Me.SerialNoDataGridViewTextBoxColumn, Me.ItemDescriptionDataGridViewTextBoxColumn, Me.UnitTypeDataGridViewTextBoxColumn, Me.UnitCostDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.DateAcquisitionDataGridViewTextBoxColumn})
        Me.TblM4_INVENTORY_ITEMS1DataGridView.DataSource = Me.ItemsDataGridViewBindingSource
        Me.TblM4_INVENTORY_ITEMS1DataGridView.Location = New System.Drawing.Point(4, 57)
        Me.TblM4_INVENTORY_ITEMS1DataGridView.Name = "TblM4_INVENTORY_ITEMS1DataGridView"
        Me.TblM4_INVENTORY_ITEMS1DataGridView.ReadOnly = True
        Me.TblM4_INVENTORY_ITEMS1DataGridView.RowHeadersVisible = False
        Me.TblM4_INVENTORY_ITEMS1DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblM4_INVENTORY_ITEMS1DataGridView.Size = New System.Drawing.Size(501, 345)
        Me.TblM4_INVENTORY_ITEMS1DataGridView.TabIndex = 0
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "Item Code"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        Me.ItemCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerialNoDataGridViewTextBoxColumn
        '
        Me.SerialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo"
        Me.SerialNoDataGridViewTextBoxColumn.HeaderText = "Serial No."
        Me.SerialNoDataGridViewTextBoxColumn.Name = "SerialNoDataGridViewTextBoxColumn"
        Me.SerialNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDescriptionDataGridViewTextBoxColumn
        '
        Me.ItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription"
        Me.ItemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.ItemDescriptionDataGridViewTextBoxColumn.Name = "ItemDescriptionDataGridViewTextBoxColumn"
        Me.ItemDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitTypeDataGridViewTextBoxColumn
        '
        Me.UnitTypeDataGridViewTextBoxColumn.DataPropertyName = "UnitType"
        Me.UnitTypeDataGridViewTextBoxColumn.HeaderText = "Unit Type"
        Me.UnitTypeDataGridViewTextBoxColumn.Name = "UnitTypeDataGridViewTextBoxColumn"
        Me.UnitTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitCostDataGridViewTextBoxColumn
        '
        Me.UnitCostDataGridViewTextBoxColumn.DataPropertyName = "UnitCost"
        Me.UnitCostDataGridViewTextBoxColumn.HeaderText = "Unit Cost"
        Me.UnitCostDataGridViewTextBoxColumn.Name = "UnitCostDataGridViewTextBoxColumn"
        Me.UnitCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Visible = False
        '
        'DateAcquisitionDataGridViewTextBoxColumn
        '
        Me.DateAcquisitionDataGridViewTextBoxColumn.DataPropertyName = "DateAcquisition"
        Me.DateAcquisitionDataGridViewTextBoxColumn.HeaderText = "Date Acquisition"
        Me.DateAcquisitionDataGridViewTextBoxColumn.Name = "DateAcquisitionDataGridViewTextBoxColumn"
        Me.DateAcquisitionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemsDataGridViewBindingSource
        '
        Me.ItemsDataGridViewBindingSource.DataMember = "ItemsDataGridView"
        Me.ItemsDataGridViewBindingSource.DataSource = Me.DS_CUSTOM
        '
        'DS_CUSTOM
        '
        Me.DS_CUSTOM.DataSetName = "DS_CUSTOM"
        Me.DS_CUSTOM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WTXT_SEARCH_ASSIGN_ITEM
        '
        Me.WTXT_SEARCH_ASSIGN_ITEM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCH_ASSIGN_ITEM.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCH_ASSIGN_ITEM.Location = New System.Drawing.Point(614, 26)
        Me.WTXT_SEARCH_ASSIGN_ITEM.Name = "WTXT_SEARCH_ASSIGN_ITEM"
        Me.WTXT_SEARCH_ASSIGN_ITEM.Size = New System.Drawing.Size(420, 24)
        Me.WTXT_SEARCH_ASSIGN_ITEM.TabIndex = 1476
        Me.WTXT_SEARCH_ASSIGN_ITEM.Watermark = "Search Item Code, Serial No., Item Description"
        '
        'WTXT_SEARCH_ITEM_DETAIL
        '
        Me.WTXT_SEARCH_ITEM_DETAIL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCH_ITEM_DETAIL.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCH_ITEM_DETAIL.Location = New System.Drawing.Point(44, 26)
        Me.WTXT_SEARCH_ITEM_DETAIL.Name = "WTXT_SEARCH_ITEM_DETAIL"
        Me.WTXT_SEARCH_ITEM_DETAIL.Size = New System.Drawing.Size(420, 24)
        Me.WTXT_SEARCH_ITEM_DETAIL.TabIndex = 1475
        Me.WTXT_SEARCH_ITEM_DETAIL.Watermark = "Search Item Code, Serial No., Item Description"
        '
        'BTN_ALL_PLUS
        '
        Me.BTN_ALL_PLUS.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_ALL_PLUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BTN_ALL_PLUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ALL_PLUS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ALL_PLUS.Location = New System.Drawing.Point(518, 134)
        Me.BTN_ALL_PLUS.Name = "BTN_ALL_PLUS"
        Me.BTN_ALL_PLUS.Size = New System.Drawing.Size(46, 39)
        Me.BTN_ALL_PLUS.TabIndex = 1486
        Me.BTN_ALL_PLUS.Text = ">>"
        Me.BTN_ALL_PLUS.UseVisualStyleBackColor = True
        '
        'BTN_ONE_PLUS
        '
        Me.BTN_ONE_PLUS.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_ONE_PLUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BTN_ONE_PLUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ONE_PLUS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ONE_PLUS.Location = New System.Drawing.Point(518, 179)
        Me.BTN_ONE_PLUS.Name = "BTN_ONE_PLUS"
        Me.BTN_ONE_PLUS.Size = New System.Drawing.Size(46, 39)
        Me.BTN_ONE_PLUS.TabIndex = 1487
        Me.BTN_ONE_PLUS.Text = ">"
        Me.BTN_ONE_PLUS.UseVisualStyleBackColor = True
        '
        'BTN_ONE_MINUS
        '
        Me.BTN_ONE_MINUS.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_ONE_MINUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BTN_ONE_MINUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ONE_MINUS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ONE_MINUS.Location = New System.Drawing.Point(518, 224)
        Me.BTN_ONE_MINUS.Name = "BTN_ONE_MINUS"
        Me.BTN_ONE_MINUS.Size = New System.Drawing.Size(46, 39)
        Me.BTN_ONE_MINUS.TabIndex = 1488
        Me.BTN_ONE_MINUS.Text = "<"
        Me.BTN_ONE_MINUS.UseVisualStyleBackColor = True
        '
        'BTN_ALL_MINUS
        '
        Me.BTN_ALL_MINUS.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_ALL_MINUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BTN_ALL_MINUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ALL_MINUS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ALL_MINUS.Location = New System.Drawing.Point(518, 269)
        Me.BTN_ALL_MINUS.Name = "BTN_ALL_MINUS"
        Me.BTN_ALL_MINUS.Size = New System.Drawing.Size(46, 39)
        Me.BTN_ALL_MINUS.TabIndex = 1489
        Me.BTN_ALL_MINUS.Text = "<<"
        Me.BTN_ALL_MINUS.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(578, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox3.TabIndex = 1483
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(1040, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox2.TabIndex = 1482
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(470, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox1.TabIndex = 1481
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PB_INVENTORY_SEARCH
        '
        Me.PB_INVENTORY_SEARCH.BackgroundImage = CType(resources.GetObject("PB_INVENTORY_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_INVENTORY_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_SEARCH.Location = New System.Drawing.Point(8, 23)
        Me.PB_INVENTORY_SEARCH.Name = "PB_INVENTORY_SEARCH"
        Me.PB_INVENTORY_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_SEARCH.TabIndex = 1482
        Me.PB_INVENTORY_SEARCH.TabStop = False
        '
        'DGV_ASSIGN_ITEMS
        '
        Me.DGV_ASSIGN_ITEMS.AllowUserToAddRows = False
        Me.DGV_ASSIGN_ITEMS.AllowUserToDeleteRows = False
        Me.DGV_ASSIGN_ITEMS.AllowUserToResizeRows = False
        Me.DGV_ASSIGN_ITEMS.AutoGenerateColumns = False
        Me.DGV_ASSIGN_ITEMS.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_ASSIGN_ITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ASSIGN_ITEMS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn1, Me.SerialNoDataGridViewTextBoxColumn1, Me.ItemDescriptionDataGridViewTextBoxColumn1, Me.UnitTypeDataGridViewTextBoxColumn1, Me.UnitCostDataGridViewTextBoxColumn1, Me.QuantityDataGridViewTextBoxColumn1, Me.DateAcquisitionDataGridViewTextBoxColumn1})
        Me.DGV_ASSIGN_ITEMS.DataSource = Me.AssignItemsDataGridViewBindingSource
        Me.DGV_ASSIGN_ITEMS.Location = New System.Drawing.Point(575, 59)
        Me.DGV_ASSIGN_ITEMS.Name = "DGV_ASSIGN_ITEMS"
        Me.DGV_ASSIGN_ITEMS.ReadOnly = True
        Me.DGV_ASSIGN_ITEMS.RowHeadersVisible = False
        Me.DGV_ASSIGN_ITEMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ASSIGN_ITEMS.Size = New System.Drawing.Size(500, 343)
        Me.DGV_ASSIGN_ITEMS.TabIndex = 1
        '
        'ItemCodeDataGridViewTextBoxColumn1
        '
        Me.ItemCodeDataGridViewTextBoxColumn1.DataPropertyName = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn1.HeaderText = "Item Code"
        Me.ItemCodeDataGridViewTextBoxColumn1.Name = "ItemCodeDataGridViewTextBoxColumn1"
        Me.ItemCodeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SerialNoDataGridViewTextBoxColumn1
        '
        Me.SerialNoDataGridViewTextBoxColumn1.DataPropertyName = "SerialNo"
        Me.SerialNoDataGridViewTextBoxColumn1.HeaderText = "Serial No."
        Me.SerialNoDataGridViewTextBoxColumn1.Name = "SerialNoDataGridViewTextBoxColumn1"
        Me.SerialNoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ItemDescriptionDataGridViewTextBoxColumn1
        '
        Me.ItemDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "ItemDescription"
        Me.ItemDescriptionDataGridViewTextBoxColumn1.HeaderText = "Item Description"
        Me.ItemDescriptionDataGridViewTextBoxColumn1.Name = "ItemDescriptionDataGridViewTextBoxColumn1"
        Me.ItemDescriptionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UnitTypeDataGridViewTextBoxColumn1
        '
        Me.UnitTypeDataGridViewTextBoxColumn1.DataPropertyName = "UnitType"
        Me.UnitTypeDataGridViewTextBoxColumn1.HeaderText = "Unit Type"
        Me.UnitTypeDataGridViewTextBoxColumn1.Name = "UnitTypeDataGridViewTextBoxColumn1"
        Me.UnitTypeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UnitCostDataGridViewTextBoxColumn1
        '
        Me.UnitCostDataGridViewTextBoxColumn1.DataPropertyName = "UnitCost"
        Me.UnitCostDataGridViewTextBoxColumn1.HeaderText = "Unit Cost"
        Me.UnitCostDataGridViewTextBoxColumn1.Name = "UnitCostDataGridViewTextBoxColumn1"
        Me.UnitCostDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn1
        '
        Me.QuantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.Name = "QuantityDataGridViewTextBoxColumn1"
        Me.QuantityDataGridViewTextBoxColumn1.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn1.Visible = False
        '
        'DateAcquisitionDataGridViewTextBoxColumn1
        '
        Me.DateAcquisitionDataGridViewTextBoxColumn1.DataPropertyName = "DateAcquisition"
        Me.DateAcquisitionDataGridViewTextBoxColumn1.HeaderText = "Date Acquisition"
        Me.DateAcquisitionDataGridViewTextBoxColumn1.Name = "DateAcquisitionDataGridViewTextBoxColumn1"
        Me.DateAcquisitionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'AssignItemsDataGridViewBindingSource
        '
        Me.AssignItemsDataGridViewBindingSource.DataMember = "AssignItemsDataGridView"
        Me.AssignItemsDataGridViewBindingSource.DataSource = Me.DS_CUSTOM
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RECT_PRCANCELEDIT})
        Me.ShapeContainer4.Size = New System.Drawing.Size(1077, 384)
        Me.ShapeContainer4.TabIndex = 2
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape5.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(1, 1)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(500, 33)
        '
        'RECT_PRCANCELEDIT
        '
        Me.RECT_PRCANCELEDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRCANCELEDIT.CornerRadius = 5
        Me.RECT_PRCANCELEDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRCANCELEDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRCANCELEDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(571, 1)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(500, 33)
        '
        'GB_ITEM_DETAILS
        '
        Me.GB_ITEM_DETAILS.Controls.Add(Me.Label14)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.Label4)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.WTXT_ACC_EMP_DIVISION)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.WTXT_ACC_EMP_DEPARTMENT)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.Label2)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.WTXT_ACC_EMP_NO)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.Label3)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.WTXT_ACC_EMP_NAME)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.Label1)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.ShapeContainer1)
        Me.GB_ITEM_DETAILS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_ITEM_DETAILS.ForeColor = System.Drawing.Color.DimGray
        Me.GB_ITEM_DETAILS.Location = New System.Drawing.Point(7, 0)
        Me.GB_ITEM_DETAILS.Name = "GB_ITEM_DETAILS"
        Me.GB_ITEM_DETAILS.Size = New System.Drawing.Size(709, 103)
        Me.GB_ITEM_DETAILS.TabIndex = 1477
        Me.GB_ITEM_DETAILS.TabStop = False
        Me.GB_ITEM_DETAILS.Text = "Accountable Officer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(397, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 1484
        Me.Label4.Text = "Division"
        '
        'WTXT_ACC_EMP_DIVISION
        '
        Me.WTXT_ACC_EMP_DIVISION.BackColor = System.Drawing.Color.White
        Me.WTXT_ACC_EMP_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ACC_EMP_DIVISION.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ACC_EMP_DIVISION.Location = New System.Drawing.Point(388, 74)
        Me.WTXT_ACC_EMP_DIVISION.Name = "WTXT_ACC_EMP_DIVISION"
        Me.WTXT_ACC_EMP_DIVISION.ReadOnly = True
        Me.WTXT_ACC_EMP_DIVISION.Size = New System.Drawing.Size(305, 14)
        Me.WTXT_ACC_EMP_DIVISION.TabIndex = 3
        Me.WTXT_ACC_EMP_DIVISION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ACC_EMP_DIVISION.Watermark = Nothing
        '
        'WTXT_ACC_EMP_DEPARTMENT
        '
        Me.WTXT_ACC_EMP_DEPARTMENT.BackColor = System.Drawing.Color.White
        Me.WTXT_ACC_EMP_DEPARTMENT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ACC_EMP_DEPARTMENT.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ACC_EMP_DEPARTMENT.Location = New System.Drawing.Point(9, 74)
        Me.WTXT_ACC_EMP_DEPARTMENT.Name = "WTXT_ACC_EMP_DEPARTMENT"
        Me.WTXT_ACC_EMP_DEPARTMENT.ReadOnly = True
        Me.WTXT_ACC_EMP_DEPARTMENT.Size = New System.Drawing.Size(361, 14)
        Me.WTXT_ACC_EMP_DEPARTMENT.TabIndex = 1
        Me.WTXT_ACC_EMP_DEPARTMENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ACC_EMP_DEPARTMENT.Watermark = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 1482
        Me.Label2.Text = "Department"
        '
        'WTXT_ACC_EMP_NO
        '
        Me.WTXT_ACC_EMP_NO.BackColor = System.Drawing.Color.White
        Me.WTXT_ACC_EMP_NO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ACC_EMP_NO.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ACC_EMP_NO.Location = New System.Drawing.Point(388, 34)
        Me.WTXT_ACC_EMP_NO.Name = "WTXT_ACC_EMP_NO"
        Me.WTXT_ACC_EMP_NO.ReadOnly = True
        Me.WTXT_ACC_EMP_NO.Size = New System.Drawing.Size(305, 14)
        Me.WTXT_ACC_EMP_NO.TabIndex = 2
        Me.WTXT_ACC_EMP_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ACC_EMP_NO.Watermark = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 1481
        Me.Label3.Text = "Employee No."
        '
        'WTXT_ACC_EMP_NAME
        '
        Me.WTXT_ACC_EMP_NAME.BackColor = System.Drawing.Color.White
        Me.WTXT_ACC_EMP_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ACC_EMP_NAME.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ACC_EMP_NAME.Location = New System.Drawing.Point(9, 34)
        Me.WTXT_ACC_EMP_NAME.Name = "WTXT_ACC_EMP_NAME"
        Me.WTXT_ACC_EMP_NAME.ReadOnly = True
        Me.WTXT_ACC_EMP_NAME.Size = New System.Drawing.Size(347, 14)
        Me.WTXT_ACC_EMP_NAME.TabIndex = 0
        Me.WTXT_ACC_EMP_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ACC_EMP_NAME.Watermark = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 1479
        Me.Label1.Text = "Name"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_ACCT_DIVISION, Me.RECT_ACCT_DEPARTMENT, Me.RECT_ACCT_POSITION, Me.RECT_ACCT_NAME})
        Me.ShapeContainer1.Size = New System.Drawing.Size(703, 81)
        Me.ShapeContainer1.TabIndex = 1480
        Me.ShapeContainer1.TabStop = False
        '
        'RECT_ACCT_DIVISION
        '
        Me.RECT_ACCT_DIVISION.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ACCT_DIVISION.CornerRadius = 5
        Me.RECT_ACCT_DIVISION.Location = New System.Drawing.Point(379, 49)
        Me.RECT_ACCT_DIVISION.Name = "RECT_ACCT_DIVISION"
        Me.RECT_ACCT_DIVISION.Size = New System.Drawing.Size(315, 24)
        '
        'RECT_ACCT_DEPARTMENT
        '
        Me.RECT_ACCT_DEPARTMENT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ACCT_DEPARTMENT.CornerRadius = 5
        Me.RECT_ACCT_DEPARTMENT.Location = New System.Drawing.Point(1, 49)
        Me.RECT_ACCT_DEPARTMENT.Name = "RECT_ACCT_DEPARTMENT"
        Me.RECT_ACCT_DEPARTMENT.Size = New System.Drawing.Size(373, 24)
        '
        'RECT_ACCT_POSITION
        '
        Me.RECT_ACCT_POSITION.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ACCT_POSITION.CornerRadius = 5
        Me.RECT_ACCT_POSITION.Location = New System.Drawing.Point(379, 9)
        Me.RECT_ACCT_POSITION.Name = "RECT_ACCT_POSITION"
        Me.RECT_ACCT_POSITION.Size = New System.Drawing.Size(315, 24)
        '
        'RECT_ACCT_NAME
        '
        Me.RECT_ACCT_NAME.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ACCT_NAME.CornerRadius = 5
        Me.RECT_ACCT_NAME.Location = New System.Drawing.Point(1, 9)
        Me.RECT_ACCT_NAME.Name = "RECT_ACCT_NAME"
        Me.RECT_ACCT_NAME.Size = New System.Drawing.Size(373, 24)
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VWM4_ITEM_ASS_IDGVBindingSource
        '
        Me.VWM4_ITEM_ASS_IDGVBindingSource.DataMember = "VWM4_ITEM_ASS_IDGV"
        Me.VWM4_ITEM_ASS_IDGVBindingSource.DataSource = Me.DS_VIEWS
        '
        'VWM4_ITEM_ASS_IDGVTableAdapter
        '
        Me.VWM4_ITEM_ASS_IDGVTableAdapter.ClearBeforeFill = True
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblM4_INVENTORY_ASSIGN_PERSONTableAdapter
        '
        Me.TblM4_INVENTORY_ASSIGN_PERSONTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TBLM4_INV_ITEMS_IMGTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENG_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENGTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_MIGRATETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAME_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAMETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_PCOUNTTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_STK_CTRLTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_STOCKSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter = Me.TblM4_INVENTORY_ASSIGN_PERSONTableAdapter
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEMS_DRTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEMS_INVTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMSTableAdapter = Me.TblM4_INVENTORY_ITEMSTableAdapter
        Me.TableAdapterManager.TBLM4_INVENTORY_PACK_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_PACKTableAdapter = Nothing
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
        Me.TableAdapterManager.TBLM4_PURCHASEREQUEST_SUP_CATTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUESTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblM4_INVENTORY_ACCOUNTABLE_OFFICERBindingSource
        '
        Me.TblM4_INVENTORY_ACCOUNTABLE_OFFICERBindingSource.DataSource = Me.DS_PROPERTYDB
        Me.TblM4_INVENTORY_ACCOUNTABLE_OFFICERBindingSource.Position = 0
        '
        'SPM4_CURRENTDATETIMETableAdapter
        '
        Me.SPM4_CURRENTDATETIMETableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter
        '
        Me.TblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter.ClearBeforeFill = True
        '
        'SpM4_PHY_C_CODETableAdapter
        '
        Me.SpM4_PHY_C_CODETableAdapter.ClearBeforeFill = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(362, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 16)
        Me.Label14.TabIndex = 1486
        Me.Label14.Text = "*"
        '
        'FRM_ASSIGN
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1105, 720)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PNL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ASSIGN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ASSIGN"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PNL_BOTTOM.ResumeLayout(False)
        Me.PNL_BOTTOM.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GB_REMARKS.ResumeLayout(False)
        Me.GB_REMARKS.PerformLayout()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_ITEMDETAILS.ResumeLayout(False)
        Me.GB_ITEMDETAILS.PerformLayout()
        CType(Me.TblM4_INVENTORY_ITEMS1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsDataGridViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ASSIGN_ITEMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignItemsDataGridViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_ITEM_DETAILS.ResumeLayout(False)
        Me.GB_ITEM_DETAILS.PerformLayout()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_ITEM_ASS_IDGVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ACCOUNTABLE_OFFICERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_SELECTION_CLOSE As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GB_ITEM_DETAILS As GroupBox
    Friend WithEvents RECT_ACCT_NAME As PowerPacks.RectangleShape
    Friend WithEvents WTXT_ACC_EMP_NAME As WatermarkTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents WTXT_ACC_EMP_DIVISION As WatermarkTextBox
    Friend WithEvents WTXT_ACC_EMP_DEPARTMENT As WatermarkTextBox
    Friend WithEvents RECT_ACCT_DIVISION As PowerPacks.RectangleShape
    Friend WithEvents RECT_ACCT_DEPARTMENT As PowerPacks.RectangleShape
    Friend WithEvents GB_ITEMDETAILS As GroupBox
    Friend WithEvents GB_REMARKS As GroupBox
    Friend WithEvents WTXT_ACC_REMARKS As WatermarkTextBox
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents DGV_ASSIGN_ITEMS As DataGridView
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BTN_ASSIGN_SAVE As Button
    Friend WithEvents BTN_ALL_PLUS As Button
    Friend WithEvents BTN_ONE_PLUS As Button
    Friend WithEvents BTN_ONE_MINUS As Button
    Friend WithEvents BTN_ALL_MINUS As Button
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents WTXT_SEARCH_ITEM_DETAIL As WatermarkTextBox
    Friend WithEvents WTXT_SEARCH_ASSIGN_ITEM As WatermarkTextBox
    Friend WithEvents TblM4_INVENTORY_ASSIGN_PERSONTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter
    Friend WithEvents DS_CUSTOM As DS_CUSTOM
    Friend WithEvents ItemsDataGridViewBindingSource As BindingSource
    Friend WithEvents WTXT_ACC_EMP_NO As WatermarkTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RECT_ACCT_POSITION As PowerPacks.RectangleShape
    Friend WithEvents AssignItemsDataGridViewBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents TblM4_INVENTORY_ITEMS1DataGridView As DataGridView
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents WTXT_ASS_PERSON_DIVISION As WatermarkTextBox
    Friend WithEvents WTXT_ASS_PERSON_DEPARTMENT As WatermarkTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents WTXT_ASS_PERSON_EMP_NO As WatermarkTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents WTXT_ASS_PERSON_NAME As WatermarkTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ShapeContainer5 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_ASS_DIVISION As PowerPacks.RectangleShape
    Friend WithEvents RECT_ASS_DEPARTMENT As PowerPacks.RectangleShape
    Friend WithEvents RECT_ASS_POSITION As PowerPacks.RectangleShape
    Friend WithEvents RECT_ASS_NAME As PowerPacks.RectangleShape
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents WTXT_ASS_PERSON_REMARKS As WatermarkTextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents Label10 As Label
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents VWM4_ITEM_ASS_IDGVBindingSource As BindingSource
    Friend WithEvents VWM4_ITEM_ASS_IDGVTableAdapter As DS_VIEWSTableAdapters.VWM4_ITEM_ASS_IDGVTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents WTXT_DATE_APPOINTED As WatermarkTextBox
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents TblM4_INVENTORY_ACCOUNTABLE_OFFICERBindingSource As BindingSource
    Friend WithEvents LLBL_ITEMS_ASSIGN_COUNT As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LLBL_ITEM_DETAILS_COUNT As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PNL_BOTTOM As Panel
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerialNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAcquisitionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SerialNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UnitTypeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UnitCostDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateAcquisitionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SPM4CURRENTDATETIMEBindingSource As BindingSource
    Friend WithEvents SPM4_CURRENTDATETIMETableAdapter As DS_STOREDPROCTableAdapters.SPM4_CURRENTDATETIMETableAdapter
    Friend WithEvents TblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter
    Friend WithEvents SpM4_PHY_C_CODETableAdapter As DS_STOREDPROCTableAdapters.SPM4_PHY_C_CODETableAdapter
    Friend WithEvents Label14 As Label
End Class
