Public Class FRM_INVENTORY_REPORT

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
    Dim CHKTEXT As String = "Select all items in "

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

#Region "CLICK"
    Private Sub BTN_INVENTORY_GENERATE_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_GENERATE_REPORT.Click,
                                                                                                WTXT_INVENTORY_REPORT_FROM.Click,
                                                                                                WTXT_INVENTORY_REPORT_TO.Click,
                                                                                                BTN_INVENTORY_REPORT_CLOSE.Click

        Try
            TXTDATE = Nothing
            Dim btn As Button = Nothing

            If TypeOf sender Is Button Then
                btn = CType(sender, Button)
            ElseIf TypeOf sender Is TextBox Then
                TXTDATE = CType(sender, TextBox)
            End If
#Region "GENERATE REPORT"
            If btn Is BTN_INVENTORY_GENERATE_REPORT Then
                _CLEAR()
                'items only
                If CB_REPORT_TYPE.SelectedIndex = 0 Then
                    If CB_FILTERBY.SelectedIndex = 0 Then
                        IR_CBFILTERBY = "Category"
                    ElseIf CB_FILTERBY.SelectedIndex = 1 Then
                        IR_CBFILTERBY = "SubCategory"
                    ElseIf CB_FILTERBY.SelectedIndex = 2 Then
                        IR_CBFILTERBY = "Brand"
                    ElseIf CB_FILTERBY.SelectedIndex = 3 Then
                        IR_CBFILTERBY = "Description"
                    End If

                    If CB_DATE_FILTER.SelectedIndex = 0 Then
                        IR_CBDATEBY = "Pastweek"
                        IR_REPORTHEADER = "Weekly"
                    ElseIf CB_DATE_FILTER.SelectedIndex = 1 Then
                        IR_CBDATEBY = "Pastmonth"
                        IR_REPORTHEADER = "Monthly"
                    ElseIf CB_DATE_FILTER.SelectedIndex = 2 Then
                        IR_CBDATEBY = "Pastyear"
                        IR_REPORTHEADER = "Annual"
                    ElseIf CB_DATE_FILTER.SelectedIndex = 3 Then
                        IR_CBDATEBY = "Custom"
                        IR_REPORTHEADER = ""
                    End If

                    If CHK_SEL_ALL_ITEMS.CheckState = CheckState.Checked Then
                        IR_ALLITEMS = True
                        IR_KEYWORD = ""
                    Else
                        IR_ALLITEMS = False
                        IR_KEYWORD = CB_SEARCH_BY.Text
                    End If

                    If CB_DATE_FILTER.SelectedIndex = 3 Then
                        IR_DATEFROM = WTXT_INVENTORY_REPORT_FROM.Text
                        IR_DATETO = WTXT_INVENTORY_REPORT_TO.Text
                    Else
                        IR_DATEFROM = Today
                        IR_DATETO = Today
                        IR_ASOFDATE = Today
                    End If

                    If CHK_ALL_YR.CheckState = CheckState.Checked Then
                        IR_ISALLYR = True
                    Else
                        IR_ISALLYR = False
                    End If

                    IR_ORDERBY = CB_ORDER_BY.Text
                    IR_ORDERTYPE = CB_ORDER1.Text

                    If CHK_ALL_YR.Checked = True Then
                        IR_YR = Nothing
                    Else
                        IR_YR = CB_YEAR.Text
                    End If

                    Dim ctr As Integer = 0
                    Try
B:
                        ctr = ctr + 1
                        SpM4_INVENTORY_REPORTTableAdapter.Fill(DS_STOREDPROC.SPM4_INVENTORY_REPORT, Trim(IR_CBFILTERBY), Trim(IR_CBDATEBY), Trim(IR_KEYWORD), Trim(IR_DATEFROM), Trim(IR_DATETO), IR_ISALLYR, IR_YR, IR_ORDERBY, IR_ORDERTYPE)
                        IR_CHKBY = WTXT_CHK_BY.Text
                        IR_CRTBY = WTXT_CRT_BY.Text


                        If DS_STOREDPROC.SPM4_INVENTORY_REPORT.Count = 0 Then
                            NotificationManager.Show(Me, "No data Found!", Color.Red, 3000)
                        Else
                            FRM_INVENTORY_REPORT_PRINT_PREVIEW.ShowDialog()
                        End If

                    Catch ex As Exception
                        If ctr = 5 Then
                            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
                        Else
                            GoTo B
                        End If

                    End Try

                    'items in location
                ElseIf CB_REPORT_TYPE.SelectedIndex = 1 Then

                    'assign items to accountable person 
                ElseIf CB_REPORT_TYPE.SelectedIndex = 2 Then

                    If DS_STOREDPROC.SPM4_INVENTORY_REPORT.Count = 0 Then
                        NotificationManager.Show(Me, "No data Found!", Color.Red, 3000)
                    Else
                        FRM_INVENTORY_REPORT_PRINT_PREVIEW.ShowDialog()
                    End If
                End If

