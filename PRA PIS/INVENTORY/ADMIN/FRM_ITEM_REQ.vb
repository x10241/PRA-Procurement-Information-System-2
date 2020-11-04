
Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_ITEM_REQ

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
    Private WithEvents UCPROCTimYLOC As New Timer With {.Interval = 10}

    Private Sub Tim_Tick(sender As Object, e As EventArgs) Handles UCPROCTim.Tick, UCPROCTimYLOC.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTim Then
            Try
                If slideFlaG = True Then
                    X_LOC -= 100
                    PNL_SLIDE.Location = New Point(X_LOC, 0)
                    If PNL_SLIDE Is APNL_ITEMINFO Then
                        If X_LOC < 514 Then
                            PNL_SLIDE.Location = New Point(514, 0)
                            X_LOC = 514
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
        ElseIf timr Is UCPROCTimYLOC Then
            Try
                If slideFlaGY = True Then
                    Y_LOC -= 100
                    PNL_SLIDE_Y.Location = New Point(705, Y_LOC)
                    If PNL_SLIDE_Y Is APNL_SIGNATORIES Then
                        If Y_LOC < 114 Then
                            PNL_SLIDE_Y.Location = New Point(705, 114)
                            Y_LOC = 114
                            UCPROCTimYLOC.Enabled = False
                        End If
                    End If
                Else
                    PNL_SLIDE_Y.Location = New Point(705, 660)
                    Y_LOC = 660
                    UCPROCTimYLOC.Enabled = False
                End If
            Catch ex As Exception
                Y_LOC = 0
            End Try
        End If
    End Sub
#End Region

    Public Sub BS_DGV_ITEM_DISTRIBUTION(ByVal BSMAIN As BindingSource, BSTRANSFER As DataTable)
        For i = 0 To BSMAIN.Count - 1
            BSTRANSFER.Rows.Add(CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(0)), "", CType(BSMAIN.List(i), DataRowView).Item(0))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(1)), "", CType(BSMAIN.List(i), DataRowView).Item(1))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(2)), "", CType(BSMAIN.List(i), DataRowView).Item(2))))
        Next
    End Sub

#Region "CLICK"
    Public Sub LLBL_NEW_REQUISITION_LinkClicked(sender As Object, e As EventArgs) Handles LLBL_NEW_REQUISITION.LinkClicked,
                                                                                                BTN_INVENTORY_MINIMIZE.Click,
                                                                                                BTN_INVENTORY_CLOSE.Click,
                                                                                                RECT_NEW_REQUISITION.Click,
                                                                                                PB_NEW_REQUISITION.Click,
                                                                                                LLBL_NEW_REQUISITION.Click,
                                                                                                WTXT_DATE_NEEDED.Click,
                                                                                                WTXT_FOR_THE_PERIOD.Click,
                                                                                                LLBL_PRINT_PREVIEW.Click,
                                                                                                PB_PRINT_PREVIEW.Click,
                                                                                                RECT_PRINT_PREVIEW.Click,
                                                                                                RECT_SIGNATORIES.Click,
                                                                                                PB_SIGNATORIES.Click,
                                                                                                LLBL_SIGNATORIES.Click,
                                                                                                RECT_SET_DEFAULT.Click,
                                                                                                PB_SET_DEFAULT.Click,
                                                                                                LLBL_SET_DEFAULT.Click,
                                                                                                WTXT_REQU_NAME.Click,
                                                                                                WTXT_AUTHORIZEDNAME.Click,
                                                                                                WTXT_APPR_NAME.Click,
                                                                                                WTXT_ISSU_NAME.Click,
                                                                                                BTN_SIGN_CLOSE.Click,
                                                                                                BTN_CLOSE_INVENTORY_MINI_CLOSE.Click,
                                                                                                LLBL_ADD_ITEM.Click,
                                                                                                PB_ADD_ITEM.Click,
                                                                                                RECT_ADD_ITEM.Click,
                                                                                                BTN_ITEM_REQ_ENC_CANCEL.Click,
                                                                                                BTN_ADD_ITEM.Click,
                                                                                                WTXT_REQUESTED_BY.Click,
                                                                                                PB_REQUISITION_CLEAR_SEARCH.Click,
                                                                                                RECT_SAVE.Click,
                                                                                                LLBL_SAVE.Click,
                                                                                                PB_SAVE.Click



        Try
            Dim pb As PictureBox = Nothing
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
            ElseIf TypeOf sender Is TextBox Then
                TXTGLOBAL = CType(sender, TextBox)
            End If

