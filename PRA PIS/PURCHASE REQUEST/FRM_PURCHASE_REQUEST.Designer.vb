<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PURCHASE_REQUEST
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
        Me.Label39 = New System.Windows.Forms.Label()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
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
        Me.DGV_PR_ITEMLIST = New System.Windows.Forms.DataGridView()
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRQUANTITYDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRUNITISSUEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TBLG3UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.DSPROPERTYDB_TABLES = New PRA_PIS.DSPROPERTYDB_TABLES()
        Me.PRSTOCKNODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblM4PURCHASEREQUESTITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GB_PRINFO = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.WTXT_PURPOSE = New PRA_PIS.WatermarkTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.WTXT_APPROVEDBY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_REQUESTEDBY = New PRA_PIS.WatermarkTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.WTXT_APPCODE = New PRA_PIS.WatermarkTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WTXT_DIVISION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_DEPARTMENT = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_REQUESTEDDATE = New PRA_PIS.WatermarkTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WTXT_PRNO = New PRA_PIS.WatermarkTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PBOX_PRNOQRCODE = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_PRPURPOSE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRAPPCODE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRREQUESTEDDATE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRPRNO = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TPPRSIGNATORY = New System.Windows.Forms.TabPage()
        Me.WTXT_SIGNNOTEDPOSITION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SIGNNOTEDNAME = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SIGNCERTIFIEDPOSITION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SIGNCERTIFIEDNAME = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SIGNAPPROVEPOSITION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SIGNAPPROVENAME = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SIGNREQUESTEDPOSITION = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SIGNREQUESTEDNAME = New PRA_PIS.WatermarkTextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.VWM4_PRIMARY_SIGNATORYDataGridView = New System.Windows.Forms.DataGridView()
        Me.RectangleShape17 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape16 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape15 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape13 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape12 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.WatermarkTextBox6 = New PRA_PIS.WatermarkTextBox()
        Me.WatermarkTextBox5 = New PRA_PIS.WatermarkTextBox()
        Me.WatermarkTextBox2 = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SIGNREQUESTEDBY = New PRA_PIS.WatermarkTextBox()
        Me.LLBL_PREDIT = New System.Windows.Forms.LinkLabel()
        Me.SQDGV_PURCHASEREQUESTDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SQDGV_PURCHASEREQUESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PB_PRICONNEW = New System.Windows.Forms.PictureBox()
        Me.PB_PBICONEDIT = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRCANCELEDIT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSAVENEW = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKtblM4PURCHASEREQUESTITEMtblM4UNITSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '  Me.VWG3_PRIMARY_SIGNATORYDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VWG3_PRIMARY_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLG3_SIGNATORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_PURCHASEREQUESTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        '   Me.TblM4_PURCHASEREQUESTTableAdapter = New PRA_PIS.DSPROPERTYDB_TABLESTableAdapters.tblM4_PURCHASEREQUESTTableAdapter()
        Me.TblM4_PURCHASEREQUEST_ITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter = New PRA_PIS.DSPROPERTYDB_TABLESTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter()
        'Me.SQDGV_PURCHASEREQUESTTableAdapter = New PRA_PIS.DSPROPERTYDB_TABLESTableAdapters.SQDGV_PURCHASEREQUESTTableAdapter()
        'Me.TableAdapterManager = New PRA_PIS.DSPROPERTYDB_TABLESTableAdapters.TableAdapterManager()
        'Me.TBLG3_UNITSTableAdapter = New PRA_PIS.DSPROPERTYDB_TABLESTableAdapters.TBLG3_UNITSTableAdapter()
        'Me.TBLG3_SIGNATORYTableAdapter = New PRA_PIS.DSPROPERTYDB_TABLESTableAdapters.TBLG3_SIGNATORYTableAdapter()
        'Me.TBLG3_PRIMARY_SIGNATORYTableAdapter = New PRA_PIS.DSPROPERTYDB_TABLESTableAdapters.TBLG3_PRIMARY_SIGNATORYTableAdapter()
        '  Me.VWG3_PRIMARY_SIGNATORYTableAdapter = New PRA_PIS.DSPROPERTYDB_TABLESTableAdapters.VWG3_PRIMARY_SIGNATORYTableAdapter()
        Me.PNL.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PB_PRICONCANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRICONSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRICONSAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRICONPRINTPREVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TPPRinfo.SuspendLayout()
        CType(Me.DGV_PR_ITEMLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPROPERTYDB_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4PURCHASEREQUESTITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_PRINFO.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPPRSIGNATORY.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShapeContainer1.SuspendLayout()
        CType(Me.VWM4_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQDGV_PURCHASEREQUESTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQDGV_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PRICONNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_PBICONEDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKtblM4PURCHASEREQUESTITEMtblM4UNITSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        '   CType(Me.VWG3_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        '  CType(Me.VWG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLG3_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_PURCHASEREQUEST_ITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(10, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(258, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "P U R C H A S E  R E Q U E S T"
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1095, 46)
        Me.PNL.TabIndex = 1401
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-269, 7)
        Me.BTN_Minimize.Name = "BTN_Minimize"
        Me.BTN_Minimize.Size = New System.Drawing.Size(28, 28)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-241, 6)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Window
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
        Me.Panel6.Location = New System.Drawing.Point(4, 42)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1087, 614)
        Me.Panel6.TabIndex = 1404
        '
        'LLBL_PRNEW
        '
        Me.LLBL_PRNEW.AutoSize = True
        Me.LLBL_PRNEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PRNEW.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_PRNEW.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PRNEW.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PRNEW.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PRNEW.Location = New System.Drawing.Point(56, 16)
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
        Me.LLBL_PRCANCEL.Location = New System.Drawing.Point(266, 15)
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
        Me.LLBL_PRSEARCH.Size = New System.Drawing.Size(75, 19)
        Me.LLBL_PRSEARCH.TabIndex = 1422
        Me.LLBL_PRSEARCH.TabStop = True
        Me.LLBL_PRSEARCH.Text = "SEARCH"
        '
        'LLBL_PRPRINTPREVIEW
        '
        Me.LLBL_PRPRINTPREVIEW.AutoSize = True
        Me.LLBL_PRPRINTPREVIEW.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.PB_PRICONSAVE.Location = New System.Drawing.Point(21, 10)
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
        Me.TabControl1.Location = New System.Drawing.Point(3, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1078, 566)
        Me.TabControl1.TabIndex = 1419
        '
        'TPPRinfo
        '
        Me.TPPRinfo.Controls.Add(Me.DGV_PR_ITEMLIST)
        Me.TPPRinfo.Controls.Add(Me.GB_PRINFO)
        Me.TPPRinfo.Location = New System.Drawing.Point(4, 26)
        Me.TPPRinfo.Name = "TPPRinfo"
        Me.TPPRinfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPRinfo.Size = New System.Drawing.Size(1070, 536)
        Me.TPPRinfo.TabIndex = 0
        Me.TPPRinfo.Text = "Purchase Request Info"
        Me.TPPRinfo.UseVisualStyleBackColor = True
        '
        'DGV_PR_ITEMLIST
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_PR_ITEMLIST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_PR_ITEMLIST.AutoGenerateColumns = False
        Me.DGV_PR_ITEMLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_PR_ITEMLIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DGV_PR_ITEMLIST.BackgroundColor = System.Drawing.Color.Gray
        Me.DGV_PR_ITEMLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PR_ITEMLIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn1, Me.PRQUANTITYDataGridViewTextBoxColumn1, Me.PRUNITISSUEDataGridViewTextBoxColumn1, Me.PRSTOCKNODataGridViewTextBoxColumn1, Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn1, Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn1})
        Me.DGV_PR_ITEMLIST.DataSource = Me.TblM4PURCHASEREQUESTITEMBindingSource
        Me.DGV_PR_ITEMLIST.Location = New System.Drawing.Point(7, 258)
        Me.DGV_PR_ITEMLIST.Name = "DGV_PR_ITEMLIST"
        Me.DGV_PR_ITEMLIST.RowHeadersVisible = False
        Me.DGV_PR_ITEMLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PR_ITEMLIST.Size = New System.Drawing.Size(1057, 321)
        Me.DGV_PR_ITEMLIST.TabIndex = 0
        '
        'PRIITEMDESCRIPTIONDataGridViewTextBoxColumn1
        '
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn1.DataPropertyName = "PRI_ITEMDESCRIPTION"
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn1.HeaderText = "ITEM DESCRIPTION"
        Me.PRIITEMDESCRIPTIONDataGridViewTextBoxColumn1.Name = "PRIITEMDESCRIPTIONDataGridViewTextBoxColumn1"
        '
        'PRQUANTITYDataGridViewTextBoxColumn1
        '
        Me.PRQUANTITYDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRQUANTITYDataGridViewTextBoxColumn1.DataPropertyName = "PR_QUANTITY"
        Me.PRQUANTITYDataGridViewTextBoxColumn1.HeaderText = "QUANTITY"
        Me.PRQUANTITYDataGridViewTextBoxColumn1.Name = "PRQUANTITYDataGridViewTextBoxColumn1"
        Me.PRQUANTITYDataGridViewTextBoxColumn1.Width = 80
        '
        'PRUNITISSUEDataGridViewTextBoxColumn1
        '
        Me.PRUNITISSUEDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRUNITISSUEDataGridViewTextBoxColumn1.DataPropertyName = "PR_UNITISSUE"
        Me.PRUNITISSUEDataGridViewTextBoxColumn1.DataSource = Me.TBLG3UNITSBindingSource
        Me.PRUNITISSUEDataGridViewTextBoxColumn1.DisplayMember = "UN_DESCRIPTION"
        Me.PRUNITISSUEDataGridViewTextBoxColumn1.HeaderText = "UNIT OF ISSUE"
        Me.PRUNITISSUEDataGridViewTextBoxColumn1.Name = "PRUNITISSUEDataGridViewTextBoxColumn1"
        Me.PRUNITISSUEDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRUNITISSUEDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TBLG3UNITSBindingSource
        '
        Me.TBLG3UNITSBindingSource.DataMember = "TBLG3_UNITS"
        Me.TBLG3UNITSBindingSource.DataSource = Me.DSPROPERTYDB_TABLES
        '
        'DSPROPERTYDB_TABLES
        '
        Me.DSPROPERTYDB_TABLES.DataSetName = "DSPROPERTYDB_TABLES"
        Me.DSPROPERTYDB_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRSTOCKNODataGridViewTextBoxColumn1
        '
        Me.PRSTOCKNODataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRSTOCKNODataGridViewTextBoxColumn1.DataPropertyName = "PR_STOCKNO"
        Me.PRSTOCKNODataGridViewTextBoxColumn1.HeaderText = "STOCK NO."
        Me.PRSTOCKNODataGridViewTextBoxColumn1.Name = "PRSTOCKNODataGridViewTextBoxColumn1"
        '
        'PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn1
        '
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn1.DataPropertyName = "PR_ESTIMATEDUNITCOST"
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn1.HeaderText = "ESTIMATED UNIT COST"
        Me.PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn1.Name = "PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn1"
        '
        'PRESTIMATEDCOSTDataGridViewTextBoxColumn1
        '
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn1.DataPropertyName = "PR_ESTIMATEDCOST"
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn1.HeaderText = "ESTIMATED COST"
        Me.PRESTIMATEDCOSTDataGridViewTextBoxColumn1.Name = "PRESTIMATEDCOSTDataGridViewTextBoxColumn1"
        '
        'TblM4PURCHASEREQUESTITEMBindingSource
        '
        Me.TblM4PURCHASEREQUESTITEMBindingSource.DataMember = "tblM4_PURCHASEREQUEST_ITEM"
        Me.TblM4PURCHASEREQUESTITEMBindingSource.DataSource = Me.DSPROPERTYDB_TABLES
        '
        'GB_PRINFO
        '
        Me.GB_PRINFO.BackColor = System.Drawing.SystemColors.Window
        Me.GB_PRINFO.Controls.Add(Me.Label17)
        Me.GB_PRINFO.Controls.Add(Me.Label16)
        Me.GB_PRINFO.Controls.Add(Me.Label15)
        Me.GB_PRINFO.Controls.Add(Me.Label14)
        Me.GB_PRINFO.Controls.Add(Me.Label13)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_PURPOSE)
        Me.GB_PRINFO.Controls.Add(Me.Label12)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_APPROVEDBY)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_REQUESTEDBY)
        Me.GB_PRINFO.Controls.Add(Me.Label11)
        Me.GB_PRINFO.Controls.Add(Me.PictureBox2)
        Me.GB_PRINFO.Controls.Add(Me.Label10)
        Me.GB_PRINFO.Controls.Add(Me.Label9)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_APPCODE)
        Me.GB_PRINFO.Controls.Add(Me.Label8)
        Me.GB_PRINFO.Controls.Add(Me.Label7)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_DIVISION)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_DEPARTMENT)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_REQUESTEDDATE)
        Me.GB_PRINFO.Controls.Add(Me.Label6)
        Me.GB_PRINFO.Controls.Add(Me.Label5)
        Me.GB_PRINFO.Controls.Add(Me.WTXT_PRNO)
        Me.GB_PRINFO.Controls.Add(Me.Label20)
        Me.GB_PRINFO.Controls.Add(Me.PBOX_PRNOQRCODE)
        Me.GB_PRINFO.Controls.Add(Me.ShapeContainer2)
        Me.GB_PRINFO.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_PRINFO.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GB_PRINFO.Location = New System.Drawing.Point(6, 2)
        Me.GB_PRINFO.Name = "GB_PRINFO"
        Me.GB_PRINFO.Size = New System.Drawing.Size(1058, 250)
        Me.GB_PRINFO.TabIndex = 1
        Me.GB_PRINFO.TabStop = False
        Me.GB_PRINFO.Text = "Purchase Request Information"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(930, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 24)
        Me.Label17.TabIndex = 1414
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(867, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(175, 16)
        Me.Label16.TabIndex = 1413
        Me.Label16.Text = "Fields with      sign must fill up"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(1029, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 24)
        Me.Label15.TabIndex = 1415
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(541, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 24)
        Me.Label14.TabIndex = 1414
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(392, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 24)
        Me.Label13.TabIndex = 1413
        Me.Label13.Text = "*"
        '
        'WTXT_PURPOSE
        '
        Me.WTXT_PURPOSE.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_PURPOSE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PURPOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_PURPOSE.Location = New System.Drawing.Point(169, 138)
        Me.WTXT_PURPOSE.MaxLength = 300
        Me.WTXT_PURPOSE.Multiline = True
        Me.WTXT_PURPOSE.Name = "WTXT_PURPOSE"
        Me.WTXT_PURPOSE.Size = New System.Drawing.Size(860, 88)
        Me.WTXT_PURPOSE.TabIndex = 7
        Me.WTXT_PURPOSE.Watermark = "Requested by"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(166, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 17)
        Me.Label12.TabIndex = 1409
        Me.Label12.Text = "PURPOSE"
        '
        'WTXT_APPROVEDBY
        '
        Me.WTXT_APPROVEDBY.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_APPROVEDBY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_APPROVEDBY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_APPROVEDBY.Location = New System.Drawing.Point(426, 86)
        Me.WTXT_APPROVEDBY.MaxLength = 100
        Me.WTXT_APPROVEDBY.Name = "WTXT_APPROVEDBY"
        Me.WTXT_APPROVEDBY.Size = New System.Drawing.Size(257, 21)
        Me.WTXT_APPROVEDBY.TabIndex = 6
        Me.WTXT_APPROVEDBY.Watermark = ""
        '
        'WTXT_REQUESTEDBY
        '
        Me.WTXT_REQUESTEDBY.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_REQUESTEDBY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_REQUESTEDBY.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_REQUESTEDBY.Location = New System.Drawing.Point(163, 87)
        Me.WTXT_REQUESTEDBY.MaxLength = 100
        Me.WTXT_REQUESTEDBY.Name = "WTXT_REQUESTEDBY"
        Me.WTXT_REQUESTEDBY.ReadOnly = True
        Me.WTXT_REQUESTEDBY.Size = New System.Drawing.Size(247, 19)
        Me.WTXT_REQUESTEDBY.TabIndex = 5
        Me.WTXT_REQUESTEDBY.Watermark = "Requested by"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(45, 185)
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
        Me.PictureBox2.Location = New System.Drawing.Point(19, 181)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 24)
        Me.PictureBox2.TabIndex = 1407
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(430, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 1406
        Me.Label10.Text = "APPROVED BY"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(166, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 1405
        Me.Label9.Text = "REQUESTED BY"
        '
        'WTXT_APPCODE
        '
        Me.WTXT_APPCODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_APPCODE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_APPCODE.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.WTXT_APPCODE.Location = New System.Drawing.Point(575, 41)
        Me.WTXT_APPCODE.MaxLength = 20
        Me.WTXT_APPCODE.Name = "WTXT_APPCODE"
        Me.WTXT_APPCODE.Size = New System.Drawing.Size(109, 21)
        Me.WTXT_APPCODE.TabIndex = 2
        Me.WTXT_APPCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_APPCODE.Watermark = "App Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(577, 24)
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
        Me.Label7.Location = New System.Drawing.Point(711, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 1339
        Me.Label7.Text = "DIVISION/UNIT"
        '
        'WTXT_DIVISION
        '
        Me.WTXT_DIVISION.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DIVISION.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_DIVISION.Location = New System.Drawing.Point(702, 88)
        Me.WTXT_DIVISION.MaxLength = 100
        Me.WTXT_DIVISION.Name = "WTXT_DIVISION"
        Me.WTXT_DIVISION.ReadOnly = True
        Me.WTXT_DIVISION.Size = New System.Drawing.Size(341, 19)
        Me.WTXT_DIVISION.TabIndex = 4
        Me.WTXT_DIVISION.Watermark = "Division"
        '
        'WTXT_DEPARTMENT
        '
        Me.WTXT_DEPARTMENT.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_DEPARTMENT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DEPARTMENT.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DEPARTMENT.Location = New System.Drawing.Point(701, 43)
        Me.WTXT_DEPARTMENT.MaxLength = 100
        Me.WTXT_DEPARTMENT.Name = "WTXT_DEPARTMENT"
        Me.WTXT_DEPARTMENT.ReadOnly = True
        Me.WTXT_DEPARTMENT.Size = New System.Drawing.Size(277, 19)
        Me.WTXT_DEPARTMENT.TabIndex = 3
        Me.WTXT_DEPARTMENT.Watermark = "Department"
        '
        'WTXT_REQUESTEDDATE
        '
        Me.WTXT_REQUESTEDDATE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_REQUESTEDDATE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_REQUESTEDDATE.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.WTXT_REQUESTEDDATE.Location = New System.Drawing.Point(426, 42)
        Me.WTXT_REQUESTEDDATE.MaxLength = 7
        Me.WTXT_REQUESTEDDATE.Name = "WTXT_REQUESTEDDATE"
        Me.WTXT_REQUESTEDDATE.ReadOnly = True
        Me.WTXT_REQUESTEDDATE.Size = New System.Drawing.Size(119, 21)
        Me.WTXT_REQUESTEDDATE.TabIndex = 1
        Me.WTXT_REQUESTEDDATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_REQUESTEDDATE.Watermark = "MM/DD/YYYY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(711, 26)
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
        Me.Label5.Location = New System.Drawing.Point(428, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 1334
        Me.Label5.Text = "REQUESTED DATE"
        '
        'WTXT_PRNO
        '
        Me.WTXT_PRNO.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_PRNO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PRNO.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_PRNO.Location = New System.Drawing.Point(163, 41)
        Me.WTXT_PRNO.MaxLength = 32
        Me.WTXT_PRNO.Name = "WTXT_PRNO"
        Me.WTXT_PRNO.Size = New System.Drawing.Size(230, 21)
        Me.WTXT_PRNO.TabIndex = 0
        Me.WTXT_PRNO.Watermark = "Purchase Request No."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DimGray
        Me.Label20.Location = New System.Drawing.Point(166, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 17)
        Me.Label20.TabIndex = 1332
        Me.Label20.Text = "PR NO."
        '
        'PBOX_PRNOQRCODE
        '
        Me.PBOX_PRNOQRCODE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBOX_PRNOQRCODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBOX_PRNOQRCODE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBOX_PRNOQRCODE.Location = New System.Drawing.Point(25, 63)
        Me.PBOX_PRNOQRCODE.Name = "PBOX_PRNOQRCODE"
        Me.PBOX_PRNOQRCODE.Size = New System.Drawing.Size(105, 105)
        Me.PBOX_PRNOQRCODE.TabIndex = 0
        Me.PBOX_PRNOQRCODE.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 24)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRPURPOSE, Me.RectangleShape11, Me.RectangleShape8, Me.RectangleShape7, Me.RECT_PRAPPCODE, Me.RectangleShape5, Me.RectangleShape4, Me.RECT_PRREQUESTEDDATE, Me.RECT_PRPRNO})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1052, 223)
        Me.ShapeContainer2.TabIndex = 1
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_PRPURPOSE
        '
        Me.RECT_PRPURPOSE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRPURPOSE.BorderWidth = 2
        Me.RECT_PRPURPOSE.CornerRadius = 5
        Me.RECT_PRPURPOSE.Location = New System.Drawing.Point(154, 99)
        Me.RECT_PRPURPOSE.Name = "RECT_PRPURPOSE"
        Me.RECT_PRPURPOSE.Size = New System.Drawing.Size(893, 113)
        '
        'RectangleShape11
        '
        Me.RectangleShape11.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape11.BorderWidth = 2
        Me.RectangleShape11.CornerRadius = 15
        Me.RectangleShape11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape11.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape11.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape11.Location = New System.Drawing.Point(7, 154)
        Me.RectangleShape11.Name = "RectangleShape11"
        Me.RectangleShape11.Size = New System.Drawing.Size(133, 30)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape8.BorderWidth = 2
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.Location = New System.Drawing.Point(418, 56)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(267, 32)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape7.BorderWidth = 2
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(154, 56)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(258, 32)
        '
        'RECT_PRAPPCODE
        '
        Me.RECT_PRAPPCODE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRAPPCODE.BorderWidth = 2
        Me.RECT_PRAPPCODE.CornerRadius = 5
        Me.RECT_PRAPPCODE.Location = New System.Drawing.Point(565, 11)
        Me.RECT_PRAPPCODE.Name = "RECT_PRAPPCODE"
        Me.RECT_PRAPPCODE.Size = New System.Drawing.Size(120, 32)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Location = New System.Drawing.Point(692, 56)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(354, 32)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(692, 11)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(354, 32)
        '
        'RECT_PRREQUESTEDDATE
        '
        Me.RECT_PRREQUESTEDDATE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRREQUESTEDDATE.BorderWidth = 2
        Me.RECT_PRREQUESTEDDATE.CornerRadius = 5
        Me.RECT_PRREQUESTEDDATE.Location = New System.Drawing.Point(418, 11)
        Me.RECT_PRREQUESTEDDATE.Name = "RECT_PRREQUESTEDDATE"
        Me.RECT_PRREQUESTEDDATE.Size = New System.Drawing.Size(142, 32)
        '
        'RECT_PRPRNO
        '
        Me.RECT_PRPRNO.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRPRNO.BorderWidth = 2
        Me.RECT_PRPRNO.CornerRadius = 5
        Me.RECT_PRPRNO.Location = New System.Drawing.Point(154, 11)
        Me.RECT_PRPRNO.Name = "RECT_PRPRNO"
        Me.RECT_PRPRNO.Size = New System.Drawing.Size(257, 31)
        '
        'TPPRSIGNATORY
        '
        Me.TPPRSIGNATORY.Controls.Add(Me.WTXT_SIGNNOTEDPOSITION)
        Me.TPPRSIGNATORY.Controls.Add(Me.WTXT_SIGNNOTEDNAME)
        Me.TPPRSIGNATORY.Controls.Add(Me.WTXT_SIGNCERTIFIEDPOSITION)
        Me.TPPRSIGNATORY.Controls.Add(Me.WTXT_SIGNCERTIFIEDNAME)
        Me.TPPRSIGNATORY.Controls.Add(Me.WTXT_SIGNAPPROVEPOSITION)
        Me.TPPRSIGNATORY.Controls.Add(Me.WTXT_SIGNAPPROVENAME)
        Me.TPPRSIGNATORY.Controls.Add(Me.WTXT_SIGNREQUESTEDPOSITION)
        Me.TPPRSIGNATORY.Controls.Add(Me.WTXT_SIGNREQUESTEDNAME)
        Me.TPPRSIGNATORY.Controls.Add(Me.LinkLabel1)
        Me.TPPRSIGNATORY.Controls.Add(Me.PictureBox1)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label27)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label26)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label25)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label2)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label24)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label22)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label23)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label19)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label21)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label3)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label4)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label18)
        Me.TPPRSIGNATORY.Controls.Add(Me.Label1)
        Me.TPPRSIGNATORY.Controls.Add(Me.ShapeContainer1)
        Me.TPPRSIGNATORY.Controls.Add(Me.WatermarkTextBox6)
        Me.TPPRSIGNATORY.Controls.Add(Me.WatermarkTextBox5)
        Me.TPPRSIGNATORY.Controls.Add(Me.WatermarkTextBox2)
        Me.TPPRSIGNATORY.Controls.Add(Me.WTXT_SIGNREQUESTEDBY)
        Me.TPPRSIGNATORY.Location = New System.Drawing.Point(4, 26)
        Me.TPPRSIGNATORY.Name = "TPPRSIGNATORY"
        Me.TPPRSIGNATORY.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPRSIGNATORY.Size = New System.Drawing.Size(1070, 536)
        Me.TPPRSIGNATORY.TabIndex = 1
        Me.TPPRSIGNATORY.Text = "Signatory"
        Me.TPPRSIGNATORY.UseVisualStyleBackColor = True
        '
        'WTXT_SIGNNOTEDPOSITION
        '
        Me.WTXT_SIGNNOTEDPOSITION.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SIGNNOTEDPOSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNNOTEDPOSITION.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WTXT_SIGNNOTEDPOSITION.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SIGNNOTEDPOSITION.Location = New System.Drawing.Point(295, 462)
        Me.WTXT_SIGNNOTEDPOSITION.MaxLength = 100
        Me.WTXT_SIGNNOTEDPOSITION.Name = "WTXT_SIGNNOTEDPOSITION"
        Me.WTXT_SIGNNOTEDPOSITION.ReadOnly = True
        Me.WTXT_SIGNNOTEDPOSITION.Size = New System.Drawing.Size(451, 19)
        Me.WTXT_SIGNNOTEDPOSITION.TabIndex = 1433
        Me.WTXT_SIGNNOTEDPOSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNNOTEDPOSITION.Watermark = "Requested by"
        '
        'WTXT_SIGNNOTEDNAME
        '
        Me.WTXT_SIGNNOTEDNAME.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SIGNNOTEDNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNNOTEDNAME.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WTXT_SIGNNOTEDNAME.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SIGNNOTEDNAME.Location = New System.Drawing.Point(296, 408)
        Me.WTXT_SIGNNOTEDNAME.MaxLength = 100
        Me.WTXT_SIGNNOTEDNAME.Name = "WTXT_SIGNNOTEDNAME"
        Me.WTXT_SIGNNOTEDNAME.ReadOnly = True
        Me.WTXT_SIGNNOTEDNAME.Size = New System.Drawing.Size(451, 19)
        Me.WTXT_SIGNNOTEDNAME.TabIndex = 1432
        Me.WTXT_SIGNNOTEDNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNNOTEDNAME.Watermark = "Requested by"
        '
        'WTXT_SIGNCERTIFIEDPOSITION
        '
        Me.WTXT_SIGNCERTIFIEDPOSITION.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SIGNCERTIFIEDPOSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNCERTIFIEDPOSITION.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WTXT_SIGNCERTIFIEDPOSITION.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SIGNCERTIFIEDPOSITION.Location = New System.Drawing.Point(296, 337)
        Me.WTXT_SIGNCERTIFIEDPOSITION.MaxLength = 100
        Me.WTXT_SIGNCERTIFIEDPOSITION.Name = "WTXT_SIGNCERTIFIEDPOSITION"
        Me.WTXT_SIGNCERTIFIEDPOSITION.ReadOnly = True
        Me.WTXT_SIGNCERTIFIEDPOSITION.Size = New System.Drawing.Size(451, 19)
        Me.WTXT_SIGNCERTIFIEDPOSITION.TabIndex = 1431
        Me.WTXT_SIGNCERTIFIEDPOSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNCERTIFIEDPOSITION.Watermark = "Requested by"
        '
        'WTXT_SIGNCERTIFIEDNAME
        '
        Me.WTXT_SIGNCERTIFIEDNAME.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SIGNCERTIFIEDNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNCERTIFIEDNAME.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WTXT_SIGNCERTIFIEDNAME.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SIGNCERTIFIEDNAME.Location = New System.Drawing.Point(296, 289)
        Me.WTXT_SIGNCERTIFIEDNAME.MaxLength = 100
        Me.WTXT_SIGNCERTIFIEDNAME.Name = "WTXT_SIGNCERTIFIEDNAME"
        Me.WTXT_SIGNCERTIFIEDNAME.ReadOnly = True
        Me.WTXT_SIGNCERTIFIEDNAME.Size = New System.Drawing.Size(451, 19)
        Me.WTXT_SIGNCERTIFIEDNAME.TabIndex = 1430
        Me.WTXT_SIGNCERTIFIEDNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNCERTIFIEDNAME.Watermark = "Requested by"
        '
        'WTXT_SIGNAPPROVEPOSITION
        '
        Me.WTXT_SIGNAPPROVEPOSITION.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SIGNAPPROVEPOSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNAPPROVEPOSITION.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WTXT_SIGNAPPROVEPOSITION.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SIGNAPPROVEPOSITION.Location = New System.Drawing.Point(296, 214)
        Me.WTXT_SIGNAPPROVEPOSITION.MaxLength = 100
        Me.WTXT_SIGNAPPROVEPOSITION.Name = "WTXT_SIGNAPPROVEPOSITION"
        Me.WTXT_SIGNAPPROVEPOSITION.ReadOnly = True
        Me.WTXT_SIGNAPPROVEPOSITION.Size = New System.Drawing.Size(451, 19)
        Me.WTXT_SIGNAPPROVEPOSITION.TabIndex = 1428
        Me.WTXT_SIGNAPPROVEPOSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNAPPROVEPOSITION.Watermark = "Requested by"
        '
        'WTXT_SIGNAPPROVENAME
        '
        Me.WTXT_SIGNAPPROVENAME.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SIGNAPPROVENAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNAPPROVENAME.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WTXT_SIGNAPPROVENAME.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SIGNAPPROVENAME.Location = New System.Drawing.Point(296, 171)
        Me.WTXT_SIGNAPPROVENAME.MaxLength = 100
        Me.WTXT_SIGNAPPROVENAME.Name = "WTXT_SIGNAPPROVENAME"
        Me.WTXT_SIGNAPPROVENAME.ReadOnly = True
        Me.WTXT_SIGNAPPROVENAME.Size = New System.Drawing.Size(451, 19)
        Me.WTXT_SIGNAPPROVENAME.TabIndex = 1429
        Me.WTXT_SIGNAPPROVENAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNAPPROVENAME.Watermark = "Requested by"
        '
        'WTXT_SIGNREQUESTEDPOSITION
        '
        Me.WTXT_SIGNREQUESTEDPOSITION.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SIGNREQUESTEDPOSITION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNREQUESTEDPOSITION.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WTXT_SIGNREQUESTEDPOSITION.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SIGNREQUESTEDPOSITION.Location = New System.Drawing.Point(295, 105)
        Me.WTXT_SIGNREQUESTEDPOSITION.MaxLength = 100
        Me.WTXT_SIGNREQUESTEDPOSITION.Name = "WTXT_SIGNREQUESTEDPOSITION"
        Me.WTXT_SIGNREQUESTEDPOSITION.ReadOnly = True
        Me.WTXT_SIGNREQUESTEDPOSITION.Size = New System.Drawing.Size(451, 19)
        Me.WTXT_SIGNREQUESTEDPOSITION.TabIndex = 1428
        Me.WTXT_SIGNREQUESTEDPOSITION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNREQUESTEDPOSITION.Watermark = "Requested by"
        '
        'WTXT_SIGNREQUESTEDNAME
        '
        Me.WTXT_SIGNREQUESTEDNAME.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SIGNREQUESTEDNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNREQUESTEDNAME.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WTXT_SIGNREQUESTEDNAME.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SIGNREQUESTEDNAME.Location = New System.Drawing.Point(296, 60)
        Me.WTXT_SIGNREQUESTEDNAME.MaxLength = 100
        Me.WTXT_SIGNREQUESTEDNAME.Name = "WTXT_SIGNREQUESTEDNAME"
        Me.WTXT_SIGNREQUESTEDNAME.ReadOnly = True
        Me.WTXT_SIGNREQUESTEDNAME.Size = New System.Drawing.Size(451, 19)
        Me.WTXT_SIGNREQUESTEDNAME.TabIndex = 1427
        Me.WTXT_SIGNREQUESTEDNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SIGNREQUESTEDNAME.Watermark = "Requested by"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.Location = New System.Drawing.Point(924, 498)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(132, 19)
        Me.LinkLabel1.TabIndex = 1426
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "SET AS DEFAULT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_save_black_18dp
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(891, 494)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox1.TabIndex = 1425
        Me.PictureBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DimGray
        Me.Label27.Location = New System.Drawing.Point(302, 41)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 17)
        Me.Label27.TabIndex = 1418
        Me.Label27.Text = "NAME"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DimGray
        Me.Label26.Location = New System.Drawing.Point(302, 151)
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
        Me.Label25.Location = New System.Drawing.Point(302, 272)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 17)
        Me.Label25.TabIndex = 1416
        Me.Label25.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(302, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1415
        Me.Label2.Text = "NAME"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DimGray
        Me.Label24.Location = New System.Drawing.Point(410, 10)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(221, 25)
        Me.Label24.TabIndex = 1414
        Me.Label24.Text = "DEFAULT SIGNATORY"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DimGray
        Me.Label22.Location = New System.Drawing.Point(302, 448)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 17)
        Me.Label22.TabIndex = 1409
        Me.Label22.Text = "POSITION"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DimGray
        Me.Label23.Location = New System.Drawing.Point(476, 489)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 16)
        Me.Label23.TabIndex = 1408
        Me.Label23.Text = "NOTED BY"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(302, 324)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 17)
        Me.Label19.TabIndex = 1407
        Me.Label19.Text = "POSITION"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DimGray
        Me.Label21.Location = New System.Drawing.Point(467, 366)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 16)
        Me.Label21.TabIndex = 1406
        Me.Label21.Text = "CERTIFIED BY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(302, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 1341
        Me.Label3.Text = "POSITION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(462, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 1340
        Me.Label4.Text = "APPROVED BY"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(302, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 17)
        Me.Label18.TabIndex = 1338
        Me.Label18.Text = "POSITION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(460, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 1333
        Me.Label1.Text = "REQUESTED BY"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Controls.Add(Me.VWM4_PRIMARY_SIGNATORYDataGridView)
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape17, Me.RectangleShape16, Me.RectangleShape15, Me.RectangleShape14, Me.RectangleShape13, Me.RectangleShape12, Me.RectangleShape10, Me.RectangleShape9, Me.RectangleShape6})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1064, 530)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'VWM4_PRIMARY_SIGNATORYDataGridView
        '
        Me.VWM4_PRIMARY_SIGNATORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VWM4_PRIMARY_SIGNATORYDataGridView.Location = New System.Drawing.Point(1159, 183)
        Me.VWM4_PRIMARY_SIGNATORYDataGridView.Name = "VWM4_PRIMARY_SIGNATORYDataGridView"
        Me.VWM4_PRIMARY_SIGNATORYDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.VWM4_PRIMARY_SIGNATORYDataGridView.TabIndex = 0
        '
        'RectangleShape17
        '
        Me.RectangleShape17.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape17.BorderWidth = 2
        Me.RectangleShape17.CornerRadius = 19
        Me.RectangleShape17.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape17.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape17.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape17.Location = New System.Drawing.Point(875, 485)
        Me.RectangleShape17.Name = "RectangleShape17"
        Me.RectangleShape17.Size = New System.Drawing.Size(184, 39)
        '
        'RectangleShape16
        '
        Me.RectangleShape16.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape16.BorderWidth = 2
        Me.RectangleShape16.CornerRadius = 5
        Me.RectangleShape16.Location = New System.Drawing.Point(287, 452)
        Me.RectangleShape16.Name = "RectangleShape16"
        Me.RectangleShape16.Size = New System.Drawing.Size(461, 32)
        '
        'RectangleShape15
        '
        Me.RectangleShape15.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape15.BorderWidth = 2
        Me.RectangleShape15.CornerRadius = 5
        Me.RectangleShape15.Location = New System.Drawing.Point(287, 398)
        Me.RectangleShape15.Name = "RectangleShape15"
        Me.RectangleShape15.Size = New System.Drawing.Size(461, 32)
        '
        'RectangleShape14
        '
        Me.RectangleShape14.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape14.BorderWidth = 2
        Me.RectangleShape14.CornerRadius = 5
        Me.RectangleShape14.Location = New System.Drawing.Point(287, 327)
        Me.RectangleShape14.Name = "RectangleShape14"
        Me.RectangleShape14.Size = New System.Drawing.Size(461, 32)
        '
        'RectangleShape13
        '
        Me.RectangleShape13.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape13.BorderWidth = 2
        Me.RectangleShape13.CornerRadius = 5
        Me.RectangleShape13.Location = New System.Drawing.Point(287, 278)
        Me.RectangleShape13.Name = "RectangleShape13"
        Me.RectangleShape13.Size = New System.Drawing.Size(461, 32)
        '
        'RectangleShape12
        '
        Me.RectangleShape12.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape12.BorderWidth = 2
        Me.RectangleShape12.CornerRadius = 5
        Me.RectangleShape12.Location = New System.Drawing.Point(287, 160)
        Me.RectangleShape12.Name = "RectangleShape12"
        Me.RectangleShape12.Size = New System.Drawing.Size(461, 32)
        '
        'RectangleShape10
        '
        Me.RectangleShape10.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape10.BorderWidth = 2
        Me.RectangleShape10.CornerRadius = 5
        Me.RectangleShape10.Location = New System.Drawing.Point(287, 204)
        Me.RectangleShape10.Name = "RectangleShape10"
        Me.RectangleShape10.Size = New System.Drawing.Size(461, 32)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape9.BorderWidth = 2
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.Location = New System.Drawing.Point(287, 94)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(461, 32)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.CornerRadius = 5
        Me.RectangleShape6.Location = New System.Drawing.Point(287, 49)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(461, 32)
        '
        'WatermarkTextBox6
        '
        Me.WatermarkTextBox6.BackColor = System.Drawing.SystemColors.Window
        Me.WatermarkTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WatermarkTextBox6.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WatermarkTextBox6.Location = New System.Drawing.Point(296, 482)
        Me.WatermarkTextBox6.MaxLength = 100
        Me.WatermarkTextBox6.Name = "WatermarkTextBox6"
        Me.WatermarkTextBox6.ReadOnly = True
        Me.WatermarkTextBox6.Size = New System.Drawing.Size(451, 19)
        Me.WatermarkTextBox6.TabIndex = 1413
        Me.WatermarkTextBox6.Watermark = "Requested by"
        '
        'WatermarkTextBox5
        '
        Me.WatermarkTextBox5.BackColor = System.Drawing.SystemColors.Window
        Me.WatermarkTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WatermarkTextBox5.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WatermarkTextBox5.Location = New System.Drawing.Point(296, 317)
        Me.WatermarkTextBox5.MaxLength = 100
        Me.WatermarkTextBox5.Name = "WatermarkTextBox5"
        Me.WatermarkTextBox5.ReadOnly = True
        Me.WatermarkTextBox5.Size = New System.Drawing.Size(451, 19)
        Me.WatermarkTextBox5.TabIndex = 1410
        Me.WatermarkTextBox5.Watermark = "Requested by"
        '
        'WatermarkTextBox2
        '
        Me.WatermarkTextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.WatermarkTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WatermarkTextBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WatermarkTextBox2.Location = New System.Drawing.Point(296, 198)
        Me.WatermarkTextBox2.MaxLength = 100
        Me.WatermarkTextBox2.Name = "WatermarkTextBox2"
        Me.WatermarkTextBox2.ReadOnly = True
        Me.WatermarkTextBox2.Size = New System.Drawing.Size(451, 19)
        Me.WatermarkTextBox2.TabIndex = 1405
        Me.WatermarkTextBox2.Watermark = "Requested by"
        '
        'WTXT_SIGNREQUESTEDBY
        '
        Me.WTXT_SIGNREQUESTEDBY.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SIGNREQUESTEDBY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SIGNREQUESTEDBY.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SIGNREQUESTEDBY.Location = New System.Drawing.Point(296, 70)
        Me.WTXT_SIGNREQUESTEDBY.MaxLength = 100
        Me.WTXT_SIGNREQUESTEDBY.Name = "WTXT_SIGNREQUESTEDBY"
        Me.WTXT_SIGNREQUESTEDBY.ReadOnly = True
        Me.WTXT_SIGNREQUESTEDBY.Size = New System.Drawing.Size(451, 19)
        Me.WTXT_SIGNREQUESTEDBY.TabIndex = 1334
        Me.WTXT_SIGNREQUESTEDBY.Watermark = "Requested by"
        '
        'LLBL_PREDIT
        '
        Me.LLBL_PREDIT.AutoSize = True
        Me.LLBL_PREDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_PREDIT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_PREDIT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_PREDIT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_PREDIT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_PREDIT.Location = New System.Drawing.Point(165, 15)
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
        Me.SQDGV_PURCHASEREQUESTDataGridView.AutoGenerateColumns = False
        Me.SQDGV_PURCHASEREQUESTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SQDGV_PURCHASEREQUESTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.SQDGV_PURCHASEREQUESTDataGridView.DataSource = Me.SQDGV_PURCHASEREQUESTBindingSource
        Me.SQDGV_PURCHASEREQUESTDataGridView.Location = New System.Drawing.Point(2005, 24)
        Me.SQDGV_PURCHASEREQUESTDataGridView.Name = "SQDGV_PURCHASEREQUESTDataGridView"
        Me.SQDGV_PURCHASEREQUESTDataGridView.ReadOnly = True
        Me.SQDGV_PURCHASEREQUESTDataGridView.Size = New System.Drawing.Size(388, 93)
        Me.SQDGV_PURCHASEREQUESTDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PR_PRNO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PR_PRNO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PR_DATEREQUESTED"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PR_DATEREQUESTED"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PR_APPCODE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PR_APPCODE"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PR_PURPOSE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PR_PURPOSE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PR_STATUS"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PR_STATUS"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CREATED_DATE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CREATED_DATE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'SQDGV_PURCHASEREQUESTBindingSource
        '
        Me.SQDGV_PURCHASEREQUESTBindingSource.DataMember = "SQDGV_PURCHASEREQUEST"
        Me.SQDGV_PURCHASEREQUESTBindingSource.DataSource = Me.DSPROPERTYDB_TABLES
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
        Me.PB_PBICONEDIT.Location = New System.Drawing.Point(128, 10)
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
        Me.ShapeContainer3.Size = New System.Drawing.Size(1087, 614)
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
        Me.RectangleShape2.Size = New System.Drawing.Size(123, 39)
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
        'VWG3_PRIMARY_SIGNATORYDataGridView
        '
        'Me.VWG3_PRIMARY_SIGNATORYDataGridView.AutoGenerateColumns = False
        'Me.VWG3_PRIMARY_SIGNATORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'Me.VWG3_PRIMARY_SIGNATORYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        'Me.VWG3_PRIMARY_SIGNATORYDataGridView.DataSource = Me.VWG3_PRIMARY_SIGNATORYBindingSource
        'Me.VWG3_PRIMARY_SIGNATORYDataGridView.Location = New System.Drawing.Point(1121, 107)
        'Me.VWG3_PRIMARY_SIGNATORYDataGridView.Name = "VWG3_PRIMARY_SIGNATORYDataGridView"
        'Me.VWG3_PRIMARY_SIGNATORYDataGridView.Size = New System.Drawing.Size(300, 220)
        'Me.VWG3_PRIMARY_SIGNATORYDataGridView.TabIndex = 1404
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SIG_POSITION"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SIG_POSITION"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SIG_OFFICE_ORDER"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SIG_OFFICE_ORDER"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SIG_POLICY"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SIG_POLICY"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SIG_AMOUNT"
        Me.DataGridViewTextBoxColumn11.HeaderText = "SIG_AMOUNT"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SIG_STATUS"
        Me.DataGridViewTextBoxColumn12.HeaderText = "SIG_STATUS"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "HDIVS_CODE"
        Me.DataGridViewTextBoxColumn13.HeaderText = "HDIVS_CODE"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "SIG_TY_NO"
        Me.DataGridViewTextBoxColumn14.HeaderText = "SIG_TY_NO"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "HRIS_EMPNO_USER"
        Me.DataGridViewTextBoxColumn15.HeaderText = "HRIS_EMPNO_USER"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "HRIS_EMPNO_SIG"
        Me.DataGridViewTextBoxColumn16.HeaderText = "HRIS_EMPNO_SIG"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FULLNAME"
        Me.DataGridViewTextBoxColumn17.HeaderText = "FULLNAME"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'VWG3_PRIMARY_SIGNATORYBindingSource
        '
        Me.VWG3_PRIMARY_SIGNATORYBindingSource.DataMember = "VWG3_PRIMARY_SIGNATORY"
        Me.VWG3_PRIMARY_SIGNATORYBindingSource.DataSource = Me.DSPROPERTYDB_TABLES
        '
        'TBLG3_PRIMARY_SIGNATORYBindingSource
        '
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource.DataMember = "TBLG3_PRIMARY_SIGNATORY"
        Me.TBLG3_PRIMARY_SIGNATORYBindingSource.DataSource = Me.DSPROPERTYDB_TABLES
        '
        'TBLG3_SIGNATORYBindingSource
        '
        Me.TBLG3_SIGNATORYBindingSource.DataMember = "TBLG3_SIGNATORY"
        Me.TBLG3_SIGNATORYBindingSource.DataSource = Me.DSPROPERTYDB_TABLES
        '
        'TblM4_PURCHASEREQUESTBindingSource
        '
        Me.TblM4_PURCHASEREQUESTBindingSource.DataMember = "tblM4_PURCHASEREQUEST"
        Me.TblM4_PURCHASEREQUESTBindingSource.DataSource = Me.DSPROPERTYDB_TABLES
        '
        'TblM4_PURCHASEREQUESTTableAdapter
        '
        '   Me.TblM4_PURCHASEREQUESTTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUEST_ITEMBindingSource
        '
        Me.TblM4_PURCHASEREQUEST_ITEMBindingSource.DataMember = "tblM4_PURCHASEREQUEST_ITEM"
        Me.TblM4_PURCHASEREQUEST_ITEMBindingSource.DataSource = Me.DSPROPERTYDB_TABLES
        '
        'TblM4_PURCHASEREQUEST_ITEMTableAdapter
        '
        '   Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter.ClearBeforeFill = True
        '
        'SQDGV_PURCHASEREQUESTTableAdapter
        '
        'Me.SQDGV_PURCHASEREQUESTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        'Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager.TBLG3_COMPANY_INFOTableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_DELIVER_RECEIPT_DETAILSTableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_DELIVERY_RECEIPTTableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_INVOICE_DETAILSTableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_INVOICETableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_PRIMARY_SIGNATORYTableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_REG_BUSTableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_REG_DVTableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_REG_PARTICULARTableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_SIGNATORY_TYPETableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_SIGNATORYTableAdapter = Nothing
        'Me.TableAdapterManager.TBLG3_UNITSTableAdapter = Nothing
        'Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ITEMTableAdapter = Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter
        'Me.TableAdapterManager.tblM4_PURCHASEREQUESTTableAdapter = Me.TblM4_PURCHASEREQUESTTableAdapter
        'Me.TableAdapterManager.UpdateOrder = PRA_PIS.DSPROPERTYDB_TABLESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        'Me.TableAdapterManager.VWG3_DR_LISTTableAdapter = Nothing
        'Me.TableAdapterManager.VWG3_EMPLOYEE_LISTTableAdapter = Nothing
        'Me.TableAdapterManager.VWG3_INVOICE_LISTTableAdapter = Nothing
        'Me.TableAdapterManager.VWG3_PRIMARY_SIGNATORYTableAdapter = Nothing
        'Me.TableAdapterManager.VWG3_REG_BUSTableAdapter = Nothing
        'Me.TableAdapterManager.VWG3_REG_DVTableAdapter = Nothing
        'Me.TableAdapterManager.VWM4_PRIMARY_SIGNATORYTableAdapter = Nothing
        '
        'TBLG3_UNITSTableAdapter
        '
        '     Me.TBLG3_UNITSTableAdapter.ClearBeforeFill = True
        '
        'TBLG3_SIGNATORYTableAdapter
        '
        '      Me.TBLG3_SIGNATORYTableAdapter.ClearBeforeFill = True
        '
        'TBLG3_PRIMARY_SIGNATORYTableAdapter
        '
        '     Me.TBLG3_PRIMARY_SIGNATORYTableAdapter.ClearBeforeFill = True
        '
        'VWG3_PRIMARY_SIGNATORYTableAdapter
        '
        '  Me.VWG3_PRIMARY_SIGNATORYTableAdapter.ClearBeforeFill = True
        '
        'FRM_PURCHASE_REQUEST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1095, 660)
        Me.ControlBox = False
        '  Me.Controls.Add(Me.VWG3_PRIMARY_SIGNATORYDataGridView)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PNL)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRM_PURCHASE_REQUEST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_PURCHASE_REQUEST"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PB_PRICONCANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRICONSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRICONSAVE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRICONPRINTPREVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TPPRinfo.ResumeLayout(False)
        CType(Me.DGV_PR_ITEMLIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPROPERTYDB_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4PURCHASEREQUESTITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_PRINFO.ResumeLayout(False)
        Me.GB_PRINFO.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPPRSIGNATORY.ResumeLayout(False)
        Me.TPPRSIGNATORY.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShapeContainer1.ResumeLayout(False)
        CType(Me.VWM4_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQDGV_PURCHASEREQUESTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQDGV_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PRICONNEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_PBICONEDIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKtblM4PURCHASEREQUESTITEMtblM4UNITSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        '   CType(Me.VWG3_PRIMARY_SIGNATORYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLG3_PRIMARY_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLG3_SIGNATORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_PURCHASEREQUESTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_PURCHASEREQUEST_ITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents PNL As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GB_PRINFO As GroupBox
    Friend WithEvents PBOX_PRNOQRCODE As PictureBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRPRNO As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRREQUESTEDDATE As PowerPacks.RectangleShape
    Friend WithEvents Label20 As Label
    Friend WithEvents WTXT_PRNO As WatermarkTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_REQUESTEDDATE As WatermarkTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents WTXT_DIVISION As WatermarkTextBox
    Friend WithEvents WTXT_DEPARTMENT As WatermarkTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RECT_PRAPPCODE As PowerPacks.RectangleShape
    Friend WithEvents WTXT_APPCODE As WatermarkTextBox
    Friend WithEvents DSPROPERTYDB_TABLES As DS_PROPERTYDB
    ' Friend WithEvents TBLG3_UNITSTableAdapter As DSPROPERTYDB_TABLESTableAdapters.TBLG3_UNITSTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RectangleShape11 As PowerPacks.RectangleShape
    Friend WithEvents Label11 As Label
    Friend WithEvents WTXT_APPROVEDBY As WatermarkTextBox
    Friend WithEvents WTXT_REQUESTEDBY As WatermarkTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents RECT_PRPURPOSE As PowerPacks.RectangleShape
    Friend WithEvents WTXT_PURPOSE As WatermarkTextBox
    Friend WithEvents PB_PRICONNEW As PictureBox
    Friend WithEvents RECT_PRSAVENEW As PowerPacks.RectangleShape
    Friend WithEvents PB_PBICONEDIT As PictureBox
    Friend WithEvents RECT_PRCANCELEDIT As PowerPacks.RectangleShape
    Friend WithEvents FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource As BindingSource
    Friend WithEvents DGV_PR_ITEMLIST As DataGridView
    Friend WithEvents FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource1 As BindingSource
    Friend WithEvents FKtblM4PURCHASEREQUESTITEMTBLG3UNITSBindingSource2 As BindingSource
    Friend WithEvents FKtblM4PURCHASEREQUESTITEMtblM4UNITSBindingSource As BindingSource
    Friend WithEvents TblM4_PURCHASEREQUESTBindingSource As BindingSource
    '  Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DSPROPERTYDB_TABLESTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents TblM4_PURCHASEREQUEST_ITEMBindingSource As BindingSource
    '   Friend WithEvents TblM4_PURCHASEREQUEST_ITEMTableAdapter As DSPROPERTYDB_TABLESTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents SQDGV_PURCHASEREQUESTBindingSource As BindingSource
    '   Friend WithEvents SQDGV_PURCHASEREQUESTTableAdapter As DSPROPERTYDB_TABLESTableAdapters.SQDGV_PURCHASEREQUESTTableAdapter
    ' Friend WithEvents TableAdapterManager As DSPROPERTYDB_TABLESTableAdapters.TableAdapterManager
    Friend WithEvents SQDGV_PURCHASEREQUESTDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents LLBL_PREDIT As LinkLabel
    Friend WithEvents LLBL_PRCANCEL As LinkLabel
    Friend WithEvents TBLG3UNITSBindingSource As BindingSource
    ' Friend WithEvents TBLG3_UNITSTableAdapter As DSPROPERTYDB_TABLESTableAdapters.TBLG3_UNITSTableAdapter
    Friend WithEvents TblM4PURCHASEREQUESTITEMBindingSource As BindingSource
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPPRinfo As TabPage
    Friend WithEvents TPPRSIGNATORY As TabPage
    Friend WithEvents LLBL_PRSEARCH As LinkLabel
    Friend WithEvents PB_PRICONSEARCH As PictureBox
    Friend WithEvents PB_PRICONCANCEL As PictureBox
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents LLBL_PRPRINTPREVIEW As LinkLabel
    Friend WithEvents PB_PRICONPRINTPREVIEW As PictureBox
    Friend WithEvents PRIITEMDESCRIPTIONDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PRQUANTITYDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PRUNITISSUEDataGridViewTextBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents PRSTOCKNODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PRESTIMATEDUNITCOSTDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PRESTIMATEDCOSTDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents WTXT_SIGNREQUESTEDBY As WatermarkTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents Label18 As Label
    Friend WithEvents WatermarkTextBox2 As WatermarkTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RectangleShape14 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape13 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape12 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape10 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents WatermarkTextBox6 As WatermarkTextBox
    Friend WithEvents WatermarkTextBox5 As WatermarkTextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents RectangleShape16 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape15 As PowerPacks.RectangleShape
    Friend WithEvents Label24 As Label
    Friend WithEvents PB_PRICONSAVE As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RectangleShape17 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_SIGNNOTEDPOSITION As WatermarkTextBox
    Friend WithEvents WTXT_SIGNNOTEDNAME As WatermarkTextBox
    Friend WithEvents WTXT_SIGNCERTIFIEDPOSITION As WatermarkTextBox
    Friend WithEvents WTXT_SIGNCERTIFIEDNAME As WatermarkTextBox
    Friend WithEvents WTXT_SIGNAPPROVEPOSITION As WatermarkTextBox
    Friend WithEvents WTXT_SIGNAPPROVENAME As WatermarkTextBox
    Friend WithEvents WTXT_SIGNREQUESTEDPOSITION As WatermarkTextBox
    Friend WithEvents WTXT_SIGNREQUESTEDNAME As WatermarkTextBox
    Friend WithEvents LLBL_PRNEW As LinkLabel
    Friend WithEvents LLBL_PRSAVE As LinkLabel
    Friend WithEvents TBLG3_SIGNATORYBindingSource As BindingSource
    ' Friend WithEvents TBLG3_SIGNATORYTableAdapter As DSPROPERTYDB_TABLESTableAdapters.TBLG3_SIGNATORYTableAdapter
    Friend WithEvents TBLG3_PRIMARY_SIGNATORYBindingSource As BindingSource
    ' Friend WithEvents TBLG3_PRIMARY_SIGNATORYTableAdapter As DSPROPERTYDB_TABLESTableAdapters.TBLG3_PRIMARY_SIGNATORYTableAdapter
    Friend WithEvents VWM4_PRIMARY_SIGNATORYDataGridView As DataGridView
    Friend WithEvents VWG3_PRIMARY_SIGNATORYBindingSource As BindingSource
    '  Friend WithEvents VWG3_PRIMARY_SIGNATORYTableAdapter As DSPROPERTYDB_TABLESTableAdapters.VWG3_PRIMARY_SIGNATORYTableAdapter
    '  Friend WithEvents VWG3_PRIMARY_SIGNATORYDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    '  Friend WithEvents SqdgV_PURCHASEREQUESTTableAdapter1 As DSPROPERTYDB_TABLESTableAdapters.SQDGV_PURCHASEREQUESTTableAdapter
End Class
