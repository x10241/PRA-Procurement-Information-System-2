Public Class FRM_PURCHASE_REQUEST_PRINTPREVIEW

    Private Sub CRV_PURCHASEREQUESTPREVIEW_Load(sender As Object, e As EventArgs) Handles CRV_PURCHASEREQUESTPREVIEW.Load
        Me.WindowState = FormWindowState.Maximized

        'kapag preview
        If is_preview Then
            If isSatellite = True Then
                'CREATE NEW INSTANCE
                RPTDOC_PURCHASEREQUEST = New RPT_PURCHASE_REQUEST_PREVIEW_SATELLITE
            Else
                'CREATE NEW INSTANCE
                RPTDOC_PURCHASEREQUEST = New RPT_PURCHASE_REQUEST_PREVIEW
            End If

            DS_PROPERTYDB.PR_PARTICULARS_PREVIEW.Rows.Clear() 'clear PURCHASE_REQUEST_PREVIEW DATATABLE

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
                                                        ISDOLLARS)

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
                                                                    ISDOLLARS) 'if dollars
                Next
            End If
            'SET RPTDOC_PURCHASEREQUEST TO PURCHASE_REQUEST_PREVIEW(DATASET)
            RPTDOC_PURCHASEREQUEST.SetDataSource(DS_PROPERTYDB.PR_PARTICULARS_PREVIEW.DataSet)
            CRV_PURCHASEREQUESTPREVIEW.ReportSource = RPTDOC_PURCHASEREQUEST

            'after transaction
        Else
            If isSatellite = True Then
                'CREATE NEW INSTANCE
                RPTDOC_PURCHASEREQUEST = New RPT_PURCHASE_REQUEST_SATELLITE
            Else
                'CREATE NEW INSTANCE
                RPTDOC_PURCHASEREQUEST = New RPT_PURCHASE_REQUEST
            End If
            'SET RPTDOC_PURCHASEREQUEST TO PURCHASE_REQUEST_PREVIEW(DATASET)
            If isNew Then
                PBOX_QRCODE.BackgroundImage = QRCODEGenerator(PRNO_GEN)
                Me.SPM4_GETPR_INFOTableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_GETPR_INFO, PRNO_GEN, IMGTOBYTE(PBOX_QRCODE))
            Else
                PBOX_QRCODE.BackgroundImage = QRCODEGenerator(PRNO)
                Me.SPM4_GETPR_INFOTableAdapter.Fill(Me.DS_PROPERTYDB.SPM4_GETPR_INFO, PRNO, IMGTOBYTE(PBOX_QRCODE))
            End If

            RPTDOC_PURCHASEREQUEST.SetDataSource(DS_PROPERTYDB.SPM4_GETPR_INFO.DataSet)
            CRV_PURCHASEREQUESTPREVIEW.ReportSource = RPTDOC_PURCHASEREQUEST
        End If
    End Sub
End Class