Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_UPDATE_PR_STATUS

    Dim TOTALLABEL As Decimal = 0.00
#Region "CLICK"
    Private Sub BTN_PRS_POSTED_Click(sender As Object, e As EventArgs) Handles BTN_PRS_POSTED.Click,
                                                                                BTN_PRS_FOR_EVALUATION.Click,
                                                                                BTN_PRS_FOR_BAC_AGENDA.Click,
                                                                                BTN_PRS_BAC_RESOLUTION_ISSUED.Click,
                                                                                BTN_PRS_AWARDED.Click,
                                                                                BTN_PRS_PO_CONTRACT_ISSUED.Click,
                                                                                BTN_PRS_PROOFING.Click,
                                                                                BTN_PRS_CANCELED_PO.Click,
                                                                                BTN_ADDBIDDER.Click,
                                                                                BTN_PRS_CLOSE.Click,
                                                                                BTN_PSR_SAVE.Click,
                                                                                WTXT_REQUESTED_DATE.Click,
                                                                                BTN_PNL_PART_CANCEL.Click,
                                                                                BTN_PNL_PART_ADD.Click,
                                                                                BTN_PREVIEW_AOQ.Click



        Dim pb As PictureBox = Nothing
        Dim lbl As Label = Nothing
        Dim btn As Button = Nothing
        llbl = Nothing
        rect = Nothing
        TXTGLOBAL = Nothing

        If TypeOf sender Is LinkLabel Then
            llbl = CType(sender, LinkLabel)
        ElseIf TypeOf sender Is RectangleShape Then
            rect = CType(sender, RectangleShape)
        ElseIf TypeOf sender Is PictureBox Then
            pb = CType(sender, PictureBox)
        ElseIf TypeOf sender Is Button Then
            btn = CType(sender, Button)
            passBtn = btn
        ElseIf TypeOf sender Is Label Then
            lbl = CType(sender, Label)
        ElseIf TypeOf sender Is TextBox Then
            TXTGLOBAL = CType(sender, TextBox)
        End If

#Region "SIDE NAV"
        If btn Is BTN_PRS_POSTED Or btn Is BTN_PRS_FOR_EVALUATION Or btn Is BTN_PRS_FOR_BAC_AGENDA Or btn Is BTN_PRS_BAC_RESOLUTION_ISSUED Or btn Is BTN_PRS_AWARDED Or btn Is BTN_PRS_PO_CONTRACT_ISSUED Or btn Is BTN_PRS_PROOFING Then
            btnPropertyChanged(btn)
#End Region

#Region "ADD BIDDER"
        ElseIf btn Is BTN_ADDBIDDER Then
            _CLEAR_ENC_PART()
            Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter.FillByPRNO(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM, PRNO)
            PNL_PARTICULARS.Visible = True
            '    FRM_DGV_ENCODING.BTN_SAVE.Text = "SAVE"
            '  FRM_DGV_ENCODING.PNL_SELECT_PARTICULARS.BringToFront()
            '  FRM_DGV_ENCODING.ShowDialog()

            Dim sugg = DS_CUSTOM.DT_PART_LIST.AsEnumerable().[Select](Function(x) New With {
                Key .PART = x.Field(Of String)("PART"),
                Key .QTY = x.Field(Of String)("QTY"),
                Key .UNIT = x.Field(Of String)("UNIT"),
                Key .UNIT_COST = x.Field(Of String)("UNIT_COST"),
                Key .TOTAL_COST = x.Field(Of String)("TOTAL_COST"),
                Key .BID_NO = x.Field(Of Int16)("BID_NO"),
                Key .PART_LIST_NO = x.Field(Of Int32)("PART_LIST_NO")
           }).GroupBy(Function(s) s.BID_NO)


#End Region

#Region "CANCEL PNL ADD"
        ElseIf btn Is BTN_PNL_PART_CANCEL Then
            PNL_PARTICULARS.Visible = False
#End Region

