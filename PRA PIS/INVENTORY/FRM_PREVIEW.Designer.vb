<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PREVIEW
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StickerPreviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PRINTSTICKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ASSIGN_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.CRV_PREVIEW.Size = New System.Drawing.Size(1563, 512)
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
        'FRM_PREVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1563, 512)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CRV_PREVIEW)
        Me.Name = "FRM_PREVIEW"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StickerPreviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PRINTSTICKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ASSIGN_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
