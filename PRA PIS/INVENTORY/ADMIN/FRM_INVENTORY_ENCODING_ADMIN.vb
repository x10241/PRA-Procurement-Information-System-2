Imports System.IO
Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_INVENTORY_ENCODING_ADMIN

#Region "VARIABLES DECLARATION"

    Dim showbool As Boolean
    Dim m_szPaperSource As String = "3"                 ' 0 auto, 1 adf front, 2 adf rear, 3 adf duplex, 4 flatbed
    Dim m_szShowScannerUI As String = "0"               ' 0 off, 1 on
    Dim m_szFileName As String = "img"
    Dim m_szFileNumber As String = "0"                  ' 0 to 999
    Dim m_szFilePathName As String = "C:\twain"
    Dim m_szLanguage As String = "0"                    ' 0 English, 1 Chinese Simplified, 2 Chinese Traditional
    Dim m_szScanAs As String = "2"                      ' 0 bw, 1 gray, 2 color
    Dim m_szDpiResolution As String = "200"             ' 100, 150, 200, 240, 250, 300, 400, 500, 600, 1200
    Dim m_szDocumentType As String = "1"                ' 0 photo, 1 textwithgraphics, 2 textwithphoto, 3 text
    Dim m_szFileType As String = "0"                    ' 0 tiff, 4 jpeg
    Dim m_szCompressionType As String = "0"             ' 0 none, 5 g4, 6 jpeg
    Dim m_szJpegQuality As String = "50"                ' 40 draft, 50 good, 80 better, 90 best, 100 superior
    Dim m_szSharpen As String = "0"                     ' 0 none, 1 normal, 2 high, 3 exaggerated
    Dim m_szOrthogonalRotation As String = "1"          ' 0 none, 1 auto, 2 90, 3 180, 4 270, 5 auto 90, 6 auto 180, 7 auto 270 
    Dim m_szImageRotation As String = "1"               ' 0 0, 1 auto, 2 none, 90 90, 180 180 , 270 270, 360 360
    Dim m_szBlankImageDeletion As String = "1"          ' 1 none, 2 content
    Dim m_szBlankImageDeletionPercent As String = "0"   ' 0 to 100
    Dim m_szScanner As String = "KODAK Scanner: i2000"
    Dim m_szScannerProfile As String = "1"              ' 1 is typically "Default" profile
    Dim m_szOnePage As String = "0"                     ' 0 scan mulitple pages, 1 scan 1 page
    Dim filenumber As Integer
    Dim i As Integer = 0

    Dim KODAKSCANSDK As KODAKSCANSDK.Program
    Dim hWnd As IntPtr = Me.Handle
    Private WithEvents MyScanEvent As KODAKSCANSDK.Program

#End Region

#Region "START ##### FORM DRAG AND DROP, MINIMIZE, CLOSE"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PNL_DoubleClick(sender As Object, e As EventArgs) Handles PNL.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseUp
        drag = False
    End Sub
#End Region

    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function

#Region "TIMER"

    Private WithEvents UCPROCTim As New Timer With {.Interval = 10}
    Private WithEvents UCPROCTim2 As New Timer With {.Interval = 10}

    Private Sub Tim_Tick(sender As Object, e As EventArgs) Handles UCPROCTim.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTim Then
            Try
                If slideFlaG = True Then
                    X_LOC -= 100
                    PNL_SLIDE.Location = New Point(X_LOC, 108)
                    If PNL_SLIDE Is APNL_ITEMINFO Then
                        If X_LOC < 514 Then
                            PNL_SLIDE.Location = New Point(514, 108)
                            X_LOC = 514
                            UCPROCTim.Enabled = False
                        End If
                    End If
                Else
                    PNL_SLIDE.Location = New Point(1095, 108)
                    X_LOC = 1095
                    UCPROCTim.Enabled = False
                End If
            Catch ex As Exception
                X_LOC = 0
            End Try
        End If
    End Sub

    Private Sub Tim_Tick2(sender As Object, e As EventArgs) Handles UCPROCTim2.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTim2 Then
            Try
                If slideFlaG = True Then
                    Y_LOC -= 74
                    GRP_SLIDE.Location = New Point(278, Y_LOC)
                    If GRP_SLIDE Is GRP_ITEMINFO Then
                        If Y_LOC < 74 Then
                            GRP_SLIDE.Location = New Point(278, 74)
                            Y_LOC = 74
                            UCPROCTim2.Enabled = False
                        End If
                    End If
                Else
                    GRP_SLIDE.Location = New Point(278, 620)
                    Y_LOC = 620
                    UCPROCTim2.Enabled = False
                End If
            Catch ex As Exception
                Y_LOC = 0
            End Try
        End If
    End Sub

#End Region

