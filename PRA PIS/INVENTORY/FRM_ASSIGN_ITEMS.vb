Public Class FRM_ASSIGN_ITEMS
    Private Sub BTN_GENERATE_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_GENERATE_REPORT.Click
        printPreview = "AssignItem"
        FRM_PREVIEW.ShowDialog()
    End Sub

    Private Sub FRM_ASSIGN_ITEMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPM4_ASSIGN_ITEMSTableAdapter.Fill(DS_STOREDPROC.SPM4_ASSIGN_ITEMS, WTXT_LIST_PREFERRED_ITEMS.Text)
    End Sub

    Private Sub WTXT_LIST_PREFERRED_ITEMS_TextChanged(sender As Object, e As EventArgs) Handles WTXT_LIST_PREFERRED_ITEMS.TextChanged
        '   SPM4_ASSIGN_ITEMSTableAdapter.Fill(DS_STOREDPROC.SPM4_ASSIGN_ITEMS, WTXT_LIST_PREFERRED_ITEMS.Text)
    End Sub

    Private Sub BTN_SELECTION_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_SELECTION_CLOSE.Click
        Me.Close()
    End Sub
End Class