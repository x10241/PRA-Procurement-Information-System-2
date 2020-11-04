Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_STOCK_ENC

#Region "TIMER"

    Private WithEvents UCPROCTim As New Timer With {.Interval = 10}

    Private Sub Tim_Tick(sender As Object, e As EventArgs) Handles UCPROCTim.Tick
        Dim timr As Timer = CType(sender, Timer)
        If timr Is UCPROCTim Then
            Try
                If slideFlaG = True Then
                    X_LOC -= 100
                    PNL_SLIDE.Location = New Point(X_LOC, 66)
                    If PNL_SLIDE Is APNL_NEW_ITEM Then
                        If X_LOC < 0 Then
                            PNL_SLIDE.Location = New Point(0, 66)
                            X_LOC = 0
                            UCPROCTim.Enabled = False
                        End If
                    End If
                Else
                    PNL_SLIDE.Location = New Point(1050, 66)
                    X_LOC = 1050
                    UCPROCTim.Enabled = False
                End If
            Catch ex As Exception
                X_LOC = 0
            End Try
        End If
    End Sub



#End Region

#Region "CLICK"
    Private Sub WTXT_DR_NO_Click(sender As Object, e As EventArgs) Handles WTXT_DR_NO.Click,
                                                                            LLBL_ADD_ITEM.Click,
                                                                            RECT_ADD_ITEM.Click,
                                                                            PB_ADD_ITEM.Click,
                                                                            BTN_ITEM_DETAILS_ENC_CANCEL.Click,
                                                                            BTN_ITEM_DETAILS_ENC_SAVE.Click,
                                                                            BTN_CLOSE_STOCK.Click,
                                                                            PB_NEW_ITEM_STOCK.Click,
                                                                            LLBL_NEW_ITEM_STOCK.Click,
                                                                            RECT_NEW_ITEM_STOCK.Click,
                                                                            RECT_SAVE_NEW_ITEM.Click,
                                                                            LLBL_SAVE_NEW_ITEM.Click,
                                                                            PB_SAVE_NEW_ITEM.Click,
                                                                            BTN_ITEM_STOCK_ENC_CLOSE.Click,
                                                                            PB_ITEM_STOCK_CLEAR_SEARCH.Click,
                                                                            RECT_STK_CTRL_SETUP.Click,
                                                                            PB_STK_CTRL_SETUP.Click,
                                                                            LLBL_STKCTRL_SETUP.Click,
                                                                            LLBL_STOCK_VIEW_REPORT.Click,
                                                                            RECT_STOCK_VIEW_REPORT.Click,
                                                                            PB_STOCK_VIEW_REPORT.Click

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

#Region "SHOW DR SEARCH FORM"
            If TXTGLOBAL Is WTXT_DR_NO Then
                ENC_TYPE = "STOCK"
                DGV_DR_PARTICULARS.Rows.Clear()
                FRM_DR_LIST_DETAILS.ShowDialog()
#End Region

#Region "SHOW VISIBLE ENCODED ITEMS"
            ElseIf llbl Is LLBL_ADD_ITEM Or rect Is RECT_ADD_ITEM Or pb Is PB_ADD_ITEM Then
                EditBool = False
                PNL_ITEM_DETAILS_ENC.Visible = True
                PNL_ITEM_DETAILS_ENC.BringToFront()
#End Region

#Region "CLOSE ENCODED ITEMS"
            ElseIf btn Is BTN_ITEM_DETAILS_ENC_CANCEL Then
                PNL_ITEM_DETAILS_ENC.Visible = False

#End Region

