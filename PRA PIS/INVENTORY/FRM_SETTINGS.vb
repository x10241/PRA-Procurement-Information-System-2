Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_SETTINGS


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

    Private Sub FRM_SETTINGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblM4_INVENTORY_CATEGORY1TableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY1, WTXT_SEARCH.Text)
        CB_MAINTENANCE_SELECTION.SelectedIndex = 0
        PB_MAINTENANCE_NEW.Visible = True
        LLBL_MAINTENANCE_NEW.Visible = True
    End Sub

    Private Sub CB_MAINTENANCE_SELECTION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_MAINTENANCE_SELECTION.SelectedIndexChanged
        'If CB_MAINTENANCE_SELECTION.SelectedIndex = 0 Then
        '    TblM4_INVENTORY_CATEGORY1TableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY1, WTXT_SEARCH.Text)
        '    DGV_MAINTENANCE_LIST.DataSource = TblM4_INVENTORY_CATEGORY1BindingSource
        '    LLBL_RECORDSFOUND.Text = DGV_MAINTENANCE_LIST.RowCount
        '    GRP_CATEGORY.Visible = True
        '    GRP_BRANDS.Visible = False
        '    GRP_SUB_CATEGORY.Visible = False
        '    DGV_MAINTENANCE_LIST.ClearSelection()
        'Else

        If CB_MAINTENANCE_SELECTION.SelectedIndex = 0 Then
            TblM4_CATEGORY_AND_SUBTableAdapter.Fill(DS_PROPERTYDB.tblM4_CATEGORY_AND_SUB, WTXT_SEARCH.Text)
            DGV_MAINTENANCE_LIST.DataSource = TblM4_CATEGORY_AND_SUBBindingSource
            LLBL_RECORDSFOUND.Text = DGV_MAINTENANCE_LIST.RowCount
            GRP_SUB_CATEGORY.Visible = True
            GRP_CATEGORY.Visible = False
            GRP_BRANDS.Visible = False
            DGV_MAINTENANCE_LIST.ClearSelection()
        ElseIf CB_MAINTENANCE_SELECTION.SelectedIndex = 1 Then
            Me.TblM4_INVENTORY_ITEMBRAND1TableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND1, WTXT_SEARCH.Text)
            DGV_MAINTENANCE_LIST.DataSource = TblM4_INVENTORY_ITEMBRAND1BindingSource
            LLBL_RECORDSFOUND.Text = DGV_MAINTENANCE_LIST.RowCount
            GRP_CATEGORY.Visible = False
            GRP_BRANDS.Visible = True
            GRP_SUB_CATEGORY.Visible = False
            DGV_MAINTENANCE_LIST.ClearSelection()
        End If
    End Sub

