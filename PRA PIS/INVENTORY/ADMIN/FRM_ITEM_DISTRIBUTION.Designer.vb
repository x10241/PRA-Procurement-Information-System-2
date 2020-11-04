<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_ITEM_DISTRIBUTION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ITEM_DISTRIBUTION))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_INVENTORY_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_ITEM_DISTRIBUTION_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.GB_ITEM_DETAILS = New System.Windows.Forms.GroupBox()
        Me.CB_ITEM_DISTRIBUTION_DIVISION = New System.Windows.Forms.ComboBox()
        Me.TblV1HRISDIVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_TABLES = New PRA_PIS.DS_TABLES()
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT = New System.Windows.Forms.ComboBox()
        Me.TblV1HRISDEPARTMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_DIVISION = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_DEPARTMENT = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.WTXT_SEARCH_ITEM_LIST = New PRA_PIS.WatermarkTextBox()
        Me.PB_ITEM_LIST_CLEAR = New System.Windows.Forms.PictureBox()
        Me.PB_INVENTORY_SEARCH = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV_ITEMLIST = New System.Windows.Forms.DataGridView()
        Me.ItemCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandProviderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofAcquisitionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemListDistributionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_CUSTOM = New PRA_PIS.DS_CUSTOM()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGV_ITEMDISTRIBUTION = New System.Windows.Forms.DataGridView()
        Me.division = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMCODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BRAND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Productno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unittype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateofacquisition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.div_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WTXT_SEARCH_ITEM_DISTRIBUTION = New PRA_PIS.WatermarkTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TblV1_HRISDEPARTMENTTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter()
        Me.TblV1_HRISDIVISIONTableAdapter = New PRA_PIS.DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter()
        Me.SPM4_ITEM_LIST_FOR_DISTRIBUTIONTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_LIST_FOR_DISTRIBUTIONTableAdapter()
        Me.TableAdapterManager1 = New PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager()
        Me.SPM4_ITEM_DISTRIBUTION_NOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_DISTRIBUTION_NOTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_DISTRIBUTION_NOTableAdapter()
        Me.SpM4_ITEM_DISTRIBUTION_STOCKTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_DISTRIBUTION_STOCKTableAdapter()
        Me.GRP_ITEMINFO = New System.Windows.Forms.GroupBox()
        Me.WTXT_REF_NO = New PRA_PIS.WatermarkTextBox()
        Me.SPM4ITEMDISTDGVBYREFNOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.WTXT_REQ_TYPE = New PRA_PIS.WatermarkTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WTXT_PURPOSE = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_FOR_THE_PERIOD = New PRA_PIS.WatermarkTextBox()
        Me.LLBL_CLOSE = New System.Windows.Forms.LinkLabel()
        Me.LLBL_SAVE_ADD_ITEM = New System.Windows.Forms.LinkLabel()
        Me.WTXT_DATE_NEEDED = New PRA_PIS.WatermarkTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PBOX_PRNOQRCODE = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape15 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape14 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRREQUESTEDDATE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_PRAPPCODE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.VWM4_REQUISITIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.PB_SAVE = New System.Windows.Forms.PictureBox()
        Me.LLBL_SAVE = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_ITEM_LIST = New System.Windows.Forms.DataGridView()
        Me.ITEMCODEDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITMUNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remstock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTN_ADD_STOCK = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.REQNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQPURPOSEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQDATENEEDEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REQDATEPERIODDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBLM4INVENTORYITEMREQUISITIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.RECT_SAVE = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RECT_CANCEL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.PB_CANCEL = New System.Windows.Forms.PictureBox()
        Me.LLBL_CANCEL = New System.Windows.Forms.LinkLabel()
        Me.TableAdapterManager = New PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager()
        Me.TblM4_INVENTORY_ITEMS_DISTRIBUTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter()
        Me.TBLM4INVENTORYREQUISITIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INVENTORY_REQUISITIONTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_REQUISITIONTableAdapter()
        Me.TblM4INVENTORYITEMSDISTRIBUTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4INVENTORYREQUISITIONBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemForDistributionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_IQ_REQ_DISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_IQ_REQ_DISTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_IQ_REQ_DISTTableAdapter()
        Me.VWM4_REQUISITIONTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_REQUISITIONTableAdapter()
        Me.SPM4_ITEM_DIST_DGV_BY_REF_NOTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_DIST_DGV_BY_REF_NOTableAdapter()
        Me.SPM4_ITEM_DIST_DGV_BY_REF_NOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMSTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMSTableAdapter()
        Me.PNL.SuspendLayout()
        Me.GB_ITEM_DETAILS.SuspendLayout()
        CType(Me.TblV1HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblV1HRISDEPARTMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ITEM_LIST_CLEAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_ITEMLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListDistributionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_ITEMDISTRIBUTION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_DISTRIBUTION_NOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_ITEMINFO.SuspendLayout()
        CType(Me.SPM4ITEMDISTDGVBYREFNOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_SAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_ITEM_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVENTORYITEMREQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_CANCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4_INVENTORY_ITEMS_DISTRIBUTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVENTORYREQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblM4INVENTORYITEMSDISTRIBUTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4INVENTORYREQUISITIONBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDistributionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_IQ_REQ_DISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4_ITEM_DIST_DGV_BY_REF_NOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_INVENTORY_CLOSE)
        Me.PNL.Controls.Add(Me.BTN_ITEM_DISTRIBUTION_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(5)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(1126, 49)
        Me.PNL.TabIndex = 1406
        '
        'BTN_INVENTORY_CLOSE
        '
        Me.BTN_INVENTORY_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_INVENTORY_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_INVENTORY_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_INVENTORY_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_INVENTORY_CLOSE.Location = New System.Drawing.Point(1090, 7)
        Me.BTN_INVENTORY_CLOSE.Name = "BTN_INVENTORY_CLOSE"
        Me.BTN_INVENTORY_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_INVENTORY_CLOSE.TabIndex = 17
        Me.BTN_INVENTORY_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_INVENTORY_CLOSE.UseVisualStyleBackColor = True
        '
        'BTN_ITEM_DISTRIBUTION_CLOSE
        '
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.close_icon_white
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.Location = New System.Drawing.Point(1238, 12)
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.Name = "BTN_ITEM_DISTRIBUTION_CLOSE"
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.Size = New System.Drawing.Size(30, 30)
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.TabIndex = 16
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ITEM_DISTRIBUTION_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(11, 14)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(232, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "I t e m  D i s t r i b u t i o n"
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
        Me.BTN_Minimize.Location = New System.Drawing.Point(-7934, 11)
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
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-7887, 10)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(5)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(50, 48)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'GB_ITEM_DETAILS
        '
        Me.GB_ITEM_DETAILS.Controls.Add(Me.CB_ITEM_DISTRIBUTION_DIVISION)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.CB_ITEM_DISTRIBUTION_DEPARTMENT)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.Label4)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.Label2)
        Me.GB_ITEM_DETAILS.Controls.Add(Me.ShapeContainer1)
        Me.GB_ITEM_DETAILS.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_ITEM_DETAILS.ForeColor = System.Drawing.Color.DimGray
        Me.GB_ITEM_DETAILS.Location = New System.Drawing.Point(1280, 57)
        Me.GB_ITEM_DETAILS.Name = "GB_ITEM_DETAILS"
        Me.GB_ITEM_DETAILS.Size = New System.Drawing.Size(709, 66)
        Me.GB_ITEM_DETAILS.TabIndex = 1478
        Me.GB_ITEM_DETAILS.TabStop = False
        Me.GB_ITEM_DETAILS.Text = "Select Department/Division"
        '
        'CB_ITEM_DISTRIBUTION_DIVISION
        '
        Me.CB_ITEM_DISTRIBUTION_DIVISION.DataSource = Me.TblV1HRISDIVISIONBindingSource
        Me.CB_ITEM_DISTRIBUTION_DIVISION.DisplayMember = "HDIV_DIVISION"
        Me.CB_ITEM_DISTRIBUTION_DIVISION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ITEM_DISTRIBUTION_DIVISION.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ITEM_DISTRIBUTION_DIVISION.FormattingEnabled = True
        Me.CB_ITEM_DISTRIBUTION_DIVISION.Location = New System.Drawing.Point(391, 32)
        Me.CB_ITEM_DISTRIBUTION_DIVISION.Name = "CB_ITEM_DISTRIBUTION_DIVISION"
        Me.CB_ITEM_DISTRIBUTION_DIVISION.Size = New System.Drawing.Size(309, 24)
        Me.CB_ITEM_DISTRIBUTION_DIVISION.TabIndex = 1491
        Me.CB_ITEM_DISTRIBUTION_DIVISION.ValueMember = "HDIVS_CODE"
        '
        'TblV1HRISDIVISIONBindingSource
        '
        Me.TblV1HRISDIVISIONBindingSource.DataMember = "tblV1_HRISDIVISION"
        Me.TblV1HRISDIVISIONBindingSource.DataSource = Me.DS_TABLES
        '
        'DS_TABLES
        '
        Me.DS_TABLES.DataSetName = "DS_TABLES"
        Me.DS_TABLES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CB_ITEM_DISTRIBUTION_DEPARTMENT
        '
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.DataSource = Me.TblV1HRISDEPARTMENTBindingSource
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.DisplayMember = "HDPT_DEPARTMENT"
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.FormattingEnabled = True
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.Location = New System.Drawing.Point(13, 32)
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.Name = "CB_ITEM_DISTRIBUTION_DEPARTMENT"
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.Size = New System.Drawing.Size(367, 24)
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.TabIndex = 1485
        Me.CB_ITEM_DISTRIBUTION_DEPARTMENT.ValueMember = "HDPT_CODE"
        '
        'TblV1HRISDEPARTMENTBindingSource
        '
        Me.TblV1HRISDEPARTMENTBindingSource.DataMember = "tblV1_HRISDEPARTMENT"
        Me.TblV1HRISDEPARTMENTBindingSource.DataSource = Me.DS_TABLES
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(399, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 1484
        Me.Label4.Text = "Division"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(22, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 1482
        Me.Label2.Text = "Department"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_DIVISION, Me.RECT_DEPARTMENT})
        Me.ShapeContainer1.Size = New System.Drawing.Size(703, 44)
        Me.ShapeContainer1.TabIndex = 1480
        Me.ShapeContainer1.TabStop = False
        '
        'RECT_DIVISION
        '
        Me.RECT_DIVISION.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_DIVISION.CornerRadius = 5
        Me.RECT_DIVISION.Location = New System.Drawing.Point(384, 9)
        Me.RECT_DIVISION.Name = "RECT_DIVISION"
        Me.RECT_DIVISION.Size = New System.Drawing.Size(315, 30)
        '
        'RECT_DEPARTMENT
        '
        Me.RECT_DEPARTMENT.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_DEPARTMENT.CornerRadius = 5
        Me.RECT_DEPARTMENT.Location = New System.Drawing.Point(6, 9)
        Me.RECT_DEPARTMENT.Name = "RECT_DEPARTMENT"
        Me.RECT_DEPARTMENT.Size = New System.Drawing.Size(373, 30)
        '
        'WTXT_SEARCH_ITEM_LIST
        '
        Me.WTXT_SEARCH_ITEM_LIST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCH_ITEM_LIST.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCH_ITEM_LIST.Location = New System.Drawing.Point(43, 23)
        Me.WTXT_SEARCH_ITEM_LIST.Name = "WTXT_SEARCH_ITEM_LIST"
        Me.WTXT_SEARCH_ITEM_LIST.Size = New System.Drawing.Size(1175, 24)
        Me.WTXT_SEARCH_ITEM_LIST.TabIndex = 1483
        Me.WTXT_SEARCH_ITEM_LIST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SEARCH_ITEM_LIST.Watermark = "Search Item Code, Brand,Subcategory, Item Description"
        '
        'PB_ITEM_LIST_CLEAR
        '
        Me.PB_ITEM_LIST_CLEAR.BackgroundImage = CType(resources.GetObject("PB_ITEM_LIST_CLEAR.BackgroundImage"), System.Drawing.Image)
        Me.PB_ITEM_LIST_CLEAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_ITEM_LIST_CLEAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ITEM_LIST_CLEAR.InitialImage = Nothing
        Me.PB_ITEM_LIST_CLEAR.Location = New System.Drawing.Point(1224, 21)
        Me.PB_ITEM_LIST_CLEAR.Name = "PB_ITEM_LIST_CLEAR"
        Me.PB_ITEM_LIST_CLEAR.Size = New System.Drawing.Size(32, 28)
        Me.PB_ITEM_LIST_CLEAR.TabIndex = 1484
        Me.PB_ITEM_LIST_CLEAR.TabStop = False
        Me.PB_ITEM_LIST_CLEAR.Visible = False
        '
        'PB_INVENTORY_SEARCH
        '
        Me.PB_INVENTORY_SEARCH.BackgroundImage = CType(resources.GetObject("PB_INVENTORY_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_INVENTORY_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_INVENTORY_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_INVENTORY_SEARCH.InitialImage = Nothing
        Me.PB_INVENTORY_SEARCH.Location = New System.Drawing.Point(8, 21)
        Me.PB_INVENTORY_SEARCH.Name = "PB_INVENTORY_SEARCH"
        Me.PB_INVENTORY_SEARCH.Size = New System.Drawing.Size(32, 28)
        Me.PB_INVENTORY_SEARCH.TabIndex = 1485
        Me.PB_INVENTORY_SEARCH.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_ITEMLIST)
        Me.GroupBox1.Controls.Add(Me.PB_ITEM_LIST_CLEAR)
        Me.GroupBox1.Controls.Add(Me.WTXT_SEARCH_ITEM_LIST)
        Me.GroupBox1.Controls.Add(Me.PB_INVENTORY_SEARCH)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.Location = New System.Drawing.Point(992, 697)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(48, 59)
        Me.GroupBox1.TabIndex = 1486
        Me.GroupBox1.TabStop = False
        '
        'DGV_ITEMLIST
        '
        Me.DGV_ITEMLIST.AllowUserToAddRows = False
        Me.DGV_ITEMLIST.AllowUserToDeleteRows = False
        Me.DGV_ITEMLIST.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_ITEMLIST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ITEMLIST.AutoGenerateColumns = False
        Me.DGV_ITEMLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ITEMLIST.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_ITEMLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEMLIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCodeDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.SubCategoryDataGridViewTextBoxColumn, Me.BrandProviderDataGridViewTextBoxColumn, Me.SerialNoDataGridViewTextBoxColumn, Me.ItemDescriptionDataGridViewTextBoxColumn, Me.UnitTypeDataGridViewTextBoxColumn, Me.UnitCostDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.DateofAcquisitionDataGridViewTextBoxColumn})
        Me.DGV_ITEMLIST.DataSource = Me.ItemListDistributionBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ITEMLIST.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ITEMLIST.Location = New System.Drawing.Point(5, 55)
        Me.DGV_ITEMLIST.MultiSelect = False
        Me.DGV_ITEMLIST.Name = "DGV_ITEMLIST"
        Me.DGV_ITEMLIST.ReadOnly = True
        Me.DGV_ITEMLIST.RowHeadersVisible = False
        Me.DGV_ITEMLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEMLIST.Size = New System.Drawing.Size(1254, 232)
        Me.DGV_ITEMLIST.TabIndex = 1487
        '
        'ItemCodeDataGridViewTextBoxColumn
        '
        Me.ItemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode"
        Me.ItemCodeDataGridViewTextBoxColumn.HeaderText = "Item Code"
        Me.ItemCodeDataGridViewTextBoxColumn.Name = "ItemCodeDataGridViewTextBoxColumn"
        Me.ItemCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubCategoryDataGridViewTextBoxColumn
        '
        Me.SubCategoryDataGridViewTextBoxColumn.DataPropertyName = "SubCategory"
        Me.SubCategoryDataGridViewTextBoxColumn.HeaderText = "Sub Category"
        Me.SubCategoryDataGridViewTextBoxColumn.Name = "SubCategoryDataGridViewTextBoxColumn"
        Me.SubCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BrandProviderDataGridViewTextBoxColumn
        '
        Me.BrandProviderDataGridViewTextBoxColumn.DataPropertyName = "BrandProvider"
        Me.BrandProviderDataGridViewTextBoxColumn.HeaderText = "Brand/Provider"
        Me.BrandProviderDataGridViewTextBoxColumn.Name = "BrandProviderDataGridViewTextBoxColumn"
        Me.BrandProviderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerialNoDataGridViewTextBoxColumn
        '
        Me.SerialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo"
        Me.SerialNoDataGridViewTextBoxColumn.HeaderText = "Product No."
        Me.SerialNoDataGridViewTextBoxColumn.Name = "SerialNoDataGridViewTextBoxColumn"
        Me.SerialNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDescriptionDataGridViewTextBoxColumn
        '
        Me.ItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription"
        Me.ItemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.ItemDescriptionDataGridViewTextBoxColumn.Name = "ItemDescriptionDataGridViewTextBoxColumn"
        Me.ItemDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitTypeDataGridViewTextBoxColumn
        '
        Me.UnitTypeDataGridViewTextBoxColumn.DataPropertyName = "UnitType"
        Me.UnitTypeDataGridViewTextBoxColumn.HeaderText = "Unit Type"
        Me.UnitTypeDataGridViewTextBoxColumn.Name = "UnitTypeDataGridViewTextBoxColumn"
        Me.UnitTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitCostDataGridViewTextBoxColumn
        '
        Me.UnitCostDataGridViewTextBoxColumn.DataPropertyName = "UnitCost"
        Me.UnitCostDataGridViewTextBoxColumn.HeaderText = "Unit Cost"
        Me.UnitCostDataGridViewTextBoxColumn.Name = "UnitCostDataGridViewTextBoxColumn"
        Me.UnitCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalCostDataGridViewTextBoxColumn
        '
        Me.TotalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost"
        Me.TotalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost"
        Me.TotalCostDataGridViewTextBoxColumn.Name = "TotalCostDataGridViewTextBoxColumn"
        Me.TotalCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateofAcquisitionDataGridViewTextBoxColumn
        '
        Me.DateofAcquisitionDataGridViewTextBoxColumn.DataPropertyName = "DateofAcquisition"
        Me.DateofAcquisitionDataGridViewTextBoxColumn.HeaderText = "Date of Acquisition"
        Me.DateofAcquisitionDataGridViewTextBoxColumn.Name = "DateofAcquisitionDataGridViewTextBoxColumn"
        Me.DateofAcquisitionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemListDistributionBindingSource
        '
        Me.ItemListDistributionBindingSource.DataMember = "ItemListDistribution"
        Me.ItemListDistributionBindingSource.DataSource = Me.DS_CUSTOM
        '
        'DS_CUSTOM
        '
        Me.DS_CUSTOM.DataSetName = "DS_CUSTOM"
        Me.DS_CUSTOM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5})
        Me.ShapeContainer2.Size = New System.Drawing.Size(42, 40)
        Me.ShapeContainer2.TabIndex = 1486
        Me.ShapeContainer2.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape5.CornerRadius = 5
        Me.RectangleShape5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape5.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape5.Location = New System.Drawing.Point(2, 2)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(1253, 33)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DGV_ITEMDISTRIBUTION)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.WTXT_SEARCH_ITEM_DISTRIBUTION)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.ShapeContainer3)
        Me.GroupBox2.Location = New System.Drawing.Point(933, 702)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(53, 47)
        Me.GroupBox2.TabIndex = 1487
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(6, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(330, 15)
        Me.Label3.TabIndex = 1492
        Me.Label3.Text = "* Double click the selected item to remove from distribution."
        '
        'DGV_ITEMDISTRIBUTION
        '
        Me.DGV_ITEMDISTRIBUTION.AllowUserToAddRows = False
        Me.DGV_ITEMDISTRIBUTION.AllowUserToDeleteRows = False
        Me.DGV_ITEMDISTRIBUTION.AllowUserToResizeRows = False
        Me.DGV_ITEMDISTRIBUTION.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ITEMDISTRIBUTION.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ITEMDISTRIBUTION.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ITEMDISTRIBUTION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEMDISTRIBUTION.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.division, Me.ITEMCODE, Me.category, Me.subcategory, Me.BRAND, Me.Productno, Me.itemDesc, Me.unittype, Me.quantity, Me.dateofacquisition, Me.div_code, Me.dept_code})
        Me.DGV_ITEMDISTRIBUTION.Location = New System.Drawing.Point(5, 55)
        Me.DGV_ITEMDISTRIBUTION.MultiSelect = False
        Me.DGV_ITEMDISTRIBUTION.Name = "DGV_ITEMDISTRIBUTION"
        Me.DGV_ITEMDISTRIBUTION.ReadOnly = True
        Me.DGV_ITEMDISTRIBUTION.RowHeadersVisible = False
        Me.DGV_ITEMDISTRIBUTION.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEMDISTRIBUTION.Size = New System.Drawing.Size(1255, 254)
        Me.DGV_ITEMDISTRIBUTION.TabIndex = 1487
        '
        'division
        '
        Me.division.HeaderText = "Division"
        Me.division.Name = "division"
        Me.division.ReadOnly = True
        '
        'ITEMCODE
        '
        Me.ITEMCODE.HeaderText = "Item Code"
        Me.ITEMCODE.Name = "ITEMCODE"
        Me.ITEMCODE.ReadOnly = True
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'subcategory
        '
        Me.subcategory.HeaderText = "Sub Category"
        Me.subcategory.Name = "subcategory"
        Me.subcategory.ReadOnly = True
        '
        'BRAND
        '
        Me.BRAND.HeaderText = "Brand/Provider"
        Me.BRAND.Name = "BRAND"
        Me.BRAND.ReadOnly = True
        '
        'Productno
        '
        Me.Productno.HeaderText = "Product No."
        Me.Productno.Name = "Productno"
        Me.Productno.ReadOnly = True
        Me.Productno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Productno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'itemDesc
        '
        Me.itemDesc.HeaderText = "Item Description"
        Me.itemDesc.Name = "itemDesc"
        Me.itemDesc.ReadOnly = True
        Me.itemDesc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.itemDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'unittype
        '
        Me.unittype.HeaderText = "Unit Type"
        Me.unittype.Name = "unittype"
        Me.unittype.ReadOnly = True
        Me.unittype.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.unittype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dateofacquisition
        '
        Me.dateofacquisition.HeaderText = "Date of Acquisition"
        Me.dateofacquisition.Name = "dateofacquisition"
        Me.dateofacquisition.ReadOnly = True
        '
        'div_code
        '
        Me.div_code.HeaderText = "div_code"
        Me.div_code.Name = "div_code"
        Me.div_code.ReadOnly = True
        Me.div_code.Visible = False
        '
        'dept_code
        '
        Me.dept_code.HeaderText = "dept_code"
        Me.dept_code.Name = "dept_code"
        Me.dept_code.ReadOnly = True
        Me.dept_code.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(1226, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox2.TabIndex = 1484
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'WTXT_SEARCH_ITEM_DISTRIBUTION
        '
        Me.WTXT_SEARCH_ITEM_DISTRIBUTION.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_SEARCH_ITEM_DISTRIBUTION.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_SEARCH_ITEM_DISTRIBUTION.Location = New System.Drawing.Point(45, 23)
        Me.WTXT_SEARCH_ITEM_DISTRIBUTION.Name = "WTXT_SEARCH_ITEM_DISTRIBUTION"
        Me.WTXT_SEARCH_ITEM_DISTRIBUTION.Size = New System.Drawing.Size(1173, 24)
        Me.WTXT_SEARCH_ITEM_DISTRIBUTION.TabIndex = 1483
        Me.WTXT_SEARCH_ITEM_DISTRIBUTION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_SEARCH_ITEM_DISTRIBUTION.Watermark = "Search Item Code,Brand,Subcategory, Item Description"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(8, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox3.TabIndex = 1485
        Me.PictureBox3.TabStop = False
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer3.Size = New System.Drawing.Size(47, 28)
        Me.ShapeContainer3.TabIndex = 1486
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape1.CornerRadius = 5
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(2, 2)
        Me.RectangleShape1.Name = "RectangleShape5"
        Me.RectangleShape1.Size = New System.Drawing.Size(1255, 33)
        '
        'TblV1_HRISDEPARTMENTTableAdapter
        '
        Me.TblV1_HRISDEPARTMENTTableAdapter.ClearBeforeFill = True
        '
        'TblV1_HRISDIVISIONTableAdapter
        '
        Me.TblV1_HRISDIVISIONTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_LIST_FOR_DISTRIBUTIONTableAdapter
        '
        Me.SPM4_ITEM_LIST_FOR_DISTRIBUTIONTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.A_CLOSEPROGRAMTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PRA_PIS.DS_STOREDPROCTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SPM4_ITEM_DISTRIBUTION_NOTableAdapter
        '
        Me.SPM4_ITEM_DISTRIBUTION_NOTableAdapter.ClearBeforeFill = True
        '
        'SpM4_ITEM_DISTRIBUTION_STOCKTableAdapter
        '
        Me.SpM4_ITEM_DISTRIBUTION_STOCKTableAdapter.ClearBeforeFill = True
        '
        'GRP_ITEMINFO
        '
        Me.GRP_ITEMINFO.BackColor = System.Drawing.SystemColors.Window
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_REF_NO)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_REQ_TYPE)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label1)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label6)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_PURPOSE)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_FOR_THE_PERIOD)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_CLOSE)
        Me.GRP_ITEMINFO.Controls.Add(Me.LLBL_SAVE_ADD_ITEM)
        Me.GRP_ITEMINFO.Controls.Add(Me.WTXT_DATE_NEEDED)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label7)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label9)
        Me.GRP_ITEMINFO.Controls.Add(Me.Label10)
        Me.GRP_ITEMINFO.Controls.Add(Me.PBOX_PRNOQRCODE)
        Me.GRP_ITEMINFO.Controls.Add(Me.ShapeContainer4)
        Me.GRP_ITEMINFO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRP_ITEMINFO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GRP_ITEMINFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GRP_ITEMINFO.Location = New System.Drawing.Point(5, 52)
        Me.GRP_ITEMINFO.Name = "GRP_ITEMINFO"
        Me.GRP_ITEMINFO.Size = New System.Drawing.Size(301, 282)
        Me.GRP_ITEMINFO.TabIndex = 1491
        Me.GRP_ITEMINFO.TabStop = False
        Me.GRP_ITEMINFO.Text = "Requisition Details"
        '
        'WTXT_REF_NO
        '
        Me.WTXT_REF_NO.BackColor = System.Drawing.Color.White
        Me.WTXT_REF_NO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_REF_NO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4ITEMDISTDGVBYREFNOBindingSource, "REQ_NO", True))
        Me.WTXT_REF_NO.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_REF_NO.Location = New System.Drawing.Point(7, 39)
        Me.WTXT_REF_NO.Name = "WTXT_REF_NO"
        Me.WTXT_REF_NO.ReadOnly = True
        Me.WTXT_REF_NO.Size = New System.Drawing.Size(141, 21)
        Me.WTXT_REF_NO.TabIndex = 1536
        Me.WTXT_REF_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_REF_NO.Watermark = ""
        '
        'SPM4ITEMDISTDGVBYREFNOBindingSource
        '
        Me.SPM4ITEMDISTDGVBYREFNOBindingSource.DataMember = "SPM4_ITEM_DIST_DGV_BY_REF_NO"
        Me.SPM4ITEMDISTDGVBYREFNOBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WTXT_REQ_TYPE
        '
        Me.WTXT_REQ_TYPE.BackColor = System.Drawing.Color.White
        Me.WTXT_REQ_TYPE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_REQ_TYPE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4ITEMDISTDGVBYREFNOBindingSource, "REQ_TYPE", True))
        Me.WTXT_REQ_TYPE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_REQ_TYPE.Location = New System.Drawing.Point(9, 83)
        Me.WTXT_REQ_TYPE.Multiline = True
        Me.WTXT_REQ_TYPE.Name = "WTXT_REQ_TYPE"
        Me.WTXT_REQ_TYPE.ReadOnly = True
        Me.WTXT_REQ_TYPE.Size = New System.Drawing.Size(283, 24)
        Me.WTXT_REQ_TYPE.TabIndex = 1535
        Me.WTXT_REQ_TYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_REQ_TYPE.Watermark = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(17, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 1534
        Me.Label1.Text = "Requisition Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(17, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 1533
        Me.Label6.Text = "Purpose"
        '
        'WTXT_PURPOSE
        '
        Me.WTXT_PURPOSE.BackColor = System.Drawing.Color.White
        Me.WTXT_PURPOSE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_PURPOSE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4ITEMDISTDGVBYREFNOBindingSource, "REQ_PURPOSE", True))
        Me.WTXT_PURPOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_PURPOSE.Location = New System.Drawing.Point(10, 171)
        Me.WTXT_PURPOSE.Multiline = True
        Me.WTXT_PURPOSE.Name = "WTXT_PURPOSE"
        Me.WTXT_PURPOSE.ReadOnly = True
        Me.WTXT_PURPOSE.Size = New System.Drawing.Size(281, 98)
        Me.WTXT_PURPOSE.TabIndex = 1532
        Me.WTXT_PURPOSE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_PURPOSE.Watermark = ""
        '
        'WTXT_FOR_THE_PERIOD
        '
        Me.WTXT_FOR_THE_PERIOD.BackColor = System.Drawing.Color.White
        Me.WTXT_FOR_THE_PERIOD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_FOR_THE_PERIOD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4ITEMDISTDGVBYREFNOBindingSource, "REQ_DATE_PERIOD", True))
        Me.WTXT_FOR_THE_PERIOD.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_FOR_THE_PERIOD.Location = New System.Drawing.Point(11, 128)
        Me.WTXT_FOR_THE_PERIOD.Name = "WTXT_FOR_THE_PERIOD"
        Me.WTXT_FOR_THE_PERIOD.ReadOnly = True
        Me.WTXT_FOR_THE_PERIOD.Size = New System.Drawing.Size(280, 21)
        Me.WTXT_FOR_THE_PERIOD.TabIndex = 1490
        Me.WTXT_FOR_THE_PERIOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_FOR_THE_PERIOD.Watermark = ""
        '
        'LLBL_CLOSE
        '
        Me.LLBL_CLOSE.AutoSize = True
        Me.LLBL_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_CLOSE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_CLOSE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_CLOSE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_CLOSE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_CLOSE.Location = New System.Drawing.Point(454, 606)
        Me.LLBL_CLOSE.Name = "LLBL_CLOSE"
        Me.LLBL_CLOSE.Size = New System.Drawing.Size(61, 19)
        Me.LLBL_CLOSE.TabIndex = 1464
        Me.LLBL_CLOSE.TabStop = True
        Me.LLBL_CLOSE.Text = "CLOSE"
        '
        'LLBL_SAVE_ADD_ITEM
        '
        Me.LLBL_SAVE_ADD_ITEM.AutoSize = True
        Me.LLBL_SAVE_ADD_ITEM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_SAVE_ADD_ITEM.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_SAVE_ADD_ITEM.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE_ADD_ITEM.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_SAVE_ADD_ITEM.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE_ADD_ITEM.Location = New System.Drawing.Point(393, 606)
        Me.LLBL_SAVE_ADD_ITEM.Name = "LLBL_SAVE_ADD_ITEM"
        Me.LLBL_SAVE_ADD_ITEM.Size = New System.Drawing.Size(46, 19)
        Me.LLBL_SAVE_ADD_ITEM.TabIndex = 1463
        Me.LLBL_SAVE_ADD_ITEM.TabStop = True
        Me.LLBL_SAVE_ADD_ITEM.Text = "ADD"
        '
        'WTXT_DATE_NEEDED
        '
        Me.WTXT_DATE_NEEDED.BackColor = System.Drawing.Color.White
        Me.WTXT_DATE_NEEDED.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_DATE_NEEDED.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SPM4ITEMDISTDGVBYREFNOBindingSource, "REQ_DATE_NEEDED", True))
        Me.WTXT_DATE_NEEDED.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_DATE_NEEDED.Location = New System.Drawing.Point(158, 40)
        Me.WTXT_DATE_NEEDED.Name = "WTXT_DATE_NEEDED"
        Me.WTXT_DATE_NEEDED.ReadOnly = True
        Me.WTXT_DATE_NEEDED.Size = New System.Drawing.Size(133, 21)
        Me.WTXT_DATE_NEEDED.TabIndex = 1417
        Me.WTXT_DATE_NEEDED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_DATE_NEEDED.Watermark = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(164, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 1334
        Me.Label7.Text = "Date Needed"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(17, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 1435
        Me.Label9.Text = "For the period"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(17, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 1433
        Me.Label10.Text = "Ref. No."
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
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape4, Me.RectangleShape15, Me.RectangleShape14, Me.RECT_PRREQUESTEDDATE, Me.RECT_PRAPPCODE})
        Me.ShapeContainer4.Size = New System.Drawing.Size(295, 260)
        Me.ShapeContainer4.TabIndex = 1
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(2, 58)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(290, 33)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(2, 145)
        Me.RectangleShape2.Name = "RectangleShape1"
        Me.RectangleShape2.Size = New System.Drawing.Size(289, 108)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(2, 101)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(290, 33)
        '
        'RectangleShape15
        '
        Me.RectangleShape15.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape15.BorderWidth = 2
        Me.RectangleShape15.CornerRadius = 19
        Me.RectangleShape15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape15.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape15.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape15.Location = New System.Drawing.Point(447, 576)
        Me.RectangleShape15.Name = "RectangleShape15"
        Me.RectangleShape15.Size = New System.Drawing.Size(67, 39)
        '
        'RectangleShape14
        '
        Me.RectangleShape14.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape14.BorderWidth = 2
        Me.RectangleShape14.CornerRadius = 19
        Me.RectangleShape14.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape14.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape14.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape14.Location = New System.Drawing.Point(382, 576)
        Me.RectangleShape14.Name = "RectangleShape14"
        Me.RectangleShape14.Size = New System.Drawing.Size(62, 39)
        '
        'RECT_PRREQUESTEDDATE
        '
        Me.RECT_PRREQUESTEDDATE.BorderColor = System.Drawing.Color.Gray
        Me.RECT_PRREQUESTEDDATE.CornerRadius = 5
        Me.RECT_PRREQUESTEDDATE.Location = New System.Drawing.Point(150, 14)
        Me.RECT_PRREQUESTEDDATE.Name = "RECT_PRREQUESTEDDATE"
        Me.RECT_PRREQUESTEDDATE.Size = New System.Drawing.Size(142, 33)
        '
        'RECT_PRAPPCODE
        '
        Me.RECT_PRAPPCODE.BorderColor = System.Drawing.Color.Gray
        Me.RECT_PRAPPCODE.CornerRadius = 5
        Me.RECT_PRAPPCODE.Location = New System.Drawing.Point(2, 14)
        Me.RECT_PRAPPCODE.Name = "RECT_PRAPPCODE"
        Me.RECT_PRAPPCODE.Size = New System.Drawing.Size(145, 32)
        '
        'VWM4_REQUISITIONBindingSource
        '
        Me.VWM4_REQUISITIONBindingSource.DataMember = "VWM4_REQUISITION"
        Me.VWM4_REQUISITIONBindingSource.DataSource = Me.DS_VIEWS
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PB_SAVE
        '
        Me.PB_SAVE.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.outline_save_black_18dp
        Me.PB_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_SAVE.InitialImage = Nothing
        Me.PB_SAVE.Location = New System.Drawing.Point(800, 347)
        Me.PB_SAVE.Name = "PB_SAVE"
        Me.PB_SAVE.Size = New System.Drawing.Size(32, 28)
        Me.PB_SAVE.TabIndex = 1538
        Me.PB_SAVE.TabStop = False
        '
        'LLBL_SAVE
        '
        Me.LLBL_SAVE.AutoSize = True
        Me.LLBL_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_SAVE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_SAVE.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_SAVE.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE.Location = New System.Drawing.Point(832, 352)
        Me.LLBL_SAVE.Name = "LLBL_SAVE"
        Me.LLBL_SAVE.Size = New System.Drawing.Size(149, 19)
        Me.LLBL_SAVE.TabIndex = 1537
        Me.LLBL_SAVE.TabStop = True
        Me.LLBL_SAVE.Text = "Save Issued Item"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DGV_ITEM_LIST)
        Me.Panel1.Location = New System.Drawing.Point(309, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 274)
        Me.Panel1.TabIndex = 1498
        '
        'DGV_ITEM_LIST
        '
        Me.DGV_ITEM_LIST.AllowUserToAddRows = False
        Me.DGV_ITEM_LIST.AllowUserToDeleteRows = False
        Me.DGV_ITEM_LIST.AllowUserToResizeColumns = False
        Me.DGV_ITEM_LIST.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ITEM_LIST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_ITEM_LIST.AutoGenerateColumns = False
        Me.DGV_ITEM_LIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ITEM_LIST.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ITEM_LIST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_ITEM_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEM_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCODEDataGridViewTextBoxColumn2, Me.ITEMDESCDataGridViewTextBoxColumn, Me.ITMUNITDataGridViewTextBoxColumn, Me.REMSTOCKDataGridViewTextBoxColumn, Me.REQQTYDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.remstock, Me.BTN_ADD_STOCK, Me.REQNODataGridViewTextBoxColumn, Me.REQTYPEDataGridViewTextBoxColumn, Me.REQPURPOSEDataGridViewTextBoxColumn, Me.REQDATENEEDEDDataGridViewTextBoxColumn, Me.REQDATEPERIODDataGridViewTextBoxColumn})
        Me.DGV_ITEM_LIST.DataSource = Me.SPM4ITEMDISTDGVBYREFNOBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ITEM_LIST.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGV_ITEM_LIST.Location = New System.Drawing.Point(3, 3)
        Me.DGV_ITEM_LIST.MultiSelect = False
        Me.DGV_ITEM_LIST.Name = "DGV_ITEM_LIST"
        Me.DGV_ITEM_LIST.ReadOnly = True
        Me.DGV_ITEM_LIST.RowHeadersVisible = False
        Me.DGV_ITEM_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ITEM_LIST.Size = New System.Drawing.Size(806, 266)
        Me.DGV_ITEM_LIST.TabIndex = 1488
        '
        'ITEMCODEDataGridViewTextBoxColumn2
        '
        Me.ITEMCODEDataGridViewTextBoxColumn2.DataPropertyName = "ITEM_CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn2.HeaderText = "ITEM_CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn2.Name = "ITEMCODEDataGridViewTextBoxColumn2"
        Me.ITEMCODEDataGridViewTextBoxColumn2.ReadOnly = True
        Me.ITEMCODEDataGridViewTextBoxColumn2.Visible = False
        '
        'ITEMDESCDataGridViewTextBoxColumn
        '
        Me.ITEMDESCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ITEMDESCDataGridViewTextBoxColumn.DataPropertyName = "ITEM_DESC"
        Me.ITEMDESCDataGridViewTextBoxColumn.HeaderText = "Item Description"
        Me.ITEMDESCDataGridViewTextBoxColumn.Name = "ITEMDESCDataGridViewTextBoxColumn"
        Me.ITEMDESCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITMUNITDataGridViewTextBoxColumn
        '
        Me.ITMUNITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ITMUNITDataGridViewTextBoxColumn.DataPropertyName = "ITM_UNIT"
        Me.ITMUNITDataGridViewTextBoxColumn.HeaderText = "Unit type"
        Me.ITMUNITDataGridViewTextBoxColumn.Name = "ITMUNITDataGridViewTextBoxColumn"
        Me.ITMUNITDataGridViewTextBoxColumn.ReadOnly = True
        Me.ITMUNITDataGridViewTextBoxColumn.Width = 90
        '
        'REMSTOCKDataGridViewTextBoxColumn
        '
        Me.REMSTOCKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.REMSTOCKDataGridViewTextBoxColumn.DataPropertyName = "TOT_STOCK"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.REMSTOCKDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.REMSTOCKDataGridViewTextBoxColumn.HeaderText = "Total no. of stocks"
        Me.REMSTOCKDataGridViewTextBoxColumn.Name = "REMSTOCKDataGridViewTextBoxColumn"
        Me.REMSTOCKDataGridViewTextBoxColumn.ReadOnly = True
        Me.REMSTOCKDataGridViewTextBoxColumn.Width = 80
        '
        'REQQTYDataGridViewTextBoxColumn
        '
        Me.REQQTYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.REQQTYDataGridViewTextBoxColumn.DataPropertyName = "REQ_QTY"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.REQQTYDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.REQQTYDataGridViewTextBoxColumn.HeaderText = "Requested Quantity"
        Me.REQQTYDataGridViewTextBoxColumn.Name = "REQQTYDataGridViewTextBoxColumn"
        Me.REQQTYDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQQTYDataGridViewTextBoxColumn.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "APP_QTY"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Approve Quantity"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'remstock
        '
        Me.remstock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.remstock.DataPropertyName = "REM_STOCK"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.NullValue = "0"
        Me.remstock.DefaultCellStyle = DataGridViewCellStyle9
        Me.remstock.HeaderText = "Remaining Stock"
        Me.remstock.Name = "remstock"
        Me.remstock.ReadOnly = True
        Me.remstock.Width = 80
        '
        'BTN_ADD_STOCK
        '
        Me.BTN_ADD_STOCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.BTN_ADD_STOCK.HeaderText = "Action"
        Me.BTN_ADD_STOCK.Name = "BTN_ADD_STOCK"
        Me.BTN_ADD_STOCK.ReadOnly = True
        Me.BTN_ADD_STOCK.Text = "Set Approve Qty"
        Me.BTN_ADD_STOCK.UseColumnTextForButtonValue = True
        Me.BTN_ADD_STOCK.Width = 120
        '
        'REQNODataGridViewTextBoxColumn
        '
        Me.REQNODataGridViewTextBoxColumn.DataPropertyName = "REQ_NO"
        Me.REQNODataGridViewTextBoxColumn.HeaderText = "REQ_NO"
        Me.REQNODataGridViewTextBoxColumn.Name = "REQNODataGridViewTextBoxColumn"
        Me.REQNODataGridViewTextBoxColumn.ReadOnly = True
        Me.REQNODataGridViewTextBoxColumn.Visible = False
        '
        'REQTYPEDataGridViewTextBoxColumn
        '
        Me.REQTYPEDataGridViewTextBoxColumn.DataPropertyName = "REQ_TYPE"
        Me.REQTYPEDataGridViewTextBoxColumn.HeaderText = "REQ_TYPE"
        Me.REQTYPEDataGridViewTextBoxColumn.Name = "REQTYPEDataGridViewTextBoxColumn"
        Me.REQTYPEDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQTYPEDataGridViewTextBoxColumn.Visible = False
        '
        'REQPURPOSEDataGridViewTextBoxColumn
        '
        Me.REQPURPOSEDataGridViewTextBoxColumn.DataPropertyName = "REQ_PURPOSE"
        Me.REQPURPOSEDataGridViewTextBoxColumn.HeaderText = "REQ_PURPOSE"
        Me.REQPURPOSEDataGridViewTextBoxColumn.Name = "REQPURPOSEDataGridViewTextBoxColumn"
        Me.REQPURPOSEDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQPURPOSEDataGridViewTextBoxColumn.Visible = False
        '
        'REQDATENEEDEDDataGridViewTextBoxColumn
        '
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.DataPropertyName = "REQ_DATE_NEEDED"
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.HeaderText = "REQ_DATE_NEEDED"
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.Name = "REQDATENEEDEDDataGridViewTextBoxColumn"
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQDATENEEDEDDataGridViewTextBoxColumn.Visible = False
        '
        'REQDATEPERIODDataGridViewTextBoxColumn
        '
        Me.REQDATEPERIODDataGridViewTextBoxColumn.DataPropertyName = "REQ_DATE_PERIOD"
        Me.REQDATEPERIODDataGridViewTextBoxColumn.HeaderText = "REQ_DATE_PERIOD"
        Me.REQDATEPERIODDataGridViewTextBoxColumn.Name = "REQDATEPERIODDataGridViewTextBoxColumn"
        Me.REQDATEPERIODDataGridViewTextBoxColumn.ReadOnly = True
        Me.REQDATEPERIODDataGridViewTextBoxColumn.Visible = False
        '
        'TBLM4INVENTORYITEMREQUISITIONBindingSource
        '
        Me.TBLM4INVENTORYITEMREQUISITIONBindingSource.DataMember = "TBLM4_INVENTORY_ITEM_REQUISITION"
        Me.TBLM4INVENTORYITEMREQUISITIONBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RECT_SAVE
        '
        Me.RECT_SAVE.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_SAVE.BorderWidth = 2
        Me.RECT_SAVE.CornerRadius = 19
        Me.RECT_SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_SAVE.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_SAVE.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_SAVE.Location = New System.Drawing.Point(788, 340)
        Me.RECT_SAVE.Name = "RECT_SAVE"
        Me.RECT_SAVE.Size = New System.Drawing.Size(200, 40)
        '
        'RECT_CANCEL
        '
        Me.RECT_CANCEL.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_CANCEL.BorderWidth = 2
        Me.RECT_CANCEL.CornerRadius = 19
        Me.RECT_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RECT_CANCEL.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_CANCEL.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_CANCEL.Location = New System.Drawing.Point(993, 341)
        Me.RECT_CANCEL.Name = "RECT_CANCEL"
        Me.RECT_CANCEL.Size = New System.Drawing.Size(126, 40)
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_SAVE, Me.RECT_CANCEL})
        Me.ShapeContainer5.Size = New System.Drawing.Size(1126, 390)
        Me.ShapeContainer5.TabIndex = 1539
        Me.ShapeContainer5.TabStop = False
        '
        'PB_CANCEL
        '
        Me.PB_CANCEL.BackgroundImage = CType(resources.GetObject("PB_CANCEL.BackgroundImage"), System.Drawing.Image)
        Me.PB_CANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_CANCEL.InitialImage = Nothing
        Me.PB_CANCEL.Location = New System.Drawing.Point(1007, 347)
        Me.PB_CANCEL.Name = "PB_CANCEL"
        Me.PB_CANCEL.Size = New System.Drawing.Size(32, 28)
        Me.PB_CANCEL.TabIndex = 1540
        Me.PB_CANCEL.TabStop = False
        '
        'LLBL_CANCEL
        '
        Me.LLBL_CANCEL.AutoSize = True
        Me.LLBL_CANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_CANCEL.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.LLBL_CANCEL.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_CANCEL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_CANCEL.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_CANCEL.Location = New System.Drawing.Point(1042, 352)
        Me.LLBL_CANCEL.Name = "LLBL_CANCEL"
        Me.LLBL_CANCEL.Size = New System.Drawing.Size(69, 19)
        Me.LLBL_CANCEL.TabIndex = 1541
        Me.LLBL_CANCEL.TabStop = True
        Me.LLBL_CANCEL.Text = "Cancel"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.TBLG3_UNITSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_DIST_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_DR_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_COLOR_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_COLORTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENG_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_LENGTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAME_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_NAMETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_OTHERSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMS_SIZETableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INV_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_ITEM_USAGETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ACQUISITION_VALUETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ASSIGN_PERSONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORY1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMBRANDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_LOCATIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.TBLM4_INVENTORY_REQUISITIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_SUB_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_INVENTORY_TYPETableAdapter = Nothing
        Me.TableAdapterManager.tblM4_ITEMBRAND1TableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CANCELEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_CATEGORYTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_POSTEDTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_PROVIDERTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUEST_REVISIONTableAdapter = Nothing
        Me.TableAdapterManager.tblM4_PURCHASEREQUESTTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_PROPERTYDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblM4_INVENTORY_ITEMS_DISTRIBUTIONBindingSource
        '
        Me.TblM4_INVENTORY_ITEMS_DISTRIBUTIONBindingSource.DataMember = "tblM4_INVENTORY_ITEMS_DISTRIBUTION"
        Me.TblM4_INVENTORY_ITEMS_DISTRIBUTIONBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter
        '
        Me.TblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter.ClearBeforeFill = True
        '
        'TBLM4INVENTORYREQUISITIONBindingSource
        '
        Me.TBLM4INVENTORYREQUISITIONBindingSource.DataMember = "TBLM4_INVENTORY_REQUISITION"
        Me.TBLM4INVENTORYREQUISITIONBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INVENTORY_REQUISITIONTableAdapter
        '
        Me.TBLM4_INVENTORY_REQUISITIONTableAdapter.ClearBeforeFill = True
        '
        'TblM4INVENTORYITEMSDISTRIBUTIONBindingSource
        '
        Me.TblM4INVENTORYITEMSDISTRIBUTIONBindingSource.DataMember = "tblM4_INVENTORY_ITEMS_DISTRIBUTION"
        Me.TblM4INVENTORYITEMSDISTRIBUTIONBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4INVENTORYREQUISITIONBindingSource1
        '
        Me.TBLM4INVENTORYREQUISITIONBindingSource1.DataMember = "TBLM4_INVENTORY_REQUISITION"
        Me.TBLM4INVENTORYREQUISITIONBindingSource1.DataSource = Me.DS_PROPERTYDB
        '
        'ItemForDistributionBindingSource
        '
        Me.ItemForDistributionBindingSource.DataMember = "ItemForDistribution"
        Me.ItemForDistributionBindingSource.DataSource = Me.DS_CUSTOM
        '
        'SPM4_IQ_REQ_DISTTableAdapter
        '
        Me.SPM4_IQ_REQ_DISTTableAdapter.ClearBeforeFill = True
        '
        'VWM4_REQUISITIONTableAdapter
        '
        Me.VWM4_REQUISITIONTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_DIST_DGV_BY_REF_NOTableAdapter
        '
        Me.SPM4_ITEM_DIST_DGV_BY_REF_NOTableAdapter.ClearBeforeFill = True
        '
        'SPM4_ITEM_DIST_DGV_BY_REF_NOBindingSource
        '
        Me.SPM4_ITEM_DIST_DGV_BY_REF_NOBindingSource.DataMember = "SPM4_ITEM_DIST_DGV_BY_REF_NO"
        Me.SPM4_ITEM_DIST_DGV_BY_REF_NOBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'TBLM4_INV_ITEMSBindingSource
        '
        Me.TBLM4_INV_ITEMSBindingSource.DataMember = "TBLM4_INV_ITEMS"
        Me.TBLM4_INV_ITEMSBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMSTableAdapter
        '
        Me.TBLM4_INV_ITEMSTableAdapter.ClearBeforeFill = True
        '
        'FRM_ITEM_DISTRIBUTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1126, 390)
        Me.Controls.Add(Me.LLBL_CANCEL)
        Me.Controls.Add(Me.PB_CANCEL)
        Me.Controls.Add(Me.PB_SAVE)
        Me.Controls.Add(Me.GRP_ITEMINFO)
        Me.Controls.Add(Me.LLBL_SAVE)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_ITEM_DETAILS)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.ShapeContainer5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ITEM_DISTRIBUTION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_ITEM_DISTRIBUTION"
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        Me.GB_ITEM_DETAILS.ResumeLayout(False)
        Me.GB_ITEM_DETAILS.PerformLayout()
        CType(Me.TblV1HRISDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_TABLES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblV1HRISDEPARTMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ITEM_LIST_CLEAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_INVENTORY_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_ITEMLIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListDistributionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_CUSTOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_ITEMDISTRIBUTION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_DISTRIBUTION_NOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_ITEMINFO.ResumeLayout(False)
        Me.GRP_ITEMINFO.PerformLayout()
        CType(Me.SPM4ITEMDISTDGVBYREFNOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOX_PRNOQRCODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4_REQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_SAVE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_ITEM_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVENTORYITEMREQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_CANCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4_INVENTORY_ITEMS_DISTRIBUTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVENTORYREQUISITIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblM4INVENTORYITEMSDISTRIBUTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4INVENTORYREQUISITIONBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDistributionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_IQ_REQ_DISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4_ITEM_DIST_DGV_BY_REF_NOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_ITEM_DISTRIBUTION_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents GB_ITEM_DETAILS As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_DIVISION As PowerPacks.RectangleShape
    Friend WithEvents RECT_DEPARTMENT As PowerPacks.RectangleShape
    Friend WithEvents WTXT_SEARCH_ITEM_LIST As WatermarkTextBox
    Friend WithEvents PB_ITEM_LIST_CLEAR As PictureBox
    Friend WithEvents PB_INVENTORY_SEARCH As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents DGV_ITEMLIST As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_ITEMDISTRIBUTION As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents WTXT_SEARCH_ITEM_DISTRIBUTION As WatermarkTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents CB_ITEM_DISTRIBUTION_DEPARTMENT As ComboBox
    Friend WithEvents CB_ITEM_DISTRIBUTION_DIVISION As ComboBox
    Friend WithEvents DS_TABLES As DS_TABLES
    Friend WithEvents TblV1HRISDEPARTMENTBindingSource As BindingSource
    Friend WithEvents TblV1_HRISDEPARTMENTTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDEPARTMENTTableAdapter
    Friend WithEvents TblV1HRISDIVISIONBindingSource As BindingSource
    Friend WithEvents TblV1_HRISDIVISIONTableAdapter As DS_TABLESTableAdapters.tblV1_HRISDIVISIONTableAdapter
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents DS_CUSTOM As DS_CUSTOM
    Friend WithEvents ItemForDistributionBindingSource As BindingSource
    Friend WithEvents ItemListDistributionBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DS_PROPERTYDBTableAdapters.TableAdapterManager
    Friend WithEvents ItemCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandProviderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerialNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofAcquisitionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPM4_ITEM_LIST_FOR_DISTRIBUTIONTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_LIST_FOR_DISTRIBUTIONTableAdapter
    Friend WithEvents TableAdapterManager1 As DS_STOREDPROCTableAdapters.TableAdapterManager
    Friend WithEvents Label3 As Label
    Friend WithEvents TblM4_INVENTORY_ITEMS_DISTRIBUTIONBindingSource As BindingSource
    Friend WithEvents TblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter As DS_PROPERTYDBTableAdapters.tblM4_INVENTORY_ITEMS_DISTRIBUTIONTableAdapter
    Friend WithEvents SPM4_ITEM_DISTRIBUTION_NOBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_DISTRIBUTION_NOTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_DISTRIBUTION_NOTableAdapter
    Friend WithEvents division As DataGridViewTextBoxColumn
    Friend WithEvents ITEMCODE As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents subcategory As DataGridViewTextBoxColumn
    Friend WithEvents BRAND As DataGridViewTextBoxColumn
    Friend WithEvents Productno As DataGridViewTextBoxColumn
    Friend WithEvents itemDesc As DataGridViewTextBoxColumn
    Friend WithEvents unittype As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents dateofacquisition As DataGridViewTextBoxColumn
    Friend WithEvents div_code As DataGridViewTextBoxColumn
    Friend WithEvents dept_code As DataGridViewTextBoxColumn
    Friend WithEvents SpM4_ITEM_DISTRIBUTION_STOCKTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_DISTRIBUTION_STOCKTableAdapter
    Friend WithEvents GRP_ITEMINFO As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents WTXT_PURPOSE As WatermarkTextBox
    Friend WithEvents WTXT_FOR_THE_PERIOD As WatermarkTextBox
    Friend WithEvents LLBL_CLOSE As LinkLabel
    Friend WithEvents LLBL_SAVE_ADD_ITEM As LinkLabel
    Friend WithEvents WTXT_DATE_NEEDED As WatermarkTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PBOX_PRNOQRCODE As PictureBox
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape15 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape14 As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRREQUESTEDDATE As PowerPacks.RectangleShape
    Friend WithEvents RECT_PRAPPCODE As PowerPacks.RectangleShape
    Friend WithEvents PB_SAVE As PictureBox
    Friend WithEvents LLBL_SAVE As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RECT_SAVE As PowerPacks.RectangleShape
    Friend WithEvents RECT_CANCEL As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer5 As PowerPacks.ShapeContainer
    Friend WithEvents WTXT_REQ_TYPE As WatermarkTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents WTXT_REF_NO As WatermarkTextBox
    Friend WithEvents PB_CANCEL As PictureBox
    Friend WithEvents LLBL_CANCEL As LinkLabel
    Friend WithEvents TBLM4INVENTORYREQUISITIONBindingSource As BindingSource
    Friend WithEvents TBLM4_INVENTORY_REQUISITIONTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INVENTORY_REQUISITIONTableAdapter
    Friend WithEvents TBLM4INVENTORYREQUISITIONBindingSource1 As BindingSource
    Friend WithEvents TblM4INVENTORYITEMSDISTRIBUTIONBindingSource As BindingSource
    Friend WithEvents TBLM4INVENTORYITEMREQUISITIONBindingSource As BindingSource
    Friend WithEvents ITMDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents SPM4_IQ_REQ_DISTBindingSource As BindingSource
    Friend WithEvents SPM4_IQ_REQ_DISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_IQ_REQ_DISTTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents APPQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateneededDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VWM4_REQUISITIONBindingSource As BindingSource
    Friend WithEvents VWM4_REQUISITIONTableAdapter As DS_VIEWSTableAdapters.VWM4_REQUISITIONTableAdapter
    Friend WithEvents DGV_ITEM_LIST As DataGridView
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents FULLDESCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPM4ITEMDISTDGVBYREFNOBindingSource As BindingSource
    Friend WithEvents SPM4_ITEM_DIST_DGV_BY_REF_NOTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_DIST_DGV_BY_REF_NOTableAdapter
    Friend WithEvents SPM4_ITEM_DIST_DGV_BY_REF_NOBindingSource As BindingSource
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ITEMDESCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITMUNITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REMSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents remstock As DataGridViewTextBoxColumn
    Friend WithEvents BTN_ADD_STOCK As DataGridViewButtonColumn
    Friend WithEvents REQNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQTYPEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQPURPOSEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQDATENEEDEDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REQDATEPERIODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BTN_INVENTORY_CLOSE As Button
    Friend WithEvents TBLM4_INV_ITEMSBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMSTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMSTableAdapter
End Class
