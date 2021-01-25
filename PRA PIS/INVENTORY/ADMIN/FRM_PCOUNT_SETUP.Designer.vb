<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PCOUNT_SETUP
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_PHY_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.BTN_GEN_CODE = New System.Windows.Forms.Button()
        Me.DGV_PCOUNT_LIST = New System.Windows.Forms.DataGridView()
        Me.PCSEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREATEDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREATEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEFORMATTEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLM4INVITEMSPCOUSETUPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter()
        Me.WTXT_P_CODE = New PRA_PIS.WatermarkTextBox()
        Me.PNL.SuspendLayout()
        CType(Me.DGV_PCOUNT_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVITEMSPCOUSETUPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_PHY_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(400, 49)
        Me.PNL.TabIndex = 1409
        '
        'BTN_PHY_CLOSE
        '
        Me.BTN_PHY_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_PHY_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_PHY_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_PHY_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_PHY_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_PHY_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PHY_CLOSE.Location = New System.Drawing.Point(360, 9)
        Me.BTN_PHY_CLOSE.Name = "BTN_PHY_CLOSE"
        Me.BTN_PHY_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_PHY_CLOSE.TabIndex = 16
        Me.BTN_PHY_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_PHY_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(9, 12)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(183, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "P C o u n t  S e t u p"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-12048, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-12001, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(23, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 17)
        Me.Label13.TabIndex = 1498
        Me.Label13.Text = "Code"
        '
        'RectangleShape12
        '
        Me.RectangleShape12.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape12.CornerRadius = 5
        Me.RectangleShape12.Location = New System.Drawing.Point(11, 65)
        Me.RectangleShape12.Name = "RectangleShape12"
        Me.RectangleShape12.Size = New System.Drawing.Size(235, 29)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape12})
        Me.ShapeContainer1.Size = New System.Drawing.Size(400, 379)
        Me.ShapeContainer1.TabIndex = 1499
        Me.ShapeContainer1.TabStop = False
        '
        'BTN_GEN_CODE
        '
        Me.BTN_GEN_CODE.BackColor = System.Drawing.Color.DodgerBlue
        Me.BTN_GEN_CODE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_GEN_CODE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_GEN_CODE.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BTN_GEN_CODE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_GEN_CODE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.BTN_GEN_CODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GEN_CODE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GEN_CODE.ForeColor = System.Drawing.Color.White
        Me.BTN_GEN_CODE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_GEN_CODE.Location = New System.Drawing.Point(236, 65)
        Me.BTN_GEN_CODE.Name = "BTN_GEN_CODE"
        Me.BTN_GEN_CODE.Size = New System.Drawing.Size(153, 30)
        Me.BTN_GEN_CODE.TabIndex = 1547
        Me.BTN_GEN_CODE.Text = "Generate Code"
        Me.BTN_GEN_CODE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_GEN_CODE.UseVisualStyleBackColor = False
        '
        'DGV_PCOUNT_LIST
        '
        Me.DGV_PCOUNT_LIST.AllowUserToAddRows = False
        Me.DGV_PCOUNT_LIST.AllowUserToDeleteRows = False
        Me.DGV_PCOUNT_LIST.AllowUserToResizeColumns = False
        Me.DGV_PCOUNT_LIST.AllowUserToResizeRows = False
        Me.DGV_PCOUNT_LIST.AutoGenerateColumns = False
        Me.DGV_PCOUNT_LIST.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_PCOUNT_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_PCOUNT_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PCOUNT_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PCSEIDDataGridViewTextBoxColumn, Me.CREATEDDATEDataGridViewTextBoxColumn, Me.CREATEDBYDataGridViewTextBoxColumn, Me.DATEFORMATTEDDataGridViewTextBoxColumn})
        Me.DGV_PCOUNT_LIST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_PCOUNT_LIST.DataSource = Me.TBLM4INVITEMSPCOUSETUPBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_PCOUNT_LIST.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_PCOUNT_LIST.Location = New System.Drawing.Point(11, 102)
        Me.DGV_PCOUNT_LIST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_PCOUNT_LIST.MultiSelect = False
        Me.DGV_PCOUNT_LIST.Name = "DGV_PCOUNT_LIST"
        Me.DGV_PCOUNT_LIST.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_PCOUNT_LIST.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_PCOUNT_LIST.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        Me.DGV_PCOUNT_LIST.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_PCOUNT_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PCOUNT_LIST.Size = New System.Drawing.Size(379, 264)
        Me.DGV_PCOUNT_LIST.TabIndex = 1548
        '
        'PCSEIDDataGridViewTextBoxColumn
        '
        Me.PCSEIDDataGridViewTextBoxColumn.DataPropertyName = "PCSE_ID"
        Me.PCSEIDDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.PCSEIDDataGridViewTextBoxColumn.Name = "PCSEIDDataGridViewTextBoxColumn"
        Me.PCSEIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PCSEIDDataGridViewTextBoxColumn.Width = 150
        '
        'CREATEDDATEDataGridViewTextBoxColumn
        '
        Me.CREATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATED_DATE"
        Me.CREATEDDATEDataGridViewTextBoxColumn.HeaderText = "CREATED_DATE"
        Me.CREATEDDATEDataGridViewTextBoxColumn.Name = "CREATEDDATEDataGridViewTextBoxColumn"
        Me.CREATEDDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CREATEDDATEDataGridViewTextBoxColumn.Visible = False
        '
        'CREATEDBYDataGridViewTextBoxColumn
        '
        Me.CREATEDBYDataGridViewTextBoxColumn.DataPropertyName = "CREATED_BY"
        Me.CREATEDBYDataGridViewTextBoxColumn.HeaderText = "CREATED_BY"
        Me.CREATEDBYDataGridViewTextBoxColumn.Name = "CREATEDBYDataGridViewTextBoxColumn"
        Me.CREATEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.CREATEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'DATEFORMATTEDDataGridViewTextBoxColumn
        '
        Me.DATEFORMATTEDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DATEFORMATTEDDataGridViewTextBoxColumn.DataPropertyName = "DATE_FORMATTED"
        Me.DATEFORMATTEDDataGridViewTextBoxColumn.HeaderText = "Date Created"
        Me.DATEFORMATTEDDataGridViewTextBoxColumn.Name = "DATEFORMATTEDDataGridViewTextBoxColumn"
        Me.DATEFORMATTEDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBLM4INVITEMSPCOUSETUPBindingSource
        '
        Me.TBLM4INVITEMSPCOUSETUPBindingSource.DataMember = "TBLM4_INV_ITEMS_PCOU_SETUP"
        Me.TBLM4INVITEMSPCOUSETUPBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter
        '
        Me.TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter.ClearBeforeFill = True
        '
        'WTXT_P_CODE
        '
        Me.WTXT_P_CODE.BackColor = System.Drawing.Color.White
        Me.WTXT_P_CODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_P_CODE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_P_CODE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBLM4INVITEMSPCOUSETUPBindingSource, "PCSE_ID", True))
        Me.WTXT_P_CODE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_P_CODE.ForeColor = System.Drawing.Color.Black
        Me.WTXT_P_CODE.Location = New System.Drawing.Point(19, 70)
        Me.WTXT_P_CODE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_P_CODE.MaxLength = 300
        Me.WTXT_P_CODE.Name = "WTXT_P_CODE"
        Me.WTXT_P_CODE.ReadOnly = True
        Me.WTXT_P_CODE.Size = New System.Drawing.Size(211, 21)
        Me.WTXT_P_CODE.TabIndex = 1504
        Me.WTXT_P_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_P_CODE.Watermark = ""
        '
        'FRM_PCOUNT_SETUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 379)
        Me.Controls.Add(Me.DGV_PCOUNT_LIST)
        Me.Controls.Add(Me.BTN_GEN_CODE)
        Me.Controls.Add(Me.WTXT_P_CODE)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_PCOUNT_SETUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "`"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DGV_PCOUNT_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVITEMSPCOUSETUPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_PHY_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents RectangleShape12 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents WTXT_P_CODE As WatermarkTextBox
    Friend WithEvents BTN_GEN_CODE As Button
    Friend WithEvents DGV_PCOUNT_LIST As DataGridView
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TBLM4INVITEMSPCOUSETUPBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter
    Friend WithEvents PCSEIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CREATEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CREATEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEFORMATTEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
