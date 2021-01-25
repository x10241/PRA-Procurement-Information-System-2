Public Class FRM_EMPLOYEE_LIST
    Private Sub FRM_EMPLOYEE_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DT_PDS_LISTTableAdapter.FillByACTIVE(Me.DS_PRAJO_DATABASE.DT_PDS_LIST, WTXT_SEARCHEMPLOYEE.Text)
    End Sub

    Private Sub WTXT_SEARCHEMPLOYEE_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCHEMPLOYEE.TextChanged
        Me.DT_PDS_LISTTableAdapter.FillByACTIVE(Me.DS_PRAJO_DATABASE.DT_PDS_LIST, WTXT_SEARCHEMPLOYEE.Text)
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub EmployeeInfoDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeInfoDataGridView.CellDoubleClick
        Dim row As New DataGridViewRow()
        row = EmployeeInfoDataGridView.Rows(e.RowIndex)

        empfullname.Text = row.Cells(1).Value
        department.Text = row.Cells(2).Value
        division.Text = row.Cells(3).Value
        If ACCOUNTABLE_CTR = True Then
            ACCOUNTABLE_OFFICER.Text = row.Cells(0).Value
        Else
            PROPERTY_USER = row.Cells(0).Value
        End If
        Me.Close()
    End Sub
End Class