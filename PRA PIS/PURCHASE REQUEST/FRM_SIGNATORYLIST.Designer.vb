<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_SIGNATORYLIST
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
        Me.PBICONSEARCH = New System.Windows.Forms.PictureBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GB_PRLIST = New System.Windows.Forms.GroupBox()
        Me.VWG3_PRIMARY_SIGNATORYDataGridView = New System.Windows.Forms.DataGridView()
        Me.SPM4_SIGNATORY_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.WTXT_SEARCHSIGNATORY = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRSEARCH = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.SPM4_SIGNATORY_LISTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_SIGNATORY_LISTTableAdapter()
        Me.SIGDATEEMPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSPOSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPFNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPMNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDSTITLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIGSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEENCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        Me.GB_PRLIST.SuspendLayout()
        CType(Me.VWG3_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_SIGNATORY_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBICONSEARCH
        '
        Me.PBICONSEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PBICONSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBICONSEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBICONSEARCH.InitialImage = Nothing
        Me.PBICONSEARCH.Location = New System.Drawing.Point(611, 26)
        Me.PBICONSEARCH.Name = "PBICONSEARCH"
        Me.PBICONSEARCH.Size = New System.Drawing.Size(32, 24)
        Me.PBICONSEARCH.TabIndex = 1408
        Me.PBICONSEARCH.TabStop = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(10, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(217, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "S I G N A T O R Y   L I S T"
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(667, 42)
        Me.PNL.TabIndex = 1406
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(633, 6)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(5, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 1411
        '
        'GB_PRLIST
        '
        Me.GB_PRLIST.BackColor = System.Drawing.SystemColors.Window
        Me.GB_PRLIST.Controls.Add(Me.VWG3_PRIMARY_SIGNATORYDataGridView)
        Me.GB_PRLIST.Controls.Add(Me.Label6)
        Me.GB_PRLIST.Controls.Add(Me.PBICONSEARCH)
        Me.GB_PRLIST.Controls.Add(Me.WTXT_SEARCHSIGNATORY)
        Me.GB_PRLIST.Controls.Add(Me.ShapeContainer2)
        Me.GB_PRLIST.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GB_PRLIST.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_PRLIST.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GB_PRLIST.Location = New System.Drawing.Point(4, 36)
        Me.GB_PRLIST.Name = "GB_PRLIST"
        Me.GB_PRLIST.Size = New System.Drawing.Size(663, 583)
        Me.GB_PRLIST.TabIndex = 1405
        Me.GB_PRLIST.TabStop = False
        '
        'VWG3_PRIMARY_SIGNATORYDataGridView
        '
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.AllowUserToAddRows = False
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.AllowUserToDeleteRows = False
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.AllowUserToResizeRows = False
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.AutoGenerateColumns = False
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SIGDATEEMPIDDataGridViewTextBoxColumn, Me.FULLNAMEDataGridViewTextBoxColumn, Me.POSPOSITIONDataGridViewTextBoxColumn, Me.EMPLNAMEDataGridViewTextBoxColumn, Me.EMPFNAMEDataGridViewTextBoxColumn, Me.EMPMNAMEDataGridViewTextBoxColumn, Me.POSNODataGridViewTextBoxColumn, Me.PDSTITLEDataGridViewTextBoxColumn, Me.SIGSTATUSDataGridViewTextBoxColumn, Me.DATEENCODEDataGridViewTextBoxColumn})
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.DataSource = Me.SPM4_SIGNATORY_LISTBindingSource
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.Location = New System.Drawing.Point(6, 61)
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.Name = "VWG3_PRIMARY_SIGNATORYDataGridView"
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.ReadOnly = True
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.RowHeadersVisible = False
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.Size = New System.Drawing.Size(650, 504)
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.TabIndex = 1407
        '
        'SPM4_SIGNATORY_LISTBindingSource
        '
        Me.SPM4_SIGNATORY_LISTBindingSource.DataMember = "SPM4_SIGNATORY_LIST"
        Me.SPM4_SIGNATORY_LISTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WTXT_SEARCHSIGNATORY
        '
        Me.WTXT_SEARCHSIGNATORY.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SEARCHSIGNATORY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCHSIGNATORY.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCHSIGNATORY.ForeColor = System.Drawing.Color.Black
        Me.WTXT_SEARCHSIGNATORY.Location = New System.Drawing.Point(16, 25)
        Me.WTXT_SEARCHSIGNATORY.Name = "WTXT_SEARCHSIGNATORY"
        Me.WTXT_SEARCHSIGNATORY.Size = New System.Drawing.Size(595, 26)
        Me.WTXT_SEARCHSIGNATORY.TabIndex = 0
        Me.WTXT_SEARCHSIGNATORY.Watermark = "Search Name"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRSEARCH})
        Me.ShapeContainer2.Size = New System.Drawing.Size(657, 561)
        Me.ShapeContainer2.TabIndex = 5
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_PRSEARCH
        '
        Me.RECT_PRSEARCH.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRSEARCH.CornerRadius = 15
        Me.RECT_PRSEARCH.Location = New System.Drawing.Point(1, 2)
        Me.RECT_PRSEARCH.Name = "RECT_PRSEARCH"
        Me.RECT_PRSEARCH.Size = New System.Drawing.Size(649, 33)
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.TBLM4_INV_ITEMS_PCOU_SETUPTableAdapter = Nothing
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
        Me.TableAdapterManager.TBLM4_INVENTORY_PACK_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_PACKTableAdapter = Nothing
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
        'SPM4_SIGNATORY_LISTTableAdapter
        '
        Me.SPM4_SIGNATORY_LISTTableAdapter.ClearBeforeFill = True
        '
        'SIGDATEEMPIDDataGridViewTextBoxColumn
        '
        Me.SIGDATEEMPIDDataGridViewTextBoxColumn.DataPropertyName = "SIG_DATE_EMP_ID"
        Me.SIGDATEEMPIDDataGridViewTextBoxColumn.HeaderText = "Emp No."
        Me.SIGDATEEMPIDDataGridViewTextBoxColumn.Name = "SIGDATEEMPIDDataGridViewTextBoxColumn"
        Me.SIGDATEEMPIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SIGDATEEMPIDDataGridViewTextBoxColumn.Visible = False
        '
        'FULLNAMEDataGridViewTextBoxColumn
        '
        Me.FULLNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "FULLNAME"
        Me.FULLNAMEDataGridViewTextBoxColumn.HeaderText = "Fullname"
        Me.FULLNAMEDataGridViewTextBoxColumn.Name = "FULLNAMEDataGridViewTextBoxColumn"
        Me.FULLNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'POSPOSITIONDataGridViewTextBoxColumn
        '
        Me.POSPOSITIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.POSPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POS_POSITION"
        Me.POSPOSITIONDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.POSPOSITIONDataGridViewTextBoxColumn.Name = "POSPOSITIONDataGridViewTextBoxColumn"
        Me.POSPOSITIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMPLNAMEDataGridViewTextBoxColumn
        '
        Me.EMPLNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMP_LNAME"
        Me.EMPLNAMEDataGridViewTextBoxColumn.HeaderText = "EMP_LNAME"
        Me.EMPLNAMEDataGridViewTextBoxColumn.Name = "EMPLNAMEDataGridViewTextBoxColumn"
        Me.EMPLNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.EMPLNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'EMPFNAMEDataGridViewTextBoxColumn
        '
        Me.EMPFNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMP_FNAME"
        Me.EMPFNAMEDataGridViewTextBoxColumn.HeaderText = "EMP_FNAME"
        Me.EMPFNAMEDataGridViewTextBoxColumn.Name = "EMPFNAMEDataGridViewTextBoxColumn"
        Me.EMPFNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.EMPFNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'EMPMNAMEDataGridViewTextBoxColumn
        '
        Me.EMPMNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMP_MNAME"
        Me.EMPMNAMEDataGridViewTextBoxColumn.HeaderText = "EMP_MNAME"
        Me.EMPMNAMEDataGridViewTextBoxColumn.Name = "EMPMNAMEDataGridViewTextBoxColumn"
        Me.EMPMNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.EMPMNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'POSNODataGridViewTextBoxColumn
        '
        Me.POSNODataGridViewTextBoxColumn.DataPropertyName = "POS_NO"
        Me.POSNODataGridViewTextBoxColumn.HeaderText = "POS_NO"
        Me.POSNODataGridViewTextBoxColumn.Name = "POSNODataGridViewTextBoxColumn"
        Me.POSNODataGridViewTextBoxColumn.ReadOnly = True
        Me.POSNODataGridViewTextBoxColumn.Visible = False
        '
        'PDSTITLEDataGridViewTextBoxColumn
        '
        Me.PDSTITLEDataGridViewTextBoxColumn.DataPropertyName = "PDS_TITLE"
        Me.PDSTITLEDataGridViewTextBoxColumn.HeaderText = "PDS_TITLE"
        Me.PDSTITLEDataGridViewTextBoxColumn.Name = "PDSTITLEDataGridViewTextBoxColumn"
        Me.PDSTITLEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PDSTITLEDataGridViewTextBoxColumn.Visible = False
        '
        'SIGSTATUSDataGridViewTextBoxColumn
        '
        Me.SIGSTATUSDataGridViewTextBoxColumn.DataPropertyName = "SIG_STATUS"
        Me.SIGSTATUSDataGridViewTextBoxColumn.HeaderText = "SIG_STATUS"
        Me.SIGSTATUSDataGridViewTextBoxColumn.Name = "SIGSTATUSDataGridViewTextBoxColumn"
        Me.SIGSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.SIGSTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'DATEENCODEDataGridViewTextBoxColumn
        '
        Me.DATEENCODEDataGridViewTextBoxColumn.DataPropertyName = "DATEENCODE"
        Me.DATEENCODEDataGridViewTextBoxColumn.HeaderText = "DATEENCODE"
        Me.DATEENCODEDataGridViewTextBoxColumn.Name = "DATEENCODEDataGridViewTextBoxColumn"
        Me.DATEENCODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.DATEENCODEDataGridViewTextBoxColumn.Visible = False
        '
        'FRM_SIGNATORYLIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 626)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.GB_PRLIST)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_SIGNATORYLIST"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_SIGNATORYLIST"
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.GB_PRLIST.ResumeLayout(False)
        Me.GB_PRLIST.PerformLayout()
        CType(Me.VWG3_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_SIGNATORY_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PBICONSEARCH As PictureBox
    '  Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DSPROPERTYDB_TABLESTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents Label39 As Label
    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents WTXT_SEARCHSIGNATORY As WatermarkTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GB_PRLIST As GroupBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRSEARCH As PowerPacks.RectangleShape
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents VWG3_PRIMARY_SIGNATORYDataGridView As DataGridView
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SPM4_SIGNATORY_LISTBindingSource As BindingSource
    Friend WithEvents SPM4_SIGNATORY_LISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_SIGNATORY_LISTTableAdapter
    Friend WithEvents SIGDATEEMPIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FULLNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POSPOSITIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPLNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPFNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMPMNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents POSNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PDSTITLEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SIGSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATEENCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
