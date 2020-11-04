<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_IMG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RECT_CLOSE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.PB_IMG = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        CType(Me.PB_IMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RECT_CLOSE
        '
        Me.RECT_CLOSE.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_CLOSE.BorderWidth = 2
        Me.RECT_CLOSE.CornerRadius = 10
        Me.RECT_CLOSE.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_CLOSE.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_CLOSE.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_CLOSE.Location = New System.Drawing.Point(1, 1)
        Me.RECT_CLOSE.Name = "RECT_CLOSE"
        Me.RECT_CLOSE.Size = New System.Drawing.Size(297, 341)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_CLOSE})
        Me.ShapeContainer1.Size = New System.Drawing.Size(300, 345)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'PB_IMG
        '
        Me.PB_IMG.Location = New System.Drawing.Point(-1, 0)
        Me.PB_IMG.Name = "PB_IMG"
        Me.PB_IMG.Size = New System.Drawing.Size(293, 293)
        Me.PB_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_IMG.TabIndex = 1
        Me.PB_IMG.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BTN_CLOSE)
        Me.Panel1.Controls.Add(Me.PB_IMG)
        Me.Panel1.Location = New System.Drawing.Point(4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 336)
        Me.Panel1.TabIndex = 2
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 10
        Me.BTN_CLOSE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE.Location = New System.Drawing.Point(0, 292)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(292, 43)
        Me.BTN_CLOSE.TabIndex = 2
        Me.BTN_CLOSE.Text = "C L O S E"
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'FRM_IMG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(300, 345)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_IMG"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_IMG"
        CType(Me.PB_IMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RECT_CLOSE As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents PB_IMG As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_CLOSE As Button
End Class
