Imports System.ComponentModel
Imports System.IO
Imports Microsoft.VisualBasic.PowerPacks
'Imports Seagull
'Imports Seagull.BarTender.Print
'Imports Seagull.BarTender.Print.Database
'Imports Seagull.BarTender.PrintServer
'Imports Seagull.BarTender.PrintServer.Tasks
'Imports System.Threading

Public Class FRM_STICKER_TAG

#Region "VARIABLES DECLARATION"
    ' Common strings.s
    'Dim appName As String = "Print Preview"

    'Dim engine As Engine = Nothing ' The BarTender Print Engine.
    'Dim btFormat As LabelFormatDocument = Nothing
    'Dim previewPath As String = "" ' The path to the folder where the previews will be exported.
    'Dim currentPage As Integer = 1 ' The current page being viewed.
    'Dim totalPages As Integer ' Number of pages.
    'Dim messages As Messages
    'Dim defaultPath As String = Environment.CurrentDirectory

    'Dim PreviewThread As Thread
    'Dim NoRecords As Boolean = False
    'Private Delegate Sub ThreadAssistDelegate()
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

    Private Sub FRM_STICKER_TAG_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        isPreviewClick = False
        CB_TEMPLATE_SIZE.SelectedIndex = 0
    End Sub

    'Sub LoadPreview()
    '    Try
    '        Dim preview4x3() As String
    '        Dim preview3x2() As String

    '        If CB_TEMPLATE_SIZE.SelectedIndex = 0 Then
    '            preview3x2 = Directory.GetFiles(defaultPath + "\StickerPrintPreview", "*3x2*.*")
    '            totalPages = preview3x2.Length
    '        Else
    '            preview4x3 = Directory.GetFiles(defaultPath + "\StickerPrintPreview", "*4x3*.*")
    '            totalPages = preview4x3.Length
    '        End If

    '        Using btEngine As New Engine
    '            btEngine.Start()
    '            btEngine.Window.VisibleWindows = VisibleWindows.None
    '            'drive c: - for testing
    '            ' Dim btFormat As LabelFormatDocument = btEngine.Documents.Open("c:\PrintPreview\4x3.btw")

    '            'if template size is 3x2
    '            If CB_TEMPLATE_SIZE.SelectedIndex = 0 Then
    '                'directory of application: - for production
    '                btFormat = btEngine.Documents.Open(defaultPath + "\3x2.btw")
    '                'if template size is 4x3
    '            Else
    '                'directory of application: - for production
    '                btFormat = btEngine.Documents.Open(defaultPath + "\4x3.btw")
    '            End If

    '            ' Export the label format's print preview image(s) to a file. 
    '            Dim queryprompts As QueryPrompts = btFormat.DatabaseConnections.QueryPrompts

    '            ' Set a QueryPrompt's value using its name (case sensitive).
    '            queryprompts("CAT_NAME").Value = CB_INVENTORY_REPORT_CATEGORY.Text
    '            queryprompts("SC_SUBCATEGORY_NAME").Value = CB_INVENTORY_REPORT_SUB_CATEGORY.Text
    '            queryprompts("ITBR_NAME").Value = CB_INVENTORY_REPORT_BRAND_NAME.Text
    '            queryprompts("DATEFROM").Value = WTXT_INVENTORY_REPORT_FROM.Text
    '            queryprompts("DATETO").Value = WTXT_INVENTORY_REPORT_TO.Text

    '            'if template size is 3x2
    '            If CB_TEMPLATE_SIZE.SelectedIndex = 0 Then
    '                ' export the file as image JPEG per row(from query)
    '                btFormat.ExportPrintPreviewToFile(defaultPath + "\StickerPrintPreview", "Preview3x2%PageNumber%.jpg", ImageType.JPEG, ColorDepth.ColorDepth256, New Resolution(300), Color.Green, OverwriteOptions.Overwrite, True, True, messages)
    '                'if template size is 4x3
    '            Else
    '                ' export the file as image JPEG per row(from query)
    '                btFormat.ExportPrintPreviewToFile(defaultPath + "\StickerPrintPreview", "Preview4x3%PageNumber%.jpg", ImageType.JPEG, ColorDepth.ColorDepth256, New Resolution(300), Color.Green, OverwriteOptions.Overwrite, True, True, messages)
    '            End If

    '            If btFormat IsNot Nothing Then
    '                ' Select the printer in use by the format.
    '                CB_PRINTERS.SelectedItem = btFormat.PrintSetup.PrinterName
    '            End If

    '            ' Get the default printer of template from the dropdown and assign it to the format.
    '            btFormat.PrintSetup.PrinterName = CB_PRINTERS.SelectedItem.ToString()

    '            ' Set control states to show working. These will be reset when the work completes.
    '            btEngine.Stop()
    '        End Using
    '    Catch ex As Exception
    '        NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
    '    End Try

    '    For Each message As Message In messages
    '        ' Console.WriteLine("Message Category: " & message.Category & ", Message Severity: " & message.Severity & ", Message ID: " & message.ID & ", Message Text: " & message.Text + Constants.vbLf)
    '        If message.Text = "No records found." Then
    '            NoRecords = True
    '        Else
    '            NoRecords = False
    '        End If
    '    Next message

    'End Sub

    Private Sub WTXT_INVENTORY_REPORT_FROM_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_MINIMIZE.Click,
                                                                                            BTN_INVENTORY_CLOSE.Click,
                                                                                            BTN_STICKER_PREVIEW.Click
        ' BTN_INVENTORY_MINIMIZE.Click()

        Dim pb As PictureBox = Nothing
        Dim lbl As Label = Nothing
        Dim btn As Button = Nothing
        llbl = Nothing
        rect = Nothing
        TXTGLOBAL = Nothing

        If TypeOf sender Is LinkLabel Then
            llbl = DirectCast(sender, LinkLabel)
        ElseIf TypeOf sender Is RectangleShape Then
            rect = DirectCast(sender, RectangleShape)
        ElseIf TypeOf sender Is PictureBox Then
            pb = CType(sender, PictureBox)
        ElseIf TypeOf sender Is Button Then
            btn = CType(sender, Button)
        ElseIf TypeOf sender Is Label Then
            lbl = CType(sender, Label)
        ElseIf TypeOf sender Is TextBox Then
            TXTGLOBAL = CType(sender, TextBox)
        End If

        If btn Is BTN_INVENTORY_MINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
        ElseIf btn Is BTN_INVENTORY_CLOSE Then
            Me.Close()
        ElseIf btn Is BTN_STICKER_PREVIEW Then
            QRTEXT = WTXT_SEARCH_QRCODEDTAG.Text
            isPreviewClick = True
            printPreview = "StickerTag"
            FRM_PMD_PREVIEW.ShowDialog()
        End If
    End Sub

    Private Sub FRM_STICKER_TAG_Load(sender As Object, e As EventArgs) Handles Me.Load
A:
        Try
            SPM4_PRINTSTICKERTableAdapter.Fill(DS_STOREDPROC.SPM4_PRINTSTICKER, WTXT_SEARCH_QRCODEDTAG.Text)
        Catch ex As Exception
            GoTo A
        End Try

    End Sub

    Private Sub WTXT_SEARCH_QRCODEDTAG_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCH_QRCODEDTAG.TextChanged
A:
        Try
            SPM4_PRINTSTICKERTableAdapter.Fill(DS_STOREDPROC.SPM4_PRINTSTICKER, WTXT_SEARCH_QRCODEDTAG.Text)
        Catch ex As Exception
            GoTo A
        End Try

    End Sub

    Private Sub CB_TEMPLATE_SIZE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_TEMPLATE_SIZE.SelectedIndexChanged
        If CB_TEMPLATE_SIZE.SelectedIndex = 0 Then
            stickerType = 1
        Else CB_template_size.SelectedIndex = 1
            stickerType = 2
        End If
    End Sub
End Class