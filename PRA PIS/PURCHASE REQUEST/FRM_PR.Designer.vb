<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PR
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_PRMINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_PRCLOSE = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BTN_TRANSCODE = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TblV1_DEFPRADIVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LLBL_PRNEW = New System.Windows.Forms.LinkLabel()
        Me.LLBL_PRSAVE = New System.Windows.Forms.LinkLabel()
        Me.PB_PRICONCANCEL = New System.Windows.Forms.PictureBox()
        Me.PB_PRICONSEARCH = New System.Windows.Forms.PictureBox()
        Me.LLBL_PRCANCEL = New System.Windows.Forms.LinkLabel()
        Me.LLBL_PRSEARCH = New System.Windows.Forms.LinkLabel()
        Me.LLBL_PRPRINTPREVIEW = New System.Windows.Forms.LinkLabel()
        Me.PB_PRICONSAVE = New System.Windows.Forms.PictureBox()
        Me.PB_PRICONPRINTPREVIEW = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TPPRinfo = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LLBL_PRVIEWREMARKS = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LLBL_ADDPARTICULARS = New System.Windows.Forms.LinkLabel()
        Me.DGV_PR_ITEMLIST = New System.Windows.Forms.DataGridView()
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRQUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRUNITISSUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRSTOCKNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDIT = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DELETE = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ShapeContainer6 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRPARTICULARS = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GB_PRINFO = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.RBTN_PESO = New System.Windows.Forms.RadioButton()
        Me.RBTN_DOLLARS = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.WTXT_SUBMITTEDBY = New PRA_PIS.WatermarkTextBox()
        Me.CB_PRDEPARTMENT = New System.Windows.Forms.ComboBox()
        Me.TblV1_HRISDEPARTMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_PRDIVISION = New System.Windows.Forms.ComboBox()
        Me.TblV1_HRISDIVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.WTXT_PURPOSE = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_APPCODE = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_REQUESTEDDATE = New PRA_PIS.WatermarkTextBox()
        Me.SPM4CURRENTDATETIMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PBOX_PRNOQRCODE = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRPURPOSE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRAPPCODE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRREQUESTEDDATE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TPPRSIGNATORY = New System.Windows.Forms.TabPage()
        Me.PanelSignatory = New System.Windows.Forms.Panel()
        Me.TXT_PRNOTEDID = New System.Windows.Forms.TextBox()
        Me.TXT_PRCERTIFIEDID = New System.Windows.Forms.TextBox()
        Me.TXT_PRRAPPROVEDID = New System.Windows.Forms.TextBox()
        Me.TXT_PRREQUESTEDID = New System.Windows.Forms.TextBox()
        Me.PB_SAVEICONSAVEDEFAULT = New System.Windows.Forms.PictureBox()
        Me.LLBL_SAVEDEFAULT = New System.Windows.Forms.LinkLabel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.WTXT_SIGNNOTEDPOSITION = New PRA_PIS.WatermarkTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WTXT_SIGNNOTEDNAME = New PRA_PIS.WatermarkTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WTXT_SIGNCERTIFIEDPOSITION = New PRA_PIS.WatermarkTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.WTXT_SIGNCERTIFIEDNAME = New PRA_PIS.WatermarkTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.WTXT_SIGNAPPROVEPOSITION = New PRA_PIS.WatermarkTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.WTXT_SIGNAPPROVENAME = New PRA_PIS.WatermarkTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.WTXT_SIGNREQUESTEDPOSITION = New PRA_PIS.WatermarkTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WTXT_SIGNREQUESTEDNAME = New PRA_PIS.WatermarkTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape17 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSIGNNOTEDPOSITION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSIGNNOTEDNAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSIGNCERTIFIEDPOSITION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSIGNCERTIFIEDNAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSIGNAPPROVEDNAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSIGNAPPROVEPOSITION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSIGNREQUESTEDPOSITION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSIGNREQUESTEDNAME = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LLBL_PREDIT = New System.Windows.Forms.LinkLabel()
        Me.SQDGV_PURCHASEREQUESTDataGridView = New System.Windows.Forms.DataGridView()
        Me.PB_PRICONNEW = New System.Windows.Forms.PictureBox()
        Me.PB_PBICONEDIT = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSAVENEW = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.WTXT_TDNUM = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LBL_SCANNERNAME = New System.Windows.Forms.Label()
        Me.cbxSources = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.VWG3_PRIMARY_SIGNATORYDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VWG3_PRIMARY_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_PURCHASEREQUEST_ITEMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblM4_PURCHASEREQUEST_ITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGV_SCANNED_IMG = New System.Windows.Forms.DataGridView()
        Me.SCANNED_IMG = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.wtxt_date = New PRA_PIS.WatermarkTextBox()
        Me.TblV1_DEFPRADIVISIONTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_DEFPRADIVISIONTableAdapter()
        Me.TblV1_HRISDIVISIONTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter()
        Me.TableAdapterManager1 = New PRA_PIS.DS_TABLESTableAdapters.TableAdapterManager()
        Me.TblV1_HRISDEPARTMENTTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter()
        Me.TblV1_USERACCOUNTTableAdapter1 = New PRA_PIS.DS_TABLESTableAdapters.tblV1_USERACCOUNTTableAdapter()
        Me.TblV1_HRISEMPLOYEEDATATableAdapter1 = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter()
        Me.TBLG3UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4PURCHASEREQUESTITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4PRCODEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VWG3_PRIMARY_SIGNATORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.VWG3_PRIMARY_SIGNATORYTableAdapter()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TBLG3_UNITSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter()
        Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter()
        Me.TblM4_PURCHASEREQUESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_PURCHASEREQUESTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter()
        Me.SPM4_PRCODETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_PRCODETableAdapter()
        Me.SPM4_CURRENTDATETIMETableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter()
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLG3_PRIMARY_SIGNATORYTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLG3_PRIMARY_SIGNATORYTableAdapter()
        Me.APNL_PRREMARKS = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.BTN_CLOSE_PRREMARKS = New System.Windows.Forms.Button()
        Me.PNL.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.TblV1_DEFPRADIVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRICONCANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRICONSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRICONSAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRICONPRINTPREVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TPPRinfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_PR_ITEMLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_PRINFO.SuspendLayout()
        CType(Me.TblV1_HRISDEPARTMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1_HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPPRSIGNATORY.SuspendLayout()
        Me.PanelSignatory.SuspendLayout()
        CType(Me.PB_SAVEICONSAVEDEFAULT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQDGV_PURCHASEREQUESTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRICONNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PBICONEDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWG3_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_PURCHASEREQUEST_ITEMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_PURCHASEREQUEST_ITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_SCANNED_IMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4PURCHASEREQUESTITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4PRCODEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APNL_PRREMARKS.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_PRMINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_PRCLOSE)
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1095, 74)
        Me.PNL.TabIndex = 1402
        '
        'BTN_PRMINIMIZE
        '
        Me.BTN_PRMINIMIZE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_PRMINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_PRMINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_PRMINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_PRMINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_PRMINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_PRMINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PRMINIMIZE.Location = New System.Drawing.Point(1027, 8)
        Me.BTN_PRMINIMIZE.Name = "BTN_PRMINIMIZE"
        Me.BTN_PRMINIMIZE.Size = New System.Drawing.Size(28, 28)
        Me.BTN_PRMINIMIZE.TabIndex = 11
        Me.BTN_PRMINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_PRMINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_PRCLOSE
        '
        Me.BTN_PRCLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_PRCLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_PRCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_PRCLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_PRCLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_PRCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PRCLOSE.Location = New System.Drawing.Point(1062, 7)
        Me.BTN_PRCLOSE.Name = "BTN_PRCLOSE"
        Me.BTN_PRCLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_PRCLOSE.TabIndex = 10
        Me.BTN_PRCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_PRCLOSE.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(9, 9)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(258, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "P U R C H A S E  R E Q U E S T"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-3410, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-3363, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Window
        Me.Panel6.Controls.Add(Me.BTN_TRANSCODE)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.LinkLabel1)
        Me.Panel6.Controls.Add(Me.LLBL_PRNEW)
        Me.Panel6.Controls.Add(Me.LLBL_PRSAVE)
        Me.Panel6.Controls.Add(Me.PB_PRICONCANCEL)
        Me.Panel6.Controls.Add(Me.PB_PRICONSEARCH)
        Me.Panel6.Controls.Add(Me.LLBL_PRCANCEL)
        Me.Panel6.Controls.Add(Me.LLBL_PRSEARCH)
        Me.Panel6.Controls.Add(Me.LLBL_PRPRINTPREVIEW)
        Me.Panel6.Controls.Add(Me.PB_PRICONSAVE)
        Me.Panel6.Controls.Add(Me.PB_PRICONPRINTPREVIEW)
        Me.Panel6.Controls.Add(Me.TabControl1)
        Me.Panel6.Controls.Add(Me.LLBL_PREDIT)
        Me.Panel6.Controls.Add(Me.SQDGV_PURCHASEREQUESTDataGridView)
        Me.Panel6.Controls.Add(Me.PB_PRICONNEW)
        Me.Panel6.Controls.Add(Me.PB_PBICONEDIT)
        Me.Panel6.Controls.Add(Me.ShapeContainer3)
        Me.Panel6.Location = New System.Drawing.Point(3, 40)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1089, 616)
        Me.Panel6.TabIndex = 1405
        '
        'BTN_TRANSCODE
        '
        Me.BTN_TRANSCODE.Location = New System.Drawing.Point(1577, 16)
        Me.BTN_TRANSCODE.Name = "BTN_TRANSCODE"
        Me.BTN_TRANSCODE.Size = New System.Drawing.Size(75, 23)
        Me.BTN_TRANSCODE.TabIndex = 1429
        Me.BTN_TRANSCODE.Text = "Button1"
        Me.BTN_TRANSCODE.UseVisualStyleBackColor = True
        Me.BTN_TRANSCODE.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblV1_DEFPRADIVISIONBindingSource, "DIVS_CODE", True))
        Me.TextBox1.Location = New System.Drawing.Point(1550, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 28)
        Me.TextBox1.TabIndex = 1428
        Me.TextBox1.Visible = False
        '
        'TblV1_DEFPRADIVISIONBindingSource
        '
        Me.TblV1_DEFPRADIVISIONBindingSource.DataMember = "tblV1_DEFPRADIVISION"
        Me.TblV1_DEFPRADIVISIONBindingSource.DataSource = Me.DS_TABLES
        '
        'DS_TABLES
        '
        Me.DS_TABLES.DataSetName = "DS_TABLES"
        Me.DS_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.Location = New System.Drawing.Point(577, 27)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 19)
        Me.LinkLabel1.TabIndex = 1427
        '
        'LLBL_PRNEW
        '
        Me.LLBL_PRNEW.AutoSize = True
        Me.LLBL_PRNEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PRNEW.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_PRNEW.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PRNEW.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PRNEW.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PRNEW.Location = New System.Drawing.Point(58, 15)
        Me.LLBL_PRNEW.Name = "LLBL_PRNEW"
        Me.LLBL_PRNEW.Size = New System.Drawing.Size(46, 19)
        Me.LLBL_PRNEW.TabIndex = 1425
        Me.LLBL_PRNEW.TabStop = True
        Me.LLBL_PRNEW.Text = "NEW"
        '
        'LLBL_PRSAVE
        '
        Me.LLBL_PRSAVE.AutoSize = True
        Me.LLBL_PRSAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PRSAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_PRSAVE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PRSAVE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PRSAVE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PRSAVE.Location = New System.Drawing.Point(56, 15)
        Me.LLBL_PRSAVE.Name = "LLBL_PRSAVE"
        Me.LLBL_PRSAVE.Size = New System.Drawing.Size(52, 19)
        Me.LLBL_PRSAVE.TabIndex = 1426
        Me.LLBL_PRSAVE.TabStop = True
        Me.LLBL_PRSAVE.Text = "SAVE"
        '
        'PB_PRICONCANCEL
        '
        Me.PB_PRICONCANCEL.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.PB_PRICONCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PRICONCANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PRICONCANCEL.Enabled = False
        Me.PB_PRICONCANCEL.InitialImage = Nothing
        Me.PB_PRICONCANCEL.Location = New System.Drawing.Point(237, 10)
        Me.PB_PRICONCANCEL.Name = "PB_PRICONCANCEL"
        Me.PB_PRICONCANCEL.Size = New System.Drawing.Size(32, 28)
        Me.PB_PRICONCANCEL.TabIndex = 1420
        Me.PB_PRICONCANCEL.TabStop = False
        '
        'PB_PRICONSEARCH
        '
        Me.PB_PRICONSEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_24dp
        Me.PB_PRICONSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PRICONSEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PRICONSEARCH.InitialImage = Nothing
        Me.PB_PRICONSEARCH.Location = New System.Drawing.Point(365, 10)
        Me.PB_PRICONSEARCH.Name = "PB_PRICONSEARCH"
        Me.PB_PRICONSEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_PRICONSEARCH.TabIndex = 1421
        Me.PB_PRICONSEARCH.TabStop = False
        '
        'LLBL_PRCANCEL
        '
        Me.LLBL_PRCANCEL.AutoSize = True
        Me.LLBL_PRCANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PRCANCEL.Enabled = False
        Me.LLBL_PRCANCEL.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_PRCANCEL.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PRCANCEL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PRCANCEL.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PRCANCEL.Location = New System.Drawing.Point(268, 15)
        Me.LLBL_PRCANCEL.Name = "LLBL_PRCANCEL"
        Me.LLBL_PRCANCEL.Size = New System.Drawing.Size(77, 19)
        Me.LLBL_PRCANCEL.TabIndex = 1418
        Me.LLBL_PRCANCEL.TabStop = True
        Me.LLBL_PRCANCEL.Text = "CANCEL"
        '
        'LLBL_PRSEARCH
        '
        Me.LLBL_PRSEARCH.AutoSize = True
        Me.LLBL_PRSEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PRSEARCH.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_PRSEARCH.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PRSEARCH.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PRSEARCH.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PRSEARCH.Location = New System.Drawing.Point(397, 15)
        Me.LLBL_PRSEARCH.Name = "LLBL_PRSEARCH"
        Me.LLBL_PRSEARCH.Size = New System.Drawing.Size(62, 19)
        Me.LLBL_PRSEARCH.TabIndex = 1422
        Me.LLBL_PRSEARCH.TabStop = True
        Me.LLBL_PRSEARCH.Text = "PR LIST"
        '
        'LLBL_PRPRINTPREVIEW
        '
        Me.LLBL_PRPRINTPREVIEW.AutoSize = True
        Me.LLBL_PRPRINTPREVIEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PRPRINTPREVIEW.Enabled = False
        Me.LLBL_PRPRINTPREVIEW.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_PRPRINTPREVIEW.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PRPRINTPREVIEW.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PRPRINTPREVIEW.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PRPRINTPREVIEW.Location = New System.Drawing.Point(927, 16)
        Me.LLBL_PRPRINTPREVIEW.Name = "LLBL_PRPRINTPREVIEW"
        Me.LLBL_PRPRINTPREVIEW.Size = New System.Drawing.Size(129, 19)
        Me.LLBL_PRPRINTPREVIEW.TabIndex = 1423
        Me.LLBL_PRPRINTPREVIEW.TabStop = True
        Me.LLBL_PRPRINTPREVIEW.Text = "PRINT PREVIEW"
        '
        'PB_PRICONSAVE
        '
        Me.PB_PRICONSAVE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_save_black_18dp
        Me.PB_PRICONSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PRICONSAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PRICONSAVE.InitialImage = Nothing
        Me.PB_PRICONSAVE.Location = New System.Drawing.Point(22, 10)
        Me.PB_PRICONSAVE.Name = "PB_PRICONSAVE"
        Me.PB_PRICONSAVE.Size = New System.Drawing.Size(32, 28)
        Me.PB_PRICONSAVE.TabIndex = 1424
        Me.PB_PRICONSAVE.TabStop = False
        '
        'PB_PRICONPRINTPREVIEW
        '
        Me.PB_PRICONPRINTPREVIEW.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.PB_PRICONPRINTPREVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PRICONPRINTPREVIEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PRICONPRINTPREVIEW.Enabled = False
        Me.PB_PRICONPRINTPREVIEW.InitialImage = Nothing
        Me.PB_PRICONPRINTPREVIEW.Location = New System.Drawing.Point(890, 12)
        Me.PB_PRICONPRINTPREVIEW.Name = "PB_PRICONPRINTPREVIEW"
        Me.PB_PRICONPRINTPREVIEW.Size = New System.Drawing.Size(32, 28)
        Me.PB_PRICONPRINTPREVIEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_PRICONPRINTPREVIEW.TabIndex = 1422
        Me.PB_PRICONPRINTPREVIEW.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPPRinfo)
        Me.TabControl1.Controls.Add(Me.TPPRSIGNATORY)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-4, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1102, 566)
        Me.TabControl1.TabIndex = 1419
        '
        'TPPRinfo
        '
        Me.TPPRinfo.AutoScroll = True
        Me.TPPRinfo.Controls.Add(Me.GroupBox1)
        Me.TPPRinfo.Controls.Add(Me.GB_PRINFO)
        Me.TPPRinfo.Location = New System.Drawing.Point(4, 26)
        Me.TPPRinfo.Name = "TPPRinfo"
        Me.TPPRinfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPRinfo.Size = New System.Drawing.Size(1094, 536)
        Me.TPPRinfo.TabIndex = 0
        Me.TPPRinfo.Text = "Purchase Request Info"
        Me.TPPRinfo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LLBL_PRVIEWREMARKS)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LLBL_ADDPARTICULARS)
        Me.GroupBox1.Controls.Add(Me.DGV_PR_ITEMLIST)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer6)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(7, 252)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1070, 278)
        Me.GroupBox1.TabIndex = 1420
        Me.GroupBox1.TabStop = False
        '
        'LLBL_PRVIEWREMARKS
        '
        Me.LLBL_PRVIEWREMARKS.AutoSize = True
        Me.LLBL_PRVIEWREMARKS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PRVIEWREMARKS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_PRVIEWREMARKS.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PRVIEWREMARKS.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PRVIEWREMARKS.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PRVIEWREMARKS.Location = New System.Drawing.Point(782, 26)
        Me.LLBL_PRVIEWREMARKS.Name = "LLBL_PRVIEWREMARKS"
        Me.LLBL_PRVIEWREMARKS.Size = New System.Drawing.Size(117, 18)
        Me.LLBL_PRVIEWREMARKS.TabIndex = 1448
        Me.LLBL_PRVIEWREMARKS.TabStop = True
        Me.LLBL_PRVIEWREMARKS.Text = "VIEW REMARKS"
        Me.LLBL_PRVIEWREMARKS.Visible = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel3.Enabled = False
        Me.LinkLabel3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel3.Location = New System.Drawing.Point(9, -2)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(103, 18)
        Me.LinkLabel3.TabIndex = 1420
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "PARTICULARS"
        '
        'LLBL_ADDPARTICULARS
        '
        Me.LLBL_ADDPARTICULARS.AutoSize = True
        Me.LLBL_ADDPARTICULARS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_ADDPARTICULARS.Enabled = False
        Me.LLBL_ADDPARTICULARS.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_ADDPARTICULARS.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_ADDPARTICULARS.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_ADDPARTICULARS.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_ADDPARTICULARS.Location = New System.Drawing.Point(921, 26)
        Me.LLBL_ADDPARTICULARS.Name = "LLBL_ADDPARTICULARS"
        Me.LLBL_ADDPARTICULARS.Size = New System.Drawing.Size(140, 18)
        Me.LLBL_ADDPARTICULARS.TabIndex = 1419
        Me.LLBL_ADDPARTICULARS.TabStop = True
        Me.LLBL_ADDPARTICULARS.Text = "ADD PARTICULARS"
        '
        'DGV_PR_ITEMLIST
        '
        Me.DGV_PR_ITEMLIST.AllowUserToAddRows = False
        Me.DGV_PR_ITEMLIST.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_PR_ITEMLIST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_PR_ITEMLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_PR_ITEMLIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DGV_PR_ITEMLIST.BackgroundColor = System.Drawing.Color.Gray
        Me.DGV_PR_ITEMLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PR_ITEMLIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn, Me.PRQUANTITYDataGridViewTextBoxColumn, Me.PRUNITISSUEDataGridViewTextBoxColumn, Me.PRSTOCKNODataGridViewTextBoxColumn, Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn, Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn, Me.EDIT, Me.DELETE})
        Me.DGV_PR_ITEMLIST.Location = New System.Drawing.Point(7, 61)
        Me.DGV_PR_ITEMLIST.Name = "DGV_PR_ITEMLIST"
        Me.DGV_PR_ITEMLIST.ReadOnly = True
        Me.DGV_PR_ITEMLIST.RowHeadersVisible = False
        Me.DGV_PR_ITEMLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PR_ITEMLIST.Size = New System.Drawing.Size(1054, 208)
        Me.DGV_PR_ITEMLIST.TabIndex = 0
        '
        'PRIITEMDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn.MaxInputLength = 300
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn.Name = "PRIITEMDESCRIPTIONDataGridViewTextBoxColumn"
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRQUANTITYDataGridViewTextBoxColumn
        '
        Me.PRQUANTITYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRQUANTITYDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.PRQUANTITYDataGridViewTextBoxColumn.MaxInputLength = 13
        Me.PRQUANTITYDataGridViewTextBoxColumn.Name = "PRQUANTITYDataGridViewTextBoxColumn"
        Me.PRQUANTITYDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRQUANTITYDataGridViewTextBoxColumn.Width = 70
        '
        'PRUNITISSUEDataGridViewTextBoxColumn
        '
        Me.PRUNITISSUEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRUNITISSUEDataGridViewTextBoxColumn.HeaderText = "Unit of Issue"
        Me.PRUNITISSUEDataGridViewTextBoxColumn.Name = "PRUNITISSUEDataGridViewTextBoxColumn"
        Me.PRUNITISSUEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRUNITISSUEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRUNITISSUEDataGridViewTextBoxColumn.Width = 75
        '
        'PRSTOCKNODataGridViewTextBoxColumn
        '
        Me.PRSTOCKNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRSTOCKNODataGridViewTextBoxColumn.HeaderText = "Stock No."
        Me.PRSTOCKNODataGridViewTextBoxColumn.MaxInputLength = 30
        Me.PRSTOCKNODataGridViewTextBoxColumn.Name = "PRSTOCKNODataGridViewTextBoxColumn"
        Me.PRSTOCKNODataGridViewTextBoxColumn.ReadOnly = True
        Me.PRSTOCKNODataGridViewTextBoxColumn.Width = 60
        '
        'PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn
        '
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn.HeaderText = "Estimated Unit Cost"
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn.MaxInputLength = 13
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn.Name = "PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn"
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn.Width = 85
        '
        'PRESTIMATEDCOSTDataGridViewTextBoxColumn
        '
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn.HeaderText = "Estimated Cost"
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn.MaxInputLength = 13
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn.Name = "PRESTIMATEDCOSTDataGridViewTextBoxColumn"
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn.Width = 85
        '
        'EDIT
        '
        Me.EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EDIT.HeaderText = ""
        Me.EDIT.Name = "EDIT"
        Me.EDIT.ReadOnly = True
        Me.EDIT.Text = "EDIT"
        Me.EDIT.UseColumnTextForButtonValue = True
        Me.EDIT.Width = 70
        '
        'DELETE
        '
        Me.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DELETE.HeaderText = ""
        Me.DELETE.Name = "DELETE"
        Me.DELETE.ReadOnly = True
        Me.DELETE.Text = "REMOVE"
        Me.DELETE.UseColumnTextForButtonValue = True
        Me.DELETE.Width = 75
        '
        'ShapeContainer6
        '
        Me.ShapeContainer6.Location = New System.Drawing.Point(3, 18)
        Me.ShapeContainer6.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer6.Name = "ShapeContainer6"
        Me.ShapeContainer6.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape6, Me.RectangleShape8, Me.RECT_PRPARTICULARS})
        Me.ShapeContainer6.Size = New System.Drawing.Size(1064, 257)
        Me.ShapeContainer6.TabIndex = 1
        Me.ShapeContainer6.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.CornerRadius = 15
        Me.RectangleShape6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape6.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape6.Location = New System.Drawing.Point(764, 1)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(141, 31)
        Me.RectangleShape6.Visible = False
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape8.BorderWidth = 2
        Me.RectangleShape8.CornerRadius = 15
        Me.RectangleShape8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape8.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape8.Location = New System.Drawing.Point(911, 1)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(151, 31)
        '
        'RECT_PRPARTICULARS
        '
        Me.RECT_PRPARTICULARS.BorderColor = System.Drawing.Color.OrangeRed
        Me.RECT_PRPARTICULARS.BorderWidth = 2
        Me.RECT_PRPARTICULARS.CornerRadius = 5
        Me.RECT_PRPARTICULARS.Location = New System.Drawing.Point(0, 38)
        Me.RECT_PRPARTICULARS.Name = "RECT_PRPARTICULARS"
        Me.RECT_PRPARTICULARS.Size = New System.Drawing.Size(1062, 215)
        Me.RECT_PRPARTICULARS.Visible = False
        '
        'GB_PRINFO
        '
        Me.GB_PRINFO.BackColor = System.Drawing.SystemColors.Window
        Me.GB_PRINFO.Controls.Add(Me.LinkLabel2)
        Me.GB_PRINFO.Controls.Add(Me.RBTN_PESO)
        Me.GB_PRINFO.Controls.Add(Me.RBTN_DOLLARS)
        Me.GB_PRINFO.Controls.Add(Me.Label10)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_SUBMITTEDBY)
        Me.GB_PRINFO.Controls.Add(Me.CB_PRDEPARTMENT)
        Me.GB_PRINFO.Controls.Add(Me.CB_PRDIVISION)
        Me.GB_PRINFO.Controls.Add(Me.Label9)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_PURPOSE)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_APPCODE)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_REQUESTEDDATE)
        Me.GB_PRINFO.Controls.Add(Me.Label12)
        Me.GB_PRINFO.Controls.Add(Me.Label8)
        Me.GB_PRINFO.Controls.Add(Me.Label7)
        Me.GB_PRINFO.Controls.Add(Me.Label6)
        Me.GB_PRINFO.Controls.Add(Me.Label5)
        Me.GB_PRINFO.Controls.Add(Me.PBOX_PRNOQRCODE)
        Me.GB_PRINFO.Controls.Add(Me.ShapeContainer2)
        Me.GB_PRINFO.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_PRINFO.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GB_PRINFO.Location = New System.Drawing.Point(6, 2)
        Me.GB_PRINFO.Name = "GB_PRINFO"
        Me.GB_PRINFO.Size = New System.Drawing.Size(1071, 250)
        Me.GB_PRINFO.TabIndex = 1
        Me.GB_PRINFO.TabStop = False
        Me.GB_PRINFO.Text = "Purchase Request Information"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel2.Enabled = False
        Me.LinkLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.LinkLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel2.Location = New System.Drawing.Point(852, 32)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(73, 17)
        Me.LinkLabel2.TabIndex = 1451
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Paid type:"
        '
        'RBTN_PESO
        '
        Me.RBTN_PESO.AutoSize = True
        Me.RBTN_PESO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTN_PESO.Location = New System.Drawing.Point(953, 50)
        Me.RBTN_PESO.Name = "RBTN_PESO"
        Me.RBTN_PESO.Size = New System.Drawing.Size(55, 20)
        Me.RBTN_PESO.TabIndex = 1450
        Me.RBTN_PESO.TabStop = True
        Me.RBTN_PESO.Text = "Peso"
        Me.RBTN_PESO.UseVisualStyleBackColor = True
        '
        'RBTN_DOLLARS
        '
        Me.RBTN_DOLLARS.AutoSize = True
        Me.RBTN_DOLLARS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTN_DOLLARS.Location = New System.Drawing.Point(875, 50)
        Me.RBTN_DOLLARS.Name = "RBTN_DOLLARS"
        Me.RBTN_DOLLARS.Size = New System.Drawing.Size(71, 20)
        Me.RBTN_DOLLARS.TabIndex = 1449
        Me.RBTN_DOLLARS.TabStop = True
        Me.RBTN_DOLLARS.Text = "Dollars"
        Me.RBTN_DOLLARS.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(1029, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 19)
        Me.Label10.TabIndex = 1431
        Me.Label10.Text = "*"
        '
        'WTXT_SUBMITTEDBY
        '
        Me.WTXT_SUBMITTEDBY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SUBMITTEDBY.Location = New System.Drawing.Point(417, 49)
        Me.WTXT_SUBMITTEDBY.MaxLength = 50
        Me.WTXT_SUBMITTEDBY.Name = "WTXT_SUBMITTEDBY"
        Me.WTXT_SUBMITTEDBY.ReadOnly = True
        Me.WTXT_SUBMITTEDBY.Size = New System.Drawing.Size(416, 21)
        Me.WTXT_SUBMITTEDBY.TabIndex = 1417
        Me.WTXT_SUBMITTEDBY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SUBMITTEDBY.Watermark = Nothing
        '
        'CB_PRDEPARTMENT
        '
        Me.CB_PRDEPARTMENT.DataSource = Me.TblV1_HRISDEPARTMENTBindingSource
        Me.CB_PRDEPARTMENT.DisplayMember = "HDPT_DEPARTMENT"
        Me.CB_PRDEPARTMENT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PRDEPARTMENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_PRDEPARTMENT.FormattingEnabled = True
        Me.CB_PRDEPARTMENT.Location = New System.Drawing.Point(31, 95)
        Me.CB_PRDEPARTMENT.Name = "CB_PRDEPARTMENT"
        Me.CB_PRDEPARTMENT.Size = New System.Drawing.Size(468, 27)
        Me.CB_PRDEPARTMENT.TabIndex = 1
        Me.CB_PRDEPARTMENT.ValueMember = "HDPT_CODE"
        '
        'TblV1_HRISDEPARTMENTBindingSource
        '
        Me.TblV1_HRISDEPARTMENTBindingSource.DataMember = "tblV1_HRISDEPARTMENT"
        Me.TblV1_HRISDEPARTMENTBindingSource.DataSource = Me.DS_TABLES
        '
        'CB_PRDIVISION
        '
        Me.CB_PRDIVISION.DataSource = Me.TblV1_HRISDIVISIONBindingSource
        Me.CB_PRDIVISION.DisplayMember = "HDIV_DIVISION"
        Me.CB_PRDIVISION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PRDIVISION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_PRDIVISION.FormattingEnabled = True
        Me.CB_PRDIVISION.Location = New System.Drawing.Point(517, 96)
        Me.CB_PRDIVISION.Name = "CB_PRDIVISION"
        Me.CB_PRDIVISION.Size = New System.Drawing.Size(525, 27)
        Me.CB_PRDIVISION.TabIndex = 0
        Me.CB_PRDIVISION.ValueMember = "HDIVS_CODE"
        '
        'TblV1_HRISDIVISIONBindingSource
        '
        Me.TblV1_HRISDIVISIONBindingSource.DataMember = "tblV1_HRISDIVISION"
        Me.TblV1_HRISDIVISIONBindingSource.DataSource = Me.DS_TABLES
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(429, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 1405
        Me.Label9.Text = "SUBMITTED BY"
        '
        'WTXT_PURPOSE
        '
        Me.WTXT_PURPOSE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PURPOSE.Location = New System.Drawing.Point(34, 149)
        Me.WTXT_PURPOSE.MaxLength = 300
        Me.WTXT_PURPOSE.Multiline = True
        Me.WTXT_PURPOSE.Name = "WTXT_PURPOSE"
        Me.WTXT_PURPOSE.Size = New System.Drawing.Size(1008, 82)
        Me.WTXT_PURPOSE.TabIndex = 1417
        Me.WTXT_PURPOSE.Watermark = Nothing
        '
        'WTXT_APPCODE
        '
        Me.WTXT_APPCODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_APPCODE.Location = New System.Drawing.Point(31, 50)
        Me.WTXT_APPCODE.MaxLength = 15
        Me.WTXT_APPCODE.Name = "WTXT_APPCODE"
        Me.WTXT_APPCODE.Size = New System.Drawing.Size(217, 21)
        Me.WTXT_APPCODE.TabIndex = 1427
        Me.WTXT_APPCODE.Watermark = Nothing
        '
        'WTXT_REQUESTEDDATE
        '
        Me.WTXT_REQUESTEDDATE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_REQUESTEDDATE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4CURRENTDATETIMEBindingSource, "datenow", True))
        Me.WTXT_REQUESTEDDATE.Location = New System.Drawing.Point(266, 49)
        Me.WTXT_REQUESTEDDATE.Name = "WTXT_REQUESTEDDATE"
        Me.WTXT_REQUESTEDDATE.ReadOnly = True
        Me.WTXT_REQUESTEDDATE.Size = New System.Drawing.Size(133, 21)
        Me.WTXT_REQUESTEDDATE.TabIndex = 1417
        Me.WTXT_REQUESTEDDATE.Watermark = Nothing
        '
        'SPM4CURRENTDATETIMEBindingSource
        '
        Me.SPM4CURRENTDATETIMEBindingSource.DataMember = "SPM4_CURRENTDATETIME"
        Me.SPM4CURRENTDATETIMEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(37, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 17)
        Me.Label12.TabIndex = 1409
        Me.Label12.Text = "PURPOSE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(37, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 1340
        Me.Label8.Text = "APP CODE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(514, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 1339
        Me.Label7.Text = "DIVISION/UNIT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(37, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 1335
        Me.Label6.Text = "DEPARTMENT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(274, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 1334
        Me.Label5.Text = "REQUESTED DATE"
        '
        'PBOX_PRNOQRCODE
        '
        Me.PBOX_PRNOQRCODE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBOX_PRNOQRCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBOX_PRNOQRCODE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBOX_PRNOQRCODE.Location = New System.Drawing.Point(1504, 55)
        Me.PBOX_PRNOQRCODE.Name = "PBOX_PRNOQRCODE"
        Me.PBOX_PRNOQRCODE.Size = New System.Drawing.Size(145, 145)
        Me.PBOX_PRNOQRCODE.TabIndex = 0
        Me.PBOX_PRNOQRCODE.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 24)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape9, Me.RectangleShape7, Me.RECT_PRPURPOSE, Me.RECT_PRAPPCODE, Me.RectangleShape5, Me.RectangleShape4, Me.RECT_PRREQUESTEDDATE})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1065, 223)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape9.BorderWidth = 2
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.Location = New System.Drawing.Point(839, 19)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(205, 32)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape7.BorderWidth = 2
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(409, 19)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(427, 32)
        '
        'RECT_PRPURPOSE
        '
        Me.RECT_PRPURPOSE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRPURPOSE.BorderWidth = 2
        Me.RECT_PRPURPOSE.CornerRadius = 5
        Me.RECT_PRPURPOSE.Location = New System.Drawing.Point(23, 113)
        Me.RECT_PRPURPOSE.Name = "RECT_PRPURPOSE"
        Me.RECT_PRPURPOSE.Size = New System.Drawing.Size(1022, 101)
        '
        'RECT_PRAPPCODE
        '
        Me.RECT_PRAPPCODE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRAPPCODE.BorderWidth = 2
        Me.RECT_PRAPPCODE.CornerRadius = 5
        Me.RECT_PRAPPCODE.Location = New System.Drawing.Point(23, 19)
        Me.RECT_PRAPPCODE.Name = "RECT_PRAPPCODE"
        Me.RECT_PRAPPCODE.Size = New System.Drawing.Size(226, 32)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Location = New System.Drawing.Point(507, 68)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(537, 32)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(23, 68)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(477, 32)
        '
        'RECT_PRREQUESTEDDATE
        '
        Me.RECT_PRREQUESTEDDATE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRREQUESTEDDATE.BorderWidth = 2
        Me.RECT_PRREQUESTEDDATE.CornerRadius = 5
        Me.RECT_PRREQUESTEDDATE.Location = New System.Drawing.Point(258, 19)
        Me.RECT_PRREQUESTEDDATE.Name = "RECT_PRREQUESTEDDATE"
        Me.RECT_PRREQUESTEDDATE.Size = New System.Drawing.Size(142, 32)
        '
        'TPPRSIGNATORY
        '
        Me.TPPRSIGNATORY.Controls.Add(Me.PanelSignatory)
        Me.TPPRSIGNATORY.Location = New System.Drawing.Point(4, 26)
        Me.TPPRSIGNATORY.Name = "TPPRSIGNATORY"
        Me.TPPRSIGNATORY.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPRSIGNATORY.Size = New System.Drawing.Size(1094, 536)
        Me.TPPRSIGNATORY.TabIndex = 1
        Me.TPPRSIGNATORY.Text = "Signatory"
        Me.TPPRSIGNATORY.UseVisualStyleBackColor = True
        '
        'PanelSignatory
        '
        Me.PanelSignatory.Controls.Add(Me.TXT_PRNOTEDID)
        Me.PanelSignatory.Controls.Add(Me.TXT_PRCERTIFIEDID)
        Me.PanelSignatory.Controls.Add(Me.TXT_PRRAPPROVEDID)
        Me.PanelSignatory.Controls.Add(Me.TXT_PRREQUESTEDID)
        Me.PanelSignatory.Controls.Add(Me.PB_SAVEICONSAVEDEFAULT)
        Me.PanelSignatory.Controls.Add(Me.LLBL_SAVEDEFAULT)
        Me.PanelSignatory.Controls.Add(Me.Label24)
        Me.PanelSignatory.Controls.Add(Me.WTXT_SIGNNOTEDPOSITION)
        Me.PanelSignatory.Controls.Add(Me.Label1)
        Me.PanelSignatory.Controls.Add(Me.WTXT_SIGNNOTEDNAME)
        Me.PanelSignatory.Controls.Add(Me.Label4)
        Me.PanelSignatory.Controls.Add(Me.WTXT_SIGNCERTIFIEDPOSITION)
        Me.PanelSignatory.Controls.Add(Me.Label21)
        Me.PanelSignatory.Controls.Add(Me.WTXT_SIGNCERTIFIEDNAME)
        Me.PanelSignatory.Controls.Add(Me.Label23)
        Me.PanelSignatory.Controls.Add(Me.WTXT_SIGNAPPROVEPOSITION)
        Me.PanelSignatory.Controls.Add(Me.Label27)
        Me.PanelSignatory.Controls.Add(Me.WTXT_SIGNAPPROVENAME)
        Me.PanelSignatory.Controls.Add(Me.Label18)
        Me.PanelSignatory.Controls.Add(Me.WTXT_SIGNREQUESTEDPOSITION)
        Me.PanelSignatory.Controls.Add(Me.Label3)
        Me.PanelSignatory.Controls.Add(Me.WTXT_SIGNREQUESTEDNAME)
        Me.PanelSignatory.Controls.Add(Me.Label19)
        Me.PanelSignatory.Controls.Add(Me.Label22)
        Me.PanelSignatory.Controls.Add(Me.Label2)
        Me.PanelSignatory.Controls.Add(Me.Label26)
        Me.PanelSignatory.Controls.Add(Me.Label25)
        Me.PanelSignatory.Controls.Add(Me.ShapeContainer4)
        Me.PanelSignatory.Enabled = False
        Me.PanelSignatory.Location = New System.Drawing.Point(6, 6)
        Me.PanelSignatory.Name = "PanelSignatory"
        Me.PanelSignatory.Size = New System.Drawing.Size(1080, 522)
        Me.PanelSignatory.TabIndex = 1435
        '
        'TXT_PRNOTEDID
        '
        Me.TXT_PRNOTEDID.Location = New System.Drawing.Point(2014, 361)
        Me.TXT_PRNOTEDID.Name = "TXT_PRNOTEDID"
        Me.TXT_PRNOTEDID.Size = New System.Drawing.Size(34, 23)
        Me.TXT_PRNOTEDID.TabIndex = 1439
        Me.TXT_PRNOTEDID.Visible = False
        '
        'TXT_PRCERTIFIEDID
        '
        Me.TXT_PRCERTIFIEDID.Location = New System.Drawing.Point(2014, 361)
        Me.TXT_PRCERTIFIEDID.Name = "TXT_PRCERTIFIEDID"
        Me.TXT_PRCERTIFIEDID.Size = New System.Drawing.Size(34, 23)
        Me.TXT_PRCERTIFIEDID.TabIndex = 1438
        Me.TXT_PRCERTIFIEDID.Visible = False
        '
        'TXT_PRRAPPROVEDID
        '
        Me.TXT_PRRAPPROVEDID.Location = New System.Drawing.Point(2014, 361)
        Me.TXT_PRRAPPROVEDID.Name = "TXT_PRRAPPROVEDID"
        Me.TXT_PRRAPPROVEDID.Size = New System.Drawing.Size(34, 23)
        Me.TXT_PRRAPPROVEDID.TabIndex = 1437
        Me.TXT_PRRAPPROVEDID.Visible = False
        '
        'TXT_PRREQUESTEDID
        '
        Me.TXT_PRREQUESTEDID.Location = New System.Drawing.Point(2014, 361)
        Me.TXT_PRREQUESTEDID.Name = "TXT_PRREQUESTEDID"
        Me.TXT_PRREQUESTEDID.Size = New System.Drawing.Size(34, 23)
        Me.TXT_PRREQUESTEDID.TabIndex = 1436
        Me.TXT_PRREQUESTEDID.Visible = False
        '
        'PB_SAVEICONSAVEDEFAULT
        '
        Me.PB_SAVEICONSAVEDEFAULT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_save_black_18dp
        Me.PB_SAVEICONSAVEDEFAULT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_SAVEICONSAVEDEFAULT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_SAVEICONSAVEDEFAULT.Enabled = False
        Me.PB_SAVEICONSAVEDEFAULT.InitialImage = Nothing
        Me.PB_SAVEICONSAVEDEFAULT.Location = New System.Drawing.Point(881, 481)
        Me.PB_SAVEICONSAVEDEFAULT.Name = "PB_SAVEICONSAVEDEFAULT"
        Me.PB_SAVEICONSAVEDEFAULT.Size = New System.Drawing.Size(32, 28)
        Me.PB_SAVEICONSAVEDEFAULT.TabIndex = 1425
        Me.PB_SAVEICONSAVEDEFAULT.TabStop = False
        '
        'LLBL_SAVEDEFAULT
        '
        Me.LLBL_SAVEDEFAULT.AutoSize = True
        Me.LLBL_SAVEDEFAULT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_SAVEDEFAULT.Enabled = False
        Me.LLBL_SAVEDEFAULT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_SAVEDEFAULT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVEDEFAULT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_SAVEDEFAULT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVEDEFAULT.Location = New System.Drawing.Point(916, 486)
        Me.LLBL_SAVEDEFAULT.Name = "LLBL_SAVEDEFAULT"
        Me.LLBL_SAVEDEFAULT.Size = New System.Drawing.Size(132, 19)
        Me.LLBL_SAVEDEFAULT.TabIndex = 1426
        Me.LLBL_SAVEDEFAULT.TabStop = True
        Me.LLBL_SAVEDEFAULT.Text = "SET AS DEFAULT"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DimGray
        Me.Label24.Location = New System.Drawing.Point(383, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(221, 25)
        Me.Label24.TabIndex = 1414
        Me.Label24.Text = "DEFAULT SIGNATORY"
        '
        'WTXT_SIGNNOTEDPOSITION
        '
        Me.WTXT_SIGNNOTEDPOSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNNOTEDPOSITION.Location = New System.Drawing.Point(266, 456)
        Me.WTXT_SIGNNOTEDPOSITION.Name = "WTXT_SIGNNOTEDPOSITION"
        Me.WTXT_SIGNNOTEDPOSITION.ReadOnly = True
        Me.WTXT_SIGNNOTEDPOSITION.Size = New System.Drawing.Size(450, 16)
        Me.WTXT_SIGNNOTEDPOSITION.TabIndex = 1434
        Me.WTXT_SIGNNOTEDPOSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNNOTEDPOSITION.Watermark = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(433, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 1333
        Me.Label1.Text = "REQUESTED BY"
        '
        'WTXT_SIGNNOTEDNAME
        '
        Me.WTXT_SIGNNOTEDNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNNOTEDNAME.Location = New System.Drawing.Point(266, 403)
        Me.WTXT_SIGNNOTEDNAME.Name = "WTXT_SIGNNOTEDNAME"
        Me.WTXT_SIGNNOTEDNAME.ReadOnly = True
        Me.WTXT_SIGNNOTEDNAME.Size = New System.Drawing.Size(450, 16)
        Me.WTXT_SIGNNOTEDNAME.TabIndex = 1433
        Me.WTXT_SIGNNOTEDNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNNOTEDNAME.Watermark = Nothing
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(433, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 1340
        Me.Label4.Text = "APPROVED BY"
        '
        'WTXT_SIGNCERTIFIEDPOSITION
        '
        Me.WTXT_SIGNCERTIFIEDPOSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNCERTIFIEDPOSITION.Location = New System.Drawing.Point(267, 332)
        Me.WTXT_SIGNCERTIFIEDPOSITION.Name = "WTXT_SIGNCERTIFIEDPOSITION"
        Me.WTXT_SIGNCERTIFIEDPOSITION.ReadOnly = True
        Me.WTXT_SIGNCERTIFIEDPOSITION.Size = New System.Drawing.Size(450, 16)
        Me.WTXT_SIGNCERTIFIEDPOSITION.TabIndex = 1432
        Me.WTXT_SIGNCERTIFIEDPOSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNCERTIFIEDPOSITION.Watermark = Nothing
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(433, 359)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 16)
        Me.Label21.TabIndex = 1406
        Me.Label21.Text = "CERTIFIED BY"
        '
        'WTXT_SIGNCERTIFIEDNAME
        '
        Me.WTXT_SIGNCERTIFIEDNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNCERTIFIEDNAME.Location = New System.Drawing.Point(266, 283)
        Me.WTXT_SIGNCERTIFIEDNAME.Name = "WTXT_SIGNCERTIFIEDNAME"
        Me.WTXT_SIGNCERTIFIEDNAME.ReadOnly = True
        Me.WTXT_SIGNCERTIFIEDNAME.Size = New System.Drawing.Size(450, 16)
        Me.WTXT_SIGNCERTIFIEDNAME.TabIndex = 1431
        Me.WTXT_SIGNCERTIFIEDNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNCERTIFIEDNAME.Watermark = Nothing
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(444, 483)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 16)
        Me.Label23.TabIndex = 1408
        Me.Label23.Text = "NOTED BY"
        '
        'WTXT_SIGNAPPROVEPOSITION
        '
        Me.WTXT_SIGNAPPROVEPOSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNAPPROVEPOSITION.Location = New System.Drawing.Point(266, 208)
        Me.WTXT_SIGNAPPROVEPOSITION.Name = "WTXT_SIGNAPPROVEPOSITION"
        Me.WTXT_SIGNAPPROVEPOSITION.ReadOnly = True
        Me.WTXT_SIGNAPPROVEPOSITION.Size = New System.Drawing.Size(450, 16)
        Me.WTXT_SIGNAPPROVEPOSITION.TabIndex = 1430
        Me.WTXT_SIGNAPPROVEPOSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNAPPROVEPOSITION.Watermark = Nothing
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DimGray
        Me.Label27.Location = New System.Drawing.Point(269, 32)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 17)
        Me.Label27.TabIndex = 1418
        Me.Label27.Text = "NAME"
        '
        'WTXT_SIGNAPPROVENAME
        '
        Me.WTXT_SIGNAPPROVENAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNAPPROVENAME.Location = New System.Drawing.Point(266, 163)
        Me.WTXT_SIGNAPPROVENAME.Name = "WTXT_SIGNAPPROVENAME"
        Me.WTXT_SIGNAPPROVENAME.ReadOnly = True
        Me.WTXT_SIGNAPPROVENAME.Size = New System.Drawing.Size(450, 16)
        Me.WTXT_SIGNAPPROVENAME.TabIndex = 1429
        Me.WTXT_SIGNAPPROVENAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNAPPROVENAME.Watermark = Nothing
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(269, 82)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 17)
        Me.Label18.TabIndex = 1338
        Me.Label18.Text = "POSITION"
        '
        'WTXT_SIGNREQUESTEDPOSITION
        '
        Me.WTXT_SIGNREQUESTEDPOSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNREQUESTEDPOSITION.Location = New System.Drawing.Point(266, 98)
        Me.WTXT_SIGNREQUESTEDPOSITION.Name = "WTXT_SIGNREQUESTEDPOSITION"
        Me.WTXT_SIGNREQUESTEDPOSITION.ReadOnly = True
        Me.WTXT_SIGNREQUESTEDPOSITION.Size = New System.Drawing.Size(450, 16)
        Me.WTXT_SIGNREQUESTEDPOSITION.TabIndex = 1428
        Me.WTXT_SIGNREQUESTEDPOSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNREQUESTEDPOSITION.Watermark = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(269, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 1341
        Me.Label3.Text = "POSITION"
        '
        'WTXT_SIGNREQUESTEDNAME
        '
        Me.WTXT_SIGNREQUESTEDNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNREQUESTEDNAME.Location = New System.Drawing.Point(266, 53)
        Me.WTXT_SIGNREQUESTEDNAME.Name = "WTXT_SIGNREQUESTEDNAME"
        Me.WTXT_SIGNREQUESTEDNAME.ReadOnly = True
        Me.WTXT_SIGNREQUESTEDNAME.Size = New System.Drawing.Size(450, 16)
        Me.WTXT_SIGNREQUESTEDNAME.TabIndex = 1427
        Me.WTXT_SIGNREQUESTEDNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNREQUESTEDNAME.Watermark = Nothing
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(269, 315)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 17)
        Me.Label19.TabIndex = 1407
        Me.Label19.Text = "POSITION"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DimGray
        Me.Label22.Location = New System.Drawing.Point(269, 439)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 17)
        Me.Label22.TabIndex = 1409
        Me.Label22.Text = "POSITION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(269, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1415
        Me.Label2.Text = "NAME"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DimGray
        Me.Label26.Location = New System.Drawing.Point(269, 142)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 17)
        Me.Label26.TabIndex = 1417
        Me.Label26.Text = "NAME"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DimGray
        Me.Label25.Location = New System.Drawing.Point(269, 263)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 17)
        Me.Label25.TabIndex = 1416
        Me.Label25.Text = "NAME"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape17, Me.RECT_PRSIGNNOTEDPOSITION, Me.RECT_PRSIGNNOTEDNAME, Me.RECT_PRSIGNCERTIFIEDPOSITION, Me.RECT_PRSIGNCERTIFIEDNAME, Me.RECT_PRSIGNAPPROVEDNAME, Me.RECT_PRSIGNAPPROVEPOSITION, Me.RECT_PRSIGNREQUESTEDPOSITION, Me.RECT_PRSIGNREQUESTEDNAME})
        Me.ShapeContainer4.Size = New System.Drawing.Size(1080, 522)
        Me.ShapeContainer4.TabIndex = 1435
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape17
        '
        Me.RectangleShape17.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape17.BorderWidth = 2
        Me.RectangleShape17.CornerRadius = 19
        Me.RectangleShape17.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape17.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape17.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape17.Location = New System.Drawing.Point(869, 475)
        Me.RectangleShape17.Name = "RectangleShape17"
        Me.RectangleShape17.Size = New System.Drawing.Size(184, 39)
        '
        'RECT_PRSIGNNOTEDPOSITION
        '
        Me.RECT_PRSIGNNOTEDPOSITION.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSIGNNOTEDPOSITION.BorderWidth = 2
        Me.RECT_PRSIGNNOTEDPOSITION.CornerRadius = 5
        Me.RECT_PRSIGNNOTEDPOSITION.Location = New System.Drawing.Point(260, 447)
        Me.RECT_PRSIGNNOTEDPOSITION.Name = "RECT_PRSIGNNOTEDPOSITION"
        Me.RECT_PRSIGNNOTEDPOSITION.Size = New System.Drawing.Size(461, 32)
        '
        'RECT_PRSIGNNOTEDNAME
        '
        Me.RECT_PRSIGNNOTEDNAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSIGNNOTEDNAME.BorderWidth = 2
        Me.RECT_PRSIGNNOTEDNAME.CornerRadius = 5
        Me.RECT_PRSIGNNOTEDNAME.Location = New System.Drawing.Point(260, 393)
        Me.RECT_PRSIGNNOTEDNAME.Name = "RECT_PRSIGNNOTEDNAME"
        Me.RECT_PRSIGNNOTEDNAME.Size = New System.Drawing.Size(461, 32)
        '
        'RECT_PRSIGNCERTIFIEDPOSITION
        '
        Me.RECT_PRSIGNCERTIFIEDPOSITION.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSIGNCERTIFIEDPOSITION.BorderWidth = 2
        Me.RECT_PRSIGNCERTIFIEDPOSITION.CornerRadius = 5
        Me.RECT_PRSIGNCERTIFIEDPOSITION.Location = New System.Drawing.Point(260, 322)
        Me.RECT_PRSIGNCERTIFIEDPOSITION.Name = "RECT_PRSIGNCERTIFIEDPOSITION"
        Me.RECT_PRSIGNCERTIFIEDPOSITION.Size = New System.Drawing.Size(461, 32)
        '
        'RECT_PRSIGNCERTIFIEDNAME
        '
        Me.RECT_PRSIGNCERTIFIEDNAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSIGNCERTIFIEDNAME.BorderWidth = 2
        Me.RECT_PRSIGNCERTIFIEDNAME.CornerRadius = 5
        Me.RECT_PRSIGNCERTIFIEDNAME.Location = New System.Drawing.Point(260, 273)
        Me.RECT_PRSIGNCERTIFIEDNAME.Name = "RECT_PRSIGNCERTIFIEDNAME"
        Me.RECT_PRSIGNCERTIFIEDNAME.Size = New System.Drawing.Size(461, 32)
        '
        'RECT_PRSIGNAPPROVEDNAME
        '
        Me.RECT_PRSIGNAPPROVEDNAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSIGNAPPROVEDNAME.BorderWidth = 2
        Me.RECT_PRSIGNAPPROVEDNAME.CornerRadius = 5
        Me.RECT_PRSIGNAPPROVEDNAME.Location = New System.Drawing.Point(260, 155)
        Me.RECT_PRSIGNAPPROVEDNAME.Name = "RECT_PRSIGNAPPROVEDNAME"
        Me.RECT_PRSIGNAPPROVEDNAME.Size = New System.Drawing.Size(461, 32)
        '
        'RECT_PRSIGNAPPROVEPOSITION
        '
        Me.RECT_PRSIGNAPPROVEPOSITION.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSIGNAPPROVEPOSITION.BorderWidth = 2
        Me.RECT_PRSIGNAPPROVEPOSITION.CornerRadius = 5
        Me.RECT_PRSIGNAPPROVEPOSITION.Location = New System.Drawing.Point(260, 199)
        Me.RECT_PRSIGNAPPROVEPOSITION.Name = "RECT_PRSIGNAPPROVEPOSITION"
        Me.RECT_PRSIGNAPPROVEPOSITION.Size = New System.Drawing.Size(461, 32)
        '
        'RECT_PRSIGNREQUESTEDPOSITION
        '
        Me.RECT_PRSIGNREQUESTEDPOSITION.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSIGNREQUESTEDPOSITION.BorderWidth = 2
        Me.RECT_PRSIGNREQUESTEDPOSITION.CornerRadius = 5
        Me.RECT_PRSIGNREQUESTEDPOSITION.Location = New System.Drawing.Point(260, 89)
        Me.RECT_PRSIGNREQUESTEDPOSITION.Name = "RECT_PRSIGNREQUESTEDPOSITION"
        Me.RECT_PRSIGNREQUESTEDPOSITION.Size = New System.Drawing.Size(461, 32)
        '
        'RECT_PRSIGNREQUESTEDNAME
        '
        Me.RECT_PRSIGNREQUESTEDNAME.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSIGNREQUESTEDNAME.BorderWidth = 2
        Me.RECT_PRSIGNREQUESTEDNAME.CornerRadius = 5
        Me.RECT_PRSIGNREQUESTEDNAME.Location = New System.Drawing.Point(260, 44)
        Me.RECT_PRSIGNREQUESTEDNAME.Name = "RECT_PRSIGNREQUESTEDNAME"
        Me.RECT_PRSIGNREQUESTEDNAME.Size = New System.Drawing.Size(461, 32)
        '
        'LLBL_PREDIT
        '
        Me.LLBL_PREDIT.AutoSize = True
        Me.LLBL_PREDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PREDIT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_PREDIT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PREDIT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PREDIT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PREDIT.Location = New System.Drawing.Point(167, 15)
        Me.LLBL_PREDIT.Name = "LLBL_PREDIT"
        Me.LLBL_PREDIT.Size = New System.Drawing.Size(42, 19)
        Me.LLBL_PREDIT.TabIndex = 1414
        Me.LLBL_PREDIT.TabStop = True
        Me.LLBL_PREDIT.Text = "EDIT"
        '
        'SQDGV_PURCHASEREQUESTDataGridView
        '
        Me.SQDGV_PURCHASEREQUESTDataGridView.AllowUserToAddRows = False
        Me.SQDGV_PURCHASEREQUESTDataGridView.AllowUserToDeleteRows = False
        Me.SQDGV_PURCHASEREQUESTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SQDGV_PURCHASEREQUESTDataGridView.Location = New System.Drawing.Point(2005, 24)
        Me.SQDGV_PURCHASEREQUESTDataGridView.Name = "SQDGV_PURCHASEREQUESTDataGridView"
        Me.SQDGV_PURCHASEREQUESTDataGridView.ReadOnly = True
        Me.SQDGV_PURCHASEREQUESTDataGridView.Size = New System.Drawing.Size(388, 93)
        Me.SQDGV_PURCHASEREQUESTDataGridView.TabIndex = 0
        '
        'PB_PRICONNEW
        '
        Me.PB_PRICONNEW.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_post_add_black_24dp
        Me.PB_PRICONNEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PRICONNEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PRICONNEW.InitialImage = Nothing
        Me.PB_PRICONNEW.Location = New System.Drawing.Point(21, 10)
        Me.PB_PRICONNEW.Name = "PB_PRICONNEW"
        Me.PB_PRICONNEW.Size = New System.Drawing.Size(32, 28)
        Me.PB_PRICONNEW.TabIndex = 1409
        Me.PB_PRICONNEW.TabStop = False
        '
        'PB_PBICONEDIT
        '
        Me.PB_PBICONEDIT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_edit_black_24dp
        Me.PB_PBICONEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_PBICONEDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_PBICONEDIT.InitialImage = Nothing
        Me.PB_PBICONEDIT.Location = New System.Drawing.Point(131, 10)
        Me.PB_PBICONEDIT.Name = "PB_PBICONEDIT"
        Me.PB_PBICONEDIT.Size = New System.Drawing.Size(32, 28)
        Me.PB_PBICONEDIT.TabIndex = 1410
        Me.PB_PBICONEDIT.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1, Me.RECT_PRCANCELEDIT, Me.RECT_PRSAVENEW})
        Me.ShapeContainer3.Size = New System.Drawing.Size(1089, 616)
        Me.ShapeContainer3.TabIndex = 2
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.CornerRadius = 19
        Me.RectangleShape3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape3.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(873, 6)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(201, 39)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.CornerRadius = 19
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape2.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(354, 4)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(107, 39)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 19
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(119, 4)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(103, 39)
        '
        'RECT_PRCANCELEDIT
        '
        Me.RECT_PRCANCELEDIT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRCANCELEDIT.BorderWidth = 2
        Me.RECT_PRCANCELEDIT.CornerRadius = 19
        Me.RECT_PRCANCELEDIT.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRCANCELEDIT.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRCANCELEDIT.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRCANCELEDIT.Location = New System.Drawing.Point(228, 4)
        Me.RECT_PRCANCELEDIT.Name = "RECT_PRCANCELEDIT"
        Me.RECT_PRCANCELEDIT.Size = New System.Drawing.Size(121, 39)
        '
        'RECT_PRSAVENEW
        '
        Me.RECT_PRSAVENEW.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_PRSAVENEW.BorderWidth = 2
        Me.RECT_PRSAVENEW.CornerRadius = 19
        Me.RECT_PRSAVENEW.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_PRSAVENEW.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_PRSAVENEW.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_PRSAVENEW.Location = New System.Drawing.Point(10, 4)
        Me.RECT_PRSAVENEW.Name = "RECT_PRSAVENEW"
        Me.RECT_PRSAVENEW.Size = New System.Drawing.Size(103, 39)
        '
        'WTXT_TDNUM
        '
        Me.WTXT_TDNUM.AutoSize = True
        Me.WTXT_TDNUM.Location = New System.Drawing.Point(1457, 588)
        Me.WTXT_TDNUM.Name = "WTXT_TDNUM"
        Me.WTXT_TDNUM.Size = New System.Drawing.Size(74, 21)
        Me.WTXT_TDNUM.TabIndex = 1430
        Me.WTXT_TDNUM.Text = "Label29"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(1522, 614)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 21)
        Me.Label28.TabIndex = 1429
        Me.Label28.Text = "Label28"
        '
        'LBL_SCANNERNAME
        '
        Me.LBL_SCANNERNAME.AutoSize = True
        Me.LBL_SCANNERNAME.Location = New System.Drawing.Point(1399, 614)
        Me.LBL_SCANNERNAME.Name = "LBL_SCANNERNAME"
        Me.LBL_SCANNERNAME.Size = New System.Drawing.Size(74, 21)
        Me.LBL_SCANNERNAME.TabIndex = 2
        Me.LBL_SCANNERNAME.Text = "Label28"
        '
        'cbxSources
        '
        Me.cbxSources.FormattingEnabled = True
        Me.cbxSources.Location = New System.Drawing.Point(1611, 590)
        Me.cbxSources.Name = "cbxSources"
        Me.cbxSources.Size = New System.Drawing.Size(121, 29)
        Me.cbxSources.TabIndex = 1428
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(1148, 614)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 16)
        Me.Label11.TabIndex = 1408
        Me.Label11.Text = "ATTACHMENT"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_attachment_black_18dp
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(1247, 611)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 24)
        Me.PictureBox2.TabIndex = 1407
        Me.PictureBox2.TabStop = False
        '
        'RectangleShape11
        '
        Me.RectangleShape11.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape11.BorderWidth = 2
        Me.RectangleShape11.CornerRadius = 15
        Me.RectangleShape11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape11.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape11.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape11.Location = New System.Drawing.Point(1161, 604)
        Me.RectangleShape11.Name = "RectangleShape11"
        Me.RectangleShape11.Size = New System.Drawing.Size(133, 30)
        '
        'VWG3_PRIMARY_SIGNATORYDataGridView
        '
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.AutoGenerateColumns = False
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.DataSource = Me.VWG3_PRIMARY_SIGNATORYBindingSource
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.Location = New System.Drawing.Point(1111, 111)
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.Name = "VWG3_PRIMARY_SIGNATORYDataGridView"
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.VWG3_PRIMARY_SIGNATORYDataGridView.TabIndex = 1406
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SIG_OFFICE_ORDER"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SIG_OFFICE_ORDER"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SIG_POLICY"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SIG_POLICY"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SIG_AMOUNT"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SIG_AMOUNT"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SIG_STATUS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "SIG_STATUS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "HDIVS_CODE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "HDIVS_CODE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SIG_TY_NO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "SIG_TY_NO"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "HRIS_EMPNO_USER"
        Me.DataGridViewTextBoxColumn11.HeaderText = "HRIS_EMPNO_USER"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "HRIS_EMPNO_SIG"
        Me.DataGridViewTextBoxColumn12.HeaderText = "HRIS_EMPNO_SIG"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'VWG3_PRIMARY_SIGNATORYBindingSource
        '
        Me.VWG3_PRIMARY_SIGNATORYBindingSource.DataMember = "VWG3_PRIMARY_SIGNATORY"
        Me.VWG3_PRIMARY_SIGNATORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_PURCHASEREQUEST_ITEMDataGridView
        '
        Me.TblM4_PURCHASEREQUEST_ITEMDataGridView.AutoGenerateColumns = False
        Me.TblM4_PURCHASEREQUEST_ITEMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblM4_PURCHASEREQUEST_ITEMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.TblM4_PURCHASEREQUEST_ITEMDataGridView.DataSource = Me.TblM4_PURCHASEREQUEST_ITEMBindingSource
        Me.TblM4_PURCHASEREQUEST_ITEMDataGridView.Location = New System.Drawing.Point(1111, 371)
        Me.TblM4_PURCHASEREQUEST_ITEMDataGridView.Name = "TblM4_PURCHASEREQUEST_ITEMDataGridView"
        Me.TblM4_PURCHASEREQUEST_ITEMDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblM4_PURCHASEREQUEST_ITEMDataGridView.TabIndex = 1406
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PRI_ITEMNO"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PRI_ITEMNO"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "PR_QUANTITY"
        Me.DataGridViewTextBoxColumn15.HeaderText = "PR_QUANTITY"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "PR_UNITISSUE"
        Me.DataGridViewTextBoxColumn16.HeaderText = "PR_UNITISSUE"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PRI_ITEMDESCRIPTION"
        Me.DataGridViewTextBoxColumn17.HeaderText = "PRI_ITEMDESCRIPTION"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PR_STOCKNO"
        Me.DataGridViewTextBoxColumn18.HeaderText = "PR_STOCKNO"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PR_ESTIMATEDUNITCOST"
        Me.DataGridViewTextBoxColumn19.HeaderText = "PR_ESTIMATEDUNITCOST"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "PR_ESTIMATEDCOST"
        Me.DataGridViewTextBoxColumn20.HeaderText = "PR_ESTIMATEDCOST"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'TblM4_PURCHASEREQUEST_ITEMBindingSource
        '
        Me.TblM4_PURCHASEREQUEST_ITEMBindingSource.DataMember = "tblM4_PURCHASEREQUEST_ITEM"
        Me.TblM4_PURCHASEREQUEST_ITEMBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DGV_SCANNED_IMG
        '
        Me.DGV_SCANNED_IMG.AllowUserToAddRows = False
        Me.DGV_SCANNED_IMG.AllowUserToDeleteRows = False
        Me.DGV_SCANNED_IMG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DGV_SCANNED_IMG.BackgroundColor = System.Drawing.Color.White
        Me.DGV_SCANNED_IMG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SCANNED_IMG.ColumnHeadersVisible = False
        Me.DGV_SCANNED_IMG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SCANNED_IMG})
        Me.DGV_SCANNED_IMG.Location = New System.Drawing.Point(1417, 114)
        Me.DGV_SCANNED_IMG.Name = "DGV_SCANNED_IMG"
        Me.DGV_SCANNED_IMG.ReadOnly = True
        Me.DGV_SCANNED_IMG.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        Me.DGV_SCANNED_IMG.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_SCANNED_IMG.RowTemplate.Height = 461
        Me.DGV_SCANNED_IMG.Size = New System.Drawing.Size(364, 462)
        Me.DGV_SCANNED_IMG.TabIndex = 1427
        '
        'SCANNED_IMG
        '
        Me.SCANNED_IMG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SCANNED_IMG.HeaderText = "SCANNED IMAGE"
        Me.SCANNED_IMG.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.SCANNED_IMG.Name = "SCANNED_IMG"
        Me.SCANNED_IMG.ReadOnly = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape11})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1095, 660)
        Me.ShapeContainer1.TabIndex = 1431
        Me.ShapeContainer1.TabStop = False
        '
        'wtxt_date
        '
        Me.wtxt_date.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.wtxt_date.Location = New System.Drawing.Point(1111, 82)
        Me.wtxt_date.Name = "wtxt_date"
        Me.wtxt_date.ReadOnly = True
        Me.wtxt_date.Size = New System.Drawing.Size(109, 21)
        Me.wtxt_date.TabIndex = 1432
        Me.wtxt_date.Watermark = Nothing
        '
        'TblV1_DEFPRADIVISIONTableAdapter
        '
        Me.TblV1_DEFPRADIVISIONTableAdapter.ClearBeforeFill = True
        '
        'TblV1_HRISDIVISIONTableAdapter
        '
        Me.TblV1_HRISDIVISIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tblV1_DEFPRADEPARTMENTSTableAdapter = Nothing
        Me.TableAdapterManager1.tblV1_DEFPRADIVISIONTableAdapter = Me.TblV1_DEFPRADIVISIONTableAdapter
        Me.TableAdapterManager1.tblV1_HRISDEPARTMENTTableAdapter = Me.TblV1_HRISDEPARTMENTTableAdapter
        Me.TableAdapterManager1.tblV1_HRISDIVISIONTableAdapter = Me.TblV1_HRISDIVISIONTableAdapter
        Me.TableAdapterManager1.tblV1_HRISEMPLOYEEDATATableAdapter = Nothing
        Me.TableAdapterManager1.tblV1_USERACCOUNTLOGSTableAdapter = Nothing
        Me.TableAdapterManager1.tblV1_USERACCOUNTTableAdapter = Nothing
        Me.TableAdapterManager1.tblV2_ACCOUNTCODETableAdapter = Nothing
        Me.TableAdapterManager1.tblV2_UsersAccountTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = PRA_PIS.DS_TABLESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblV1_HRISDEPARTMENTTableAdapter
        '
        Me.TblV1_HRISDEPARTMENTTableAdapter.ClearBeforeFill = True
        '
        'TblV1_USERACCOUNTTableAdapter1
        '
        Me.TblV1_USERACCOUNTTableAdapter1.ClearBeforeFill = True
        '
        'TblV1_HRISEMPLOYEEDATATableAdapter1
        '
        Me.TblV1_HRISEMPLOYEEDATATableAdapter1.ClearBeforeFill = True
        '
        'TBLG3UNITSBindingSource
        '
        Me.TBLG3UNITSBindingSource.DataMember = "TBLG3_UNITS"
        Me.TBLG3UNITSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4PURCHASEREQUESTITEMBindingSource
        '
        Me.TblM4PURCHASEREQUESTITEMBindingSource.DataMember = "tblM4_PURCHASEREQUEST_ITEM"
        Me.TblM4PURCHASEREQUESTITEMBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'SPM4PRCODEBindingSource
        '
        Me.SPM4PRCODEBindingSource.DataMember = "SPM4_PRCODE"
        Me.SPM4PRCODEBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'VWG3_PRIMARY_SIGNATORYTableAdapter
        '
        Me.VWG3_PRIMARY_SIGNATORYTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBLG3_COMPANY_INFOTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_DELIVER_RECEIPT_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_DELIVERY_RECEIPTTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_INVOICE_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_INVOICETableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_PRIMARY_SIGNATORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_BUSTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_DVTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_REG_PARTICULARTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORY_TYPETableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORY1TableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_SIGNATORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLG3_UNITSTableAdapter = Me.TBLG3_UNITSTableAdapter
        Me.TableAdapterManager.tblM4_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_SUB_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CANCELEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ITEMTableAdapter = Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_POSTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_PROVIDERTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_REVISIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUESTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBLG3_UNITSTableAdapter
        '
        Me.TBLG3_UNITSTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUEST_ITEMTableAdapter
        '
        Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUESTBindingSource
        '
        Me.TblM4_PURCHASEREQUESTBindingSource.DataMember = "tblM4_PURCHASEREQUEST"
        Me.TblM4_PURCHASEREQUESTBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_PURCHASEREQUESTTableAdapter
        '
        Me.TblM4_PURCHASEREQUESTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_PRCODETableAdapter
        '
        Me.SPM4_PRCODETableAdapter.ClearBeforeFill = True
        '
        'SPM4_CURRENTDATETIMETableAdapter
        '
        Me.SPM4_CURRENTDATETIMETableAdapter.ClearBeforeFill = True
        '
        'TBLG3_PRIMARY_SIGNATORYBindingSource
        '
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource.DataMember = "TBLG3_PRIMARY_SIGNATORY"
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLG3_PRIMARY_SIGNATORYTableAdapter
        '
        Me.TBLG3_PRIMARY_SIGNATORYTableAdapter.ClearBeforeFill = True
        '
        'APNL_PRREMARKS
        '
        Me.APNL_PRREMARKS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.APNL_PRREMARKS.BackColor = System.Drawing.Color.White
        Me.APNL_PRREMARKS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APNL_PRREMARKS.Controls.Add(Me.Panel23)
        Me.APNL_PRREMARKS.Controls.Add(Me.BTN_CLOSE_PRREMARKS)
        Me.APNL_PRREMARKS.Location = New System.Drawing.Point(1095, 40)
        Me.APNL_PRREMARKS.Name = "APNL_PRREMARKS"
        Me.APNL_PRREMARKS.Size = New System.Drawing.Size(1095, 618)
        Me.APNL_PRREMARKS.TabIndex = 1447
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel23.Controls.Add(Me.Label70)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(30, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(1063, 35)
        Me.Panel23.TabIndex = 1401
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.White
        Me.Label70.Location = New System.Drawing.Point(12, 4)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(308, 25)
        Me.Label70.TabIndex = 8
        Me.Label70.Text = "PURCHASE REQUEST REMARKS"
        '
        'BTN_CLOSE_PRREMARKS
        '
        Me.BTN_CLOSE_PRREMARKS.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_CLOSE_PRREMARKS.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE_PRREMARKS.Location = New System.Drawing.Point(0, 0)
        Me.BTN_CLOSE_PRREMARKS.Name = "BTN_CLOSE_PRREMARKS"
        Me.BTN_CLOSE_PRREMARKS.Size = New System.Drawing.Size(30, 616)
        Me.BTN_CLOSE_PRREMARKS.TabIndex = 0
        Me.BTN_CLOSE_PRREMARKS.Text = ">>"
        Me.BTN_CLOSE_PRREMARKS.UseVisualStyleBackColor = True
        '
        'FRM_PR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1095, 660)
        Me.Controls.Add(Me.APNL_PRREMARKS)
        Me.Controls.Add(Me.wtxt_date)
        Me.Controls.Add(Me.WTXT_TDNUM)
        Me.Controls.Add(Me.DGV_SCANNED_IMG)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.LBL_SCANNERNAME)
        Me.Controls.Add(Me.TblM4_PURCHASEREQUEST_ITEMDataGridView)
        Me.Controls.Add(Me.cbxSources)
        Me.Controls.Add(Me.VWG3_PRIMARY_SIGNATORYDataGridView)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FRM_PR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FRM_PR"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.TblV1_DEFPRADIVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRICONCANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRICONSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRICONSAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRICONPRINTPREVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TPPRinfo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_PR_ITEMLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_PRINFO.ResumeLayout(False)
        Me.GB_PRINFO.PerformLayout()
        CType(Me.TblV1_HRISDEPARTMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1_HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4CURRENTDATETIMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPPRSIGNATORY.ResumeLayout(False)
        Me.PanelSignatory.ResumeLayout(False)
        Me.PanelSignatory.PerformLayout()
        CType(Me.PB_SAVEICONSAVEDEFAULT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQDGV_PURCHASEREQUESTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRICONNEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PBICONEDIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWG3_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_PURCHASEREQUEST_ITEMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_PURCHASEREQUEST_ITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_SCANNED_IMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4PURCHASEREQUESTITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4PRCODEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APNL_PRREMARKS.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LLBL_PRNEW As LinkLabel
    Friend WithEvents LLBL_PRSAVE As LinkLabel
    Friend WithEvents PB_PRICONCANCEL As PictureBox
    Friend WithEvents PB_PRICONSEARCH As PictureBox
    Friend WithEvents LLBL_PRCANCEL As LinkLabel
    Friend WithEvents LLBL_PRSEARCH As LinkLabel
    Friend WithEvents LLBL_PRPRINTPREVIEW As LinkLabel
    Friend WithEvents PB_PRICONSAVE As PictureBox
    Friend WithEvents PB_PRICONPRINTPREVIEW As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPPRinfo As TabPage
    Friend WithEvents DGV_PR_ITEMLIST As DataGridView
    Friend WithEvents GB_PRINFO As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PBOX_PRNOQRCODE As PictureBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRPURPOSE As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape11 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRAPPCODE As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRREQUESTEDDATE As PowerPacks.RectangleShape
    Friend WithEvents TPPRSIGNATORY As TabPage
    Friend WithEvents LLBL_SAVEDEFAULT As LinkLabel
    Friend WithEvents PB_SAVEICONSAVEDEFAULT As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RectangleShape17 As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSIGNNOTEDPOSITION As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSIGNNOTEDNAME As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSIGNCERTIFIEDPOSITION As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSIGNCERTIFIEDNAME As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSIGNAPPROVEDNAME As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSIGNAPPROVEPOSITION As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSIGNREQUESTEDPOSITION As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSIGNREQUESTEDNAME As PowerPacks.RectangleShape
    Friend WithEvents LLBL_PREDIT As LinkLabel
    Friend WithEvents SQDGV_PURCHASEREQUESTDataGridView As DataGridView
    Friend WithEvents PB_PRICONNEW As PictureBox
    Friend WithEvents PB_PBICONEDIT As PictureBox
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRSAVENEW As PowerPacks.RectangleShape
    Friend WithEvents WTXT_SIGNREQUESTEDNAME As WatermarkTextBox
    Friend WithEvents WTXT_SIGNREQUESTEDPOSITION As WatermarkTextBox
    Friend WithEvents WTXT_SIGNNOTEDPOSITION As WatermarkTextBox
    Friend WithEvents WTXT_SIGNNOTEDNAME As WatermarkTextBox
    Friend WithEvents WTXT_SIGNCERTIFIEDPOSITION As WatermarkTextBox
    Friend WithEvents WTXT_SIGNCERTIFIEDNAME As WatermarkTextBox
    Friend WithEvents WTXT_SIGNAPPROVEPOSITION As WatermarkTextBox
    Friend WithEvents WTXT_SIGNAPPROVENAME As WatermarkTextBox
    Friend WithEvents WTXT_PURPOSE As WatermarkTextBox
    Friend WithEvents WTXT_SUBMITTEDBY As WatermarkTextBox
    Friend WithEvents WTXT_APPCODE As WatermarkTextBox
    Friend WithEvents WTXT_REQUESTEDDATE As WatermarkTextBox
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents VWG3_PRIMARY_SIGNATORYBindingSource As BindingSource
    Friend WithEvents VWG3_PRIMARY_SIGNATORYTableAdapter As DS_PROPERTYDBTableAdapters.VWG3_PRIMARY_SIGNATORYTableAdapter
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents VWG3_PRIMARY_SIGNATORYDataGridView As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents TblM4_PURCHASEREQUEST_ITEMTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter
    Friend WithEvents TblM4_PURCHASEREQUEST_ITEMBindingSource As BindingSource
    Friend WithEvents TblM4_PURCHASEREQUEST_ITEMDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents TblM4PURCHASEREQUESTITEMBindingSource As BindingSource
    Friend WithEvents TBLG3_UNITSTableAdapter As DS_PROPERTYDBTableAdapters.TBLG3_UNITSTableAdapter
    Friend WithEvents TBLG3UNITSBindingSource As BindingSource
    Friend WithEvents TblM4_PURCHASEREQUESTBindingSource As BindingSource
    Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents PanelSignatory As Panel
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cbxSources As ComboBox
    Friend WithEvents LBL_SCANNERNAME As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents WTXT_TDNUM As Label
    Friend WithEvents DGV_SCANNED_IMG As DataGridView
    Friend WithEvents SCANNED_IMG As DataGridViewImageColumn
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents SPM4PRCODEBindingSource As BindingSource
    Friend WithEvents SPM4_PRCODETableAdapter As DS_PROPERTYDBTableAdapters.SPM4_PRCODETableAdapter
    Friend WithEvents SPM4_CURRENTDATETIMETableAdapter As DS_PROPERTYDBTableAdapters.SPM4_CURRENTDATETIMETableAdapter
    Friend WithEvents wtxt_date As WatermarkTextBox
    Friend WithEvents TBLG3_PRIMARY_SIGNATORYBindingSource As BindingSource
    Friend WithEvents TBLG3_PRIMARY_SIGNATORYTableAdapter As DS_PROPERTYDBTableAdapters.TBLG3_PRIMARY_SIGNATORYTableAdapter
    Friend WithEvents TXT_PRNOTEDID As TextBox
    Friend WithEvents TXT_PRCERTIFIEDID As TextBox
    Friend WithEvents TXT_PRRAPPROVEDID As TextBox
    Friend WithEvents TXT_PRREQUESTEDID As TextBox
    Friend WithEvents LLBL_ADDPARTICULARS As LinkLabel
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TblV1_DEFPRADIVISIONTableAdapter As DS_TABLESTableAdapters.tblV1_DEFPRADIVISIONTableAdapter
    Friend WithEvents TblV1_DEFPRADIVISIONBindingSource As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TblV1_HRISDIVISIONBindingSource As BindingSource
    Friend WithEvents TblV1_HRISDIVISIONTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter
    Friend WithEvents TableAdapterManager1 As DS_TABLESTableAdapters.TableAdapterManager
    Friend WithEvents CB_PRDIVISION As ComboBox
    Friend WithEvents TblV1_HRISDEPARTMENTTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter
    Friend WithEvents TblV1_HRISDEPARTMENTBindingSource As BindingSource
    Friend WithEvents CB_PRDEPARTMENT As ComboBox
    Friend WithEvents BTN_PRMINIMIZE As Button
    Friend WithEvents BTN_PRCLOSE As Button
    Friend WithEvents SPM4CURRENTDATETIMEBindingSource As BindingSource
    Friend WithEvents BTN_TRANSCODE As Button
    Friend WithEvents TblV1_USERACCOUNTTableAdapter1 As DS_TABLESTableAdapters.tblV1_USERACCOUNTTableAdapter
    Friend WithEvents RECT_PRPARTICULARS As PowerPacks.RectangleShape
    Friend WithEvents TblV1_HRISEMPLOYEEDATATableAdapter1 As DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShapeContainer6 As PowerPacks.ShapeContainer
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents PRIITEMDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRQUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRUNITISSUEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRSTOCKNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRESTIMATEDCOSTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EDIT As DataGridViewButtonColumn
    Friend WithEvents DELETE As DataGridViewButtonColumn
    Friend WithEvents APNL_PRREMARKS As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Label70 As Label
    Friend WithEvents BTN_CLOSE_PRREMARKS As Button
    Friend WithEvents LLBL_PRVIEWREMARKS As LinkLabel
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents RBTN_PESO As RadioButton
    Friend WithEvents RBTN_DOLLARS As RadioButton
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
End Class
