Imports System.IO
Imports Microsoft.VisualBasic.PowerPacks
Public Class FRM_PR


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

        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLG3_PRIMARY_SIGNATORY' table. You can move, or remove it, as needed.
        Me.TBLG3_PRIMARY_SIGNATORYTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_PRIMARY_SIGNATORY)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_PURCHASEREQUEST' table. You can move, or remove it, as needed.
        Me.TblM4_PURCHASEREQUESTTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST)

        'TODO: This line of code loads data into the 'DS_PROPERTYDB.VWG3_PRIMARY_SIGNATORY' table. You can move, or remove it, as needed.
        Me.VWG3_PRIMARY_SIGNATORYTableAdapter.Fill(Me.DS_PROPERTYDB.VWG3_PRIMARY_SIGNATORY)
        _DISABLE(True)
        '   OPENINITSCANNER()



    End Sub
#End Region

    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function

    Private WithEvents UCPROCTim As New Timer With {.Interval = 10}

    Private Sub Tim_Tick(sender As Object, e As EventArgs) Handles UCPROCTim.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTim Then
            Try
                If slideFlaG = True Then
                    X_LOC -= 100
                    PNL_SLIDE.Location = New Point(X_LOC, 40)
                    If PNL_SLIDE Is APNL_PRREMARKS Then
                        If X_LOC < 424 Then
                            PNL_SLIDE.Location = New Point(424, 40)
                            X_LOC = 424
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