#End Region

#Region "Date POP UP"
            ElseIf TXTDATE Is WTXT_INVENTORY_REPORT_FROM Or TXTDATE Is WTXT_INVENTORY_REPORT_TO Then
                FRM_DATAENTRY.ShowDialog()
#End Region

#Region "Close"
            ElseIf btn Is BTN_INVENTORY_REPORT_CLOSE Then
                Me.Close()
#End Region

            End If
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)

        End Try


    End Sub
#End Region

#Region "LOAD"
    Private Sub FRM_INVENTORY_PRINT_PREVIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_CUSTOM.DT_INVENTORY_ITM_YR' table. You can move, or remove it, as needed.
        Me.DT_INVENTORY_ITM_YRTableAdapter.Fill(Me.DS_CUSTOM.DT_INVENTORY_ITM_YR)
        CB_REPORT_TYPE.SelectedIndex = 0
        CB_FILTERBY.SelectedIndex = 0
        CB_DATE_FILTER.SelectedIndex = 0
        CB_ASSIGN_BY.SelectedIndex = 0
        CB_YEAR.SelectedIndex = 0
        CB_ORDER1.SelectedIndex = 0
        CB_ORDER_BY.SelectedIndex = 0

A:
        Try
            Me.SPM4_PDS_LISTTableAdapter.FillBySEARCH(Me.DS_PRAJO_DATABASE.SPM4_PDS_LIST, "")
#Region "APPROVED BY"
            Dim USERsuggestions As New AutoCompleteStringCollection()
            If SPM4_PDS_LISTBindingSource.Count > 0 Then
                For x = 0 To SPM4_PDS_LISTBindingSource.Count - 1
                    USERsuggestions.Add(CStr(If(IsDBNull(CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0)), "", CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0))))
                Next
                WTXT_CHK_BY.AutoCompleteCustomSource = USERsuggestions
                WTXT_CRT_BY.AutoCompleteCustomSource = USERsuggestions
            End If
#End Region
        Catch ex As Exception
            GoTo A
        End Try
    End Sub
#End Region

