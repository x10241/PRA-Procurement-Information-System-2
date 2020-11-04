Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_PCOUNT
    Public DGV_INDEX As Integer
    Public BOOLEDIT As Boolean = False

#Region "CLICK"
    Private Sub BTN_DATE_Click(sender As Object, e As EventArgs) Handles BTN_DATE_FROM.Click,
                                                                         BTN_DATE_TO.Click,
                                                                            BTN_ADD_ITEM.Click,
                                                                            BTN_ITEM_DETAILS_ENC_CANCEL.Click,
                                                                            BTN_ITEM_DETAILS_ENC_SAVE.Click,
                                                                            WTXT_PHY_DATE_ENCODED.Click,
                                                                            BTN_PHY_CLOSE.Click,
                                                                            LLBL_NEW_PHY_C.Click,
                                                                            PB_NEW_PHY_C.Click,
                                                                            RECT_NEW_PHY_C.Click,
                                                                            RECT_PHY_CANCEL.Click,
                                                                            PB_PHY_CANCEL.Click,
                                                                            LLBL_PHY_CANCEL.Click,
                                                                            LLBL_PHY_SAVE.Click,
                                                                            PB_PHY_SAVE.Click,
                                                                            RECT_PHY_SAVE.Click,
                                                                            RECT_MIGRATE.Click,
                                                                            PB_MIGRATE.Click,
                                                                            LLBL_MIGRATE.Click

        Try
            Dim pb As PictureBox = Nothing
            Dim btn As Button = Nothing
            llbl = Nothing
            rect = Nothing
            TXTGLOBAL = Nothing
            TXTDATE = Nothing

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

#Region "DATE"
            If btn Is BTN_DATE_FROM Then
                TXTDATE = CType(WTXT_DATE_FROM, TextBox)
                FRM_DATAENTRY.ShowDialog()
                Me.VWM4_PCM_LISTTableAdapter.FillByPCBETW(Me.DS_VIEWS.VWM4_PCM_LIST, WTXT_DATE_FROM.Text, WTXT_DATE_TO.Text)
            ElseIf btn Is BTN_DATE_TO Then
                TXTDATE = CType(WTXT_DATE_TO, TextBox)
                FRM_DATAENTRY.ShowDialog()
                Me.VWM4_PCM_LISTTableAdapter.FillByPCBETW(Me.DS_VIEWS.VWM4_PCM_LIST, WTXT_DATE_FROM.Text, WTXT_DATE_TO.Text)
            ElseIf TXTGLOBAL Is WTXT_PHY_DATE_ENCODED Then
                TXTDATE = CType(WTXT_PHY_DATE_ENCODED, TextBox)
                FRM_DATAENTRY.ShowDialog()
#End Region

#Region "NEW P.COUNT"
            ElseIf llbl Is LLBL_NEW_PHY_C Or pb Is PB_NEW_PHY_C Or rect Is RECT_NEW_PHY_C Then
                PNL_PHY_DETAILS.Enabled = True
                _CLEAR_PHY_DETAILS()
                PNL_DATES.Enabled = False
                PNL_DGV.Enabled = False
                LLBL_NEW_PHY_C.Enabled = False
                PB_NEW_PHY_C.Enabled = False
                RECT_NEW_PHY_C.Enabled = False

                RECT_MIGRATE.Enabled = False
                LLBL_MIGRATE.Enabled = False
                PB_MIGRATE.Enabled = False

#End Region

#Region "ADD ITEM"
            ElseIf btn Is BTN_ADD_ITEM Then
                PNL_ITEM_DETAILS_ENC.Visible = True
#End Region

#Region "CLOSE ADD ITEM"
            ElseIf btn Is BTN_ITEM_DETAILS_ENC_CANCEL Then
                PNL_ITEM_DETAILS_ENC.Visible = False
                _CLEAR_ENC()
#End Region

