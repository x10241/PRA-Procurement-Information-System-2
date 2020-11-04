Public Class FRM_PURCHASE_REQUEST_PRINTPREVIEW

    Private Sub CRV_PURCHASEREQUESTPREVIEW_Load(sender As Object, e As EventArgs) Handles CRV_PRINT_PREV.Load
        ''kapag preview
        'If is_preview Then

        '    'after transaction
        'Else
        '    If isSatellite = True Then
        '        'CREATE NEW INSTANCE
        '        rptDoc = New RPT_PURCHASE_REQUEST_SATELLITE
        '    Else
        '        'CREATE NEW INSTANCE
        '        rptDoc = New RPT_PURCHASE_REQUEST
        '    End If
        '    'SET RPTDOC_PURCHASEREQUEST TO PURCHASE_REQUEST_PREVIEW(DATASET)
        '    If isNew Then
        '        PBOX_QRCODE.BackgroundImage = QRCODEGenerator(PRNO_GEN)
        '        Me.SPM4_GETPR_INFOTableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_GETPR_INFO, PRNO_GEN, IMGTOBYTE(PBOX_QRCODE))
        '    Else
        '        PBOX_QRCODE.BackgroundImage = QRCODEGenerator(PRNO)
        '        Me.SPM4_GETPR_INFOTableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_GETPR_INFO, PRNO, IMGTOBYTE(PBOX_QRCODE))
        '    End If

        '    rptDoc.SetDataSource(DS_PROPERTYDB.SPM4_GETPR_INFO.DataSet)
        '    CRV_PRINT_PREV.ReportSource = rptDoc
        'End If


        If isSatellite = True Then
            'CREATE NEW INSTANCE
            rptDoc = New RPT_PURCHASE_REQUEST_PREVIEW_SATELLITE
        Else
            'CREATE NEW INSTANCE
            rptDoc = New RPT_PURCHASE_REQUEST_PREVIEW
        End If

        DS_PROPERTYDB.PR_PARTICULARS_PREVIEW.Rows.Clear() 'clear PURCHASE_REQUEST_PREVIEW DATATABLE
        'If REPRINT = False Then
        '    PRNO_GEN = SPM4_PRCODETableAdapter.SPM4_SQ_PRCODE(DIVISION_NO)

        'Else
        '    BTN_GENERATE_REPORT.Text = ""
        '    BTN_GENERATE_REPORT.Image = Nothing
        '    BTN_GENERATE_REPORT.Enabled = False
        'End If
        PBOX_QRCODE.BackgroundImage = QRCODEGenerator(PRNO_GEN)
        'ADD NEW ROWS
        If dgv.RowCount = 0 Then
            DS_PROPERTYDB.PR_PARTICULARS_PREVIEW.Rows.Add(PR_DATEREQUESTED, 'PR_DATEREQUESTED
                                                    PR_APPCODE, 'PR_APPCODE
                                                    PR_PURPOSE, 'PR_PURPOSE
                                                    PR_REQUESTEDBY, 'PR_REQUESTEDBY
                                                    PR_REQUESTEDBYPOSITION, 'PR_REQUESTEDBYPOSITION
                                                    PR_APPROVEDBY, 'PR_APPROVEDBY
                                                    PR_APPROVEDBYPOSITION, 'PR_APPROVEDBYPOSITION
                                                    PR_CERTIFIEDBY, 'PR_CERTIFIEDBY
                                                    PR_CERTIFIEDBYPOSITION, 'PR_CERTIFIEDBYPOSITION
                                                    PR_NOTEDBY, 'PR_NOTEDBY
                                                    PR_NOTEDBYPOSITION, 'PR_NOTEDBYPOSITION 
                                                    PR_DEPARTMENT, 'PR_DEPARTMENT
                                                    PR_DIVISION, 'PR_DIVISION
                                                    "", 'PRI_ITEM_DESCRIPTION
                                                    "", 'PRI_QTY
                                                    "", 'PRI_UNITOFISSUE
                                                    "", 'PRI_STOCKNO
                                                    0, ' PRI_ESTIMATEDUNITCOST
                                                    0, 'PRI_ESTIMATEDCOST)
                                                    ISDOLLARS, 'IF DOLLARS
                                                    IMGTOBYTE(PBOX_QRCODE), 'QR_CODE
                                                    PRNO_GEN) 'PR NO

        Else
            For Each row As DataGridViewRow In dgv.Rows
                DS_PROPERTYDB.PR_PARTICULARS_PREVIEW.Rows.Add(PR_DATEREQUESTED, 'PR_DATEREQUESTED
                                                                PR_APPCODE, 'PR_APPCODE
                                                                PR_PURPOSE, 'PR_PURPOSE
                                                                PR_REQUESTEDBY, 'PR_REQUESTEDBY
                                                                PR_REQUESTEDBYPOSITION, 'PR_REQUESTEDBYPOSITION
                                                                PR_APPROVEDBY, 'PR_APPROVEDBY
                                                                PR_APPROVEDBYPOSITION, 'PR_APPROVEDBYPOSITION
                                                                PR_CERTIFIEDBY, 'PR_CERTIFIEDBY
                                                                PR_CERTIFIEDBYPOSITION, 'PR_CERTIFIEDBYPOSITION
                                                                PR_NOTEDBY, 'PR_NOTEDBY
                                                                PR_NOTEDBYPOSITION, 'PR_NOTEDBYPOSITION 
                                                                PR_DEPARTMENT, 'PR_DEPARTMENTw
                                                                PR_DIVISION, 'PR_DIVISION
                                                                row.Cells(0).Value, 'PRI_ITEM_DESCRIPTION
                                                                row.Cells(1).Value, 'PRI_QTY
                                                                row.Cells(2).Value, 'PRI_UNITOFISSUE
                                                                row.Cells(3).Value, 'PRI_STOCKNO
                                                                row.Cells(4).Value, ' PRI_ESTIMATEDUNITCOST
                                                                row.Cells(5).Value, 'PRI_ESTIMATEDCOST
                                                                ISDOLLARS, 'if dollars
                                                                IMGTOBYTE(PBOX_QRCODE), 'QR CODE
                                                                PRNO_GEN) 'PR NO
            Next
        End If
        'SET RPTDOC_PURCHASEREQUEST TO PURCHASE_REQUEST_PREVIEW(DATASET)
        rptDoc.SetDataSource(DS_PROPERTYDB.PR_PARTICULARS_PREVIEW.DataSet)
        CRV_PRINT_PREV.ReportSource = rptDoc
    End Sub

    Private Sub BTN_INVENTORY_REPORT_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_REPORT_CLOSE.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BTN_INVENTORY_GENERATE_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_GENERATE_REPORT.Click
        PrintDialog.Document = PrintDocument
        PrintDialog.PrinterSettings = PrintDocument.PrinterSettings
        If PrintDialog.ShowDialog = DialogResult.OK Then
            Try
                Dim PrinterName As String = PrintDocument.PrinterSettings.PrinterName
                rptDoc.PrintOptions.PrinterName = PrinterName
                rptDoc.PrintToPrinter(1, False, 0, 0)
                'If REPRINT = False Then
                '    TblM4_PURCHASEREQUESTTableAdapter.IQ_PURCHASE_REQUEST(PRNO_GEN, Trim(PR_DATEREQUESTED), Trim(PR_APPCODE), Trim(PR_PURPOSE), 4, Trim(PR_REQUESTEDBY), Trim(PR_REQUESTEDBYPOSITION), Trim(PR_APPROVEDBY), Trim(PR_APPROVEDBYPOSITION), Trim(PR_CERTIFIEDBY), Trim(PR_CERTIFIEDBYPOSITION), Trim(PR_NOTEDBY), Trim(PR_NOTEDBYPOSITION), Trim(EMP_NO), Trim(PR_DEPARTMENT), Trim(PR_DIVISION), ISDOLLARS)
                '    For Each row As DataGridViewRow In dgv.Rows
                '        If Not row.IsNewRow Then
                '            TblM4_PURCHASEREQUEST_ITEMTableAdapter.IQ_PR_ITEMS(PRNO_GEN, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(0).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString)
                '        End If
                '    Next
                '    ISSAVE = False
                'Else
                '    If isNew = False Then
                '        TblM4_PURCHASEREQUESTTableAdapter.UQ_PR(Trim(PR_DATEREQUESTED), Trim(PR_APPCODE), Trim(PR_PURPOSE), 4, Trim(PR_REQUESTEDBY), Trim(PR_REQUESTEDBYPOSITION), Trim(PR_APPROVEDBY), Trim(PR_APPROVEDBYPOSITION), Trim(PR_CERTIFIEDBY), Trim(PR_CERTIFIEDBYPOSITION), Trim(PR_NOTEDBY), Trim(PR_NOTEDBYPOSITION), Trim(EMP_NO), Trim(PR_DEPARTMENT), Trim(PR_DIVISION), Trim(EMP_NO), ISDOLLARS, PRNO_GEN)
                '        TblM4_PURCHASEREQUEST_ITEMTableAdapter.DQ_PR_ITEMS(PRNO_GEN)
                '        For Each row As DataGridViewRow In dgv.Rows
                '            If Not row.IsNewRow Then
                '                TblM4_PURCHASEREQUEST_ITEMTableAdapter.IQ_PR_ITEMS(PRNO_GEN, row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(0).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString)
                '            End If
                '        Next
                '    End If
                '    ISSAVE = True
                '    Me.Close()
                'End If
                Me.Close()
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "PURCHASE REQUEST: SAVE AND PRINT: BTN_INVENTORY_GENERATE_REPORT.Click")
            End Try
        End If
    End Sub

End Class