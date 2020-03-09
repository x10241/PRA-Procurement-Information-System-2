Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_PURCHASE_ORDER

#Region "START ##### FORM DRAG AND DROP, MINIMIZE, CLOSE"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PNL_DoubleClick(sender As Object, e As EventArgs) Handles PNL.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseUp
        drag = False
    End Sub
#End Region

    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function

    Private Sub BTN_PRCLOSE_Click(sender As Object, e As EventArgs) Handles BTN_PRCLOSE.Click,
                                                                            BTN_PRMINIMIZE.Click

        Dim pb As PictureBox = Nothing
        Dim lbl As Label = Nothing
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
        ElseIf TypeOf sender Is Label Then
            lbl = CType(sender, Label)
        ElseIf TypeOf sender Is TextBox Then
            TXTGLOBAL = CType(sender, TextBox)
        End If

        If btn Is BTN_PRCLOSE Then
            Me.Close()
            'MINIMIZE BUTTON
        ElseIf btn Is BTN_PRMINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
End Class