#Region "ADD SAVE ENCODED ITEMS"
            ElseIf btn Is BTN_ITEM_DETAILS_ENC_SAVE Then
                If WTXT_ITEM_CODE.Text.Length > 0 Then
                    If EditBool Then
                        DGV_ITEM_STOCK_DETAILS.Rows.RemoveAt(DGV_REQ_ROWCTR)
                    End If
                    DGV_ITEM_STOCK_DETAILS.Rows.Add(WTXT_ITEM_CODE.Text, WTXT_ITEM_DESCRIPTION.Text, WTXT_QTY.Text, CB_UNIT_TYPE.Text, WTXT_UNIT_PRICE.Text, WTXT_TOTAL_PRICE.Text)
                    CLEAR_PNL_ITEM_DETAILS_ENC()
                    EditBool = False
                Else
                    NotificationManager.Show(Me, "Item Not Exist!", Color.Red, 3000)
                End If
#End Region

#Region "NEW ITEM"
            ElseIf llbl Is LLBL_NEW_ITEM_STOCK Or pb Is PB_NEW_ITEM_STOCK Or rect Is RECT_NEW_ITEM_STOCK Then
                UCPROCTim.Enabled = True
                slideFlaG = True
                PNL_SLIDE = APNL_NEW_ITEM
                PNL_SLIDE.BringToFront()
                PNL_BUTTONS.Enabled = False
                PNL_SEARCH_DGV.Enabled = False
                BTN_ITEM_STOCK_ENC_CLOSE.Enabled = False

#End Region

#Region "CLOSE ADD ITEM"
            ElseIf btn Is BTN_CLOSE_STOCK Then
                UCPROCTim.Enabled = True
                slideFlaG = False
                PNL_BUTTONS.Enabled = True
                PNL_SEARCH_DGV.Enabled = True
                BTN_ITEM_STOCK_ENC_CLOSE.Enabled = True

#End Region

#Region "SAVE NEW ITEM"
            ElseIf rect Is RECT_SAVE_NEW_ITEM Or llbl Is LLBL_SAVE_NEW_ITEM Or pb Is PB_SAVE_NEW_ITEM Then
                _SAVE_NEW_ITEM()

#End Region

#Region "CLOSE FORM"
            ElseIf btn Is BTN_ITEM_STOCK_ENC_CLOSE Then
                Me.Close()
#End Region

#Region "CLEAR SEARCH BOX"
            ElseIf pb Is PB_ITEM_STOCK_CLEAR_SEARCH Then
                WTXT_ITEM_STOCK_SEARCH.Clear()
#End Region

#Region "STOCK CONTROL SETUP"
            ElseIf pb Is PB_STK_CTRL_SETUP Or llbl Is LLBL_STKCTRL_SETUP Or rect Is RECT_STK_CTRL_SETUP Then
                FRM_STK_CTRL.ShowDialog()
                SPM4_ITEM_STOCKMASTERLISTTableAdapter.FillByFILTER_SEARCH(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST, CB_FILTER_BY.SelectedIndex, WTXT_ITEM_STOCK_SEARCH.Text, DIVISION_NO)
                ' VWM4_STOCK_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_STOCK_LIST, WTXT_ITEM_STOCK_SEARCH.Text)
#End Region

#Region "SHOW STOCK REPORT"
            ElseIf llbl Is LLBL_STOCK_VIEW_REPORT Or rect Is RECT_STOCK_VIEW_REPORT Or pb Is PB_STOCK_VIEW_REPORT Then
                REP_TYPE = "STOCK_LIST"
                FRM_REPORT_STOCK_FILTER.ShowDialog()
#End Region

            End If
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub

#End Region

#Region "CLEAR"
    Sub CLEAR_PNL_ITEM_DETAILS_ENC()
        WTXT_ITEM_DESCRIPTION.Clear()
        WTXT_QTY.Text = 0
        WTXT_UNIT_PRICE.Text = 0
        WTXT_TOTAL_PRICE.Clear()
    End Sub

    Sub CLEAR_ADD_ITEM()
        DGV_ITEM_STOCK_DETAILS.Rows.Clear()
        DGV_DR_PARTICULARS.Rows.Clear()
        WTXT_DR_NO.Clear()
        WTXT_DATE_DELIVERED.Clear()
        WTXT_TIN_NO.Clear()
        WTXT_COMPANY_NAME.Clear()
        PNL_BUTTONS.Enabled = True
        PNL_SEARCH_DGV.Enabled = True
    End Sub