#Region "BUTTON/TEXTBOX/LINKLABEL CLICK"

    Public Sub WTXT_REQUESTEDDATE_Click(sender As Object, e As EventArgs) Handles RECT_PRSAVENEW.Click,
                                                                                    RECT_PRCANCELEDIT.Click,
                                                                                    PB_PRICONNEW.Click,
                                                                                    PB_PBICONEDIT.Click,
                                                                                    PB_PRICONSEARCH.Click,
                                                                                    PB_PRICONSAVE.Click,
                                                                                    PB_PRICONPRINTPREVIEW.Click,
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
                                                                                    LLBL_PRPRINTPREVIEW.Click,
                                                                                    LLBL_SAVEDEFAULT.Click,
                                                                                    PB_SAVEICONSAVEDEFAULT.Click,
                                                                                    LLBL_ADDPARTICULARS.Click,
                                                                                    BTN_TRANSCODE.Click,
                                                                                    BTN_PRCLOSE.Click,
                                                                                    BTN_PRMINIMIZE.Click,
                                                                                    LLBL_PRVIEWREMARKS.LinkClicked,
                                                                                    BTN_CLOSE_PRREMARKS.Click
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
        ElseIf pb Is PB_PRICONNEW Or llbl Is LLBL_PRNEW Then
            _CLEAR()
            _DISABLE(False)
            isNew = True

            WTXT_SUBMITTEDBY.Text = USERFULLNAME
            PB_SAVEICONSAVEDEFAULT.Enabled = True
            LLBL_SAVEDEFAULT.Enabled = True
            LLBL_ADDPARTICULARS.Enabled = True
            GET_PRI_SIGNATORY()
            'GETDATE
            Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_CURRENTDATETIME)
            'GET DIVISION
            Me.TblV1_HRISDIVISIONTableAdapter.Fill(Me.DS_TABLES.tblV1_HRISDIVISION)
            'GET DEPARTMENT
            Me.TblV1_HRISDEPARTMENTTableAdapter.Fill(Me.DS_TABLES.tblV1_HRISDEPARTMENT)
            Me.TblV1_HRISDIVISIONTableAdapter.FillByDEPTCODE(Me.DS_TABLES.tblV1_HRISDIVISION, CB_PRDEPARTMENT.SelectedValue)
            Me.DGV_PR_ITEMLIST.Columns(6).Visible = True
            Me.DGV_PR_ITEMLIST.Columns(7).Visible = True
            RECT_PRPARTICULARS.Visible = False
            CB_PRDEPARTMENT.SelectedIndex = CB_PRDEPARTMENT.FindStringExact(USERDEPARTMENT)
            CB_PRDIVISION.SelectedIndex = CB_PRDIVISION.FindStringExact(USERDIVISION)

            'EDIT BUTTON
        ElseIf pb Is PB_PBICONEDIT Or lbl Is LLBL_PREDIT Or llbl Is LLBL_PREDIT Then
            _DISABLE(False)
            TXTAPPCODE = CType(WTXT_APPCODE, TextBox)
            TXTREQUESTEDDATE = CType(WTXT_REQUESTEDDATE, TextBox)
            TXTSUBMITTEDBY = CType(WTXT_SUBMITTEDBY, TextBox)
            RBTNISDOLLAR = CType(RBTN_DOLLARS, RadioButton)
            CBDEPARTMENT = CType(CB_PRDEPARTMENT, ComboBox)
            CBDIVISION = CType(CB_PRDIVISION, ComboBox)
            TXTPURPOSE = CType(WTXT_PURPOSE, TextBox)
            FRM_EDITPR.ShowDialog()
            'CANCEL Button
        ElseIf pb Is PB_PRICONCANCEL Or llbl Is LLBL_PRCANCEL Then
            If MsgBox("Do you really want to cancel this request?", vbYesNo, "Confirm") = vbYes Then
                _DISABLE(True)
                _CLEAR()
                LLBL_PRNEW.BringToFront()
                LLBL_ADDPARTICULARS.Enabled = False
                CB_PRDEPARTMENT.SelectedIndex = -1
                CB_PRDIVISION.SelectedIndex = -1
                isNew = False
                DGV_PR_ITEMLIST.Rows.Clear()
                RECT_PRPARTICULARS.Visible = False
                PB_PRICONSAVE.Enabled = False
                LLBL_PRSAVE.Enabled = False
                PB_PRICONNEW.Enabled = True
                LLBL_PRNEW.Enabled = True
            End If
            'SAVE BUTTON
        ElseIf pb Is PB_PRICONSAVE Or llbl Is LLBL_PRSAVE Or llbl Is LLBL_PRSAVE Then

            ISVALID = True
            'PURPOSE VALIDATION
            If REQFIELDVALIDATION(WTXT_PURPOSE) Then
                RECT_PRPURPOSE.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_PRPURPOSE.BorderColor = Color.LightSeaGreen
            End If
            'PARTICULARS
            If DGV_PR_ITEMLIST.RowCount = 0 Then
                RECT_PRPARTICULARS.Visible = True
                ISVALID = False
            Else
                RECT_PRPARTICULARS.Visible = False
            End If

            'APPROVE NAME
            If REQFIELDVALIDATION(WTXT_SIGNAPPROVENAME) Then
                RECT_PRSIGNAPPROVEDNAME.BorderColor = Color.OrangeRed
                RECT_PRSIGNAPPROVEPOSITION.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_PRSIGNAPPROVEDNAME.BorderColor = Color.LightSeaGreen
                RECT_PRSIGNAPPROVEPOSITION.BorderColor = Color.LightSeaGreen
            End If

            'CERTIFIED NAME
            If REQFIELDVALIDATION(WTXT_SIGNCERTIFIEDNAME) Then
                RECT_PRSIGNCERTIFIEDNAME.BorderColor = Color.OrangeRed
                RECT_PRSIGNCERTIFIEDPOSITION.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_PRSIGNCERTIFIEDNAME.BorderColor = Color.LightSeaGreen
                RECT_PRSIGNCERTIFIEDPOSITION.BorderColor = Color.LightSeaGreen
            End If

            'NOTED NAME
            If REQFIELDVALIDATION(WTXT_SIGNNOTEDNAME) Then
                RECT_PRSIGNNOTEDNAME.BorderColor = Color.OrangeRed
                RECT_PRSIGNNOTEDPOSITION.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_PRSIGNNOTEDNAME.BorderColor = Color.LightSeaGreen
                RECT_PRSIGNNOTEDPOSITION.BorderColor = Color.LightSeaGreen
            End If

            'REQUESTED NAME
            If REQFIELDVALIDATION(WTXT_SIGNREQUESTEDNAME) Then
                RECT_PRSIGNREQUESTEDNAME.BorderColor = Color.OrangeRed
                RECT_PRSIGNREQUESTEDPOSITION.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_PRSIGNREQUESTEDNAME.BorderColor = Color.LightSeaGreen
                RECT_PRSIGNREQUESTEDPOSITION.BorderColor = Color.LightSeaGreen
            End If

            'APPCODE
            'If REQFIELDVALIDATION(WTXT_APPCODE) Then
            '    RECT_PRAPPCODE.BorderColor = Color.OrangeRed
            '    RECT_PRAPPCODE.BorderColor = Color.OrangeRed
            '    ISVALID = False
            'Else
            '    RECT_PRAPPCODE.BorderColor = Color.LightSeaGreen
            'End If

            'if all required fields are filled up.
            If ISVALID Then
                If MsgBox("Submit this request?", vbYesNo, "Confirm") = vbYes Then
                    _SAVE()
                    If MsgBox("Do you want to print this transaction?", vbYesNo, "Confirm") = vbYes Then
                        is_preview = False
                        PREVIEW()
                    End If
                    _DISABLE(True)
                    _CLEAR()
                    PB_PRICONNEW.Enabled = True
                    LLBL_PRNEW.Enabled = True
                    PB_PRICONNEW.BringToFront()
                    PB_PBICONEDIT.BringToFront()
                    PB_PRICONSAVE.SendToBack()
                    LLBL_PRNEW.BringToFront()
                    CB_PRDEPARTMENT.SelectedIndex = -1
                    CB_PRDIVISION.SelectedIndex = -1
                    isNew = False
                    DGV_PR_ITEMLIST.Rows.Clear()
                End If
            Else
                NotificationManager.Show(Me, "PLEASE PROVIDE ALL REQUIRED FIELD!", Color.Red, 3000)
            End If
            'CLOSE BUTTON
        ElseIf btn Is BTN_PRCLOSE Then
            Me.Close()
            'MINIMIZE BUTTON
        ElseIf btn Is BTN_PRMINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
            'SEARCH BUTTON
        ElseIf llbl Is LLBL_PRSEARCH Or pb Is PB_PRICONSEARCH Then
            FRM_SEARCHPRLIST.ShowDialog()
        ElseIf llbl Is LLBL_PRPRINTPREVIEW Or pb Is PB_PRICONPRINTPREVIEW Then
            is_preview = True
            PREVIEW()
        ElseIf llbl Is LLBL_SAVEDEFAULT Or pb Is PB_SAVEICONSAVEDEFAULT Then
            _SIGNATORYDEFAULT()
        ElseIf llbl Is LLBL_ADDPARTICULARS Then
            dgv = DGV_PR_ITEMLIST
            FRM_DGV_ENCODING.PNL_PARTICULARS.BringToFront()
            FRM_DGV_ENCODING.BTN_SAVE.Text = "SAVE"
            FRM_DGV_ENCODING.ShowDialog()
        ElseIf llbl Is LLBL_PRVIEWREMARKS Then
            UCPROCTim.Enabled = True
            slideFlaG = True
            PNL_SLIDE = APNL_PRREMARKS
            PNL_SLIDE.BringToFront()
        ElseIf btn Is BTN_CLOSE_PRREMARKS Then
            UCPROCTim.Enabled = True
            slideFlaG = False
        End If
    End Sub
