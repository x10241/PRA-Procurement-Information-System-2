Public Class FRM_DISCONNECTED
    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        FRM_LOGIN.Close()
    End Sub

    Private Sub TMR_MDIMAIN_Tick(sender As Object, e As EventArgs) Handles TMR_MDIMAIN.Tick

    End Sub

    Private Sub FRM_DISCONNECTED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TMR_MDIMAIN.Start()
    End Sub
End Class