#Region "CLICK"
    Private Sub LLBL_INVENTORY_NEW_LinkClicked(sender As Object, e As EventArgs) Handles LLBL_INVENTORY_NEW.LinkClicked,
                                                                                                PB_INVENTORY_NEW.Click,
                                                                                                LLBL_INVENTORY_VIEW_REPORT.LinkClicked,
                                                                                                PB_INVENTORY_VIEW_REPORT.Click,
                                                                                                LLBL_INVENTORY_EDIT.LinkClicked,
                                                                                                PB_INVENTORY_EDIT.Click,
                                                                                                BTN_INVENTORY_SAVE.Click,
                                                                                                BTN_INVENTORY_CANCEL.Click,
                                                                                                BTN_CLOSE_INVENTORY_MINI_CLOSE.Click,
                                                                                                BTN_INVENTORY_MINIMIZE.Click,
                                                                                                BTN_INVENTORY_CLOSE.Click,
                                                                                                PB_INVENTORY_CLEAR_SEARCH.Click,
                                                                                                PB_INVENTORY_SEARCH.Click,
                                                                                                BTN_ADD_CATEGORY.Click,
                                                                                                LLBL_STICK_LAB.Click,
                                                                                                PB_STICK_LAB.Click,
                                                                                                RECT_STICK_LAB.Click,
                                                                                                WTXT_INVENTORY_DATE_OF_ACQUISITION.Click,
                                                                                                BTN_ADD_SUBCATEGORY.Click,
                                                                                                BTN_ADD_BRAND_PROVIDER.Click,
                                                                                                PB_ITEM_DISTRIBUTION.Click,
                                                                                                LLBL_ITEM_DISTRIBUTION.Click,
                                                                                                RECT_ITEM_DISTRIBUTION.Click,
                                                                                                LLBL_STOCKS.Click,
                                                                                                RECT_STOCKS.Click,
                                                                                                PB_STOCKS.Click,
                                                                                                LLBL_DR_LIST.Click,
                                                                                                RECT_DR_LIST.Click,
                                                                                                LLBL_IIL.Click,
                                                                                                RECT_IIL.Click,
                                                                                                RECT_PCOUNT.Click,
                                                                                                PB_PCOUNT.Click,
                                                                                                LLBL_PCOUNT.Click,
                                                                                                RECT_INVENTORY_VIEW_REPORT.Click


        Try
            Dim pb As PictureBox = Nothing
            Dim btn As Button = Nothing
            llbl = Nothing
            rect = Nothing
            TXTGLOBAL = Nothing

            If TypeOf sender Is LinkLabel Then
                llbl = DirectCast(sender, LinkLabel)
            ElseIf TypeOf sender Is RectangleShape Then
                MD_GLOBALVAR.rect = DirectCast(sender, RectangleShape)
            ElseIf TypeOf sender Is PictureBox Then
                pb = CType(sender, PictureBox)
            ElseIf TypeOf sender Is Button Then
                btn = CType(sender, Button)
            ElseIf TypeOf sender Is TextBox Then
                TXTGLOBAL = CType(sender, TextBox)
            End If
#Region "New"
            If llbl Is LLBL_INVENTORY_NEW Or pb Is PB_INVENTORY_NEW Then

                UCPROCTim.Enabled = True
                slideFlaG = True
                PNL_SLIDE = APNL_ITEMINFO
                PNL_SLIDE.BringToFront()
                _ENABLE("New")
                EditBool = False
                Me.TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, 1, DIVISION_NO)
                Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.FillByINVCODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND, 1)
                Me.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_OTHERS_MAIN)
                Me.TBLM4_INV_ITEMS_LENG_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_LENG_MAIN)
                If CB_INV_CAT.Items.Count > 0 Then
                    Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INV_CAT.SelectedValue), 0, CB_INV_CAT.SelectedValue)), DIVISION_NO)
                End If
                If CB_INV_SC.Items.Count > 0 Then
                    TBLM4_INV_ITEMS_NAME_MAINTableAdapter.FillBySC_CODE(DS_PROPERTYDB.TBLM4_INV_ITEMS_NAME_MAIN, CInt(If(IsDBNull(CB_INV_SC.SelectedValue), 0, CB_INV_SC.SelectedValue)))
                End If
                TBLM4_INV_ITEMS_COLOR_MAINTableAdapter.Fill(DS_PROPERTYDB.TBLM4_INV_ITEMS_COLOR_MAIN)
                TBLM4_INV_ITEMS_SIZE_MAINTableAdapter.Fill(DS_PROPERTYDB.TBLM4_INV_ITEMS_SIZE_MAIN)
                PB_ITEM_IMAGE.BackgroundImage = My.Resources.images
                PB_ITEM_IMAGE.Image = Nothing
#End Region

            ElseIf TXTGLOBAL Is WTXT_INVENTORY_DATE_OF_ACQUISITION Then
                TXTDATE = CType(sender, TextBox)
                FRM_DATAENTRY.ShowDialog()

#Region "Edit"
            ElseIf llbl Is LLBL_INVENTORY_EDIT Or pb Is PB_INVENTORY_EDIT Then
                'If DGV_INV_ITEM_LIST.SelectedRows.Count > 0 Then
                '    If EditBool Then

                '    End If
                'End If
#End Region

#Region "Save"
            ElseIf btn Is BTN_INVENTORY_SAVE Then
                '  If REQFIELDVALIDATION(WTXT_INV_ALIAS_NAME) Then
                '  If MsgBox("Are you sure do you want to leave Alias name as Blank?", vbYesNo, "Confirm") = vbYes Then
                _SAVE()
                '    End If
                '  End If

#End Region

#Region "Cancel"
            ElseIf btn Is BTN_INVENTORY_CANCEL Or btn Is BTN_CLOSE_INVENTORY_MINI_CLOSE Then
                If MsgBox("Do you want to cancel this?", vbYesNo, "Confirm") = vbYes Then
                    _ENABLE("Clear")
                    UCPROCTim.Enabled = True
                    slideFlaG = False
                    DGV_INV_ITEM_LIST.ClearSelection()
                End If
#End Region

#Region "REPORT"
            ElseIf pb Is PB_INVENTORY_VIEW_REPORT Or llbl Is LLBL_INVENTORY_VIEW_REPORT Or rect Is RECT_INVENTORY_VIEW_REPORT Then
                REP_TYPE = "ITEM_LIST"
                dgv = DGV_INV_ITEM_LIST
                FRM_PMD_PRINT_PREVIEW.ShowDialog()
#End Region

#Region "Minimize"
            ElseIf btn Is BTN_INVENTORY_MINIMIZE Then
                Me.WindowState = FormWindowState.Minimized
#End Region

#Region "Close"
            ElseIf btn Is BTN_INVENTORY_CLOSE Then
                Me.Close()
#End Region

#Region "Clear"
            ElseIf pb Is PB_INVENTORY_CLEAR_SEARCH Then
                WTXT_ITEM_SEARCH.Clear()
#End Region