#Region "SAVE ADD ITEM"
            ElseIf btn Is BTN_ITEM_DETAILS_ENC_SAVE Then
                If REQFIELDVALIDATION(WTXT_ITEM_DESCRIPTION) Then
                    RECT_ITEM_DESCRIPTION.BorderColor = Color.Red
                ElseIf REQFIELDVALIDATION(WTXT_ITEM_COUNT_BY) Then
                    RECT_COUNT_BY.BorderColor = Color.Red
                ElseIf REQFIELDVALIDATION(WTXT_ITEM_DESCRIPTION) And REQFIELDVALIDATION(WTXT_ITEM_COUNT_BY) Then
                    RECT_COUNT_BY.BorderColor = Color.Red
                    RECT_ITEM_DESCRIPTION.BorderColor = Color.Red
                Else
                    RECT_COUNT_BY.BorderColor = Color.Gray
                    RECT_ITEM_DESCRIPTION.BorderColor = Color.Gray
                    If BOOLEDIT Then
                        DGV_ITEM_PCOUNT.Rows.RemoveAt(DGV_INDEX)
                        BOOLEDIT = False
                        PNL_ITEM_DETAILS_ENC.Visible = False
                    End If
                    DGV_ITEM_PCOUNT.Rows.Add(WTXT_ITEM_CODE.Text, WTXT_ITEM_DESCRIPTION.Text, WTXT_QTY.Text, IIf(WTXT_UNIT_COST.Text.Length = 0, 0.00, WTXT_UNIT_COST.Text), WTXT_TOTAL_COST.Text, CB_UNIT_TYPE.Text, WTXT_ITEM_REMARKS.Text, WTXT_ITEM_COUNT_BY.Text)
                    LLBL_RECORDSFOUND.Text = DGV_ITEM_PCOUNT.Rows.Count
                End If
#End Region

#Region "CLOSE FORM"
            ElseIf btn Is BTN_PHY_CLOSE Then
                Me.Dispose()
                Me.Close()
#End Region

#Region "CANCEL ADD ITEM"
            ElseIf rect Is RECT_PHY_CANCEL Or pb Is PB_PHY_CANCEL Or llbl Is LLBL_PHY_CANCEL Then
                If MsgBox("You have unsaved changes.", vbYesNo, "Discard changes?") = vbYes Then
                    _CLEAR_PHY_DETAILS()
                    PNL_PHY_DETAILS.Enabled = False
                    LLBL_RECORDSFOUND.Text = DGV_ITEM_PCOUNT.Rows.Count
                    PNL_DATES.Enabled = True
                    PNL_DGV.Enabled = True
                    LLBL_NEW_PHY_C.Enabled = True
                    PB_NEW_PHY_C.Enabled = True
                    RECT_NEW_PHY_C.Enabled = True
                    RECT_MIGRATE.Enabled = True
                    LLBL_MIGRATE.Enabled = True
                    PB_MIGRATE.Enabled = True
                End If
#End Region

