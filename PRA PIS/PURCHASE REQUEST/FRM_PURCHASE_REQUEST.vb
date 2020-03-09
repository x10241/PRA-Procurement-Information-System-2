Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_PURCHASE_REQUEST


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
        'TODO: This line of code loads data into the 'DSPROPERTYDB_TABLES.VWG3_PRIMARY_SIGNATORY' table. You can move, or remove it, as needed.
        'Me.VWG3_PRIMARY_SIGNATORYTableAdapter.Fill(Me.DSPROPERTYDB_TABLES.VWG3_PRIMARY_SIGNATORY)
        'TODO: This line of code loads data into the 'DSPROPERTYDB_TABLES.VWG3_PRIMARY_SIGNATORY' table. You can move, or remove it, as needed.
        '  Me.VWG3_PRIMARY_SIGNATORYTableAdapter.Fill(Me.DSPROPERTYDB_TABLES.VWG3_PRIMARY_SIGNATORY)
        '   Me.TBLG3_SIGNATORYTableAdapter.Fill(Me.DSPROPERTYDB_TABLES.TBLG3_SIGNATORY)
        'TODO: This line of code loads data into the 'DSPROPERTYDB_TABLES.TBLG3_UNITS' table. You can move, or remove it, as needed.
        '     Me.TBLG3_UNITSTableAdapter.Fill(Me.DSPROPERTYDB_TABLES.TBLG3_UNITS)


        _DISABLE(True)
    End Sub
#End Region

    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function

    Private Sub WTXT_PRNO_TextChanged(sender As Object, e As EventArgs) Handles WTXT_PRNO.TextChanged
        PBOX_PRNOQRCODE.BackgroundImage = QRCODEGenerator(WTXT_PRNO.Text)
    End Sub

#Region "BUTTON/TEXTBOX CLICK"
    Private Sub WTXT_REQUESTEDDATE_Click(sender As Object, e As EventArgs) Handles WTXT_REQUESTEDDATE.Click,
                                                                                    WTXT_REQUESTEDDATE.Enter,
                                                                                    RECT_PRSAVENEW.Click,
                                                                                    RECT_PRCANCELEDIT.Click,
                                                                                    PB_PRICONNEW.Click,
                                                                                    PB_PBICONEDIT.Click,
                                                                                    PB_PRICONSEARCH.Click,
                                                                                    PB_PRICONSAVE.Click,
                                                                                    PB_PRICONPRINTPREVIEW.Click,
                                                                                    BTN_Minimize.Click,
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
                                                                                    LLBL_PRPRINTPREVIEW.Click

        Dim pb As PictureBox = Nothing
        Dim lbl As Label = Nothing
        Dim btn As Button = Nothing
        llbl = Nothing
        rect = Nothing
        TXTGLOBAL = Nothing

        If TypeOf sender Is LinkLabel Then
            llbl = DirectCast(sender, LinkLabel)
        ElseIf TypeOf sender Is RectangleShape Then
            rect = DirectCast(sender, RectangleShape)
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
            TXTGLOBAL = CType(sender, TextBox)
            FRM_SIGNATORYLIST.ShowDialog()
            'NEW BUTTON
        ElseIf pb Is PB_PRICONNEW Or llbl Is LLBL_PRNEW Then
            _CLEAR()
            _DISABLE(False)
            DGV_PR_ITEMLIST.AllowUserToAddRows = True
            isNew = True
            WTXT_DEPARTMENT.Text = USERDEPARTMENT
            WTXT_DIVISION.Text = USERDIVISION
            GET_PRI_SIGNATORY()
            'EDIT BUTTON
        ElseIf pb Is PB_PBICONEDIT Or lbl Is LLBL_PREDIT Or llbl Is LLBL_PREDIT Then
            'If DGV_PRLIST.SelectedRows.Count > 0 Then
            '    _DISABLE(False)
            '    PB_PRICONSAVE.BringToFront()
            '    PB_PRICONCANCEL.BringToFront()
            '    LLBL_PRSAVE.BringToFront()
            '    LLBL_PRCANCEL.Visible = True
            '    PB_PRICONCANCEL.Location = New Point(600, 14)
            '    RECT_PRCANCELEDIT.Size = New Point(111, 39)
            '    DGV_PR_ITEMLIST.AllowUserToAddRows = True
            '    isNew = False
            'Else
            '    NotificationManager.Show(Me, "PLEASE SELECT PR NO. IN PURCHASE REQUEST LIST!", Color.Red, 3000)
            'End If
            'CANCEL Button
        ElseIf pb Is PB_PRICONCANCEL Or llbl Is LLBL_PRCANCEL Then
            If MsgBox("Do you really want to cancel this request?", vbYesNo, "Confirm") = vbYes Then
                _DISABLE(True)
                _CLEAR()
                LLBL_PRNEW.BringToFront()
                DGV_PR_ITEMLIST.DataSource = TblM4PURCHASEREQUESTITEMBindingSource
                '       DGV_PRLIST.ClearSelection()
            End If
            'SAVE BUTTON
        ElseIf pb Is PB_PRICONSAVE Or llbl Is LLBL_PRSAVE Or lbl Is LLBL_PRSAVE Then

            'PR NO VALIDATION
            If REQFIELDVALIDATION(WTXT_PRNO) Then
                RECT_PRPRNO.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_PRPRNO.BorderColor = Color.LightSeaGreen
                ISVALID = True
            End If

            'REQUESTED DATE VALIDATION
            If REQFIELDVALIDATION(WTXT_REQUESTEDDATE) Then
                RECT_PRREQUESTEDDATE.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_PRREQUESTEDDATE.BorderColor = Color.LightSeaGreen
                ISVALID = True
            End If

            'PURPOSE VALIDATION
            If REQFIELDVALIDATION(WTXT_PURPOSE) Then
                RECT_PRPURPOSE.BorderColor = Color.OrangeRed
                ISVALID = False
            Else
                RECT_PRPURPOSE.BorderColor = Color.LightSeaGreen
                ISVALID = True
            End If

            'if all required fields are filled up.
            If ISVALID Then
                If MsgBox("Submit this request?", vbYesNo, "Confirm") = vbYes Then
                    _SAVE()
                    _DISABLE(True)
                    _CLEAR()
                    RECT_PRSAVENEW.Enabled = True
                    PB_PRICONNEW.Enabled = True
                    LLBL_PRNEW.Enabled = True
                    PB_PRICONNEW.BringToFront()
                    PB_PBICONEDIT.BringToFront()
                    PB_PRICONSAVE.SendToBack()
                    PB_PRICONCANCEL.SendToBack()
                    '   LLBL_PRSAVE.SendToBack()
                    LLBL_PRNEW.BringToFront()
                    DGV_PR_ITEMLIST.DataSource = Nothing
                    DGV_PR_ITEMLIST.DataSource = TblM4PURCHASEREQUESTITEMBindingSource
                    ' DGV_PR_ITEMLIST.Rows.Clear()
                    ISVALID = False
                End If
            Else
                NotificationManager.Show(Me, "PLEASE PROVIDE ALL REQUIRED FIELD!", Color.Red, 3000)
            End If
            'CLOSE BUTTON
        ElseIf btn Is BTN_CLOSE Then
            Me.Close()
            'MINIMIZE BUTTON
        ElseIf btn Is BTN_Minimize Then
            Me.WindowState = FormWindowState.Minimized
            'SEARCH 
            'ElseIf pb Is PBICONSEARCH Then
            '    SQDGV_PURCHASEREQUESTTableAdapter.Fillby_Search(DSPROPERTYDB_TABLES.SQDGV_PURCHASEREQUEST, WTXT_SEARCHPR.Text)
            '    DGV_PRLIST.ClearSelection()
            'SEARCH BUTTON
        ElseIf llbl Is LLBL_PRSEARCH Or pb Is PB_PRICONSEARCH Then
            FRM_SEARCHPRLIST.ShowDialog()
        ElseIf llbl Is LLBL_PRPRINTPREVIEW Or pb Is PB_PRICONPRINTPREVIEW Then
            PREVIEW()
        End If
    End Sub