#Region "Search"
            ElseIf pb Is PB_INVENTORY_SEARCH Then
                If WTXT_ITEM_SEARCH.Text.Length > 0 Then
                    PB_INVENTORY_CLEAR_SEARCH.BringToFront()
                Else
                    PB_INVENTORY_SEARCH.BringToFront()
                End If
                '  SPM4_INVENTORYDGVLISTTableAdapter.Fill(DS_PROPERTYDB.SPM4_INVENTORYDGVLIST, WTXT_INVENTORY_SEARCH.Text, "IT-ADMIN")
                LLBL_RECORDSFOUND.Text = DGV_INV_ITEM_LIST.Rows.Count
#End Region

#Region "STICKER TAG"
            ElseIf llbl Is LLBL_STICK_LAB Or rect Is rect_STICK_LAB Then
                FRM_RACK_STICKER.ShowDialog()
#End Region

#Region "SHOW STOCKS FORM"
            ElseIf llbl Is LLBL_STOCKS Or pb Is PB_STOCKS Or rect Is RECT_STOCKS Then
                FRM_STOCK_ENC.ShowDialog()
#End Region

#Region "DR LIST"
            ElseIf llbl Is LLBL_DR_LIST Or pb Is PB_DR_LIST Or rect Is RECT_DR_LIST Then
                FRM_DR_MASTERLIST.ShowDialog()

#End Region

#Region "ISSUED LIST"

            ElseIf llbl Is LLBL_IIL Or pb Is PB_IIL Or rect Is RECT_IIL Then
                ITEMCODE = ""
                FRM_ISSUED_ITEM_LIST.LBLSETTINGSHEAD.Text = "I s s u e d  I t e m  M a s t e r l i s t"
                FRM_ISSUED_ITEM_LIST.ShowDialog()
#End Region

#Region "P COUNT"

            ElseIf rect Is RECT_PCOUNT Or pb Is PB_PCOUNT Or llbl Is LLBL_PCOUNT Then
                FRM_PCOUNT.ShowDialog()

#End Region

#Region "Search Ref No."
            ElseIf pb Is PB_ITEM_DISTRIBUTION Or llbl Is LLBL_ITEM_DISTRIBUTION Or rect Is RECT_ITEM_DISTRIBUTION Then
                FRM_SEARCH_REF_NO.ShowDialog()
                ' FRM_ITEM_DISTRIBUTION.ShowDialog()
            End If
#End Region

        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub
#End Region

#Region "ENABLE/CLEAR"
    Sub _ENABLE(TRANSACTION As String)
        If TRANSACTION = "New" Then
            isNew = True
            WTXT_INV_ALIAS_NAME.Clear()
            'WTXT_INVENTORY_QUANTITY.Text = 0
            'WTXT_INVENTORY_UNITCOST.Text = 0
            'WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = True
            'WTXT_INVENTORY_ITEM_DESCRIPTION.Enabled = True
            'WTXT_INVENTORY_QUANTITY.Enabled = True
            'WTXT_INVENTORY_SERIAL_NO.Enabled = True
            'WTXT_INVENTORY_UNITCOST.Enabled = True
            'CB_INVENTORY_BRAND_NAME.Enabled = True
            'CB_INVENTORY_CATEGORY.Enabled = True
            'CB_INVENTORY_SUBCATEGORY.Enabled = True
            'CB_INVENTORY_UNIT_TYPE.Enabled = True
            ''  CB_ITEMS_LOCATION.Enabled = True
            'LLBL_INVENTORY_EDIT.Enabled = False
            'PB_INVENTORY_EDIT.Enabled = False
            'PB_INVENTORY_NEW.Enabled = False
            'LLBL_INVENTORY_NEW.Enabled = False
            'WTXT_INVENTORY_SEARCH.Enabled = False
            'DGV_INV_ITEM_LIST.Enabled = False
            'LLBL_INVENTORY_VIEW_REPORT.Enabled = False
            'PB_INVENTORY_VIEW_REPORT.Enabled = False
            'WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = True
            'RBT_PURCHASED.Checked = True
            'CB_INV_CAT.SelectedIndex = 0
            'CB_INV_SC.SelectedIndex = 0
            'CB_INV_BRAND.SelectedIndex = 0
            'CB_INV_SIZE.SelectedIndex = 0
            'CB_INV_COLOR.SelectedIndex = 0
        ElseIf TRANSACTION = "Edit" Then
            isNew = False
            WTXT_INVENTORY_ITEM_DESCRIPTION.Enabled = True
            WTXT_INVENTORY_QUANTITY.Enabled = True
            WTXT_INVENTORY_SERIAL_NO.Enabled = True
            WTXT_INVENTORY_UNITCOST.Enabled = True
            CB_INVENTORY_BRAND_NAME.Enabled = True
            CB_INVENTORY_CATEGORY.Enabled = True
            CB_INVENTORY_SUBCATEGORY.Enabled = True
            CB_INVENTORY_UNIT_TYPE.Enabled = True

            '    CB_ITEMS_LOCATION.Enabled = True
            LLBL_INVENTORY_EDIT.Enabled = True
            PB_INVENTORY_EDIT.Enabled = True
            PB_INVENTORY_NEW.Enabled = False
            LLBL_INVENTORY_NEW.Enabled = False
            WTXT_ITEM_SEARCH.Enabled = False
            DGV_INV_ITEM_LIST.Enabled = False
            LLBL_INVENTORY_VIEW_REPORT.Enabled = False
            PB_INVENTORY_VIEW_REPORT.Enabled = True
            WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = True
            DGV_ITEM_INFO.ClearSelection()
        Else
            WTXT_INV_ALIAS_NAME.Clear()
            WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = False
            WTXT_INVENTORY_ITEM_DESCRIPTION.Enabled = False
            WTXT_INVENTORY_QUANTITY.Enabled = False
            WTXT_INVENTORY_SERIAL_NO.Enabled = False
            WTXT_INVENTORY_UNITCOST.Enabled = False
            LLBL_INVENTORY_EDIT.Enabled = True
            PB_INVENTORY_EDIT.Enabled = True
            CB_INVENTORY_BRAND_NAME.Enabled = False
            CB_INVENTORY_CATEGORY.Enabled = False
            CB_INVENTORY_SUBCATEGORY.Enabled = False
            CB_INVENTORY_UNIT_TYPE.Enabled = False
            '  CB_ITEMS_LOCATION.Enabled = False
            PB_INVENTORY_NEW.Enabled = True
            LLBL_INVENTORY_NEW.Enabled = True
            CB_INVENTORY_BRAND_NAME.SelectedIndex = -1
            CB_INVENTORY_CATEGORY.SelectedIndex = -1
            CB_INVENTORY_SUBCATEGORY.SelectedIndex = -1
            CB_INVENTORY_UNIT_TYPE.SelectedIndex = -1
            CB_ACQUISITION_VALUE.SelectedIndex = -1
            'CB_DIVISION_UNIT.SelectedIndex = -1
            CB_ITEM_USAGE.SelectedIndex = -1
            WTXT_INVENTORY_DATE_OF_ACQUISITION.Clear()
            WTXT_INVENTORY_ITEM_DESCRIPTION.Clear()
            WTXT_INVENTORY_QUANTITY.Clear()
            WTXT_INVENTORY_SERIAL_NO.Clear()
            WTXT_INVENTORY_UNITCOST.Clear()
            WTXT_INVENTORY_TOTAL_COST.Clear()
            RECT_INVENTORY_SERIAL_NO.BorderColor = Color.LightSeaGreen
            RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = Color.LightSeaGreen
            RECT_INVENTORY_QUANTITY.BorderColor = Color.LightSeaGreen
            RECT_INVENTORY_UNIT_COST.BorderColor = Color.LightSeaGreen
            WTXT_ITEM_SEARCH.Enabled = True
            DGV_INV_ITEM_LIST.Enabled = True
            LLBL_INVENTORY_VIEW_REPORT.Enabled = True
            PB_INVENTORY_VIEW_REPORT.Enabled = True
            RBT_PURCHASED.Checked = False
            RBT_DONATED.Checked = False
            '  WTXT_CUSTODIAN_NAME.Clear()
            '   WTXT_PROPERTY_USER.Clear()
            DGV_ITEM_INFO.Rows.Clear()
            PB_ITEM_IMAGE.Image = Nothing
        End If
    End Sub
