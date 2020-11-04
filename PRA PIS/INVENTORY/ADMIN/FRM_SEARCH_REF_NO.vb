Public Class FRM_SEARCH_REF_NO

    Private Sub BTN_INVENTORY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub PB_SEARCH_CLEAR_Click(sender As Object, e As EventArgs) Handles PB_SEARCH_CLEAR.Click
        WTXT_REF_SEARCH.Clear()
    End Sub

    Private Sub FRM_SEARCH_REF_NO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLM4_INV_DIST_MAIN' table. You can move, or remove it, as needed.
        Me.TBLM4_INV_DIST_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_DIST_MAIN)
        WTXT_REF_SEARCH.Clear()
        Me.ActiveControl = WTXT_REF_SEARCH
    End Sub

    Private Sub WTXT_INVENTORY_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles WTXT_REF_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TBLM4_INVENTORY_REQUISITIONTableAdapter.SQ_SEARCH_REQ_NO(Trim(WTXT_REF_SEARCH.Text)) = 0 Then
                NotificationManager.Show(Me, "No Data Found!", Color.Red, 3000)
            Else
                If TBLM4_INV_DIST_MAINTableAdapter.SQ_INV_DIST_MAIN_EXIST(Trim(WTXT_REF_SEARCH.Text)) = 1 Then
                    NotificationManager.Show(Me, "Ref. No. Already encoded!", Color.Red, 3000)
                Else
                    REQ_CODE = WTXT_REF_SEARCH.Text
                    Me.Close()
                    FRM_ITEM_DISTRIBUTION.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub WTXT_REF_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_REF_SEARCH.TextChanged
        If WTXT_REF_SEARCH.Text.Length > 0 Then
            PB_SEARCH_CLEAR.Visible = True
        Else
            PB_SEARCH_CLEAR.Visible = False
        End If
    End Sub
End Class