#End Region

#Region "Hover BUTTON/PB/LLBL"

#End Region

#Region "PRINT PREVIEW"
    Sub PREVIEW()
        dgv = DGV_PR_ITEMLIST
        pr_NO = WTXT_PRNO.Text
        PR_DATEREQUESTED = WTXT_REQUESTEDDATE.Text
        PR_APPCODE = WTXT_APPCODE.Text
        PR_DEPARTMENT = WTXT_DEPARTMENT.Text
        PR_DIVISION = WTXT_DIVISION.Text
        PR_PURPOSE = WTXT_PURPOSE.Text
        PR_REQUESTEDBY = WTXT_SIGNREQUESTEDNAME.Text
        PR_REQUESTEDBYPOSITION = WTXT_SIGNREQUESTEDPOSITION.Text
        PR_APPROVEDBY = WTXT_SIGNAPPROVENAME.Text
        PR_APPROVEDBYPOSITION = WTXT_SIGNAPPROVEPOSITION.Text
        PR_CERTIFIEDBY = WTXT_SIGNCERTIFIEDNAME.Text
        PR_CERTIFIEDBYPOSITION = WTXT_SIGNAPPROVEPOSITION.Text
        PR_NOTEDBY = WTXT_SIGNNOTEDNAME.Text
        PR_NOTEDBYPOSITION = WTXT_SIGNNOTEDPOSITION.Text
        FRM_PURCHASE_REQUEST_PRINTPREVIEW.ShowDialog()
    End Sub
#End Region

#Region "COLOR"
    Private Sub DGV_PRLIST_RowPrePaint_1(sender As Object, e As DataGridViewRowPrePaintEventArgs)

    End Sub
#End Region

#Region "DISABLE/ENABLE"
    Private Sub _DISABLE(ByVal disable As Boolean)
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
        End If
    End Sub
