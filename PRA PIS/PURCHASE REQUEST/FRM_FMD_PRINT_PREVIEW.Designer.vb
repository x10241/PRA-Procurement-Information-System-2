<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_FMD_PRINT_PREVIEW
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
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.BTN_GENERATE_REPORT = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_INVENTORY_REPORT_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_INVENTORY_REPORT_MINIMIZE = New System.Windows.Forms.Button()
        Me.PBX_QRCODE = New System.Windows.Forms.PictureBox()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.TableAdapterManager = New PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager()
        Me.DS_CUSTOM = New PRA_PIS.DS_CUSTOM()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CRV_PREVIEW = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.PBX_QRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_GENERATE_REPORT
        '
        Me.BTN_GENERATE_REPORT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_GENERATE_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_GENERATE_REPORT.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTN_GENERATE_REPORT.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GENERATE_REPORT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_GENERATE_REPORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GENERATE_REPORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GENERATE_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GENERATE_REPORT.Image = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.BTN_GENERATE_REPORT.Location = New System.Drawing.Point(0, 241)
        Me.BTN_GENERATE_REPORT.Name = "BTN_GENERATE_REPORT"
        Me.BTN_GENERATE_REPORT.Size = New System.Drawing.Size(466, 43)
        Me.BTN_GENERATE_REPORT.TabIndex = 1465
        Me.BTN_GENERATE_REPORT.Text = "PRINT REPORT"
        Me.BTN_GENERATE_REPORT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_GENERATE_REPORT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_GENERATE_REPORT.UseVisualStyleBackColor = False
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4573, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4620, 11)
        Me.BTN_Minimize.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_Minimize.Name = "BTN_Minimize"
        Me.BTN_Minimize.Size = New System.Drawing.Size(47, 45)
        Me.BTN_Minimize.TabIndex = 7
        Me.BTN_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Minimize.UseVisualStyleBackColor = False
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
        'BTN_INVENTORY_REPORT_CLOSE
        '
        Me.BTN_INVENTORY_REPORT_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_INVENTORY_REPORT_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INVENTORY_REPORT_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_REPORT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_REPORT_CLOSE.Location = New System.Drawing.Point(423, 7)
        Me.BTN_INVENTORY_REPORT_CLOSE.Name = "BTN_INVENTORY_REPORT_CLOSE"
        Me.BTN_INVENTORY_REPORT_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INVENTORY_REPORT_CLOSE.TabIndex = 10
        Me.BTN_INVENTORY_REPORT_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_REPORT_CLOSE.UseVisualStyleBackColor = True
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
        Me.BTN_INVENTORY_REPORT_MINIMIZE.Location = New System.Drawing.Point(389, 9)
        Me.BTN_INVENTORY_REPORT_MINIMIZE.Name = "BTN_INVENTORY_REPORT_MINIMIZE"
        Me.BTN_INVENTORY_REPORT_MINIMIZE.Size = New System.Drawing.Size(28, 28)
        Me.BTN_INVENTORY_REPORT_MINIMIZE.TabIndex = 12
        Me.BTN_INVENTORY_REPORT_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_REPORT_MINIMIZE.UseVisualStyleBackColor = False
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
        Me.PNL.Size = New System.Drawing.Size(466, 47)
        Me.PNL.TabIndex = 1464
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.A_CLOSEPROGRAMTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DS_CUSTOM
        '
        Me.DS_CUSTOM.DataSetName = "DS_CUSTOM"
        Me.DS_CUSTOM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.CRV_PREVIEW)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 194)
        Me.Panel1.TabIndex = 1466
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'CRV_PREVIEW
        '
        Me.CRV_PREVIEW.ActiveViewIndex = -1
        Me.CRV_PREVIEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV_PREVIEW.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV_PREVIEW.DisplayBackgroundEdge = False
        Me.CRV_PREVIEW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV_PREVIEW.EnableRefresh = False
        Me.CRV_PREVIEW.Location = New System.Drawing.Point(0, 0)
        Me.CRV_PREVIEW.Name = "CRV_PREVIEW"
        Me.CRV_PREVIEW.ShowCloseButton = False
        Me.CRV_PREVIEW.ShowCopyButton = False
        Me.CRV_PREVIEW.ShowExportButton = False
        Me.CRV_PREVIEW.ShowGroupTreeButton = False
        Me.CRV_PREVIEW.ShowLogo = False
        Me.CRV_PREVIEW.ShowPrintButton = False
        Me.CRV_PREVIEW.ShowRefreshButton = False
        Me.CRV_PREVIEW.ShowTextSearchButton = False
        Me.CRV_PREVIEW.Size = New System.Drawing.Size(466, 194)
        Me.CRV_PREVIEW.TabIndex = 0
        Me.CRV_PREVIEW.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FRM_FMD_PRINT_PREVIEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(466, 284)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.BTN_GENERATE_REPORT)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_FMD_PRINT_PREVIEW"
        Me.Text = "FRM_FMD_PRINT_PREVIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PBX_QRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents BTN_GENERATE_REPORT As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_INVENTORY_REPORT_CLOSE As Button
    Friend WithEvents BTN_INVENTORY_REPORT_MINIMIZE As Button
    Friend WithEvents PBX_QRCODE As PictureBox
    Friend WithEvents PNL As Panel
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents TableAdapterManager As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents DS_CUSTOM As DS_CUSTOM
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CRV_PREVIEW As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
