<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_STK_CTRL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_STK_CTRL))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LLBL_SAVE_ITEM_DETAILS = New System.Windows.Forms.LinkLabel()
        Me.PB_SAVE_ITEM_DETAILS = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.WTXT_MAX_QTY = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_MIN_QTY = New PRA_PIS.WatermarkTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WTXT_ITEM_DESC = New PRA_PIS.WatermarkTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WTXT_QTY_STOCKS = New PRA_PIS.WatermarkTextBox()
        Me.WTXT_ITEM_CODE = New PRA_PIS.WatermarkTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_SAVE_ITEM_DETAILS = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PB_ITEM_STOCK_SEARCH = New System.Windows.Forms.PictureBox()
        Me.WTXT_ITEM_STOCK_SEARCH = New PRA_PIS.WatermarkTextBox()
        Me.PB_ITEM_STOCK_CLEAR_SEARCH = New System.Windows.Forms.PictureBox()
        Me.DGV_STOCK_LIST = New System.Windows.Forms.DataGridView()
        Me.VWM4STOCKLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_VIEWS = New PRA_PIS.DS_VIEWS()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RECT_ITEM_STOCK = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TableAdapterManager = New PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager()
        Me.PNL = New System.Windows.Forms.Panel()
        Me.BTN_ITEM_STOCK_ENC_CLOSE = New System.Windows.Forms.Button()
        Me.LBLSETTINGSHEAD = New System.Windows.Forms.Label()
        Me.BTN_Minimize = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.DS_PROPERTYDB = New PRA_PIS.DS_PROPERTYDB()
        Me.TBLM4_INV_ITEMS_STK_CTRLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLM4_INV_ITEMS_STK_CTRLTableAdapter = New PRA_PIS.DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_STK_CTRLTableAdapter()
        Me.HDIVSCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VWM4_STOCK_LISTTableAdapter = New PRA_PIS.DS_VIEWSTableAdapters.VWM4_STOCK_LISTTableAdapter()
        Me.DS_STOREDPROC = New PRA_PIS.DS_STOREDPROC()
        Me.SPM4ITEMSTOCKMASTERLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SPM4_ITEM_STOCKMASTERLISTTableAdapter = New PRA_PIS.DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKMASTERLISTTableAdapter()
        Me.ITEMCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMALIASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMUNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMSTOCKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDIVSCODEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMMINQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEMMAXQTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PB_SAVE_ITEM_DETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_ITEM_STOCK_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_STOCK_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWM4STOCKLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL.SuspendLayout()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLM4_INV_ITEMS_STK_CTRLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPM4ITEMSTOCKMASTERLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ShapeContainer2)
        Me.Panel1.Location = New System.Drawing.Point(1, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 488)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PB_ITEM_STOCK_SEARCH)
        Me.Panel2.Controls.Add(Me.WTXT_ITEM_STOCK_SEARCH)
        Me.Panel2.Controls.Add(Me.PB_ITEM_STOCK_CLEAR_SEARCH)
        Me.Panel2.Controls.Add(Me.DGV_STOCK_LIST)
        Me.Panel2.Controls.Add(Me.ShapeContainer1)
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(665, 469)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LLBL_SAVE_ITEM_DETAILS)
        Me.Panel3.Controls.Add(Me.PB_SAVE_ITEM_DETAILS)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.ShapeContainer3)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(658, 158)
        Me.Panel3.TabIndex = 1447
        '
        'LLBL_SAVE_ITEM_DETAILS
        '
        Me.LLBL_SAVE_ITEM_DETAILS.AutoSize = True
        Me.LLBL_SAVE_ITEM_DETAILS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LLBL_SAVE_ITEM_DETAILS.Enabled = False
        Me.LLBL_SAVE_ITEM_DETAILS.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_SAVE_ITEM_DETAILS.ForeColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE_ITEM_DETAILS.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LLBL_SAVE_ITEM_DETAILS.LinkColor = System.Drawing.Color.DimGray
        Me.LLBL_SAVE_ITEM_DETAILS.Location = New System.Drawing.Point(591, 120)
        Me.LLBL_SAVE_ITEM_DETAILS.Name = "LLBL_SAVE_ITEM_DETAILS"
        Me.LLBL_SAVE_ITEM_DETAILS.Size = New System.Drawing.Size(52, 19)
        Me.LLBL_SAVE_ITEM_DETAILS.TabIndex = 1457
        Me.LLBL_SAVE_ITEM_DETAILS.TabStop = True
        Me.LLBL_SAVE_ITEM_DETAILS.Text = "SAVE"
        '
        'PB_SAVE_ITEM_DETAILS
        '
        Me.PB_SAVE_ITEM_DETAILS.BackgroundImage = Global.PRA_PIS.My.Resources.Resources.baseline_save_black_18dp
        Me.PB_SAVE_ITEM_DETAILS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_SAVE_ITEM_DETAILS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_SAVE_ITEM_DETAILS.Enabled = False
        Me.PB_SAVE_ITEM_DETAILS.InitialImage = Nothing
        Me.PB_SAVE_ITEM_DETAILS.Location = New System.Drawing.Point(554, 113)
        Me.PB_SAVE_ITEM_DETAILS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_SAVE_ITEM_DETAILS.Name = "PB_SAVE_ITEM_DETAILS"
        Me.PB_SAVE_ITEM_DETAILS.Size = New System.Drawing.Size(37, 34)
        Me.PB_SAVE_ITEM_DETAILS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_SAVE_ITEM_DETAILS.TabIndex = 1458
        Me.PB_SAVE_ITEM_DETAILS.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.WTXT_MAX_QTY)
        Me.Panel4.Controls.Add(Me.WTXT_MIN_QTY)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.WTXT_ITEM_DESC)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.WTXT_QTY_STOCKS)
        Me.Panel4.Controls.Add(Me.WTXT_ITEM_CODE)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.ShapeContainer4)
        Me.Panel4.Location = New System.Drawing.Point(2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(651, 104)
        Me.Panel4.TabIndex = 2
        '
        'WTXT_MAX_QTY
        '
        Me.WTXT_MAX_QTY.BackColor = System.Drawing.Color.White
        Me.WTXT_MAX_QTY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_MAX_QTY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_MAX_QTY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_MAX_QTY.ForeColor = System.Drawing.Color.Black
        Me.WTXT_MAX_QTY.Location = New System.Drawing.Point(330, 75)
        Me.WTXT_MAX_QTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_MAX_QTY.MaxLength = 300
        Me.WTXT_MAX_QTY.Name = "WTXT_MAX_QTY"
        Me.WTXT_MAX_QTY.Size = New System.Drawing.Size(145, 21)
        Me.WTXT_MAX_QTY.TabIndex = 1518
        Me.WTXT_MAX_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_MAX_QTY.Watermark = "0"
        '
        'WTXT_MIN_QTY
        '
        Me.WTXT_MIN_QTY.BackColor = System.Drawing.Color.White
        Me.WTXT_MIN_QTY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_MIN_QTY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_MIN_QTY.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_MIN_QTY.ForeColor = System.Drawing.Color.Black
        Me.WTXT_MIN_QTY.Location = New System.Drawing.Point(172, 74)
        Me.WTXT_MIN_QTY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_MIN_QTY.MaxLength = 300
        Me.WTXT_MIN_QTY.Name = "WTXT_MIN_QTY"
        Me.WTXT_MIN_QTY.Size = New System.Drawing.Size(145, 21)
        Me.WTXT_MIN_QTY.TabIndex = 1517
        Me.WTXT_MIN_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_MIN_QTY.Watermark = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(340, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 1516
        Me.Label4.Text = "Maximum Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(172, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 1515
        Me.Label3.Text = "Minimum Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 1514
        Me.Label2.Text = "No. of Stocks"
        '
        'WTXT_ITEM_DESC
        '
        Me.WTXT_ITEM_DESC.BackColor = System.Drawing.Color.White
        Me.WTXT_ITEM_DESC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_DESC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_ITEM_DESC.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_DESC.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_DESC.Location = New System.Drawing.Point(335, 34)
        Me.WTXT_ITEM_DESC.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_DESC.MaxLength = 300
        Me.WTXT_ITEM_DESC.Name = "WTXT_ITEM_DESC"
        Me.WTXT_ITEM_DESC.ReadOnly = True
        Me.WTXT_ITEM_DESC.Size = New System.Drawing.Size(304, 21)
        Me.WTXT_ITEM_DESC.TabIndex = 1513
        Me.WTXT_ITEM_DESC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ITEM_DESC.Watermark = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(340, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 1512
        Me.Label1.Text = "Item Description"
        '
        'WTXT_QTY_STOCKS
        '
        Me.WTXT_QTY_STOCKS.BackColor = System.Drawing.Color.White
        Me.WTXT_QTY_STOCKS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_QTY_STOCKS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_QTY_STOCKS.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_QTY_STOCKS.ForeColor = System.Drawing.Color.Black
        Me.WTXT_QTY_STOCKS.Location = New System.Drawing.Point(12, 74)
        Me.WTXT_QTY_STOCKS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_QTY_STOCKS.MaxLength = 300
        Me.WTXT_QTY_STOCKS.Name = "WTXT_QTY_STOCKS"
        Me.WTXT_QTY_STOCKS.ReadOnly = True
        Me.WTXT_QTY_STOCKS.Size = New System.Drawing.Size(145, 21)
        Me.WTXT_QTY_STOCKS.TabIndex = 1505
        Me.WTXT_QTY_STOCKS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.WTXT_QTY_STOCKS.Watermark = "0"
        '
        'WTXT_ITEM_CODE
        '
        Me.WTXT_ITEM_CODE.BackColor = System.Drawing.Color.White
        Me.WTXT_ITEM_CODE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_CODE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WTXT_ITEM_CODE.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_CODE.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_CODE.Location = New System.Drawing.Point(14, 35)
        Me.WTXT_ITEM_CODE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_CODE.MaxLength = 300
        Me.WTXT_ITEM_CODE.Name = "WTXT_ITEM_CODE"
        Me.WTXT_ITEM_CODE.ReadOnly = True
        Me.WTXT_ITEM_CODE.Size = New System.Drawing.Size(304, 21)
        Me.WTXT_ITEM_CODE.TabIndex = 1503
        Me.WTXT_ITEM_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.WTXT_ITEM_CODE.Watermark = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(16, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 1497
        Me.Label9.Text = "Item Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 1495
        Me.Label10.Text = "Item Details"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape6, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape9})
        Me.ShapeContainer4.Size = New System.Drawing.Size(651, 104)
        Me.ShapeContainer4.TabIndex = 1496
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape6.CornerRadius = 5
        Me.RectangleShape6.Location = New System.Drawing.Point(326, 70)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(155, 29)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape4.CornerRadius = 5
        Me.RectangleShape4.Location = New System.Drawing.Point(165, 69)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(157, 29)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape3.CornerRadius = 5
        Me.RectangleShape3.Location = New System.Drawing.Point(6, 69)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(155, 29)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape2.CornerRadius = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(328, 29)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(316, 29)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape9.CornerRadius = 5
        Me.RectangleShape9.Location = New System.Drawing.Point(7, 30)
        Me.RectangleShape9.Name = "RECT_ITEM_DESCRIPTION"
        Me.RectangleShape9.Size = New System.Drawing.Size(316, 29)
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_SAVE_ITEM_DETAILS})
        Me.ShapeContainer3.Size = New System.Drawing.Size(656, 156)
        Me.ShapeContainer3.TabIndex = 3
        Me.ShapeContainer3.TabStop = False
        '
        'RECT_SAVE_ITEM_DETAILS
        '
        Me.RECT_SAVE_ITEM_DETAILS.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_SAVE_ITEM_DETAILS.BorderWidth = 2
        Me.RECT_SAVE_ITEM_DETAILS.CornerRadius = 19
        Me.RECT_SAVE_ITEM_DETAILS.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_SAVE_ITEM_DETAILS.Enabled = False
        Me.RECT_SAVE_ITEM_DETAILS.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_SAVE_ITEM_DETAILS.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_SAVE_ITEM_DETAILS.Location = New System.Drawing.Point(544, 109)
        Me.RECT_SAVE_ITEM_DETAILS.Name = "RECT_SAVE_ITEM_DETAILS"
        Me.RECT_SAVE_ITEM_DETAILS.Size = New System.Drawing.Size(105, 40)
        '
        'PB_ITEM_STOCK_SEARCH
        '
        Me.PB_ITEM_STOCK_SEARCH.BackgroundImage = CType(resources.GetObject("PB_ITEM_STOCK_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_ITEM_STOCK_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_ITEM_STOCK_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ITEM_STOCK_SEARCH.InitialImage = Nothing
        Me.PB_ITEM_STOCK_SEARCH.Location = New System.Drawing.Point(21, 166)
        Me.PB_ITEM_STOCK_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_ITEM_STOCK_SEARCH.Name = "PB_ITEM_STOCK_SEARCH"
        Me.PB_ITEM_STOCK_SEARCH.Size = New System.Drawing.Size(37, 34)
        Me.PB_ITEM_STOCK_SEARCH.TabIndex = 1444
        Me.PB_ITEM_STOCK_SEARCH.TabStop = False
        '
        'WTXT_ITEM_STOCK_SEARCH
        '
        Me.WTXT_ITEM_STOCK_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WTXT_ITEM_STOCK_SEARCH.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTXT_ITEM_STOCK_SEARCH.ForeColor = System.Drawing.Color.Black
        Me.WTXT_ITEM_STOCK_SEARCH.Location = New System.Drawing.Point(62, 175)
        Me.WTXT_ITEM_STOCK_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WTXT_ITEM_STOCK_SEARCH.MaxLength = 300
        Me.WTXT_ITEM_STOCK_SEARCH.Name = "WTXT_ITEM_STOCK_SEARCH"
        Me.WTXT_ITEM_STOCK_SEARCH.Size = New System.Drawing.Size(544, 21)
        Me.WTXT_ITEM_STOCK_SEARCH.TabIndex = 1445
        Me.WTXT_ITEM_STOCK_SEARCH.Watermark = "Search Item description"
        '
        'PB_ITEM_STOCK_CLEAR_SEARCH
        '
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.BackgroundImage = CType(resources.GetObject("PB_ITEM_STOCK_CLEAR_SEARCH.BackgroundImage"), System.Drawing.Image)
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.InitialImage = Nothing
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Location = New System.Drawing.Point(611, 167)
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Name = "PB_ITEM_STOCK_CLEAR_SEARCH"
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Size = New System.Drawing.Size(37, 34)
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.TabIndex = 1446
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.TabStop = False
        Me.PB_ITEM_STOCK_CLEAR_SEARCH.Visible = False
        '
        'DGV_STOCK_LIST
        '
        Me.DGV_STOCK_LIST.AllowUserToAddRows = False
        Me.DGV_STOCK_LIST.AllowUserToDeleteRows = False
        Me.DGV_STOCK_LIST.AllowUserToResizeRows = False
        Me.DGV_STOCK_LIST.AutoGenerateColumns = False
        Me.DGV_STOCK_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_STOCK_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_STOCK_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ITEMCODEDataGridViewTextBoxColumn, Me.ITEMALIASDataGridViewTextBoxColumn, Me.TOTALSTOCKDataGridViewTextBoxColumn, Me.ITEMUNITDataGridViewTextBoxColumn, Me.APPQTYDataGridViewTextBoxColumn, Me.REMSTOCKDataGridViewTextBoxColumn, Me.HDIVSCODEDataGridViewTextBoxColumn1, Me.ITEMMINQTYDataGridViewTextBoxColumn, Me.ITEMMAXQTYDataGridViewTextBoxColumn})
        Me.DGV_STOCK_LIST.DataSource = Me.SPM4ITEMSTOCKMASTERLISTBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_STOCK_LIST.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_STOCK_LIST.Location = New System.Drawing.Point(6, 209)
        Me.DGV_STOCK_LIST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGV_STOCK_LIST.MultiSelect = False
        Me.DGV_STOCK_LIST.Name = "DGV_STOCK_LIST"
        Me.DGV_STOCK_LIST.ReadOnly = True
        Me.DGV_STOCK_LIST.RowHeadersVisible = False
        Me.DGV_STOCK_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_STOCK_LIST.Size = New System.Drawing.Size(654, 256)
        Me.DGV_STOCK_LIST.TabIndex = 1
        '
        'VWM4STOCKLISTBindingSource
        '
        Me.VWM4STOCKLISTBindingSource.DataMember = "VWM4_STOCK_LIST"
        Me.VWM4STOCKLISTBindingSource.DataSource = Me.DS_VIEWS
        '
        'DS_VIEWS
        '
        Me.DS_VIEWS.DataSetName = "DS_VIEWS"
        Me.DS_VIEWS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(665, 469)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DimGray
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.CornerRadius = 19
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(3, 164)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(656, 39)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RECT_ITEM_STOCK})
        Me.ShapeContainer2.Size = New System.Drawing.Size(686, 488)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RECT_ITEM_STOCK
        '
        Me.RECT_ITEM_STOCK.BorderColor = System.Drawing.Color.DimGray
        Me.RECT_ITEM_STOCK.BorderWidth = 2
        Me.RECT_ITEM_STOCK.CornerRadius = 10
        Me.RECT_ITEM_STOCK.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RECT_ITEM_STOCK.FillColor = System.Drawing.SystemColors.HighlightText
        Me.RECT_ITEM_STOCK.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RECT_ITEM_STOCK.Location = New System.Drawing.Point(2, 1)
        Me.RECT_ITEM_STOCK.Name = "RECT_ITEM_STOCK"
        Me.RECT_ITEM_STOCK.Size = New System.Drawing.Size(679, 483)
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PRA_PIS.DS_VIEWSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PNL
        '
        Me.PNL.BackColor = System.Drawing.Color.Teal
        Me.PNL.Controls.Add(Me.BTN_ITEM_STOCK_ENC_CLOSE)
        Me.PNL.Controls.Add(Me.LBLSETTINGSHEAD)
        Me.PNL.Controls.Add(Me.BTN_Minimize)
        Me.PNL.Controls.Add(Me.BTN_CLOSE)
        Me.PNL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL.Location = New System.Drawing.Point(0, 0)
        Me.PNL.Margin = New System.Windows.Forms.Padding(6)
        Me.PNL.Name = "PNL"
        Me.PNL.Size = New System.Drawing.Size(687, 60)
        Me.PNL.TabIndex = 1408
        '
        'BTN_ITEM_STOCK_ENC_CLOSE
        '
        Me.BTN_ITEM_STOCK_ENC_CLOSE.BackgroundImage = CType(resources.GetObject("BTN_ITEM_STOCK_ENC_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_ITEM_STOCK_ENC_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_ITEM_STOCK_ENC_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_ITEM_STOCK_ENC_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_ITEM_STOCK_ENC_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ITEM_STOCK_ENC_CLOSE.Location = New System.Drawing.Point(640, 13)
        Me.BTN_ITEM_STOCK_ENC_CLOSE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTN_ITEM_STOCK_ENC_CLOSE.Name = "BTN_ITEM_STOCK_ENC_CLOSE"
        Me.BTN_ITEM_STOCK_ENC_CLOSE.Size = New System.Drawing.Size(35, 37)
        Me.BTN_ITEM_STOCK_ENC_CLOSE.TabIndex = 16
        Me.BTN_ITEM_STOCK_ENC_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_ITEM_STOCK_ENC_CLOSE.UseVisualStyleBackColor = True
        '
        'LBLSETTINGSHEAD
        '
        Me.LBLSETTINGSHEAD.AutoSize = True
        Me.LBLSETTINGSHEAD.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSETTINGSHEAD.ForeColor = System.Drawing.Color.White
        Me.LBLSETTINGSHEAD.Location = New System.Drawing.Point(13, 17)
        Me.LBLSETTINGSHEAD.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLSETTINGSHEAD.Name = "LBLSETTINGSHEAD"
        Me.LBLSETTINGSHEAD.Size = New System.Drawing.Size(315, 23)
        Me.LBLSETTINGSHEAD.TabIndex = 8
        Me.LBLSETTINGSHEAD.Text = "S T O C K S  C O N T R O L  S E T U P"
        '
        'BTN_Minimize
        '
        Me.BTN_Minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Minimize.BackColor = System.Drawing.Color.DarkCyan
        Me.BTN_Minimize.BackgroundImage = CType(resources.GetObject("BTN_Minimize.BackgroundImage"), System.Drawing.Image)
        Me.BTN_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_Minimize.FlatAppearance.BorderSize = 3
        Me.BTN_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Minimize.Location = New System.Drawing.Point(-9104, 14)
        Me.BTN_Minimize.Margin = New System.Windows.Forms.Padding(6)
        Me.BTN_Minimize.Name = "BTN_Minimize"
        Me.BTN_Minimize.Size = New System.Drawing.Size(55, 55)
        Me.BTN_Minimize.TabIndex = 7
        Me.BTN_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_Minimize.UseVisualStyleBackColor = False
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_CLOSE.BackgroundImage = CType(resources.GetObject("BTN_CLOSE.BackgroundImage"), System.Drawing.Image)
        Me.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 3
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Location = New System.Drawing.Point(-9049, 12)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(6)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(58, 59)
        Me.BTN_CLOSE.TabIndex = 6
        Me.BTN_CLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'DS_PROPERTYDB
        '
        Me.DS_PROPERTYDB.DataSetName = "DS_PROPERTYDB"
        Me.DS_PROPERTYDB.EnforceConstraints = False
        Me.DS_PROPERTYDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLM4_INV_ITEMS_STK_CTRLBindingSource
        '
        Me.TBLM4_INV_ITEMS_STK_CTRLBindingSource.DataMember = "TBLM4_INV_ITEMS_STK_CTRL"
        Me.TBLM4_INV_ITEMS_STK_CTRLBindingSource.DataSource = Me.DS_PROPERTYDB
        '
        'TBLM4_INV_ITEMS_STK_CTRLTableAdapter
        '
        Me.TBLM4_INV_ITEMS_STK_CTRLTableAdapter.ClearBeforeFill = True
        '
        'HDIVSCODEDataGridViewTextBoxColumn
        '
        Me.HDIVSCODEDataGridViewTextBoxColumn.DataPropertyName = "HDIVS_CODE"
        Me.HDIVSCODEDataGridViewTextBoxColumn.HeaderText = "HDIVS_CODE"
        Me.HDIVSCODEDataGridViewTextBoxColumn.Name = "HDIVSCODEDataGridViewTextBoxColumn"
        '
        'VWM4_STOCK_LISTTableAdapter
        '
        Me.VWM4_STOCK_LISTTableAdapter.ClearBeforeFill = True
        '
        'DS_STOREDPROC
        '
        Me.DS_STOREDPROC.DataSetName = "DS_STOREDPROC"
        Me.DS_STOREDPROC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPM4ITEMSTOCKMASTERLISTBindingSource
        '
        Me.SPM4ITEMSTOCKMASTERLISTBindingSource.DataMember = "SPM4_ITEM_STOCKMASTERLIST"
        Me.SPM4ITEMSTOCKMASTERLISTBindingSource.DataSource = Me.DS_STOREDPROC
        '
        'SPM4_ITEM_STOCKMASTERLISTTableAdapter
        '
        Me.SPM4_ITEM_STOCKMASTERLISTTableAdapter.ClearBeforeFill = True
        '
        'ITEMCODEDataGridViewTextBoxColumn
        '
        Me.ITEMCODEDataGridViewTextBoxColumn.DataPropertyName = "ITEM_CODE"
        Me.ITEMCODEDataGridViewTextBoxColumn.HeaderText = "Item code"
        Me.ITEMCODEDataGridViewTextBoxColumn.Name = "ITEMCODEDataGridViewTextBoxColumn"
        Me.ITEMCODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMALIASDataGridViewTextBoxColumn
        '
        Me.ITEMALIASDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ITEMALIASDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ALIAS"
        Me.ITEMALIASDataGridViewTextBoxColumn.HeaderText = "Item description"
        Me.ITEMALIASDataGridViewTextBoxColumn.Name = "ITEMALIASDataGridViewTextBoxColumn"
        Me.ITEMALIASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALSTOCKDataGridViewTextBoxColumn
        '
        Me.TOTALSTOCKDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_STOCK"
        Me.TOTALSTOCKDataGridViewTextBoxColumn.HeaderText = "TOTAL_STOCK"
        Me.TOTALSTOCKDataGridViewTextBoxColumn.Name = "TOTALSTOCKDataGridViewTextBoxColumn"
        Me.TOTALSTOCKDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTALSTOCKDataGridViewTextBoxColumn.Visible = False
        '
        'ITEMUNITDataGridViewTextBoxColumn
        '
        Me.ITEMUNITDataGridViewTextBoxColumn.DataPropertyName = "ITEM_UNIT"
        Me.ITEMUNITDataGridViewTextBoxColumn.HeaderText = "Unit type"
        Me.ITEMUNITDataGridViewTextBoxColumn.Name = "ITEMUNITDataGridViewTextBoxColumn"
        Me.ITEMUNITDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APPQTYDataGridViewTextBoxColumn
        '
        Me.APPQTYDataGridViewTextBoxColumn.DataPropertyName = "APP_QTY"
        Me.APPQTYDataGridViewTextBoxColumn.HeaderText = "APP_QTY"
        Me.APPQTYDataGridViewTextBoxColumn.Name = "APPQTYDataGridViewTextBoxColumn"
        Me.APPQTYDataGridViewTextBoxColumn.ReadOnly = True
        Me.APPQTYDataGridViewTextBoxColumn.Visible = False
        '
        'REMSTOCKDataGridViewTextBoxColumn
        '
        Me.REMSTOCKDataGridViewTextBoxColumn.DataPropertyName = "REM_STOCK"
        Me.REMSTOCKDataGridViewTextBoxColumn.HeaderText = "No. of stocks"
        Me.REMSTOCKDataGridViewTextBoxColumn.Name = "REMSTOCKDataGridViewTextBoxColumn"
        Me.REMSTOCKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HDIVSCODEDataGridViewTextBoxColumn1
        '
        Me.HDIVSCODEDataGridViewTextBoxColumn1.DataPropertyName = "HDIVS_CODE"
        Me.HDIVSCODEDataGridViewTextBoxColumn1.HeaderText = "HDIVS_CODE"
        Me.HDIVSCODEDataGridViewTextBoxColumn1.Name = "HDIVSCODEDataGridViewTextBoxColumn1"
        Me.HDIVSCODEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.HDIVSCODEDataGridViewTextBoxColumn1.Visible = False
        '
        'ITEMMINQTYDataGridViewTextBoxColumn
        '
        Me.ITEMMINQTYDataGridViewTextBoxColumn.DataPropertyName = "ITEM_MIN_QTY"
        Me.ITEMMINQTYDataGridViewTextBoxColumn.HeaderText = "Min. quantity"
        Me.ITEMMINQTYDataGridViewTextBoxColumn.Name = "ITEMMINQTYDataGridViewTextBoxColumn"
        Me.ITEMMINQTYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ITEMMAXQTYDataGridViewTextBoxColumn
        '
        Me.ITEMMAXQTYDataGridViewTextBoxColumn.DataPropertyName = "ITEM_MAX_QTY"
        Me.ITEMMAXQTYDataGridViewTextBoxColumn.HeaderText = "Max. quantity"
        Me.ITEMMAXQTYDataGridViewTextBoxColumn.Name = "ITEMMAXQTYDataGridViewTextBoxColumn"
        Me.ITEMMAXQTYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FRM_STK_CTRL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 551)
        Me.Controls.Add(Me.PNL)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_STK_CTRL"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_STK_CTRL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PB_SAVE_ITEM_DETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PB_ITEM_STOCK_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_ITEM_STOCK_CLEAR_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_STOCK_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWM4STOCKLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_VIEWS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL.ResumeLayout(False)
        Me.PNL.PerformLayout()
        CType(Me.DS_PROPERTYDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLM4_INV_ITEMS_STK_CTRLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_STOREDPROC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPM4ITEMSTOCKMASTERLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_ITEM_STOCK As PowerPacks.RectangleShape
    Friend WithEvents DGV_STOCK_LIST As DataGridView
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PB_ITEM_STOCK_SEARCH As PictureBox
    Friend WithEvents WTXT_ITEM_STOCK_SEARCH As WatermarkTextBox
    Friend WithEvents PB_ITEM_STOCK_CLEAR_SEARCH As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents WTXT_MAX_QTY As WatermarkTextBox
    Friend WithEvents WTXT_MIN_QTY As WatermarkTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WTXT_ITEM_DESC As WatermarkTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WTXT_QTY_STOCKS As WatermarkTextBox
    Friend WithEvents WTXT_ITEM_CODE As WatermarkTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ShapeContainer4 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer3 As PowerPacks.ShapeContainer
    Friend WithEvents RECT_SAVE_ITEM_DETAILS As PowerPacks.RectangleShape
    Friend WithEvents LLBL_SAVE_ITEM_DETAILS As LinkLabel
    Friend WithEvents PB_SAVE_ITEM_DETAILS As PictureBox
    Friend WithEvents DS_VIEWS As DS_VIEWS
    Friend WithEvents TableAdapterManager As DS_VIEWSTableAdapters.TableAdapterManager
    Friend WithEvents PNL As Panel
    Friend WithEvents BTN_ITEM_STOCK_ENC_CLOSE As Button
    Friend WithEvents LBLSETTINGSHEAD As Label
    Friend WithEvents BTN_Minimize As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents DS_PROPERTYDB As DS_PROPERTYDB
    Friend WithEvents TBLM4_INV_ITEMS_STK_CTRLBindingSource As BindingSource
    Friend WithEvents TBLM4_INV_ITEMS_STK_CTRLTableAdapter As DS_PROPERTYDBTableAdapters.TBLM4_INV_ITEMS_STK_CTRLTableAdapter
    Friend WithEvents VWM4STOCKLISTBindingSource As BindingSource
    Friend WithEvents HDIVSCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VWM4_STOCK_LISTTableAdapter As DS_VIEWSTableAdapters.VWM4_STOCK_LISTTableAdapter
    Friend WithEvents ITEMCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMALIASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMUNITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APPQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents REMSTOCKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HDIVSCODEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ITEMMINQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITEMMAXQTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPM4ITEMSTOCKMASTERLISTBindingSource As BindingSource
    Friend WithEvents DS_STOREDPROC As DS_STOREDPROC
    Friend WithEvents SPM4_ITEM_STOCKMASTERLISTTableAdapter As DS_STOREDPROCTableAdapters.SPM4_ITEM_STOCKMASTERLISTTableAdapter
End Class
