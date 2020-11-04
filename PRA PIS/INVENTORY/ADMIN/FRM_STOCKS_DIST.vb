Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_STOCKS_DIST
    Private Sub FRM_STOCKS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WTXT_NO_OF_STOCKS.Text = A_STOCKS
        Me.ActiveControl = WTXT_APPROVED_QUANTITY
    End Sub

    Private Sub WTXT_APPROVED_QUANTITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_APPROVED_QUANTITY.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub WTXT_APPROVED_QUANTITY_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_APPROVED_QUANTITY.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CInt(WTXT_APPROVED_QUANTITY.Text) > CInt(WTXT_NO_OF_STOCKS.Text) Then
                WTXT_APPROVED_QUANTITY.Clear()
                NotificationManager.Show(Me, "Insufficient Quantity!", Color.Red, 2000)
                ISVALID = False
            ElseIf REQFIELDVALIDATION(WTXT_APPROVED_QUANTITY) Then
                NotificationManager.Show(Me, "Invalid Quantity!", Color.Red, 2000)
                ISVALID = False
            Else
                ISVALID = True
            End If

            If ISVALID Then
                FRM_ITEM_DISTRIBUTION.DGV_ITEM_LIST(6, DGV_REQ_ROWCTR).Value = CInt(WTXT_NO_OF_STOCKS.Text) - CInt(WTXT_APPROVED_QUANTITY.Text)
                FRM_ITEM_DISTRIBUTION.DGV_ITEM_LIST(5, DGV_REQ_ROWCTR).Value = CInt(WTXT_APPROVED_QUANTITY.Text)
                ' FRM_ITEM_DISTRIBUTION.DGV_ITEM_LIST(5, DGV_REQ_ROWCTR).Value = CInt(WTXT_NO_OF_STOCKS.Text)
                Me.Close()
                '  FRM_ITEM_DISTRIBUTION.DGV_ITEM_LIST(4, FRM_ITEM_DISTRIBUTION.DGV_ITEM_LIST.SelectedRows).Value
            End If
        End If
    End Sub

    Private Sub LLBL_CANCEL_Click(sender As Object, e As EventArgs) Handles RECT_CANCEL.Click,
                                                                             PB_CANCEL.Click,
                                                                             LLBL_CANCEL.Click

        Try
            Dim pb As PictureBox = Nothing
            Dim btn As Button = Nothing
            llbl = Nothing
            rect = Nothing
            TXTGLOBAL = Nothing

            If TypeOf sender Is LinkLabel Then
                llbl = DirectCast(sender, LinkLabel)
            ElseIf TypeOf sender Is RectangleShape Then
                rect = DirectCast(sender, RectangleShape)
            ElseIf TypeOf sender Is PictureBox Then
                pb = CType(sender, PictureBox)
            ElseIf TypeOf sender Is Button Then
                btn = CType(sender, Button)
            ElseIf TypeOf sender Is TextBox Then
                TXTGLOBAL = CType(sender, TextBox)
            End If

            If llbl Is LLBL_CANCEL Or rect Is RECT_CANCEL Or pb Is PB_CANCEL Then
                Me.Close()
            End If
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "CANCEL STOCK")
        End Try



    End Sub


End Class