Public Class FRM_PRINT_PREVIEW

#Region "CLICK"

    Private Sub BTN_INVENTORY_REPORT_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_REPORT_CLOSE.Click,
                                                                                            BTN_INVENTORY_REPORT_MINIMIZE.Click,
                                                                                            BTN_GENERATE_REPORT.Click
        Dim btn As Button = Nothing

        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

        If btn Is BTN_INVENTORY_REPORT_MINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
        ElseIf btn Is BTN_INVENTORY_REPORT_CLOSE Then
            Me.Close()
            Me.Dispose()
        ElseIf btn Is BTN_GENERATE_REPORT Then
            _GEN_REPORT()
        End If
    End Sub

#End Region

    Sub LoadREPORT()
        If REP_TYPE = "INV" Then
            rptDoc = New RPT_INVENTORY_REPORT
        ElseIf REP_TYPE = "PCOUNT" Then
            rptDoc = New RPT_INVENTORY_REPORT
        ElseIf REP_TYPE = "STOCK_LIST" Then
            rptDoc = New RPT_STOCKMASTERLIST
        End If

        SPM4_ITEM_STOCKMASTERLISTTableAdapter.FillByFILTER_SEARCH(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST, CStr(0), "", DIVISION_NO)
        rptDoc.SetDataSource(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST.DataSet)
        With rptDoc
            .SetParameterValue(0, MONTHYEARLabel1.Text)
            .SetParameterValue(1, MONTHYEARLabel1.Text)
            .SetParameterValue(2, MONTHYEARLabel1.Text)
            .SetParameterValue(3, MONTHYEARLabel1.Text)
            .SetParameterValue(4, MONTHYEARLabel1.Text)
        End With

        CRV_PREVIEW.ReportSource = rptDoc
        CRV_PREVIEW.Zoom(130)
    End Sub

#Region "LOAD"
    Private Sub FRM_PRINT_PREVIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPM4_CURRENTDATETIMETableAdapter.Fill(DS_STOREDPROC.SPM4_CURRENTDATETIME)
        LoadREPORT()
    End Sub

    Private Sub CRV_PREVIEW_Load(sender As Object, e As EventArgs) Handles CRV_PREVIEW.Load
        SPM4_CURRENTDATETIMETableAdapter.Fill(DS_STOREDPROC.SPM4_CURRENTDATETIME)
        LoadREPORT()
    End Sub
#End Region

#Region "GENERATE REPORT"
    Sub _GEN_REPORT()
        PrintDialog.Document = PrintDocument
        PrintDialog.PrinterSettings = PrintDocument.PrinterSettings
        If PrintDialog.ShowDialog = DialogResult.OK Then
            Try
                Dim PrinterName As String = PrintDocument.PrinterSettings.PrinterName
                rptDoc.PrintOptions.PrinterName = PrinterName
                rptDoc.PrintToPrinter(1, False, 0, 0)
                Me.Close()
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "_GEN_REPORT")
            End Try
        End If
    End Sub


#End Region

End Class