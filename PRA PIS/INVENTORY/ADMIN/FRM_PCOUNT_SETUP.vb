Public Class FRM_PCOUNT_SETUP
    Private Sub BTN_PHY_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_PHY_CLOSE.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BTN_GEN_CODE_Click(sender As Object, e As EventArgs) Handles BTN_GEN_CODE.Click
        WTXT_P_CODE.Text = RandomGenCode(6)
        Dim results As DialogResult = MessageBox.Show("Do you want to save this as new P.count Code?" & vbNewLine & vbNewLine & "You can't undo this action.",
                                        "Confirmation Message.",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)

        If results = DialogResult.Yes Then
            TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter.IQ_PCOUNT_CODE(WTXT_P_CODE.Text, EMP_NO, DIVISION_NO)
            Me.TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter.FillByDIV_CODE(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_PCOU_SETUP, DIVISION_NO)
            NotificationManager.Show(Me, "Successfuly save!", Color.Green, 3000)
        End If
        'If MsgBox("Do you want to save this as new P.count Code?" & vbNewLine & vbNewLine & "You can't undo this action.", vbYesNo, "Confirmation Message.", ) = vbYes Then

        'End If
    End Sub

    Private Sub FRM_PCOUNT_SETUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter.FillByDIV_CODE(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_PCOU_SETUP, DIVISION_NO)
        TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter.SQ_LATEST_CODE(DIVISION_NO)
    End Sub
End Class