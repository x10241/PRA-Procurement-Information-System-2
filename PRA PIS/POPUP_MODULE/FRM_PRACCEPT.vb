Imports System.IO

Public Class FRM_PRACCEPT

#Region "VARIABLES DECLARATION"


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

#Region "LOAD"
    Private Sub FRM_PRACCEPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ACCEPTED' table. You can move, or remove it, as needed.
        'Me.TblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ACCEPTED)
        ''TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ACCEPTED' table. You can move, or remove it, as needed.
        'Me.TblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ACCEPTED)
        ''TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_PURCHASEREQUEST_CATEGORY' table. You can move, or remove it, as needed.
        Me.TblM4_PURCHASEREQUEST_CATEGORYTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST_CATEGORY)
        ' CB_PURCHASE_REQUEST_CATEGORY.SelectedIndex = 0
        'DGV_SCANNED_IMG.Rows.Clear()
        '  If isSCANNERCLOSE = False Then
        'OPENINITSCANNER()
        ' End If
    End Sub

#End Region

#Region "SCANNER TO COMBOBOX SELECTION"
    Private Sub DisplayScanners(ByVal strScanners As String)
        cbxSources.Items.Clear()
        For Each s In Split(strScanners, ",")
            cbxSources.Items.Add(s)
        Next
    End Sub
#End Region

#Region "OPEN SCANNER INITIALIZE"
    '    Public Sub OPENINITSCANNER()
    '        Try
    '            KODAKSCANSDK = New KODAKSCANSDK.Program
    '            AddHandler MyScanEvent.ScanEvent, AddressOf DataGridView1_Click
    '#Region "Scanner Selection"
    '            Dim ExitCode As Integer
    '            Dim strScanners As String

    '            If KODAKSCANSDK.SetLanguage(m_szLanguage) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetLanguage" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.Init(hWnd) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: Init" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            End If

    '            strScanners = KODAKSCANSDK.SelectScanner()
    '            DisplayScanners(strScanners)
    '            cbxSources.SelectedIndex = 0
    '            'LBL_SCANNERNAME.Text = cbxSources.Text
    '#End Region

    '#Region "Opening Scanner"
    '            filenumber = Convert.ToInt32(m_szFileNumber)
    '            If KODAKSCANSDK.SetScanner(m_szScanner) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetScanner" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetFileNumber(m_szFileNumber) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetFileNumber" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetFileName(m_szFileName) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetFileName" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetFilePathName(m_szFilePathName) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetFilePathName" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.OpenScanner(hWnd) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: OpenScanner" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetScannerProfile(m_szScannerProfile) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetScannerProfile" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            End If

    '#End Region

    '#Region "Set Scanner's Parameter"

    '            If KODAKSCANSDK.SetPaperSource(m_szPaperSource) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetPaperSource" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetScanAs("2") <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetScanAs" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetDocumentType(m_szDocumentType) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetDocumentType" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetDPIResolution(m_szDpiResolution) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetDPIResolution" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetFileType(m_szFileType) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetFileType" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetCompressionType(m_szCompressionType) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetCompressionType" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf (m_szCompressionType = "6") Then
    '                If KODAKSCANSDK.SetJPEGQuality(m_szJpegQuality) <> 0 Then
    '                    NotificationManager.Show(Me, "An error occurred: SetJPEGQuality" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '                End If
    '            ElseIf (m_szScanAs <> "0") Then
    '                If KODAKSCANSDK.SetSharpen(m_szSharpen) <> 0 Then
    '                    NotificationManager.Show(Me, "An error occurred: SetSharpen" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '                End If
    '            ElseIf KODAKSCANSDK.SetImageRotation(m_szImageRotation) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetImageRotation" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf KODAKSCANSDK.SetBlankImageDeletion(m_szBlankImageDeletion) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: SetBlankImageDeletion" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            ElseIf (m_szBlankImageDeletion = "2") Then
    '                If KODAKSCANSDK.SetBlankImageDeletionPercent(m_szBlankImageDeletionPercent) <> 0 Then
    '                    NotificationManager.Show(Me, "An error occurred: SetBlankImageDeletionPercent" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '                End If
    '            ElseIf KODAKSCANSDK.ShowScannerUI(m_szShowScannerUI) <> 0 Then
    '                NotificationManager.Show(Me, "An error occurred: ShowScannerUI" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
    '            End If

    '#End Region
    '        Catch ex As Exception
    '            NotificationManager.Show(Me, "An error occurred: Init Scanner Opening", Color.Red, 3000)
    '        End Try
    'End Sub
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_ACCEPT_SCAN.Click, BTN_ACCEPT_SAVE.Click

        Dim pb As PictureBox = Nothing
        Dim lbl As Label = Nothing
        Dim btn As Button = Nothing
        llbl = Nothing
        rect = Nothing
        TXTGLOBAL = Nothing

        If TypeOf sender Is LinkLabel Then
            llbl = DirectCast(sender, LinkLabel)
        ElseIf TypeOf sender Is PictureBox Then
            pb = CType(sender, PictureBox)
        ElseIf TypeOf sender Is Button Then
            btn = CType(sender, Button)
        ElseIf TypeOf sender Is Label Then
            lbl = CType(sender, Label)
        ElseIf TypeOf sender Is TextBox Then
            TXTGLOBAL = CType(sender, TextBox)
        End If

