Public Class FRM_INVENTORY_REPORT_PRINT_PREVIEW


    Private Sub CRV_INVENTORY_PREVIEW_Load(sender As Object, e As EventArgs) Handles CRV_INVENTORY_PREVIEW.Load
        LoadReport()
    End Sub

    Sub LoadReport()

        rptDoc = New RPT_INVENTORY_REPORT
        SpM4_INVENTORY_REPORTTableAdapter.Fill(DS_STOREDPROC.SPM4_INVENTORY_REPORT, Trim(IR_CBFILTERBY), Trim(IR_CBDATEBY), Trim(IR_KEYWORD), Trim(IR_DATEFROM), Trim(IR_DATETO))
        rptDoc.SetDataSource(DS_STOREDPROC.SPM4_INVENTORY_REPORT.DataSet)
        With rptDoc
            .SetParameterValue(0, Trim(IR_CBFILTERBY))
            .SetParameterValue(1, Trim(IR_CBDATEBY))
            .SetParameterValue(2, Trim(IR_KEYWORD))
            .SetParameterValue(3, Trim(IR_DATEFROM))
            .SetParameterValue(4, Trim(IR_DATETO))
            .SetParameterValue(5, Trim(IR_REPORTHEADER))
            .SetParameterValue(6, Trim(IR_ASOFDATE))
            .SetParameterValue(7, Trim(IR_ALLITEMS))
        End With
        CRV_INVENTORY_PREVIEW.ReportSource = rptDoc
        CRV_INVENTORY_PREVIEW.Zoom(1)

    End Sub

    Private Sub BTN_INVENTORY_GENERATE_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_GENERATE_REPORT.Click
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
    End Sub

    Private Sub BTN_INVENTORY_REPORT_MINIMIZE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_REPORT_MINIMIZE.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTN_INVENTORY_REPORT_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_REPORT_CLOSE.Click
        Me.Close()
    End Sub
End Class