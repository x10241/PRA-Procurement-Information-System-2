Public Class FRM_ITEM_CODE_SELECTION
    Private Sub BTN_SEL_DR_LIST_Click(sender As Object, e As EventArgs) Handles BTN_SEL_DR_LIST.Click,
                                                                                    BTN_SEL_ISS_LIST.Click
        Dim btn As Button = Nothing
        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

        If btn Is BTN_SEL_DR_LIST Then
            Me.Close()
            FRM_ITEM_DR_LIST.ShowDialog()
        ElseIf btn Is BTN_SEL_ISS_LIST Then
            Me.Close()
            FRM_ISSUED_ITEM_LIST.LBLSETTINGSHEAD.Text = "I s s u e d  I t e m  L i s t"
            FRM_ISSUED_ITEM_LIST.ShowDialog()
        End If
    End Sub

    Private Sub BTN_INVENTORY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_CLOSE.Click
        Me.Close()
    End Sub
End Class