Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_SETTINGS_SELECTION

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

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseMove

    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseUp
        drag = False
    End Sub
#End Region


    Public Function OpenProgram(ByVal ThisOne As Form) As Form
        Return CType(Activator.CreateInstance(ThisOne.GetType()), Form)
    End Function

    Private Sub BTN_PRCLOSE_Click(sender As Object, e As EventArgs) Handles BTN_SELECTIONCLOSE.Click
        Me.Close()
    End Sub

    Private Sub BTN_SETTINGS_CATEGORY_Click(sender As Object, e As EventArgs) Handles BTN_SETTINGS_CATEGORY.Click,
                                                                                        BTN_SETTINGS_SUB_CATEGORY.Click,
                                                                                        BTN_SETTINGS_BRANDS.Click,
                                                                                        BTN_SELECTIONMINIMIZE.Click,
                                                                                        BTN_SELECTIONCLOSE.Click
        Dim btn As Button = Nothing
        llbl = Nothing
        rect = Nothing
        TXTGLOBAL = Nothing

        If TypeOf sender Is LinkLabel Then
            llbl = DirectCast(sender, LinkLabel)
        ElseIf TypeOf sender Is RectangleShape Then
            rect = DirectCast(sender, RectangleShape)
        ElseIf TypeOf sender Is Button Then
            btn = CType(sender, Button)
        ElseIf TypeOf sender Is TextBox Then
            TXTGLOBAL = CType(sender, TextBox)
        End If

        'If btn Is BTN_SETTINGS_CATEGORY Then
        '    Dim newApp As Form = FRM_SETTINGS.OpenProgram(FRM_SETTINGS)
        '    FRM_SETTINGS.LBLSETTINGSHEAD.Text = "C A T E G O R Y"
        '    FRM_SETTINGS.GBOX_SETTINGS.Text = "TOTAL NO. OF CATEGORIES"
        '    FRM_SETTINGS.Show()
        'ElseIf btn Is BTN_SETTINGS_CATEGORY Then
        '    Dim newApp As Form = FRM_SETTINGS.OpenProgram(FRM_SETTINGS)
        '    FRM_SETTINGS.LBLSETTINGSHEAD.Text = "S U B  C A T E G O R Y"
        '    FRM_SETTINGS.GBOX_SETTINGS.Text = "TOTAL NO. OF SUB CATEGORY"
        '    FRM_SETTINGS.Show()
        'ElseIf btn Is BTN_SETTINGS_CATEGORY Then
        '    Dim newApp As Form = FRM_SETTINGS.OpenProgram(FRM_SETTINGS)
        '    FRM_SETTINGS.LBLSETTINGSHEAD.Text = "B R A N D S"
        '    FRM_SETTINGS.GBOX_SETTINGS.Text = "TOTAL NO. OF BRANDS"
        '    FRM_SETTINGS.Show()
        'ElseIf btn Is BTN_SELECTIONMINIMIZE Then
        '    Me.WindowState = FormWindowState.Minimized
        'ElseIf btn Is BTN_SELECTIONCLOSE Then
        '    Me.Close()
        'End If
    End Sub
End Class