Imports System.IO
Imports Microsoft.VisualBasic.PowerPacks
Public Class FRM_PR

    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function

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

#Region "LOAD"
    Private Sub FRM_PURCHASE_REQUEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SPM4_PR_LISTTableAdapter.FillByDIV_SEARCH(DS_STOREDPROC.SPM4_PR_LIST, DIVISION_NO, WTXT_PR_SEARCH.Text)
        LLBL_RECORDSFOUND.Text = DGV_PR_LIST.Rows.Count
        _DISABLE(True)
    End Sub
#End Region

#Region "TIMER"
    Private WithEvents UCPROCTim As New Timer With {.Interval = 10}
    Private WithEvents UCPROCTimY As New Timer With {.Interval = 10}
    Private WithEvents UCPROCTimPRSTATS As New Timer With {.Interval = 10}
    Private Sub Tim_Tick(sender As Object, e As EventArgs) Handles UCPROCTim.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTim Then
            Try
                If slideFlaG = True Then
                    X_LOC -= 100
                    PNL_SLIDE.Location = New Point(X_LOC, 40)
                    If PNL_SLIDE Is APNL_PR_DETAILS Then
                        If X_LOC < 395 Then
                            PNL_SLIDE.Location = New Point(336, 40)
                            X_LOC = 395
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

    Private Sub Tim_Tick2(sender As Object, e As EventArgs) Handles UCPROCTimY.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTimY Then
            Try
                If slideFlaGY = True Then
                    Y_LOC -= 100
                    PNL_SLIDE_Y.Location = New Point(575, Y_LOC)
                    If PNL_SLIDE_Y Is APNL_PR_SIGNATORIES Then
                        If Y_LOC < 132 Then
                            PNL_SLIDE_Y.Location = New Point(575, 132)
                            Y_LOC = 132
                            UCPROCTimY.Enabled = False
                        End If
                    End If
                Else
                    PNL_SLIDE_Y.Location = New Point(575, Y_LOC)
                    Y_LOC = 660
                    UCPROCTimY.Enabled = False
                End If
            Catch ex As Exception
                Y_LOC = 0
            End Try
        End If
    End Sub

    Private Sub Tim_Tick3(sender As Object, e As EventArgs) Handles UCPROCTimPRSTATS.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTimPRSTATS Then
            Try
                If slideFlaGX2 = True Then
                    X2_LOC -= 100
                    PNL_SLIDE2.Location = New Point(580, 0)
                    If PNL_SLIDE2 Is APNL_PR_STATUS Then
                        If X2_LOC < 580 Then
                            PNL_SLIDE2.Location = New Point(580, 0)
                            X2_LOC = 580
                            UCPROCTimPRSTATS.Enabled = False
                        End If
                    End If
                Else
                    PNL_SLIDE2.Location = New Point(1095, 0)
                    X2_LOC = 1095
                    UCPROCTimPRSTATS.Enabled = False
                End If
            Catch ex As Exception
                X2_LOC = 0
            End Try
        End If
    End Sub


#End Region

