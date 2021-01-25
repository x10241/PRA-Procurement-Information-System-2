<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PMD_PREVIEW
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
        Me.CRV_PREVIEW = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SpM4_CURRENTDATETIMETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SpM4_ITEMS_IN_LOCATIONTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEMS_IN_LOCATIONTableAdapter()
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.StickerPreviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_PRINTSTICKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_PRINTSTICKERTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_PRINTSTICKERTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager()
        Me.SPM4_ASSIGN_ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ASSIGN_ITEMSTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ASSIGN_ITEMSTableAdapter()
        Me.SPM4_PRINTSTICKERDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StickerPreviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PRINTSTICKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ASSIGN_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PRINTSTICKERDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRV_PREVIEW
        '
        Me.CRV_PREVIEW.ActiveViewIndex = -1
        Me.CRV_PREVIEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_PREVIEW.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_PREVIEW.DisplayStatusBar = False
        Me.CRV_PREVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_PREVIEW.Location = New System.Drawing.Point(0, 0)
        Me.CRV_PREVIEW.Name = "CRV_PREVIEW"
        Me.CRV_PREVIEW.ShowCloseButton = False
        Me.CRV_PREVIEW.ShowExportButton = False
        Me.CRV_PREVIEW.ShowGroupTreeButton = False
        Me.CRV_PREVIEW.ShowLogo = False
        Me.CRV_PREVIEW.ShowParameterPanelButton = False
        Me.CRV_PREVIEW.ShowRefreshButton = False
        Me.CRV_PREVIEW.Size = New System.Drawing.Size(383, 532)
        Me.CRV_PREVIEW.TabIndex = 0
        Me.CRV_PREVIEW.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'SpM4_CURRENTDATETIMETableAdapter
        '
        Me.SpM4_CURRENTDATETIMETableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1443, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'SpM4_ITEMS_IN_LOCATIONTableAdapter
        '
        Me.SpM4_ITEMS_IN_LOCATIONTableAdapter.ClearBeforeFill = True
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StickerPreviewBindingSource
        '
        Me.StickerPreviewBindingSource.DataMember = "StickerPreview"
        Me.StickerPreviewBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_PRINTSTICKERBindingSource
        '
        Me.SPM4_PRINTSTICKERBindingSource.DataMember = "SPM4_PRINTSTICKER"
        Me.SPM4_PRINTSTICKERBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_PRINTSTICKERTableAdapter
        '
        Me.SPM4_PRINTSTICKERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.A_CLOSEPROGRAMTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SPM4_ASSIGN_ITEMSBindingSource
        '
        Me.SPM4_ASSIGN_ITEMSBindingSource.DataMember = "SPM4_ASSIGN_ITEMS"
        Me.SPM4_ASSIGN_ITEMSBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_ASSIGN_ITEMSTableAdapter
        '
        Me.SPM4_ASSIGN_ITEMSTableAdapter.ClearBeforeFill = True
        '
        'SPM4_PRINTSTICKERDataGridView
        '
        Me.SPM4_PRINTSTICKERDataGridView.AutoGenerateColumns = False
        Me.SPM4_PRINTSTICKERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SPM4_PRINTSTICKERDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewImageColumn1})
        Me.SPM4_PRINTSTICKERDataGridView.DataSource = Me.SPM4_PRINTSTICKERBindingSource
        Me.SPM4_PRINTSTICKERDataGridView.Location = New System.Drawing.Point(5871, 100)
        Me.SPM4_PRINTSTICKERDataGridView.Name = "SPM4_PRINTSTICKERDataGridView"
        Me.SPM4_PRINTSTICKERDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.SPM4_PRINTSTICKERDataGridView.TabIndex = 2
        Me.SPM4_PRINTSTICKERDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CAT NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CAT NAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SUB CATEGORY"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SUB CATEGORY"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BRAND NAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BRAND NAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ITEM CODE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ITEM CODE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SERIAL NO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SERIAL NO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ITEM DESCRIPTION"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ITEM DESCRIPTION"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TOTAL COST"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TOTAL COST"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Date of Acquisition"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Date of Acquisition"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Date Encode"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date Encode"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fullname"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fullname"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "DIVISION"
        Me.DataGridViewTextBoxColumn11.HeaderText = "DIVISION"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "img"
        Me.DataGridViewImageColumn1.HeaderText = "img"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'FRM_PREVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 532)
        Me.Controls.Add(Me.SPM4_PRINTSTICKERDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CRV_PREVIEW)
        Me.Name = "FRM_PREVIEW"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StickerPreviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PRINTSTICKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ASSIGN_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PRINTSTICKERDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRV_PREVIEW As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SpM4_ITEMS_IN_LOCATIONTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEMS_IN_LOCATIONTableAdapter
    Friend WithEvents SpM4_CURRENTDATETIMETableAdapter As DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents StickerPreviewBindingSource As BindingSource
    Friend WithEvents SPM4_PRINTSTICKERBindingSource As BindingSource
    Friend WithEvents SPM4_PRINTSTICKERTableAdapter As DS_STOREDPROCTableAdapters.SPM4_PRINTSTICKERTableAdapter
    Friend WithEvents TableAdapterManager As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents SPM4_ASSIGN_ITEMSBindingSource As BindingSource
    Friend WithEvents SPM4_ASSIGN_ITEMSTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ASSIGN_ITEMSTableAdapter
    Friend WithEvents SPM4_PRINTSTICKERDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class