#Region "Click"
    Private Sub BTN_PRMINIMIZE_Click(sender As Object, e As EventArgs) Handles BTN_INMA_MINIMIZE.Click,
                                                                                BTN_INMA_CLOSE.Click,
                                                                                LLBL_MAINTENANCE_NEW.Click,
                                                                                PB_MAINTENANCE_NEW.Click,
                                                                                PB_MAINTENANCE_SAVE.Click,
                                                                                LLBL_MAINTENANCE_SAVE.Click,
                                                                                LLBL_MAINTENANCE_CANCEL.Click,
                                                                                PB_MAINTENANCE_CANCEL.Click,
                                                                                PB_MAINTENANCE_EDIT.Click,
                                                                                LLBL_MAINTENANCE_EDIT.Click,
                                                                                PB_MAINTENANCE_CLEAR.Click


        Dim pb As PictureBox = Nothing
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
        ElseIf TypeOf sender Is TextBox Then
            TXTGLOBAL = CType(sender, TextBox)
        End If

        'MINIMIZE BUTTON HEADER
        If btn Is BTN_INMA_MINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
            'CLOSE FORM
        ElseIf btn Is BTN_INMA_CLOSE Then
            Me.Close()
            'NEW : LABEL AND PB
        ElseIf llbl Is LLBL_MAINTENANCE_NEW Or pb Is PB_MAINTENANCE_NEW Then
            CB_MAINTENANCE_SELECTION.Enabled = False
            LLBL_MAINTENANCE_CANCEL.Enabled = True
            If GRP_BRANDS.Visible = True Then
                GRP_BRANDS.Enabled = True
                RGB_BRANDS_ACTIVE.Checked = True
                WTXT_BRANDNAME.Clear()
            ElseIf GRP_CATEGORY.Visible = True Then
                GRP_CATEGORY.Enabled = True
                RGB_CATEGORY_ACTIVE.Checked = True
                WTXT_CATEGORY_NAME.Clear()
            ElseIf GRP_SUB_CATEGORY.Visible = True Then
                TblM4_INVENTORY_CATEGORYTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
                GRP_SUB_CATEGORY.Enabled = True
                RGB_SUB_CATEGORY_ACTIVE.Checked = True
                WTXT_SUBCATEGORY_NAME.Clear()
            End If
            PB_MAINTENANCE_NEW.Visible = False
            LLBL_MAINTENANCE_NEW.Visible = False
            PB_MAINTENANCE_SAVE.Visible = True
            LLBL_MAINTENANCE_SAVE.Visible = True
            isNew = True
            DGV_MAINTENANCE_LIST.Enabled = False

            'SAVE: LABEL AND PB
        ElseIf llbl Is LLBL_MAINTENANCE_SAVE Or pb Is PB_MAINTENANCE_SAVE Then
            'VALIDATION
            If GRP_BRANDS.Visible = True Then
                ISVALID = True
                If REQFIELDVALIDATION(WTXT_BRANDNAME) = True Then
                    ISVALID = False
                    RECT_BRAND_NAME.BorderColor = Color.OrangeRed
                Else
                    RECT_BRAND_NAME.BorderColor = Color.LightSeaGreen
                End If
            ElseIf GRP_CATEGORY.Visible = True Then
                ISVALID = True
                If REQFIELDVALIDATION(WTXT_CATEGORY_NAME) = True Then
                    ISVALID = False
                    RECT_CATEGORY_NAME.BorderColor = Color.OrangeRed
                Else
                    RECT_CATEGORY_NAME.BorderColor = Color.LightSeaGreen
                End If
            ElseIf GRP_SUB_CATEGORY.Visible = True Then
                ISVALID = True
                If REQFIELDVALIDATION(WTXT_SUBCATEGORY_NAME) = True Then
                    ISVALID = False
                    RECT_SUB_CATEGORY_NAME.BorderColor = Color.OrangeRed
                Else
                    RECT_SUB_CATEGORY_NAME.BorderColor = Color.LightSeaGreen
                End If
            End If
            'IF VALID
            If ISVALID Then
                _SAVE()
                LLBL_MAINTENANCE_CANCEL.Enabled = False
                PB_MAINTENANCE_NEW.Visible = True
                LLBL_MAINTENANCE_NEW.Visible = True
                PB_MAINTENANCE_SAVE.Visible = False
                LLBL_MAINTENANCE_SAVE.Visible = False
                DGV_MAINTENANCE_LIST.ClearSelection()
                DGV_MAINTENANCE_LIST.Enabled = True
            End If
        ElseIf llbl Is LLBL_MAINTENANCE_CANCEL Or pb Is PB_MAINTENANCE_CANCEL Then
            If MsgBox("Cancel this transaction?", vbYesNo, "CONFIRM") = vbYes Then
                PB_MAINTENANCE_NEW.Visible = True
                LLBL_MAINTENANCE_NEW.Visible = True
                PB_MAINTENANCE_SAVE.Visible = False
                LLBL_MAINTENANCE_SAVE.Visible = False
                If GRP_BRANDS.Visible = True Then
                    GRP_BRANDS.Enabled = False
                    RECT_BRAND_NAME.BorderColor = Color.LightSeaGreen
                ElseIf GRP_CATEGORY.Visible = True Then
                    GRP_CATEGORY.Enabled = False
                    RECT_CATEGORY_NAME.BorderColor = Color.LightSeaGreen
                ElseIf GRP_SUB_CATEGORY.Visible = True Then
                    GRP_SUB_CATEGORY.Enabled = False
                    RECT_SUB_CATEGORY_NAME.BorderColor = Color.LightSeaGreen
                End If
                CB_MAINTENANCE_SELECTION.Enabled = True
                PB_MAINTENANCE_CANCEL.Enabled = False
                LLBL_MAINTENANCE_CANCEL.Enabled = False
                DGV_MAINTENANCE_LIST.ClearSelection()
                DGV_MAINTENANCE_LIST.Enabled = True
                CB_CATEGORYNAME.SelectedIndex = -1
                WTXT_BRANDNAME.Clear()
                WTXT_CATEGORY_NAME.Clear()
                WTXT_SEARCH.Clear()
                WTXT_SUBCATEGORY_NAME.Clear()
            End If
        ElseIf llbl Is LLBL_MAINTENANCE_EDIT Or pb Is PB_MAINTENANCE_EDIT Then
            If DGV_MAINTENANCE_LIST.SelectedRows.Count > 0 Then
                LLBL_MAINTENANCE_EDIT.Enabled = False
                PB_MAINTENANCE_EDIT.Enabled = False
                LLBL_MAINTENANCE_CANCEL.Enabled = True
                PB_MAINTENANCE_CANCEL.Enabled = True
                LLBL_MAINTENANCE_SAVE.Visible = True
                PB_MAINTENANCE_SAVE.Visible = True
                LLBL_MAINTENANCE_NEW.Visible = False
                PB_MAINTENANCE_NEW.Visible = False
                If GRP_BRANDS.Visible = True Then
                    GRP_BRANDS.Enabled = True
                ElseIf GRP_CATEGORY.Visible = True Then
                    GRP_CATEGORY.Enabled = True
                ElseIf GRP_SUB_CATEGORY.Visible = True Then
                    GRP_SUB_CATEGORY.Enabled = True
                End If
                isNew = False
                DGV_MAINTENANCE_LIST.Enabled = False
            Else
                NotificationManager.Show(Me, "No selected data.", Color.Red, 3000)
            End If
        ElseIf pb Is PB_MAINTENANCE_CLEAR Then
            WTXT_SEARCH.Clear()
        End If
    End Sub