#Region "BTN PNL ADD"
        ElseIf btn Is BTN_PNL_PART_ADD Then
            DS_CUSTOM.DT_BID_LIST.Rows.Add(WTXT_TIN_NO.Text, WTXT_PRO_COMPSUPPLIERNAME.Text, WTXT_PRO_CONTACT_NO.Text, WTXT_PRO_FAX.Text, WTXT_PRO_EMAIL.Text)
            'GET LATEST ID
            Dim BID_NO As Integer = 0
            For Each row As DataGridViewRow In DGV_BID_LIST.Rows
                If row.Cells(0).Value > BID_NO Then BID_NO = row.Cells(0).Value
            Next
            'INSERT ALL VALUES FROM PARTICULARS TO
            Dim totalcost As Decimal = 0.00
            Dim unitcost As Decimal = 0.00
            TOTALLABEL = 0.00
            For Each rows As DataGridViewRow In DGV_ENC_PART_LIST.Rows
                totalcost = rows.Cells(9).Value
                TOTALLABEL = TOTALLABEL + rows.Cells(9).Value
                unitcost = rows.Cells(8).Value
                DS_CUSTOM.DT_PART_LIST.Rows.Add(rows.Cells(0).Value, rows.Cells(1).Value, rows.Cells(2).Value, unitcost.ToString("N2"), totalcost.ToString("N2"), BID_NO)
            Next
            LLBL_TOTAL.Text = TOTALLABEL.ToString("N2")
            PNL_PARTICULARS.Visible = False
            ' DS_CUSTOM.DT_PART_LIST.Compute("MIN(TOTAL_COST)", DTPARTLISTBindingSource.Filter)
            DTPARTLISTBindingSource.Filter = "BID_NO = " & BID_NO

            'DS_CUSTOM.DT_PART_LIST.Compute("MAX(TOTAL_COST)", DTPARTLISTBS_MAX.Filter)
            '   DTPARTLISTBS_MAX.Filter = "TOTAL_COST"
            'LBL_SUGGESTION
#End Region

#Region "PREVIEW"
        ElseIf btn Is BTN_PREVIEW_AOQ Then
            '   For Each row As DataGridViewRow In DGV_BID_LIST.Rows
            ''if check
            'If row.Cells(6).Value = True Then
            '    MsgBox(row.Cells(6).Value)
            'End If
            dgv = DGV_BID_LIST
            dgv2 = DGV_PART_LIST
            FRM_FMD_PRINT_PREVIEW.ShowDialog()
            '  Next

#End Region

#Region "CLOSE"
        ElseIf btn Is BTN_PRS_CLOSE Then
            Me.Close()
            Me.Dispose()
#End Region

#Region "SAVE TRANS"
        ElseIf btn Is BTN_PSR_SAVE Then
            savePRSTATUS()
#End Region

#Region "DATE"
        ElseIf TXTGLOBAL Is WTXT_REQUESTED_DATE Then
            TXTDATE = CType(sender, TextBox)
            FRM_DATAENTRY.ShowDialog()
#End Region

        End If
    End Sub

#End Region

