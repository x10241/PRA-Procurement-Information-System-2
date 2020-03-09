Public Class FRM_SELECTION
    Private Sub BTN_PRSEARCHTRANSACTIONCODE_Click(sender As Object, e As EventArgs) Handles BTN_SELECTIONLOCATION.Click,
                                                                                                BTN_SELECTIONENDUSER.Click,
                                                                                                BTN_SELECTION_CLOSE.Click

        Dim btn As Button = Nothing
        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

        If btn Is BTN_SELECTIONLOCATION Then
            Me.Close()
            FRM_LOCATION.ShowDialog()
        ElseIf btn Is BTN_SELECTIONENDUSER Then
            Me.Close()
            FRM_ASSIGN.ShowDialog()
        ElseIf btn Is BTN_SELECTION_CLOSE Then
            Me.Close()
        End If
        'Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE1.Click
        Me.Close()
    End Sub
End Class