#Region "SAVE P.COUNT"
            ElseIf llbl Is LLBL_PHY_SAVE Or pb Is PB_PHY_SAVE Or rect Is RECT_PHY_SAVE Then
                ISVALID = True
                'WTXT_PHY_REASON
                If REQFIELDVALIDATION(WTXT_PHY_REASON) Then
                    RECT_PHY_REASON.BorderColor = Color.Red
                    ISVALID = False
                Else
                    RECT_PHY_REASON.BorderColor = Color.Gray
                End If
                'WTXT_PHY_DATE_ENCODED
                If REQFIELDVALIDATION(WTXT_PHY_DATE_ENCODED) Then
                    RECT_PHY_DATE_ENCODED.BorderColor = Color.Red
                    ISVALID = False
                Else
                    RECT_PHY_DATE_ENCODED.BorderColor = Color.Gray
                End If
                'WTXT_PHY_REMARKS
                'If REQFIELDVALIDATION(WTXT_PHY_REMARKS) Then
                '    RECT_PHY_REMARKS.BorderColor = Color.Red
                '    ISVALID = False
                'Else
                '    RECT_PHY_REMARKS.BorderColor = Color.Gray
                'End If

                'RECT_PHY_CHK_BY
                If REQFIELDVALIDATION(WTXT_PHY_CHK_BY) Then
                    RECT_PHY_CHK_BY.BorderColor = Color.Red
                    ISVALID = False
                Else
                    RECT_PHY_CHK_BY.BorderColor = Color.Gray
                End If

                'RECT_PHY_NOTED_BY
                If REQFIELDVALIDATION(WTXT_PHY_NOTED_BY) Then
                    RECT_PHY_NOTED_BY.BorderColor = Color.Red
                    ISVALID = False
                Else
                    RECT_PHY_NOTED_BY.BorderColor = Color.Gray
                End If

                If ISVALID Then
                    Try
                        Dim PCODE As String = SPM4_PHY_C_CODETableAdapter.SPM4_PHY_C_CODE
                        TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter.IQ_ITEM_PCOUNT_MAIN(Trim(PCODE), Trim(WTXT_PHY_REASON.Text), Trim(WTXT_PHY_CHK_BY.Text), Trim(WTXT_PHY_NOTED_BY.Text), Trim(WTXT_PHY_DATE_ENCODED.Text), Trim(WTXT_PHY_REMARKS.Text), DIVISION_NO)
                        For Each row As DataGridViewRow In DGV_ITEM_PCOUNT.Rows
                            '  TBLM4_INV_ITEMS_PCOUNTTableAdapter.IQ_ITEM_PCOUNT(PCODE, Trim(row.Cells(0).Value), IIf(Trim(row.Cells(2).Value).Length = 0, 0.00, Trim(row.Cells(2).Value)), Trim(row.Cells(6).Value), Trim(row.Cells(7).Value), IIf(Trim(row.Cells(3).Value).Length = 0, 0.00, Trim(row.Cells(3).Value)), IIf(Trim(row.Cells(4).Value).Length = 0, 0.00, Trim(row.Cells(4).Value)), Trim(row.Cells(5).Value))
                            TBLM4_INV_ITEMS_PCOUNTTableAdapter.IQ_ITEM_PCOUNT(Trim(PCODE), Trim(row.Cells(0).Value), CInt(row.Cells(2).Value), row.Cells(6).Value, EMP_NO, CDec(row.Cells(3).Value), CDec(row.Cells(4).Value), row.Cells(5).Value)
                        Next
                        _CLEAR_PHY_DETAILS()
                        PNL_PHY_DETAILS.Enabled = False
                        PNL_DATES.Enabled = True
                        PNL_DGV.Enabled = True
                        LLBL_NEW_PHY_C.Enabled = True
                        PB_NEW_PHY_C.Enabled = True
                        RECT_NEW_PHY_C.Enabled = True
                        NotificationManager.Show(Me, "Successfully saved.", Color.Green, 4000)
                        Me.VWM4_PCM_LISTTableAdapter.FillByPCBETW(Me.DS_VIEWS.VWM4_PCM_LIST, WTXT_DATE_FROM.Text, WTXT_DATE_TO.Text)
                        RECT_MIGRATE.Enabled = True
                        LLBL_MIGRATE.Enabled = True
                        PB_MIGRATE.Enabled = True

                    Catch ex As Exception
                        ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "SAVE P. COUNT")
                        '  NotificationManager.Show(Me, "Successfully saved.", Color.Green, 4000)
                    End Try
                Else
                    NotificationManager.Show(Me, "Please check required fields and item details.", Color.Red, 4000)
                End If

#End Region

#Region "MIGRATE"
            ElseIf RECT Is RECT_MIGRATE Or pb Is PB_MIGRATE Or llbl Is LLBL_MIGRATE Then
                FRM_MIGRATE.ShowDialog()
#End Region

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region

#Region "LOAD"
    Private Sub FRM_PCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLG3_UNITS' table. You can move, or remove it, as needed.
            Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
            Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_STOREDPROC.SPM4_CURRENTDATETIME)
            Me.VWM4_PCM_LISTTableAdapter.FillByPCBETW(Me.DS_VIEWS.VWM4_PCM_LIST, WTXT_DATE_FROM.Text, WTXT_DATE_TO.Text)
#Region "ITEM DESCRIPTION"
            Dim itemdescsuggestions As New AutoCompleteStringCollection()
            Me.VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(Me.DS_VIEWS.VWM4_ITEM_LIST, "", DIVISION_NO)
            Me.SPM4_PDS_LISTTableAdapter.FillBySEARCH(Me.DS_PRAJO_DATABASE.SPM4_PDS_LIST, "")
            If VWM4_ITEM_LISTBindingSource.Count > 0 Then
                For x = 0 To VWM4_ITEM_LISTBindingSource.Count - 1
                    itemdescsuggestions.Add(CStr(If(IsDBNull(CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17)), "", CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17))))
                Next
                WTXT_ITEM_DESCRIPTION.AutoCompleteCustomSource = itemdescsuggestions
            End If
