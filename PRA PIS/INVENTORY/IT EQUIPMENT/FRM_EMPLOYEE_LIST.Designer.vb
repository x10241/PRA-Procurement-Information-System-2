<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_EMPLOYEE_LIST
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_EMPLOYEE_LIST))
        Me.GB_PRLIST = New System.Windows.Forms.GroupBox()
        Me.EmployeeInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.EMPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDPTDEPARTMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDIVDIVISIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTPDSLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PRAJO_DATABASE = New PRA_PIS.DS_PRAJO_DATABASE()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PBICONSEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_SEARCHEMPLOYEE = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New PRA_PIS.DS_TABLESTableAdapters.TableAdapterManager()
        Me.DT_PDS_LISTTableAdapter = New PRA_PIS.DS_PRAJO_DATABASETableAdapters.DT_PDS_LISTTableAdapter()
        Me.GB_PRLIST.SuspendLayout()
        CType(Me.EmployeeInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTPDSLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PRAJO_DATABASE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_PRLIST
        '
        Me.GB_PRLIST.BackColor = System.Drawing.SystemColors.Window
        Me.GB_PRLIST.Controls.Add(Me.EmployeeInfoDataGridView)
        Me.GB_PRLIST.Controls.Add(Me.PictureBox2)
        Me.GB_PRLIST.Controls.Add(Me.Label6)
        Me.GB_PRLIST.Controls.Add(Me.PBICONSEARCH)
        Me.GB_PRLIST.Controls.Add(Me.WTXT_SEARCHEMPLOYEE)
        Me.GB_PRLIST.Controls.Add(Me.ShapeContainer1)
        Me.GB_PRLIST.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GB_PRLIST.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_PRLIST.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GB_PRLIST.Location = New System.Drawing.Point(4, 40)
        Me.GB_PRLIST.Name = "GB_PRLIST"
        Me.GB_PRLIST.Size = New System.Drawing.Size(662, 583)
        Me.GB_PRLIST.TabIndex = 1407
        Me.GB_PRLIST.TabStop = False
        '
        'EmployeeInfoDataGridView
        '
        Me.EmployeeInfoDataGridView.AllowUserToAddRows = False
        Me.EmployeeInfoDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeInfoDataGridView.AllowUserToResizeColumns = False
        Me.EmployeeInfoDataGridView.AllowUserToResizeRows = False
        Me.EmployeeInfoDataGridView.AutoGenerateColumns = False
        Me.EmployeeInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeeInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPIDDataGridViewTextBoxColumn, Me.FULLNAMEDataGridViewTextBoxColumn, Me.HDPTDEPARTMENTDataGridViewTextBoxColumn, Me.HDIVDIVISIONDataGridViewTextBoxColumn})
        Me.EmployeeInfoDataGridView.DataSource = Me.DTPDSLISTBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeeInfoDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeeInfoDataGridView.Location = New System.Drawing.Point(11, 64)
        Me.EmployeeInfoDataGridView.Name = "EmployeeInfoDataGridView"
        Me.EmployeeInfoDataGridView.ReadOnly = True
        Me.EmployeeInfoDataGridView.RowHeadersVisible = False
        Me.EmployeeInfoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeInfoDataGridView.Size = New System.Drawing.Size(637, 513)
        Me.EmployeeInfoDataGridView.TabIndex = 0
        '
        'EMPIDDataGridViewTextBoxColumn
        '
        Me.EMPIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMP_ID"
        Me.EMPIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE ID"
        Me.EMPIDDataGridViewTextBoxColumn.Name = "EMPIDDataGridViewTextBoxColumn"
        Me.EMPIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EMPIDDataGridViewTextBoxColumn.Width = 120
        '
        'FULLNAMEDataGridViewTextBoxColumn
        '
        Me.FULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "FULLNAME"
        Me.FULLNAMEDataGridViewTextBoxColumn.HeaderText = "FULLNAME"
        Me.FULLNAMEDataGridViewTextBoxColumn.Name = "FULLNAMEDataGridViewTextBoxColumn"
        Me.FULLNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HDPTDEPARTMENTDataGridViewTextBoxColumn
        '
        Me.HDPTDEPARTMENTDataGridViewTextBoxColumn.DataPropertyName = "HDPT_DEPARTMENT"
        Me.HDPTDEPARTMENTDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT"
        Me.HDPTDEPARTMENTDataGridViewTextBoxColumn.Name = "HDPTDEPARTMENTDataGridViewTextBoxColumn"
        Me.HDPTDEPARTMENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HDIVDIVISIONDataGridViewTextBoxColumn
        '
        Me.HDIVDIVISIONDataGridViewTextBoxColumn.DataPropertyName = "HDIV_DIVISION"
        Me.HDIVDIVISIONDataGridViewTextBoxColumn.HeaderText = "DIVISION"
        Me.HDIVDIVISIONDataGridViewTextBoxColumn.Name = "HDIVDIVISIONDataGridViewTextBoxColumn"
        Me.HDIVDIVISIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DTPDSLISTBindingSource
        '
        Me.DTPDSLISTBindingSource.DataMember = "DT_PDS_LIST"
        Me.DTPDSLISTBindingSource.DataSource = Me.DS_PRAJO_DATABASE
        '
        'DS_PRAJO_DATABASE
        '
        Me.DS_PRAJO_DATABASE.DataSetName = "DS_PRAJO_DATABASE"
        Me.DS_PRAJO_DATABASE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(616, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox2.TabIndex = 1483
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
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
        Me.PBICONSEARCH.Location = New System.Drawing.Point(16, 27)
        Me.PBICONSEARCH.Name = "PBICONSEARCH"
        Me.PBICONSEARCH.Size = New System.Drawing.Size(32, 24)
        Me.PBICONSEARCH.TabIndex = 1408
        Me.PBICONSEARCH.TabStop = False
        '
        'WTXT_SEARCHEMPLOYEE
        '
        Me.WTXT_SEARCHEMPLOYEE.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SEARCHEMPLOYEE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCHEMPLOYEE.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCHEMPLOYEE.ForeColor = System.Drawing.Color.Black
        Me.WTXT_SEARCHEMPLOYEE.Location = New System.Drawing.Point(52, 26)
        Me.WTXT_SEARCHEMPLOYEE.Name = "WTXT_SEARCHEMPLOYEE"
        Me.WTXT_SEARCHEMPLOYEE.Size = New System.Drawing.Size(559, 26)
        Me.WTXT_SEARCHEMPLOYEE.TabIndex = 0
        Me.WTXT_SEARCHEMPLOYEE.Watermark = "Search Name"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.AutoScroll = True
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRCANCELEDIT})
        Me.ShapeContainer1.Size = New System.Drawing.Size(656, 561)
        Me.ShapeContainer1.TabIndex = 1412
        Me.ShapeContainer1.TabStop = False
        '
        'RECT_PRCANCELEDIT
        '
        Me.RECT_PRCANCELEDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRCANCELEDIT.CornerRadius = 5
        Me.RECT_PRCANCELEDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRCANCELEDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRCANCELEDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(7, 3)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(640, 33)
        '
        'DS_TABLES
        '
        Me.DS_TABLES.DataSetName = "DS_TABLES"
        Me.DS_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label39.Size = New System.Drawing.Size(195, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "E M P L O Y E E  L I S T"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tblV1_DEFPRADEPARTMENTSTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_DEFPRADIVISIONTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_HRISDEPARTMENTTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_HRISDIVISIONTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_HRISEMPLOYEEDATATableAdapter = Nothing
        Me.TableAdapterManager.tblV1_USERACCOUNTLOGSTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_USERACCOUNTTableAdapter = Nothing
        Me.TableAdapterManager.tblV2_ACCOUNTCODETableAdapter = Nothing
        Me.TableAdapterManager.tblV2_UsersAccountTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_TABLESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DT_PDS_LISTTableAdapter
        '
        Me.DT_PDS_LISTTableAdapter.ClearBeforeFill = True
        '
        'FRM_EMPLOYEE_LIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(667, 626)
        Me.Controls.Add(Me.GB_PRLIST)
        Me.Controls.Add(Me.PNL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_EMPLOYEE_LIST"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_EMPLOYEE_LIST"
        Me.GB_PRLIST.ResumeLayout(False)
        Me.GB_PRLIST.PerformLayout()
        CType(Me.EmployeeInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTPDSLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PRAJO_DATABASE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_PRLIST As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PBICONSEARCH As PictureBox
    Friend WithEvents WTXT_SEARCHEMPLOYEE As WatermarkTextBox
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TableAdapterManager As DS_TABLESTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeInfoDataGridView As DataGridView
    Friend WithEvents DS_PRAJO_DATABASE As DS_PRAJO_DATABASE
    Friend WithEvents DTPDSLISTBindingSource As BindingSource
    Friend WithEvents DT_PDS_LISTTableAdapter As DS_PRAJO_DATABASETableAdapters.DT_PDS_LISTTableAdapter
    Friend WithEvents EMPIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FULLNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HDPTDEPARTMENTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HDIVDIVISIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
