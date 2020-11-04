Public Class FRM_DR_LIST_DETAILS

#Region "KEYDOWN"
    Private Sub WTXT_ITEM_STOCK_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_DR_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ENC_TYPE = "STOCK" Then
                Me.VWG3_DR_LISTTableAdapter.FillByDR_NO(Me.DS_VIEWS.VWG3_DR_LIST, WTXT_DR_SEARCH.Text)
            ElseIf ENC_TYPE = "ITEM_ENC" Then
                VWG3_DR_LISTBindingSource.Filter = "DRD_DESCRIPTION Like '%" + WTXT_DR_SEARCH.Text + "%'" +
                    " OR COM_COMPANY_NAME LIKE '%" + WTXT_DR_SEARCH.Text + "%'" +
                    " OR DR_NO LIKE '%" + WTXT_DR_SEARCH.Text + "%'"
            End If
        End If
    End Sub
#End Region

#Region "CELL CLICK"
    Private Sub DGV_STOCK_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_STOCK_LIST.CellClick
        If e.RowIndex >= 0 Then
            If ENC_TYPE = "STOCK" Then
                FRM_STOCK_ENC.WTXT_DR_NO.Text = DGV_STOCK_LIST(0, e.RowIndex).Value
                FRM_STOCK_ENC.WTXT_DATE_DELIVERED.Text = DGV_STOCK_LIST(1, e.RowIndex).Value
                FRM_STOCK_ENC.WTXT_TIN_NO.Text = DGV_STOCK_LIST(9, e.RowIndex).Value
                FRM_STOCK_ENC.WTXT_COMPANY_NAME.Text = DGV_STOCK_LIST(10, e.RowIndex).Value
                DR_ID = DGV_STOCK_LIST(20, e.RowIndex).Value
                FRM_STOCK_ENC.DGV_DR_PARTICULARS.Rows.Add(DGV_STOCK_LIST(5, e.RowIndex).Value, DGV_STOCK_LIST(6, e.RowIndex).Value, DGV_STOCK_LIST(7, e.RowIndex).Value, DGV_STOCK_LIST(19, e.RowIndex).Value)
            ElseIf ENC_TYPE = "ITEM_ENC" Then
                T_INV_NO = DGV_STOCK_LIST(0, e.RowIndex).Value
                T_INV_TIN_NO = DGV_STOCK_LIST(9, e.RowIndex).Value
                T_INV_COMPANY = DGV_STOCK_LIST(10, e.RowIndex).Value
                T_INV_DT = DGV_STOCK_LIST(1, e.RowIndex).Value
                ''DR NO
                'ITM_DR_NO = DGV_STOCK_LIST(0, e.RowIndex).Value
                ''DATE DELIVERED
                'ITM_DR_DATE_DELIVERED = DGV_STOCK_LIST(1, e.RowIndex).Value
                ''TIN NO.
                'ITM_DR_TIN_NO = DGV_STOCK_LIST(9, e.RowIndex).Value
                ''COMP. NAME
                'ITM_DR_COMP_NAME = DGV_STOCK_LIST(10, e.RowIndex).Value
                'DR-TIN ID
                DR_ID = DGV_STOCK_LIST(20, e.RowIndex).Value
                'ITEM DESC
                ITM_DR_DESC = DGV_STOCK_LIST(5, e.RowIndex).Value
                'QTY
                ITM_DR_QTY = DGV_STOCK_LIST(6, e.RowIndex).Value
                'UNIT TYPE
                ITM_DR_UNIT_TYPE = DGV_STOCK_LIST(7, e.RowIndex).Value
                'WARRANTY
                If IsDBNull(DGV_STOCK_LIST(19, e.RowIndex).Value) Then
                    ITM_DR_WARRANTY = ""
                Else
                    ITM_DR_WARRANTY = DGV_STOCK_LIST(19, e.RowIndex).Value
                End If
                '  FRM_INVENTORY_ENCODING.DGV_ITM_DR_PARTICULARS.Rows.Add(DGV_STOCK_LIST(6, e.RowIndex).Value, DGV_STOCK_LIST(7, e.RowIndex).Value, DGV_STOCK_LIST(8, e.RowIndex).Value, DGV_STOCK_LIST(20, e.RowIndex).Value)
            End If
            Me.Close()
            Me.Dispose()
        End If
    End Sub
#End Region

#Region "TEXT CHANGED"
    Private Sub WTXT_DR_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_DR_SEARCH.TextChanged
        If WTXT_DR_SEARCH.Text.Length > 0 Then
            PB_DR_CLEAR_SEARCH.Visible = True
        Else
            PB_DR_CLEAR_SEARCH.Visible = False
        End If
    End Sub
#End Region

#Region "CLICK"
    Private Sub BTN_INVENTORY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_CLOSE.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PB_DR_CLEAR_SEARCH_Click(sender As Object, e As EventArgs) Handles PB_DR_CLEAR_SEARCH.Click
        WTXT_DR_SEARCH.Clear()
    End Sub
#End Region

#Region "LOAD"
    Private Sub FRM_DR_LIST_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ENC_TYPE = "ITEM_ENC" Then
            Me.VWG3_DR_LISTTableAdapter.Fill(Me.DS_VIEWS.VWG3_DR_LIST)
        ElseIf ENC_TYPE = "STOCK" Then
            Me.VWG3_DR_LISTTableAdapter.FillByDR_NO(Me.DS_VIEWS.VWG3_DR_LIST, WTXT_DR_SEARCH.Text)
        End If
    End Sub
#End Region

End Class