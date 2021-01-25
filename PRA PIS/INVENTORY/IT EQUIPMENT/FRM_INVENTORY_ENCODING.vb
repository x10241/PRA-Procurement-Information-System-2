Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_INVENTORY_ENCODING
    Public IS_ITEM_ADD As Boolean = False

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

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseDown, GRP_ITEMINFO_PER_LOT.MouseDown, PNL_LOT_PACK.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseMove, GRP_ITEMINFO_PER_LOT.MouseMove, PNL_LOT_PACK.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseUp, GRP_ITEMINFO_PER_LOT.MouseUp, PNL_LOT_PACK.MouseUp
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
                    PNL_SLIDE.Location = New Point(X_LOC, 0)
                    If PNL_SLIDE Is APNL_ITEMINFO Then
                        If X_LOC < 0 Then
                            PNL_SLIDE.Location = New Point(0, 0)
                            X_LOC = 0
                            UCPROCTim.Enabled = False
                        End If
                    End If
                Else
                    PNL_SLIDE.Location = New Point(1095, 0)
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
                    If GRP_SLIDE Is GRP_ITEMINFO_PER_ITEM Then
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
                                                                                                BTN_INVENTORY_SAVE.Click,
                                                                                                BTN_INVENTORY_CANCEL.Click,
                                                                                                BTN_INVENTORY_CANCEL_ARROW.Click,
                                                                                                BTN_INVENTORY_MINIMIZE.Click,
                                                                                                BTN_INVENTORY_CLOSE.Click,
                                                                                                PB_INVENTORY_CLEAR_SEARCH.Click,
                                                                                                PB_INVENTORY_SEARCH.Click,
                                                                                                LLBL_INVENOTYR_ASSIGN.Click,
                                                                                                LLBL_ID_SAVE_ADD_ITEM.Click,
                                                                                                PB_ID_SAVE_ADD_ITEM.Click,
                                                                                                RECT_ID_SAVE_ADD_ITEM.Click,
                                                                                                LLBL_ID_CLOSE.Click,
                                                                                                RECT_ID_CLOSE.Click,
                                                                                                PB_ID_CLOSE.Click,
                                                                                                PB_ADD_ITEM.Click,
                                                                                                LLBL_ADD_ITEM.Click,
                                                                                                RECT_ADD_ITEM.Click,
                                                                                                PB_SEARCH_DR.Click,
                                                                                                WTXT_ITM_DR_DATE_DELIVERED.Click,
                                                                                                WTXT_INVENTORY_DOA.Click,
                                                                                                WTXT_INV_DATE_DELIVERED.Click,
                                                                                                PB_INVOICE_NO.Click,
                                                                                                RECT_INV_NEW.Click,
                                                                                                RECT_INV_ASSIGN.Click,
                                                                                                PB_ADD_ITEM_LOT.Click,
                                                                                                RECT_ADD_ITEM_LOT.Click,
                                                                                                LLBL_ADD_ITEM_LOT.Click,
                                                                                                PB_CLOSE_ITEM_LOT.Click,
                                                                                                LLBL_CLOSE_ITEM_LOT.Click,
                                                                                                RECT_CLOSE_ITEM_LOT.Click,
                                                                                                WTXT_DOA_LOT.Click

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
#Region "NEW"
            If llbl Is LLBL_INVENTORY_NEW Or pb Is PB_INVENTORY_NEW Or rect Is RECT_INV_NEW Then
                If MsgBox("Encode item as LOT/PACKAGE?", vbYesNo, "Confirmation") = vbYes Then
                    ISLOT = True
                Else
                    ISLOT = False
                End If

                UCPROCTim.Enabled = True
                slideFlaG = True
                PNL_SLIDE = APNL_ITEMINFO
                PNL_SLIDE.BringToFront()
                _ENABLE("New")
                isNew = True
                'unit type
                Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
                'item brand
                TblM4_INVENTORY_ITEMBRANDTableAdapter.FillByINVCODE(DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND, 0)
                'current date time
                Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_STOREDPROC.SPM4_CURRENTDATETIME)
                'category
                TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, 0, DIVISION_NO)
                If CB_INVENTORY_CATEGORY.Items.Count > 0 Then
                    Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INVENTORY_CATEGORY.SelectedValue), 0, CB_INVENTORY_CATEGORY.SelectedValue)), DIVISION_NO)
                End If
                Me.TblM4_INVENTORY_ACQUISITION_VALUETableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ACQUISITION_VALUE)
                Me.TblV1_HRISDIVISIONTableAdapter.Fill(Me.DS_TABLES.tblV1_HRISDIVISION)
                Me.TblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ACQUISITION_ITEM_USAGE)
                'If CB_INVENTORY_UNIT_TYPE.SelectedValue = 1 Then
                '    PNL_LOT.Visible = True
                '    PNL_NOT_LOT.Visible = False
                'Else
                '    PNL_LOT.Visible = False
                '    PNL_NOT_LOT.Visible = True
                'End If

