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
                    PNL_SLIDE.Location = New Point(X_LOC, 40)
                    If PNL_SLIDE Is APNL_ITEMINFO Then
                        If X_LOC < 514 Then
                            PNL_SLIDE.Location = New Point(514, 40)
                            X_LOC = 514
                            UCPROCTim.Enabled = False
                        End If
                    End If
                Else
                    PNL_SLIDE.Location = New Point(1095, 40)
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
                                                                                                LLBL_INVENTORY_SAVE.LinkClicked,
                                                                                                PB_INVENTORY_SAVE.Click,
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
                                                                                                LLBL_INVENOTYR_ASSIGN.Click,
                                                                                                WTXT_INVENTORY_DATE_OF_ACQUISITION.Click,
                                                                                                BTN_ADD_SUBCATEGORY.Click,
                                                                                                BTN_ADD_BRAND_PROVIDER.Click
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
                'unit type
                Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
                'item brand
                TblM4_INVENTORY_ITEMBRANDTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND)
                'current date time
                Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_CURRENTDATETIME)


                'CATEGORY
                TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, CB_SUPPLY_TYPE.SelectedValue)
                'SUB CATEGORY
                TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CB_INVENTORY_CATEGORY.SelectedValue)
                'BRAND
                TblM4_INVENTORY_ITEMBRANDTableAdapter.FillByINVCODE(DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND, CB_SUPPLY_TYPE.SelectedValue)
                CB_INVENTORY_BRAND_NAME.SelectedIndex = 0


                Me.TblM4_INVENTORY_ACQUISITION_VALUETableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ACQUISITION_VALUE)
                Me.TblV1_HRISDIVISIONTableAdapter.Fill(Me.DS_TABLES.tblV1_HRISDIVISION)
                Me.TblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ACQUISITION_ITEM_USAGE)
#End Region

            ElseIf TXTGLOBAL Is WTXT_INVENTORY_DATE_OF_ACQUISITION Then
                TXTDATE = CType(sender, TextBox)
                FRM_DATAENTRY.ShowDialog()

#Region "Edit"
            ElseIf llbl Is LLBL_INVENTORY_EDIT Or pb Is PB_INVENTORY_EDIT Then
                If DGV_INVENTORY_LIST.SelectedRows.Count > 0 Then
                    If EditBool Then
                        _ENABLE("Edit")
                        UCPROCTim.Enabled = True
                        slideFlaG = True
                        PNL_SLIDE = APNL_ITEMINFO
                        PNL_SLIDE.BringToFront()
                    End If
                End If
#End Region

#Region "Save"
            ElseIf btn Is BTN_INVENTORY_SAVE Then


                ' If ISVALID Then
                '  _SAVE()
                '   Else
                '  NotificationManager.Show(Me, "Please provide all required fields.", Color.Red, 3000)
                '  End If

                ISVALID = True
                If REQFIELDVALIDATION(WTXT_INVENTORY_ITEM_DESCRIPTION) Then
                    RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = Color.OrangeRed
                    ISVALID = False
                Else
                    RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = Color.LightSeaGreen
                End If

                'If REQFIELDVALIDATION(WTXT_INVENTORY_SERIAL_NO) Then
                '    RECT_INVENTORY_SERIAL_NO.BorderColor = Color.OrangeRed
                '    ISVALID = False
                'Else
                '    RECT_INVENTORY_SERIAL_NO.BorderColor = Color.LightSeaGreen
                'End If

                If WTXT_INVENTORY_QUANTITY.Text = 0 Then
                    RECT_INVENTORY_QUANTITY.BorderColor = Color.OrangeRed
                    ISVALID = False
                Else
                    RECT_INVENTORY_QUANTITY.BorderColor = Color.LightSeaGreen

                End If

                'If WTXT_INVENTORY_UNITCOST.Text = 0 Then
                '    RECT_INVENTORY_UNIT_COST.BorderColor = Color.OrangeRed
                '    ISVALID = False
                'Else
                '    RECT_INVENTORY_UNIT_COST.BorderColor = Color.LightSeaGreen
                'End If


                If ISVALID Then
                    _SAVE()
                Else
                    NotificationManager.Show(Me, "Please provide all required fields.", Color.Red, 3000)
                End If
