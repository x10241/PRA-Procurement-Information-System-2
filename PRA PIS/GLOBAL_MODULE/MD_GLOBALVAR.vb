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
    Public slideFlaGY As Boolean
    Public slideFlaGX2 As Boolean
    Public X2_LOC As Integer = 1095
    Public X_LOC As Integer = 1095
    Public Y_LOC As Integer = 620
    Public PNL_SLIDE As Panel
    Public PNL_SLIDE2 As Panel
    Public PNL_SLIDE_Y As Panel
    Public GRP_SLIDE As GroupBox
    Public rptDoc As ReportDocument

    Public _IMGPATH As String

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
    Public QUANTITYFORDISTRIBUTION As Integer
    Public CELLVALUEHOLDER As Integer
    Public DATEPERIOD As String
    Public DATEPERIODBOOL As Boolean = True
    Public ISITE As Boolean = True
    Public EMP_DEPT_DIV As String
    Public SYS_USER As String
    Public SYS_FULLNAME_FML As String
    Public TXT_REQ_ID As TextBox
    Public TXT_AUTH_ID As TextBox
    Public TXT_APPR_ID As TextBox
    Public TXT_ISSU_ID As TextBox
    Public R_CB_REQUISITION_TYPE As String
    Public R_PURPOSE As String
    Public R_FOR_THE_PERIOD As String
    Public R_DATE_NEEDED As String
    Public R_REQU_NAME As String
    Public R_REQU_POSI As String
    Public R_AUTHORIZEDNAME As String
    Public R_AUTH_POSITION As String
    Public R_APPR_NAME As String
    Public R_APPR_POSI As String
    Public R_ISSU_NAME As String
    Public R_ISSU_POSI As String
    Public R_DATE As String
    Public REQ_CODE As String
    Public EMP_POSITION As String
    Public REPRINT As Boolean
    Public A_STOCKS As Integer
    Public ITM_CODE As String
    Public INV_CAT As Integer
    Public INV_SUB_CAT As Integer
    Public INV_BRAND As Integer
    Public INV_SIZE As Integer
    Public INV_COLOR As Integer
    Public INV_LENG As Integer
    Public INV_OTHERS As Integer
    Public INV_NAME As Integer
    Public DR_ID As String
    Public CODEHOLDER As Integer
    Public INV_DEF_CAT As String
    Public INV_DEF_SUB_CAT As String
    Public INV_DEF_BRAND As String
    Public INV_DEF_SIZE As String
    Public INV_DEF_COLOR As String
    Public INV_DEF_LENG As String
    Public INV_DEF_OTHER As String
    Public INV_DEF_NAME As String
    Public REPORT_TYPE As String
    Public ISSAVE As Boolean
    Public REP_TYPE As String
    Public ENC_TYPE As String
    Public ITM_DR_NO As String
    Public ITM_DR_DATE_DELIVERED As String
    Public ITM_DR_TIN_NO As String
    Public ITM_DR_COMP_NAME As String
    Public ITM_DR_DESC As String
    Public ITM_DR_QTY As String
    Public ITM_DR_UNIT_TYPE As String
    Public ITM_DR_WARRANTY As String
    Public INV_NO As String
    Public T_INV_NO As String
    Public T_INV_DT As String
    Public T_INV_TIN_NO As String
    Public T_INV_COMPANY As String
    Public FILTERTYPE As String = Nothing
    Public USER_DIVISION As String
    Public ISLOT As Boolean
    Public INV_ENC_UNIT_COST As String
    Public INV_ENC_TOTAL_COST As String
End Module
