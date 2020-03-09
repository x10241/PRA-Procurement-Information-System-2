<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PRREVISION
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
        Me.PNL = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_SAVE = New System.Windows.Forms.Button()
        Me.DGV_CLOSE = New System.Windows.Forms.Button()
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.TblM4PURCHASEREQUESTITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter()
        Me.PNL.SuspendLayout()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4PURCHASEREQUESTITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(687, 40)
        Me.PNL.TabIndex = 1409
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(9, 11)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(150, 18)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "F O R  R E V I S I O N"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3818, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3771, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_SAVE.Location = New System.Drawing.Point(487, 478)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(92, 32)
        Me.BTN_SAVE.TabIndex = 1413
        Me.BTN_SAVE.Text = "SAVE"
        Me.BTN_SAVE.UseVisualStyleBackColor = True
        '
        'DGV_CLOSE
        '
        Me.DGV_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.DGV_CLOSE.FlatAppearance.BorderSize = 5
        Me.DGV_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.DGV_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DGV_CLOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.DGV_CLOSE.Location = New System.Drawing.Point(585, 478)
        Me.DGV_CLOSE.Name = "DGV_CLOSE"
        Me.DGV_CLOSE.Size = New System.Drawing.Size(90, 32)
        Me.DGV_CLOSE.TabIndex = 1414
        Me.DGV_CLOSE.Text = "CLOSE"
        Me.DGV_CLOSE.UseVisualStyleBackColor = True
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblM4PURCHASEREQUESTITEMBindingSource
        '
        Me.TblM4PURCHASEREQUESTITEMBindingSource.DataMember = "tblM4_PURCHASEREQUEST_ITEM"
        Me.TblM4PURCHASEREQUESTITEMBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_PURCHASEREQUEST_ITEMTableAdapter
        '
        Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter.ClearBeforeFill = True
        '
        'FRM_PRREVISION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 522)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.DGV_CLOSE)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRM_PRREVISION"
        Me.Text = "FRM_PRREVISION"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4PURCHASEREQUESTITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents DGV_CLOSE As Button
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TblM4PURCHASEREQUESTITEMBindingSource As BindingSource
    Friend WithEvents TblM4_PURCHASEREQUEST_ITEMTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter
End Class
