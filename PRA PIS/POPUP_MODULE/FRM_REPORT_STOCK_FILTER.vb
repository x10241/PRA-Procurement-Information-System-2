Public Class FRM_REPORT_STOCK_FILTER
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
            FRM_PRINT_PREVIEW.ShowDialog()
        End If
    End Sub

    Private Sub FRM_REPORT_STOCK_FILTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub


End Class