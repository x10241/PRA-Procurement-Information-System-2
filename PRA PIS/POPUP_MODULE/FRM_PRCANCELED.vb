Public Class FRM_PRCANCELED
    Private Sub FRM_PRCANCELED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WTXT_CANCELED_REMARKS.SelectAll()
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click, DGV_CLOSE.Click

        Dim btn As Button = Nothing

        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

        If btn Is BTN_SAVE Then
            TblM4_PURCHASEREQUESTTableAdapter.UQ_UPDATEPRSTATUS("3", EMP_NO, PRNO)
            TblM4_PURCHASEREQUEST_CANCELEDTableAdapter.IQ_CANCELEDPR(PRNO, WTXT_CANCELED_REMARKS.Text, EMP_NO)
            MsgBox("Successfully Saved.", MsgBoxStyle.Information)
            PNL_SLIDE.Location = New Point(1095, 40)
            Me.Close()
        ElseIf btn Is DGV_CLOSE Then
            Me.Close()
        End If
    End Sub
End Class