#End Region

#Region "TEXT CHANGED"
    Private Sub WTXT_ITEM_DESCRIPTION_TextChanged(sender As Object, e As EventArgs) Handles WTXT_ITEM_DESCRIPTION.TextChanged
        WTXT_ITEM_CODE.Text = VWM4_ITEM_LISTTableAdapter.SQ_ITEM_CODE_ITEM_DESC(WTXT_ITEM_DESCRIPTION.Text, DIVISION_NO)
    End Sub
#End Region

#Region "LOAD"
    Private Sub FRM_STOCK_ENC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_STOREDPROC.SPM4_PHY_C_CODE' table. You can move, or remove it, as needed.
        Me.SPM4_PHY_C_CODETableAdapter.Fill(Me.DS_STOREDPROC.SPM4_PHY_C_CODE)
        '   VWM4_STOCK_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_STOCK_LIST, WTXT_ITEM_STOCK_SEARCH.Text, DIVISION_NO)
        SPM4_ITEM_STOCKMASTERLISTTableAdapter.FillByFILTER_SEARCH(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST, CB_FILTER_BY.SelectedIndex, WTXT_ITEM_STOCK_SEARCH.Text, DIVISION_NO)
        Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
        Dim suggestions As New AutoCompleteStringCollection()
        Me.VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(Me.DS_VIEWS.VWM4_ITEM_LIST, "", DIVISION_NO)
        If VWM4_ITEM_LISTBindingSource.Count > 0 Then
            For x = 0 To VWM4_ITEM_LISTBindingSource.Count - 1
                suggestions.Add(CStr(If(IsDBNull(CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17)), "", CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17))))
            Next
            WTXT_ITEM_DESCRIPTION.AutoCompleteCustomSource = suggestions
        End If
        CB_FILTER_BY.SelectedIndex = 0
        LLBL_NORMAL.Text = SPM4_ITEM_STOCKS_LEGENDTableAdapter.SPM4_ITEM_STOCKS_LEGEND(0, DIVISION_NO)
        LLBL_CRITICAL.Text = SPM4_ITEM_STOCKS_LEGENDTableAdapter.SPM4_ITEM_STOCKS_LEGEND(1, DIVISION_NO)
        LLBL_OVER_STOCK.Text = SPM4_ITEM_STOCKS_LEGENDTableAdapter.SPM4_ITEM_STOCKS_LEGEND(2, DIVISION_NO)
        LLBL_NOSTOCK.Text = SPM4_ITEM_STOCKS_LEGENDTableAdapter.SPM4_ITEM_STOCKS_LEGEND(3, DIVISION_NO)
    End Sub
#End Region

#Region "KEY EVENT"
    Private Sub WTXT_QTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_QTY.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub WTXT_ITEM_STOCK_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_ITEM_STOCK_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' VWM4_STOCK_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_STOCK_LIST, WTXT_ITEM_STOCK_SEARCH.Text)
            SPM4_ITEM_STOCKMASTERLISTTableAdapter.FillByFILTER_SEARCH(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST, CB_FILTER_BY.SelectedIndex, WTXT_ITEM_STOCK_SEARCH.Text, DIVISION_NO)
            LBL_TOTALNOOFREC.Text = DGV_STOCK_LIST.Rows.Count
        End If
    End Sub
#End Region

