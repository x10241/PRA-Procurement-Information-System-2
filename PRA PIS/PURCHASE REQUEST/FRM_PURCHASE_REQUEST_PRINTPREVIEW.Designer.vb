<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PURCHASE_REQUEST_PRINTPREVIEW
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
        Me.CRV_PRINT_PREV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.PR_PARTICULARS_PREVIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_GETPR_INFOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_GETPR_INFOTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_GETPR_INFOTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.PBOX_QRCODE = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN_GENERATE_REPORT = New System.Windows.Forms.Button()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.PBX_QRCODE = New System.Windows.Forms.PictureBox()
        Me.BTN_REPORT_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.SPM4_PRCODETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_PRCODETableAdapter()
        Me.SPM4PRCODEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter()
        Me.TblM4_PURCHASEREQUESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_PURCHASEREQUESTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter()
        Me.TblM4_PURCHASEREQUEST_ITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PR_PARTICULARS_PREVIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_GETPR_INFOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOX_QRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PNL.SuspendLayout()
        CType(Me.PBX_QRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4PRCODEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_PURCHASEREQUEST_ITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRV_PRINT_PREV
        '
        Me.CRV_PRINT_PREV.ActiveViewIndex = -1
        Me.CRV_PRINT_PREV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_PRINT_PREV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_PRINT_PREV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_PRINT_PREV.Location = New System.Drawing.Point(0, 0)
        Me.CRV_PRINT_PREV.Name = "CRV_PRINT_PREV"
        Me.CRV_PRINT_PREV.ShowCloseButton = False
        Me.CRV_PRINT_PREV.ShowCopyButton = False
        Me.CRV_PRINT_PREV.ShowExportButton = False
        Me.CRV_PRINT_PREV.ShowGotoPageButton = False
        Me.CRV_PRINT_PREV.ShowGroupTreeButton = False
        Me.CRV_PRINT_PREV.ShowLogo = False
        Me.CRV_PRINT_PREV.ShowParameterPanelButton = False
        Me.CRV_PRINT_PREV.ShowPrintButton = False
        Me.CRV_PRINT_PREV.ShowRefreshButton = False
        Me.CRV_PRINT_PREV.ShowTextSearchButton = False
        Me.CRV_PRINT_PREV.Size = New System.Drawing.Size(811, 463)
        Me.CRV_PRINT_PREV.TabIndex = 0
        Me.CRV_PRINT_PREV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PR_PARTICULARS_PREVIEWBindingSource
        '
        Me.PR_PARTICULARS_PREVIEWBindingSource.DataMember = "PR_PARTICULARS_PREVIEW"
        Me.PR_PARTICULARS_PREVIEWBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'SPM4_GETPR_INFOBindingSource
        '
        Me.SPM4_GETPR_INFOBindingSource.DataMember = "SPM4_GETPR_INFO"
        Me.SPM4_GETPR_INFOBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'SPM4_GETPR_INFOTableAdapter
        '
        Me.SPM4_GETPR_INFOTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENG_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENGTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAME_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAMETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERSTableAdapter = Nothing
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
        'PBOX_QRCODE
        '
        Me.PBOX_QRCODE.Location = New System.Drawing.Point(1095, 419)
        Me.PBOX_QRCODE.Name = "PBOX_QRCODE"
        Me.PBOX_QRCODE.Size = New System.Drawing.Size(100, 50)
        Me.PBOX_QRCODE.TabIndex = 1
        Me.PBOX_QRCODE.TabStop = False
        Me.PBOX_QRCODE.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 560)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PBOX_QRCODE)
        Me.Panel2.Controls.Add(Me.PNL)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(811, 560)
        Me.Panel2.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CRV_PRINT_PREV)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(811, 463)
        Me.Panel4.TabIndex = 1465
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BTN_GENERATE_REPORT)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 512)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(811, 48)
        Me.Panel3.TabIndex = 1464
        '
        'BTN_GENERATE_REPORT
        '
        Me.BTN_GENERATE_REPORT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_GENERATE_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_GENERATE_REPORT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BTN_GENERATE_REPORT.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GENERATE_REPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_GENERATE_REPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GENERATE_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GENERATE_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GENERATE_REPORT.Image = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.BTN_GENERATE_REPORT.Location = New System.Drawing.Point(0, 0)
        Me.BTN_GENERATE_REPORT.Name = "BTN_GENERATE_REPORT"
        Me.BTN_GENERATE_REPORT.Size = New System.Drawing.Size(811, 48)
        Me.BTN_GENERATE_REPORT.TabIndex = 1463
        Me.BTN_GENERATE_REPORT.Text = "SAVE AND PRINT"
        Me.BTN_GENERATE_REPORT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_GENERATE_REPORT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_GENERATE_REPORT.UseVisualStyleBackColor = False
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.PBX_QRCODE)
        Me.PNL.Controls.Add(Me.BTN_REPORT_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(811, 49)
        Me.PNL.TabIndex = 1462
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
        'BTN_REPORT_CLOSE
        '
        Me.BTN_REPORT_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_REPORT_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_REPORT_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_REPORT_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_REPORT_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_REPORT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REPORT_CLOSE.Location = New System.Drawing.Point(768, 7)
        Me.BTN_REPORT_CLOSE.Name = "BTN_REPORT_CLOSE"
        Me.BTN_REPORT_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_REPORT_CLOSE.TabIndex = 10
        Me.BTN_REPORT_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_REPORT_CLOSE.UseVisualStyleBackColor = True
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4275, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4228, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'SPM4_PRCODETableAdapter
        '
        Me.SPM4_PRCODETableAdapter.ClearBeforeFill = True
        '
        'SPM4PRCODEBindingSource
        '
        Me.SPM4PRCODEBindingSource.DataMember = "SPM4_PRCODE"
        Me.SPM4PRCODEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblM4_PURCHASEREQUEST_ITEMTableAdapter
        '
        Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUESTBindingSource
        '
        Me.TblM4_PURCHASEREQUESTBindingSource.DataMember = "tblM4_PURCHASEREQUEST"
        Me.TblM4_PURCHASEREQUESTBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_PURCHASEREQUESTTableAdapter
        '
        Me.TblM4_PURCHASEREQUESTTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUEST_ITEMBindingSource
        '
        Me.TblM4_PURCHASEREQUEST_ITEMBindingSource.DataMember = "tblM4_PURCHASEREQUEST_ITEM"
        Me.TblM4_PURCHASEREQUEST_ITEMBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'FRM_PURCHASE_REQUEST_PRINTPREVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 560)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_PURCHASE_REQUEST_PRINTPREVIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PR_PARTICULARS_PREVIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_GETPR_INFOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOX_QRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.PBX_QRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4PRCODEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_PURCHASEREQUEST_ITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV_PRINT_PREV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents PR_PARTICULARS_PREVIEWBindingSource As BindingSource
    Friend WithEvents SPM4_GETPR_INFOBindingSource As BindingSource
    Friend WithEvents SPM4_GETPR_INFOTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_GETPR_INFOTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents PBOX_QRCODE As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PNL As Panel
    Friend WithEvents PBX_QRCODE As PictureBox
    Friend WithEvents BTN_REPORT_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents BTN_GENERATE_REPORT As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents SPM4_PRCODETableAdapter As DS_PROPERTYDBTableAdapters.SPM4_PRCODETableAdapter
    Friend WithEvents SPM4PRCODEBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents TblM4_PURCHASEREQUEST_ITEMTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter
    Friend WithEvents TblM4_PURCHASEREQUESTBindingSource As BindingSource
    Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents TblM4_PURCHASEREQUEST_ITEMBindingSource As BindingSource
End Class