#Region "SUB"
    Sub btnPropertyChanged(sender As Button)
        'posted
        If sender Is BTN_PRS_POSTED Then
            'color
            BTN_PRS_POSTED.BackColor = Color.LightSeaGreen
            BTN_PRS_FOR_EVALUATION.BackColor = Color.White
            BTN_PRS_FOR_BAC_AGENDA.BackColor = Color.White
            BTN_PRS_BAC_RESOLUTION_ISSUED.BackColor = Color.White
            BTN_PRS_AWARDED.BackColor = Color.White
            BTN_PRS_PO_CONTRACT_ISSUED.BackColor = Color.White
            BTN_PRS_PROOFING.BackColor = Color.White
            BTN_PRS_CANCELED_PO.BackColor = Color.White

            'visible
            PNL_POSTED.Visible = True
            PNL_FOR_EVALUATION.Visible = False

            'evaluation
        ElseIf sender Is BTN_PRS_FOR_EVALUATION Then
            BTN_PRS_POSTED.BackColor = Color.White
            BTN_PRS_FOR_EVALUATION.BackColor = Color.LightSeaGreen
            BTN_PRS_FOR_BAC_AGENDA.BackColor = Color.White
            BTN_PRS_BAC_RESOLUTION_ISSUED.BackColor = Color.White
            BTN_PRS_AWARDED.BackColor = Color.White
            BTN_PRS_PO_CONTRACT_ISSUED.BackColor = Color.White
            BTN_PRS_PROOFING.BackColor = Color.White
            BTN_PRS_CANCELED_PO.BackColor = Color.White

            'visible
            PNL_POSTED.Visible = False
            PNL_FOR_EVALUATION.Visible = True
            TblM4_PURCHASEREQUEST_ITEMTableAdapter.FillByPRNO(DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM, PRNO)
            'bac agenda
        ElseIf sender Is BTN_PRS_FOR_BAC_AGENDA Then
            BTN_PRS_POSTED.BackColor = Color.White
            BTN_PRS_FOR_EVALUATION.BackColor = Color.White
            BTN_PRS_FOR_BAC_AGENDA.BackColor = Color.LightSeaGreen
            BTN_PRS_BAC_RESOLUTION_ISSUED.BackColor = Color.White
            BTN_PRS_AWARDED.BackColor = Color.White
            BTN_PRS_PO_CONTRACT_ISSUED.BackColor = Color.White
            BTN_PRS_PROOFING.BackColor = Color.White
            BTN_PRS_CANCELED_PO.BackColor = Color.White
            'bac reso
        ElseIf sender Is BTN_PRS_BAC_RESOLUTION_ISSUED Then
            BTN_PRS_POSTED.BackColor = Color.White
            BTN_PRS_FOR_EVALUATION.BackColor = Color.White
            BTN_PRS_FOR_BAC_AGENDA.BackColor = Color.White
            BTN_PRS_BAC_RESOLUTION_ISSUED.BackColor = Color.LightSeaGreen
            BTN_PRS_AWARDED.BackColor = Color.White
            BTN_PRS_PO_CONTRACT_ISSUED.BackColor = Color.White
            BTN_PRS_PROOFING.BackColor = Color.White
            BTN_PRS_CANCELED_PO.BackColor = Color.White
            'awarded
        ElseIf sender Is BTN_PRS_AWARDED Then
            BTN_PRS_POSTED.BackColor = Color.White
            BTN_PRS_FOR_EVALUATION.BackColor = Color.White
            BTN_PRS_FOR_BAC_AGENDA.BackColor = Color.White
            BTN_PRS_BAC_RESOLUTION_ISSUED.BackColor = Color.White
            BTN_PRS_AWARDED.BackColor = Color.LightSeaGreen
            BTN_PRS_PO_CONTRACT_ISSUED.BackColor = Color.White
            BTN_PRS_PROOFING.BackColor = Color.White
            BTN_PRS_CANCELED_PO.BackColor = Color.White
            'PO/contract issued
        ElseIf sender Is BTN_PRS_PO_CONTRACT_ISSUED Then
            BTN_PRS_POSTED.BackColor = Color.White
            BTN_PRS_FOR_EVALUATION.BackColor = Color.White
            BTN_PRS_FOR_BAC_AGENDA.BackColor = Color.White
            BTN_PRS_BAC_RESOLUTION_ISSUED.BackColor = Color.White
            BTN_PRS_AWARDED.BackColor = Color.White
            BTN_PRS_PO_CONTRACT_ISSUED.BackColor = Color.LightSeaGreen
            BTN_PRS_PROOFING.BackColor = Color.White
            BTN_PRS_CANCELED_PO.BackColor = Color.White
            'Proofing
        ElseIf sender Is BTN_PRS_PROOFING Then
            BTN_PRS_POSTED.BackColor = Color.White
            BTN_PRS_FOR_EVALUATION.BackColor = Color.White
            BTN_PRS_FOR_BAC_AGENDA.BackColor = Color.White
            BTN_PRS_BAC_RESOLUTION_ISSUED.BackColor = Color.White
            BTN_PRS_AWARDED.BackColor = Color.White
            BTN_PRS_PO_CONTRACT_ISSUED.BackColor = Color.White
            BTN_PRS_PROOFING.BackColor = Color.LightSeaGreen
            BTN_PRS_CANCELED_PO.BackColor = Color.White
            'Canceled PO
        ElseIf sender Is BTN_PRS_CANCELED_PO Then
            BTN_PRS_POSTED.BackColor = Color.White
            BTN_PRS_FOR_EVALUATION.BackColor = Color.White
            BTN_PRS_FOR_BAC_AGENDA.BackColor = Color.White
            BTN_PRS_BAC_RESOLUTION_ISSUED.BackColor = Color.White
            BTN_PRS_AWARDED.BackColor = Color.White
            BTN_PRS_PO_CONTRACT_ISSUED.BackColor = Color.White
            BTN_PRS_PROOFING.BackColor = Color.White
            BTN_PRS_CANCELED_PO.BackColor = Color.LightSeaGreen
        End If
    End Sub

    Sub _CLEAR_ENC_PART()
        WTXT_TIN_NO.Clear()
        WTXT_PRO_COMPSUPPLIERNAME.Clear()
        WTXT_PRO_CONTACT_NO.Clear()
        WTXT_PRO_FAX.Clear()
        WTXT_PRO_EMAIL.Clear()
    End Sub
    Sub savePRSTATUS()
        If PNL_POSTED.Visible = True Then
            TblM4_PURCHASEREQUEST_POSTEDTableAdapter.IQ_POSTED(PRNO, WTXT_POSTED_REMARKS.Text, WTXT_POSTED_URLADDRESS.Text)
            ClearPosted()
            NotificationManager.Show(Me, "PR No. " + PRNO + " has been set as Posted.", Color.Green, 5000)
        ElseIf PNL_FOR_EVALUATION.Visible = True Then

            NotificationManager.Show(Me, "PR No. " + PRNO + " has been set as For Evaluation.", Color.Green, 5000)
        End If
    End Sub

    Sub ClearPosted()
        WTXT_POSTED_REMARKS.Clear()
        WTXT_POSTED_URLADDRESS.Clear()
    End Sub