#End Region

#Region "DATE"
            ElseIf TXTGLOBAL Is WTXT_ITM_DR_DATE_DELIVERED Or TXTGLOBAL Is WTXT_INVENTORY_DOA Or TXTGLOBAL Is WTXT_INV_DATE_DELIVERED Or TXTGLOBAL Is WTXT_DOA_LOT Then
                TXTDATE = CType(sender, TextBox)
                FRM_DATAENTRY.ShowDialog()
#End Region

#Region "SAVE"
            ElseIf btn Is BTN_INVENTORY_SAVE Then


                ' If ISVALID Then
                '  _SAVE()
                '   Else
                '  NotificationManager.Show(Me, "Please provide all required fields.", Color.Red, 3000)
                '  End If

                ISVALID = True

                'If REQFIELDVALIDATION(WTXT_INVENTORY_ITEM_DESCRIPTION) Then
                '    RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = Color.OrangeRed
                '    ISVALID = False
                'Else
                '    RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = Color.DimGray
                'End If

                'If REQFIELDVALIDATION(WTXT_INVENTORY_SERIAL_NO) Then
                '    RECT_INVENTORY_SERIAL_NO.BorderColor = Color.OrangeRed
                '    ISVALID = False
                'Else
                '    RECT_INVENTORY_SERIAL_NO.BorderColor = Color.LightSeaGreen
                'End If

                'If WTXT_INVENTORY_QUANTITY.Text = 0 Then
                '    RECT_INVENTORY_QUANTITY.BorderColor = Color.OrangeRed
                '    ISVALID = False
                'Else
                '    RECT_INVENTORY_QUANTITY.BorderColor = Color.LightSeaGreen

                'End If

                'If WTXT_INVENTORY_UNITCOST.Text = 0 Then
                '    RECT_INVENTORY_UNIT_COST.BorderColor = Color.OrangeRed
                '    ISVALID = False
                'Else
                '    RECT_INVENTORY_UNIT_COST.BorderColor = Color.LightSeaGreen
                'End If

                If DR_ID = String.Empty Then
                    If WTXT_ITM_DR_NO.Text.Length = 0 Then
                        ISVALID = False
                    Else
                        ISVALID = True
                        DR_ID = WTXT_ITM_DR_NO.Text
                    End If
                Else
                    ISVALID = True
                End If

                If DGV_ITEM_DETAILS.Rows.Count = 0 Then
                    ISVALID = False
                Else
                    ISVALID = True
                End If

                If ISVALID Then
                    _SAVE()
                Else
                    NotificationManager.Show(Me, "Please provide all required fields.", Color.Red, 3000)
                End If
#End Region

#Region "CANCEL"
            ElseIf btn Is BTN_INVENTORY_CANCEL Or btn Is BTN_INVENTORY_CANCEL_ARROW Then
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

#Region "MINIMIZE"
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
                LLBL_TOT_REC.Text = DGV_ITEM_LIST.Rows.Count
#End Region

#Region "Search"
            ElseIf pb Is PB_INVENTORY_SEARCH Then
                If WTXT_INVENTORY_SEARCH.Text.Length > 0 Then
                    PB_INVENTORY_CLEAR_SEARCH.BringToFront()
                Else
                    PB_INVENTORY_SEARCH.BringToFront()
                End If
                VWM4_INV_ITEMS_LISTTableAdapter.FillBySEARCH(DS_VIEWS.VWM4_INV_ITEMS_LIST, WTXT_INV_SEARCH.Text)
                LLBL_TOT_REC.Text = DGV_ITEM_LIST.Rows.Count