#Region "CLICK"
    Public Sub WTXT_REQUESTEDDATE_Click(sender As Object, e As EventArgs) Handles RECT_PRNEW.Click,
                                                                                    RECT_PRCANCELEDIT.Click,
                                                                                    PB_PRICONNEW.Click,
                                                                                    PB_PBICONEDIT.Click,
                                                                                    PB_PRICONSEARCH.Click,
                                                                                    PB_PRICONSAVE.Click,
                                                                                    BTN_CLOSE.Click,
                                                                                    LLBL_PREDIT.Click,
                                                                                    LLBL_PRSEARCH.Click,
                                                                                    LLBL_PRNEW.Click,
                                                                                    LLBL_PRCANCEL.Click,
                                                                                    LLBL_PRSAVE.Click,
                                                                                    WTXT_SIGNAPPROVENAME.Click,
                                                                                    WTXT_SIGNCERTIFIEDNAME.Click,
                                                                                    WTXT_SIGNNOTEDNAME.Click,
                                                                                    WTXT_SIGNREQUESTEDNAME.Click,
                                                                                    LLBL_ADDPARTICULARS.Click,
                                                                                    BTN_TRANSCODE.Click,
                                                                                    BTN_PRCLOSE.Click,
                                                                                    BTN_PRMINIMIZE.Click,
                                                                                    BTN_CLOSE_PR_DETAILS.Click,
                                                                                    LLBL_SIGNATORIES.Click,
                                                                                    PB_SIGNATORIES.Click,
                                                                                    BTN_CLOSE_SIGNATORY.Click,
                                                                                    LLBL_PR_SAVE_TRANS.Click,
                                                                                    PB_PRICONPRINTPREVIEW.Click,
                                                                                    PB_ADD_PART.Click,
                                                                                    RECT_ADD_PARTICULARS.Click,
                                                                                    LLBL_SIG_SAVEDEFAULT.Click,
                                                                                    PB_SIG_SAVEDEFAULT.Click,
                                                                                    RECT_SIG_SAVEDEFAULT.Click,
                                                                                    BTN_PR_STATUS_CLOSE.Click,
                                                                                    WTXT_REQUESTEDDATE.Click,
                                                                                    LLBL_PRINT_PREV.Click,
                                                                                    PB_PRINT_PREV.Click,
                                                                                    RECT_PRINT_PREV.Click


        Dim pb As PictureBox = Nothing
        Dim lbl As Label = Nothing
        Dim btn As Button = Nothing
        llbl = Nothing
        rect = Nothing
        TXTGLOBAL = Nothing

        If TypeOf sender Is LinkLabel Then
            llbl = CType(sender, LinkLabel)
        ElseIf TypeOf sender Is RectangleShape Then
            rect = CType(sender, RectangleShape)
        ElseIf TypeOf sender Is PictureBox Then
            pb = CType(sender, PictureBox)
        ElseIf TypeOf sender Is Button Then
            btn = CType(sender, Button)

        ElseIf TypeOf sender Is Label Then
            lbl = CType(sender, Label)
        ElseIf TypeOf sender Is TextBox Then
            TXTGLOBAL = CType(sender, TextBox)
        End If

        'DATE TEXTBOX
        If TXTGLOBAL Is WTXT_REQUESTEDDATE Then
            TXTDATE = CType(sender, TextBox)
            FRM_DATAENTRY.ShowDialog()
            'SIGN APPROVE NAME
        ElseIf TXTGLOBAL Is WTXT_SIGNAPPROVENAME Or TXTGLOBAL Is WTXT_SIGNCERTIFIEDNAME Or TXTGLOBAL Is WTXT_SIGNNOTEDNAME Or TXTGLOBAL Is WTXT_SIGNREQUESTEDNAME Then
            If CType(sender, TextBox).Name = "WTXT_SIGNAPPROVENAME" Then
                TXTGLOBAL = CType(WTXT_SIGNAPPROVENAME, TextBox)
                POSITION = CType(WTXT_SIGNAPPROVEPOSITION, TextBox)
                TXTSIGNO = CType(TXT_PRRAPPROVEDID, TextBox)
            ElseIf CType(sender, TextBox).Name = "WTXT_SIGNNOTEDNAME" Then
                TXTGLOBAL = CType(WTXT_SIGNNOTEDNAME, TextBox)
                POSITION = CType(WTXT_SIGNNOTEDPOSITION, TextBox)
                TXTSIGNO = CType(TXT_PRNOTEDID, TextBox)
            ElseIf CType(sender, TextBox).Name = "WTXT_SIGNCERTIFIEDNAME" Then
                TXTGLOBAL = CType(WTXT_SIGNCERTIFIEDNAME, TextBox)
                POSITION = CType(WTXT_SIGNCERTIFIEDPOSITION, TextBox)
                TXTSIGNO = CType(TXT_PRCERTIFIEDID, TextBox)
            ElseIf CType(sender, TextBox).Name = "WTXT_SIGNREQUESTEDNAME" Then
                TXTGLOBAL = CType(WTXT_SIGNREQUESTEDNAME, TextBox)
                POSITION = CType(WTXT_SIGNREQUESTEDPOSITION, TextBox)
                TXTSIGNO = CType(TXT_PRREQUESTEDID, TextBox)
            End If
            FRM_SIGNATORYLIST.ShowDialog()
            'NEW BUTTON
#Region "NEW PR"
        ElseIf pb Is PB_PRICONNEW Or llbl Is LLBL_PRNEW Or rect Is RECT_PRNEW Then
            dgv = Nothing
            UCPROCTim.Enabled = True
            slideFlaG = True
            PNL_SLIDE = APNL_PR_DETAILS
            PNL_SLIDE.BringToFront()
            PNL_BUTTONS.Enabled = False
            PNL_LIST.Enabled = False
            REPRINT = False
            _CLEAR()
            _DISABLE(False)
            isNew = True
            WTXT_SUBMITTEDBY.Text = USERFULLNAME
            PB_SAVEICONSAVEDEFAULT.Enabled = True
            LLBL_SAVEDEFAULT.Enabled = True
            LLBL_ADDPARTICULARS.Enabled = True
            GET_PRI_SIGNATORY()
            'GETDATE
            Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_STOREDPROC.SPM4_CURRENTDATETIME)
            Me.V1VW_USERACCEMPLOYEETableAdapter.FillByUSERNAME(Me.DS_VIEWS.V1VW_USERACCEMPLOYEE, SYS_USER)
            'Me.DGV_PR_ITEMLIST.Columns(6).Visible = True
            'Me.DGV_PR_ITEMLIST.Columns(7).Visible = True
            RECT_PRPARTICULARS.Visible = False
            WTXT_SUBMITTEDBY.Text = SYS_FULLNAME_FML