#Region "TEXTBOX LEAVE"
    Private Sub WTXT_QTY_Leave(sender As Object, e As EventArgs) Handles WTXT_QTY.Leave
        If WTXT_QTY.Text.Length = 0 Then
            WTXT_QTY.Text = 0
        End If

        If CInt(WTXT_QTY.Text) >= 0 And CDec(WTXT_UNIT_PRICE.Text) >= 0 Then
            WTXT_TOTAL_PRICE.Text = CInt(WTXT_QTY.Text) * CDec(WTXT_UNIT_PRICE.Text)
        End If
    End Sub

    Private Sub WTXT_UNIT_PRICE_Leave(sender As Object, e As EventArgs) Handles WTXT_UNIT_PRICE.Leave
        If WTXT_UNIT_PRICE.Text.Length = 0 Then
            WTXT_UNIT_PRICE.Text = 0
        End If

        If CInt(WTXT_QTY.Text) >= 0 And CDec(WTXT_UNIT_PRICE.Text) >= 0 Then
            WTXT_TOTAL_PRICE.Text = CInt(WTXT_QTY.Text) * CDec(WTXT_UNIT_PRICE.Text)
        End If
    End Sub
#End Region

#Region "CELL EVENT"
    Private Sub DGV_ITEM_STOCK_DETAILS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ITEM_STOCK_DETAILS.CellClick
        If e.ColumnIndex = 6 Then
            EditBool = True
            DGV_REQ_ROWCTR = e.RowIndex
            WTXT_ITEM_CODE.Text = DGV_ITEM_STOCK_DETAILS(0, e.RowIndex).Value
            WTXT_ITEM_DESCRIPTION.Text = DGV_ITEM_STOCK_DETAILS(1, e.RowIndex).Value
            WTXT_QTY.Text = DGV_ITEM_STOCK_DETAILS(2, e.RowIndex).Value
            CB_UNIT_TYPE.SelectedIndex = CB_UNIT_TYPE.FindStringExact(DGV_ITEM_STOCK_DETAILS(3, e.RowIndex).Value)
            WTXT_UNIT_PRICE.Text = DGV_ITEM_STOCK_DETAILS(4, e.RowIndex).Value
            WTXT_TOTAL_PRICE.Text = DGV_ITEM_STOCK_DETAILS(5, e.RowIndex).Value
            PNL_ITEM_DETAILS_ENC.Visible = True
        ElseIf e.ColumnIndex = 7 Then
            If MsgBox("Are you sure you want to remove this?" & vbCrLf & "You can't undo this action.", vbYesNo, "Confirmation") = vbYes Then
                DGV_ITEM_STOCK_DETAILS.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub DGV_STOCK_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_STOCK_LIST.CellDoubleClick
        If e.RowIndex >= 0 Then
            ITEMCODE = DGV_STOCK_LIST(1, e.RowIndex).Value
            FRM_ITEM_CODE_SELECTION.ShowDialog()
        End If
    End Sub



#End Region