#End Region

#Region "Assign"
            ElseIf llbl Is LLBL_INVENOTYR_ASSIGN Or rect Is RECT_INV_ASSIGN Or pb Is RECT_INV_ASSIGN Then
                FRM_SELECTION.ShowDialog()
#End Region

#Region "SAVE ADD ITEM"
            ElseIf llbl Is LLBL_ID_SAVE_ADD_ITEM Or pb Is PB_ID_SAVE_ADD_ITEM Or rect Is RECT_ID_SAVE_ADD_ITEM Or pb Is PB_ADD_ITEM_LOT Or rect Is RECT_ADD_ITEM_LOT Or llbl Is LLBL_ADD_ITEM_LOT Then

                If ISLOT Then
                    INV_ENC_UNIT_COST = WTXT_INVENTORY_UNITCOST.Text
                    INV_ENC_TOTAL_COST = WTXT_INVENTORY_TOTAL_COST.Text
                    DGV_ITEM_DETAILS.Rows.Add(CB_CAT_LOT.Text,
                                        CB_CAT_LOT.SelectedValue,
                                        CB_SUB_CAT_LOT.Text,
                                        CB_SUB_CAT_LOT.SelectedValue,
                                        CB_BRAND_LOT.Text,
                                        CB_BRAND_LOT.SelectedValue,
                                        "0.00",
                                        "0.00",
                                        CB_UNIT_TYPE_LOT.Text,
                                        WTXT_SERIAL_LOT.Text,
                                        WTXT_ITEM_DESC_LOT.Text,
                                        WTXT_DOA_LOT.Text)
                Else
                    DGV_ITEM_DETAILS.Rows.Add(CB_INVENTORY_CATEGORY.Text,
                                         CB_INVENTORY_CATEGORY.SelectedValue,
                                         CB_INVENTORY_SUBCATEGORY.Text,
                                         CB_INVENTORY_SUBCATEGORY.SelectedValue,
                                         CB_INVENTORY_BRAND_NAME.Text,
                                         CB_INVENTORY_BRAND_NAME.SelectedValue,
                                         WTXT_INVENTORY_UNITCOST.Text,
                                         WTXT_INVENTORY_TOTAL_COST.Text,
                                         CB_INVENTORY_UNIT_TYPE.Text,
                                         WTXT_INVENTORY_SERIAL_NO.Text,
                                         WTXT_INVENTORY_ITEM_DESCRIPTION.Text,
                                         WTXT_INVENTORY_DOA.Text)
                End If
                NotificationManager.Show(Me, "Item added!", Color.Green, 1000)

#End Region

#Region "ADD ITEM SHOW FORM"
            ElseIf pb Is PB_ADD_ITEM Or llbl Is LLBL_ADD_ITEM Or rect Is RECT_ADD_ITEM Then
                If ISLOT Then
                    GRP_ITEMINFO_PER_LOT.Visible = True
                    GRP_ITEMINFO_PER_ITEM.Visible = False
                    GRP_ITEMINFO_PER_LOT.BringToFront()
                Else
                    GRP_ITEMINFO_PER_ITEM.Visible = True
                    GRP_ITEMINFO_PER_LOT.Visible = False
                    GRP_ITEMINFO_PER_ITEM.BringToFront()
                End If

#End Region

#Region "CLOSE ITEM"
            ElseIf llbl Is LLBL_ID_CLOSE Or pb Is PB_ID_CLOSE Or rect Is RECT_ID_CLOSE Or rect Is RECT_CLOSE_ITEM_LOT Or llbl Is LLBL_CLOSE_ITEM_LOT Or pb Is PB_CLOSE_ITEM_LOT Then
                If ISLOT Then
                    GRP_ITEMINFO_PER_LOT.Visible = False
                Else
                    GRP_ITEMINFO_PER_ITEM.Visible = False
                End If
#End Region

