Public Class FRM_INVENTORY_PRINT_PREVIEW

#Region "VARIABLES DECLARATION"

    Dim showbool As Boolean
    Dim m_szPaperSource As String = "3"                 ' 0 auto, 1 adf front, 2 adf rear, 3 adf duplex, 4 flatbed
    Dim m_szShowScannerUI As String = "0"               ' 0 off, 1 on
    Dim m_szFileName As String = "img"
    Dim m_szFileNumber As String = "0"                  ' 0 to 999
    Dim m_szFilePathName As String = "C:\twain"
    Dim m_szLanguage As String = "0"                    ' 0 English, 1 Chinese Simplified, 2 Chinese Traditional
    Dim m_szScanAs As String = "2"                      ' 0 bw, 1 gray, 2 color
    Dim m_szDpiResolution As String = "200"             ' 100, 150, 200, 240, 250, 300, 400, 500, 600, 1200
    Dim m_szDocumentType As String = "1"                ' 0 photo, 1 textwithgraphics, 2 textwithphoto, 3 text
    Dim m_szFileType As String = "0"                    ' 0 tiff, 4 jpeg
    Dim m_szCompressionType As String = "0"             ' 0 none, 5 g4, 6 jpeg
    Dim m_szJpegQuality As String = "50"                ' 40 draft, 50 good, 80 better, 90 best, 100 superior
    Dim m_szSharpen As String = "0"                     ' 0 none, 1 normal, 2 high, 3 exaggerated
    Dim m_szOrthogonalRotation As String = "1"          ' 0 none, 1 auto, 2 90, 3 180, 4 270, 5 auto 90, 6 auto 180, 7 auto 270 
    Dim m_szImageRotation As String = "1"               ' 0 0, 1 auto, 2 none, 90 90, 180 180 , 270 270, 360 360
    Dim m_szBlankImageDeletion As String = "1"          ' 1 none, 2 content
    Dim m_szBlankImageDeletionPercent As String = "0"   ' 0 to 100
    Dim m_szScanner As String = "KODAK Scanner: i2000"
    Dim m_szScannerProfile As String = "1"              ' 1 is typically "Default" profile
    Dim m_szOnePage As String = "0"                     ' 0 scan mulitple pages, 1 scan 1 page
    Dim filenumber As Integer
    Dim i As Integer = 0

    Dim KODAKSCANSDK As KODAKSCANSDK.Program
    Dim hWnd As IntPtr = Me.Handle
    Private WithEvents MyScanEvent As KODAKSCANSDK.Program

#End Region

#Region "START ##### FORM DRAG AND DROP, MINIMIZE, CLOSE"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PNL_DoubleClick(sender As Object, e As EventArgs) Handles PNL.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseUp
        drag = False
    End Sub
#End Region

    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function

#Region "CLICK"
    Private Sub BTN_INVENTORY_GENERATE_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_GENERATE_REPORT.Click,
                                                                                                WTXT_INVENTORY_REPORT_FROM.Click,
                                                                                                WTXT_INVENTORY_REPORT_TO.Click,
                                                                                                BTN_INVENTORY_REPORT_MINIMIZE.Click,
                                                                                                BTN_INVENTORY_REPORT_CLOSE.Click,
                                                                                                BTN_INVENTORY_PRINT.Click

        Try
            TXTDATE = Nothing
            Dim btn As Button = Nothing

            If TypeOf sender Is Button Then
                btn = CType(sender, Button)
            ElseIf TypeOf sender Is TextBox Then
                TXTDATE = CType(sender, TextBox)
            End If
#Region "Generate Report"
            If btn Is BTN_INVENTORY_GENERATE_REPORT Then
                LoadReport()
#End Region

#Region "Print"
            ElseIf btn Is BTN_INVENTORY_PRINT Then
                PrintDialog.Document = PrintDocument
                PrintDialog.PrinterSettings = PrintDocument.PrinterSettings
                If PrintDialog.ShowDialog = DialogResult.OK Then
                    Try
                        Dim PrinterName As String = PrintDocument.PrinterSettings.PrinterName
                        rptDoc.PrintOptions.PrinterName = PrinterName
                        rptDoc.PrintToPrinter(1, False, 0, 0)
                    Catch ex As Exception
                        NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
                    End Try
                End If
#End Region

#Region "Date POP UP"
            ElseIf TXTDATE Is WTXT_INVENTORY_REPORT_FROM Or TXTDATE Is WTXT_INVENTORY_REPORT_TO Then
                FRM_DATAENTRY.ShowDialog()