#Region "SELECTED INDEX CHANGED"

    Private Sub CB_DATE_FILTER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_DATE_FILTER.SelectedIndexChanged
        If CB_DATE_FILTER.SelectedIndex = 3 Then
            PNL_CUSTOM_RANGE.Visible = True
            PNL_YEAR.Visible = False
        ElseIf CB_DATE_FILTER.SelectedIndex = 2 Then
            PNL_CUSTOM_RANGE.Visible = False
            PNL_YEAR.Visible = True
        Else
            PNL_YEAR.Visible = False
            PNL_CUSTOM_RANGE.Visible = False
        End If
    End Sub

    Private Sub CB_FILTERBY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FILTERBY.SelectedIndexChanged
        'category
        If CB_FILTERBY.SelectedIndex = 0 Then
            TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, "0", DIVISION_NO)
            With CB_SEARCH_BY
                .DataSource = TblM4INVENTORYCATEGORYBindingSource
                .ValueMember = "CAT_CODE"
                .DisplayMember = "CAT_NAME"
            End With
            CHK_SEL_ALL_ITEMS.Text = CHKTEXT & "Category"
            'sub category
        ElseIf CB_FILTERBY.SelectedIndex = 1 Then
            TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByDIV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, DIVISION_NO)
            With CB_SEARCH_BY
                .DataSource = TblM4INVENTORYSUBCATEGORYBindingSource
                .ValueMember = "SC_NO"
                .DisplayMember = "SC_SUBCATEGORY_NAME"
            End With
            CHK_SEL_ALL_ITEMS.Text = CHKTEXT & "Sub Category/Type"
            'brand
        ElseIf CB_FILTERBY.SelectedIndex = 2 Then
            TblM4_INVENTORY_ITEMBRANDTableAdapter.FillByINVCODE(DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND, "0")
            With CB_SEARCH_BY
                .DataSource = TblM4INVENTORYITEMBRANDBindingSource
                .ValueMember = "ITBR_NO"
                .DisplayMember = "ITBR_NAME"
            End With
            CHK_SEL_ALL_ITEMS.Text = CHKTEXT & "Brand/Provider Name"
            'item description
        ElseIf CB_FILTERBY.SelectedIndex = 3 Then
            TblM4_INVENTORY_ITEMS2TableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_ITEMS2)
            With CB_SEARCH_BY
                .DataSource = TblM4_INVENTORY_ITEMS2BindingSource
                .DisplayMember = "ITEM_DESCRIPTION"
            End With
            CHK_SEL_ALL_ITEMS.Text = CHKTEXT & "Item Description"
        End If
    End Sub

    Private Sub CB_ASSIGN_BY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ASSIGN_BY.SelectedIndexChanged
        'employee name
        If CB_ASSIGN_BY.SelectedIndex = 0 Then
            EmployeeInfoTableAdapter.Fill(DS_TABLES.EmployeeInfo)
            With CB_ASSIGN_SEARCH_BY
                .DataSource = EmployeeInfoBindingSource
                .DisplayMember = "FULLNAME"
            End With
            CHK_ASSIGN_ITEMS_BY.Text = CHKTEXT & "assign to employee"
            'division/unit
        ElseIf CB_ASSIGN_BY.SelectedIndex = 1 Then
            TblV1_HRISDIVISIONTableAdapter.Fill(DS_TABLES.tblV1_HRISDIVISION)
            With CB_ASSIGN_SEARCH_BY
                .DataSource = TblV1_HRISDIVISIONBindingSource
                .DisplayMember = "HDIV_DIVISION"
            End With
            CHK_ASSIGN_ITEMS_BY.Text = CHKTEXT & "assign to division/unit"
        End If
    End Sub

    Private Sub CB_REPORT_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_REPORT_TYPE.SelectedIndexChanged
        'ITEM ONLY
        If CB_REPORT_TYPE.SelectedIndex = 0 Then
            PNL_ITEM_ONLY.BringToFront()
            'accountable person
        ElseIf CB_REPORT_TYPE.SelectedIndex = 2 Then
            PNL_ACCOUNTABLE_PERSON.BringToFront()
        End If
    End Sub
#End Region

#Region "CLEAR"
    Sub _CLEAR()
        IR_CBFILTERBY = Nothing
        IR_CBDATEBY = Nothing
        IR_REPORTHEADER = Nothing
        IR_ALLITEMS = Nothing
        IR_KEYWORD = Nothing
        IR_DATEFROM = Nothing
        IR_DATETO = Nothing
        IR_ASOFDATE = Nothing
        IR_CHKBY = Nothing
        IR_CRTBY = Nothing
        'IR_CRT_POS = Nothing
        'IR_CHK_POS = Nothing
    End Sub
#End Region

#Region "TEXT CHANGED"
    Private Sub WTXT_CHK_BY_TextChanged(sender As Object, e As EventArgs) Handles WTXT_CHK_BY.TextChanged
        SPM4_PDS_LISTBindingSource.Filter = "FULLNAME = '" & WTXT_CHK_BY.Text & "'"
        IR_CHK_POS = BS_SINGLEROW(SPM4_PDS_LISTBindingSource, 47)
    End Sub

    Private Sub WTXT_CRT_BY_TextChanged(sender As Object, e As EventArgs) Handles WTXT_CRT_BY.TextChanged
        SPM4_PDS_LISTBindingSource.Filter = "FULLNAME = '" & WTXT_CRT_BY.Text & "'"
        IR_CRT_POS = BS_SINGLEROW(SPM4_PDS_LISTBindingSource, 47)
    End Sub

#End Region

    Private Sub CHK_ALL_YR_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_ALL_YR.CheckedChanged
        If CHK_ALL_YR.Checked = True Then
            CB_YEAR.Enabled = False
            IR_ISALLYR = True
        Else
            CB_YEAR.Enabled = True
            IR_ISALLYR = False
        End If
    End Sub

End Class