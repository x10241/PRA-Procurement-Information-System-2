Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_CHECK_PR


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

    Private WithEvents UCPROCTim As New Timer With {.Interval = 10}

    Public Sub Tim_Tick(sender As Object, e As EventArgs) Handles UCPROCTim.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTim Then
            Try
                If slideFlaG = True Then
                    X_LOC -= 100
                    PNL_SLIDE.Location = New Point(X_LOC, 0)
                    If PNL_SLIDE Is APNL_VALIDATEPR Then
                        If X_LOC < 0 Then
                            PNL_SLIDE.Location = New Point(0, 0)
                            X_LOC = 0
                            UCPROCTim.Enabled = False
                        End If
                    End If
                Else
                    X_LOC += 100
                    PNL_SLIDE.Location = New Point(X_LOC, 0)
                    If PNL_SLIDE Is APNL_VALIDATEPR Then
                        If X_LOC > 1095 Then
                            PNL_SLIDE.Location = New Point(1095, 0)
                            X_LOC = 1095
                            UCPROCTim.Enabled = False
                        End If
                    End If
                End If
            Catch ex As Exception
                X_LOC = 0
            End Try
        End If
    End Sub

    Private Sub BTN_PRCLOSE_Click(sender As Object, e As EventArgs) Handles BTN_PRCLOSE.Click,
                                                                             BTN_PRMINIMIZE.Click,
                                                                             BTN_CPR_ACCEPT.Click,
                                                                             BTN_CPR_CANCEL.Click,
                                                                             BTN_CPR_FORREVISION.Click,
                                                                             PB_VALIDATE_PR.Click,
                                                                             LLBL_VALIDATE_PR.Click,
                                                                             BTN_CLOSE_VALIDATEPR_MINI_CLOSE.Click,
                                                                             PB_VALIDATE_PR_VIEW_REPORT.Click,
                                                                             LLBL_VALIDATE_PR_VIEW_REPORT.Click,
                                                                             BTN_INMA_CLOSE.Click,
                                                                             BTN_INMA_MINIMIZE.Click,
                                                                             LLBL_VALIDATE_PRPREVIEW.Click,
                                                                             PB_VALIDATE_PRPREVIEW.Click,
                                                                             PB_CLEARSEARCH.Click


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

        If btn Is BTN_PRMINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
        ElseIf btn Is BTN_PRCLOSE Then
            Me.Close()

#Region "Accept"
        ElseIf btn Is BTN_CPR_ACCEPT Then
            PRNO = WTXT_SEARCHPR.Text
            ISVALID = True
            If Trim(WTXT_APPCODE.Text.Length) > 0 Then
                ISVALID = True
                RECT_PRAPPCODE.BorderColor = Color.LightSeaGreen
            Else
                ISVALID = False
                RECT_PRAPPCODE.BorderColor = Color.Red
            End If

            If ISVALID Then
                If MsgBox("Are you sure you want to accept this?" & vbCrLf & "You can't undo this action.", vbYesNo, "Please confirm the details in purchase request info.") = vbYes Then
                    PR_APPCODE = Trim(WTXT_APPCODE.Text)
                    FRM_PRACCEPT.ShowDialog()
                    SPM4_PMDPRLISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_PMDPRLIST, WTXT_SEARCHLIST_PR.Text)
                    LBL_TOTALNOOFPR.Text = DGV_PRLIST.Rows.Count
                End If
            Else
                NotificationManager.Show(Me, "Please check APP CODE value!", Color.Red, 4000)
            End If


#End Region

#Region "Cancel PR"
        ElseIf btn Is BTN_CPR_CANCEL Then
            PRNO = WTXT_SEARCHPR.Text
            If MsgBox("Are you sure you want to cancel this PR?" & vbCrLf & "You can't undo this action.", vbYesNo, "Confimation") = vbYes Then
                PR_APPCODE = Trim(WTXT_APPCODE.Text)
                FRM_PRCANCELED.ShowDialog()
                WTXT_SEARCHPR.Clear()
                SPM4_PMDPRLISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_PMDPRLIST, WTXT_SEARCHLIST_PR.Text)
                LBL_TOTALNOOFPR.Text = DGV_PRLIST.Rows.Count
            End If
#End Region

