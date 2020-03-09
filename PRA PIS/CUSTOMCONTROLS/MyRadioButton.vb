
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Class MyRadioButton
    Inherits RadioButton

    Public Sub New()
        Me.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(ByVal value As Boolean)
            MyBase.AutoSize = False
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim h As Integer = Me.ClientSize.Height - 2
        Dim rc As Rectangle = New Rectangle(New Point(0, 1), New Size(h, h))
        ControlPaint.DrawCheckBox(e.Graphics, rc, If(Me.Checked, ButtonState.Checked, ButtonState.Normal))
    End Sub
End Class