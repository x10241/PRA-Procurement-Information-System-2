Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_ITEM_DISTRIBUTION

#Region "FUNCTION"
    Public Sub BS_DGV_ITEM_DISTRIBUTION(ByVal BSMAIN As BindingSource, BSTRANSFER As DataTable)
        For i = 0 To BSMAIN.Count - 1
            BSTRANSFER.Rows.Add(CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(0)), "", CType(BSMAIN.List(i), DataRowView).Item(0))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(1)), "", CType(BSMAIN.List(i), DataRowView).Item(1))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(2)), "", CType(BSMAIN.List(i), DataRowView).Item(2))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(3)), "", CType(BSMAIN.List(i), DataRowView).Item(3))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(4)), "", CType(BSMAIN.List(i), DataRowView).Item(4))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(5)), "", CType(BSMAIN.List(i), DataRowView).Item(5))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(6)), "", CType(BSMAIN.List(i), DataRowView).Item(6))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(7)), "", CType(BSMAIN.List(i), DataRowView).Item(7))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(8)), "", CType(BSMAIN.List(i), DataRowView).Item(8))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(9)), "", CType(BSMAIN.List(i), DataRowView).Item(9))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(10)), "", CType(BSMAIN.List(i), DataRowView).Item(10))))
        Next
    End Sub
#End Region

#Region "LOAD"
    Private Sub FRM_ITEM_DISTRIBUTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLM4_INV_ITEMS' table. You can move, or remove it, as needed.
        Me.TBLM4_INV_ITEMSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS)
        SPM4_ITEM_DIST_DGV_BY_REF_NOTableAdapter.FillByREQ_NO(DS_STOREDPROC.SPM4_ITEM_DIST_DGV_BY_REF_NO, REQ_CODE)
    End Sub
#End Region

#Region "SELECTED INDEX CHANGED"
    Private Sub CB_ITEM_DISTRIBUTION_DEPARTMENT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ITEM_DISTRIBUTION_DEPARTMENT.SelectedIndexChanged
        Try
            TblV1_HRISDIVISIONTableAdapter.FillByDEPTCODE(DS_TABLES.tblV1_HRISDIVISION, CB_ITEM_DISTRIBUTION_DEPARTMENT.SelectedValue)
        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "CLICK"
    Private Sub LLBL_CANCEL_Click(sender As Object, e As EventArgs) Handles LLBL_CANCEL.Click,
                                                                            RECT_CANCEL.Click,
                                                                            PB_CANCEL.Click,
                                                                            LLBL_SAVE.Click,
                                                                            PB_SAVE.Click,
                                                                            RECT_SAVE.Click

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

            If llbl Is LLBL_CANCEL Or pb Is PB_CANCEL Or rect Is RECT_CANCEL Then
                Me.Close()
            ElseIf llbl Is LLBL_SAVE Or pb Is PB_SAVE Or rect Is RECT_SAVE Then
                ISVALID = True
                For Each row As DataGridViewRow In DGV_ITEM_LIST.Rows
                    If row.Cells(5).Value = 0 Then
                        ISVALID = False
                    Else
                        ISVALID = True
                    End If
                Next

                If ISVALID = False Then
                    If MsgBox("Are you sure you want to save this without setting the value of approve quantity?" & vbCrLf & vbCrLf & "You can't undo this action.", vbYesNo, "Confirmation") = vbYes Then
                        _SAVE()
                    End If
                Else
                    _SAVE()
                End If
            End If
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "LLBL_CANCEL_Click")
        End Try
    End Sub
#End Region

#Region "TEXT CHANGED"
    Private Sub WTXT_SEARCH_ITEM_DETAIL_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCH_ITEM_LIST.TextChanged
        If WTXT_SEARCH_ITEM_LIST.Text.Length > 0 Then
            PB_ITEM_LIST_CLEAR.Visible = True
        Else
            PB_ITEM_LIST_CLEAR.Visible = False
        End If
    End Sub
#End Region

#Region "KEY EVENT"
    Private Sub WTXT_SEARCH_ITEM_LIST_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_SEARCH_ITEM_LIST.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Key Enter
    Private Sub WTXT_SEARCH_ITEM_LIST_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_SEARCH_ITEM_LIST.KeyDown
        If e.KeyCode = Keys.Enter Then
            ItemListDistributionBindingSource.Filter = "ItemCode LIKE '%" & WTXT_SEARCH_ITEM_LIST.Text & "%'" &
                                                   " OR Category LIKE '%" & WTXT_SEARCH_ITEM_LIST.Text & "%'" &
                                                   " OR SubCategory LIKE '%" & WTXT_SEARCH_ITEM_LIST.Text & "%'" &
                                                   " OR ItemDescription LIKE '%" & WTXT_SEARCH_ITEM_LIST.Text & "%'" &
                                                   " OR BrandProvider LIKE '%" & WTXT_SEARCH_ITEM_LIST.Text & "%'"
        End If
    End Sub
#End Region

#Region "CELL EVENT"
    Private Sub DGV_ITEMLIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ITEMLIST.CellDoubleClick
        If e.RowIndex >= 0 Then
            FRM_AVAILABLE_QUANTITY.WTXT_AVAILABLE_QUANTITY.Text = DGV_ITEMLIST.Rows(e.RowIndex).Cells(9).Value
            FRM_AVAILABLE_QUANTITY.WTXT_AVAILABLE_QTY_CATEGORY.Text = DGV_ITEMLIST.Rows(e.RowIndex).Cells(1).Value
            FRM_AVAILABLE_QUANTITY.WTXT_AVAILABLE_QTY_SUB_CATEGORY.Text = DGV_ITEMLIST.Rows(e.RowIndex).Cells(2).Value
            FRM_AVAILABLE_QUANTITY.WTXT_AVAILABLE_QTY_BRAND.Text = DGV_ITEMLIST.Rows(e.RowIndex).Cells(3).Value
            FRM_AVAILABLE_QUANTITY.WTXT_AVAILABLE_QTY_ITEM_DESC.Text = DGV_ITEMLIST.Rows(e.RowIndex).Cells(5).Value
            FRM_AVAILABLE_QUANTITY.ShowDialog()
        End If
    End Sub

    Private Sub DGV_ITEMDISTRIBUTION_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ITEMDISTRIBUTION.CellDoubleClick
        If e.RowIndex >= 0 Then
            If MsgBox("Are you sure you want to remove this?" & vbCrLf & "You can't undo this action.", vbYesNo, "Confirmation") = vbYes Then
                DGV_ITEMDISTRIBUTION.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub
#End Region

#Region "SAVE"
    Sub _SAVE()

        Try
            For Each row As DataGridViewRow In DGV_ITEM_LIST.Rows
                SPM4_IQ_REQ_DISTTableAdapter.SPM4_IQ_REQ_DIST(Trim(WTXT_REF_NO.Text), row.Cells(0).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString, EMP_NO, EMP_NO)
            Next
            MsgBox("Successfully Saved.", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "SAVE - ITEM DISTRIBUTION")
        End Try
    End Sub

    Private Sub DGV_ITEM_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ITEM_LIST.CellClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 7 Then
                A_STOCKS = CInt(DGV_ITEM_LIST(3, e.RowIndex).Value)
                DGV_REQ_ROWCTR = e.RowIndex
                FRM_STOCKS_DIST.ShowDialog()
            End If
        End If
    End Sub

    Private Sub BTN_INVENTORY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_CLOSE.Click
        Me.Close()
    End Sub

#End Region

End Class