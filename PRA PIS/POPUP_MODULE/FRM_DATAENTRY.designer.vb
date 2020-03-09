<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_DATAENTRY
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
        Me.components = New System.ComponentModel.Container()
        Me.MTB_DATEFrom = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.RECT_APPSave = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_APPClear = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape78 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LLBL_APPSave = New System.Windows.Forms.LinkLabel()
        Me.BTN_APPSave = New System.Windows.Forms.Button()
        Me.LLBL_APPClear = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSRRVHEADER = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.A_CLOSEPROGRAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.A_CLOSEPROGRAMTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.A_CLOSEPROGRAMTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A_CLOSEPROGRAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MTB_DATEFrom
        '
        Me.MTB_DATEFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MTB_DATEFrom.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTB_DATEFrom.Location = New System.Drawing.Point(41, 63)
        Me.MTB_DATEFrom.Mask = "00/00/0000"
        Me.MTB_DATEFrom.Name = "MTB_DATEFrom"
        Me.MTB_DATEFrom.Size = New System.Drawing.Size(115, 24)
        Me.MTB_DATEFrom.TabIndex = 0
        Me.MTB_DATEFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpDate
        '
        Me.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(265, 14)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(83, 21)
        Me.dtpDate.TabIndex = 530
        '
        'RECT_APPSave
        '
        Me.RECT_APPSave.BorderColor = System.Drawing.Color.SpringGreen
        Me.RECT_APPSave.BorderWidth = 5
        Me.RECT_APPSave.CornerRadius = 15
        Me.RECT_APPSave.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RECT_APPSave.Location = New System.Drawing.Point(25, 106)
        Me.RECT_APPSave.Name = "RECT_APPSave"
        Me.RECT_APPSave.Size = New System.Drawing.Size(70, 30)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(231, 180)
        Me.ShapeContainer1.TabIndex = 531
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape2.BackColor = System.Drawing.Color.White
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Teal
        Me.RectangleShape2.BorderWidth = 10
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.FillColor = System.Drawing.Color.White
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape2.Location = New System.Drawing.Point(9, 8)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(213, 159)
        '
        'RECT_APPClear
        '
        Me.RECT_APPClear.BorderColor = System.Drawing.Color.Crimson
        Me.RECT_APPClear.BorderWidth = 5
        Me.RECT_APPClear.CornerRadius = 15
        Me.RECT_APPClear.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RECT_APPClear.Location = New System.Drawing.Point(104, 106)
        Me.RECT_APPClear.Name = "RECT_APPClear"
        Me.RECT_APPClear.Size = New System.Drawing.Size(70, 30)
        '
        'RectangleShape78
        '
        Me.RectangleShape78.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape78.BorderWidth = 2
        Me.RectangleShape78.CornerRadius = 3
        Me.RectangleShape78.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape78.Location = New System.Drawing.Point(35, 57)
        Me.RectangleShape78.Name = "RectangleShape78"
        Me.RectangleShape78.Size = New System.Drawing.Size(126, 35)
        '
        'LLBL_APPSave
        '
        Me.LLBL_APPSave.ActiveLinkColor = System.Drawing.Color.Blue
        Me.LLBL_APPSave.AutoSize = True
        Me.LLBL_APPSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_APPSave.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LLBL_APPSave.LinkColor = System.Drawing.Color.LimeGreen
        Me.LLBL_APPSave.Location = New System.Drawing.Point(43, 112)
        Me.LLBL_APPSave.Name = "LLBL_APPSave"
        Me.LLBL_APPSave.Size = New System.Drawing.Size(32, 19)
        Me.LLBL_APPSave.TabIndex = 1103
        Me.LLBL_APPSave.TabStop = True
        Me.LLBL_APPSave.Text = "OK"
        '
        'BTN_APPSave
        '
        Me.BTN_APPSave.Location = New System.Drawing.Point(302, 61)
        Me.BTN_APPSave.Name = "BTN_APPSave"
        Me.BTN_APPSave.Size = New System.Drawing.Size(14, 23)
        Me.BTN_APPSave.TabIndex = 1104
        Me.BTN_APPSave.Text = "Button1"
        Me.BTN_APPSave.UseVisualStyleBackColor = True
        '
        'LLBL_APPClear
        '
        Me.LLBL_APPClear.ActiveLinkColor = System.Drawing.Color.Blue
        Me.LLBL_APPClear.AutoSize = True
        Me.LLBL_APPClear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_APPClear.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LLBL_APPClear.LinkColor = System.Drawing.Color.Crimson
        Me.LLBL_APPClear.Location = New System.Drawing.Point(110, 112)
        Me.LLBL_APPClear.Name = "LLBL_APPClear"
        Me.LLBL_APPClear.Size = New System.Drawing.Size(57, 19)
        Me.LLBL_APPClear.TabIndex = 1105
        Me.LLBL_APPClear.TabStop = True
        Me.LLBL_APPClear.Text = "CLEAR"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BTN_CLOSE)
        Me.Panel1.Controls.Add(Me.LBLSRRVHEADER)
        Me.Panel1.Controls.Add(Me.MTB_DATEFrom)
        Me.Panel1.Controls.Add(Me.LLBL_APPClear)
        Me.Panel1.Controls.Add(Me.LLBL_APPSave)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(14, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 149)
        Me.Panel1.TabIndex = 1106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(46, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 1114
        Me.Label1.Text = "MM/DD/YYYY"
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(169, 3)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_CLOSE.TabIndex = 1113
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSRRVHEADER
        '
        Me.LBLSRRVHEADER.AutoSize = True
        Me.LBLSRRVHEADER.BackColor = System.Drawing.Color.Transparent
        Me.LBLSRRVHEADER.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSRRVHEADER.ForeColor = System.Drawing.Color.DimGray
        Me.LBLSRRVHEADER.Location = New System.Drawing.Point(5, 5)
        Me.LBLSRRVHEADER.Name = "LBLSRRVHEADER"
        Me.LBLSRRVHEADER.Size = New System.Drawing.Size(97, 19)
        Me.LBLSRRVHEADER.TabIndex = 1112
        Me.LBLSRRVHEADER.Text = "DATE ENTRY"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_APPClear, Me.RECT_APPSave, Me.RectangleShape78})
        Me.ShapeContainer2.Size = New System.Drawing.Size(202, 149)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'A_CLOSEPROGRAMBindingSource
        '
        Me.A_CLOSEPROGRAMBindingSource.DataMember = "A_CLOSEPROGRAM"
        Me.A_CLOSEPROGRAMBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'A_CLOSEPROGRAMTableAdapter
        '
        Me.A_CLOSEPROGRAMTableAdapter.ClearBeforeFill = True
        '
        'FRM_DATAENTRY
        '
        Me.AcceptButton = Me.BTN_APPSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(231, 180)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_APPSave)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_DATAENTRY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = ".0"
        Me.TransparencyKey = System.Drawing.SystemColors.ControlLight
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A_CLOSEPROGRAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MTB_DATEFrom As MaskedTextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents RECT_APPSave As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LLBL_APPSave As LinkLabel
    Friend WithEvents RectangleShape78 As PowerPacks.RectangleShape
    Friend WithEvents BTN_APPSave As Button
    Friend WithEvents RECT_APPClear As PowerPacks.RectangleShape
    Friend WithEvents LLBL_APPClear As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LBLSRRVHEADER As Label
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents A_CLOSEPROGRAMBindingSource As BindingSource
    Friend WithEvents A_CLOSEPROGRAMTableAdapter As DS_STOREDPROCTableAdapters.A_CLOSEPROGRAMTableAdapter
End Class
