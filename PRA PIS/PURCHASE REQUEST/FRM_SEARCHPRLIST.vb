
Imports System.Windows.Forms.VisualStyles

Public Class FRM_SEARCHPRLIST
    Dim stats As String

    Private WithEvents UCPROCTim As New Timer With {.Interval = 10}

    Private Sub Tim_Tick(sender As Object, e As EventArgs) Handles UCPROCTim.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTim Then
            Try
                If slideFlaG = True Then
                    X_LOC -= 100
                    PNL_SLIDE.Location = New Point(X_LOC, 40)
                    If PNL_SLIDE Is APNL_REQUEST_STATUS Then
                        If X_LOC < 680 Then
                            PNL_SLIDE.Location = New Point(680, 40)
                            X_LOC = 680
                            UCPROCTim.Enabled = False
                        End If
                    End If
                Else
                    X_LOC += 100
                    PNL_SLIDE.Location = New Point(X_LOC, 40)
                    If PNL_SLIDE Is APNL_REQUEST_STATUS Then
                        If X_LOC > 1095 Then
                            PNL_SLIDE.Location = New Point(1095, 40)
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


    Private Sub FRM_SEARCHPRLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CB_PRLISTSTATUS.SelectedIndex = 4
        Me.TblM4_PURCHASEREQUESTTableAdapter.FillBySubmittedUser(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO)

        Me.SPM4_PURCHASELISTTableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_PURCHASELIST, WTXT_SEARCHPR.Text, EMP_NO, False)
        LBL_TOTALNOOFPR.Text = DGV_PRLIST.Rows.Count



    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub WTXT_SEARCHPR_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCHPR.TextChanged
        'If CB_PRLISTSTATUS.SelectedIndex = 0 Then
        '    stats = 1
        '    Me.TblM4_PURCHASEREQUESTTableAdapter.FillBySubmittedAndPRNOStatus(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, stats, WTXT_SEARCHPR.Text)
        'ElseIf CB_PRLISTSTATUS.SelectedIndex = 1 Then
        '    stats = 2
        '    Me.TblM4_PURCHASEREQUESTTableAdapter.FillBySubmittedAndPRNOStatus(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, stats, WTXT_SEARCHPR.Text)
        'ElseIf CB_PRLISTSTATUS.SelectedIndex = 2 Then
        '    stats = 3
        '    Me.TblM4_PURCHASEREQUESTTableAdapter.FillBySubmittedAndPRNOStatus(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, stats, WTXT_SEARCHPR.Text)
        'ElseIf CB_PRLISTSTATUS.SelectedIndex = 3 Then
        '    stats = 4
        '    Me.TblM4_PURCHASEREQUESTTableAdapter.FillBySubmittedAndPRNOStatus(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, stats, WTXT_SEARCHPR.Text)
        'ElseIf CB_PRLISTSTATUS.SelectedIndex = 4 Then
        '    Me.TblM4_PURCHASEREQUESTTableAdapter.FillByALLSTATUS(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, WTXT_SEARCHPR.Text)
        'End If

        Me.SPM4_PURCHASELISTTableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_PURCHASELIST, WTXT_SEARCHPR.Text, EMP_NO, False)
        LBL_TOTALNOOFPR.Text = DGV_PRLIST.Rows.Count
    End Sub

    Private Sub DGV_PRLIST_RowPrePaint_1(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DGV_PRLIST.RowPrePaint
        If Not IsDBNull(DGV_PRLIST(1, e.RowIndex).Value) Then
            If DGV_PRLIST(1, e.RowIndex).Value = 1 Then
                DGV_PRLIST(1, e.RowIndex).Style.BackColor = Color.LimeGreen
                DGV_PRLIST(1, e.RowIndex).Style.ForeColor = Color.LimeGreen
                ' DGV_PRLIST(1, e.RowIndex).Value = Nothing


                stats = 1
            ElseIf DGV_PRLIST(1, e.RowIndex).Value = 2 Then
                DGV_PRLIST(1, e.RowIndex).Style.BackColor = Color.Red
                DGV_PRLIST(1, e.RowIndex).Style.ForeColor = Color.Red
                '  DGV_PRLIST(1, e.RowIndex).Value = Nothing

                stats = 2
            ElseIf DGV_PRLIST(1, e.RowIndex).Value = 3 Then
                DGV_PRLIST(1, e.RowIndex).Style.BackColor = Color.Gold
                DGV_PRLIST(1, e.RowIndex).Style.ForeColor = Color.Gold
                '  DGV_PRLIST(1, e.RowIndex).Value = Nothing

                stats = 3
            ElseIf DGV_PRLIST(1, e.RowIndex).Value = 4 Then
                DGV_PRLIST(1, e.RowIndex).Style.BackColor = Color.DimGray
                DGV_PRLIST(1, e.RowIndex).Style.ForeColor = Color.DimGray
                '  DGV_PRLIST(1, e.RowIndex).Value = Nothing
                stats = 4


            End If
        End If

        If Not IsDBNull(DGV_PRLIST(0, e.RowIndex).Value) Then
            If DGV_PRLIST(0, e.RowIndex).Value = String.Empty Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.DimGray
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.DimGray
                DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "1" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.CornflowerBlue
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.CornflowerBlue
                DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "2" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.DarkOrange
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.DarkOrange
                DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "3" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.MediumOrchid
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.MediumOrchid
                DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "4" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.HotPink
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.HotPink
                DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "5" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.MediumTurquoise
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.MediumTurquoise
                DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "6" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.Blue
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.Blue
                DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "7" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.OrangeRed
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.OrangeRed
                DGV_PRLIST(0, e.RowIndex).Value = Nothing
            ElseIf DGV_PRLIST(0, e.RowIndex).Value = "8" Then
                DGV_PRLIST(0, e.RowIndex).Style.BackColor = Color.SpringGreen
                DGV_PRLIST(0, e.RowIndex).Style.ForeColor = Color.SpringGreen
                DGV_PRLIST(0, e.RowIndex).Value = Nothing
            End If
        End If


        'accepted
        If stats = 1 Then

            'for revision
        ElseIf stats = 2 Then

            'cancel pr
        ElseIf stats = 3 Then

            'pending
        ElseIf stats = 4 Then

        End If
    End Sub

    Private Sub DGV_PRLIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PRLIST.CellContentClick
        If DGV_PRLIST.SelectedRows.Count >= 0 Then
            If e.RowIndex >= 0 Then
                Dim row As New DataGridViewRow()
                row = DGV_PRLIST.Rows(e.RowIndex)
                ' PRNO_GEN = row.Cells(1).Value

                If TypeOf DGV_PRLIST.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
                   e.RowIndex >= 0 AndAlso e.ColumnIndex = 4 Then

                    UCPROCTim.Enabled = True
                    slideFlaG = True
                    PNL_SLIDE = APNL_REQUEST_STATUS
                    PNL_SLIDE.BringToFront()
                    SPM4_PURCHASEREQUEST_STATUSTableAdapter.Fill(DS_PROPERTYDB.SPM4_PURCHASEREQUEST_STATUS, row.Cells(2).Value)
                    If SPM4_PURCHASEREQUEST_STATUSDataGridView.RowCount > 0 Then
                        '  PBX_NORECORDSFOUND.Visible = False
                    Else
                        ' PBX_NORECORDSFOUND.Visible = True
                    End If
                    SPM4_PURCHASEREQUEST_STATUSDataGridView.ClearSelection()

                    'If DGV_PRLIST(0, e.RowIndex).Style.ForeColor.Then Then
                    '    NotificationManager.Show(Me, "PR Already accepted.", Color.Red, 3000)
                    'Else
                    '    If MsgBox("Edit?", vbYesNo, "CONFIRM") = vbYes Then
                    '        'If stats = 2 Then
                    '        '    If MsgBox("Do you want to revise this?", vbYesNo, "CONFIRM") = vbYes Then
                    '        '        Me.Close()
                    '        '        TblM4_PURCHASEREQUESTTableAdapter.FillByPRNO(DS_PROPERTYDB.tblM4_PURCHASEREQUEST, PRNO_GEN)
                    '        '        If DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows.Count > 0 Then
                    '        '            'GET DIVISION
                    '        '            Me.TblV1_HRISDIVISIONTableAdapter.Fill(Me.DS_TABLES.tblV1_HRISDIVISION)
                    '        '            'GET DEPARTMENT
                    '        '            Me.TblV1_HRISDEPARTMENTTableAdapter.Fill(Me.DS_TABLES.tblV1_HRISDEPARTMENT)
                    '        '            FRM_PR.WTXT_SUBMITTEDBY.Text = TblV1_HRISEMPLOYEEDATATableAdapter.SQ_GETFULLNAME(DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(13).ToString())
                    '        '            FRM_PR.CB_PRDEPARTMENT.SelectedIndex = FRM_PR.CB_PRDEPARTMENT.FindStringExact(DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(14).ToString())
                    '        '            FRM_PR.CB_PRDIVISION.SelectedIndex = FRM_PR.CB_PRDIVISION.FindStringExact(DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(15).ToString())
                    '        '            FRM_PR.WTXT_SIGNNOTEDPOSITION.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(12).ToString()
                    '        '            FRM_PR.WTXT_SIGNNOTEDNAME.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(11).ToString()
                    '        '            FRM_PR.WTXT_SIGNCERTIFIEDPOSITION.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(10).ToString()
                    '        '            FRM_PR.WTXT_SIGNCERTIFIEDNAME.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(9).ToString()
                    '        '            FRM_PR.WTXT_SIGNAPPROVEPOSITION.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(8).ToString()
                    '        '            FRM_PR.WTXT_SIGNAPPROVENAME.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(7).ToString()
                    '        '            FRM_PR.WTXT_SIGNREQUESTEDPOSITION.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(6).ToString()
                    '        '            FRM_PR.WTXT_SIGNREQUESTEDNAME.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(5).ToString()
                    '        '            FRM_PR.WTXT_PURPOSE.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(3).ToString()
                    '        '            FRM_PR.WTXT_APPCODE.Text = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(2).ToString()
                    '        '            PR_STATUS = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(4)
                    '        '            Dim dt As DateTime = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(1).ToString()
                    '        '            FRM_PR.WTXT_REQUESTEDDATE.Text = dt.ToString("MMM dd, yyyy")
                    '        '            PRNO_GEN = DS_PROPERTYDB.tblM4_PURCHASEREQUEST.Rows(0)(18).ToString()
                    '        '            FRM_PR.PB_PRICONSAVE.Enabled = True
                    '        '        End If
                    '        '    End If
                    '        'End If
                    '    End If
                    'End If

                ElseIf TypeOf DGV_PRLIST.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
                e.RowIndex >= 0 AndAlso e.ColumnIndex = 5 Then
                    If MsgBox("Do you want to print this transaction?", vbYesNo, "CONFIRM") = vbYes Then
                        PRNO = row.Cells(2).Value
                        is_preview = False
                        isNew = False
                        FRM_PURCHASE_REQUEST_PRINTPREVIEW.ShowDialog()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CB_PRLISTSTATUS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PRLISTSTATUS.SelectedIndexChanged

        If CB_PRLISTSTATUS.SelectedIndex = 0 Then
            stats = 1
            Me.TblM4_PURCHASEREQUESTTableAdapter.FillBySubmittedAndPRNOStatus(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, stats, WTXT_SEARCHPR.Text)
        ElseIf CB_PRLISTSTATUS.SelectedIndex = 1 Then
            stats = 2
            Me.TblM4_PURCHASEREQUESTTableAdapter.FillBySubmittedAndPRNOStatus(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, stats, WTXT_SEARCHPR.Text)
        ElseIf CB_PRLISTSTATUS.SelectedIndex = 2 Then
            stats = 3
            Me.TblM4_PURCHASEREQUESTTableAdapter.FillBySubmittedAndPRNOStatus(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, stats, WTXT_SEARCHPR.Text)
        ElseIf CB_PRLISTSTATUS.SelectedIndex = 3 Then
            stats = 4
            Me.TblM4_PURCHASEREQUESTTableAdapter.FillBySubmittedAndPRNOStatus(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, stats, WTXT_SEARCHPR.Text)
        ElseIf CB_PRLISTSTATUS.SelectedIndex = 4 Then
            Me.TblM4_PURCHASEREQUESTTableAdapter.FillByALLSTATUS(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST, EMP_NO, WTXT_SEARCHPR.Text)
        End If
    End Sub

    Private Sub BTN_APNL_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_APNL_CLOSE.Click
        UCPROCTim.Enabled = True
        slideFlaG = False
    End Sub

    Private Sub SPM4_PURCHASEREQUEST_STATUSDataGridView_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles SPM4_PURCHASEREQUEST_STATUSDataGridView.RowPrePaint
        If Not IsDBNull(SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value) Then
            If SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = String.Empty Then
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.BackColor = Color.DimGray
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.ForeColor = Color.DimGray
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = Nothing
            ElseIf SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = "1" Then
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.BackColor = Color.CornflowerBlue
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.ForeColor = Color.CornflowerBlue
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = Nothing
            ElseIf SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = "2" Then
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.BackColor = Color.DarkOrange
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.ForeColor = Color.DarkOrange
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = Nothing
            ElseIf SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = "3" Then
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.BackColor = Color.MediumOrchid
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.ForeColor = Color.MediumOrchid
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = Nothing
            ElseIf SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = "4" Then
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.BackColor = Color.HotPink
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.ForeColor = Color.HotPink
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = Nothing
            ElseIf SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = "5" Then
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.BackColor = Color.MediumTurquoise
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.ForeColor = Color.MediumTurquoise
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = Nothing
            ElseIf SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = "6" Then
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.BackColor = Color.Blue
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.ForeColor = Color.Blue
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = Nothing
            ElseIf SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = "7" Then
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.BackColor = Color.OrangeRed
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.ForeColor = Color.OrangeRed
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = Nothing
            ElseIf SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = "8" Then
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.BackColor = Color.SpringGreen
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Style.ForeColor = Color.SpringGreen
                SPM4_PURCHASEREQUEST_STATUSDataGridView(0, e.RowIndex).Value = Nothing
            End If
        End If
    End Sub

End Class