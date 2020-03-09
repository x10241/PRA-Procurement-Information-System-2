Public Class FRM_SIGNATORYLIST
    Private Sub FRM_SIGNATORYLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLG3_SIGNATORY1' table. You can move, or remove it, as needed.
        Me.TBLG3_SIGNATORY1TableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_SIGNATORY1)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.VWG3_PRIMARY_SIGNATORY' table. You can move, or remove it, as needed.
        Me.VWG3_PRIMARY_SIGNATORYTableAdapter.Fill(Me.DS_PROPERTYDB.VWG3_PRIMARY_SIGNATORY)
        'TBLG3_SIGNATORYTableAdapter.Fill(DSPROPERTYDB_TABLES.TBLG3_SIGNATORY)
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub VWG3_PRIMARY_SIGNATORYDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VWG3_PRIMARY_SIGNATORYDataGridView.CellDoubleClick
        Dim row As New DataGridViewRow()
        row = VWG3_PRIMARY_SIGNATORYDataGridView.Rows(e.RowIndex)
        TXTGLOBAL.Text = row.Cells(0).Value
        POSITION.Text = row.Cells(1).Value
        TXTSIGNO.Text = row.Cells(2).Value
        Me.Close()
    End Sub

    Private Sub WTXT_SEARCHSIGNATORY_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCHSIGNATORY.TextChanged
        TBLG3_SIGNATORY1TableAdapter.FillBy(DS_PROPERTYDB.TBLG3_SIGNATORY1, WTXT_SEARCHSIGNATORY.Text)
    End Sub
End Class