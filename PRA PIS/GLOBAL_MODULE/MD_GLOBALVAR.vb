Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.VisualBasic.PowerPacks

Module MD_GLOBALVAR
    Public ERRLOG As New ErrorLogger
    Public enc As New RimsClass.SECURITY
    Public GBL_USERNAME As String
    Public GBL_USERNPASS As String
    Public DIVISION_NO As String
    Public EMP_NO As String
    Public STARTINGPOSITION As Integer
    Public TXTISDBATE As Boolean
    Public TXTDATE As TextBox
    Public TXTGLOBAL As TextBox
    Public TXTSIGNO As TextBox
    Public POSITION As TextBox
    Public llbl As LinkLabel
    Public dgv As DataGridView
    Public rect As RectangleShape
    Public RPTDOC_PURCHASEREQUEST As ReportDocument
    Public TRANSCHK_BOOL As Boolean
    Public CB_SCHEMEHANDLED As Boolean = False
    Public MEMTYPE As String
    Public SRRV_STR As String
    Public slideFlaG As Boolean
    Public X_LOC As Integer = 1095
    Public Y_LOC As Integer = 620
    Public PNL_SLIDE As Panel
    Public GRP_SLIDE As GroupBox
    Public rptDoc As ReportDocument

    Public ABTNMAINCTR As Integer = 0

    Public CRSAIF_ENC_UPT_VAL As Integer = 0

    Public DGV_REQ_ROWCTR As Integer
    Public DGV_REQ_COLCTR As Integer

    Public VALIDATEDCHK As String

    Public BM_CODE As String
    Public PASSPORT As String
    Public LNAME As String
    Public FNAME As String
    Public BANK_CODE As String
    Public BANK_NAME As String
    Public BKBR_ID As String
    Public BANK_BRANCH As String
    Public BANK_LOC As String

    Public NAME_BOOL As Boolean
    Public BANK_BOOL As Boolean
    Public IFCTDACCEPTED As Boolean

    Public ISVALID As Boolean = True
    Public isNew As Boolean = True
    Public USERFULLNAME As String
    Public USERDEPARTMENT As String
    Public USERDIVISION As String
    Public dt As DataTable

    'variable for purchase request
    Public PR_DATEREQUESTED As String
    Public PR_APPCODE As String
    Public PR_PURPOSE As String
    Public PR_REQUESTEDBY As String
    Public PR_REQUESTEDBYPOSITION As String
    Public PR_APPROVEDBY As String
    Public PR_APPROVEDBYPOSITION As String
    Public PR_CERTIFIEDBY As String
    Public PR_CERTIFIEDBYPOSITION As String
    Public PR_NOTEDBY As String
    Public PR_NOTEDBYPOSITION As String
    Public PR_DEPARTMENT As String
    Public PR_DIVISION As String
    Public PRNO_GEN As String
    Public BYT() As Byte
    Public PBX As PictureBox
    Public PR_ATTACHMENT As String
    Public TXTTRANSCODE As TextBox
    Public is_preview As Boolean
    Public isPODIV As Boolean = True
    Public isValidPRNO As Boolean
    Public PR_STATUS As Integer
    Public PRSELECTION As String
    Public MAINTENANCEIDHOLD As String
    Public ITEMCODE As String
    Public CAT_HOLDERNO As String
    Public PRNO As String
    Public isSCANNERCLOSE As Boolean = True
    Public ISDOLLARS As Boolean
    Public holdbyte As Byte
    Public isPreviewClick As Boolean
    Public isSatellite As Boolean
    Public passBtn As Button
    Public isBinded As Boolean
    Public EditBool As Boolean
    Public printPreview As String
    Public stickerType As Integer
    Public maintenanceCODE As String
    Public empfullname As TextBox
    Public division As TextBox
    Public department As TextBox
    Public employee_no As TextBox
    Public BSDGRID As BindingSource
    Public QRTEXT As String
    Public ACCOUNTABLE_OFFICER As TextBox
    Public PROPERTY_USER As String
    Public ACCOUNTABLE_CTR As Boolean = True
    Public TXTAPPCODE As TextBox
    Public TXTREQUESTEDDATE As TextBox
    Public TXTSUBMITTEDBY As TextBox
    Public RBTNISDOLLAR As RadioButton
    Public CBDEPARTMENT As ComboBox
    Public CBDIVISION As ComboBox
    Public TXTPURPOSE As TextBox
    Public IR_CBFILTERBY As String
    Public IR_CBDATEBY As String
    Public IR_KEYWORD As String
    Public IR_DATEFROM As String
    Public IR_DATETO As String
    Public IR_REPORTHEADER As String
    Public IR_ALLITEMS As Boolean
    Public IR_ASOFDATE As Date
    Public ITEQUIPMENTBOOL As Boolean
End Module