#End Region

#Region "CANCEL"
        ElseIf pb Is PB_PRICONCANCEL Or llbl Is LLBL_PRCANCEL Then
            If MsgBox("Do you really want to cancel this?", vbYesNo, "Confirm") = vbYes Then
                _DISABLE(True)
                _CLEAR()
                LLBL_PRNEW.BringToFront()
                LLBL_ADDPARTICULARS.Enabled = False

                isNew = False
                DGV_PR_ITEMLIST.Rows.Clear()
                RECT_PRPARTICULARS.Visible = False
                PB_PRICONSAVE.Enabled = False
                LLBL_PRSAVE.Enabled = False
                PB_PRICONNEW.Enabled = True
                LLBL_PRNEW.Enabled = True
            End If
#End Region

#Region "SAVE"
        ElseIf llbl Is LLBL_PR_SAVE_TRANS Or pb Is PB_PRICONPRINTPREVIEW Then
            ' is_preview = True
            ISVALID = True
            'PURPOSE VALIDATION
            If REQFIELDVALIDATION(WTXT_PURPOSE) Then
                RECT_PRPURPOSE.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_PRPURPOSE.BorderColor = Color.DimGray
            End If
            'PARTICULARS
            If DGV_PR_ITEMLIST.RowCount = 0 Then
                RECT_PRPARTICULARS.Visible = True
                ISVALID = False
            Else
                RECT_PRPARTICULARS.Visible = False
            End If

            'APPROVE NAME
            'If REQFIELDVALIDATION(WTXT_SIGNAPPROVENAME) Then
            '    RECT_PRSIGNAPPROVEDNAME.BorderColor = Color.OrangeRed
            '    RECT_PRSIGNAPPROVEPOSITION.BorderColor = Color.OrangeRed
            '    ISVALID = False
            'Else
            '    RECT_PRSIGNAPPROVEDNAME.BorderColor = Color.DimGray
            '    RECT_PRSIGNAPPROVEPOSITION.BorderColor = Color.DimGray
            'End If

            ''CERTIFIED NAME
            'If REQFIELDVALIDATION(WTXT_SIGNCERTIFIEDNAME) Then
            '    RECT_PRSIGNCERTIFIEDNAME.BorderColor = Color.OrangeRed
            '    RECT_PRSIGNCERTIFIEDPOSITION.BorderColor = Color.OrangeRed
            '    ISVALID = False
            'Else
            '    RECT_PRSIGNCERTIFIEDNAME.BorderColor = Color.DimGray
            '    RECT_PRSIGNCERTIFIEDPOSITION.BorderColor = Color.DimGray
            'End If

            ''NOTED NAME
            'If REQFIELDVALIDATION(WTXT_SIGNNOTEDNAME) Then
            '    RECT_PRSIGNNOTEDNAME.BorderColor = Color.OrangeRed
            '    RECT_PRSIGNNOTEDPOSITION.BorderColor = Color.OrangeRed
            '    ISVALID = False
            'Else
            '    RECT_PRSIGNNOTEDNAME.BorderColor = Color.DimGray
            '    RECT_PRSIGNNOTEDPOSITION.BorderColor = Color.DimGray
            'End If

            ''REQUESTED NAME
            'If REQFIELDVALIDATION(WTXT_SIGNREQUESTEDNAME) Then
            '    RECT_PRSIGNREQUESTEDNAME.BorderColor = Color.OrangeRed
            '    RECT_PRSIGNREQUESTEDPOSITION.BorderColor = Color.OrangeRed
            '    ISVALID = False
            'Else
            '    RECT_PRSIGNREQUESTEDNAME.BorderColor = Color.DimGray
            '    RECT_PRSIGNREQUESTEDPOSITION.BorderColor = Color.DimGray
            'End If

            If ISVALID Then
                SAVE()
            Else
                NotificationManager.Show(Me, "PLEASE CHECK SIGNATORIES AND OTHER REQUIRED FIELDS!", Color.Red, 3000)
            End If
#End Region

#Region "SAVE SIGNATORIES"
        ElseIf llbl Is LLBL_SIG_SAVEDEFAULT Or pb Is PB_SIG_SAVEDEFAULT Or rect Is RECT_SIG_SAVEDEFAULT Then
            _SIGNATORYDEFAULT()
#End Region

#Region "ADD PARTICULARS"
        ElseIf llbl Is LLBL_ADDPARTICULARS Or pb Is PB_ADD_PART Or rect Is RECT_ADD_PARTICULARS Then
            dgv = DGV_PR_ITEMLIST
            FRM_DGV_ENCODING.PNL_PARTICULARS.BringToFront()
            FRM_DGV_ENCODING.ShowDialog()
#End Region