#Region "Scan button"
        If btn Is BTN_ACCEPT_SCAN Then
            'DGV_SCANNED_IMG.Rows.Clear()
            'Dim NUMBER_OF_SCAN As String = InputBox("PLEASE ENTER THE NUMBER OF DOCUMENT/S TO BE SCAN.", "ENTER VALUE", "0")
            'Try
            '    If CInt(NUMBER_OF_SCAN) > 0 And CInt(NUMBER_OF_SCAN) < 6 Then
            '        For x = 0 To NUMBER_OF_SCAN - 1
            '            DGV_SCANNED_IMG.Rows.Add(My.Resources.SCAN_DOCUMENT)
            '        Next
            '        Dim ExitCode As Integer
            '        i = 0
            '        If KODAKSCANSDK.StartScan(m_szOnePage, hWnd) <> 0 Then
            '            NotificationManager.Show(Me, "An error occurred: StartScan" & vbCrLf & ExitCode.ToString("X"), Color.Red, 3000)
            '        End If
            '    Else
            '        NotificationManager.Show(Me, "VALUE HAS EXCEED THE MAX NUMBER OF DOCUMENTS" & vbNewLine & "MAX DOCUMENT=5", Color.Red, 3000)
            '    End If
            'Catch ex As Exception
            '    NotificationManager.Show(Me, "INVALID INPUT!", Color.Red, 3000)
            'End Try
#End Region

#Region "Save"
        ElseIf btn Is BTN_ACCEPT_SAVE Then
            '   If DGV_SCANNED_IMG.Rows.Count > 0 Then
            'If Not BwMakePdf.IsBusy Then
            '    'Create and fill up WorkerParameters object.
            '    Dim info As New WorkerParameters
            '    With info
            '        .InputDirectory = SCANNEDFILEDIR_JPEG_FOLDER(PRNO, My.Settings.PIS_FILENAME_PR, Trim(PRNO))
            '        .OutputFile = SCANNEDFILEDIR(PRNO, My.Settings.PIS_FILENAME_PR, Trim(PRNO))
            '    End With
            '    'Start thread using "info" object as Argument
            '    BwMakePdf.RunWorkerAsync(info)
            'Else
            '    MsgBox("Thread is busy.", vbExclamation, "Busy.")
            'End If
            ISVALID = True

            If CB_PURCHASE_REQUEST_CATEGORY.SelectedIndex >= 0 Then
                ISVALID = True
            Else
                ISVALID = False
            End If

            If ISVALID Then
                TblM4_PURCHASEREQUEST_ACCEPTEDTableAdapter.IQ_ACCEPTED(PRNO, EMP_NO, CB_PURCHASE_REQUEST_CATEGORY.SelectedValue)
                TblM4_PURCHASEREQUESTTableAdapter.UQ_STATUSAPPCODE(1, EMP_NO, PR_APPCODE, PRNO)
                Me.Close()
                MsgBox("Successfully Accepted.", MsgBoxStyle.Information)
                PNL_SLIDE.Location = New Point(1095, 40)
            Else
                NotificationManager.Show(Me, "Please select category!", Color.Red, 3000)
            End If

            '  End If
#End Region

        End If

    End Sub