#End Region

#Region "Minimize"
            ElseIf btn Is BTN_INVENTORY_REPORT_MINIMIZE Then
                Me.WindowState = FormWindowState.Minimized
#End Region

#Region "Close"
            ElseIf btn Is BTN_INVENTORY_REPORT_CLOSE Then
                Me.Close()
#End Region
            End If
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try


    End Sub
#End Region

    Private Sub FRM_INVENTORY_PRINT_PREVIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblM4_INVENTORY_CATEGORYTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND' table. You can move, or remove it, as needed.
        Me.TblM4_INVENTORY_ITEMBRANDTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY' table. You can move, or remove it, as needed.
        Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_ITEMBRAND' table. You can move, or remove it, as needed.

        'add "ALL" to category combobox
        Dim rowtblM4_CATEGORY As DataRow = DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY.NewRow()
        rowtblM4_CATEGORY(0) = 0
        rowtblM4_CATEGORY(1) = "All"
        DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY.Rows.InsertAt(rowtblM4_CATEGORY, 0)
        CB_INVENTORY_REPORT_CATEGORY.DataSource = TblM4INVENTORYCATEGORYBindingSource

        Dim rowtblM4_ITEMBRAND As DataRow = DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND.NewRow()
        rowtblM4_ITEMBRAND(0) = 0
        rowtblM4_ITEMBRAND(1) = "All"
        DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND.Rows.InsertAt(rowtblM4_ITEMBRAND, 0)
        CB_INVENTORY_REPORT_BRAND_NAME.DataSource = TblM4INVENTORYITEMBRANDBindingSource

        Me.SPM4_CURRENTDATETIMETableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_CURRENTDATETIME)
        Dim dte As Date = WatermarkTextBox1.Text
        WTXT_INVENTORY_REPORT_FROM.Text = dte.ToString("MM/dd/yyyy")
        WTXT_INVENTORY_REPORT_TO.Text = dte.ToString("MM/dd/yyyy")
        CB_INVENTORY_REPORT_CATEGORY.SelectedIndex = 0
        CB_INVENTORY_REPORT_BRAND_NAME.SelectedIndex = 0
    End Sub

    Private Sub CB_INVENTORY_REPORT_CATEGORY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INVENTORY_REPORT_CATEGORY.SelectedIndexChanged
        If CB_INVENTORY_REPORT_SUB_CATEGORY.Items.Contains("All") = False Then
            '  TblM4_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_SUB_CATEGORY, CB_INVENTORY_REPORT_CATEGORY.SelectedValue)
            TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CB_INVENTORY_REPORT_CATEGORY.SelectedValue)
            Dim row As DataRow = DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY.NewRow()
            row(0) = 0
            row(2) = "All"
            DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY.Rows.InsertAt(row, 0)
            CB_INVENTORY_REPORT_SUB_CATEGORY.DataSource = TblM4INVENTORYSUBCATEGORYBindingSource
            CB_INVENTORY_REPORT_BRAND_NAME.SelectedIndex = 0
        End If
    End Sub

    Sub LoadReport()
        rptDoc = New RPT_INVENTORY_REPORT
        SpM4_INVENTORY_REPORTTableAdapter.Fill(DS_PROPERTYDB.SPM4_INVENTORY_REPORT, Trim(CB_INVENTORY_REPORT_CATEGORY.Text), Trim(CB_INVENTORY_REPORT_SUB_CATEGORY.Text), Trim(CB_INVENTORY_REPORT_BRAND_NAME.Text), Trim(WTXT_INVENTORY_REPORT_FROM.Text), Trim(WTXT_INVENTORY_REPORT_TO.Text))
        rptDoc.SetDataSource(DS_PROPERTYDB.SPM4_INVENTORY_REPORT.DataSet)
        With rptDoc
            .SetParameterValue(0, Trim(CB_INVENTORY_REPORT_CATEGORY.Text))
            .SetParameterValue(1, Trim(CB_INVENTORY_REPORT_SUB_CATEGORY.Text))
            .SetParameterValue(2, Trim(CB_INVENTORY_REPORT_BRAND_NAME.Text))
            .SetParameterValue(3, Trim(WTXT_INVENTORY_REPORT_FROM.Text))
            .SetParameterValue(4, Trim(WTXT_INVENTORY_REPORT_TO.Text))
        End With
        CRReportInventory.ReportSource = rptDoc
        CRReportInventory.Zoom(1)
    End Sub
End Class