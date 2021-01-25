<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_DGV_ENCODING
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
        Me.BTN_SAVE = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CB_UNITOFISSUE = New System.Windows.Forms.ComboBox()
        Me.TBLG3UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.TBLG3_UNITSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter()
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.WTXT_DESCRIPTION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_QUANTITY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ESTIMATEDCOST = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ESTIMATEDUNITCOST = New PRA_PIS.WatermarkTextBox()
        Me.TblV1_HRISDEPARTMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV_CLOSE = New System.Windows.Forms.Button()
        Me.TblV1_HRISDEPARTMENTTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_TABLESTableAdapters.TableAdapterManager()
        Me.TblV1_HRISDIVISIONTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TblV1_HRISDIVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.WTXT_STOCKNO = New PRA_PIS.WatermarkTextBox()
        Me.PNL_PARTICULARS = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_DGESTIMATEDUNITCOST = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_DGVQUANTITY = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRPRNO = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_HRISDEPARTMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        Me.PNL_PARTICULARS.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.BTN_SAVE.Location = New System.Drawing.Point(85, 381)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(148, 32)
        Me.BTN_SAVE.TabIndex = 0
        Me.BTN_SAVE.Text = "Add Particulars"
        Me.BTN_SAVE.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PictureBox1.Location = New System.Drawing.Point(210, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1407
        Me.PictureBox1.TabStop = False
        '
        'CB_UNITOFISSUE
        '
        Me.CB_UNITOFISSUE.DataSource = Me.TBLG3UNITSBindingSource
        Me.CB_UNITOFISSUE.DisplayMember = "UN_DESCRIPTION"
        Me.CB_UNITOFISSUE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_UNITOFISSUE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_UNITOFISSUE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_UNITOFISSUE.FormattingEnabled = True
        Me.CB_UNITOFISSUE.Location = New System.Drawing.Point(256, 17)
        Me.CB_UNITOFISSUE.Name = "CB_UNITOFISSUE"
        Me.CB_UNITOFISSUE.Size = New System.Drawing.Size(143, 29)
        Me.CB_UNITOFISSUE.TabIndex = 1
        Me.CB_UNITOFISSUE.ValueMember = "UN_DESCRIPTION"
        '
        'TBLG3UNITSBindingSource
        '
        Me.TBLG3UNITSBindingSource.DataMember = "TBLG3_UNITS"
        Me.TBLG3UNITSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLG3_UNITSTableAdapter
        '
        Me.TBLG3_UNITSTableAdapter.ClearBeforeFill = True
        '
        'DS_TABLES
        '
        Me.DS_TABLES.DataSetName = "DS_TABLES"
        Me.DS_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WTXT_DESCRIPTION
        '
        Me.WTXT_DESCRIPTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DESCRIPTION.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DESCRIPTION.Location = New System.Drawing.Point(20, 69)
        Me.WTXT_DESCRIPTION.Multiline = True
        Me.WTXT_DESCRIPTION.Name = "WTXT_DESCRIPTION"
        Me.WTXT_DESCRIPTION.Size = New System.Drawing.Size(379, 108)
        Me.WTXT_DESCRIPTION.TabIndex = 2
        Me.WTXT_DESCRIPTION.Watermark = Nothing
        '
        'WTXT_QUANTITY
        '
        Me.WTXT_QUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_QUANTITY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_QUANTITY.Location = New System.Drawing.Point(201, 204)
        Me.WTXT_QUANTITY.MaxLength = 10
        Me.WTXT_QUANTITY.Name = "WTXT_QUANTITY"
        Me.WTXT_QUANTITY.Size = New System.Drawing.Size(83, 21)
        Me.WTXT_QUANTITY.TabIndex = 3
        Me.WTXT_QUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_QUANTITY.Watermark = "0"
        '
        'WTXT_ESTIMATEDCOST
        '
        Me.WTXT_ESTIMATEDCOST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ESTIMATEDCOST.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ESTIMATEDCOST.Location = New System.Drawing.Point(199, 270)
        Me.WTXT_ESTIMATEDCOST.MaxLength = 30
        Me.WTXT_ESTIMATEDCOST.Name = "WTXT_ESTIMATEDCOST"
        Me.WTXT_ESTIMATEDCOST.ReadOnly = True
        Me.WTXT_ESTIMATEDCOST.Size = New System.Drawing.Size(197, 21)
        Me.WTXT_ESTIMATEDCOST.TabIndex = 1438
        Me.WTXT_ESTIMATEDCOST.Text = "0.00"
        Me.WTXT_ESTIMATEDCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_ESTIMATEDCOST.Watermark = "0.00"
        '
        'WTXT_ESTIMATEDUNITCOST
        '
        Me.WTXT_ESTIMATEDUNITCOST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ESTIMATEDUNITCOST.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ESTIMATEDUNITCOST.Location = New System.Drawing.Point(199, 237)
        Me.WTXT_ESTIMATEDUNITCOST.MaxLength = 20
        Me.WTXT_ESTIMATEDUNITCOST.Name = "WTXT_ESTIMATEDUNITCOST"
        Me.WTXT_ESTIMATEDUNITCOST.Size = New System.Drawing.Size(197, 21)
        Me.WTXT_ESTIMATEDUNITCOST.TabIndex = 4
        Me.WTXT_ESTIMATEDUNITCOST.Text = "0.00"
        Me.WTXT_ESTIMATEDUNITCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_ESTIMATEDUNITCOST.Watermark = "0.00"
        '
        'TblV1_HRISDEPARTMENTBindingSource
        '
        Me.TblV1_HRISDEPARTMENTBindingSource.DataMember = "tblV1_HRISDEPARTMENT"
        Me.TblV1_HRISDEPARTMENTBindingSource.DataSource = Me.DS_TABLES
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 19)
        Me.Label6.TabIndex = 1436
        Me.Label6.Text = "Estimated Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 19)
        Me.Label4.TabIndex = 1434
        Me.Label4.Text = "Item Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 1433
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 1431
        Me.Label2.Text = "Unit of Issue"
        '
        'DGV_CLOSE
        '
        Me.DGV_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.DGV_CLOSE.FlatAppearance.BorderSize = 5
        Me.DGV_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.DGV_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DGV_CLOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.DGV_CLOSE.Location = New System.Drawing.Point(239, 381)
        Me.DGV_CLOSE.Name = "DGV_CLOSE"
        Me.DGV_CLOSE.Size = New System.Drawing.Size(90, 32)
        Me.DGV_CLOSE.TabIndex = 1
        Me.DGV_CLOSE.Text = "Close"
        Me.DGV_CLOSE.UseVisualStyleBackColor = True
        '
        'TblV1_HRISDEPARTMENTTableAdapter
        '
        Me.TblV1_HRISDEPARTMENTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblV1_DEFPRADEPARTMENTSTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_DEFPRADIVISIONTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_HRISDEPARTMENTTableAdapter = Me.TblV1_HRISDEPARTMENTTableAdapter
        Me.TableAdapterManager.tblV1_HRISDIVISIONTableAdapter = Me.TblV1_HRISDIVISIONTableAdapter
        Me.TableAdapterManager.tblV1_HRISEMPLOYEEDATATableAdapter = Nothing
        Me.TableAdapterManager.tblV1_USERACCOUNTLOGSTableAdapter = Nothing
        Me.TableAdapterManager.tblV1_USERACCOUNTTableAdapter = Nothing
        Me.TableAdapterManager.tblV2_ACCOUNTCODETableAdapter = Nothing
        Me.TableAdapterManager.tblV2_UsersAccountTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_TABLESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblV1_HRISDIVISIONTableAdapter
        '
        Me.TblV1_HRISDIVISIONTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 19)
        Me.Label5.TabIndex = 1435
        Me.Label5.Text = "Estimated Unit Cost"
        '
        'TblV1_HRISDIVISIONBindingSource
        '
        Me.TblV1_HRISDIVISIONBindingSource.DataMember = "tblV1_HRISDIVISION"
        Me.TblV1_HRISDIVISIONBindingSource.DataSource = Me.DS_TABLES
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 1430
        Me.Label1.Text = "Stock No."
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(9, 9)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(184, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "P A R T I C U L A R S "
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-4068, 11)
        Me.BTN_Minimize.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_Minimize.Name = "BTN_Minimize"
        Me.BTN_Minimize.Size = New System.Drawing.Size(47, 45)
        Me.BTN_Minimize.TabIndex = 7
        Me.BTN_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Minimize.UseVisualStyleBackColor = False
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
        Me.PNL.Size = New System.Drawing.Size(437, 50)
        Me.PNL.TabIndex = 1407
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-4021, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'WTXT_STOCKNO
        '
        Me.WTXT_STOCKNO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_STOCKNO.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_STOCKNO.Location = New System.Drawing.Point(20, 19)
        Me.WTXT_STOCKNO.Name = "WTXT_STOCKNO"
        Me.WTXT_STOCKNO.Size = New System.Drawing.Size(184, 21)
        Me.WTXT_STOCKNO.TabIndex = 0
        Me.WTXT_STOCKNO.Watermark = Nothing
        '
        'PNL_PARTICULARS
        '
        Me.PNL_PARTICULARS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_PARTICULARS.Controls.Add(Me.PictureBox1)
        Me.PNL_PARTICULARS.Controls.Add(Me.CB_UNITOFISSUE)
        Me.PNL_PARTICULARS.Controls.Add(Me.WTXT_DESCRIPTION)
        Me.PNL_PARTICULARS.Controls.Add(Me.WTXT_QUANTITY)
        Me.PNL_PARTICULARS.Controls.Add(Me.WTXT_ESTIMATEDCOST)
        Me.PNL_PARTICULARS.Controls.Add(Me.WTXT_ESTIMATEDUNITCOST)
        Me.PNL_PARTICULARS.Controls.Add(Me.Label6)
        Me.PNL_PARTICULARS.Controls.Add(Me.Label5)
        Me.PNL_PARTICULARS.Controls.Add(Me.Label4)
        Me.PNL_PARTICULARS.Controls.Add(Me.Label3)
        Me.PNL_PARTICULARS.Controls.Add(Me.Label2)
        Me.PNL_PARTICULARS.Controls.Add(Me.Label1)
        Me.PNL_PARTICULARS.Controls.Add(Me.WTXT_STOCKNO)
        Me.PNL_PARTICULARS.Controls.Add(Me.ShapeContainer1)
        Me.PNL_PARTICULARS.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.PNL_PARTICULARS.Location = New System.Drawing.Point(10, 56)
        Me.PNL_PARTICULARS.Name = "PNL_PARTICULARS"
        Me.PNL_PARTICULARS.Size = New System.Drawing.Size(418, 319)
        Me.PNL_PARTICULARS.TabIndex = 1406
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RECT_DGESTIMATEDUNITCOST, Me.RectangleShape3, Me.RECT_DGVQUANTITY, Me.RectangleShape1, Me.RECT_PRPRNO})
        Me.ShapeContainer1.Size = New System.Drawing.Size(416, 317)
        Me.ShapeContainer1.TabIndex = 1429
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Location = New System.Drawing.Point(15, 63)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(388, 119)
        '
        'RECT_DGESTIMATEDUNITCOST
        '
        Me.RECT_DGESTIMATEDUNITCOST.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_DGESTIMATEDUNITCOST.CornerRadius = 5
        Me.RECT_DGESTIMATEDUNITCOST.Location = New System.Drawing.Point(195, 233)
        Me.RECT_DGESTIMATEDUNITCOST.Name = "RECT_DGESTIMATEDUNITCOST"
        Me.RECT_DGESTIMATEDUNITCOST.Size = New System.Drawing.Size(205, 27)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(195, 264)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(205, 31)
        '
        'RECT_DGVQUANTITY
        '
        Me.RECT_DGVQUANTITY.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_DGVQUANTITY.CornerRadius = 5
        Me.RECT_DGVQUANTITY.Location = New System.Drawing.Point(196, 198)
        Me.RECT_DGVQUANTITY.Name = "RECT_DGVQUANTITY"
        Me.RECT_DGVQUANTITY.Size = New System.Drawing.Size(89, 31)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(252, 12)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(151, 35)
        '
        'RECT_PRPRNO
        '
        Me.RECT_PRPRNO.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRPRNO.CornerRadius = 5
        Me.RECT_PRPRNO.Location = New System.Drawing.Point(15, 12)
        Me.RECT_PRPRNO.Name = "RECT_PRPRNO"
        Me.RECT_PRPRNO.Size = New System.Drawing.Size(224, 32)
        '
        'FRM_DGV_ENCODING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(437, 425)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.DGV_CLOSE)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.PNL_PARTICULARS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_DGV_ENCODING"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_DGV_ENCODING"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_HRISDEPARTMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.PNL_PARTICULARS.ResumeLayout(False)
        Me.PNL_PARTICULARS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CB_UNITOFISSUE As ComboBox
    Friend WithEvents TBLG3UNITSBindingSource As BindingSource
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TBLG3_UNITSTableAdapter As DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents WTXT_DESCRIPTION As WatermarkTextBox
    Friend WithEvents WTXT_QUANTITY As WatermarkTextBox
    Friend WithEvents WTXT_ESTIMATEDCOST As WatermarkTextBox
    Friend WithEvents WTXT_ESTIMATEDUNITCOST As WatermarkTextBox
    Friend WithEvents TblV1_HRISDEPARTMENTBindingSource As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV_CLOSE As Button
    Friend WithEvents TblV1_HRISDEPARTMENTTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter
    Friend WithEvents TableAdapterManager As DS_TABLESTableAdapters.TableAdapterManager
    Friend WithEvents TblV1_HRISDIVISIONTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents TblV1_HRISDIVISIONBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents WTXT_STOCKNO As WatermarkTextBox
    Friend WithEvents PNL_PARTICULARS As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents RECT_DGESTIMATEDUNITCOST As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RECT_DGVQUANTITY As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRPRNO As PowerPacks.RectangleShape
End Class
