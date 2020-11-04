Public Class FRM_ASSIGN_ITEMS
    Private Sub BTN_GENERATE_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_GENERATE_REPORT.Click
        printPreview = "AssignItem"
        FRM_PREVIEW.ShowDialog()
    End Sub

    Private Sub FRM_ASSIGN_ITEMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VWM4_ITEM_ASSTableAdapter.FillByITEM_CODE(Me.DS_VIEWS.VWM4_ITEM_ASS)
    End Sub

    Private Sub WTXT_LIST_PREFERRED_ITEMS_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCH_ASS_ITEM.TextChanged
        VWM4_ITEM_ASSBindingSource.Filter = "ITEM_CODE LIKE '%" + WTXT_SEARCH_ASS_ITEM.Text + "%'" + " OR " +
                                            "ITEM_SERIAL_NO LIKE '%" + WTXT_SEARCH_ASS_ITEM.Text + "%'" + " OR " +
                                            "ITEM_DESCRIPTION LIKE '%" + WTXT_SEARCH_ASS_ITEM.Text + "%'" + " OR " +
                                            "FULLNAME LIKE '%" + WTXT_SEARCH_ASS_ITEM.Text + "%'"
    End Sub

    Private Sub BTN_SELECTION_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_SELECTION_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub BTN_ASSIGN_ITEM_Click(sender As Object, e As EventArgs) Handles BTN_ASSIGN_ITEM.Click
        FRM_ASSIGN.ShowDialog()
        Me.VWM4_ITEM_ASSTableAdapter.FillByITEM_CODE(Me.DS_VIEWS.VWM4_ITEM_ASS)
    End Sub

    Private Sub DGV_ASSIGN_ITEMS_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ASSIGN_ITEMS_LIST.CellClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 21 Then
                'FRM_ASSIGN.GB_ITEMDETAILS.Enabled = False

            End If
        End If
    End Sub
End Class