#Region "MINIMIZE"
        ElseIf btn Is BTN_PRMINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
#End Region

#Region "CLOSE FORM"
        ElseIf btn Is BTN_CLOSE_SIGNATORY Then
            'UCPROCTimY.Enabled = True
            'slideFlaGY = False
            APNL_PR_DETAILS.Enabled = True
            APNL_PR_SIGNATORIES.Location = New Point(575, 660)
        ElseIf btn Is BTN_CLOSE_PR_DETAILS Then
            UCPROCTim.Enabled = True
            slideFlaG = False
            PNL_BUTTONS.Enabled = True
            PNL_LIST.Enabled = True
        ElseIf btn Is BTN_PRCLOSE Then
            Me.Close()
        ElseIf btn Is BTN_PR_STATUS_CLOSE Then
            UCPROCTimPRSTATS.Enabled = True
            slideFlaGX2 = False
            PNL_BUTTONS.Enabled = True
            PNL_LIST.Enabled = True
#End Region

#Region "SHOW SIGNATORIES"
        ElseIf rect Is RECT_SIGNATORIES Or llbl Is LLBL_SIGNATORIES Or pb Is PB_SIGNATORIES Then
            UCPROCTimY.Enabled = True
            slideFlaGY = True
            PNL_SLIDE_Y = APNL_PR_SIGNATORIES
            PNL_SLIDE_Y.BringToFront()
            APNL_PR_DETAILS.Enabled = False
#End Region

#Region "PRINT PREVIEW"
        ElseIf llbl Is LLBL_PRINT_PREV Or pb Is PB_PRINT_PREV Or rect Is RECT_PRINT_PREV Then
            PRINT_PREVIEW()
#End Region

        End If
    End Sub

#End Region

