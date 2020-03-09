<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_INVENTORY_PRINT_PREVIEW
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
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INVENTORY_REPORT_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY_REPORT_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.APNL_INVENTORY_REPORT = New System.Windows.Forms.Panel()
        Me.WatermarkTextBox1 = New PRA_PIS.WatermarkTextBox()
        Me.SPM4CURRENTDATETIMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.WTXT_INVENTORY_REPORT_TO = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_INVENTORY_REPORT_FROM = New PRA_PIS.WatermarkTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY = New System.Windows.Forms.ComboBox()
        Me.CB_INVENTORY_REPORT_CATEGORY = New System.Windows.Forms.ComboBox()
        Me.CB_INVENTORY_REPORT_BRAND_NAME = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTN_INVENTORY_GENERATE_REPORT = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRREQUESTEDDATE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CRReportInventory = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RECT_PRAPPCODE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.BTN_INVENTORY_PRINT = New System.Windows.Forms.Button()
        Me.SPM4_CURRENTDATETIMETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.SpM4_INVENTORY_REPORTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_INVENTORY_REPORTTableAdapter()
        Me.SPM4INVENTORYREPORTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter()
        Me.TblM4INVENTORYCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPROPERTYDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4INVENTORYSUBCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter()
        Me.TblM4INVENTORYITEMBRANDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter()
        Me.PNL.SuspendLayout()
        Me.APNL_INVENTORY_REPORT.SuspendLayout()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4INVENTORYREPORTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPROPERTYDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_REPORT_MINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_REPORT_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1095, 49)
        Me.PNL.TabIndex = 1457
        '
        'BTN_INVENTORY_REPORT_MINIMIZE
        '
        Me.BTN_INVENTORY_REPORT_MINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INVENTORY_REPORT_MINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_REPORT_MINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_INVENTORY_REPORT_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_REPORT_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_REPORT_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_REPORT_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_REPORT_MINIMIZE.Location = New System.Drawing.Point(1018, 9)
        Me.BTN_INVENTORY_REPORT_MINIMIZE.Name = "BTN_INVENTORY_REPORT_MINIMIZE"
        Me.BTN_INVENTORY_REPORT_MINIMIZE.Size = New System.Drawing.Size(28, 28)
        Me.BTN_INVENTORY_REPORT_MINIMIZE.TabIndex = 12
        Me.BTN_INVENTORY_REPORT_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_REPORT_MINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_INVENTORY_REPORT_CLOSE
        '
        Me.BTN_INVENTORY_REPORT_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INVENTORY_REPORT_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INVENTORY_REPORT_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_REPORT_CLOSE.Location = New System.Drawing.Point(1052, 7)
        Me.BTN_INVENTORY_REPORT_CLOSE.Name = "BTN_INVENTORY_REPORT_CLOSE"
        Me.BTN_INVENTORY_REPORT_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INVENTORY_REPORT_CLOSE.TabIndex = 10
        Me.BTN_INVENTORY_REPORT_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_REPORT_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(12, 14)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(235, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "I n v e n t o r y   R e p o r t"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3991, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3944, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'APNL_INVENTORY_REPORT
        '
        Me.APNL_INVENTORY_REPORT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.APNL_INVENTORY_REPORT.BackColor = System.Drawing.Color.White
        Me.APNL_INVENTORY_REPORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.WatermarkTextBox1)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.WTXT_INVENTORY_REPORT_TO)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.WTXT_INVENTORY_REPORT_FROM)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.Label5)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.Label4)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.CB_INVENTORY_REPORT_SUB_CATEGORY)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.CB_INVENTORY_REPORT_CATEGORY)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.CB_INVENTORY_REPORT_BRAND_NAME)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.Label3)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.Label2)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.Label1)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.Label6)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.BTN_INVENTORY_GENERATE_REPORT)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.ShapeContainer1)
        Me.APNL_INVENTORY_REPORT.Location = New System.Drawing.Point(3, 51)
        Me.APNL_INVENTORY_REPORT.Name = "APNL_INVENTORY_REPORT"
        Me.APNL_INVENTORY_REPORT.Size = New System.Drawing.Size(1089, 90)
        Me.APNL_INVENTORY_REPORT.TabIndex = 1456
        '
        'WatermarkTextBox1
        '
        Me.WatermarkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WatermarkTextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WatermarkTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4CURRENTDATETIMEBindingSource, "Column1", True))
        Me.WatermarkTextBox1.Location = New System.Drawing.Point(1095, 34)
        Me.WatermarkTextBox1.Name = "WatermarkTextBox1"
        Me.WatermarkTextBox1.ReadOnly = True
        Me.WatermarkTextBox1.Size = New System.Drawing.Size(127, 20)
        Me.WatermarkTextBox1.TabIndex = 1471
        Me.WatermarkTextBox1.Text = "MM/DD/YYYY"
        Me.WatermarkTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WatermarkTextBox1.Watermark = "MM/DD/YYYY"
        '
        'SPM4CURRENTDATETIMEBindingSource
        '
        Me.SPM4CURRENTDATETIMEBindingSource.DataMember = "SPM4_CURRENTDATETIME"
        Me.SPM4CURRENTDATETIMEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WTXT_INVENTORY_REPORT_TO
        '
        Me.WTXT_INVENTORY_REPORT_TO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_REPORT_TO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_INVENTORY_REPORT_TO.Location = New System.Drawing.Point(363, 57)
        Me.WTXT_INVENTORY_REPORT_TO.Name = "WTXT_INVENTORY_REPORT_TO"
        Me.WTXT_INVENTORY_REPORT_TO.ReadOnly = True
        Me.WTXT_INVENTORY_REPORT_TO.Size = New System.Drawing.Size(127, 20)
        Me.WTXT_INVENTORY_REPORT_TO.TabIndex = 4
        Me.WTXT_INVENTORY_REPORT_TO.Text = "MM/DD/YYYY"
        Me.WTXT_INVENTORY_REPORT_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_INVENTORY_REPORT_TO.Watermark = "MM/DD/YYYY"
        '
        'WTXT_INVENTORY_REPORT_FROM
        '
        Me.WTXT_INVENTORY_REPORT_FROM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_REPORT_FROM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_INVENTORY_REPORT_FROM.Location = New System.Drawing.Point(167, 57)
        Me.WTXT_INVENTORY_REPORT_FROM.Name = "WTXT_INVENTORY_REPORT_FROM"
        Me.WTXT_INVENTORY_REPORT_FROM.ReadOnly = True
        Me.WTXT_INVENTORY_REPORT_FROM.Size = New System.Drawing.Size(127, 20)
        Me.WTXT_INVENTORY_REPORT_FROM.TabIndex = 3
        Me.WTXT_INVENTORY_REPORT_FROM.Text = "MM/DD/YYYY"
        Me.WTXT_INVENTORY_REPORT_FROM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_INVENTORY_REPORT_FROM.Watermark = "MM/DD/YYYY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(300, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 1470
        Me.Label5.Text = "DATE TO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(81, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 1469
        Me.Label4.Text = "DATE FROM"
        '
        'CB_INVENTORY_REPORT_SUB_CATEGORY
        '
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.DataSource = Me.TblM4INVENTORYSUBCATEGORYBindingSource
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.DisplayMember = "SC_SUBCATEGORY_NAME"
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.FormattingEnabled = True
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.Location = New System.Drawing.Point(324, 14)
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.Name = "CB_INVENTORY_REPORT_SUB_CATEGORY"
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.Size = New System.Drawing.Size(238, 27)
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.TabIndex = 1
        Me.CB_INVENTORY_REPORT_SUB_CATEGORY.ValueMember = "SC_NO"
        '
        'CB_INVENTORY_REPORT_CATEGORY
        '
        Me.CB_INVENTORY_REPORT_CATEGORY.DataSource = Me.TblM4INVENTORYCATEGORYBindingSource
        Me.CB_INVENTORY_REPORT_CATEGORY.DisplayMember = "CAT_NAME"
        Me.CB_INVENTORY_REPORT_CATEGORY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_REPORT_CATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_REPORT_CATEGORY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_REPORT_CATEGORY.FormattingEnabled = True
        Me.CB_INVENTORY_REPORT_CATEGORY.Location = New System.Drawing.Point(82, 14)
        Me.CB_INVENTORY_REPORT_CATEGORY.Name = "CB_INVENTORY_REPORT_CATEGORY"
        Me.CB_INVENTORY_REPORT_CATEGORY.Size = New System.Drawing.Size(231, 27)
        Me.CB_INVENTORY_REPORT_CATEGORY.TabIndex = 0
        Me.CB_INVENTORY_REPORT_CATEGORY.ValueMember = "CAT_CODE"
        '
        'CB_INVENTORY_REPORT_BRAND_NAME
        '
        Me.CB_INVENTORY_REPORT_BRAND_NAME.DataSource = Me.TblM4INVENTORYITEMBRANDBindingSource
        Me.CB_INVENTORY_REPORT_BRAND_NAME.DisplayMember = "ITBR_NAME"
        Me.CB_INVENTORY_REPORT_BRAND_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_INVENTORY_REPORT_BRAND_NAME.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_INVENTORY_REPORT_BRAND_NAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.CB_INVENTORY_REPORT_BRAND_NAME.FormattingEnabled = True
        Me.CB_INVENTORY_REPORT_BRAND_NAME.Location = New System.Drawing.Point(572, 14)
        Me.CB_INVENTORY_REPORT_BRAND_NAME.Name = "CB_INVENTORY_REPORT_BRAND_NAME"
        Me.CB_INVENTORY_REPORT_BRAND_NAME.Size = New System.Drawing.Size(252, 27)
        Me.CB_INVENTORY_REPORT_BRAND_NAME.TabIndex = 2
        Me.CB_INVENTORY_REPORT_BRAND_NAME.ValueMember = "ITBR_NO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(578, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 16)
        Me.Label3.TabIndex = 1467
        Me.Label3.Text = "BRAND/PROVIDER NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(328, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 16)
        Me.Label2.TabIndex = 1465
        Me.Label2.Text = "SUB-CATEGORY/TYPE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(84, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 1464
        Me.Label1.Text = "CATEGORY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(7, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 1463
        Me.Label6.Text = "Filter by:"
        '
        'BTN_INVENTORY_GENERATE_REPORT
        '
        Me.BTN_INVENTORY_GENERATE_REPORT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_INVENTORY_GENERATE_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INVENTORY_GENERATE_REPORT.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_GENERATE_REPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INVENTORY_GENERATE_REPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_GENERATE_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_GENERATE_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INVENTORY_GENERATE_REPORT.Image = Global.PRA_PIS.My.Resources.Resources.outline_refresh_black_18dp
        Me.BTN_INVENTORY_GENERATE_REPORT.Location = New System.Drawing.Point(839, 20)
        Me.BTN_INVENTORY_GENERATE_REPORT.Name = "BTN_INVENTORY_GENERATE_REPORT"
        Me.BTN_INVENTORY_GENERATE_REPORT.Size = New System.Drawing.Size(244, 43)
        Me.BTN_INVENTORY_GENERATE_REPORT.TabIndex = 5
        Me.BTN_INVENTORY_GENERATE_REPORT.Text = "GENERATE REPORT"
        Me.BTN_INVENTORY_GENERATE_REPORT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_INVENTORY_GENERATE_REPORT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_GENERATE_REPORT.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RECT_PRREQUESTEDDATE, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1087, 88)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Location = New System.Drawing.Point(360, 53)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(133, 27)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(163, 53)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(133, 27)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(568, 11)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(258, 32)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(320, 11)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(243, 32)
        '
        'RECT_PRREQUESTEDDATE
        '
        Me.RECT_PRREQUESTEDDATE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRREQUESTEDDATE.BorderWidth = 2
        Me.RECT_PRREQUESTEDDATE.CornerRadius = 5
        Me.RECT_PRREQUESTEDDATE.Location = New System.Drawing.Point(78, 11)
        Me.RECT_PRREQUESTEDDATE.Name = "RECT_PRREQUESTEDDATE"
        Me.RECT_PRREQUESTEDDATE.Size = New System.Drawing.Size(237, 32)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(838, 19)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(245, 44)
        '
        'CRReportInventory
        '
        Me.CRReportInventory.ActiveViewIndex = -1
        Me.CRReportInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRReportInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRReportInventory.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRReportInventory.EnableDrillDown = False
        Me.CRReportInventory.Location = New System.Drawing.Point(3, 143)
        Me.CRReportInventory.Name = "CRReportInventory"
        Me.CRReportInventory.ShowCloseButton = False
        Me.CRReportInventory.ShowCopyButton = False
        Me.CRReportInventory.ShowExportButton = False
        Me.CRReportInventory.ShowGroupTreeButton = False
        Me.CRReportInventory.ShowLogo = False
        Me.CRReportInventory.ShowParameterPanelButton = False
        Me.CRReportInventory.ShowPrintButton = False
        Me.CRReportInventory.ShowRefreshButton = False
        Me.CRReportInventory.ShowTextSearchButton = False
        Me.CRReportInventory.Size = New System.Drawing.Size(1089, 459)
        Me.CRReportInventory.TabIndex = 1459
        Me.CRReportInventory.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RECT_PRAPPCODE
        '
        Me.RECT_PRAPPCODE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRAPPCODE.BorderWidth = 2
        Me.RECT_PRAPPCODE.CornerRadius = 5
        Me.RECT_PRAPPCODE.Location = New System.Drawing.Point(8, 607)
        Me.RECT_PRAPPCODE.Name = "RECT_PRAPPCODE"
        Me.RECT_PRAPPCODE.Size = New System.Drawing.Size(1081, 45)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRAPPCODE})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1095, 660)
        Me.ShapeContainer2.TabIndex = 1460
        Me.ShapeContainer2.TabStop = False
        '
        'BTN_INVENTORY_PRINT
        '
        Me.BTN_INVENTORY_PRINT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_INVENTORY_PRINT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INVENTORY_PRINT.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_PRINT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INVENTORY_PRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_PRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_PRINT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INVENTORY_PRINT.Image = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.BTN_INVENTORY_PRINT.Location = New System.Drawing.Point(9, 608)
        Me.BTN_INVENTORY_PRINT.Name = "BTN_INVENTORY_PRINT"
        Me.BTN_INVENTORY_PRINT.Size = New System.Drawing.Size(1080, 44)
        Me.BTN_INVENTORY_PRINT.TabIndex = 0
        Me.BTN_INVENTORY_PRINT.Text = "PRINT"
        Me.BTN_INVENTORY_PRINT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_INVENTORY_PRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_PRINT.UseVisualStyleBackColor = False
        '
        'SPM4_CURRENTDATETIMETableAdapter
        '
        Me.SPM4_CURRENTDATETIMETableAdapter.ClearBeforeFill = True
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'SpM4_INVENTORY_REPORTTableAdapter
        '
        Me.SpM4_INVENTORY_REPORTTableAdapter.ClearBeforeFill = True
        '
        'SPM4INVENTORYREPORTBindingSource
        '
        Me.SPM4INVENTORYREPORTBindingSource.DataMember = "SPM4_INVENTORY_REPORT"
        Me.SPM4INVENTORYREPORTBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'TblM4INVENTORYCATEGORYBindingSource
        '
        Me.TblM4INVENTORYCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_CATEGORY"
        Me.TblM4INVENTORYCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DSPROPERTYDBBindingSource
        '
        Me.DSPROPERTYDBBindingSource.DataSource = Me.DS_PROPERTYDB
        Me.DSPROPERTYDBBindingSource.Position = 0
        '
        'TblM4INVENTORYSUBCATEGORYBindingSource
        '
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_SUB_CATEGORY"
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_SUB_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'TblM4INVENTORYITEMBRANDBindingSource
        '
        Me.TblM4INVENTORYITEMBRANDBindingSource.DataMember = "tblM4_INVENTORY_ITEMBRAND"
        Me.TblM4INVENTORYITEMBRANDBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_ITEMBRANDTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.ClearBeforeFill = True
        '
        'FRM_INVENTORY_PRINT_PREVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 660)
        Me.Controls.Add(Me.BTN_INVENTORY_PRINT)
        Me.Controls.Add(Me.CRReportInventory)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.APNL_INVENTORY_REPORT)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FRM_INVENTORY_PRINT_PREVIEW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " "
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.APNL_INVENTORY_REPORT.ResumeLayout(False)
        Me.APNL_INVENTORY_REPORT.PerformLayout()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4INVENTORYREPORTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPROPERTYDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_INVENTORY_REPORT_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents APNL_INVENTORY_REPORT As Panel
    Friend WithEvents CRReportInventory As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RECT_PRAPPCODE As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents BTN_INVENTORY_PRINT As Button
    Friend WithEvents BTN_INVENTORY_GENERATE_REPORT As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label6 As Label
    Friend WithEvents RECT_PRREQUESTEDDATE As PowerPacks.RectangleShape
    Friend WithEvents CB_INVENTORY_REPORT_CATEGORY As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_INVENTORY_REPORT_SUB_CATEGORY As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents CB_INVENTORY_REPORT_BRAND_NAME As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_INVENTORY_REPORT_TO As WatermarkTextBox
    Friend WithEvents WTXT_INVENTORY_REPORT_FROM As WatermarkTextBox
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    ' Friend WithEvents TblM4_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_CATEGORYTableAdapter
    '  Friend WithEvents TblM4SUBCATEGORYBindingSource As BindingSource
    'Friend WithEvents TblM4_SUB_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_SUB_CATEGORYTableAdapter
    '   Friend WithEvents TblM4ITEMBRANDBindingSource As BindingSource
    '  Friend WithEvents TblM4_ITEMBRANDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_ITEMBRANDTableAdapter
    Friend WithEvents WatermarkTextBox1 As WatermarkTextBox
    Friend WithEvents SPM4CURRENTDATETIMEBindingSource As BindingSource
    Friend WithEvents SPM4_CURRENTDATETIMETableAdapter As DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents BTN_INVENTORY_REPORT_MINIMIZE As Button
    Friend WithEvents SpM4_INVENTORY_REPORTTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_INVENTORY_REPORTTableAdapter
    Friend WithEvents SPM4INVENTORYREPORTBindingSource As BindingSource
    Friend WithEvents DSPROPERTYDBBindingSource As BindingSource
    Friend WithEvents TblM4INVENTORYCATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter
    Friend WithEvents TblM4INVENTORYSUBCATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_SUB_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter
    Friend WithEvents TblM4INVENTORYITEMBRANDBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMBRANDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter
End Class