#Region "_SAVE_NEW_ITEM"
    Sub _SAVE_NEW_ITEM()
        Try
            ISVALID = True

            If REQFIELDVALIDATION(WTXT_DR_NO) Then
                RECT_DR_NO.BorderColor = Color.Red
                RECT_DATE_DELIVERED.BorderColor = Color.Red
                RECT_COMP_NAME.BorderColor = Color.Red
                RECT_TIN_NO.BorderColor = Color.Red
                ISVALID = False
            ElseIf DGV_ITEM_STOCK_DETAILS.Rows.Count = 0 Then
                ISVALID = False
            Else
                RECT_DR_NO.BorderColor = Color.Gray
                RECT_DATE_DELIVERED.BorderColor = Color.Gray
                RECT_COMP_NAME.BorderColor = Color.Gray
                RECT_TIN_NO.BorderColor = Color.Gray
            End If

            If ISVALID Then
                Dim STOCK_NO As String = SPM4_PHY_C_CODETableAdapter.SPM4_PHY_C_CODE
                For Each row As DataGridViewRow In DGV_ITEM_STOCK_DETAILS.Rows
                    If TBLM4_INV_DR_ITEMSTableAdapter.SQ_DR_ITEM_CODE_EXIST(row.Cells(0).Value, DR_ID) > 0 Then
                        NotificationManager.Show(Me, "Item Already Exist!", Color.Red, 2000)
                        Exit Sub
                    Else
                        'MsgBox(row.Cells(0).Value)
                        'MsgBox(DR_ID)
                        'MsgBox(CDec(row.Cells(4).Value))
                        'MsgBox(CDec(row.Cells(5).Value))
                        'MsgBox(CInt(row.Cells(2).Value))
                        'MsgBox(row.Cells(3).Value)
                        'MsgBox(STOCK_NO)
                        TBLM4_INV_DR_ITEMSTableAdapter.IQ_INV_DR_ITEMS(row.Cells(0).Value, DR_ID, CDec(row.Cells(4).Value), CDec(row.Cells(5).Value), CInt(row.Cells(2).Value), EMP_NO, row.Cells(3).Value, "", STOCK_NO)
                    End If
                Next
                CLEAR_ADD_ITEM()
                UCPROCTim.Enabled = True
                slideFlaG = False
                PNL_BUTTONS.Enabled = True
                PNL_SEARCH_DGV.Enabled = True
                BTN_ITEM_STOCK_ENC_CLOSE.Enabled = True
                SPM4_ITEM_STOCKMASTERLISTTableAdapter.FillByFILTER_SEARCH(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST, CB_FILTER_BY.SelectedIndex, WTXT_ITEM_STOCK_SEARCH.Text, DIVISION_NO)
                '  VWM4_STOCK_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_STOCK_LIST, WTXT_ITEM_STOCK_SEARCH.Text)
                NotificationManager.Show(Me, "Successfully saved!", Color.Green, 4000)
            Else
                NotificationManager.Show(Me, "Please provide required field!", Color.Red, 4000)
            End If
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "_SAVE_NEW_ITEM")
        End Try
    End Sub


#End Region

#Region "COMBOBOX"
    Private Sub CB_FILTER_BY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FILTER_BY.SelectedIndexChanged
        SPM4_ITEM_STOCKMASTERLISTTableAdapter.FillByFILTER_SEARCH(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST, CB_FILTER_BY.SelectedIndex, WTXT_ITEM_STOCK_SEARCH.Text, DIVISION_NO)
        LBL_TOTALNOOFREC.Text = DGV_STOCK_LIST.Rows.Count
    End Sub
#End Region

#Region "TEXT CHANGED"
    Private Sub WTXT_ITEM_STOCK_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_ITEM_STOCK_SEARCH.TextChanged
        If WTXT_ITEM_STOCK_SEARCH.Text.Length > 0 Then
            PB_ITEM_STOCK_CLEAR_SEARCH.Visible = True
        Else
            PB_ITEM_STOCK_CLEAR_SEARCH.Visible = False
        End If
    End Sub


#End Region

#Region "DGV"
    Private Sub DGV_STOCK_LIST_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DGV_STOCK_LIST.RowPrePaint
        'NO STOCK
        If DGV_STOCK_LIST(6, e.RowIndex).Value = 0 Then
            DGV_STOCK_LIST(0, e.RowIndex).Style.BackColor = Color.Blue
            'CRITICAL
        ElseIf DGV_STOCK_LIST(6, e.RowIndex).Value < DGV_STOCK_LIST(7, e.RowIndex).Value Then
            DGV_STOCK_LIST(0, e.RowIndex).Style.BackColor = Color.Red
            'OVER STOCK
        ElseIf DGV_STOCK_LIST(6, e.RowIndex).Value > DGV_STOCK_LIST(8, e.RowIndex).Value Then
            DGV_STOCK_LIST(0, e.RowIndex).Style.BackColor = Color.Green
            'NORMAL
        Else
            DGV_STOCK_LIST(0, e.RowIndex).Style.BackColor = Color.WhiteSmoke
        End If
    End Sub


#End Region

End Class