#Region "Validate PR"
        ElseIf pb Is PB_VALIDATE_PR Or llbl Is LLBL_VALIDATE_PR Then
            _CLEAR()
            UCPROCTim.Enabled = True
            slideFlaG = True
            PNL_SLIDE = APNL_VALIDATEPR
            PNL_SLIDE.BringToFront()
            WTXT_SEARCHPR.Focus()
            WTXT_SEARCHPR.SelectAll()
#End Region

#Region "Close Slide"
        ElseIf btn Is BTN_CLOSE_VALIDATEPR_MINI_CLOSE Then
            UCPROCTim.Enabled = True
            slideFlaG = False
#End Region

#Region "View Report"
        ElseIf pb Is PB_VALIDATE_PRPREVIEW Or llbl Is LLBL_VALIDATE_PRPREVIEW Then
            PRNO_GEN = WTXT_SEARCHPR.Text
            REPRINT = True
            dgv = DGV_PR_ITEMLIST
            PR_DATEREQUESTED = WTXT_REQUESTEDDATE.Text
            PR_APPCODE = WTXT_APPCODE.Text
            PR_PURPOSE = WTXT_PURPOSE.Text
            PR_REQUESTEDBY = ""
            PR_REQUESTEDBYPOSITION = ""
            PR_APPROVEDBY = ""
            PR_APPROVEDBYPOSITION = ""
            PR_CERTIFIEDBY = ""
            PR_CERTIFIEDBYPOSITION = ""
            PR_NOTEDBY = ""
            PR_NOTEDBYPOSITION = ""
            PR_DEPARTMENT = WTXT_DEPARTMENT.Text
            PR_DIVISION = WTXT_DIVISION.Text
            If LBL_SIGN.Text = "Php" Then
                ISDOLLARS = 0
            Else
                ISDOLLARS = 1
            End If
            FRM_PURCHASE_REQUEST_PRINTPREVIEW.ShowDialog()
#End Region

#Region "Minimize"
        ElseIf btn Is BTN_INMA_MINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
#End Region

#Region "Close"
        ElseIf btn Is BTN_INMA_CLOSE Then
            Me.Close()
#End Region

#Region "Clear Search"
        ElseIf pb Is PB_CLEARSEARCH Then
            WTXT_SEARCHLIST_PR.Clear()
#End Region

        End If
    End Sub

#Region "CLEAR"
    Sub _CLEAR()
        WTXT_APPCODE.Clear()
        WTXT_REQUESTEDDATE.Clear()
        WTXT_SUBMITTEDBY.Clear()
        WTXT_DEPARTMENT.Clear()
        WTXT_DIVISION.Clear()
        WTXT_PURPOSE.Clear()
        BTN_CPR_ACCEPT.Enabled = False
        BTN_CPR_CANCEL.Enabled = False
        LLBL_VALIDATE_PRPREVIEW.Enabled = False
        PB_VALIDATE_PRPREVIEW.Enabled = False
        WTXT_SEARCHPR.Clear()
        DGV_PR_ITEMLIST.Rows.Clear()
    End Sub
#End Region