#Region "SEARCH DR"
            ElseIf pb Is PB_SEARCH_DR Then
                _CLEAR_DR_INV()
                ENC_TYPE = "ITEM_ENC"
                DGV_INV_LIST.Rows.Clear()
                FRM_DR_LIST_DETAILS.ShowDialog()
                DGV_INV_LIST.Rows.Add(ITM_DR_DESC, ITM_DR_QTY, ITM_DR_UNIT_TYPE, ITM_DR_WARRANTY)
                WTXT_ITM_DR_NO.Text = T_INV_NO
                WTXT_INV_DT.Text = T_INV_DT
                WTXT_INV_TIN_NO.Text = T_INV_TIN_NO
                WTXT_INV_COMPANY.Text = T_INV_COMPANY
                WTXT_INV_NO.Clear()

#End Region

#Region "SEARCH INVOICE"
            ElseIf pb Is PB_INVOICE_NO Then
                _CLEAR_DR_INV()
                ENC_TYPE = "INV"
                DGV_INV_LIST.Rows.Clear()
                FRM_INV.ShowDialog()
                DGV_INV_LIST.Rows.Add(ITM_DR_DESC, ITM_DR_QTY, ITM_DR_UNIT_TYPE, ITM_DR_WARRANTY)
                WTXT_INV_NO.Text = T_INV_NO
                WTXT_INV_DT.Text = T_INV_DT
                WTXT_INV_TIN_NO.Text = T_INV_TIN_NO
                WTXT_INV_COMPANY.Text = T_INV_COMPANY
                WTXT_ITM_DR_NO.Clear()
#End Region

            End If
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub

    Private Sub PB_INV_CLEAR_Click(sender As Object, e As EventArgs) Handles PB_INV_CLEAR.Click
        WTXT_INV_SEARCH.Clear()
    End Sub
#End Region

#Region "CLEAR DR/INVOICE"
    Sub _CLEAR_DR_INV()
        WTXT_INV_NO.Clear()
        WTXT_INV_DT.Clear()
        WTXT_INV_TIN_NO.Clear()
        WTXT_INV_COMPANY.Clear()
    End Sub
#End Region

