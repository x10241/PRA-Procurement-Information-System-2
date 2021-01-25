Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_ISSUED_ITEM_LIST
    Private Sub FRM_ISSUED_ITEM_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPM4_ITEM_ISSUED_LISTTableAdapter.FillBy(DS_STOREDPROC.SPM4_ITEM_ISSUED_LIST, WTXT_II_SEARCH.Text, ITEMCODE, DIVISION_NO)
        LLBL_RECORDSFOUND.Text = DGV_II_ML.Rows.Count
    End Sub

    Private Sub BTN_INVENTORY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub WTXT_ISS_ITEM_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_II_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            SPM4_ITEM_ISSUED_LISTTableAdapter.FillBy(DS_STOREDPROC.SPM4_ITEM_ISSUED_LIST, WTXT_II_SEARCH.Text, ITEMCODE, DIVISION_NO)
            LLBL_RECORDSFOUND.Text = DGV_II_ML.Rows.Count
        End If
    End Sub

    Private Sub PB_DR_CLEAR_SEARCH_Click(sender As Object, e As EventArgs) Handles PB_II_CLEAR_SEARCH.Click
        WTXT_II_SEARCH.Clear()
    End Sub

    Private Sub WTXT_ISS_ITEM_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_II_SEARCH.TextChanged
        If WTXT_II_SEARCH.Text.Length > 0 Then
            PB_II_CLEAR_SEARCH.Visible = True
        Else
            PB_II_CLEAR_SEARCH.Visible = False
        End If
    End Sub

    Private Sub RECT_II_ML_Click(sender As Object, e As EventArgs) Handles RECT_II_ML.Click,
                                                                            LLBL_II_ML.Click,
                                                                            PB_II_ML.Click
        Try
            Dim pb As PictureBox = Nothing
            Dim btn As Button = Nothing
            llbl = Nothing
            rect = Nothing
            TXTGLOBAL = Nothing

            If TypeOf sender Is LinkLabel Then
                llbl = DirectCast(sender, LinkLabel)
            ElseIf TypeOf sender Is RectangleShape Then
                MD_GLOBALVAR.rect = DirectCast(sender, RectangleShape)
            ElseIf TypeOf sender Is PictureBox Then
                pb = CType(sender, PictureBox)
            ElseIf TypeOf sender Is Button Then
                btn = CType(sender, Button)
            ElseIf TypeOf sender Is TextBox Then
                TXTGLOBAL = CType(sender, TextBox)
            End If

            If pb Is PB_II_ML Or llbl Is LLBL_II_ML Or rect Is RECT_II_ML Then
                II_SEARCH = WTXT_II_SEARCH.Text
                REP_TYPE = "II_ML"
                FRM_PMD_PRINT_PREVIEW.ShowDialog()
            End If
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try

    End Sub
End Class