#Region "MINIMIZE FORM"
            'MINIMIZE FORM
            If btn Is BTN_INVENTORY_MINIMIZE Then
                Me.WindowState = FormWindowState.Minimized
#End Region

#Region "CLOSE FORM"
            ElseIf btn Is BTN_INVENTORY_CLOSE Then
                Me.Close()
#End Region

#Region "NEW REQUISITION"
            ElseIf llbl Is LLBL_NEW_REQUISITION Or pb Is PB_NEW_REQUISITION Or rect Is RECT_NEW_REQUISITION Then
                GRP_ITEMINFO.Visible = True
                isNew = True
                Me.TblM4_INVENTORY_TYPETableAdapter.FillBY_NOT_ITQUIPMENT(Me.DS_PROPERTYDB.tblM4_INVENTORY_TYPE)
                UCPROCTim.Enabled = True
                slideFlaG = True
                PNL_SLIDE = APNL_ITEMINFO
                PNL_SLIDE.BringToFront()
                PNL_BUTTONS.Enabled = False
                GRP_LIST.Enabled = False
                _CLEAR()
                Me.SPM4_CURRENTDATETIMETableAdapter.Fill(DS_STOREDPROC.SPM4_CURRENTDATETIME)
                FILTERTYPE = Nothing
                If CB_REQUISITION_TYPE.SelectedValue = 3 Then
                    FILTERTYPE = "AP"
                ElseIf CB_REQUISITION_TYPE.SelectedValue = 1 Or CB_REQUISITION_TYPE.SelectedValue = 2 Then
                    FILTERTYPE = "AD"
                End If
                GET_PRI_SIGNATORY()
#End Region

#Region "DATE"
            ElseIf TXTGLOBAL Is WTXT_DATE_NEEDED Then
                TXTDATE = CType(sender, TextBox)
                FRM_DATAENTRY.ShowDialog()
                'FOR THE PERIOD
            ElseIf TXTGLOBAL Is WTXT_FOR_THE_PERIOD Then
                TXTDATE = CType(sender, TextBox)
                FRM_DATAENTRY.ShowDialog()
                DATEPERIOD = TXTDATE.Text
                FRM_DATAENTRY.ShowDialog()
                WTXT_FOR_THE_PERIOD.Text = DATEPERIOD & " - " & TXTDATE.Text
#End Region

#Region "SHOW ITEM ENC"
            ElseIf llbl Is LLBL_ADD_ITEM Or pb Is PB_ADD_ITEM Or rect Is RECT_ADD_ITEM Then
                PNL_ITEM_DETAILS.Visible = True
                PNL_ITEM_DETAILS.BringToFront()
#End Region

#Region "CANCEL ENC"
            ElseIf btn Is BTN_ITEM_REQ_ENC_CANCEL Then
                WTXT_QUANTITY.Clear()
                WTXT_ITEM_DESCRIPTION.Clear()
                PNL_ITEM_DETAILS.Visible = False
#End Region

#Region "ADD ITEM"
            ElseIf btn Is BTN_ADD_ITEM Then
                ISVALID = True
                If WTXT_QUANTITY.Text.Length > 0 Then
                    ISVALID = True
                    RECT_QUANTITY.BorderColor = Color.Gray
                Else
                    ISVALID = False
                    RECT_QUANTITY.BorderColor = Color.OrangeRed
                End If

                If WTXT_ITEM_DESCRIPTION.Text.Length > 0 Then
                    ISVALID = True
                    RECT_ITEM_DESCRIPTION.BorderColor = Color.Gray
                Else
                    ISVALID = False
                    RECT_ITEM_DESCRIPTION.BorderColor = Color.OrangeRed
                End If

                If ISVALID = True Then
                    If CB_REQUISITION_TYPE.SelectedValue = 3 Then
                        FILTERTYPE = "AP"
                    ElseIf CB_REQUISITION_TYPE.SelectedValue = 1 Or CB_REQUISITION_TYPE.SelectedValue = 2 Then
                        FILTERTYPE = "AD"
                    End If
                    If VWM4_ITEM_LISTTableAdapter.SQ_CHECKIFFULLDESC_EXIST(WTXT_ITEM_DESCRIPTION.Text, FILTERTYPE) > 0 Then
                        If WTXT_QUANTITY.Text.Length = 0 Then
                            NotificationManager.Show(Me, "Please provide required field!", Color.Red, 3000)
                        Else
                            DGV_ITEM_LIST.Rows.Add(VWM4_ITEM_LISTTableAdapter.SQ_ITEM_CODE_ITEM_DESC(WTXT_ITEM_DESCRIPTION.Text, FILTERTYPE), Trim(WTXT_ITEM_DESCRIPTION.Text), Trim(WTXT_QUANTITY.Text), Trim(CB_UNIT_TYPE.Text))
                            WTXT_ITEM_DESCRIPTION.Clear()
                            WTXT_QUANTITY.Clear()
                        End If
                    Else
                        NotificationManager.Show(Me, "Item Not Exist!", Color.Red, 3000)
                        WTXT_ITEM_DESCRIPTION.Clear()
                    End If
                Else
                    NotificationManager.Show(Me, "Please provide required field!", Color.Red, 3000)
                End If