#Region "ENABLE/CLEAR"
    Sub _ENABLE(TRANSACTION As String)
        If TRANSACTION = "New" Then
            isNew = True
            WTXT_INVENTORY_QUANTITY.Text = 0
            '  WTXT_INVENTORY_UNITCOST.Text = 0
            ' WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = True
            WTXT_INVENTORY_ITEM_DESCRIPTION.Enabled = True
            WTXT_INVENTORY_QUANTITY.Enabled = True
            WTXT_INVENTORY_SERIAL_NO.Enabled = True
            WTXT_INVENTORY_UNITCOST.Enabled = True
            CB_INVENTORY_BRAND_NAME.Enabled = True
            CB_INVENTORY_CATEGORY.Enabled = True
            CB_INVENTORY_SUBCATEGORY.Enabled = True
            CB_INVENTORY_UNIT_TYPE.Enabled = True
            '  CB_ITEMS_LOCATION.Enabled = True

            PB_INVENTORY_NEW.Enabled = False
            LLBL_INVENTORY_NEW.Enabled = False
            WTXT_INVENTORY_SEARCH.Enabled = False
            DGV_INVENTORY_LIST.Enabled = False
            LLBL_INVENTORY_VIEW_REPORT.Enabled = False
            PB_INVENTORY_VIEW_REPORT.Enabled = False
            '   WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = True
            RBT_PURCHASED.Checked = True

            WTXT_INV_NO.Clear()
            WTXT_INV_DT.Clear()
            WTXT_INV_TIN_NO.Clear()
            WTXT_INV_COMPANY.Clear()
            DGV_INV_LIST.Rows.Clear()


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

            PB_INVENTORY_NEW.Enabled = False
            LLBL_INVENTORY_NEW.Enabled = False
            WTXT_INVENTORY_SEARCH.Enabled = False
            DGV_INVENTORY_LIST.Enabled = False
            LLBL_INVENTORY_VIEW_REPORT.Enabled = False
            PB_INVENTORY_VIEW_REPORT.Enabled = True
            '   WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = True
            ' DGV_ITEM_INFO.ClearSelection()
        Else
            ' WTXT_INVENTORY_DATE_OF_ACQUISITION.Enabled = False
            WTXT_INVENTORY_ITEM_DESCRIPTION.Enabled = False
            WTXT_INVENTORY_QUANTITY.Enabled = False
            WTXT_INVENTORY_SERIAL_NO.Enabled = False
            WTXT_INVENTORY_UNITCOST.Enabled = False

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


            CB_CAT_LOT.SelectedIndex = -1
            CB_SUB_CAT_LOT.SelectedIndex = -1
            CB_INVENTORY_BRAND_NAME.SelectedIndex = -1

            'CB_DIVISION_UNIT.SelectedIndex = -1
            CB_ITEM_USAGE.SelectedIndex = -1
            '  WTXT_INVENTORY_DATE_OF_ACQUISITION.Clear()
            WTXT_INVENTORY_ITEM_DESCRIPTION.Clear()
            WTXT_INVENTORY_QUANTITY.Clear()
            WTXT_INVENTORY_SERIAL_NO.Clear()
            WTXT_INVENTORY_UNITCOST.Clear()
            WTXT_INVENTORY_TOTAL_COST.Clear()
            RECT_INVENTORY_SERIAL_NO.BorderColor = Color.DimGray
            RECT_INVENTORY_ITEM_DESCRIPTION.BorderColor = Color.DimGray
            WTXT_LOT_DESCRIPTION.Clear()
            WTXT_QTY_LOT.Clear()
            WTXT_SERIAL_LOT.Clear()
            WTXT_UNIT_COST_LOT.Clear()
            WTXT_TOTAL_COST_LOT.Clear()
            WTXT_ITEM_DESCRIPTION_LOT.Clear()
            '  RECT_INVENTORY_QUANTITY.BorderColor = Color.LightSeaGreen
            RECT_INVENTORY_UNIT_COST.BorderColor = Color.DimGray
            WTXT_INVENTORY_SEARCH.Enabled = True
            DGV_INVENTORY_LIST.Enabled = True
            LLBL_INVENTORY_VIEW_REPORT.Enabled = True
            PB_INVENTORY_VIEW_REPORT.Enabled = True
            RBT_PURCHASED.Checked = False
            RBT_DONATED.Checked = False
            '  WTXT_CUSTODIAN_NAME.Clear()
            '   WTXT_PROPERTY_USER.Clear()
            '  DGV_ITEM_INFO.Rows.Clear()
            WTXT_ITM_DR_COMP_NAME.Clear()
            WTXT_ITM_DR_DATE_DELIVERED.Clear()
            WTXT_ITM_DR_NO.Clear()
            WTXT_ITM_DR_TIN_NO.Clear()
            DGV_ITM_DR_PARTICULARS.Rows.Clear()
            DGV_ITEM_DETAILS.Rows.Clear()
        End If
    End Sub
#End Region