#End Region

#Region "SAVE"
    Sub _SAVE()
        Try
            Dim IMG_PATH As String = Nothing
            Dim IMG_2 As String = Nothing
            Dim fileCount As Integer = Nothing
            'check if item code has existing image
            If Directory.Exists(My.Settings.PIS_ITEM_DIR & ITM_CODE) Then
                fileCount = Directory.GetFiles(My.Settings.PIS_ITEM_DIR & ITM_CODE, "*.jpg").Length
            End If
            'check if module is for editing
            If EditBool Then
                TBLM4_INV_ITEMS_COLORTableAdapter.DQ_ITEMS_COLOR(ITM_CODE, INV_COLOR)
                TBLM4_INV_ITEMS_SIZETableAdapter.DQ_INV_ITEMS_SIZE(ITM_CODE, INV_SIZE)
                TBLM4_INV_ITEMS_LENGTableAdapter.DQ_INV_ITEMS_LENG(ITM_CODE, INV_LENG)
                TBLM4_INV_ITEMS_OTHERSTableAdapter.DQ_INV_ITEMS_OTHERS(ITM_CODE, INV_OTHERS)
                TBLM4_INV_ITEMS_NAMETableAdapter.DQ_INV_ITEMS_NAME(ITM_CODE, INV_NAME)
                TBLM4_INV_ITEMSTableAdapter.UQ_INV_ITEM(Trim(CB_INV_SC.SelectedValue), Trim(CB_INV_BRAND.SelectedValue), Trim(WTXT_INV_ALIAS_NAME.Text), EMP_NO, DIVISION_NO, ITM_CODE)
            Else
                ITM_CODE = SPM4_ITEM_CODE_GENERATORTableAdapter.SPM4_ITEM_CODE_GEN(Trim(CB_INV_CAT.SelectedValue), Trim(CB_INV_SC.SelectedValue), Trim(CB_INV_BRAND.SelectedValue), Trim(CB_INV_COLOR.SelectedValue), Trim(CB_INV_SIZE.SelectedValue), Trim(CB_INV_LENGTH.SelectedValue), Trim(CB_INV_OTHER_DESC.SelectedValue), Trim(CB_INV_NAME.SelectedValue))
                TBLM4_INV_ITEMSTableAdapter.IQ_INV_ITEM(ITM_CODE, Trim(CB_INV_SC.SelectedValue), Trim(CB_INV_BRAND.SelectedValue), EMP_NO, Trim(WTXT_INV_ALIAS_NAME.Text), DIVISION_NO)
            End If

            'check if picturebox has image
            If Not PB_ITEM_IMAGE.Image Is Nothing Then
                'check if image exists
                If File.Exists(My.Settings.PIS_ITEM_DIR & ITM_CODE & "\" & ITM_CODE & ".jpg") Then
                    IMG_2 = ITM_CODE + "_" + fileCount.ToString
                    IMG_PATH = SAVEIMAGE_TOFOLDER(ITM_CODE, IMG_2, PB_ITEM_IMAGE.Image)
                    TBLM4_INV_ITEMS_IMGTableAdapter.UQ_INV_ITEMS_IG(IMG_PATH, ITM_CODE)
                Else
                    IMG_2 = ITM_CODE
                    IMG_PATH = SAVEIMAGE_TOFOLDER(ITM_CODE, IMG_2, PB_ITEM_IMAGE.Image)
                    TBLM4_INV_ITEMS_IMGTableAdapter.IQ_INV_ITEMS_IMG(ITM_CODE, IMG_PATH, EMP_NO)
                End If
            End If

            If CB_INV_COLOR.SelectedValue <> 0 Then
                TBLM4_INV_ITEMS_COLORTableAdapter.IQ_ITEMS_COLOR(ITM_CODE, CB_INV_COLOR.SelectedValue)
            End If
            If CB_INV_SIZE.SelectedValue <> 0 Then
                TBLM4_INV_ITEMS_SIZETableAdapter.IQ_INV_ITEMS_SIZE(ITM_CODE, CB_INV_SIZE.SelectedValue)
            End If

            If CB_INV_LENGTH.SelectedValue <> 0 Then
                TBLM4_INV_ITEMS_LENGTableAdapter.IQ_INV_ITEMS_LENG(ITM_CODE, CB_INV_LENGTH.SelectedValue)
            End If

            If CB_INV_OTHER_DESC.SelectedValue <> 0 Then
                TBLM4_INV_ITEMS_OTHERSTableAdapter.IQ_INV_ITEMS_OTHERS(ITM_CODE, CB_INV_OTHER_DESC.SelectedValue)
            End If

            If CB_INV_NAME.SelectedValue <> 0 Then
                TBLM4_INV_ITEMS_NAMETableAdapter.IQ_INV_ITEMS_NAME(ITM_CODE, CB_INV_NAME.SelectedValue)
            End If

            _ENABLE("Clear")
            UCPROCTim.Enabled = True
            slideFlaG = False
            VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_ITEM_LIST, WTXT_ITEM_SEARCH.Text, DIVISION_NO)
            LLBL_RECORDSFOUND.Text = DGV_INV_ITEM_LIST.Rows.Count
            DGV_INV_ITEM_LIST.ClearSelection()
            NotificationManager.Show(Me, "Successfully Saved.", Color.Green, 3000)
        Catch ex As Exception
            NotificationManager.Show(Me, "Item Already Exist", Color.Red, 6000)
        End Try
    End Sub