#End Region

#Region "Hover BUTTON/PB/LLBL"

#End Region

#Region "PRINT PREVIEW"
    Sub PREVIEW()
        If CB_PRDEPARTMENT.SelectedValue = "PSO" Then
            isSatellite = True
        Else
            isSatellite = False
        End If

        If RBTN_DOLLARS.Checked = True Then
            ISDOLLARS = True
        Else
            ISDOLLARS = False
        End If
        dgv = DGV_PR_ITEMLIST
        PR_DATEREQUESTED = WTXT_REQUESTEDDATE.Text
        PR_APPCODE = WTXT_APPCODE.Text
        PR_DEPARTMENT = CB_PRDEPARTMENT.Text
        PR_DIVISION = CB_PRDIVISION.Text
        PR_PURPOSE = WTXT_PURPOSE.Text
        PR_REQUESTEDBY = WTXT_SIGNREQUESTEDNAME.Text
        PR_REQUESTEDBYPOSITION = WTXT_SIGNREQUESTEDPOSITION.Text
        PR_APPROVEDBY = WTXT_SIGNAPPROVENAME.Text
        PR_APPROVEDBYPOSITION = WTXT_SIGNAPPROVEPOSITION.Text
        PR_CERTIFIEDBY = WTXT_SIGNCERTIFIEDNAME.Text
        PR_CERTIFIEDBYPOSITION = WTXT_SIGNCERTIFIEDPOSITION.Text
        PR_NOTEDBY = WTXT_SIGNNOTEDNAME.Text
        PR_NOTEDBYPOSITION = WTXT_SIGNNOTEDPOSITION.Text
        FRM_PURCHASE_REQUEST_PRINTPREVIEW.ShowDialog()

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
            LLBL_PRPRINTPREVIEW.Enabled = False
            PB_PRICONPRINTPREVIEW.Enabled = False
            RBTN_PESO.Checked = False
            'FALSE
        Else
            RBTN_PESO.Checked = True
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
            LLBL_PRPRINTPREVIEW.Enabled = True
            PB_PRICONPRINTPREVIEW.Enabled = True
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
        DGV_PR_ITEMLIST.DataSource = Nothing
        RECT_PRPURPOSE.BorderColor = Color.LightSeaGreen
        RECT_PRREQUESTEDDATE.BorderColor = Color.LightSeaGreen
        RECT_PRAPPCODE.BorderColor = Color.LightSeaGreen
    End Sub

