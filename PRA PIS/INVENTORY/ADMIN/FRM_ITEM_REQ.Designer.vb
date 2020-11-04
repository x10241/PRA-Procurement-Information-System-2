<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ITEM_REQ
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INVENTORY_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PNL_BUTTONS = New System.Windows.Forms.Panel()
        Me.LLBL_INVENTORY_VIEW_REPORT = New System.Windows.Forms.LinkLabel()
        Me.LLBL_NEW_REQUISITION = New System.Windows.Forms.LinkLabel()
        Me.PB_INVENTORY_VIEW_REPORT = New System.Windows.Forms.PictureBox()
        Me.PB_NEW_REQUISITION = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_NEW_REQUISITION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.APNL_ITEMINFO = New System.Windows.Forms.Panel()
        Me.GRP_ITEMINFO = New System.Windows.Forms.GroupBox()
        Me.LLBL_SAVE = New System.Windows.Forms.LinkLabel()
        Me.PB_SAVE = New System.Windows.Forms.PictureBox()
        Me.WTXT_FOR_THE_PERIOD = New PRA_PIS.WatermarkTextBox()
        Me.LLBL_FOR_THE_PERIOD = New System.Windows.Forms.Label()
        Me.PB_SIGNATORIES = New System.Windows.Forms.PictureBox()
        Me.LLBL_SIGNATORIES = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WTXT_PURPOSE = New PRA_PIS.WatermarkTextBox()
        Me.LLBL_ADD_ITEM = New System.Windows.Forms.LinkLabel()
        Me.PB_ADD_ITEM = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_ITEM_LIST = New System.Windows.Forms.DataGridView()
        Me.ITM_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITM_DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PB_PRINT_PREVIEW = New System.Windows.Forms.PictureBox()
        Me.LLBL_PRINT_PREVIEW = New System.Windows.Forms.LinkLabel()
        Me.CB_REQUISITION_TYPE = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.LLBL_CLOSE = New System.Windows.Forms.LinkLabel()
        Me.LLBL_SAVE_ADD_ITEM = New System.Windows.Forms.LinkLabel()
        Me.WTXT_DATE_NEEDED = New PRA_PIS.WatermarkTextBox()
        Me.SPM4_CURRENTDATETIMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.LLBL_DATE_NEEDED = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBOX_PRNOQRCODE = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_SAVE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_FOR_THE_PERIOD = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_SIGNATORIES = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_ADD_ITEM = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRINT_PREVIEW = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape15 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_DATE_NEEDED = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRAPPCODE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
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
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.LLBL_INVENTORY_ENCODING_HEADER = New System.Windows.Forms.Label()
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE = New System.Windows.Forms.Button()
        Me.GRP_D_ITEMINFO = New System.Windows.Forms.GroupBox()
        Me.WTXT_D_REQ_TYPE = New PRA_PIS.WatermarkTextBox()
        Me.SPM4REQDETAILSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label29 = New System.Windows.Forms.Label()
        Me.WTXT_D_PURPOSE = New PRA_PIS.WatermarkTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FULLDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITMUNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITMQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQBYDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEAPPROVEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQTYPEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQPURPOSEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQDIVISIONDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEREQUESTEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQDATEPERIODDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQDATENEEDEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQBY1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQBYPOSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQAUTHDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQAUTHPOSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQAPPDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQAPPPOSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQISSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQISSPOSDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WTXT_D_FOR_THE_PER = New PRA_PIS.WatermarkTextBox()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.WTXT_D_DATE_NEEDED = New PRA_PIS.WatermarkTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer8 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape24 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape27 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape28 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape29 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape30 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape31 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DTITEMREQPREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_CUSTOM = New PRA_PIS.DS_CUSTOM()
        Me.TBLG3UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTITEMREQUISITIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GRP_LIST = New System.Windows.Forms.GroupBox()
        Me.PB_REQUISITION_SEARCH = New System.Windows.Forms.PictureBox()
        Me.PB_REQUISITION_CLEAR_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_REQUISITION_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.GBOX_SETTINGS = New System.Windows.Forms.GroupBox()
        Me.LLBL_RECORDSFOUND = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DGV_REQUISITION_LIST = New System.Windows.Forms.DataGridView()
        Me.REQNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQPURPOSEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQDIVISIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQDATEPERIODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_NEEDED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENCODED_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQBYPOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQAUTHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQAUTHPOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQAPPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQAPPPOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQISSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQISSPOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNPRINT = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BTNACTION_EDIT = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BTN_DETAILS = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.VWM4ITEMREQBYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.VWG3_PRIMARY_SIGNATORYDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VWG3_PRIMARY_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APNL_SIGNATORIES = New System.Windows.Forms.Panel()
        Me.WTXT_REQ_POSITION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_REQUESTED_BY = New PRA_PIS.WatermarkTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BTN_SIGN_CLOSE = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.WTXT_ISSU_POSI = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ISSU_NAME = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_APPR_POSI = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_APPR_NAME = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_AUTH_POSITION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_AUTHORIZEDNAME = New PRA_PIS.WatermarkTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PB_SET_DEFAULT = New System.Windows.Forms.PictureBox()
        Me.LLBL_SET_DEFAULT = New System.Windows.Forms.LinkLabel()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape20 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape19 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape18 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape17 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape16 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_SET_DEFAULT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.WTXT_REQ_ID = New System.Windows.Forms.TextBox()
        Me.WTXT_AUTH_ID = New System.Windows.Forms.TextBox()
        Me.WTXT_APPR_ID = New System.Windows.Forms.TextBox()
        Me.WTXT_ISSU_ID = New System.Windows.Forms.TextBox()
        Me.TXT_DATENOW = New System.Windows.Forms.TextBox()
        Me.VWM4_ITEM_REQ_BYTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_ITEM_REQ_BYTableAdapter()
        Me.SPM4EMPLSIGNLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_EMPL_SIGN_LISTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_EMPL_SIGN_LISTTableAdapter()
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_TYPETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_TYPETableAdapter()
        Me.TBLG3_UNITSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter()
        Me.TblG3_PRIMARY_SIGNATORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_PRIMARY_SIGNATORYTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.VWG3_PRIMARY_SIGNATORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.VWG3_PRIMARY_SIGNATORYTableAdapter()
        Me.TBLM4INVENTORYREQUISITIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INVENTORY_REQUISITIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_REQUISITIONTableAdapter()
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter()
        Me.TBLM4_INVENTORY_ITEM_REQUISITION1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INVENTORY_ITEM_REQUISITION1TableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_ITEM_REQUISITION1TableAdapter()
        Me.SPM4_CHK_CONTAINS_LETTERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_CHK_CONTAINS_LETTERTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_CHK_CONTAINS_LETTERTableAdapter()
        Me.PNL_ITEM_DETAILS = New System.Windows.Forms.Panel()
        Me.BTN_ITEM_REQ_ENC_CANCEL = New System.Windows.Forms.Button()
        Me.BTN_ADD_ITEM = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WTXT_ITEM_DESCRIPTION = New PRA_PIS.WatermarkTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.WTXT_QUANTITY = New PRA_PIS.WatermarkTextBox()
        Me.CB_UNIT_TYPE = New System.Windows.Forms.ComboBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_ITEM_DESCRIPTION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_QUANTITY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.VWM4_ITEM_LISTTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter()
        Me.VWM4_ITEM_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VWM4_ITEM_REQ_DESCTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_ITEM_REQ_DESCTableAdapter()
        Me.VWM4_ITEM_REQ_DESCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WatermarkTextBox2 = New PRA_PIS.WatermarkTextBox()
        Me.WatermarkTextBox1 = New PRA_PIS.WatermarkTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ShapeContainer7 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape22 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape21 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TBLM4_INV_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMSTableAdapter()
        Me.TBLM4_INV_ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_REQ_DETAILSTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_REQ_DETAILSTableAdapter()
        Me.SPM4_UQ_IQ_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_UQ_IQ_SIGNATORYTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_UQ_IQ_SIGNATORYTableAdapter()
        Me.SPM4_USER_SIGNATORYTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_USER_SIGNATORYTableAdapter()
        Me.SPM4_USER_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WTXT_REQU_POSI = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_REQU_NAME = New PRA_PIS.WatermarkTextBox()
        Me.SPM4_CURRENTDATETIMETableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_CURRENTDATETIMETableAdapter()
        Me.SPM4_ITEM_REQ_CODEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_REQ_CODETableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_REQ_CODETableAdapter()
        Me.PNL.SuspendLayout()
        Me.PNL_BUTTONS.SuspendLayout()
        CType(Me.PB_INVENTORY_VIEW_REPORT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_NEW_REQUISITION, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APNL_ITEMINFO.SuspendLayout()
        Me.GRP_ITEMINFO.SuspendLayout()
        CType(Me.PB_SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_SIGNATORIES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ADD_ITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_ITEM_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRINT_PREVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GRP_CONSUMABLE.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.GRP_D_ITEMINFO.SuspendLayout()
        CType(Me.SPM4REQDETAILSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTITEMREQPREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTITEMREQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_LIST.SuspendLayout()
        CType(Me.PB_REQUISITION_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_REQUISITION_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBOX_SETTINGS.SuspendLayout()
        CType(Me.DGV_REQUISITION_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4ITEMREQBYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWG3_PRIMARY_SIGNATORYDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APNL_SIGNATORIES.SuspendLayout()
        CType(Me.PB_SET_DEFAULT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4EMPLSIGNLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVENTORYREQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INVENTORY_ITEM_REQUISITION1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_CHK_CONTAINS_LETTERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_ITEM_DETAILS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_ITEM_REQ_DESCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_UQ_IQ_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_USER_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_REQ_CODEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PNL.TabIndex = 1407
        '
        'BTN_INVENTORY_MINIMIZE
        '
        Me.BTN_INVENTORY_MINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_MINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_INVENTORY_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_MINIMIZE.Location = New System.Drawing.Point(1008, 8)
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
        Me.BTN_INVENTORY_CLOSE.Location = New System.Drawing.Point(1043, 7)
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
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(23, 14)
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-10357, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-10310, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'PNL_BUTTONS
        '
        Me.PNL_BUTTONS.Controls.Add(Me.LLBL_INVENTORY_VIEW_REPORT)
        Me.PNL_BUTTONS.Controls.Add(Me.LLBL_NEW_REQUISITION)
        Me.PNL_BUTTONS.Controls.Add(Me.PB_INVENTORY_VIEW_REPORT)
        Me.PNL_BUTTONS.Controls.Add(Me.PB_NEW_REQUISITION)
        Me.PNL_BUTTONS.Controls.Add(Me.ShapeContainer5)
        Me.PNL_BUTTONS.Location = New System.Drawing.Point(7, 52)
        Me.PNL_BUTTONS.Name = "PNL_BUTTONS"
        Me.PNL_BUTTONS.Size = New System.Drawing.Size(389, 50)
        Me.PNL_BUTTONS.TabIndex = 1528
        '
        'LLBL_INVENTORY_VIEW_REPORT
        '
        Me.LLBL_INVENTORY_VIEW_REPORT.AutoSize = True
        Me.LLBL_INVENTORY_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_INVENTORY_VIEW_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_INVENTORY_VIEW_REPORT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_VIEW_REPORT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_INVENTORY_VIEW_REPORT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_INVENTORY_VIEW_REPORT.Location = New System.Drawing.Point(259, 15)
        Me.LLBL_INVENTORY_VIEW_REPORT.Name = "LLBL_INVENTORY_VIEW_REPORT"
        Me.LLBL_INVENTORY_VIEW_REPORT.Size = New System.Drawing.Size(115, 19)
        Me.LLBL_INVENTORY_VIEW_REPORT.TabIndex = 1459
        Me.LLBL_INVENTORY_VIEW_REPORT.TabStop = True
        Me.LLBL_INVENTORY_VIEW_REPORT.Text = "VIEW REPORT"
        '
        'LLBL_NEW_REQUISITION
        '
        Me.LLBL_NEW_REQUISITION.AutoSize = True
        Me.LLBL_NEW_REQUISITION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_NEW_REQUISITION.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_NEW_REQUISITION.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_NEW_REQUISITION.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_NEW_REQUISITION.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_NEW_REQUISITION.Location = New System.Drawing.Point(50, 15)
        Me.LLBL_NEW_REQUISITION.Name = "LLBL_NEW_REQUISITION"
        Me.LLBL_NEW_REQUISITION.Size = New System.Drawing.Size(152, 19)
        Me.LLBL_NEW_REQUISITION.TabIndex = 1455
        Me.LLBL_NEW_REQUISITION.TabStop = True
        Me.LLBL_NEW_REQUISITION.Text = "NEW REQUISITION"
        '
        'PB_INVENTORY_VIEW_REPORT
        '
        Me.PB_INVENTORY_VIEW_REPORT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.PB_INVENTORY_VIEW_REPORT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_VIEW_REPORT.InitialImage = Nothing
        Me.PB_INVENTORY_VIEW_REPORT.Location = New System.Drawing.Point(222, 10)
        Me.PB_INVENTORY_VIEW_REPORT.Name = "PB_INVENTORY_VIEW_REPORT"
        Me.PB_INVENTORY_VIEW_REPORT.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_VIEW_REPORT.TabIndex = 1460
        Me.PB_INVENTORY_VIEW_REPORT.TabStop = False
        '
        'PB_NEW_REQUISITION
        '
        Me.PB_NEW_REQUISITION.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_post_add_black_18dp
        Me.PB_NEW_REQUISITION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_NEW_REQUISITION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_NEW_REQUISITION.InitialImage = Nothing
        Me.PB_NEW_REQUISITION.Location = New System.Drawing.Point(12, 10)
        Me.PB_NEW_REQUISITION.Name = "PB_NEW_REQUISITION"
        Me.PB_NEW_REQUISITION.Size = New System.Drawing.Size(32, 28)
        Me.PB_NEW_REQUISITION.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_NEW_REQUISITION.TabIndex = 1456
        Me.PB_NEW_REQUISITION.TabStop = False
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RECT_NEW_REQUISITION})
        Me.ShapeContainer5.Size = New System.Drawing.Size(389, 50)
        Me.ShapeContainer5.TabIndex = 0
        Me.ShapeContainer5.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 19
        Me.RectangleShape5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape5.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(209, 4)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(172, 40)
        '
        'RECT_NEW_REQUISITION
        '
        Me.RECT_NEW_REQUISITION.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_NEW_REQUISITION.BorderWidth = 2
        Me.RECT_NEW_REQUISITION.CornerRadius = 19
        Me.RECT_NEW_REQUISITION.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_NEW_REQUISITION.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_NEW_REQUISITION.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_NEW_REQUISITION.Location = New System.Drawing.Point(3, 4)
        Me.RECT_NEW_REQUISITION.Name = "RECT_NEW_REQUISITION"
        Me.RECT_NEW_REQUISITION.Size = New System.Drawing.Size(202, 40)
        '
        'APNL_ITEMINFO
        '
        Me.APNL_ITEMINFO.BackColor = System.Drawing.Color.White
        Me.APNL_ITEMINFO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APNL_ITEMINFO.Controls.Add(Me.GRP_ITEMINFO)
        Me.APNL_ITEMINFO.Controls.Add(Me.GroupBox3)
        Me.APNL_ITEMINFO.Controls.Add(Me.Panel23)
        Me.APNL_ITEMINFO.Controls.Add(Me.BTN_CLOSE_INVENTORY_MINI_CLOSE)
        Me.APNL_ITEMINFO.Location = New System.Drawing.Point(1095, 0)
        Me.APNL_ITEMINFO.Name = "APNL_ITEMINFO"
        Me.APNL_ITEMINFO.Size = New System.Drawing.Size(584, 657)
        Me.APNL_ITEMINFO.TabIndex = 1530
        '
        'GRP_ITEMINFO
        '
        Me.GRP_ITEMINFO.BackColor = System.Drawing.SystemColors.Window
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_SAVE)
        Me.GRP_ITEMINFO.Controls.Add(Me.PB_SAVE)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_FOR_THE_PERIOD)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_FOR_THE_PERIOD)
        Me.GRP_ITEMINFO.Controls.Add(Me.PB_SIGNATORIES)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_SIGNATORIES)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label6)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_PURPOSE)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_ADD_ITEM)
        Me.GRP_ITEMINFO.Controls.Add(Me.PB_ADD_ITEM)
        Me.GRP_ITEMINFO.Controls.Add(Me.Panel1)
        Me.GRP_ITEMINFO.Controls.Add(Me.PB_PRINT_PREVIEW)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_PRINT_PREVIEW)
        Me.GRP_ITEMINFO.Controls.Add(Me.CB_REQUISITION_TYPE)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_CLOSE)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_SAVE_ADD_ITEM)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_DATE_NEEDED)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_DATE_NEEDED)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label1)
        Me.GRP_ITEMINFO.Controls.Add(Me.PBOX_PRNOQRCODE)
        Me.GRP_ITEMINFO.Controls.Add(Me.ShapeContainer3)
        Me.GRP_ITEMINFO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRP_ITEMINFO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GRP_ITEMINFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GRP_ITEMINFO.Location = New System.Drawing.Point(47, 42)
        Me.GRP_ITEMINFO.Name = "GRP_ITEMINFO"
        Me.GRP_ITEMINFO.Size = New System.Drawing.Size(530, 610)
        Me.GRP_ITEMINFO.TabIndex = 1443
        Me.GRP_ITEMINFO.TabStop = False
        Me.GRP_ITEMINFO.Text = "Item Details"
        '
        'LLBL_SAVE
        '
        Me.LLBL_SAVE.AutoSize = True
        Me.LLBL_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_SAVE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_SAVE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE.Location = New System.Drawing.Point(468, 575)
        Me.LLBL_SAVE.Name = "LLBL_SAVE"
        Me.LLBL_SAVE.Size = New System.Drawing.Size(50, 19)
        Me.LLBL_SAVE.TabIndex = 1497
        Me.LLBL_SAVE.TabStop = True
        Me.LLBL_SAVE.Text = "Save"
        '
        'PB_SAVE
        '
        Me.PB_SAVE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_save_black_18dp
        Me.PB_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_SAVE.InitialImage = Nothing
        Me.PB_SAVE.Location = New System.Drawing.Point(435, 572)
        Me.PB_SAVE.Name = "PB_SAVE"
        Me.PB_SAVE.Size = New System.Drawing.Size(32, 28)
        Me.PB_SAVE.TabIndex = 1550
        Me.PB_SAVE.TabStop = False
        '
        'WTXT_FOR_THE_PERIOD
        '
        Me.WTXT_FOR_THE_PERIOD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_FOR_THE_PERIOD.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_FOR_THE_PERIOD.Location = New System.Drawing.Point(272, 39)
        Me.WTXT_FOR_THE_PERIOD.Name = "WTXT_FOR_THE_PERIOD"
        Me.WTXT_FOR_THE_PERIOD.Size = New System.Drawing.Size(247, 21)
        Me.WTXT_FOR_THE_PERIOD.TabIndex = 1490
        Me.WTXT_FOR_THE_PERIOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_FOR_THE_PERIOD.Watermark = "MM/DD/YYYY - MM/DD/YYYY"
        '
        'LLBL_FOR_THE_PERIOD
        '
        Me.LLBL_FOR_THE_PERIOD.AutoSize = True
        Me.LLBL_FOR_THE_PERIOD.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_FOR_THE_PERIOD.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_FOR_THE_PERIOD.Location = New System.Drawing.Point(275, 20)
        Me.LLBL_FOR_THE_PERIOD.Name = "LLBL_FOR_THE_PERIOD"
        Me.LLBL_FOR_THE_PERIOD.Size = New System.Drawing.Size(98, 17)
        Me.LLBL_FOR_THE_PERIOD.TabIndex = 1435
        Me.LLBL_FOR_THE_PERIOD.Text = "For the period"
        '
        'PB_SIGNATORIES
        '
        Me.PB_SIGNATORIES.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_assignment_black_18dp
        Me.PB_SIGNATORIES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_SIGNATORIES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_SIGNATORIES.InitialImage = Nothing
        Me.PB_SIGNATORIES.Location = New System.Drawing.Point(125, 570)
        Me.PB_SIGNATORIES.Name = "PB_SIGNATORIES"
        Me.PB_SIGNATORIES.Size = New System.Drawing.Size(32, 28)
        Me.PB_SIGNATORIES.TabIndex = 1538
        Me.PB_SIGNATORIES.TabStop = False
        '
        'LLBL_SIGNATORIES
        '
        Me.LLBL_SIGNATORIES.AutoSize = True
        Me.LLBL_SIGNATORIES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_SIGNATORIES.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_SIGNATORIES.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_SIGNATORIES.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_SIGNATORIES.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_SIGNATORIES.Location = New System.Drawing.Point(158, 575)
        Me.LLBL_SIGNATORIES.Name = "LLBL_SIGNATORIES"
        Me.LLBL_SIGNATORIES.Size = New System.Drawing.Size(97, 19)
        Me.LLBL_SIGNATORIES.TabIndex = 1537
        Me.LLBL_SIGNATORIES.TabStop = True
        Me.LLBL_SIGNATORIES.Text = "Signatories"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(17, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 1533
        Me.Label6.Text = "Purpose"
        '
        'WTXT_PURPOSE
        '
        Me.WTXT_PURPOSE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PURPOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_PURPOSE.Location = New System.Drawing.Point(10, 81)
        Me.WTXT_PURPOSE.Multiline = True
        Me.WTXT_PURPOSE.Name = "WTXT_PURPOSE"
        Me.WTXT_PURPOSE.Size = New System.Drawing.Size(362, 24)
        Me.WTXT_PURPOSE.TabIndex = 1532
        Me.WTXT_PURPOSE.Watermark = ""
        '
        'LLBL_ADD_ITEM
        '
        Me.LLBL_ADD_ITEM.AutoSize = True
        Me.LLBL_ADD_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_ADD_ITEM.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_ADD_ITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_ADD_ITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_ADD_ITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_ADD_ITEM.Location = New System.Drawing.Point(428, 129)
        Me.LLBL_ADD_ITEM.Name = "LLBL_ADD_ITEM"
        Me.LLBL_ADD_ITEM.Size = New System.Drawing.Size(84, 19)
        Me.LLBL_ADD_ITEM.TabIndex = 1500
        Me.LLBL_ADD_ITEM.TabStop = True
        Me.LLBL_ADD_ITEM.Text = "Add item"
        '
        'PB_ADD_ITEM
        '
        Me.PB_ADD_ITEM.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_post_add_black_18dp
        Me.PB_ADD_ITEM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_ADD_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ADD_ITEM.InitialImage = Nothing
        Me.PB_ADD_ITEM.Location = New System.Drawing.Point(392, 124)
        Me.PB_ADD_ITEM.Name = "PB_ADD_ITEM"
        Me.PB_ADD_ITEM.Size = New System.Drawing.Size(32, 28)
        Me.PB_ADD_ITEM.TabIndex = 1499
        Me.PB_ADD_ITEM.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DGV_ITEM_LIST)
        Me.Panel1.Location = New System.Drawing.Point(3, 163)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 401)
        Me.Panel1.TabIndex = 1498
        '
        'DGV_ITEM_LIST
        '
        Me.DGV_ITEM_LIST.AllowUserToAddRows = False
        Me.DGV_ITEM_LIST.AllowUserToDeleteRows = False
        Me.DGV_ITEM_LIST.AllowUserToResizeColumns = False
        Me.DGV_ITEM_LIST.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_ITEM_LIST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ITEM_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ITEM_LIST.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ITEM_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ITEM_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEM_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITM_CODE, Me.ITM_DESCRIPTION, Me.qty, Me.UNIT, Me.action})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ITEM_LIST.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ITEM_LIST.Location = New System.Drawing.Point(3, 2)
        Me.DGV_ITEM_LIST.MultiSelect = False
        Me.DGV_ITEM_LIST.Name = "DGV_ITEM_LIST"
        Me.DGV_ITEM_LIST.ReadOnly = True
        Me.DGV_ITEM_LIST.RowHeadersVisible = False
        Me.DGV_ITEM_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEM_LIST.Size = New System.Drawing.Size(513, 394)
        Me.DGV_ITEM_LIST.TabIndex = 1488
        '
        'ITM_CODE
        '
        Me.ITM_CODE.HeaderText = "ITM_CODE"
        Me.ITM_CODE.Name = "ITM_CODE"
        Me.ITM_CODE.ReadOnly = True
        Me.ITM_CODE.Visible = False
        '
        'ITM_DESCRIPTION
        '
        Me.ITM_DESCRIPTION.FillWeight = 14.90257!
        Me.ITM_DESCRIPTION.HeaderText = "Item Description"
        Me.ITM_DESCRIPTION.Name = "ITM_DESCRIPTION"
        Me.ITM_DESCRIPTION.ReadOnly = True
        '
        'qty
        '
        Me.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.qty.FillWeight = 72.49901!
        Me.qty.HeaderText = "Quantity"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 90
        '
        'UNIT
        '
        Me.UNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UNIT.FillWeight = 212.5984!
        Me.UNIT.HeaderText = "Unit"
        Me.UNIT.Name = "UNIT"
        Me.UNIT.ReadOnly = True
        Me.UNIT.Width = 90
        '
        'action
        '
        Me.action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.action.HeaderText = "Action"
        Me.action.Name = "action"
        Me.action.ReadOnly = True
        Me.action.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.action.Text = "Remove"
        Me.action.UseColumnTextForButtonValue = True
        Me.action.Width = 70
        '
        'PB_PRINT_PREVIEW
        '
        Me.PB_PRINT_PREVIEW.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.PB_PRINT_PREVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PRINT_PREVIEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PRINT_PREVIEW.InitialImage = Nothing
        Me.PB_PRINT_PREVIEW.Location = New System.Drawing.Point(275, 572)
        Me.PB_PRINT_PREVIEW.Name = "PB_PRINT_PREVIEW"
        Me.PB_PRINT_PREVIEW.Size = New System.Drawing.Size(32, 28)
        Me.PB_PRINT_PREVIEW.TabIndex = 1497
        Me.PB_PRINT_PREVIEW.TabStop = False
        '
        'LLBL_PRINT_PREVIEW
        '
        Me.LLBL_PRINT_PREVIEW.AutoSize = True
        Me.LLBL_PRINT_PREVIEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PRINT_PREVIEW.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_PRINT_PREVIEW.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PRINT_PREVIEW.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PRINT_PREVIEW.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PRINT_PREVIEW.Location = New System.Drawing.Point(308, 575)
        Me.LLBL_PRINT_PREVIEW.Name = "LLBL_PRINT_PREVIEW"
        Me.LLBL_PRINT_PREVIEW.Size = New System.Drawing.Size(112, 19)
        Me.LLBL_PRINT_PREVIEW.TabIndex = 1496
        Me.LLBL_PRINT_PREVIEW.TabStop = True
        Me.LLBL_PRINT_PREVIEW.Text = "Print Preview"
        '
        'CB_REQUISITION_TYPE
        '
        Me.CB_REQUISITION_TYPE.DataSource = Me.TblM4INVENTORYTYPEBindingSource
        Me.CB_REQUISITION_TYPE.DisplayMember = "INV_DESC"
        Me.CB_REQUISITION_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_REQUISITION_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_REQUISITION_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_REQUISITION_TYPE.FormattingEnabled = True
        Me.CB_REQUISITION_TYPE.Location = New System.Drawing.Point(9, 36)
        Me.CB_REQUISITION_TYPE.Name = "CB_REQUISITION_TYPE"
        Me.CB_REQUISITION_TYPE.Size = New System.Drawing.Size(253, 27)
        Me.CB_REQUISITION_TYPE.TabIndex = 1489
        Me.CB_REQUISITION_TYPE.ValueMember = "INV_CODE"
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
        'LLBL_CLOSE
        '
        Me.LLBL_CLOSE.AutoSize = True
        Me.LLBL_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_CLOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_CLOSE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_CLOSE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_CLOSE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_CLOSE.Location = New System.Drawing.Point(454, 631)
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
        Me.LLBL_SAVE_ADD_ITEM.Location = New System.Drawing.Point(393, 631)
        Me.LLBL_SAVE_ADD_ITEM.Name = "LLBL_SAVE_ADD_ITEM"
        Me.LLBL_SAVE_ADD_ITEM.Size = New System.Drawing.Size(46, 19)
        Me.LLBL_SAVE_ADD_ITEM.TabIndex = 1463
        Me.LLBL_SAVE_ADD_ITEM.TabStop = True
        Me.LLBL_SAVE_ADD_ITEM.Text = "ADD"
        '
        'WTXT_DATE_NEEDED
        '
        Me.WTXT_DATE_NEEDED.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DATE_NEEDED.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4_CURRENTDATETIMEBindingSource, "datenowFormatted", True))
        Me.WTXT_DATE_NEEDED.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DATE_NEEDED.Location = New System.Drawing.Point(387, 84)
        Me.WTXT_DATE_NEEDED.Name = "WTXT_DATE_NEEDED"
        Me.WTXT_DATE_NEEDED.Size = New System.Drawing.Size(133, 21)
        Me.WTXT_DATE_NEEDED.TabIndex = 1417
        Me.WTXT_DATE_NEEDED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_DATE_NEEDED.Watermark = "MM/DD/YYYY"
        '
        'SPM4_CURRENTDATETIMEBindingSource
        '
        Me.SPM4_CURRENTDATETIMEBindingSource.DataMember = "SPM4_CURRENTDATETIME"
        Me.SPM4_CURRENTDATETIMEBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LLBL_DATE_NEEDED
        '
        Me.LLBL_DATE_NEEDED.AutoSize = True
        Me.LLBL_DATE_NEEDED.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_DATE_NEEDED.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_DATE_NEEDED.Location = New System.Drawing.Point(390, 68)
        Me.LLBL_DATE_NEEDED.Name = "LLBL_DATE_NEEDED"
        Me.LLBL_DATE_NEEDED.Size = New System.Drawing.Size(96, 17)
        Me.LLBL_DATE_NEEDED.TabIndex = 1334
        Me.LLBL_DATE_NEEDED.Text = "Date Needed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 1433
        Me.Label1.Text = "Requisition Type"
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
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_SAVE, Me.RECT_FOR_THE_PERIOD, Me.RECT_SIGNATORIES, Me.RectangleShape1, Me.RECT_ADD_ITEM, Me.RECT_PRINT_PREVIEW, Me.RectangleShape15, Me.RectangleShape14, Me.RECT_DATE_NEEDED, Me.RECT_PRAPPCODE})
        Me.ShapeContainer3.Size = New System.Drawing.Size(524, 588)
        Me.ShapeContainer3.TabIndex = 1
        Me.ShapeContainer3.TabStop = False
        '
        'RECT_SAVE
        '
        Me.RECT_SAVE.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_SAVE.BorderWidth = 2
        Me.RECT_SAVE.CornerRadius = 16
        Me.RECT_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_SAVE.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_SAVE.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_SAVE.Location = New System.Drawing.Point(423, 549)
        Me.RECT_SAVE.Name = "RECT_SAVE"
        Me.RECT_SAVE.Size = New System.Drawing.Size(99, 34)
        '
        'RECT_FOR_THE_PERIOD
        '
        Me.RECT_FOR_THE_PERIOD.BorderColor = System.Drawing.Color.Gray
        Me.RECT_FOR_THE_PERIOD.CornerRadius = 5
        Me.RECT_FOR_THE_PERIOD.Location = New System.Drawing.Point(265, 13)
        Me.RECT_FOR_THE_PERIOD.Name = "RECT_FOR_THE_PERIOD"
        Me.RECT_FOR_THE_PERIOD.Size = New System.Drawing.Size(255, 33)
        '
        'RECT_SIGNATORIES
        '
        Me.RECT_SIGNATORIES.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_SIGNATORIES.BorderWidth = 2
        Me.RECT_SIGNATORIES.CornerRadius = 16
        Me.RECT_SIGNATORIES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_SIGNATORIES.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_SIGNATORIES.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_SIGNATORIES.Location = New System.Drawing.Point(110, 548)
        Me.RECT_SIGNATORIES.Name = "RECT_SIGNATORIES"
        Me.RECT_SIGNATORIES.Size = New System.Drawing.Size(147, 34)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(2, 57)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(372, 33)
        '
        'RECT_ADD_ITEM
        '
        Me.RECT_ADD_ITEM.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ADD_ITEM.BorderWidth = 2
        Me.RECT_ADD_ITEM.CornerRadius = 19
        Me.RECT_ADD_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_ADD_ITEM.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_ADD_ITEM.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_ADD_ITEM.Location = New System.Drawing.Point(375, 98)
        Me.RECT_ADD_ITEM.Name = "RECT_ADD_ITEM"
        Me.RECT_ADD_ITEM.Size = New System.Drawing.Size(141, 40)
        '
        'RECT_PRINT_PREVIEW
        '
        Me.RECT_PRINT_PREVIEW.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRINT_PREVIEW.BorderWidth = 2
        Me.RECT_PRINT_PREVIEW.CornerRadius = 16
        Me.RECT_PRINT_PREVIEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_PRINT_PREVIEW.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRINT_PREVIEW.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRINT_PREVIEW.Location = New System.Drawing.Point(260, 549)
        Me.RECT_PRINT_PREVIEW.Name = "RECT_PRINT_PREVIEW"
        Me.RECT_PRINT_PREVIEW.Size = New System.Drawing.Size(161, 33)
        '
        'RectangleShape15
        '
        Me.RectangleShape15.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape15.BorderWidth = 2
        Me.RectangleShape15.CornerRadius = 19
        Me.RectangleShape15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape15.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape15.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape15.Location = New System.Drawing.Point(447, 595)
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
        Me.RectangleShape14.Location = New System.Drawing.Point(382, 595)
        Me.RectangleShape14.Name = "RectangleShape14"
        Me.RectangleShape14.Size = New System.Drawing.Size(62, 39)
        '
        'RECT_DATE_NEEDED
        '
        Me.RECT_DATE_NEEDED.BorderColor = System.Drawing.Color.Gray
        Me.RECT_DATE_NEEDED.CornerRadius = 5
        Me.RECT_DATE_NEEDED.Location = New System.Drawing.Point(379, 57)
        Me.RECT_DATE_NEEDED.Name = "RECT_DATE_NEEDED"
        Me.RECT_DATE_NEEDED.Size = New System.Drawing.Size(142, 33)
        '
        'RECT_PRAPPCODE
        '
        Me.RECT_PRAPPCODE.BorderColor = System.Drawing.Color.Gray
        Me.RECT_PRAPPCODE.CornerRadius = 5
        Me.RECT_PRAPPCODE.Location = New System.Drawing.Point(2, 14)
        Me.RECT_PRAPPCODE.Name = "RECT_PRAPPCODE"
        Me.RECT_PRAPPCODE.Size = New System.Drawing.Size(260, 32)
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
        'CB_ACQUISITION_VALUE
        '
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
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel23.Controls.Add(Me.LLBL_INVENTORY_ENCODING_HEADER)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(45, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(537, 35)
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
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Image = Global.PRA_PIS.My.Resources.Resources.outline_double_arrow_black_18dp
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Location = New System.Drawing.Point(0, 0)
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Name = "BTN_CLOSE_INVENTORY_MINI_CLOSE"
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.Size = New System.Drawing.Size(45, 655)
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.TabIndex = 0
        Me.BTN_CLOSE_INVENTORY_MINI_CLOSE.UseVisualStyleBackColor = True
        '
        'GRP_D_ITEMINFO
        '
        Me.GRP_D_ITEMINFO.BackColor = System.Drawing.SystemColors.Window
        Me.GRP_D_ITEMINFO.Controls.Add(Me.WTXT_D_REQ_TYPE)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.Label29)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.WTXT_D_PURPOSE)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.Panel3)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.WTXT_D_FOR_THE_PER)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.LinkLabel7)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.LinkLabel8)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.WTXT_D_DATE_NEEDED)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.Label30)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.Label31)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.Label32)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.PictureBox7)
        Me.GRP_D_ITEMINFO.Controls.Add(Me.ShapeContainer8)
        Me.GRP_D_ITEMINFO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRP_D_ITEMINFO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GRP_D_ITEMINFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GRP_D_ITEMINFO.Location = New System.Drawing.Point(2030, 68)
        Me.GRP_D_ITEMINFO.Name = "GRP_D_ITEMINFO"
        Me.GRP_D_ITEMINFO.Size = New System.Drawing.Size(530, 580)
        Me.GRP_D_ITEMINFO.TabIndex = 1444
        Me.GRP_D_ITEMINFO.TabStop = False
        Me.GRP_D_ITEMINFO.Text = "Item Details"
        Me.GRP_D_ITEMINFO.Visible = False
        '
        'WTXT_D_REQ_TYPE
        '
        Me.WTXT_D_REQ_TYPE.BackColor = System.Drawing.Color.White
        Me.WTXT_D_REQ_TYPE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_D_REQ_TYPE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4REQDETAILSBindingSource, "REQ_TYPE", True))
        Me.WTXT_D_REQ_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_D_REQ_TYPE.Location = New System.Drawing.Point(9, 38)
        Me.WTXT_D_REQ_TYPE.Multiline = True
        Me.WTXT_D_REQ_TYPE.Name = "WTXT_D_REQ_TYPE"
        Me.WTXT_D_REQ_TYPE.ReadOnly = True
        Me.WTXT_D_REQ_TYPE.Size = New System.Drawing.Size(252, 24)
        Me.WTXT_D_REQ_TYPE.TabIndex = 1550
        Me.WTXT_D_REQ_TYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_D_REQ_TYPE.Watermark = ""
        '
        'SPM4REQDETAILSBindingSource
        '
        Me.SPM4REQDETAILSBindingSource.DataMember = "SPM4_REQ_DETAILS"
        Me.SPM4REQDETAILSBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DimGray
        Me.Label29.Location = New System.Drawing.Point(17, 68)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(59, 17)
        Me.Label29.TabIndex = 1533
        Me.Label29.Text = "Purpose"
        '
        'WTXT_D_PURPOSE
        '
        Me.WTXT_D_PURPOSE.BackColor = System.Drawing.Color.White
        Me.WTXT_D_PURPOSE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_D_PURPOSE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4REQDETAILSBindingSource, "REQ_PURPOSE", True))
        Me.WTXT_D_PURPOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_D_PURPOSE.Location = New System.Drawing.Point(10, 81)
        Me.WTXT_D_PURPOSE.Multiline = True
        Me.WTXT_D_PURPOSE.Name = "WTXT_D_PURPOSE"
        Me.WTXT_D_PURPOSE.ReadOnly = True
        Me.WTXT_D_PURPOSE.Size = New System.Drawing.Size(362, 24)
        Me.WTXT_D_PURPOSE.TabIndex = 1532
        Me.WTXT_D_PURPOSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_D_PURPOSE.Watermark = ""
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(5, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(519, 460)
        Me.Panel3.TabIndex = 1498
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FULLDESCDataGridViewTextBoxColumn, Me.ITMUNITDataGridViewTextBoxColumn, Me.ITMQTYDataGridViewTextBoxColumn, Me.APPQTYDataGridViewTextBoxColumn, Me.REQBYDataGridViewTextBoxColumn1, Me.DATEAPPROVEDDataGridViewTextBoxColumn, Me.REQTYPEDataGridViewTextBoxColumn1, Me.REQPURPOSEDataGridViewTextBoxColumn1, Me.REQDIVISIONDataGridViewTextBoxColumn1, Me.EMPNODataGridViewTextBoxColumn, Me.DATEREQUESTEDDataGridViewTextBoxColumn, Me.REQDATEPERIODDataGridViewTextBoxColumn1, Me.REQDATENEEDEDDataGridViewTextBoxColumn, Me.REQBY1DataGridViewTextBoxColumn, Me.REQBYPOSDataGridViewTextBoxColumn1, Me.REQAUTHDataGridViewTextBoxColumn1, Me.REQAUTHPOSDataGridViewTextBoxColumn1, Me.REQAPPDataGridViewTextBoxColumn1, Me.REQAPPPOSDataGridViewTextBoxColumn1, Me.REQISSDataGridViewTextBoxColumn1, Me.REQISSPOSDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.SPM4REQDETAILSBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(511, 452)
        Me.DataGridView1.TabIndex = 1488
        '
        'FULLDESCDataGridViewTextBoxColumn
        '
        Me.FULLDESCDataGridViewTextBoxColumn.DataPropertyName = "FULLDESC"
        Me.FULLDESCDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.FULLDESCDataGridViewTextBoxColumn.Name = "FULLDESCDataGridViewTextBoxColumn"
        Me.FULLDESCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITMUNITDataGridViewTextBoxColumn
        '
        Me.ITMUNITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITMUNITDataGridViewTextBoxColumn.DataPropertyName = "ITM_UNIT"
        Me.ITMUNITDataGridViewTextBoxColumn.HeaderText = "Unit"
        Me.ITMUNITDataGridViewTextBoxColumn.Name = "ITMUNITDataGridViewTextBoxColumn"
        Me.ITMUNITDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITMUNITDataGridViewTextBoxColumn.Width = 60
        '
        'ITMQTYDataGridViewTextBoxColumn
        '
        Me.ITMQTYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITMQTYDataGridViewTextBoxColumn.DataPropertyName = "ITM_QTY"
        Me.ITMQTYDataGridViewTextBoxColumn.HeaderText = "Req. Qty"
        Me.ITMQTYDataGridViewTextBoxColumn.Name = "ITMQTYDataGridViewTextBoxColumn"
        Me.ITMQTYDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITMQTYDataGridViewTextBoxColumn.Width = 90
        '
        'APPQTYDataGridViewTextBoxColumn
        '
        Me.APPQTYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.APPQTYDataGridViewTextBoxColumn.DataPropertyName = "APP_QTY"
        Me.APPQTYDataGridViewTextBoxColumn.HeaderText = "App. Qty"
        Me.APPQTYDataGridViewTextBoxColumn.Name = "APPQTYDataGridViewTextBoxColumn"
        Me.APPQTYDataGridViewTextBoxColumn.ReadOnly = True
        Me.APPQTYDataGridViewTextBoxColumn.Width = 90
        '
        'REQBYDataGridViewTextBoxColumn1
        '
        Me.REQBYDataGridViewTextBoxColumn1.DataPropertyName = "REQ_BY"
        Me.REQBYDataGridViewTextBoxColumn1.HeaderText = "REQ_BY"
        Me.REQBYDataGridViewTextBoxColumn1.Name = "REQBYDataGridViewTextBoxColumn1"
        Me.REQBYDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQBYDataGridViewTextBoxColumn1.Visible = False
        '
        'DATEAPPROVEDDataGridViewTextBoxColumn
        '
        Me.DATEAPPROVEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_APPROVED"
        Me.DATEAPPROVEDDataGridViewTextBoxColumn.HeaderText = "DATE_APPROVED"
        Me.DATEAPPROVEDDataGridViewTextBoxColumn.Name = "DATEAPPROVEDDataGridViewTextBoxColumn"
        Me.DATEAPPROVEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DATEAPPROVEDDataGridViewTextBoxColumn.Visible = False
        '
        'REQTYPEDataGridViewTextBoxColumn1
        '
        Me.REQTYPEDataGridViewTextBoxColumn1.DataPropertyName = "REQ_TYPE"
        Me.REQTYPEDataGridViewTextBoxColumn1.HeaderText = "REQ_TYPE"
        Me.REQTYPEDataGridViewTextBoxColumn1.Name = "REQTYPEDataGridViewTextBoxColumn1"
        Me.REQTYPEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQTYPEDataGridViewTextBoxColumn1.Visible = False
        '
        'REQPURPOSEDataGridViewTextBoxColumn1
        '
        Me.REQPURPOSEDataGridViewTextBoxColumn1.DataPropertyName = "REQ_PURPOSE"
        Me.REQPURPOSEDataGridViewTextBoxColumn1.HeaderText = "REQ_PURPOSE"
        Me.REQPURPOSEDataGridViewTextBoxColumn1.Name = "REQPURPOSEDataGridViewTextBoxColumn1"
        Me.REQPURPOSEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQPURPOSEDataGridViewTextBoxColumn1.Visible = False
        '
        'REQDIVISIONDataGridViewTextBoxColumn1
        '
        Me.REQDIVISIONDataGridViewTextBoxColumn1.DataPropertyName = "REQ_DIVISION"
        Me.REQDIVISIONDataGridViewTextBoxColumn1.HeaderText = "REQ_DIVISION"
        Me.REQDIVISIONDataGridViewTextBoxColumn1.Name = "REQDIVISIONDataGridViewTextBoxColumn1"
        Me.REQDIVISIONDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQDIVISIONDataGridViewTextBoxColumn1.Visible = False
        '
        'EMPNODataGridViewTextBoxColumn
        '
        Me.EMPNODataGridViewTextBoxColumn.DataPropertyName = "EMP_NO"
        Me.EMPNODataGridViewTextBoxColumn.HeaderText = "EMP_NO"
        Me.EMPNODataGridViewTextBoxColumn.Name = "EMPNODataGridViewTextBoxColumn"
        Me.EMPNODataGridViewTextBoxColumn.ReadOnly = True
        Me.EMPNODataGridViewTextBoxColumn.Visible = False
        '
        'DATEREQUESTEDDataGridViewTextBoxColumn
        '
        Me.DATEREQUESTEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_REQUESTED"
        Me.DATEREQUESTEDDataGridViewTextBoxColumn.HeaderText = "DATE_REQUESTED"
        Me.DATEREQUESTEDDataGridViewTextBoxColumn.Name = "DATEREQUESTEDDataGridViewTextBoxColumn"
        Me.DATEREQUESTEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DATEREQUESTEDDataGridViewTextBoxColumn.Visible = False
        '
        'REQDATEPERIODDataGridViewTextBoxColumn1
        '
        Me.REQDATEPERIODDataGridViewTextBoxColumn1.DataPropertyName = "REQ_DATE_PERIOD"
        Me.REQDATEPERIODDataGridViewTextBoxColumn1.HeaderText = "REQ_DATE_PERIOD"
        Me.REQDATEPERIODDataGridViewTextBoxColumn1.Name = "REQDATEPERIODDataGridViewTextBoxColumn1"
        Me.REQDATEPERIODDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQDATEPERIODDataGridViewTextBoxColumn1.Visible = False
        '
        'REQDATENEEDEDDataGridViewTextBoxColumn
        '
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.DataPropertyName = "REQ_DATE_NEEDED"
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.HeaderText = "REQ_DATE_NEEDED"
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.Name = "REQDATENEEDEDDataGridViewTextBoxColumn"
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.Visible = False
        '
        'REQBY1DataGridViewTextBoxColumn
        '
        Me.REQBY1DataGridViewTextBoxColumn.DataPropertyName = "REQ_BY1"
        Me.REQBY1DataGridViewTextBoxColumn.HeaderText = "REQ_BY1"
        Me.REQBY1DataGridViewTextBoxColumn.Name = "REQBY1DataGridViewTextBoxColumn"
        Me.REQBY1DataGridViewTextBoxColumn.ReadOnly = True
        Me.REQBY1DataGridViewTextBoxColumn.Visible = False
        '
        'REQBYPOSDataGridViewTextBoxColumn1
        '
        Me.REQBYPOSDataGridViewTextBoxColumn1.DataPropertyName = "REQ_BY_POS"
        Me.REQBYPOSDataGridViewTextBoxColumn1.HeaderText = "REQ_BY_POS"
        Me.REQBYPOSDataGridViewTextBoxColumn1.Name = "REQBYPOSDataGridViewTextBoxColumn1"
        Me.REQBYPOSDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQBYPOSDataGridViewTextBoxColumn1.Visible = False
        '
        'REQAUTHDataGridViewTextBoxColumn1
        '
        Me.REQAUTHDataGridViewTextBoxColumn1.DataPropertyName = "REQ_AUTH"
        Me.REQAUTHDataGridViewTextBoxColumn1.HeaderText = "REQ_AUTH"
        Me.REQAUTHDataGridViewTextBoxColumn1.Name = "REQAUTHDataGridViewTextBoxColumn1"
        Me.REQAUTHDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQAUTHDataGridViewTextBoxColumn1.Visible = False
        '
        'REQAUTHPOSDataGridViewTextBoxColumn1
        '
        Me.REQAUTHPOSDataGridViewTextBoxColumn1.DataPropertyName = "REQ_AUTH_POS"
        Me.REQAUTHPOSDataGridViewTextBoxColumn1.HeaderText = "REQ_AUTH_POS"
        Me.REQAUTHPOSDataGridViewTextBoxColumn1.Name = "REQAUTHPOSDataGridViewTextBoxColumn1"
        Me.REQAUTHPOSDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQAUTHPOSDataGridViewTextBoxColumn1.Visible = False
        '
        'REQAPPDataGridViewTextBoxColumn1
        '
        Me.REQAPPDataGridViewTextBoxColumn1.DataPropertyName = "REQ_APP"
        Me.REQAPPDataGridViewTextBoxColumn1.HeaderText = "REQ_APP"
        Me.REQAPPDataGridViewTextBoxColumn1.Name = "REQAPPDataGridViewTextBoxColumn1"
        Me.REQAPPDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQAPPDataGridViewTextBoxColumn1.Visible = False
        '
        'REQAPPPOSDataGridViewTextBoxColumn1
        '
        Me.REQAPPPOSDataGridViewTextBoxColumn1.DataPropertyName = "REQ_APP_POS"
        Me.REQAPPPOSDataGridViewTextBoxColumn1.HeaderText = "REQ_APP_POS"
        Me.REQAPPPOSDataGridViewTextBoxColumn1.Name = "REQAPPPOSDataGridViewTextBoxColumn1"
        Me.REQAPPPOSDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQAPPPOSDataGridViewTextBoxColumn1.Visible = False
        '
        'REQISSDataGridViewTextBoxColumn1
        '
        Me.REQISSDataGridViewTextBoxColumn1.DataPropertyName = "REQ_ISS"
        Me.REQISSDataGridViewTextBoxColumn1.HeaderText = "REQ_ISS"
        Me.REQISSDataGridViewTextBoxColumn1.Name = "REQISSDataGridViewTextBoxColumn1"
        Me.REQISSDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQISSDataGridViewTextBoxColumn1.Visible = False
        '
        'REQISSPOSDataGridViewTextBoxColumn1
        '
        Me.REQISSPOSDataGridViewTextBoxColumn1.DataPropertyName = "REQ_ISS_POS"
        Me.REQISSPOSDataGridViewTextBoxColumn1.HeaderText = "REQ_ISS_POS"
        Me.REQISSPOSDataGridViewTextBoxColumn1.Name = "REQISSPOSDataGridViewTextBoxColumn1"
        Me.REQISSPOSDataGridViewTextBoxColumn1.ReadOnly = True
        Me.REQISSPOSDataGridViewTextBoxColumn1.Visible = False
        '
        'WTXT_D_FOR_THE_PER
        '
        Me.WTXT_D_FOR_THE_PER.BackColor = System.Drawing.Color.White
        Me.WTXT_D_FOR_THE_PER.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_D_FOR_THE_PER.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4REQDETAILSBindingSource, "REQ_DATE_PERIOD", True))
        Me.WTXT_D_FOR_THE_PER.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_D_FOR_THE_PER.Location = New System.Drawing.Point(274, 40)
        Me.WTXT_D_FOR_THE_PER.Name = "WTXT_D_FOR_THE_PER"
        Me.WTXT_D_FOR_THE_PER.ReadOnly = True
        Me.WTXT_D_FOR_THE_PER.Size = New System.Drawing.Size(247, 21)
        Me.WTXT_D_FOR_THE_PER.TabIndex = 1490
        Me.WTXT_D_FOR_THE_PER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_D_FOR_THE_PER.Watermark = "MM/DD/YYYY - MM/DD/YYYY"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel7.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel7.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel7.Location = New System.Drawing.Point(454, 606)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(61, 19)
        Me.LinkLabel7.TabIndex = 1464
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "CLOSE"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel8.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel8.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel8.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel8.Location = New System.Drawing.Point(393, 606)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(46, 19)
        Me.LinkLabel8.TabIndex = 1463
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "ADD"
        '
        'WTXT_D_DATE_NEEDED
        '
        Me.WTXT_D_DATE_NEEDED.BackColor = System.Drawing.Color.White
        Me.WTXT_D_DATE_NEEDED.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_D_DATE_NEEDED.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4REQDETAILSBindingSource, "REQ_DATE_NEEDED", True))
        Me.WTXT_D_DATE_NEEDED.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_D_DATE_NEEDED.Location = New System.Drawing.Point(387, 84)
        Me.WTXT_D_DATE_NEEDED.Name = "WTXT_D_DATE_NEEDED"
        Me.WTXT_D_DATE_NEEDED.ReadOnly = True
        Me.WTXT_D_DATE_NEEDED.Size = New System.Drawing.Size(133, 21)
        Me.WTXT_D_DATE_NEEDED.TabIndex = 1417
        Me.WTXT_D_DATE_NEEDED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_D_DATE_NEEDED.Watermark = "MM/DD/YYYY"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DimGray
        Me.Label30.Location = New System.Drawing.Point(390, 68)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 17)
        Me.Label30.TabIndex = 1334
        Me.Label30.Text = "Date Needed"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DimGray
        Me.Label31.Location = New System.Drawing.Point(280, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 17)
        Me.Label31.TabIndex = 1435
        Me.Label31.Text = "For the period"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.DimGray
        Me.Label32.Location = New System.Drawing.Point(17, 20)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(109, 17)
        Me.Label32.TabIndex = 1433
        Me.Label32.Text = "Requisition Type"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Location = New System.Drawing.Point(1504, 55)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(145, 145)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'ShapeContainer8
        '
        Me.ShapeContainer8.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer8.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer8.Name = "ShapeContainer8"
        Me.ShapeContainer8.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape24, Me.RectangleShape27, Me.RectangleShape28, Me.RectangleShape29, Me.RectangleShape30, Me.RectangleShape31})
        Me.ShapeContainer8.Size = New System.Drawing.Size(524, 558)
        Me.ShapeContainer8.TabIndex = 1
        Me.ShapeContainer8.TabStop = False
        '
        'RectangleShape24
        '
        Me.RectangleShape24.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape24.CornerRadius = 5
        Me.RectangleShape24.Location = New System.Drawing.Point(2, 57)
        Me.RectangleShape24.Name = "RectangleShape1"
        Me.RectangleShape24.Size = New System.Drawing.Size(372, 33)
        '
        'RectangleShape27
        '
        Me.RectangleShape27.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape27.CornerRadius = 5
        Me.RectangleShape27.Location = New System.Drawing.Point(267, 14)
        Me.RectangleShape27.Name = "RectangleShape4"
        Me.RectangleShape27.Size = New System.Drawing.Size(254, 32)
        '
        'RectangleShape28
        '
        Me.RectangleShape28.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape28.BorderWidth = 2
        Me.RectangleShape28.CornerRadius = 19
        Me.RectangleShape28.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape28.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape28.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape28.Location = New System.Drawing.Point(447, 576)
        Me.RectangleShape28.Name = "RectangleShape15"
        Me.RectangleShape28.Size = New System.Drawing.Size(67, 39)
        '
        'RectangleShape29
        '
        Me.RectangleShape29.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape29.BorderWidth = 2
        Me.RectangleShape29.CornerRadius = 19
        Me.RectangleShape29.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape29.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape29.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape29.Location = New System.Drawing.Point(382, 576)
        Me.RectangleShape29.Name = "RectangleShape14"
        Me.RectangleShape29.Size = New System.Drawing.Size(62, 39)
        '
        'RectangleShape30
        '
        Me.RectangleShape30.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape30.CornerRadius = 5
        Me.RectangleShape30.Location = New System.Drawing.Point(379, 57)
        Me.RectangleShape30.Name = "RECT_PRREQUESTEDDATE"
        Me.RectangleShape30.Size = New System.Drawing.Size(142, 33)
        '
        'RectangleShape31
        '
        Me.RectangleShape31.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape31.CornerRadius = 5
        Me.RectangleShape31.Location = New System.Drawing.Point(2, 14)
        Me.RectangleShape31.Name = "RECT_PRAPPCODE"
        Me.RectangleShape31.Size = New System.Drawing.Size(260, 32)
        '
        'DTITEMREQPREBindingSource
        '
        Me.DTITEMREQPREBindingSource.DataMember = "DT_ITEM_REQ_PRE"
        Me.DTITEMREQPREBindingSource.DataSource = Me.DS_CUSTOM
        '
        'DS_CUSTOM
        '
        Me.DS_CUSTOM.DataSetName = "DS_CUSTOM"
        Me.DS_CUSTOM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLG3UNITSBindingSource
        '
        Me.TBLG3UNITSBindingSource.DataMember = "TBLG3_UNITS"
        Me.TBLG3UNITSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DTITEMREQUISITIONBindingSource
        '
        Me.DTITEMREQUISITIONBindingSource.DataMember = "DT_ITEM_REQUISITION"
        Me.DTITEMREQUISITIONBindingSource.DataSource = Me.DS_CUSTOM
        '
        'GRP_LIST
        '
        Me.GRP_LIST.BackColor = System.Drawing.SystemColors.Window
        Me.GRP_LIST.Controls.Add(Me.PB_REQUISITION_SEARCH)
        Me.GRP_LIST.Controls.Add(Me.PB_REQUISITION_CLEAR_SEARCH)
        Me.GRP_LIST.Controls.Add(Me.WTXT_REQUISITION_SEARCH)
        Me.GRP_LIST.Controls.Add(Me.GBOX_SETTINGS)
        Me.GRP_LIST.Controls.Add(Me.DGV_REQUISITION_LIST)
        Me.GRP_LIST.Controls.Add(Me.PictureBox1)
        Me.GRP_LIST.Controls.Add(Me.ShapeContainer1)
        Me.GRP_LIST.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_LIST.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GRP_LIST.Location = New System.Drawing.Point(7, 108)
        Me.GRP_LIST.Name = "GRP_LIST"
        Me.GRP_LIST.Size = New System.Drawing.Size(1083, 546)
        Me.GRP_LIST.TabIndex = 1531
        Me.GRP_LIST.TabStop = False
        Me.GRP_LIST.Text = "Item List"
        '
        'PB_REQUISITION_SEARCH
        '
        Me.PB_REQUISITION_SEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PB_REQUISITION_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_REQUISITION_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_REQUISITION_SEARCH.InitialImage = Nothing
        Me.PB_REQUISITION_SEARCH.Location = New System.Drawing.Point(20, 30)
        Me.PB_REQUISITION_SEARCH.Name = "PB_REQUISITION_SEARCH"
        Me.PB_REQUISITION_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_REQUISITION_SEARCH.TabIndex = 1430
        Me.PB_REQUISITION_SEARCH.TabStop = False
        '
        'PB_REQUISITION_CLEAR_SEARCH
        '
        Me.PB_REQUISITION_CLEAR_SEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.PB_REQUISITION_CLEAR_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_REQUISITION_CLEAR_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_REQUISITION_CLEAR_SEARCH.InitialImage = Nothing
        Me.PB_REQUISITION_CLEAR_SEARCH.Location = New System.Drawing.Point(1038, 30)
        Me.PB_REQUISITION_CLEAR_SEARCH.Name = "PB_REQUISITION_CLEAR_SEARCH"
        Me.PB_REQUISITION_CLEAR_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_REQUISITION_CLEAR_SEARCH.TabIndex = 1440
        Me.PB_REQUISITION_CLEAR_SEARCH.TabStop = False
        Me.PB_REQUISITION_CLEAR_SEARCH.Visible = False
        '
        'WTXT_REQUISITION_SEARCH
        '
        Me.WTXT_REQUISITION_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_REQUISITION_SEARCH.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_REQUISITION_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.WTXT_REQUISITION_SEARCH.Location = New System.Drawing.Point(57, 34)
        Me.WTXT_REQUISITION_SEARCH.MaxLength = 300
        Me.WTXT_REQUISITION_SEARCH.Name = "WTXT_REQUISITION_SEARCH"
        Me.WTXT_REQUISITION_SEARCH.Size = New System.Drawing.Size(965, 21)
        Me.WTXT_REQUISITION_SEARCH.TabIndex = 1430
        Me.WTXT_REQUISITION_SEARCH.Watermark = "Search Req. Code, Type, Or Purpose"
        '
        'GBOX_SETTINGS
        '
        Me.GBOX_SETTINGS.Controls.Add(Me.LLBL_RECORDSFOUND)
        Me.GBOX_SETTINGS.Controls.Add(Me.LinkLabel1)
        Me.GBOX_SETTINGS.Location = New System.Drawing.Point(6, 489)
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
        'DGV_REQUISITION_LIST
        '
        Me.DGV_REQUISITION_LIST.AllowUserToAddRows = False
        Me.DGV_REQUISITION_LIST.AllowUserToDeleteRows = False
        Me.DGV_REQUISITION_LIST.AllowUserToResizeColumns = False
        Me.DGV_REQUISITION_LIST.AllowUserToResizeRows = False
        Me.DGV_REQUISITION_LIST.AutoGenerateColumns = False
        Me.DGV_REQUISITION_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_REQUISITION_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_REQUISITION_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_REQUISITION_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REQNODataGridViewTextBoxColumn, Me.REQTYPEDataGridViewTextBoxColumn, Me.REQPURPOSEDataGridViewTextBoxColumn, Me.REQDIVISIONDataGridViewTextBoxColumn, Me.REQDATEPERIODDataGridViewTextBoxColumn, Me.DATE_NEEDED, Me.FULLNAME, Me.ENCODED_DATE, Me.REQBYDataGridViewTextBoxColumn, Me.REQBYPOSDataGridViewTextBoxColumn, Me.REQAUTHDataGridViewTextBoxColumn, Me.REQAUTHPOSDataGridViewTextBoxColumn, Me.REQAPPDataGridViewTextBoxColumn, Me.REQAPPPOSDataGridViewTextBoxColumn, Me.REQISSDataGridViewTextBoxColumn, Me.REQISSPOSDataGridViewTextBoxColumn, Me.BTNPRINT, Me.BTNACTION_EDIT, Me.BTN_DETAILS})
        Me.DGV_REQUISITION_LIST.DataSource = Me.VWM4ITEMREQBYBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_REQUISITION_LIST.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_REQUISITION_LIST.Location = New System.Drawing.Point(7, 69)
        Me.DGV_REQUISITION_LIST.MultiSelect = False
        Me.DGV_REQUISITION_LIST.Name = "DGV_REQUISITION_LIST"
        Me.DGV_REQUISITION_LIST.ReadOnly = True
        Me.DGV_REQUISITION_LIST.RowHeadersVisible = False
        Me.DGV_REQUISITION_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_REQUISITION_LIST.Size = New System.Drawing.Size(1072, 419)
        Me.DGV_REQUISITION_LIST.TabIndex = 1
        '
        'REQNODataGridViewTextBoxColumn
        '
        Me.REQNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.REQNODataGridViewTextBoxColumn.DataPropertyName = "REQ_NO"
        Me.REQNODataGridViewTextBoxColumn.HeaderText = "Req. No."
        Me.REQNODataGridViewTextBoxColumn.Name = "REQNODataGridViewTextBoxColumn"
        Me.REQNODataGridViewTextBoxColumn.ReadOnly = True
        Me.REQNODataGridViewTextBoxColumn.Width = 130
        '
        'REQTYPEDataGridViewTextBoxColumn
        '
        Me.REQTYPEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.REQTYPEDataGridViewTextBoxColumn.DataPropertyName = "REQ_TYPE"
        Me.REQTYPEDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.REQTYPEDataGridViewTextBoxColumn.Name = "REQTYPEDataGridViewTextBoxColumn"
        Me.REQTYPEDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQTYPEDataGridViewTextBoxColumn.Width = 110
        '
        'REQPURPOSEDataGridViewTextBoxColumn
        '
        Me.REQPURPOSEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.REQPURPOSEDataGridViewTextBoxColumn.DataPropertyName = "REQ_PURPOSE"
        Me.REQPURPOSEDataGridViewTextBoxColumn.HeaderText = "Purpose"
        Me.REQPURPOSEDataGridViewTextBoxColumn.Name = "REQPURPOSEDataGridViewTextBoxColumn"
        Me.REQPURPOSEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'REQDIVISIONDataGridViewTextBoxColumn
        '
        Me.REQDIVISIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.REQDIVISIONDataGridViewTextBoxColumn.DataPropertyName = "REQ_DIVISION"
        Me.REQDIVISIONDataGridViewTextBoxColumn.HeaderText = "Division"
        Me.REQDIVISIONDataGridViewTextBoxColumn.Name = "REQDIVISIONDataGridViewTextBoxColumn"
        Me.REQDIVISIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQDIVISIONDataGridViewTextBoxColumn.Visible = False
        Me.REQDIVISIONDataGridViewTextBoxColumn.Width = 183
        '
        'REQDATEPERIODDataGridViewTextBoxColumn
        '
        Me.REQDATEPERIODDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.REQDATEPERIODDataGridViewTextBoxColumn.DataPropertyName = "REQ_DATE_PERIOD"
        Me.REQDATEPERIODDataGridViewTextBoxColumn.HeaderText = "Date Period"
        Me.REQDATEPERIODDataGridViewTextBoxColumn.Name = "REQDATEPERIODDataGridViewTextBoxColumn"
        Me.REQDATEPERIODDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DATE_NEEDED
        '
        Me.DATE_NEEDED.DataPropertyName = "DATE_NEEDED"
        Me.DATE_NEEDED.HeaderText = "Date Needed"
        Me.DATE_NEEDED.Name = "DATE_NEEDED"
        Me.DATE_NEEDED.ReadOnly = True
        '
        'FULLNAME
        '
        Me.FULLNAME.DataPropertyName = "FULLNAME"
        Me.FULLNAME.HeaderText = "Encoded by"
        Me.FULLNAME.Name = "FULLNAME"
        Me.FULLNAME.ReadOnly = True
        '
        'ENCODED_DATE
        '
        Me.ENCODED_DATE.DataPropertyName = "ENCODED_DATE"
        Me.ENCODED_DATE.HeaderText = "Encoded date"
        Me.ENCODED_DATE.Name = "ENCODED_DATE"
        Me.ENCODED_DATE.ReadOnly = True
        '
        'REQBYDataGridViewTextBoxColumn
        '
        Me.REQBYDataGridViewTextBoxColumn.DataPropertyName = "REQ_BY"
        Me.REQBYDataGridViewTextBoxColumn.HeaderText = "REQ_BY"
        Me.REQBYDataGridViewTextBoxColumn.Name = "REQBYDataGridViewTextBoxColumn"
        Me.REQBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQBYDataGridViewTextBoxColumn.Visible = False
        '
        'REQBYPOSDataGridViewTextBoxColumn
        '
        Me.REQBYPOSDataGridViewTextBoxColumn.DataPropertyName = "REQ_BY_POS"
        Me.REQBYPOSDataGridViewTextBoxColumn.HeaderText = "REQ_BY_POS"
        Me.REQBYPOSDataGridViewTextBoxColumn.Name = "REQBYPOSDataGridViewTextBoxColumn"
        Me.REQBYPOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQBYPOSDataGridViewTextBoxColumn.Visible = False
        '
        'REQAUTHDataGridViewTextBoxColumn
        '
        Me.REQAUTHDataGridViewTextBoxColumn.DataPropertyName = "REQ_AUTH"
        Me.REQAUTHDataGridViewTextBoxColumn.HeaderText = "REQ_AUTH"
        Me.REQAUTHDataGridViewTextBoxColumn.Name = "REQAUTHDataGridViewTextBoxColumn"
        Me.REQAUTHDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQAUTHDataGridViewTextBoxColumn.Visible = False
        '
        'REQAUTHPOSDataGridViewTextBoxColumn
        '
        Me.REQAUTHPOSDataGridViewTextBoxColumn.DataPropertyName = "REQ_AUTH_POS"
        Me.REQAUTHPOSDataGridViewTextBoxColumn.HeaderText = "REQ_AUTH_POS"
        Me.REQAUTHPOSDataGridViewTextBoxColumn.Name = "REQAUTHPOSDataGridViewTextBoxColumn"
        Me.REQAUTHPOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQAUTHPOSDataGridViewTextBoxColumn.Visible = False
        '
        'REQAPPDataGridViewTextBoxColumn
        '
        Me.REQAPPDataGridViewTextBoxColumn.DataPropertyName = "REQ_APP"
        Me.REQAPPDataGridViewTextBoxColumn.HeaderText = "REQ_APP"
        Me.REQAPPDataGridViewTextBoxColumn.Name = "REQAPPDataGridViewTextBoxColumn"
        Me.REQAPPDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQAPPDataGridViewTextBoxColumn.Visible = False
        '
        'REQAPPPOSDataGridViewTextBoxColumn
        '
        Me.REQAPPPOSDataGridViewTextBoxColumn.DataPropertyName = "REQ_APP_POS"
        Me.REQAPPPOSDataGridViewTextBoxColumn.HeaderText = "REQ_APP_POS"
        Me.REQAPPPOSDataGridViewTextBoxColumn.Name = "REQAPPPOSDataGridViewTextBoxColumn"
        Me.REQAPPPOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQAPPPOSDataGridViewTextBoxColumn.Visible = False
        '
        'REQISSDataGridViewTextBoxColumn
        '
        Me.REQISSDataGridViewTextBoxColumn.DataPropertyName = "REQ_ISS"
        Me.REQISSDataGridViewTextBoxColumn.HeaderText = "REQ_ISS"
        Me.REQISSDataGridViewTextBoxColumn.Name = "REQISSDataGridViewTextBoxColumn"
        Me.REQISSDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQISSDataGridViewTextBoxColumn.Visible = False
        '
        'REQISSPOSDataGridViewTextBoxColumn
        '
        Me.REQISSPOSDataGridViewTextBoxColumn.DataPropertyName = "REQ_ISS_POS"
        Me.REQISSPOSDataGridViewTextBoxColumn.HeaderText = "REQ_ISS_POS"
        Me.REQISSPOSDataGridViewTextBoxColumn.Name = "REQISSPOSDataGridViewTextBoxColumn"
        Me.REQISSPOSDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQISSPOSDataGridViewTextBoxColumn.Visible = False
        '
        'BTNPRINT
        '
        Me.BTNPRINT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.BTNPRINT.HeaderText = "Action"
        Me.BTNPRINT.Name = "BTNPRINT"
        Me.BTNPRINT.ReadOnly = True
        Me.BTNPRINT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BTNPRINT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BTNPRINT.Text = "Print"
        Me.BTNPRINT.UseColumnTextForButtonValue = True
        Me.BTNPRINT.Width = 80
        '
        'BTNACTION_EDIT
        '
        Me.BTNACTION_EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.BTNACTION_EDIT.HeaderText = "Action"
        Me.BTNACTION_EDIT.Name = "BTNACTION_EDIT"
        Me.BTNACTION_EDIT.ReadOnly = True
        Me.BTNACTION_EDIT.Text = "Edit"
        Me.BTNACTION_EDIT.UseColumnTextForButtonValue = True
        Me.BTNACTION_EDIT.Width = 80
        '
        'BTN_DETAILS
        '
        Me.BTN_DETAILS.HeaderText = "Action"
        Me.BTN_DETAILS.Name = "BTN_DETAILS"
        Me.BTN_DETAILS.ReadOnly = True
        Me.BTN_DETAILS.Text = "View Details"
        Me.BTN_DETAILS.UseColumnTextForButtonValue = True
        '
        'VWM4ITEMREQBYBindingSource
        '
        Me.VWM4ITEMREQBYBindingSource.DataMember = "VWM4_ITEM_REQ_BY"
        Me.VWM4ITEMREQBYBindingSource.DataSource = Me.DS_VIEWS
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(1077, 525)
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
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(1, 6)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(1074, 39)
        '
        'VWG3_PRIMARY_SIGNATORYDataGridView1
        '
        Me.VWG3_PRIMARY_SIGNATORYDataGridView1.AutoGenerateColumns = False
        Me.VWG3_PRIMARY_SIGNATORYDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VWG3_PRIMARY_SIGNATORYDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10})
        Me.VWG3_PRIMARY_SIGNATORYDataGridView1.DataSource = Me.VWG3_PRIMARY_SIGNATORYBindingSource
        Me.VWG3_PRIMARY_SIGNATORYDataGridView1.Location = New System.Drawing.Point(1200, 399)
        Me.VWG3_PRIMARY_SIGNATORYDataGridView1.Name = "VWG3_PRIMARY_SIGNATORYDataGridView1"
        Me.VWG3_PRIMARY_SIGNATORYDataGridView1.Size = New System.Drawing.Size(175, 68)
        Me.VWG3_PRIMARY_SIGNATORYDataGridView1.TabIndex = 1532
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FULLNAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FULLNAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SIG_POSITION"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SIG_POSITION"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SIG_TY_NO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SIG_TY_NO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "HDIVS_CODE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "HDIVS_CODE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HRIS_EMPNO_USER"
        Me.DataGridViewTextBoxColumn3.HeaderText = "HRIS_EMPNO_USER"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SIG_AMOUNT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SIG_AMOUNT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SIG_OFFICE_ORDER"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SIG_OFFICE_ORDER"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SIG_POLICY"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SIG_POLICY"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SIG_STATUS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "SIG_STATUS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "HRIS_EMPNO_SIG"
        Me.DataGridViewTextBoxColumn10.HeaderText = "HRIS_EMPNO_SIG"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'VWG3_PRIMARY_SIGNATORYBindingSource
        '
        Me.VWG3_PRIMARY_SIGNATORYBindingSource.DataMember = "VWG3_PRIMARY_SIGNATORY"
        Me.VWG3_PRIMARY_SIGNATORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'APNL_SIGNATORIES
        '
        Me.APNL_SIGNATORIES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APNL_SIGNATORIES.Controls.Add(Me.WTXT_REQ_POSITION)
        Me.APNL_SIGNATORIES.Controls.Add(Me.WTXT_REQUESTED_BY)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label13)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label14)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label19)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label25)
        Me.APNL_SIGNATORIES.Controls.Add(Me.BTN_SIGN_CLOSE)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label24)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label23)
        Me.APNL_SIGNATORIES.Controls.Add(Me.WTXT_ISSU_POSI)
        Me.APNL_SIGNATORIES.Controls.Add(Me.WTXT_ISSU_NAME)
        Me.APNL_SIGNATORIES.Controls.Add(Me.WTXT_APPR_POSI)
        Me.APNL_SIGNATORIES.Controls.Add(Me.WTXT_APPR_NAME)
        Me.APNL_SIGNATORIES.Controls.Add(Me.WTXT_AUTH_POSITION)
        Me.APNL_SIGNATORIES.Controls.Add(Me.WTXT_AUTHORIZEDNAME)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label22)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label20)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label18)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label11)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label10)
        Me.APNL_SIGNATORIES.Controls.Add(Me.Label9)
        Me.APNL_SIGNATORIES.Controls.Add(Me.PB_SET_DEFAULT)
        Me.APNL_SIGNATORIES.Controls.Add(Me.LLBL_SET_DEFAULT)
        Me.APNL_SIGNATORIES.Controls.Add(Me.ShapeContainer2)
        Me.APNL_SIGNATORIES.Location = New System.Drawing.Point(705, 660)
        Me.APNL_SIGNATORIES.Name = "APNL_SIGNATORIES"
        Me.APNL_SIGNATORIES.Size = New System.Drawing.Size(390, 546)
        Me.APNL_SIGNATORIES.TabIndex = 1532
        '
        'WTXT_REQ_POSITION
        '
        Me.WTXT_REQ_POSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_REQ_POSITION.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_REQ_POSITION.Location = New System.Drawing.Point(23, 113)
        Me.WTXT_REQ_POSITION.Multiline = True
        Me.WTXT_REQ_POSITION.Name = "WTXT_REQ_POSITION"
        Me.WTXT_REQ_POSITION.Size = New System.Drawing.Size(352, 24)
        Me.WTXT_REQ_POSITION.TabIndex = 1561
        Me.WTXT_REQ_POSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_REQ_POSITION.Watermark = ""
        '
        'WTXT_REQUESTED_BY
        '
        Me.WTXT_REQUESTED_BY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_REQUESTED_BY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_REQUESTED_BY.Location = New System.Drawing.Point(23, 66)
        Me.WTXT_REQUESTED_BY.Multiline = True
        Me.WTXT_REQUESTED_BY.Name = "WTXT_REQUESTED_BY"
        Me.WTXT_REQUESTED_BY.Size = New System.Drawing.Size(352, 24)
        Me.WTXT_REQUESTED_BY.TabIndex = 1560
        Me.WTXT_REQUESTED_BY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_REQUESTED_BY.Watermark = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(42, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 17)
        Me.Label13.TabIndex = 1559
        Me.Label13.Text = "Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(42, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 17)
        Me.Label14.TabIndex = 1558
        Me.Label14.Text = "Position"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(3, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 16)
        Me.Label19.TabIndex = 1557
        Me.Label19.Text = "Requested by:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(41, 395)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 17)
        Me.Label25.TabIndex = 1556
        Me.Label25.Text = "Name"
        '
        'BTN_SIGN_CLOSE
        '
        Me.BTN_SIGN_CLOSE.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_SIGN_CLOSE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SIGN_CLOSE.Image = Global.PRA_PIS.My.Resources.Resources.outline_double_arrow_black_18dp1
        Me.BTN_SIGN_CLOSE.Location = New System.Drawing.Point(0, 0)
        Me.BTN_SIGN_CLOSE.Name = "BTN_SIGN_CLOSE"
        Me.BTN_SIGN_CLOSE.Size = New System.Drawing.Size(388, 31)
        Me.BTN_SIGN_CLOSE.TabIndex = 1555
        Me.BTN_SIGN_CLOSE.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DimGray
        Me.Label24.Location = New System.Drawing.Point(41, 286)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 17)
        Me.Label24.TabIndex = 1554
        Me.Label24.Text = "Name"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(41, 174)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 17)
        Me.Label23.TabIndex = 1553
        Me.Label23.Text = "Name"
        '
        'WTXT_ISSU_POSI
        '
        Me.WTXT_ISSU_POSI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ISSU_POSI.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ISSU_POSI.Location = New System.Drawing.Point(20, 450)
        Me.WTXT_ISSU_POSI.Multiline = True
        Me.WTXT_ISSU_POSI.Name = "WTXT_ISSU_POSI"
        Me.WTXT_ISSU_POSI.Size = New System.Drawing.Size(352, 24)
        Me.WTXT_ISSU_POSI.TabIndex = 1552
        Me.WTXT_ISSU_POSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ISSU_POSI.Watermark = ""
        '
        'WTXT_ISSU_NAME
        '
        Me.WTXT_ISSU_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ISSU_NAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ISSU_NAME.Location = New System.Drawing.Point(23, 405)
        Me.WTXT_ISSU_NAME.Multiline = True
        Me.WTXT_ISSU_NAME.Name = "WTXT_ISSU_NAME"
        Me.WTXT_ISSU_NAME.Size = New System.Drawing.Size(352, 24)
        Me.WTXT_ISSU_NAME.TabIndex = 1548
        Me.WTXT_ISSU_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ISSU_NAME.Watermark = ""
        '
        'WTXT_APPR_POSI
        '
        Me.WTXT_APPR_POSI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_APPR_POSI.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_APPR_POSI.Location = New System.Drawing.Point(23, 341)
        Me.WTXT_APPR_POSI.Multiline = True
        Me.WTXT_APPR_POSI.Name = "WTXT_APPR_POSI"
        Me.WTXT_APPR_POSI.Size = New System.Drawing.Size(352, 24)
        Me.WTXT_APPR_POSI.TabIndex = 1548
        Me.WTXT_APPR_POSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_APPR_POSI.Watermark = ""
        '
        'WTXT_APPR_NAME
        '
        Me.WTXT_APPR_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_APPR_NAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_APPR_NAME.Location = New System.Drawing.Point(23, 300)
        Me.WTXT_APPR_NAME.Multiline = True
        Me.WTXT_APPR_NAME.Name = "WTXT_APPR_NAME"
        Me.WTXT_APPR_NAME.Size = New System.Drawing.Size(352, 24)
        Me.WTXT_APPR_NAME.TabIndex = 1551
        Me.WTXT_APPR_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_APPR_NAME.Watermark = ""
        '
        'WTXT_AUTH_POSITION
        '
        Me.WTXT_AUTH_POSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_AUTH_POSITION.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_AUTH_POSITION.Location = New System.Drawing.Point(23, 235)
        Me.WTXT_AUTH_POSITION.Multiline = True
        Me.WTXT_AUTH_POSITION.Name = "WTXT_AUTH_POSITION"
        Me.WTXT_AUTH_POSITION.Size = New System.Drawing.Size(352, 24)
        Me.WTXT_AUTH_POSITION.TabIndex = 1550
        Me.WTXT_AUTH_POSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_AUTH_POSITION.Watermark = ""
        '
        'WTXT_AUTHORIZEDNAME
        '
        Me.WTXT_AUTHORIZEDNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_AUTHORIZEDNAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_AUTHORIZEDNAME.Location = New System.Drawing.Point(23, 188)
        Me.WTXT_AUTHORIZEDNAME.Multiline = True
        Me.WTXT_AUTHORIZEDNAME.Name = "WTXT_AUTHORIZEDNAME"
        Me.WTXT_AUTHORIZEDNAME.Size = New System.Drawing.Size(352, 24)
        Me.WTXT_AUTHORIZEDNAME.TabIndex = 1549
        Me.WTXT_AUTHORIZEDNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_AUTHORIZEDNAME.Watermark = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DimGray
        Me.Label22.Location = New System.Drawing.Point(41, 436)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 17)
        Me.Label22.TabIndex = 1546
        Me.Label22.Text = "Position"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(41, 328)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 17)
        Me.Label20.TabIndex = 1544
        Me.Label20.Text = "Position"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(41, 221)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 17)
        Me.Label18.TabIndex = 1542
        Me.Label18.Text = "Position"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(2, 378)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 16)
        Me.Label11.TabIndex = 1538
        Me.Label11.Text = "Issued by:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(2, 269)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 1537
        Me.Label10.Text = "Approved by:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(2, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 1536
        Me.Label9.Text = "Authorized by:"
        '
        'PB_SET_DEFAULT
        '
        Me.PB_SET_DEFAULT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_save_black_18dp
        Me.PB_SET_DEFAULT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_SET_DEFAULT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_SET_DEFAULT.InitialImage = Nothing
        Me.PB_SET_DEFAULT.Location = New System.Drawing.Point(216, 500)
        Me.PB_SET_DEFAULT.Name = "PB_SET_DEFAULT"
        Me.PB_SET_DEFAULT.Size = New System.Drawing.Size(32, 28)
        Me.PB_SET_DEFAULT.TabIndex = 1534
        Me.PB_SET_DEFAULT.TabStop = False
        '
        'LLBL_SET_DEFAULT
        '
        Me.LLBL_SET_DEFAULT.AutoSize = True
        Me.LLBL_SET_DEFAULT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_SET_DEFAULT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_SET_DEFAULT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_SET_DEFAULT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_SET_DEFAULT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_SET_DEFAULT.Location = New System.Drawing.Point(251, 504)
        Me.LLBL_SET_DEFAULT.Name = "LLBL_SET_DEFAULT"
        Me.LLBL_SET_DEFAULT.Size = New System.Drawing.Size(118, 19)
        Me.LLBL_SET_DEFAULT.TabIndex = 1533
        Me.LLBL_SET_DEFAULT.TabStop = True
        Me.LLBL_SET_DEFAULT.Text = "Set as default"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape8, Me.RectangleShape7, Me.RectangleShape20, Me.RectangleShape19, Me.RectangleShape18, Me.RectangleShape17, Me.RectangleShape16, Me.RectangleShape13, Me.RECT_SET_DEFAULT})
        Me.ShapeContainer2.Size = New System.Drawing.Size(388, 544)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.Location = New System.Drawing.Point(19, 107)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(361, 33)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(19, 60)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(361, 33)
        '
        'RectangleShape20
        '
        Me.RectangleShape20.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape20.CornerRadius = 5
        Me.RectangleShape20.Location = New System.Drawing.Point(16, 444)
        Me.RectangleShape20.Name = "RectangleShape20"
        Me.RectangleShape20.Size = New System.Drawing.Size(361, 33)
        '
        'RectangleShape19
        '
        Me.RectangleShape19.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape19.CornerRadius = 5
        Me.RectangleShape19.Location = New System.Drawing.Point(17, 399)
        Me.RectangleShape19.Name = "RectangleShape19"
        Me.RectangleShape19.Size = New System.Drawing.Size(361, 33)
        '
        'RectangleShape18
        '
        Me.RectangleShape18.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape18.CornerRadius = 5
        Me.RectangleShape18.Location = New System.Drawing.Point(18, 336)
        Me.RectangleShape18.Name = "RectangleShape18"
        Me.RectangleShape18.Size = New System.Drawing.Size(361, 32)
        '
        'RectangleShape17
        '
        Me.RectangleShape17.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape17.CornerRadius = 5
        Me.RectangleShape17.Location = New System.Drawing.Point(18, 294)
        Me.RectangleShape17.Name = "RectangleShape17"
        Me.RectangleShape17.Size = New System.Drawing.Size(361, 33)
        '
        'RectangleShape16
        '
        Me.RectangleShape16.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape16.CornerRadius = 5
        Me.RectangleShape16.Location = New System.Drawing.Point(19, 229)
        Me.RectangleShape16.Name = "RectangleShape16"
        Me.RectangleShape16.Size = New System.Drawing.Size(361, 33)
        '
        'RectangleShape13
        '
        Me.RectangleShape13.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape13.CornerRadius = 5
        Me.RectangleShape13.Location = New System.Drawing.Point(19, 182)
        Me.RectangleShape13.Name = "RectangleShape13"
        Me.RectangleShape13.Size = New System.Drawing.Size(361, 33)
        '
        'RECT_SET_DEFAULT
        '
        Me.RECT_SET_DEFAULT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_SET_DEFAULT.BorderWidth = 2
        Me.RECT_SET_DEFAULT.CornerRadius = 19
        Me.RECT_SET_DEFAULT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_SET_DEFAULT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_SET_DEFAULT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_SET_DEFAULT.Location = New System.Drawing.Point(205, 494)
        Me.RECT_SET_DEFAULT.Name = "RECT_SET_DEFAULT"
        Me.RECT_SET_DEFAULT.Size = New System.Drawing.Size(171, 40)
        '
        'WTXT_REQ_ID
        '
        Me.WTXT_REQ_ID.Location = New System.Drawing.Point(1200, 473)
        Me.WTXT_REQ_ID.Name = "WTXT_REQ_ID"
        Me.WTXT_REQ_ID.Size = New System.Drawing.Size(37, 20)
        Me.WTXT_REQ_ID.TabIndex = 1533
        '
        'WTXT_AUTH_ID
        '
        Me.WTXT_AUTH_ID.Location = New System.Drawing.Point(1200, 499)
        Me.WTXT_AUTH_ID.Name = "WTXT_AUTH_ID"
        Me.WTXT_AUTH_ID.Size = New System.Drawing.Size(37, 20)
        Me.WTXT_AUTH_ID.TabIndex = 1534
        '
        'WTXT_APPR_ID
        '
        Me.WTXT_APPR_ID.Location = New System.Drawing.Point(1200, 524)
        Me.WTXT_APPR_ID.Name = "WTXT_APPR_ID"
        Me.WTXT_APPR_ID.Size = New System.Drawing.Size(37, 20)
        Me.WTXT_APPR_ID.TabIndex = 1535
        '
        'WTXT_ISSU_ID
        '
        Me.WTXT_ISSU_ID.Location = New System.Drawing.Point(1200, 524)
        Me.WTXT_ISSU_ID.Name = "WTXT_ISSU_ID"
        Me.WTXT_ISSU_ID.Size = New System.Drawing.Size(37, 20)
        Me.WTXT_ISSU_ID.TabIndex = 1536
        '
        'TXT_DATENOW
        '
        Me.TXT_DATENOW.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4_CURRENTDATETIMEBindingSource, "datenowFormatted", True))
        Me.TXT_DATENOW.Location = New System.Drawing.Point(1200, 560)
        Me.TXT_DATENOW.Name = "TXT_DATENOW"
        Me.TXT_DATENOW.Size = New System.Drawing.Size(91, 20)
        Me.TXT_DATENOW.TabIndex = 1537
        '
        'VWM4_ITEM_REQ_BYTableAdapter
        '
        Me.VWM4_ITEM_REQ_BYTableAdapter.ClearBeforeFill = True
        '
        'SPM4EMPLSIGNLISTBindingSource
        '
        Me.SPM4EMPLSIGNLISTBindingSource.DataMember = "SPM4_EMPL_SIGN_LIST"
        Me.SPM4EMPLSIGNLISTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_EMPL_SIGN_LISTTableAdapter
        '
        Me.SPM4_EMPL_SIGN_LISTTableAdapter.ClearBeforeFill = True
        '
        'TBLG3_PRIMARY_SIGNATORYBindingSource
        '
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource.DataMember = "TBLG3_PRIMARY_SIGNATORY"
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_TYPETableAdapter
        '
        Me.TblM4_INVENTORY_TYPETableAdapter.ClearBeforeFill = True
        '
        'TBLG3_UNITSTableAdapter
        '
        Me.TBLG3_UNITSTableAdapter.ClearBeforeFill = True
        '
        'TblG3_PRIMARY_SIGNATORYTableAdapter
        '
        Me.TblG3_PRIMARY_SIGNATORYTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBLG3_COMPANY_INFOTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_DELIVER_RECEIPT_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_DELIVERY_RECEIPTTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_INVOICE_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_INVOICETableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_PRIMARY_SIGNATORYTableAdapter = Me.TblG3_PRIMARY_SIGNATORYTableAdapter
        Me.TableAdapterManager.TBLG3_REG_BUSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_DVTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_PARTICULARTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORY_TYPETableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORY1TableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_UNITSTableAdapter = Me.TBLG3_UNITSTableAdapter
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
        Me.TableAdapterManager.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_PCOUNTTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_STK_CTRLTableAdapter = Nothing
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
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEMS_DRTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEMS_INVTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_REQUISITIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_SUB_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_TYPETableAdapter = Me.TblM4_INVENTORY_TYPETableAdapter
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
        'VWG3_PRIMARY_SIGNATORYTableAdapter
        '
        Me.VWG3_PRIMARY_SIGNATORYTableAdapter.ClearBeforeFill = True
        '
        'TBLM4INVENTORYREQUISITIONBindingSource
        '
        Me.TBLM4INVENTORYREQUISITIONBindingSource.DataMember = "TBLM4_INVENTORY_REQUISITION"
        Me.TBLM4INVENTORYREQUISITIONBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource
        '
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource.DataMember = "TBLM4_INVENTORY_ITEM_REQUISITION"
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INVENTORY_REQUISITIONTableAdapter
        '
        Me.TBLM4_INVENTORY_REQUISITIONTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter
        '
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INVENTORY_ITEM_REQUISITION1BindingSource
        '
        Me.TBLM4_INVENTORY_ITEM_REQUISITION1BindingSource.DataMember = "TBLM4_INVENTORY_ITEM_REQUISITION1"
        Me.TBLM4_INVENTORY_ITEM_REQUISITION1BindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INVENTORY_ITEM_REQUISITION1TableAdapter
        '
        Me.TBLM4_INVENTORY_ITEM_REQUISITION1TableAdapter.ClearBeforeFill = True
        '
        'SPM4_CHK_CONTAINS_LETTERBindingSource
        '
        Me.SPM4_CHK_CONTAINS_LETTERBindingSource.DataMember = "SPM4_CHK_CONTAINS_LETTER"
        Me.SPM4_CHK_CONTAINS_LETTERBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_CHK_CONTAINS_LETTERTableAdapter
        '
        Me.SPM4_CHK_CONTAINS_LETTERTableAdapter.ClearBeforeFill = True
        '
        'PNL_ITEM_DETAILS
        '
        Me.PNL_ITEM_DETAILS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_ITEM_DETAILS.Controls.Add(Me.BTN_ITEM_REQ_ENC_CANCEL)
        Me.PNL_ITEM_DETAILS.Controls.Add(Me.BTN_ADD_ITEM)
        Me.PNL_ITEM_DETAILS.Controls.Add(Me.GroupBox1)
        Me.PNL_ITEM_DETAILS.Location = New System.Drawing.Point(300, 250)
        Me.PNL_ITEM_DETAILS.Name = "PNL_ITEM_DETAILS"
        Me.PNL_ITEM_DETAILS.Size = New System.Drawing.Size(564, 190)
        Me.PNL_ITEM_DETAILS.TabIndex = 1549
        Me.PNL_ITEM_DETAILS.Visible = False
        '
        'BTN_ITEM_REQ_ENC_CANCEL
        '
        Me.BTN_ITEM_REQ_ENC_CANCEL.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ITEM_REQ_ENC_CANCEL.Location = New System.Drawing.Point(451, 144)
        Me.BTN_ITEM_REQ_ENC_CANCEL.Name = "BTN_ITEM_REQ_ENC_CANCEL"
        Me.BTN_ITEM_REQ_ENC_CANCEL.Size = New System.Drawing.Size(101, 33)
        Me.BTN_ITEM_REQ_ENC_CANCEL.TabIndex = 1544
        Me.BTN_ITEM_REQ_ENC_CANCEL.Text = "CLOSE"
        Me.BTN_ITEM_REQ_ENC_CANCEL.UseVisualStyleBackColor = True
        '
        'BTN_ADD_ITEM
        '
        Me.BTN_ADD_ITEM.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD_ITEM.Location = New System.Drawing.Point(346, 144)
        Me.BTN_ADD_ITEM.Name = "BTN_ADD_ITEM"
        Me.BTN_ADD_ITEM.Size = New System.Drawing.Size(99, 33)
        Me.BTN_ADD_ITEM.TabIndex = 1543
        Me.BTN_ADD_ITEM.Text = "ADD ITEM"
        Me.BTN_ADD_ITEM.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.WTXT_ITEM_DESCRIPTION)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.WTXT_QUANTITY)
        Me.GroupBox1.Controls.Add(Me.CB_UNIT_TYPE)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 133)
        Me.GroupBox1.TabIndex = 1445
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(526, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 16)
        Me.Label2.TabIndex = 1496
        Me.Label2.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(292, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 16)
        Me.Label4.TabIndex = 1495
        Me.Label4.Text = "*"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(173, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 1494
        Me.Label8.Text = "Quantity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(15, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 17)
        Me.Label12.TabIndex = 1493
        Me.Label12.Text = "Unit type"
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
        Me.WTXT_QUANTITY.Watermark = "0"
        '
        'CB_UNIT_TYPE
        '
        Me.CB_UNIT_TYPE.DataSource = Me.TBLG3UNITSBindingSource
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
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel2.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel2.Location = New System.Drawing.Point(454, 606)
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
        Me.LinkLabel3.Location = New System.Drawing.Point(393, 606)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(46, 19)
        Me.LinkLabel3.TabIndex = 1463
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "ADD"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(1504, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 145)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_ITEM_DESCRIPTION, Me.RECT_QUANTITY, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape6})
        Me.ShapeContainer4.Size = New System.Drawing.Size(543, 111)
        Me.ShapeContainer4.TabIndex = 1
        Me.ShapeContainer4.TabStop = False
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
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 19
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(447, 576)
        Me.RectangleShape2.Name = "RectangleShape15"
        Me.RectangleShape2.Size = New System.Drawing.Size(67, 39)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.CornerRadius = 19
        Me.RectangleShape6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape6.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape6.Location = New System.Drawing.Point(382, 576)
        Me.RectangleShape6.Name = "RectangleShape14"
        Me.RectangleShape6.Size = New System.Drawing.Size(62, 39)
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
        'VWM4_ITEM_REQ_DESCTableAdapter
        '
        Me.VWM4_ITEM_REQ_DESCTableAdapter.ClearBeforeFill = True
        '
        'VWM4_ITEM_REQ_DESCBindingSource
        '
        Me.VWM4_ITEM_REQ_DESCBindingSource.DataMember = "VWM4_ITEM_REQ_DESC"
        Me.VWM4_ITEM_REQ_DESCBindingSource.DataSource = Me.DS_VIEWS
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.WatermarkTextBox2)
        Me.Panel2.Controls.Add(Me.WatermarkTextBox1)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.ShapeContainer7)
        Me.Panel2.Location = New System.Drawing.Point(2400, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(322, 47)
        Me.Panel2.TabIndex = 1441
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DimGray
        Me.Label28.Location = New System.Drawing.Point(441, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 16)
        Me.Label28.TabIndex = 1552
        Me.Label28.Text = "Search"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(416, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox3.TabIndex = 1552
        Me.PictureBox3.TabStop = False
        '
        'WatermarkTextBox2
        '
        Me.WatermarkTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WatermarkTextBox2.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WatermarkTextBox2.Location = New System.Drawing.Point(264, 17)
        Me.WatermarkTextBox2.Name = "WatermarkTextBox2"
        Me.WatermarkTextBox2.Size = New System.Drawing.Size(133, 21)
        Me.WatermarkTextBox2.TabIndex = 1550
        Me.WatermarkTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WatermarkTextBox2.Watermark = "MM/DD/YYYY"
        '
        'WatermarkTextBox1
        '
        Me.WatermarkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WatermarkTextBox1.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WatermarkTextBox1.Location = New System.Drawing.Point(115, 17)
        Me.WatermarkTextBox1.Name = "WatermarkTextBox1"
        Me.WatermarkTextBox1.Size = New System.Drawing.Size(133, 21)
        Me.WatermarkTextBox1.TabIndex = 1550
        Me.WatermarkTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WatermarkTextBox1.Watermark = "MM/DD/YYYY"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DimGray
        Me.Label27.Location = New System.Drawing.Point(270, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(24, 17)
        Me.Label27.TabIndex = 1551
        Me.Label27.Text = "TO"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DimGray
        Me.Label26.Location = New System.Drawing.Point(118, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 17)
        Me.Label26.TabIndex = 1550
        Me.Label26.Text = "FROM"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(7, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 17)
        Me.Label21.TabIndex = 1434
        Me.Label21.Text = "Date Needed:"
        '
        'ShapeContainer7
        '
        Me.ShapeContainer7.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer7.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer7.Name = "ShapeContainer7"
        Me.ShapeContainer7.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape22, Me.RectangleShape21, Me.RectangleShape9})
        Me.ShapeContainer7.Size = New System.Drawing.Size(322, 47)
        Me.ShapeContainer7.TabIndex = 0
        Me.ShapeContainer7.TabStop = False
        '
        'RectangleShape22
        '
        Me.RectangleShape22.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape22.BorderWidth = 2
        Me.RectangleShape22.CornerRadius = 14
        Me.RectangleShape22.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape22.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape22.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape22.Location = New System.Drawing.Point(406, 11)
        Me.RectangleShape22.Name = "RectangleShape22"
        Me.RectangleShape22.Size = New System.Drawing.Size(93, 29)
        '
        'RectangleShape21
        '
        Me.RectangleShape21.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape21.CornerRadius = 5
        Me.RectangleShape21.Location = New System.Drawing.Point(259, 9)
        Me.RectangleShape21.Name = "RectangleShape21"
        Me.RectangleShape21.Size = New System.Drawing.Size(142, 33)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.Location = New System.Drawing.Point(110, 9)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(142, 33)
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
        'SPM4_REQ_DETAILSTableAdapter
        '
        Me.SPM4_REQ_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'SPM4_UQ_IQ_SIGNATORYBindingSource
        '
        Me.SPM4_UQ_IQ_SIGNATORYBindingSource.DataMember = "SPM4_UQ_IQ_SIGNATORY"
        Me.SPM4_UQ_IQ_SIGNATORYBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_UQ_IQ_SIGNATORYTableAdapter
        '
        Me.SPM4_UQ_IQ_SIGNATORYTableAdapter.ClearBeforeFill = True
        '
        'SPM4_USER_SIGNATORYTableAdapter
        '
        Me.SPM4_USER_SIGNATORYTableAdapter.ClearBeforeFill = True
        '
        'SPM4_USER_SIGNATORYBindingSource
        '
        Me.SPM4_USER_SIGNATORYBindingSource.DataMember = "SPM4_USER_SIGNATORY"
        Me.SPM4_USER_SIGNATORYBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'WTXT_REQU_POSI
        '
        Me.WTXT_REQU_POSI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WTXT_REQU_POSI.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_REQU_POSI.Location = New System.Drawing.Point(7, 1045)
        Me.WTXT_REQU_POSI.Multiline = True
        Me.WTXT_REQU_POSI.Name = "WTXT_REQU_POSI"
        Me.WTXT_REQU_POSI.Size = New System.Drawing.Size(33, 24)
        Me.WTXT_REQU_POSI.TabIndex = 1548
        Me.WTXT_REQU_POSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_REQU_POSI.Visible = False
        Me.WTXT_REQU_POSI.Watermark = ""
        '
        'WTXT_REQU_NAME
        '
        Me.WTXT_REQU_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WTXT_REQU_NAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_REQU_NAME.Location = New System.Drawing.Point(7, 1001)
        Me.WTXT_REQU_NAME.Multiline = True
        Me.WTXT_REQU_NAME.Name = "WTXT_REQU_NAME"
        Me.WTXT_REQU_NAME.Size = New System.Drawing.Size(33, 24)
        Me.WTXT_REQU_NAME.TabIndex = 1547
        Me.WTXT_REQU_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_REQU_NAME.Visible = False
        Me.WTXT_REQU_NAME.Watermark = ""
        '
        'SPM4_CURRENTDATETIMETableAdapter
        '
        Me.SPM4_CURRENTDATETIMETableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_REQ_CODEBindingSource
        '
        Me.SPM4_ITEM_REQ_CODEBindingSource.DataMember = "SPM4_ITEM_REQ_CODE"
        Me.SPM4_ITEM_REQ_CODEBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_ITEM_REQ_CODETableAdapter
        '
        Me.SPM4_ITEM_REQ_CODETableAdapter.ClearBeforeFill = True
        '
        'FRM_ITEM_REQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 660)
        Me.Controls.Add(Me.GRP_D_ITEMINFO)
        Me.Controls.Add(Me.APNL_ITEMINFO)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PNL_ITEM_DETAILS)
        Me.Controls.Add(Me.APNL_SIGNATORIES)
        Me.Controls.Add(Me.GRP_LIST)
        Me.Controls.Add(Me.PNL_BUTTONS)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.WTXT_REQ_ID)
        Me.Controls.Add(Me.TXT_DATENOW)
        Me.Controls.Add(Me.WTXT_ISSU_ID)
        Me.Controls.Add(Me.WTXT_APPR_ID)
        Me.Controls.Add(Me.WTXT_AUTH_ID)
        Me.Controls.Add(Me.WTXT_REQU_POSI)
        Me.Controls.Add(Me.VWG3_PRIMARY_SIGNATORYDataGridView1)
        Me.Controls.Add(Me.WTXT_REQU_NAME)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ITEM_REQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FRM_ITEM_REQ"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.PNL_BUTTONS.ResumeLayout(False)
        Me.PNL_BUTTONS.PerformLayout()
        CType(Me.PB_INVENTORY_VIEW_REPORT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_NEW_REQUISITION, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APNL_ITEMINFO.ResumeLayout(False)
        Me.GRP_ITEMINFO.ResumeLayout(False)
        Me.GRP_ITEMINFO.PerformLayout()
        CType(Me.PB_SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_SIGNATORIES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ADD_ITEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_ITEM_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRINT_PREVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GRP_CONSUMABLE.ResumeLayout(False)
        Me.GRP_CONSUMABLE.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.GRP_D_ITEMINFO.ResumeLayout(False)
        Me.GRP_D_ITEMINFO.PerformLayout()
        CType(Me.SPM4REQDETAILSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTITEMREQPREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTITEMREQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_LIST.ResumeLayout(False)
        Me.GRP_LIST.PerformLayout()
        CType(Me.PB_REQUISITION_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_REQUISITION_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBOX_SETTINGS.ResumeLayout(False)
        Me.GBOX_SETTINGS.PerformLayout()
        CType(Me.DGV_REQUISITION_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4ITEMREQBYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWG3_PRIMARY_SIGNATORYDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APNL_SIGNATORIES.ResumeLayout(False)
        Me.APNL_SIGNATORIES.PerformLayout()
        CType(Me.PB_SET_DEFAULT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4EMPLSIGNLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVENTORYREQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INVENTORY_ITEM_REQUISITION1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_CHK_CONTAINS_LETTERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_ITEM_DETAILS.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_ITEM_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_ITEM_REQ_DESCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_UQ_IQ_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_USER_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_REQ_CODEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_INVENTORY_MINIMIZE As Button
    Friend WithEvents BTN_INVENTORY_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL_BUTTONS As Panel
    Friend WithEvents LLBL_INVENTORY_VIEW_REPORT As LinkLabel
    Friend WithEvents LLBL_NEW_REQUISITION As LinkLabel
    Friend WithEvents PB_INVENTORY_VIEW_REPORT As PictureBox
    Friend WithEvents PB_NEW_REQUISITION As PictureBox
    Friend WithEvents ShapeContainer5 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents RECT_NEW_REQUISITION As PowerPacks.RectangleShape
    Friend WithEvents APNL_ITEMINFO As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GRP_CONSUMABLE As GroupBox
    Friend WithEvents RBT_DEPLETED As RadioButton
    Friend WithEvents RBT_PERPARTS As RadioButton
    Friend WithEvents CB_ITEM_USAGE As ComboBox
    Friend WithEvents CB_ACQUISITION_VALUE As ComboBox
    Friend WithEvents RBT_PURCHASED As RadioButton
    Friend WithEvents RBT_DONATED As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ShapeContainer6 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape10 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape11 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape12 As PowerPacks.RectangleShape
    Friend WithEvents Panel23 As Panel
    Friend WithEvents LLBL_INVENTORY_ENCODING_HEADER As Label
    Friend WithEvents BTN_CLOSE_INVENTORY_MINI_CLOSE As Button
    Friend WithEvents SPM4EMPLSIGNLISTBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents VWG3_PRIMARY_SIGNATORYBindingSource As BindingSource
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TBLG3_PRIMARY_SIGNATORYBindingSource As BindingSource
    Friend WithEvents TBLG3UNITSBindingSource As BindingSource
    Friend WithEvents TblM4INVENTORYTYPEBindingSource As BindingSource
    Friend WithEvents DTITEMREQUISITIONBindingSource As BindingSource
    Friend WithEvents DS_CUSTOM As DS_CUSTOM
    Friend WithEvents TblM4_INVENTORY_TYPETableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_TYPETableAdapter
    Friend WithEvents TBLG3_UNITSTableAdapter As DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter
    Friend WithEvents TblG3_PRIMARY_SIGNATORYTableAdapter As DS_PROPERTYDBTableAdapters.TBLG3_PRIMARY_SIGNATORYTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents VWG3_PRIMARY_SIGNATORYTableAdapter As DS_PROPERTYDBTableAdapters.VWG3_PRIMARY_SIGNATORYTableAdapter
    Friend WithEvents SPM4_EMPL_SIGN_LISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_EMPL_SIGN_LISTTableAdapter
    Friend WithEvents GRP_LIST As GroupBox
    Friend WithEvents PB_REQUISITION_SEARCH As PictureBox
    Friend WithEvents PB_REQUISITION_CLEAR_SEARCH As PictureBox
    Friend WithEvents WTXT_REQUISITION_SEARCH As WatermarkTextBox
    Friend WithEvents GBOX_SETTINGS As GroupBox
    Friend WithEvents LLBL_RECORDSFOUND As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DGV_REQUISITION_LIST As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents GRP_ITEMINFO As GroupBox
    Friend WithEvents LLBL_ADD_ITEM As LinkLabel
    Friend WithEvents PB_ADD_ITEM As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV_ITEM_LIST As DataGridView
    Friend WithEvents PB_PRINT_PREVIEW As PictureBox
    Friend WithEvents LLBL_PRINT_PREVIEW As LinkLabel
    Friend WithEvents WTXT_FOR_THE_PERIOD As WatermarkTextBox
    Friend WithEvents CB_REQUISITION_TYPE As ComboBox
    Friend WithEvents LLBL_CLOSE As LinkLabel
    Friend WithEvents LLBL_SAVE_ADD_ITEM As LinkLabel
    Friend WithEvents WTXT_DATE_NEEDED As WatermarkTextBox
    Friend WithEvents LLBL_FOR_THE_PERIOD As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PBOX_PRNOQRCODE As PictureBox
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_ADD_ITEM As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRINT_PREVIEW As PowerPacks.RectangleShape
    Friend WithEvents RECT_FOR_THE_PERIOD As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape15 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape14 As PowerPacks.RectangleShape
    Friend WithEvents RECT_DATE_NEEDED As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRAPPCODE As PowerPacks.RectangleShape
    Friend WithEvents Label6 As Label
    Friend WithEvents WTXT_PURPOSE As WatermarkTextBox
    Friend WithEvents LLBL_DATE_NEEDED As Label
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents APNL_SIGNATORIES As Panel
    Friend WithEvents PB_SET_DEFAULT As PictureBox
    Friend WithEvents LLBL_SET_DEFAULT As LinkLabel
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_SET_DEFAULT As PowerPacks.RectangleShape
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RectangleShape20 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape19 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape18 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape17 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape16 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape13 As PowerPacks.RectangleShape
    Friend WithEvents BTN_SIGN_CLOSE As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents WTXT_ISSU_POSI As WatermarkTextBox
    Friend WithEvents WTXT_ISSU_NAME As WatermarkTextBox
    Friend WithEvents WTXT_APPR_POSI As WatermarkTextBox
    Friend WithEvents WTXT_APPR_NAME As WatermarkTextBox
    Friend WithEvents WTXT_AUTH_POSITION As WatermarkTextBox
    Friend WithEvents WTXT_AUTHORIZEDNAME As WatermarkTextBox
    Friend WithEvents WTXT_REQU_POSI As WatermarkTextBox
    Friend WithEvents WTXT_REQU_NAME As WatermarkTextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents VWG3_PRIMARY_SIGNATORYDataGridView1 As DataGridView
    Friend WithEvents WTXT_REQ_ID As TextBox
    Friend WithEvents WTXT_AUTH_ID As TextBox
    Friend WithEvents WTXT_APPR_ID As TextBox
    Friend WithEvents WTXT_ISSU_ID As TextBox
    Friend WithEvents PB_SIGNATORIES As PictureBox
    Friend WithEvents LLBL_SIGNATORIES As LinkLabel
    Friend WithEvents RECT_SIGNATORIES As PowerPacks.RectangleShape
    Friend WithEvents TXT_DATENOW As TextBox
    Friend WithEvents DTITEMREQPREBindingSource As BindingSource
    Friend WithEvents ITMDESCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TBLM4INVENTORYREQUISITIONBindingSource As BindingSource
    Friend WithEvents TBLM4_INVENTORY_REQUISITIONTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_REQUISITIONTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource As BindingSource
    Friend WithEvents TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter
    Friend WithEvents TBLM4_INVENTORY_ITEM_REQUISITION1BindingSource As BindingSource
    Friend WithEvents TBLM4_INVENTORY_ITEM_REQUISITION1TableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_ITEM_REQUISITION1TableAdapter
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents VWM4ITEMREQBYBindingSource As BindingSource
    Friend WithEvents VWM4_ITEM_REQ_BYTableAdapter As DS_VIEWSTableAdapters.VWM4_ITEM_REQ_BYTableAdapter
    Friend WithEvents SPM4_CHK_CONTAINS_LETTERBindingSource As BindingSource
    Friend WithEvents SPM4_CHK_CONTAINS_LETTERTableAdapter As DS_STOREDPROCTableAdapters.SPM4_CHK_CONTAINS_LETTERTableAdapter
    Friend WithEvents ITM_CODE As DataGridViewTextBoxColumn
    Friend WithEvents ITM_DESCRIPTION As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents UNIT As DataGridViewTextBoxColumn
    Friend WithEvents action As DataGridViewButtonColumn
    '  Friend WithEvents VWM4_ITEM_REQ_DESCBindingSource As BindingSource
    Friend WithEvents PNL_ITEM_DETAILS As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents WTXT_ITEM_DESCRIPTION As WatermarkTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents WTXT_QUANTITY As WatermarkTextBox
    Friend WithEvents CB_UNIT_TYPE As ComboBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_ITEM_DESCRIPTION As PowerPacks.RectangleShape
    Friend WithEvents RECT_QUANTITY As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents BTN_ITEM_REQ_ENC_CANCEL As Button
    Friend WithEvents BTN_ADD_ITEM As Button
    Friend WithEvents VWM4_ITEM_LISTTableAdapter As DS_VIEWSTableAdapters.VWM4_ITEM_LISTTableAdapter
    Friend WithEvents VWM4_ITEM_LISTBindingSource As BindingSource
    Friend WithEvents VWM4_ITEM_REQ_DESCTableAdapter As DS_VIEWSTableAdapters.VWM4_ITEM_REQ_DESCTableAdapter
    Friend WithEvents VWM4_ITEM_REQ_DESCBindingSource As BindingSource
    Friend WithEvents WTXT_REQ_POSITION As WatermarkTextBox
    Friend WithEvents WTXT_REQUESTED_BY As WatermarkTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents Panel2 As Panel
    Friend WithEvents WatermarkTextBox2 As WatermarkTextBox
    Friend WithEvents WatermarkTextBox1 As WatermarkTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ShapeContainer7 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape21 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents Label28 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RectangleShape22 As PowerPacks.RectangleShape
    Friend WithEvents TBLM4_INV_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMSTableAdapter
    Friend WithEvents TBLM4_INV_ITEMSBindingSource As BindingSource
    Friend WithEvents GRP_D_ITEMINFO As GroupBox
    Friend WithEvents WTXT_D_REQ_TYPE As WatermarkTextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents WTXT_D_PURPOSE As WatermarkTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WTXT_D_FOR_THE_PER As WatermarkTextBox
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents WTXT_D_DATE_NEEDED As WatermarkTextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents ShapeContainer8 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape24 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape27 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape28 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape29 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape30 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape31 As PowerPacks.RectangleShape
    Friend WithEvents SPM4REQDETAILSBindingSource As BindingSource
    Friend WithEvents SPM4_REQ_DETAILSTableAdapter As DS_STOREDPROCTableAdapters.SPM4_REQ_DETAILSTableAdapter
    Friend WithEvents FULLDESCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITMUNITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITMQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APPQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQBYDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DATEAPPROVEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQTYPEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQPURPOSEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQDIVISIONDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EMPNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEREQUESTEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQDATEPERIODDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQDATENEEDEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQBY1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQBYPOSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQAUTHDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQAUTHPOSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQAPPDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQAPPPOSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQISSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQISSPOSDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents REQNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQTYPEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQPURPOSEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQDIVISIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQDATEPERIODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATE_NEEDED As DataGridViewTextBoxColumn
    Friend WithEvents FULLNAME As DataGridViewTextBoxColumn
    Friend WithEvents ENCODED_DATE As DataGridViewTextBoxColumn
    Friend WithEvents REQBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQBYPOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQAUTHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQAUTHPOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQAPPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQAPPPOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQISSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQISSPOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BTNPRINT As DataGridViewButtonColumn
    Friend WithEvents BTNACTION_EDIT As DataGridViewButtonColumn
    Friend WithEvents BTN_DETAILS As DataGridViewButtonColumn
    Friend WithEvents SPM4_UQ_IQ_SIGNATORYBindingSource As BindingSource
    Friend WithEvents SPM4_UQ_IQ_SIGNATORYTableAdapter As DS_STOREDPROCTableAdapters.SPM4_UQ_IQ_SIGNATORYTableAdapter
    Friend WithEvents SPM4_USER_SIGNATORYBindingSource As BindingSource
    Friend WithEvents SPM4_USER_SIGNATORYTableAdapter As DS_STOREDPROCTableAdapters.SPM4_USER_SIGNATORYTableAdapter
    Friend WithEvents TableAdapterManager1 As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SPM4_CURRENTDATETIMEBindingSource As BindingSource
    Friend WithEvents SPM4_CURRENTDATETIMETableAdapter As DS_STOREDPROCTableAdapters.SPM4_CURRENTDATETIMETableAdapter
    Friend WithEvents LLBL_SAVE As LinkLabel
    Friend WithEvents PB_SAVE As PictureBox
    Friend WithEvents RECT_SAVE As PowerPacks.RectangleShape
    Friend WithEvents SPM4_ITEM_REQ_CODEBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_REQ_CODETableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_REQ_CODETableAdapter
End Class