#End Region

#Region "LEAVE"
    Private Sub WTXT_INVENTORY_QUANTITY_Leave(sender As Object, e As EventArgs) Handles WTXT_INVENTORY_UNITCOST.Leave, WTXT_INVENTORY_QUANTITY.Leave
        Try
            TXTGLOBAL = Nothing
            If TypeOf sender Is TextBox Then
                TXTGLOBAL = DirectCast(sender, TextBox)
            End If
            If TXTGLOBAL Is WTXT_INVENTORY_UNITCOST Or TXTGLOBAL Is WTXT_INVENTORY_QUANTITY Then
                WTXT_INVENTORY_TOTAL_COST.Text = CInt(WTXT_INVENTORY_QUANTITY.Text) * CDec(WTXT_INVENTORY_UNITCOST.Text)
                WTXT_INVENTORY_TOTAL_COST.Text = TXTSETTO_0(WTXT_INVENTORY_TOTAL_COST, False)
            End If
        Catch ex As Exception
            NotificationManager.Show(Me, "PLEASE CHECK QUANTITY AND UNIT COST VALUE!", Color.Red, 3000)
        End Try
    End Sub
#End Region

#Region "LOAD"
    Private Sub FRM_INVENTORY_ENCODING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLM4_INV_ITEMS_IMG' table. You can move, or remove it, as needed.
        Me.TBLM4_INV_ITEMS_IMGTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_IMG)
        VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_ITEM_LIST, WTXT_ITEM_SEARCH.Text, DIVISION_NO)
        LLBL_RECORDSFOUND.Text = DGV_INV_ITEM_LIST.Rows.Count
        'WTXT_ITEM_SEARCH.Text = "asd"
        'VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_ITEM_LIST, WTXT_ITEM_SEARCH.Text, DIVISION_NO)
        'WTXT_ITEM_SEARCH.Clear()
    End Sub

#End Region

#Region "COMBOBOX"
    Private Sub CB_ITEM_USAGE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ITEM_USAGE.SelectedIndexChanged
        If CB_ITEM_USAGE.SelectedIndex = CB_ITEM_USAGE.FindStringExact("Consumable") Then
            GRP_CONSUMABLE.Visible = True
        Else
            GRP_CONSUMABLE.Visible = False
        End If
    End Sub


    Private Sub CB_INV_CAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INV_CAT.SelectedIndexChanged
        If CB_INV_CAT.Items.Count > 0 Then
            Try
                Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INV_CAT.SelectedValue), 0, CB_INV_CAT.SelectedValue)), DIVISION_NO)
                If CB_INV_SC.Items.Count > 0 Then
                    Try
                        TBLM4_INV_ITEMS_NAME_MAINTableAdapter.FillBySC_CODE(DS_PROPERTYDB.TBLM4_INV_ITEMS_NAME_MAIN, CInt(If(IsDBNull(CB_INV_SC.SelectedValue), 0, CB_INV_SC.SelectedValue)))
                    Catch ex As Exception
                        ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "SUB CATEGORY SELECTED INDEX CHANGED")
                    End Try
                End If
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "CATEGORY SELECTED INDEX CHANGED")
            End Try
        End If
    End Sub

    Private Sub CB_INV_SC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INV_SC.SelectedIndexChanged
        If CB_INV_SC.Items.Count > 0 Then
            Try
                TBLM4_INV_ITEMS_NAME_MAINTableAdapter.FillBySC_CODE(DS_PROPERTYDB.TBLM4_INV_ITEMS_NAME_MAIN, CInt(If(IsDBNull(CB_INV_SC.SelectedValue), 0, CB_INV_SC.SelectedValue)))
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "SUB CATEGORY SELECTED INDEX CHANGED")
            End Try
        End If
    End Sub


#End Region

