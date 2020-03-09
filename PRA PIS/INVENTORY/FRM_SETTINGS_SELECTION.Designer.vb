<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_SETTINGS_SELECTION
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_SELECTIONMINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_SELECTIONCLOSE = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_SETTINGS_CATEGORY = New System.Windows.Forms.Button()
        Me.BTN_SETTINGS_SUB_CATEGORY = New System.Windows.Forms.Button()
        Me.BTN_SETTINGS_BRANDS = New System.Windows.Forms.Button()
        Me.PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_SELECTIONMINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_SELECTIONCLOSE)
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(285, 52)
        Me.PNL.TabIndex = 1403
        '
        'BTN_SELECTIONMINIMIZE
        '
        Me.BTN_SELECTIONMINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_SELECTIONMINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_SELECTIONMINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_SELECTIONMINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SELECTIONMINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_SELECTIONMINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_SELECTIONMINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SELECTIONMINIMIZE.Location = New System.Drawing.Point(218, 7)
        Me.BTN_SELECTIONMINIMIZE.Name = "BTN_SELECTIONMINIMIZE"
        Me.BTN_SELECTIONMINIMIZE.Size = New System.Drawing.Size(28, 28)
        Me.BTN_SELECTIONMINIMIZE.TabIndex = 12
        Me.BTN_SELECTIONMINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_SELECTIONMINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_SELECTIONCLOSE
        '
        Me.BTN_SELECTIONCLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_SELECTIONCLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_SELECTIONCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SELECTIONCLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_SELECTIONCLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_SELECTIONCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SELECTIONCLOSE.Location = New System.Drawing.Point(252, 7)
        Me.BTN_SELECTIONCLOSE.Name = "BTN_SELECTIONCLOSE"
        Me.BTN_SELECTIONCLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_SELECTIONCLOSE.TabIndex = 10
        Me.BTN_SELECTIONCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_SELECTIONCLOSE.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(9, 9)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(133, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "Maintenance"
        '
        'BTN_Minimize
        '
        Me.BTN_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Minimize.BackColor = System.Drawing.Color.DarkCyan
        Me.BTN_Minimize.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_Minimize.FlatAppearance.BorderSize = 3
        Me.BTN_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4220, 11)
        Me.BTN_Minimize.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_Minimize.Name = "BTN_Minimize"
        Me.BTN_Minimize.Size = New System.Drawing.Size(47, 45)
        Me.BTN_Minimize.TabIndex = 7
        Me.BTN_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Minimize.UseVisualStyleBackColor = False
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4173, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(285, 248)
        Me.ShapeContainer2.TabIndex = 1430
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(85, 156)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(121, 68)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(150, 74)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(121, 68)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(19, 74)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(121, 68)
        '
        'BTN_SETTINGS_CATEGORY
        '
        Me.BTN_SETTINGS_CATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_SETTINGS_CATEGORY.FlatAppearance.BorderSize = 0
        Me.BTN_SETTINGS_CATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_SETTINGS_CATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_SETTINGS_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SETTINGS_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SETTINGS_CATEGORY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_SETTINGS_CATEGORY.Location = New System.Drawing.Point(21, 76)
        Me.BTN_SETTINGS_CATEGORY.Name = "BTN_SETTINGS_CATEGORY"
        Me.BTN_SETTINGS_CATEGORY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_SETTINGS_CATEGORY.Size = New System.Drawing.Size(118, 65)
        Me.BTN_SETTINGS_CATEGORY.TabIndex = 1435
        Me.BTN_SETTINGS_CATEGORY.Text = "CATEGORY"
        Me.BTN_SETTINGS_CATEGORY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_SETTINGS_CATEGORY.UseVisualStyleBackColor = True
        '
        'BTN_SETTINGS_SUB_CATEGORY
        '
        Me.BTN_SETTINGS_SUB_CATEGORY.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_SETTINGS_SUB_CATEGORY.FlatAppearance.BorderSize = 0
        Me.BTN_SETTINGS_SUB_CATEGORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_SETTINGS_SUB_CATEGORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_SETTINGS_SUB_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SETTINGS_SUB_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SETTINGS_SUB_CATEGORY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_SETTINGS_SUB_CATEGORY.Location = New System.Drawing.Point(152, 76)
        Me.BTN_SETTINGS_SUB_CATEGORY.Name = "BTN_SETTINGS_SUB_CATEGORY"
        Me.BTN_SETTINGS_SUB_CATEGORY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_SETTINGS_SUB_CATEGORY.Size = New System.Drawing.Size(118, 65)
        Me.BTN_SETTINGS_SUB_CATEGORY.TabIndex = 1437
        Me.BTN_SETTINGS_SUB_CATEGORY.Text = "SUB CATEGORY"
        Me.BTN_SETTINGS_SUB_CATEGORY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_SETTINGS_SUB_CATEGORY.UseVisualStyleBackColor = True
        '
        'BTN_SETTINGS_BRANDS
        '
        Me.BTN_SETTINGS_BRANDS.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_SETTINGS_BRANDS.FlatAppearance.BorderSize = 0
        Me.BTN_SETTINGS_BRANDS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_SETTINGS_BRANDS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_SETTINGS_BRANDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SETTINGS_BRANDS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SETTINGS_BRANDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_SETTINGS_BRANDS.Location = New System.Drawing.Point(87, 158)
        Me.BTN_SETTINGS_BRANDS.Name = "BTN_SETTINGS_BRANDS"
        Me.BTN_SETTINGS_BRANDS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_SETTINGS_BRANDS.Size = New System.Drawing.Size(118, 65)
        Me.BTN_SETTINGS_BRANDS.TabIndex = 1438
        Me.BTN_SETTINGS_BRANDS.Text = "BRANDS"
        Me.BTN_SETTINGS_BRANDS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_SETTINGS_BRANDS.UseVisualStyleBackColor = True
        '
        'FRM_SETTINGS_SELECTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(285, 248)
        Me.Controls.Add(Me.BTN_SETTINGS_BRANDS)
        Me.Controls.Add(Me.BTN_SETTINGS_SUB_CATEGORY)
        Me.Controls.Add(Me.BTN_SETTINGS_CATEGORY)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_SETTINGS_SELECTION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_SETTINGS"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_SELECTIONCLOSE As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents BTN_SETTINGS_CATEGORY As Button
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents BTN_SETTINGS_SUB_CATEGORY As Button
    Friend WithEvents BTN_SETTINGS_BRANDS As Button
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents BTN_SELECTIONMINIMIZE As Button
End Class
