Public Class FRM_DR_MASTERLIST
    Private Sub FRM_DR_MASTERLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPM4_ITEM_DR_LISTTableAdapter.FillByITEM_CODE(DS_STOREDPROC.SPM4_ITEM_DR_LIST, "", WTXT_DR_SEARCH.Text, DIVISION_NO)
    End Sub

    Private Sub BTN_INVENTORY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub WTXT_DR_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_DR_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            SPM4_ITEM_DR_LISTTableAdapter.FillByITEM_CODE(DS_STOREDPROC.SPM4_ITEM_DR_LIST, "", WTXT_DR_SEARCH.Text, DIVISION_NO)
        End If
    End Sub
End Class