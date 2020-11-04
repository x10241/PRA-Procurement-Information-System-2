Public Class FRM_ISSUED_ITEM_LIST
    Private Sub FRM_ISSUED_ITEM_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPM4_ITEM_ISSUED_LISTTableAdapter.FillBy(DS_STOREDPROC.SPM4_ITEM_ISSUED_LIST, WTXT_ISS_ITEM_SEARCH.Text, ITEMCODE, DIVISION_NO)
    End Sub

    Private Sub BTN_INVENTORY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub WTXT_ISS_ITEM_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_ISS_ITEM_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            SPM4_ITEM_ISSUED_LISTTableAdapter.FillBy(DS_STOREDPROC.SPM4_ITEM_ISSUED_LIST, WTXT_ISS_ITEM_SEARCH.Text, ITEMCODE, DIVISION_NO)
        End If
    End Sub
End Class