#End Region

#Region "PRINT PREVIEW"
            ElseIf llbl Is LLBL_PRINT_PREVIEW Or pb Is PB_PRINT_PREVIEW Or rect Is RECT_PRINT_PREVIEW Then
                ISITE = False
                R_CB_REQUISITION_TYPE = CB_REQUISITION_TYPE.Text
                R_PURPOSE = WTXT_PURPOSE.Text
                R_FOR_THE_PERIOD = WTXT_FOR_THE_PERIOD.Text
                R_DATE_NEEDED = WTXT_DATE_NEEDED.Text
                R_REQU_NAME = SYS_FULLNAME_FML
                R_REQU_POSI = EMP_POSITION
                R_AUTHORIZEDNAME = WTXT_AUTHORIZEDNAME.Text
                R_AUTH_POSITION = WTXT_AUTH_POSITION.Text
                R_APPR_NAME = WTXT_APPR_NAME.Text
                R_APPR_POSI = WTXT_APPR_POSI.Text
                R_ISSU_NAME = WTXT_ISSU_NAME.Text
                R_ISSU_POSI = WTXT_ISSU_POSI.Text
                R_DATE = TXT_DATENOW.Text
                dgv = DGV_ITEM_LIST
                If isNew = False Then
                    printPreview = 0
                Else
                    printPreview = 1
                End If
                '  If isNew Then

                '   Else
                '
                'End If

                FRM_INVENTORY_REPORT_PRINT_PREVIEW.ShowDialog()
#End Region

#Region "SAVE"
            ElseIf llbl Is LLBL_SAVE Or pb Is PB_SAVE Or rect Is RECT_SAVE Then
                If DGV_ITEM_LIST.Rows.Count > 0 Then
                    ISVALID = True
                Else
                    ISVALID = False
                End If

                If ISVALID Then
                    ISITE = False
                    If isNew Then
                        REQ_CODE = SPM4_ITEM_REQ_CODETableAdapter.SPM4_ITEM_REQ_CODE(DIVISION_NO)
                        TBLM4_INVENTORY_REQUISITIONTableAdapter.IQ_REQUISITION(Trim(REQ_CODE), Trim(CB_REQUISITION_TYPE.Text), Trim(WTXT_PURPOSE.Text), Trim(DIVISION_NO), Trim(EMP_NO), Trim(WTXT_FOR_THE_PERIOD.Text), Trim(WTXT_DATE_NEEDED.Text), Trim(SYS_FULLNAME_FML), Trim(EMP_POSITION), Trim(WTXT_AUTHORIZEDNAME.Text), Trim(WTXT_AUTH_POSITION.Text), Trim(WTXT_APPR_NAME.Text), Trim(WTXT_APPR_POSI.Text), Trim(WTXT_ISSU_NAME.Text), Trim(WTXT_ISSU_POSI.Text))
                        For Each row As DataGridViewRow In DGV_ITEM_LIST.Rows
                            TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter.IQ_INV_ITEM_REQU(Trim(row.Cells(0).Value), Trim(REQ_CODE), Trim(CInt(row.Cells(2).Value)), Trim(row.Cells(3).Value))
                        Next
                    Else
                        TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter.DQ_ITEM_REQU(REQ_CODE)
                        TBLM4_INVENTORY_REQUISITIONTableAdapter.UQ_REQUISITION(Trim(CB_REQUISITION_TYPE.Text), Trim(WTXT_PURPOSE.Text), Trim(DIVISION_NO), Trim(EMP_NO), Trim(WTXT_FOR_THE_PERIOD.Text), Trim(WTXT_DATE_NEEDED.Text), Trim(SYS_FULLNAME_FML), Trim(EMP_POSITION), Trim(WTXT_AUTHORIZEDNAME.Text), Trim(WTXT_AUTH_POSITION.Text), Trim(WTXT_APPR_NAME.Text), Trim(WTXT_APPR_POSI.Text), Trim(WTXT_ISSU_NAME.Text), Trim(WTXT_ISSU_POSI.Text), REQ_CODE)
                        For Each row As DataGridViewRow In DGV_ITEM_LIST.Rows
                            TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter.IQ_INV_ITEM_REQU(Trim(row.Cells(0).Value), Trim(REQ_CODE), Trim(CInt(row.Cells(2).Value)), Trim(row.Cells(3).Value))
                        Next
                    End If

                    If MsgBox("Do you want to print?", vbYesNo, "Confirm") = vbYes Then
                        printPreview = 1
                        FRM_INVENTORY_REPORT_PRINT_PREVIEW.Text = "PRINT"
                        FRM_INVENTORY_REPORT_PRINT_PREVIEW.ShowDialog()
                    End If

                    UCPROCTim.Enabled = True
                    slideFlaG = False
                    PNL_BUTTONS.Enabled = True
                    GRP_LIST.Enabled = True
                    _CLEAR()

                    Me.TBLM4_INVENTORY_REQUISITIONTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INVENTORY_REQUISITION)
                    NotificationManager.Show(Me, "Successfully Saved.", Color.Green, 6000)
                Else
                    NotificationManager.Show(Me, "Please check item list!", Color.Red, 6000)
                End If
