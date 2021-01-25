<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_PDS_LIST
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
        Me.DGV_EMP_LIST = New System.Windows.Forms.DataGridView()
        Me.SPM4EMPLSIGNLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PBICONSEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_SEARCHSIGNATORY = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRSEARCH = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.SPM4_EMPL_SIGN_LISTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_EMPL_SIGN_LISTTableAdapter()
        Me.EMPNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_PRLIST.SuspendLayout()
        CType(Me.DGV_EMP_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4EMPLSIGNLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_PRLIST
        '
        Me.GB_PRLIST.BackColor = System.Drawing.SystemColors.Window
        Me.GB_PRLIST.Controls.Add(Me.DGV_EMP_LIST)
        Me.GB_PRLIST.Controls.Add(Me.Label6)
        Me.GB_PRLIST.Controls.Add(Me.PBICONSEARCH)
        Me.GB_PRLIST.Controls.Add(Me.WTXT_SEARCHSIGNATORY)
        Me.GB_PRLIST.Controls.Add(Me.ShapeContainer2)
        Me.GB_PRLIST.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GB_PRLIST.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_PRLIST.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GB_PRLIST.Location = New System.Drawing.Point(2, 43)
        Me.GB_PRLIST.Name = "GB_PRLIST"
        Me.GB_PRLIST.Size = New System.Drawing.Size(663, 573)
        Me.GB_PRLIST.TabIndex = 1407
        Me.GB_PRLIST.TabStop = False
        '
        'DGV_EMP_LIST
        '
        Me.DGV_EMP_LIST.AllowUserToAddRows = False
        Me.DGV_EMP_LIST.AllowUserToDeleteRows = False
        Me.DGV_EMP_LIST.AllowUserToResizeRows = False
        Me.DGV_EMP_LIST.AutoGenerateColumns = False
        Me.DGV_EMP_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_EMP_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_EMP_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_EMP_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPNODataGridViewTextBoxColumn, Me.FULLNAME, Me.POSITION})
        Me.DGV_EMP_LIST.DataSource = Me.SPM4EMPLSIGNLISTBindingSource
        Me.DGV_EMP_LIST.Location = New System.Drawing.Point(6, 61)
        Me.DGV_EMP_LIST.Name = "DGV_EMP_LIST"
        Me.DGV_EMP_LIST.ReadOnly = True
        Me.DGV_EMP_LIST.RowHeadersVisible = False
        Me.DGV_EMP_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_EMP_LIST.Size = New System.Drawing.Size(650, 504)
        Me.DGV_EMP_LIST.TabIndex = 1407
        '
        'SPM4EMPLSIGNLISTBindingSource
        '
        Me.SPM4EMPLSIGNLISTBindingSource.DataMember = "SPM4_EMPL_SIGN_LIST"
        Me.SPM4EMPLSIGNLISTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.PBICONSEARCH.Location = New System.Drawing.Point(611, 26)
        Me.PBICONSEARCH.Name = "PBICONSEARCH"
        Me.PBICONSEARCH.Size = New System.Drawing.Size(32, 24)
        Me.PBICONSEARCH.TabIndex = 1408
        Me.PBICONSEARCH.TabStop = False
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
        Me.ShapeContainer2.Size = New System.Drawing.Size(657, 551)
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
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(635, 6)
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
        Me.PNL.Size = New System.Drawing.Size(669, 42)
        Me.PNL.TabIndex = 1408
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(10, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(200, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "E M P L O Y E E   L I S T"
        '
        'SPM4_EMPL_SIGN_LISTTableAdapter
        '
        Me.SPM4_EMPL_SIGN_LISTTableAdapter.ClearBeforeFill = True
        '
        'EMPNODataGridViewTextBoxColumn
        '
        Me.EMPNODataGridViewTextBoxColumn.DataPropertyName = "EMP_NO"
        Me.EMPNODataGridViewTextBoxColumn.HeaderText = "Emp No."
        Me.EMPNODataGridViewTextBoxColumn.Name = "EMPNODataGridViewTextBoxColumn"
        Me.EMPNODataGridViewTextBoxColumn.ReadOnly = True
        Me.EMPNODataGridViewTextBoxColumn.Visible = False
        '
        'FULLNAME
        '
        Me.FULLNAME.DataPropertyName = "FULLNAME"
        Me.FULLNAME.HeaderText = "Fullname"
        Me.FULLNAME.Name = "FULLNAME"
        Me.FULLNAME.ReadOnly = True
        '
        'POSITION
        '
        Me.POSITION.DataPropertyName = "POSITION"
        Me.POSITION.HeaderText = "Position"
        Me.POSITION.Name = "POSITION"
        Me.POSITION.ReadOnly = True
        '
        'FRM_PDS_LIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 621)
        Me.Controls.Add(Me.GB_PRLIST)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_PDS_LIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_PDS_LIST"
        Me.GB_PRLIST.ResumeLayout(False)
        Me.GB_PRLIST.PerformLayout()
        CType(Me.DGV_EMP_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4EMPLSIGNLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WTXT_SEARCHSIGNATORY As WatermarkTextBox
    Friend WithEvents GB_PRLIST As GroupBox
    Friend WithEvents DGV_EMP_LIST As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents PBICONSEARCH As PictureBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRSEARCH As PowerPacks.RectangleShape
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents SPM4EMPLSIGNLISTBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SPM4_EMPL_SIGN_LISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_EMPL_SIGN_LISTTableAdapter
    Friend WithEvents EMPNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FULLNAME As DataGridViewTextBoxColumn
    Friend WithEvents POSITION As DataGridViewTextBoxColumn
End Class
