<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_STOCKS_DIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_STOCKS_DIST))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WTXT_NO_OF_STOCKS = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WTXT_APPROVED_QUANTITY = New System.Windows.Forms.TextBox()
        Me.RECT_PRREQUESTEDDATE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_CANCEL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LLBL_CANCEL = New System.Windows.Forms.LinkLabel()
        Me.PB_CANCEL = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PB_CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WTXT_NO_OF_STOCKS)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 145)
        Me.GroupBox1.TabIndex = 1495
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "No. of Stocks"
        '
        'WTXT_NO_OF_STOCKS
        '
        Me.WTXT_NO_OF_STOCKS.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WTXT_NO_OF_STOCKS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_NO_OF_STOCKS.Font = New System.Drawing.Font("Century Gothic", 65.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_NO_OF_STOCKS.Location = New System.Drawing.Point(6, 26)
        Me.WTXT_NO_OF_STOCKS.Name = "WTXT_NO_OF_STOCKS"
        Me.WTXT_NO_OF_STOCKS.ReadOnly = True
        Me.WTXT_NO_OF_STOCKS.Size = New System.Drawing.Size(291, 107)
        Me.WTXT_NO_OF_STOCKS.TabIndex = 1
        Me.WTXT_NO_OF_STOCKS.Text = "0"
        Me.WTXT_NO_OF_STOCKS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WTXT_APPROVED_QUANTITY)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(321, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 145)
        Me.GroupBox2.TabIndex = 1496
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Approved Quantity"
        '
        'WTXT_APPROVED_QUANTITY
        '
        Me.WTXT_APPROVED_QUANTITY.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WTXT_APPROVED_QUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_APPROVED_QUANTITY.Font = New System.Drawing.Font("Century Gothic", 65.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_APPROVED_QUANTITY.Location = New System.Drawing.Point(6, 26)
        Me.WTXT_APPROVED_QUANTITY.Name = "WTXT_APPROVED_QUANTITY"
        Me.WTXT_APPROVED_QUANTITY.Size = New System.Drawing.Size(291, 107)
        Me.WTXT_APPROVED_QUANTITY.TabIndex = 1
        Me.WTXT_APPROVED_QUANTITY.Text = "0"
        Me.WTXT_APPROVED_QUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RECT_PRREQUESTEDDATE
        '
        Me.RECT_PRREQUESTEDDATE.BorderColor = System.Drawing.Color.Gray
        Me.RECT_PRREQUESTEDDATE.BorderWidth = 2
        Me.RECT_PRREQUESTEDDATE.CornerRadius = 5
        Me.RECT_PRREQUESTEDDATE.Location = New System.Drawing.Point(3, 3)
        Me.RECT_PRREQUESTEDDATE.Name = "RECT_PRREQUESTEDDATE"
        Me.RECT_PRREQUESTEDDATE.Size = New System.Drawing.Size(626, 155)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_CANCEL, Me.RECT_PRREQUESTEDDATE})
        Me.ShapeContainer1.Size = New System.Drawing.Size(633, 200)
        Me.ShapeContainer1.TabIndex = 1497
        Me.ShapeContainer1.TabStop = False
        '
        'RECT_CANCEL
        '
        Me.RECT_CANCEL.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_CANCEL.BorderWidth = 2
        Me.RECT_CANCEL.CornerRadius = 13
        Me.RECT_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_CANCEL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_CANCEL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_CANCEL.Location = New System.Drawing.Point(502, 165)
        Me.RECT_CANCEL.Name = "RECT_CANCEL"
        Me.RECT_CANCEL.Size = New System.Drawing.Size(120, 30)
        '
        'LLBL_CANCEL
        '
        Me.LLBL_CANCEL.AutoSize = True
        Me.LLBL_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_CANCEL.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_CANCEL.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_CANCEL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_CANCEL.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_CANCEL.Location = New System.Drawing.Point(543, 171)
        Me.LLBL_CANCEL.Name = "LLBL_CANCEL"
        Me.LLBL_CANCEL.Size = New System.Drawing.Size(69, 19)
        Me.LLBL_CANCEL.TabIndex = 1543
        Me.LLBL_CANCEL.TabStop = True
        Me.LLBL_CANCEL.Text = "Cancel"
        '
        'PB_CANCEL
        '
        Me.PB_CANCEL.BackgroundImage = CType(resources.GetObject("PB_CANCEL.BackgroundImage"), System.Drawing.Image)
        Me.PB_CANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_CANCEL.InitialImage = Nothing
        Me.PB_CANCEL.Location = New System.Drawing.Point(514, 167)
        Me.PB_CANCEL.Name = "PB_CANCEL"
        Me.PB_CANCEL.Size = New System.Drawing.Size(28, 28)
        Me.PB_CANCEL.TabIndex = 1542
        Me.PB_CANCEL.TabStop = False
        '
        'FRM_STOCKS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 200)
        Me.Controls.Add(Me.LLBL_CANCEL)
        Me.Controls.Add(Me.PB_CANCEL)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_STOCKS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_STOCKS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PB_CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WTXT_NO_OF_STOCKS As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents WTXT_APPROVED_QUANTITY As TextBox
    Friend WithEvents RECT_PRREQUESTEDDATE As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_CANCEL As PowerPacks.RectangleShape
    Friend WithEvents LLBL_CANCEL As LinkLabel
    Friend WithEvents PB_CANCEL As PictureBox
End Class
