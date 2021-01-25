<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PRACCEPT
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
        Me.DGV_SCANNED_IMG = New System.Windows.Forms.DataGridView()
        Me.SCANNED_IMG = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_PRMINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_PRCLOSE = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PNL_SCANSELECTION = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_PURCHASE_REQUEST_CATEGORY = New System.Windows.Forms.ComboBox()
        Me.TblM4PURCHASEREQUESTCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cbxSources = New System.Windows.Forms.ComboBox()
        Me.RectangleShape43 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BwMakePdf = New System.ComponentModel.BackgroundWorker()
        Me.OFD_SCANCTD = New System.Windows.Forms.OpenFileDialog()
        Me.BTN_ACCEPT_SCAN = New System.Windows.Forms.Button()
        Me.BTN_ACCEPT_SAVE = New System.Windows.Forms.Button()
        Me.TblM4_PURCHASEREQUEST_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_CATEGORYTableAdapter()
        Me.TblM4_PURCHASEREQUESTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter()
        Me.TblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter()
        CType(Me.DGV_SCANNED_IMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        Me.PNL_SCANSELECTION.SuspendLayout()
        CType(Me.TblM4PURCHASEREQUESTCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_SCANNED_IMG
        '
        Me.DGV_SCANNED_IMG.AllowUserToAddRows = False
        Me.DGV_SCANNED_IMG.AllowUserToDeleteRows = False
        Me.DGV_SCANNED_IMG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGV_SCANNED_IMG.BackgroundColor = System.Drawing.Color.White
        Me.DGV_SCANNED_IMG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SCANNED_IMG.ColumnHeadersVisible = False
        Me.DGV_SCANNED_IMG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SCANNED_IMG})
        Me.DGV_SCANNED_IMG.Location = New System.Drawing.Point(376, 460)
        Me.DGV_SCANNED_IMG.Name = "DGV_SCANNED_IMG"
        Me.DGV_SCANNED_IMG.ReadOnly = True
        Me.DGV_SCANNED_IMG.RowHeadersVisible = False
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        Me.DGV_SCANNED_IMG.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_SCANNED_IMG.RowTemplate.Height = 461
        Me.DGV_SCANNED_IMG.Size = New System.Drawing.Size(101, 0)
        Me.DGV_SCANNED_IMG.TabIndex = 1427
        Me.DGV_SCANNED_IMG.Visible = False
        '
        'SCANNED_IMG
        '
        Me.SCANNED_IMG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SCANNED_IMG.HeaderText = "SCANNED IMAGE"
        Me.SCANNED_IMG.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.SCANNED_IMG.Name = "SCANNED_IMG"
        Me.SCANNED_IMG.ReadOnly = True
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
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(343, 32)
        Me.PNL.TabIndex = 1428
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
        Me.BTN_PRMINIMIZE.Location = New System.Drawing.Point(1420, 8)
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
        Me.BTN_PRCLOSE.Location = New System.Drawing.Point(1455, 7)
        Me.BTN_PRCLOSE.Name = "BTN_PRCLOSE"
        Me.BTN_PRCLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_PRCLOSE.TabIndex = 10
        Me.BTN_PRCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_PRCLOSE.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(6, 6)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(118, 18)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "A C C E P T   P R"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3017, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-2970, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'PNL_SCANSELECTION
        '
        Me.PNL_SCANSELECTION.Controls.Add(Me.Label1)
        Me.PNL_SCANSELECTION.Controls.Add(Me.CB_PURCHASE_REQUEST_CATEGORY)
        Me.PNL_SCANSELECTION.Location = New System.Drawing.Point(7, 42)
        Me.PNL_SCANSELECTION.Name = "PNL_SCANSELECTION"
        Me.PNL_SCANSELECTION.Size = New System.Drawing.Size(327, 49)
        Me.PNL_SCANSELECTION.TabIndex = 1453
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 16)
        Me.Label1.TabIndex = 1462
        Me.Label1.Text = "CATEGORY SELECTION"
        '
        'CB_PURCHASE_REQUEST_CATEGORY
        '
        Me.CB_PURCHASE_REQUEST_CATEGORY.BackColor = System.Drawing.Color.White
        Me.CB_PURCHASE_REQUEST_CATEGORY.DataSource = Me.TblM4PURCHASEREQUESTCATEGORYBindingSource
        Me.CB_PURCHASE_REQUEST_CATEGORY.DisplayMember = "PRCAT_CATEGORY_NAME"
        Me.CB_PURCHASE_REQUEST_CATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PURCHASE_REQUEST_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PURCHASE_REQUEST_CATEGORY.ForeColor = System.Drawing.Color.DimGray
        Me.CB_PURCHASE_REQUEST_CATEGORY.FormattingEnabled = True
        Me.CB_PURCHASE_REQUEST_CATEGORY.Location = New System.Drawing.Point(2, 19)
        Me.CB_PURCHASE_REQUEST_CATEGORY.Name = "CB_PURCHASE_REQUEST_CATEGORY"
        Me.CB_PURCHASE_REQUEST_CATEGORY.Size = New System.Drawing.Size(321, 24)
        Me.CB_PURCHASE_REQUEST_CATEGORY.TabIndex = 1461
        Me.CB_PURCHASE_REQUEST_CATEGORY.ValueMember = "PRCAT_NO"
        '
        'TblM4PURCHASEREQUESTCATEGORYBindingSource
        '
        Me.TblM4PURCHASEREQUESTCATEGORYBindingSource.DataMember = "tblM4_PURCHASEREQUEST_CATEGORY"
        Me.TblM4PURCHASEREQUESTCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(18, 535)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(120, 16)
        Me.Label46.TabIndex = 1421
        Me.Label46.Text = "SCANNER SELECTION"
        '
        'cbxSources
        '
        Me.cbxSources.BackColor = System.Drawing.Color.White
        Me.cbxSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSources.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSources.ForeColor = System.Drawing.Color.DimGray
        Me.cbxSources.FormattingEnabled = True
        Me.cbxSources.Location = New System.Drawing.Point(17, 551)
        Me.cbxSources.Name = "cbxSources"
        Me.cbxSources.Size = New System.Drawing.Size(321, 24)
        Me.cbxSources.TabIndex = 12
        '
        'RectangleShape43
        '
        Me.RectangleShape43.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape43.CornerRadius = 3
        Me.RectangleShape43.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape43.Location = New System.Drawing.Point(3, 36)
        Me.RectangleShape43.Name = "RectangleShape43"
        Me.RectangleShape43.Size = New System.Drawing.Size(333, 60)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape4, Me.RectangleShape43})
        Me.ShapeContainer1.Size = New System.Drawing.Size(343, 153)
        Me.ShapeContainer1.TabIndex = 1454
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(253, 101)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(80, 39)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(157, 589)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(105, 49)
        '
        'OFD_SCANCTD
        '
        Me.OFD_SCANCTD.FileName = "OpenFileDialog1"
        '
        'BTN_ACCEPT_SCAN
        '
        Me.BTN_ACCEPT_SCAN.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ACCEPT_SCAN.FlatAppearance.BorderSize = 0
        Me.BTN_ACCEPT_SCAN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ACCEPT_SCAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ACCEPT_SCAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ACCEPT_SCAN.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACCEPT_SCAN.Image = Global.PRA_PIS.My.Resources.Resources.outline_scanner_black_18dp
        Me.BTN_ACCEPT_SCAN.Location = New System.Drawing.Point(236, 460)
        Me.BTN_ACCEPT_SCAN.Name = "BTN_ACCEPT_SCAN"
        Me.BTN_ACCEPT_SCAN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ACCEPT_SCAN.Size = New System.Drawing.Size(102, 46)
        Me.BTN_ACCEPT_SCAN.TabIndex = 1458
        Me.BTN_ACCEPT_SCAN.Text = "SCAN"
        Me.BTN_ACCEPT_SCAN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_ACCEPT_SCAN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ACCEPT_SCAN.UseVisualStyleBackColor = True
        '
        'BTN_ACCEPT_SAVE
        '
        Me.BTN_ACCEPT_SAVE.BackColor = System.Drawing.Color.White
        Me.BTN_ACCEPT_SAVE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.baseline_save_black_18dp
        Me.BTN_ACCEPT_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_ACCEPT_SAVE.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ACCEPT_SAVE.FlatAppearance.BorderSize = 0
        Me.BTN_ACCEPT_SAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ACCEPT_SAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_ACCEPT_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ACCEPT_SAVE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACCEPT_SAVE.Location = New System.Drawing.Point(255, 102)
        Me.BTN_ACCEPT_SAVE.Name = "BTN_ACCEPT_SAVE"
        Me.BTN_ACCEPT_SAVE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_ACCEPT_SAVE.Size = New System.Drawing.Size(77, 38)
        Me.BTN_ACCEPT_SAVE.TabIndex = 1459
        Me.BTN_ACCEPT_SAVE.Text = "SAVE"
        Me.BTN_ACCEPT_SAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_ACCEPT_SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ACCEPT_SAVE.UseVisualStyleBackColor = False
        '
        'TblM4_PURCHASEREQUEST_CATEGORYTableAdapter
        '
        Me.TblM4_PURCHASEREQUEST_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUESTTableAdapter
        '
        Me.TblM4_PURCHASEREQUESTTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter
        '
        Me.TblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter.ClearBeforeFill = True
        '
        'FRM_PRACCEPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(343, 153)
        Me.Controls.Add(Me.cbxSources)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.BTN_ACCEPT_SAVE)
        Me.Controls.Add(Me.BTN_ACCEPT_SCAN)
        Me.Controls.Add(Me.PNL_SCANSELECTION)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.DGV_SCANNED_IMG)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_PRACCEPT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_PRACCEPT"
        CType(Me.DGV_SCANNED_IMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.PNL_SCANSELECTION.ResumeLayout(False)
        Me.PNL_SCANSELECTION.PerformLayout()
        CType(Me.TblM4PURCHASEREQUESTCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_SCANNED_IMG As DataGridView
    Friend WithEvents SCANNED_IMG As DataGridViewImageColumn
    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_PRMINIMIZE As Button
    Friend WithEvents BTN_PRCLOSE As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL_SCANSELECTION As Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents cbxSources As ComboBox
    Private WithEvents RectangleShape43 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents BwMakePdf As System.ComponentModel.BackgroundWorker
    Friend WithEvents OFD_SCANCTD As OpenFileDialog
    Friend WithEvents BTN_ACCEPT_SCAN As Button
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents BTN_ACCEPT_SAVE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_PURCHASE_REQUEST_CATEGORY As ComboBox
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TblM4PURCHASEREQUESTCATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_PURCHASEREQUEST_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_CATEGORYTableAdapter
    Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents TblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter
End Class
