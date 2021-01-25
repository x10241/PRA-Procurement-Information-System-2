Public Class FRM_REPORT_STOCK_FILTER


#Region "START ##### FORM DRAG AND DROP"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

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



    Private Sub BTN_INVENTORY_REPORT_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_REPORT_CLOSE.Click,
                                                                                            BTN_VIEW_REPORT.Click
        Dim btn As Button = Nothing

        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

        If btn Is BTN_INVENTORY_REPORT_CLOSE Then
            Me.Close()
            Me.Dispose()
        ElseIf btn Is BTN_VIEW_REPORT Then
            REP_TYPE = "STOCK_LIST"
            STK_ORDERBY = CB_ITEM_ORDER.SelectedIndex
            STK_SORTBY = CB_SORT_BY.SelectedIndex
            STK_MONTH = CB_MONTH.Text
            STK_YEAR = CB_YEAR.Text
            STK_APPBY = WTXT_APPROVED_BY.Text
            STK_POS = WTXT_POSITION.Text
            STK_ORDER_B = CB_SORT_BY.Text
            FRM_PMD_PRINT_PREVIEW.ShowDialog()
        End If
    End Sub

    Private Sub FRM_REPORT_STOCK_FILTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
A:
        Try
            Me.SPM4_PDS_LISTTableAdapter.FillBySEARCH(Me.DS_PRAJO_DATABASE.SPM4_PDS_LIST, "")
#Region "APPROVED BY"
            Dim USERsuggestions As New AutoCompleteStringCollection()
            If SPM4_PDS_LISTBindingSource.Count > 0 Then
                For x = 0 To SPM4_PDS_LISTBindingSource.Count - 1
                    USERsuggestions.Add(CStr(If(IsDBNull(CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0)), "", CType(SPM4_PDS_LISTBindingSource.List(x), DataRowView).Item(0))))
                Next
                WTXT_APPROVED_BY.AutoCompleteCustomSource = USERsuggestions
            End If
#End Region
        Catch ex As Exception
            GoTo A
        End Try

#Region "CB FOR MONTH/YEAR"
        SPM4_ITEM_STOCKMASTERLIST_RPT_DTTableAdapter.FillByYCODE(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST_RPT_DT, "Y")
        SPM4_ITEM_STOCKMASTERLIST_RPT_DT1TableAdapter.Fill(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST_RPT_DT1, "M")
        CB_ITEM_ORDER.SelectedIndex = 0
        CB_SORT_BY.SelectedIndex = 0
#End Region
    End Sub

    Private Sub WTXT_APPROVED_BY_TextChanged(sender As Object, e As EventArgs) Handles WTXT_APPROVED_BY.TextChanged
        SPM4_PDS_LISTBindingSource.Filter = "FULLNAME = '" & WTXT_APPROVED_BY.Text & "'"
        WTXT_POSITION.Text = BS_SINGLEROW(SPM4_PDS_LISTBindingSource, 47)
    End Sub
End Class