#Region "SCANNER TO DGV SHOW"
    'Private Sub DataGridView1_Click(args As String) Handles MyScanEvent.ScanEvent
    '    Dim filename As String
    '    If (args = 1) Then
    '        filenumber = filenumber + 1
    '        If (m_szFileType = "0") Then
    '            filename = Path.Combine(m_szFilePathName, m_szFileName & filenumber.ToString("000000") & ".tif")
    '        Else
    '            filename = Path.Combine(m_szFilePathName, m_szFileName & filenumber.ToString("000000") & ".jpg")
    '        End If
    '        Dim fs As FileStream
    '        fs = New FileStream(filename, IO.FileMode.Open, IO.FileAccess.Read)
    '        If i Mod 2 = 0 Then
    '            DGV_SCANNED_IMG(0, If(i < 1, 0, i - 1)).Value = Image.FromStream(fs)
    '            SCANNEDFILEDIR_JPEG(PRNO, My.Settings.PIS_FILENAME_PR, PRNO, Image.FromStream(fs), If(i < 1, 0, i - 1))
    '        End If
    '        fs.Close()
    '        i += 1
    '    End If
    'End Sub

#End Region

#Region "BACKGROUNDWORKER"
    'Private Class WorkerParameters
    '    Public Property InputDirectory As String
    '    Public Property OutputFile As String
    'End Class
    'Private Sub bwMakePdf_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BwMakePdf.DoWork
    '    'Create new PDF Document.
    '    Using pdf As New PdfSharp.Pdf.PdfDocument
    '        'Get parameter to process PDF.
    '        Dim info As WorkerParameters = DirectCast(e.Argument, WorkerParameters)

    '        'Find all files on source directory (sub-directories not included).
    '        Dim allFiles = Directory.GetFiles(info.InputDirectory, "*.*", SearchOption.TopDirectoryOnly)

    '        'Function to find compatible file types.
    '        'In .NET 4.0, you can use LINQ to do this.
    '        Dim findMatch = Function(filePath As String)
    '                            'PDFSharp only supports PNG, BMP, JPG, and GIF.
    '                            Return filePath.ToLower.EndsWith(".png") Or
    '                                   filePath.ToLower.EndsWith(".bmp") Or
    '                                   filePath.ToLower.EndsWith(".jpg") Or
    '                                   filePath.ToLower.EndsWith(".gif")
    '                        End Function

    '        'Find entire array.
    '        Dim filesToProcess = Array.FindAll(Of String)(allFiles, findMatch)

    '        'Get file count.
    '        Dim fileCount As Integer = filesToProcess.Length

    '        'Add PDF pages.
    '        For i As Integer = 1 To fileCount
    '            'Check if operation is cancelled.
    '            If BwMakePdf.CancellationPending Then
    '                Exit For
    '            End If

    '            'Create new PDF page.
    '            Dim page = pdf.AddPage()

    '            'Create XImage object from file.
    '            Using xImg = PdfSharp.Drawing.XImage.FromFile(filesToProcess(i - 1))
    '                'Resize page Width and Height to fit picture size.
    '                page.Width = xImg.PixelWidth * 72 / xImg.HorizontalResolution
    '                page.Height = xImg.PixelHeight * 72 / xImg.HorizontalResolution

    '                'Draw current image file to page.
    '                Dim GR = PdfSharp.Drawing.XGraphics.FromPdfPage(page)
    '                GR.DrawImage(xImg, 0, 0, page.Width, page.Height)
    '            End Using

    '            'Report progress.
    '            BwMakePdf.WorkerReportsProgress = True
    '            BwMakePdf.ReportProgress((i / fileCount) * 100)
    '        Next

    '        'Erase all items in array. Memory leaking free...
    '        Erase filesToProcess

    '        'Save to PDF file.
    '        pdf.Save(info.OutputFile)
    '    End Using
    'End Sub
#End Region

    Private Sub FRM_PRACCEPT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' isSCANNERCLOSE = False
        'KODAKSCANSDK = Nothing
        'CLOSESCANNER()
    End Sub

#Region "CLOSING SCANNER"
    'Public Sub CLOSESCANNER()
    '    Try
    '        If KODAKSCANSDK.CloseScanner() <> 0 Then
    '            NotificationManager.Show(MDI_Mainform, "An error occurred: CloseScanner" & vbCrLf & KODAKSCANSDK.CloseScanner().ToString("X"), Color.Red, 3000)
    '        End If
    '    Catch ex As Exception
    '        '   ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "FRM_PRIVATEBANK ERROR")
    '        NotificationManager.Show(Me, "AN ERROR OCCURED PLEASE CONTACT SYSTEM DEVELOPER!" & vbNewLine & My.Settings.PRADEV, Color.Red, 3000)
    '    End Try
    'End Sub
#End Region

End Class