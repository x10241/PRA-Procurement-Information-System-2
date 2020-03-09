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
        Me.CRV_PURCHASEREQUESTPREVIEW = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.PR_PARTICULARS_PREVIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_GETPR_INFOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_GETPR_INFOTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_GETPR_INFOTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.PBOX_QRCODE = New System.Windows.Forms.PictureBox()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PR_PARTICULARS_PREVIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_GETPR_INFOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOX_QRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRV_PURCHASEREQUESTPREVIEW
        '
        Me.CRV_PURCHASEREQUESTPREVIEW.ActiveViewIndex = -1
        Me.CRV_PURCHASEREQUESTPREVIEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_PURCHASEREQUESTPREVIEW.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_PURCHASEREQUESTPREVIEW.DisplayStatusBar = False
        Me.CRV_PURCHASEREQUESTPREVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_PURCHASEREQUESTPREVIEW.Location = New System.Drawing.Point(0, 0)
        Me.CRV_PURCHASEREQUESTPREVIEW.Name = "CRV_PURCHASEREQUESTPREVIEW"
        Me.CRV_PURCHASEREQUESTPREVIEW.ShowCloseButton = False
        Me.CRV_PURCHASEREQUESTPREVIEW.ShowCopyButton = False
        Me.CRV_PURCHASEREQUESTPREVIEW.ShowExportButton = False
        Me.CRV_PURCHASEREQUESTPREVIEW.ShowGotoPageButton = False
        Me.CRV_PURCHASEREQUESTPREVIEW.ShowGroupTreeButton = False
        Me.CRV_PURCHASEREQUESTPREVIEW.ShowLogo = False
        Me.CRV_PURCHASEREQUESTPREVIEW.ShowParameterPanelButton = False
        Me.CRV_PURCHASEREQUESTPREVIEW.ShowRefreshButton = False
        Me.CRV_PURCHASEREQUESTPREVIEW.ShowTextSearchButton = False
        Me.CRV_PURCHASEREQUESTPREVIEW.Size = New System.Drawing.Size(402, 507)
        Me.CRV_PURCHASEREQUESTPREVIEW.TabIndex = 0
        Me.CRV_PURCHASEREQUESTPREVIEW.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
        '  Me.TableAdapterManager.tblM4_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_ITEMBRAND1TableAdapter = Nothing
        '  Me.TableAdapterManager.tblM4_ITEMBRANDTableAdapter = Nothing
        'Me.TableAdapterManager.tblM4_ITEMS_LOCATIONTableAdapter = Nothing
        'Me.TableAdapterManager.tblM4_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUESTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PBOX_QRCODE
        '
        Me.PBOX_QRCODE.Location = New System.Drawing.Point(301, 213)
        Me.PBOX_QRCODE.Name = "PBOX_QRCODE"
        Me.PBOX_QRCODE.Size = New System.Drawing.Size(100, 50)
        Me.PBOX_QRCODE.TabIndex = 1
        Me.PBOX_QRCODE.TabStop = False
        Me.PBOX_QRCODE.Visible = False
        '
        'FRM_PURCHASE_REQUEST_PRINTPREVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 507)
        Me.Controls.Add(Me.PBOX_QRCODE)
        Me.Controls.Add(Me.CRV_PURCHASEREQUESTPREVIEW)
        Me.Name = "FRM_PURCHASE_REQUEST_PRINTPREVIEW"
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PR_PARTICULARS_PREVIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_GETPR_INFOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOX_QRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV_PURCHASEREQUESTPREVIEW As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents PR_PARTICULARS_PREVIEWBindingSource As BindingSource
    Friend WithEvents SPM4_GETPR_INFOBindingSource As BindingSource
    Friend WithEvents SPM4_GETPR_INFOTableAdapter As DS_PROPERTYDBTableAdapters.SPM4_GETPR_INFOTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents PBOX_QRCODE As PictureBox
End Class