#End Region

#Region "SHOW DEFAULT SIGNATORIES"
            ElseIf llbl Is LLBL_SIGNATORIES Or pb Is PB_SIGNATORIES Or rect Is RECT_SIGNATORIES Then
                UCPROCTimYLOC.Enabled = True
                slideFlaGY = True
                PNL_SLIDE_Y = APNL_SIGNATORIES
                PNL_SLIDE_Y.BringToFront()
                APNL_ITEMINFO.Enabled = False
#End Region

#Region "WHEN SIGNATORY NAME CLICK"
            ElseIf TXTGLOBAL Is WTXT_AUTHORIZEDNAME Or TXTGLOBAL Is WTXT_APPR_NAME Or TXTGLOBAL Is WTXT_ISSU_NAME Or TXTGLOBAL Is WTXT_REQUESTED_BY Then
                If CType(sender, TextBox).Name = "WTXT_AUTHORIZEDNAME" Then
                    TXTGLOBAL = WTXT_AUTHORIZEDNAME
                    POSITION = WTXT_AUTH_POSITION
                    TXTSIGNO = WTXT_AUTH_ID
                ElseIf CType(sender, TextBox).Name = "WTXT_APPR_NAME" Then
                    TXTGLOBAL = WTXT_APPR_NAME
                    POSITION = WTXT_APPR_POSI
                    TXTSIGNO = WTXT_APPR_ID
                ElseIf CType(sender, TextBox).Name = "WTXT_ISSU_NAME" Then
                    TXTGLOBAL = WTXT_ISSU_NAME
                    POSITION = WTXT_ISSU_POSI
                    TXTSIGNO = WTXT_ISSU_ID
                ElseIf CType(sender, TextBox).Name = "WTXT_REQUESTED_BY" Then
                    TXTGLOBAL = WTXT_REQUESTED_BY
                    POSITION = WTXT_REQ_POSITION
                    TXTSIGNO = WTXT_REQ_ID
                End If
                FRM_SIGNATORYLIST.ShowDialog()
#End Region

#Region "SET AS DEFAULT SIGNATORIES"
            ElseIf llbl Is LLBL_SET_DEFAULT Or pb Is PB_SIGNATORIES Or rect Is RECT_SIGNATORIES Then
                Try
                    If SPM4_CHK_CONTAINS_LETTERTableAdapter.SPM4_CHK_CONTAINS_LETTER(EMP_NO) Then
                        NotificationManager.Show(Me, "Saving Failed!." & vbNewLine & vbNewLine & "Please contact ICTD to update your personal info.", Color.Red, 6000)
                    Else
                        _SAVE_SIGNATORY()
                        'SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(25, EMP_NO, If(WTXT_ISSU_NAME.Text = String.Empty, 0, WTXT_ISSU_NAME.Text))
                        GET_PRI_SIGNATORY()
                        NotificationManager.Show(Me, "Successfully Saved.", Color.Green, 3000)
                    End If
                Catch ex As Exception
                    ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "SET AS DEFAULT SIGNATORIES")
                    NotificationManager.Show(Me, "Saving Failed!", Color.Red, 6000)
                End Try
#End Region