#End Region

        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "FRM_PCOUNT_Load")
        End Try

#Region "COUNT BY"
        Dim USERsuggestions As New AutoCompleteStringCollection()
        If SPM4_PDS_LISTBindingSource.Count > 0 Then
            For x = 0 To SPM4_PDS_LISTBindingSource.Count - 1
                USERsuggestions.Add(CStr(If(IsDBNull(CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0)), "", CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0))))
            Next
            WTXT_ITEM_COUNT_BY.AutoCompleteCustomSource = USERsuggestions
        End If
#End Region

#Region "CHECK BY"
        Dim CHKBYsuggestions As New AutoCompleteStringCollection()
        '  Me.SPM4_PDS_LISTTableAdapter.Fill(Me.DS_PRAJO_DATABASE.SPM4_PDS_LIST)
        If SPM4_PDS_LISTBindingSource.Count > 0 Then
            For x = 0 To SPM4_PDS_LISTBindingSource.Count - 1
                CHKBYsuggestions.Add(CStr(If(IsDBNull(CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0)), "", CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0))))
            Next
            WTXT_PHY_CHK_BY.AutoCompleteCustomSource = CHKBYsuggestions
        End If
#End Region

#Region "NOTED BY"

        Dim NOTEDBYsuggestions As New AutoCompleteStringCollection()
        '   Me.SPM4_PDS_LISTTableAdapter.Fill(Me.DS_PRAJO_DATABASE.SPM4_PDS_LIST)
        If SPM4_PDS_LISTBindingSource.Count > 0 Then
            For x = 0 To SPM4_PDS_LISTBindingSource.Count - 1
                NOTEDBYsuggestions.Add(CStr(If(IsDBNull(CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0)), "", CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0))))
            Next
            WTXT_PHY_NOTED_BY.AutoCompleteCustomSource = NOTEDBYsuggestions
        End If
#End Region

    End Sub

#End Region

#Region "CLEAR ENC"
    Sub _CLEAR_ENC()
        WTXT_ITEM_CODE.Clear()
        WTXT_ITEM_DESCRIPTION.Clear()
        WTXT_QTY.Clear()
        WTXT_ITEM_REMARKS.Clear()
        WTXT_ITEM_COUNT_BY.Clear()
        RECT_COUNT_BY.BorderColor = Color.Gray
        RECT_ITEM_DESCRIPTION.BorderColor = Color.Gray
    End Sub
#End Region

#Region "CLEAR PHY DETAILS"
    Sub _CLEAR_PHY_DETAILS()
        WTXT_PHY_REASON.Clear()
        WTXT_PHY_REMARKS.Clear()
        WTXT_PHY_DATE_ENCODED.Clear()
        DGV_ITEM_PCOUNT.Rows.Clear()
        WTXT_PHY_CHK_BY.Clear()
        WTXT_PHY_NOTED_BY.Clear()
        RECT_PHY_REASON.BorderColor = Color.Gray
        RECT_PHY_DATE_ENCODED.BorderColor = Color.Gray
        RECT_PHY_REMARKS.BorderColor = Color.Gray
        RECT_PHY_CHK_BY.BorderColor = Color.Gray
        RECT_PHY_NOTED_BY.BorderColor = Color.Gray
        LLBL_RECORDSFOUND.Text = 0
    End Sub
#End Region

