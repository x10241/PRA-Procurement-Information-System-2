Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_STK_CTRL

#Region "LOAD"
    Private Sub FRM_STK_CTRL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VWM4_STOCK_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_STOCK_LIST, WTXT_ITEM_STOCK_SEARCH.Text, DIVISION_NO)
    End Sub
#End Region

#Region "CELL EVENT"
    Private Sub DGV_STOCK_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_STOCK_LIST.CellClick
        If e.RowIndex >= 0 Then
            WTXT_ITEM_CODE.Text = DGV_STOCK_LIST(0, e.RowIndex).Value
            WTXT_ITEM_DESC.Text = DGV_STOCK_LIST(1, e.RowIndex).Value
            WTXT_MIN_QTY.Text = DGV_STOCK_LIST(6, e.RowIndex).Value
            WTXT_MAX_QTY.Text = DGV_STOCK_LIST(7, e.RowIndex).Value
            WTXT_QTY_STOCKS.Text = DGV_STOCK_LIST(5, e.RowIndex).Value
        End If
    End Sub
#End Region

#Region "KEY EVENT"
    Private Sub WTXT_ITEM_STOCK_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_ITEM_STOCK_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            VWM4_STOCK_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_STOCK_LIST, WTXT_ITEM_STOCK_SEARCH.Text, DIVISION_NO)
        End If
    End Sub

    Private Sub WTXT_ITEM_STOCK_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_ITEM_STOCK_SEARCH.TextChanged
        If WTXT_ITEM_STOCK_SEARCH.Text.Length > 0 Then
            PB_ITEM_STOCK_CLEAR_SEARCH.Visible = True
        Else
            PB_ITEM_STOCK_CLEAR_SEARCH.Visible = False
        End If
    End Sub

    Private Sub WTXT_MIN_QTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_MIN_QTY.KeyPress
        TXTGLOBAL = Nothing
        If TypeOf sender Is TextBox Then
            TXTGLOBAL = DirectCast(sender, TextBox)
        End If

        If TXTGLOBAL Is WTXT_MIN_QTY Or TXTGLOBAL Is WTXT_MAX_QTY Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

#End Region

#Region "CLICK"

    Private Sub LLBL_SAVE_ITEM_DETAILS_LinkClicked(sender As Object, e As EventArgs) Handles LLBL_SAVE_ITEM_DETAILS.Click,
                                                                                                                    PB_SAVE_ITEM_DETAILS.Click,
                                                                                                                    RECT_SAVE_ITEM_DETAILS.Click,
                                                                                                                    PB_ITEM_STOCK_CLEAR_SEARCH.Click,
                                                                                                                    BTN_ITEM_STOCK_ENC_CLOSE.Click

        Dim pb As PictureBox = Nothing
        Dim btn As Button = Nothing
        llbl = Nothing
        rect = Nothing

        If TypeOf sender Is LinkLabel Then
            llbl = DirectCast(sender, LinkLabel)
        ElseIf TypeOf sender Is RectangleShape Then
            rect = DirectCast(sender, RectangleShape)
        ElseIf TypeOf sender Is PictureBox Then
            pb = CType(sender, PictureBox)
        ElseIf TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

        If llbl Is LLBL_SAVE_ITEM_DETAILS Or pb Is PB_SAVE_ITEM_DETAILS Or rect Is RECT_SAVE_ITEM_DETAILS Then
            _SAVE()
            VWM4_STOCK_LISTTableAdapter.FillByITEM_DESC(DS_VIEWS.VWM4_STOCK_LIST, WTXT_ITEM_STOCK_SEARCH.Text, DIVISION_NO)
        ElseIf pb Is PB_ITEM_STOCK_CLEAR_SEARCH Then
            WTXT_ITEM_STOCK_SEARCH.Clear()
        ElseIf btn Is BTN_ITEM_STOCK_ENC_CLOSE Then
            Me.Close()
            Me.Dispose()
        End If
    End Sub
#End Region

#Region "SAVE FUNCTION"
    Sub _SAVE()
        If TBLM4_INV_ITEMS_STK_CTRLTableAdapter.SQ_CHK_EXIST(Trim(WTXT_ITEM_CODE.Text)) = 0 Then
            'INSERT
            TBLM4_INV_ITEMS_STK_CTRLTableAdapter.IQ_STK_CTRL(Trim(WTXT_ITEM_CODE.Text), Trim(WTXT_MIN_QTY.Text), Trim(WTXT_MAX_QTY.Text), EMP_NO)

        Else
            'UPDATE
            TBLM4_INV_ITEMS_STK_CTRLTableAdapter.UQ_STK_CTRL(Trim(WTXT_MIN_QTY.Text), Trim(WTXT_MAX_QTY.Text), EMP_NO, Trim(WTXT_ITEM_CODE.Text))
        End If
        NotificationManager.Show(Me, "Successfully save!", Color.Green, 3000)
    End Sub

    Private Sub WTXT_ITEM_CODE_TextChanged(sender As Object, e As EventArgs) Handles WTXT_ITEM_CODE.TextChanged
        If WTXT_ITEM_CODE.Text.Length > 0 Then
            RECT_SAVE_ITEM_DETAILS.Enabled = True
            PB_SAVE_ITEM_DETAILS.Enabled = True
            LLBL_SAVE_ITEM_DETAILS.Enabled = True
        Else
            RECT_SAVE_ITEM_DETAILS.Enabled = False
            PB_SAVE_ITEM_DETAILS.Enabled = False
            LLBL_SAVE_ITEM_DETAILS.Enabled = False
        End If
    End Sub


#End Region

End Class