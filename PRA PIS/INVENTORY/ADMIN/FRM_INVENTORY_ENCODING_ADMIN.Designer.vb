<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_INVENTORY_ENCODING_ADMIN

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
        Me.CB_SUPPLY_TYPE = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.CB_INVENTORY_BRAND_NAME = New System.Windows.Forms.ComboBox()
        Me.CB_INVENTORY_SUBCATEGORY = New System.Windows.Forms.ComboBox()
        Me.CB_INVENTORY_CATEGORY = New System.Windows.Forms.ComboBox()
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
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape15 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRREQUESTEDDATE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_ITEM_DESCRIPTION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_TOTAL_COST = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_UNIT_COST = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_QUANTITY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_SERIAL_NO = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_SUB_CATEGORY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_BRAND = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_CATEGORY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LLBL_INVENTORY_VIEW_REPORT = New System.Windows.Forms.LinkLabel()
        Me.PB_INVENTORY_VIEW_REPORT = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_CLEAR_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_ITEM_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.GBOX_SETTINGS = New System.Windows.Forms.GroupBox()
        Me.LLBL_RECORDSFOUND = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DGV_INV_ITEM_LIST = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ITEMCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITBRNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITBRNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLDESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMSERIALNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLRNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLRNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISACTIVEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SIZENUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIZENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREATEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISACTIVESIZEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LENG_NUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTHER_NUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITM_NAME_NUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITM_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAME_IS_ACTIVE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IMG_PATH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.VWM4_ITEM_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_NEW_SAVE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_INVENTORY_EDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_STOCKS = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ITEM_DISTRIBUTION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_CANCEL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LLBL_INVENTORY_NEW = New System.Windows.Forms.LinkLabel()
        Me.PB_INVENTORY_NEW = New System.Windows.Forms.PictureBox()
        Me.LLBL_INVENTORY_EDIT = New System.Windows.Forms.LinkLabel()
        Me.PB_INVENTORY_EDIT = New System.Windows.Forms.PictureBox()
        Me.APNL_ITEMINFO = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PB_ITEM_IMAGE = New System.Windows.Forms.PictureBox()
        Me.WTXT_INV_ALIAS_NAME = New PRA_PIS.WatermarkTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BTN_INV_NAME = New System.Windows.Forms.Button()
        Me.CB_INV_NAME = New System.Windows.Forms.ComboBox()
        Me.TBLM4INVITEMSNAMEMAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CB_INV_OTHER_DESC = New System.Windows.Forms.ComboBox()
        Me.TBLM4INVITEMSOTHERSMAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_INV_LENGTH = New System.Windows.Forms.ComboBox()
        Me.TBLM4INVITEMSLENGMAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_INV_OTHER_DESC = New System.Windows.Forms.Button()
        Me.BTN_INV_LENGTH = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CB_INV_SC = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYSUBCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_INV_COLOR = New System.Windows.Forms.ComboBox()
        Me.TBLM4INVITEMSCOLORMAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_INV_COLOR = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BTN_INV_SIZE = New System.Windows.Forms.Button()
        Me.CB_INV_SIZE = New System.Windows.Forms.ComboBox()
        Me.TBLM4INVITEMSSIZEMAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_INV_BRAND = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYITEMBRANDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_INV_BR = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.BTN_INV_SC = New System.Windows.Forms.Button()
        Me.BTN_INV_CAT = New System.Windows.Forms.Button()
        Me.CB_INV_CAT = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape21 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape20 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape19 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape18 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape17 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape16 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape24 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GRP_CONSUMABLE = New System.Windows.Forms.GroupBox()
        Me.RBT_DEPLETED = New System.Windows.Forms.RadioButton()
        Me.RBT_PERPARTS = New System.Windows.Forms.RadioButton()
        Me.CB_ITEM_USAGE = New System.Windows.Forms.ComboBox()
        Me.CB_ACQUISITION_VALUE = New System.Windows.Forms.ComboBox()
        Me.RBT_PURCHASED = New System.Windows.Forms.RadioButton()
        Me.RBT_DONATED = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_INVENTORY_SAVE = New System.Windows.Forms.Button()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.LLBL_INVENTORY_ENCODING_HEADER = New System.Windows.Forms.Label()
        Me.BTN_INVENTORY_CANCEL = New System.Windows.Forms.Button()
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE = New System.Windows.Forms.Button()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GRP_LIST_ITEMS = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.LLBL_INVENOTYR_ASSIGN = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.ShapeContainer9 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape28 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape29 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape30 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ShapeContainer10 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape31 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape32 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LLBL_ITEM_DISTRIBUTION = New System.Windows.Forms.LinkLabel()
        Me.PB_ITEM_DISTRIBUTION = New System.Windows.Forms.PictureBox()
        Me.TblM4_INVENTORY_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter()
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter()
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter()
        Me.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter()
        Me.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter()
        Me.SPM4_ITEM_CODE_GENERATORTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_CODE_GENERATORTableAdapter()
        Me.SPM4_ITEM_CODE_GENERATORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.TableAdapterManager = New PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager()
        Me.TBLM4_INV_ITEMS_SIZETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_SIZETableAdapter()
        Me.TBLM4_INV_ITEMS_SIZEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_COLORTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_COLORTableAdapter()
        Me.TBLM4_INV_ITEMS_COLORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PB_STOCKS = New System.Windows.Forms.PictureBox()
        Me.LLBL_STOCKS = New System.Windows.Forms.LinkLabel()
        Me.TBLM4_INV_ITEMS_LENG_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_LENG_MAINTableAdapter()
        Me.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter()
        Me.TBLM4_INV_ITEMS_LENGTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_LENGTableAdapter()
        Me.TBLM4_INV_ITEMS_LENGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_OTHERSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_OTHERSTableAdapter()
        Me.TBLM4_INV_ITEMS_OTHERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_NAME_MAINTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_NAME_MAINTableAdapter()
        Me.TBLM4_INV_ITEMS_NAMETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_NAMETableAdapter()
        Me.TBLM4_INV_ITEMS_NAMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMSTableAdapter()
        Me.TBLM4_INV_ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VWM4_ITEM_LISTTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter()
        Me.RECT_DR_LIST = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_IIL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LLBL_PCOUNT = New System.Windows.Forms.LinkLabel()
        Me.PB_PCOUNT = New System.Windows.Forms.PictureBox()
        Me.PB_IIL = New System.Windows.Forms.PictureBox()
        Me.LLBL_IIL = New System.Windows.Forms.LinkLabel()
        Me.PB_DR_LIST = New System.Windows.Forms.PictureBox()
        Me.LLBL_DR_LIST = New System.Windows.Forms.LinkLabel()
        Me.ShapeContainer8 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PCOUNT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.OFD_ITEM_DESC = New System.Windows.Forms.OpenFileDialog()
        Me.TBLM4_INV_ITEMS_IMGTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_IMGTableAdapter()
        Me.TBLM4_INV_ITEMS_IMGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PNL.SuspendLayout()
        Me.GRP_ITEMINFO.SuspendLayout()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PB_INVENTORY_VIEW_REPORT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBOX_SETTINGS.SuspendLayout()
        CType(Me.DGV_INV_ITEM_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_NEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_EDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APNL_ITEMINFO.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PB_ITEM_IMAGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVITEMSNAMEMAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVITEMSOTHERSMAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVITEMSLENGMAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVITEMSCOLORMAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVITEMSSIZEMAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GRP_CONSUMABLE.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.GRP_LIST_ITEMS.SuspendLayout()
        CType(Me.DGV_ITEM_INFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ITEM_DISTRIBUTION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_SIZEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_COLORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_STOCKS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_LENGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_OTHERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_NAMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PB_PCOUNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_IIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_DR_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_IMGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PNL.Size = New System.Drawing.Size(1095, 49)
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
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(257, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "S u p p l i e s  I n v e n t o r y"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-9370, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-9323, 10)
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
        Me.GRP_ITEMINFO.Controls.Add(Me.CB_SUPPLY_TYPE)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label6)
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
        Me.GRP_ITEMINFO.Location = New System.Drawing.Point(34, 549)
        Me.GRP_ITEMINFO.Name = "GRP_ITEMINFO"
        Me.GRP_ITEMINFO.Size = New System.Drawing.Size(530, 503)
        Me.GRP_ITEMINFO.TabIndex = 1406
        Me.GRP_ITEMINFO.TabStop = False
        Me.GRP_ITEMINFO.Text = "Item Details"
        '
        'CB_SUPPLY_TYPE
        '
        Me.CB_SUPPLY_TYPE.DisplayMember = "INV_CODE"
        Me.CB_SUPPLY_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SUPPLY_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_SUPPLY_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_SUPPLY_TYPE.FormattingEnabled = True
        Me.CB_SUPPLY_TYPE.Location = New System.Drawing.Point(13, 31)
        Me.CB_SUPPLY_TYPE.Name = "CB_SUPPLY_TYPE"
        Me.CB_SUPPLY_TYPE.Size = New System.Drawing.Size(500, 27)
        Me.CB_SUPPLY_TYPE.TabIndex = 1463
        Me.CB_SUPPLY_TYPE.ValueMember = "INV_CODE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(18, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 1463
        Me.Label6.Text = "Supply Type"
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
        Me.BTN_ADD_UNITTYPE.Location = New System.Drawing.Point(490, 230)
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
        Me.BTN_ADD_BRAND_PROVIDER.Location = New System.Drawing.Point(406, 183)
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
        Me.BTN_ADD_SUBCATEGORY.Location = New System.Drawing.Point(406, 132)
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
        Me.WTXT_INVENTORY_DATE_OF_ACQUISITION.Location = New System.Drawing.Point(380, 85)
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
        Me.WTXT_INVENTORY_UNITCOST.Location = New System.Drawing.Point(117, 285)
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
        Me.Label5.Location = New System.Drawing.Point(385, 64)
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
        Me.BTN_ADD_CATEGORY.Location = New System.Drawing.Point(347, 80)
        Me.BTN_ADD_CATEGORY.Name = "BTN_ADD_CATEGORY"
        Me.BTN_ADD_CATEGORY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ADD_CATEGORY.Size = New System.Drawing.Size(24, 24)
        Me.BTN_ADD_CATEGORY.TabIndex = 1457
        Me.BTN_ADD_CATEGORY.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_ADD_CATEGORY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ADD_CATEGORY.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(500, 331)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 19)
        Me.Label12.TabIndex = 1455
        Me.Label12.Text = "*"
        '
        'CB_INVENTORY_UNIT_TYPE
        '
        Me.CB_INVENTORY_UNIT_TYPE.DisplayMember = "UN_NO"
        Me.CB_INVENTORY_UNIT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_UNIT_TYPE.Enabled = False
        Me.CB_INVENTORY_UNIT_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_UNIT_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_UNIT_TYPE.FormattingEnabled = True
        Me.CB_INVENTORY_UNIT_TYPE.Location = New System.Drawing.Point(346, 228)
        Me.CB_INVENTORY_UNIT_TYPE.Name = "CB_INVENTORY_UNIT_TYPE"
        Me.CB_INVENTORY_UNIT_TYPE.Size = New System.Drawing.Size(137, 27)
        Me.CB_INVENTORY_UNIT_TYPE.TabIndex = 4
        Me.CB_INVENTORY_UNIT_TYPE.ValueMember = "UN_NO"
        '
        'CB_INVENTORY_BRAND_NAME
        '
        Me.CB_INVENTORY_BRAND_NAME.DisplayMember = "ITBR_NO"
        Me.CB_INVENTORY_BRAND_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_BRAND_NAME.Enabled = False
        Me.CB_INVENTORY_BRAND_NAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_BRAND_NAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_BRAND_NAME.FormattingEnabled = True
        Me.CB_INVENTORY_BRAND_NAME.Location = New System.Drawing.Point(11, 179)
        Me.CB_INVENTORY_BRAND_NAME.Name = "CB_INVENTORY_BRAND_NAME"
        Me.CB_INVENTORY_BRAND_NAME.Size = New System.Drawing.Size(389, 27)
        Me.CB_INVENTORY_BRAND_NAME.TabIndex = 2
        Me.CB_INVENTORY_BRAND_NAME.ValueMember = "ITBR_NO"
        '
        'CB_INVENTORY_SUBCATEGORY
        '
        Me.CB_INVENTORY_SUBCATEGORY.DisplayMember = "SC_NO"
        Me.CB_INVENTORY_SUBCATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_SUBCATEGORY.Enabled = False
        Me.CB_INVENTORY_SUBCATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_SUBCATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_SUBCATEGORY.FormattingEnabled = True
        Me.CB_INVENTORY_SUBCATEGORY.Location = New System.Drawing.Point(11, 129)
        Me.CB_INVENTORY_SUBCATEGORY.Name = "CB_INVENTORY_SUBCATEGORY"
        Me.CB_INVENTORY_SUBCATEGORY.Size = New System.Drawing.Size(389, 27)
        Me.CB_INVENTORY_SUBCATEGORY.TabIndex = 1
        Me.CB_INVENTORY_SUBCATEGORY.ValueMember = "SC_NO"
        '
        'CB_INVENTORY_CATEGORY
        '
        Me.CB_INVENTORY_CATEGORY.DisplayMember = "CAT_CODE"
        Me.CB_INVENTORY_CATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_CATEGORY.Enabled = False
        Me.CB_INVENTORY_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_CATEGORY.FormattingEnabled = True
        Me.CB_INVENTORY_CATEGORY.Location = New System.Drawing.Point(12, 78)
        Me.CB_INVENTORY_CATEGORY.Name = "CB_INVENTORY_CATEGORY"
        Me.CB_INVENTORY_CATEGORY.Size = New System.Drawing.Size(329, 27)
        Me.CB_INVENTORY_CATEGORY.TabIndex = 0
        Me.CB_INVENTORY_CATEGORY.ValueMember = "CAT_CODE"
        '
        'WTXT_INVENTORY_ITEM_DESCRIPTION
        '
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Enabled = False
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Location = New System.Drawing.Point(11, 332)
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.MaxLength = 120
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Multiline = True
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Name = "WTXT_INVENTORY_ITEM_DESCRIPTION"
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Size = New System.Drawing.Size(505, 156)
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.TabIndex = 7
        Me.WTXT_INVENTORY_ITEM_DESCRIPTION.Watermark = Nothing
        '
        'WTXT_INVENTORY_TOTAL_COST
        '
        Me.WTXT_INVENTORY_TOTAL_COST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_TOTAL_COST.Enabled = False
        Me.WTXT_INVENTORY_TOTAL_COST.Location = New System.Drawing.Point(344, 285)
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
        Me.WTXT_INVENTORY_QUANTITY.Location = New System.Drawing.Point(11, 285)
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
        Me.WTXT_INVENTORY_SERIAL_NO.Location = New System.Drawing.Point(11, 233)
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
        Me.Label11.Location = New System.Drawing.Point(18, 312)
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
        Me.Label10.Location = New System.Drawing.Point(352, 261)
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
        Me.Label9.Location = New System.Drawing.Point(130, 261)
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
        Me.Label7.Location = New System.Drawing.Point(18, 261)
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
        Me.Label4.Location = New System.Drawing.Point(351, 212)
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
        Me.Label3.Location = New System.Drawing.Point(18, 112)
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
        Me.Label2.Location = New System.Drawing.Point(18, 162)
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
        Me.Label1.Location = New System.Drawing.Point(18, 62)
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
        Me.Label8.Location = New System.Drawing.Point(18, 212)
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
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape9, Me.RectangleShape15, Me.RectangleShape14, Me.RECT_PRREQUESTEDDATE, Me.RECT_INVENTORY_ITEM_DESCRIPTION, Me.RECT_INVENTORY_TOTAL_COST, Me.RECT_INVENTORY_UNIT_COST, Me.RECT_INVENTORY_QUANTITY, Me.RectangleShape4, Me.RECT_INVENTORY_SERIAL_NO, Me.RECT_SUB_CATEGORY, Me.RECT_BRAND, Me.RECT_CATEGORY})
        Me.ShapeContainer2.Size = New System.Drawing.Size(524, 481)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape9.BorderWidth = 2
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.Location = New System.Drawing.Point(3, 9)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(511, 32)
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
        'RECT_PRREQUESTEDDATE
        '
        Me.RECT_PRREQUESTEDDATE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRREQUESTEDDATE.BorderWidth = 2
        Me.RECT_PRREQUESTEDDATE.CornerRadius = 5
        Me.RECT_PRREQUESTEDDATE.Location = New System.Drawing.Point(372, 56)
        Me.RECT_PRREQUESTEDDATE.Name = "RECT_PRREQUESTEDDATE"
        Me.RECT_PRREQUESTEDDATE.Size = New System.Drawing.Size(142, 33)
        '
        'RECT_INVENTORY_ITEM_DESCRIPTION
        '
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.BorderWidth = 2
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.CornerRadius = 5
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.Location = New System.Drawing.Point(3, 307)
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.Name = "RECT_INVENTORY_ITEM_DESCRIPTION"
        Me.RECT_INVENTORY_ITEM_DESCRIPTION.Size = New System.Drawing.Size(514, 165)
        '
        'RECT_INVENTORY_TOTAL_COST
        '
        Me.RECT_INVENTORY_TOTAL_COST.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_TOTAL_COST.BorderWidth = 2
        Me.RECT_INVENTORY_TOTAL_COST.CornerRadius = 5
        Me.RECT_INVENTORY_TOTAL_COST.Location = New System.Drawing.Point(336, 256)
        Me.RECT_INVENTORY_TOTAL_COST.Name = "RECT_INVENTORY_TOTAL_COST"
        Me.RECT_INVENTORY_TOTAL_COST.Size = New System.Drawing.Size(180, 32)
        '
        'RECT_INVENTORY_UNIT_COST
        '
        Me.RECT_INVENTORY_UNIT_COST.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_UNIT_COST.BorderWidth = 2
        Me.RECT_INVENTORY_UNIT_COST.CornerRadius = 5
        Me.RECT_INVENTORY_UNIT_COST.Location = New System.Drawing.Point(109, 256)
        Me.RECT_INVENTORY_UNIT_COST.Name = "RECT_INVENTORY_UNIT_COST"
        Me.RECT_INVENTORY_UNIT_COST.Size = New System.Drawing.Size(225, 32)
        '
        'RECT_INVENTORY_QUANTITY
        '
        Me.RECT_INVENTORY_QUANTITY.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_QUANTITY.BorderWidth = 2
        Me.RECT_INVENTORY_QUANTITY.CornerRadius = 5
        Me.RECT_INVENTORY_QUANTITY.Location = New System.Drawing.Point(3, 256)
        Me.RECT_INVENTORY_QUANTITY.Name = "RECT_INVENTORY_QUANTITY"
        Me.RECT_INVENTORY_QUANTITY.Size = New System.Drawing.Size(104, 32)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(339, 206)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(145, 32)
        '
        'RECT_INVENTORY_SERIAL_NO
        '
        Me.RECT_INVENTORY_SERIAL_NO.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_SERIAL_NO.BorderWidth = 2
        Me.RECT_INVENTORY_SERIAL_NO.CornerRadius = 5
        Me.RECT_INVENTORY_SERIAL_NO.Location = New System.Drawing.Point(3, 206)
        Me.RECT_INVENTORY_SERIAL_NO.Name = "RECT_INVENTORY_SERIAL_NO"
        Me.RECT_INVENTORY_SERIAL_NO.Size = New System.Drawing.Size(334, 32)
        '
        'RECT_SUB_CATEGORY
        '
        Me.RECT_SUB_CATEGORY.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_SUB_CATEGORY.BorderWidth = 2
        Me.RECT_SUB_CATEGORY.CornerRadius = 5
        Me.RECT_SUB_CATEGORY.Location = New System.Drawing.Point(3, 107)
        Me.RECT_SUB_CATEGORY.Name = "RECT_SUB_CATEGORY"
        Me.RECT_SUB_CATEGORY.Size = New System.Drawing.Size(397, 32)
        '
        'RECT_BRAND
        '
        Me.RECT_BRAND.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_BRAND.BorderWidth = 2
        Me.RECT_BRAND.CornerRadius = 5
        Me.RECT_BRAND.Location = New System.Drawing.Point(3, 156)
        Me.RECT_BRAND.Name = "RECT_BRAND"
        Me.RECT_BRAND.Size = New System.Drawing.Size(397, 33)
        '
        'RECT_CATEGORY
        '
        Me.RECT_CATEGORY.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_CATEGORY.BorderWidth = 2
        Me.RECT_CATEGORY.CornerRadius = 5
        Me.RECT_CATEGORY.Location = New System.Drawing.Point(3, 56)
        Me.RECT_CATEGORY.Name = "RECT_CATEGORY"
        Me.RECT_CATEGORY.Size = New System.Drawing.Size(339, 32)
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.EnforceConstraints = False
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.LLBL_INVENTORY_VIEW_REPORT)
        Me.GroupBox1.Controls.Add(Me.PB_INVENTORY_VIEW_REPORT)
        Me.GroupBox1.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.GroupBox1.Controls.Add(Me.PB_INVENTORY_CLEAR_SEARCH)
        Me.GroupBox1.Controls.Add(Me.WTXT_ITEM_SEARCH)
        Me.GroupBox1.Controls.Add(Me.GBOX_SETTINGS)
        Me.GroupBox1.Controls.Add(Me.DGV_INV_ITEM_LIST)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(10, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 541)
        Me.GroupBox1.TabIndex = 1407
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item List"
        '
        'LLBL_INVENTORY_VIEW_REPORT
        '
        Me.LLBL_INVENTORY_VIEW_REPORT.AutoSize = True
        Me.LLBL_INVENTORY_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENTORY_VIEW_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_INVENTORY_VIEW_REPORT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_VIEW_REPORT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENTORY_VIEW_REPORT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_VIEW_REPORT.Location = New System.Drawing.Point(945, 506)
        Me.LLBL_INVENTORY_VIEW_REPORT.Name = "LLBL_INVENTORY_VIEW_REPORT"
        Me.LLBL_INVENTORY_VIEW_REPORT.Size = New System.Drawing.Size(115, 19)
        Me.LLBL_INVENTORY_VIEW_REPORT.TabIndex = 1453
        Me.LLBL_INVENTORY_VIEW_REPORT.TabStop = True
        Me.LLBL_INVENTORY_VIEW_REPORT.Text = "VIEW REPORT"
        '
        'PB_INVENTORY_VIEW_REPORT
        '
        Me.PB_INVENTORY_VIEW_REPORT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.PB_INVENTORY_VIEW_REPORT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_VIEW_REPORT.InitialImage = Nothing
        Me.PB_INVENTORY_VIEW_REPORT.Location = New System.Drawing.Point(907, 502)
        Me.PB_INVENTORY_VIEW_REPORT.Name = "PB_INVENTORY_VIEW_REPORT"
        Me.PB_INVENTORY_VIEW_REPORT.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_VIEW_REPORT.TabIndex = 1454
        Me.PB_INVENTORY_VIEW_REPORT.TabStop = False
        '
        'PB_INVENTORY_SEARCH
        '
        Me.PB_INVENTORY_SEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PB_INVENTORY_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_SEARCH.Location = New System.Drawing.Point(13, 25)
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
        Me.PB_INVENTORY_CLEAR_SEARCH.Location = New System.Drawing.Point(1028, 25)
        Me.PB_INVENTORY_CLEAR_SEARCH.Name = "PB_INVENTORY_CLEAR_SEARCH"
        Me.PB_INVENTORY_CLEAR_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_CLEAR_SEARCH.TabIndex = 1440
        Me.PB_INVENTORY_CLEAR_SEARCH.TabStop = False
        Me.PB_INVENTORY_CLEAR_SEARCH.Visible = False
        '
        'WTXT_ITEM_SEARCH
        '
        Me.WTXT_ITEM_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_SEARCH.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_SEARCH.Location = New System.Drawing.Point(49, 29)
        Me.WTXT_ITEM_SEARCH.MaxLength = 300
        Me.WTXT_ITEM_SEARCH.Name = "WTXT_ITEM_SEARCH"
        Me.WTXT_ITEM_SEARCH.Size = New System.Drawing.Size(974, 21)
        Me.WTXT_ITEM_SEARCH.TabIndex = 1430
        Me.WTXT_ITEM_SEARCH.Watermark = "Search Item Description"
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
        'DGV_INV_ITEM_LIST
        '
        Me.DGV_INV_ITEM_LIST.AllowUserToAddRows = False
        Me.DGV_INV_ITEM_LIST.AllowUserToDeleteRows = False
        Me.DGV_INV_ITEM_LIST.AllowUserToResizeColumns = False
        Me.DGV_INV_ITEM_LIST.AllowUserToResizeRows = False
        Me.DGV_INV_ITEM_LIST.AutoGenerateColumns = False
        Me.DGV_INV_ITEM_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_INV_ITEM_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_INV_ITEM_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_INV_ITEM_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ITEMCODEDataGridViewTextBoxColumn, Me.CATCODEDataGridViewTextBoxColumn, Me.CATNAMEDataGridViewTextBoxColumn, Me.SCNODataGridViewTextBoxColumn, Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn, Me.ITBRNODataGridViewTextBoxColumn, Me.ITBRNAMEDataGridViewTextBoxColumn, Me.FULLDESC, Me.ITEMSERIALNODataGridViewTextBoxColumn, Me.COLRNUMDataGridViewTextBoxColumn, Me.COLRNAMEDataGridViewTextBoxColumn, Me.ISACTIVEDataGridViewCheckBoxColumn, Me.SIZENUMDataGridViewTextBoxColumn, Me.SIZENAMEDataGridViewTextBoxColumn, Me.ITEMCREATEDDATEDataGridViewTextBoxColumn, Me.CREATEDBYDataGridViewTextBoxColumn, Me.ISACTIVESIZEDataGridViewCheckBoxColumn, Me.LENG_NUM, Me.OTHER_NUM, Me.ITM_NAME_NUM, Me.ITM_NAME, Me.NAME_IS_ACTIVE, Me.btnEdit, Me.IMG_PATH, Me.Column2})
        Me.DGV_INV_ITEM_LIST.DataSource = Me.VWM4_ITEM_LISTBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_INV_ITEM_LIST.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_INV_ITEM_LIST.Location = New System.Drawing.Point(6, 64)
        Me.DGV_INV_ITEM_LIST.MultiSelect = False
        Me.DGV_INV_ITEM_LIST.Name = "DGV_INV_ITEM_LIST"
        Me.DGV_INV_ITEM_LIST.ReadOnly = True
        Me.DGV_INV_ITEM_LIST.RowHeadersVisible = False
        Me.DGV_INV_ITEM_LIST.RowTemplate.Height = 25
        Me.DGV_INV_ITEM_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_INV_ITEM_LIST.Size = New System.Drawing.Size(1062, 422)
        Me.DGV_INV_ITEM_LIST.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Column1.MinimumWidth = 100
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Visible = False
        '
        'ITEMCODEDataGridViewTextBoxColumn
        '
        Me.ITEMCODEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.HeaderText = "Item Code"
        Me.ITEMCODEDataGridViewTextBoxColumn.Name = "ITEMCODEDataGridViewTextBoxColumn"
        Me.ITEMCODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CATCODEDataGridViewTextBoxColumn
        '
        Me.CATCODEDataGridViewTextBoxColumn.DataPropertyName = "CAT_CODE"
        Me.CATCODEDataGridViewTextBoxColumn.HeaderText = "CAT_CODE"
        Me.CATCODEDataGridViewTextBoxColumn.Name = "CATCODEDataGridViewTextBoxColumn"
        Me.CATCODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CATCODEDataGridViewTextBoxColumn.Visible = False
        '
        'CATNAMEDataGridViewTextBoxColumn
        '
        Me.CATNAMEDataGridViewTextBoxColumn.DataPropertyName = "CAT_NAME"
        Me.CATNAMEDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CATNAMEDataGridViewTextBoxColumn.Name = "CATNAMEDataGridViewTextBoxColumn"
        Me.CATNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SCNODataGridViewTextBoxColumn
        '
        Me.SCNODataGridViewTextBoxColumn.DataPropertyName = "SC_NO"
        Me.SCNODataGridViewTextBoxColumn.HeaderText = "SC_NO"
        Me.SCNODataGridViewTextBoxColumn.Name = "SCNODataGridViewTextBoxColumn"
        Me.SCNODataGridViewTextBoxColumn.ReadOnly = True
        Me.SCNODataGridViewTextBoxColumn.Visible = False
        '
        'SCSUBCATEGORYNAMEDataGridViewTextBoxColumn
        '
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn.DataPropertyName = "SC_SUBCATEGORY_NAME"
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn.HeaderText = "Sub Category Name"
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn.Name = "SCSUBCATEGORYNAMEDataGridViewTextBoxColumn"
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SCSUBCATEGORYNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'ITBRNODataGridViewTextBoxColumn
        '
        Me.ITBRNODataGridViewTextBoxColumn.DataPropertyName = "ITBR_NO"
        Me.ITBRNODataGridViewTextBoxColumn.HeaderText = "ITBR_NO"
        Me.ITBRNODataGridViewTextBoxColumn.Name = "ITBRNODataGridViewTextBoxColumn"
        Me.ITBRNODataGridViewTextBoxColumn.ReadOnly = True
        Me.ITBRNODataGridViewTextBoxColumn.Visible = False
        '
        'ITBRNAMEDataGridViewTextBoxColumn
        '
        Me.ITBRNAMEDataGridViewTextBoxColumn.DataPropertyName = "ITBR_NAME"
        Me.ITBRNAMEDataGridViewTextBoxColumn.HeaderText = "Brand Name"
        Me.ITBRNAMEDataGridViewTextBoxColumn.Name = "ITBRNAMEDataGridViewTextBoxColumn"
        Me.ITBRNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FULLDESC
        '
        Me.FULLDESC.DataPropertyName = "FULLDESC"
        Me.FULLDESC.HeaderText = "Item Description"
        Me.FULLDESC.Name = "FULLDESC"
        Me.FULLDESC.ReadOnly = True
        '
        'ITEMSERIALNODataGridViewTextBoxColumn
        '
        Me.ITEMSERIALNODataGridViewTextBoxColumn.DataPropertyName = "ITEM_SERIAL_NO"
        Me.ITEMSERIALNODataGridViewTextBoxColumn.HeaderText = "ITEM_SERIAL_NO"
        Me.ITEMSERIALNODataGridViewTextBoxColumn.Name = "ITEMSERIALNODataGridViewTextBoxColumn"
        Me.ITEMSERIALNODataGridViewTextBoxColumn.ReadOnly = True
        Me.ITEMSERIALNODataGridViewTextBoxColumn.Visible = False
        '
        'COLRNUMDataGridViewTextBoxColumn
        '
        Me.COLRNUMDataGridViewTextBoxColumn.DataPropertyName = "COLR_NUM"
        Me.COLRNUMDataGridViewTextBoxColumn.HeaderText = "COLR_NUM"
        Me.COLRNUMDataGridViewTextBoxColumn.Name = "COLRNUMDataGridViewTextBoxColumn"
        Me.COLRNUMDataGridViewTextBoxColumn.ReadOnly = True
        Me.COLRNUMDataGridViewTextBoxColumn.Visible = False
        '
        'COLRNAMEDataGridViewTextBoxColumn
        '
        Me.COLRNAMEDataGridViewTextBoxColumn.DataPropertyName = "COLR_NAME"
        Me.COLRNAMEDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.COLRNAMEDataGridViewTextBoxColumn.Name = "COLRNAMEDataGridViewTextBoxColumn"
        Me.COLRNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.COLRNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'ISACTIVEDataGridViewCheckBoxColumn
        '
        Me.ISACTIVEDataGridViewCheckBoxColumn.DataPropertyName = "IS_ACTIVE"
        Me.ISACTIVEDataGridViewCheckBoxColumn.HeaderText = "IS_ACTIVE"
        Me.ISACTIVEDataGridViewCheckBoxColumn.Name = "ISACTIVEDataGridViewCheckBoxColumn"
        Me.ISACTIVEDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ISACTIVEDataGridViewCheckBoxColumn.Visible = False
        '
        'SIZENUMDataGridViewTextBoxColumn
        '
        Me.SIZENUMDataGridViewTextBoxColumn.DataPropertyName = "SIZE_NUM"
        Me.SIZENUMDataGridViewTextBoxColumn.HeaderText = "SIZE_NUM"
        Me.SIZENUMDataGridViewTextBoxColumn.Name = "SIZENUMDataGridViewTextBoxColumn"
        Me.SIZENUMDataGridViewTextBoxColumn.ReadOnly = True
        Me.SIZENUMDataGridViewTextBoxColumn.Visible = False
        '
        'SIZENAMEDataGridViewTextBoxColumn
        '
        Me.SIZENAMEDataGridViewTextBoxColumn.DataPropertyName = "SIZE_NAME"
        Me.SIZENAMEDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SIZENAMEDataGridViewTextBoxColumn.Name = "SIZENAMEDataGridViewTextBoxColumn"
        Me.SIZENAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SIZENAMEDataGridViewTextBoxColumn.Visible = False
        '
        'ITEMCREATEDDATEDataGridViewTextBoxColumn
        '
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CREATED_DATE"
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.HeaderText = "Created Date"
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.Name = "ITEMCREATEDDATEDataGridViewTextBoxColumn"
        Me.ITEMCREATEDDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CREATEDBYDataGridViewTextBoxColumn
        '
        Me.CREATEDBYDataGridViewTextBoxColumn.DataPropertyName = "CREATED_BY"
        Me.CREATEDBYDataGridViewTextBoxColumn.HeaderText = "Encoded By"
        Me.CREATEDBYDataGridViewTextBoxColumn.Name = "CREATEDBYDataGridViewTextBoxColumn"
        Me.CREATEDBYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ISACTIVESIZEDataGridViewCheckBoxColumn
        '
        Me.ISACTIVESIZEDataGridViewCheckBoxColumn.DataPropertyName = "IS_ACTIVE_SIZE"
        Me.ISACTIVESIZEDataGridViewCheckBoxColumn.HeaderText = "IS_ACTIVE_SIZE"
        Me.ISACTIVESIZEDataGridViewCheckBoxColumn.Name = "ISACTIVESIZEDataGridViewCheckBoxColumn"
        Me.ISACTIVESIZEDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ISACTIVESIZEDataGridViewCheckBoxColumn.Visible = False
        '
        'LENG_NUM
        '
        Me.LENG_NUM.DataPropertyName = "LENG_NUM"
        Me.LENG_NUM.HeaderText = "LENG_NUM"
        Me.LENG_NUM.Name = "LENG_NUM"
        Me.LENG_NUM.ReadOnly = True
        Me.LENG_NUM.Visible = False
        '
        'OTHER_NUM
        '
        Me.OTHER_NUM.DataPropertyName = "OTHER_NUM"
        Me.OTHER_NUM.HeaderText = "OTHER_NUM"
        Me.OTHER_NUM.Name = "OTHER_NUM"
        Me.OTHER_NUM.ReadOnly = True
        Me.OTHER_NUM.Visible = False
        '
        'ITM_NAME_NUM
        '
        Me.ITM_NAME_NUM.DataPropertyName = "ITM_NAME_NUM"
        Me.ITM_NAME_NUM.HeaderText = "ITM_NAME_NUM"
        Me.ITM_NAME_NUM.Name = "ITM_NAME_NUM"
        Me.ITM_NAME_NUM.ReadOnly = True
        Me.ITM_NAME_NUM.Visible = False
        '
        'ITM_NAME
        '
        Me.ITM_NAME.DataPropertyName = "ITM_NAME"
        Me.ITM_NAME.HeaderText = "ITM_NAME"
        Me.ITM_NAME.Name = "ITM_NAME"
        Me.ITM_NAME.ReadOnly = True
        Me.ITM_NAME.Visible = False
        '
        'NAME_IS_ACTIVE
        '
        Me.NAME_IS_ACTIVE.DataPropertyName = "NAME_IS_ACTIVE"
        Me.NAME_IS_ACTIVE.HeaderText = "NAME_IS_ACTIVE"
        Me.NAME_IS_ACTIVE.Name = "NAME_IS_ACTIVE"
        Me.NAME_IS_ACTIVE.ReadOnly = True
        Me.NAME_IS_ACTIVE.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.btnEdit.HeaderText = "Action"
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ReadOnly = True
        Me.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseColumnTextForButtonValue = True
        Me.btnEdit.Width = 70
        '
        'IMG_PATH
        '
        Me.IMG_PATH.DataPropertyName = "IMG_PATH"
        Me.IMG_PATH.HeaderText = ""
        Me.IMG_PATH.Name = "IMG_PATH"
        Me.IMG_PATH.ReadOnly = True
        Me.IMG_PATH.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IMG_PATH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IMG_PATH.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "Action"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "View Image"
        Me.Column2.UseColumnTextForButtonValue = True
        Me.Column2.Width = 90
        '
        'VWM4_ITEM_LISTBindingSource
        '
        Me.VWM4_ITEM_LISTBindingSource.DataMember = "VWM4_ITEM_LIST"
        Me.VWM4_ITEM_LISTBindingSource.DataSource = Me.DS_VIEWS
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RECT_PRCANCELEDIT})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1068, 520)
        Me.ShapeContainer1.TabIndex = 1439
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 19
        Me.RectangleShape5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape5.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(893, 477)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(170, 39)
        '
        'RECT_PRCANCELEDIT
        '
        Me.RECT_PRCANCELEDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRCANCELEDIT.BorderWidth = 2
        Me.RECT_PRCANCELEDIT.CornerRadius = 19
        Me.RECT_PRCANCELEDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRCANCELEDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRCANCELEDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(0, 1)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(1065, 39)
        '
        'RECT_INVENTORY_NEW_SAVE
        '
        Me.RECT_INVENTORY_NEW_SAVE.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_INVENTORY_NEW_SAVE.BorderWidth = 2
        Me.RECT_INVENTORY_NEW_SAVE.CornerRadius = 19
        Me.RECT_INVENTORY_NEW_SAVE.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_NEW_SAVE.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_NEW_SAVE.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_NEW_SAVE.Location = New System.Drawing.Point(5, 5)
        Me.RECT_INVENTORY_NEW_SAVE.Name = "RECT_INVENTORY_NEW_SAVE"
        Me.RECT_INVENTORY_NEW_SAVE.Size = New System.Drawing.Size(141, 39)
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_INVENTORY_EDIT})
        Me.ShapeContainer3.Size = New System.Drawing.Size(1095, 660)
        Me.ShapeContainer3.TabIndex = 1408
        Me.ShapeContainer3.TabStop = False
        '
        'RECT_INVENTORY_EDIT
        '
        Me.RECT_INVENTORY_EDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_INVENTORY_EDIT.BorderWidth = 2
        Me.RECT_INVENTORY_EDIT.CornerRadius = 19
        Me.RECT_INVENTORY_EDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_EDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_EDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_EDIT.Location = New System.Drawing.Point(115, 756)
        Me.RECT_INVENTORY_EDIT.Name = "RECT_INVENTORY_EDIT"
        Me.RECT_INVENTORY_EDIT.Size = New System.Drawing.Size(98, 39)
        '
        'RECT_STOCKS
        '
        Me.RECT_STOCKS.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_STOCKS.BorderWidth = 2
        Me.RECT_STOCKS.CornerRadius = 19
        Me.RECT_STOCKS.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_STOCKS.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_STOCKS.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_STOCKS.Location = New System.Drawing.Point(149, 5)
        Me.RECT_STOCKS.Name = "RECT_STOCKS"
        Me.RECT_STOCKS.Size = New System.Drawing.Size(120, 39)
        '
        'RECT_ITEM_DISTRIBUTION
        '
        Me.RECT_ITEM_DISTRIBUTION.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ITEM_DISTRIBUTION.BorderWidth = 2
        Me.RECT_ITEM_DISTRIBUTION.CornerRadius = 19
        Me.RECT_ITEM_DISTRIBUTION.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_ITEM_DISTRIBUTION.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_ITEM_DISTRIBUTION.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_ITEM_DISTRIBUTION.Location = New System.Drawing.Point(581, 5)
        Me.RECT_ITEM_DISTRIBUTION.Name = "RECT_ITEM_DISTRIBUTION"
        Me.RECT_ITEM_DISTRIBUTION.Size = New System.Drawing.Size(207, 39)
        '
        'RECT_INVENTORY_CANCEL
        '
        Me.RECT_INVENTORY_CANCEL.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_INVENTORY_CANCEL.BorderWidth = 2
        Me.RECT_INVENTORY_CANCEL.CornerRadius = 19
        Me.RECT_INVENTORY_CANCEL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_CANCEL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_CANCEL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_CANCEL.Location = New System.Drawing.Point(913, 5)
        Me.RECT_INVENTORY_CANCEL.Name = "RECT_INVENTORY_CANCEL"
        Me.RECT_INVENTORY_CANCEL.Size = New System.Drawing.Size(169, 39)
        '
        'LLBL_INVENTORY_NEW
        '
        Me.LLBL_INVENTORY_NEW.AutoSize = True
        Me.LLBL_INVENTORY_NEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENTORY_NEW.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_INVENTORY_NEW.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_NEW.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENTORY_NEW.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_NEW.Location = New System.Drawing.Point(51, 15)
        Me.LLBL_INVENTORY_NEW.Name = "LLBL_INVENTORY_NEW"
        Me.LLBL_INVENTORY_NEW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LLBL_INVENTORY_NEW.Size = New System.Drawing.Size(87, 19)
        Me.LLBL_INVENTORY_NEW.TabIndex = 1449
        Me.LLBL_INVENTORY_NEW.TabStop = True
        Me.LLBL_INVENTORY_NEW.Text = "NEW ITEM"
        '
        'PB_INVENTORY_NEW
        '
        Me.PB_INVENTORY_NEW.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_post_add_black_18dp
        Me.PB_INVENTORY_NEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_NEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_NEW.InitialImage = Nothing
        Me.PB_INVENTORY_NEW.Location = New System.Drawing.Point(16, 11)
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
        Me.LLBL_INVENTORY_EDIT.Location = New System.Drawing.Point(165, 766)
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
        Me.PB_INVENTORY_EDIT.Location = New System.Drawing.Point(127, 762)
        Me.PB_INVENTORY_EDIT.Name = "PB_INVENTORY_EDIT"
        Me.PB_INVENTORY_EDIT.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_EDIT.TabIndex = 1451
        Me.PB_INVENTORY_EDIT.TabStop = False
        '
        'APNL_ITEMINFO
        '
        Me.APNL_ITEMINFO.BackColor = System.Drawing.Color.White
        Me.APNL_ITEMINFO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APNL_ITEMINFO.Controls.Add(Me.GroupBox4)
        Me.APNL_ITEMINFO.Controls.Add(Me.GroupBox3)
        Me.APNL_ITEMINFO.Controls.Add(Me.BTN_INVENTORY_SAVE)
        Me.APNL_ITEMINFO.Controls.Add(Me.Panel23)
        Me.APNL_ITEMINFO.Controls.Add(Me.BTN_INVENTORY_CANCEL)
        Me.APNL_ITEMINFO.Controls.Add(Me.BTN_CLOSE_INVENTORY_MINI_CLOSE)
        Me.APNL_ITEMINFO.Controls.Add(Me.ShapeContainer4)
        Me.APNL_ITEMINFO.Location = New System.Drawing.Point(1095, 3)
        Me.APNL_ITEMINFO.Name = "APNL_ITEMINFO"
        Me.APNL_ITEMINFO.Size = New System.Drawing.Size(582, 547)
        Me.APNL_ITEMINFO.TabIndex = 1455
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.PB_ITEM_IMAGE)
        Me.GroupBox4.Controls.Add(Me.WTXT_INV_ALIAS_NAME)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.BTN_INV_NAME)
        Me.GroupBox4.Controls.Add(Me.CB_INV_NAME)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.CB_INV_OTHER_DESC)
        Me.GroupBox4.Controls.Add(Me.CB_INV_LENGTH)
        Me.GroupBox4.Controls.Add(Me.BTN_INV_OTHER_DESC)
        Me.GroupBox4.Controls.Add(Me.BTN_INV_LENGTH)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.CB_INV_SC)
        Me.GroupBox4.Controls.Add(Me.CB_INV_COLOR)
        Me.GroupBox4.Controls.Add(Me.BTN_INV_COLOR)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.BTN_INV_SIZE)
        Me.GroupBox4.Controls.Add(Me.CB_INV_SIZE)
        Me.GroupBox4.Controls.Add(Me.CB_INV_BRAND)
        Me.GroupBox4.Controls.Add(Me.BTN_INV_BR)
        Me.GroupBox4.Controls.Add(Me.LinkLabel2)
        Me.GroupBox4.Controls.Add(Me.LinkLabel3)
        Me.GroupBox4.Controls.Add(Me.BTN_INV_SC)
        Me.GroupBox4.Controls.Add(Me.BTN_INV_CAT)
        Me.GroupBox4.Controls.Add(Me.CB_INV_CAT)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.PictureBox3)
        Me.GroupBox4.Controls.Add(Me.ShapeContainer5)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(38, 34)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(530, 441)
        Me.GroupBox4.TabIndex = 1446
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Item Description"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DimGray
        Me.Label24.Location = New System.Drawing.Point(166, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 16)
        Me.Label24.TabIndex = 1435
        Me.Label24.Text = "Sub Category"
        '
        'PB_ITEM_IMAGE
        '
        Me.PB_ITEM_IMAGE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.images
        Me.PB_ITEM_IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PB_ITEM_IMAGE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ITEM_IMAGE.Location = New System.Drawing.Point(11, 19)
        Me.PB_ITEM_IMAGE.Name = "PB_ITEM_IMAGE"
        Me.PB_ITEM_IMAGE.Size = New System.Drawing.Size(142, 142)
        Me.PB_ITEM_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_ITEM_IMAGE.TabIndex = 1482
        Me.PB_ITEM_IMAGE.TabStop = False
        '
        'WTXT_INV_ALIAS_NAME
        '
        Me.WTXT_INV_ALIAS_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INV_ALIAS_NAME.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_INV_ALIAS_NAME.Location = New System.Drawing.Point(12, 405)
        Me.WTXT_INV_ALIAS_NAME.Name = "WTXT_INV_ALIAS_NAME"
        Me.WTXT_INV_ALIAS_NAME.Size = New System.Drawing.Size(473, 19)
        Me.WTXT_INV_ALIAS_NAME.TabIndex = 1481
        Me.WTXT_INV_ALIAS_NAME.Watermark = Nothing
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(21, 388)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 16)
        Me.Label21.TabIndex = 1480
        Me.Label21.Text = "Alias Name"
        '
        'BTN_INV_NAME
        '
        Me.BTN_INV_NAME.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_INV_NAME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INV_NAME.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INV_NAME.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_INV_NAME.FlatAppearance.BorderSize = 0
        Me.BTN_INV_NAME.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INV_NAME.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_INV_NAME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INV_NAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INV_NAME.Location = New System.Drawing.Point(494, 133)
        Me.BTN_INV_NAME.Name = "BTN_INV_NAME"
        Me.BTN_INV_NAME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INV_NAME.Size = New System.Drawing.Size(24, 24)
        Me.BTN_INV_NAME.TabIndex = 1479
        Me.BTN_INV_NAME.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_INV_NAME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INV_NAME.UseVisualStyleBackColor = True
        '
        'CB_INV_NAME
        '
        Me.CB_INV_NAME.DataSource = Me.TBLM4INVITEMSNAMEMAINBindingSource
        Me.CB_INV_NAME.DisplayMember = "ITM_NAME"
        Me.CB_INV_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_NAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_NAME.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_NAME.FormattingEnabled = True
        Me.CB_INV_NAME.Location = New System.Drawing.Point(158, 131)
        Me.CB_INV_NAME.Name = "CB_INV_NAME"
        Me.CB_INV_NAME.Size = New System.Drawing.Size(328, 28)
        Me.CB_INV_NAME.TabIndex = 1478
        Me.CB_INV_NAME.ValueMember = "ITM_NAME_NUM"
        '
        'TBLM4INVITEMSNAMEMAINBindingSource
        '
        Me.TBLM4INVITEMSNAMEMAINBindingSource.DataMember = "TBLM4_INV_ITEMS_NAME_MAIN"
        Me.TBLM4INVITEMSNAMEMAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(21, 345)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(121, 16)
        Me.Label20.TabIndex = 1477
        Me.Label20.Text = "Other Description"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(21, 298)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 16)
        Me.Label18.TabIndex = 1476
        Me.Label18.Text = "Length"
        '
        'CB_INV_OTHER_DESC
        '
        Me.CB_INV_OTHER_DESC.DataSource = Me.TBLM4INVITEMSOTHERSMAINBindingSource
        Me.CB_INV_OTHER_DESC.DisplayMember = "OTHERS_NAME"
        Me.CB_INV_OTHER_DESC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_OTHER_DESC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_OTHER_DESC.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_OTHER_DESC.FormattingEnabled = True
        Me.CB_INV_OTHER_DESC.Location = New System.Drawing.Point(11, 355)
        Me.CB_INV_OTHER_DESC.Name = "CB_INV_OTHER_DESC"
        Me.CB_INV_OTHER_DESC.Size = New System.Drawing.Size(474, 28)
        Me.CB_INV_OTHER_DESC.TabIndex = 1473
        Me.CB_INV_OTHER_DESC.ValueMember = "OTHERS_NUM"
        '
        'TBLM4INVITEMSOTHERSMAINBindingSource
        '
        Me.TBLM4INVITEMSOTHERSMAINBindingSource.DataMember = "TBLM4_INV_ITEMS_OTHERS_MAIN"
        Me.TBLM4INVITEMSOTHERSMAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'CB_INV_LENGTH
        '
        Me.CB_INV_LENGTH.DataSource = Me.TBLM4INVITEMSLENGMAINBindingSource
        Me.CB_INV_LENGTH.DisplayMember = "LENG_NAME"
        Me.CB_INV_LENGTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_LENGTH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_LENGTH.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_LENGTH.FormattingEnabled = True
        Me.CB_INV_LENGTH.Location = New System.Drawing.Point(11, 310)
        Me.CB_INV_LENGTH.Name = "CB_INV_LENGTH"
        Me.CB_INV_LENGTH.Size = New System.Drawing.Size(474, 28)
        Me.CB_INV_LENGTH.TabIndex = 1472
        Me.CB_INV_LENGTH.ValueMember = "LENG_NUM"
        '
        'TBLM4INVITEMSLENGMAINBindingSource
        '
        Me.TBLM4INVITEMSLENGMAINBindingSource.DataMember = "TBLM4_INV_ITEMS_LENG_MAIN"
        Me.TBLM4INVITEMSLENGMAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'BTN_INV_OTHER_DESC
        '
        Me.BTN_INV_OTHER_DESC.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_INV_OTHER_DESC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INV_OTHER_DESC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INV_OTHER_DESC.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_INV_OTHER_DESC.FlatAppearance.BorderSize = 0
        Me.BTN_INV_OTHER_DESC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INV_OTHER_DESC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_INV_OTHER_DESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INV_OTHER_DESC.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INV_OTHER_DESC.Location = New System.Drawing.Point(494, 357)
        Me.BTN_INV_OTHER_DESC.Name = "BTN_INV_OTHER_DESC"
        Me.BTN_INV_OTHER_DESC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INV_OTHER_DESC.Size = New System.Drawing.Size(24, 24)
        Me.BTN_INV_OTHER_DESC.TabIndex = 1475
        Me.BTN_INV_OTHER_DESC.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_INV_OTHER_DESC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INV_OTHER_DESC.UseVisualStyleBackColor = True
        '
        'BTN_INV_LENGTH
        '
        Me.BTN_INV_LENGTH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_INV_LENGTH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INV_LENGTH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INV_LENGTH.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_INV_LENGTH.FlatAppearance.BorderSize = 0
        Me.BTN_INV_LENGTH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INV_LENGTH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_INV_LENGTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INV_LENGTH.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INV_LENGTH.Location = New System.Drawing.Point(494, 313)
        Me.BTN_INV_LENGTH.Name = "BTN_INV_LENGTH"
        Me.BTN_INV_LENGTH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INV_LENGTH.Size = New System.Drawing.Size(24, 24)
        Me.BTN_INV_LENGTH.TabIndex = 1474
        Me.BTN_INV_LENGTH.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_INV_LENGTH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INV_LENGTH.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(21, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 16)
        Me.Label14.TabIndex = 1472
        Me.Label14.Text = "Color"
        '
        'CB_INV_SC
        '
        Me.CB_INV_SC.DataSource = Me.TblM4INVENTORYSUBCATEGORYBindingSource
        Me.CB_INV_SC.DisplayMember = "SC_SUBCATEGORY_NAME"
        Me.CB_INV_SC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_SC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_SC.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_SC.FormattingEnabled = True
        Me.CB_INV_SC.Location = New System.Drawing.Point(159, 84)
        Me.CB_INV_SC.Name = "CB_INV_SC"
        Me.CB_INV_SC.Size = New System.Drawing.Size(327, 28)
        Me.CB_INV_SC.TabIndex = 1
        Me.CB_INV_SC.ValueMember = "SC_NO"
        '
        'TblM4INVENTORYSUBCATEGORYBindingSource
        '
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_SUB_CATEGORY"
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'CB_INV_COLOR
        '
        Me.CB_INV_COLOR.DataSource = Me.TBLM4INVITEMSCOLORMAINBindingSource
        Me.CB_INV_COLOR.DisplayMember = "COLR_NAME"
        Me.CB_INV_COLOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_COLOR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_COLOR.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_COLOR.FormattingEnabled = True
        Me.CB_INV_COLOR.Location = New System.Drawing.Point(12, 266)
        Me.CB_INV_COLOR.Name = "CB_INV_COLOR"
        Me.CB_INV_COLOR.Size = New System.Drawing.Size(474, 28)
        Me.CB_INV_COLOR.TabIndex = 1471
        Me.CB_INV_COLOR.ValueMember = "COLR_NUM"
        '
        'TBLM4INVITEMSCOLORMAINBindingSource
        '
        Me.TBLM4INVITEMSCOLORMAINBindingSource.DataMember = "TBLM4_INV_ITEMS_COLOR_MAIN"
        Me.TBLM4INVITEMSCOLORMAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'BTN_INV_COLOR
        '
        Me.BTN_INV_COLOR.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_INV_COLOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INV_COLOR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INV_COLOR.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_INV_COLOR.FlatAppearance.BorderSize = 0
        Me.BTN_INV_COLOR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INV_COLOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_INV_COLOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INV_COLOR.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INV_COLOR.Location = New System.Drawing.Point(494, 268)
        Me.BTN_INV_COLOR.Name = "BTN_INV_COLOR"
        Me.BTN_INV_COLOR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INV_COLOR.Size = New System.Drawing.Size(24, 24)
        Me.BTN_INV_COLOR.TabIndex = 1470
        Me.BTN_INV_COLOR.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_INV_COLOR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INV_COLOR.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(21, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 16)
        Me.Label13.TabIndex = 1469
        Me.Label13.Text = "Size"
        '
        'BTN_INV_SIZE
        '
        Me.BTN_INV_SIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_INV_SIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INV_SIZE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INV_SIZE.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_INV_SIZE.FlatAppearance.BorderSize = 0
        Me.BTN_INV_SIZE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INV_SIZE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_INV_SIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INV_SIZE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INV_SIZE.Location = New System.Drawing.Point(494, 223)
        Me.BTN_INV_SIZE.Name = "BTN_INV_SIZE"
        Me.BTN_INV_SIZE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INV_SIZE.Size = New System.Drawing.Size(24, 24)
        Me.BTN_INV_SIZE.TabIndex = 1468
        Me.BTN_INV_SIZE.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_INV_SIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INV_SIZE.UseVisualStyleBackColor = True
        '
        'CB_INV_SIZE
        '
        Me.CB_INV_SIZE.DataSource = Me.TBLM4INVITEMSSIZEMAINBindingSource
        Me.CB_INV_SIZE.DisplayMember = "SIZE_NAME"
        Me.CB_INV_SIZE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_SIZE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_SIZE.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_SIZE.FormattingEnabled = True
        Me.CB_INV_SIZE.Location = New System.Drawing.Point(12, 219)
        Me.CB_INV_SIZE.Name = "CB_INV_SIZE"
        Me.CB_INV_SIZE.Size = New System.Drawing.Size(474, 28)
        Me.CB_INV_SIZE.TabIndex = 1467
        Me.CB_INV_SIZE.ValueMember = "SIZE_NUM"
        '
        'TBLM4INVITEMSSIZEMAINBindingSource
        '
        Me.TBLM4INVITEMSSIZEMAINBindingSource.DataMember = "TBLM4_INV_ITEMS_SIZE_MAIN"
        Me.TBLM4INVITEMSSIZEMAINBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'CB_INV_BRAND
        '
        Me.CB_INV_BRAND.DataSource = Me.TblM4INVENTORYITEMBRANDBindingSource
        Me.CB_INV_BRAND.DisplayMember = "ITBR_NAME"
        Me.CB_INV_BRAND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_BRAND.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_BRAND.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_BRAND.FormattingEnabled = True
        Me.CB_INV_BRAND.Location = New System.Drawing.Point(12, 176)
        Me.CB_INV_BRAND.Name = "CB_INV_BRAND"
        Me.CB_INV_BRAND.Size = New System.Drawing.Size(474, 28)
        Me.CB_INV_BRAND.TabIndex = 1466
        Me.CB_INV_BRAND.ValueMember = "ITBR_NO"
        '
        'TblM4INVENTORYITEMBRANDBindingSource
        '
        Me.TblM4INVENTORYITEMBRANDBindingSource.DataMember = "tblM4_INVENTORY_ITEMBRAND"
        Me.TblM4INVENTORYITEMBRANDBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'BTN_INV_BR
        '
        Me.BTN_INV_BR.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_INV_BR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INV_BR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INV_BR.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_INV_BR.FlatAppearance.BorderSize = 0
        Me.BTN_INV_BR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INV_BR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_INV_BR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INV_BR.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INV_BR.Location = New System.Drawing.Point(494, 179)
        Me.BTN_INV_BR.Name = "BTN_INV_BR"
        Me.BTN_INV_BR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INV_BR.Size = New System.Drawing.Size(24, 24)
        Me.BTN_INV_BR.TabIndex = 1465
        Me.BTN_INV_BR.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_INV_BR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INV_BR.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel2.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel2.Location = New System.Drawing.Point(454, 620)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(61, 19)
        Me.LinkLabel2.TabIndex = 1464
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "CLOSE"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel3.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel3.Location = New System.Drawing.Point(393, 620)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(46, 19)
        Me.LinkLabel3.TabIndex = 1463
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "ADD"
        '
        'BTN_INV_SC
        '
        Me.BTN_INV_SC.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_INV_SC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INV_SC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INV_SC.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_INV_SC.FlatAppearance.BorderSize = 0
        Me.BTN_INV_SC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INV_SC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_INV_SC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INV_SC.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INV_SC.Location = New System.Drawing.Point(494, 85)
        Me.BTN_INV_SC.Name = "BTN_INV_SC"
        Me.BTN_INV_SC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INV_SC.Size = New System.Drawing.Size(24, 24)
        Me.BTN_INV_SC.TabIndex = 1460
        Me.BTN_INV_SC.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_INV_SC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INV_SC.UseVisualStyleBackColor = True
        '
        'BTN_INV_CAT
        '
        Me.BTN_INV_CAT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_add_box_black_18dp
        Me.BTN_INV_CAT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INV_CAT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INV_CAT.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BTN_INV_CAT.FlatAppearance.BorderSize = 0
        Me.BTN_INV_CAT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INV_CAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BTN_INV_CAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INV_CAT.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INV_CAT.Location = New System.Drawing.Point(494, 42)
        Me.BTN_INV_CAT.Name = "BTN_INV_CAT"
        Me.BTN_INV_CAT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INV_CAT.Size = New System.Drawing.Size(24, 24)
        Me.BTN_INV_CAT.TabIndex = 1457
        Me.BTN_INV_CAT.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_INV_CAT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INV_CAT.UseVisualStyleBackColor = True
        '
        'CB_INV_CAT
        '
        Me.CB_INV_CAT.DataSource = Me.TblM4INVENTORYCATEGORYBindingSource
        Me.CB_INV_CAT.DisplayMember = "CAT_NAME"
        Me.CB_INV_CAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INV_CAT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INV_CAT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_INV_CAT.FormattingEnabled = True
        Me.CB_INV_CAT.Location = New System.Drawing.Point(159, 38)
        Me.CB_INV_CAT.Name = "CB_INV_CAT"
        Me.CB_INV_CAT.Size = New System.Drawing.Size(327, 28)
        Me.CB_INV_CAT.TabIndex = 0
        Me.CB_INV_CAT.ValueMember = "CAT_CODE"
        '
        'TblM4INVENTORYCATEGORYBindingSource
        '
        Me.TblM4INVENTORYCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_CATEGORY"
        Me.TblM4INVENTORYCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(21, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 16)
        Me.Label19.TabIndex = 1438
        Me.Label19.Text = "Brand/Provider"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(166, 116)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 16)
        Me.Label25.TabIndex = 1434
        Me.Label25.Text = "Name"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DimGray
        Me.Label26.Location = New System.Drawing.Point(166, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 16)
        Me.Label26.TabIndex = 1433
        Me.Label26.Text = "Category"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(1504, 55)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(145, 145)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape21, Me.RectangleShape20, Me.RectangleShape19, Me.RectangleShape18, Me.RectangleShape17, Me.RectangleShape16, Me.RectangleShape8, Me.RectangleShape1, Me.RectangleShape2, Me.RectangleShape7, Me.RectangleShape24})
        Me.ShapeContainer5.Size = New System.Drawing.Size(524, 419)
        Me.ShapeContainer5.TabIndex = 1
        Me.ShapeContainer5.TabStop = False
        '
        'RectangleShape21
        '
        Me.RectangleShape21.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape21.BorderWidth = 2
        Me.RectangleShape21.CornerRadius = 5
        Me.RectangleShape21.Location = New System.Drawing.Point(5, 379)
        Me.RectangleShape21.Name = "RectangleShape21"
        Me.RectangleShape21.Size = New System.Drawing.Size(479, 31)
        '
        'RectangleShape20
        '
        Me.RectangleShape20.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape20.BorderWidth = 2
        Me.RectangleShape20.CornerRadius = 5
        Me.RectangleShape20.Location = New System.Drawing.Point(5, 333)
        Me.RectangleShape20.Name = "RectangleShape20"
        Me.RectangleShape20.Size = New System.Drawing.Size(479, 32)
        '
        'RectangleShape19
        '
        Me.RectangleShape19.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape19.BorderWidth = 2
        Me.RectangleShape19.CornerRadius = 5
        Me.RectangleShape19.Location = New System.Drawing.Point(5, 288)
        Me.RectangleShape19.Name = "RectangleShape19"
        Me.RectangleShape19.Size = New System.Drawing.Size(479, 32)
        '
        'RectangleShape18
        '
        Me.RectangleShape18.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape18.BorderWidth = 2
        Me.RectangleShape18.CornerRadius = 5
        Me.RectangleShape18.Location = New System.Drawing.Point(5, 244)
        Me.RectangleShape18.Name = "RectangleShape18"
        Me.RectangleShape18.Size = New System.Drawing.Size(479, 32)
        '
        'RectangleShape17
        '
        Me.RectangleShape17.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape17.BorderWidth = 2
        Me.RectangleShape17.CornerRadius = 5
        Me.RectangleShape17.Location = New System.Drawing.Point(6, 197)
        Me.RectangleShape17.Name = "RectangleShape17"
        Me.RectangleShape17.Size = New System.Drawing.Size(479, 32)
        '
        'RectangleShape16
        '
        Me.RectangleShape16.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape16.BorderWidth = 2
        Me.RectangleShape16.CornerRadius = 5
        Me.RectangleShape16.Location = New System.Drawing.Point(6, 155)
        Me.RectangleShape16.Name = "RectangleShape16"
        Me.RectangleShape16.Size = New System.Drawing.Size(479, 31)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape8.BorderWidth = 2
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.Location = New System.Drawing.Point(153, 110)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(332, 31)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(153, 63)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(332, 31)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 19
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(447, 602)
        Me.RectangleShape2.Name = "RectangleShape15"
        Me.RectangleShape2.Size = New System.Drawing.Size(67, 39)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape7.BorderWidth = 2
        Me.RectangleShape7.CornerRadius = 19
        Me.RectangleShape7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape7.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape7.Location = New System.Drawing.Point(382, 602)
        Me.RectangleShape7.Name = "RectangleShape14"
        Me.RectangleShape7.Size = New System.Drawing.Size(62, 39)
        '
        'RectangleShape24
        '
        Me.RectangleShape24.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape24.BorderWidth = 2
        Me.RectangleShape24.CornerRadius = 5
        Me.RectangleShape24.Location = New System.Drawing.Point(153, 17)
        Me.RectangleShape24.Name = "RECT_CATEGORY"
        Me.RectangleShape24.Size = New System.Drawing.Size(332, 32)
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
        Me.GroupBox3.Location = New System.Drawing.Point(1213, 647)
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
        Me.CB_ITEM_USAGE.DisplayMember = "USG_CODE"
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
        'CB_ACQUISITION_VALUE
        '
        Me.CB_ACQUISITION_VALUE.DisplayMember = "ACQV_CODE"
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
        Me.BTN_INVENTORY_SAVE.Location = New System.Drawing.Point(340, 487)
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
        Me.Panel23.Size = New System.Drawing.Size(550, 35)
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
        Me.BTN_INVENTORY_CANCEL.Location = New System.Drawing.Point(452, 487)
        Me.BTN_INVENTORY_CANCEL.Name = "BTN_INVENTORY_CANCEL"
        Me.BTN_INVENTORY_CANCEL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_INVENTORY_CANCEL.Size = New System.Drawing.Size(104, 46)
        Me.BTN_INVENTORY_CANCEL.TabIndex = 1438
        Me.BTN_INVENTORY_CANCEL.Text = "CANCEL"
        Me.BTN_INVENTORY_CANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_CANCEL.UseVisualStyleBackColor = True
        '
        'BTN_CLOSE_INVENTORY_MINI_CLOSE
        '
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Location = New System.Drawing.Point(0, 0)
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Name = "BTN_CLOSE_INVENTORY_MINI_CLOSE"
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Size = New System.Drawing.Size(30, 545)
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
        Me.ShapeContainer4.Size = New System.Drawing.Size(580, 545)
        Me.ShapeContainer4.TabIndex = 1447
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.CornerRadius = 5
        Me.RectangleShape6.Location = New System.Drawing.Point(451, 485)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(105, 49)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(339, 485)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(105, 49)
        '
        'GRP_LIST_ITEMS
        '
        Me.GRP_LIST_ITEMS.Controls.Add(Me.GroupBox2)
        Me.GRP_LIST_ITEMS.Controls.Add(Me.LLBL_EDIT_ITEM)
        Me.GRP_LIST_ITEMS.Controls.Add(Me.LLBL_REMOVE_ITEM)
        Me.GRP_LIST_ITEMS.Controls.Add(Me.DGV_ITEM_INFO)
        Me.GRP_LIST_ITEMS.Controls.Add(Me.LLBL_ADDITEM)
        Me.GRP_LIST_ITEMS.Controls.Add(Me.ShapeContainer7)
        Me.GRP_LIST_ITEMS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_LIST_ITEMS.Location = New System.Drawing.Point(34, 40)
        Me.GRP_LIST_ITEMS.Name = "GRP_LIST_ITEMS"
        Me.GRP_LIST_ITEMS.Size = New System.Drawing.Size(1009, 503)
        Me.GRP_LIST_ITEMS.TabIndex = 1445
        Me.GRP_LIST_ITEMS.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 43)
        Me.GroupBox2.TabIndex = 1448
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SET ITEM AS"
        '
        'LLBL_EDIT_ITEM
        '
        Me.LLBL_EDIT_ITEM.AutoSize = True
        Me.LLBL_EDIT_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_EDIT_ITEM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_EDIT_ITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_EDIT_ITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_EDIT_ITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_EDIT_ITEM.Location = New System.Drawing.Point(700, 25)
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
        Me.LLBL_REMOVE_ITEM.Location = New System.Drawing.Point(790, 26)
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
        Me.DGV_ITEM_INFO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ITEM_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEM_INFO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dateacquisition, Me.category, Me.subcategory, Me.brand, Me.serialproduct, Me.unit, Me.quantity, Me.unitcost, Me.totalcost, Me.itemdescription, Me.subcat, Me.brandd, Me.item_code})
        Me.DGV_ITEM_INFO.Location = New System.Drawing.Point(6, 58)
        Me.DGV_ITEM_INFO.MultiSelect = False
        Me.DGV_ITEM_INFO.Name = "DGV_ITEM_INFO"
        Me.DGV_ITEM_INFO.ReadOnly = True
        Me.DGV_ITEM_INFO.RowHeadersVisible = False
        Me.DGV_ITEM_INFO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEM_INFO.Size = New System.Drawing.Size(997, 436)
        Me.DGV_ITEM_INFO.TabIndex = 1443
        '
        'dateacquisition
        '
        Me.dateacquisition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dateacquisition.HeaderText = "Date Acquisition"
        Me.dateacquisition.Name = "dateacquisition"
        Me.dateacquisition.ReadOnly = True
        '
        'category
        '
        Me.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.category.FillWeight = 122.3927!
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'subcategory
        '
        Me.subcategory.FillWeight = 113.6672!
        Me.subcategory.HeaderText = "Sub Category"
        Me.subcategory.Name = "subcategory"
        Me.subcategory.ReadOnly = True
        '
        'brand
        '
        Me.brand.FillWeight = 106.0975!
        Me.brand.HeaderText = "Brand/Provider"
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = True
        '
        'serialproduct
        '
        Me.serialproduct.FillWeight = 99.53027!
        Me.serialproduct.HeaderText = "Serial No./Product No."
        Me.serialproduct.Name = "serialproduct"
        Me.serialproduct.ReadOnly = True
        '
        'unit
        '
        Me.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.unit.FillWeight = 93.83293!
        Me.unit.HeaderText = "Unit Type"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        Me.unit.Width = 74
        '
        'quantity
        '
        Me.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
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
        '
        'totalcost
        '
        Me.totalcost.FillWeight = 80.88204!
        Me.totalcost.HeaderText = "Total Cost"
        Me.totalcost.Name = "totalcost"
        Me.totalcost.ReadOnly = True
        '
        'itemdescription
        '
        Me.itemdescription.FillWeight = 77.65466!
        Me.itemdescription.HeaderText = "Item Description"
        Me.itemdescription.Name = "itemdescription"
        Me.itemdescription.ReadOnly = True
        '
        'subcat
        '
        Me.subcat.HeaderText = "subcat"
        Me.subcat.Name = "subcat"
        Me.subcat.ReadOnly = True
        Me.subcat.Visible = False
        '
        'brandd
        '
        Me.brandd.HeaderText = "brand"
        Me.brandd.Name = "brandd"
        Me.brandd.ReadOnly = True
        Me.brandd.Visible = False
        '
        'item_code
        '
        Me.item_code.HeaderText = "item_code"
        Me.item_code.Name = "item_code"
        Me.item_code.ReadOnly = True
        Me.item_code.Visible = False
        '
        'LLBL_ADDITEM
        '
        Me.LLBL_ADDITEM.AutoSize = True
        Me.LLBL_ADDITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_ADDITEM.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_ADDITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_ADDITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_ADDITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_ADDITEM.Location = New System.Drawing.Point(917, 27)
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
        Me.ShapeContainer7.Size = New System.Drawing.Size(1003, 483)
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
        Me.RECT_EDIT_ITEM.Location = New System.Drawing.Point(689, 0)
        Me.RECT_EDIT_ITEM.Name = "RECT_EDIT_ITEM"
        Me.RECT_EDIT_ITEM.Size = New System.Drawing.Size(84, 32)
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
        Me.RECT_REMOVE_ITEM.Location = New System.Drawing.Point(776, 2)
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
        Me.RectangleShape13.Location = New System.Drawing.Point(900, 3)
        Me.RectangleShape13.Name = "RectangleShape13"
        Me.RectangleShape13.Size = New System.Drawing.Size(99, 31)
        '
        'LLBL_INVENOTYR_ASSIGN
        '
        Me.LLBL_INVENOTYR_ASSIGN.AutoSize = True
        Me.LLBL_INVENOTYR_ASSIGN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENOTYR_ASSIGN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_INVENOTYR_ASSIGN.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENOTYR_ASSIGN.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENOTYR_ASSIGN.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENOTYR_ASSIGN.Location = New System.Drawing.Point(955, 17)
        Me.LLBL_INVENOTYR_ASSIGN.Name = "LLBL_INVENOTYR_ASSIGN"
        Me.LLBL_INVENOTYR_ASSIGN.Size = New System.Drawing.Size(123, 16)
        Me.LLBL_INVENOTYR_ASSIGN.TabIndex = 1456
        Me.LLBL_INVENOTYR_ASSIGN.TabStop = True
        Me.LLBL_INVENOTYR_ASSIGN.Text = "CATEGORIZATION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GRP_ITEMINFO)
        Me.Panel1.Controls.Add(Me.GRP_LIST_ITEMS)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.ShapeContainer10)
        Me.Panel1.Location = New System.Drawing.Point(1707, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 614)
        Me.Panel1.TabIndex = 1457
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.ComboBox5)
        Me.GroupBox6.Controls.Add(Me.ComboBox6)
        Me.GroupBox6.Controls.Add(Me.RadioButton7)
        Me.GroupBox6.Controls.Add(Me.RadioButton8)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Controls.Add(Me.ShapeContainer9)
        Me.GroupBox6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(1054, 533)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(483, 240)
        Me.GroupBox6.TabIndex = 1442
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Item Classification"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RadioButton5)
        Me.GroupBox7.Controls.Add(Me.RadioButton6)
        Me.GroupBox7.Location = New System.Drawing.Point(22, 185)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(211, 41)
        Me.GroupBox7.TabIndex = 1466
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(14, 13)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(85, 20)
        Me.RadioButton5.TabIndex = 1466
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Depleted"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(119, 13)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(81, 20)
        Me.RadioButton6.TabIndex = 1467
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Per Parts"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'ComboBox5
        '
        Me.ComboBox5.DisplayMember = "USG_CODE"
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox5.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(17, 147)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(453, 27)
        Me.ComboBox5.TabIndex = 1458
        Me.ComboBox5.ValueMember = "USG_CODE"
        '
        'ComboBox6
        '
        Me.ComboBox6.DisplayMember = "ACQV_CODE"
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox6.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(17, 49)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(453, 27)
        Me.ComboBox6.TabIndex = 1457
        Me.ComboBox6.ValueMember = "ACQV_CODE"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(43, 99)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(94, 20)
        Me.RadioButton7.TabIndex = 1464
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Purchased"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(168, 99)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(81, 20)
        Me.RadioButton8.TabIndex = 1465
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Donated"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DimGray
        Me.Label29.Location = New System.Drawing.Point(24, 81)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(110, 17)
        Me.Label29.TabIndex = 1457
        Me.Label29.Text = "Acquisition Type"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DimGray
        Me.Label30.Location = New System.Drawing.Point(24, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(119, 17)
        Me.Label30.TabIndex = 1436
        Me.Label30.Text = "Acquisition Value"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DimGray
        Me.Label31.Location = New System.Drawing.Point(24, 130)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 17)
        Me.Label31.TabIndex = 1434
        Me.Label31.Text = "Item Usage"
        '
        'ShapeContainer9
        '
        Me.ShapeContainer9.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer9.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer9.Name = "ShapeContainer9"
        Me.ShapeContainer9.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape28, Me.RectangleShape29, Me.RectangleShape30})
        Me.ShapeContainer9.Size = New System.Drawing.Size(477, 218)
        Me.ShapeContainer9.TabIndex = 3
        Me.ShapeContainer9.TabStop = False
        '
        'RectangleShape28
        '
        Me.RectangleShape28.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape28.BorderWidth = 2
        Me.RectangleShape28.CornerRadius = 5
        Me.RectangleShape28.Location = New System.Drawing.Point(8, 75)
        Me.RectangleShape28.Name = "RectangleShape9"
        Me.RectangleShape28.Size = New System.Drawing.Size(268, 32)
        '
        'RectangleShape29
        '
        Me.RectangleShape29.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape29.BorderWidth = 2
        Me.RectangleShape29.CornerRadius = 5
        Me.RectangleShape29.Location = New System.Drawing.Point(8, 27)
        Me.RectangleShape29.Name = "RectangleShape8"
        Me.RectangleShape29.Size = New System.Drawing.Size(462, 32)
        '
        'RectangleShape30
        '
        Me.RectangleShape30.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape30.BorderWidth = 2
        Me.RectangleShape30.CornerRadius = 5
        Me.RectangleShape30.Location = New System.Drawing.Point(8, 125)
        Me.RectangleShape30.Name = "RectangleShape7"
        Me.RectangleShape30.Size = New System.Drawing.Size(462, 32)
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button5.Location = New System.Drawing.Point(932, 553)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(104, 46)
        Me.Button5.TabIndex = 1438
        Me.Button5.Text = "CANCEL"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.PRA_PIS.My.Resources.Resources.outline_save_black_18dp
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(820, 553)
        Me.Button6.Name = "Button6"
        Me.Button6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button6.Size = New System.Drawing.Size(104, 46)
        Me.Button6.TabIndex = 1437
        Me.Button6.Text = "SAVE"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(30, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1018, 35)
        Me.Panel2.TabIndex = 1401
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(11, 4)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(143, 25)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "I t e m  I n f o"
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(0, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(30, 612)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = ">>"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ShapeContainer10
        '
        Me.ShapeContainer10.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer10.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer10.Name = "ShapeContainer10"
        Me.ShapeContainer10.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape31, Me.RectangleShape32})
        Me.ShapeContainer10.Size = New System.Drawing.Size(1048, 612)
        Me.ShapeContainer10.TabIndex = 1440
        Me.ShapeContainer10.TabStop = False
        '
        'RectangleShape31
        '
        Me.RectangleShape31.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape31.BorderWidth = 2
        Me.RectangleShape31.CornerRadius = 5
        Me.RectangleShape31.Location = New System.Drawing.Point(931, 551)
        Me.RectangleShape31.Name = "RectangleShape6"
        Me.RectangleShape31.Size = New System.Drawing.Size(105, 49)
        '
        'RectangleShape32
        '
        Me.RectangleShape32.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape32.BorderWidth = 2
        Me.RectangleShape32.CornerRadius = 5
        Me.RectangleShape32.Location = New System.Drawing.Point(819, 551)
        Me.RectangleShape32.Name = "RectangleShape3"
        Me.RectangleShape32.Size = New System.Drawing.Size(105, 49)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_settings_black_18dp
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(923, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox2.TabIndex = 1459
        Me.PictureBox2.TabStop = False
        '
        'LLBL_ITEM_DISTRIBUTION
        '
        Me.LLBL_ITEM_DISTRIBUTION.AutoSize = True
        Me.LLBL_ITEM_DISTRIBUTION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_ITEM_DISTRIBUTION.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_ITEM_DISTRIBUTION.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_ITEM_DISTRIBUTION.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_ITEM_DISTRIBUTION.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_ITEM_DISTRIBUTION.Location = New System.Drawing.Point(625, 15)
        Me.LLBL_ITEM_DISTRIBUTION.Name = "LLBL_ITEM_DISTRIBUTION"
        Me.LLBL_ITEM_DISTRIBUTION.Size = New System.Drawing.Size(157, 19)
        Me.LLBL_ITEM_DISTRIBUTION.TabIndex = 1461
        Me.LLBL_ITEM_DISTRIBUTION.TabStop = True
        Me.LLBL_ITEM_DISTRIBUTION.Text = "ITEM DISTRIBUTION"
        '
        'PB_ITEM_DISTRIBUTION
        '
        Me.PB_ITEM_DISTRIBUTION.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_low_priority_black_18dp
        Me.PB_ITEM_DISTRIBUTION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_ITEM_DISTRIBUTION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ITEM_DISTRIBUTION.InitialImage = Nothing
        Me.PB_ITEM_DISTRIBUTION.Location = New System.Drawing.Point(590, 11)
        Me.PB_ITEM_DISTRIBUTION.Name = "PB_ITEM_DISTRIBUTION"
        Me.PB_ITEM_DISTRIBUTION.Size = New System.Drawing.Size(32, 28)
        Me.PB_ITEM_DISTRIBUTION.TabIndex = 1460
        Me.PB_ITEM_DISTRIBUTION.TabStop = False
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
        'TBLM4_INV_ITEMS_SIZE_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_COLOR_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_CODE_GENERATORTableAdapter
        '
        Me.SPM4_ITEM_CODE_GENERATORTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_CODE_GENERATORBindingSource
        '
        Me.SPM4_ITEM_CODE_GENERATORBindingSource.DataMember = "SPM4_ITEM_CODE_GENERATOR"
        Me.SPM4_ITEM_CODE_GENERATORBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.A_CLOSEPROGRAMTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBLM4_INV_ITEMS_SIZETableAdapter
        '
        Me.TBLM4_INV_ITEMS_SIZETableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_SIZEBindingSource
        '
        Me.TBLM4_INV_ITEMS_SIZEBindingSource.DataMember = "TBLM4_INV_ITEMS_SIZE"
        Me.TBLM4_INV_ITEMS_SIZEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_COLORTableAdapter
        '
        Me.TBLM4_INV_ITEMS_COLORTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_COLORBindingSource
        '
        Me.TBLM4_INV_ITEMS_COLORBindingSource.DataMember = "TBLM4_INV_ITEMS_COLOR"
        Me.TBLM4_INV_ITEMS_COLORBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'PB_STOCKS
        '
        Me.PB_STOCKS.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_assignment_turned_in_black_18dp
        Me.PB_STOCKS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_STOCKS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_STOCKS.InitialImage = Nothing
        Me.PB_STOCKS.Location = New System.Drawing.Point(157, 11)
        Me.PB_STOCKS.Name = "PB_STOCKS"
        Me.PB_STOCKS.Size = New System.Drawing.Size(32, 28)
        Me.PB_STOCKS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_STOCKS.TabIndex = 1462
        Me.PB_STOCKS.TabStop = False
        '
        'LLBL_STOCKS
        '
        Me.LLBL_STOCKS.AutoSize = True
        Me.LLBL_STOCKS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_STOCKS.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_STOCKS.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_STOCKS.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_STOCKS.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_STOCKS.Location = New System.Drawing.Point(191, 16)
        Me.LLBL_STOCKS.Name = "LLBL_STOCKS"
        Me.LLBL_STOCKS.Size = New System.Drawing.Size(72, 19)
        Me.LLBL_STOCKS.TabIndex = 1463
        Me.LLBL_STOCKS.TabStop = True
        Me.LLBL_STOCKS.Text = "STOCKS"
        '
        'TBLM4_INV_ITEMS_LENG_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_LENG_MAINTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_LENGTableAdapter
        '
        Me.TBLM4_INV_ITEMS_LENGTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_LENGBindingSource
        '
        Me.TBLM4_INV_ITEMS_LENGBindingSource.DataMember = "TBLM4_INV_ITEMS_LENG"
        Me.TBLM4_INV_ITEMS_LENGBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_OTHERSTableAdapter
        '
        Me.TBLM4_INV_ITEMS_OTHERSTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_OTHERSBindingSource
        '
        Me.TBLM4_INV_ITEMS_OTHERSBindingSource.DataMember = "TBLM4_INV_ITEMS_OTHERS"
        Me.TBLM4_INV_ITEMS_OTHERSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_NAME_MAINTableAdapter
        '
        Me.TBLM4_INV_ITEMS_NAME_MAINTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_NAMETableAdapter
        '
        Me.TBLM4_INV_ITEMS_NAMETableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_NAMEBindingSource
        '
        Me.TBLM4_INV_ITEMS_NAMEBindingSource.DataMember = "TBLM4_INV_ITEMS_NAME"
        Me.TBLM4_INV_ITEMS_NAMEBindingSource.DataSource = Me.DS_PROPERTYDB
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
        'VWM4_ITEM_LISTTableAdapter
        '
        Me.VWM4_ITEM_LISTTableAdapter.ClearBeforeFill = True
        '
        'RECT_DR_LIST
        '
        Me.RECT_DR_LIST.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_DR_LIST.BorderWidth = 2
        Me.RECT_DR_LIST.CornerRadius = 19
        Me.RECT_DR_LIST.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_DR_LIST.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_DR_LIST.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_DR_LIST.Location = New System.Drawing.Point(272, 5)
        Me.RECT_DR_LIST.Name = "RECT_DR_LIST"
        Me.RECT_DR_LIST.Size = New System.Drawing.Size(115, 40)
        '
        'RECT_IIL
        '
        Me.RECT_IIL.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_IIL.BorderWidth = 2
        Me.RECT_IIL.CornerRadius = 19
        Me.RECT_IIL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_IIL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_IIL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_IIL.Location = New System.Drawing.Point(389, 5)
        Me.RECT_IIL.Name = "RECT_IIL"
        Me.RECT_IIL.Size = New System.Drawing.Size(190, 40)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LLBL_PCOUNT)
        Me.Panel3.Controls.Add(Me.PB_PCOUNT)
        Me.Panel3.Controls.Add(Me.PB_IIL)
        Me.Panel3.Controls.Add(Me.LLBL_INVENOTYR_ASSIGN)
        Me.Panel3.Controls.Add(Me.LLBL_IIL)
        Me.Panel3.Controls.Add(Me.LLBL_INVENTORY_NEW)
        Me.Panel3.Controls.Add(Me.PB_DR_LIST)
        Me.Panel3.Controls.Add(Me.PB_INVENTORY_NEW)
        Me.Panel3.Controls.Add(Me.LLBL_DR_LIST)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PB_ITEM_DISTRIBUTION)
        Me.Panel3.Controls.Add(Me.LLBL_STOCKS)
        Me.Panel3.Controls.Add(Me.LLBL_ITEM_DISTRIBUTION)
        Me.Panel3.Controls.Add(Me.PB_STOCKS)
        Me.Panel3.Controls.Add(Me.ShapeContainer8)
        Me.Panel3.Location = New System.Drawing.Point(2, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1090, 51)
        Me.Panel3.TabIndex = 1464
        '
        'LLBL_PCOUNT
        '
        Me.LLBL_PCOUNT.AutoSize = True
        Me.LLBL_PCOUNT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PCOUNT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_PCOUNT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PCOUNT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PCOUNT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PCOUNT.Location = New System.Drawing.Point(831, 15)
        Me.LLBL_PCOUNT.Name = "LLBL_PCOUNT"
        Me.LLBL_PCOUNT.Size = New System.Drawing.Size(76, 19)
        Me.LLBL_PCOUNT.TabIndex = 1465
        Me.LLBL_PCOUNT.TabStop = True
        Me.LLBL_PCOUNT.Text = "PCOUNT"
        '
        'PB_PCOUNT
        '
        Me.PB_PCOUNT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_description_black_18dp
        Me.PB_PCOUNT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PCOUNT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PCOUNT.InitialImage = Nothing
        Me.PB_PCOUNT.Location = New System.Drawing.Point(799, 11)
        Me.PB_PCOUNT.Name = "PB_PCOUNT"
        Me.PB_PCOUNT.Size = New System.Drawing.Size(32, 28)
        Me.PB_PCOUNT.TabIndex = 1465
        Me.PB_PCOUNT.TabStop = False
        '
        'PB_IIL
        '
        Me.PB_IIL.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_list_alt_black_18dp
        Me.PB_IIL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_IIL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_IIL.InitialImage = Nothing
        Me.PB_IIL.Location = New System.Drawing.Point(401, 8)
        Me.PB_IIL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_IIL.Name = "PB_IIL"
        Me.PB_IIL.Size = New System.Drawing.Size(37, 34)
        Me.PB_IIL.TabIndex = 1537
        Me.PB_IIL.TabStop = False
        '
        'LLBL_IIL
        '
        Me.LLBL_IIL.AutoSize = True
        Me.LLBL_IIL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_IIL.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_IIL.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_IIL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_IIL.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_IIL.Location = New System.Drawing.Point(438, 16)
        Me.LLBL_IIL.Name = "LLBL_IIL"
        Me.LLBL_IIL.Size = New System.Drawing.Size(137, 19)
        Me.LLBL_IIL.TabIndex = 1536
        Me.LLBL_IIL.TabStop = True
        Me.LLBL_IIL.Text = "ISSUED ITEM LIST"
        '
        'PB_DR_LIST
        '
        Me.PB_DR_LIST.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_assignment_black_18dp
        Me.PB_DR_LIST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_DR_LIST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_DR_LIST.InitialImage = Nothing
        Me.PB_DR_LIST.Location = New System.Drawing.Point(283, 8)
        Me.PB_DR_LIST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_DR_LIST.Name = "PB_DR_LIST"
        Me.PB_DR_LIST.Size = New System.Drawing.Size(37, 34)
        Me.PB_DR_LIST.TabIndex = 1535
        Me.PB_DR_LIST.TabStop = False
        '
        'LLBL_DR_LIST
        '
        Me.LLBL_DR_LIST.AutoSize = True
        Me.LLBL_DR_LIST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_DR_LIST.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_DR_LIST.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_DR_LIST.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_DR_LIST.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_DR_LIST.Location = New System.Drawing.Point(319, 16)
        Me.LLBL_DR_LIST.Name = "LLBL_DR_LIST"
        Me.LLBL_DR_LIST.Size = New System.Drawing.Size(64, 19)
        Me.LLBL_DR_LIST.TabIndex = 1534
        Me.LLBL_DR_LIST.TabStop = True
        Me.LLBL_DR_LIST.Text = "DR LIST"
        '
        'ShapeContainer8
        '
        Me.ShapeContainer8.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer8.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer8.Name = "ShapeContainer8"
        Me.ShapeContainer8.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PCOUNT, Me.RECT_IIL, Me.RECT_DR_LIST, Me.RECT_STOCKS, Me.RECT_ITEM_DISTRIBUTION, Me.RECT_INVENTORY_CANCEL, Me.RECT_INVENTORY_NEW_SAVE})
        Me.ShapeContainer8.Size = New System.Drawing.Size(1090, 51)
        Me.ShapeContainer8.TabIndex = 0
        Me.ShapeContainer8.TabStop = False
        '
        'RECT_PCOUNT
        '
        Me.RECT_PCOUNT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PCOUNT.BorderWidth = 2
        Me.RECT_PCOUNT.CornerRadius = 19
        Me.RECT_PCOUNT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PCOUNT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PCOUNT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PCOUNT.Location = New System.Drawing.Point(790, 5)
        Me.RECT_PCOUNT.Name = "RECT_PCOUNT"
        Me.RECT_PCOUNT.Size = New System.Drawing.Size(121, 39)
        '
        'OFD_ITEM_DESC
        '
        Me.OFD_ITEM_DESC.FileName = "OpenFileDialog1"
        '
        'TBLM4_INV_ITEMS_IMGTableAdapter
        '
        Me.TBLM4_INV_ITEMS_IMGTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INV_ITEMS_IMGBindingSource
        '
        Me.TBLM4_INV_ITEMS_IMGBindingSource.DataSource = Me.DS_PROPERTYDB
        Me.TBLM4_INV_ITEMS_IMGBindingSource.Position = 0
        '
        'FRM_INVENTORY_ENCODING_ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 660)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.APNL_ITEMINFO)
        Me.Controls.Add(Me.LLBL_INVENTORY_EDIT)
        Me.Controls.Add(Me.PB_INVENTORY_EDIT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.ShapeContainer3)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FRM_INVENTORY_ENCODING_ADMIN"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.GRP_ITEMINFO.ResumeLayout(False)
        Me.GRP_ITEMINFO.PerformLayout()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PB_INVENTORY_VIEW_REPORT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBOX_SETTINGS.ResumeLayout(False)
        Me.GBOX_SETTINGS.PerformLayout()
        CType(Me.DGV_INV_ITEM_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_NEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_EDIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APNL_ITEMINFO.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PB_ITEM_IMAGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVITEMSNAMEMAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVITEMSOTHERSMAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVITEMSLENGMAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVITEMSCOLORMAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVITEMSSIZEMAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GRP_CONSUMABLE.ResumeLayout(False)
        Me.GRP_CONSUMABLE.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.GRP_LIST_ITEMS.ResumeLayout(False)
        Me.GRP_LIST_ITEMS.PerformLayout()
        CType(Me.DGV_ITEM_INFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ITEM_DISTRIBUTION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_CODE_GENERATORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_SIZEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_COLORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_STOCKS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_LENGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_OTHERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_NAMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PB_PCOUNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_IIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_DR_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_IMGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RECT_CATEGORY As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRREQUESTEDDATE As PowerPacks.RectangleShape
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RECT_BRAND As PowerPacks.RectangleShape
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV_INV_ITEM_LIST As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RECT_INVENTORY_SERIAL_NO As PowerPacks.RectangleShape
    Friend WithEvents RECT_SUB_CATEGORY As PowerPacks.RectangleShape
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
    Friend WithEvents WTXT_ITEM_SEARCH As WatermarkTextBox
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents PB_INVENTORY_CLEAR_SEARCH As PictureBox
    Friend WithEvents CB_INVENTORY_UNIT_TYPE As ComboBox
    Friend WithEvents RECT_INVENTORY_NEW_SAVE As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents LLBL_INVENTORY_NEW As LinkLabel
    Friend WithEvents PB_INVENTORY_NEW As PictureBox
    Friend WithEvents LLBL_INVENTORY_EDIT As LinkLabel
    Friend WithEvents PB_INVENTORY_EDIT As PictureBox
    Friend WithEvents RECT_INVENTORY_EDIT As PowerPacks.RectangleShape
    Friend WithEvents PB_INVENTORY_VIEW_REPORT As PictureBox
    Friend WithEvents LLBL_INVENTORY_VIEW_REPORT As LinkLabel
    Friend WithEvents RECT_INVENTORY_CANCEL As PowerPacks.RectangleShape
    'Friend WithEvents TblM4_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_ITEMSTableAdapter
    Friend WithEvents Label12 As Label
    Friend WithEvents APNL_ITEMINFO As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents LLBL_INVENTORY_ENCODING_HEADER As Label
    Friend WithEvents BTN_CLOSE_INVENTORY_MINI_CLOSE As Button
    Friend WithEvents BTN_INVENTORY_CANCEL As Button
    Friend WithEvents BTN_INVENTORY_SAVE As Button
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents BTN_ADD_CATEGORY As Button
    Friend WithEvents BTN_ADD_UNITTYPE As Button
    Friend WithEvents BTN_ADD_BRAND_PROVIDER As Button
    Friend WithEvents BTN_ADD_SUBCATEGORY As Button
    Friend WithEvents BTN_INVENTORY_MINIMIZE As Button
    Friend WithEvents BTN_INVENTORY_CLOSE As Button
    Friend WithEvents LLBL_INVENOTYR_ASSIGN As LinkLabel
    Friend WithEvents ITEMPROPERTYNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUNITCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMTOTALCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents CB_ITEM_USAGE As ComboBox
    Friend WithEvents GRP_CONSUMABLE As GroupBox
    Friend WithEvents RBT_DEPLETED As RadioButton
    Friend WithEvents RBT_PERPARTS As RadioButton
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DGV_ITEM_INFO As DataGridView
    Friend WithEvents LLBL_ADDITEM As LinkLabel
    Friend WithEvents RectangleShape13 As PowerPacks.RectangleShape
    Friend WithEvents LLBL_SAVE_ADD_ITEM As LinkLabel
    Friend WithEvents RectangleShape14 As PowerPacks.RectangleShape
    Friend WithEvents LLBL_CLOSE As LinkLabel
    Friend WithEvents RectangleShape15 As PowerPacks.RectangleShape
    Friend WithEvents GRP_LIST_ITEMS As GroupBox
    Friend WithEvents LLBL_REMOVE_ITEM As LinkLabel
    Friend WithEvents RECT_REMOVE_ITEM As PowerPacks.RectangleShape
    Friend WithEvents LLBL_EDIT_ITEM As LinkLabel
    Friend WithEvents RECT_EDIT_ITEM As PowerPacks.RectangleShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents ShapeContainer9 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape28 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape29 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape30 As PowerPacks.RectangleShape
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents ShapeContainer10 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape31 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape32 As PowerPacks.RectangleShape
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
    Friend WithEvents ShapeContainer7 As PowerPacks.ShapeContainer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RECT_ITEM_DISTRIBUTION As PowerPacks.RectangleShape
    Friend WithEvents LLBL_ITEM_DISTRIBUTION As LinkLabel
    Friend WithEvents PB_ITEM_DISTRIBUTION As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents CB_SUPPLY_TYPE As ComboBox
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents BTN_INV_SC As Button
    Friend WithEvents CB_INV_SC As ComboBox
    Friend WithEvents CB_INV_CAT As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ShapeContainer5 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape24 As PowerPacks.RectangleShape
    Friend WithEvents BTN_INV_CAT As Button
    Friend WithEvents CB_INV_BRAND As ComboBox
    Friend WithEvents BTN_INV_BR As Button
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents BTN_INV_SIZE As Button
    Friend WithEvents CB_INV_SIZE As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents RectangleShape16 As PowerPacks.RectangleShape
    Friend WithEvents BTN_INV_COLOR As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents RectangleShape17 As PowerPacks.RectangleShape
    Friend WithEvents CB_INV_COLOR As ComboBox
    Friend WithEvents VWM4_ITEM_LISTBindingSource As BindingSource
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TblM4INVENTORYCATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter
    Friend WithEvents TblM4INVENTORYSUBCATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_SUB_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter
    Friend WithEvents TblM4INVENTORYITEMBRANDBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMBRANDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter
    Friend WithEvents TBLM4INVITEMSSIZEMAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_SIZE_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter
    Friend WithEvents TBLM4INVITEMSCOLORMAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_COLOR_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter
    Friend WithEvents SPM4_ITEM_CODE_GENERATORTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_CODE_GENERATORTableAdapter
    Friend WithEvents SPM4_ITEM_CODE_GENERATORBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents TableAdapterManager As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents TBLM4_INV_ITEMS_SIZETableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_SIZETableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_SIZEBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_COLORTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_COLORTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_COLORBindingSource As BindingSource
    Friend WithEvents RECT_STOCKS As PowerPacks.RectangleShape
    Friend WithEvents PB_STOCKS As PictureBox
    Friend WithEvents LLBL_STOCKS As LinkLabel
    Friend WithEvents BTN_INV_OTHER_DESC As Button
    Friend WithEvents BTN_INV_LENGTH As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents RectangleShape19 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape18 As PowerPacks.RectangleShape
    Friend WithEvents Label18 As Label
    Friend WithEvents CB_INV_OTHER_DESC As ComboBox
    Friend WithEvents CB_INV_LENGTH As ComboBox
    Friend WithEvents TBLM4INVITEMSLENGMAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_LENG_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_LENG_MAINTableAdapter
    Friend WithEvents TBLM4INVITEMSOTHERSMAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_LENGTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_LENGTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_LENGBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_OTHERSTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_OTHERSTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_OTHERSBindingSource As BindingSource
    Friend WithEvents ITEMDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label20 As Label
    Friend WithEvents RectangleShape20 As PowerPacks.RectangleShape
    Friend WithEvents CB_INV_NAME As ComboBox
    Friend WithEvents BTN_INV_NAME As Button
    Friend WithEvents WTXT_INV_ALIAS_NAME As WatermarkTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents RectangleShape21 As PowerPacks.RectangleShape
    Friend WithEvents TBLM4INVITEMSNAMEMAINBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_NAME_MAINTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_NAME_MAINTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_NAMETableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_NAMETableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_NAMEBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMSTableAdapter
    Friend WithEvents TBLM4_INV_ITEMSBindingSource As BindingSource
    Friend WithEvents VWM4_ITEM_LISTTableAdapter As DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter
    Friend WithEvents RECT_IIL As PowerPacks.RectangleShape
    Friend WithEvents RECT_DR_LIST As PowerPacks.RectangleShape
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PB_IIL As PictureBox
    Friend WithEvents LLBL_IIL As LinkLabel
    Friend WithEvents PB_DR_LIST As PictureBox
    Friend WithEvents LLBL_DR_LIST As LinkLabel
    Friend WithEvents ShapeContainer8 As PowerPacks.ShapeContainer
    Friend WithEvents PB_PCOUNT As PictureBox
    Friend WithEvents RECT_PCOUNT As PowerPacks.RectangleShape
    Friend WithEvents LLBL_PCOUNT As LinkLabel
    Friend WithEvents PB_ITEM_IMAGE As PictureBox
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents OFD_ITEM_DESC As OpenFileDialog
    Friend WithEvents TBLM4_INV_ITEMS_IMGTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_IMGTableAdapter
    Friend WithEvents TBLM4_INV_ITEMS_IMGBindingSource As BindingSource
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SCNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SCSUBCATEGORYNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITBRNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITBRNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FULLDESC As DataGridViewTextBoxColumn
    Friend WithEvents ITEMSERIALNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COLRNUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COLRNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISACTIVEDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SIZENUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SIZENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCREATEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CREATEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISACTIVESIZEDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LENG_NUM As DataGridViewTextBoxColumn
    Friend WithEvents OTHER_NUM As DataGridViewTextBoxColumn
    Friend WithEvents ITM_NAME_NUM As DataGridViewTextBoxColumn
    Friend WithEvents ITM_NAME As DataGridViewTextBoxColumn
    Friend WithEvents NAME_IS_ACTIVE As DataGridViewCheckBoxColumn
    Friend WithEvents btnEdit As DataGridViewButtonColumn
    Friend WithEvents IMG_PATH As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
End Class