#Region "SAVE"
    Sub _SAVE()
        Try
            If isNew Then
                Dim REF_CODE As String = SPM4_PHY_C_CODETableAdapter.SPM4_PHY_C_CODE()
                If ISLOT Then
                    TBLM4_INVENTORY_PACK_MAINTableAdapter.IQ_INV_PACK_MAIN(REF_CODE, WTXT_LOT_DESCRIPTION.Text, WTXT_QTY_LOT.Text, CDec(WTXT_UNIT_COST_LOT.Text), CDec(WTXT_TOTAL_COST_LOT.Text), EMP_NO)
                End If
                For Each row As DataGridViewRow In DGV_ITEM_DETAILS.Rows
                    ITEMCODE = SPM4_IT_ITEM_CODE_GENTableAdapter.SPM4_IT_ITEM_CODE_GEN(Trim(row.Cells(1).Value), Trim(row.Cells(3).Value), Trim(row.Cells(5).Value))
                    TblM4_INVENTORY_ITEMSTableAdapter.IQ_INVENTORY_ITEMS(ITEMCODE, Trim(row.Cells(3).Value), Trim(row.Cells(5).Value), Trim(row.Cells(9).Value), Trim(row.Cells(10).Value), Trim(row.Cells(8).Value), Trim(row.Cells(6).Value), Trim(row.Cells(7).Value), Trim(1), Trim(row.Cells(11).Value), 0)
                    'TBLM4_INVENTORY_ITEMS_DRTableAdapter.IQ_INVENTORY_ITMS_DR(ITEMCODE, DR_ID, EMP_NO, WTXT_INVOICE_NO.Text, WTXT_INV_DATE_DELIVERED.Text)
                    If ISLOT Then
                        TBLM4_INVENTORY_PACKTableAdapter.IQ_INV_PACK(REF_CODE, ITEMCODE)
                    End If
                    If WTXT_ITM_DR_NO.Text.Length > 0 Then
                        TBLM4_INVENTORY_ITEMS_DRTableAdapter.IQ_INVENTORY_ITMS_DR(ITEMCODE, DR_ID, EMP_NO)
                    ElseIf WTXT_INV_NO.Text.Length > 0 Then
                        TBLM4_INVENTORY_ITEMS_INVTableAdapter.IQ_ITEMS_INV(ITEMCODE, WTXT_INV_NO.Text, EMP_NO)
                    End If
                Next
            End If
            _ENABLE("Clear")
            UCPROCTim.Enabled = True
            slideFlaG = False
            DGV_INVENTORY_LIST.ClearSelection()
            VWM4_INV_ITEMS_LISTTableAdapter.FillBySEARCH(DS_VIEWS.VWM4_INV_ITEMS_LIST, WTXT_INV_SEARCH.Text)
            LLBL_TOT_REC.Text = DGV_ITEM_LIST.Rows.Count
            NotificationManager.Show(Me, "Successfully Saved.", Color.Green, 3000)
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "_SAVE")
        End Try
    End Sub

#End Region

#Region "Combobox Index Changed"
    Private Sub CB_INVENTORY_CATEGORY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INVENTORY_CATEGORY.SelectedIndexChanged
        If CB_INVENTORY_CATEGORY.Items.Count > 0 Then
            Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INVENTORY_CATEGORY.SelectedValue), 0, CB_INVENTORY_CATEGORY.SelectedValue)), DIVISION_NO)
        End If
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
                WTXT_INVENTORY_TOTAL_COST.Text = 1 * CDec(WTXT_INVENTORY_UNITCOST.Text)
                WTXT_INVENTORY_TOTAL_COST.Text = TXTSETTO_0(WTXT_INVENTORY_TOTAL_COST, False)
                WTXT_INVENTORY_UNITCOST.Text = TXTSETTO_0(WTXT_INVENTORY_UNITCOST, False)
            End If
        Catch ex As Exception
            NotificationManager.Show(Me, "PLEASE CHECK QUANTITY AND UNIT COST VALUE!", Color.Red, 3000)
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "WTXT_INVENTORY_QUANTITY_Leave")
        End Try
    End Sub


    Private Sub WTXT_UNIT_COST_LOT_Leave(sender As Object, e As EventArgs) Handles WTXT_UNIT_COST_LOT.Leave, WTXT_QTY_LOT.Leave
        Try
            TXTGLOBAL = Nothing
            If TypeOf sender Is TextBox Then
                TXTGLOBAL = DirectCast(sender, TextBox)
            End If
            If TXTGLOBAL Is WTXT_UNIT_COST_LOT Or TXTGLOBAL Is WTXT_QTY_LOT Then
                WTXT_TOTAL_COST_LOT.Text = CInt(WTXT_QTY_LOT.Text) * CDec(WTXT_UNIT_COST_LOT.Text)
                WTXT_TOTAL_COST_LOT.Text = TXTSETTO_0(WTXT_TOTAL_COST_LOT, False)
                WTXT_UNIT_COST_LOT.Text = TXTSETTO_0(WTXT_UNIT_COST_LOT, False)
            End If
        Catch ex As Exception
            NotificationManager.Show(Me, "PLEASE CHECK QUANTITY AND UNIT COST VALUE!", Color.Red, 3000)
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "WTXT_INVENTORY_QUANTITY_Leave")
        End Try
    End Sub

#End Region