#Region "SAVE"
    Sub SAVE()
        'If CB_PRDEPARTMENT.SelectedValue = "PSO" Then
        '    isSatellite = True
        'Else
        '    isSatellite = False
        'End If

        If RBTN_DOLLARS.Checked = True Then
            ISDOLLARS = True
        Else
            ISDOLLARS = False
        End If
        dgv = DGV_PR_ITEMLIST
        PR_DATEREQUESTED = WTXT_REQUESTEDDATE.Text
        PR_APPCODE = WTXT_APPCODE.Text
        PR_DEPARTMENT = WTXT_PRDEPARTMENT.Text
        PR_DIVISION = WTXT_PRDIV.Text
        PR_PURPOSE = WTXT_PURPOSE.Text
        PR_REQUESTEDBY = WTXT_SIGNREQUESTEDNAME.Text
        PR_REQUESTEDBYPOSITION = WTXT_SIGNREQUESTEDPOSITION.Text
        PR_APPROVEDBY = WTXT_SIGNAPPROVENAME.Text
        PR_APPROVEDBYPOSITION = WTXT_SIGNAPPROVEPOSITION.Text
        PR_CERTIFIEDBY = WTXT_SIGNCERTIFIEDNAME.Text
        PR_CERTIFIEDBYPOSITION = WTXT_SIGNCERTIFIEDPOSITION.Text
        PR_NOTEDBY = WTXT_SIGNNOTEDNAME.Text
        PR_NOTEDBYPOSITION = WTXT_SIGNNOTEDPOSITION.Text

        If isNew Then
            PRNO_GEN = SPM4_PRCODETableAdapter.SPM4_SQ_PRCODE(DIVISION_NO)
            TblM4_PURCHASEREQUESTTableAdapter.IQ_PURCHASE_REQUEST(PRNO_GEN, Trim(PR_DATEREQUESTED), Trim(PR_APPCODE), Trim(PR_PURPOSE), 4, Trim(PR_REQUESTEDBY), Trim(PR_REQUESTEDBYPOSITION), Trim(PR_APPROVEDBY), Trim(PR_APPROVEDBYPOSITION), Trim(PR_CERTIFIEDBY), Trim(PR_CERTIFIEDBYPOSITION), Trim(PR_NOTEDBY), Trim(PR_NOTEDBYPOSITION), Trim(EMP_NO), Trim(PR_DEPARTMENT), Trim(PR_DIVISION), ISDOLLARS)
            For Each row As DataGridViewRow In DGV_PR_ITEMLIST.Rows
                If Not row.IsNewRow Then
                    TblM4_PURCHASEREQUEST_ITEMTableAdapter.IQ_PR_ITEMS(PRNO_GEN, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(0).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString)
                End If
            Next
        Else
            TblM4_PURCHASEREQUESTTableAdapter.UQ_PR(Trim(PR_DATEREQUESTED), Trim(PR_APPCODE), Trim(PR_PURPOSE), 4, Trim(PR_REQUESTEDBY), Trim(PR_REQUESTEDBYPOSITION), Trim(PR_APPROVEDBY), Trim(PR_APPROVEDBYPOSITION), Trim(PR_CERTIFIEDBY), Trim(PR_CERTIFIEDBYPOSITION), Trim(PR_NOTEDBY), Trim(PR_NOTEDBYPOSITION), Trim(EMP_NO), Trim(PR_DEPARTMENT), Trim(PR_DIVISION), Trim(EMP_NO), ISDOLLARS, PRNO_GEN)
            TblM4_PURCHASEREQUEST_ITEMTableAdapter.DQ_PR_ITEMS(PRNO_GEN)
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then
                    TblM4_PURCHASEREQUEST_ITEMTableAdapter.IQ_PR_ITEMS(PRNO_GEN, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(0).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString)
                End If
            Next
        End If


        MessageBox.Show("Successfully saved.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If MsgBox("Do you want to print?", vbYesNo, "Confirm") = vbYes Then
            FRM_PURCHASE_REQUEST_PRINTPREVIEW.BTN_GENERATE_REPORT.Visible = True
            FRM_PURCHASE_REQUEST_PRINTPREVIEW.BTN_GENERATE_REPORT.Text = "PRINT"
            FRM_PURCHASE_REQUEST_PRINTPREVIEW.ShowDialog()
        End If
        _DISABLE(True)
        _CLEAR()
        PB_PRICONNEW.Enabled = True
        LLBL_PRNEW.Enabled = True
        PB_PRICONNEW.BringToFront()
        PB_PBICONEDIT.BringToFront()
        PB_PRICONSAVE.SendToBack()
        LLBL_PRNEW.BringToFront()
        UCPROCTim.Enabled = True
        slideFlaG = False
        PNL_BUTTONS.Enabled = True
        PNL_LIST.Enabled = True
        isNew = False
        DGV_PR_ITEMLIST.Rows.Clear()
        SPM4_PR_LISTTableAdapter.FillByDIV_SEARCH(DS_STOREDPROC.SPM4_PR_LIST, DIVISION_NO, WTXT_PR_SEARCH.Text)
        'ISSAVE = False
        'If RBTN_DOLLARS.Checked = True Then
        '    ISDOLLARS = True
        'Else
        '    ISDOLLARS = False
        'End If
        'dgv = DGV_PR_ITEMLIST
        'PR_DATEREQUESTED = WTXT_REQUESTEDDATE.Text
        'PR_APPCODE = WTXT_APPCODE.Text
        'PR_DEPARTMENT = WTXT_PRDEPARTMENT.Text
        'PR_DIVISION = WTXT_PRDIV.Text
        'PR_PURPOSE = WTXT_PURPOSE.Text
        'PR_REQUESTEDBY = WTXT_SIGNREQUESTEDNAME.Text
        'PR_REQUESTEDBYPOSITION = WTXT_SIGNREQUESTEDPOSITION.Text
        'PR_APPROVEDBY = WTXT_SIGNAPPROVENAME.Text
        'PR_APPROVEDBYPOSITION = WTXT_SIGNAPPROVEPOSITION.Text
        'PR_CERTIFIEDBY = WTXT_SIGNCERTIFIEDNAME.Text
        'PR_CERTIFIEDBYPOSITION = WTXT_SIGNCERTIFIEDPOSITION.Text
        'PR_NOTEDBY = WTXT_SIGNNOTEDNAME.Text
        'PR_NOTEDBYPOSITION = WTXT_SIGNNOTEDPOSITION.Text
        'If REPRINT Then
        '    If isNew = False Then
        '        FRM_PURCHASE_REQUEST_PRINTPREVIEW.BTN_GENERATE_REPORT.Text = "SAVE AND PRINT"
        '    Else
        '        FRM_PURCHASE_REQUEST_PRINTPREVIEW.BTN_GENERATE_REPORT.Text = "PRINT"
        '    End If
        'End If
        'FRM_PURCHASE_REQUEST_PRINTPREVIEW.ShowDialog()
        'If ISSAVE Then
        '    NotificationManager.Show(Me, "Successfully save!.", Color.Green, 6000)
        '    _DISABLE(True)
        '    _CLEAR()
        '    PB_PRICONNEW.Enabled = True
        '    LLBL_PRNEW.Enabled = True
        '    PB_PRICONNEW.BringToFront()
        '    PB_PBICONEDIT.BringToFront()
        '    PB_PRICONSAVE.SendToBack()
        '    LLBL_PRNEW.BringToFront()
        '    UCPROCTim.Enabled = True
        '    slideFlaG = False
        '    PNL_BUTTONS.Enabled = True
        '    PNL_LIST.Enabled = True
        '    isNew = False
        '    DGV_PR_ITEMLIST.Rows.Clear()
        'End If
    End Sub
#End Region

#Region "PREVIEW"
    Sub PRINT_PREVIEW()
        If RBTN_DOLLARS.Checked = True Then
            ISDOLLARS = True
        Else
            ISDOLLARS = False
        End If
        dgv = DGV_PR_ITEMLIST
        PR_DATEREQUESTED = WTXT_REQUESTEDDATE.Text
        PR_APPCODE = WTXT_APPCODE.Text
        PR_DEPARTMENT = WTXT_PRDEPARTMENT.Text
        PR_DIVISION = WTXT_PRDIV.Text
        PR_PURPOSE = WTXT_PURPOSE.Text
        PR_REQUESTEDBY = WTXT_SIGNREQUESTEDNAME.Text
        PR_REQUESTEDBYPOSITION = WTXT_SIGNREQUESTEDPOSITION.Text
        PR_APPROVEDBY = WTXT_SIGNAPPROVENAME.Text
        PR_APPROVEDBYPOSITION = WTXT_SIGNAPPROVEPOSITION.Text
        PR_CERTIFIEDBY = WTXT_SIGNCERTIFIEDNAME.Text
        PR_CERTIFIEDBYPOSITION = WTXT_SIGNCERTIFIEDPOSITION.Text
        PR_NOTEDBY = WTXT_SIGNNOTEDNAME.Text
        PR_NOTEDBYPOSITION = WTXT_SIGNNOTEDPOSITION.Text
        FRM_PURCHASE_REQUEST_PRINTPREVIEW.BTN_GENERATE_REPORT.Text = "PRINT"
        If REPRINT Then
            If isNew = False Then
                FRM_PURCHASE_REQUEST_PRINTPREVIEW.BTN_GENERATE_REPORT.Visible = False
            Else
                FRM_PURCHASE_REQUEST_PRINTPREVIEW.BTN_GENERATE_REPORT.Visible = True
            End If

        Else
            PRNO_GEN = SPM4_PRCODETableAdapter.SPM4_SQ_PRCODE(DIVISION_NO)
            FRM_PURCHASE_REQUEST_PRINTPREVIEW.BTN_GENERATE_REPORT.Visible = False
        End If
        FRM_PURCHASE_REQUEST_PRINTPREVIEW.ShowDialog()

        'FRM_PURCHASE_REQUEST_PRINTPREVIEW.ShowDialog()
    End Sub
#End Region

#Region "DISABLE/ENABLE"
    Public Sub _DISABLE(ByVal disable As Boolean)
        'TRUE
        If disable Then
            GB_PRINFO.Enabled = False
            LLBL_PRSEARCH.Enabled = True
            PB_PRICONSEARCH.Enabled = True
            LLBL_PREDIT.Enabled = True
            PB_PBICONEDIT.Enabled = True
            PB_PRICONCANCEL.Enabled = False
            LLBL_PRCANCEL.Enabled = False
            PB_PRICONNEW.BringToFront()
            DGV_PR_ITEMLIST.Enabled = False
            PanelSignatory.Enabled = False
            'FALSE
        Else
            GB_PRINFO.Enabled = True
            PB_PRICONSAVE.BringToFront()
            LLBL_PRSAVE.BringToFront()
            LLBL_PRSEARCH.Enabled = False
            PB_PRICONSEARCH.Enabled = False
            LLBL_PREDIT.Enabled = False
            PB_PBICONEDIT.Enabled = False
            PB_PRICONCANCEL.Enabled = True
            LLBL_PRCANCEL.Enabled = True
            DGV_PR_ITEMLIST.Enabled = True
            PanelSignatory.Enabled = True
        End If
    End Sub
#End Region

#Region "CLEAR"
    Public Sub _CLEAR()
        WTXT_APPCODE.Clear()
        WTXT_SUBMITTEDBY.Clear()
        WTXT_PURPOSE.Clear()
        WTXT_SUBMITTEDBY.Clear()
        WTXT_REQUESTEDDATE.Clear()
        WTXT_SIGNAPPROVENAME.Clear()
        WTXT_SIGNAPPROVEPOSITION.Clear()
        WTXT_SIGNCERTIFIEDNAME.Clear()
        WTXT_SIGNCERTIFIEDPOSITION.Clear()
        WTXT_SIGNNOTEDNAME.Clear()
        WTXT_SIGNNOTEDPOSITION.Clear()
        WTXT_SIGNREQUESTEDNAME.Clear()
        WTXT_SIGNREQUESTEDPOSITION.Clear()
        DGV_PR_ITEMLIST.Rows.Clear()
        DGV_PR_ITEMLIST.DataSource = Nothing
        RECT_PRPURPOSE.BorderColor = Color.DimGray
        RECT_PRREQUESTEDDATE.BorderColor = Color.DimGray
        RECT_PRAPPCODE.BorderColor = Color.DimGray
    End Sub

#End Region

#Region "GET PRIMARY SIGNATORY"
    Sub GET_PRI_SIGNATORY()
        Try
            SPM4_USER_SIGNATORYTableAdapter.FillByEMPID_FORM_CODE(DS_STOREDPROC.SPM4_USER_SIGNATORY, EMP_NO, "PRA-PM-FORM-0001")
            Dim cnt As Integer = SPM4_USER_SIGNATORYBindingSource.Count - 1
            For i = 0 To cnt
                If BS(SPM4_USER_SIGNATORYBindingSource, i, 10) = "Requested by:" Then
                    WTXT_SIGNREQUESTEDNAME.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 3))
                    WTXT_SIGNREQUESTEDPOSITION.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 4))
                    TXT_PRREQUESTEDID.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 2))
                ElseIf BS(SPM4_USER_SIGNATORYBindingSource, i, 10) = "Approved by:" Then
                    WTXT_SIGNAPPROVENAME.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 3))
                    WTXT_SIGNAPPROVEPOSITION.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 4))
                    TXT_PRRAPPROVEDID.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 2))
                ElseIf BS(SPM4_USER_SIGNATORYBindingSource, i, 10) = "Certified by:" Then
                    WTXT_SIGNCERTIFIEDNAME.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 3))
                    WTXT_SIGNCERTIFIEDPOSITION.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 4))
                    TXT_PRCERTIFIEDID.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 2))
                ElseIf BS(SPM4_USER_SIGNATORYBindingSource, i, 10) = "Noted by:" Then
                    WTXT_SIGNNOTEDNAME.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 3))
                    WTXT_SIGNNOTEDPOSITION.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 4))
                    TXT_PRNOTEDID.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 2))
                End If
            Next
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "GET_PRI_SIGNATORY")
        End Try
    End Sub
