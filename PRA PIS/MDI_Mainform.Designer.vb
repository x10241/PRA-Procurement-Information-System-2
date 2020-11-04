<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDI_Mainform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI_Mainform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBL_EXRATE = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LBLSystemUser = New System.Windows.Forms.Label()
        Me.LBLShowTime = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ABTNEQUIPMENTSTATUS = New System.Windows.Forms.Button()
        Me.APNLSHOWSEL = New System.Windows.Forms.Panel()
        Me.ABTNSEL5 = New System.Windows.Forms.Button()
        Me.ABTNSEL4 = New System.Windows.Forms.Button()
        Me.ABTNSEL3 = New System.Windows.Forms.Button()
        Me.ABTNSEL2 = New System.Windows.Forms.Button()
        Me.ABTNSEL1 = New System.Windows.Forms.Button()
        Me.ABTNLOGOUT = New System.Windows.Forms.Button()
        Me.ABTNMAINPREVENTIVEMAINTENANCE = New System.Windows.Forms.Button()
        Me.ABTNMAININVENTORY = New System.Windows.Forms.Button()
        Me.ABTNMAINREQUEST = New System.Windows.Forms.Button()
        Me.ABTNMAINSUPPLIER = New System.Windows.Forms.Button()
        Me.ABTNMAINHOME = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTNMAIN_NOTIFICATION = New System.Windows.Forms.Button()
        Me.BTNMAINMaximize = New System.Windows.Forms.Button()
        Me.LBL_RIMSHEADER = New System.Windows.Forms.Label()
        Me.PNL_Home = New System.Windows.Forms.Panel()
        Me.ABTNMAINUDITTRAIL = New System.Windows.Forms.Button()
        Me.ABTNSYSTEMADMIN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBLSRRVHEADER = New System.Windows.Forms.Label()
        Me.TTP_MDIMAIN = New System.Windows.Forms.ToolTip(Me.components)
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.TblV1_USERACCOUNTTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_USERACCOUNTTableAdapter()
        Me.TblV1_USERACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblV1_USERACCOUNTLOGSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblV1_USERACCOUNTLOGSTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_USERACCOUNTLOGSTableAdapter()
        Me.TMR_MDIMAIN = New System.Windows.Forms.Timer(Me.components)
        Me.TblV2_FINEXCHANGERATEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.V1VW_USERACCESSMAINBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V1VW_USERACCESSMAINTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.V1VW_USERACCESSMAINTableAdapter()
        Me.V1VW_USERACCESSSUBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V1VW_USERACCESSSUBTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.V1VW_USERACCESSSUBTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.APNLSHOWSEL.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        Me.PNL_Home.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_USERACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_USERACCOUNTLOGSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV2_FINEXCHANGERATEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V1VW_USERACCESSMAINBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V1VW_USERACCESSSUBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LBL_EXRATE)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.LBLSystemUser)
        Me.Panel1.Controls.Add(Me.LBLShowTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 721)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 47)
        Me.Panel1.TabIndex = 0
        '
        'LBL_EXRATE
        '
        Me.LBL_EXRATE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBL_EXRATE.AutoSize = True
        Me.LBL_EXRATE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_EXRATE.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EXRATE.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_EXRATE.Location = New System.Drawing.Point(951, 7)
        Me.LBL_EXRATE.Name = "LBL_EXRATE"
        Me.LBL_EXRATE.Size = New System.Drawing.Size(85, 34)
        Me.LBL_EXRATE.TabIndex = 37
        Me.LBL_EXRATE.Text = "00.0000"
        Me.LBL_EXRATE.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(1029, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 34)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "|"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(676, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 34)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "TODAYS EXCHANGE DOLLAR RATE :"
        Me.Label1.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(1046, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.TabIndex = 34
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'LBLSystemUser
        '
        Me.LBLSystemUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBLSystemUser.AutoSize = True
        Me.LBLSystemUser.BackColor = System.Drawing.Color.Transparent
        Me.LBLSystemUser.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSystemUser.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LBLSystemUser.Location = New System.Drawing.Point(43, 7)
        Me.LBLSystemUser.Name = "LBLSystemUser"
        Me.LBLSystemUser.Size = New System.Drawing.Size(150, 34)
        Me.LBLSystemUser.TabIndex = 32
        Me.LBLSystemUser.Text = "SYSTEM DEFAULT"
        '
        'LBLShowTime
        '
        Me.LBLShowTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLShowTime.AutoSize = True
        Me.LBLShowTime.BackColor = System.Drawing.Color.Transparent
        Me.LBLShowTime.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLShowTime.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LBLShowTime.Location = New System.Drawing.Point(1084, 7)
        Me.LBLShowTime.Name = "LBLShowTime"
        Me.LBLShowTime.Size = New System.Drawing.Size(191, 34)
        Me.LBLShowTime.TabIndex = 31
        Me.LBLShowTime.Text = "FEB 15, 2018 10:23 AM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.ABTNEQUIPMENTSTATUS)
        Me.Panel2.Controls.Add(Me.APNLSHOWSEL)
        Me.Panel2.Controls.Add(Me.ABTNLOGOUT)
        Me.Panel2.Controls.Add(Me.ABTNMAINPREVENTIVEMAINTENANCE)
        Me.Panel2.Controls.Add(Me.ABTNMAININVENTORY)
        Me.Panel2.Controls.Add(Me.ABTNMAINREQUEST)
        Me.Panel2.Controls.Add(Me.ABTNMAINSUPPLIER)
        Me.Panel2.Controls.Add(Me.ABTNMAINHOME)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 721)
        Me.Panel2.TabIndex = 1
        '
        'ABTNEQUIPMENTSTATUS
        '
        Me.ABTNEQUIPMENTSTATUS.BackColor = System.Drawing.Color.DimGray
        Me.ABTNEQUIPMENTSTATUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNEQUIPMENTSTATUS.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNEQUIPMENTSTATUS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNEQUIPMENTSTATUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNEQUIPMENTSTATUS.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNEQUIPMENTSTATUS.ForeColor = System.Drawing.Color.White
        Me.ABTNEQUIPMENTSTATUS.Image = Global.PRA_PIS.My.Resources.Resources.outline_build_white_24dp
        Me.ABTNEQUIPMENTSTATUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNEQUIPMENTSTATUS.Location = New System.Drawing.Point(1, 426)
        Me.ABTNEQUIPMENTSTATUS.Name = "ABTNEQUIPMENTSTATUS"
        Me.ABTNEQUIPMENTSTATUS.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNEQUIPMENTSTATUS.Size = New System.Drawing.Size(180, 70)
        Me.ABTNEQUIPMENTSTATUS.TabIndex = 1010
        Me.ABTNEQUIPMENTSTATUS.Text = "  EQUIPMENT          STATUS"
        Me.ABTNEQUIPMENTSTATUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNEQUIPMENTSTATUS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABTNEQUIPMENTSTATUS.UseVisualStyleBackColor = False
        '
        'APNLSHOWSEL
        '
        Me.APNLSHOWSEL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.APNLSHOWSEL.Controls.Add(Me.ABTNSEL5)
        Me.APNLSHOWSEL.Controls.Add(Me.ABTNSEL4)
        Me.APNLSHOWSEL.Controls.Add(Me.ABTNSEL3)
        Me.APNLSHOWSEL.Controls.Add(Me.ABTNSEL2)
        Me.APNLSHOWSEL.Controls.Add(Me.ABTNSEL1)
        Me.APNLSHOWSEL.Location = New System.Drawing.Point(5, 500)
        Me.APNLSHOWSEL.Name = "APNLSHOWSEL"
        Me.APNLSHOWSEL.Size = New System.Drawing.Size(142, 163)
        Me.APNLSHOWSEL.TabIndex = 1012
        Me.APNLSHOWSEL.Visible = False
        '
        'ABTNSEL5
        '
        Me.ABTNSEL5.BackColor = System.Drawing.Color.White
        Me.ABTNSEL5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNSEL5.Dock = System.Windows.Forms.DockStyle.Top
        Me.ABTNSEL5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNSEL5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNSEL5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNSEL5.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNSEL5.ForeColor = System.Drawing.Color.Black
        Me.ABTNSEL5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL5.Location = New System.Drawing.Point(0, 112)
        Me.ABTNSEL5.Name = "ABTNSEL5"
        Me.ABTNSEL5.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNSEL5.Size = New System.Drawing.Size(142, 28)
        Me.ABTNSEL5.TabIndex = 6
        Me.ABTNSEL5.Text = "     "
        Me.ABTNSEL5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL5.UseVisualStyleBackColor = False
        '
        'ABTNSEL4
        '
        Me.ABTNSEL4.BackColor = System.Drawing.Color.White
        Me.ABTNSEL4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNSEL4.Dock = System.Windows.Forms.DockStyle.Top
        Me.ABTNSEL4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNSEL4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNSEL4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNSEL4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNSEL4.ForeColor = System.Drawing.Color.Black
        Me.ABTNSEL4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL4.Location = New System.Drawing.Point(0, 84)
        Me.ABTNSEL4.Name = "ABTNSEL4"
        Me.ABTNSEL4.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNSEL4.Size = New System.Drawing.Size(142, 28)
        Me.ABTNSEL4.TabIndex = 5
        Me.ABTNSEL4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL4.UseVisualStyleBackColor = False
        '
        'ABTNSEL3
        '
        Me.ABTNSEL3.BackColor = System.Drawing.Color.White
        Me.ABTNSEL3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNSEL3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ABTNSEL3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNSEL3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNSEL3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNSEL3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNSEL3.ForeColor = System.Drawing.Color.Black
        Me.ABTNSEL3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL3.Location = New System.Drawing.Point(0, 56)
        Me.ABTNSEL3.Name = "ABTNSEL3"
        Me.ABTNSEL3.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNSEL3.Size = New System.Drawing.Size(142, 28)
        Me.ABTNSEL3.TabIndex = 4
        Me.ABTNSEL3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL3.UseVisualStyleBackColor = False
        '
        'ABTNSEL2
        '
        Me.ABTNSEL2.BackColor = System.Drawing.Color.White
        Me.ABTNSEL2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNSEL2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ABTNSEL2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNSEL2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNSEL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNSEL2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNSEL2.ForeColor = System.Drawing.Color.Black
        Me.ABTNSEL2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL2.Location = New System.Drawing.Point(0, 28)
        Me.ABTNSEL2.Name = "ABTNSEL2"
        Me.ABTNSEL2.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNSEL2.Size = New System.Drawing.Size(142, 28)
        Me.ABTNSEL2.TabIndex = 3
        Me.ABTNSEL2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL2.UseVisualStyleBackColor = False
        '
        'ABTNSEL1
        '
        Me.ABTNSEL1.BackColor = System.Drawing.Color.White
        Me.ABTNSEL1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNSEL1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ABTNSEL1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNSEL1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNSEL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNSEL1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNSEL1.ForeColor = System.Drawing.Color.Black
        Me.ABTNSEL1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL1.Location = New System.Drawing.Point(0, 0)
        Me.ABTNSEL1.Name = "ABTNSEL1"
        Me.ABTNSEL1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNSEL1.Size = New System.Drawing.Size(142, 28)
        Me.ABTNSEL1.TabIndex = 2
        Me.ABTNSEL1.Text = " "
        Me.ABTNSEL1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSEL1.UseVisualStyleBackColor = False
        '
        'ABTNLOGOUT
        '
        Me.ABTNLOGOUT.BackColor = System.Drawing.Color.DimGray
        Me.ABTNLOGOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNLOGOUT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ABTNLOGOUT.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ABTNLOGOUT.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNLOGOUT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.ABTNLOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNLOGOUT.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNLOGOUT.ForeColor = System.Drawing.Color.White
        Me.ABTNLOGOUT.Image = CType(resources.GetObject("ABTNLOGOUT.Image"), System.Drawing.Image)
        Me.ABTNLOGOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNLOGOUT.Location = New System.Drawing.Point(0, 651)
        Me.ABTNLOGOUT.Name = "ABTNLOGOUT"
        Me.ABTNLOGOUT.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNLOGOUT.Size = New System.Drawing.Size(180, 70)
        Me.ABTNLOGOUT.TabIndex = 1009
        Me.ABTNLOGOUT.Text = "     LOG-OUT"
        Me.ABTNLOGOUT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNLOGOUT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABTNLOGOUT.UseVisualStyleBackColor = False
        '
        'ABTNMAINPREVENTIVEMAINTENANCE
        '
        Me.ABTNMAINPREVENTIVEMAINTENANCE.BackColor = System.Drawing.Color.DimGray
        Me.ABTNMAINPREVENTIVEMAINTENANCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNMAINPREVENTIVEMAINTENANCE.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNMAINPREVENTIVEMAINTENANCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNMAINPREVENTIVEMAINTENANCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNMAINPREVENTIVEMAINTENANCE.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNMAINPREVENTIVEMAINTENANCE.ForeColor = System.Drawing.Color.White
        Me.ABTNMAINPREVENTIVEMAINTENANCE.Image = Global.PRA_PIS.My.Resources.Resources.outline_folder_shared_white_24dp
        Me.ABTNMAINPREVENTIVEMAINTENANCE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINPREVENTIVEMAINTENANCE.Location = New System.Drawing.Point(-1, 350)
        Me.ABTNMAINPREVENTIVEMAINTENANCE.Name = "ABTNMAINPREVENTIVEMAINTENANCE"
        Me.ABTNMAINPREVENTIVEMAINTENANCE.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNMAINPREVENTIVEMAINTENANCE.Size = New System.Drawing.Size(180, 70)
        Me.ABTNMAINPREVENTIVEMAINTENANCE.TabIndex = 1007
        Me.ABTNMAINPREVENTIVEMAINTENANCE.Text = "   PREVENTIVE        MAINTENANCE"
        Me.ABTNMAINPREVENTIVEMAINTENANCE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINPREVENTIVEMAINTENANCE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABTNMAINPREVENTIVEMAINTENANCE.UseVisualStyleBackColor = False
        '
        'ABTNMAININVENTORY
        '
        Me.ABTNMAININVENTORY.BackColor = System.Drawing.Color.DimGray
        Me.ABTNMAININVENTORY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNMAININVENTORY.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNMAININVENTORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNMAININVENTORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNMAININVENTORY.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNMAININVENTORY.ForeColor = System.Drawing.Color.White
        Me.ABTNMAININVENTORY.Image = CType(resources.GetObject("ABTNMAININVENTORY.Image"), System.Drawing.Image)
        Me.ABTNMAININVENTORY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAININVENTORY.Location = New System.Drawing.Point(0, 280)
        Me.ABTNMAININVENTORY.Name = "ABTNMAININVENTORY"
        Me.ABTNMAININVENTORY.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNMAININVENTORY.Size = New System.Drawing.Size(180, 70)
        Me.ABTNMAININVENTORY.TabIndex = 1008
        Me.ABTNMAININVENTORY.Text = "  INVENTORY"
        Me.ABTNMAININVENTORY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAININVENTORY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABTNMAININVENTORY.UseVisualStyleBackColor = False
        '
        'ABTNMAINREQUEST
        '
        Me.ABTNMAINREQUEST.BackColor = System.Drawing.Color.DimGray
        Me.ABTNMAINREQUEST.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNMAINREQUEST.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNMAINREQUEST.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNMAINREQUEST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNMAINREQUEST.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNMAINREQUEST.ForeColor = System.Drawing.Color.White
        Me.ABTNMAINREQUEST.Image = Global.PRA_PIS.My.Resources.Resources.outline_assignment_white_24dp
        Me.ABTNMAINREQUEST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINREQUEST.Location = New System.Drawing.Point(1, 132)
        Me.ABTNMAINREQUEST.Name = "ABTNMAINREQUEST"
        Me.ABTNMAINREQUEST.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNMAINREQUEST.Size = New System.Drawing.Size(180, 70)
        Me.ABTNMAINREQUEST.TabIndex = 1006
        Me.ABTNMAINREQUEST.Text = "   PURCHASE          REQUEST"
        Me.ABTNMAINREQUEST.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINREQUEST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABTNMAINREQUEST.UseVisualStyleBackColor = False
        '
        'ABTNMAINSUPPLIER
        '
        Me.ABTNMAINSUPPLIER.BackColor = System.Drawing.Color.DimGray
        Me.ABTNMAINSUPPLIER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNMAINSUPPLIER.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNMAINSUPPLIER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNMAINSUPPLIER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNMAINSUPPLIER.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNMAINSUPPLIER.ForeColor = System.Drawing.Color.White
        Me.ABTNMAINSUPPLIER.Image = Global.PRA_PIS.My.Resources.Resources.outline_home_work_white_24dp
        Me.ABTNMAINSUPPLIER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINSUPPLIER.Location = New System.Drawing.Point(-1, 204)
        Me.ABTNMAINSUPPLIER.Name = "ABTNMAINSUPPLIER"
        Me.ABTNMAINSUPPLIER.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNMAINSUPPLIER.Size = New System.Drawing.Size(180, 70)
        Me.ABTNMAINSUPPLIER.TabIndex = 1005
        Me.ABTNMAINSUPPLIER.Text = "   SUPPLIER"
        Me.ABTNMAINSUPPLIER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINSUPPLIER.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABTNMAINSUPPLIER.UseVisualStyleBackColor = False
        '
        'ABTNMAINHOME
        '
        Me.ABTNMAINHOME.BackColor = System.Drawing.Color.DimGray
        Me.ABTNMAINHOME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNMAINHOME.Dock = System.Windows.Forms.DockStyle.Top
        Me.ABTNMAINHOME.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNMAINHOME.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNMAINHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNMAINHOME.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNMAINHOME.ForeColor = System.Drawing.Color.White
        Me.ABTNMAINHOME.Image = CType(resources.GetObject("ABTNMAINHOME.Image"), System.Drawing.Image)
        Me.ABTNMAINHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINHOME.Location = New System.Drawing.Point(0, 56)
        Me.ABTNMAINHOME.Name = "ABTNMAINHOME"
        Me.ABTNMAINHOME.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNMAINHOME.Size = New System.Drawing.Size(180, 70)
        Me.ABTNMAINHOME.TabIndex = 6
        Me.ABTNMAINHOME.Text = "    HOME"
        Me.ABTNMAINHOME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINHOME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABTNMAINHOME.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(180, 56)
        Me.Panel4.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.PRA_LOGO_WHITE_BG
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.TabIndex = 1003
        Me.PictureBox2.TabStop = False
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.White
        Me.PNL.Controls.Add(Me.BTNMAIN_NOTIFICATION)
        Me.PNL.Controls.Add(Me.BTNMAINMaximize)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(180, 0)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1100, 56)
        Me.PNL.TabIndex = 3
        '
        'BTNMAIN_NOTIFICATION
        '
        Me.BTNMAIN_NOTIFICATION.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTNMAIN_NOTIFICATION.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNMAIN_NOTIFICATION.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise
        Me.BTNMAIN_NOTIFICATION.FlatAppearance.BorderSize = 0
        Me.BTNMAIN_NOTIFICATION.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTNMAIN_NOTIFICATION.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BTNMAIN_NOTIFICATION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMAIN_NOTIFICATION.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMAIN_NOTIFICATION.ForeColor = System.Drawing.Color.Red
        Me.BTNMAIN_NOTIFICATION.Image = Global.PRA_PIS.My.Resources.Resources.outline_notifications_black_18dp
        Me.BTNMAIN_NOTIFICATION.Location = New System.Drawing.Point(997, 7)
        Me.BTNMAIN_NOTIFICATION.Name = "BTNMAIN_NOTIFICATION"
        Me.BTNMAIN_NOTIFICATION.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BTNMAIN_NOTIFICATION.Size = New System.Drawing.Size(58, 43)
        Me.BTNMAIN_NOTIFICATION.TabIndex = 35
        Me.BTNMAIN_NOTIFICATION.Text = "10"
        Me.BTNMAIN_NOTIFICATION.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTNMAIN_NOTIFICATION.UseVisualStyleBackColor = False
        Me.BTNMAIN_NOTIFICATION.Visible = False
        '
        'BTNMAINMaximize
        '
        Me.BTNMAINMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNMAINMaximize.BackColor = System.Drawing.Color.Transparent
        Me.BTNMAINMaximize.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left
        Me.BTNMAINMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNMAINMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTNMAINMaximize.FlatAppearance.BorderSize = 3
        Me.BTNMAINMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BTNMAINMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BTNMAINMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMAINMaximize.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMAINMaximize.Location = New System.Drawing.Point(1059, 9)
        Me.BTNMAINMaximize.Name = "BTNMAINMaximize"
        Me.BTNMAINMaximize.Size = New System.Drawing.Size(30, 30)
        Me.BTNMAINMaximize.TabIndex = 33
        Me.TTP_MDIMAIN.SetToolTip(Me.BTNMAINMaximize, "Mini")
        Me.BTNMAINMaximize.UseVisualStyleBackColor = False
        '
        'LBL_RIMSHEADER
        '
        Me.LBL_RIMSHEADER.AutoSize = True
        Me.LBL_RIMSHEADER.BackColor = System.Drawing.Color.White
        Me.LBL_RIMSHEADER.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_RIMSHEADER.ForeColor = System.Drawing.Color.DarkRed
        Me.LBL_RIMSHEADER.Location = New System.Drawing.Point(68, 14)
        Me.LBL_RIMSHEADER.Name = "LBL_RIMSHEADER"
        Me.LBL_RIMSHEADER.Size = New System.Drawing.Size(36, 31)
        Me.LBL_RIMSHEADER.TabIndex = 17
        Me.LBL_RIMSHEADER.Text = "PR"
        '
        'PNL_Home
        '
        Me.PNL_Home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_Home.Controls.Add(Me.ABTNMAINUDITTRAIL)
        Me.PNL_Home.Controls.Add(Me.ABTNSYSTEMADMIN)
        Me.PNL_Home.Controls.Add(Me.PictureBox1)
        Me.PNL_Home.Controls.Add(Me.LBLSRRVHEADER)
        Me.PNL_Home.Location = New System.Drawing.Point(180, 56)
        Me.PNL_Home.Name = "PNL_Home"
        Me.PNL_Home.Size = New System.Drawing.Size(1100, 665)
        Me.PNL_Home.TabIndex = 19
        Me.TTP_MDIMAIN.SetToolTip(Me.PNL_Home, "Minimize")
        '
        'ABTNMAINUDITTRAIL
        '
        Me.ABTNMAINUDITTRAIL.BackColor = System.Drawing.Color.DimGray
        Me.ABTNMAINUDITTRAIL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNMAINUDITTRAIL.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNMAINUDITTRAIL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNMAINUDITTRAIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNMAINUDITTRAIL.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNMAINUDITTRAIL.ForeColor = System.Drawing.Color.White
        Me.ABTNMAINUDITTRAIL.Image = CType(resources.GetObject("ABTNMAINUDITTRAIL.Image"), System.Drawing.Image)
        Me.ABTNMAINUDITTRAIL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINUDITTRAIL.Location = New System.Drawing.Point(919, 514)
        Me.ABTNMAINUDITTRAIL.Name = "ABTNMAINUDITTRAIL"
        Me.ABTNMAINUDITTRAIL.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNMAINUDITTRAIL.Size = New System.Drawing.Size(180, 70)
        Me.ABTNMAINUDITTRAIL.TabIndex = 1011
        Me.ABTNMAINUDITTRAIL.Text = "     CRSA AUDIT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     TRAIL"
        Me.ABTNMAINUDITTRAIL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNMAINUDITTRAIL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABTNMAINUDITTRAIL.UseVisualStyleBackColor = False
        Me.ABTNMAINUDITTRAIL.Visible = False
        '
        'ABTNSYSTEMADMIN
        '
        Me.ABTNSYSTEMADMIN.BackColor = System.Drawing.Color.DimGray
        Me.ABTNSYSTEMADMIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ABTNSYSTEMADMIN.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.ABTNSYSTEMADMIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ABTNSYSTEMADMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ABTNSYSTEMADMIN.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABTNSYSTEMADMIN.ForeColor = System.Drawing.Color.White
        Me.ABTNSYSTEMADMIN.Image = CType(resources.GetObject("ABTNSYSTEMADMIN.Image"), System.Drawing.Image)
        Me.ABTNSYSTEMADMIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSYSTEMADMIN.Location = New System.Drawing.Point(919, 590)
        Me.ABTNSYSTEMADMIN.Name = "ABTNSYSTEMADMIN"
        Me.ABTNSYSTEMADMIN.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.ABTNSYSTEMADMIN.Size = New System.Drawing.Size(180, 70)
        Me.ABTNSYSTEMADMIN.TabIndex = 1010
        Me.ABTNSYSTEMADMIN.Text = "     ADMIN (SYSTEM)"
        Me.ABTNSYSTEMADMIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ABTNSYSTEMADMIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ABTNSYSTEMADMIN.UseVisualStyleBackColor = False
        Me.ABTNSYSTEMADMIN.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.PRA_LOGO_WHITE_BG
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(364, 146)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 370)
        Me.PictureBox1.TabIndex = 1004
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LBLSRRVHEADER
        '
        Me.LBLSRRVHEADER.AutoSize = True
        Me.LBLSRRVHEADER.BackColor = System.Drawing.Color.Gray
        Me.LBLSRRVHEADER.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLSRRVHEADER.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSRRVHEADER.ForeColor = System.Drawing.Color.White
        Me.LBLSRRVHEADER.Location = New System.Drawing.Point(0, 0)
        Me.LBLSRRVHEADER.Name = "LBLSRRVHEADER"
        Me.LBLSRRVHEADER.Size = New System.Drawing.Size(421, 42)
        Me.LBLSRRVHEADER.TabIndex = 1005
        Me.LBLSRRVHEADER.Text = "PHILIPPINE RETIREMENT AUTHORITY"
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
        'TMR_MDIMAIN
        '
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V1VW_USERACCESSMAINBindingSource
        '
        Me.V1VW_USERACCESSMAINBindingSource.DataMember = "V1VW_USERACCESSMAIN"
        Me.V1VW_USERACCESSMAINBindingSource.DataSource = Me.DS_VIEWS
        '
        'V1VW_USERACCESSMAINTableAdapter
        '
        Me.V1VW_USERACCESSMAINTableAdapter.ClearBeforeFill = True
        '
        'V1VW_USERACCESSSUBBindingSource
        '
        Me.V1VW_USERACCESSSUBBindingSource.DataMember = "V1VW_USERACCESSSUB"
        Me.V1VW_USERACCESSSUBBindingSource.DataSource = Me.DS_VIEWS
        '
        'V1VW_USERACCESSSUBTableAdapter
        '
        Me.V1VW_USERACCESSSUBTableAdapter.ClearBeforeFill = True
        '
        'MDI_Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.ABTNLOGOUT
        Me.ClientSize = New System.Drawing.Size(1280, 768)
        Me.Controls.Add(Me.PNL_Home)
        Me.Controls.Add(Me.LBL_RIMSHEADER)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDI_Mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procurement Information System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.APNLSHOWSEL.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL_Home.ResumeLayout(False)
        Me.PNL_Home.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_USERACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_USERACCOUNTLOGSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV2_FINEXCHANGERATEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V1VW_USERACCESSMAINBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V1VW_USERACCESSSUBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PNL As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LBLSystemUser As Label
    Friend WithEvents LBLShowTime As Label
    Friend WithEvents ABTNSYSTEMADMIN As Button
    Friend WithEvents ABTNLOGOUT As Button
    Friend WithEvents ABTNMAINPREVENTIVEMAINTENANCE As Button
    Friend WithEvents ABTNMAININVENTORY As Button
    Friend WithEvents ABTNMAINREQUEST As Button
    Friend WithEvents ABTNMAINSUPPLIER As Button
    Friend WithEvents ABTNMAINHOME As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BTNMAINMaximize As Button
    Friend WithEvents LBL_RIMSHEADER As Label
    Friend WithEvents ABTNMAINUDITTRAIL As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PNL_Home As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBLSRRVHEADER As Label
    Friend WithEvents TTP_MDIMAIN As ToolTip
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TblV1_USERACCOUNTTableAdapter As DS_TABLESTableAdapters.tblV1_USERACCOUNTTableAdapter
    Friend WithEvents TblV1_USERACCOUNTBindingSource As BindingSource
    Friend WithEvents TblV1_USERACCOUNTLOGSBindingSource As BindingSource
    Friend WithEvents TblV1_USERACCOUNTLOGSTableAdapter As DS_TABLESTableAdapters.tblV1_USERACCOUNTLOGSTableAdapter
    Friend WithEvents TMR_MDIMAIN As Timer
    Friend WithEvents APNLSHOWSEL As Panel
    Friend WithEvents ABTNSEL5 As Button
    Friend WithEvents ABTNSEL4 As Button
    Friend WithEvents ABTNSEL3 As Button
    Friend WithEvents ABTNSEL2 As Button
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents V1VW_USERACCESSMAINBindingSource As BindingSource
    Friend WithEvents V1VW_USERACCESSMAINTableAdapter As DS_VIEWSTableAdapters.V1VW_USERACCESSMAINTableAdapter
    Friend WithEvents V1VW_USERACCESSSUBBindingSource As BindingSource
    Friend WithEvents V1VW_USERACCESSSUBTableAdapter As DS_VIEWSTableAdapters.V1VW_USERACCESSSUBTableAdapter
    Friend WithEvents LBL_EXRATE As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TblV2_FINEXCHANGERATEBindingSource As BindingSource
    Friend WithEvents ABTNSEL1 As Button
    Friend WithEvents ABTNEQUIPMENTSTATUS As Button
    Friend WithEvents BTNMAIN_NOTIFICATION As Button
End Class
