<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ABSTRACT_OF_QUOTATION
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
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_PRMINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_PRCLOSE = New System.Windows.Forms.Button()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_PRMINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_PRCLOSE)
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1095, 49)
        Me.PNL.TabIndex = 1404
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(12, 14)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(335, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "A B S T R A C T  O F  Q U O T A T I O N"
        '
        'BTN_PRMINIMIZE
        '
        Me.BTN_PRMINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_PRMINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_PRMINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_PRMINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_PRMINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_PRMINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_PRMINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PRMINIMIZE.Location = New System.Drawing.Point(1027, 8)
        Me.BTN_PRMINIMIZE.Name = "BTN_PRMINIMIZE"
        Me.BTN_PRMINIMIZE.Size = New System.Drawing.Size(28, 28)
        Me.BTN_PRMINIMIZE.TabIndex = 11
        Me.BTN_PRMINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_PRMINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_PRCLOSE
        '
        Me.BTN_PRCLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_PRCLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_PRCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_PRCLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_PRCLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_PRCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PRCLOSE.Location = New System.Drawing.Point(1062, 7)
        Me.BTN_PRCLOSE.Name = "BTN_PRCLOSE"
        Me.BTN_PRCLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_PRCLOSE.TabIndex = 10
        Me.BTN_PRCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_PRCLOSE.UseVisualStyleBackColor = True
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3410, 11)
        Me.BTN_Minimize.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3363, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'FRM_ABSTRACT_OF_QUOTATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 660)
        Me.Controls.Add(Me.PNL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ABSTRACT_OF_QUOTATION"
        Me.Text = "FRM_ABSTRACT_OF_QUOTATION"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_PRMINIMIZE As Button
    Friend WithEvents BTN_PRCLOSE As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
End Class