#End Region

#Region "SAVE/UPDATE DEFAULT SIGNATORY"
    Sub _SIGNATORYDEFAULT()
        Try
            NotificationManager.Show(Me, "Default Signatory has been save.", Color.Green, 3000)
            If REQFIELDVALIDATION(TXT_PRREQUESTEDID) = False Then
                SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(17, EMP_NO, If(TXT_PRREQUESTEDID.Text = String.Empty, 0, TXT_PRREQUESTEDID.Text))
            End If

            If REQFIELDVALIDATION(TXT_PRRAPPROVEDID) = False Then
                SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(18, EMP_NO, If(TXT_PRRAPPROVEDID.Text = String.Empty, 0, TXT_PRRAPPROVEDID.Text))
            End If

            If REQFIELDVALIDATION(TXT_PRCERTIFIEDID) = False Then
                SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(19, EMP_NO, If(TXT_PRCERTIFIEDID.Text = String.Empty, 0, TXT_PRCERTIFIEDID.Text))
            End If

            If REQFIELDVALIDATION(TXT_PRNOTEDID) = False Then
                SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(20, EMP_NO, If(TXT_PRNOTEDID.Text = String.Empty, 0, TXT_PRNOTEDID.Text))
            End If

            GET_PRI_SIGNATORY()
            APNL_PR_SIGNATORIES.Location = New Point(575, 660)
            APNL_PR_DETAILS.Enabled = True
        Catch ex As Exception
            '  NotificationManager.Show(Me, "Please select signatory!", Color.Red, 3000)
        End Try

    End Sub