#End Region

#Region "Cancel"
            ElseIf btn Is BTN_INVENTORY_CANCEL Or btn Is BTN_CLOSE_INVENTORY_MINI_CLOSE Then
                If MsgBox("Do you want to cancel this?", vbYesNo, "Confirm") = vbYes Then
                    _ENABLE("Clear")
                    UCPROCTim.Enabled = True
                    slideFlaG = False
                    DGV_INVENTORY_LIST.ClearSelection()
                End If
#End Region

#Region "REPORT"
            ElseIf pb Is PB_INVENTORY_VIEW_REPORT Or llbl Is LLBL_INVENTORY_VIEW_REPORT Then
                FRM_INVENTORY_REPORT.ShowDialog()
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
                WTXT_INVENTORY_SEARCH.Clear()
#End Region

#Region "Search"
            ElseIf pb Is PB_INVENTORY_SEARCH Then
                If WTXT_INVENTORY_SEARCH.Text.Length > 0 Then
                    PB_INVENTORY_CLEAR_SEARCH.BringToFront()
                Else
                    PB_INVENTORY_SEARCH.BringToFront()
                End If
                SPM4_INVENTORYDGVLISTTableAdapter.Fill(DS_PROPERTYDB.SPM4_INVENTORYDGVLIST, WTXT_INVENTORY_SEARCH.Text, "IT-ADMIN")
                LLBL_RECORDSFOUND.Text = DGV_INVENTORY_LIST.Rows.Count
#End Region

#Region "Assign"
            ElseIf llbl Is LLBL_INVENOTYR_ASSIGN Then
                FRM_SELECTION.ShowDialog()
#End Region

#Region "Add Category"
            ElseIf btn Is BTN_ADD_CATEGORY Then
                ITEQUIPMENTBOOL = False
                FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "C A T E G O R Y  N A M E"
                FRM_ADDITIONAL_CATEGORIZATION.GRP_CATEGORY_ADMIN.Visible = True
                FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
                'CATEGORY
                TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, CB_SUPPLY_TYPE.SelectedValue)
#End Region

#Region "Add Sub Category"
            ElseIf btn Is BTN_ADD_SUBCATEGORY Then
                ITEQUIPMENTBOOL = False
                FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "S U B  C A T E G O R Y"
                FRM_ADDITIONAL_CATEGORIZATION.GRP_SUB_CATEGORY_ADMIN.Visible = True
                FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
                'SUB CATEGORY
                TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CB_INVENTORY_CATEGORY.SelectedValue)
#End Region

#Region "Add Provider/Brand"
            ElseIf btn Is BTN_ADD_BRAND_PROVIDER Then
                ITEQUIPMENTBOOL = False
                FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "B R A N D  N A M E"
                FRM_ADDITIONAL_CATEGORIZATION.GRP_BRAND_ADMIN.Visible = True
                FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
                'BRAND
                TblM4_INVENTORY_ITEMBRANDTableAdapter.FillByINVCODE(DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND, CB_SUPPLY_TYPE.SelectedValue)
#End Region

            End If
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub

#End Region

