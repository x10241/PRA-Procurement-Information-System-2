<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_INVENTORY_REPORT_PRINT_PREVIEW
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
        Me.PBX_QRCODE = New System.Windows.Forms.PictureBox()
        Me.BTN_INVENTORY_REPORT_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY_REPORT_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.SPM4_CURRENTDATETIMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.BTN_INVENTORY_GENERATE_REPORT = New System.Windows.Forms.Button()
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.SpM4_INVENTORY_REPORTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_INVENTORY_REPORTTableAdapter()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.CRV_INVENTORY_PREVIEW = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DT_REQUISITIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.SpM4_CURRENTDATETIMETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter()
        Me.DS_CUSTOM = New PRA_PIS.DS_CUSTOM()
        Me.DT_ITEM_REQ_PREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeedataTableAdapter1 = New PRA_PIS.DS_TABLESTableAdapters.EMPLOYEEDATATableAdapter()
        Me.TBLM4_INVENTORY_REQUISITIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_REQ_CODEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_REQ_CODETableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_REQ_CODETableAdapter()
        Me.TableAdapterManager1 = New PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager()
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter()
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INVENTORY_REQUISITIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_REQUISITIONTableAdapter()
        Me.PNL.SuspendLayout()
        CType(Me.PBX_QRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DT_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_ITEM_REQ_PREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INVENTORY_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_REQ_CODEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.PBX_QRCODE)
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_REPORT_MINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_REPORT_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(746, 49)
        Me.PNL.TabIndex = 1458
        '
        'PBX_QRCODE
        '
        Me.PBX_QRCODE.Location = New System.Drawing.Point(1095, 14)
        Me.PBX_QRCODE.Name = "PBX_QRCODE"
        Me.PBX_QRCODE.Size = New System.Drawing.Size(100, 50)
        Me.PBX_QRCODE.TabIndex = 13
        Me.PBX_QRCODE.TabStop = False
        Me.PBX_QRCODE.Visible = False
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
        Me.BTN_INVENTORY_REPORT_MINIMIZE.Location = New System.Drawing.Point(669, 9)
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
        Me.BTN_INVENTORY_REPORT_CLOSE.Location = New System.Drawing.Point(703, 7)
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
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(181, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "P r i n t  P r e v i e w"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4340, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4293, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'SPM4_CURRENTDATETIMEBindingSource
        '
        Me.SPM4_CURRENTDATETIMEBindingSource.DataMember = "SPM4_CURRENTDATETIME"
        Me.SPM4_CURRENTDATETIMEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTN_INVENTORY_GENERATE_REPORT
        '
        Me.BTN_INVENTORY_GENERATE_REPORT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_INVENTORY_GENERATE_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INVENTORY_GENERATE_REPORT.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTN_INVENTORY_GENERATE_REPORT.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_GENERATE_REPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_INVENTORY_GENERATE_REPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_INVENTORY_GENERATE_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_GENERATE_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INVENTORY_GENERATE_REPORT.Image = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.BTN_INVENTORY_GENERATE_REPORT.Location = New System.Drawing.Point(0, 418)
        Me.BTN_INVENTORY_GENERATE_REPORT.Name = "BTN_INVENTORY_GENERATE_REPORT"
        Me.BTN_INVENTORY_GENERATE_REPORT.Size = New System.Drawing.Size(746, 43)
        Me.BTN_INVENTORY_GENERATE_REPORT.TabIndex = 1459
        Me.BTN_INVENTORY_GENERATE_REPORT.Text = "PRINT REPORT"
        Me.BTN_INVENTORY_GENERATE_REPORT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_INVENTORY_GENERATE_REPORT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_GENERATE_REPORT.UseVisualStyleBackColor = False
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
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'CRV_INVENTORY_PREVIEW
        '
        Me.CRV_INVENTORY_PREVIEW.ActiveViewIndex = -1
        Me.CRV_INVENTORY_PREVIEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_INVENTORY_PREVIEW.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_INVENTORY_PREVIEW.DisplayBackgroundEdge = False
        Me.CRV_INVENTORY_PREVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_INVENTORY_PREVIEW.EnableRefresh = False
        Me.CRV_INVENTORY_PREVIEW.Location = New System.Drawing.Point(0, 0)
        Me.CRV_INVENTORY_PREVIEW.Name = "CRV_INVENTORY_PREVIEW"
        Me.CRV_INVENTORY_PREVIEW.ShowCloseButton = False
        Me.CRV_INVENTORY_PREVIEW.ShowCopyButton = False
        Me.CRV_INVENTORY_PREVIEW.ShowExportButton = False
        Me.CRV_INVENTORY_PREVIEW.ShowGroupTreeButton = False
        Me.CRV_INVENTORY_PREVIEW.ShowLogo = False
        Me.CRV_INVENTORY_PREVIEW.ShowPrintButton = False
        Me.CRV_INVENTORY_PREVIEW.ShowRefreshButton = False
        Me.CRV_INVENTORY_PREVIEW.ShowTextSearchButton = False
        Me.CRV_INVENTORY_PREVIEW.Size = New System.Drawing.Size(746, 369)
        Me.CRV_INVENTORY_PREVIEW.TabIndex = 0
        Me.CRV_INVENTORY_PREVIEW.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CRV_INVENTORY_PREVIEW)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 369)
        Me.Panel1.TabIndex = 1460
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.TBLG3_COMPANY_INFOTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_DELIVER_RECEIPT_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_DELIVERY_RECEIPTTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_INVOICE_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_INVOICETableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_PRIMARY_SIGNATORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_BUSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_DVTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_PARTICULARTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORY_TYPETableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORY1TableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_UNITSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_DIST_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_DR_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_COLORTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_IMGTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENG_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENGTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_MIGRATETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAME_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAMETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_PCOUNTTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_STK_CTRLTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEMS_DRTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEMS_INVTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_REQUISITIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_SUB_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_TYPETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CANCELEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_POSTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_PROVIDERTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_REVISIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUESTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SpM4_CURRENTDATETIMETableAdapter
        '
        Me.SpM4_CURRENTDATETIMETableAdapter.ClearBeforeFill = True
        '
        'DS_CUSTOM
        '
        Me.DS_CUSTOM.DataSetName = "DS_CUSTOM"
        Me.DS_CUSTOM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_ITEM_REQ_PREBindingSource
        '
        Me.DT_ITEM_REQ_PREBindingSource.DataSource = Me.DS_CUSTOM
        Me.DT_ITEM_REQ_PREBindingSource.Position = 0
        '
        'EmployeedataTableAdapter1
        '
        Me.EmployeedataTableAdapter1.ClearBeforeFill = True
        '
        'TBLM4_INVENTORY_REQUISITIONBindingSource
        '
        Me.TBLM4_INVENTORY_REQUISITIONBindingSource.DataMember = "TBLM4_INVENTORY_REQUISITION"
        Me.TBLM4_INVENTORY_REQUISITIONBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'SPM4_ITEM_REQ_CODEBindingSource
        '
        Me.SPM4_ITEM_REQ_CODEBindingSource.DataMember = "SPM4_ITEM_REQ_CODE"
        Me.SPM4_ITEM_REQ_CODEBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_ITEM_REQ_CODETableAdapter
        '
        Me.SPM4_ITEM_REQ_CODETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.A_CLOSEPROGRAMTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter
        '
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter.ClearBeforeFill = True
        '
        'TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource
        '
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource.DataMember = "TBLM4_INVENTORY_ITEM_REQUISITION"
        Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INVENTORY_REQUISITIONTableAdapter
        '
        Me.TBLM4_INVENTORY_REQUISITIONTableAdapter.ClearBeforeFill = True
        '
        'FRM_INVENTORY_REPORT_PRINT_PREVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(746, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_INVENTORY_GENERATE_REPORT)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_INVENTORY_REPORT_PRINT_PREVIEW"
        Me.Text = "Print Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.PBX_QRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DT_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_ITEM_REQ_PREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INVENTORY_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_REQ_CODEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_INVENTORY_REPORT_MINIMIZE As Button
    Friend WithEvents BTN_INVENTORY_REPORT_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents BTN_INVENTORY_GENERATE_REPORT As Button
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SpM4_INVENTORY_REPORTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_INVENTORY_REPORTTableAdapter
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents CRV_INVENTORY_PREVIEW As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DT_REQUISITIONBindingSource As BindingSource
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents SPM4_CURRENTDATETIMEBindingSource As BindingSource
    Friend WithEvents SpM4_CURRENTDATETIMETableAdapter As DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter
    Friend WithEvents DS_CUSTOM As DS_CUSTOM
    Friend WithEvents DT_ITEM_REQ_PREBindingSource As BindingSource
    Friend WithEvents EmployeedataTableAdapter1 As DS_TABLESTableAdapters.EMPLOYEEDATATableAdapter
    Friend WithEvents TBLM4_INVENTORY_REQUISITIONBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_REQ_CODEBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_REQ_CODETableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_REQ_CODETableAdapter
    Friend WithEvents TableAdapterManager1 As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents PBX_QRCODE As PictureBox
    Friend WithEvents TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter
    Friend WithEvents TBLM4_INVENTORY_ITEM_REQUISITIONBindingSource As BindingSource
    Friend WithEvents TBLM4_INVENTORY_REQUISITIONTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_REQUISITIONTableAdapter
End Class
