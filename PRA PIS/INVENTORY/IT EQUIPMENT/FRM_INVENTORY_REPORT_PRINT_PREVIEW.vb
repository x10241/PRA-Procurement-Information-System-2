Public Class FRM_INVENTORY_REPORT_PRINT_PREVIEW

    Private Sub CRV_INVENTORY_PREVIEW_Load(sender As Object, e As EventArgs) Handles CRV_INVENTORY_PREVIEW.Load
        If ISITE Then
            LoadITQReport()
            BTN_INVENTORY_GENERATE_REPORT.Text = "PRINT REPORT"
        Else
            If printPreview = 0 Then
                BTN_INVENTORY_GENERATE_REPORT.Enabled = False
            Else
                BTN_INVENTORY_GENERATE_REPORT.Enabled = True
            End If
            LoadADMINReport()

            'If REPRINT Then
            '    REPRINT = False
            '    BTN_INVENTORY_GENERATE_REPORT.Text = "PRINT"
            'Else
            '    REPRINT = True
            '    BTN_INVENTORY_GENERATE_REPORT.Text = "SAVE and PRINT"
            'End If
        End If
    End Sub

    Sub LoadITQReport()
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

    Sub LoadADMINReport()
        Try
            ISVALID = False
            rptDoc = Nothing
            DS_CUSTOM.DT_ITEM_REQUISITION.Clear()
            DS_CUSTOM.DT_REQUISITION.Clear()
            If isNew Then
                REQ_CODE = SPM4_ITEM_REQ_CODETableAdapter.SPM4_ITEM_REQ_CODE(DIVISION_NO)
            End If
            PBX_QRCODE.BackgroundImage = QRCODEGenerator(REQ_CODE)
            DS_CUSTOM.DT_REQUISITION.Rows.Add(R_CB_REQUISITION_TYPE, R_PURPOSE, USER_DIVISION, EMP_NO, R_FOR_THE_PERIOD, R_DATE_NEEDED, R_REQU_NAME, R_REQU_POSI, R_AUTHORIZEDNAME, R_AUTH_POSITION, R_APPR_NAME, R_APPR_POSI, R_ISSU_NAME, R_ISSU_POSI, R_DATE, REQ_CODE, IMGTOBYTE(PBX_QRCODE))
            For Each row As DataGridViewRow In dgv.Rows
                DS_CUSTOM.DT_ITEM_REQUISITION.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value)
            Next

            If FILTERTYPE = "AP" Then
                Dim i As Integer = 8 - DS_CUSTOM.DT_ITEM_REQUISITION.Rows.Count

                For rowcount = 1 To i
                    DS_CUSTOM.DT_ITEM_REQUISITION.Rows.Add("", "", "")
                Next
                rptDoc = New RPT_MARKETING_SLIP
                rptDoc.SetDataSource(DS_CUSTOM.DT_REQUISITION.DataSet)
                rptDoc.SetDataSource(DS_CUSTOM.DT_ITEM_REQUISITION.DataSet)
                '   rptDoc.Subreports("SLIP_DRAWING").SetDataSource(DS_CUSTOM.DT_ITEM_REQUISITION.DataSet)
                CRV_INVENTORY_PREVIEW.ReportSource = rptDoc
            ElseIf FILTERTYPE = "AD" Then
                Dim i As Integer = 10 - DS_CUSTOM.DT_ITEM_REQUISITION.Rows.Count

                For rowcount = 1 To i
                    DS_CUSTOM.DT_ITEM_REQUISITION.Rows.Add("", "", "")
                Next
                rptDoc = New RPT_SLIP_DRAWING
                rptDoc.SetDataSource(DS_CUSTOM.DT_REQUISITION.DataSet)
                rptDoc.Subreports("SLIP_DRAWING").SetDataSource(DS_CUSTOM.DT_ITEM_REQUISITION.DataSet)
                CRV_INVENTORY_PREVIEW.ReportSource = rptDoc
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTN_INVENTORY_GENERATE_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_GENERATE_REPORT.Click
        '   If isNew Then
        PrintDialog.Document = PrintDocument
        PrintDialog.PrinterSettings = PrintDocument.PrinterSettings
        If PrintDialog.ShowDialog = DialogResult.OK Then
            Try
                Dim PrinterName As String = PrintDocument.PrinterSettings.PrinterName
                rptDoc.PrintOptions.PrinterName = PrinterName
                rptDoc.PrintToPrinter(1, False, 0, 0)
                'If ISITE = False Then
                '    LoadADMINReport()
                '    TBLM4_INVENTORY_REQUISITIONTableAdapter.IQ_REQUISITION(Trim(REQ_CODE), Trim(R_CB_REQUISITION_TYPE), Trim(R_PURPOSE), Trim(DIVISION_NO), Trim(EMP_NO), Trim(R_FOR_THE_PERIOD), Trim(R_DATE_NEEDED), Trim(R_REQU_NAME), Trim(R_REQU_POSI), Trim(R_AUTHORIZEDNAME), Trim(R_AUTH_POSITION), Trim(R_APPR_NAME), Trim(R_APPR_POSI), Trim(R_ISSU_NAME), Trim(R_ISSU_POSI))
                '    For Each row As DataGridViewRow In dgv.Rows
                '        TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter.IQ_INV_ITEM_REQU(Trim(row.Cells(0).Value), Trim(REQ_CODE), Trim(CInt(row.Cells(2).Value)), Trim(row.Cells(3).Value))
                '    Next

                '    Me.Close()
                'End If
                Me.Close()
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "SAVE AND PRINT")
            End Try
        End If
        '  Else
        'Try
        '    TBLM4_INVENTORY_REQUISITIONTableAdapter.UQ_REQUISITION(Trim(R_CB_REQUISITION_TYPE), Trim(R_PURPOSE), Trim(DIVISION_NO), Trim(EMP_NO), Trim(R_FOR_THE_PERIOD), Trim(R_DATE_NEEDED), Trim(R_REQU_NAME), Trim(R_REQU_POSI), Trim(R_AUTHORIZEDNAME), Trim(R_AUTH_POSITION), Trim(R_APPR_NAME), Trim(R_APPR_POSI), Trim(R_ISSU_NAME), Trim(R_ISSU_POSI), Trim(REQ_CODE))
        '    TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter.DQ_ITEM_REQU(REQ_CODE)
        '    If TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter.SQ_COUNT_REQ_NO(REQ_CODE) = 0 Then
        '        For Each row As DataGridViewRow In dgv.Rows
        '            TBLM4_INVENTORY_ITEM_REQUISITIONTableAdapter.IQ_INV_ITEM_REQU(Trim(row.Cells(0).Value), Trim(REQ_CODE), Trim(CInt(row.Cells(2).Value)), Trim(row.Cells(3).Value))
        '        Next
        '    End If

        '    If MsgBox("Do you want to print this?", vbYesNo, "Confirmation") = vbYes Then
        '        PrintDialog.Document = PrintDocument
        '        PrintDialog.PrinterSettings = PrintDocument.PrinterSettings
        '        Dim PrinterName As String = PrintDocument.PrinterSettings.PrinterName
        '        rptDoc.PrintOptions.PrinterName = PrinterName
        '        rptDoc.PrintToPrinter(1, False, 0, 0)
        '        ISVALID = True
        '        Me.Close()
        '    End If
        'Catch ex As Exception
        '    ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "SAVE UPDATE AND PRINT")
        'End Try
        ' End If
    End Sub

    Private Sub BTN_INVENTORY_REPORT_MINIMIZE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_REPORT_MINIMIZE.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTN_INVENTORY_REPORT_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_REPORT_CLOSE.Click
        Me.Close()
    End Sub
End Class