#End Region

#Region "KEYDOWN"
    Private Sub WTXT_PR_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_PR_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            SPM4_PR_LISTTableAdapter.FillByDIV_SEARCH(DS_STOREDPROC.SPM4_PR_LIST, DIVISION_NO, WTXT_PR_SEARCH.Text)
            LLBL_RECORDSFOUND.Text = DGV_PR_LIST.Rows.Count
        End If
    End Sub
#End Region

#Region "CELL/CONTENT CLICK"
    Private Sub DGV_PR_ITEMLIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PR_ITEMLIST.CellClick
        '   Dim dgv = DirectCast(sender, DataGridView)
        Dim dgv1 = CType(sender, DataGridView)
        If dgv1 Is DGV_PR_ITEMLIST Then
            If dgv1.ColumnCount = 8 AndAlso e.ColumnIndex = 7 Then
                If MsgBox("REMOVE THIS?", vbYesNo, "CONFIRM") = vbYes Then
                    dgv1.Rows.RemoveAt(e.RowIndex)
                End If
            ElseIf dgv1.ColumnCount = 8 AndAlso e.ColumnIndex = 6 Then
                If MsgBox("UPDATE THIS?", vbYesNo, "CONFIRM") = vbYes Then
                    dgv = DGV_PR_ITEMLIST
                    FRM_DGV_ENCODING.WTXT_DESCRIPTION.Text = dgv1.Rows(e.RowIndex).Cells(0).Value.ToString
                    FRM_DGV_ENCODING.WTXT_QUANTITY.Text = dgv1.Rows(e.RowIndex).Cells(1).Value.ToString
                    FRM_DGV_ENCODING.CB_UNITOFISSUE.Text = dgv1.Rows(e.RowIndex).Cells(2).Value.ToString
                    FRM_DGV_ENCODING.WTXT_STOCKNO.Text = dgv1.Rows(e.RowIndex).Cells(3).Value.ToString
                    FRM_DGV_ENCODING.WTXT_ESTIMATEDUNITCOST.Text = dgv1.Rows(e.RowIndex).Cells(4).Value.ToString
                    FRM_DGV_ENCODING.WTXT_ESTIMATEDUNITCOST.Text = TXTSETTO_0(FRM_DGV_ENCODING.WTXT_ESTIMATEDUNITCOST, False)
                    FRM_DGV_ENCODING.WTXT_ESTIMATEDCOST.Text = dgv1.Rows(e.RowIndex).Cells(5).Value.ToString
                    FRM_DGV_ENCODING.WTXT_ESTIMATEDCOST.Text = TXTSETTO_0(FRM_DGV_ENCODING.WTXT_ESTIMATEDCOST, False)
                    FRM_DGV_ENCODING.BTN_SAVE.Text = "Update Particulars"
                    FRM_DGV_ENCODING.ShowDialog()
                End If
            End If

        End If

    End Sub

    Private Sub DGV_PR_LIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PR_LIST.CellContentClick
        If e.RowIndex >= 0 Then
            TblM4_PURCHASEREQUEST_ITEMTableAdapter.FillByPRNO(DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM, DGV_PR_LIST(0, e.RowIndex).Value)
            PRNO_GEN = DGV_PR_LIST(0, e.RowIndex).Value
            WTXT_APPCODE.Text = DGV_PR_LIST(2, e.RowIndex).Value
            If DGV_PR_LIST(19, e.RowIndex).Value = True Then
                RBTN_DOLLARS.Checked = True

            Else
              
                RBTN_PESO.Checked = True
            End If
            WTXT_REQUESTEDDATE.Text = DGV_PR_LIST(1, e.RowIndex).Value
            If Not IsDBNull(DGV_PR_LIST(20, e.RowIndex).Value) Then
                WTXT_SUBMITTEDBY.Text = DGV_PR_LIST(20, e.RowIndex).Value
            Else
                WTXT_SUBMITTEDBY.Text = ""
            End If

            WTXT_PRDEPARTMENT.Text = DGV_PR_LIST(15, e.RowIndex).Value
            WTXT_PRDIV.Text = DGV_PR_LIST(16, e.RowIndex).Value
            WTXT_PURPOSE.Text = DGV_PR_LIST(4, e.RowIndex).Value
            WTXT_SIGNREQUESTEDNAME.Text = DGV_PR_LIST(6, e.RowIndex).Value
            WTXT_SIGNREQUESTEDPOSITION.Text = DGV_PR_LIST(7, e.RowIndex).Value
            WTXT_SIGNAPPROVENAME.Text = DGV_PR_LIST(8, e.RowIndex).Value
            WTXT_SIGNAPPROVEPOSITION.Text = DGV_PR_LIST(9, e.RowIndex).Value
            WTXT_SIGNCERTIFIEDNAME.Text = DGV_PR_LIST(10, e.RowIndex).Value
            WTXT_SIGNCERTIFIEDPOSITION.Text = DGV_PR_LIST(11, e.RowIndex).Value
            WTXT_SIGNNOTEDNAME.Text = DGV_PR_LIST(12, e.RowIndex).Value
            WTXT_SIGNNOTEDPOSITION.Text = DGV_PR_LIST(13, e.RowIndex).Value

            DGV_PR_ITEMLIST.Rows.Clear()
            For Each row As DataGridViewRow In TblM4_PURCHASEREQUEST_ITEMDataGridView1.Rows
                DGV_PR_ITEMLIST.Rows.Add(row.Cells(2).Value, row.Cells(0).Value, row.Cells(1).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value)
            Next
            'PRINT
            If e.ColumnIndex = 23 Then
                REPRINT = True
                isNew = True
                PRINT_PREVIEW()
                'EDIT
            ElseIf e.ColumnIndex = 22 Then
                UCPROCTim.Enabled = True
                slideFlaG = True
                PNL_SLIDE = APNL_PR_DETAILS
                PNL_SLIDE.BringToFront()
                PNL_BUTTONS.Enabled = False
                PNL_LIST.Enabled = False
                REPRINT = True
                isNew = False
                _DISABLE(False)
                'VIEW
            ElseIf e.ColumnIndex = 21 Then
                UCPROCTimPRSTATS.Enabled = True
                slideFlaGX2 = True
                PNL_SLIDE2 = APNL_PR_STATUS
                PNL_SLIDE2.BringToFront()
                PNL_BUTTONS.Enabled = False
                PNL_LIST.Enabled = False
            End If
        End If
    End Sub
#End Region


End Class