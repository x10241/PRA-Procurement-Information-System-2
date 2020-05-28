Public Class FRM_EDITPR
    Private Sub FRM_EDITPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TblM4_PURCHASEREQUESTTableAdapter.FillBySUBMITTEDBY_PR_NO(DS_PROPERTYDB.tblM4_PURCHASEREQUEST, WTXT_SEARCHPR.Text, EMP_NO)
    End Sub

    Private Sub WTXT_SEARCHSIGNATORY_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_SEARCHPR.KeyDown
        If e.KeyCode = Keys.Enter Then
            TblM4_PURCHASEREQUESTTableAdapter.FillBySUBMITTEDBY_PR_NO(DS_PROPERTYDB.tblM4_PURCHASEREQUEST, WTXT_SEARCHPR.Text, EMP_NO)
        End If
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DGV_EDIT_PR_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_EDIT_PR_LIST.CellDoubleClick
        PRNO = DGV_EDIT_PR_LIST(0, e.RowIndex).Value
        TXTREQUESTEDDATE.Text = DGV_EDIT_PR_LIST(1, e.RowIndex).Value
        TXTAPPCODE.Text = DGV_EDIT_PR_LIST(2, e.RowIndex).Value
        TXTPURPOSE.Text = DGV_EDIT_PR_LIST(3, e.RowIndex).Value
        TXTSUBMITTEDBY.Text = DGV_EDIT_PR_LIST(13, e.RowIndex).Value
        MsgBox(DGV_EDIT_PR_LIST(17, e.RowIndex).Value)
        RBTNISDOLLAR.Checked = If(DGV_EDIT_PR_LIST(17, e.RowIndex).Value = 1, True, False)
        CBDEPARTMENT.Text = DGV_EDIT_PR_LIST(13, e.RowIndex).Value
        CBDIVISION.Text = DGV_EDIT_PR_LIST(14, e.RowIndex).Value
        Me.Close()
        Me.Dispose()
    End Sub
End Class