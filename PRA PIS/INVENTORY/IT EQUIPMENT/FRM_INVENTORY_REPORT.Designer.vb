<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_INVENTORY_REPORT
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
        Me.BTN_INVENTORY_REPORT_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.APNL_INVENTORY_REPORT = New System.Windows.Forms.Panel()
        Me.PNL_ACCOUNTABLE_PERSON = New System.Windows.Forms.Panel()
        Me.CHK_ASSIGN_ITEMS_BY = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_ASSIGN_SEARCH_BY = New System.Windows.Forms.ComboBox()
        Me.EmployeeInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.CB_ASSIGN_BY = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CB_REPORT_TYPE = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_DATE_FILTER = New System.Windows.Forms.ComboBox()
        Me.PNL_CUSTOM_RANGE = New System.Windows.Forms.Panel()
        Me.WTXT_INVENTORY_REPORT_TO = New PRA_PIS.WatermarkTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WTXT_INVENTORY_REPORT_FROM = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PNL_ITEM_ONLY = New System.Windows.Forms.Panel()
        Me.CHK_SEL_ALL_ITEMS = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_SEARCH_BY = New System.Windows.Forms.ComboBox()
        Me.TblM4INVENTORYITEMBRANDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.CB_FILTERBY = New System.Windows.Forms.ComboBox()
        Me.WatermarkTextBox1 = New PRA_PIS.WatermarkTextBox()
        Me.SPM4CURRENTDATETIMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTN_INVENTORY_GENERATE_REPORT = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SPM4_CURRENTDATETIMETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter()
        Me.SPM4INVENTORYREPORTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter()
        Me.DSPROPERTYDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter()
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter()
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.SpM4_INVENTORY_REPORTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_INVENTORY_REPORTTableAdapter()
        Me.TblM4INVENTORYCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4INVENTORYSUBCATEGORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4INVENTORYITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter()
        Me.TblM4_INVENTORY_ITEMS2TableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS2TableAdapter()
        Me.TblM4_INVENTORY_ITEMS2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeInfoTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.EmployeeInfoTableAdapter()
        Me.TblV1_HRISDIVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblV1_HRISDIVISIONTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter()
        Me.PNL.SuspendLayout()
        Me.APNL_INVENTORY_REPORT.SuspendLayout()
        Me.PNL_ACCOUNTABLE_PERSON.SuspendLayout()
        CType(Me.EmployeeInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PNL_CUSTOM_RANGE.SuspendLayout()
        Me.PNL_ITEM_ONLY.SuspendLayout()
        CType(Me.TblM4INVENTORYITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4INVENTORYREPORTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPROPERTYDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMS2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_REPORT_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(915, 49)
        Me.PNL.TabIndex = 1457
        '
        'BTN_INVENTORY_REPORT_CLOSE
        '
        Me.BTN_INVENTORY_REPORT_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INVENTORY_REPORT_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INVENTORY_REPORT_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_REPORT_CLOSE.Location = New System.Drawing.Point(873, 11)
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4487, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4440, 10)
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
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.PNL_ACCOUNTABLE_PERSON)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.Panel3)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.Panel2)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.PNL_ITEM_ONLY)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.WatermarkTextBox1)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.BTN_INVENTORY_GENERATE_REPORT)
        Me.APNL_INVENTORY_REPORT.Controls.Add(Me.ShapeContainer1)
        Me.APNL_INVENTORY_REPORT.Location = New System.Drawing.Point(3, 51)
        Me.APNL_INVENTORY_REPORT.Name = "APNL_INVENTORY_REPORT"
        Me.APNL_INVENTORY_REPORT.Size = New System.Drawing.Size(909, 212)
        Me.APNL_INVENTORY_REPORT.TabIndex = 1456
        '
        'PNL_ACCOUNTABLE_PERSON
        '
        Me.PNL_ACCOUNTABLE_PERSON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_ACCOUNTABLE_PERSON.Controls.Add(Me.CHK_ASSIGN_ITEMS_BY)
        Me.PNL_ACCOUNTABLE_PERSON.Controls.Add(Me.Label5)
        Me.PNL_ACCOUNTABLE_PERSON.Controls.Add(Me.CB_ASSIGN_SEARCH_BY)
        Me.PNL_ACCOUNTABLE_PERSON.Controls.Add(Me.CB_ASSIGN_BY)
        Me.PNL_ACCOUNTABLE_PERSON.Location = New System.Drawing.Point(0, 46)
        Me.PNL_ACCOUNTABLE_PERSON.Name = "PNL_ACCOUNTABLE_PERSON"
        Me.PNL_ACCOUNTABLE_PERSON.Size = New System.Drawing.Size(907, 60)
        Me.PNL_ACCOUNTABLE_PERSON.TabIndex = 1483
        '
        'CHK_ASSIGN_ITEMS_BY
        '
        Me.CHK_ASSIGN_ITEMS_BY.AutoSize = True
        Me.CHK_ASSIGN_ITEMS_BY.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_ASSIGN_ITEMS_BY.Location = New System.Drawing.Point(372, 39)
        Me.CHK_ASSIGN_ITEMS_BY.Name = "CHK_ASSIGN_ITEMS_BY"
        Me.CHK_ASSIGN_ITEMS_BY.Size = New System.Drawing.Size(122, 20)
        Me.CHK_ASSIGN_ITEMS_BY.TabIndex = 1481
        Me.CHK_ASSIGN_ITEMS_BY.Text = "Select all items"
        Me.CHK_ASSIGN_ITEMS_BY.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(9, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 1463
        Me.Label5.Text = "Search by:"
        '
        'CB_ASSIGN_SEARCH_BY
        '
        Me.CB_ASSIGN_SEARCH_BY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_ASSIGN_SEARCH_BY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_ASSIGN_SEARCH_BY.DataSource = Me.EmployeeInfoBindingSource
        Me.CB_ASSIGN_SEARCH_BY.DisplayMember = "FULLNAME"
        Me.CB_ASSIGN_SEARCH_BY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ASSIGN_SEARCH_BY.FormattingEnabled = True
        Me.CB_ASSIGN_SEARCH_BY.Location = New System.Drawing.Point(366, 7)
        Me.CB_ASSIGN_SEARCH_BY.Name = "CB_ASSIGN_SEARCH_BY"
        Me.CB_ASSIGN_SEARCH_BY.Size = New System.Drawing.Size(468, 29)
        Me.CB_ASSIGN_SEARCH_BY.TabIndex = 1479
        Me.CB_ASSIGN_SEARCH_BY.ValueMember = "HRIS_EMPNO"
        '
        'EmployeeInfoBindingSource
        '
        Me.EmployeeInfoBindingSource.DataMember = "EmployeeInfo"
        Me.EmployeeInfoBindingSource.DataSource = Me.DS_TABLES
        '
        'DS_TABLES
        '
        Me.DS_TABLES.DataSetName = "DS_TABLES"
        Me.DS_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CB_ASSIGN_BY
        '
        Me.CB_ASSIGN_BY.DisplayMember = "SC_NO"
        Me.CB_ASSIGN_BY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ASSIGN_BY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ASSIGN_BY.FormattingEnabled = True
        Me.CB_ASSIGN_BY.Items.AddRange(New Object() {"Employee Name", "Division/Unit"})
        Me.CB_ASSIGN_BY.Location = New System.Drawing.Point(122, 7)
        Me.CB_ASSIGN_BY.Name = "CB_ASSIGN_BY"
        Me.CB_ASSIGN_BY.Size = New System.Drawing.Size(238, 29)
        Me.CB_ASSIGN_BY.TabIndex = 1472
        Me.CB_ASSIGN_BY.ValueMember = "SC_NO"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CB_REPORT_TYPE)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(907, 44)
        Me.Panel3.TabIndex = 1482
        '
        'CB_REPORT_TYPE
        '
        Me.CB_REPORT_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_REPORT_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_REPORT_TYPE.FormattingEnabled = True
        Me.CB_REPORT_TYPE.Items.AddRange(New Object() {"Item Only", "Items w/ Location", "Item assign to accountable person"})
        Me.CB_REPORT_TYPE.Location = New System.Drawing.Point(122, 7)
        Me.CB_REPORT_TYPE.Name = "CB_REPORT_TYPE"
        Me.CB_REPORT_TYPE.Size = New System.Drawing.Size(374, 29)
        Me.CB_REPORT_TYPE.TabIndex = 1473
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(9, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 1463
        Me.Label4.Text = "Report type:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.CB_DATE_FILTER)
        Me.Panel2.Controls.Add(Me.PNL_CUSTOM_RANGE)
        Me.Panel2.Location = New System.Drawing.Point(0, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(907, 49)
        Me.Panel2.TabIndex = 1481
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(9, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 18)
        Me.Label3.TabIndex = 1478
        Me.Label3.Text = "Date Range:"
        '
        'CB_DATE_FILTER
        '
        Me.CB_DATE_FILTER.DisplayMember = "SC_NO"
        Me.CB_DATE_FILTER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_DATE_FILTER.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_DATE_FILTER.FormattingEnabled = True
        Me.CB_DATE_FILTER.Items.AddRange(New Object() {"Past Week", "Past Month", "Past Year", "Custom Range"})
        Me.CB_DATE_FILTER.Location = New System.Drawing.Point(122, 8)
        Me.CB_DATE_FILTER.Name = "CB_DATE_FILTER"
        Me.CB_DATE_FILTER.Size = New System.Drawing.Size(238, 29)
        Me.CB_DATE_FILTER.TabIndex = 1474
        Me.CB_DATE_FILTER.ValueMember = "SC_NO"
        '
        'PNL_CUSTOM_RANGE
        '
        Me.PNL_CUSTOM_RANGE.Controls.Add(Me.WTXT_INVENTORY_REPORT_TO)
        Me.PNL_CUSTOM_RANGE.Controls.Add(Me.Label2)
        Me.PNL_CUSTOM_RANGE.Controls.Add(Me.Label1)
        Me.PNL_CUSTOM_RANGE.Controls.Add(Me.WTXT_INVENTORY_REPORT_FROM)
        Me.PNL_CUSTOM_RANGE.Controls.Add(Me.ShapeContainer2)
        Me.PNL_CUSTOM_RANGE.Location = New System.Drawing.Point(366, -3)
        Me.PNL_CUSTOM_RANGE.Name = "PNL_CUSTOM_RANGE"
        Me.PNL_CUSTOM_RANGE.Size = New System.Drawing.Size(359, 51)
        Me.PNL_CUSTOM_RANGE.TabIndex = 1476
        Me.PNL_CUSTOM_RANGE.Visible = False
        '
        'WTXT_INVENTORY_REPORT_TO
        '
        Me.WTXT_INVENTORY_REPORT_TO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_REPORT_TO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_INVENTORY_REPORT_TO.Location = New System.Drawing.Point(218, 14)
        Me.WTXT_INVENTORY_REPORT_TO.Name = "WTXT_INVENTORY_REPORT_TO"
        Me.WTXT_INVENTORY_REPORT_TO.ReadOnly = True
        Me.WTXT_INVENTORY_REPORT_TO.Size = New System.Drawing.Size(127, 20)
        Me.WTXT_INVENTORY_REPORT_TO.TabIndex = 4
        Me.WTXT_INVENTORY_REPORT_TO.Text = "MM/DD/YYYY"
        Me.WTXT_INVENTORY_REPORT_TO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_INVENTORY_REPORT_TO.Watermark = "MM/DD/YYYY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(187, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 16)
        Me.Label2.TabIndex = 1475
        Me.Label2.Text = "TO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 1473
        Me.Label1.Text = "FROM"
        '
        'WTXT_INVENTORY_REPORT_FROM
        '
        Me.WTXT_INVENTORY_REPORT_FROM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_INVENTORY_REPORT_FROM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_INVENTORY_REPORT_FROM.Location = New System.Drawing.Point(54, 14)
        Me.WTXT_INVENTORY_REPORT_FROM.Name = "WTXT_INVENTORY_REPORT_FROM"
        Me.WTXT_INVENTORY_REPORT_FROM.ReadOnly = True
        Me.WTXT_INVENTORY_REPORT_FROM.Size = New System.Drawing.Size(127, 20)
        Me.WTXT_INVENTORY_REPORT_FROM.TabIndex = 3
        Me.WTXT_INVENTORY_REPORT_FROM.Text = "MM/DD/YYYY"
        Me.WTXT_INVENTORY_REPORT_FROM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_INVENTORY_REPORT_FROM.Watermark = "MM/DD/YYYY"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape5})
        Me.ShapeContainer2.Size = New System.Drawing.Size(359, 51)
        Me.ShapeContainer2.TabIndex = 1474
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(216, 10)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(132, 27)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Location = New System.Drawing.Point(51, 10)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(132, 27)
        '
        'PNL_ITEM_ONLY
        '
        Me.PNL_ITEM_ONLY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_ITEM_ONLY.Controls.Add(Me.CHK_SEL_ALL_ITEMS)
        Me.PNL_ITEM_ONLY.Controls.Add(Me.Label6)
        Me.PNL_ITEM_ONLY.Controls.Add(Me.CB_SEARCH_BY)
        Me.PNL_ITEM_ONLY.Controls.Add(Me.CB_FILTERBY)
        Me.PNL_ITEM_ONLY.Location = New System.Drawing.Point(0, 46)
        Me.PNL_ITEM_ONLY.Name = "PNL_ITEM_ONLY"
        Me.PNL_ITEM_ONLY.Size = New System.Drawing.Size(907, 60)
        Me.PNL_ITEM_ONLY.TabIndex = 1480
        '
        'CHK_SEL_ALL_ITEMS
        '
        Me.CHK_SEL_ALL_ITEMS.AutoSize = True
        Me.CHK_SEL_ALL_ITEMS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SEL_ALL_ITEMS.Location = New System.Drawing.Point(398, 39)
        Me.CHK_SEL_ALL_ITEMS.Name = "CHK_SEL_ALL_ITEMS"
        Me.CHK_SEL_ALL_ITEMS.Size = New System.Drawing.Size(141, 20)
        Me.CHK_SEL_ALL_ITEMS.TabIndex = 1481
        Me.CHK_SEL_ALL_ITEMS.Text = "Select all items in "
        Me.CHK_SEL_ALL_ITEMS.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label6.Location = New System.Drawing.Point(9, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 1463
        Me.Label6.Text = "Search by:"
        '
        'CB_SEARCH_BY
        '
        Me.CB_SEARCH_BY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CB_SEARCH_BY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_SEARCH_BY.DataSource = Me.TblM4INVENTORYITEMBRANDBindingSource
        Me.CB_SEARCH_BY.DisplayMember = "SC_NO"
        Me.CB_SEARCH_BY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_SEARCH_BY.FormattingEnabled = True
        Me.CB_SEARCH_BY.Location = New System.Drawing.Point(366, 7)
        Me.CB_SEARCH_BY.Name = "CB_SEARCH_BY"
        Me.CB_SEARCH_BY.Size = New System.Drawing.Size(317, 29)
        Me.CB_SEARCH_BY.TabIndex = 1479
        Me.CB_SEARCH_BY.ValueMember = "SC_NO"
        '
        'TblM4INVENTORYITEMBRANDBindingSource
        '
        Me.TblM4INVENTORYITEMBRANDBindingSource.DataMember = "tblM4_INVENTORY_ITEMBRAND"
        Me.TblM4INVENTORYITEMBRANDBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CB_FILTERBY
        '
        Me.CB_FILTERBY.DisplayMember = "SC_NO"
        Me.CB_FILTERBY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_FILTERBY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FILTERBY.FormattingEnabled = True
        Me.CB_FILTERBY.Items.AddRange(New Object() {"Category", "Sub Category/Type", "Brand/Provider Name", "Item Description"})
        Me.CB_FILTERBY.Location = New System.Drawing.Point(122, 7)
        Me.CB_FILTERBY.Name = "CB_FILTERBY"
        Me.CB_FILTERBY.Size = New System.Drawing.Size(238, 29)
        Me.CB_FILTERBY.TabIndex = 1472
        Me.CB_FILTERBY.ValueMember = "SC_NO"
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
        Me.BTN_INVENTORY_GENERATE_REPORT.Location = New System.Drawing.Point(4, 160)
        Me.BTN_INVENTORY_GENERATE_REPORT.Name = "BTN_INVENTORY_GENERATE_REPORT"
        Me.BTN_INVENTORY_GENERATE_REPORT.Size = New System.Drawing.Size(900, 43)
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(907, 210)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(3, 159)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(900, 45)
        '
        'SPM4_CURRENTDATETIMETableAdapter
        '
        Me.SPM4_CURRENTDATETIMETableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'DSPROPERTYDBBindingSource
        '
        Me.DSPROPERTYDBBindingSource.DataSource = Me.DS_PROPERTYDB
        Me.DSPROPERTYDBBindingSource.Position = 0
        '
        'TblM4_INVENTORY_SUB_CATEGORYTableAdapter
        '
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMBRANDTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.ClearBeforeFill = True
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpM4_INVENTORY_REPORTTableAdapter
        '
        Me.SpM4_INVENTORY_REPORTTableAdapter.ClearBeforeFill = True
        '
        'TblM4INVENTORYCATEGORYBindingSource
        '
        Me.TblM4INVENTORYCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_CATEGORY"
        Me.TblM4INVENTORYCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4INVENTORYSUBCATEGORYBindingSource
        '
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataMember = "tblM4_INVENTORY_SUB_CATEGORY"
        Me.TblM4INVENTORYSUBCATEGORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4INVENTORYITEMSBindingSource
        '
        Me.TblM4INVENTORYITEMSBindingSource.DataMember = "tblM4_INVENTORY_ITEMS"
        Me.TblM4INVENTORYITEMSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_ITEMSTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMSTableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMS2TableAdapter
        '
        Me.TblM4_INVENTORY_ITEMS2TableAdapter.ClearBeforeFill = True
        '
        'TblM4_INVENTORY_ITEMS2BindingSource
        '
        Me.TblM4_INVENTORY_ITEMS2BindingSource.DataMember = "tblM4_INVENTORY_ITEMS2"
        Me.TblM4_INVENTORY_ITEMS2BindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'EmployeeInfoTableAdapter
        '
        Me.EmployeeInfoTableAdapter.ClearBeforeFill = True
        '
        'TblV1_HRISDIVISIONBindingSource
        '
        Me.TblV1_HRISDIVISIONBindingSource.DataMember = "tblV1_HRISDIVISION"
        Me.TblV1_HRISDIVISIONBindingSource.DataSource = Me.DS_TABLES
        '
        'TblV1_HRISDIVISIONTableAdapter
        '
        Me.TblV1_HRISDIVISIONTableAdapter.ClearBeforeFill = True
        '
        'FRM_INVENTORY_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 265)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.APNL_INVENTORY_REPORT)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FRM_INVENTORY_REPORT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.APNL_INVENTORY_REPORT.ResumeLayout(False)
        Me.APNL_INVENTORY_REPORT.PerformLayout()
        Me.PNL_ACCOUNTABLE_PERSON.ResumeLayout(False)
        Me.PNL_ACCOUNTABLE_PERSON.PerformLayout()
        CType(Me.EmployeeInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PNL_CUSTOM_RANGE.ResumeLayout(False)
        Me.PNL_CUSTOM_RANGE.PerformLayout()
        Me.PNL_ITEM_ONLY.ResumeLayout(False)
        Me.PNL_ITEM_ONLY.PerformLayout()
        CType(Me.TblM4INVENTORYITEMBRANDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4INVENTORYREPORTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPROPERTYDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYSUBCATEGORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMS2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_INVENTORY_REPORT_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents APNL_INVENTORY_REPORT As Panel
    Friend WithEvents BTN_INVENTORY_GENERATE_REPORT As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
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
    '  Friend WithEvents SpM4_INVENTORY_REPORTTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_INVENTORY_REPORTTableAdapter
    Friend WithEvents SPM4INVENTORYREPORTBindingSource As BindingSource
    Friend WithEvents DSPROPERTYDBBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_CATEGORYTableAdapter
    Friend WithEvents TblM4_INVENTORY_SUB_CATEGORYTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_SUB_CATEGORYTableAdapter
    Friend WithEvents TblM4_INVENTORY_ITEMBRANDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMBRANDTableAdapter
    Friend WithEvents CB_DATE_FILTER As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PNL_CUSTOM_RANGE As Panel
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SpM4_INVENTORY_REPORTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_INVENTORY_REPORTTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_REPORT_TYPE As ComboBox
    Friend WithEvents TblM4INVENTORYCATEGORYBindingSource As BindingSource
    Friend WithEvents TblM4INVENTORYITEMBRANDBindingSource As BindingSource
    Friend WithEvents TblM4INVENTORYSUBCATEGORYBindingSource As BindingSource
    Friend WithEvents PNL_ITEM_ONLY As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents CB_SEARCH_BY As ComboBox
    Friend WithEvents CB_FILTERBY As ComboBox
    Friend WithEvents TblM4INVENTORYITEMSBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMSTableAdapter
    Friend WithEvents CHK_SEL_ALL_ITEMS As CheckBox
    Friend WithEvents TblM4_INVENTORY_ITEMS2TableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS2TableAdapter
    Friend WithEvents TblM4_INVENTORY_ITEMS2BindingSource As BindingSource
    Friend WithEvents PNL_ACCOUNTABLE_PERSON As Panel
    Friend WithEvents CHK_ASSIGN_ITEMS_BY As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_ASSIGN_SEARCH_BY As ComboBox
    Friend WithEvents CB_ASSIGN_BY As ComboBox
    Friend WithEvents EmployeeInfoTableAdapter As DS_TABLESTableAdapters.EmployeeInfoTableAdapter
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TblV1_HRISDIVISIONBindingSource As BindingSource
    Friend WithEvents TblV1_HRISDIVISIONTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter
    Friend WithEvents EmployeeInfoBindingSource As BindingSource
End Class