#Region "CLOSE SLIDE"
            ElseIf btn Is BTN_SIGN_CLOSE Then
                UCPROCTimYLOC.Enabled = True
                slideFlaGY = False
                APNL_ITEMINFO.Enabled = True
#End Region

#Region "CLOSE ITEM ENC"
            ElseIf btn Is BTN_CLOSE_INVENTORY_MINI_CLOSE Then
                If GRP_ITEMINFO.Visible = True Then
                    _CLEAR()
                End If
                GRP_ITEMINFO.Visible = False
                GRP_D_ITEMINFO.Visible = False
                UCPROCTim.Enabled = True
                slideFlaG = False
                PNL_BUTTONS.Enabled = True
                GRP_LIST.Enabled = True
#End Region

#Region "CLEAR SEARCH"
            ElseIf pb Is PB_REQUISITION_CLEAR_SEARCH Then
                WTXT_REQUISITION_SEARCH.Clear()
#End Region

            End If
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "CLICK")
        End Try
    End Sub
#End Region

#Region "CLEAR"
    Sub _CLEAR()
        WTXT_PURPOSE.Clear()
        WTXT_FOR_THE_PERIOD.Clear()
        WTXT_DATE_NEEDED.Clear()
        WTXT_REQU_NAME.Clear()
        WTXT_REQU_POSI.Clear()
        WTXT_AUTHORIZEDNAME.Clear()
        WTXT_AUTH_POSITION.Clear()
        WTXT_APPR_NAME.Clear()
        WTXT_APPR_POSI.Clear()
        WTXT_ISSU_NAME.Clear()
        WTXT_ISSU_POSI.Clear()
        TXT_DATENOW.Clear()
        DGV_ITEM_LIST.Rows.Clear()
        'WTXT_ITEM_DESCRIPTION.Clear()
        'WTXT_QUANTITY.Clear()
        DS_CUSTOM.DT_ITEM_REQ_PRE.Clear()
        ' dgv.Rows.Clear()
    End Sub
#End Region

#Region "LOAD"
    Private Sub FRM_ITEM_REQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_STOREDPROC.SPM4_CURRENTDATETIME)
        Me.TBLM4_INV_ITEMSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS)
        Me.VWM4_ITEM_REQ_DESCTableAdapter.Fill(Me.DS_VIEWS.VWM4_ITEM_REQ_DESC)
        VWM4_ITEM_REQ_BYTableAdapter.FillByREQ_NO_DIV_NO(DS_VIEWS.VWM4_ITEM_REQ_BY, WTXT_REQUISITION_SEARCH.Text, EMP_NO)
        LLBL_RECORDSFOUND.Text = DGV_REQUISITION_LIST.Rows.Count
        Me.VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(Me.DS_VIEWS.VWM4_ITEM_LIST, WTXT_ITEM_DESCRIPTION.Text, EMP_NO)
        Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
        Me.VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(Me.DS_VIEWS.VWM4_ITEM_LIST, "", "AD")
        Dim suggestions As New AutoCompleteStringCollection()
        If VWM4_ITEM_LISTBindingSource.Count > 0 Then
            For x = 0 To VWM4_ITEM_LISTBindingSource.Count - 1
                suggestions.Add(CStr(If(IsDBNull(CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17)), "", CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17))))
            Next
            WTXT_ITEM_DESCRIPTION.AutoCompleteCustomSource = suggestions
        End If
        LLBL_RECORDSFOUND.Text = DGV_REQUISITION_LIST.Rows.Count
    End Sub
#End Region