#End Region

#Region "CLEAR"
    Sub _CLEAR()
        WTXT_APPCODE.Clear()
        WTXT_APPROVEDBY.Clear()
        WTXT_DEPARTMENT.Clear()
        WTXT_DIVISION.Clear()
        WTXT_PRNO.Clear()
        WTXT_PURPOSE.Clear()
        WTXT_REQUESTEDBY.Clear()
        WTXT_REQUESTEDDATE.Clear()
        '  WTXT_SEARCHPR.Clear()
        DGV_PR_ITEMLIST.DataSource = Nothing
        RECT_PRPURPOSE.BorderColor = Color.LightSeaGreen
        RECT_PRPRNO.BorderColor = Color.LightSeaGreen
        RECT_PRREQUESTEDDATE.BorderColor = Color.LightSeaGreen
    End Sub

#End Region

#Region "SAVE"
    Sub _SAVE()
        Try
            'check if request is new
            If isNew Then
                'TblM4_PURCHASEREQUESTTableAdapter.IQ_PURCHASE_REQUEST(Trim(WTXT_PRNO.Text), Trim(WTXT_REQUESTEDDATE.Text), Trim(WTXT_APPCODE.Text), Trim(WTXT_PURPOSE.Text), 4, Trim(WTXT_SIGNREQUESTEDNAME.Text), Trim(WTXT_SIGNREQUESTEDPOSITION.Text), Trim(WTXT_SIGNAPPROVENAME.Text), Trim(WTXT_SIGNAPPROVEPOSITION.Text), Trim(WTXT_SIGNCERTIFIEDNAME.Text), Trim(WTXT_SIGNCERTIFIEDPOSITION.Text), Trim(WTXT_SIGNNOTEDNAME.Text), Trim(WTXT_SIGNNOTEDPOSITION.Text), Trim(EMP_NO), Trim(WTXT_DEPARTMENT.Text), Trim(WTXT_DIVISION.Text), IMGTOBYTE(PBOX_PRNOQRCODE))
                For Each row As DataGridViewRow In DGV_PR_ITEMLIST.Rows
                    If Not row.IsNewRow Then
                        '  TblM4_PURCHASEREQUEST_ITEMTableAdapter.IQ_PR_ITEMS()
                        '          TblM4_PURCHASEREQUEST_ITEMTableAdapter.IQ_PR_ITEMS(WTXT_PRNO.Text, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(0).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString)
                    End If
                Next
                MsgBox("Successfully submit!", MsgBoxStyle.Information, "Saved")
                'if for updating
                'Else
                '    MsgBox("Successfully submit!", MsgBoxStyle.Information, "Saved")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region


#Region "GET PRIMARY SIGNATORY"
    Sub GET_PRI_SIGNATORY()
        Try
           ' VWG3_PRIMARY_SIGNATORYTableAdapter.FillBy_HRIS_EMPNO_USER(DSPROPERTYDB_TABLES.VWG3_PRIMARY_SIGNATORY, EMP_NO)
            WTXT_SIGNREQUESTEDNAME.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 0, 9)
            WTXT_SIGNREQUESTEDPOSITION.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 0, 0)

            WTXT_SIGNAPPROVENAME.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 1, 9)
            WTXT_SIGNAPPROVEPOSITION.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 1, 0)

            WTXT_SIGNCERTIFIEDNAME.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 2, 9)
            WTXT_SIGNCERTIFIEDPOSITION.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 2, 0)

            WTXT_SIGNNOTEDNAME.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 3, 9)
            WTXT_SIGNNOTEDPOSITION.Text = BS(VWG3_PRIMARY_SIGNATORYBindingSource, 3, 0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub DGV_PRLIST_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            WTXT_PRNO.Text = SQDGV_PURCHASEREQUESTDataGridView.Rows(e.RowIndex).Cells(0).Value
            WTXT_REQUESTEDDATE.Text = SQDGV_PURCHASEREQUESTDataGridView.Rows(e.RowIndex).Cells(1).Value
            WTXT_APPCODE.Text = SQDGV_PURCHASEREQUESTDataGridView.Rows(e.RowIndex).Cells(3).Value
            WTXT_PURPOSE.Text = SQDGV_PURCHASEREQUESTDataGridView.Rows(e.RowIndex).Cells(4).Value
            '     TblM4_PURCHASEREQUEST_ITEMTableAdapter.FillBy(DSPROPERTYDB_TABLES.tblM4_PURCHASEREQUEST_ITEM, WTXT_PRNO.Text)
            DGV_PR_ITEMLIST.AllowUserToAddRows = False
            DGV_PR_ITEMLIST.ClearSelection()
        End If
    End Sub

    Private Sub DGV_PR_ITEMLIST_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGV_PR_ITEMLIST.CellValidating
        'If (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
        '    NotificationManager.Show(Me, "Item Description is required.", Color.Red, 3000)
        '    e.Cancel = True
        'End If
    End Sub



End Class