#Region "ENABLE/CLEAR"
    Sub _ENABLE(TRANSACTION As String)
        If TRANSACTION = "New" Then
            isNew = True
            WTXT_INVENTORY_QUANTITY.Text = 0
            WTXT_INVENTORY_UNITCOST.Text = 0
            WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = True
            WTXT_INVENTORY_ITEM_DESCRIPTION.Enabled = True
            WTXT_INVENTORY_QUANTITY.Enabled = True
            WTXT_INVENTORY_SERIAL_NO.Enabled = True
            WTXT_INVENTORY_UNITCOST.Enabled = True
            CB_INVENTORY_BRAND_NAME.Enabled = True
            CB_INVENTORY_CATEGORY.Enabled = True
            CB_INVENTORY_SUBCATEGORY.Enabled = True
            CB_INVENTORY_UNIT_TYPE.Enabled = True
            '  CB_ITEMS_LOCATION.Enabled = True
            LLBL_INVENTORY_EDIT.Enabled = False
            PB_INVENTORY_EDIT.Enabled = False
            PB_INVENTORY_NEW.Enabled = False
            LLBL_INVENTORY_NEW.Enabled = False
            WTXT_INVENTORY_SEARCH.Enabled = False
            DGV_INVENTORY_LIST.Enabled = False
            LLBL_INVENTORY_VIEW_REPORT.Enabled = False
            PB_INVENTORY_VIEW_REPORT.Enabled = False
            WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = True
            RBT_PURCHASED.Checked = True
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
            WTXT_INVENTORY_SEARCH.Enabled = False
            DGV_INVENTORY_LIST.Enabled = False
            LLBL_INVENTORY_VIEW_REPORT.Enabled = False
            PB_INVENTORY_VIEW_REPORT.Enabled = True
            WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = True
            DGV_ITEM_INFO.ClearSelection()
        Else
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
            WTXT_INVENTORY_SEARCH.Enabled = True
            DGV_INVENTORY_LIST.Enabled = True
            LLBL_INVENTORY_VIEW_REPORT.Enabled = True
            PB_INVENTORY_VIEW_REPORT.Enabled = True
            RBT_PURCHASED.Checked = False
            RBT_DONATED.Checked = False
            '  WTXT_CUSTODIAN_NAME.Clear()
            '   WTXT_PROPERTY_USER.Clear()
            DGV_ITEM_INFO.Rows.Clear()
        End If
    End Sub
#End Region