#Region "GET PRIMARY SIGNATORY"
    Sub GET_PRI_SIGNATORY()
        Try
            _CLEAR_SIGNATORY()
            Dim FORM_CODE As String = Nothing
            If FILTERTYPE = "AP" Then
                FORM_CODE = "PRA-CR-FORM-0034"
            ElseIf FILTERTYPE = "AD" Then
                FORM_CODE = "PRA-AD-FORM-0002"
            End If
            SPM4_USER_SIGNATORYTableAdapter.FillByEMPID_FORM_CODE(DS_STOREDPROC.SPM4_USER_SIGNATORY, EMP_NO, FORM_CODE)
            Dim cnt As Integer = SPM4_USER_SIGNATORYBindingSource.Count - 1
            For i = 0 To cnt
                If BS(SPM4_USER_SIGNATORYBindingSource, i, 10) = "Requested by:" Then
                    WTXT_REQUESTED_BY.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 3))
                    WTXT_REQ_POSITION.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 4))
                    WTXT_REQ_ID.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 2))
                ElseIf BS(SPM4_USER_SIGNATORYBindingSource, i, 10) = "Authorized by:" Then
                    WTXT_AUTHORIZEDNAME.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 3))
                    WTXT_AUTH_POSITION.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 4))
                    WTXT_AUTH_ID.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 2))
                ElseIf BS(SPM4_USER_SIGNATORYBindingSource, i, 10) = "Approved by:" Then
                    WTXT_APPR_NAME.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 3))
                    WTXT_APPR_POSI.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 4))
                    WTXT_APPR_ID.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 2))
                ElseIf BS(SPM4_USER_SIGNATORYBindingSource, i, 10) = "Issued by:" Then
                    WTXT_ISSU_NAME.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 3))
                    WTXT_ISSU_POSI.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 4))
                    WTXT_ISSU_ID.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, i, 2))
                ElseIf BS(SPM4_USER_SIGNATORYBindingSource, i, 10) = "Received by:" Then

                End If
            Next
            'wtxt_re.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, 4, 3))
            'WTXT_SIGNNOTEDPOSITION.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, 4, 4))
            'TXT_PRNOTEDID.Text = Trim(BS(SPM4_USER_SIGNATORYBindingSource, 4, 2))
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "GET_PRI_SIGNATORY")
        End Try
    End Sub
#End Region

#Region "CLEAR SIGNATORY"
    Sub _CLEAR_SIGNATORY()
        WTXT_REQUESTED_BY.Clear()
        WTXT_REQ_POSITION.Clear()
        WTXT_REQ_ID.Clear()
        WTXT_AUTHORIZEDNAME.Clear()
        WTXT_AUTH_POSITION.Clear()
        WTXT_AUTH_ID.Clear()
        WTXT_APPR_NAME.Clear()
        WTXT_APPR_POSI.Clear()
        WTXT_APPR_ID.Clear()
        WTXT_ISSU_NAME.Clear()
        WTXT_ISSU_POSI.Clear()
        WTXT_ISSU_ID.Clear()
    End Sub
#End Region

#Region "SAVE SIGNATORY"
    Sub _SAVE_SIGNATORY()
        Try

            If FILTERTYPE = "AP" Then
                If REQFIELDVALIDATION(WTXT_REQ_ID) = False Then
                    SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(1021, EMP_NO, If(WTXT_REQ_ID.Text = String.Empty, 0, WTXT_REQ_ID.Text))
                End If

                If REQFIELDVALIDATION(WTXT_AUTH_ID) = False Then
                    SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(1022, EMP_NO, If(WTXT_AUTH_ID.Text = String.Empty, 0, WTXT_AUTH_ID.Text))
                End If

                If REQFIELDVALIDATION(WTXT_APPR_ID) = False Then
                    SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(1023, EMP_NO, If(WTXT_APPR_ID.Text = String.Empty, 0, WTXT_APPR_ID.Text))
                End If

                If REQFIELDVALIDATION(WTXT_ISSU_ID) = False Then
                    SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(1024, EMP_NO, If(WTXT_ISSU_ID.Text = String.Empty, 0, WTXT_ISSU_ID.Text))
                End If
            Else
                If REQFIELDVALIDATION(WTXT_REQ_ID) = False Then
                    SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(21, EMP_NO, If(WTXT_REQ_ID.Text = String.Empty, 0, WTXT_REQ_ID.Text))
                End If

                If REQFIELDVALIDATION(WTXT_AUTH_ID) = False Then
                    SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(22, EMP_NO, If(WTXT_AUTH_ID.Text = String.Empty, 0, WTXT_AUTH_ID.Text))
                End If

                If REQFIELDVALIDATION(WTXT_APPR_ID) = False Then
                    SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(23, EMP_NO, If(WTXT_APPR_ID.Text = String.Empty, 0, WTXT_APPR_ID.Text))
                End If

                If REQFIELDVALIDATION(WTXT_ISSU_ID) = False Then
                    SPM4_UQ_IQ_SIGNATORYTableAdapter.SPM4_UQ_IQ_SIGNATORY(24, EMP_NO, If(WTXT_ISSU_ID.Text = String.Empty, 0, WTXT_ISSU_ID.Text))
                End If
            End If

        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "_SAVE_SIGNATORY")
        End Try
    End Sub
#End Region

