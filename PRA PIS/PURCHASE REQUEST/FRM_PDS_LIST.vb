Public Class FRM_PDS_LIST
    Private Sub FRM_PDS_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPM4_EMPL_SIGN_LISTTableAdapter.FillByFULLNAME(DS_STOREDPROC.SPM4_EMPL_SIGN_LIST, WTXT_SEARCHSIGNATORY.Text)
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DGV_EMP_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_EMP_LIST.CellDoubleClick
        '   Dim row As New DataGridViewRow()
        '    row = DGV_EMP_LIST.Rows(e.RowIndex)
        TXTGLOBAL.Text = DGV_EMP_LIST(1, e.RowIndex).Value

        If IsDBNull(DGV_EMP_LIST(2, e.RowIndex).Value) Then
            ' POSITION.Text = " "
            TXTPOSITION.Text = " "
        Else
            TXTPOSITION.Text = DGV_EMP_LIST(2, e.RowIndex).Value
        End If




        '   TXTSIGNO.Text = DGV_EMP_LIST(0, e.RowIndex).Value
        Me.Close()
    End Sub

    Private Sub WTXT_SEARCHSIGNATORY_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_SEARCHSIGNATORY.KeyDown
        If e.KeyCode = Keys.Enter Then
            SPM4_EMPL_SIGN_LISTTableAdapter.FillByFULLNAME(DS_STOREDPROC.SPM4_EMPL_SIGN_LIST, WTXT_SEARCHSIGNATORY.Text)
        End If
    End Sub
End Class