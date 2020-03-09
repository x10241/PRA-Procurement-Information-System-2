<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PRCANCELED
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
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_SAVE = New System.Windows.Forms.Button()
        Me.DGV_CLOSE = New System.Windows.Forms.Button()
        Me.WTXT_CANCELED_REMARKS = New PRA_PIS.WatermarkTextBox()
        Me.TblM4_PURCHASEREQUEST_CANCELEDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_CANCELEDTableAdapter()
        Me.TblM4_PURCHASEREQUESTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter()
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.SpM4_PURCHASELISTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_PURCHASELISTTableAdapter()
        Me.PNL.SuspendLayout()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(287, 40)
        Me.PNL.TabIndex = 1408
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(9, 11)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(132, 16)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "C A N C E L E D  P R"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4218, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4171, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(6, 49)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(275, 121)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(287, 222)
        Me.ShapeContainer1.TabIndex = 1409
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 1410
        Me.Label1.Text = "Remarks"
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_SAVE.Location = New System.Drawing.Point(51, 178)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(92, 32)
        Me.BTN_SAVE.TabIndex = 1411
        Me.BTN_SAVE.Text = "SAVE"
        Me.BTN_SAVE.UseVisualStyleBackColor = True
        '
        'DGV_CLOSE
        '
        Me.DGV_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.DGV_CLOSE.FlatAppearance.BorderSize = 5
        Me.DGV_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.DGV_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DGV_CLOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.DGV_CLOSE.Location = New System.Drawing.Point(149, 178)
        Me.DGV_CLOSE.Name = "DGV_CLOSE"
        Me.DGV_CLOSE.Size = New System.Drawing.Size(90, 32)
        Me.DGV_CLOSE.TabIndex = 1412
        Me.DGV_CLOSE.Text = "CLOSE"
        Me.DGV_CLOSE.UseVisualStyleBackColor = True
        '
        'WTXT_CANCELED_REMARKS
        '
        Me.WTXT_CANCELED_REMARKS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_CANCELED_REMARKS.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_CANCELED_REMARKS.Location = New System.Drawing.Point(12, 59)
        Me.WTXT_CANCELED_REMARKS.MaxLength = 300
        Me.WTXT_CANCELED_REMARKS.Multiline = True
        Me.WTXT_CANCELED_REMARKS.Name = "WTXT_CANCELED_REMARKS"
        Me.WTXT_CANCELED_REMARKS.Size = New System.Drawing.Size(263, 107)
        Me.WTXT_CANCELED_REMARKS.TabIndex = 1418
        Me.WTXT_CANCELED_REMARKS.Watermark = Nothing
        '
        'TblM4_PURCHASEREQUEST_CANCELEDTableAdapter
        '
        Me.TblM4_PURCHASEREQUEST_CANCELEDTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUESTTableAdapter
        '
        Me.TblM4_PURCHASEREQUESTTableAdapter.ClearBeforeFill = True
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpM4_PURCHASELISTTableAdapter
        '
        Me.SpM4_PURCHASELISTTableAdapter.ClearBeforeFill = True
        '
        'FRM_PRCANCELED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(287, 222)
        Me.Controls.Add(Me.WTXT_CANCELED_REMARKS)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.DGV_CLOSE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FRM_PRCANCELED"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_PRCANCELED"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents DGV_CLOSE As Button
    Friend WithEvents WTXT_CANCELED_REMARKS As WatermarkTextBox
    Friend WithEvents TblM4_PURCHASEREQUEST_CANCELEDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_CANCELEDTableAdapter
    Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents SpM4_PURCHASELISTTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_PURCHASELISTTableAdapter
End Class
