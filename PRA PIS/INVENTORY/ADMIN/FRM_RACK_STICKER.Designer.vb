<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_RACK_STICKER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_RACK_STICKER))
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
        Me.ImgDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.BTN_STICKER_PREVIEW = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGV_RACKSTICKER = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WTXT_SEARCH_QRCODEDTAG = New PRA_PIS.WatermarkTextBox()
        Me.CB_TEMPLATE_SIZE = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_INVENTORY_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_INMA_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INMA_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PNL = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV_RACKSTICKER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'CATNAMEDataGridViewTextBoxColumn
        '
        Me.CATNAMEDataGridViewTextBoxColumn.DataPropertyName = "CAT NAME"
        Me.CATNAMEDataGridViewTextBoxColumn.HeaderText = "CAT NAME"
        Me.CATNAMEDataGridViewTextBoxColumn.Name = "CATNAMEDataGridViewTextBoxColumn"
        Me.CATNAMEDataGridViewTextBoxColumn.Width = 90
        '
        'SUBCATEGORYDataGridViewTextBoxColumn
        '
        Me.SUBCATEGORYDataGridViewTextBoxColumn.DataPropertyName = "SUB CATEGORY"
        Me.SUBCATEGORYDataGridViewTextBoxColumn.HeaderText = "SUB CATEGORY"
        Me.SUBCATEGORYDataGridViewTextBoxColumn.Name = "SUBCATEGORYDataGridViewTextBoxColumn"
        Me.SUBCATEGORYDataGridViewTextBoxColumn.Width = 91
        '
        'BRANDNAMEDataGridViewTextBoxColumn
        '
        Me.BRANDNAMEDataGridViewTextBoxColumn.DataPropertyName = "BRAND NAME"
        Me.BRANDNAMEDataGridViewTextBoxColumn.HeaderText = "BRAND NAME"
        Me.BRANDNAMEDataGridViewTextBoxColumn.Name = "BRANDNAMEDataGridViewTextBoxColumn"
        Me.BRANDNAMEDataGridViewTextBoxColumn.Width = 90
        '
        'ITEMCODEDataGridViewTextBoxColumn
        '
        Me.ITEMCODEDataGridViewTextBoxColumn.DataPropertyName = "ITEM CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.HeaderText = "ITEM CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.Name = "ITEMCODEDataGridViewTextBoxColumn"
        Me.ITEMCODEDataGridViewTextBoxColumn.Width = 90
        '
        'SERIALNODataGridViewTextBoxColumn
        '
        Me.SERIALNODataGridViewTextBoxColumn.DataPropertyName = "SERIAL NO"
        Me.SERIALNODataGridViewTextBoxColumn.HeaderText = "SERIAL NO"
        Me.SERIALNODataGridViewTextBoxColumn.Name = "SERIALNODataGridViewTextBoxColumn"
        Me.SERIALNODataGridViewTextBoxColumn.Width = 90
        '
        'ITEMDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "ITEM DESCRIPTION"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "ITEM DESCRIPTION"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.Name = "ITEMDESCRIPTIONDataGridViewTextBoxColumn"
        Me.ITEMDESCRIPTIONDataGridViewTextBoxColumn.Width = 91
        '
        'TOTALCOSTDataGridViewTextBoxColumn
        '
        Me.TOTALCOSTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn.HeaderText = "TOTAL COST"
        Me.TOTALCOSTDataGridViewTextBoxColumn.Name = "TOTALCOSTDataGridViewTextBoxColumn"
        Me.TOTALCOSTDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALCOSTDataGridViewTextBoxColumn.Width = 90
        '
        'DateOfAcquisitionDataGridViewTextBoxColumn
        '
        Me.DateOfAcquisitionDataGridViewTextBoxColumn.DataPropertyName = "Date of Acquisition"
        Me.DateOfAcquisitionDataGridViewTextBoxColumn.HeaderText = "Date of Acquisition"
        Me.DateOfAcquisitionDataGridViewTextBoxColumn.Name = "DateOfAcquisitionDataGridViewTextBoxColumn"
        Me.DateOfAcquisitionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateOfAcquisitionDataGridViewTextBoxColumn.Width = 90
        '
        'DateEncodeDataGridViewTextBoxColumn
        '
        Me.DateEncodeDataGridViewTextBoxColumn.DataPropertyName = "Date Encode"
        Me.DateEncodeDataGridViewTextBoxColumn.HeaderText = "Date Encode"
        Me.DateEncodeDataGridViewTextBoxColumn.Name = "DateEncodeDataGridViewTextBoxColumn"
        Me.DateEncodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateEncodeDataGridViewTextBoxColumn.Width = 90
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FullnameDataGridViewTextBoxColumn.Width = 91
        '
        'DIVISIONDataGridViewTextBoxColumn
        '
        Me.DIVISIONDataGridViewTextBoxColumn.DataPropertyName = "DIVISION"
        Me.DIVISIONDataGridViewTextBoxColumn.HeaderText = "DIVISION"
        Me.DIVISIONDataGridViewTextBoxColumn.Name = "DIVISIONDataGridViewTextBoxColumn"
        Me.DIVISIONDataGridViewTextBoxColumn.Width = 90
        '
        'ImgDataGridViewImageColumn
        '
        Me.ImgDataGridViewImageColumn.DataPropertyName = "img"
        Me.ImgDataGridViewImageColumn.HeaderText = "img"
        Me.ImgDataGridViewImageColumn.Name = "ImgDataGridViewImageColumn"
        Me.ImgDataGridViewImageColumn.Width = 90
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(1765, 279)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(667, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox1.TabIndex = 1480
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PB_INVENTORY_SEARCH
        '
        Me.PB_INVENTORY_SEARCH.BackgroundImage = CType(resources.GetObject("PB_INVENTORY_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_INVENTORY_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_SEARCH.Location = New System.Drawing.Point(13, 9)
        Me.PB_INVENTORY_SEARCH.Name = "PB_INVENTORY_SEARCH"
        Me.PB_INVENTORY_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_SEARCH.TabIndex = 1480
        Me.PB_INVENTORY_SEARCH.TabStop = False
        '
        'BTN_STICKER_PREVIEW
        '
        Me.BTN_STICKER_PREVIEW.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_STICKER_PREVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_STICKER_PREVIEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_STICKER_PREVIEW.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BTN_STICKER_PREVIEW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_STICKER_PREVIEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_STICKER_PREVIEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_STICKER_PREVIEW.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_STICKER_PREVIEW.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_STICKER_PREVIEW.Location = New System.Drawing.Point(947, 9)
        Me.BTN_STICKER_PREVIEW.Name = "BTN_STICKER_PREVIEW"
        Me.BTN_STICKER_PREVIEW.Size = New System.Drawing.Size(128, 29)
        Me.BTN_STICKER_PREVIEW.TabIndex = 1475
        Me.BTN_STICKER_PREVIEW.Text = "Preview"
        Me.BTN_STICKER_PREVIEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_STICKER_PREVIEW.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DGV_RACKSTICKER)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(8, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1080, 541)
        Me.Panel2.TabIndex = 1412
        '
        'DGV_RACKSTICKER
        '
        Me.DGV_RACKSTICKER.AllowUserToAddRows = False
        Me.DGV_RACKSTICKER.AllowUserToDeleteRows = False
        Me.DGV_RACKSTICKER.AllowUserToResizeColumns = False
        Me.DGV_RACKSTICKER.AllowUserToResizeRows = False
        Me.DGV_RACKSTICKER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_RACKSTICKER.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGV_RACKSTICKER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_RACKSTICKER.Location = New System.Drawing.Point(-3, -1)
        Me.DGV_RACKSTICKER.Name = "DGV_RACKSTICKER"
        Me.DGV_RACKSTICKER.ReadOnly = True
        Me.DGV_RACKSTICKER.RowHeadersVisible = False
        Me.DGV_RACKSTICKER.Size = New System.Drawing.Size(1086, 541)
        Me.DGV_RACKSTICKER.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(708, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Template Size:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.WTXT_SEARCH_QRCODEDTAG)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.Panel1.Controls.Add(Me.BTN_STICKER_PREVIEW)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CB_TEMPLATE_SIZE)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(7, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 48)
        Me.Panel1.TabIndex = 1411
        '
        'WTXT_SEARCH_QRCODEDTAG
        '
        Me.WTXT_SEARCH_QRCODEDTAG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCH_QRCODEDTAG.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCH_QRCODEDTAG.ForeColor = System.Drawing.Color.Black
        Me.WTXT_SEARCH_QRCODEDTAG.Location = New System.Drawing.Point(49, 14)
        Me.WTXT_SEARCH_QRCODEDTAG.MaxLength = 15
        Me.WTXT_SEARCH_QRCODEDTAG.Name = "WTXT_SEARCH_QRCODEDTAG"
        Me.WTXT_SEARCH_QRCODEDTAG.Size = New System.Drawing.Size(612, 20)
        Me.WTXT_SEARCH_QRCODEDTAG.TabIndex = 1480
        Me.WTXT_SEARCH_QRCODEDTAG.Watermark = "Search Item Code, Category, Sub Category, Brand/Provider"
        '
        'CB_TEMPLATE_SIZE
        '
        Me.CB_TEMPLATE_SIZE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TEMPLATE_SIZE.FormattingEnabled = True
        Me.CB_TEMPLATE_SIZE.Items.AddRange(New Object() {"3 x 1 in.", "4 x 2 in."})
        Me.CB_TEMPLATE_SIZE.Location = New System.Drawing.Point(827, 9)
        Me.CB_TEMPLATE_SIZE.Name = "CB_TEMPLATE_SIZE"
        Me.CB_TEMPLATE_SIZE.Size = New System.Drawing.Size(114, 29)
        Me.CB_TEMPLATE_SIZE.TabIndex = 0
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRCANCELEDIT})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1078, 46)
        Me.ShapeContainer2.TabIndex = 1476
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_PRCANCELEDIT
        '
        Me.RECT_PRCANCELEDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRCANCELEDIT.CornerRadius = 5
        Me.RECT_PRCANCELEDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRCANCELEDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRCANCELEDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(10, 6)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(692, 33)
        '
        'BTN_INVENTORY_MINIMIZE
        '
        Me.BTN_INVENTORY_MINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_MINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_INVENTORY_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_MINIMIZE.Location = New System.Drawing.Point(1023, 12)
        Me.BTN_INVENTORY_MINIMIZE.Name = "BTN_INVENTORY_MINIMIZE"
        Me.BTN_INVENTORY_MINIMIZE.Size = New System.Drawing.Size(27, 28)
        Me.BTN_INVENTORY_MINIMIZE.TabIndex = 19
        Me.BTN_INVENTORY_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_MINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_INVENTORY_CLOSE
        '
        Me.BTN_INVENTORY_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INVENTORY_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_CLOSE.Location = New System.Drawing.Point(1058, 11)
        Me.BTN_INVENTORY_CLOSE.Name = "BTN_INVENTORY_CLOSE"
        Me.BTN_INVENTORY_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INVENTORY_CLOSE.TabIndex = 18
        Me.BTN_INVENTORY_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_CLOSE.UseVisualStyleBackColor = True
        '
        'BTN_INMA_MINIMIZE
        '
        Me.BTN_INMA_MINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INMA_MINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_INMA_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_INMA_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INMA_MINIMIZE.Location = New System.Drawing.Point(-974, 8)
        Me.BTN_INMA_MINIMIZE.Name = "BTN_INMA_MINIMIZE"
        Me.BTN_INMA_MINIMIZE.Size = New System.Drawing.Size(27, 28)
        Me.BTN_INMA_MINIMIZE.TabIndex = 11
        Me.BTN_INMA_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INMA_MINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_INMA_CLOSE
        '
        Me.BTN_INMA_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INMA_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INMA_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INMA_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INMA_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INMA_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INMA_CLOSE.Location = New System.Drawing.Point(-939, 7)
        Me.BTN_INMA_CLOSE.Name = "BTN_INMA_CLOSE"
        Me.BTN_INMA_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INMA_CLOSE.TabIndex = 10
        Me.BTN_INMA_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INMA_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(11, 14)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(197, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "Q R  C O D E D  T A G"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-6793, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-6746, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_MINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_CLOSE)
        Me.PNL.Controls.Add(Me.BTN_INMA_MINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_INMA_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1094, 52)
        Me.PNL.TabIndex = 1410
        '
        'FRM_RACK_STICKER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1094, 660)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_RACK_STICKER"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGV_RACKSTICKER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents ImgDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents WTXT_SEARCH_QRCODEDTAG As WatermarkTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents BTN_STICKER_PREVIEW As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV_RACKSTICKER As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CB_TEMPLATE_SIZE As ComboBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents BTN_INVENTORY_MINIMIZE As Button
    Friend WithEvents BTN_INVENTORY_CLOSE As Button
    Friend WithEvents BTN_INMA_MINIMIZE As Button
    Friend WithEvents BTN_INMA_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL As Panel
End Class
