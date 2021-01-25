Public Class FRM_REASSIGN
    Dim PC_LIST As New List(Of String)

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

    Private Sub BTN_NEXT_Click(sender As Object, e As EventArgs) Handles BTN_NEXT.Click,
                                                                           BTN_PREVIOUS.Click,
                                                                           BTN_SAVE.Click,
                                                                           WTXT_NEW_ASS_DATE.Click,
                                                                           WTXT_NEW_ACC_DATE.Click


        Dim btn As Button = Nothing
        Dim txt As WatermarkTextBox = Nothing
        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        ElseIf TypeOf sender Is WatermarkTextBox Then
            txt = CType(sender, WatermarkTextBox)
        End If

        'IF BTN NEXT CLICK
        If btn Is BTN_NEXT Then
            TblM4_INVENTORY_ITEMS1DataGridView.Rows.Clear()
            For Each row As DataGridViewRow In DGV_EMP_ITEMS.Rows
                'if check
                If row.Cells(18).Value = True Then
                    TblM4_INVENTORY_ITEMS1DataGridView.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value)
                End If
            Next

            BTN_PREVIOUS.Visible = True
            BTN_SAVE.Visible = True
            PNL_2.Visible = True
            PNL_1.Visible = False

        ElseIf TXT Is WTXT_NEW_ASS_DATE Or txt Is WTXT_NEW_ACC_DATE Then


            'IF BTN PREVIOUS CLICK
        ElseIf btn Is BTN_PREVIOUS Then
            BTN_PREVIOUS.Visible = False
            BTN_SAVE.Visible = False
            BTN_NEXT.Visible = True
            PNL_2.Visible = False
            PNL_1.Visible = True
            'IF BTN SAVE CLICK  
        ElseIf btn Is BTN_SAVE Then

        End If
    End Sub

    Private Sub FRM_REASSIGN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DT_INV_ACC_OFFTableAdapter.Fill(Me.DS_PROPERTYDB.DT_INV_ACC_OFF)
    End Sub


    Private Sub WTXT_SEARCH_ITEM_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCH_ITEM.TextChanged
        If WTXT_SEARCH_ITEM.Text.Length > 0 Then
            PB_ITEM_CLEAR_SEARCH.Visible = True
        Else
            PB_ITEM_CLEAR_SEARCH.Visible = False
        End If
    End Sub

    Private Sub WTXT_EMP_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_EMP_SEARCH.TextChanged
        If WTXT_EMP_SEARCH.Text.Length > 0 Then
            PB_EMP_CLEAR_SEARCH.Visible = True
        Else
            PB_EMP_CLEAR_SEARCH.Visible = False
        End If
    End Sub

    Private Sub PB_EMP_CLEAR_SEARCH_Click(sender As Object, e As EventArgs) Handles PB_EMP_CLEAR_SEARCH.Click
        WTXT_EMP_SEARCH.Clear()
    End Sub

    Private Sub PB_ITEM_CLEAR_SEARCH_Click(sender As Object, e As EventArgs) Handles PB_ITEM_CLEAR_SEARCH.Click
        WTXT_SEARCH_ITEM.Clear()
    End Sub

    Private Sub DGV_ACC_EMP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ACC_EMP.CellClick
        If e.RowIndex >= 0 Then
            Me.VWM4_ITEM_ASSTableAdapter.FillByEMP_NO(Me.DS_VIEWS.VWM4_ITEM_ASS, DGV_ACC_EMP(0, e.RowIndex).Value)
        End If

    End Sub

    Private Sub WTXT_EMP_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_EMP_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTINVACCOFFBindingSource.Filter = "DATE_APPOINTED Like '%" + WTXT_EMP_SEARCH.Text + "%'" + " OR FULLNAME Like '%" + WTXT_EMP_SEARCH.Text + "%'" + " OR EMP_NO Like '%" + WTXT_EMP_SEARCH.Text + "%'"
        End If
    End Sub

    Private Sub WTXT_SEARCH_ITEM_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_SEARCH_ITEM.KeyDown
        If e.KeyCode = Keys.Enter Then
            VWM4ITEMASSBindingSource.Filter = "ITEM_CODE Like '%" + WTXT_SEARCH_ITEM.Text + "%'" + " OR ITEM_DESCRIPTION Like '%" + WTXT_SEARCH_ITEM.Text + "%'" + " OR ITEM_SERIAL_NO Like '%" + WTXT_SEARCH_ITEM.Text + "%'"
        End If
    End Sub

    Private Sub DGV_EMP_ITEMS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_EMP_ITEMS.CellClick
        If e.ColumnIndex = 18 Then
            Dim cell As DataGridViewCheckBoxCell = DGV_EMP_ITEMS.Rows(e.RowIndex).Cells(18)
            If cell.Value Then
                cell.Value = False
            Else
                cell.Value = True
            End If
        End If

    End Sub
End Class