#Region "SAVE function"
    Sub _SAVE()
        Try
            'If isNew Then
            '    For Each row As DataGridViewRow In DGV_ITEM_INFO.Rows
            '        If Not row.IsNewRow Then
            '            ITEMCODE = SpM4_ITEM_CODE_GENERATORTableAdapter.SPM4_ITEM_CODE_GEN(row.Cells(10).Value, row.Cells(11).Value, row.Cells(12).Value)
            '            TblM4_INVENTORY_ITEMSTableAdapter.IQ_INVENTORY_ITEMS(ITEMCODE, row.Cells(11).Value, row.Cells(12).Value, row.Cells(4).Value, row.Cells(9).Value, row.Cells(5).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(6).Value, row.Cells(0).Value)
            '            TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter.IQ_PROPERTY_ITEMS(ITEMCODE, CB_DIVISION_UNIT.SelectedValue, ACCOUNTABLE_OFFICER, PROPERTY_USER, EMP_NO)
            '        End If
            '    Next
            '    DGV_ITEM_INFO.Rows.Clear()
            '    SPM4_INVENTORYDGVLISTTableAdapter.Fill(DS_PROPERTYDB.SPM4_INVENTORYDGVLIST, "")
            'Else
            '    For Each row As DataGridViewRow In DGV_ITEM_INFO.Rows
            '        If TblM4_INVENTORY_ITEMSTableAdapter.CHECKIFEXIST(row.Cells(12).Value) = 1 Then
            '            TblM4_INVENTORY_ITEMSTableAdapter.UQ_INVENTORY_ITEMS(row.Cells(10).Value, row.Cells(11).Value, row.Cells(4).Value, row.Cells(9).Value, row.Cells(5).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(6).Value, row.Cells(0).Value, row.Cells(12).Value)
            '            If TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter.CHECKIFEXIST(row.Cells(12).Value) = 1 Then
            '                TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter.UQ_ITEMS_PROPERTY(CB_DIVISION_UNIT.SelectedValue, ACCOUNTABLE_OFFICER, PROPERTY_USER, EMP_NO, row.Cells(12).Value)
            '            Else
            '                TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter.IQ_PROPERTY_ITEMS(ITEMCODE, CB_DIVISION_UNIT.SelectedValue, ACCOUNTABLE_OFFICER, PROPERTY_USER, EMP_NO)
            '            End If
            '        Else
            '            ITEMCODE = SpM4_ITEM_CODE_GENERATORTableAdapter.SPM4_ITEM_CODE_GEN(row.Cells(10).Value, row.Cells(11).Value, row.Cells(12).Value)
            '            TblM4_INVENTORY_ITEMSTableAdapter.IQ_INVENTORY_ITEMS(ITEMCODE, row.Cells(11).Value, row.Cells(12).Value, row.Cells(4).Value, row.Cells(9).Value, row.Cells(5).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(6).Value, row.Cells(0).Value)
            '            TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter.IQ_PROPERTY_ITEMS(ITEMCODE, CB_DIVISION_UNIT.SelectedValue, ACCOUNTABLE_OFFICER, PROPERTY_USER, EMP_NO)
            '        End If
            '    Next
            '    DGV_ITEM_INFO.Rows.Clear()
            '    SPM4_INVENTORYDGVLISTTableAdapter.Fill(DS_PROPERTYDB.SPM4_INVENTORYDGVLIST, "")
            'End If

            If isNew Then

                ITEMCODE = SpM4_ITEM_CODE_GENERATORTableAdapter.SPM4_ITEM_CODE_GEN(CB_INVENTORY_CATEGORY.SelectedValue, CB_INVENTORY_SUBCATEGORY.SelectedValue, CB_INVENTORY_BRAND_NAME.SelectedValue)

                Dim dt As DateTime = WTXT_INVENTORY_DATE_OF_ACQUISITION.Text
                WTXT_INVENTORY_DATE_OF_ACQUISITION.Text = dt.ToString("MMM dd, yyyy")
                TblM4_INVENTORY_ITEMSTableAdapter.IQ_INVENTORY_ITEMS(ITEMCODE, CB_INVENTORY_SUBCATEGORY.SelectedValue, CB_INVENTORY_BRAND_NAME.SelectedValue, WTXT_INVENTORY_SERIAL_NO.Text, WTXT_INVENTORY_ITEM_DESCRIPTION.Text, CB_INVENTORY_UNIT_TYPE.Text, WTXT_INVENTORY_UNITCOST.Text, WTXT_INVENTORY_TOTAL_COST.Text, WTXT_INVENTORY_QUANTITY.Text, WTXT_INVENTORY_DATE_OF_ACQUISITION.Text, CB_SUPPLY_TYPE.SelectedValue)
                SPM4_INVENTORYDGVLISTTableAdapter.Fill(DS_PROPERTYDB.SPM4_INVENTORYDGVLIST, "", "IT-ADMIN")
            Else

                Dim dt As DateTime = WTXT_INVENTORY_DATE_OF_ACQUISITION.Text
                WTXT_INVENTORY_DATE_OF_ACQUISITION.Text = dt.ToString("yyyy/MM/dd")
                TblM4_INVENTORY_ITEMSTableAdapter.UQ_INVENTORY_ITEMS(CB_INVENTORY_SUBCATEGORY.SelectedValue, CB_INVENTORY_BRAND_NAME.SelectedValue, WTXT_INVENTORY_SERIAL_NO.Text, WTXT_INVENTORY_ITEM_DESCRIPTION.Text, CB_INVENTORY_UNIT_TYPE.Text, WTXT_INVENTORY_UNITCOST.Text, WTXT_INVENTORY_TOTAL_COST.Text, WTXT_INVENTORY_QUANTITY.Text, WTXT_INVENTORY_DATE_OF_ACQUISITION.Text, CB_SUPPLY_TYPE.SelectedValue, ITEMCODE)

                ' TblM4_INVENTORY_ITEMSTableAdapter.UQ_INVENTORY_ITEMS()
                ' TblM4_INVENTORY_ITEMSTableAdapter.UQ_INVENTORY_ITEMS(CB_INVENTORY_SUBCATEGORY.SelectedValue, CB_INVENTORY_BRAND_NAME.SelectedValue, WTXT_INVENTORY_SERIAL_NO.Text, WTXT_INVENTORY_ITEM_DESCRIPTION.Text, CB_INVENTORY_UNIT_TYPE.Text, WTXT_INVENTORY_UNITCOST.Text, WTXT_INVENTORY_TOTAL_COST.Text, WTXT_INVENTORY_QUANTITY.Text, WTXT_INVENTORY_DATE_OF_ACQUISITION.Text, ITEMCODE, CB_SUPPLY_TYPE.SelectedValue)
                SPM4_INVENTORYDGVLISTTableAdapter.Fill(DS_PROPERTYDB.SPM4_INVENTORYDGVLIST, "", "IT-ADMIN")

            End If
            _ENABLE("Clear")
            UCPROCTim.Enabled = True
            slideFlaG = False
            LLBL_RECORDSFOUND.Text = DGV_INVENTORY_LIST.Rows.Count
            DGV_INVENTORY_LIST.ClearSelection()
            NotificationManager.Show(Me, "Successfully Saved.", Color.Green, 3000)
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub

#End Region

#Region "Combobox Index Changed"
    Private Sub CB_INVENTORY_CATEGORY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INVENTORY_CATEGORY.SelectedIndexChanged
        'SUB CATEGORY
        TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CB_INVENTORY_CATEGORY.SelectedValue)


        'If CB_INVENTORY_CATEGORY.Text <> "Software" Then

        'Else

        'End If
    End Sub
#End Region

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

#Region "LOAD"
    Private Sub FRM_INVENTORY_ENCODING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblM4_INVENTORY_TYPETableAdapter.FillBY_NOT_ITQUIPMENT(Me.DS_PROPERTYDB.tblM4_INVENTORY_TYPE)
        'Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND)
        'Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY)
        'Me.TblM4_INVENTORY_CATEGORYTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)

        SPM4_INVENTORYDGVLISTTableAdapter.Fill(DS_PROPERTYDB.SPM4_INVENTORYDGVLIST, WTXT_INVENTORY_SEARCH.Text, "")
        LLBL_RECORDSFOUND.Text = DGV_INVENTORY_LIST.Rows.Count
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

    Private Sub CB_SUPPLY_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_SUPPLY_TYPE.SelectedIndexChanged
        'CATEGORY
        TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, CB_SUPPLY_TYPE.SelectedValue)
        'SUB CATEGORY
        TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CB_INVENTORY_CATEGORY.SelectedValue)
        'BRAND
        TblM4_INVENTORY_ITEMBRANDTableAdapter.FillByINVCODE(DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND, CB_SUPPLY_TYPE.SelectedValue)
        CB_INVENTORY_BRAND_NAME.SelectedIndex = 0
    End Sub
#End Region

#Region "TEXTBOX CLICK"
    Private Sub WTXT_CUSTODIAN_NAME_Click(sender As Object, e As EventArgs)

        'TXTGLOBAL = Nothing
        'If TypeOf sender Is TextBox Then
        '    TXTGLOBAL = CType(sender, TextBox)
        'End If

        'If TXTGLOBAL Is WTXT_CUSTODIAN_NAME Then
        '    empfullname = CType(WTXT_CUSTODIAN_NAME, TextBox)
        '    ACCOUNTABLE_CTR = True
        'ElseIf TXTGLOBAL Is WTXT_PROPERTY_USER Then
        '    empfullname = CType(WTXT_PROPERTY_USER, TextBox)
        '    ACCOUNTABLE_CTR = False
        'End If
        'FRM_EMPLOYEE_LIST.ShowDialog()
    End Sub