#Region "LABEL CLICK INSIDE PANEL SLIDE"
    Private Sub LLBL_ADDITEM_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLBL_ADDITEM.LinkClicked,
                                                                                                        LLBL_CLOSE.LinkClicked,
                                                                                                         LLBL_SAVE_ADD_ITEM.LinkClicked,
                                                                                                          LLBL_REMOVE_ITEM.LinkClicked,
                                                                                                          LLBL_EDIT_ITEM.LinkClicked

        llbl = Nothing
        If TypeOf sender Is LinkLabel Then
            llbl = CType(sender, LinkLabel)
        End If

        If llbl Is LLBL_ADDITEM Then
            UCPROCTim2.Enabled = True
            slideFlaG = True
            GRP_SLIDE = GRP_ITEMINFO
            GRP_SLIDE.BringToFront()
            'GRP_ACCOUNTABLE_UNIT_PERSON.Enabled = False
            GRP_LIST_ITEMS.Enabled = False
            BTN_INVENTORY_CANCEL.Enabled = False
            BTN_INVENTORY_SAVE.Enabled = False
            ' Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_CURRENTDATETIME)
            '   _ENABLE("clear")
            _ENABLE("New")
        ElseIf llbl Is LLBL_CLOSE Then
            UCPROCTim2.Enabled = True
            slideFlaG = False
            '   GRP_ACCOUNTABLE_UNIT_PERSON.Enabled = True
            GRP_LIST_ITEMS.Enabled = True
            BTN_INVENTORY_CANCEL.Enabled = True
            BTN_INVENTORY_SAVE.Enabled = True
            DGV_ITEM_INFO.ClearSelection()
        ElseIf llbl Is LLBL_SAVE_ADD_ITEM Then
            ISVALID = True
            If REQFIELDVALIDATION(WTXT_INVENTORY_ITEM_DESCRIPTION) Then
                RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = Color.LightSeaGreen
            End If


            If WTXT_INVENTORY_QUANTITY.Text = 0 Then
                RECT_INVENTORY_QUANTITY.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_INVENTORY_QUANTITY.BorderColor = Color.LightSeaGreen
            End If

            If ISVALID Then
                If DGV_ITEM_INFO.Rows.Count > 0 Then
                    DGV_ITEM_INFO.Rows.RemoveAt(DGV_ITEM_INFO.CurrentRow.Index)
                End If

                DGV_ITEM_INFO.Rows.Add(WTXT_INVENTORY_DATE_OF_ACQUISITION.Text,
                              CB_INVENTORY_CATEGORY.Text,
                              CB_INVENTORY_SUBCATEGORY.Text,
                              CB_INVENTORY_BRAND_NAME.Text,
                              WTXT_INVENTORY_SERIAL_NO.Text,
                              CB_INVENTORY_UNIT_TYPE.Text,
                              WTXT_INVENTORY_QUANTITY.Text,
                              WTXT_INVENTORY_UNITCOST.Text,
                              WTXT_INVENTORY_TOTAL_COST.Text,
                              WTXT_INVENTORY_ITEM_DESCRIPTION.Text,
                               CB_INVENTORY_CATEGORY.SelectedValue,
                               CB_INVENTORY_SUBCATEGORY.SelectedValue,
                               CB_INVENTORY_BRAND_NAME.SelectedValue)
                NotificationManager.Show(GRP_ITEMINFO, "Successfully added!", Color.Green, 1000)
            Else
                NotificationManager.Show(GRP_ITEMINFO, "Please provide all required fields.", Color.Red, 3000)
            End If

        ElseIf llbl Is LLBL_REMOVE_ITEM Then
            If DGV_ITEM_INFO.SelectedRows.Count > 0 Then
                If MsgBox("Remove this?", vbYesNo, "Confirm") = vbYes Then
                    DGV_ITEM_INFO.Rows.RemoveAt(DGV_ITEM_INFO.CurrentRow.Index)
                End If
            End If
        ElseIf llbl Is LLBL_EDIT_ITEM Then
            If DGV_ITEM_INFO.SelectedRows.Count > 0 Then
                'Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND)
                'Me.TblM4_INVENTORY_CATEGORYTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
                'TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CB_INVENTORY_CATEGORY.SelectedValue)
                CB_INVENTORY_CATEGORY.SelectedIndex = CB_INVENTORY_CATEGORY.FindStringExact(DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(1).Value)
                CB_INVENTORY_SUBCATEGORY.SelectedIndex = CB_INVENTORY_SUBCATEGORY.FindStringExact(DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(2).Value)
                CB_INVENTORY_BRAND_NAME.SelectedIndex = CB_INVENTORY_BRAND_NAME.FindStringExact(DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(3).Value)
                WTXT_INVENTORY_SERIAL_NO.Text = DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(4).Value
                CB_INVENTORY_UNIT_TYPE.SelectedIndex = CB_INVENTORY_UNIT_TYPE.FindStringExact(DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(5).Value)
                WTXT_INVENTORY_QUANTITY.Text = DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(6).Value
                WTXT_INVENTORY_UNITCOST.Text = DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(7).Value
                WTXT_INVENTORY_UNITCOST.Text = TXTSETTO_0(WTXT_INVENTORY_UNITCOST, True)
                WTXT_INVENTORY_TOTAL_COST.Text = DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(8).Value
                WTXT_INVENTORY_TOTAL_COST.Text = TXTSETTO_0(WTXT_INVENTORY_TOTAL_COST, True)
                WTXT_INVENTORY_ITEM_DESCRIPTION.Text = DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(9).Value
                WTXT_INVENTORY_DATE_OF_ACQUISITION.Text = DGV_ITEM_INFO.Rows(DGV_ITEM_INFO.CurrentRow.Index).Cells(0).Value
                UCPROCTim2.Enabled = True
                slideFlaG = True
                GRP_SLIDE = GRP_ITEMINFO
                GRP_SLIDE.BringToFront()
                '      GRP_ACCOUNTABLE_UNIT_PERSON.Enabled = False
                GRP_LIST_ITEMS.Enabled = False
                BTN_INVENTORY_CANCEL.Enabled = False
                BTN_INVENTORY_SAVE.Enabled = False

            End If
        End If
    End Sub
