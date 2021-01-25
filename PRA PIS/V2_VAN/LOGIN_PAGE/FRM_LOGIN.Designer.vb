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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LOGIN))
        Me.BTNCLOSE = New System.Windows.Forms.Button()
        Me.BTNLOGIN = New System.Windows.Forms.Button()
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.TblV1_USERACCOUNTTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_USERACCOUNTTableAdapter()
        Me.TblV1_USERACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tmrClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TblV1_USERACCOUNTLOGSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblV1_USERACCOUNTLOGSTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_USERACCOUNTLOGSTableAdapter()
        Me.RECT_MAINRECT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.PNL_MAINPANEL = New System.Windows.Forms.Panel()
        Me.LBL_VERSION = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBL_PASSCLEAR = New System.Windows.Forms.Label()
        Me.TXT_PASSWORD = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LBL_USERCLEAR = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TXT_USERNAME = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape22 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.V1VW_USERACCEMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V1VW_USERACCEMPLOYEETableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.V1VW_USERACCEMPLOYEETableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PRAJO_DATABASETableAdapters.TableAdapterManager()
        Me.SPM4_PDS_LISTTableAdapter = New PRA_PIS.DS_PRAJO_DATABASETableAdapters.SPM4_PDS_LISTTableAdapter()
        Me.SPM4_PDS_LISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_USERACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_USERACCOUNTLOGSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_MAINPANEL.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V1VW_USERACCEMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PDS_LISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNCLOSE
        '
        Me.BTNCLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCLOSE.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BTNCLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.PADLOCK
        Me.BTNCLOSE.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCLOSE.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BTNCLOSE.FlatAppearance.BorderSize = 2
        Me.BTNCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCLOSE.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLOSE.ForeColor = System.Drawing.Color.White
        Me.BTNCLOSE.Location = New System.Drawing.Point(431, 350)
        Me.BTNCLOSE.Name = "BTNCLOSE"
        Me.BTNCLOSE.Size = New System.Drawing.Size(230, 46)
        Me.BTNCLOSE.TabIndex = 50
        Me.BTNCLOSE.Text = "EXIT"
        Me.BTNCLOSE.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTNCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNCLOSE.UseVisualStyleBackColor = False
        '
        'BTNLOGIN
        '
        Me.BTNLOGIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNLOGIN.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BTNLOGIN.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.PADLOCK
        Me.BTNLOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNLOGIN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNLOGIN.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BTNLOGIN.FlatAppearance.BorderSize = 2
        Me.BTNLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLOGIN.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGIN.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.Location = New System.Drawing.Point(116, 350)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.Size = New System.Drawing.Size(230, 46)
        Me.BTNLOGIN.TabIndex = 48
        Me.BTNLOGIN.Text = "LOGIN"
        Me.BTNLOGIN.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTNLOGIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNLOGIN.UseVisualStyleBackColor = False
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
        'RECT_MAINRECT
        '
        Me.RECT_MAINRECT.BorderColor = System.Drawing.Color.Gainsboro
        Me.RECT_MAINRECT.BorderWidth = 3
        Me.RECT_MAINRECT.CornerRadius = 8
        Me.RECT_MAINRECT.FillColor = System.Drawing.Color.White
        Me.RECT_MAINRECT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_MAINRECT.Location = New System.Drawing.Point(8, 74)
        Me.RECT_MAINRECT.Name = "RECT_MAINRECT"
        Me.RECT_MAINRECT.Size = New System.Drawing.Size(788, 433)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_MAINRECT})
        Me.ShapeContainer1.Size = New System.Drawing.Size(803, 513)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'PNL_MAINPANEL
        '
        Me.PNL_MAINPANEL.BackColor = System.Drawing.Color.White
        Me.PNL_MAINPANEL.Controls.Add(Me.LBL_VERSION)
        Me.PNL_MAINPANEL.Controls.Add(Me.BTNCLOSE)
        Me.PNL_MAINPANEL.Controls.Add(Me.BTNLOGIN)
        Me.PNL_MAINPANEL.Controls.Add(Me.Label1)
        Me.PNL_MAINPANEL.Controls.Add(Me.Label6)
        Me.PNL_MAINPANEL.Controls.Add(Me.Label3)
        Me.PNL_MAINPANEL.Controls.Add(Me.Panel7)
        Me.PNL_MAINPANEL.Controls.Add(Me.Panel4)
        Me.PNL_MAINPANEL.Controls.Add(Me.ShapeContainer2)
        Me.PNL_MAINPANEL.Location = New System.Drawing.Point(14, 78)
        Me.PNL_MAINPANEL.Name = "PNL_MAINPANEL"
        Me.PNL_MAINPANEL.Size = New System.Drawing.Size(776, 426)
        Me.PNL_MAINPANEL.TabIndex = 3
        '
        'LBL_VERSION
        '
        Me.LBL_VERSION.AutoSize = True
        Me.LBL_VERSION.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_VERSION.Location = New System.Drawing.Point(693, 407)
        Me.LBL_VERSION.Name = "LBL_VERSION"
        Me.LBL_VERSION.Size = New System.Drawing.Size(80, 15)
        Me.LBL_VERSION.TabIndex = 1450
        Me.LBL_VERSION.Text = "VERSION (1.6)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 30)
        Me.Label1.TabIndex = 1448
        Me.Label1.Text = "PRA Login"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(287, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 33)
        Me.Label6.TabIndex = 1444
        Me.Label6.Text = "Welcome User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(535, 42)
        Me.Label3.TabIndex = 1443
        Me.Label3.Text = "Philippine Retirement Authority"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.LBL_PASSCLEAR)
        Me.Panel7.Controls.Add(Me.TXT_PASSWORD)
        Me.Panel7.Controls.Add(Me.ShapeContainer4)
        Me.Panel7.Location = New System.Drawing.Point(116, 276)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(545, 48)
        Me.Panel7.TabIndex = 1442
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Image = Global.PRA_PIS.My.Resources.Resources.round_vpn_key_black_18dp
        Me.Label7.Location = New System.Drawing.Point(17, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 36)
        Me.Label7.TabIndex = 1445
        Me.Label7.Text = "   "
        '
        'LBL_PASSCLEAR
        '
        Me.LBL_PASSCLEAR.AutoSize = True
        Me.LBL_PASSCLEAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBL_PASSCLEAR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PASSCLEAR.ForeColor = System.Drawing.Color.DimGray
        Me.LBL_PASSCLEAR.Location = New System.Drawing.Point(507, 14)
        Me.LBL_PASSCLEAR.Name = "LBL_PASSCLEAR"
        Me.LBL_PASSCLEAR.Size = New System.Drawing.Size(32, 21)
        Me.LBL_PASSCLEAR.TabIndex = 1446
        Me.LBL_PASSCLEAR.Text = "❌"
        Me.LBL_PASSCLEAR.Visible = False
        '
        'TXT_PASSWORD
        '
        Me.TXT_PASSWORD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_PASSWORD.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PASSWORD.ForeColor = System.Drawing.Color.DimGray
        Me.TXT_PASSWORD.Location = New System.Drawing.Point(62, 10)
        Me.TXT_PASSWORD.Name = "TXT_PASSWORD"
        Me.TXT_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PASSWORD.Size = New System.Drawing.Size(437, 30)
        Me.TXT_PASSWORD.TabIndex = 1438
        Me.TXT_PASSWORD.Watermark = "Password"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer4.Size = New System.Drawing.Size(545, 48)
        Me.ShapeContainer4.TabIndex = 0
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape2.Location = New System.Drawing.Point(6, 3)
        Me.RectangleShape2.Name = "RectangleShape22"
        Me.RectangleShape2.Size = New System.Drawing.Size(536, 42)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LBL_USERCLEAR)
        Me.Panel4.Controls.Add(Me.Label55)
        Me.Panel4.Controls.Add(Me.TXT_USERNAME)
        Me.Panel4.Controls.Add(Me.ShapeContainer3)
        Me.Panel4.Location = New System.Drawing.Point(116, 216)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(545, 48)
        Me.Panel4.TabIndex = 1441
        '
        'LBL_USERCLEAR
        '
        Me.LBL_USERCLEAR.AutoSize = True
        Me.LBL_USERCLEAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBL_USERCLEAR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_USERCLEAR.ForeColor = System.Drawing.Color.DimGray
        Me.LBL_USERCLEAR.Location = New System.Drawing.Point(507, 13)
        Me.LBL_USERCLEAR.Name = "LBL_USERCLEAR"
        Me.LBL_USERCLEAR.Size = New System.Drawing.Size(32, 21)
        Me.LBL_USERCLEAR.TabIndex = 1447
        Me.LBL_USERCLEAR.Text = "❌"
        Me.LBL_USERCLEAR.Visible = False
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label55.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.DimGray
        Me.Label55.Image = CType(resources.GetObject("Label55.Image"), System.Drawing.Image)
        Me.Label55.Location = New System.Drawing.Point(17, 7)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(39, 36)
        Me.Label55.TabIndex = 1440
        Me.Label55.Text = "   "
        '
        'TXT_USERNAME
        '
        Me.TXT_USERNAME.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_USERNAME.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USERNAME.ForeColor = System.Drawing.Color.DimGray
        Me.TXT_USERNAME.Location = New System.Drawing.Point(62, 10)
        Me.TXT_USERNAME.Name = "TXT_USERNAME"
        Me.TXT_USERNAME.Size = New System.Drawing.Size(437, 30)
        Me.TXT_USERNAME.TabIndex = 1438
        Me.TXT_USERNAME.Watermark = "Username"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape22})
        Me.ShapeContainer3.Size = New System.Drawing.Size(545, 48)
        Me.ShapeContainer3.TabIndex = 0
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape22
        '
        Me.RectangleShape22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape22.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape22.BorderWidth = 2
        Me.RectangleShape22.CornerRadius = 5
        Me.RectangleShape22.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape22.Location = New System.Drawing.Point(6, 3)
        Me.RectangleShape22.Name = "RectangleShape22"
        Me.RectangleShape22.Size = New System.Drawing.Size(534, 42)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(776, 426)
        Me.ShapeContainer2.TabIndex = 1405
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 2
        Me.RectangleShape1.FillColor = System.Drawing.Color.Silver
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.LightSlateGray
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(56, 149)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.HotPink
        Me.RectangleShape1.Size = New System.Drawing.Size(665, 12)
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.PRA_LOGO_WHITE_HALF_BG
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(352, 24)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox5.TabIndex = 1446
        Me.PictureBox5.TabStop = False
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V1VW_USERACCEMPLOYEEBindingSource
        '
        Me.V1VW_USERACCEMPLOYEEBindingSource.DataMember = "V1VW_USERACCEMPLOYEE"
        Me.V1VW_USERACCEMPLOYEEBindingSource.DataSource = Me.DS_VIEWS
        '
        'V1VW_USERACCEMPLOYEETableAdapter
        '
        Me.V1VW_USERACCEMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_PRAJO_DATABASETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SPM4_PDS_LISTTableAdapter
        '
        Me.SPM4_PDS_LISTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_PDS_LISTBindingSource
        '
        Me.SPM4_PDS_LISTBindingSource.DataMember = "SPM4_PDS_LIST"
        '
        'FRM_LOGIN
        '
        Me.AcceptButton = Me.BTNLOGIN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.BTNCLOSE
        Me.ClientSize = New System.Drawing.Size(803, 513)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PNL_MAINPANEL)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_USERACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_USERACCOUNTLOGSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_MAINPANEL.ResumeLayout(False)
        Me.PNL_MAINPANEL.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V1VW_USERACCEMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PDS_LISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNLOGIN As Button
    Friend WithEvents BTNCLOSE As Button
    Friend WithEvents TblV1_USERACCOUNTBindingSource As BindingSource
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TblV1_USERACCOUNTTableAdapter As DS_TABLESTableAdapters.tblV1_USERACCOUNTTableAdapter
    Friend WithEvents tmrClockTimer As Timer
    Friend WithEvents TblV1_USERACCOUNTLOGSBindingSource As BindingSource
    Friend WithEvents TblV1_USERACCOUNTLOGSTableAdapter As DS_TABLESTableAdapters.tblV1_USERACCOUNTLOGSTableAdapter
    Friend WithEvents RECT_MAINRECT As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents PNL_MAINPANEL As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label55 As Label
    Friend WithEvents TXT_USERNAME As WatermarkTextBox
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape22 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TXT_PASSWORD As WatermarkTextBox
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_PASSCLEAR As Label
    Friend WithEvents LBL_USERCLEAR As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents V1VW_USERACCEMPLOYEEBindingSource As BindingSource
    Friend WithEvents V1VW_USERACCEMPLOYEETableAdapter As DS_VIEWSTableAdapters.V1VW_USERACCEMPLOYEETableAdapter
    Friend WithEvents TableAdapterManager As DS_PRAJO_DATABASETableAdapters.TableAdapterManager
    Friend WithEvents SPM4_PDS_LISTTableAdapter As DS_PRAJO_DATABASETableAdapters.SPM4_PDS_LISTTableAdapter
    Friend WithEvents SPM4_PDS_LISTBindingSource As BindingSource
    Friend WithEvents LBL_VERSION As Label
End Class
