Option Strict On
Option Explicit On

Public Class Toggle
    Inherits System.Windows.Forms.Control

    Private _checked As Boolean
    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(ByVal value As Boolean)
            If Not _checked.Equals(value) Then
                _checked = value
                Me.OnCheckedChanged()
            End If
        End Set
    End Property

    Protected Overridable Sub OnCheckedChanged()
        RaiseEvent CheckedChanged(Me, EventArgs.Empty)
    End Sub

    Public Event CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        Me.Checked = Not Me.Checked
        Me.Invalidate()
        MyBase.OnMouseClick(e)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        'Draw a transparent background
        Using parentColor As Pen = New Pen(Me.Parent.BackColor, 10)
            e.Graphics.DrawRectangle(parentColor, Me.DisplayRectangle)
        End Using

        'Draw the "slider" border
        ControlPaint.DrawBorder(e.Graphics, New Rectangle(5, 5, Me.Width - 10, Me.Height - 10), SystemColors.ControlDark, ButtonBorderStyle.Solid)

        'Draw the "grip"
        ControlPaint.DrawGrabHandle(e.Graphics, New Rectangle(If(Me.Checked, 0, Me.Width - 25), 0, 25, Me.Height), True, True)

        MyBase.OnPaint(e)
    End Sub

End Class