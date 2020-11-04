Public Class FRM_SIGNATORYLIST
    Private Sub FRM_SIGNATORYLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPM4_SIGNATORY_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_SIGNATORY_LIST, WTXT_SEARCHSIGNATORY.Text)
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub VWG3_PRIMARY_SIGNATORYDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VWG3_PRIMARY_SIGNATORYDataGridView.CellDoubleClick
        Dim row As New DataGridViewRow()
        row = VWG3_PRIMARY_SIGNATORYDataGridView.Rows(e.RowIndex)
        TXTGLOBAL.Text = row.Cells(1).Value '
        If IsDBNull(row.Cells(1).Value) Then
            POSITION.Text = " "
        Else
            POSITION.Text = row.Cells(2).Value
        End If

        TXTSIGNO.Text = row.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub WTXT_SEARCHSIGNATORY_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCHSIGNATORY.TextChanged
        'SPM4EMPLSIGNLISTBindingSource.Filter = "FULLNAME LIKE '%" & WTXT_SEARCHSIGNATORY.Text & "%'" &
        '                                           " OR POSITION LIKE '%" & WTXT_SEARCHSIGNATORY.Text & "%'"
        SPM4_SIGNATORY_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_SIGNATORY_LIST, WTXT_SEARCHSIGNATORY.Text)
    End Sub


End Class