#End Region

#Region "SAVE"
    Sub _SAVE()
        Try

            'check if request is new
            If isNew Then
                PRNO_GEN = SPM4_PRCODETableAdapter.SPM4_SQ_PRCODE(CB_PRDIVISION.SelectedValue)
                If RBTN_DOLLARS.Checked = True Then
                    ISDOLLARS = True
                Else
                    ISDOLLARS = False
                End If
                TblM4_PURCHASEREQUESTTableAdapter.IQ_PURCHASE_REQUEST(PRNO_GEN, Trim(WTXT_REQUESTEDDATE.Text), Trim(WTXT_APPCODE.Text), Trim(WTXT_PURPOSE.Text), 4, Trim(WTXT_SIGNREQUESTEDNAME.Text), Trim(WTXT_SIGNREQUESTEDPOSITION.Text), Trim(WTXT_SIGNAPPROVENAME.Text), Trim(WTXT_SIGNAPPROVEPOSITION.Text), Trim(WTXT_SIGNCERTIFIEDNAME.Text), Trim(WTXT_SIGNCERTIFIEDPOSITION.Text), Trim(WTXT_SIGNNOTEDNAME.Text), Trim(WTXT_SIGNNOTEDPOSITION.Text), Trim(EMP_NO), Trim(CB_PRDEPARTMENT.Text), Trim(CB_PRDIVISION.Text), ISDOLLARS)
                For Each row As DataGridViewRow In DGV_PR_ITEMLIST.Rows
                    If Not row.IsNewRow Then
                        TblM4_PURCHASEREQUEST_ITEMTableAdapter.IQ_PR_ITEMS(PRNO_GEN, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(0).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString)
                    End If
                Next
                NotificationManager.Show(Me, "Successfully submit!.", Color.Green, 3000)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "GET PRIMARY SIGNATORY"
    Sub GET_PRI_SIGNATORY()
        Try
            VWG3_PRIMARY_SIGNATORYTableAdapter.FillBy_HRIS_EMPNO_USER(DS_PROPERTYDB.VWG3_PRIMARY_SIGNATORY, EMP_NO)

            WTXT_SIGNREQUESTEDNAME.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 0, 8)
            WTXT_SIGNREQUESTEDPOSITION.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 0, 9)
            TXT_PRREQUESTEDID.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 0, 5)

            WTXT_SIGNAPPROVENAME.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 1, 8)
            WTXT_SIGNAPPROVEPOSITION.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 1, 9)
            TXT_PRRAPPROVEDID.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 1, 5)

            WTXT_SIGNCERTIFIEDNAME.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 2, 8)
            WTXT_SIGNCERTIFIEDPOSITION.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 2, 9)
            TXT_PRCERTIFIEDID.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 2, 5)

            WTXT_SIGNNOTEDNAME.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 3, 8)
            WTXT_SIGNNOTEDPOSITION.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 3, 9)
            TXT_PRNOTEDID.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 3, 5)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "SAVE/UPDATE DEFAULT SIGNATORY"
    Sub _SIGNATORYDEFAULT()
        'update
        If TBLG3_PRIMARY_SIGNATORYTableAdapter.SQ_IFUSERHASDEFAULTSIGNATORY(EMP_NO) <> 0 Then
            TBLG3_PRIMARY_SIGNATORYTableAdapter.UQ_PRIMARY_SIGNATORY_PURCHASE_REQUEST(6, EMP_NO, TXT_PRREQUESTEDID.Text, 6, EMP_NO)
            TBLG3_PRIMARY_SIGNATORYTableAdapter.UQ_PRIMARY_SIGNATORY_PURCHASE_REQUEST(7, EMP_NO, TXT_PRRAPPROVEDID.Text, 7, EMP_NO)
            TBLG3_PRIMARY_SIGNATORYTableAdapter.UQ_PRIMARY_SIGNATORY_PURCHASE_REQUEST(8, EMP_NO, TXT_PRCERTIFIEDID.Text, 8, EMP_NO)
            TBLG3_PRIMARY_SIGNATORYTableAdapter.UQ_PRIMARY_SIGNATORY_PURCHASE_REQUEST(9, EMP_NO, TXT_PRNOTEDID.Text, 9, EMP_NO)
            'insert new
        Else
            TBLG3_PRIMARY_SIGNATORYTableAdapter.IQ_PRIMARY_SIGNATORY_PURCHASE_REQUEST(6, EMP_NO, TXT_PRREQUESTEDID.Text)
            TBLG3_PRIMARY_SIGNATORYTableAdapter.IQ_PRIMARY_SIGNATORY_PURCHASE_REQUEST(7, EMP_NO, TXT_PRRAPPROVEDID.Text)
            TBLG3_PRIMARY_SIGNATORYTableAdapter.IQ_PRIMARY_SIGNATORY_PURCHASE_REQUEST(8, EMP_NO, TXT_PRCERTIFIEDID.Text)
            TBLG3_PRIMARY_SIGNATORYTableAdapter.IQ_PRIMARY_SIGNATORY_PURCHASE_REQUEST(9, EMP_NO, TXT_PRNOTEDID.Text)
        End If
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLG3_PRIMARY_SIGNATORY' table. You can move, or remove it, as needed.
        Me.TBLG3_PRIMARY_SIGNATORYTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_PRIMARY_SIGNATORY)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLG3_PRIMARY_SIGNATORY' table. You can move, or remove it, as needed.
        Me.TBLG3_PRIMARY_SIGNATORYTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_PRIMARY_SIGNATORY)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_PURCHASEREQUEST' table. You can move, or remove it, as needed.
        Me.TblM4_PURCHASEREQUESTTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLG3_UNITS' table. You can move, or remove it, as needed.
        Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM' table. You can move, or remove it, as needed.
        'Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.VWG3_PRIMARY_SIGNATORY' table. You can move, or remove it, as needed.
        Me.VWG3_PRIMARY_SIGNATORYTableAdapter.Fill(Me.DS_PROPERTYDB.VWG3_PRIMARY_SIGNATORY)

        NotificationManager.Show(Me, "Default Signatory has been update.", Color.Green, 3000)
    End Sub