#Region "LOAD"
    Private Sub FRM_INVENTORY_ENCODING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VWM4_INV_ITEMS_LISTTableAdapter.FillBySEARCH(DS_VIEWS.VWM4_INV_ITEMS_LIST, WTXT_INV_SEARCH.Text)
        Me.SPM4_PHY_C_CODETableAdapter.Fill(Me.DS_STOREDPROC.SPM4_PHY_C_CODE)
        Me.TBLM4_INVENTORY_PACK_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INVENTORY_PACK_MAIN)
        Me.TBLM4_INVENTORY_PACKTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INVENTORY_PACK)
        Me.VWM4_INV_ITEM_DR_LISTTableAdapter.FillBySEARCH(Me.DS_VIEWS.VWM4_INV_ITEM_DR_LIST, WTXT_INVENTORY_SEARCH.Text)
        Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_STOREDPROC.SPM4_CURRENTDATETIME)
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND)
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY)
        Me.TblM4_INVENTORY_CATEGORYTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
        LLBL_TOT_REC.Text = DGV_ITEM_LIST.Rows.Count
    End Sub

#End Region

#Region "COMBOBOX EVENT"
    Private Sub CB_ITEM_USAGE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ITEM_USAGE.SelectedIndexChanged
        If CB_ITEM_USAGE.SelectedIndex = CB_ITEM_USAGE.FindStringExact("Consumable") Then
            GRP_CONSUMABLE.Visible = True
        Else
            GRP_CONSUMABLE.Visible = False
        End If
    End Sub


    Private Sub CB_INVENTORY_UNIT_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INVENTORY_UNIT_TYPE.SelectedIndexChanged
        If CB_INVENTORY_UNIT_TYPE.SelectedValue = 1 Then
            PNL_LOT.Visible = True
            PNL_NOT_LOT.Visible = False
        Else
            PNL_LOT.Visible = False
            PNL_NOT_LOT.Visible = True
        End If
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
    Private Sub BTN_ADD_SUBCATEGORY_Click(sender As Object, e As EventArgs) Handles BTN_ADD_SUBCATEGORY.Click,
                                                                                    BTN_ADD_BRAND_PROVIDER.Click,
                                                                                    BTN_ADD_CATEGORY.Click,
                                                                                    BTN_ADD_SUBCATEGORY_LOT.Click,
                                                                                    BTN_ADD_BRAND_PROVIDER_LOT.Click,
                                                                                    BTN_ADD_CATEGORY_LOT.Click
        Dim btn As Button = Nothing

        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If
        CODEHOLDER = 0
        If btn Is BTN_ADD_SUBCATEGORY Or btn Is BTN_ADD_SUBCATEGORY_LOT Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "S U B  C A T E G O R Y"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_SUB_CATEGORY.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            If ISLOT Then
                Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(CB_CAT_LOT.SelectedValue), DIVISION_NO)
            Else
                Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(CB_INVENTORY_CATEGORY.SelectedValue), DIVISION_NO)
            End If

        ElseIf btn Is BTN_ADD_BRAND_PROVIDER Or btn Is BTN_ADD_BRAND_PROVIDER_LOT Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "B R A N D  N A M E"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_BRAND.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()

            Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.FillByINVCODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND, 0)

        ElseIf btn Is BTN_ADD_CATEGORY Or btn Is BTN_ADD_CATEGORY_LOT Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = "C A T E G O R Y"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_CATEGORY.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, 0, DIVISION_NO)
        End If
    End Sub

#End Region

