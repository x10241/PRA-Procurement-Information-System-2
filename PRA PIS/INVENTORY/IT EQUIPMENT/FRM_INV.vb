Public Class FRM_INV
    Private Sub FRM_INV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_VIEWS.VWG3_INVOICE_LIST' table. You can move, or remove it, as needed.
        Me.VWG3_INVOICE_LISTTableAdapter.FillBySEARCH(Me.DS_VIEWS.VWG3_INVOICE_LIST, WTXT_INV_SEARCH.Text)
        WTXT_INV_SEARCH.Select()
    End Sub

    Private Sub DGV_INV_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_INV_LIST.CellDoubleClick
        If e.RowIndex >= 0 Then
            If ENC_TYPE = "INV" Then
                T_INV_NO = DGV_INV_LIST(1, e.RowIndex).Value
                T_INV_DT = DGV_INV_LIST(2, e.RowIndex).Value
                T_INV_TIN_NO = DGV_INV_LIST(11, e.RowIndex).Value
                T_INV_COMPANY = DGV_INV_LIST(12, e.RowIndex).Value
                INV_NO = DGV_INV_LIST(0, e.RowIndex).Value
                '  FRM_INVENTORY_ENCODING.DGV_INV_LIST.Rows.Add(DGV_INV_LIST(3, e.RowIndex).Value, DGV_INV_LIST(7, e.RowIndex).Value, DGV_INV_LIST(10, e.RowIndex).Value, DGV_INV_LIST(19, e.RowIndex).Value)
                'ITEM DESC
                ITM_DR_DESC = DGV_INV_LIST(3, e.RowIndex).Value
                'QTY
                ITM_DR_QTY = DGV_INV_LIST(7, e.RowIndex).Value
                'UNIT TYPE
                ITM_DR_UNIT_TYPE = DGV_INV_LIST(10, e.RowIndex).Value
            End If
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub BTN_INVENTORY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub WTXT_INV_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_INV_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.VWG3_INVOICE_LISTTableAdapter.FillBySEARCH(Me.DS_VIEWS.VWG3_INVOICE_LIST, WTXT_INV_SEARCH.Text)
        End If
    End Sub
End Class