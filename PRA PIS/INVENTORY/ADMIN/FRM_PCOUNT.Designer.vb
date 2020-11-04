<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PCOUNT
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_PCOUNT))
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_PHY_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.DGV_PCOUNT_LIST = New System.Windows.Forms.DataGridView()
        Me.DATEENCODEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOMREASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOMIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOMCHKBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOMNOTEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOMREMARKSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOMDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Print = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Migrate = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VWM4_PCM_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LLBL_MIGRATE = New System.Windows.Forms.LinkLabel()
        Me.PB_MIGRATE = New System.Windows.Forms.PictureBox()
        Me.PNL_DATES = New System.Windows.Forms.Panel()
        Me.BTN_DATE_TO = New System.Windows.Forms.Button()
        Me.WTXT_DATE_TO = New PRA_PIS.WatermarkTextBox()
        Me.SPM4CURRENTDATETIMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.WTXT_DATE_FROM = New PRA_PIS.WatermarkTextBox()
        Me.BTN_DATE_FROM = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LLBL_NEW_PHY_C = New System.Windows.Forms.LinkLabel()
        Me.PB_NEW_PHY_C = New System.Windows.Forms.PictureBox()
        Me.PNL_DGV = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PNL_PHY_DETAILS = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LLBL_PHY_CANCEL = New System.Windows.Forms.LinkLabel()
        Me.PB_PHY_CANCEL = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_ADD_ITEM = New System.Windows.Forms.Button()
        Me.WTXT_PHY_NOTED_BY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_PHY_CHK_BY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_PHY_REMARKS = New PRA_PIS.WatermarkTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PB_PHY_SAVE = New System.Windows.Forms.PictureBox()
        Me.LLBL_PHY_SAVE = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WTXT_PHY_DATE_ENCODED = New PRA_PIS.WatermarkTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.WTXT_PHY_REASON = New PRA_PIS.WatermarkTextBox()
        Me.DGV_ITEM_PCOUNT = New System.Windows.Forms.DataGridView()
        Me.ITEM_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITM_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOU_STK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitcost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalcost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unittype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOU_REMARKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOU_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIONEDIT = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ACTIONREMOVE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GBOX_SETTINGS = New System.Windows.Forms.GroupBox()
        Me.LLBL_RECORDSFOUND = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PHY_CANCEL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PHY_NOTED_BY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PHY_CHK_BY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PHY_SAVE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PHY_REMARKS = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PHY_DATE_ENCODED = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PHY_REASON = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_MIGRATE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_NEW_PHY_C = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PNL_ITEM_DETAILS_ENC = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CB_UNIT_TYPE = New System.Windows.Forms.ComboBox()
        Me.TBLG3UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.WTXT_TOTAL_COST = New PRA_PIS.WatermarkTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.WTXT_UNIT_COST = New PRA_PIS.WatermarkTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WTXT_EXISTING_STOCK = New PRA_PIS.WatermarkTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.WTXT_ITEM_COUNT_BY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ITEM_REMARKS = New PRA_PIS.WatermarkTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_ITEM_DETAILS_ENC_CANCEL = New System.Windows.Forms.Button()
        Me.BTN_ITEM_DETAILS_ENC_SAVE = New System.Windows.Forms.Button()
        Me.WTXT_QTY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ITEM_DESCRIPTION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ITEM_CODE = New PRA_PIS.WatermarkTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_COUNT_BY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ITEM_DESCRIPTION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DS_PRAJO_DATABASE = New PRA_PIS.DS_PRAJO_DATABASE()
        Me.SPM4_PDS_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_PDS_LISTTableAdapter = New PRA_PIS.DS_PRAJO_DATABASETableAdapters.SPM4_PDS_LISTTableAdapter()
        Me.SPM4_PHY_C_CODETableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_PHY_C_CODETableAdapter()
        Me.SPM4_PHY_C_CODEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_CURRENTDATETIMETableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_CURRENTDATETIMETableAdapter()
        Me.VWM4_ITEM_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VWM4_ITEM_LISTTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager()
        Me.VWM4_PCM_LISTTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_PCM_LISTTableAdapter()
        Me.SPM4_GET_EXIST_STOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_GET_EXIST_STOCKTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_GET_EXIST_STOCKTableAdapter()
        Me.TableAdapterManager1 = New PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager()
        Me.DGV_PCOUNT_DETAILS = New System.Windows.Forms.DataGridView()
        Me.PCOMIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOUSTKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOUREMARKSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCOUBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLM4_INV_ITEMS_PCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4INVITEMSPCOUNTMAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_PCOUNTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_PCOUNTTableAdapter()
        Me.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter()
        Me.TBLM4_INV_ITEMS_PCOUNT_MAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_MIGRATETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_MIGRATETableAdapter()
        Me.TBLM4_INV_ITEMS_MIGRATEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_MIGRATEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_MIGRATETableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_MIGRATETableAdapter()
        Me.TBLG3_UNITSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter()
        Me.PNL.SuspendLayout()
        CType(Me.DGV_PCOUNT_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_PCM_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_MIGRATE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_DATES.SuspendLayout()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_NEW_PHY_C, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_DGV.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PNL_PHY_DETAILS.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PHY_CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PHY_SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ITEM_PCOUNT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBOX_SETTINGS.SuspendLayout()
        Me.PNL_ITEM_DETAILS_ENC.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PRAJO_DATABASE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PDS_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PHY_C_CODEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_GET_EXIST_STOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_PCOUNT_DETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_PCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVITEMSPCOUNTMAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_PCOUNT_MAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_MIGRATEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_MIGRATEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_PHY_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1085, 49)
        Me.PNL.TabIndex = 1408
        '
        'BTN_PHY_CLOSE
        '
        Me.BTN_PHY_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_PHY_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_PHY_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_PHY_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_PHY_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PHY_CLOSE.Location = New System.Drawing.Point(1043, 11)
        Me.BTN_PHY_CLOSE.Name = "BTN_PHY_CLOSE"
        Me.BTN_PHY_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_PHY_CLOSE.TabIndex = 16
        Me.BTN_PHY_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_PHY_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(23, 14)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(206, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "P h y s i c a l  C o u n t"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-11363, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-11316, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'DGV_PCOUNT_LIST
        '
        Me.DGV_PCOUNT_LIST.AllowUserToAddRows = False
        Me.DGV_PCOUNT_LIST.AllowUserToDeleteRows = False
        Me.DGV_PCOUNT_LIST.AllowUserToResizeColumns = False
        Me.DGV_PCOUNT_LIST.AllowUserToResizeRows = False
        Me.DGV_PCOUNT_LIST.AutoGenerateColumns = False
        Me.DGV_PCOUNT_LIST.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_PCOUNT_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DGV_PCOUNT_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PCOUNT_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DATEENCODEDDataGridViewTextBoxColumn, Me.PCOMREASDataGridViewTextBoxColumn, Me.PCOMIDDataGridViewTextBoxColumn, Me.PCOMCHKBYDataGridViewTextBoxColumn, Me.PCOMNOTEDBYDataGridViewTextBoxColumn, Me.PCOMREMARKSDataGridViewTextBoxColumn, Me.PCOMDATEDataGridViewTextBoxColumn, Me.Print, Me.Migrate})
        Me.DGV_PCOUNT_LIST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_PCOUNT_LIST.DataSource = Me.VWM4_PCM_LISTBindingSource
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_PCOUNT_LIST.DefaultCellStyle = DataGridViewCellStyle18
        Me.DGV_PCOUNT_LIST.Location = New System.Drawing.Point(2, 4)
        Me.DGV_PCOUNT_LIST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_PCOUNT_LIST.MultiSelect = False
        Me.DGV_PCOUNT_LIST.Name = "DGV_PCOUNT_LIST"
        Me.DGV_PCOUNT_LIST.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_PCOUNT_LIST.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DGV_PCOUNT_LIST.RowHeadersVisible = False
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Gray
        Me.DGV_PCOUNT_LIST.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DGV_PCOUNT_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PCOUNT_LIST.Size = New System.Drawing.Size(262, 542)
        Me.DGV_PCOUNT_LIST.TabIndex = 0
        '
        'DATEENCODEDDataGridViewTextBoxColumn
        '
        Me.DATEENCODEDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DATEENCODEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_ENCODED"
        Me.DATEENCODEDDataGridViewTextBoxColumn.HeaderText = "Date Encoded"
        Me.DATEENCODEDDataGridViewTextBoxColumn.Name = "DATEENCODEDDataGridViewTextBoxColumn"
        Me.DATEENCODEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DATEENCODEDDataGridViewTextBoxColumn.Width = 85
        '
        'PCOMREASDataGridViewTextBoxColumn
        '
        Me.PCOMREASDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PCOMREASDataGridViewTextBoxColumn.DataPropertyName = "PCOM_REAS"
        Me.PCOMREASDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.PCOMREASDataGridViewTextBoxColumn.Name = "PCOMREASDataGridViewTextBoxColumn"
        Me.PCOMREASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PCOMIDDataGridViewTextBoxColumn
        '
        Me.PCOMIDDataGridViewTextBoxColumn.DataPropertyName = "PCOM_ID"
        Me.PCOMIDDataGridViewTextBoxColumn.HeaderText = "PCOM_ID"
        Me.PCOMIDDataGridViewTextBoxColumn.Name = "PCOMIDDataGridViewTextBoxColumn"
        Me.PCOMIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PCOMIDDataGridViewTextBoxColumn.Visible = False
        '
        'PCOMCHKBYDataGridViewTextBoxColumn
        '
        Me.PCOMCHKBYDataGridViewTextBoxColumn.DataPropertyName = "PCOM_CHK_BY"
        Me.PCOMCHKBYDataGridViewTextBoxColumn.HeaderText = "PCOM_CHK_BY"
        Me.PCOMCHKBYDataGridViewTextBoxColumn.Name = "PCOMCHKBYDataGridViewTextBoxColumn"
        Me.PCOMCHKBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.PCOMCHKBYDataGridViewTextBoxColumn.Visible = False
        '
        'PCOMNOTEDBYDataGridViewTextBoxColumn
        '
        Me.PCOMNOTEDBYDataGridViewTextBoxColumn.DataPropertyName = "PCOM_NOTED_BY"
        Me.PCOMNOTEDBYDataGridViewTextBoxColumn.HeaderText = "PCOM_NOTED_BY"
        Me.PCOMNOTEDBYDataGridViewTextBoxColumn.Name = "PCOMNOTEDBYDataGridViewTextBoxColumn"
        Me.PCOMNOTEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.PCOMNOTEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'PCOMREMARKSDataGridViewTextBoxColumn
        '
        Me.PCOMREMARKSDataGridViewTextBoxColumn.DataPropertyName = "PCOM_REMARKS"
        Me.PCOMREMARKSDataGridViewTextBoxColumn.HeaderText = "PCOM_REMARKS"
        Me.PCOMREMARKSDataGridViewTextBoxColumn.Name = "PCOMREMARKSDataGridViewTextBoxColumn"
        Me.PCOMREMARKSDataGridViewTextBoxColumn.ReadOnly = True
        Me.PCOMREMARKSDataGridViewTextBoxColumn.Visible = False
        '
        'PCOMDATEDataGridViewTextBoxColumn
        '
        Me.PCOMDATEDataGridViewTextBoxColumn.DataPropertyName = "PCOM_DATE"
        Me.PCOMDATEDataGridViewTextBoxColumn.HeaderText = "PCOM_DATE"
        Me.PCOMDATEDataGridViewTextBoxColumn.Name = "PCOMDATEDataGridViewTextBoxColumn"
        Me.PCOMDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PCOMDATEDataGridViewTextBoxColumn.Visible = False
        '
        'Print
        '
        Me.Print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Print.HeaderText = "Print"
        Me.Print.Image = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.Print.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Print.Name = "Print"
        Me.Print.ReadOnly = True
        Me.Print.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Print.Width = 40
        '
        'Migrate
        '
        Me.Migrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Migrate.HeaderText = "Migrate"
        Me.Migrate.Image = Global.PRA_PIS.My.Resources.Resources.baseline_sync_black_18dp
        Me.Migrate.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Migrate.Name = "Migrate"
        Me.Migrate.ReadOnly = True
        Me.Migrate.Visible = False
        Me.Migrate.Width = 50
        '
        'VWM4_PCM_LISTBindingSource
        '
        Me.VWM4_PCM_LISTBindingSource.DataMember = "VWM4_PCM_LIST"
        Me.VWM4_PCM_LISTBindingSource.DataSource = Me.DS_VIEWS
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LLBL_MIGRATE)
        Me.Panel1.Controls.Add(Me.PB_MIGRATE)
        Me.Panel1.Controls.Add(Me.PNL_DATES)
        Me.Panel1.Controls.Add(Me.LLBL_NEW_PHY_C)
        Me.Panel1.Controls.Add(Me.PB_NEW_PHY_C)
        Me.Panel1.Controls.Add(Me.PNL_DGV)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ShapeContainer5)
        Me.Panel1.Location = New System.Drawing.Point(2, 51)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 607)
        Me.Panel1.TabIndex = 1418
        '
        'LLBL_MIGRATE
        '
        Me.LLBL_MIGRATE.AutoSize = True
        Me.LLBL_MIGRATE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_MIGRATE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_MIGRATE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_MIGRATE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_MIGRATE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_MIGRATE.Location = New System.Drawing.Point(984, 18)
        Me.LLBL_MIGRATE.Name = "LLBL_MIGRATE"
        Me.LLBL_MIGRATE.Size = New System.Drawing.Size(82, 19)
        Me.LLBL_MIGRATE.TabIndex = 1543
        Me.LLBL_MIGRATE.TabStop = True
        Me.LLBL_MIGRATE.Text = "MIGRATE"
        '
        'PB_MIGRATE
        '
        Me.PB_MIGRATE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources._323_3233189_plm_migration_data_source_icon_png_clipart
        Me.PB_MIGRATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_MIGRATE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_MIGRATE.InitialImage = Nothing
        Me.PB_MIGRATE.Location = New System.Drawing.Point(947, 11)
        Me.PB_MIGRATE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_MIGRATE.Name = "PB_MIGRATE"
        Me.PB_MIGRATE.Size = New System.Drawing.Size(37, 34)
        Me.PB_MIGRATE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_MIGRATE.TabIndex = 1544
        Me.PB_MIGRATE.TabStop = False
        '
        'PNL_DATES
        '
        Me.PNL_DATES.Controls.Add(Me.BTN_DATE_TO)
        Me.PNL_DATES.Controls.Add(Me.WTXT_DATE_TO)
        Me.PNL_DATES.Controls.Add(Me.Label9)
        Me.PNL_DATES.Controls.Add(Me.WTXT_DATE_FROM)
        Me.PNL_DATES.Controls.Add(Me.BTN_DATE_FROM)
        Me.PNL_DATES.Controls.Add(Me.Label4)
        Me.PNL_DATES.Controls.Add(Me.ShapeContainer1)
        Me.PNL_DATES.Location = New System.Drawing.Point(2, 3)
        Me.PNL_DATES.Name = "PNL_DATES"
        Me.PNL_DATES.Size = New System.Drawing.Size(272, 49)
        Me.PNL_DATES.TabIndex = 1541
        '
        'BTN_DATE_TO
        '
        Me.BTN_DATE_TO.BackColor = System.Drawing.Color.LightGray
        Me.BTN_DATE_TO.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_event_note_black_18dp
        Me.BTN_DATE_TO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_DATE_TO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_DATE_TO.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BTN_DATE_TO.FlatAppearance.BorderSize = 3
        Me.BTN_DATE_TO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BTN_DATE_TO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DATE_TO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DATE_TO.ForeColor = System.Drawing.Color.White
        Me.BTN_DATE_TO.Location = New System.Drawing.Point(241, 15)
        Me.BTN_DATE_TO.Name = "BTN_DATE_TO"
        Me.BTN_DATE_TO.Padding = New System.Windows.Forms.Padding(15)
        Me.BTN_DATE_TO.Size = New System.Drawing.Size(25, 25)
        Me.BTN_DATE_TO.TabIndex = 1528
        Me.BTN_DATE_TO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN_DATE_TO.UseVisualStyleBackColor = False
        '
        'WTXT_DATE_TO
        '
        Me.WTXT_DATE_TO.BackColor = System.Drawing.Color.White
        Me.WTXT_DATE_TO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DATE_TO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_DATE_TO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4CURRENTDATETIMEBindingSource, "datenowFormatted", True))
        Me.WTXT_DATE_TO.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DATE_TO.ForeColor = System.Drawing.Color.Black
        Me.WTXT_DATE_TO.Location = New System.Drawing.Point(142, 19)
        Me.WTXT_DATE_TO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_DATE_TO.MaxLength = 300
        Me.WTXT_DATE_TO.Name = "WTXT_DATE_TO"
        Me.WTXT_DATE_TO.ReadOnly = True
        Me.WTXT_DATE_TO.Size = New System.Drawing.Size(100, 19)
        Me.WTXT_DATE_TO.TabIndex = 1524
        Me.WTXT_DATE_TO.Watermark = "MM/DD/YYYY"
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(151, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 16)
        Me.Label9.TabIndex = 1540
        Me.Label9.Text = "TO"
        '
        'WTXT_DATE_FROM
        '
        Me.WTXT_DATE_FROM.BackColor = System.Drawing.Color.White
        Me.WTXT_DATE_FROM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DATE_FROM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_DATE_FROM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4CURRENTDATETIMEBindingSource, "datenowFormatted", True))
        Me.WTXT_DATE_FROM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DATE_FROM.ForeColor = System.Drawing.Color.Black
        Me.WTXT_DATE_FROM.Location = New System.Drawing.Point(7, 19)
        Me.WTXT_DATE_FROM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_DATE_FROM.MaxLength = 300
        Me.WTXT_DATE_FROM.Name = "WTXT_DATE_FROM"
        Me.WTXT_DATE_FROM.ReadOnly = True
        Me.WTXT_DATE_FROM.Size = New System.Drawing.Size(100, 19)
        Me.WTXT_DATE_FROM.TabIndex = 1523
        Me.WTXT_DATE_FROM.Watermark = "MM/DD/YYYY"
        '
        'BTN_DATE_FROM
        '
        Me.BTN_DATE_FROM.BackColor = System.Drawing.Color.LightGray
        Me.BTN_DATE_FROM.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_event_note_black_18dp
        Me.BTN_DATE_FROM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_DATE_FROM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_DATE_FROM.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.BTN_DATE_FROM.FlatAppearance.BorderSize = 3
        Me.BTN_DATE_FROM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BTN_DATE_FROM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DATE_FROM.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DATE_FROM.ForeColor = System.Drawing.Color.White
        Me.BTN_DATE_FROM.Location = New System.Drawing.Point(107, 15)
        Me.BTN_DATE_FROM.Name = "BTN_DATE_FROM"
        Me.BTN_DATE_FROM.Padding = New System.Windows.Forms.Padding(15)
        Me.BTN_DATE_FROM.Size = New System.Drawing.Size(25, 25)
        Me.BTN_DATE_FROM.TabIndex = 1527
        Me.BTN_DATE_FROM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTN_DATE_FROM.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(9, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 1539
        Me.Label4.Text = "FROM"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(272, 49)
        Me.ShapeContainer1.TabIndex = 1540
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(137, 11)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(132, 32)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(3, 11)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(132, 32)
        '
        'LLBL_NEW_PHY_C
        '
        Me.LLBL_NEW_PHY_C.AutoSize = True
        Me.LLBL_NEW_PHY_C.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_NEW_PHY_C.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_NEW_PHY_C.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_NEW_PHY_C.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_NEW_PHY_C.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_NEW_PHY_C.Location = New System.Drawing.Point(325, 18)
        Me.LLBL_NEW_PHY_C.Name = "LLBL_NEW_PHY_C"
        Me.LLBL_NEW_PHY_C.Size = New System.Drawing.Size(123, 19)
        Me.LLBL_NEW_PHY_C.TabIndex = 1457
        Me.LLBL_NEW_PHY_C.TabStop = True
        Me.LLBL_NEW_PHY_C.Text = "NEW P.COUNT"
        '
        'PB_NEW_PHY_C
        '
        Me.PB_NEW_PHY_C.BackgroundImage = CType(resources.GetObject("PB_NEW_PHY_C.BackgroundImage"), System.Drawing.Image)
        Me.PB_NEW_PHY_C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_NEW_PHY_C.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_NEW_PHY_C.InitialImage = Nothing
        Me.PB_NEW_PHY_C.Location = New System.Drawing.Point(287, 10)
        Me.PB_NEW_PHY_C.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_NEW_PHY_C.Name = "PB_NEW_PHY_C"
        Me.PB_NEW_PHY_C.Size = New System.Drawing.Size(37, 34)
        Me.PB_NEW_PHY_C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_NEW_PHY_C.TabIndex = 1458
        Me.PB_NEW_PHY_C.TabStop = False
        '
        'PNL_DGV
        '
        Me.PNL_DGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_DGV.Controls.Add(Me.DGV_PCOUNT_LIST)
        Me.PNL_DGV.Location = New System.Drawing.Point(4, 52)
        Me.PNL_DGV.Name = "PNL_DGV"
        Me.PNL_DGV.Size = New System.Drawing.Size(268, 552)
        Me.PNL_DGV.TabIndex = 1527
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PNL_PHY_DETAILS)
        Me.Panel2.Location = New System.Drawing.Point(274, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 552)
        Me.Panel2.TabIndex = 1523
        '
        'PNL_PHY_DETAILS
        '
        Me.PNL_PHY_DETAILS.Controls.Add(Me.PictureBox6)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.PictureBox5)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.PictureBox4)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.LLBL_PHY_CANCEL)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.PB_PHY_CANCEL)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.Label5)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.BTN_ADD_ITEM)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.WTXT_PHY_NOTED_BY)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.WTXT_PHY_CHK_BY)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.WTXT_PHY_REMARKS)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.Label3)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.PB_PHY_SAVE)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.LLBL_PHY_SAVE)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.Label2)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.Label1)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.WTXT_PHY_DATE_ENCODED)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.Label7)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.Label10)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.WTXT_PHY_REASON)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.DGV_ITEM_PCOUNT)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.GBOX_SETTINGS)
        Me.PNL_PHY_DETAILS.Controls.Add(Me.ShapeContainer2)
        Me.PNL_PHY_DETAILS.Enabled = False
        Me.PNL_PHY_DETAILS.Location = New System.Drawing.Point(2, 3)
        Me.PNL_PHY_DETAILS.Name = "PNL_PHY_DETAILS"
        Me.PNL_PHY_DETAILS.Size = New System.Drawing.Size(796, 545)
        Me.PNL_PHY_DETAILS.TabIndex = 0
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.REQ_FIELD
        Me.PictureBox6.Location = New System.Drawing.Point(760, 457)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox6.TabIndex = 1518
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.REQ_FIELD
        Me.PictureBox5.Location = New System.Drawing.Point(367, 457)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox5.TabIndex = 1518
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.REQ_FIELD
        Me.PictureBox4.Location = New System.Drawing.Point(597, 39)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox4.TabIndex = 1517
        Me.PictureBox4.TabStop = False
        '
        'LLBL_PHY_CANCEL
        '
        Me.LLBL_PHY_CANCEL.AutoSize = True
        Me.LLBL_PHY_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PHY_CANCEL.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_PHY_CANCEL.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PHY_CANCEL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PHY_CANCEL.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PHY_CANCEL.Location = New System.Drawing.Point(709, 511)
        Me.LLBL_PHY_CANCEL.Name = "LLBL_PHY_CANCEL"
        Me.LLBL_PHY_CANCEL.Size = New System.Drawing.Size(77, 19)
        Me.LLBL_PHY_CANCEL.TabIndex = 1526
        Me.LLBL_PHY_CANCEL.TabStop = True
        Me.LLBL_PHY_CANCEL.Text = "CANCEL"
        '
        'PB_PHY_CANCEL
        '
        Me.PB_PHY_CANCEL.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.PB_PHY_CANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PHY_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PHY_CANCEL.InitialImage = Nothing
        Me.PB_PHY_CANCEL.Location = New System.Drawing.Point(677, 506)
        Me.PB_PHY_CANCEL.Name = "PB_PHY_CANCEL"
        Me.PB_PHY_CANCEL.Size = New System.Drawing.Size(32, 28)
        Me.PB_PHY_CANCEL.TabIndex = 1533
        Me.PB_PHY_CANCEL.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(5, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 16)
        Me.Label5.TabIndex = 1539
        Me.Label5.Text = "PHYSICAL COUNT DETAILS"
        '
        'BTN_ADD_ITEM
        '
        Me.BTN_ADD_ITEM.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_ADD_ITEM.Location = New System.Drawing.Point(674, 119)
        Me.BTN_ADD_ITEM.Name = "BTN_ADD_ITEM"
        Me.BTN_ADD_ITEM.Size = New System.Drawing.Size(111, 26)
        Me.BTN_ADD_ITEM.TabIndex = 1547
        Me.BTN_ADD_ITEM.Text = "Add item"
        Me.BTN_ADD_ITEM.UseVisualStyleBackColor = True
        '
        'WTXT_PHY_NOTED_BY
        '
        Me.WTXT_PHY_NOTED_BY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WTXT_PHY_NOTED_BY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.WTXT_PHY_NOTED_BY.BackColor = System.Drawing.Color.White
        Me.WTXT_PHY_NOTED_BY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PHY_NOTED_BY.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_PHY_NOTED_BY.Location = New System.Drawing.Point(477, 460)
        Me.WTXT_PHY_NOTED_BY.Name = "WTXT_PHY_NOTED_BY"
        Me.WTXT_PHY_NOTED_BY.Size = New System.Drawing.Size(279, 19)
        Me.WTXT_PHY_NOTED_BY.TabIndex = 1546
        Me.WTXT_PHY_NOTED_BY.Watermark = ""
        '
        'WTXT_PHY_CHK_BY
        '
        Me.WTXT_PHY_CHK_BY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WTXT_PHY_CHK_BY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.WTXT_PHY_CHK_BY.BackColor = System.Drawing.Color.White
        Me.WTXT_PHY_CHK_BY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PHY_CHK_BY.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_PHY_CHK_BY.Location = New System.Drawing.Point(85, 460)
        Me.WTXT_PHY_CHK_BY.Name = "WTXT_PHY_CHK_BY"
        Me.WTXT_PHY_CHK_BY.Size = New System.Drawing.Size(278, 19)
        Me.WTXT_PHY_CHK_BY.TabIndex = 1545
        Me.WTXT_PHY_CHK_BY.Watermark = ""
        '
        'WTXT_PHY_REMARKS
        '
        Me.WTXT_PHY_REMARKS.BackColor = System.Drawing.Color.White
        Me.WTXT_PHY_REMARKS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PHY_REMARKS.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_PHY_REMARKS.Location = New System.Drawing.Point(18, 87)
        Me.WTXT_PHY_REMARKS.Name = "WTXT_PHY_REMARKS"
        Me.WTXT_PHY_REMARKS.Size = New System.Drawing.Size(763, 21)
        Me.WTXT_PHY_REMARKS.TabIndex = 1544
        Me.WTXT_PHY_REMARKS.Watermark = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(399, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 1543
        Me.Label3.Text = "Noted by:"
        '
        'PB_PHY_SAVE
        '
        Me.PB_PHY_SAVE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_save_black_18dp
        Me.PB_PHY_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PHY_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PHY_SAVE.InitialImage = Nothing
        Me.PB_PHY_SAVE.Location = New System.Drawing.Point(573, 505)
        Me.PB_PHY_SAVE.Name = "PB_PHY_SAVE"
        Me.PB_PHY_SAVE.Size = New System.Drawing.Size(32, 28)
        Me.PB_PHY_SAVE.TabIndex = 1526
        Me.PB_PHY_SAVE.TabStop = False
        '
        'LLBL_PHY_SAVE
        '
        Me.LLBL_PHY_SAVE.AutoSize = True
        Me.LLBL_PHY_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PHY_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_PHY_SAVE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PHY_SAVE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PHY_SAVE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PHY_SAVE.Location = New System.Drawing.Point(607, 509)
        Me.LLBL_PHY_SAVE.Name = "LLBL_PHY_SAVE"
        Me.LLBL_PHY_SAVE.Size = New System.Drawing.Size(52, 19)
        Me.LLBL_PHY_SAVE.TabIndex = 1525
        Me.LLBL_PHY_SAVE.TabStop = True
        Me.LLBL_PHY_SAVE.Text = "SAVE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(5, 462)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 1542
        Me.Label2.Text = "Check by:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(21, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 1541
        Me.Label1.Text = "Remarks"
        '
        'WTXT_PHY_DATE_ENCODED
        '
        Me.WTXT_PHY_DATE_ENCODED.BackColor = System.Drawing.Color.White
        Me.WTXT_PHY_DATE_ENCODED.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PHY_DATE_ENCODED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_PHY_DATE_ENCODED.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_PHY_DATE_ENCODED.Location = New System.Drawing.Point(630, 41)
        Me.WTXT_PHY_DATE_ENCODED.Name = "WTXT_PHY_DATE_ENCODED"
        Me.WTXT_PHY_DATE_ENCODED.Size = New System.Drawing.Size(151, 21)
        Me.WTXT_PHY_DATE_ENCODED.TabIndex = 1540
        Me.WTXT_PHY_DATE_ENCODED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_PHY_DATE_ENCODED.Watermark = "MM/DD/YYYY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(638, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 1539
        Me.Label7.Text = "Date Encoded"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(21, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 17)
        Me.Label10.TabIndex = 1538
        Me.Label10.Text = "Reason for pyhsical count"
        '
        'WTXT_PHY_REASON
        '
        Me.WTXT_PHY_REASON.BackColor = System.Drawing.Color.White
        Me.WTXT_PHY_REASON.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PHY_REASON.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_PHY_REASON.Location = New System.Drawing.Point(18, 42)
        Me.WTXT_PHY_REASON.Name = "WTXT_PHY_REASON"
        Me.WTXT_PHY_REASON.Size = New System.Drawing.Size(574, 21)
        Me.WTXT_PHY_REASON.TabIndex = 1537
        Me.WTXT_PHY_REASON.Watermark = ""
        '
        'DGV_ITEM_PCOUNT
        '
        Me.DGV_ITEM_PCOUNT.AllowUserToAddRows = False
        Me.DGV_ITEM_PCOUNT.AllowUserToDeleteRows = False
        Me.DGV_ITEM_PCOUNT.AllowUserToResizeColumns = False
        Me.DGV_ITEM_PCOUNT.AllowUserToResizeRows = False
        Me.DGV_ITEM_PCOUNT.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ITEM_PCOUNT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.DGV_ITEM_PCOUNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEM_PCOUNT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM_CODE, Me.ITM_DESC, Me.PCOU_STK, Me.unitcost, Me.totalcost, Me.unittype, Me.PCOU_REMARKS, Me.PCOU_BY, Me.ACTIONEDIT, Me.ACTIONREMOVE})
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ITEM_PCOUNT.DefaultCellStyle = DataGridViewCellStyle22
        Me.DGV_ITEM_PCOUNT.Location = New System.Drawing.Point(7, 155)
        Me.DGV_ITEM_PCOUNT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_ITEM_PCOUNT.MultiSelect = False
        Me.DGV_ITEM_PCOUNT.Name = "DGV_ITEM_PCOUNT"
        Me.DGV_ITEM_PCOUNT.ReadOnly = True
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ITEM_PCOUNT.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.DGV_ITEM_PCOUNT.RowHeadersVisible = False
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Gray
        Me.DGV_ITEM_PCOUNT.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DGV_ITEM_PCOUNT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEM_PCOUNT.Size = New System.Drawing.Size(782, 288)
        Me.DGV_ITEM_PCOUNT.TabIndex = 1440
        '
        'ITEM_CODE
        '
        Me.ITEM_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEM_CODE.HeaderText = "Item Code"
        Me.ITEM_CODE.Name = "ITEM_CODE"
        Me.ITEM_CODE.ReadOnly = True
        '
        'ITM_DESC
        '
        Me.ITM_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITM_DESC.HeaderText = "Item Description"
        Me.ITM_DESC.Name = "ITM_DESC"
        Me.ITM_DESC.ReadOnly = True
        '
        'PCOU_STK
        '
        Me.PCOU_STK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PCOU_STK.HeaderText = "No. of stocks"
        Me.PCOU_STK.Name = "PCOU_STK"
        Me.PCOU_STK.ReadOnly = True
        '
        'unitcost
        '
        Me.unitcost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.unitcost.HeaderText = "Unit cost"
        Me.unitcost.Name = "unitcost"
        Me.unitcost.ReadOnly = True
        '
        'totalcost
        '
        Me.totalcost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.totalcost.HeaderText = "Total cost"
        Me.totalcost.Name = "totalcost"
        Me.totalcost.ReadOnly = True
        '
        'unittype
        '
        Me.unittype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.unittype.HeaderText = "Unit type"
        Me.unittype.Name = "unittype"
        Me.unittype.ReadOnly = True
        '
        'PCOU_REMARKS
        '
        Me.PCOU_REMARKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PCOU_REMARKS.HeaderText = "Remarks"
        Me.PCOU_REMARKS.Name = "PCOU_REMARKS"
        Me.PCOU_REMARKS.ReadOnly = True
        '
        'PCOU_BY
        '
        Me.PCOU_BY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PCOU_BY.HeaderText = "Count by"
        Me.PCOU_BY.Name = "PCOU_BY"
        Me.PCOU_BY.ReadOnly = True
        '
        'ACTIONEDIT
        '
        Me.ACTIONEDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ACTIONEDIT.HeaderText = "Action"
        Me.ACTIONEDIT.Name = "ACTIONEDIT"
        Me.ACTIONEDIT.ReadOnly = True
        Me.ACTIONEDIT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ACTIONEDIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ACTIONEDIT.Text = "Edit"
        Me.ACTIONEDIT.UseColumnTextForButtonValue = True
        Me.ACTIONEDIT.Width = 70
        '
        'ACTIONREMOVE
        '
        Me.ACTIONREMOVE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ACTIONREMOVE.HeaderText = "Action"
        Me.ACTIONREMOVE.Name = "ACTIONREMOVE"
        Me.ACTIONREMOVE.ReadOnly = True
        Me.ACTIONREMOVE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ACTIONREMOVE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ACTIONREMOVE.Text = "Remove"
        Me.ACTIONREMOVE.UseColumnTextForButtonValue = True
        Me.ACTIONREMOVE.Width = 70
        '
        'GBOX_SETTINGS
        '
        Me.GBOX_SETTINGS.Controls.Add(Me.LLBL_RECORDSFOUND)
        Me.GBOX_SETTINGS.Controls.Add(Me.LinkLabel1)
        Me.GBOX_SETTINGS.Location = New System.Drawing.Point(3, 492)
        Me.GBOX_SETTINGS.Name = "GBOX_SETTINGS"
        Me.GBOX_SETTINGS.Size = New System.Drawing.Size(313, 50)
        Me.GBOX_SETTINGS.TabIndex = 1439
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
        Me.LLBL_RECORDSFOUND.Location = New System.Drawing.Point(265, 19)
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
        Me.LinkLabel1.Size = New System.Drawing.Size(159, 19)
        Me.LinkLabel1.TabIndex = 1440
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Total No. of items :"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PHY_CANCEL, Me.RectangleShape6, Me.RECT_PHY_NOTED_BY, Me.RECT_PHY_CHK_BY, Me.RECT_PHY_SAVE, Me.RECT_PHY_REMARKS, Me.RECT_PHY_DATE_ENCODED, Me.RECT_PHY_REASON})
        Me.ShapeContainer2.Size = New System.Drawing.Size(796, 545)
        Me.ShapeContainer2.TabIndex = 1444
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_PHY_CANCEL
        '
        Me.RECT_PHY_CANCEL.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PHY_CANCEL.BorderWidth = 2
        Me.RECT_PHY_CANCEL.CornerRadius = 19
        Me.RECT_PHY_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_PHY_CANCEL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PHY_CANCEL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PHY_CANCEL.Location = New System.Drawing.Point(668, 500)
        Me.RECT_PHY_CANCEL.Name = "RECT_PHY_CANCEL"
        Me.RECT_PHY_CANCEL.Size = New System.Drawing.Size(121, 39)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.CornerRadius = 19
        Me.RectangleShape6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape6.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape6.Location = New System.Drawing.Point(341, 254)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(115, 39)
        '
        'RECT_PHY_NOTED_BY
        '
        Me.RECT_PHY_NOTED_BY.BorderColor = System.Drawing.Color.Gray
        Me.RECT_PHY_NOTED_BY.CornerRadius = 5
        Me.RECT_PHY_NOTED_BY.Location = New System.Drawing.Point(473, 453)
        Me.RECT_PHY_NOTED_BY.Name = "RECT_PHY_NOTED_BY"
        Me.RECT_PHY_NOTED_BY.Size = New System.Drawing.Size(314, 32)
        '
        'RECT_PHY_CHK_BY
        '
        Me.RECT_PHY_CHK_BY.BorderColor = System.Drawing.Color.Gray
        Me.RECT_PHY_CHK_BY.CornerRadius = 5
        Me.RECT_PHY_CHK_BY.Location = New System.Drawing.Point(79, 453)
        Me.RECT_PHY_CHK_BY.Name = "RECT_PHY_CHK_BY"
        Me.RECT_PHY_CHK_BY.Size = New System.Drawing.Size(316, 32)
        '
        'RECT_PHY_SAVE
        '
        Me.RECT_PHY_SAVE.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PHY_SAVE.BorderWidth = 2
        Me.RECT_PHY_SAVE.CornerRadius = 19
        Me.RECT_PHY_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_PHY_SAVE.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PHY_SAVE.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PHY_SAVE.Location = New System.Drawing.Point(559, 499)
        Me.RECT_PHY_SAVE.Name = "RECT_PHY_SAVE"
        Me.RECT_PHY_SAVE.Size = New System.Drawing.Size(106, 39)
        '
        'RECT_PHY_REMARKS
        '
        Me.RECT_PHY_REMARKS.BorderColor = System.Drawing.Color.Gray
        Me.RECT_PHY_REMARKS.CornerRadius = 5
        Me.RECT_PHY_REMARKS.Location = New System.Drawing.Point(13, 80)
        Me.RECT_PHY_REMARKS.Name = "RECT_PHY_REMARKS"
        Me.RECT_PHY_REMARKS.Size = New System.Drawing.Size(771, 32)
        '
        'RECT_PHY_DATE_ENCODED
        '
        Me.RECT_PHY_DATE_ENCODED.BorderColor = System.Drawing.Color.Gray
        Me.RECT_PHY_DATE_ENCODED.CornerRadius = 5
        Me.RECT_PHY_DATE_ENCODED.Location = New System.Drawing.Point(626, 35)
        Me.RECT_PHY_DATE_ENCODED.Name = "RECT_PHY_DATE_ENCODED"
        Me.RECT_PHY_DATE_ENCODED.Size = New System.Drawing.Size(158, 32)
        '
        'RECT_PHY_REASON
        '
        Me.RECT_PHY_REASON.BorderColor = System.Drawing.Color.Gray
        Me.RECT_PHY_REASON.CornerRadius = 5
        Me.RECT_PHY_REASON.Location = New System.Drawing.Point(13, 35)
        Me.RECT_PHY_REASON.Name = "RECT_PHY_REASON"
        Me.RECT_PHY_REASON.Size = New System.Drawing.Size(611, 32)
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_MIGRATE, Me.RECT_NEW_PHY_C})
        Me.ShapeContainer5.Size = New System.Drawing.Size(1080, 607)
        Me.ShapeContainer5.TabIndex = 1528
        Me.ShapeContainer5.TabStop = False
        '
        'RECT_MIGRATE
        '
        Me.RECT_MIGRATE.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_MIGRATE.BorderWidth = 2
        Me.RECT_MIGRATE.CornerRadius = 19
        Me.RECT_MIGRATE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_MIGRATE.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_MIGRATE.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_MIGRATE.Location = New System.Drawing.Point(930, 7)
        Me.RECT_MIGRATE.Name = "RECT_MIGRATE"
        Me.RECT_MIGRATE.Size = New System.Drawing.Size(143, 40)
        '
        'RECT_NEW_PHY_C
        '
        Me.RECT_NEW_PHY_C.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_NEW_PHY_C.BorderWidth = 2
        Me.RECT_NEW_PHY_C.CornerRadius = 19
        Me.RECT_NEW_PHY_C.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_NEW_PHY_C.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_NEW_PHY_C.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_NEW_PHY_C.Location = New System.Drawing.Point(274, 6)
        Me.RECT_NEW_PHY_C.Name = "RECT_NEW_PHY_C"
        Me.RECT_NEW_PHY_C.Size = New System.Drawing.Size(181, 40)
        '
        'PNL_ITEM_DETAILS_ENC
        '
        Me.PNL_ITEM_DETAILS_ENC.Controls.Add(Me.Panel7)
        Me.PNL_ITEM_DETAILS_ENC.Controls.Add(Me.ShapeContainer6)
        Me.PNL_ITEM_DETAILS_ENC.Location = New System.Drawing.Point(300, 221)
        Me.PNL_ITEM_DETAILS_ENC.Name = "PNL_ITEM_DETAILS_ENC"
        Me.PNL_ITEM_DETAILS_ENC.Size = New System.Drawing.Size(628, 294)
        Me.PNL_ITEM_DETAILS_ENC.TabIndex = 1532
        Me.PNL_ITEM_DETAILS_ENC.Visible = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.CB_UNIT_TYPE)
        Me.Panel7.Controls.Add(Me.Label18)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Controls.Add(Me.WTXT_TOTAL_COST)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.WTXT_UNIT_COST)
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.WTXT_EXISTING_STOCK)
        Me.Panel7.Controls.Add(Me.PictureBox3)
        Me.Panel7.Controls.Add(Me.PictureBox7)
        Me.Panel7.Controls.Add(Me.WTXT_ITEM_COUNT_BY)
        Me.Panel7.Controls.Add(Me.WTXT_ITEM_REMARKS)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.BTN_ITEM_DETAILS_ENC_CANCEL)
        Me.Panel7.Controls.Add(Me.BTN_ITEM_DETAILS_ENC_SAVE)
        Me.Panel7.Controls.Add(Me.WTXT_QTY)
        Me.Panel7.Controls.Add(Me.WTXT_ITEM_DESCRIPTION)
        Me.Panel7.Controls.Add(Me.WTXT_ITEM_CODE)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.ShapeContainer4)
        Me.Panel7.Location = New System.Drawing.Point(5, 7)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(617, 264)
        Me.Panel7.TabIndex = 1
        '
        'CB_UNIT_TYPE
        '
        Me.CB_UNIT_TYPE.DataSource = Me.TBLG3UNITSBindingSource
        Me.CB_UNIT_TYPE.DisplayMember = "UN_DESCRIPTION"
        Me.CB_UNIT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_UNIT_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_UNIT_TYPE.FormattingEnabled = True
        Me.CB_UNIT_TYPE.Location = New System.Drawing.Point(495, 163)
        Me.CB_UNIT_TYPE.Name = "CB_UNIT_TYPE"
        Me.CB_UNIT_TYPE.Size = New System.Drawing.Size(99, 21)
        Me.CB_UNIT_TYPE.TabIndex = 1543
        Me.CB_UNIT_TYPE.ValueMember = "UN_NO"
        '
        'TBLG3UNITSBindingSource
        '
        Me.TBLG3UNITSBindingSource.DataMember = "TBLG3_UNITS"
        Me.TBLG3UNITSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(497, 148)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 17)
        Me.Label18.TabIndex = 1543
        Me.Label18.Text = "Unit type"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(388, 149)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 17)
        Me.Label17.TabIndex = 1545
        Me.Label17.Text = "Total cost"
        '
        'WTXT_TOTAL_COST
        '
        Me.WTXT_TOTAL_COST.BackColor = System.Drawing.Color.White
        Me.WTXT_TOTAL_COST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_TOTAL_COST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_TOTAL_COST.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_TOTAL_COST.ForeColor = System.Drawing.Color.Black
        Me.WTXT_TOTAL_COST.Location = New System.Drawing.Point(385, 163)
        Me.WTXT_TOTAL_COST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_TOTAL_COST.MaxLength = 300
        Me.WTXT_TOTAL_COST.Name = "WTXT_TOTAL_COST"
        Me.WTXT_TOTAL_COST.ReadOnly = True
        Me.WTXT_TOTAL_COST.Size = New System.Drawing.Size(95, 21)
        Me.WTXT_TOTAL_COST.TabIndex = 1546
        Me.WTXT_TOTAL_COST.Text = "0.00"
        Me.WTXT_TOTAL_COST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_TOTAL_COST.Watermark = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(270, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 17)
        Me.Label16.TabIndex = 1544
        Me.Label16.Text = "Unit cost"
        '
        'WTXT_UNIT_COST
        '
        Me.WTXT_UNIT_COST.BackColor = System.Drawing.Color.White
        Me.WTXT_UNIT_COST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_UNIT_COST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_UNIT_COST.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_UNIT_COST.ForeColor = System.Drawing.Color.Black
        Me.WTXT_UNIT_COST.Location = New System.Drawing.Point(258, 163)
        Me.WTXT_UNIT_COST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_UNIT_COST.MaxLength = 300
        Me.WTXT_UNIT_COST.Name = "WTXT_UNIT_COST"
        Me.WTXT_UNIT_COST.Size = New System.Drawing.Size(114, 21)
        Me.WTXT_UNIT_COST.TabIndex = 1543
        Me.WTXT_UNIT_COST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_UNIT_COST.Watermark = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(27, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 17)
        Me.Label15.TabIndex = 1534
        Me.Label15.Text = "Existing stocks"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(27, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 1513
        Me.Label8.Text = "Count by"
        '
        'WTXT_EXISTING_STOCK
        '
        Me.WTXT_EXISTING_STOCK.BackColor = System.Drawing.Color.White
        Me.WTXT_EXISTING_STOCK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_EXISTING_STOCK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_EXISTING_STOCK.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_EXISTING_STOCK.ForeColor = System.Drawing.Color.Black
        Me.WTXT_EXISTING_STOCK.Location = New System.Drawing.Point(25, 163)
        Me.WTXT_EXISTING_STOCK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_EXISTING_STOCK.MaxLength = 300
        Me.WTXT_EXISTING_STOCK.Name = "WTXT_EXISTING_STOCK"
        Me.WTXT_EXISTING_STOCK.ReadOnly = True
        Me.WTXT_EXISTING_STOCK.Size = New System.Drawing.Size(108, 21)
        Me.WTXT_EXISTING_STOCK.TabIndex = 1535
        Me.WTXT_EXISTING_STOCK.Text = "0"
        Me.WTXT_EXISTING_STOCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_EXISTING_STOCK.Watermark = ""
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.REQ_FIELD
        Me.PictureBox3.Location = New System.Drawing.Point(571, 79)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.TabIndex = 1517
        Me.PictureBox3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.REQ_FIELD
        Me.PictureBox7.Location = New System.Drawing.Point(571, 199)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox7.TabIndex = 1533
        Me.PictureBox7.TabStop = False
        '
        'WTXT_ITEM_COUNT_BY
        '
        Me.WTXT_ITEM_COUNT_BY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WTXT_ITEM_COUNT_BY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.WTXT_ITEM_COUNT_BY.BackColor = System.Drawing.Color.White
        Me.WTXT_ITEM_COUNT_BY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_COUNT_BY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_ITEM_COUNT_BY.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_COUNT_BY.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_COUNT_BY.Location = New System.Drawing.Point(22, 202)
        Me.WTXT_ITEM_COUNT_BY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_COUNT_BY.MaxLength = 300
        Me.WTXT_ITEM_COUNT_BY.Name = "WTXT_ITEM_COUNT_BY"
        Me.WTXT_ITEM_COUNT_BY.Size = New System.Drawing.Size(543, 19)
        Me.WTXT_ITEM_COUNT_BY.TabIndex = 1514
        Me.WTXT_ITEM_COUNT_BY.Watermark = ""
        '
        'WTXT_ITEM_REMARKS
        '
        Me.WTXT_ITEM_REMARKS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WTXT_ITEM_REMARKS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.WTXT_ITEM_REMARKS.BackColor = System.Drawing.Color.White
        Me.WTXT_ITEM_REMARKS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_REMARKS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_ITEM_REMARKS.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_REMARKS.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_REMARKS.Location = New System.Drawing.Point(25, 122)
        Me.WTXT_ITEM_REMARKS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_REMARKS.MaxLength = 300
        Me.WTXT_ITEM_REMARKS.Name = "WTXT_ITEM_REMARKS"
        Me.WTXT_ITEM_REMARKS.Size = New System.Drawing.Size(571, 21)
        Me.WTXT_ITEM_REMARKS.TabIndex = 1512
        Me.WTXT_ITEM_REMARKS.Watermark = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(27, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 1511
        Me.Label6.Text = "Remarks"
        '
        'BTN_ITEM_DETAILS_ENC_CANCEL
        '
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Location = New System.Drawing.Point(509, 231)
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Name = "BTN_ITEM_DETAILS_ENC_CANCEL"
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Size = New System.Drawing.Size(91, 27)
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.TabIndex = 1510
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Text = "CLOSE"
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.UseVisualStyleBackColor = True
        '
        'BTN_ITEM_DETAILS_ENC_SAVE
        '
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Location = New System.Drawing.Point(407, 231)
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Name = "BTN_ITEM_DETAILS_ENC_SAVE"
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Size = New System.Drawing.Size(100, 27)
        Me.BTN_ITEM_DETAILS_ENC_SAVE.TabIndex = 1509
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Text = "SAVE ITEM"
        Me.BTN_ITEM_DETAILS_ENC_SAVE.UseVisualStyleBackColor = True
        '
        'WTXT_QTY
        '
        Me.WTXT_QTY.BackColor = System.Drawing.Color.White
        Me.WTXT_QTY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_QTY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_QTY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_QTY.ForeColor = System.Drawing.Color.Black
        Me.WTXT_QTY.Location = New System.Drawing.Point(148, 163)
        Me.WTXT_QTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_QTY.MaxLength = 300
        Me.WTXT_QTY.Name = "WTXT_QTY"
        Me.WTXT_QTY.Size = New System.Drawing.Size(96, 21)
        Me.WTXT_QTY.TabIndex = 1505
        Me.WTXT_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_QTY.Watermark = "0"
        '
        'WTXT_ITEM_DESCRIPTION
        '
        Me.WTXT_ITEM_DESCRIPTION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WTXT_ITEM_DESCRIPTION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.WTXT_ITEM_DESCRIPTION.BackColor = System.Drawing.Color.White
        Me.WTXT_ITEM_DESCRIPTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_DESCRIPTION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_ITEM_DESCRIPTION.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_DESCRIPTION.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_DESCRIPTION.Location = New System.Drawing.Point(27, 82)
        Me.WTXT_ITEM_DESCRIPTION.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_DESCRIPTION.MaxLength = 300
        Me.WTXT_ITEM_DESCRIPTION.Name = "WTXT_ITEM_DESCRIPTION"
        Me.WTXT_ITEM_DESCRIPTION.Size = New System.Drawing.Size(538, 19)
        Me.WTXT_ITEM_DESCRIPTION.TabIndex = 1504
        Me.WTXT_ITEM_DESCRIPTION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ITEM_DESCRIPTION.Watermark = ""
        '
        'WTXT_ITEM_CODE
        '
        Me.WTXT_ITEM_CODE.BackColor = System.Drawing.Color.White
        Me.WTXT_ITEM_CODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_CODE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_ITEM_CODE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_CODE.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_CODE.Location = New System.Drawing.Point(29, 41)
        Me.WTXT_ITEM_CODE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_CODE.MaxLength = 300
        Me.WTXT_ITEM_CODE.Name = "WTXT_ITEM_CODE"
        Me.WTXT_ITEM_CODE.ReadOnly = True
        Me.WTXT_ITEM_CODE.Size = New System.Drawing.Size(564, 21)
        Me.WTXT_ITEM_CODE.TabIndex = 1503
        Me.WTXT_ITEM_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ITEM_CODE.Watermark = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(151, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 17)
        Me.Label11.TabIndex = 1499
        Me.Label11.Text = "No. of stocks"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(27, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 17)
        Me.Label12.TabIndex = 1498
        Me.Label12.Text = "Item Description"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(27, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 17)
        Me.Label13.TabIndex = 1497
        Me.Label13.Text = "Item Code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(3, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 16)
        Me.Label14.TabIndex = 1495
        Me.Label14.Text = "Item Details"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape8, Me.RectangleShape5, Me.RectangleShape2, Me.RectangleShape1, Me.RECT_COUNT_BY, Me.RectangleShape7, Me.RectangleShape10, Me.RECT_ITEM_DESCRIPTION, Me.RectangleShape12})
        Me.ShapeContainer4.Size = New System.Drawing.Size(617, 264)
        Me.ShapeContainer4.TabIndex = 1496
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.Location = New System.Drawing.Point(490, 158)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(108, 29)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Location = New System.Drawing.Point(254, 158)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(123, 29)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(140, 158)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(111, 29)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(17, 158)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(120, 29)
        '
        'RECT_COUNT_BY
        '
        Me.RECT_COUNT_BY.BorderColor = System.Drawing.Color.Gray
        Me.RECT_COUNT_BY.CornerRadius = 5
        Me.RECT_COUNT_BY.Location = New System.Drawing.Point(17, 196)
        Me.RECT_COUNT_BY.Name = "RECT_COUNT_BY"
        Me.RECT_COUNT_BY.Size = New System.Drawing.Size(581, 28)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(18, 117)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(581, 29)
        '
        'RectangleShape10
        '
        Me.RectangleShape10.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape10.CornerRadius = 5
        Me.RectangleShape10.Location = New System.Drawing.Point(380, 158)
        Me.RectangleShape10.Name = "RectangleShape2"
        Me.RectangleShape10.Size = New System.Drawing.Size(106, 29)
        '
        'RECT_ITEM_DESCRIPTION
        '
        Me.RECT_ITEM_DESCRIPTION.BorderColor = System.Drawing.Color.Gray
        Me.RECT_ITEM_DESCRIPTION.CornerRadius = 5
        Me.RECT_ITEM_DESCRIPTION.Location = New System.Drawing.Point(19, 76)
        Me.RECT_ITEM_DESCRIPTION.Name = "RECT_ITEM_DESCRIPTION"
        Me.RECT_ITEM_DESCRIPTION.Size = New System.Drawing.Size(579, 29)
        '
        'RectangleShape12
        '
        Me.RectangleShape12.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape12.CornerRadius = 5
        Me.RectangleShape12.Location = New System.Drawing.Point(20, 36)
        Me.RectangleShape12.Name = "RECT_ITEM_DESCRIPTION"
        Me.RectangleShape12.Size = New System.Drawing.Size(577, 29)
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape13})
        Me.ShapeContainer6.Size = New System.Drawing.Size(628, 294)
        Me.ShapeContainer6.TabIndex = 2
        Me.ShapeContainer6.TabStop = False
        '
        'RectangleShape13
        '
        Me.RectangleShape13.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape13.BorderWidth = 2
        Me.RectangleShape13.CornerRadius = 1
        Me.RectangleShape13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape13.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape13.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape13.Location = New System.Drawing.Point(3, 3)
        Me.RectangleShape13.Name = "RECT_ITEM_STOCK"
        Me.RectangleShape13.Size = New System.Drawing.Size(620, 280)
        '
        'DS_PRAJO_DATABASE
        '
        Me.DS_PRAJO_DATABASE.DataSetName = "DS_PRAJO_DATABASE"
        Me.DS_PRAJO_DATABASE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPM4_PDS_LISTBindingSource
        '
        Me.SPM4_PDS_LISTBindingSource.DataMember = "SPM4_PDS_LIST"
        Me.SPM4_PDS_LISTBindingSource.DataSource = Me.DS_PRAJO_DATABASE
        '
        'SPM4_PDS_LISTTableAdapter
        '
        Me.SPM4_PDS_LISTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_PHY_C_CODETableAdapter
        '
        Me.SPM4_PHY_C_CODETableAdapter.ClearBeforeFill = True
        '
        'SPM4_PHY_C_CODEBindingSource
        '
        Me.SPM4_PHY_C_CODEBindingSource.DataMember = "SPM4_PHY_C_CODE"
        Me.SPM4_PHY_C_CODEBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_CURRENTDATETIMETableAdapter
        '
        Me.SPM4_CURRENTDATETIMETableAdapter.ClearBeforeFill = True
        '
        'VWM4_ITEM_LISTBindingSource
        '
        Me.VWM4_ITEM_LISTBindingSource.AllowNew = False
        Me.VWM4_ITEM_LISTBindingSource.DataMember = "VWM4_ITEM_LIST"
        Me.VWM4_ITEM_LISTBindingSource.DataSource = Me.DS_VIEWS
        '
        'VWM4_ITEM_LISTTableAdapter
        '
        Me.VWM4_ITEM_LISTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VWM4_PCM_LISTTableAdapter
        '
        Me.VWM4_PCM_LISTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_GET_EXIST_STOCKBindingSource
        '
        Me.SPM4_GET_EXIST_STOCKBindingSource.DataMember = "SPM4_GET_EXIST_STOCK"
        Me.SPM4_GET_EXIST_STOCKBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_GET_EXIST_STOCKTableAdapter
        '
        Me.SPM4_GET_EXIST_STOCKTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.A_CLOSEPROGRAMTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DGV_PCOUNT_DETAILS
        '
        Me.DGV_PCOUNT_DETAILS.AllowUserToAddRows = False
        Me.DGV_PCOUNT_DETAILS.AllowUserToDeleteRows = False
        Me.DGV_PCOUNT_DETAILS.AutoGenerateColumns = False
        Me.DGV_PCOUNT_DETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PCOUNT_DETAILS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PCOMIDDataGridViewTextBoxColumn1, Me.ITEMCODEDataGridViewTextBoxColumn, Me.PCOUSTKDataGridViewTextBoxColumn, Me.PCOUREMARKSDataGridViewTextBoxColumn, Me.PCOUBYDataGridViewTextBoxColumn})
        Me.DGV_PCOUNT_DETAILS.DataSource = Me.TBLM4_INV_ITEMS_PCOUNTBindingSource
        Me.DGV_PCOUNT_DETAILS.Location = New System.Drawing.Point(1098, 103)
        Me.DGV_PCOUNT_DETAILS.Name = "DGV_PCOUNT_DETAILS"
        Me.DGV_PCOUNT_DETAILS.ReadOnly = True
        Me.DGV_PCOUNT_DETAILS.RowHeadersVisible = False
        Me.DGV_PCOUNT_DETAILS.Size = New System.Drawing.Size(485, 378)
        Me.DGV_PCOUNT_DETAILS.TabIndex = 1542
        '
        'PCOMIDDataGridViewTextBoxColumn1
        '
        Me.PCOMIDDataGridViewTextBoxColumn1.DataPropertyName = "PCOM_ID"
        Me.PCOMIDDataGridViewTextBoxColumn1.HeaderText = "PCOM_ID"
        Me.PCOMIDDataGridViewTextBoxColumn1.Name = "PCOMIDDataGridViewTextBoxColumn1"
        Me.PCOMIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ITEMCODEDataGridViewTextBoxColumn
        '
        Me.ITEMCODEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.HeaderText = "ITEM_CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.Name = "ITEMCODEDataGridViewTextBoxColumn"
        Me.ITEMCODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PCOUSTKDataGridViewTextBoxColumn
        '
        Me.PCOUSTKDataGridViewTextBoxColumn.DataPropertyName = "PCOU_STK"
        Me.PCOUSTKDataGridViewTextBoxColumn.HeaderText = "PCOU_STK"
        Me.PCOUSTKDataGridViewTextBoxColumn.Name = "PCOUSTKDataGridViewTextBoxColumn"
        Me.PCOUSTKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PCOUREMARKSDataGridViewTextBoxColumn
        '
        Me.PCOUREMARKSDataGridViewTextBoxColumn.DataPropertyName = "PCOU_REMARKS"
        Me.PCOUREMARKSDataGridViewTextBoxColumn.HeaderText = "PCOU_REMARKS"
        Me.PCOUREMARKSDataGridViewTextBoxColumn.Name = "PCOUREMARKSDataGridViewTextBoxColumn"
        Me.PCOUREMARKSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PCOUBYDataGridViewTextBoxColumn
        '
        Me.PCOUBYDataGridViewTextBoxColumn.DataPropertyName = "PCOU_BY"
        Me.PCOUBYDataGridViewTextBoxColumn.HeaderText = "PCOU_BY"
        Me.PCOUBYDataGridViewTextBoxColumn.Name = "PCOUBYDataGridViewTextBoxColumn"
        Me.PCOUBYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBLM4_INV_ITEMS_PCOUNTBindingSource
        '
        Me.TBLM4_INV_ITEMS_PCOUNTBindingSource.DataMember = "TBLM4_INV_ITEMS_PCOUNT"
        Me.TBLM4_INV_ITEMS_PCOUNTBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4INVITEMSPCOUNTMAINBindingSource
        '
        Me.TBLM4INVITEMSPCOUNTMAINBindingSource.DataMember = "TBLM4_INV_ITEMS_PCOUNT_MAIN"
        Me.TBLM4INVITEMSPCOUNTMAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_PCOUNTTableAdapter
        '
        Me.TBLM4_INV_ITEMS_PCOUNTTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_PCOUNT_MAINBindingSource
        '
        Me.TBLM4_INV_ITEMS_PCOUNT_MAINBindingSource.DataMember = "TBLM4_INV_ITEMS_PCOUNT_MAIN"
        Me.TBLM4_INV_ITEMS_PCOUNT_MAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_MIGRATETableAdapter
        '
        Me.TBLM4_INV_ITEMS_MIGRATETableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_MIGRATEBindingSource
        '
        Me.TBLM4_INV_ITEMS_MIGRATEBindingSource.DataMember = "TBLM4_INV_ITEMS_MIGRATE"
        Me.TBLM4_INV_ITEMS_MIGRATEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'SPM4_ITEM_MIGRATEBindingSource
        '
        Me.SPM4_ITEM_MIGRATEBindingSource.DataMember = "SPM4_ITEM_MIGRATE"
        Me.SPM4_ITEM_MIGRATEBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_ITEM_MIGRATETableAdapter
        '
        Me.SPM4_ITEM_MIGRATETableAdapter.ClearBeforeFill = True
        '
        'TBLG3_UNITSTableAdapter
        '
        Me.TBLG3_UNITSTableAdapter.ClearBeforeFill = True
        '
        'FRM_PCOUNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1085, 660)
        Me.Controls.Add(Me.DGV_PCOUNT_DETAILS)
        Me.Controls.Add(Me.PNL_ITEM_DETAILS_ENC)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_PCOUNT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_PCOUNT"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DGV_PCOUNT_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_PCM_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PB_MIGRATE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_DATES.ResumeLayout(False)
        Me.PNL_DATES.PerformLayout()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_NEW_PHY_C, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_DGV.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PNL_PHY_DETAILS.ResumeLayout(False)
        Me.PNL_PHY_DETAILS.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PHY_CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PHY_SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ITEM_PCOUNT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBOX_SETTINGS.ResumeLayout(False)
        Me.GBOX_SETTINGS.PerformLayout()
        Me.PNL_ITEM_DETAILS_ENC.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PRAJO_DATABASE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PDS_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PHY_C_CODEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_GET_EXIST_STOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_PCOUNT_DETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_PCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVITEMSPCOUNTMAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_PCOUNT_MAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_MIGRATEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_MIGRATEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_PHY_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents DGV_PCOUNT_LIST As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RECT_PHY_SAVE As PowerPacks.RectangleShape
    Friend WithEvents LLBL_PHY_SAVE As LinkLabel
    Friend WithEvents PB_PHY_SAVE As PictureBox
    Friend WithEvents PNL_DGV As Panel
    Friend WithEvents PNL_PHY_DETAILS As Panel
    Friend WithEvents GBOX_SETTINGS As GroupBox
    Friend WithEvents LLBL_RECORDSFOUND As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DGV_ITEM_PCOUNT As DataGridView
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PHY_REASON As PowerPacks.RectangleShape
    Friend WithEvents WTXT_PHY_REASON As WatermarkTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents WTXT_PHY_DATE_ENCODED As WatermarkTextBox
    Friend WithEvents RECT_PHY_DATE_ENCODED As PowerPacks.RectangleShape
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RECT_PHY_NOTED_BY As PowerPacks.RectangleShape
    Friend WithEvents RECT_PHY_CHK_BY As PowerPacks.RectangleShape
    Friend WithEvents RECT_PHY_REMARKS As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_PHY_NOTED_BY As WatermarkTextBox
    Friend WithEvents WTXT_PHY_CHK_BY As WatermarkTextBox
    Friend WithEvents WTXT_PHY_REMARKS As WatermarkTextBox
    Friend WithEvents BTN_ADD_ITEM As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PNL_ITEM_DETAILS_ENC As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BTN_ITEM_DETAILS_ENC_CANCEL As Button
    Friend WithEvents BTN_ITEM_DETAILS_ENC_SAVE As Button
    Friend WithEvents WTXT_QTY As WatermarkTextBox
    Friend WithEvents WTXT_ITEM_DESCRIPTION As WatermarkTextBox
    Friend WithEvents WTXT_ITEM_CODE As WatermarkTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape10 As PowerPacks.RectangleShape
    Friend WithEvents RECT_ITEM_DESCRIPTION As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape12 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer6 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape13 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_ITEM_COUNT_BY As WatermarkTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents WTXT_ITEM_REMARKS As WatermarkTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RECT_COUNT_BY As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents VWM4_ITEM_LISTBindingSource As BindingSource
    Friend WithEvents VWM4_ITEM_LISTTableAdapter As DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter
    Friend WithEvents TableAdapterManager As DS_VIEWSTableAdapters.TableAdapterManager
    Friend WithEvents DS_PRAJO_DATABASE As DS_PRAJO_DATABASE
    Friend WithEvents SPM4_PDS_LISTBindingSource As BindingSource
    Friend WithEvents SPM4_PDS_LISTTableAdapter As DS_PRAJO_DATABASETableAdapters.SPM4_PDS_LISTTableAdapter
    Friend WithEvents ShapeContainer5 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_NEW_PHY_C As PowerPacks.RectangleShape
    Friend WithEvents LLBL_NEW_PHY_C As LinkLabel
    Friend WithEvents PB_NEW_PHY_C As PictureBox
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TBLM4_INV_ITEMS_PCOUNTTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_PCOUNTTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_PCOUNTBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_PCOUNT_MAINBindingSource As BindingSource
    Friend WithEvents LLBL_PHY_CANCEL As LinkLabel
    Friend WithEvents PB_PHY_CANCEL As PictureBox
    Friend WithEvents RECT_PHY_CANCEL As PowerPacks.RectangleShape
    Friend WithEvents SPM4_PHY_C_CODETableAdapter As DS_STOREDPROCTableAdapters.SPM4_PHY_C_CODETableAdapter
    Friend WithEvents SPM4_PHY_C_CODEBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents BTN_DATE_TO As Button
    Friend WithEvents BTN_DATE_FROM As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents WTXT_DATE_TO As WatermarkTextBox
    Friend WithEvents WTXT_DATE_FROM As WatermarkTextBox
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents TBLM4INVITEMSPCOUNTMAINBindingSource As BindingSource
    Friend WithEvents SPM4CURRENTDATETIMEBindingSource As BindingSource
    Friend WithEvents SPM4_CURRENTDATETIMETableAdapter As DS_STOREDPROCTableAdapters.SPM4_CURRENTDATETIMETableAdapter
    Friend WithEvents VWM4_PCM_LISTTableAdapter As DS_VIEWSTableAdapters.VWM4_PCM_LISTTableAdapter
    Friend WithEvents VWM4_PCM_LISTBindingSource As BindingSource
    Friend WithEvents PNL_DATES As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents WTXT_EXISTING_STOCK As WatermarkTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents SPM4_GET_EXIST_STOCKBindingSource As BindingSource
    Friend WithEvents SPM4_GET_EXIST_STOCKTableAdapter As DS_STOREDPROCTableAdapters.SPM4_GET_EXIST_STOCKTableAdapter
    Friend WithEvents TableAdapterManager1 As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents TBLM4_INV_ITEMS_MIGRATETableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_MIGRATETableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_MIGRATEBindingSource As BindingSource
    Friend WithEvents DGV_PCOUNT_DETAILS As DataGridView
    Friend WithEvents PCOMIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCOUSTKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCOUREMARKSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCOUBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPM4_ITEM_MIGRATEBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_MIGRATETableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_MIGRATETableAdapter
    Friend WithEvents DATEENCODEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCOMREASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCOMIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCOMCHKBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCOMNOTEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCOMREMARKSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCOMDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Print As DataGridViewImageColumn
    Friend WithEvents Migrate As DataGridViewImageColumn
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents WTXT_TOTAL_COST As WatermarkTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents WTXT_UNIT_COST As WatermarkTextBox
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents CB_UNIT_TYPE As ComboBox
    Friend WithEvents TBLG3UNITSBindingSource As BindingSource
    Friend WithEvents TBLG3_UNITSTableAdapter As DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter
    Friend WithEvents ITEM_CODE As DataGridViewTextBoxColumn
    Friend WithEvents ITM_DESC As DataGridViewTextBoxColumn
    Friend WithEvents PCOU_STK As DataGridViewTextBoxColumn
    Friend WithEvents unitcost As DataGridViewTextBoxColumn
    Friend WithEvents totalcost As DataGridViewTextBoxColumn
    Friend WithEvents unittype As DataGridViewTextBoxColumn
    Friend WithEvents PCOU_REMARKS As DataGridViewTextBoxColumn
    Friend WithEvents PCOU_BY As DataGridViewTextBoxColumn
    Friend WithEvents ACTIONEDIT As DataGridViewButtonColumn
    Friend WithEvents ACTIONREMOVE As DataGridViewButtonColumn
    Friend WithEvents LLBL_MIGRATE As LinkLabel
    Friend WithEvents PB_MIGRATE As PictureBox
    Friend WithEvents RECT_MIGRATE As PowerPacks.RectangleShape
End Class
