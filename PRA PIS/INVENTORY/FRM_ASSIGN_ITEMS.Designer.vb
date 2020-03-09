<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ASSIGN_ITEMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ASSIGN_ITEMS))
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_SELECTION_CLOSE = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_GENERATE_REPORT = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_INVENTORY_CANCEL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_LIST_PREFERRED_ITEMS = New PRA_PIS.WatermarkTextBox()
        Me.DGV_ASSIGN_ITEMS_LIST = New System.Windows.Forms.DataGridView()
        Me.CATNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBCATEGORYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BRANDNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERIALNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALCOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfAcquisitionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateEncodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIVISIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPM4ASSIGNITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SpM4_ASSIGN_ITEMSTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ASSIGN_ITEMSTableAdapter()
        Me.PNL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ASSIGN_ITEMS_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4ASSIGNITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_SELECTION_CLOSE)
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1015, 42)
        Me.PNL.TabIndex = 1415
        '
        'BTN_SELECTION_CLOSE
        '
        Me.BTN_SELECTION_CLOSE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_SELECTION_CLOSE.BackgroundImage = CType(resources.GetObject("BTN_SELECTION_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_SELECTION_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_SELECTION_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_SELECTION_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SELECTION_CLOSE.Location = New System.Drawing.Point(982, 8)
        Me.BTN_SELECTION_CLOSE.Name = "BTN_SELECTION_CLOSE"
        Me.BTN_SELECTION_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_SELECTION_CLOSE.TabIndex = 17
        Me.BTN_SELECTION_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_SELECTION_CLOSE.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(12, 11)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(240, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "A S S I G N  I T E M S  L I S T"
        '
        'BTN_Minimize
        '
        Me.BTN_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Minimize.BackColor = System.Drawing.Color.DarkCyan
        Me.BTN_Minimize.BackgroundImage = CType(resources.GetObject("BTN_Minimize.BackgroundImage"), System.Drawing.Image)
        Me.BTN_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_Minimize.FlatAppearance.BorderSize = 3
        Me.BTN_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3490, 11)
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
        Me.BTN_CLOSE.BackgroundImage = CType(resources.GetObject("BTN_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3443, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BTN_GENERATE_REPORT)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(1, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 58)
        Me.Panel1.TabIndex = 1473
        '
        'BTN_GENERATE_REPORT
        '
        Me.BTN_GENERATE_REPORT.BackColor = System.Drawing.Color.White
        Me.BTN_GENERATE_REPORT.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GENERATE_REPORT.FlatAppearance.BorderSize = 0
        Me.BTN_GENERATE_REPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_GENERATE_REPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GENERATE_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GENERATE_REPORT.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_GENERATE_REPORT.Image = CType(resources.GetObject("BTN_GENERATE_REPORT.Image"), System.Drawing.Image)
        Me.BTN_GENERATE_REPORT.Location = New System.Drawing.Point(863, 8)
        Me.BTN_GENERATE_REPORT.Name = "BTN_GENERATE_REPORT"
        Me.BTN_GENERATE_REPORT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_GENERATE_REPORT.Size = New System.Drawing.Size(128, 41)
        Me.BTN_GENERATE_REPORT.TabIndex = 1472
        Me.BTN_GENERATE_REPORT.Text = "GENERATE REPORT"
        Me.BTN_GENERATE_REPORT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_GENERATE_REPORT.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.AutoScroll = True
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_INVENTORY_CANCEL})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1009, 56)
        Me.ShapeContainer2.TabIndex = 1470
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_INVENTORY_CANCEL
        '
        Me.RECT_INVENTORY_CANCEL.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_INVENTORY_CANCEL.BorderWidth = 2
        Me.RECT_INVENTORY_CANCEL.CornerRadius = 5
        Me.RECT_INVENTORY_CANCEL.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_CANCEL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_CANCEL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_CANCEL.Location = New System.Drawing.Point(861, 6)
        Me.RECT_INVENTORY_CANCEL.Name = "RECT_INVENTORY_CANCEL"
        Me.RECT_INVENTORY_CANCEL.Size = New System.Drawing.Size(131, 44)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.Panel2.Controls.Add(Me.WTXT_LIST_PREFERRED_ITEMS)
        Me.Panel2.Controls.Add(Me.DGV_ASSIGN_ITEMS_LIST)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(1, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1011, 449)
        Me.Panel2.TabIndex = 1474
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(970, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox1.TabIndex = 1477
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PB_INVENTORY_SEARCH
        '
        Me.PB_INVENTORY_SEARCH.BackgroundImage = CType(resources.GetObject("PB_INVENTORY_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_INVENTORY_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_SEARCH.Location = New System.Drawing.Point(11, 8)
        Me.PB_INVENTORY_SEARCH.Name = "PB_INVENTORY_SEARCH"
        Me.PB_INVENTORY_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_SEARCH.TabIndex = 1468
        Me.PB_INVENTORY_SEARCH.TabStop = False
        '
        'WTXT_LIST_PREFERRED_ITEMS
        '
        Me.WTXT_LIST_PREFERRED_ITEMS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_LIST_PREFERRED_ITEMS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_LIST_PREFERRED_ITEMS.ForeColor = System.Drawing.Color.Black
        Me.WTXT_LIST_PREFERRED_ITEMS.Location = New System.Drawing.Point(46, 12)
        Me.WTXT_LIST_PREFERRED_ITEMS.MaxLength = 15
        Me.WTXT_LIST_PREFERRED_ITEMS.Name = "WTXT_LIST_PREFERRED_ITEMS"
        Me.WTXT_LIST_PREFERRED_ITEMS.Size = New System.Drawing.Size(918, 20)
        Me.WTXT_LIST_PREFERRED_ITEMS.TabIndex = 1467
        Me.WTXT_LIST_PREFERRED_ITEMS.Watermark = "Search Item Code, Category, Sub Category, Brand/Provider, Serial No., Item Descri" &
    "ption"
        '
        'DGV_ASSIGN_ITEMS_LIST
        '
        Me.DGV_ASSIGN_ITEMS_LIST.AllowUserToAddRows = False
        Me.DGV_ASSIGN_ITEMS_LIST.AllowUserToDeleteRows = False
        Me.DGV_ASSIGN_ITEMS_LIST.AllowUserToResizeColumns = False
        Me.DGV_ASSIGN_ITEMS_LIST.AllowUserToResizeRows = False
        Me.DGV_ASSIGN_ITEMS_LIST.AutoGenerateColumns = False
        Me.DGV_ASSIGN_ITEMS_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ASSIGN_ITEMS_LIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_ASSIGN_ITEMS_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_ASSIGN_ITEMS_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ASSIGN_ITEMS_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CATNAMEDataGridViewTextBoxColumn, Me.SUBCATEGORYDataGridViewTextBoxColumn, Me.BRANDNAMEDataGridViewTextBoxColumn, Me.ITEMCODEDataGridViewTextBoxColumn, Me.SERIALNODataGridViewTextBoxColumn, Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn, Me.TOTALCOSTDataGridViewTextBoxColumn, Me.DateOfAcquisitionDataGridViewTextBoxColumn, Me.DateEncodeDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.DIVISIONDataGridViewTextBoxColumn})
        Me.DGV_ASSIGN_ITEMS_LIST.DataSource = Me.SPM4ASSIGNITEMSBindingSource
        Me.DGV_ASSIGN_ITEMS_LIST.Location = New System.Drawing.Point(3, 43)
        Me.DGV_ASSIGN_ITEMS_LIST.Name = "DGV_ASSIGN_ITEMS_LIST"
        Me.DGV_ASSIGN_ITEMS_LIST.ReadOnly = True
        Me.DGV_ASSIGN_ITEMS_LIST.RowHeadersVisible = False
        Me.DGV_ASSIGN_ITEMS_LIST.Size = New System.Drawing.Size(1003, 401)
        Me.DGV_ASSIGN_ITEMS_LIST.TabIndex = 0
        '
        'CATNAMEDataGridViewTextBoxColumn
        '
        Me.CATNAMEDataGridViewTextBoxColumn.DataPropertyName = "CAT NAME"
        Me.CATNAMEDataGridViewTextBoxColumn.HeaderText = "CAT NAME"
        Me.CATNAMEDataGridViewTextBoxColumn.Name = "CATNAMEDataGridViewTextBoxColumn"
        Me.CATNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SUBCATEGORYDataGridViewTextBoxColumn
        '
        Me.SUBCATEGORYDataGridViewTextBoxColumn.DataPropertyName = "SUB CATEGORY"
        Me.SUBCATEGORYDataGridViewTextBoxColumn.HeaderText = "SUB CATEGORY"
        Me.SUBCATEGORYDataGridViewTextBoxColumn.Name = "SUBCATEGORYDataGridViewTextBoxColumn"
        Me.SUBCATEGORYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BRANDNAMEDataGridViewTextBoxColumn
        '
        Me.BRANDNAMEDataGridViewTextBoxColumn.DataPropertyName = "BRAND NAME"
        Me.BRANDNAMEDataGridViewTextBoxColumn.HeaderText = "BRAND NAME"
        Me.BRANDNAMEDataGridViewTextBoxColumn.Name = "BRANDNAMEDataGridViewTextBoxColumn"
        Me.BRANDNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMCODEDataGridViewTextBoxColumn
        '
        Me.ITEMCODEDataGridViewTextBoxColumn.DataPropertyName = "ITEM CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.HeaderText = "ITEM CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.Name = "ITEMCODEDataGridViewTextBoxColumn"
        Me.ITEMCODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SERIALNODataGridViewTextBoxColumn
        '
        Me.SERIALNODataGridViewTextBoxColumn.DataPropertyName = "SERIAL NO"
        Me.SERIALNODataGridViewTextBoxColumn.HeaderText = "SERIAL NO"
        Me.SERIALNODataGridViewTextBoxColumn.Name = "SERIALNODataGridViewTextBoxColumn"
        Me.SERIALNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "ITEM DESCRIPTION"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "ITEM DESCRIPTION"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.Name = "ITEMDESCRIPTIONDataGridViewTextBoxColumn"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALCOSTDataGridViewTextBoxColumn
        '
        Me.TOTALCOSTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn.HeaderText = "TOTAL COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn.Name = "TOTALCOSTDataGridViewTextBoxColumn"
        Me.TOTALCOSTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateOfAcquisitionDataGridViewTextBoxColumn
        '
        Me.DateOfAcquisitionDataGridViewTextBoxColumn.DataPropertyName = "Date of Acquisition"
        Me.DateOfAcquisitionDataGridViewTextBoxColumn.HeaderText = "Date of Acquisition"
        Me.DateOfAcquisitionDataGridViewTextBoxColumn.Name = "DateOfAcquisitionDataGridViewTextBoxColumn"
        Me.DateOfAcquisitionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateEncodeDataGridViewTextBoxColumn
        '
        Me.DateEncodeDataGridViewTextBoxColumn.DataPropertyName = "Date Encode"
        Me.DateEncodeDataGridViewTextBoxColumn.HeaderText = "Date Encode"
        Me.DateEncodeDataGridViewTextBoxColumn.Name = "DateEncodeDataGridViewTextBoxColumn"
        Me.DateEncodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DIVISIONDataGridViewTextBoxColumn
        '
        Me.DIVISIONDataGridViewTextBoxColumn.DataPropertyName = "DIVISION"
        Me.DIVISIONDataGridViewTextBoxColumn.HeaderText = "DIVISION"
        Me.DIVISIONDataGridViewTextBoxColumn.Name = "DIVISIONDataGridViewTextBoxColumn"
        Me.DIVISIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SPM4ASSIGNITEMSBindingSource
        '
        Me.SPM4ASSIGNITEMSBindingSource.DataMember = "SPM4_ASSIGN_ITEMS"
        Me.SPM4ASSIGNITEMSBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRCANCELEDIT})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1009, 447)
        Me.ShapeContainer1.TabIndex = 1468
        Me.ShapeContainer1.TabStop = False
        '
        'RECT_PRCANCELEDIT
        '
        Me.RECT_PRCANCELEDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRCANCELEDIT.CornerRadius = 5
        Me.RECT_PRCANCELEDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRCANCELEDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRCANCELEDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(3, 5)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(1002, 33)
        '
        'SpM4_ASSIGN_ITEMSTableAdapter
        '
        Me.SpM4_ASSIGN_ITEMSTableAdapter.ClearBeforeFill = True
        '
        'FRM_ASSIGN_ITEMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1015, 554)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_ASSIGN_ITEMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ASSIGN_ITEMS"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ASSIGN_ITEMS_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4ASSIGNITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_SELECTION_CLOSE As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_GENERATE_REPORT As Button
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_INVENTORY_CANCEL As PowerPacks.RectangleShape
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents WTXT_LIST_PREFERRED_ITEMS As WatermarkTextBox
    Friend WithEvents DGV_ASSIGN_ITEMS_LIST As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents CATNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBCATEGORYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BRANDNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SERIALNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfAcquisitionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateEncodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DIVISIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPM4ASSIGNITEMSBindingSource As BindingSource
    Friend WithEvents SpM4_ASSIGN_ITEMSTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ASSIGN_ITEMSTableAdapter
End Class
