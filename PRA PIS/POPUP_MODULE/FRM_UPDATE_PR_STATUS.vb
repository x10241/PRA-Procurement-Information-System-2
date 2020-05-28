Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_UPDATE_PR_STATUS


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
                                                                                BTN_PSR_SAVE.Click



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

        If btn Is BTN_PRS_POSTED Or btn Is BTN_PRS_FOR_EVALUATION Or btn Is BTN_PRS_FOR_BAC_AGENDA Or btn Is BTN_PRS_BAC_RESOLUTION_ISSUED Or btn Is BTN_PRS_AWARDED Or btn Is BTN_PRS_PO_CONTRACT_ISSUED Or btn Is BTN_PRS_PROOFING Then
            btnPropertyChanged(btn)
        ElseIf btn Is BTN_ADDBIDDER Then
            FRM_DGV_ENCODING.BTN_SAVE.Text = "SAVE"
            FRM_DGV_ENCODING.PNL_SELECT_PARTICULARS.BringToFront()
            FRM_DGV_ENCODING.ShowDialog()
        ElseIf btn Is BTN_PRS_CLOSE Then
            Me.Close()
            Me.Dispose()
        ElseIf btn Is BTN_PSR_SAVE Then
            savePRSTATUS()
        End If
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

    Private Sub FRM_UPDATE_PR_STATUS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TblM4_PURCHASEREQUEST_POSTEDTableAdapter.FillByPR_NO(DS_PROPERTYDB.tblM4_PURCHASEREQUEST_POSTED, PRNO)
        'WTXT_POSTED_REMARKS.Text = BS(TblM4_PURCHASEREQUEST_POSTEDBindingSource, 0, 1)
        'WTXT_POSTED_URLADDRESS.Text = BS(TblM4_PURCHASEREQUEST_POSTEDBindingSource, 0, 2)
    End Sub
End Class