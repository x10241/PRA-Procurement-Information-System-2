<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_EDITPR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GB_PRLIST = New System.Windows.Forms.GroupBox()
        Me.DGV_EDIT_PR_LIST = New System.Windows.Forms.DataGridView()
        Me.TblM4PURCHASEREQUESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PBICONSEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_SEARCHPR = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRSEARCH = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TblM4_PURCHASEREQUESTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter()
        Me.PRPRNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDATEREQUESTEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRAPPCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRPURPOSEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRREQUESTEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRAPPROVEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRCERTIFIEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRNOTEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRNOTEDBYPOSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRSUBMITTEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDEPARTMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRDIVISIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREATEDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRUPDATEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRISDOLLARDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIG_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_PRLIST.SuspendLayout()
        CType(Me.DGV_EDIT_PR_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_PRLIST
        '
        Me.GB_PRLIST.BackColor = System.Drawing.SystemColors.Window
        Me.GB_PRLIST.Controls.Add(Me.DGV_EDIT_PR_LIST)
        Me.GB_PRLIST.Controls.Add(Me.Label6)
        Me.GB_PRLIST.Controls.Add(Me.PBICONSEARCH)
        Me.GB_PRLIST.Controls.Add(Me.WTXT_SEARCHPR)
        Me.GB_PRLIST.Controls.Add(Me.ShapeContainer2)
        Me.GB_PRLIST.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GB_PRLIST.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_PRLIST.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GB_PRLIST.Location = New System.Drawing.Point(3, 46)
        Me.GB_PRLIST.Name = "GB_PRLIST"
        Me.GB_PRLIST.Size = New System.Drawing.Size(662, 583)
        Me.GB_PRLIST.TabIndex = 1407
        Me.GB_PRLIST.TabStop = False
        '
        'DGV_EDIT_PR_LIST
        '
        Me.DGV_EDIT_PR_LIST.AllowUserToAddRows = False
        Me.DGV_EDIT_PR_LIST.AllowUserToDeleteRows = False
        Me.DGV_EDIT_PR_LIST.AllowUserToResizeColumns = False
        Me.DGV_EDIT_PR_LIST.AllowUserToResizeRows = False
        Me.DGV_EDIT_PR_LIST.AutoGenerateColumns = False
        Me.DGV_EDIT_PR_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_EDIT_PR_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_EDIT_PR_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRPRNODataGridViewTextBoxColumn, Me.PRDATEREQUESTEDDataGridViewTextBoxColumn, Me.PRAPPCODEDataGridViewTextBoxColumn, Me.PRPURPOSEDataGridViewTextBoxColumn, Me.PRSTATUSDataGridViewTextBoxColumn, Me.PRREQUESTEDBYDataGridViewTextBoxColumn, Me.PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn, Me.PRAPPROVEDBYDataGridViewTextBoxColumn, Me.PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn, Me.PRCERTIFIEDBYDataGridViewTextBoxColumn, Me.PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn, Me.PRNOTEDBYDataGridViewTextBoxColumn, Me.PRNOTEDBYPOSITIONDataGridViewTextBoxColumn, Me.PRSUBMITTEDBYDataGridViewTextBoxColumn, Me.PRDEPARTMENTDataGridViewTextBoxColumn, Me.PRDIVISIONDataGridViewTextBoxColumn, Me.CREATEDDATEDataGridViewTextBoxColumn, Me.PRUPDATEDBYDataGridViewTextBoxColumn, Me.PRISDOLLARDataGridViewCheckBoxColumn, Me.SIG_NO})
        Me.DGV_EDIT_PR_LIST.DataSource = Me.TblM4PURCHASEREQUESTBindingSource
        Me.DGV_EDIT_PR_LIST.Location = New System.Drawing.Point(9, 66)
        Me.DGV_EDIT_PR_LIST.Name = "DGV_EDIT_PR_LIST"
        Me.DGV_EDIT_PR_LIST.ReadOnly = True
        Me.DGV_EDIT_PR_LIST.RowHeadersVisible = False
        Me.DGV_EDIT_PR_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_EDIT_PR_LIST.Size = New System.Drawing.Size(642, 504)
        Me.DGV_EDIT_PR_LIST.TabIndex = 1407
        '
        'TblM4PURCHASEREQUESTBindingSource
        '
        Me.TblM4PURCHASEREQUESTBindingSource.DataMember = "tblM4_PURCHASEREQUEST"
        Me.TblM4PURCHASEREQUESTBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PBICONSEARCH
        '
        Me.PBICONSEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PBICONSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBICONSEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBICONSEARCH.InitialImage = Nothing
        Me.PBICONSEARCH.Location = New System.Drawing.Point(611, 25)
        Me.PBICONSEARCH.Name = "PBICONSEARCH"
        Me.PBICONSEARCH.Size = New System.Drawing.Size(32, 24)
        Me.PBICONSEARCH.TabIndex = 1408
        Me.PBICONSEARCH.TabStop = False
        '
        'WTXT_SEARCHPR
        '
        Me.WTXT_SEARCHPR.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SEARCHPR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCHPR.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCHPR.ForeColor = System.Drawing.Color.Black
        Me.WTXT_SEARCHPR.Location = New System.Drawing.Point(16, 25)
        Me.WTXT_SEARCHPR.Name = "WTXT_SEARCHPR"
        Me.WTXT_SEARCHPR.Size = New System.Drawing.Size(595, 26)
        Me.WTXT_SEARCHPR.TabIndex = 0
        Me.WTXT_SEARCHPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SEARCHPR.Watermark = "Search Purpose or PR No."
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRSEARCH})
        Me.ShapeContainer2.Size = New System.Drawing.Size(656, 561)
        Me.ShapeContainer2.TabIndex = 5
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_PRSEARCH
        '
        Me.RECT_PRSEARCH.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSEARCH.BorderWidth = 2
        Me.RECT_PRSEARCH.CornerRadius = 15
        Me.RECT_PRSEARCH.Location = New System.Drawing.Point(1, 2)
        Me.RECT_PRSEARCH.Name = "RECT_PRSEARCH"
        Me.RECT_PRSEARCH.Size = New System.Drawing.Size(644, 33)
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
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(667, 42)
        Me.PNL.TabIndex = 1408
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(10, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(98, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "E D I T  P R"
        '
        'TblM4_PURCHASEREQUESTTableAdapter
        '
        Me.TblM4_PURCHASEREQUESTTableAdapter.ClearBeforeFill = True
        '
        'PRPRNODataGridViewTextBoxColumn
        '
        Me.PRPRNODataGridViewTextBoxColumn.DataPropertyName = "PR_PRNO"
        Me.PRPRNODataGridViewTextBoxColumn.HeaderText = "PR No."
        Me.PRPRNODataGridViewTextBoxColumn.Name = "PRPRNODataGridViewTextBoxColumn"
        Me.PRPRNODataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRDATEREQUESTEDDataGridViewTextBoxColumn
        '
        Me.PRDATEREQUESTEDDataGridViewTextBoxColumn.DataPropertyName = "PR_DATEREQUESTED"
        Me.PRDATEREQUESTEDDataGridViewTextBoxColumn.HeaderText = "PR_DATEREQUESTED"
        Me.PRDATEREQUESTEDDataGridViewTextBoxColumn.Name = "PRDATEREQUESTEDDataGridViewTextBoxColumn"
        Me.PRDATEREQUESTEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRDATEREQUESTEDDataGridViewTextBoxColumn.Visible = False
        '
        'PRAPPCODEDataGridViewTextBoxColumn
        '
        Me.PRAPPCODEDataGridViewTextBoxColumn.DataPropertyName = "PR_APPCODE"
        Me.PRAPPCODEDataGridViewTextBoxColumn.HeaderText = "PR_APPCODE"
        Me.PRAPPCODEDataGridViewTextBoxColumn.Name = "PRAPPCODEDataGridViewTextBoxColumn"
        Me.PRAPPCODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRAPPCODEDataGridViewTextBoxColumn.Visible = False
        '
        'PRPURPOSEDataGridViewTextBoxColumn
        '
        Me.PRPURPOSEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRPURPOSEDataGridViewTextBoxColumn.DataPropertyName = "PR_PURPOSE"
        Me.PRPURPOSEDataGridViewTextBoxColumn.HeaderText = "Purpose"
        Me.PRPURPOSEDataGridViewTextBoxColumn.Name = "PRPURPOSEDataGridViewTextBoxColumn"
        Me.PRPURPOSEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRPURPOSEDataGridViewTextBoxColumn.Width = 450
        '
        'PRSTATUSDataGridViewTextBoxColumn
        '
        Me.PRSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PR_STATUS"
        Me.PRSTATUSDataGridViewTextBoxColumn.HeaderText = "PR_STATUS"
        Me.PRSTATUSDataGridViewTextBoxColumn.Name = "PRSTATUSDataGridViewTextBoxColumn"
        Me.PRSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRSTATUSDataGridViewTextBoxColumn.Visible = False
        '
        'PRREQUESTEDBYDataGridViewTextBoxColumn
        '
        Me.PRREQUESTEDBYDataGridViewTextBoxColumn.DataPropertyName = "PR_REQUESTEDBY"
        Me.PRREQUESTEDBYDataGridViewTextBoxColumn.HeaderText = "PR_REQUESTEDBY"
        Me.PRREQUESTEDBYDataGridViewTextBoxColumn.Name = "PRREQUESTEDBYDataGridViewTextBoxColumn"
        Me.PRREQUESTEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRREQUESTEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn
        '
        Me.PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "PR_REQUESTEDBYPOSITION"
        Me.PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn.HeaderText = "PR_REQUESTEDBYPOSITION"
        Me.PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn.Name = "PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn"
        Me.PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn.Visible = False
        '
        'PRAPPROVEDBYDataGridViewTextBoxColumn
        '
        Me.PRAPPROVEDBYDataGridViewTextBoxColumn.DataPropertyName = "PR_APPROVEDBY"
        Me.PRAPPROVEDBYDataGridViewTextBoxColumn.HeaderText = "PR_APPROVEDBY"
        Me.PRAPPROVEDBYDataGridViewTextBoxColumn.Name = "PRAPPROVEDBYDataGridViewTextBoxColumn"
        Me.PRAPPROVEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRAPPROVEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn
        '
        Me.PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "PR_APPROVEDBYPOSITION"
        Me.PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn.HeaderText = "PR_APPROVEDBYPOSITION"
        Me.PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn.Name = "PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn"
        Me.PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn.Visible = False
        '
        'PRCERTIFIEDBYDataGridViewTextBoxColumn
        '
        Me.PRCERTIFIEDBYDataGridViewTextBoxColumn.DataPropertyName = "PR_CERTIFIEDBY"
        Me.PRCERTIFIEDBYDataGridViewTextBoxColumn.HeaderText = "PR_CERTIFIEDBY"
        Me.PRCERTIFIEDBYDataGridViewTextBoxColumn.Name = "PRCERTIFIEDBYDataGridViewTextBoxColumn"
        Me.PRCERTIFIEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRCERTIFIEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn
        '
        Me.PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "PR_CERTIFIEDBYPOSITION"
        Me.PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn.HeaderText = "PR_CERTIFIEDBYPOSITION"
        Me.PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn.Name = "PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn"
        Me.PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn.Visible = False
        '
        'PRNOTEDBYDataGridViewTextBoxColumn
        '
        Me.PRNOTEDBYDataGridViewTextBoxColumn.DataPropertyName = "PR_NOTEDBY"
        Me.PRNOTEDBYDataGridViewTextBoxColumn.HeaderText = "PR_NOTEDBY"
        Me.PRNOTEDBYDataGridViewTextBoxColumn.Name = "PRNOTEDBYDataGridViewTextBoxColumn"
        Me.PRNOTEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRNOTEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'PRNOTEDBYPOSITIONDataGridViewTextBoxColumn
        '
        Me.PRNOTEDBYPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "PR_NOTEDBYPOSITION"
        Me.PRNOTEDBYPOSITIONDataGridViewTextBoxColumn.HeaderText = "PR_NOTEDBYPOSITION"
        Me.PRNOTEDBYPOSITIONDataGridViewTextBoxColumn.Name = "PRNOTEDBYPOSITIONDataGridViewTextBoxColumn"
        Me.PRNOTEDBYPOSITIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRNOTEDBYPOSITIONDataGridViewTextBoxColumn.Visible = False
        '
        'PRSUBMITTEDBYDataGridViewTextBoxColumn
        '
        Me.PRSUBMITTEDBYDataGridViewTextBoxColumn.DataPropertyName = "PR_SUBMITTEDBY"
        Me.PRSUBMITTEDBYDataGridViewTextBoxColumn.HeaderText = "PR_SUBMITTEDBY"
        Me.PRSUBMITTEDBYDataGridViewTextBoxColumn.Name = "PRSUBMITTEDBYDataGridViewTextBoxColumn"
        Me.PRSUBMITTEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRSUBMITTEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'PRDEPARTMENTDataGridViewTextBoxColumn
        '
        Me.PRDEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "PR_DEPARTMENT"
        Me.PRDEPARTMENTDataGridViewTextBoxColumn.HeaderText = "PR_DEPARTMENT"
        Me.PRDEPARTMENTDataGridViewTextBoxColumn.Name = "PRDEPARTMENTDataGridViewTextBoxColumn"
        Me.PRDEPARTMENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRDEPARTMENTDataGridViewTextBoxColumn.Visible = False
        '
        'PRDIVISIONDataGridViewTextBoxColumn
        '
        Me.PRDIVISIONDataGridViewTextBoxColumn.DataPropertyName = "PR_DIVISION"
        Me.PRDIVISIONDataGridViewTextBoxColumn.HeaderText = "PR_DIVISION"
        Me.PRDIVISIONDataGridViewTextBoxColumn.Name = "PRDIVISIONDataGridViewTextBoxColumn"
        Me.PRDIVISIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRDIVISIONDataGridViewTextBoxColumn.Visible = False
        '
        'CREATEDDATEDataGridViewTextBoxColumn
        '
        Me.CREATEDDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATED_DATE"
        Me.CREATEDDATEDataGridViewTextBoxColumn.HeaderText = "CREATED_DATE"
        Me.CREATEDDATEDataGridViewTextBoxColumn.Name = "CREATEDDATEDataGridViewTextBoxColumn"
        Me.CREATEDDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CREATEDDATEDataGridViewTextBoxColumn.Visible = False
        '
        'PRUPDATEDBYDataGridViewTextBoxColumn
        '
        Me.PRUPDATEDBYDataGridViewTextBoxColumn.DataPropertyName = "PR_UPDATEDBY"
        Me.PRUPDATEDBYDataGridViewTextBoxColumn.HeaderText = "PR_UPDATEDBY"
        Me.PRUPDATEDBYDataGridViewTextBoxColumn.Name = "PRUPDATEDBYDataGridViewTextBoxColumn"
        Me.PRUPDATEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRUPDATEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'PRISDOLLARDataGridViewCheckBoxColumn
        '
        Me.PRISDOLLARDataGridViewCheckBoxColumn.DataPropertyName = "PR_ISDOLLAR"
        Me.PRISDOLLARDataGridViewCheckBoxColumn.HeaderText = "PR_ISDOLLAR"
        Me.PRISDOLLARDataGridViewCheckBoxColumn.Name = "PRISDOLLARDataGridViewCheckBoxColumn"
        Me.PRISDOLLARDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PRISDOLLARDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRISDOLLARDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PRISDOLLARDataGridViewCheckBoxColumn.Visible = False
        '
        'SIG_NO
        '
        Me.SIG_NO.DataPropertyName = "SIG_NO"
        Me.SIG_NO.HeaderText = "SIG_NO"
        Me.SIG_NO.Name = "SIG_NO"
        Me.SIG_NO.ReadOnly = True
        Me.SIG_NO.Visible = False
        '
        'FRM_EDITPR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 626)
        Me.Controls.Add(Me.GB_PRLIST)
        Me.Controls.Add(Me.PNL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_EDITPR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GB_PRLIST.ResumeLayout(False)
        Me.GB_PRLIST.PerformLayout()
        CType(Me.DGV_EDIT_PR_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_PRLIST As GroupBox
    Friend WithEvents DGV_EDIT_PR_LIST As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents PBICONSEARCH As PictureBox
    Friend WithEvents WTXT_SEARCHPR As WatermarkTextBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRSEARCH As PowerPacks.RectangleShape
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TblM4PURCHASEREQUESTBindingSource As BindingSource
    Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents PRPRNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRDATEREQUESTEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRAPPCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRPURPOSEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRREQUESTEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRREQUESTEDBYPOSITIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRAPPROVEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRAPPROVEDBYPOSITIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRCERTIFIEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRCERTIFIEDBYPOSITIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRNOTEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRNOTEDBYPOSITIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRSUBMITTEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRDEPARTMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRDIVISIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CREATEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRUPDATEDBYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRISDOLLARDataGridViewCheckBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SIG_NO As DataGridViewTextBoxColumn
End Class
