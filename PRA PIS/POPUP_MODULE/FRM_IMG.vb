Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_IMG
    Private Sub LLBL_CLOSE_LinkClicked(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Try
            Dim btn As Button = Nothing

            If TypeOf sender Is Button Then
                btn = CType(sender, Button)
            End If

            If btn Is BTN_CLOSE Then
                Me.Close()
            End If
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub

    Private Sub FRM_IMG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _IMGPATH = "0" Then
            PB_IMG.Image = My.Resources._480px_No_image_available_svg
        Else
            PB_IMG.Image = Image.FromFile(_IMGPATH)
        End If
    End Sub

End Class