#Region "KEY EVENT"

    Private Sub WTXT_SEARCHPR_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles WTXT_SEARCHPR.KeyDown
        If e.KeyCode = Keys.Enter Then
            isValidPRNO = True
            BTN_CPR_ACCEPT.Enabled = False
            BTN_CPR_CANCEL.Enabled = False
            BTN_CPR_FORREVISION.Enabled = False
            DGV_PR_ITEMLIST.Rows.Clear()
            LLBL_TOTALESTIMATEDCOST.Text = "0.00"
            TblM4_PURCHASEREQUESTTableAdapter.FillByPRNO(DS_PROPERTYDB.tblM4_PURCHASEREQUEST, WTXT_SEARCHPR.Text)
            TblM4_PURCHASEREQUEST_ITEMTableAdapter.FillByTRANSCODE(DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM, WTXT_SEARCHPR.Text)
            'CHECK IF PR EXIST
            If DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows.Count > 0 Then
                WTXT_SUBMITTEDBY.Text = TblV1_HRISEMPLOYEEDATATableAdapter.SQ_GETFULLNAME(DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(13).ToString())
                WTXT_DEPARTMENT.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(14).ToString()
                WTXT_DIVISION.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(15).ToString()
                WTXT_PURPOSE.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(3).ToString()
                WTXT_APPCODE.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(2).ToString()
                PR_STATUS = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(4)
                Dim dt As DateTime = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(1).ToString()
                WTXT_REQUESTEDDATE.Text = dt.ToString("MMM dd, yyyy")
                'if dollar
                If DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(18) = True Then
                    LBL_SIGN.Text = "$"
                    'if peso
                Else
                    LBL_SIGN.Text = "Php"
                End If
            Else
                isValidPRNO = False
            End If

            If DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM.Rows.Count > 0 Then
                Dim totalEstimatedCost As Decimal = 0.00
                Dim hestiunitcost As Decimal = 0.00
                Dim hesticost As Decimal = 0.00
                For Each row As DataRow In DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM.Rows
                    If IsDBNull(row.Item(4)) Then
                        row.Item(4) = 0.00
                    End If

                    If IsDBNull(row.Item(5)) Then
                        row.Item(5) = 0.00
                    End If
                    hestiunitcost = row.Item(4)
                    hesticost = row.Item(5)
                    DGV_PR_ITEMLIST.Rows.Add(row.Item(2), row.Item(0), row.Item(1), row.Item(3), hestiunitcost.ToString("N2"), hesticost.ToString("N2"))
                    totalEstimatedCost += row.Item(5)
                Next row
                LLBL_TOTALESTIMATEDCOST.Text = totalEstimatedCost.ToString("N2")
            Else
                isValidPRNO = False
            End If
            'CHECK IF PR EXIST (END)

            'if exist but ACCEPTED,REVISED OR CANCELED
            If isValidPRNO Then
                If PR_STATUS = 1 Then
                    NotificationManager.Show(Me, "PR NO. HAS ALREADY BEEN ACCEPTED!", Color.Red, 3000)
                    'ElseIf PR_STATUS = 2 Then
                    '    NotificationManager.Show(Me, "PR NO. HAS ALREADY BEEN SET FOR REVISION!", Color.Red, 4000)
                ElseIf PR_STATUS = 3 Then
                    NotificationManager.Show(Me, "PR NO. HAS ALREADY BEEN CANCELED!", Color.Red, 3000)
                ElseIf PR_STATUS = 4 Then
                    BTN_CPR_ACCEPT.Enabled = True
                    BTN_CPR_CANCEL.Enabled = True
                    BTN_CPR_FORREVISION.Enabled = True
                    LLBL_VALIDATE_PRPREVIEW.Enabled = True
                    PB_VALIDATE_PRPREVIEW.Enabled = True
                    WTXT_APPCODE.SelectAll()
                End If
            Else
                WTXT_SUBMITTEDBY.Clear()
                WTXT_DEPARTMENT.Clear()
                WTXT_DIVISION.Clear()
                WTXT_PURPOSE.Clear()
                WTXT_APPCODE.Clear()
                WTXT_REQUESTEDDATE.Clear()
                PR_STATUS = Nothing
                BTN_CPR_ACCEPT.Enabled = False
                BTN_CPR_CANCEL.Enabled = False
                BTN_CPR_FORREVISION.Enabled = False
                LLBL_VALIDATE_PRPREVIEW.Enabled = False
                PB_VALIDATE_PRPREVIEW.Enabled = False
                NotificationManager.Show(Me, "NO DATA FOUND!", Color.Red, 3000)
            End If
        End If
    End Sub

    Private Sub WTXT_SEARCHLIST_PR_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_SEARCHLIST_PR.KeyDown
        If e.KeyCode = Keys.Enter Then
            WTXT_SEARCHPR.Clear()
            SPM4_PMDPRLISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_PMDPRLIST, WTXT_SEARCHLIST_PR.Text)
            LBL_TOTALNOOFPR.Text = DGV_PRLIST.Rows.Count
        End If
    End Sub

#End Region

#Region "LOAD"
    Private Sub FRM_CHECK_PR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WTXT_SEARCHPR.Clear()
        SPM4_PMDPRLISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_PMDPRLIST, WTXT_SEARCHLIST_PR.Text)
        LBL_TOTALNOOFPR.Text = DGV_PRLIST.Rows.Count
    End Sub
#End Region

