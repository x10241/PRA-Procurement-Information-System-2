<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_INVENTORY_ENCODING
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
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INVENTORY_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.GRP_ITEMINFO = New System.Windows.Forms.GroupBox()
        Me.LLBL_CLOSE = New System.Windows.Forms.LinkLabel()
        Me.LLBL_SAVE_ADD_ITEM = New System.Windows.Forms.LinkLabel()
        Me.BTN_ADD_UNITTYPE = New System.Windows.Forms.Button()
        Me.BTN_ADD_BRAND_PROVIDER = New System.Windows.Forms.Button()
        Me.BTN_ADD_SUBCATEGORY = New System.Windows.Forms.Button()
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_INVENTORY_UNITCOST = New PRA_PIS.WatermarkTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_ADD_CATEGORY = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_INVENTORY_UNIT_TYPE = New System.Windows.Forms.ComboBox()
        Me.TBLG3UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.CB_INVENTORY_BRAND_NAME = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYITEMBRANDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_INVENTORY_SUBCATEGORY = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYSUBCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_INVENTORY_CATEGORY = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_INVENTORY_TOTAL_COST = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_INVENTORY_QUANTITY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_INVENTORY_SERIAL_NO = New PRA_PIS.WatermarkTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PBOX_PRNOQRCODE = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape15 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRREQUESTEDDATE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_ITEM_DESCRIPTION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_TOTAL_COST = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_UNIT_COST = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_QUANTITY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_SERIAL_NO = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRAPPCODE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_CLEAR_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_INVENTORY_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.GBOX_SETTINGS = New System.Windows.Forms.GroupBox()
        Me.LLBL_RECORDSFOUND = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DGV_INVENTORY_LIST = New System.Windows.Forms.DataGridView()
        Me.CATNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITBRNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITBRNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMSERIALNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMUNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMQUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_UNIT_COST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_TOTAL_COST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMUPDATEDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOC_LOCATION_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPM4INVENTORYDGVLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_NEW_SAVE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.TblM4_INVENTORY_ITEMSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblM4_INVENTORY_ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblM4_INVENTORY_ITEMS_PROPERTYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_CANCEL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_EDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LLBL_INVENTORY_SAVE = New System.Windows.Forms.LinkLabel()
        Me.PB_INVENTORY_SAVE = New System.Windows.Forms.PictureBox()
        Me.LLBL_INVENTORY_NEW = New System.Windows.Forms.LinkLabel()
        Me.PB_INVENTORY_NEW = New System.Windows.Forms.PictureBox()
        Me.LLBL_INVENTORY_EDIT = New System.Windows.Forms.LinkLabel()
        Me.PB_INVENTORY_EDIT = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_VIEW_REPORT = New System.Windows.Forms.PictureBox()
        Me.LLBL_INVENTORY_VIEW_REPORT = New System.Windows.Forms.LinkLabel()
        Me.APNL_ITEMINFO = New System.Windows.Forms.Panel()
        Me.GRP_LIST_ITEMS = New System.Windows.Forms.GroupBox()
        Me.LLBL_EDIT_ITEM = New System.Windows.Forms.LinkLabel()
        Me.LLBL_REMOVE_ITEM = New System.Windows.Forms.LinkLabel()
        Me.DGV_ITEM_INFO = New System.Windows.Forms.DataGridView()
        Me.dateacquisition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serialproduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitcost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalcost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemdescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subcat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brandd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LLBL_ADDITEM = New System.Windows.Forms.LinkLabel()
        Me.ShapeContainer7 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_EDIT_ITEM = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_REMOVE_ITEM = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GRP_CONSUMABLE = New System.Windows.Forms.GroupBox()
        Me.RBT_DEPLETED = New System.Windows.Forms.RadioButton()
        Me.RBT_PERPARTS = New System.Windows.Forms.RadioButton()
        Me.CB_ITEM_USAGE = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYACQUISITIONITEMUSAGEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_ACQUISITION_VALUE = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYACQUISITIONVALUEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RBT_PURCHASED = New System.Windows.Forms.RadioButton()
        Me.RBT_DONATED = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_ACCOUNTABLE_UNIT_PERSON = New System.Windows.Forms.GroupBox()
        Me.WTXT_PROPERTY_USER = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_CUSTODIAN_NAME = New PRA_PIS.WatermarkTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_DIVISION_UNIT = New System.Windows.Forms.ComboBox()
        Me.TblV1HRISDIVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_INVENTORY_CANCEL = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY_SAVE = New System.Windows.Forms.Button()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.LLBL_INVENTORY_ENCODING_HEADER = New System.Windows.Forms.Label()
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE = New System.Windows.Forms.Button()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TblM4INVENTORYACQUISITIONTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LLBL_INVENOTYR_ASSIGN = New System.Windows.Forms.LinkLabel()
        Me.SpM4_ITEM_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_CODE_GENERATORTableAdapter()
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.DS_CUSTOM = New PRA_PIS.DS_CUSTOM()
        Me.DSCUSTOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblV1_HRISDIVISIONTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter()
        Me.TblV1_HRISEMPLOYEEDATATableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter()
        Me.SPM4CURRENTDATETIMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_CURRENTDATETIMETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter()
        Me.TBLG3_UNITSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter()
        Me.SPM4_INVENTORYDGVLISTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_INVENTORYDGVLISTTableAdapter()
        Me.SPM4_PROPERTY_NOTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_PROPERTY_NOTableAdapter()
        Me.TblG3_DELIVER_RECEIPT_DETAILSTableAdapter1 = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_DELIVER_RECEIPT_DETAILSTableAdapter()
        Me.TblM4_INVENTORY_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter()
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter()
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter()
        Me.TblM4_INVENTORY_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter()
        Me.TblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter()
        Me.TblM4_INVENTORY_ACQUISITION_VALUETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter()
        Me.TblM4_CATEGORY_AND_SUBTableAdapter1 = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_CATEGORY_AND_SUBTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter()
        Me.PNL.SuspendLayout()
        Me.GRP_ITEMINFO.SuspendLayout()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBOX_SETTINGS.SuspendLayout()
        CType(Me.DGV_INVENTORY_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4INVENTORYDGVLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShapeContainer3.SuspendLayout()
        CType(Me.TblM4_INVENTORY_ITEMSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMS_PROPERTYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_NEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_EDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_VIEW_REPORT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APNL_ITEMINFO.SuspendLayout()
        Me.GRP_LIST_ITEMS.SuspendLayout()
        CType(Me.DGV_ITEM_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GRP_CONSUMABLE.SuspendLayout()
        CType(Me.TblM4INVENTORYACQUISITIONITEMUSAGEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYACQUISITIONVALUEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.SuspendLayout()
        CType(Me.TblV1HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel23.SuspendLayout()
        CType(Me.TblM4INVENTORYACQUISITIONTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCUSTOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_MINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(2288, 49)
        Me.PNL.TabIndex = 1405
        '
        'BTN_INVENTORY_MINIMIZE
        '
        Me.BTN_INVENTORY_MINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_MINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_INVENTORY_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_MINIMIZE.Location = New System.Drawing.Point(1022, 10)
        Me.BTN_INVENTORY_MINIMIZE.Name = "BTN_INVENTORY_MINIMIZE"
        Me.BTN_INVENTORY_MINIMIZE.Size = New System.Drawing.Size(27, 28)
        Me.BTN_INVENTORY_MINIMIZE.TabIndex = 17
        Me.BTN_INVENTORY_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_MINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_INVENTORY_CLOSE
        '
        Me.BTN_INVENTORY_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INVENTORY_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_CLOSE.Location = New System.Drawing.Point(1057, 9)
        Me.BTN_INVENTORY_CLOSE.Name = "BTN_INVENTORY_CLOSE"
        Me.BTN_INVENTORY_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INVENTORY_CLOSE.TabIndex = 16
        Me.BTN_INVENTORY_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(11, 14)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(272, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "I n v e n t o r y   E n c o d i n g"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-5599, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-5552, 10)
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
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_CLOSE)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_SAVE_ADD_ITEM)
        Me.GRP_ITEMINFO.Controls.Add(Me.BTN_ADD_UNITTYPE)
        Me.GRP_ITEMINFO.Controls.Add(Me.BTN_ADD_BRAND_PROVIDER)
        Me.GRP_ITEMINFO.Controls.Add(Me.BTN_ADD_SUBCATEGORY)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_INVENTORY_DATE_OF_ACQUISITION)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_INVENTORY_UNITCOST)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label5)
        Me.GRP_ITEMINFO.Controls.Add(Me.BTN_ADD_CATEGORY)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label12)
        Me.GRP_ITEMINFO.Controls.Add(Me.CB_INVENTORY_UNIT_TYPE)
        Me.GRP_ITEMINFO.Controls.Add(Me.CB_INVENTORY_BRAND_NAME)
        Me.GRP_ITEMINFO.Controls.Add(Me.CB_INVENTORY_SUBCATEGORY)
        Me.GRP_ITEMINFO.Controls.Add(Me.CB_INVENTORY_CATEGORY)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_INVENTORY_ITEM_DESCRIPTION)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_INVENTORY_TOTAL_COST)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_INVENTORY_QUANTITY)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_INVENTORY_SERIAL_NO)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label11)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label10)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label9)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label7)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label4)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label3)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label2)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label1)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label8)
        Me.GRP_ITEMINFO.Controls.Add(Me.PBOX_PRNOQRCODE)
        Me.GRP_ITEMINFO.Controls.Add(Me.ShapeContainer2)
        Me.GRP_ITEMINFO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRP_ITEMINFO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GRP_ITEMINFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GRP_ITEMINFO.Location = New System.Drawing.Point(278, 620)
        Me.GRP_ITEMINFO.Name = "GRP_ITEMINFO"
        Me.GRP_ITEMINFO.Size = New System.Drawing.Size(530, 542)
        Me.GRP_ITEMINFO.TabIndex = 1406
        Me.GRP_ITEMINFO.TabStop = False
        Me.GRP_ITEMINFO.Text = "Item Details"
        '
        'LLBL_CLOSE
        '
        Me.LLBL_CLOSE.AutoSize = True
        Me.LLBL_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_CLOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_CLOSE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_CLOSE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_CLOSE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_CLOSE.Location = New System.Drawing.Point(454, 506)
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
        Me.LLBL_SAVE_ADD_ITEM.Location = New System.Drawing.Point(393, 506)
        Me.LLBL_SAVE_ADD_ITEM.Name = "LLBL_SAVE_ADD_ITEM"
        Me.LLBL_SAVE_ADD_ITEM.Size = New System.Drawing.Size(46, 19)
        Me.LLBL_SAVE_ADD_ITEM.TabIndex = 1463
        Me.LLBL_SAVE_ADD_ITEM.TabStop = True
        Me.LLBL_SAVE_ADD_ITEM.Text = "ADD"
        '
        'BTN_ADD_UNITTYPE
        '
        Me.BTN_ADD_UNITTYPE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_ADD_UNITTYPE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ADD_UNITTYPE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ADD_UNITTYPE.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_ADD_UNITTYPE.FlatAppearance.BorderSize = 0
        Me.BTN_ADD_UNITTYPE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ADD_UNITTYPE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_ADD_UNITTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADD_UNITTYPE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD_UNITTYPE.Location = New System.Drawing.Point(490, 192)
        Me.BTN_ADD_UNITTYPE.Name = "BTN_ADD_UNITTYPE"
        Me.BTN_ADD_UNITTYPE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ADD_UNITTYPE.Size = New System.Drawing.Size(24, 24)
        Me.BTN_ADD_UNITTYPE.TabIndex = 1462
        Me.BTN_ADD_UNITTYPE.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_ADD_UNITTYPE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ADD_UNITTYPE.UseVisualStyleBackColor = True
        Me.BTN_ADD_UNITTYPE.Visible = False
        '
        'BTN_ADD_BRAND_PROVIDER
        '
        Me.BTN_ADD_BRAND_PROVIDER.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_ADD_BRAND_PROVIDER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ADD_BRAND_PROVIDER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ADD_BRAND_PROVIDER.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_ADD_BRAND_PROVIDER.FlatAppearance.BorderSize = 0
        Me.BTN_ADD_BRAND_PROVIDER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ADD_BRAND_PROVIDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_ADD_BRAND_PROVIDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADD_BRAND_PROVIDER.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD_BRAND_PROVIDER.Location = New System.Drawing.Point(406, 144)
        Me.BTN_ADD_BRAND_PROVIDER.Name = "BTN_ADD_BRAND_PROVIDER"
        Me.BTN_ADD_BRAND_PROVIDER.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ADD_BRAND_PROVIDER.Size = New System.Drawing.Size(24, 24)
        Me.BTN_ADD_BRAND_PROVIDER.TabIndex = 1461
        Me.BTN_ADD_BRAND_PROVIDER.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_ADD_BRAND_PROVIDER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ADD_BRAND_PROVIDER.UseVisualStyleBackColor = True
        '
        'BTN_ADD_SUBCATEGORY
        '
        Me.BTN_ADD_SUBCATEGORY.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_ADD_SUBCATEGORY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ADD_SUBCATEGORY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ADD_SUBCATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_ADD_SUBCATEGORY.FlatAppearance.BorderSize = 0
        Me.BTN_ADD_SUBCATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ADD_SUBCATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_ADD_SUBCATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ADD_SUBCATEGORY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD_SUBCATEGORY.Location = New System.Drawing.Point(406, 94)
        Me.BTN_ADD_SUBCATEGORY.Name = "BTN_ADD_SUBCATEGORY"
        Me.BTN_ADD_SUBCATEGORY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ADD_SUBCATEGORY.Size = New System.Drawing.Size(24, 24)
        Me.BTN_ADD_SUBCATEGORY.TabIndex = 1460
        Me.BTN_ADD_SUBCATEGORY.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_ADD_SUBCATEGORY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ADD_SUBCATEGORY.UseVisualStyleBackColor = True
        '
        'WTXT_INVENTORY_DATE_OF_ACQUISITION
        '
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = False
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION.Location = New System.Drawing.Point(380, 47)
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION.Name = "WTXT_INVENTORY_DATE_OF_ACQUISITION"
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION.Size = New System.Drawing.Size(133, 16)
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION.TabIndex = 1417
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION.Watermark = "MM/DD/YYYY"
        '
        'WTXT_INVENTORY_UNITCOST
        '
        Me.WTXT_INVENTORY_UNITCOST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_UNITCOST.Enabled = False
        Me.WTXT_INVENTORY_UNITCOST.Location = New System.Drawing.Point(117, 241)
        Me.WTXT_INVENTORY_UNITCOST.MaxLength = 15
        Me.WTXT_INVENTORY_UNITCOST.Name = "WTXT_INVENTORY_UNITCOST"
        Me.WTXT_INVENTORY_UNITCOST.Size = New System.Drawing.Size(216, 16)
        Me.WTXT_INVENTORY_UNITCOST.TabIndex = 6
        Me.WTXT_INVENTORY_UNITCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_INVENTORY_UNITCOST.Watermark = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(385, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 1334
        Me.Label5.Text = "Date Acquisition"
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
        Me.BTN_ADD_CATEGORY.Location = New System.Drawing.Point(342, 42)
        Me.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY"
        Me.BTN_ADD_CATEGORY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ADD_CATEGORY.Size = New System.Drawing.Size(24, 24)
        Me.BTN_ADD_CATEGORY.TabIndex = 1457
        Me.BTN_ADD_CATEGORY.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_ADD_CATEGORY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ADD_CATEGORY.UseVisualStyleBackColor = True
        Me.BTN_ADD_CATEGORY.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(501, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 19)
        Me.Label12.TabIndex = 1455
        Me.Label12.Text = "*"
        '
        'CB_INVENTORY_UNIT_TYPE
        '
        Me.CB_INVENTORY_UNIT_TYPE.DataSource = Me.TBLG3UNITSBindingSource
        Me.CB_INVENTORY_UNIT_TYPE.DisplayMember = "UN_DESCRIPTION"
        Me.CB_INVENTORY_UNIT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_UNIT_TYPE.Enabled = False
        Me.CB_INVENTORY_UNIT_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_UNIT_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_UNIT_TYPE.FormattingEnabled = True
        Me.CB_INVENTORY_UNIT_TYPE.Location = New System.Drawing.Point(346, 190)
        Me.CB_INVENTORY_UNIT_TYPE.Name = "CB_INVENTORY_UNIT_TYPE"
        Me.CB_INVENTORY_UNIT_TYPE.Size = New System.Drawing.Size(137, 27)
        Me.CB_INVENTORY_UNIT_TYPE.TabIndex = 4
        Me.CB_INVENTORY_UNIT_TYPE.ValueMember = "UN_NO"
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
        'CB_INVENTORY_BRAND_NAME
        '
        Me.CB_INVENTORY_BRAND_NAME.DataSource = Me.TblM4INVENTORYITEMBRANDBindingSource
        Me.CB_INVENTORY_BRAND_NAME.DisplayMember = "ITBR_NAME"
        Me.CB_INVENTORY_BRAND_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_BRAND_NAME.Enabled = False
        Me.CB_INVENTORY_BRAND_NAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_BRAND_NAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_BRAND_NAME.FormattingEnabled = True
        Me.CB_INVENTORY_BRAND_NAME.Location = New System.Drawing.Point(11, 140)
        Me.CB_INVENTORY_BRAND_NAME.Name = "CB_INVENTORY_BRAND_NAME"
        Me.CB_INVENTORY_BRAND_NAME.Size = New System.Drawing.Size(389, 27)
        Me.CB_INVENTORY_BRAND_NAME.TabIndex = 2
        Me.CB_INVENTORY_BRAND_NAME.ValueMember = "ITBR_NO"
        '
        'TblM4INVENTORYITEMBRANDBindingSource
        '
        Me.TblM4INVENTORYITEMBRANDBindingSource.DataMember = "tblM4_INVENTORY_ITEMBRAND"
        Me.TblM4INVENTORYITEMBRANDBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'CB_INVENTORY_SUBCATEGORY
        '
        Me.CB_INVENTORY_SUBCATEGORY.DataSource = Me.TblM4INVENTORYSUBCATEGORYBindingSource
        Me.CB_INVENTORY_SUBCATEGORY.DisplayMember = "SC_SUBCATEGORY_NAME"
        Me.CB_INVENTORY_SUBCATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_SUBCATEGORY.Enabled = False
        Me.CB_INVENTORY_SUBCATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_SUBCATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_SUBCATEGORY.FormattingEnabled = True
        Me.CB_INVENTORY_SUBCATEGORY.Location = New System.Drawing.Point(11, 91)
        Me.CB_INVENTORY_SUBCATEGORY.Name = "CB_INVENTORY_SUBCATEGORY"
        Me.CB_INVENTORY_SUBCATEGORY.Size = New System.Drawing.Size(389, 27)
        Me.CB_INVENTORY_SUBCATEGORY.TabIndex = 1
        Me.CB_INVENTORY_SUBCATEGORY.ValueMember = "SC_NO"
        '
        'TblM4INVENTORYSUBCATEGORYBindingSource
        '
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_SUB_CATEGORY"
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'CB_INVENTORY_CATEGORY
        '
        Me.CB_INVENTORY_CATEGORY.DataSource = Me.TblM4INVENTORYCATEGORYBindingSource
        Me.CB_INVENTORY_CATEGORY.DisplayMember = "CAT_NAME"
        Me.CB_INVENTORY_CATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_CATEGORY.Enabled = False
        Me.CB_INVENTORY_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_CATEGORY.FormattingEnabled = True
        Me.CB_INVENTORY_CATEGORY.Location = New System.Drawing.Point(12, 42)
        Me.CB_INVENTORY_CATEGORY.Name = "CB_INVENTORY_CATEGORY"
        Me.CB_INVENTORY_CATEGORY.Size = New System.Drawing.Size(353, 27)
        Me.CB_INVENTORY_CATEGORY.TabIndex = 0
        Me.CB_INVENTORY_CATEGORY.ValueMember = "CAT_CODE"
        '
        'TblM4INVENTORYCATEGORYBindingSource
        '
        Me.TblM4INVENTORYCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_CATEGORY"
        Me.TblM4INVENTORYCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'WTXT_INVENTORY_ITEM_DESCRIPTION
        '
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Enabled = False
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Location = New System.Drawing.Point(11, 290)
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.MaxLength = 120
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Multiline = True
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Name = "WTXT_INVENTORY_ITEM_DESCRIPTION"
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Size = New System.Drawing.Size(505, 192)
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.TabIndex = 7
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Watermark = Nothing
        '
        'WTXT_INVENTORY_TOTAL_COST
        '
        Me.WTXT_INVENTORY_TOTAL_COST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_TOTAL_COST.Enabled = False
        Me.WTXT_INVENTORY_TOTAL_COST.Location = New System.Drawing.Point(344, 241)
        Me.WTXT_INVENTORY_TOTAL_COST.MaxLength = 15
        Me.WTXT_INVENTORY_TOTAL_COST.Name = "WTXT_INVENTORY_TOTAL_COST"
        Me.WTXT_INVENTORY_TOTAL_COST.Size = New System.Drawing.Size(170, 16)
        Me.WTXT_INVENTORY_TOTAL_COST.TabIndex = 1429
        Me.WTXT_INVENTORY_TOTAL_COST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_INVENTORY_TOTAL_COST.Watermark = Nothing
        '
        'WTXT_INVENTORY_QUANTITY
        '
        Me.WTXT_INVENTORY_QUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_QUANTITY.Enabled = False
        Me.WTXT_INVENTORY_QUANTITY.Location = New System.Drawing.Point(11, 241)
        Me.WTXT_INVENTORY_QUANTITY.MaxLength = 10
        Me.WTXT_INVENTORY_QUANTITY.Name = "WTXT_INVENTORY_QUANTITY"
        Me.WTXT_INVENTORY_QUANTITY.Size = New System.Drawing.Size(95, 16)
        Me.WTXT_INVENTORY_QUANTITY.TabIndex = 5
        Me.WTXT_INVENTORY_QUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_INVENTORY_QUANTITY.Watermark = Nothing
        '
        'WTXT_INVENTORY_SERIAL_NO
        '
        Me.WTXT_INVENTORY_SERIAL_NO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_SERIAL_NO.Enabled = False
        Me.WTXT_INVENTORY_SERIAL_NO.Location = New System.Drawing.Point(11, 195)
        Me.WTXT_INVENTORY_SERIAL_NO.MaxLength = 50
        Me.WTXT_INVENTORY_SERIAL_NO.Name = "WTXT_INVENTORY_SERIAL_NO"
        Me.WTXT_INVENTORY_SERIAL_NO.Size = New System.Drawing.Size(325, 16)
        Me.WTXT_INVENTORY_SERIAL_NO.TabIndex = 3
        Me.WTXT_INVENTORY_SERIAL_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_INVENTORY_SERIAL_NO.Watermark = Nothing
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(18, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 17)
        Me.Label11.TabIndex = 1438
        Me.Label11.Text = "Item Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(352, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 1439
        Me.Label10.Text = "Total Cost"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(130, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 1438
        Me.Label9.Text = "Unit Cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(18, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 1437
        Me.Label7.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(351, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 1436
        Me.Label4.Text = "Unit Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(18, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 1435
        Me.Label3.Text = "Sub Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(18, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 1434
        Me.Label2.Text = "Brand/Provider"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 1433
        Me.Label1.Text = "Category"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(18, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 17)
        Me.Label8.TabIndex = 1340
        Me.Label8.Text = "Serial No. /Product No."
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
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape15, Me.RectangleShape14, Me.RECT_PRREQUESTEDDATE, Me.RECT_INVENTORY_ITEM_DESCRIPTION, Me.RECT_INVENTORY_TOTAL_COST, Me.RECT_INVENTORY_UNIT_COST, Me.RECT_INVENTORY_QUANTITY, Me.RectangleShape4, Me.RECT_INVENTORY_SERIAL_NO, Me.RectangleShape2, Me.RectangleShape1, Me.RECT_PRAPPCODE})
        Me.ShapeContainer2.Size = New System.Drawing.Size(524, 520)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape15
        '
        Me.RectangleShape15.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape15.BorderWidth = 2
        Me.RectangleShape15.CornerRadius = 19
        Me.RectangleShape15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape15.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape15.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape15.Location = New System.Drawing.Point(447, 476)
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
        Me.RectangleShape14.Location = New System.Drawing.Point(382, 476)
        Me.RectangleShape14.Name = "RectangleShape14"
        Me.RectangleShape14.Size = New System.Drawing.Size(62, 39)
        '
        'RECT_PRREQUESTEDDATE
        '
        Me.RECT_PRREQUESTEDDATE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRREQUESTEDDATE.BorderWidth = 2
        Me.RECT_PRREQUESTEDDATE.CornerRadius = 5
        Me.RECT_PRREQUESTEDDATE.Location = New System.Drawing.Point(372, 19)
        Me.RECT_PRREQUESTEDDATE.Name = "RECT_PRREQUESTEDDATE"
        Me.RECT_PRREQUESTEDDATE.Size = New System.Drawing.Size(142, 33)
        '
        'RECT_INVENTORY_ITEM_DESCRIPTION
        '
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.BorderWidth = 2
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.CornerRadius = 5
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.Location = New System.Drawing.Point(3, 261)
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.Name = "RECT_INVENTORY_ITEM_DESCRIPTION"
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.Size = New System.Drawing.Size(514, 206)
        '
        'RECT_INVENTORY_TOTAL_COST
        '
        Me.RECT_INVENTORY_TOTAL_COST.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_TOTAL_COST.BorderWidth = 2
        Me.RECT_INVENTORY_TOTAL_COST.CornerRadius = 5
        Me.RECT_INVENTORY_TOTAL_COST.Location = New System.Drawing.Point(336, 213)
        Me.RECT_INVENTORY_TOTAL_COST.Name = "RECT_INVENTORY_TOTAL_COST"
        Me.RECT_INVENTORY_TOTAL_COST.Size = New System.Drawing.Size(180, 32)
        '
        'RECT_INVENTORY_UNIT_COST
        '
        Me.RECT_INVENTORY_UNIT_COST.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_UNIT_COST.BorderWidth = 2
        Me.RECT_INVENTORY_UNIT_COST.CornerRadius = 5
        Me.RECT_INVENTORY_UNIT_COST.Location = New System.Drawing.Point(109, 213)
        Me.RECT_INVENTORY_UNIT_COST.Name = "RECT_INVENTORY_UNIT_COST"
        Me.RECT_INVENTORY_UNIT_COST.Size = New System.Drawing.Size(225, 32)
        '
        'RECT_INVENTORY_QUANTITY
        '
        Me.RECT_INVENTORY_QUANTITY.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_QUANTITY.BorderWidth = 2
        Me.RECT_INVENTORY_QUANTITY.CornerRadius = 5
        Me.RECT_INVENTORY_QUANTITY.Location = New System.Drawing.Point(3, 213)
        Me.RECT_INVENTORY_QUANTITY.Name = "RECT_INVENTORY_QUANTITY"
        Me.RECT_INVENTORY_QUANTITY.Size = New System.Drawing.Size(104, 32)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(339, 167)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(145, 32)
        '
        'RECT_INVENTORY_SERIAL_NO
        '
        Me.RECT_INVENTORY_SERIAL_NO.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_SERIAL_NO.BorderWidth = 2
        Me.RECT_INVENTORY_SERIAL_NO.CornerRadius = 5
        Me.RECT_INVENTORY_SERIAL_NO.Location = New System.Drawing.Point(3, 167)
        Me.RECT_INVENTORY_SERIAL_NO.Name = "RECT_INVENTORY_SERIAL_NO"
        Me.RECT_INVENTORY_SERIAL_NO.Size = New System.Drawing.Size(334, 32)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(3, 68)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(397, 32)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(3, 117)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(397, 33)
        '
        'RECT_PRAPPCODE
        '
        Me.RECT_PRAPPCODE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRAPPCODE.BorderWidth = 2
        Me.RECT_PRAPPCODE.CornerRadius = 5
        Me.RECT_PRAPPCODE.Location = New System.Drawing.Point(2, 19)
        Me.RECT_PRAPPCODE.Name = "RECT_PRAPPCODE"
        Me.RECT_PRAPPCODE.Size = New System.Drawing.Size(365, 32)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.GroupBox1.Controls.Add(Me.PB_INVENTORY_CLEAR_SEARCH)
        Me.GroupBox1.Controls.Add(Me.WTXT_INVENTORY_SEARCH)
        Me.GroupBox1.Controls.Add(Me.GBOX_SETTINGS)
        Me.GroupBox1.Controls.Add(Me.DGV_INVENTORY_LIST)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(9, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 546)
        Me.GroupBox1.TabIndex = 1407
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item List"
        '
        'PB_INVENTORY_SEARCH
        '
        Me.PB_INVENTORY_SEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PB_INVENTORY_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_SEARCH.Location = New System.Drawing.Point(1027, 25)
        Me.PB_INVENTORY_SEARCH.Name = "PB_INVENTORY_SEARCH"
        Me.PB_INVENTORY_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_SEARCH.TabIndex = 1430
        Me.PB_INVENTORY_SEARCH.TabStop = False
        '
        'PB_INVENTORY_CLEAR_SEARCH
        '
        Me.PB_INVENTORY_CLEAR_SEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.PB_INVENTORY_CLEAR_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_CLEAR_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_CLEAR_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_CLEAR_SEARCH.Location = New System.Drawing.Point(1027, 25)
        Me.PB_INVENTORY_CLEAR_SEARCH.Name = "PB_INVENTORY_CLEAR_SEARCH"
        Me.PB_INVENTORY_CLEAR_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_CLEAR_SEARCH.TabIndex = 1440
        Me.PB_INVENTORY_CLEAR_SEARCH.TabStop = False
        '
        'WTXT_INVENTORY_SEARCH
        '
        Me.WTXT_INVENTORY_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_SEARCH.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_INVENTORY_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.WTXT_INVENTORY_SEARCH.Location = New System.Drawing.Point(30, 29)
        Me.WTXT_INVENTORY_SEARCH.MaxLength = 300
        Me.WTXT_INVENTORY_SEARCH.Name = "WTXT_INVENTORY_SEARCH"
        Me.WTXT_INVENTORY_SEARCH.Size = New System.Drawing.Size(993, 21)
        Me.WTXT_INVENTORY_SEARCH.TabIndex = 1430
        Me.WTXT_INVENTORY_SEARCH.Watermark = "Search Item Code, Category, Sub Category, Brand/Provider Name, Serial No. Or Item" &
    " Description"
        '
        'GBOX_SETTINGS
        '
        Me.GBOX_SETTINGS.Controls.Add(Me.LLBL_RECORDSFOUND)
        Me.GBOX_SETTINGS.Controls.Add(Me.LinkLabel1)
        Me.GBOX_SETTINGS.Location = New System.Drawing.Point(6, 486)
        Me.GBOX_SETTINGS.Name = "GBOX_SETTINGS"
        Me.GBOX_SETTINGS.Size = New System.Drawing.Size(313, 50)
        Me.GBOX_SETTINGS.TabIndex = 1438
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
        Me.LinkLabel1.Size = New System.Drawing.Size(238, 19)
        Me.LinkLabel1.TabIndex = 1440
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Total No. of Records Found :"
        '
        'DGV_INVENTORY_LIST
        '
        Me.DGV_INVENTORY_LIST.AllowUserToAddRows = False
        Me.DGV_INVENTORY_LIST.AllowUserToDeleteRows = False
        Me.DGV_INVENTORY_LIST.AllowUserToResizeColumns = False
        Me.DGV_INVENTORY_LIST.AllowUserToResizeRows = False
        Me.DGV_INVENTORY_LIST.AutoGenerateColumns = False
        Me.DGV_INVENTORY_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_INVENTORY_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_INVENTORY_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CATNAMEDataGridViewTextBoxColumn, Me.Column1, Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn, Me.SCNODataGridViewTextBoxColumn, Me.ITBRNAMEDataGridViewTextBoxColumn, Me.ITBRNODataGridViewTextBoxColumn, Me.ITEMSERIALNODataGridViewTextBoxColumn, Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn, Me.ITEMUNITDataGridViewTextBoxColumn, Me.ITEMQUANTITYDataGridViewTextBoxColumn, Me.ITEM_UNIT_COST, Me.ITEM_TOTAL_COST, Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn, Me.ITEMCREATEDDATEDataGridViewTextBoxColumn, Me.ITEMUPDATEDDATEDataGridViewTextBoxColumn, Me.LOC_LOCATION_ID})
        Me.DGV_INVENTORY_LIST.DataSource = Me.SPM4INVENTORYDGVLISTBindingSource
        Me.DGV_INVENTORY_LIST.Location = New System.Drawing.Point(9, 62)
        Me.DGV_INVENTORY_LIST.MultiSelect = False
        Me.DGV_INVENTORY_LIST.Name = "DGV_INVENTORY_LIST"
        Me.DGV_INVENTORY_LIST.ReadOnly = True
        Me.DGV_INVENTORY_LIST.RowHeadersVisible = False
        Me.DGV_INVENTORY_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_INVENTORY_LIST.Size = New System.Drawing.Size(1062, 422)
        Me.DGV_INVENTORY_LIST.TabIndex = 1
        '
        'CATNAMEDataGridViewTextBoxColumn
        '
        Me.CATNAMEDataGridViewTextBoxColumn.DataPropertyName = "CAT_NAME"
        Me.CATNAMEDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CATNAMEDataGridViewTextBoxColumn.Name = "CATNAMEDataGridViewTextBoxColumn"
        Me.CATNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ITEM_CODE"
        Me.Column1.HeaderText = "Item Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'SCSUBCATEGORYNAMEDataGridViewTextBoxColumn
        '
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn.DataPropertyName = "SC_SUBCATEGORY_NAME"
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn.HeaderText = "Sub Category Name"
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn.Name = "SCSUBCATEGORYNAMEDataGridViewTextBoxColumn"
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SCNODataGridViewTextBoxColumn
        '
        Me.SCNODataGridViewTextBoxColumn.DataPropertyName = "SC_NO"
        Me.SCNODataGridViewTextBoxColumn.HeaderText = "SC_NO"
        Me.SCNODataGridViewTextBoxColumn.Name = "SCNODataGridViewTextBoxColumn"
        Me.SCNODataGridViewTextBoxColumn.ReadOnly = True
        Me.SCNODataGridViewTextBoxColumn.Visible = False
        '
        'ITBRNAMEDataGridViewTextBoxColumn
        '
        Me.ITBRNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITBR_NAME"
        Me.ITBRNAMEDataGridViewTextBoxColumn.HeaderText = "Brand/Provider Name"
        Me.ITBRNAMEDataGridViewTextBoxColumn.Name = "ITBRNAMEDataGridViewTextBoxColumn"
        Me.ITBRNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITBRNODataGridViewTextBoxColumn
        '
        Me.ITBRNODataGridViewTextBoxColumn.DataPropertyName = "ITBR_NO"
        Me.ITBRNODataGridViewTextBoxColumn.HeaderText = "ITBR_NO"
        Me.ITBRNODataGridViewTextBoxColumn.Name = "ITBRNODataGridViewTextBoxColumn"
        Me.ITBRNODataGridViewTextBoxColumn.ReadOnly = True
        Me.ITBRNODataGridViewTextBoxColumn.Visible = False
        '
        'ITEMSERIALNODataGridViewTextBoxColumn
        '
        Me.ITEMSERIALNODataGridViewTextBoxColumn.DataPropertyName = "ITEM_SERIAL_NO"
        Me.ITEMSERIALNODataGridViewTextBoxColumn.HeaderText = "Serial No./Product No."
        Me.ITEMSERIALNODataGridViewTextBoxColumn.Name = "ITEMSERIALNODataGridViewTextBoxColumn"
        Me.ITEMSERIALNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "ITEM_DESCRIPTION"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.Name = "ITEMDESCRIPTIONDataGridViewTextBoxColumn"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMUNITDataGridViewTextBoxColumn
        '
        Me.ITEMUNITDataGridViewTextBoxColumn.DataPropertyName = "ITEM_UNIT"
        Me.ITEMUNITDataGridViewTextBoxColumn.HeaderText = "Unit Type"
        Me.ITEMUNITDataGridViewTextBoxColumn.Name = "ITEMUNITDataGridViewTextBoxColumn"
        Me.ITEMUNITDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMUNITDataGridViewTextBoxColumn.Visible = False
        '
        'ITEMQUANTITYDataGridViewTextBoxColumn
        '
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.DataPropertyName = "ITEM_QUANTITY"
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.Name = "ITEMQUANTITYDataGridViewTextBoxColumn"
        Me.ITEMQUANTITYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEM_UNIT_COST
        '
        Me.ITEM_UNIT_COST.DataPropertyName = "ITEM_UNIT_COST"
        Me.ITEM_UNIT_COST.HeaderText = "Unit Cost"
        Me.ITEM_UNIT_COST.Name = "ITEM_UNIT_COST"
        Me.ITEM_UNIT_COST.ReadOnly = True
        '
        'ITEM_TOTAL_COST
        '
        Me.ITEM_TOTAL_COST.DataPropertyName = "ITEM_TOTAL_COST"
        Me.ITEM_TOTAL_COST.HeaderText = "Total Cost"
        Me.ITEM_TOTAL_COST.Name = "ITEM_TOTAL_COST"
        Me.ITEM_TOTAL_COST.ReadOnly = True
        '
        'ITEMDATEAQUISITIONDataGridViewTextBoxColumn
        '
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.DataPropertyName = "ITEM_DATE_AQUISITION"
        DataGridViewCellStyle1.Format = "MM/dd/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.HeaderText = "Date Acquisition"
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.Name = "ITEMDATEAQUISITIONDataGridViewTextBoxColumn"
        Me.ITEMDATEAQUISITIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMCREATEDDATEDataGridViewTextBoxColumn
        '
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CREATED_DATE"
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.HeaderText = "ITEM_CREATED_DATE"
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.Name = "ITEMCREATEDDATEDataGridViewTextBoxColumn"
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.Visible = False
        '
        'ITEMUPDATEDDATEDataGridViewTextBoxColumn
        '
        Me.ITEMUPDATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_UPDATED_DATE"
        Me.ITEMUPDATEDDATEDataGridViewTextBoxColumn.HeaderText = "ITEM_UPDATED_DATE"
        Me.ITEMUPDATEDDATEDataGridViewTextBoxColumn.Name = "ITEMUPDATEDDATEDataGridViewTextBoxColumn"
        Me.ITEMUPDATEDDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMUPDATEDDATEDataGridViewTextBoxColumn.Visible = False
        '
        'LOC_LOCATION_ID
        '
        Me.LOC_LOCATION_ID.DataPropertyName = "LOC_LOCATION_ID"
        Me.LOC_LOCATION_ID.HeaderText = "LOC_LOCATION_ID"
        Me.LOC_LOCATION_ID.Name = "LOC_LOCATION_ID"
        Me.LOC_LOCATION_ID.ReadOnly = True
        Me.LOC_LOCATION_ID.Visible = False
        '
        'SPM4INVENTORYDGVLISTBindingSource
        '
        Me.SPM4INVENTORYDGVLISTBindingSource.DataMember = "SPM4_INVENTORYDGVLIST"
        Me.SPM4INVENTORYDGVLISTBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(1504, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 145)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 18)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRCANCELEDIT})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1068, 525)
        Me.ShapeContainer1.TabIndex = 1439
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
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(5, 1)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(1060, 39)
        '
        'RECT_INVENTORY_NEW_SAVE
        '
        Me.RECT_INVENTORY_NEW_SAVE.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_INVENTORY_NEW_SAVE.BorderWidth = 2
        Me.RECT_INVENTORY_NEW_SAVE.CornerRadius = 19
        Me.RECT_INVENTORY_NEW_SAVE.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_NEW_SAVE.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_NEW_SAVE.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_NEW_SAVE.Location = New System.Drawing.Point(10, 56)
        Me.RECT_INVENTORY_NEW_SAVE.Name = "RECT_INVENTORY_NEW_SAVE"
        Me.RECT_INVENTORY_NEW_SAVE.Size = New System.Drawing.Size(103, 39)
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Controls.Add(Me.TblM4_INVENTORY_ITEMSDataGridView)
        Me.ShapeContainer3.Controls.Add(Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView)
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RECT_INVENTORY_CANCEL, Me.RECT_INVENTORY_EDIT, Me.RECT_INVENTORY_NEW_SAVE})
        Me.ShapeContainer3.Size = New System.Drawing.Size(2288, 660)
        Me.ShapeContainer3.TabIndex = 1408
        Me.ShapeContainer3.TabStop = False
        '
        'TblM4_INVENTORY_ITEMSDataGridView
        '
        Me.TblM4_INVENTORY_ITEMSDataGridView.AutoGenerateColumns = False
        Me.TblM4_INVENTORY_ITEMSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblM4_INVENTORY_ITEMSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.TblM4_INVENTORY_ITEMSDataGridView.DataSource = Me.TblM4_INVENTORY_ITEMSBindingSource
        Me.TblM4_INVENTORY_ITEMSDataGridView.Location = New System.Drawing.Point(1095, 242)
        Me.TblM4_INVENTORY_ITEMSDataGridView.Name = "TblM4_INVENTORY_ITEMSDataGridView"
        Me.TblM4_INVENTORY_ITEMSDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblM4_INVENTORY_ITEMSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ITEM_CODE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ITEM_CODE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SC_NO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "SC_NO"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ITBR_NO"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ITBR_NO"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ITEM_SERIAL_NO"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ITEM_SERIAL_NO"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ITEM_DESCRIPTION"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ITEM_DESCRIPTION"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ITEM_UNIT"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ITEM_UNIT"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ITEM_UNIT_COST"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ITEM_UNIT_COST"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ITEM_TOTAL_COST"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ITEM_TOTAL_COST"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ITEM_QUANTITY"
        Me.DataGridViewTextBoxColumn19.HeaderText = "ITEM_QUANTITY"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "ITEM_DATE_AQUISITION"
        Me.DataGridViewTextBoxColumn20.HeaderText = "ITEM_DATE_AQUISITION"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ITEM_CREATED_DATE"
        Me.DataGridViewTextBoxColumn21.HeaderText = "ITEM_CREATED_DATE"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "ITEM_UPDATED_DATE"
        Me.DataGridViewTextBoxColumn22.HeaderText = "ITEM_UPDATED_DATE"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'TblM4_INVENTORY_ITEMSBindingSource
        '
        Me.TblM4_INVENTORY_ITEMSBindingSource.DataMember = "tblM4_INVENTORY_ITEMS"
        Me.TblM4_INVENTORY_ITEMSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_ITEMS_PROPERTYDataGridView
        '
        Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.AutoGenerateColumns = False
        Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.DataSource = Me.TblM4_INVENTORY_ITEMS_PROPERTYBindingSource
        Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Location = New System.Drawing.Point(1095, 66)
        Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Name = "TblM4_INVENTORY_ITEMS_PROPERTYDataGridView"
        Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ITEM_NO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ITEM_NO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ITEM_CODE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ITEM_CODE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PROP_DIVISION_UNIT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PROP_DIVISION_UNIT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PROP_CUSTODIAN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PROP_CUSTODIAN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PROP_PROPERTY_USER"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PROP_PROPERTY_USER"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PROP_ENCODED_BY"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PROP_ENCODED_BY"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PROP_CREATED_DATE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PROP_CREATED_DATE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'TblM4_INVENTORY_ITEMS_PROPERTYBindingSource
        '
        Me.TblM4_INVENTORY_ITEMS_PROPERTYBindingSource.DataMember = "tblM4_INVENTORY_ITEMS_PROPERTY"
        Me.TblM4_INVENTORY_ITEMS_PROPERTYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 19
        Me.RectangleShape5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape5.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(225, 56)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(172, 39)
        '
        'RECT_INVENTORY_CANCEL
        '
        Me.RECT_INVENTORY_CANCEL.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_INVENTORY_CANCEL.BorderWidth = 2
        Me.RECT_INVENTORY_CANCEL.CornerRadius = 19
        Me.RECT_INVENTORY_CANCEL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_CANCEL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_CANCEL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_CANCEL.Location = New System.Drawing.Point(990, 56)
        Me.RECT_INVENTORY_CANCEL.Name = "RECT_INVENTORY_CANCEL"
        Me.RECT_INVENTORY_CANCEL.Size = New System.Drawing.Size(91, 39)
        Me.RECT_INVENTORY_CANCEL.Visible = False
        '
        'RECT_INVENTORY_EDIT
        '
        Me.RECT_INVENTORY_EDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_INVENTORY_EDIT.BorderWidth = 2
        Me.RECT_INVENTORY_EDIT.CornerRadius = 19
        Me.RECT_INVENTORY_EDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_EDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_EDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_EDIT.Location = New System.Drawing.Point(118, 56)
        Me.RECT_INVENTORY_EDIT.Name = "RECT_INVENTORY_EDIT"
        Me.RECT_INVENTORY_EDIT.Size = New System.Drawing.Size(103, 39)
        '
        'LLBL_INVENTORY_SAVE
        '
        Me.LLBL_INVENTORY_SAVE.ActiveLinkColor = System.Drawing.Color.Red
        Me.LLBL_INVENTORY_SAVE.AutoSize = True
        Me.LLBL_INVENTORY_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENTORY_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_INVENTORY_SAVE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_SAVE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENTORY_SAVE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_SAVE.Location = New System.Drawing.Point(54, 67)
        Me.LLBL_INVENTORY_SAVE.Name = "LLBL_INVENTORY_SAVE"
        Me.LLBL_INVENTORY_SAVE.Size = New System.Drawing.Size(52, 19)
        Me.LLBL_INVENTORY_SAVE.TabIndex = 1447
        Me.LLBL_INVENTORY_SAVE.TabStop = True
        Me.LLBL_INVENTORY_SAVE.Text = "SAVE"
        Me.LLBL_INVENTORY_SAVE.Visible = False
        '
        'PB_INVENTORY_SAVE
        '
        Me.PB_INVENTORY_SAVE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.baseline_save_black_18dp
        Me.PB_INVENTORY_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SAVE.InitialImage = Nothing
        Me.PB_INVENTORY_SAVE.Location = New System.Drawing.Point(22, 62)
        Me.PB_INVENTORY_SAVE.Name = "PB_INVENTORY_SAVE"
        Me.PB_INVENTORY_SAVE.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_SAVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_INVENTORY_SAVE.TabIndex = 1448
        Me.PB_INVENTORY_SAVE.TabStop = False
        Me.PB_INVENTORY_SAVE.Visible = False
        '
        'LLBL_INVENTORY_NEW
        '
        Me.LLBL_INVENTORY_NEW.AutoSize = True
        Me.LLBL_INVENTORY_NEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENTORY_NEW.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_INVENTORY_NEW.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_NEW.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENTORY_NEW.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_NEW.Location = New System.Drawing.Point(59, 67)
        Me.LLBL_INVENTORY_NEW.Name = "LLBL_INVENTORY_NEW"
        Me.LLBL_INVENTORY_NEW.Size = New System.Drawing.Size(46, 19)
        Me.LLBL_INVENTORY_NEW.TabIndex = 1449
        Me.LLBL_INVENTORY_NEW.TabStop = True
        Me.LLBL_INVENTORY_NEW.Text = "NEW"
        '
        'PB_INVENTORY_NEW
        '
        Me.PB_INVENTORY_NEW.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_post_add_black_18dp
        Me.PB_INVENTORY_NEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_NEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_NEW.InitialImage = Nothing
        Me.PB_INVENTORY_NEW.Location = New System.Drawing.Point(22, 62)
        Me.PB_INVENTORY_NEW.Name = "PB_INVENTORY_NEW"
        Me.PB_INVENTORY_NEW.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_NEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_INVENTORY_NEW.TabIndex = 1450
        Me.PB_INVENTORY_NEW.TabStop = False
        '
        'LLBL_INVENTORY_EDIT
        '
        Me.LLBL_INVENTORY_EDIT.AutoSize = True
        Me.LLBL_INVENTORY_EDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENTORY_EDIT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_INVENTORY_EDIT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_EDIT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENTORY_EDIT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_EDIT.Location = New System.Drawing.Point(169, 67)
        Me.LLBL_INVENTORY_EDIT.Name = "LLBL_INVENTORY_EDIT"
        Me.LLBL_INVENTORY_EDIT.Size = New System.Drawing.Size(42, 19)
        Me.LLBL_INVENTORY_EDIT.TabIndex = 1452
        Me.LLBL_INVENTORY_EDIT.TabStop = True
        Me.LLBL_INVENTORY_EDIT.Text = "EDIT"
        '
        'PB_INVENTORY_EDIT
        '
        Me.PB_INVENTORY_EDIT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_edit_black_24dp
        Me.PB_INVENTORY_EDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_EDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_EDIT.InitialImage = Nothing
        Me.PB_INVENTORY_EDIT.Location = New System.Drawing.Point(131, 62)
        Me.PB_INVENTORY_EDIT.Name = "PB_INVENTORY_EDIT"
        Me.PB_INVENTORY_EDIT.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_EDIT.TabIndex = 1451
        Me.PB_INVENTORY_EDIT.TabStop = False
        '
        'PB_INVENTORY_VIEW_REPORT
        '
        Me.PB_INVENTORY_VIEW_REPORT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.PB_INVENTORY_VIEW_REPORT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_VIEW_REPORT.InitialImage = Nothing
        Me.PB_INVENTORY_VIEW_REPORT.Location = New System.Drawing.Point(239, 62)
        Me.PB_INVENTORY_VIEW_REPORT.Name = "PB_INVENTORY_VIEW_REPORT"
        Me.PB_INVENTORY_VIEW_REPORT.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_VIEW_REPORT.TabIndex = 1454
        Me.PB_INVENTORY_VIEW_REPORT.TabStop = False
        '
        'LLBL_INVENTORY_VIEW_REPORT
        '
        Me.LLBL_INVENTORY_VIEW_REPORT.AutoSize = True
        Me.LLBL_INVENTORY_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENTORY_VIEW_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_INVENTORY_VIEW_REPORT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_VIEW_REPORT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENTORY_VIEW_REPORT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_VIEW_REPORT.Location = New System.Drawing.Point(273, 67)
        Me.LLBL_INVENTORY_VIEW_REPORT.Name = "LLBL_INVENTORY_VIEW_REPORT"
        Me.LLBL_INVENTORY_VIEW_REPORT.Size = New System.Drawing.Size(115, 19)
        Me.LLBL_INVENTORY_VIEW_REPORT.TabIndex = 1453
        Me.LLBL_INVENTORY_VIEW_REPORT.TabStop = True
        Me.LLBL_INVENTORY_VIEW_REPORT.Text = "VIEW REPORT"
        '
        'APNL_ITEMINFO
        '
        Me.APNL_ITEMINFO.BackColor = System.Drawing.Color.White
        Me.APNL_ITEMINFO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APNL_ITEMINFO.Controls.Add(Me.GRP_ITEMINFO)
        Me.APNL_ITEMINFO.Controls.Add(Me.GRP_LIST_ITEMS)
        Me.APNL_ITEMINFO.Controls.Add(Me.GroupBox3)
        Me.APNL_ITEMINFO.Controls.Add(Me.GRP_ACCOUNTABLE_UNIT_PERSON)
        Me.APNL_ITEMINFO.Controls.Add(Me.BTN_INVENTORY_CANCEL)
        Me.APNL_ITEMINFO.Controls.Add(Me.BTN_INVENTORY_SAVE)
        Me.APNL_ITEMINFO.Controls.Add(Me.Panel23)
        Me.APNL_ITEMINFO.Controls.Add(Me.BTN_CLOSE_INVENTORY_MINI_CLOSE)
        Me.APNL_ITEMINFO.Controls.Add(Me.ShapeContainer4)
        Me.APNL_ITEMINFO.Location = New System.Drawing.Point(1095, 42)
        Me.APNL_ITEMINFO.Name = "APNL_ITEMINFO"
        Me.APNL_ITEMINFO.Size = New System.Drawing.Size(812, 614)
        Me.APNL_ITEMINFO.TabIndex = 1455
        '
        'GRP_LIST_ITEMS
        '
        Me.GRP_LIST_ITEMS.Controls.Add(Me.LLBL_EDIT_ITEM)
        Me.GRP_LIST_ITEMS.Controls.Add(Me.LLBL_REMOVE_ITEM)
        Me.GRP_LIST_ITEMS.Controls.Add(Me.DGV_ITEM_INFO)
        Me.GRP_LIST_ITEMS.Controls.Add(Me.LLBL_ADDITEM)
        Me.GRP_LIST_ITEMS.Controls.Add(Me.ShapeContainer7)
        Me.GRP_LIST_ITEMS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_LIST_ITEMS.Location = New System.Drawing.Point(36, 231)
        Me.GRP_LIST_ITEMS.Name = "GRP_LIST_ITEMS"
        Me.GRP_LIST_ITEMS.Size = New System.Drawing.Size(768, 314)
        Me.GRP_LIST_ITEMS.TabIndex = 1445
        Me.GRP_LIST_ITEMS.TabStop = False
        Me.GRP_LIST_ITEMS.Text = "List Items"
        '
        'LLBL_EDIT_ITEM
        '
        Me.LLBL_EDIT_ITEM.AutoSize = True
        Me.LLBL_EDIT_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_EDIT_ITEM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_EDIT_ITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_EDIT_ITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_EDIT_ITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_EDIT_ITEM.Location = New System.Drawing.Point(458, 25)
        Me.LLBL_EDIT_ITEM.Name = "LLBL_EDIT_ITEM"
        Me.LLBL_EDIT_ITEM.Size = New System.Drawing.Size(73, 18)
        Me.LLBL_EDIT_ITEM.TabIndex = 1447
        Me.LLBL_EDIT_ITEM.TabStop = True
        Me.LLBL_EDIT_ITEM.Text = "EDIT ITEM"
        Me.LLBL_EDIT_ITEM.Visible = False
        '
        'LLBL_REMOVE_ITEM
        '
        Me.LLBL_REMOVE_ITEM.AutoSize = True
        Me.LLBL_REMOVE_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_REMOVE_ITEM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_REMOVE_ITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_REMOVE_ITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_REMOVE_ITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_REMOVE_ITEM.Location = New System.Drawing.Point(548, 26)
        Me.LLBL_REMOVE_ITEM.Name = "LLBL_REMOVE_ITEM"
        Me.LLBL_REMOVE_ITEM.Size = New System.Drawing.Size(107, 18)
        Me.LLBL_REMOVE_ITEM.TabIndex = 1446
        Me.LLBL_REMOVE_ITEM.TabStop = True
        Me.LLBL_REMOVE_ITEM.Text = "REMOVE ITEM"
        Me.LLBL_REMOVE_ITEM.Visible = False
        '
        'DGV_ITEM_INFO
        '
        Me.DGV_ITEM_INFO.AllowUserToAddRows = False
        Me.DGV_ITEM_INFO.AllowUserToDeleteRows = False
        Me.DGV_ITEM_INFO.AllowUserToResizeColumns = False
        Me.DGV_ITEM_INFO.AllowUserToResizeRows = False
        Me.DGV_ITEM_INFO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGV_ITEM_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEM_INFO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dateacquisition, Me.category, Me.subcategory, Me.brand, Me.serialproduct, Me.unit, Me.quantity, Me.unitcost, Me.totalcost, Me.itemdescription, Me.subcat, Me.brandd, Me.item_code})
        Me.DGV_ITEM_INFO.Location = New System.Drawing.Point(6, 57)
        Me.DGV_ITEM_INFO.MultiSelect = False
        Me.DGV_ITEM_INFO.Name = "DGV_ITEM_INFO"
        Me.DGV_ITEM_INFO.ReadOnly = True
        Me.DGV_ITEM_INFO.RowHeadersVisible = False
        Me.DGV_ITEM_INFO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEM_INFO.Size = New System.Drawing.Size(758, 251)
        Me.DGV_ITEM_INFO.TabIndex = 1443
        '
        'dateacquisition
        '
        Me.dateacquisition.FillWeight = 132.4503!
        Me.dateacquisition.HeaderText = "Date Acquisition"
        Me.dateacquisition.Name = "dateacquisition"
        Me.dateacquisition.ReadOnly = True
        Me.dateacquisition.Width = 110
        '
        'category
        '
        Me.category.FillWeight = 122.3927!
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        Me.category.Width = 81
        '
        'subcategory
        '
        Me.subcategory.FillWeight = 113.6672!
        Me.subcategory.HeaderText = "Sub Category"
        Me.subcategory.Name = "subcategory"
        Me.subcategory.ReadOnly = True
        Me.subcategory.Width = 96
        '
        'brand
        '
        Me.brand.FillWeight = 106.0975!
        Me.brand.HeaderText = "Brand/Provider"
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = True
        Me.brand.Width = 114
        '
        'serialproduct
        '
        Me.serialproduct.FillWeight = 99.53027!
        Me.serialproduct.HeaderText = "Serial No./Product No."
        Me.serialproduct.Name = "serialproduct"
        Me.serialproduct.ReadOnly = True
        Me.serialproduct.Width = 123
        '
        'unit
        '
        Me.unit.FillWeight = 93.83293!
        Me.unit.HeaderText = "Unit Type"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.Width = 74
        '
        'quantity
        '
        Me.quantity.FillWeight = 88.89021!
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 77
        '
        'unitcost
        '
        Me.unitcost.FillWeight = 84.60213!
        Me.unitcost.HeaderText = "Unit Cost"
        Me.unitcost.Name = "unitcost"
        Me.unitcost.ReadOnly = True
        Me.unitcost.Width = 72
        '
        'totalcost
        '
        Me.totalcost.FillWeight = 80.88204!
        Me.totalcost.HeaderText = "Total Cost"
        Me.totalcost.Name = "totalcost"
        Me.totalcost.ReadOnly = True
        Me.totalcost.Width = 77
        '
        'itemdescription
        '
        Me.itemdescription.FillWeight = 77.65466!
        Me.itemdescription.HeaderText = "Item Description"
        Me.itemdescription.Name = "itemdescription"
        Me.itemdescription.ReadOnly = True
        Me.itemdescription.Width = 107
        '
        'subcat
        '
        Me.subcat.HeaderText = "subcat"
        Me.subcat.Name = "subcat"
        Me.subcat.ReadOnly = True
        Me.subcat.Visible = False
        Me.subcat.Width = 64
        '
        'brandd
        '
        Me.brandd.HeaderText = "brand"
        Me.brandd.Name = "brandd"
        Me.brandd.ReadOnly = True
        Me.brandd.Visible = False
        Me.brandd.Width = 59
        '
        'item_code
        '
        Me.item_code.HeaderText = "item_code"
        Me.item_code.Name = "item_code"
        Me.item_code.ReadOnly = True
        Me.item_code.Visible = False
        Me.item_code.Width = 81
        '
        'LLBL_ADDITEM
        '
        Me.LLBL_ADDITEM.AutoSize = True
        Me.LLBL_ADDITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_ADDITEM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_ADDITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_ADDITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_ADDITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_ADDITEM.Location = New System.Drawing.Point(675, 27)
        Me.LLBL_ADDITEM.Name = "LLBL_ADDITEM"
        Me.LLBL_ADDITEM.Size = New System.Drawing.Size(77, 18)
        Me.LLBL_ADDITEM.TabIndex = 1444
        Me.LLBL_ADDITEM.TabStop = True
        Me.LLBL_ADDITEM.Text = "ADD ITEM"
        '
        'ShapeContainer7
        '
        Me.ShapeContainer7.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer7.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer7.Name = "ShapeContainer7"
        Me.ShapeContainer7.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_EDIT_ITEM, Me.RECT_REMOVE_ITEM, Me.RectangleShape13})
        Me.ShapeContainer7.Size = New System.Drawing.Size(762, 294)
        Me.ShapeContainer7.TabIndex = 1445
        Me.ShapeContainer7.TabStop = False
        '
        'RECT_EDIT_ITEM
        '
        Me.RECT_EDIT_ITEM.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_EDIT_ITEM.BorderWidth = 2
        Me.RECT_EDIT_ITEM.CornerRadius = 15
        Me.RECT_EDIT_ITEM.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_EDIT_ITEM.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_EDIT_ITEM.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_EDIT_ITEM.Location = New System.Drawing.Point(448, 1)
        Me.RECT_EDIT_ITEM.Name = "RECT_EDIT_ITEM"
        Me.RECT_EDIT_ITEM.Size = New System.Drawing.Size(84, 31)
        Me.RECT_EDIT_ITEM.Visible = False
        '
        'RECT_REMOVE_ITEM
        '
        Me.RECT_REMOVE_ITEM.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_REMOVE_ITEM.BorderWidth = 2
        Me.RECT_REMOVE_ITEM.CornerRadius = 15
        Me.RECT_REMOVE_ITEM.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_REMOVE_ITEM.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_REMOVE_ITEM.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_REMOVE_ITEM.Location = New System.Drawing.Point(535, 2)
        Me.RECT_REMOVE_ITEM.Name = "RECT_REMOVE_ITEM"
        Me.RECT_REMOVE_ITEM.Size = New System.Drawing.Size(122, 31)
        Me.RECT_REMOVE_ITEM.Visible = False
        '
        'RectangleShape13
        '
        Me.RectangleShape13.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape13.BorderWidth = 2
        Me.RectangleShape13.CornerRadius = 15
        Me.RectangleShape13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape13.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape13.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape13.Location = New System.Drawing.Point(659, 3)
        Me.RectangleShape13.Name = "RectangleShape13"
        Me.RectangleShape13.Size = New System.Drawing.Size(99, 31)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GRP_CONSUMABLE)
        Me.GroupBox3.Controls.Add(Me.CB_ITEM_USAGE)
        Me.GroupBox3.Controls.Add(Me.CB_ACQUISITION_VALUE)
        Me.GroupBox3.Controls.Add(Me.RBT_PURCHASED)
        Me.GroupBox3.Controls.Add(Me.RBT_DONATED)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.ShapeContainer6)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1054, 533)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(483, 240)
        Me.GroupBox3.TabIndex = 1442
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item Classification"
        '
        'GRP_CONSUMABLE
        '
        Me.GRP_CONSUMABLE.Controls.Add(Me.RBT_DEPLETED)
        Me.GRP_CONSUMABLE.Controls.Add(Me.RBT_PERPARTS)
        Me.GRP_CONSUMABLE.Location = New System.Drawing.Point(22, 185)
        Me.GRP_CONSUMABLE.Name = "GRP_CONSUMABLE"
        Me.GRP_CONSUMABLE.Size = New System.Drawing.Size(211, 41)
        Me.GRP_CONSUMABLE.TabIndex = 1466
        Me.GRP_CONSUMABLE.TabStop = False
        Me.GRP_CONSUMABLE.Visible = False
        '
        'RBT_DEPLETED
        '
        Me.RBT_DEPLETED.AutoSize = True
        Me.RBT_DEPLETED.Location = New System.Drawing.Point(14, 13)
        Me.RBT_DEPLETED.Name = "RBT_DEPLETED"
        Me.RBT_DEPLETED.Size = New System.Drawing.Size(85, 20)
        Me.RBT_DEPLETED.TabIndex = 1466
        Me.RBT_DEPLETED.TabStop = True
        Me.RBT_DEPLETED.Text = "Depleted"
        Me.RBT_DEPLETED.UseVisualStyleBackColor = True
        '
        'RBT_PERPARTS
        '
        Me.RBT_PERPARTS.AutoSize = True
        Me.RBT_PERPARTS.Location = New System.Drawing.Point(119, 13)
        Me.RBT_PERPARTS.Name = "RBT_PERPARTS"
        Me.RBT_PERPARTS.Size = New System.Drawing.Size(81, 20)
        Me.RBT_PERPARTS.TabIndex = 1467
        Me.RBT_PERPARTS.TabStop = True
        Me.RBT_PERPARTS.Text = "Per Parts"
        Me.RBT_PERPARTS.UseVisualStyleBackColor = True
        '
        'CB_ITEM_USAGE
        '
        Me.CB_ITEM_USAGE.DataSource = Me.TblM4INVENTORYACQUISITIONITEMUSAGEBindingSource
        Me.CB_ITEM_USAGE.DisplayMember = "USG_NAME"
        Me.CB_ITEM_USAGE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ITEM_USAGE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_ITEM_USAGE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_ITEM_USAGE.FormattingEnabled = True
        Me.CB_ITEM_USAGE.Location = New System.Drawing.Point(17, 147)
        Me.CB_ITEM_USAGE.Name = "CB_ITEM_USAGE"
        Me.CB_ITEM_USAGE.Size = New System.Drawing.Size(453, 27)
        Me.CB_ITEM_USAGE.TabIndex = 1458
        Me.CB_ITEM_USAGE.ValueMember = "USG_CODE"
        '
        'TblM4INVENTORYACQUISITIONITEMUSAGEBindingSource
        '
        Me.TblM4INVENTORYACQUISITIONITEMUSAGEBindingSource.DataMember = "tblM4_INVENTORY_ACQUISITION_ITEM_USAGE"
        Me.TblM4INVENTORYACQUISITIONITEMUSAGEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'CB_ACQUISITION_VALUE
        '
        Me.CB_ACQUISITION_VALUE.DataSource = Me.TblM4INVENTORYACQUISITIONVALUEBindingSource
        Me.CB_ACQUISITION_VALUE.DisplayMember = "ACQV_TITLE"
        Me.CB_ACQUISITION_VALUE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ACQUISITION_VALUE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_ACQUISITION_VALUE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_ACQUISITION_VALUE.FormattingEnabled = True
        Me.CB_ACQUISITION_VALUE.Location = New System.Drawing.Point(17, 49)
        Me.CB_ACQUISITION_VALUE.Name = "CB_ACQUISITION_VALUE"
        Me.CB_ACQUISITION_VALUE.Size = New System.Drawing.Size(453, 27)
        Me.CB_ACQUISITION_VALUE.TabIndex = 1457
        Me.CB_ACQUISITION_VALUE.ValueMember = "ACQV_CODE"
        '
        'TblM4INVENTORYACQUISITIONVALUEBindingSource
        '
        Me.TblM4INVENTORYACQUISITIONVALUEBindingSource.DataMember = "tblM4_INVENTORY_ACQUISITION_VALUE"
        Me.TblM4INVENTORYACQUISITIONVALUEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'RBT_PURCHASED
        '
        Me.RBT_PURCHASED.AutoSize = True
        Me.RBT_PURCHASED.Location = New System.Drawing.Point(43, 99)
        Me.RBT_PURCHASED.Name = "RBT_PURCHASED"
        Me.RBT_PURCHASED.Size = New System.Drawing.Size(94, 20)
        Me.RBT_PURCHASED.TabIndex = 1464
        Me.RBT_PURCHASED.TabStop = True
        Me.RBT_PURCHASED.Text = "Purchased"
        Me.RBT_PURCHASED.UseVisualStyleBackColor = True
        '
        'RBT_DONATED
        '
        Me.RBT_DONATED.AutoSize = True
        Me.RBT_DONATED.Location = New System.Drawing.Point(168, 99)
        Me.RBT_DONATED.Name = "RBT_DONATED"
        Me.RBT_DONATED.Size = New System.Drawing.Size(81, 20)
        Me.RBT_DONATED.TabIndex = 1465
        Me.RBT_DONATED.TabStop = True
        Me.RBT_DONATED.Text = "Donated"
        Me.RBT_DONATED.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(24, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 17)
        Me.Label15.TabIndex = 1457
        Me.Label15.Text = "Acquisition Type"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(24, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 17)
        Me.Label16.TabIndex = 1436
        Me.Label16.Text = "Acquisition Value"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(24, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 17)
        Me.Label17.TabIndex = 1434
        Me.Label17.Text = "Item Usage"
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape10, Me.RectangleShape11, Me.RectangleShape12})
        Me.ShapeContainer6.Size = New System.Drawing.Size(477, 218)
        Me.ShapeContainer6.TabIndex = 3
        Me.ShapeContainer6.TabStop = False
        '
        'RectangleShape10
        '
        Me.RectangleShape10.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape10.BorderWidth = 2
        Me.RectangleShape10.CornerRadius = 5
        Me.RectangleShape10.Location = New System.Drawing.Point(8, 75)
        Me.RectangleShape10.Name = "RectangleShape9"
        Me.RectangleShape10.Size = New System.Drawing.Size(268, 32)
        '
        'RectangleShape11
        '
        Me.RectangleShape11.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape11.BorderWidth = 2
        Me.RectangleShape11.CornerRadius = 5
        Me.RectangleShape11.Location = New System.Drawing.Point(8, 27)
        Me.RectangleShape11.Name = "RectangleShape8"
        Me.RectangleShape11.Size = New System.Drawing.Size(462, 32)
        '
        'RectangleShape12
        '
        Me.RectangleShape12.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape12.BorderWidth = 2
        Me.RectangleShape12.CornerRadius = 5
        Me.RectangleShape12.Location = New System.Drawing.Point(8, 125)
        Me.RectangleShape12.Name = "RectangleShape7"
        Me.RectangleShape12.Size = New System.Drawing.Size(462, 32)
        '
        'GRP_ACCOUNTABLE_UNIT_PERSON
        '
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Controls.Add(Me.WTXT_PROPERTY_USER)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Controls.Add(Me.WTXT_CUSTODIAN_NAME)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Controls.Add(Me.Label14)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Controls.Add(Me.Label13)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Controls.Add(Me.Label6)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Controls.Add(Me.CB_DIVISION_UNIT)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Controls.Add(Me.ShapeContainer5)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Location = New System.Drawing.Point(36, 41)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Name = "GRP_ACCOUNTABLE_UNIT_PERSON"
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Size = New System.Drawing.Size(745, 187)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.TabIndex = 1441
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.TabStop = False
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.Text = "Accountable Unit/Person"
        '
        'WTXT_PROPERTY_USER
        '
        Me.WTXT_PROPERTY_USER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PROPERTY_USER.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.WTXT_PROPERTY_USER.Location = New System.Drawing.Point(29, 148)
        Me.WTXT_PROPERTY_USER.MaxLength = 50
        Me.WTXT_PROPERTY_USER.Name = "WTXT_PROPERTY_USER"
        Me.WTXT_PROPERTY_USER.Size = New System.Drawing.Size(685, 21)
        Me.WTXT_PROPERTY_USER.TabIndex = 1464
        Me.WTXT_PROPERTY_USER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_PROPERTY_USER.Watermark = Nothing
        '
        'WTXT_CUSTODIAN_NAME
        '
        Me.WTXT_CUSTODIAN_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_CUSTODIAN_NAME.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.WTXT_CUSTODIAN_NAME.Location = New System.Drawing.Point(29, 99)
        Me.WTXT_CUSTODIAN_NAME.MaxLength = 50
        Me.WTXT_CUSTODIAN_NAME.Name = "WTXT_CUSTODIAN_NAME"
        Me.WTXT_CUSTODIAN_NAME.Size = New System.Drawing.Size(685, 21)
        Me.WTXT_CUSTODIAN_NAME.TabIndex = 1463
        Me.WTXT_CUSTODIAN_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_CUSTODIAN_NAME.Watermark = Nothing
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(36, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 17)
        Me.Label14.TabIndex = 1457
        Me.Label14.Text = "Property User"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(36, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 17)
        Me.Label13.TabIndex = 1436
        Me.Label13.Text = "Accountable Officer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(36, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 17)
        Me.Label6.TabIndex = 1434
        Me.Label6.Text = "Division/Unit"
        '
        'CB_DIVISION_UNIT
        '
        Me.CB_DIVISION_UNIT.DataSource = Me.TblV1HRISDIVISIONBindingSource
        Me.CB_DIVISION_UNIT.DisplayMember = "HDIV_DIVISION"
        Me.CB_DIVISION_UNIT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_DIVISION_UNIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_DIVISION_UNIT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_DIVISION_UNIT.FormattingEnabled = True
        Me.CB_DIVISION_UNIT.Location = New System.Drawing.Point(29, 47)
        Me.CB_DIVISION_UNIT.Name = "CB_DIVISION_UNIT"
        Me.CB_DIVISION_UNIT.Size = New System.Drawing.Size(526, 27)
        Me.CB_DIVISION_UNIT.TabIndex = 2
        Me.CB_DIVISION_UNIT.ValueMember = "HDIVS_CODE"
        '
        'TblV1HRISDIVISIONBindingSource
        '
        Me.TblV1HRISDIVISIONBindingSource.DataMember = "tblV1_HRISDIVISION"
        Me.TblV1HRISDIVISIONBindingSource.DataSource = Me.DS_TABLES
        '
        'DS_TABLES
        '
        Me.DS_TABLES.DataSetName = "DS_TABLES"
        Me.DS_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7})
        Me.ShapeContainer5.Size = New System.Drawing.Size(739, 165)
        Me.ShapeContainer5.TabIndex = 3
        Me.ShapeContainer5.TabStop = False
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape9.BorderWidth = 2
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.Location = New System.Drawing.Point(23, 123)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(691, 32)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape8.BorderWidth = 2
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.Location = New System.Drawing.Point(23, 74)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(690, 32)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape7.BorderWidth = 2
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(23, 25)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(531, 32)
        '
        'BTN_INVENTORY_CANCEL
        '
        Me.BTN_INVENTORY_CANCEL.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_CANCEL.FlatAppearance.BorderSize = 0
        Me.BTN_INVENTORY_CANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INVENTORY_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_CANCEL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INVENTORY_CANCEL.Image = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.BTN_INVENTORY_CANCEL.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BTN_INVENTORY_CANCEL.Location = New System.Drawing.Point(691, 553)
        Me.BTN_INVENTORY_CANCEL.Name = "BTN_INVENTORY_CANCEL"
        Me.BTN_INVENTORY_CANCEL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INVENTORY_CANCEL.Size = New System.Drawing.Size(104, 46)
        Me.BTN_INVENTORY_CANCEL.TabIndex = 1438
        Me.BTN_INVENTORY_CANCEL.Text = "CANCEL"
        Me.BTN_INVENTORY_CANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_CANCEL.UseVisualStyleBackColor = True
        '
        'BTN_INVENTORY_SAVE
        '
        Me.BTN_INVENTORY_SAVE.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_SAVE.FlatAppearance.BorderSize = 0
        Me.BTN_INVENTORY_SAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INVENTORY_SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_SAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INVENTORY_SAVE.Image = Global.PRA_PIS.My.Resources.Resources.outline_save_black_18dp
        Me.BTN_INVENTORY_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_INVENTORY_SAVE.Location = New System.Drawing.Point(579, 553)
        Me.BTN_INVENTORY_SAVE.Name = "BTN_INVENTORY_SAVE"
        Me.BTN_INVENTORY_SAVE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INVENTORY_SAVE.Size = New System.Drawing.Size(104, 46)
        Me.BTN_INVENTORY_SAVE.TabIndex = 1437
        Me.BTN_INVENTORY_SAVE.Text = "SAVE"
        Me.BTN_INVENTORY_SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_SAVE.UseVisualStyleBackColor = True
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel23.Controls.Add(Me.LLBL_INVENTORY_ENCODING_HEADER)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(30, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(780, 35)
        Me.Panel23.TabIndex = 1401
        '
        'LLBL_INVENTORY_ENCODING_HEADER
        '
        Me.LLBL_INVENTORY_ENCODING_HEADER.AutoSize = True
        Me.LLBL_INVENTORY_ENCODING_HEADER.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_INVENTORY_ENCODING_HEADER.ForeColor = System.Drawing.Color.White
        Me.LLBL_INVENTORY_ENCODING_HEADER.Location = New System.Drawing.Point(11, 4)
        Me.LLBL_INVENTORY_ENCODING_HEADER.Name = "LLBL_INVENTORY_ENCODING_HEADER"
        Me.LLBL_INVENTORY_ENCODING_HEADER.Size = New System.Drawing.Size(143, 25)
        Me.LLBL_INVENTORY_ENCODING_HEADER.TabIndex = 8
        Me.LLBL_INVENTORY_ENCODING_HEADER.Text = "I t e m  I n f o"
        '
        'BTN_CLOSE_INVENTORY_MINI_CLOSE
        '
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Location = New System.Drawing.Point(0, 0)
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Name = "BTN_CLOSE_INVENTORY_MINI_CLOSE"
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Size = New System.Drawing.Size(30, 612)
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.TabIndex = 0
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Text = ">>"
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.UseVisualStyleBackColor = True
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape6, Me.RectangleShape3})
        Me.ShapeContainer4.Size = New System.Drawing.Size(810, 612)
        Me.ShapeContainer4.TabIndex = 1440
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.CornerRadius = 5
        Me.RectangleShape6.Location = New System.Drawing.Point(690, 551)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(105, 49)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(578, 551)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(105, 49)
        '
        'LLBL_INVENOTYR_ASSIGN
        '
        Me.LLBL_INVENOTYR_ASSIGN.AutoSize = True
        Me.LLBL_INVENOTYR_ASSIGN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENOTYR_ASSIGN.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_INVENOTYR_ASSIGN.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENOTYR_ASSIGN.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENOTYR_ASSIGN.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENOTYR_ASSIGN.Location = New System.Drawing.Point(1000, 66)
        Me.LLBL_INVENOTYR_ASSIGN.Name = "LLBL_INVENOTYR_ASSIGN"
        Me.LLBL_INVENOTYR_ASSIGN.Size = New System.Drawing.Size(72, 19)
        Me.LLBL_INVENOTYR_ASSIGN.TabIndex = 1456
        Me.LLBL_INVENOTYR_ASSIGN.TabStop = True
        Me.LLBL_INVENOTYR_ASSIGN.Text = "ASSIGN"
        Me.LLBL_INVENOTYR_ASSIGN.Visible = False
        '
        'SpM4_ITEM_CODE_GENERATORTableAdapter
        '
        Me.SpM4_ITEM_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DS_CUSTOM
        '
        Me.DS_CUSTOM.DataSetName = "DS_CUSTOM"
        Me.DS_CUSTOM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DSCUSTOMBindingSource
        '
        Me.DSCUSTOMBindingSource.DataSource = Me.DS_CUSTOM
        Me.DSCUSTOMBindingSource.Position = 0
        '
        'TblV1_HRISDIVISIONTableAdapter
        '
        Me.TblV1_HRISDIVISIONTableAdapter.ClearBeforeFill = True
        '
        'TblV1_HRISEMPLOYEEDATATableAdapter
        '
        Me.TblV1_HRISEMPLOYEEDATATableAdapter.ClearBeforeFill = True
        '
        'SPM4CURRENTDATETIMEBindingSource
        '
        Me.SPM4CURRENTDATETIMEBindingSource.DataMember = "SPM4_CURRENTDATETIME"
        Me.SPM4CURRENTDATETIMEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'SPM4_CURRENTDATETIMETableAdapter
        '
        Me.SPM4_CURRENTDATETIMETableAdapter.ClearBeforeFill = True
        '
        'TBLG3_UNITSTableAdapter
        '
        Me.TBLG3_UNITSTableAdapter.ClearBeforeFill = True
        '
        'SPM4_INVENTORYDGVLISTTableAdapter
        '
        Me.SPM4_INVENTORYDGVLISTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_PROPERTY_NOTableAdapter
        '
        Me.SPM4_PROPERTY_NOTableAdapter.ClearBeforeFill = True
        '
        'TblG3_DELIVER_RECEIPT_DETAILSTableAdapter1
        '
        Me.TblG3_DELIVER_RECEIPT_DETAILSTableAdapter1.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_SUB_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMBRANDTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMSTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMSTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter
        '
        Me.TblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ACQUISITION_VALUETableAdapter
        '
        Me.TblM4_INVENTORY_ACQUISITION_VALUETableAdapter.ClearBeforeFill = True
        '
        'TblM4_CATEGORY_AND_SUBTableAdapter1
        '
        Me.TblM4_CATEGORY_AND_SUBTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBLG3_COMPANY_INFOTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_DELIVER_RECEIPT_DETAILSTableAdapter = Me.TblG3_DELIVER_RECEIPT_DETAILSTableAdapter1
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
        Me.TableAdapterManager.TBLG3_UNITSTableAdapter = Me.TBLG3_UNITSTableAdapter
        Me.TableAdapterManager.tblM4_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter = Me.TblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter = Me.TblM4_INVENTORY_ACQUISITION_VALUETableAdapter
        Me.TableAdapterManager.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Me.TblM4_INVENTORY_CATEGORYTableAdapter
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Me.TblM4_INVENTORY_ITEMBRANDTableAdapter
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMSTableAdapter = Me.TblM4_INVENTORY_ITEMSTableAdapter
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
        'TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter.ClearBeforeFill = True
        '
        'FRM_INVENTORY_ENCODING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(2288, 660)
        Me.Controls.Add(Me.LLBL_INVENOTYR_ASSIGN)
        Me.Controls.Add(Me.APNL_ITEMINFO)
        Me.Controls.Add(Me.PB_INVENTORY_VIEW_REPORT)
        Me.Controls.Add(Me.LLBL_INVENTORY_VIEW_REPORT)
        Me.Controls.Add(Me.LLBL_INVENTORY_EDIT)
        Me.Controls.Add(Me.PB_INVENTORY_EDIT)
        Me.Controls.Add(Me.PB_INVENTORY_NEW)
        Me.Controls.Add(Me.LLBL_INVENTORY_NEW)
        Me.Controls.Add(Me.PB_INVENTORY_SAVE)
        Me.Controls.Add(Me.LLBL_INVENTORY_SAVE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.ShapeContainer3)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FRM_INVENTORY_ENCODING"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "       "
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.GRP_ITEMINFO.ResumeLayout(False)
        Me.GRP_ITEMINFO.PerformLayout()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBOX_SETTINGS.ResumeLayout(False)
        Me.GBOX_SETTINGS.PerformLayout()
        CType(Me.DGV_INVENTORY_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4INVENTORYDGVLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShapeContainer3.ResumeLayout(False)
        CType(Me.TblM4_INVENTORY_ITEMSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMS_PROPERTYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMS_PROPERTYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_NEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_EDIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_VIEW_REPORT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APNL_ITEMINFO.ResumeLayout(False)
        Me.GRP_LIST_ITEMS.ResumeLayout(False)
        Me.GRP_LIST_ITEMS.PerformLayout()
        CType(Me.DGV_ITEM_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GRP_CONSUMABLE.ResumeLayout(False)
        Me.GRP_CONSUMABLE.PerformLayout()
        CType(Me.TblM4INVENTORYACQUISITIONITEMUSAGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYACQUISITIONVALUEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.ResumeLayout(False)
        Me.GRP_ACCOUNTABLE_UNIT_PERSON.PerformLayout()
        CType(Me.TblV1HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        CType(Me.TblM4INVENTORYACQUISITIONTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCUSTOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents GRP_ITEMINFO As GroupBox
    Friend WithEvents WTXT_INVENTORY_ITEM_DESCRIPTION As WatermarkTextBox
    Friend WithEvents WTXT_INVENTORY_DATE_OF_ACQUISITION As WatermarkTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PBOX_PRNOQRCODE As PictureBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRAPPCODE As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRREQUESTEDDATE As PowerPacks.RectangleShape
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_INVENTORY_LIST As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RECT_INVENTORY_SERIAL_NO As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RECT_INVENTORY_TOTAL_COST As PowerPacks.RectangleShape
    Friend WithEvents RECT_INVENTORY_UNIT_COST As PowerPacks.RectangleShape
    Friend WithEvents RECT_INVENTORY_QUANTITY As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents Label11 As Label
    Friend WithEvents RECT_INVENTORY_ITEM_DESCRIPTION As PowerPacks.RectangleShape
    Friend WithEvents WTXT_INVENTORY_TOTAL_COST As WatermarkTextBox
    Friend WithEvents WTXT_INVENTORY_UNITCOST As WatermarkTextBox
    Friend WithEvents WTXT_INVENTORY_QUANTITY As WatermarkTextBox
    Friend WithEvents WTXT_INVENTORY_SERIAL_NO As WatermarkTextBox
    Friend WithEvents GBOX_SETTINGS As GroupBox
    Friend WithEvents LLBL_RECORDSFOUND As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CB_INVENTORY_BRAND_NAME As ComboBox
    Friend WithEvents CB_INVENTORY_SUBCATEGORY As ComboBox
    Friend WithEvents CB_INVENTORY_CATEGORY As ComboBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents WTXT_INVENTORY_SEARCH As WatermarkTextBox
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents PB_INVENTORY_CLEAR_SEARCH As PictureBox
    Friend WithEvents CB_INVENTORY_UNIT_TYPE As ComboBox
    Friend WithEvents RECT_INVENTORY_NEW_SAVE As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents LLBL_INVENTORY_SAVE As LinkLabel
    Friend WithEvents PB_INVENTORY_SAVE As PictureBox
    Friend WithEvents LLBL_INVENTORY_NEW As LinkLabel
    Friend WithEvents PB_INVENTORY_NEW As PictureBox
    Friend WithEvents LLBL_INVENTORY_EDIT As LinkLabel
    Friend WithEvents PB_INVENTORY_EDIT As PictureBox
    Friend WithEvents RECT_INVENTORY_EDIT As PowerPacks.RectangleShape
    Friend WithEvents PB_INVENTORY_VIEW_REPORT As PictureBox
    Friend WithEvents LLBL_INVENTORY_VIEW_REPORT As LinkLabel
    Friend WithEvents RECT_INVENTORY_CANCEL As PowerPacks.RectangleShape
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    '  Friend WithEvents TblM4_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_CATEGORYTableAdapter
    Friend WithEvents SPM4CURRENTDATETIMEBindingSource As BindingSource
    Friend WithEvents SPM4_CURRENTDATETIMETableAdapter As DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter
    '   Friend WithEvents TblM4_ITEMBRANDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_ITEMBRANDTableAdapter
    Friend WithEvents TBLG3UNITSBindingSource As BindingSource
    Friend WithEvents TBLG3_UNITSTableAdapter As DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter
    'Friend WithEvents TblM4_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_ITEMSTableAdapter
    Friend WithEvents Label12 As Label
    Friend WithEvents APNL_ITEMINFO As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents LLBL_INVENTORY_ENCODING_HEADER As Label
    Friend WithEvents BTN_CLOSE_INVENTORY_MINI_CLOSE As Button
    Friend WithEvents BTN_INVENTORY_CANCEL As Button
    Friend WithEvents BTN_INVENTORY_SAVE As Button
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents BTN_ADD_CATEGORY As Button
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents SPM4_INVENTORYDGVLISTTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_INVENTORYDGVLISTTableAdapter
    Friend WithEvents SPM4INVENTORYDGVLISTBindingSource As BindingSource
    Friend WithEvents SPM4_PROPERTY_NOTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_PROPERTY_NOTableAdapter
    Friend WithEvents BTN_ADD_UNITTYPE As Button
    Friend WithEvents BTN_ADD_BRAND_PROVIDER As Button
    Friend WithEvents BTN_ADD_SUBCATEGORY As Button
    Friend WithEvents BTN_INVENTORY_MINIMIZE As Button
    Friend WithEvents BTN_INVENTORY_CLOSE As Button
    Friend WithEvents LLBL_INVENOTYR_ASSIGN As LinkLabel
    Friend WithEvents TblG3_DELIVER_RECEIPT_DETAILSTableAdapter1 As DS_PROPERTYDBTableAdapters.TBLG3_DELIVER_RECEIPT_DETAILSTableAdapter
    Friend WithEvents ITEMPROPERTYNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUNITCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMTOTALCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TblM4INVENTORYCATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter
    Friend WithEvents TblM4INVENTORYSUBCATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_SUB_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter
    Friend WithEvents TblM4INVENTORYITEMBRANDBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMBRANDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter
    Friend WithEvents TblM4_INVENTORY_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter
    Friend WithEvents SpM4_ITEM_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_CODE_GENERATORTableAdapter
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents GRP_ACCOUNTABLE_UNIT_PERSON As GroupBox
    Friend WithEvents CB_DIVISION_UNIT As ComboBox
    Friend WithEvents ShapeContainer5 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents Label6 As Label
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_PROPERTY_USER As WatermarkTextBox
    Friend WithEvents WTXT_CUSTODIAN_NAME As WatermarkTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ShapeContainer6 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape11 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape12 As PowerPacks.RectangleShape
    Friend WithEvents RBT_DONATED As RadioButton
    Friend WithEvents RBT_PURCHASED As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents RectangleShape10 As PowerPacks.RectangleShape
    Friend WithEvents CB_ACQUISITION_VALUE As ComboBox
    Friend WithEvents DS_CUSTOM As DS_CUSTOM
    Friend WithEvents DSCUSTOMBindingSource As BindingSource
    Friend WithEvents TblM4INVENTORYACQUISITIONTYPEBindingSource As BindingSource
    Friend WithEvents CB_ITEM_USAGE As ComboBox
    Friend WithEvents TblM4INVENTORYACQUISITIONITEMUSAGEBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter
    Friend WithEvents GRP_CONSUMABLE As GroupBox
    Friend WithEvents RBT_DEPLETED As RadioButton
    Friend WithEvents RBT_PERPARTS As RadioButton
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TblV1HRISDIVISIONBindingSource As BindingSource
    Friend WithEvents TblV1_HRISDIVISIONTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter
    Friend WithEvents TblM4INVENTORYACQUISITIONVALUEBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ACQUISITION_VALUETableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter
    Friend WithEvents TblM4_CATEGORY_AND_SUBTableAdapter1 As DS_PROPERTYDBTableAdapters.tblM4_CATEGORY_AND_SUBTableAdapter
    Friend WithEvents TblM4_INVENTORY_ITEMS_PROPERTYBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter
    Friend WithEvents TblM4_INVENTORY_ITEMS_PROPERTYDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DGV_ITEM_INFO As DataGridView
    Friend WithEvents LLBL_ADDITEM As LinkLabel
    Friend WithEvents RectangleShape13 As PowerPacks.RectangleShape
    Friend WithEvents LLBL_SAVE_ADD_ITEM As LinkLabel
    Friend WithEvents RectangleShape14 As PowerPacks.RectangleShape
    Friend WithEvents LLBL_CLOSE As LinkLabel
    Friend WithEvents RectangleShape15 As PowerPacks.RectangleShape
    Friend WithEvents GRP_LIST_ITEMS As GroupBox
    Friend WithEvents ShapeContainer7 As PowerPacks.ShapeContainer
    Friend WithEvents LLBL_REMOVE_ITEM As LinkLabel
    Friend WithEvents RECT_REMOVE_ITEM As PowerPacks.RectangleShape
    Friend WithEvents TblM4_INVENTORY_ITEMSDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents TblM4_INVENTORY_ITEMSBindingSource As BindingSource
    Friend WithEvents dateacquisition As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents subcategory As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents serialproduct As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents unitcost As DataGridViewTextBoxColumn
    Friend WithEvents totalcost As DataGridViewTextBoxColumn
    Friend WithEvents itemdescription As DataGridViewTextBoxColumn
    Friend WithEvents subcat As DataGridViewTextBoxColumn
    Friend WithEvents brandd As DataGridViewTextBoxColumn
    Friend WithEvents item_code As DataGridViewTextBoxColumn
    Friend WithEvents TblV1_HRISEMPLOYEEDATATableAdapter As DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter
    Friend WithEvents LLBL_EDIT_ITEM As LinkLabel
    Friend WithEvents RECT_EDIT_ITEM As PowerPacks.RectangleShape
    Friend WithEvents CATNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents SCSUBCATEGORYNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SCNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITBRNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITBRNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMSERIALNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUNITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMQUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_UNIT_COST As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_TOTAL_COST As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDATEAQUISITIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCREATEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUPDATEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOC_LOCATION_ID As DataGridViewTextBoxColumn
End Class