#End Region

#Region "Cell Event"

    Private Sub DGV_INV_ITEM_LIST_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV_INV_ITEM_LIST.CellFormatting
        'If Not IsDBNull(DGV_INV_ITEM_LIST(24, e.RowIndex).Value) Then
        '    DGV_INV_ITEM_LIST(0, e.RowIndex).Value = Image.FromFile(DGV_INV_ITEM_LIST(24, e.RowIndex).Value)
        'Else
        '    DGV_INV_ITEM_LIST(0, e.RowIndex).Value = My.Resources._480px_No_image_available_svg
        'End If
    End Sub


    Private Sub DGV_ITEM_INFO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ITEM_INFO.CellClick
        If DGV_ITEM_INFO.SelectedRows.Count > 0 Then
            RECT_REMOVE_ITEM.Visible = True
            LLBL_REMOVE_ITEM.Visible = True
            RECT_EDIT_ITEM.Visible = True
            LLBL_EDIT_ITEM.Visible = True
        Else
            RECT_REMOVE_ITEM.Visible = False
            LLBL_REMOVE_ITEM.Visible = False
            RECT_EDIT_ITEM.Visible = False
            LLBL_EDIT_ITEM.Visible = False
        End If
    End Sub

    Private Sub DGV_ITEM_INFO_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGV_ITEM_INFO.RowsRemoved
        If DGV_ITEM_INFO.SelectedRows.Count = 0 Then
            RECT_REMOVE_ITEM.Visible = False
            LLBL_REMOVE_ITEM.Visible = False
            RECT_EDIT_ITEM.Visible = False
            LLBL_EDIT_ITEM.Visible = False
        End If
    End Sub

    Private Sub DGV_INVENTORY_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_INV_ITEM_LIST.CellClick
        _ENABLE("Clear")
        Dim dgv1 = CType(sender, DataGridView)
        If DGV_INV_ITEM_LIST.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                'EDIT
                If e.ColumnIndex = 23 Then


                    'load default value to combobox
                    TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, 1, DIVISION_NO)
                    TblM4_INVENTORY_ITEMBRANDTableAdapter.FillByINVCODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND, 1)
                    TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_OTHERS_MAIN)
                    TBLM4_INV_ITEMS_LENG_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_LENG_MAIN)
                    TBLM4_INV_ITEMS_COLOR_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_COLOR_MAIN)
                    TBLM4_INV_ITEMS_SIZE_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_SIZE_MAIN)
                    TBLM4_INV_ITEMS_NAME_MAINTableAdapter.Fill(DS_PROPERTYDB.TBLM4_INV_ITEMS_NAME_MAIN)
                    'load value of sub category IF CATEGORY CONTAINS VALUE
                    If CB_INV_CAT.Items.Count > 0 Then
                        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INV_CAT.SelectedValue), 0, CB_INV_CAT.SelectedValue)), DIVISION_NO)
                        TBLM4_INV_ITEMS_NAME_MAINTableAdapter.FillBySC_CODE(DS_PROPERTYDB.TBLM4_INV_ITEMS_NAME_MAIN, CInt(If(IsDBNull(CB_INV_SC.SelectedValue), 0, CB_INV_SC.SelectedValue)))

                    End If
                    '    If CB_INV_SC.Items.Count > 0 Then

                    '   End If
                    PB_ITEM_IMAGE.BackgroundImage = Nothing
                    _IMGPATH = If(IsDBNull(DGV_INV_ITEM_LIST(24, e.RowIndex).Value), 0, DGV_INV_ITEM_LIST(24, e.RowIndex).Value)
                    If _IMGPATH = "0" Then
                        PB_ITEM_IMAGE.BackgroundImage = My.Resources._480px_No_image_available_svg
                    Else
                        PB_ITEM_IMAGE.Image = Image.FromFile(_IMGPATH)
                    End If

                    'PASS VALUE TO COMBOBOX
                    ITM_CODE = DGV_INV_ITEM_LIST(1, e.RowIndex).Value
                    CB_INV_CAT.SelectedValue = DGV_INV_ITEM_LIST(2, e.RowIndex).Value
                    CB_INV_SC.SelectedValue = DGV_INV_ITEM_LIST(4, e.RowIndex).Value
                    INV_NAME = If(IsDBNull(DGV_INV_ITEM_LIST(20, e.RowIndex).Value), 0, DGV_INV_ITEM_LIST(20, e.RowIndex).Value)
                    CB_INV_NAME.SelectedValue = INV_NAME
                    CB_INV_BRAND.SelectedValue = DGV_INV_ITEM_LIST(6, e.RowIndex).Value

                    INV_SIZE = If(IsDBNull(DGV_INV_ITEM_LIST(13, e.RowIndex).Value), 0, DGV_INV_ITEM_LIST(13, e.RowIndex).Value)
                    CB_INV_SIZE.SelectedValue = INV_SIZE

                    INV_COLOR = If(IsDBNull(DGV_INV_ITEM_LIST(10, e.RowIndex).Value), 0, DGV_INV_ITEM_LIST(10, e.RowIndex).Value)
                    CB_INV_COLOR.SelectedValue = INV_COLOR

                    INV_LENG = If(IsDBNull(DGV_INV_ITEM_LIST(18, e.RowIndex).Value), 0, DGV_INV_ITEM_LIST(18, e.RowIndex).Value)
                    CB_INV_LENGTH.SelectedValue = INV_LENG

                    INV_OTHERS = If(IsDBNull(DGV_INV_ITEM_LIST(19, e.RowIndex).Value), 0, DGV_INV_ITEM_LIST(19, e.RowIndex).Value)
                    CB_INV_OTHER_DESC.SelectedValue = INV_OTHERS


                    WTXT_INV_ALIAS_NAME.Text = If(IsDBNull(DGV_INV_ITEM_LIST(8, e.RowIndex).Value), String.Empty, DGV_INV_ITEM_LIST(8, e.RowIndex).Value)

                    _ENABLE("Edit")
                    UCPROCTim.Enabled = True
                    slideFlaG = True
                    PNL_SLIDE = APNL_ITEMINFO
                    PNL_SLIDE.BringToFront()
                    EditBool = True
                ElseIf e.ColumnIndex = 25 Then
                    _IMGPATH = If(IsDBNull(DGV_INV_ITEM_LIST(24, e.RowIndex).Value), 0, DGV_INV_ITEM_LIST(24, e.RowIndex).Value)
                    FRM_IMG.ShowDialog()
                End If
            End If
        End If
    End Sub