#End Region

    Private Sub DGV_PR_ITEMLIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PR_ITEMLIST.CellContentClick
        '   Dim dgv = DirectCast(sender, DataGridView)
        Dim dgv1 = CType(sender, DataGridView)
        If dgv1 Is DGV_PR_ITEMLIST Then
            If dgv1.ColumnCount = 8 AndAlso e.ColumnIndex = 7 Then
                If MsgBox("REMOVE THIS?", vbYesNo, "CONFIRM") = vbYes Then
                    dgv1.Rows.RemoveAt(e.RowIndex)
                End If
            ElseIf dgv1.ColumnCount = 8 AndAlso e.ColumnIndex = 6 Then
                If MsgBox("UPDATE THIS?", vbYesNo, "CONFIRM") = vbYes Then
                    FRM_DGV_ENCODING.WTXT_DESCRIPTION.Text = dgv1.Rows(e.RowIndex).Cells(0).Value.ToString
                    FRM_DGV_ENCODING.WTXT_QUANTITY.Text = dgv1.Rows(e.RowIndex).Cells(1).Value.ToString
                    FRM_DGV_ENCODING.CB_UNITOFISSUE.Text = dgv1.Rows(e.RowIndex).Cells(2).Value.ToString
                    FRM_DGV_ENCODING.WTXT_STOCKNO.Text = dgv1.Rows(e.RowIndex).Cells(3).Value.ToString
                    FRM_DGV_ENCODING.WTXT_ESTIMATEDUNITCOST.Text = dgv1.Rows(e.RowIndex).Cells(4).Value.ToString
                    FRM_DGV_ENCODING.WTXT_ESTIMATEDCOST.Text = dgv1.Rows(e.RowIndex).Cells(5).Value.ToString
                    FRM_DGV_ENCODING.BTN_SAVE.Text = "UPDATE"
                    FRM_DGV_ENCODING.ShowDialog()
                End If
            End If

        End If

    End Sub

    Private Sub CB_PRDEPARTMENT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PRDEPARTMENT.SelectedIndexChanged
        If CB_PRDEPARTMENT.Text.Length <> 0 Then
            Me.TblV1_HRISDIVISIONTableAdapter.FillByDEPTCODE(Me.DS_TABLES.tblV1_HRISDIVISION, CB_PRDEPARTMENT.SelectedValue)
        End If
    End Sub

    Private Sub LLBL_PRNEW_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLBL_PRNEW.LinkClicked

    End Sub
End Class