#End Region

#Region "BUTTON"
    Private Sub BTN_ADD_SUBCATEGORY_Click(sender As Object, e As EventArgs) Handles BTN_ADD_SUBCATEGORY.Click, BTN_ADD_BRAND_PROVIDER.Click
        Dim btn As Button = Nothing

        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
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
            Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_CURRENTDATETIME)
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
                Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND)
                Me.TblM4_INVENTORY_CATEGORYTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
                TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CB_INVENTORY_CATEGORY.SelectedValue)
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

    Private Sub DGV_INVENTORY_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_INVENTORY_LIST.CellClick
        _ENABLE("Clear")
        Dim dgv1 = CType(sender, DataGridView)
        If DGV_INVENTORY_LIST.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                EditBool = True
                'unit type
                Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
                'item brand
                TblM4_INVENTORY_ITEMBRANDTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND)
                'current date time
                Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_CURRENTDATETIME)
                'category
                TblM4_INVENTORY_CATEGORYTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
                TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CB_INVENTORY_CATEGORY.SelectedValue)

                '  TblM4_INVENTORY_ITEMSTableAdapter.FillByItemCode(DS_PROPERTYDB.tblM4_INVENTORY_ITEMS, dgv1.Rows(e.RowIndex).Cells(1).Value)
                Dim dt As DateTime = dgv1.Rows(e.RowIndex).Cells(12).Value.ToString()
                'DGV_ITEM_INFO.Rows.Add(dt.ToString("MMM dd, yyyy"), 'date acquisition
                '                       dgv1.Rows(e.RowIndex).Cells(0).Value, 'category
                '                       dgv1.Rows(e.RowIndex).Cells(2).Value, 'sub category
                '                        dgv1.Rows(e.RowIndex).Cells(4).Value, 'brand
                '                        dgv1.Rows(e.RowIndex).Cells(6).Value.ToString(), ' serial
                '                        dgv1.Rows(e.RowIndex).Cells(8).Value.ToString(), ' unit type
                '                        dgv1.Rows(e.RowIndex).Cells(9).Value.ToString(), ' quantity
                '                        dgv1.Rows(e.RowIndex).Cells(10).Value.ToString(), 'unit cost
                '                        dgv1.Rows(e.RowIndex).Cells(11).Value.ToString(), 'total cost
                '                        dgv1.Rows(e.RowIndex).Cells(7).Value.ToString(), ' item description
                '                        dgv1.Rows(e.RowIndex).Cells(3).Value.ToString(), ' sc_no
                '                        dgv1.Rows(e.RowIndex).Cells(5).Value.ToString(),
                '                        dgv1.Rows(e.RowIndex).Cells(1).Value) ' brand
                ITEMCODE = dgv1.Rows(e.RowIndex).Cells(1).Value
                CB_INVENTORY_CATEGORY.SelectedIndex = CB_INVENTORY_CATEGORY.FindStringExact(dgv1.Rows(e.RowIndex).Cells(0).Value)
                ITEMCODE = dgv1.Rows(e.RowIndex).Cells(1).Value
                CB_INVENTORY_SUBCATEGORY.SelectedValue = dgv1.Rows(e.RowIndex).Cells(3).Value
                CB_INVENTORY_BRAND_NAME.SelectedValue = dgv1.Rows(e.RowIndex).Cells(5).Value
                WTXT_INVENTORY_SERIAL_NO.Text = dgv1.Rows(e.RowIndex).Cells(6).Value.ToString()
                WTXT_INVENTORY_ITEM_DESCRIPTION.Text = dgv1.Rows(e.RowIndex).Cells(7).Value
                CB_INVENTORY_UNIT_TYPE.SelectedIndex = CB_INVENTORY_UNIT_TYPE.FindStringExact(dgv1.Rows(e.RowIndex).Cells(8).Value.ToString())
                WTXT_INVENTORY_QUANTITY.Text = dgv1.Rows(e.RowIndex).Cells(9).Value.ToString()
                WTXT_INVENTORY_UNITCOST.Text = dgv1.Rows(e.RowIndex).Cells(10).Value.ToString()
                WTXT_INVENTORY_TOTAL_COST.Text = dgv1.Rows(e.RowIndex).Cells(11).Value.ToString()
                WTXT_INVENTORY_UNITCOST.Text = TXTSETTO_0(WTXT_INVENTORY_UNITCOST, True)
                WTXT_INVENTORY_TOTAL_COST.Text = TXTSETTO_0(WTXT_INVENTORY_TOTAL_COST, True)
                WTXT_INVENTORY_DATE_OF_ACQUISITION.Text = dt.ToString("MMM dd, yyyy")
                'TblM4_INVENTORY_ITEMS_PROPERTYTableAdapter.FillByItemCode(DS_PROPERTYDB.tblM4_INVENTORY_ITEMS_PROPERTY, ITEMCODE)
                'Me.TblV1_HRISDIVISIONTableAdapter.Fill(Me.DS_TABLES.tblV1_HRISDIVISION)
                'If TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows.Count > 1 Then
                '    Me.TblM4_INVENTORY_ACQUISITION_VALUETableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ACQUISITION_VALUE)


                '    Me.TblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ACQUISITION_ITEM_USAGE)
                '    ' CB_ACQUISITION_VALUE
                '    CB_DIVISION_UNIT.SelectedValue = TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(2).Value.ToString
                '    WTXT_CUSTODIAN_NAME.Text = TblV1_HRISEMPLOYEEDATATableAdapter.SQ_GETFULLNAME(TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(3).Value.ToString)
                '    WTXT_PROPERTY_USER.Text = TblV1_HRISEMPLOYEEDATATableAdapter.SQ_GETFULLNAME(TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(4).Value.ToString)
                '    ACCOUNTABLE_OFFICER = TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(3).Value.ToString
                '    PROPERTY_USER = TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(4).Value.ToString
                '    'CB_ACQUISITION_VALUE.SelectedValue = TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(5).Value.ToString
                '    'CB_ITEM_USAGE.SelectedValue = TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(6).Value.ToString
                '    'If CB_ITEM_USAGE.Text = "Consumables" Then
                '    '    If TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(7).Value.ToString = 0 Then
                '    '        RBT_DEPLETED.Checked = True
                '    '    ElseIf TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(7).Value.ToString = 1 Then
                '    '        RBT_PERPARTS.Checked = True
                '    '    Else
                '    '        RBT_PERPARTS.Checked = False
                '    '        RBT_DEPLETED.Checked = False
                '    '    End If
                '    'End If
                '    'If TblM4_INVENTORY_ITEMS_PROPERTYDataGridView.Rows(0).Cells(8).Value = 0 Then
                '    '    RBT_PURCHASED.Checked = True
                '    'Else
                '    '    RBT_DONATED.Checked = True
                '    'End If
                'End If
            Else
                EditBool = False
            End If
        End If
    End Sub

#End Region

#Region "Key EVENT"
    Private Sub WTXT_INVENTORY_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_INVENTORY_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            If WTXT_INVENTORY_SEARCH.Text.Length > 0 Then
                PB_INVENTORY_CLEAR_SEARCH.BringToFront()
            Else
                PB_INVENTORY_SEARCH.BringToFront()
            End If
            SPM4_INVENTORYDGVLISTTableAdapter.Fill(DS_PROPERTYDB.SPM4_INVENTORYDGVLIST, WTXT_INVENTORY_SEARCH.Text, "IT-ADMIN")
            LLBL_RECORDSFOUND.Text = DGV_INVENTORY_LIST.Rows.Count
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


End Class