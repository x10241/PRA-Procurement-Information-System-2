Public Class FRM_ASSIGN_ITEMS

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

    Private Sub BTN_GENERATE_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_GENERATE_REPORT.Click
        printPreview = "AssignItem"
        FRM_PMD_PREVIEW.ShowDialog()
    End Sub

    Private Sub FRM_ASSIGN_ITEMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VWM4_ITEM_ASSTableAdapter.FillByITEM_CODE(Me.DS_VIEWS.VWM4_ITEM_ASS)
        LLBL_TOT_REC.Text = DGV_ASSIGN_ITEMS_LIST.Rows.Count
    End Sub

    Private Sub WTXT_LIST_PREFERRED_ITEMS_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCH_ASS_ITEM.TextChanged
        VWM4_ITEM_ASSBindingSource.Filter = "ITEM_CODE LIKE '%" + WTXT_SEARCH_ASS_ITEM.Text + "%'" + " OR " +
                                            "ITEM_SERIAL_NO LIKE '%" + WTXT_SEARCH_ASS_ITEM.Text + "%'" + " OR " +
                                            "ITEM_DESCRIPTION LIKE '%" + WTXT_SEARCH_ASS_ITEM.Text + "%'" + " OR " +
                                            "FULLNAME LIKE '%" + WTXT_SEARCH_ASS_ITEM.Text + "%'"
        LLBL_TOT_REC.Text = DGV_ASSIGN_ITEMS_LIST.Rows.Count
    End Sub

    Private Sub BTN_SELECTION_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_SELECTION_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub BTN_ASSIGN_ITEM_Click(sender As Object, e As EventArgs) Handles BTN_ASSIGN_ITEM.Click
        FRM_ASSIGN.ShowDialog()
        Me.VWM4_ITEM_ASSTableAdapter.FillByITEM_CODE(Me.DS_VIEWS.VWM4_ITEM_ASS)
    End Sub

    Private Sub DGV_ASSIGN_ITEMS_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ASSIGN_ITEMS_LIST.CellClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = 21 Then
                'FRM_ASSIGN.GB_ITEMDETAILS.Enabled = False

            End If
        End If
    End Sub
End Class