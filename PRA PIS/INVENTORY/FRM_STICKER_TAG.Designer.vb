<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_STICKER_TAG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_STICKER_TAG))
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INVENTORY_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_INMA_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INMA_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WTXT_SEARCH_QRCODEDTAG = New PRA_PIS.WatermarkTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.BTN_STICKER_PREVIEW = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_TEMPLATE_SIZE = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.SPM4_PRINTSTICKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SPM4_PRINTSTICKERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SPM4_PRINTSTICKERTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_PRINTSTICKERTableAdapter()
        Me.PNL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PRINTSTICKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SPM4_PRINTSTICKERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PNL.TabIndex = 1406
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
        Me.Panel1.Location = New System.Drawing.Point(7, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 48)
        Me.Panel1.TabIndex = 1408
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
        Me.WTXT_SEARCH_QRCODEDTAG.Watermark = "Search Item Code, Category, Sub Category, Brand/Provider, Serial No."
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
        'CB_TEMPLATE_SIZE
        '
        Me.CB_TEMPLATE_SIZE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_TEMPLATE_SIZE.FormattingEnabled = True
        Me.CB_TEMPLATE_SIZE.Items.AddRange(New Object() {"3 x 2 in.", "4 x 3 in."})
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
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPM4_PRINTSTICKERBindingSource
        '
        Me.SPM4_PRINTSTICKERBindingSource.DataMember = "SPM4_PRINTSTICKER"
        Me.SPM4_PRINTSTICKERBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.A_CLOSEPROGRAMTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.SPM4_PRINTSTICKERDataGridView)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(8, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1080, 541)
        Me.Panel2.TabIndex = 1409
        '
        'SPM4_PRINTSTICKERDataGridView
        '
        Me.SPM4_PRINTSTICKERDataGridView.AllowUserToAddRows = False
        Me.SPM4_PRINTSTICKERDataGridView.AllowUserToDeleteRows = False
        Me.SPM4_PRINTSTICKERDataGridView.AllowUserToResizeColumns = False
        Me.SPM4_PRINTSTICKERDataGridView.AllowUserToResizeRows = False
        Me.SPM4_PRINTSTICKERDataGridView.AutoGenerateColumns = False
        Me.SPM4_PRINTSTICKERDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SPM4_PRINTSTICKERDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SPM4_PRINTSTICKERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SPM4_PRINTSTICKERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn19})
        Me.SPM4_PRINTSTICKERDataGridView.DataSource = Me.SPM4_PRINTSTICKERBindingSource
        Me.SPM4_PRINTSTICKERDataGridView.Location = New System.Drawing.Point(-3, -1)
        Me.SPM4_PRINTSTICKERDataGridView.Name = "SPM4_PRINTSTICKERDataGridView"
        Me.SPM4_PRINTSTICKERDataGridView.ReadOnly = True
        Me.SPM4_PRINTSTICKERDataGridView.RowHeadersVisible = False
        Me.SPM4_PRINTSTICKERDataGridView.Size = New System.Drawing.Size(1086, 541)
        Me.SPM4_PRINTSTICKERDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CAT NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Category Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SUB CATEGORY"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sub Category"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "BRAND NAME"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Brand Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ITEM CODE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Item Code"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SERIAL NO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Serial No."
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ITEM DESCRIPTION"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Item Description"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TOTAL COST"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Total Cost"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Date of Acquisition"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Date of Acquisition"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Date Encode"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Date Encoded"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "fullname"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "DIVISION"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Division"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
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
        'SPM4_PRINTSTICKERTableAdapter
        '
        Me.SPM4_PRINTSTICKERTableAdapter.ClearBeforeFill = True
        '
        'FRM_STICKER_TAG
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
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FRM_STICKER_TAG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FRM_STICKER_TAG"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PRINTSTICKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.SPM4_PRINTSTICKERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_INMA_MINIMIZE As Button
    Friend WithEvents BTN_INMA_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CB_TEMPLATE_SIZE As ComboBox
    Friend WithEvents BTN_STICKER_PREVIEW As Button
    Friend WithEvents BTN_INVENTORY_MINIMIZE As Button
    Friend WithEvents BTN_INVENTORY_CLOSE As Button
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SPM4_PRINTSTICKERBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WTXT_SEARCH_QRCODEDTAG As WatermarkTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SPM4_PRINTSTICKERDataGridView As DataGridView
    Friend WithEvents SPM4_PRINTSTICKERTableAdapter As DS_STOREDPROCTableAdapters.SPM4_PRINTSTICKERTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
End Class