#Region "CELL EVENT"
    Private Sub DGV_REQUISITION_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_REQUISITION_LIST.CellClick
        If e.RowIndex >= 0 Then
            Me.TblM4_INVENTORY_TYPETableAdapter.FillBY_NOT_ITQUIPMENT(Me.DS_PROPERTYDB.tblM4_INVENTORY_TYPE)
            SPM4_REQ_DETAILSTableAdapter.FillByREQ_NO(DS_STOREDPROC.SPM4_REQ_DETAILS, DGV_REQUISITION_LIST(0, e.RowIndex).Value)
            DGV_ITEM_LIST.Rows.Clear()
            Dim dts As Date = DGV_REQUISITION_LIST(7, e.RowIndex).Value
            TXT_DATENOW.Text = dts.ToString("MMM dd, yyyy")
            WTXT_REQU_NAME.Text = DGV_REQUISITION_LIST(8, e.RowIndex).Value
            WTXT_REQU_POSI.Text = DGV_REQUISITION_LIST(9, e.RowIndex).Value
            WTXT_AUTHORIZEDNAME.Text = DGV_REQUISITION_LIST(10, e.RowIndex).Value
            WTXT_AUTH_POSITION.Text = DGV_REQUISITION_LIST(11, e.RowIndex).Value
            WTXT_APPR_NAME.Text = DGV_REQUISITION_LIST(12, e.RowIndex).Value
            WTXT_APPR_POSI.Text = DGV_REQUISITION_LIST(13, e.RowIndex).Value
            WTXT_ISSU_NAME.Text = DGV_REQUISITION_LIST(14, e.RowIndex).Value
            WTXT_ISSU_POSI.Text = DGV_REQUISITION_LIST(15, e.RowIndex).Value
            REQ_CODE = DGV_REQUISITION_LIST(0, e.RowIndex).Value
            CB_REQUISITION_TYPE.SelectedIndex = CB_REQUISITION_TYPE.FindStringExact(DGV_REQUISITION_LIST(1, e.RowIndex).Value)
            WTXT_FOR_THE_PERIOD.Text = DGV_REQUISITION_LIST(4, e.RowIndex).Value
            WTXT_PURPOSE.Text = DGV_REQUISITION_LIST(2, e.RowIndex).Value
            Dim dt As Date = DGV_REQUISITION_LIST(5, e.RowIndex).Value
            WTXT_DATE_NEEDED.Text = dt.ToString("MMM dd, yyyy")
            VWM4_ITEM_REQ_DESCTableAdapter.FillByFULLDESC(DS_VIEWS.VWM4_ITEM_REQ_DESC, REQ_CODE)
            Dim ITEM_REQ_COUNT As Integer = VWM4_ITEM_REQ_DESCTableAdapter.SQ_COUNT_ITEM_REQUI(REQ_CODE)
            If ITEM_REQ_COUNT > 0 Then
                For i As Integer = 0 To ITEM_REQ_COUNT - 1
                    DGV_ITEM_LIST.Rows.Add(CType(VWM4_ITEM_REQ_DESCBindingSource.List(i), DataRowView).Item(2), CType(VWM4_ITEM_REQ_DESCBindingSource.List(i), DataRowView).Item(1), CType(VWM4_ITEM_REQ_DESCBindingSource.List(i), DataRowView).Item(3), CType(VWM4_ITEM_REQ_DESCBindingSource.List(i), DataRowView).Item(4))
                Next
            End If
            '  Me.TblM4_INVENTORY_TYPETableAdapter.FillBY_NOT_ITQUIPMENT(Me.DS_PROPERTYDB.tblM4_INVENTORY_TYPE)

            If CB_REQUISITION_TYPE.SelectedValue = 3 Then
                FILTERTYPE = "AP"
            ElseIf CB_REQUISITION_TYPE.SelectedValue = 1 Or CB_REQUISITION_TYPE.SelectedValue = 2 Then
                FILTERTYPE = "AD"
            End If

            If FILTERTYPE = "AP" Then
                RECT_FOR_THE_PERIOD.Visible = False
                LLBL_FOR_THE_PERIOD.Visible = False
                WTXT_FOR_THE_PERIOD.Visible = False
                WTXT_FOR_THE_PERIOD.Clear()
                RECT_DATE_NEEDED.Visible = False
                LLBL_DATE_NEEDED.Visible = False
                WTXT_DATE_NEEDED.Visible = False
            ElseIf FILTERTYPE = "AD" Then
                RECT_FOR_THE_PERIOD.Visible = True
                LLBL_FOR_THE_PERIOD.Visible = True
                WTXT_FOR_THE_PERIOD.Visible = True
                RECT_DATE_NEEDED.Visible = True
                LLBL_DATE_NEEDED.Visible = True
                WTXT_DATE_NEEDED.Visible = True
            End If


            If e.ColumnIndex = 16 Then
                isNew = True
                LLBL_NEW_REQUISITION_LinkClicked(LLBL_PRINT_PREVIEW, e)
            ElseIf e.ColumnIndex = 17 Then
                isNew = False
                UCPROCTim.Enabled = True
                slideFlaG = True
                PNL_SLIDE = APNL_ITEMINFO
                PNL_SLIDE.BringToFront()
                PNL_BUTTONS.Enabled = False
                GRP_LIST.Enabled = False
                GRP_ITEMINFO.Visible = True
            ElseIf e.ColumnIndex = 18 Then
                GRP_D_ITEMINFO.Visible = True
                GRP_ITEMINFO.Visible = False
                UCPROCTim.Enabled = True
                slideFlaG = True
                PNL_SLIDE = APNL_ITEMINFO
                PNL_SLIDE.BringToFront()
                PNL_BUTTONS.Enabled = False
                GRP_LIST.Enabled = False
            End If
        End If
    End Sub

    Private Sub DGV_ITEM_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ITEM_LIST.CellClick
        If e.ColumnIndex = 4 Then
            If e.RowIndex >= 0 Then
                If MsgBox("Remove this?", vbYesNo, "Confirmation") = vbYes Then
                    DGV_ITEM_LIST.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        End If
    End Sub
