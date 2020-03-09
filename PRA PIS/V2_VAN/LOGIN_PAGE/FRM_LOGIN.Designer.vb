<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_LOGIN
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBLG3_PRIMARY_SIGNATORYDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPROPERTYDB_TABLES = New PRA_PIS.DS_PROPERTYDB()
        Me.BTNCLOSE = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNLOGIN = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TXT_PASSWORD = New PRA_PIS.WatermarkTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TXT_USERNAME = New PRA_PIS.WatermarkTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.TblV1_USERACCOUNTTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_USERACCOUNTTableAdapter()
        Me.TblV1_USERACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblV1_USERACCOUNTLOGSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblV1_USERACCOUNTLOGSTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_USERACCOUNTLOGSTableAdapter()
        Me.TblV1_HRISEMPLOYEEDATATableAdapter1 = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter()
        Me.TblV1_HRISDIVISIONTableAdapter1 = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter()
        Me.TblV1_HRISDEPARTMENTTableAdapter1 = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.TBLG3_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPROPERTYDB_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_USERACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_USERACCOUNTLOGSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TBLG3_PRIMARY_SIGNATORYDataGridView)
        Me.Panel1.Controls.Add(Me.BTNCLOSE)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BTNLOGIN)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(4, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 266)
        Me.Panel1.TabIndex = 1
        '
        'TBLG3_PRIMARY_SIGNATORYDataGridView
        '
        Me.TBLG3_PRIMARY_SIGNATORYDataGridView.AutoGenerateColumns = False
        Me.TBLG3_PRIMARY_SIGNATORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBLG3_PRIMARY_SIGNATORYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TBLG3_PRIMARY_SIGNATORYDataGridView.DataSource = Me.TBLG3_PRIMARY_SIGNATORYBindingSource
        Me.TBLG3_PRIMARY_SIGNATORYDataGridView.Location = New System.Drawing.Point(587, 195)
        Me.TBLG3_PRIMARY_SIGNATORYDataGridView.Name = "TBLG3_PRIMARY_SIGNATORYDataGridView"
        Me.TBLG3_PRIMARY_SIGNATORYDataGridView.Size = New System.Drawing.Size(197, 62)
        Me.TBLG3_PRIMARY_SIGNATORYDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SIG_TY_NO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SIG_TY_NO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "HRIS_EMPNO_USER"
        Me.DataGridViewTextBoxColumn2.HeaderText = "HRIS_EMPNO_USER"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HRIS_EMPNO_SIG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "HRIS_EMPNO_SIG"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'TBLG3_PRIMARY_SIGNATORYBindingSource
        '
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource.DataMember = "TBLG3_PRIMARY_SIGNATORY"
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource.DataSource = Me.DSPROPERTYDB_TABLES
        '
        'DSPROPERTYDB_TABLES
        '
        Me.DSPROPERTYDB_TABLES.DataSetName = "DSPROPERTYDB_TABLES"
        Me.DSPROPERTYDB_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTNCLOSE
        '
        Me.BTNCLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCLOSE.BackColor = System.Drawing.SystemColors.GrayText
        Me.BTNCLOSE.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCLOSE.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLOSE.ForeColor = System.Drawing.Color.White
        Me.BTNCLOSE.Location = New System.Drawing.Point(207, 156)
        Me.BTNCLOSE.Name = "BTNCLOSE"
        Me.BTNCLOSE.Size = New System.Drawing.Size(98, 33)
        Me.BTNCLOSE.TabIndex = 50
        Me.BTNCLOSE.Text = "CLOSE"
        Me.BTNCLOSE.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(45, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Login"
        '
        'BTNLOGIN
        '
        Me.BTNLOGIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNLOGIN.BackColor = System.Drawing.SystemColors.GrayText
        Me.BTNLOGIN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNLOGIN.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGIN.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.Location = New System.Drawing.Point(66, 156)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.Size = New System.Drawing.Size(98, 33)
        Me.BTNLOGIN.TabIndex = 48
        Me.BTNLOGIN.Text = "LOGIN"
        Me.BTNLOGIN.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TXT_PASSWORD)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(44, 107)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(283, 30)
        Me.Panel5.TabIndex = 6
        '
        'TXT_PASSWORD
        '
        Me.TXT_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PASSWORD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_PASSWORD.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.TXT_PASSWORD.Location = New System.Drawing.Point(5, 0)
        Me.TXT_PASSWORD.Name = "TXT_PASSWORD"
        Me.TXT_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PASSWORD.Size = New System.Drawing.Size(245, 28)
        Me.TXT_PASSWORD.TabIndex = 52
        Me.TXT_PASSWORD.Watermark = Nothing
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Location = New System.Drawing.Point(250, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 28)
        Me.Panel6.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TXT_USERNAME)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(44, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 30)
        Me.Panel2.TabIndex = 3
        '
        'TXT_USERNAME
        '
        Me.TXT_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_USERNAME.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_USERNAME.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.TXT_USERNAME.Location = New System.Drawing.Point(5, 0)
        Me.TXT_USERNAME.Name = "TXT_USERNAME"
        Me.TXT_USERNAME.Size = New System.Drawing.Size(245, 28)
        Me.TXT_USERNAME.TabIndex = 51
        Me.TXT_USERNAME.Watermark = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(250, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 28)
        Me.Panel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(125, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "WELCOME"
        '
        'DS_TABLES
        '
        Me.DS_TABLES.DataSetName = "DS_TABLES"
        Me.DS_TABLES.EnforceConstraints = False
        Me.DS_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblV1_USERACCOUNTTableAdapter
        '
        Me.TblV1_USERACCOUNTTableAdapter.ClearBeforeFill = True
        '
        'TblV1_USERACCOUNTBindingSource
        '
        Me.TblV1_USERACCOUNTBindingSource.DataMember = "tblV1_USERACCOUNT"
        Me.TblV1_USERACCOUNTBindingSource.DataSource = Me.DS_TABLES
        '
        'TblV1_USERACCOUNTLOGSBindingSource
        '
        Me.TblV1_USERACCOUNTLOGSBindingSource.DataMember = "tblV1_USERACCOUNTLOGS"
        Me.TblV1_USERACCOUNTLOGSBindingSource.DataSource = Me.DS_TABLES
        '
        'TblV1_USERACCOUNTLOGSTableAdapter
        '
        Me.TblV1_USERACCOUNTLOGSTableAdapter.ClearBeforeFill = True
        '
        'TblV1_HRISEMPLOYEEDATATableAdapter1
        '
        Me.TblV1_HRISEMPLOYEEDATATableAdapter1.ClearBeforeFill = True
        '
        'TblV1_HRISDIVISIONTableAdapter1
        '
        Me.TblV1_HRISDIVISIONTableAdapter1.ClearBeforeFill = True
        '
        'TblV1_HRISDEPARTMENTTableAdapter1
        '
        Me.TblV1_HRISDEPARTMENTTableAdapter1.ClearBeforeFill = True
        '
        'FRM_LOGIN
        '
        Me.AcceptButton = Me.BTNLOGIN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.BTNCLOSE
        Me.ClientSize = New System.Drawing.Size(400, 317)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TBLG3_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPROPERTYDB_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_USERACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_USERACCOUNTLOGSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNLOGIN As Button
    Friend WithEvents BTNCLOSE As Button
    Friend WithEvents TblV1_USERACCOUNTBindingSource As BindingSource
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TblV1_USERACCOUNTTableAdapter As DS_TABLESTableAdapters.tblV1_USERACCOUNTTableAdapter
    Friend WithEvents TXT_PASSWORD As WatermarkTextBox
    Friend WithEvents TXT_USERNAME As WatermarkTextBox
    Friend WithEvents tmrClockTimer As Timer
    Friend WithEvents TblV1_USERACCOUNTLOGSBindingSource As BindingSource
    Friend WithEvents TblV1_USERACCOUNTLOGSTableAdapter As DS_TABLESTableAdapters.tblV1_USERACCOUNTLOGSTableAdapter
    Friend WithEvents TblV1_HRISEMPLOYEEDATATableAdapter1 As DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter
    Friend WithEvents TblV1_HRISDIVISIONTableAdapter1 As DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter
    Friend WithEvents TblV1_HRISDEPARTMENTTableAdapter1 As DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter
    Friend WithEvents DSPROPERTYDB_TABLES As DS_PROPERTYDB
    Friend WithEvents TBLG3_PRIMARY_SIGNATORYBindingSource As BindingSource

    Friend WithEvents TBLG3_PRIMARY_SIGNATORYDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