#End Region

#Region "Key EVENT"
    Private Sub WTXT_INVENTORY_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_ITEM_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            If WTXT_ITEM_SEARCH.Text.Length > 0 Then
                PB_INVENTORY_CLEAR_SEARCH.Visible = True
            Else
                PB_INVENTORY_CLEAR_SEARCH.Visible = False
            End If
            VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_ITEM_LIST, WTXT_ITEM_SEARCH.Text, DIVISION_NO)
            LLBL_RECORDSFOUND.Text = DGV_INV_ITEM_LIST.Rows.Count
        End If
    End Sub

    Private Sub WTXT_INVENTORY_QUANTITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_INVENTORY_QUANTITY.KeyPress, WTXT_INVENTORY_UNITCOST.KeyPress
        If TypeOf sender Is TextBox Then
            TXTGLOBAL = DirectCast(sender, TextBox)
        End If

        If TXTGLOBAL Is WTXT_INVENTORY_UNITCOST Then
            If (WTXT_INVENTORY_UNITCOST.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True
        Else
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
            If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
        End If
    End Sub






#End Region

#Region "Add Category, Sub Category, Brand, Size, Color"
    Private Sub BTN_INV_CAT_Click(sender As Object, e As EventArgs) Handles BTN_INV_CAT.Click,
                                                                            BTN_INV_SC.Click,
                                                                            BTN_INV_BR.Click,
                                                                            BTN_INV_SIZE.Click,
                                                                            BTN_INV_COLOR.Click,
                                                                            BTN_INV_LENGTH.Click,
                                                                            BTN_INV_OTHER_DESC.Click,
                                                                            BTN_INV_NAME.Click

        Dim btn As Button = CType(sender, Button)
        CODEHOLDER = 1
        If btn Is BTN_INV_CAT Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "C A T E G O R Y"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_CATEGORY.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            Me.TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, 1, DIVISION_NO)
            CB_INV_CAT.SelectedIndex = CB_INV_CAT.FindStringExact(INV_DEF_CAT)
        ElseIf btn Is BTN_INV_SC Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "S U B  C A T E G O R Y"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_SUB_CATEGORY.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            Try
                Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INV_CAT.SelectedValue), 0, CB_INV_CAT.SelectedValue)), DIVISION_NO)
                CB_INV_SC.SelectedIndex = CB_INV_SC.FindStringExact(INV_DEF_SUB_CAT)
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "CATEGORY SELECTED INDEX CHANGED")
            End Try
        ElseIf btn Is BTN_INV_BR Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "B R A N D"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_BRAND.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.FillByINVCODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND, 1)
            CB_INV_BRAND.SelectedIndex = CB_INV_BRAND.FindStringExact(INV_DEF_BRAND)
        ElseIf btn Is BTN_INV_SIZE Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "S I Z E"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_SIZE.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            Me.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_SIZE_MAIN)
            CB_INV_SIZE.SelectedIndex = CB_INV_SIZE.FindStringExact(INV_DEF_SIZE)
        ElseIf btn Is BTN_INV_COLOR Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "C O L O R"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_COLOR.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            Me.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_COLOR_MAIN)
            CB_INV_COLOR.SelectedIndex = CB_INV_COLOR.FindStringExact(INV_DEF_COLOR)
        ElseIf btn Is BTN_INV_LENGTH Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "L E N G T H"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_LENGTH.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            Me.TBLM4_INV_ITEMS_LENG_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_LENG_MAIN)
            CB_INV_LENGTH.SelectedIndex = CB_INV_LENGTH.FindStringExact(INV_DEF_LENG)
        ElseIf btn Is BTN_INV_OTHER_DESC Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "O T H E R  D E S C R I P T I O N"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_OTHER_DESC.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            Me.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_OTHERS_MAIN)
            CB_INV_OTHER_DESC.SelectedIndex = CB_INV_OTHER_DESC.FindStringExact(INV_DEF_OTHER)
        ElseIf btn Is BTN_INV_NAME Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "I T E M  N A M E"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_ITEM_NAME.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()

            Try
                Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INV_CAT.SelectedValue), 0, CB_INV_CAT.SelectedValue)), DIVISION_NO)
                Me.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_SIZE_MAIN)
                TBLM4_INV_ITEMS_NAME_MAINTableAdapter.Fill(DS_PROPERTYDB.TBLM4_INV_ITEMS_NAME_MAIN)
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "CATEGORY SELECTED INDEX CHANGED")
            End Try
            CB_INV_NAME.SelectedIndex = CB_INV_NAME.FindStringExact(INV_DEF_NAME)
        End If
    End Sub

    Private Sub PB_ITEM_IMAGE_DoubleClick(sender As Object, e As EventArgs) Handles PB_ITEM_IMAGE.DoubleClick
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PB_ITEM_IMAGE.Image = Image.FromFile(OpenFileDialog1.FileName)
            PB_ITEM_IMAGE.BackgroundImage = Nothing
        End If



    End Sub


#End Region


End Class