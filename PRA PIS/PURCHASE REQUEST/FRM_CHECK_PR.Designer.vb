<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_CHECK_PR
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INMA_MINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_INMA_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_PRMINIMIZE = New System.Windows.Forms.Button()
        Me.BTN_PRCLOSE = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.LLBL_VALIDATE_PRPREVIEW = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.DGV_PR_ITEMLIST = New System.Windows.Forms.DataGridView()
        Me.Itemdescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitOfIssue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedUnitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBL_SIGN = New System.Windows.Forms.Label()
        Me.LLBL_TOTALESTIMATEDCOST = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WTXT_PURPOSE = New PRA_PIS.WatermarkTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WTXT_DIVISION = New PRA_PIS.WatermarkTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WTXT_DEPARTMENT = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_SUBMITTEDBY = New PRA_PIS.WatermarkTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WTXT_REQUESTEDDATE = New PRA_PIS.WatermarkTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WTXT_APPCODE = New PRA_PIS.WatermarkTextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRREQUESTEDDATE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRAPPCODE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape11 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRSEARCH = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DGV_PRLIST = New System.Windows.Forms.DataGridView()
        Me.StatusOfOngoingPRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRSTATUSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRPRNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewDetails = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdateStatus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PRPRNO1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAXDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPM4PMDPRLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LBL_TOTALNOOFPR = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TblV1_HRISEMPLOYEEDATATableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter()
        Me.APNL_VALIDATEPR = New System.Windows.Forms.Panel()
        Me.PBICONSEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_SEARCHPR = New PRA_PIS.WatermarkTextBox()
        Me.PB_VALIDATE_PRPREVIEW = New System.Windows.Forms.PictureBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.LLBL_INVENTORY_ENCODING_HEADER = New System.Windows.Forms.Label()
        Me.BTN_CPR_CANCEL = New System.Windows.Forms.Button()
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_CPR_FORREVISION = New System.Windows.Forms.Button()
        Me.BTN_CPR_ACCEPT = New System.Windows.Forms.Button()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_INVENTORY_NEW_SAVE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LLBL_VALIDATE_PR = New System.Windows.Forms.LinkLabel()
        Me.LLBL_VALIDATE_PR_VIEW_REPORT = New System.Windows.Forms.LinkLabel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PB_CLEARSEARCH = New System.Windows.Forms.PictureBox()
        Me.PB_VALIDATE_PR_VIEW_REPORT = New System.Windows.Forms.PictureBox()
        Me.PB_VALIDATE_PR = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TblM4_PURCHASEREQUESTTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter()
        Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter()
        Me.TblM4_PURCHASEREQUEST_CANCELEDTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_CANCELEDTableAdapter()
        Me.TblM4_PURCHASEREQUEST_REVISIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_REVISIONTableAdapter()
        Me.WTXT_SEARCHLIST_PR = New PRA_PIS.WatermarkTextBox()
        Me.SPM4_PURCHASELISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4PURCHASELISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_PURCHASELISTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_PURCHASELISTTableAdapter()
        Me.SPM4_PMDPRLISTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_PMDPRLISTTableAdapter()
        Me.PNL.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_PR_ITEMLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_PRLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4PMDPRLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.APNL_VALIDATEPR.SuspendLayout()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_VALIDATE_PRPREVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel23.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_CLEARSEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_VALIDATE_PR_VIEW_REPORT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_VALIDATE_PR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_PURCHASELISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4PURCHASELISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_INMA_MINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_INMA_CLOSE)
        Me.PNL.Controls.Add(Me.BTN_PRMINIMIZE)
        Me.PNL.Controls.Add(Me.BTN_PRCLOSE)
        Me.PNL.Controls.Add(Me.Label39)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1095, 49)
        Me.PNL.TabIndex = 1403
        '
        'BTN_INMA_MINIMIZE
        '
        Me.BTN_INMA_MINIMIZE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_INMA_MINIMIZE.BackColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.Minimized_Left_white
        Me.BTN_INMA_MINIMIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INMA_MINIMIZE.FlatAppearance.BorderSize = 3
        Me.BTN_INMA_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INMA_MINIMIZE.Location = New System.Drawing.Point(1018, 8)
        Me.BTN_INMA_MINIMIZE.Name = "BTN_INMA_MINIMIZE"
        Me.BTN_INMA_MINIMIZE.Size = New System.Drawing.Size(27, 28)
        Me.BTN_INMA_MINIMIZE.TabIndex = 15
        Me.BTN_INMA_MINIMIZE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INMA_MINIMIZE.UseVisualStyleBackColor = False
        '
        'BTN_INMA_CLOSE
        '
        Me.BTN_INMA_CLOSE.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTN_INMA_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INMA_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INMA_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INMA_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INMA_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INMA_CLOSE.Location = New System.Drawing.Point(1053, 7)
        Me.BTN_INMA_CLOSE.Name = "BTN_INMA_CLOSE"
        Me.BTN_INMA_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INMA_CLOSE.TabIndex = 14
        Me.BTN_INMA_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INMA_CLOSE.UseVisualStyleBackColor = True
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
        Me.BTN_PRMINIMIZE.Location = New System.Drawing.Point(2172, 8)
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
        Me.BTN_PRCLOSE.Location = New System.Drawing.Point(2207, 7)
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
        Me.Label39.Location = New System.Drawing.Point(12, 14)
        Me.Label39.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(353, 23)
        Me.Label39.TabIndex = 8
        Me.Label39.Text = "C H E C K  P U R C H A S E  R E Q U E S T"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-2265, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-2218, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'LLBL_VALIDATE_PRPREVIEW
        '
        Me.LLBL_VALIDATE_PRPREVIEW.AutoSize = True
        Me.LLBL_VALIDATE_PRPREVIEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_VALIDATE_PRPREVIEW.Enabled = False
        Me.LLBL_VALIDATE_PRPREVIEW.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_VALIDATE_PRPREVIEW.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_VALIDATE_PRPREVIEW.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_VALIDATE_PRPREVIEW.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_VALIDATE_PRPREVIEW.Location = New System.Drawing.Point(992, 60)
        Me.LLBL_VALIDATE_PRPREVIEW.Name = "LLBL_VALIDATE_PRPREVIEW"
        Me.LLBL_VALIDATE_PRPREVIEW.Size = New System.Drawing.Size(79, 19)
        Me.LLBL_VALIDATE_PRPREVIEW.TabIndex = 1425
        Me.LLBL_VALIDATE_PRPREVIEW.TabStop = True
        Me.LLBL_VALIDATE_PRPREVIEW.Text = "PREVIEW"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel3)
        Me.GroupBox2.Controls.Add(Me.DGV_PR_ITEMLIST)
        Me.GroupBox2.Controls.Add(Me.LBL_SIGN)
        Me.GroupBox2.Controls.Add(Me.LLBL_TOTALESTIMATEDCOST)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(496, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 490)
        Me.GroupBox2.TabIndex = 1431
        Me.GroupBox2.TabStop = False
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
        Me.LinkLabel3.Location = New System.Drawing.Point(14, -1)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(103, 18)
        Me.LinkLabel3.TabIndex = 1436
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "PARTICULARS"
        '
        'DGV_PR_ITEMLIST
        '
        Me.DGV_PR_ITEMLIST.AllowUserToAddRows = False
        Me.DGV_PR_ITEMLIST.AllowUserToDeleteRows = False
        Me.DGV_PR_ITEMLIST.AllowUserToResizeColumns = False
        Me.DGV_PR_ITEMLIST.AllowUserToResizeRows = False
        Me.DGV_PR_ITEMLIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_PR_ITEMLIST.ColumnHeadersHeight = 56
        Me.DGV_PR_ITEMLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_PR_ITEMLIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Itemdescription, Me.Quantity, Me.UnitOfIssue, Me.StockNo, Me.EstimatedUnitCost, Me.EstimatedCost})
        Me.DGV_PR_ITEMLIST.Location = New System.Drawing.Point(5, 18)
        Me.DGV_PR_ITEMLIST.Name = "DGV_PR_ITEMLIST"
        Me.DGV_PR_ITEMLIST.ReadOnly = True
        Me.DGV_PR_ITEMLIST.RowHeadersVisible = False
        Me.DGV_PR_ITEMLIST.RowHeadersWidth = 100
        Me.DGV_PR_ITEMLIST.Size = New System.Drawing.Size(584, 440)
        Me.DGV_PR_ITEMLIST.TabIndex = 1435
        '
        'Itemdescription
        '
        Me.Itemdescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Itemdescription.DefaultCellStyle = DataGridViewCellStyle1
        Me.Itemdescription.HeaderText = "Item Description"
        Me.Itemdescription.Name = "Itemdescription"
        Me.Itemdescription.ReadOnly = True
        Me.Itemdescription.Width = 170
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 70
        '
        'UnitOfIssue
        '
        Me.UnitOfIssue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.UnitOfIssue.HeaderText = "Unit Of Issue"
        Me.UnitOfIssue.Name = "UnitOfIssue"
        Me.UnitOfIssue.ReadOnly = True
        Me.UnitOfIssue.Width = 60
        '
        'StockNo
        '
        Me.StockNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.StockNo.HeaderText = "Stock No."
        Me.StockNo.Name = "StockNo"
        Me.StockNo.ReadOnly = True
        Me.StockNo.Width = 70
        '
        'EstimatedUnitCost
        '
        Me.EstimatedUnitCost.HeaderText = "Estimated Unit Cost"
        Me.EstimatedUnitCost.Name = "EstimatedUnitCost"
        Me.EstimatedUnitCost.ReadOnly = True
        '
        'EstimatedCost
        '
        Me.EstimatedCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EstimatedCost.HeaderText = "Estimated Cost"
        Me.EstimatedCost.Name = "EstimatedCost"
        Me.EstimatedCost.ReadOnly = True
        '
        'LBL_SIGN
        '
        Me.LBL_SIGN.AutoSize = True
        Me.LBL_SIGN.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SIGN.ForeColor = System.Drawing.Color.DimGray
        Me.LBL_SIGN.Location = New System.Drawing.Point(457, 463)
        Me.LBL_SIGN.Name = "LBL_SIGN"
        Me.LBL_SIGN.Size = New System.Drawing.Size(31, 16)
        Me.LBL_SIGN.TabIndex = 1434
        Me.LBL_SIGN.Text = "PHP"
        '
        'LLBL_TOTALESTIMATEDCOST
        '
        Me.LLBL_TOTALESTIMATEDCOST.AutoSize = True
        Me.LLBL_TOTALESTIMATEDCOST.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_TOTALESTIMATEDCOST.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_TOTALESTIMATEDCOST.Location = New System.Drawing.Point(487, 463)
        Me.LLBL_TOTALESTIMATEDCOST.Name = "LLBL_TOTALESTIMATEDCOST"
        Me.LLBL_TOTALESTIMATEDCOST.Size = New System.Drawing.Size(33, 16)
        Me.LLBL_TOTALESTIMATEDCOST.TabIndex = 1433
        Me.LLBL_TOTALESTIMATEDCOST.Text = "0.00"
        Me.LLBL_TOTALESTIMATEDCOST.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(300, 461)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 17)
        Me.Label12.TabIndex = 1432
        Me.Label12.Text = "TOTAL ESTIMATED COST :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.WTXT_PURPOSE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.WTXT_DIVISION)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.WTXT_DEPARTMENT)
        Me.GroupBox1.Controls.Add(Me.WTXT_SUBMITTEDBY)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.WTXT_REQUESTEDDATE)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.WTXT_APPCODE)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(31, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 493)
        Me.GroupBox1.TabIndex = 1429
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PURCHASE REQUEST INFO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(223, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 19)
        Me.Label7.TabIndex = 1439
        Me.Label7.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(26, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 1438
        Me.Label3.Text = "PURPOSE"
        '
        'WTXT_PURPOSE
        '
        Me.WTXT_PURPOSE.BackColor = System.Drawing.Color.White
        Me.WTXT_PURPOSE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PURPOSE.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_PURPOSE.ForeColor = System.Drawing.Color.Gray
        Me.WTXT_PURPOSE.Location = New System.Drawing.Point(20, 248)
        Me.WTXT_PURPOSE.MaxLength = 300
        Me.WTXT_PURPOSE.Multiline = True
        Me.WTXT_PURPOSE.Name = "WTXT_PURPOSE"
        Me.WTXT_PURPOSE.ReadOnly = True
        Me.WTXT_PURPOSE.Size = New System.Drawing.Size(420, 216)
        Me.WTXT_PURPOSE.TabIndex = 1438
        Me.WTXT_PURPOSE.Watermark = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(27, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 1437
        Me.Label2.Text = "DIVISION"
        '
        'WTXT_DIVISION
        '
        Me.WTXT_DIVISION.BackColor = System.Drawing.Color.White
        Me.WTXT_DIVISION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DIVISION.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_DIVISION.ForeColor = System.Drawing.Color.Gray
        Me.WTXT_DIVISION.Location = New System.Drawing.Point(20, 193)
        Me.WTXT_DIVISION.MaxLength = 50
        Me.WTXT_DIVISION.Name = "WTXT_DIVISION"
        Me.WTXT_DIVISION.ReadOnly = True
        Me.WTXT_DIVISION.Size = New System.Drawing.Size(418, 19)
        Me.WTXT_DIVISION.TabIndex = 1436
        Me.WTXT_DIVISION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_DIVISION.Watermark = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(27, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 1435
        Me.Label1.Text = "DEPARTMENT"
        '
        'WTXT_DEPARTMENT
        '
        Me.WTXT_DEPARTMENT.BackColor = System.Drawing.Color.White
        Me.WTXT_DEPARTMENT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DEPARTMENT.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_DEPARTMENT.ForeColor = System.Drawing.Color.Gray
        Me.WTXT_DEPARTMENT.Location = New System.Drawing.Point(20, 141)
        Me.WTXT_DEPARTMENT.MaxLength = 50
        Me.WTXT_DEPARTMENT.Name = "WTXT_DEPARTMENT"
        Me.WTXT_DEPARTMENT.ReadOnly = True
        Me.WTXT_DEPARTMENT.Size = New System.Drawing.Size(418, 19)
        Me.WTXT_DEPARTMENT.TabIndex = 1434
        Me.WTXT_DEPARTMENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_DEPARTMENT.Watermark = Nothing
        '
        'WTXT_SUBMITTEDBY
        '
        Me.WTXT_SUBMITTEDBY.BackColor = System.Drawing.Color.White
        Me.WTXT_SUBMITTEDBY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SUBMITTEDBY.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_SUBMITTEDBY.ForeColor = System.Drawing.Color.Gray
        Me.WTXT_SUBMITTEDBY.Location = New System.Drawing.Point(20, 89)
        Me.WTXT_SUBMITTEDBY.MaxLength = 50
        Me.WTXT_SUBMITTEDBY.Name = "WTXT_SUBMITTEDBY"
        Me.WTXT_SUBMITTEDBY.ReadOnly = True
        Me.WTXT_SUBMITTEDBY.Size = New System.Drawing.Size(418, 19)
        Me.WTXT_SUBMITTEDBY.TabIndex = 1433
        Me.WTXT_SUBMITTEDBY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SUBMITTEDBY.Watermark = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(27, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 1432
        Me.Label9.Text = "SUBMITTED BY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(257, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 1431
        Me.Label5.Text = "REQUESTED DATE"
        '
        'WTXT_REQUESTEDDATE
        '
        Me.WTXT_REQUESTEDDATE.BackColor = System.Drawing.Color.White
        Me.WTXT_REQUESTEDDATE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_REQUESTEDDATE.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_REQUESTEDDATE.ForeColor = System.Drawing.Color.Gray
        Me.WTXT_REQUESTEDDATE.Location = New System.Drawing.Point(257, 46)
        Me.WTXT_REQUESTEDDATE.Name = "WTXT_REQUESTEDDATE"
        Me.WTXT_REQUESTEDDATE.ReadOnly = True
        Me.WTXT_REQUESTEDDATE.Size = New System.Drawing.Size(133, 19)
        Me.WTXT_REQUESTEDDATE.TabIndex = 1430
        Me.WTXT_REQUESTEDDATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_REQUESTEDDATE.Watermark = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(27, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 1429
        Me.Label8.Text = "APP CODE"
        '
        'WTXT_APPCODE
        '
        Me.WTXT_APPCODE.BackColor = System.Drawing.Color.White
        Me.WTXT_APPCODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_APPCODE.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.WTXT_APPCODE.ForeColor = System.Drawing.Color.Gray
        Me.WTXT_APPCODE.Location = New System.Drawing.Point(22, 46)
        Me.WTXT_APPCODE.MaxLength = 15
        Me.WTXT_APPCODE.Name = "WTXT_APPCODE"
        Me.WTXT_APPCODE.Size = New System.Drawing.Size(197, 19)
        Me.WTXT_APPCODE.TabIndex = 1428
        Me.WTXT_APPCODE.Watermark = Nothing
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1, Me.RectangleShape7, Me.RECT_PRREQUESTEDDATE, Me.RECT_PRAPPCODE})
        Me.ShapeContainer2.Size = New System.Drawing.Size(456, 467)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(13, 217)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(427, 238)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(12, 162)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(427, 32)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Location = New System.Drawing.Point(12, 111)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(427, 32)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape7.CornerRadius = 5
        Me.RectangleShape7.Location = New System.Drawing.Point(12, 59)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(427, 32)
        '
        'RECT_PRREQUESTEDDATE
        '
        Me.RECT_PRREQUESTEDDATE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRREQUESTEDDATE.CornerRadius = 5
        Me.RECT_PRREQUESTEDDATE.Location = New System.Drawing.Point(249, 16)
        Me.RECT_PRREQUESTEDDATE.Name = "RECT_PRREQUESTEDDATE"
        Me.RECT_PRREQUESTEDDATE.Size = New System.Drawing.Size(142, 32)
        '
        'RECT_PRAPPCODE
        '
        Me.RECT_PRAPPCODE.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRAPPCODE.CornerRadius = 5
        Me.RECT_PRAPPCODE.Location = New System.Drawing.Point(12, 16)
        Me.RECT_PRAPPCODE.Name = "RECT_PRAPPCODE"
        Me.RECT_PRAPPCODE.Size = New System.Drawing.Size(226, 31)
        '
        'RectangleShape11
        '
        Me.RectangleShape11.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape11.BorderWidth = 2
        Me.RectangleShape11.CornerRadius = 19
        Me.RectangleShape11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape11.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape11.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape11.Location = New System.Drawing.Point(946, 50)
        Me.RectangleShape11.Name = "RectangleShape11"
        Me.RectangleShape11.Size = New System.Drawing.Size(132, 39)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape8.BorderWidth = 2
        Me.RectangleShape8.CornerRadius = 5
        Me.RectangleShape8.Location = New System.Drawing.Point(979, 590)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(106, 48)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(868, 590)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(105, 49)
        '
        'RECT_PRSEARCH
        '
        Me.RECT_PRSEARCH.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RECT_PRSEARCH.CornerRadius = 15
        Me.RECT_PRSEARCH.Location = New System.Drawing.Point(51, 49)
        Me.RECT_PRSEARCH.Name = "RECT_PRSEARCH"
        Me.RECT_PRSEARCH.Size = New System.Drawing.Size(428, 33)
        '
        'DGV_PRLIST
        '
        Me.DGV_PRLIST.AllowUserToAddRows = False
        Me.DGV_PRLIST.AllowUserToDeleteRows = False
        Me.DGV_PRLIST.AllowUserToResizeRows = False
        Me.DGV_PRLIST.AutoGenerateColumns = False
        Me.DGV_PRLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_PRLIST.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_PRLIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_PRLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PRLIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StatusOfOngoingPRDataGridViewTextBoxColumn, Me.PRSTATUSDataGridViewTextBoxColumn, Me.PRPRNODataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.DateCreatedDataGridViewTextBoxColumn, Me.btnViewDetails, Me.btnUpdateStatus, Me.PRPRNO1DataGridViewTextBoxColumn, Me.MAXDATEDataGridViewTextBoxColumn})
        Me.DGV_PRLIST.DataSource = Me.SPM4PMDPRLISTBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_PRLIST.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_PRLIST.GridColor = System.Drawing.Color.LightGray
        Me.DGV_PRLIST.Location = New System.Drawing.Point(190, 157)
        Me.DGV_PRLIST.Name = "DGV_PRLIST"
        Me.DGV_PRLIST.ReadOnly = True
        Me.DGV_PRLIST.RowHeadersVisible = False
        Me.DGV_PRLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PRLIST.Size = New System.Drawing.Size(892, 452)
        Me.DGV_PRLIST.TabIndex = 1414
        '
        'StatusOfOngoingPRDataGridViewTextBoxColumn
        '
        Me.StatusOfOngoingPRDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.StatusOfOngoingPRDataGridViewTextBoxColumn.DataPropertyName = "Status of Ongoing PR"
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent
        Me.StatusOfOngoingPRDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.StatusOfOngoingPRDataGridViewTextBoxColumn.HeaderText = ""
        Me.StatusOfOngoingPRDataGridViewTextBoxColumn.Name = "StatusOfOngoingPRDataGridViewTextBoxColumn"
        Me.StatusOfOngoingPRDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusOfOngoingPRDataGridViewTextBoxColumn.Width = 25
        '
        'PRSTATUSDataGridViewTextBoxColumn
        '
        Me.PRSTATUSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRSTATUSDataGridViewTextBoxColumn.DataPropertyName = "PR_STATUS"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent
        Me.PRSTATUSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PRSTATUSDataGridViewTextBoxColumn.FillWeight = 385.8268!
        Me.PRSTATUSDataGridViewTextBoxColumn.HeaderText = ""
        Me.PRSTATUSDataGridViewTextBoxColumn.Name = "PRSTATUSDataGridViewTextBoxColumn"
        Me.PRSTATUSDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRSTATUSDataGridViewTextBoxColumn.Width = 25
        '
        'PRPRNODataGridViewTextBoxColumn
        '
        Me.PRPRNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRPRNODataGridViewTextBoxColumn.DataPropertyName = "PR_PRNO"
        Me.PRPRNODataGridViewTextBoxColumn.FillWeight = 52.3622!
        Me.PRPRNODataGridViewTextBoxColumn.HeaderText = "PR No."
        Me.PRPRNODataGridViewTextBoxColumn.Name = "PRPRNODataGridViewTextBoxColumn"
        Me.PRPRNODataGridViewTextBoxColumn.ReadOnly = True
        Me.PRPRNODataGridViewTextBoxColumn.Width = 140
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.FillWeight = 52.3622!
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateCreatedDataGridViewTextBoxColumn
        '
        Me.DateCreatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated"
        Me.DateCreatedDataGridViewTextBoxColumn.FillWeight = 52.3622!
        Me.DateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created"
        Me.DateCreatedDataGridViewTextBoxColumn.Name = "DateCreatedDataGridViewTextBoxColumn"
        Me.DateCreatedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateCreatedDataGridViewTextBoxColumn.Width = 150
        '
        'btnViewDetails
        '
        Me.btnViewDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.DefaultCellStyle = DataGridViewCellStyle5
        Me.btnViewDetails.FillWeight = 52.3622!
        Me.btnViewDetails.HeaderText = ""
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.ReadOnly = True
        Me.btnViewDetails.Text = "View Details"
        Me.btnViewDetails.UseColumnTextForButtonValue = True
        Me.btnViewDetails.Width = 110
        '
        'btnUpdateStatus
        '
        Me.btnUpdateStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStatus.DefaultCellStyle = DataGridViewCellStyle6
        Me.btnUpdateStatus.FillWeight = 52.3622!
        Me.btnUpdateStatus.HeaderText = ""
        Me.btnUpdateStatus.Name = "btnUpdateStatus"
        Me.btnUpdateStatus.ReadOnly = True
        Me.btnUpdateStatus.Text = "Update Status"
        Me.btnUpdateStatus.UseColumnTextForButtonValue = True
        Me.btnUpdateStatus.Width = 110
        '
        'PRPRNO1DataGridViewTextBoxColumn
        '
        Me.PRPRNO1DataGridViewTextBoxColumn.DataPropertyName = "PR_PRNO1"
        Me.PRPRNO1DataGridViewTextBoxColumn.HeaderText = "PR_PRNO1"
        Me.PRPRNO1DataGridViewTextBoxColumn.Name = "PRPRNO1DataGridViewTextBoxColumn"
        Me.PRPRNO1DataGridViewTextBoxColumn.ReadOnly = True
        Me.PRPRNO1DataGridViewTextBoxColumn.Visible = False
        '
        'MAXDATEDataGridViewTextBoxColumn
        '
        Me.MAXDATEDataGridViewTextBoxColumn.DataPropertyName = "MAXDATE"
        Me.MAXDATEDataGridViewTextBoxColumn.FillWeight = 52.3622!
        Me.MAXDATEDataGridViewTextBoxColumn.HeaderText = "MAXDATE"
        Me.MAXDATEDataGridViewTextBoxColumn.Name = "MAXDATEDataGridViewTextBoxColumn"
        Me.MAXDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.MAXDATEDataGridViewTextBoxColumn.Visible = False
        '
        'SPM4PMDPRLISTBindingSource
        '
        Me.SPM4PMDPRLISTBindingSource.DataMember = "SPM4_PMDPRLIST"
        Me.SPM4PMDPRLISTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.LBL_TOTALNOOFPR)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(190, 609)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(266, 45)
        Me.GroupBox4.TabIndex = 1413
        Me.GroupBox4.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(166, 19)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Total No. of Records :"
        '
        'LBL_TOTALNOOFPR
        '
        Me.LBL_TOTALNOOFPR.AutoSize = True
        Me.LBL_TOTALNOOFPR.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TOTALNOOFPR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_TOTALNOOFPR.Location = New System.Drawing.Point(177, 15)
        Me.LBL_TOTALNOOFPR.Name = "LBL_TOTALNOOFPR"
        Me.LBL_TOTALNOOFPR.Size = New System.Drawing.Size(21, 23)
        Me.LBL_TOTALNOOFPR.TabIndex = 5
        Me.LBL_TOTALNOOFPR.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Panel5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 519)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(181, 135)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status of encoded PR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(29, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pending"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(9, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(20, 29)
        Me.Panel5.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(31, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Canceled"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(30, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Accepted"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(8, 65)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(20, 29)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(8, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(20, 29)
        Me.Panel3.TabIndex = 2
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape9.CornerRadius = 15
        Me.RectangleShape9.Location = New System.Drawing.Point(189, 106)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(894, 43)
        '
        'TblV1_HRISEMPLOYEEDATATableAdapter
        '
        Me.TblV1_HRISEMPLOYEEDATATableAdapter.ClearBeforeFill = True
        '
        'APNL_VALIDATEPR
        '
        Me.APNL_VALIDATEPR.BackColor = System.Drawing.Color.White
        Me.APNL_VALIDATEPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.APNL_VALIDATEPR.Controls.Add(Me.PBICONSEARCH)
        Me.APNL_VALIDATEPR.Controls.Add(Me.WTXT_SEARCHPR)
        Me.APNL_VALIDATEPR.Controls.Add(Me.LLBL_VALIDATE_PRPREVIEW)
        Me.APNL_VALIDATEPR.Controls.Add(Me.PB_VALIDATE_PRPREVIEW)
        Me.APNL_VALIDATEPR.Controls.Add(Me.GroupBox2)
        Me.APNL_VALIDATEPR.Controls.Add(Me.GroupBox1)
        Me.APNL_VALIDATEPR.Controls.Add(Me.Panel23)
        Me.APNL_VALIDATEPR.Controls.Add(Me.BTN_CPR_CANCEL)
        Me.APNL_VALIDATEPR.Controls.Add(Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE)
        Me.APNL_VALIDATEPR.Controls.Add(Me.BTN_CPR_FORREVISION)
        Me.APNL_VALIDATEPR.Controls.Add(Me.BTN_CPR_ACCEPT)
        Me.APNL_VALIDATEPR.Controls.Add(Me.ShapeContainer3)
        Me.APNL_VALIDATEPR.Location = New System.Drawing.Point(1095, 0)
        Me.APNL_VALIDATEPR.Name = "APNL_VALIDATEPR"
        Me.APNL_VALIDATEPR.Size = New System.Drawing.Size(1095, 658)
        Me.APNL_VALIDATEPR.TabIndex = 1456
        '
        'PBICONSEARCH
        '
        Me.PBICONSEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_18dp
        Me.PBICONSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBICONSEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBICONSEARCH.InitialImage = Nothing
        Me.PBICONSEARCH.Location = New System.Drawing.Point(65, 51)
        Me.PBICONSEARCH.Name = "PBICONSEARCH"
        Me.PBICONSEARCH.Size = New System.Drawing.Size(35, 30)
        Me.PBICONSEARCH.TabIndex = 1410
        Me.PBICONSEARCH.TabStop = False
        '
        'WTXT_SEARCHPR
        '
        Me.WTXT_SEARCHPR.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SEARCHPR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCHPR.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCHPR.ForeColor = System.Drawing.Color.Black
        Me.WTXT_SEARCHPR.Location = New System.Drawing.Point(105, 53)
        Me.WTXT_SEARCHPR.MaxLength = 30
        Me.WTXT_SEARCHPR.Name = "WTXT_SEARCHPR"
        Me.WTXT_SEARCHPR.Size = New System.Drawing.Size(363, 26)
        Me.WTXT_SEARCHPR.TabIndex = 1409
        Me.WTXT_SEARCHPR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SEARCHPR.Watermark = "Search PR No."
        '
        'PB_VALIDATE_PRPREVIEW
        '
        Me.PB_VALIDATE_PRPREVIEW.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.PB_VALIDATE_PRPREVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_VALIDATE_PRPREVIEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_VALIDATE_PRPREVIEW.Enabled = False
        Me.PB_VALIDATE_PRPREVIEW.InitialImage = Nothing
        Me.PB_VALIDATE_PRPREVIEW.Location = New System.Drawing.Point(960, 56)
        Me.PB_VALIDATE_PRPREVIEW.Name = "PB_VALIDATE_PRPREVIEW"
        Me.PB_VALIDATE_PRPREVIEW.Size = New System.Drawing.Size(32, 28)
        Me.PB_VALIDATE_PRPREVIEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_VALIDATE_PRPREVIEW.TabIndex = 1424
        Me.PB_VALIDATE_PRPREVIEW.TabStop = False
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel23.Controls.Add(Me.LLBL_INVENTORY_ENCODING_HEADER)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(30, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(1063, 35)
        Me.Panel23.TabIndex = 1401
        '
        'LLBL_INVENTORY_ENCODING_HEADER
        '
        Me.LLBL_INVENTORY_ENCODING_HEADER.AutoSize = True
        Me.LLBL_INVENTORY_ENCODING_HEADER.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_INVENTORY_ENCODING_HEADER.ForeColor = System.Drawing.Color.White
        Me.LLBL_INVENTORY_ENCODING_HEADER.Location = New System.Drawing.Point(11, 4)
        Me.LLBL_INVENTORY_ENCODING_HEADER.Name = "LLBL_INVENTORY_ENCODING_HEADER"
        Me.LLBL_INVENTORY_ENCODING_HEADER.Size = New System.Drawing.Size(443, 25)
        Me.LLBL_INVENTORY_ENCODING_HEADER.TabIndex = 8
        Me.LLBL_INVENTORY_ENCODING_HEADER.Text = "V A L I D A T E  P U R C H A S E  R E Q U E S T"
        '
        'BTN_CPR_CANCEL
        '
        Me.BTN_CPR_CANCEL.Enabled = False
        Me.BTN_CPR_CANCEL.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_CPR_CANCEL.FlatAppearance.BorderSize = 0
        Me.BTN_CPR_CANCEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_CPR_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_CPR_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CPR_CANCEL.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CPR_CANCEL.Image = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.BTN_CPR_CANCEL.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTN_CPR_CANCEL.Location = New System.Drawing.Point(981, 591)
        Me.BTN_CPR_CANCEL.Name = "BTN_CPR_CANCEL"
        Me.BTN_CPR_CANCEL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_CPR_CANCEL.Size = New System.Drawing.Size(102, 46)
        Me.BTN_CPR_CANCEL.TabIndex = 1436
        Me.BTN_CPR_CANCEL.Text = "CANCEL PR"
        Me.BTN_CPR_CANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CPR_CANCEL.UseVisualStyleBackColor = True
        '
        'BTN_CLOSE_VALIDATEPR_MINI_CLOSE
        '
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_double_arrow_black_18dp
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE.Location = New System.Drawing.Point(0, 0)
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE.Name = "BTN_CLOSE_VALIDATEPR_MINI_CLOSE"
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE.Size = New System.Drawing.Size(30, 656)
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE.TabIndex = 0
        Me.BTN_CLOSE_VALIDATEPR_MINI_CLOSE.UseVisualStyleBackColor = True
        '
        'BTN_CPR_FORREVISION
        '
        Me.BTN_CPR_FORREVISION.Enabled = False
        Me.BTN_CPR_FORREVISION.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_CPR_FORREVISION.FlatAppearance.BorderSize = 0
        Me.BTN_CPR_FORREVISION.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_CPR_FORREVISION.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_CPR_FORREVISION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CPR_FORREVISION.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CPR_FORREVISION.Image = Global.PRA_PIS.My.Resources.Resources.outline_refresh_black_18dp
        Me.BTN_CPR_FORREVISION.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BTN_CPR_FORREVISION.Location = New System.Drawing.Point(745, 567)
        Me.BTN_CPR_FORREVISION.Name = "BTN_CPR_FORREVISION"
        Me.BTN_CPR_FORREVISION.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_CPR_FORREVISION.Size = New System.Drawing.Size(102, 46)
        Me.BTN_CPR_FORREVISION.TabIndex = 1435
        Me.BTN_CPR_FORREVISION.Text = "FOR REVISION"
        Me.BTN_CPR_FORREVISION.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CPR_FORREVISION.UseVisualStyleBackColor = True
        Me.BTN_CPR_FORREVISION.Visible = False
        '
        'BTN_CPR_ACCEPT
        '
        Me.BTN_CPR_ACCEPT.Enabled = False
        Me.BTN_CPR_ACCEPT.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_CPR_ACCEPT.FlatAppearance.BorderSize = 0
        Me.BTN_CPR_ACCEPT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_CPR_ACCEPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_CPR_ACCEPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CPR_ACCEPT.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CPR_ACCEPT.Image = Global.PRA_PIS.My.Resources.Resources.outline_check_black_18dp
        Me.BTN_CPR_ACCEPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_CPR_ACCEPT.Location = New System.Drawing.Point(870, 592)
        Me.BTN_CPR_ACCEPT.Name = "BTN_CPR_ACCEPT"
        Me.BTN_CPR_ACCEPT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_CPR_ACCEPT.Size = New System.Drawing.Size(102, 46)
        Me.BTN_CPR_ACCEPT.TabIndex = 1434
        Me.BTN_CPR_ACCEPT.Text = "ACCEPT"
        Me.BTN_CPR_ACCEPT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CPR_ACCEPT.UseVisualStyleBackColor = True
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_PRSEARCH, Me.RectangleShape11, Me.RectangleShape8, Me.RectangleShape4})
        Me.ShapeContainer3.Size = New System.Drawing.Size(1093, 656)
        Me.ShapeContainer3.TabIndex = 1437
        Me.ShapeContainer3.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RECT_INVENTORY_NEW_SAVE, Me.RectangleShape9})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1095, 660)
        Me.ShapeContainer1.TabIndex = 1457
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.CornerRadius = 19
        Me.RectangleShape5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape5.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(187, 58)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(172, 39)
        '
        'RECT_INVENTORY_NEW_SAVE
        '
        Me.RECT_INVENTORY_NEW_SAVE.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_INVENTORY_NEW_SAVE.BorderWidth = 2
        Me.RECT_INVENTORY_NEW_SAVE.CornerRadius = 19
        Me.RECT_INVENTORY_NEW_SAVE.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_INVENTORY_NEW_SAVE.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_INVENTORY_NEW_SAVE.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_INVENTORY_NEW_SAVE.Location = New System.Drawing.Point(10, 58)
        Me.RECT_INVENTORY_NEW_SAVE.Name = "RECT_INVENTORY_NEW_SAVE"
        Me.RECT_INVENTORY_NEW_SAVE.Size = New System.Drawing.Size(173, 39)
        '
        'LLBL_VALIDATE_PR
        '
        Me.LLBL_VALIDATE_PR.AutoSize = True
        Me.LLBL_VALIDATE_PR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_VALIDATE_PR.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_VALIDATE_PR.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_VALIDATE_PR.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_VALIDATE_PR.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_VALIDATE_PR.Location = New System.Drawing.Point(61, 68)
        Me.LLBL_VALIDATE_PR.Name = "LLBL_VALIDATE_PR"
        Me.LLBL_VALIDATE_PR.Size = New System.Drawing.Size(112, 19)
        Me.LLBL_VALIDATE_PR.TabIndex = 1458
        Me.LLBL_VALIDATE_PR.TabStop = True
        Me.LLBL_VALIDATE_PR.Text = "VALIDATE PR"
        '
        'LLBL_VALIDATE_PR_VIEW_REPORT
        '
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.AutoSize = True
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.Location = New System.Drawing.Point(233, 68)
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.Name = "LLBL_VALIDATE_PR_VIEW_REPORT"
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.Size = New System.Drawing.Size(115, 19)
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.TabIndex = 1460
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.TabStop = True
        Me.LLBL_VALIDATE_PR_VIEW_REPORT.Text = "VIEW REPORT"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Panel13)
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Panel11)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Panel12)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Panel10)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Panel9)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Panel1)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Panel6)
        Me.GroupBox5.Controls.Add(Me.Panel7)
        Me.GroupBox5.Controls.Add(Me.Panel8)
        Me.GroupBox5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(3, 148)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(181, 372)
        Me.GroupBox5.TabIndex = 1463
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Status for on-going PR"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(31, 315)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 16)
        Me.Label23.TabIndex = 1466
        Me.Label23.Text = "Pending"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.DimGray
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel13.Location = New System.Drawing.Point(8, 310)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(20, 29)
        Me.Panel13.TabIndex = 1465
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_subdirectory_arrow_right_black_18dp
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(187, 237)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 29)
        Me.PictureBox2.TabIndex = 1464
        Me.PictureBox2.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(222, 255)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 16)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "B. Delivered"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(30, 281)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 16)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Canceled PO"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Location = New System.Drawing.Point(8, 275)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(20, 29)
        Me.Panel11.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(30, 246)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 16)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "For Proofing"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel12.Location = New System.Drawing.Point(8, 240)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(20, 29)
        Me.Panel12.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(220, 236)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 16)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "A. For Delivery"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(29, 214)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 16)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "PO/Contract Issued"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Blue
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Location = New System.Drawing.Point(8, 208)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(20, 29)
        Me.Panel10.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(30, 179)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Awarded"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Location = New System.Drawing.Point(8, 173)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(20, 29)
        Me.Panel9.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(28, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "BAC Resolution Issued"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(8, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(20, 29)
        Me.Panel1.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(31, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 16)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "For BAC Agenda"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(29, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "For Evaluation"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(30, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Posted"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MediumOrchid
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(8, 103)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(20, 29)
        Me.Panel6.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Location = New System.Drawing.Point(8, 33)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(20, 29)
        Me.Panel7.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Location = New System.Drawing.Point(8, 68)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(20, 29)
        Me.Panel8.TabIndex = 1
        '
        'PB_CLEARSEARCH
        '
        Me.PB_CLEARSEARCH.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_cancel_black_18dp
        Me.PB_CLEARSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_CLEARSEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_CLEARSEARCH.InitialImage = Nothing
        Me.PB_CLEARSEARCH.Location = New System.Drawing.Point(1049, 115)
        Me.PB_CLEARSEARCH.Name = "PB_CLEARSEARCH"
        Me.PB_CLEARSEARCH.Size = New System.Drawing.Size(25, 25)
        Me.PB_CLEARSEARCH.TabIndex = 1462
        Me.PB_CLEARSEARCH.TabStop = False
        Me.PB_CLEARSEARCH.Visible = False
        '
        'PB_VALIDATE_PR_VIEW_REPORT
        '
        Me.PB_VALIDATE_PR_VIEW_REPORT.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_print_black_18dp
        Me.PB_VALIDATE_PR_VIEW_REPORT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_VALIDATE_PR_VIEW_REPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_VALIDATE_PR_VIEW_REPORT.InitialImage = Nothing
        Me.PB_VALIDATE_PR_VIEW_REPORT.Location = New System.Drawing.Point(199, 63)
        Me.PB_VALIDATE_PR_VIEW_REPORT.Name = "PB_VALIDATE_PR_VIEW_REPORT"
        Me.PB_VALIDATE_PR_VIEW_REPORT.Size = New System.Drawing.Size(32, 28)
        Me.PB_VALIDATE_PR_VIEW_REPORT.TabIndex = 1461
        Me.PB_VALIDATE_PR_VIEW_REPORT.TabStop = False
        '
        'PB_VALIDATE_PR
        '
        Me.PB_VALIDATE_PR.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_playlist_add_check_black_18dp
        Me.PB_VALIDATE_PR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_VALIDATE_PR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_VALIDATE_PR.InitialImage = Nothing
        Me.PB_VALIDATE_PR.Location = New System.Drawing.Point(27, 64)
        Me.PB_VALIDATE_PR.Name = "PB_VALIDATE_PR"
        Me.PB_VALIDATE_PR.Size = New System.Drawing.Size(32, 28)
        Me.PB_VALIDATE_PR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_VALIDATE_PR.TabIndex = 1459
        Me.PB_VALIDATE_PR.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_search_black_18dp
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(198, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.TabIndex = 1409
        Me.PictureBox1.TabStop = False
        '
        'TblM4_PURCHASEREQUESTTableAdapter
        '
        Me.TblM4_PURCHASEREQUESTTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUEST_ITEMTableAdapter
        '
        Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUEST_CANCELEDTableAdapter
        '
        Me.TblM4_PURCHASEREQUEST_CANCELEDTableAdapter.ClearBeforeFill = True
        '
        'TblM4_PURCHASEREQUEST_REVISIONTableAdapter
        '
        Me.TblM4_PURCHASEREQUEST_REVISIONTableAdapter.ClearBeforeFill = True
        '
        'WTXT_SEARCHLIST_PR
        '
        Me.WTXT_SEARCHLIST_PR.BackColor = System.Drawing.SystemColors.Window
        Me.WTXT_SEARCHLIST_PR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCHLIST_PR.Font = New System.Drawing.Font("Century Gothic", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCHLIST_PR.ForeColor = System.Drawing.Color.Black
        Me.WTXT_SEARCHLIST_PR.Location = New System.Drawing.Point(241, 113)
        Me.WTXT_SEARCHLIST_PR.MaxLength = 30
        Me.WTXT_SEARCHLIST_PR.Name = "WTXT_SEARCHLIST_PR"
        Me.WTXT_SEARCHLIST_PR.Size = New System.Drawing.Size(796, 31)
        Me.WTXT_SEARCHLIST_PR.TabIndex = 1410
        Me.WTXT_SEARCHLIST_PR.Watermark = "Search PR No./Description"
        '
        'SPM4_PURCHASELISTBindingSource
        '
        Me.SPM4_PURCHASELISTBindingSource.DataMember = "SPM4_PURCHASELIST"
        '
        'SPM4PURCHASELISTBindingSource
        '
        Me.SPM4PURCHASELISTBindingSource.DataMember = "SPM4_PURCHASELIST"
        Me.SPM4PURCHASELISTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_PURCHASELISTTableAdapter
        '
        Me.SPM4_PURCHASELISTTableAdapter.ClearBeforeFill = True
        '
        'SPM4_PMDPRLISTTableAdapter
        '
        Me.SPM4_PMDPRLISTTableAdapter.ClearBeforeFill = True
        '
        'FRM_CHECK_PR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1095, 660)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.PB_CLEARSEARCH)
        Me.Controls.Add(Me.PB_VALIDATE_PR_VIEW_REPORT)
        Me.Controls.Add(Me.LLBL_VALIDATE_PR_VIEW_REPORT)
        Me.Controls.Add(Me.PB_VALIDATE_PR)
        Me.Controls.Add(Me.LLBL_VALIDATE_PR)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DGV_PRLIST)
        Me.Controls.Add(Me.WTXT_SEARCHLIST_PR)
        Me.Controls.Add(Me.APNL_VALIDATEPR)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_CHECK_PR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FRM_CHECK_PR"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_PR_ITEMLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_PRLIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4PMDPRLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.APNL_VALIDATEPR.ResumeLayout(False)
        Me.APNL_VALIDATEPR.PerformLayout()
        CType(Me.PBICONSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_VALIDATE_PRPREVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_CLEARSEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_VALIDATE_PR_VIEW_REPORT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_VALIDATE_PR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_PURCHASELISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4PURCHASELISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_PRMINIMIZE As Button
    Friend WithEvents BTN_PRCLOSE As Button
    Friend WithEvents Label39 As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents WTXT_SEARCHPR As WatermarkTextBox
    Friend WithEvents PBICONSEARCH As PictureBox
    Friend WithEvents RECT_PRSEARCH As PowerPacks.RectangleShape
    Friend WithEvents WTXT_APPCODE As WatermarkTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_PRAPPCODE As PowerPacks.RectangleShape
    Friend WithEvents Label8 As Label
    Friend WithEvents WTXT_REQUESTEDDATE As WatermarkTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RECT_PRREQUESTEDDATE As PowerPacks.RectangleShape
    Friend WithEvents Label9 As Label
    Friend WithEvents WTXT_SUBMITTEDBY As WatermarkTextBox
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
    Friend WithEvents Label1 As Label
    Friend WithEvents WTXT_DEPARTMENT As WatermarkTextBox
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label2 As Label
    Friend WithEvents WTXT_DIVISION As WatermarkTextBox
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_PURPOSE As WatermarkTextBox
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTN_CPR_ACCEPT As Button
    Friend WithEvents BTN_CPR_CANCEL As Button
    Friend WithEvents BTN_CPR_FORREVISION As Button
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LBL_TOTALNOOFPR As Label
    Friend WithEvents DGV_PRLIST As DataGridView
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TblV1_HRISEMPLOYEEDATATableAdapter As DS_TABLESTableAdapters.tblV1_HRISEMPLOYEEDATATableAdapter
    Friend WithEvents TblM4_PURCHASEREQUESTTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUESTTableAdapter
    Friend WithEvents TblM4_PURCHASEREQUEST_ITEMTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_ITEMTableAdapter
    Friend WithEvents LBL_SIGN As Label
    Friend WithEvents LLBL_TOTALESTIMATEDCOST As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DGV_PR_ITEMLIST As DataGridView
    Friend WithEvents WTXT_SEARCHLIST_PR As WatermarkTextBox
    Friend WithEvents Itemdescription As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents UnitOfIssue As DataGridViewTextBoxColumn
    Friend WithEvents StockNo As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedUnitCost As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedCost As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents RectangleShape11 As PowerPacks.RectangleShape
    Friend WithEvents LLBL_VALIDATE_PRPREVIEW As LinkLabel
    Friend WithEvents PB_VALIDATE_PRPREVIEW As PictureBox
    Friend WithEvents APNL_VALIDATEPR As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents LLBL_INVENTORY_ENCODING_HEADER As Label
    Friend WithEvents BTN_CLOSE_VALIDATEPR_MINI_CLOSE As Button
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents PB_VALIDATE_PR As PictureBox
    Friend WithEvents LLBL_VALIDATE_PR As LinkLabel
    Friend WithEvents RECT_INVENTORY_NEW_SAVE As PowerPacks.RectangleShape
    Friend WithEvents PB_VALIDATE_PR_VIEW_REPORT As PictureBox
    Friend WithEvents LLBL_VALIDATE_PR_VIEW_REPORT As LinkLabel
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents PB_CLEARSEARCH As PictureBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BTN_INMA_MINIMIZE As Button
    Friend WithEvents BTN_INMA_CLOSE As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents TblM4_PURCHASEREQUEST_CANCELEDTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_CANCELEDTableAdapter
    Friend WithEvents TblM4_PURCHASEREQUEST_REVISIONTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_PURCHASEREQUEST_REVISIONTableAdapter
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents SPM4_PURCHASELISTBindingSource As BindingSource
    Friend WithEvents SPM4_PURCHASELISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_PURCHASELISTTableAdapter
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SPM4PURCHASELISTBindingSource As BindingSource
    Friend WithEvents StatusOfOngoingPRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRSTATUSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRPRNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnViewDetails As DataGridViewButtonColumn
    Friend WithEvents btnUpdateStatus As DataGridViewButtonColumn
    Friend WithEvents PRPRNO1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MAXDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPM4PMDPRLISTBindingSource As BindingSource
    Friend WithEvents SPM4_PMDPRLISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_PMDPRLISTTableAdapter
End Class