#Region "CELL PAINT"
    Private Sub DGV_PRLIST_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DGV_PRLIST.RowPrePaint
        If Not IsDBNull(DGV_PRLIST(1, e.RowIndex).Value) Then
            If DGV_PRLIST(1, e.RowIndex).Value = 1 Then
                DGV_PRLIST(1, e.RowIndex).Style.BackColor = Color.LimeGreen
                DGV_PRLIST(1, e.RowIndex).Style.ForeColor = Color.LimeGreen
                '     DGV_PRLIST(1, e.RowIndex).Value = Nothing
                '  stats = 1
                'ElseIf DGV_PRLIST(1, e.RowIndex).Value = 2 Then
                '    DGV_PRLIST(1, e.RowIndex).Style.BackColor = Color.Red
                '    DGV_PRLIST(1, e.RowIndex).Style.ForeColor = Color.Red
                '    '   DGV_PRLIST(1, e.RowIndex).Value = Nothing
                '    '  stats = 2
            ElseIf DGV_PRLIST(1, e.RowIndex).Value = 3 Then
                DGV_PRLIST(1, e.RowIndex).Style.BackColor = Color.Red
                DGV_PRLIST(1, e.RowIndex).Style.ForeColor = Color.Red
                '  DGV_PRLIST(1, e.RowIndex).Value = Nothing
                '  stats = 3
            ElseIf DGV_PRLIST(1, e.RowIndex).Value = 4 Then
                DGV_PRLIST(1, e.RowIndex).Style.BackColor = Color.DimGray
                DGV_PRLIST(1, e.RowIndex).Style.ForeColor = Color.DimGray
                '  DGV_PRLIST(1, e.RowIndex).Value = Nothing
                '   stats = 4
            End If
        End If

        If Not IsDBNull(DGV_PRLIST(0, e.RowIndex).Value) Then
            If DGV_PRLIST(0, e.RowIndex).Value = String.Empty Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.DimGray
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.DimGray
                '   DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "1" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.CornflowerBlue
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.CornflowerBlue
                '   DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "2" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.DarkOrange
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.DarkOrange
                '   DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "3" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.MediumOrchid
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.MediumOrchid
                '   DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "4" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.HotPink
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.HotPink
                '    DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "5" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.MediumTurquoise
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.MediumTurquoise
                '    DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "6" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.Blue
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.Blue
                '   DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "7" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.OrangeRed
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.OrangeRed
                '  DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "8" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.SpringGreen
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.SpringGreen
                '   DGV_PRLIST(0, e.RowIndex).Value = Nothing
            End If
        End If
    End Sub

#End Region

#Region "CELL EVENT"
    Private Sub DGV_PRLIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PRLIST.CellContentClick
        If DGV_PRLIST.SelectedRows.Count >= 0 Then
            If e.RowIndex >= 0 Then
                Dim row As New DataGridViewRow()
                row = DGV_PRLIST.Rows(e.RowIndex)
#Region "View Details"
                If TypeOf DGV_PRLIST.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
                  e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then



#End Region

#Region "Update Status"
                ElseIf TypeOf DGV_PRLIST.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
                  e.RowIndex >= 0 AndAlso e.ColumnIndex = 6 Then
                    'PENDING
                    If DGV_PRLIST.Rows(e.RowIndex).Cells(1).Value = "4" Then
                        If MsgBox("Current PR has not been accepted, do you want to process this PR?", vbYesNo, "Update PR Status") = vbYes Then
                            BTN_PRCLOSE_Click(LLBL_VALIDATE_PR, e)
                            WTXT_SEARCHPR.Text = DGV_PRLIST.Rows(e.RowIndex).Cells(2).Value
                            PBICONSEARCH_Click(PBICONSEARCH, e)
                        End If
                        'ACCEPTED
                    ElseIf DGV_PRLIST.Rows(e.RowIndex).Cells(1).Value = "1" Then
                        PRNO = DGV_PRLIST.Rows(e.RowIndex).Cells(2).Value
                        FRM_UPDATE_PR_STATUS.ShowDialog()
                    End If
#End Region
                End If
            End If
        End If
    End Sub
