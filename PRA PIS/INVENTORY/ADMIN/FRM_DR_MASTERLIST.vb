Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_DR_MASTERLIST
    Private Sub FRM_DR_MASTERLIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPM4_ITEM_DR_LISTTableAdapter.FillByITEM_CODE(DS_STOREDPROC.SPM4_ITEM_DR_LIST, "", WTXT_DR_SEARCH.Text, DIVISION_NO)
        LLBL_RECORDSFOUND.Text = DGV_DR_ML.Rows.Count
    End Sub

    Private Sub BTN_INVENTORY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub WTXT_DR_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_DR_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            SPM4_ITEM_DR_LISTTableAdapter.FillByITEM_CODE(DS_STOREDPROC.SPM4_ITEM_DR_LIST, "", WTXT_DR_SEARCH.Text, DIVISION_NO)
            LLBL_RECORDSFOUND.Text = DGV_DR_ML.Rows.Count
        End If
    End Sub

    Private Sub PB_DR_CLEAR_SEARCH_Click(sender As Object, e As EventArgs) Handles PB_DR_CLEAR_SEARCH.Click
        WTXT_DR_SEARCH.Clear()
    End Sub

    Private Sub WTXT_DR_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_DR_SEARCH.TextChanged
        If WTXT_DR_SEARCH.Text.Length > 0 Then
            PB_DR_CLEAR_SEARCH.Visible = True
        Else
            PB_DR_CLEAR_SEARCH.Visible = False
        End If
    End Sub

    Private Sub PB_GEN_REP_DR_ML_Click(sender As Object, e As EventArgs) Handles PB_GEN_REP_DR_ML.Click,
                                                                                    LLBL_GEN_REP_DR_ML.Click,
                                                                                    RECT_GEN_REP_DR_ML.Click

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

            If pb Is PB_GEN_REP_DR_ML Or llbl Is LLBL_GEN_REP_DR_ML Or rect Is RECT_GEN_REP_DR_ML Then
                DR_SEARCH = WTXT_DR_SEARCH.Text
                REP_TYPE = "DR_ML"
                FRM_PMD_PRINT_PREVIEW.ShowDialog()
            End If
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try

    End Sub
End Class