#End Region

#Region "Save"
    Sub _SAVE()
        Try
            If isNew Then
                'brand
                If GRP_BRANDS.Visible = True Then
                    Me.SPM4_BR_CODE_GENERATORTableAdapter.Fill(Me.DS_STOREDPROC.SPM4_BR_CODE_GENERATOR)
                    TblM4_INVENTORY_ITEMBRANDTableAdapter.IQ_INVENTORY_ITEMS_BRAND(BRCODETextBox.Text, WTXT_BRANDNAME.Text, EMP_NO, If(RGB_BRANDS_ACTIVE.Checked = True, 1, 0))
                    Me.TblM4_INVENTORY_ITEMBRAND1TableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND1, WTXT_SEARCH.Text)
                    DGV_MAINTENANCE_LIST.DataSource = TblM4_INVENTORY_ITEMBRAND1BindingSource
                    LLBL_RECORDSFOUND.Text = DGV_MAINTENANCE_LIST.RowCount
                    WTXT_BRANDNAME.Clear()
                    GRP_BRANDS.Enabled = False
                    CB_MAINTENANCE_SELECTION.Enabled = True
                    'category
                ElseIf GRP_CATEGORY.Visible = True Then
                    TblM4_INVENTORY_CATEGORYTableAdapter.IQ_INVENTORY_CATEGORY(RandomCode, WTXT_CATEGORY_NAME.Text, If(RGB_CATEGORY_ACTIVE.Checked = True, 1, 0), EMP_NO)
                    TblM4_INVENTORY_CATEGORY1TableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY1, WTXT_SEARCH.Text)
                    DGV_MAINTENANCE_LIST.DataSource = TblM4_INVENTORY_CATEGORY1BindingSource
                    LLBL_RECORDSFOUND.Text = DGV_MAINTENANCE_LIST.RowCount
                    GRP_CATEGORY.Enabled = False
                    CB_MAINTENANCE_SELECTION.Enabled = True
                    WTXT_CATEGORY_NAME.Clear()
                    'sub category
                ElseIf GRP_SUB_CATEGORY.Visible = True Then
                    SPM4_SC_CODE_GENERATORTableAdapter.Fill(DS_STOREDPROC.SPM4_SC_CODE_GENERATOR)
                    TblM4_INVENTORY_SUB_CATEGORYTableAdapter.IQ_INVENTORY_SUB_CATEGORY(SCCODETextBox.Text, CB_CATEGORYNAME.SelectedValue, WTXT_SUBCATEGORY_NAME.Text, If(RGB_SUB_CATEGORY_ACTIVE.Checked = True, 1, 0), EMP_NO)
                    TblM4_CATEGORY_AND_SUBTableAdapter.Fill(DS_PROPERTYDB.tblM4_CATEGORY_AND_SUB, WTXT_SEARCH.Text)
                    DGV_MAINTENANCE_LIST.DataSource = TblM4_CATEGORY_AND_SUBBindingSource
                    LLBL_RECORDSFOUND.Text = DGV_MAINTENANCE_LIST.RowCount
                    WTXT_SUBCATEGORY_NAME.Clear()
                    GRP_SUB_CATEGORY.Enabled = False
                    CB_MAINTENANCE_SELECTION.Enabled = True
                    CB_CATEGORYNAME.SelectedIndex = -1
                End If
            Else
                'brand
                If GRP_BRANDS.Visible = True Then
                    TblM4_INVENTORY_ITEMBRANDTableAdapter.UQ_INVENTORY_ITEMS_BRAND(WTXT_BRANDNAME.Text, EMP_NO, If(RGB_BRANDS_ACTIVE.Checked = True, 1, 0), MAINTENANCEIDHOLD)
                    TblM4_INVENTORY_ITEMBRAND1TableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_ITEMBRAND1, WTXT_SEARCH.Text)
                    DGV_MAINTENANCE_LIST.DataSource = TblM4_INVENTORY_ITEMBRAND1BindingSource
                    LLBL_RECORDSFOUND.Text = DGV_MAINTENANCE_LIST.RowCount
                    WTXT_BRANDNAME.Clear()
                    GRP_BRANDS.Enabled = False
                    CB_MAINTENANCE_SELECTION.Enabled = True
                    'category
                ElseIf GRP_CATEGORY.Visible = True Then
                    TblM4_INVENTORY_CATEGORYTableAdapter.UQ_INVENTORY_CATEGORY(WTXT_CATEGORY_NAME.Text, If(RGB_CATEGORY_ACTIVE.Checked = True, 1, 0), EMP_NO, MAINTENANCEIDHOLD)
                    TblM4_INVENTORY_CATEGORY1TableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY1, WTXT_SEARCH.Text)
                    DGV_MAINTENANCE_LIST.DataSource = TblM4_INVENTORY_CATEGORY1BindingSource
                    LLBL_RECORDSFOUND.Text = DGV_MAINTENANCE_LIST.RowCount
                    GRP_CATEGORY.Enabled = False
                    CB_MAINTENANCE_SELECTION.Enabled = True
                    'sub category
                ElseIf GRP_SUB_CATEGORY.Visible = True Then
                    TblM4_INVENTORY_SUB_CATEGORYTableAdapter.UQ_INVENTORY_SUB_CATEGORY(CB_CATEGORYNAME.SelectedValue, WTXT_SUBCATEGORY_NAME.Text, If(RGB_SUB_CATEGORY_ACTIVE.Checked = True, 1, 0), EMP_NO, MAINTENANCEIDHOLD)
                    TblM4_CATEGORY_AND_SUBTableAdapter.Fill(DS_PROPERTYDB.tblM4_CATEGORY_AND_SUB, WTXT_SEARCH.Text)
                    DGV_MAINTENANCE_LIST.DataSource = TblM4_CATEGORY_AND_SUBBindingSource
                    LLBL_RECORDSFOUND.Text = DGV_MAINTENANCE_LIST.RowCount
                    WTXT_SUBCATEGORY_NAME.Clear()
                    GRP_SUB_CATEGORY.Enabled = False
                    CB_MAINTENANCE_SELECTION.Enabled = True
                End If
            End If
            NotificationManager.Show(Me, "Successfully Saved.", Color.Green, 3000)
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub
#End Region