#End Region


#Region "LOAD"
    Private Sub FRM_UPDATE_PR_STATUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TBLM4_PURCHASEREQUEST_SUP_CATTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_PURCHASEREQUEST_SUP_CAT)
    End Sub
#End Region

#Region "CELL EVENT"

    'BID LIST
    Private Sub DGV_BID_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BID_LIST.CellClick
        If e.RowIndex >= 0 Then
            DTPARTLISTBindingSource.Filter = "BID_NO = " & DGV_BID_LIST(0, e.RowIndex).Value
            TOTALLABEL = 0.00
            For Each rows As DataGridViewRow In DGV_PART_LIST.Rows
                '   Dim tcost As String =
                TOTALLABEL = TOTALLABEL + RemoveCharacter(rows.Cells(4).Value, ",")
            Next
            LLBL_TOTAL.Text = TOTALLABEL.ToString("N2")
            ' DS_CUSTOM.DT_PART_LIST.Compute("MIN(TOTAL_COST)", DTPARTLISTBindingSource.Filter)

            '  MsgBox(DGV_BID_LIST.Rows(e.RowIndex).Cells(6).Value)
            If e.ColumnIndex = 6 Then
                Dim cell As DataGridViewCheckBoxCell = DGV_BID_LIST.Rows(e.RowIndex).Cells(6)
                If cell.Value Then
                    cell.Value = False
                Else
                    cell.Value = True
                End If
            End If

            If e.ColumnIndex = 8 Then
                If MsgBox("Are you sure you want to remove this?" & vbCrLf & "You can't undo this action.", vbYesNo) = vbYes Then
                    DGV_BID_LIST.Rows.RemoveAt(DGV_BID_LIST.CurrentRow.Index)
                End If
            End If

        End If
    End Sub

    'PARTICULAR LIST
    Private Sub DGV_PART_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PART_LIST.CellClick
        If e.RowIndex >= 0 Then
            '  DGV_ENC_PART_LIST(8, e.RowIndex).Value 
            DS_CUSTOM.DT_PART_LIST.Compute("MIN(TOTAL_COST)", DTPARTLISTBS_MAX.Filter)
        End If

        'REMOVE
        If e.ColumnIndex = 8 Then
            If MsgBox("Are you sure you want to remove this?" & vbCrLf & "You can't undo this action.", vbYesNo) = vbYes Then
                DGV_PART_LIST.Rows.RemoveAt(DGV_PART_LIST.CurrentRow.Index)
            End If
            'EDIT
        ElseIf e.ColumnIndex = 7 Then
            WTXT_TIN_NO.Text = DGV_PART_LIST(1, e.RowIndex).Value
            WTXT_PRO_COMPSUPPLIERNAME.Text = DGV_PART_LIST(2, e.RowIndex).Value
            WTXT_PRO_CONTACT_NO.Text = DGV_PART_LIST(3, e.RowIndex).Value
            WTXT_PRO_FAX.Text = DGV_PART_LIST(4, e.RowIndex).Value
            WTXT_PRO_EMAIL.Text = DGV_PART_LIST(5, e.RowIndex).Value

            For Each row As DataGridViewRow In DGV_PART_LIST.Rows

            Next
        End If
    End Sub

    'ENCODING PARTICULAR LIST
    Private Sub DGV_ENC_PART_LIST_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ENC_PART_LIST.CellValueChanged
        If e.RowIndex >= 0 Then
            If String.IsNullOrEmpty(DGV_ENC_PART_LIST(8, e.RowIndex).Value) = False Then
                DGV_ENC_PART_LIST(9, e.RowIndex).Value = DGV_ENC_PART_LIST(8, e.RowIndex).Value * DGV_ENC_PART_LIST(1, e.RowIndex).Value
            End If
        End If
    End Sub


#End Region

End Class