#End Region

    Private Sub PBICONSEARCH_Click(sender As Object, e As EventArgs) Handles PBICONSEARCH.Click
        isValidPRNO = True
        BTN_CPR_ACCEPT.Enabled = False
        BTN_CPR_CANCEL.Enabled = False
        BTN_CPR_FORREVISION.Enabled = False
        DGV_PR_ITEMLIST.Rows.Clear()
        LLBL_TOTALESTIMATEDCOST.Text = "0.00"
        TblM4_PURCHASEREQUESTTableAdapter.FillByPRNO(DS_PROPERTYDB.tblM4_PURCHASEREQUEST, WTXT_SEARCHPR.Text)
        TblM4_PURCHASEREQUEST_ITEMTableAdapter.FillByTRANSCODE(DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM, WTXT_SEARCHPR.Text)
        'CHECK IF PR EXIST
        If DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows.Count > 0 Then
            WTXT_SUBMITTEDBY.Text = TblV1_HRISEMPLOYEEDATATableAdapter.SQ_GETFULLNAME(DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(13).ToString())
            WTXT_DEPARTMENT.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(14).ToString()
            WTXT_DIVISION.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(15).ToString()
            WTXT_PURPOSE.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(3).ToString()
            WTXT_APPCODE.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(2).ToString()
            PR_STATUS = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(4)
            Dim dt As DateTime = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(1).ToString()
            WTXT_REQUESTEDDATE.Text = dt.ToString("MMM dd, yyyy")
            'if dollar
            If DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(18) = True Then
                LBL_SIGN.Text = "$"
                'if peso
            Else
                LBL_SIGN.Text = "Php"
            End If
        Else
            isValidPRNO = False
        End If

        If DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM.Rows.Count > 0 Then
            Dim totalEstimatedCost As Decimal = 0.00
            Dim hestiunitcost As Decimal = 0.00
            Dim hesticost As Decimal = 0.00
            For Each row As DataRow In DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM.Rows
                If IsDBNull(row.Item(4)) Then
                    row.Item(4) = 0.00
                End If

                If IsDBNull(row.Item(5)) Then
                    row.Item(5) = 0.00
                End If
                hestiunitcost = row.Item(4)
                hesticost = row.Item(5)
                DGV_PR_ITEMLIST.Rows.Add(row.Item(2), row.Item(0), row.Item(1), row.Item(3), hestiunitcost.ToString("N2"), hesticost.ToString("N2"))
                totalEstimatedCost += row.Item(5)
            Next row
            LLBL_TOTALESTIMATEDCOST.Text = totalEstimatedCost.ToString("N2")
        Else
            isValidPRNO = False
        End If
        'CHECK IF PR EXIST (END)

        'if exist but ACCEPTED,REVISED OR CANCELED
        If isValidPRNO Then
            If PR_STATUS = 1 Then
                NotificationManager.Show(Me, "PR NO. HAS ALREADY BEEN ACCEPTED!", Color.Red, 3000)
                'ElseIf PR_STATUS = 2 Then
                '    NotificationManager.Show(Me, "PR NO. HAS ALREADY BEEN SET FOR REVISION!", Color.Red, 4000)
            ElseIf PR_STATUS = 3 Then
                NotificationManager.Show(Me, "PR NO. HAS ALREADY BEEN CANCELED!", Color.Red, 3000)
            ElseIf PR_STATUS = 4 Then
                BTN_CPR_ACCEPT.Enabled = True
                BTN_CPR_CANCEL.Enabled = True
                BTN_CPR_FORREVISION.Enabled = True
                LLBL_VALIDATE_PRPREVIEW.Enabled = True
                PB_VALIDATE_PRPREVIEW.Enabled = True
                WTXT_APPCODE.SelectAll()
            End If
        Else
            WTXT_SUBMITTEDBY.Clear()
            WTXT_DEPARTMENT.Clear()
            WTXT_DIVISION.Clear()
            WTXT_PURPOSE.Clear()
            WTXT_APPCODE.Clear()
            WTXT_REQUESTEDDATE.Clear()
            PR_STATUS = Nothing
            BTN_CPR_ACCEPT.Enabled = False
            BTN_CPR_CANCEL.Enabled = False
            BTN_CPR_FORREVISION.Enabled = False
            LLBL_VALIDATE_PRPREVIEW.Enabled = False
            PB_VALIDATE_PRPREVIEW.Enabled = False
            NotificationManager.Show(Me, "NO DATA FOUND!", Color.Red, 3000)
        End If
    End Sub

End Class