#Region "Cell Click"
    Private Sub DGV_MAINTENANCE_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_MAINTENANCE_LIST.CellClick
        Dim dgv1 = CType(sender, DataGridView)
        If DGV_MAINTENANCE_LIST.SelectedRows.Count > 0 Then
            If e.RowIndex >= 0 Then
                LLBL_MAINTENANCE_EDIT.Enabled = True
                PB_MAINTENANCE_EDIT.Enabled = True
                'ITEM BRAND
                If GRP_BRANDS.Visible = True Then
                    If dgv1.Rows(e.RowIndex).Cells(3).Value.ToString() = "Active" Then
                        RGB_BRANDS_ACTIVE.Checked = True
                    Else
                        RGB_BRANDS_INACTIVE.Checked = True
                    End If
                    MAINTENANCEIDHOLD = dgv1.Rows(e.RowIndex).Cells(0).Value.ToString()
                    WTXT_BRANDNAME.Text = dgv1.Rows(e.RowIndex).Cells(1).Value.ToString()
                    'CATEGORY
                ElseIf GRP_CATEGORY.Visible = True Then
                    If dgv1.Rows(e.RowIndex).Cells(3).Value.ToString() = "Active" Then
                        RGB_CATEGORY_ACTIVE.Checked = True
                    Else
                        RGB_CATEGORY_INACTIVE.Checked = True
                    End If
                    MAINTENANCEIDHOLD = dgv1.Rows(e.RowIndex).Cells(0).Value.ToString()
                    WTXT_CATEGORY_NAME.Text = dgv1.Rows(e.RowIndex).Cells(1).Value.ToString()
                    'SUB CATEGORY
                ElseIf GRP_SUB_CATEGORY.Visible = True Then
                    If dgv1.Rows(e.RowIndex).Cells(4).Value.ToString() = "Active" Then
                        RGB_SUB_CATEGORY_ACTIVE.Checked = True
                    Else
                        RGB_SUB_CATEGORY_INACTIVE.Checked = True
                    End If
                    ' TblM4_INVENTORY_CATEGORY1TableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY1, WTXT_SEARCH.Text)
                    TblM4_INVENTORY_CATEGORYTableAdapter.FillByActive(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
                    MAINTENANCEIDHOLD = dgv1.Rows(e.RowIndex).Cells(0).Value.ToString()
                    CB_CATEGORYNAME.SelectedIndex = CB_CATEGORYNAME.FindStringExact(dgv1.Rows(e.RowIndex).Cells(1).Value.ToString())
                    WTXT_SUBCATEGORY_NAME.Text = dgv1.Rows(e.RowIndex).Cells(2).Value.ToString()
                End If
            End If
        Else
            LLBL_MAINTENANCE_EDIT.Enabled = False
            PB_MAINTENANCE_EDIT.Enabled = False
        End If
    End Sub

#End Region

#Region "TextChanged"
    Private Sub WTXT_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCH.TextChanged
        If REQFIELDVALIDATION(WTXT_SEARCH) Then
            PB_MAINTENANCE_CLEAR.Visible = False
        Else
            PB_MAINTENANCE_CLEAR.Visible = True
        End If
        TblM4_INVENTORY_CATEGORY1TableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY1, WTXT_SEARCH.Text)
    End Sub

    Private Sub BTN_ADD_SUBCATEGORY_Click(sender As Object, e As EventArgs) Handles BTN_ADD_CATEGORY.Click
        Dim btn As Button = Nothing

        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

        If btn Is BTN_ADD_CATEGORY Then
            FRM_ADDITIONAL_CATEGORIZATION.LBL_ADDITIONAL_CATEGORIZATION.Text = " C A T E G O R Y"
            FRM_ADDITIONAL_CATEGORIZATION.GRP_CATEGORY.Visible = True
            FRM_ADDITIONAL_CATEGORIZATION.GRP_CATEGORY.Enabled = True
            FRM_ADDITIONAL_CATEGORIZATION.ShowDialog()
            TblM4_INVENTORY_CATEGORYTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
        End If
    End Sub
#End Region

End Class