#Region "CELL EVENT"
    Private Sub DGV_ITEM_PCOUNT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ITEM_PCOUNT.CellClick
        Dim dgv1 = CType(sender, DataGridView)
        If dgv1 Is DGV_ITEM_PCOUNT Then
            If e.ColumnIndex = 9 Then
                If MsgBox("REMOVE THIS?", vbYesNo, "CONFIRM") = vbYes Then
                    dgv1.Rows.RemoveAt(e.RowIndex)
                    LLBL_RECORDSFOUND.Text = DGV_ITEM_PCOUNT.Rows.Count
                End If
            ElseIf e.ColumnIndex = 8 Then
                If MsgBox("UPDATE THIS?", vbYesNo, "CONFIRM") = vbYes Then
                    TBLG3_UNITSTableAdapter.Fill(DS_PROPERTYDB.TBLG3_UNITS)
                    WTXT_ITEM_CODE.Text = dgv1.Rows(e.RowIndex).Cells(0).Value.ToString
                    WTXT_ITEM_DESCRIPTION.Text = dgv1.Rows(e.RowIndex).Cells(1).Value.ToString
                    WTXT_QTY.Text = dgv1.Rows(e.RowIndex).Cells(2).Value.ToString
                    WTXT_UNIT_COST.Text = dgv1.Rows(e.RowIndex).Cells(3).Value.ToString
                    WTXT_TOTAL_COST.Text = dgv1.Rows(e.RowIndex).Cells(4).Value.ToString
                    CB_UNIT_TYPE.SelectedIndex = CB_UNIT_TYPE.FindStringExact(dgv1.Rows(e.RowIndex).Cells(5).Value.ToString)
                    WTXT_ITEM_REMARKS.Text = dgv1.Rows(e.RowIndex).Cells(6).Value.ToString
                    WTXT_ITEM_COUNT_BY.Text = dgv1.Rows(e.RowIndex).Cells(7).Value.ToString
                    DGV_INDEX = e.RowIndex
                    PNL_ITEM_DETAILS_ENC.Visible = True
                    BOOLEDIT = True
                End If
            End If

        End If
    End Sub

    Private Sub DGV_PCOUNT_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PCOUNT_LIST.CellClick
        If e.RowIndex >= 0 Then
            TBLM4_INV_ITEMS_PCOUNTTableAdapter.FillByPCOM_ID(DS_PROPERTYDB.TBLM4_INV_ITEMS_PCOUNT, DGV_PCOUNT_LIST(2, e.RowIndex).Value)
            'MIGRATE
            If e.ColumnIndex = 8 Then
                If MsgBox("Do you want to migrate this?" & vbCrLf & "You can't undo this action.", vbYesNo, "Confirmation") = vbYes Then
                    '   TBLM4_INV_ITEMS_MIGRATETableAdapter.IQ_INV_ITEMS_MIGRATE(DGV_PCOUNT_LIST(,))
                    For Each row As DataGridViewRow In DGV_PCOUNT_DETAILS.Rows
                        SPM4_ITEM_MIGRATETableAdapter.SPM4_ITEM_MIGRATE(row.Cells(1).Value, row.Cells(0).Value, row.Cells(2).Value, EMP_NO)
                    Next
                End If
                'PRINT
            ElseIf e.ColumnIndex = 7 Then

            End If
        End If
    End Sub
#End Region

#Region "TEXT CHANGED"
    Private Sub WTXT_ITEM_DESCRIPTION_TextChanged(sender As Object, e As EventArgs) Handles WTXT_ITEM_DESCRIPTION.TextChanged
        WTXT_ITEM_CODE.Text = VWM4_ITEM_LISTTableAdapter.SQ_ITEM_CODE_ITEM_DESC(WTXT_ITEM_DESCRIPTION.Text, DIVISION_NO)
        WTXT_EXISTING_STOCK.Text = SPM4_GET_EXIST_STOCKTableAdapter.SPM4_GET_EXIST_STOCK(WTXT_ITEM_CODE.Text)
    End Sub

    Private Sub RectangleShape13_Click(sender As Object, e As EventArgs) Handles RectangleShape13.Click

    End Sub

    Private Sub WTXT_QTY_Leave(sender As Object, e As EventArgs) Handles WTXT_QTY.Leave, WTXT_UNIT_COST.Leave
        Try
            TXTGLOBAL = Nothing
            If TypeOf sender Is TextBox Then
                TXTGLOBAL = DirectCast(sender, TextBox)
            End If
            If TXTGLOBAL Is WTXT_QTY Or TXTGLOBAL Is WTXT_UNIT_COST Then
                WTXT_TOTAL_COST.Text = CInt(WTXT_QTY.Text) * CDec(WTXT_UNIT_COST.Text)
                WTXT_TOTAL_COST.Text = TXTSETTO_0(WTXT_TOTAL_COST, False)
                WTXT_UNIT_COST.Text = TXTSETTO_0(WTXT_UNIT_COST, False)
            End If
        Catch ex As Exception
            '  NotificationManager.Show(Me, "PLEASE CHECK QUANTITY AND UNIT COST VALUE!", Color.Red, 3000)
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "WTXT_QTY_Leave")
        End Try
    End Sub
#End Region


End Class