#End Region

#Region "Key Event"
    Private Sub WTXT_QUANTITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_QUANTITY.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub WTXT_REQUISITION_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_REQUISITION_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            VWM4_ITEM_REQ_BYTableAdapter.FillByREQ_NO_DIV_NO(DS_VIEWS.VWM4_ITEM_REQ_BY, WTXT_REQUISITION_SEARCH.Text, DIVISION_NO)
            LLBL_RECORDSFOUND.Text = DGV_REQUISITION_LIST.Rows.Count
        End If
    End Sub


#End Region

#Region "COMBOBOX EVENT"
    Private Sub CB_REQUISITION_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_REQUISITION_TYPE.SelectedIndexChanged
        If CB_REQUISITION_TYPE.Items.Count > 0 Then
            FILTERTYPE = Nothing
            If CB_REQUISITION_TYPE.SelectedValue = 3 Then
                FILTERTYPE = "AP"
            ElseIf CB_REQUISITION_TYPE.SelectedValue = 1 Or CB_REQUISITION_TYPE.SelectedValue = 2 Then
                FILTERTYPE = "AD"
            End If
            If FILTERTYPE = "AP" Then
                RECT_FOR_THE_PERIOD.Visible = False
                LLBL_FOR_THE_PERIOD.Visible = False
                WTXT_FOR_THE_PERIOD.Visible = False
                WTXT_FOR_THE_PERIOD.Clear()
                RECT_DATE_NEEDED.Visible = False
                LLBL_DATE_NEEDED.Visible = False
                WTXT_DATE_NEEDED.Visible = False
            ElseIf FILTERTYPE = "AD" Then
                RECT_FOR_THE_PERIOD.Visible = True
                LLBL_FOR_THE_PERIOD.Visible = True
                WTXT_FOR_THE_PERIOD.Visible = True
                RECT_DATE_NEEDED.Visible = True
                LLBL_DATE_NEEDED.Visible = True
                WTXT_DATE_NEEDED.Visible = True
                SPM4_CURRENTDATETIMETableAdapter.Fill(DS_STOREDPROC.SPM4_CURRENTDATETIME)
            End If
            Me.VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(Me.DS_VIEWS.VWM4_ITEM_LIST, "", FILTERTYPE)
            Dim suggestions As New AutoCompleteStringCollection()
            If VWM4_ITEM_LISTBindingSource.Count > 0 Then
                For x = 0 To VWM4_ITEM_LISTBindingSource.Count - 1
                    suggestions.Add(CStr(If(IsDBNull(CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17)), "", CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17))))
                Next
                WTXT_ITEM_DESCRIPTION.AutoCompleteCustomSource = suggestions
            End If
            GET_PRI_SIGNATORY()
        End If
    End Sub

    Private Sub WTXT_REQUISITION_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_REQUISITION_SEARCH.TextChanged
        If WTXT_REQUISITION_SEARCH.Text.Length > 0 Then
            PB_REQUISITION_CLEAR_SEARCH.Visible = True
        Else
            PB_REQUISITION_CLEAR_SEARCH.Visible = False
        End If
    End Sub
#End Region

End Class