#Region "CELL CLICK"
    '    Private Sub DGV_INVENTORY_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_INVENTORY_LIST.CellClick

    '        Dim dgv1 = CType(sender, DataGridView)
    '        If DGV_INVENTORY_LIST.SelectedRows.Count > 0 Then
    '            If e.RowIndex >= 0 Then
    '                EditBool = True
    '                'unit type
    '                Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
    '                'item brand
    '                TblM4_INVENTORY_ITEMBRANDTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND)
    '                'current date time
    '                Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_STOREDPROC.SPM4_CURRENTDATETIME)
    '                'category
    '                TblM4_INVENTORY_CATEGORYTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
    '                If CB_INVENTORY_CATEGORY.Items.Count > 0 Then
    '                    Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INVENTORY_CATEGORY.SelectedValue), 0, CB_INVENTORY_CATEGORY.SelectedValue)))
    '                End If

    '                Dim dt As DateTime = dgv1.Rows(e.RowIndex).Cells(12).Value.ToString()
    '                CB_INVENTORY_CATEGORY.SelectedIndex = CB_INVENTORY_CATEGORY.FindStringExact(dgv1.Rows(e.RowIndex).Cells(0).Value)
    '                ITEMCODE = dgv1.Rows(e.RowIndex).Cells(1).Value
    '                CB_INVENTORY_SUBCATEGORY.SelectedValue = dgv1.Rows(e.RowIndex).Cells(3).Value
    '                CB_INVENTORY_BRAND_NAME.SelectedValue = dgv1.Rows(e.RowIndex).Cells(5).Value
    '                WTXT_INVENTORY_SERIAL_NO.Text = dgv1.Rows(e.RowIndex).Cells(6).Value.ToString()
    '                WTXT_INVENTORY_ITEM_DESCRIPTION.Text = dgv1.Rows(e.RowIndex).Cells(7).Value
    '                CB_INVENTORY_UNIT_TYPE.SelectedIndex = CB_INVENTORY_UNIT_TYPE.FindStringExact(dgv1.Rows(e.RowIndex).Cells(8).Value.ToString())
    '                WTXT_INVENTORY_QUANTITY.Text = dgv1.Rows(e.RowIndex).Cells(9).Value.ToString()
    '                WTXT_INVENTORY_UNITCOST.Text = dgv1.Rows(e.RowIndex).Cells(10).Value.ToString()
    '                WTXT_INVENTORY_TOTAL_COST.Text = dgv1.Rows(e.RowIndex).Cells(11).Value.ToString()
    '                WTXT_INVENTORY_UNITCOST.Text = TXTSETTO_0(WTXT_INVENTORY_UNITCOST, True)
    '                WTXT_INVENTORY_TOTAL_COST.Text = TXTSETTO_0(WTXT_INVENTORY_TOTAL_COST, True)
    '                '  WTXT_INVENTORY_DATE_OF_ACQUISITION.Text = dt.ToString("MMM dd, yyyy")
    '            Else
    '                EditBool = False
    '            End If
    '        End If
    '    End Sub

    Private Sub DGV_ITEM_DETAILS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ITEM_DETAILS.CellContentClick
        If e.RowIndex >= 0 Then
            'REMOVE
            If e.ColumnIndex = 12 Then
                If MsgBox("REMOVE THIS?", vbYesNo, "CONFIRM") = vbYes Then
                    DGV_ITEM_DETAILS.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub


#End Region

#Region "KEY DOWN"
    Private Sub WTXT_INV_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_INV_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            If WTXT_INVENTORY_SEARCH.Text.Length > 0 Then
                PB_INV_CLEAR.Visible = True
            Else
                PB_INV_CLEAR.Visible = False
            End If
            VWM4_INV_ITEMS_LISTTableAdapter.FillBySEARCH(DS_VIEWS.VWM4_INV_ITEMS_LIST, WTXT_INV_SEARCH.Text)
            LLBL_TOT_REC.Text = DGV_ITEM_LIST.Rows.Count

        End If
    End Sub

    Private Sub WTXT_INVENTORY_QUANTITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_INVENTORY_QUANTITY.KeyPress, WTXT_INVENTORY_UNITCOST.KeyPress, WTXT_QTY_LOT.KeyPress
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

    Private Sub WTXT_INVENTORY_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_INVENTORY_SEARCH.TextChanged
        If WTXT_INVENTORY_SEARCH.Text.Length > 0 Then
            PB_INVENTORY_CLEAR_SEARCH.Visible = True
        Else
            PB_INVENTORY_CLEAR_SEARCH.Visible = False
        End If
    End Sub






#End Region

#Region "ROW EVENT"
    Private Sub DGV_ITEM_DETAILS_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV_ITEM_DETAILS.RowsAdded
        LLBL_ITEM_DET_COUNT.Text = DGV_ITEM_DETAILS.Rows.Count
    End Sub

    Private Sub DGV_ITEM_DETAILS_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGV_ITEM_DETAILS.RowsRemoved
        LLBL_ITEM_DET_COUNT.Text = DGV_ITEM_DETAILS.Rows.Count
    End Sub
#End Region

End Class