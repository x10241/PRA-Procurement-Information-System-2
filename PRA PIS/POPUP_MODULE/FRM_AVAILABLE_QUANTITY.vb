Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_AVAILABLE_QUANTITY

    Public Function QTY_DEDUCTION(ByVal DG As DataGridView, MAXQTY As Integer) As Integer
        Dim totalcount As Integer = 0
        For Each row As DataGridViewRow In DG.Rows
            If Not row.IsNewRow Then
                totalcount += If(IsDBNull(row.Cells(2).Value), 0, row.Cells(2).Value)
            End If
        Next
        Return MAXQTY - totalcount
    End Function

#Region "CLICK"
    Private Sub BTN_ITEM_DISTRIBUTION_CANCEL_Click(sender As Object, e As EventArgs) Handles BTN_CANCEL.Click,
                                                                                                BTN_ADD_ITEM.Click
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

            If btn Is BTN_CANCEL Then
                WTXT_QUANTITY_FOR_DISTRIBUTION.Clear()
                Me.Close()
            ElseIf btn Is BTN_ADD_ITEM Then
                _SAVE()
            End If
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub

#End Region

#Region "LOAD"
    Private Sub FRM_AVAILABLE_QUANTITY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_TABLES.tblV1_HRISDIVISION' table. You can move, or remove it, as needed.
        Me.TblV1_HRISDIVISIONTableAdapter.Fill(Me.DS_TABLES.tblV1_HRISDIVISION)
        WTXT_QUANTITY_FOR_DISTRIBUTION.MaxLength = WTXT_AVAILABLE_QUANTITY.Text.Length
        CELLVALUEHOLDER = CInt(WTXT_AVAILABLE_QUANTITY.Text)
        WTXT_QUANTITY_FOR_DISTRIBUTION.Select()
    End Sub
#End Region

#Region "KEY EVENT"
    'Private Sub WTXT_QUANTITY_FOR_DISTRIBUTION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_QUANTITY_FOR_DISTRIBUTION.KeyPress
    '    '48 - 57  = Ascii codes for numbers
    '    If Asc(e.KeyChar) <> 8 Then
    '        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub WTXT_QUANTITY_FOR_DISTRIBUTION_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_QUANTITY_FOR_DISTRIBUTION.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        _SAVE()
    '    End If
    'End Sub
#End Region

#Region "SAVE"
    Sub _SAVE()
        Try

            For Each row As DataGridViewRow In DGV_DIVISION.Rows
                If row.Cells(0).Value Then
                    FRM_ITEM_DISTRIBUTION.DGV_ITEMDISTRIBUTION.Rows.Add(row.Cells(1).Value,
                                                                   FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST(0, FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST.CurrentRow.Index).Value,
                                                                   FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST(1, FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST.CurrentRow.Index).Value,
                                                                   FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST(2, FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST.CurrentRow.Index).Value,
                                                                   FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST(3, FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST.CurrentRow.Index).Value,
                                                                   FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST(4, FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST.CurrentRow.Index).Value,
                                                                   FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST(5, FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST.CurrentRow.Index).Value,
                                                                   FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST(6, FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST.CurrentRow.Index).Value,
                                                                   row.Cells(2).Value,
                                                                   FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST(10, FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST.CurrentRow.Index).Value,
                                                                   row.Cells(3).Value,
                                                                   row.Cells(4).Value)
                End If
            Next
            FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST(9, FRM_ITEM_DISTRIBUTION.DGV_ITEMLIST.CurrentRow.Index).Value = WTXT_AVAILABLE_QUANTITY.Text
            Me.Close()
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub


#End Region

#Region "CELL EVENT"
    Private Sub TblV1_HRISDIVISIONDataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DIVISION.CellValueChanged
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 2 Then
                If IsDBNull(DGV_DIVISION(2, e.RowIndex).Value) = False Then
                    If CInt(WTXT_AVAILABLE_QUANTITY.Text) < CInt(DGV_DIVISION(2, e.RowIndex).Value) Then
                        DGV_DIVISION(2, e.RowIndex).Value = 0
                        NotificationManager.Show(Me, "Insufficient Quantity!", Color.Red, 2000)

                    Else
                        WTXT_AVAILABLE_QUANTITY.Text = QTY_DEDUCTION(DGV_DIVISION, CELLVALUEHOLDER)
                        If CInt(WTXT_AVAILABLE_QUANTITY.Text) <= 0 Then
                            WTXT_AVAILABLE_QUANTITY.Text = 0
                        End If
                    End If
                Else
                    WTXT_AVAILABLE_QUANTITY.Text = QTY_DEDUCTION(DGV_DIVISION, CELLVALUEHOLDER)
                End If
            End If
        End If
    End Sub

    Private Sub DGV_DIVISION_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)
        If DGV_DIVISION.CurrentCell.ColumnIndex = 2 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region

End Class