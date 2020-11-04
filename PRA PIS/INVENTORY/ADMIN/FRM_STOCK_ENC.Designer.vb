<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_STOCK_ENC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_STOCK_ENC))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_ITEM_STOCK_ENC_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PNL_SEARCH_DGV = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CB_FILTER_BY = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LBL_TOTALNOOFREC = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LLBL_NOSTOCK = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LLBL_OVER_STOCK = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LLBL_CRITICAL = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LLBL_NORMAL = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PB_ITEM_STOCK_SEARCH = New System.Windows.Forms.PictureBox()
        Me.PB_ITEM_STOCK_CLEAR_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_ITEM_STOCK_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.DGV_STOCK_LIST = New System.Windows.Forms.DataGridView()
        Me.SPM4ITEMSTOCKMASTERLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_ITEM_STOCK = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.VWM4STOCKLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.PNL_BUTTONS = New System.Windows.Forms.Panel()
        Me.LLBL_STKCTRL_SETUP = New System.Windows.Forms.LinkLabel()
        Me.PB_STK_CTRL_SETUP = New System.Windows.Forms.PictureBox()
        Me.LLBL_STOCK_VIEW_REPORT = New System.Windows.Forms.LinkLabel()
        Me.LLBL_NEW_ITEM_STOCK = New System.Windows.Forms.LinkLabel()
        Me.PB_STOCK_VIEW_REPORT = New System.Windows.Forms.PictureBox()
        Me.PB_NEW_ITEM_STOCK = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_STK_CTRL_SETUP = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_STOCK_VIEW_REPORT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_NEW_ITEM_STOCK = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.APNL_NEW_ITEM = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LLBL_SAVE_NEW_ITEM = New System.Windows.Forms.LinkLabel()
        Me.PB_SAVE_NEW_ITEM = New System.Windows.Forms.PictureBox()
        Me.LLBL_ADD_ITEM = New System.Windows.Forms.LinkLabel()
        Me.PB_ADD_ITEM = New System.Windows.Forms.PictureBox()
        Me.DGV_ITEM_STOCK_DETAILS = New System.Windows.Forms.DataGridView()
        Me.ITM_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTION_EDIT = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ACTION_DELETE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_SAVE_NEW_ITEM = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ADD_ITEM = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_DR_DETAILS = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGV_DR_PARTICULARS = New System.Windows.Forms.DataGridView()
        Me.DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Units = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WARRANTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WTXT_DATE_DELIVERED = New PRA_PIS.WatermarkTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WTXT_COMPANY_NAME = New PRA_PIS.WatermarkTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WTXT_TIN_NO = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_DR_NO = New PRA_PIS.WatermarkTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_DATE_DELIVERED = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_COMP_NAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_TIN_NO = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_DR_NO = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_CLOSE_STOCK = New System.Windows.Forms.Button()
        Me.PNL_ITEM_DETAILS_ENC = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CB_UNIT_TYPE = New System.Windows.Forms.ComboBox()
        Me.TBLG3UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.BTN_ITEM_DETAILS_ENC_CANCEL = New System.Windows.Forms.Button()
        Me.BTN_ITEM_DETAILS_ENC_SAVE = New System.Windows.Forms.Button()
        Me.WTXT_TOTAL_PRICE = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_UNIT_PRICE = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_QTY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ITEM_DESCRIPTION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ITEM_CODE = New PRA_PIS.WatermarkTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TableAdapterManager = New PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager()
        Me.TBLG3_UNITSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter()
        Me.TBLM4_INV_DR_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_DR_ITEMSTableAdapter()
        Me.TBLM4_INV_DR_ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VWM4_ITEM_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VWM4_ITEM_LISTTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter()
        Me.SPM4_ITEM_STOCKMASTERLISTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKMASTERLISTTableAdapter()
        Me.SPM4_ITEM_STOCKS_LEGENDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_STOCKS_LEGENDTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKS_LEGENDTableAdapter()
        Me.TableAdapterManager1 = New PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager()
        Me.SPM4_PHY_C_CODETableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_PHY_C_CODETableAdapter()
        Me.SPM4_PHY_C_CODEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ITEM_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMUNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_MIN_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_MAX_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNL.SuspendLayout()
        Me.PNL_SEARCH_DGV.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ITEM_STOCK_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_STOCK_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4ITEMSTOCKMASTERLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4STOCKLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_BUTTONS.SuspendLayout()
        CType(Me.PB_STK_CTRL_SETUP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_STOCK_VIEW_REPORT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_NEW_ITEM_STOCK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APNL_NEW_ITEM.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PB_SAVE_NEW_ITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ADD_ITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ITEM_STOCK_DETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_DR_DETAILS.SuspendLayout()
        CType(Me.DGV_DR_PARTICULARS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_ITEM_DETAILS_ENC.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_DR_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_STOCKS_LEGENDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PHY_C_CODEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_ITEM_STOCK_ENC_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(6)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1050, 60)
        Me.PNL.TabIndex = 1407
        '
        'BTN_ITEM_STOCK_ENC_CLOSE
        '
        Me.BTN_ITEM_STOCK_ENC_CLOSE.BackgroundImage = CType(resources.GetObject("BTN_ITEM_STOCK_ENC_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_ITEM_STOCK_ENC_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ITEM_STOCK_ENC_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_ITEM_STOCK_ENC_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_ITEM_STOCK_ENC_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ITEM_STOCK_ENC_CLOSE.Location = New System.Drawing.Point(997, 13)
        Me.BTN_ITEM_STOCK_ENC_CLOSE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_ITEM_STOCK_ENC_CLOSE.Name = "BTN_ITEM_STOCK_ENC_CLOSE"
        Me.BTN_ITEM_STOCK_ENC_CLOSE.Size = New System.Drawing.Size(35, 37)
        Me.BTN_ITEM_STOCK_ENC_CLOSE.TabIndex = 16
        Me.BTN_ITEM_STOCK_ENC_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ITEM_STOCK_ENC_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(13, 17)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(262, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "S T O C K S  M A S T E R L I S T"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-7600, 14)
        Me.BTN_Minimize.Margin = New System.Windows.Forms.Padding(6)
        Me.BTN_Minimize.Name = "BTN_Minimize"
        Me.BTN_Minimize.Size = New System.Drawing.Size(55, 55)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-7545, 12)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(6)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(58, 59)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'PNL_SEARCH_DGV
        '
        Me.PNL_SEARCH_DGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_SEARCH_DGV.Controls.Add(Me.LinkLabel1)
        Me.PNL_SEARCH_DGV.Controls.Add(Me.CB_FILTER_BY)
        Me.PNL_SEARCH_DGV.Controls.Add(Me.Panel1)
        Me.PNL_SEARCH_DGV.Controls.Add(Me.PB_ITEM_STOCK_SEARCH)
        Me.PNL_SEARCH_DGV.Controls.Add(Me.PB_ITEM_STOCK_CLEAR_SEARCH)
        Me.PNL_SEARCH_DGV.Controls.Add(Me.WTXT_ITEM_STOCK_SEARCH)
        Me.PNL_SEARCH_DGV.Controls.Add(Me.DGV_STOCK_LIST)
        Me.PNL_SEARCH_DGV.Controls.Add(Me.ShapeContainer1)
        Me.PNL_SEARCH_DGV.Location = New System.Drawing.Point(7, 128)
        Me.PNL_SEARCH_DGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PNL_SEARCH_DGV.Name = "PNL_SEARCH_DGV"
        Me.PNL_SEARCH_DGV.Size = New System.Drawing.Size(1038, 677)
        Me.PNL_SEARCH_DGV.TabIndex = 1408
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.Location = New System.Drawing.Point(716, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 19)
        Me.LinkLabel1.TabIndex = 1461
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "FILTER BY:"
        '
        'CB_FILTER_BY
        '
        Me.CB_FILTER_BY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FILTER_BY.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FILTER_BY.FormattingEnabled = True
        Me.CB_FILTER_BY.Items.AddRange(New Object() {"Show All", "Stocks Only", "No Stocks", "Critical"})
        Me.CB_FILTER_BY.Location = New System.Drawing.Point(803, 8)
        Me.CB_FILTER_BY.Name = "CB_FILTER_BY"
        Me.CB_FILTER_BY.Size = New System.Drawing.Size(224, 31)
        Me.CB_FILTER_BY.TabIndex = 1445
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 593)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 79)
        Me.Panel1.TabIndex = 1444
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.GroupBox4)
        Me.Panel9.Location = New System.Drawing.Point(528, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(499, 71)
        Me.Panel9.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.LBL_TOTALNOOFREC)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, -9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(266, 45)
        Me.GroupBox4.TabIndex = 1467
        Me.GroupBox4.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(145, 19)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Total No. of items :"
        '
        'LBL_TOTALNOOFREC
        '
        Me.LBL_TOTALNOOFREC.AutoSize = True
        Me.LBL_TOTALNOOFREC.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TOTALNOOFREC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_TOTALNOOFREC.Location = New System.Drawing.Point(160, 14)
        Me.LBL_TOTALNOOFREC.Name = "LBL_TOTALNOOFREC"
        Me.LBL_TOTALNOOFREC.Size = New System.Drawing.Size(21, 23)
        Me.LBL_TOTALNOOFREC.TabIndex = 5
        Me.LBL_TOTALNOOFREC.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.LLBL_NOSTOCK)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.LLBL_OVER_STOCK)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.LLBL_CRITICAL)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.LLBL_NORMAL)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 71)
        Me.Panel2.TabIndex = 0
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(420, 25)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 16)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "Selected Item"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Location = New System.Drawing.Point(397, 25)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(20, 33)
        Me.Panel8.TabIndex = 18
        '
        'LLBL_NOSTOCK
        '
        Me.LLBL_NOSTOCK.AutoSize = True
        Me.LLBL_NOSTOCK.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_NOSTOCK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LLBL_NOSTOCK.Location = New System.Drawing.Point(326, 41)
        Me.LLBL_NOSTOCK.Name = "LLBL_NOSTOCK"
        Me.LLBL_NOSTOCK.Size = New System.Drawing.Size(15, 16)
        Me.LLBL_NOSTOCK.TabIndex = 17
        Me.LLBL_NOSTOCK.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(326, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 16)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "No Stock"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Blue
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(300, 25)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(20, 33)
        Me.Panel6.TabIndex = 15
        '
        'LLBL_OVER_STOCK
        '
        Me.LLBL_OVER_STOCK.AutoSize = True
        Me.LLBL_OVER_STOCK.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_OVER_STOCK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LLBL_OVER_STOCK.Location = New System.Drawing.Point(221, 41)
        Me.LLBL_OVER_STOCK.Name = "LLBL_OVER_STOCK"
        Me.LLBL_OVER_STOCK.Size = New System.Drawing.Size(15, 16)
        Me.LLBL_OVER_STOCK.TabIndex = 14
        Me.LLBL_OVER_STOCK.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(221, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 16)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Over Stock"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Green
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(195, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(20, 33)
        Me.Panel5.TabIndex = 12
        '
        'LLBL_CRITICAL
        '
        Me.LLBL_CRITICAL.AutoSize = True
        Me.LLBL_CRITICAL.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_CRITICAL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LLBL_CRITICAL.Location = New System.Drawing.Point(130, 41)
        Me.LLBL_CRITICAL.Name = "LLBL_CRITICAL"
        Me.LLBL_CRITICAL.Size = New System.Drawing.Size(15, 16)
        Me.LLBL_CRITICAL.TabIndex = 11
        Me.LLBL_CRITICAL.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(130, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 16)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Critical"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(104, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(20, 33)
        Me.Panel4.TabIndex = 9
        '
        'LLBL_NORMAL
        '
        Me.LLBL_NORMAL.AutoSize = True
        Me.LLBL_NORMAL.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_NORMAL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LLBL_NORMAL.Location = New System.Drawing.Point(34, 41)
        Me.LLBL_NORMAL.Name = "LLBL_NORMAL"
        Me.LLBL_NORMAL.Size = New System.Drawing.Size(15, 16)
        Me.LLBL_NORMAL.TabIndex = 8
        Me.LLBL_NORMAL.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(4, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 16)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Stocks Legend:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(34, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 16)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Normal"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Location = New System.Drawing.Point(8, 25)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(20, 33)
        Me.Panel7.TabIndex = 5
        '
        'PB_ITEM_STOCK_SEARCH
        '
        Me.PB_ITEM_STOCK_SEARCH.BackgroundImage = CType(resources.GetObject("PB_ITEM_STOCK_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_ITEM_STOCK_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_ITEM_STOCK_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ITEM_STOCK_SEARCH.InitialImage = Nothing
        Me.PB_ITEM_STOCK_SEARCH.Location = New System.Drawing.Point(14, 7)
        Me.PB_ITEM_STOCK_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_ITEM_STOCK_SEARCH.Name = "PB_ITEM_STOCK_SEARCH"
        Me.PB_ITEM_STOCK_SEARCH.Size = New System.Drawing.Size(37, 34)
        Me.PB_ITEM_STOCK_SEARCH.TabIndex = 1441
        Me.PB_ITEM_STOCK_SEARCH.TabStop = False
        '
        'PB_ITEM_STOCK_CLEAR_SEARCH
        '
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.BackgroundImage = CType(resources.GetObject("PB_ITEM_STOCK_CLEAR_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.InitialImage = Nothing
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Location = New System.Drawing.Point(663, 7)
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Name = "PB_ITEM_STOCK_CLEAR_SEARCH"
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Size = New System.Drawing.Size(37, 34)
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.TabIndex = 1443
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.TabStop = False
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Visible = False
        '
        'WTXT_ITEM_STOCK_SEARCH
        '
        Me.WTXT_ITEM_STOCK_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_STOCK_SEARCH.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_STOCK_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_STOCK_SEARCH.Location = New System.Drawing.Point(55, 13)
        Me.WTXT_ITEM_STOCK_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_STOCK_SEARCH.MaxLength = 300
        Me.WTXT_ITEM_STOCK_SEARCH.Name = "WTXT_ITEM_STOCK_SEARCH"
        Me.WTXT_ITEM_STOCK_SEARCH.Size = New System.Drawing.Size(607, 21)
        Me.WTXT_ITEM_STOCK_SEARCH.TabIndex = 1442
        Me.WTXT_ITEM_STOCK_SEARCH.Watermark = "Search Item description"
        '
        'DGV_STOCK_LIST
        '
        Me.DGV_STOCK_LIST.AllowUserToAddRows = False
        Me.DGV_STOCK_LIST.AllowUserToDeleteRows = False
        Me.DGV_STOCK_LIST.AllowUserToResizeRows = False
        Me.DGV_STOCK_LIST.AutoGenerateColumns = False
        Me.DGV_STOCK_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_STOCK_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_STOCK_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEM_STATUS, Me.ITEMCODEDataGridViewTextBoxColumn, Me.ITEMDESCDataGridViewTextBoxColumn, Me.TOTALSTOCKDataGridViewTextBoxColumn, Me.ITEMUNITDataGridViewTextBoxColumn, Me.APPQTYDataGridViewTextBoxColumn, Me.REMSTOCKDataGridViewTextBoxColumn, Me.ITEM_MIN_QTY, Me.ITEM_MAX_QTY})
        Me.DGV_STOCK_LIST.DataSource = Me.SPM4ITEMSTOCKMASTERLISTBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_STOCK_LIST.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_STOCK_LIST.Location = New System.Drawing.Point(2, 49)
        Me.DGV_STOCK_LIST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_STOCK_LIST.MultiSelect = False
        Me.DGV_STOCK_LIST.Name = "DGV_STOCK_LIST"
        Me.DGV_STOCK_LIST.ReadOnly = True
        Me.DGV_STOCK_LIST.RowHeadersVisible = False
        Me.DGV_STOCK_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_STOCK_LIST.Size = New System.Drawing.Size(1032, 542)
        Me.DGV_STOCK_LIST.TabIndex = 0
        '
        'SPM4ITEMSTOCKMASTERLISTBindingSource
        '
        Me.SPM4ITEMSTOCKMASTERLISTBindingSource.DataMember = "SPM4_ITEM_STOCKMASTERLIST"
        Me.SPM4ITEMSTOCKMASTERLISTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_ITEM_STOCK})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1036, 675)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RECT_ITEM_STOCK
        '
        Me.RECT_ITEM_STOCK.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ITEM_STOCK.BorderWidth = 2
        Me.RECT_ITEM_STOCK.CornerRadius = 19
        Me.RECT_ITEM_STOCK.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_ITEM_STOCK.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_ITEM_STOCK.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_ITEM_STOCK.Location = New System.Drawing.Point(3, 4)
        Me.RECT_ITEM_STOCK.Name = "RECT_ITEM_STOCK"
        Me.RECT_ITEM_STOCK.Size = New System.Drawing.Size(708, 39)
        '
        'VWM4STOCKLISTBindingSource
        '
        Me.VWM4STOCKLISTBindingSource.DataMember = "VWM4_STOCK_LIST"
        Me.VWM4STOCKLISTBindingSource.DataSource = Me.DS_VIEWS
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PNL_BUTTONS
        '
        Me.PNL_BUTTONS.Controls.Add(Me.LLBL_STKCTRL_SETUP)
        Me.PNL_BUTTONS.Controls.Add(Me.PB_STK_CTRL_SETUP)
        Me.PNL_BUTTONS.Controls.Add(Me.LLBL_STOCK_VIEW_REPORT)
        Me.PNL_BUTTONS.Controls.Add(Me.LLBL_NEW_ITEM_STOCK)
        Me.PNL_BUTTONS.Controls.Add(Me.PB_STOCK_VIEW_REPORT)
        Me.PNL_BUTTONS.Controls.Add(Me.PB_NEW_ITEM_STOCK)
        Me.PNL_BUTTONS.Controls.Add(Me.ShapeContainer5)
        Me.PNL_BUTTONS.Location = New System.Drawing.Point(7, 67)
        Me.PNL_BUTTONS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PNL_BUTTONS.Name = "PNL_BUTTONS"
        Me.PNL_BUTTONS.Size = New System.Drawing.Size(1038, 56)
        Me.PNL_BUTTONS.TabIndex = 1529
        '
        'LLBL_STKCTRL_SETUP
        '
        Me.LLBL_STKCTRL_SETUP.AutoSize = True
        Me.LLBL_STKCTRL_SETUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_STKCTRL_SETUP.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_STKCTRL_SETUP.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_STKCTRL_SETUP.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_STKCTRL_SETUP.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_STKCTRL_SETUP.Location = New System.Drawing.Point(829, 21)
        Me.LLBL_STKCTRL_SETUP.Name = "LLBL_STKCTRL_SETUP"
        Me.LLBL_STKCTRL_SETUP.Size = New System.Drawing.Size(196, 19)
        Me.LLBL_STKCTRL_SETUP.TabIndex = 1532
        Me.LLBL_STKCTRL_SETUP.TabStop = True
        Me.LLBL_STKCTRL_SETUP.Text = "STOCK CONTROL SETUP"
        '
        'PB_STK_CTRL_SETUP
        '
        Me.PB_STK_CTRL_SETUP.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_settings_black_18dp
        Me.PB_STK_CTRL_SETUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_STK_CTRL_SETUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_STK_CTRL_SETUP.InitialImage = Nothing
        Me.PB_STK_CTRL_SETUP.Location = New System.Drawing.Point(797, 16)
        Me.PB_STK_CTRL_SETUP.Name = "PB_STK_CTRL_SETUP"
        Me.PB_STK_CTRL_SETUP.Size = New System.Drawing.Size(32, 28)
        Me.PB_STK_CTRL_SETUP.TabIndex = 1532
        Me.PB_STK_CTRL_SETUP.TabStop = False
        '
        'LLBL_STOCK_VIEW_REPORT
        '
        Me.LLBL_STOCK_VIEW_REPORT.AutoSize = True
        Me.LLBL_STOCK_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_STOCK_VIEW_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_STOCK_VIEW_REPORT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_STOCK_VIEW_REPORT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_STOCK_VIEW_REPORT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_STOCK_VIEW_REPORT.Location = New System.Drawing.Point(614, 20)
        Me.LLBL_STOCK_VIEW_REPORT.Name = "LLBL_STOCK_VIEW_REPORT"
        Me.LLBL_STOCK_VIEW_REPORT.Size = New System.Drawing.Size(158, 19)
        Me.LLBL_STOCK_VIEW_REPORT.TabIndex = 1459
        Me.LLBL_STOCK_VIEW_REPORT.TabStop = True
        Me.LLBL_STOCK_VIEW_REPORT.Text = "GENERATE REPORT"
        '
        'LLBL_NEW_ITEM_STOCK
        '
        Me.LLBL_NEW_ITEM_STOCK.AutoSize = True
        Me.LLBL_NEW_ITEM_STOCK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_NEW_ITEM_STOCK.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_NEW_ITEM_STOCK.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_NEW_ITEM_STOCK.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_NEW_ITEM_STOCK.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_NEW_ITEM_STOCK.Location = New System.Drawing.Point(51, 18)
        Me.LLBL_NEW_ITEM_STOCK.Name = "LLBL_NEW_ITEM_STOCK"
        Me.LLBL_NEW_ITEM_STOCK.Size = New System.Drawing.Size(87, 19)
        Me.LLBL_NEW_ITEM_STOCK.TabIndex = 1455
        Me.LLBL_NEW_ITEM_STOCK.TabStop = True
        Me.LLBL_NEW_ITEM_STOCK.Text = "NEW ITEM"
        '
        'PB_STOCK_VIEW_REPORT
        '
        Me.PB_STOCK_VIEW_REPORT.BackgroundImage = CType(resources.GetObject("PB_STOCK_VIEW_REPORT.BackgroundImage"), System.Drawing.Image)
        Me.PB_STOCK_VIEW_REPORT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_STOCK_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_STOCK_VIEW_REPORT.InitialImage = Nothing
        Me.PB_STOCK_VIEW_REPORT.Location = New System.Drawing.Point(574, 13)
        Me.PB_STOCK_VIEW_REPORT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_STOCK_VIEW_REPORT.Name = "PB_STOCK_VIEW_REPORT"
        Me.PB_STOCK_VIEW_REPORT.Size = New System.Drawing.Size(37, 34)
        Me.PB_STOCK_VIEW_REPORT.TabIndex = 1460
        Me.PB_STOCK_VIEW_REPORT.TabStop = False
        '
        'PB_NEW_ITEM_STOCK
        '
        Me.PB_NEW_ITEM_STOCK.BackgroundImage = CType(resources.GetObject("PB_NEW_ITEM_STOCK.BackgroundImage"), System.Drawing.Image)
        Me.PB_NEW_ITEM_STOCK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_NEW_ITEM_STOCK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_NEW_ITEM_STOCK.InitialImage = Nothing
        Me.PB_NEW_ITEM_STOCK.Location = New System.Drawing.Point(14, 11)
        Me.PB_NEW_ITEM_STOCK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_NEW_ITEM_STOCK.Name = "PB_NEW_ITEM_STOCK"
        Me.PB_NEW_ITEM_STOCK.Size = New System.Drawing.Size(37, 34)
        Me.PB_NEW_ITEM_STOCK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_NEW_ITEM_STOCK.TabIndex = 1456
        Me.PB_NEW_ITEM_STOCK.TabStop = False
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_STK_CTRL_SETUP, Me.RECT_STOCK_VIEW_REPORT, Me.RECT_NEW_ITEM_STOCK})
        Me.ShapeContainer5.Size = New System.Drawing.Size(1038, 56)
        Me.ShapeContainer5.TabIndex = 0
        Me.ShapeContainer5.TabStop = False
        '
        'RECT_STK_CTRL_SETUP
        '
        Me.RECT_STK_CTRL_SETUP.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_STK_CTRL_SETUP.BorderWidth = 2
        Me.RECT_STK_CTRL_SETUP.CornerRadius = 19
        Me.RECT_STK_CTRL_SETUP.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_STK_CTRL_SETUP.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_STK_CTRL_SETUP.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_STK_CTRL_SETUP.Location = New System.Drawing.Point(786, 9)
        Me.RECT_STK_CTRL_SETUP.Name = "RECT_STK_CTRL_SETUP"
        Me.RECT_STK_CTRL_SETUP.Size = New System.Drawing.Size(246, 40)
        '
        'RECT_STOCK_VIEW_REPORT
        '
        Me.RECT_STOCK_VIEW_REPORT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_STOCK_VIEW_REPORT.BorderWidth = 2
        Me.RECT_STOCK_VIEW_REPORT.CornerRadius = 19
        Me.RECT_STOCK_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_STOCK_VIEW_REPORT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_STOCK_VIEW_REPORT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_STOCK_VIEW_REPORT.Location = New System.Drawing.Point(563, 9)
        Me.RECT_STOCK_VIEW_REPORT.Name = "RECT_STOCK_VIEW_REPORT"
        Me.RECT_STOCK_VIEW_REPORT.Size = New System.Drawing.Size(219, 40)
        '
        'RECT_NEW_ITEM_STOCK
        '
        Me.RECT_NEW_ITEM_STOCK.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_NEW_ITEM_STOCK.BorderWidth = 2
        Me.RECT_NEW_ITEM_STOCK.CornerRadius = 19
        Me.RECT_NEW_ITEM_STOCK.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_NEW_ITEM_STOCK.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_NEW_ITEM_STOCK.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_NEW_ITEM_STOCK.Location = New System.Drawing.Point(3, 7)
        Me.RECT_NEW_ITEM_STOCK.Name = "RECT_NEW_ITEM_STOCK"
        Me.RECT_NEW_ITEM_STOCK.Size = New System.Drawing.Size(140, 40)
        '
        'APNL_NEW_ITEM
        '
        Me.APNL_NEW_ITEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APNL_NEW_ITEM.Controls.Add(Me.GroupBox1)
        Me.APNL_NEW_ITEM.Controls.Add(Me.GRP_DR_DETAILS)
        Me.APNL_NEW_ITEM.Controls.Add(Me.BTN_CLOSE_STOCK)
        Me.APNL_NEW_ITEM.Location = New System.Drawing.Point(1050, 66)
        Me.APNL_NEW_ITEM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.APNL_NEW_ITEM.Name = "APNL_NEW_ITEM"
        Me.APNL_NEW_ITEM.Size = New System.Drawing.Size(1040, 739)
        Me.APNL_NEW_ITEM.TabIndex = 1530
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LLBL_SAVE_NEW_ITEM)
        Me.GroupBox1.Controls.Add(Me.PB_SAVE_NEW_ITEM)
        Me.GroupBox1.Controls.Add(Me.LLBL_ADD_ITEM)
        Me.GroupBox1.Controls.Add(Me.PB_ADD_ITEM)
        Me.GroupBox1.Controls.Add(Me.DGV_ITEM_STOCK_DETAILS)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(55, 266)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(979, 467)
        Me.GroupBox1.TabIndex = 1498
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEM STOCK DETAILS"
        '
        'LLBL_SAVE_NEW_ITEM
        '
        Me.LLBL_SAVE_NEW_ITEM.AutoSize = True
        Me.LLBL_SAVE_NEW_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_SAVE_NEW_ITEM.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_SAVE_NEW_ITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE_NEW_ITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_SAVE_NEW_ITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE_NEW_ITEM.Location = New System.Drawing.Point(911, 432)
        Me.LLBL_SAVE_NEW_ITEM.Name = "LLBL_SAVE_NEW_ITEM"
        Me.LLBL_SAVE_NEW_ITEM.Size = New System.Drawing.Size(52, 19)
        Me.LLBL_SAVE_NEW_ITEM.TabIndex = 1534
        Me.LLBL_SAVE_NEW_ITEM.TabStop = True
        Me.LLBL_SAVE_NEW_ITEM.Text = "SAVE"
        '
        'PB_SAVE_NEW_ITEM
        '
        Me.PB_SAVE_NEW_ITEM.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.baseline_save_black_18dp
        Me.PB_SAVE_NEW_ITEM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_SAVE_NEW_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_SAVE_NEW_ITEM.InitialImage = Nothing
        Me.PB_SAVE_NEW_ITEM.Location = New System.Drawing.Point(881, 427)
        Me.PB_SAVE_NEW_ITEM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_SAVE_NEW_ITEM.Name = "PB_SAVE_NEW_ITEM"
        Me.PB_SAVE_NEW_ITEM.Size = New System.Drawing.Size(30, 30)
        Me.PB_SAVE_NEW_ITEM.TabIndex = 1533
        Me.PB_SAVE_NEW_ITEM.TabStop = False
        '
        'LLBL_ADD_ITEM
        '
        Me.LLBL_ADD_ITEM.AutoSize = True
        Me.LLBL_ADD_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_ADD_ITEM.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_ADD_ITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_ADD_ITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_ADD_ITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_ADD_ITEM.Location = New System.Drawing.Point(871, 27)
        Me.LLBL_ADD_ITEM.Name = "LLBL_ADD_ITEM"
        Me.LLBL_ADD_ITEM.Size = New System.Drawing.Size(87, 19)
        Me.LLBL_ADD_ITEM.TabIndex = 1531
        Me.LLBL_ADD_ITEM.TabStop = True
        Me.LLBL_ADD_ITEM.Text = "ADD ITEM"
        '
        'PB_ADD_ITEM
        '
        Me.PB_ADD_ITEM.BackgroundImage = CType(resources.GetObject("PB_ADD_ITEM.BackgroundImage"), System.Drawing.Image)
        Me.PB_ADD_ITEM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_ADD_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ADD_ITEM.InitialImage = Nothing
        Me.PB_ADD_ITEM.Location = New System.Drawing.Point(841, 21)
        Me.PB_ADD_ITEM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_ADD_ITEM.Name = "PB_ADD_ITEM"
        Me.PB_ADD_ITEM.Size = New System.Drawing.Size(30, 30)
        Me.PB_ADD_ITEM.TabIndex = 1532
        Me.PB_ADD_ITEM.TabStop = False
        '
        'DGV_ITEM_STOCK_DETAILS
        '
        Me.DGV_ITEM_STOCK_DETAILS.AllowUserToAddRows = False
        Me.DGV_ITEM_STOCK_DETAILS.AllowUserToDeleteRows = False
        Me.DGV_ITEM_STOCK_DETAILS.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_ITEM_STOCK_DETAILS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_ITEM_STOCK_DETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEM_STOCK_DETAILS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITM_CODE, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.TOTAL_PRICE, Me.ACTION_EDIT, Me.ACTION_DELETE})
        Me.DGV_ITEM_STOCK_DETAILS.Location = New System.Drawing.Point(9, 67)
        Me.DGV_ITEM_STOCK_DETAILS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_ITEM_STOCK_DETAILS.MultiSelect = False
        Me.DGV_ITEM_STOCK_DETAILS.Name = "DGV_ITEM_STOCK_DETAILS"
        Me.DGV_ITEM_STOCK_DETAILS.ReadOnly = True
        Me.DGV_ITEM_STOCK_DETAILS.RowHeadersVisible = False
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.DGV_ITEM_STOCK_DETAILS.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_ITEM_STOCK_DETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEM_STOCK_DETAILS.Size = New System.Drawing.Size(962, 348)
        Me.DGV_ITEM_STOCK_DETAILS.TabIndex = 1
        '
        'ITM_CODE
        '
        Me.ITM_CODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITM_CODE.HeaderText = "Item Code"
        Me.ITM_CODE.Name = "ITM_CODE"
        Me.ITM_CODE.ReadOnly = True
        Me.ITM_CODE.Width = 120
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item Description"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'TOTAL_PRICE
        '
        Me.TOTAL_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TOTAL_PRICE.HeaderText = "Total Price"
        Me.TOTAL_PRICE.Name = "TOTAL_PRICE"
        Me.TOTAL_PRICE.ReadOnly = True
        '
        'ACTION_EDIT
        '
        Me.ACTION_EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ACTION_EDIT.HeaderText = "Action"
        Me.ACTION_EDIT.Name = "ACTION_EDIT"
        Me.ACTION_EDIT.ReadOnly = True
        Me.ACTION_EDIT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ACTION_EDIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ACTION_EDIT.Text = "Edit"
        Me.ACTION_EDIT.UseColumnTextForButtonValue = True
        Me.ACTION_EDIT.Width = 80
        '
        'ACTION_DELETE
        '
        Me.ACTION_DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ACTION_DELETE.HeaderText = "Action"
        Me.ACTION_DELETE.Name = "ACTION_DELETE"
        Me.ACTION_DELETE.ReadOnly = True
        Me.ACTION_DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ACTION_DELETE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ACTION_DELETE.Text = "Remove"
        Me.ACTION_DELETE.UseColumnTextForButtonValue = True
        Me.ACTION_DELETE.Width = 80
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 18)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_SAVE_NEW_ITEM, Me.RECT_ADD_ITEM})
        Me.ShapeContainer3.Size = New System.Drawing.Size(973, 445)
        Me.ShapeContainer3.TabIndex = 2
        Me.ShapeContainer3.TabStop = False
        '
        'RECT_SAVE_NEW_ITEM
        '
        Me.RECT_SAVE_NEW_ITEM.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_SAVE_NEW_ITEM.BorderWidth = 2
        Me.RECT_SAVE_NEW_ITEM.CornerRadius = 17
        Me.RECT_SAVE_NEW_ITEM.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_SAVE_NEW_ITEM.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_SAVE_NEW_ITEM.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_SAVE_NEW_ITEM.Location = New System.Drawing.Point(865, 406)
        Me.RECT_SAVE_NEW_ITEM.Name = "RECT_SAVE_NEW_ITEM"
        Me.RECT_SAVE_NEW_ITEM.Size = New System.Drawing.Size(100, 34)
        '
        'RECT_ADD_ITEM
        '
        Me.RECT_ADD_ITEM.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ADD_ITEM.BorderWidth = 2
        Me.RECT_ADD_ITEM.CornerRadius = 17
        Me.RECT_ADD_ITEM.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_ADD_ITEM.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_ADD_ITEM.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_ADD_ITEM.Location = New System.Drawing.Point(823, 1)
        Me.RECT_ADD_ITEM.Name = "RECT_ADD_ITEM"
        Me.RECT_ADD_ITEM.Size = New System.Drawing.Size(137, 34)
        '
        'GRP_DR_DETAILS
        '
        Me.GRP_DR_DETAILS.Controls.Add(Me.Label15)
        Me.GRP_DR_DETAILS.Controls.Add(Me.Label14)
        Me.GRP_DR_DETAILS.Controls.Add(Me.Label13)
        Me.GRP_DR_DETAILS.Controls.Add(Me.Label11)
        Me.GRP_DR_DETAILS.Controls.Add(Me.DGV_DR_PARTICULARS)
        Me.GRP_DR_DETAILS.Controls.Add(Me.WTXT_DATE_DELIVERED)
        Me.GRP_DR_DETAILS.Controls.Add(Me.Label3)
        Me.GRP_DR_DETAILS.Controls.Add(Me.WTXT_COMPANY_NAME)
        Me.GRP_DR_DETAILS.Controls.Add(Me.Label2)
        Me.GRP_DR_DETAILS.Controls.Add(Me.WTXT_TIN_NO)
        Me.GRP_DR_DETAILS.Controls.Add(Me.WTXT_DR_NO)
        Me.GRP_DR_DETAILS.Controls.Add(Me.Label1)
        Me.GRP_DR_DETAILS.Controls.Add(Me.Label12)
        Me.GRP_DR_DETAILS.Controls.Add(Me.ShapeContainer2)
        Me.GRP_DR_DETAILS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_DR_DETAILS.Location = New System.Drawing.Point(55, 5)
        Me.GRP_DR_DETAILS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GRP_DR_DETAILS.Name = "GRP_DR_DETAILS"
        Me.GRP_DR_DETAILS.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GRP_DR_DETAILS.Size = New System.Drawing.Size(979, 253)
        Me.GRP_DR_DETAILS.TabIndex = 1497
        Me.GRP_DR_DETAILS.TabStop = False
        Me.GRP_DR_DETAILS.Text = "DELIVERY RECEIPT DETAILS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(957, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 16)
        Me.Label15.TabIndex = 1505
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(264, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 16)
        Me.Label14.TabIndex = 1504
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(533, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 16)
        Me.Label13.TabIndex = 1503
        Me.Label13.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(262, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 16)
        Me.Label11.TabIndex = 1502
        Me.Label11.Text = "*"
        '
        'DGV_DR_PARTICULARS
        '
        Me.DGV_DR_PARTICULARS.AllowUserToAddRows = False
        Me.DGV_DR_PARTICULARS.AllowUserToDeleteRows = False
        Me.DGV_DR_PARTICULARS.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_DR_PARTICULARS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_DR_PARTICULARS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DR_PARTICULARS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESC, Me.QTY, Me.Units, Me.WARRANTY})
        Me.DGV_DR_PARTICULARS.Location = New System.Drawing.Point(9, 137)
        Me.DGV_DR_PARTICULARS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_DR_PARTICULARS.MultiSelect = False
        Me.DGV_DR_PARTICULARS.Name = "DGV_DR_PARTICULARS"
        Me.DGV_DR_PARTICULARS.ReadOnly = True
        Me.DGV_DR_PARTICULARS.RowHeadersVisible = False
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.DGV_DR_PARTICULARS.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_DR_PARTICULARS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_DR_PARTICULARS.Size = New System.Drawing.Size(962, 108)
        Me.DGV_DR_PARTICULARS.TabIndex = 1
        '
        'DESC
        '
        Me.DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DESC.HeaderText = "Description"
        Me.DESC.Name = "DESC"
        Me.DESC.ReadOnly = True
        '
        'QTY
        '
        Me.QTY.HeaderText = "Quantity"
        Me.QTY.Name = "QTY"
        Me.QTY.ReadOnly = True
        '
        'Units
        '
        Me.Units.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Units.HeaderText = "Unit"
        Me.Units.Name = "Units"
        Me.Units.ReadOnly = True
        '
        'WARRANTY
        '
        Me.WARRANTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.WARRANTY.HeaderText = "Warranty"
        Me.WARRANTY.Name = "WARRANTY"
        Me.WARRANTY.ReadOnly = True
        Me.WARRANTY.Width = 150
        '
        'WTXT_DATE_DELIVERED
        '
        Me.WTXT_DATE_DELIVERED.BackColor = System.Drawing.Color.White
        Me.WTXT_DATE_DELIVERED.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DATE_DELIVERED.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_DATE_DELIVERED.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DATE_DELIVERED.ForeColor = System.Drawing.Color.Black
        Me.WTXT_DATE_DELIVERED.Location = New System.Drawing.Point(288, 47)
        Me.WTXT_DATE_DELIVERED.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_DATE_DELIVERED.MaxLength = 300
        Me.WTXT_DATE_DELIVERED.Name = "WTXT_DATE_DELIVERED"
        Me.WTXT_DATE_DELIVERED.ReadOnly = True
        Me.WTXT_DATE_DELIVERED.Size = New System.Drawing.Size(256, 21)
        Me.WTXT_DATE_DELIVERED.TabIndex = 1501
        Me.WTXT_DATE_DELIVERED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_DATE_DELIVERED.Watermark = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(296, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 1500
        Me.Label3.Text = "Date Delivered"
        '
        'WTXT_COMPANY_NAME
        '
        Me.WTXT_COMPANY_NAME.BackColor = System.Drawing.Color.White
        Me.WTXT_COMPANY_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_COMPANY_NAME.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_COMPANY_NAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_COMPANY_NAME.ForeColor = System.Drawing.Color.Black
        Me.WTXT_COMPANY_NAME.Location = New System.Drawing.Point(288, 96)
        Me.WTXT_COMPANY_NAME.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_COMPANY_NAME.MaxLength = 300
        Me.WTXT_COMPANY_NAME.Name = "WTXT_COMPANY_NAME"
        Me.WTXT_COMPANY_NAME.ReadOnly = True
        Me.WTXT_COMPANY_NAME.Size = New System.Drawing.Size(679, 21)
        Me.WTXT_COMPANY_NAME.TabIndex = 1499
        Me.WTXT_COMPANY_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_COMPANY_NAME.Watermark = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(24, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 1498
        Me.Label2.Text = "Tin No."
        '
        'WTXT_TIN_NO
        '
        Me.WTXT_TIN_NO.BackColor = System.Drawing.Color.White
        Me.WTXT_TIN_NO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_TIN_NO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_TIN_NO.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_TIN_NO.ForeColor = System.Drawing.Color.Black
        Me.WTXT_TIN_NO.Location = New System.Drawing.Point(17, 96)
        Me.WTXT_TIN_NO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_TIN_NO.MaxLength = 300
        Me.WTXT_TIN_NO.Name = "WTXT_TIN_NO"
        Me.WTXT_TIN_NO.ReadOnly = True
        Me.WTXT_TIN_NO.Size = New System.Drawing.Size(256, 21)
        Me.WTXT_TIN_NO.TabIndex = 1497
        Me.WTXT_TIN_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_TIN_NO.Watermark = ""
        '
        'WTXT_DR_NO
        '
        Me.WTXT_DR_NO.BackColor = System.Drawing.Color.White
        Me.WTXT_DR_NO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DR_NO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_DR_NO.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DR_NO.ForeColor = System.Drawing.Color.Black
        Me.WTXT_DR_NO.Location = New System.Drawing.Point(17, 47)
        Me.WTXT_DR_NO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_DR_NO.MaxLength = 300
        Me.WTXT_DR_NO.Name = "WTXT_DR_NO"
        Me.WTXT_DR_NO.ReadOnly = True
        Me.WTXT_DR_NO.Size = New System.Drawing.Size(256, 21)
        Me.WTXT_DR_NO.TabIndex = 1496
        Me.WTXT_DR_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_DR_NO.Watermark = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(296, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 1495
        Me.Label1.Text = "Company Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(24, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 16)
        Me.Label12.TabIndex = 1494
        Me.Label12.Text = "DR No."
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 18)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_DATE_DELIVERED, Me.RECT_COMP_NAME, Me.RECT_TIN_NO, Me.RECT_DR_NO})
        Me.ShapeContainer2.Size = New System.Drawing.Size(973, 231)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_DATE_DELIVERED
        '
        Me.RECT_DATE_DELIVERED.BorderColor = System.Drawing.Color.Gray
        Me.RECT_DATE_DELIVERED.CornerRadius = 5
        Me.RECT_DATE_DELIVERED.Location = New System.Drawing.Point(279, 21)
        Me.RECT_DATE_DELIVERED.Name = "RECT_DATE_DELIVERED"
        Me.RECT_DATE_DELIVERED.Size = New System.Drawing.Size(267, 35)
        '
        'RECT_COMP_NAME
        '
        Me.RECT_COMP_NAME.BorderColor = System.Drawing.Color.Gray
        Me.RECT_COMP_NAME.CornerRadius = 5
        Me.RECT_COMP_NAME.Location = New System.Drawing.Point(280, 69)
        Me.RECT_COMP_NAME.Name = "RECT_COMP_NAME"
        Me.RECT_COMP_NAME.Size = New System.Drawing.Size(689, 35)
        '
        'RECT_TIN_NO
        '
        Me.RECT_TIN_NO.BorderColor = System.Drawing.Color.Gray
        Me.RECT_TIN_NO.CornerRadius = 5
        Me.RECT_TIN_NO.Location = New System.Drawing.Point(8, 69)
        Me.RECT_TIN_NO.Name = "RECT_TIN_NO"
        Me.RECT_TIN_NO.Size = New System.Drawing.Size(268, 35)
        '
        'RECT_DR_NO
        '
        Me.RECT_DR_NO.BorderColor = System.Drawing.Color.Gray
        Me.RECT_DR_NO.CornerRadius = 5
        Me.RECT_DR_NO.Location = New System.Drawing.Point(8, 21)
        Me.RECT_DR_NO.Name = "RECT_DR_NO"
        Me.RECT_DR_NO.Size = New System.Drawing.Size(267, 35)
        '
        'BTN_CLOSE_STOCK
        '
        Me.BTN_CLOSE_STOCK.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_CLOSE_STOCK.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE_STOCK.Image = CType(resources.GetObject("BTN_CLOSE_STOCK.Image"), System.Drawing.Image)
        Me.BTN_CLOSE_STOCK.Location = New System.Drawing.Point(0, 0)
        Me.BTN_CLOSE_STOCK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_CLOSE_STOCK.Name = "BTN_CLOSE_STOCK"
        Me.BTN_CLOSE_STOCK.Size = New System.Drawing.Size(52, 737)
        Me.BTN_CLOSE_STOCK.TabIndex = 1
        Me.BTN_CLOSE_STOCK.UseVisualStyleBackColor = True
        '
        'PNL_ITEM_DETAILS_ENC
        '
        Me.PNL_ITEM_DETAILS_ENC.Controls.Add(Me.Panel3)
        Me.PNL_ITEM_DETAILS_ENC.Controls.Add(Me.ShapeContainer6)
        Me.PNL_ITEM_DETAILS_ENC.Location = New System.Drawing.Point(287, 287)
        Me.PNL_ITEM_DETAILS_ENC.Name = "PNL_ITEM_DETAILS_ENC"
        Me.PNL_ITEM_DETAILS_ENC.Size = New System.Drawing.Size(541, 238)
        Me.PNL_ITEM_DETAILS_ENC.TabIndex = 1531
        Me.PNL_ITEM_DETAILS_ENC.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CB_UNIT_TYPE)
        Me.Panel3.Controls.Add(Me.BTN_ITEM_DETAILS_ENC_CANCEL)
        Me.Panel3.Controls.Add(Me.BTN_ITEM_DETAILS_ENC_SAVE)
        Me.Panel3.Controls.Add(Me.WTXT_TOTAL_PRICE)
        Me.Panel3.Controls.Add(Me.WTXT_UNIT_PRICE)
        Me.Panel3.Controls.Add(Me.WTXT_QTY)
        Me.Panel3.Controls.Add(Me.WTXT_ITEM_DESCRIPTION)
        Me.Panel3.Controls.Add(Me.WTXT_ITEM_CODE)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.ShapeContainer4)
        Me.Panel3.Location = New System.Drawing.Point(7, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 201)
        Me.Panel3.TabIndex = 1
        '
        'CB_UNIT_TYPE
        '
        Me.CB_UNIT_TYPE.DataSource = Me.TBLG3UNITSBindingSource
        Me.CB_UNIT_TYPE.DisplayMember = "UN_DESCRIPTION"
        Me.CB_UNIT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_UNIT_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_UNIT_TYPE.FormattingEnabled = True
        Me.CB_UNIT_TYPE.Location = New System.Drawing.Point(149, 123)
        Me.CB_UNIT_TYPE.Name = "CB_UNIT_TYPE"
        Me.CB_UNIT_TYPE.Size = New System.Drawing.Size(99, 24)
        Me.CB_UNIT_TYPE.TabIndex = 1511
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
        'BTN_ITEM_DETAILS_ENC_CANCEL
        '
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Location = New System.Drawing.Point(415, 161)
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Name = "BTN_ITEM_DETAILS_ENC_CANCEL"
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Size = New System.Drawing.Size(91, 27)
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.TabIndex = 1510
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.Text = "CLOSE"
        Me.BTN_ITEM_DETAILS_ENC_CANCEL.UseVisualStyleBackColor = True
        '
        'BTN_ITEM_DETAILS_ENC_SAVE
        '
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Location = New System.Drawing.Point(338, 161)
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Name = "BTN_ITEM_DETAILS_ENC_SAVE"
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Size = New System.Drawing.Size(75, 27)
        Me.BTN_ITEM_DETAILS_ENC_SAVE.TabIndex = 1509
        Me.BTN_ITEM_DETAILS_ENC_SAVE.Text = "SAVE"
        Me.BTN_ITEM_DETAILS_ENC_SAVE.UseVisualStyleBackColor = True
        '
        'WTXT_TOTAL_PRICE
        '
        Me.WTXT_TOTAL_PRICE.BackColor = System.Drawing.Color.White
        Me.WTXT_TOTAL_PRICE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_TOTAL_PRICE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_TOTAL_PRICE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_TOTAL_PRICE.ForeColor = System.Drawing.Color.Black
        Me.WTXT_TOTAL_PRICE.Location = New System.Drawing.Point(389, 124)
        Me.WTXT_TOTAL_PRICE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_TOTAL_PRICE.MaxLength = 300
        Me.WTXT_TOTAL_PRICE.Name = "WTXT_TOTAL_PRICE"
        Me.WTXT_TOTAL_PRICE.ReadOnly = True
        Me.WTXT_TOTAL_PRICE.Size = New System.Drawing.Size(110, 21)
        Me.WTXT_TOTAL_PRICE.TabIndex = 1508
        Me.WTXT_TOTAL_PRICE.Text = "0"
        Me.WTXT_TOTAL_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_TOTAL_PRICE.Watermark = ""
        '
        'WTXT_UNIT_PRICE
        '
        Me.WTXT_UNIT_PRICE.BackColor = System.Drawing.Color.White
        Me.WTXT_UNIT_PRICE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_UNIT_PRICE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_UNIT_PRICE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_UNIT_PRICE.ForeColor = System.Drawing.Color.Black
        Me.WTXT_UNIT_PRICE.Location = New System.Drawing.Point(261, 124)
        Me.WTXT_UNIT_PRICE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_UNIT_PRICE.MaxLength = 300
        Me.WTXT_UNIT_PRICE.Name = "WTXT_UNIT_PRICE"
        Me.WTXT_UNIT_PRICE.Size = New System.Drawing.Size(110, 21)
        Me.WTXT_UNIT_PRICE.TabIndex = 1507
        Me.WTXT_UNIT_PRICE.Text = "0"
        Me.WTXT_UNIT_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_UNIT_PRICE.Watermark = ""
        '
        'WTXT_QTY
        '
        Me.WTXT_QTY.BackColor = System.Drawing.Color.White
        Me.WTXT_QTY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_QTY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_QTY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_QTY.ForeColor = System.Drawing.Color.Black
        Me.WTXT_QTY.Location = New System.Drawing.Point(28, 124)
        Me.WTXT_QTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_QTY.MaxLength = 300
        Me.WTXT_QTY.Name = "WTXT_QTY"
        Me.WTXT_QTY.Size = New System.Drawing.Size(110, 21)
        Me.WTXT_QTY.TabIndex = 1505
        Me.WTXT_QTY.Text = "0"
        Me.WTXT_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_QTY.Watermark = ""
        '
        'WTXT_ITEM_DESCRIPTION
        '
        Me.WTXT_ITEM_DESCRIPTION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.WTXT_ITEM_DESCRIPTION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.WTXT_ITEM_DESCRIPTION.BackColor = System.Drawing.Color.White
        Me.WTXT_ITEM_DESCRIPTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_DESCRIPTION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_ITEM_DESCRIPTION.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_DESCRIPTION.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_DESCRIPTION.Location = New System.Drawing.Point(27, 82)
        Me.WTXT_ITEM_DESCRIPTION.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_DESCRIPTION.MaxLength = 300
        Me.WTXT_ITEM_DESCRIPTION.Name = "WTXT_ITEM_DESCRIPTION"
        Me.WTXT_ITEM_DESCRIPTION.Size = New System.Drawing.Size(472, 21)
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
        Me.WTXT_ITEM_CODE.Location = New System.Drawing.Point(30, 42)
        Me.WTXT_ITEM_CODE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_CODE.MaxLength = 300
        Me.WTXT_ITEM_CODE.Name = "WTXT_ITEM_CODE"
        Me.WTXT_ITEM_CODE.ReadOnly = True
        Me.WTXT_ITEM_CODE.Size = New System.Drawing.Size(469, 21)
        Me.WTXT_ITEM_CODE.TabIndex = 1503
        Me.WTXT_ITEM_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ITEM_CODE.Watermark = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(388, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 1502
        Me.Label6.Text = "Total Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(259, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 1501
        Me.Label5.Text = "Unit Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(155, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 1500
        Me.Label4.Text = "Unit Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(27, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 1499
        Me.Label7.Text = "Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(27, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 16)
        Me.Label8.TabIndex = 1498
        Me.Label8.Text = "Item Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(27, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 1497
        Me.Label9.Text = "Item Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(213, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 1495
        Me.Label10.Text = "Item Details"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape6, Me.RectangleShape7, Me.RectangleShape8, Me.RectangleShape9})
        Me.ShapeContainer4.Size = New System.Drawing.Size(520, 201)
        Me.ShapeContainer4.TabIndex = 1496
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Location = New System.Drawing.Point(380, 119)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(125, 29)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(252, 119)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(125, 29)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape6.CornerRadius = 5
        Me.RectangleShape6.Location = New System.Drawing.Point(147, 119)
        Me.RectangleShape6.Name = "RectangleShape3"
        Me.RectangleShape6.Size = New System.Drawing.Size(102, 29)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(19, 119)
        Me.RectangleShape7.Name = "RectangleShape2"
        Me.RectangleShape7.Size = New System.Drawing.Size(125, 29)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.Location = New System.Drawing.Point(19, 76)
        Me.RectangleShape8.Name = "RectangleShape1"
        Me.RectangleShape8.Size = New System.Drawing.Size(486, 29)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.Location = New System.Drawing.Point(20, 36)
        Me.RectangleShape9.Name = "RECT_ITEM_DESCRIPTION"
        Me.RectangleShape9.Size = New System.Drawing.Size(485, 29)
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape10})
        Me.ShapeContainer6.Size = New System.Drawing.Size(541, 238)
        Me.ShapeContainer6.TabIndex = 2
        Me.ShapeContainer6.TabStop = False
        '
        'RectangleShape10
        '
        Me.RectangleShape10.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape10.BorderWidth = 2
        Me.RectangleShape10.CornerRadius = 1
        Me.RectangleShape10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape10.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape10.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape10.Location = New System.Drawing.Point(3, 3)
        Me.RectangleShape10.Name = "RECT_ITEM_STOCK"
        Me.RectangleShape10.Size = New System.Drawing.Size(527, 209)
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBLG3_UNITSTableAdapter
        '
        Me.TBLG3_UNITSTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_DR_ITEMSTableAdapter
        '
        Me.TBLM4_INV_DR_ITEMSTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_DR_ITEMSBindingSource
        '
        Me.TBLM4_INV_DR_ITEMSBindingSource.DataMember = "TBLM4_INV_DR_ITEMS"
        Me.TBLM4_INV_DR_ITEMSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'VWM4_ITEM_LISTBindingSource
        '
        Me.VWM4_ITEM_LISTBindingSource.DataMember = "VWM4_ITEM_LIST"
        Me.VWM4_ITEM_LISTBindingSource.DataSource = Me.DS_VIEWS
        '
        'VWM4_ITEM_LISTTableAdapter
        '
        Me.VWM4_ITEM_LISTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_STOCKMASTERLISTTableAdapter
        '
        Me.SPM4_ITEM_STOCKMASTERLISTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_STOCKS_LEGENDBindingSource
        '
        Me.SPM4_ITEM_STOCKS_LEGENDBindingSource.DataMember = "SPM4_ITEM_STOCKS_LEGEND"
        Me.SPM4_ITEM_STOCKS_LEGENDBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_ITEM_STOCKS_LEGENDTableAdapter
        '
        Me.SPM4_ITEM_STOCKS_LEGENDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.A_CLOSEPROGRAMTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'ITEM_STATUS
        '
        Me.ITEM_STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent
        Me.ITEM_STATUS.DefaultCellStyle = DataGridViewCellStyle1
        Me.ITEM_STATUS.HeaderText = ""
        Me.ITEM_STATUS.Name = "ITEM_STATUS"
        Me.ITEM_STATUS.ReadOnly = True
        Me.ITEM_STATUS.Width = 25
        '
        'ITEMCODEDataGridViewTextBoxColumn
        '
        Me.ITEMCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITEMCODEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CODE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ITEMCODEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ITEMCODEDataGridViewTextBoxColumn.HeaderText = "Item Code"
        Me.ITEMCODEDataGridViewTextBoxColumn.Name = "ITEMCODEDataGridViewTextBoxColumn"
        Me.ITEMCODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMCODEDataGridViewTextBoxColumn.Width = 160
        '
        'ITEMDESCDataGridViewTextBoxColumn
        '
        Me.ITEMDESCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ITEMDESCDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ALIAS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ITEMDESCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ITEMDESCDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.ITEMDESCDataGridViewTextBoxColumn.Name = "ITEMDESCDataGridViewTextBoxColumn"
        Me.ITEMDESCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALSTOCKDataGridViewTextBoxColumn
        '
        Me.TOTALSTOCKDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_STOCK"
        Me.TOTALSTOCKDataGridViewTextBoxColumn.HeaderText = "TOTAL_STOCK"
        Me.TOTALSTOCKDataGridViewTextBoxColumn.Name = "TOTALSTOCKDataGridViewTextBoxColumn"
        Me.TOTALSTOCKDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALSTOCKDataGridViewTextBoxColumn.Visible = False
        '
        'ITEMUNITDataGridViewTextBoxColumn
        '
        Me.ITEMUNITDataGridViewTextBoxColumn.DataPropertyName = "ITEM_UNIT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.ITEMUNITDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ITEMUNITDataGridViewTextBoxColumn.HeaderText = "Unit"
        Me.ITEMUNITDataGridViewTextBoxColumn.Name = "ITEMUNITDataGridViewTextBoxColumn"
        Me.ITEMUNITDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APPQTYDataGridViewTextBoxColumn
        '
        Me.APPQTYDataGridViewTextBoxColumn.DataPropertyName = "APP_QTY"
        Me.APPQTYDataGridViewTextBoxColumn.HeaderText = "APP_QTY"
        Me.APPQTYDataGridViewTextBoxColumn.Name = "APPQTYDataGridViewTextBoxColumn"
        Me.APPQTYDataGridViewTextBoxColumn.ReadOnly = True
        Me.APPQTYDataGridViewTextBoxColumn.Visible = False
        '
        'REMSTOCKDataGridViewTextBoxColumn
        '
        Me.REMSTOCKDataGridViewTextBoxColumn.DataPropertyName = "REM_STOCK"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.REMSTOCKDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.REMSTOCKDataGridViewTextBoxColumn.HeaderText = "No. of stocks"
        Me.REMSTOCKDataGridViewTextBoxColumn.Name = "REMSTOCKDataGridViewTextBoxColumn"
        Me.REMSTOCKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEM_MIN_QTY
        '
        Me.ITEM_MIN_QTY.DataPropertyName = "ITEM_MIN_QTY"
        Me.ITEM_MIN_QTY.HeaderText = "ITEM_MIN_QTY"
        Me.ITEM_MIN_QTY.Name = "ITEM_MIN_QTY"
        Me.ITEM_MIN_QTY.ReadOnly = True
        Me.ITEM_MIN_QTY.Visible = False
        '
        'ITEM_MAX_QTY
        '
        Me.ITEM_MAX_QTY.DataPropertyName = "ITEM_MAX_QTY"
        Me.ITEM_MAX_QTY.HeaderText = "ITEM_MAX_QTY"
        Me.ITEM_MAX_QTY.Name = "ITEM_MAX_QTY"
        Me.ITEM_MAX_QTY.ReadOnly = True
        Me.ITEM_MAX_QTY.Visible = False
        '
        'FRM_STOCK_ENC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 812)
        Me.Controls.Add(Me.PNL_ITEM_DETAILS_ENC)
        Me.Controls.Add(Me.APNL_NEW_ITEM)
        Me.Controls.Add(Me.PNL_BUTTONS)
        Me.Controls.Add(Me.PNL_SEARCH_DGV)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_STOCK_ENC"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_STOCK_ENC"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.PNL_SEARCH_DGV.ResumeLayout(False)
        Me.PNL_SEARCH_DGV.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ITEM_STOCK_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_STOCK_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4ITEMSTOCKMASTERLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4STOCKLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_BUTTONS.ResumeLayout(False)
        Me.PNL_BUTTONS.PerformLayout()
        CType(Me.PB_STK_CTRL_SETUP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_STOCK_VIEW_REPORT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_NEW_ITEM_STOCK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APNL_NEW_ITEM.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PB_SAVE_NEW_ITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ADD_ITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ITEM_STOCK_DETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_DR_DETAILS.ResumeLayout(False)
        Me.GRP_DR_DETAILS.PerformLayout()
        CType(Me.DGV_DR_PARTICULARS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_ITEM_DETAILS_ENC.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_DR_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_STOCKS_LEGENDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PHY_C_CODEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_ITEM_STOCK_ENC_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL_SEARCH_DGV As Panel
    Friend WithEvents PNL_BUTTONS As Panel
    Friend WithEvents LLBL_STOCK_VIEW_REPORT As LinkLabel
    Friend WithEvents LLBL_NEW_ITEM_STOCK As LinkLabel
    Friend WithEvents PB_STOCK_VIEW_REPORT As PictureBox
    Friend WithEvents PB_NEW_ITEM_STOCK As PictureBox
    Friend WithEvents ShapeContainer5 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_NEW_ITEM_STOCK As PowerPacks.RectangleShape
    Friend WithEvents DGV_STOCK_LIST As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_ITEM_STOCK As PowerPacks.RectangleShape
    Friend WithEvents APNL_NEW_ITEM As Panel
    Friend WithEvents PB_ITEM_STOCK_SEARCH As PictureBox
    Friend WithEvents PB_ITEM_STOCK_CLEAR_SEARCH As PictureBox
    Friend WithEvents WTXT_ITEM_STOCK_SEARCH As WatermarkTextBox
    Friend WithEvents RECT_DR_NO As PowerPacks.RectangleShape
    Friend WithEvents RECT_TIN_NO As PowerPacks.RectangleShape
    Friend WithEvents BTN_CLOSE_STOCK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GRP_DR_DETAILS As GroupBox
    Friend WithEvents WTXT_TIN_NO As WatermarkTextBox
    Friend WithEvents WTXT_DR_NO As WatermarkTextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents WTXT_COMPANY_NAME As WatermarkTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RECT_COMP_NAME As PowerPacks.RectangleShape
    Friend WithEvents Label3 As Label
    Friend WithEvents RECT_DATE_DELIVERED As PowerPacks.RectangleShape
    Friend WithEvents WTXT_DATE_DELIVERED As WatermarkTextBox
    Friend WithEvents DGV_DR_PARTICULARS As DataGridView
    Friend WithEvents DESC As DataGridViewTextBoxColumn
    Friend WithEvents QTY As DataGridViewTextBoxColumn
    Friend WithEvents Units As DataGridViewTextBoxColumn
    Friend WithEvents WARRANTY As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_ITEM_STOCK_DETAILS As DataGridView
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_ADD_ITEM As PowerPacks.RectangleShape
    Friend WithEvents LLBL_ADD_ITEM As LinkLabel
    Friend WithEvents PB_ADD_ITEM As PictureBox
    Friend WithEvents PNL_ITEM_DETAILS_ENC As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_ITEM_DETAILS_ENC_CANCEL As Button
    Friend WithEvents BTN_ITEM_DETAILS_ENC_SAVE As Button
    Friend WithEvents WTXT_TOTAL_PRICE As WatermarkTextBox
    Friend WithEvents WTXT_UNIT_PRICE As WatermarkTextBox
    Friend WithEvents WTXT_QTY As WatermarkTextBox
    Friend WithEvents WTXT_ITEM_DESCRIPTION As WatermarkTextBox
    Friend WithEvents WTXT_ITEM_CODE As WatermarkTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer6 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape10 As PowerPacks.RectangleShape
    Friend WithEvents TableAdapterManager As DS_VIEWSTableAdapters.TableAdapterManager
    Friend WithEvents CB_UNIT_TYPE As ComboBox
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TBLG3UNITSBindingSource As BindingSource
    Friend WithEvents TBLG3_UNITSTableAdapter As DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter
    Friend WithEvents ITM_CODE As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_PRICE As DataGridViewTextBoxColumn
    Friend WithEvents ACTION_EDIT As DataGridViewButtonColumn
    Friend WithEvents ACTION_DELETE As DataGridViewButtonColumn
    Friend WithEvents LLBL_SAVE_NEW_ITEM As LinkLabel
    Friend WithEvents PB_SAVE_NEW_ITEM As PictureBox
    Friend WithEvents RECT_SAVE_NEW_ITEM As PowerPacks.RectangleShape
    Friend WithEvents TBLM4_INV_DR_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_DR_ITEMSTableAdapter
    Friend WithEvents TBLM4_INV_DR_ITEMSBindingSource As BindingSource
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents VWM4STOCKLISTBindingSource As BindingSource
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents VWM4_ITEM_LISTBindingSource As BindingSource
    Friend WithEvents VWM4_ITEM_LISTTableAdapter As DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter
    Friend WithEvents RECT_STOCK_VIEW_REPORT As PowerPacks.RectangleShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LLBL_NOSTOCK As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LLBL_OVER_STOCK As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LLBL_CRITICAL As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LLBL_NORMAL As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents CB_FILTER_BY As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents LBL_TOTALNOOFREC As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents RECT_STK_CTRL_SETUP As PowerPacks.RectangleShape
    Friend WithEvents LLBL_STKCTRL_SETUP As LinkLabel
    Friend WithEvents PB_STK_CTRL_SETUP As PictureBox
    Friend WithEvents SPM4ITEMSTOCKMASTERLISTBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SPM4_ITEM_STOCKMASTERLISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKMASTERLISTTableAdapter
    Friend WithEvents SPM4_ITEM_STOCKS_LEGENDBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_STOCKS_LEGENDTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKS_LEGENDTableAdapter
    Friend WithEvents TableAdapterManager1 As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents SPM4_PHY_C_CODETableAdapter As DS_STOREDPROCTableAdapters.SPM4_PHY_C_CODETableAdapter
    Friend WithEvents SPM4_PHY_C_CODEBindingSource As BindingSource
    Friend WithEvents ITEM_STATUS As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDESCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUNITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APPQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REMSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_MIN_QTY As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_MAX_QTY As DataGridViewTextBoxColumn
End Class
