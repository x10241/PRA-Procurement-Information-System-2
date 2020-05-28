Public Class FRM_PREVIEW

    Public Sub BS_DATA_TRANSFER_STICKERPREVIEW_DATA(ByVal BSMAIN As BindingSource)
        Try
            For i = 0 To BSMAIN.Count - 1
                DS_STOREDPROC.StickerPreview.Rows.Add()
                For col = 0 To 11
                    If col = 11 Then
                        PictureBox1.BackgroundImage = QRCODEGenerator(CType(BSMAIN.List(i), DataRowView).Item(3))
                        DS_STOREDPROC.StickerPreview.Rows(i).Item(col) = IMGTOBYTE(PictureBox1)
                    Else
                        DS_STOREDPROC.StickerPreview.Rows(i).Item(col) = CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(col)), "", CType(BSMAIN.List(i), DataRowView).Item(col)))
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CRV_PREVIEW_Load(sender As Object, e As EventArgs) Handles CRV_PREVIEW.Load
        Me.WindowState = FormWindowState.Maximized
        If printPreview = "ItemsInLocation" Then
            'CREATE NEW INSTANCE
            RPTDOC_PURCHASEREQUEST = New RPT_ITEMS_IN_LOCATION
            SpM4_ITEMS_IN_LOCATIONTableAdapter.Fill(DS_STOREDPROC.SPM4_ITEMS_IN_LOCATION, FRM_LOCATION_LIST.CMB_DEFLOCATION.SelectedValue, FRM_LOCATION_LIST.WTXT_LIST_PREFERRED_ITEMS.Text)
            RPTDOC_PURCHASEREQUEST.SetDataSource(DS_STOREDPROC.SPM4_ITEMS_IN_LOCATION.DataSet)
            CRV_PREVIEW.ReportSource = RPTDOC_PURCHASEREQUEST
        ElseIf printPreview = "StickerTag" Then

            DS_STOREDPROC.StickerPreview.Rows.Clear()
            If stickerType = 1 Then
                rptDoc = New RPT_STICKER_TAG3x2
            ElseIf stickerType = 2 Then
                rptDoc = New RPT_STICKER_TAG4x3
            End If
            SPM4_PRINTSTICKERTableAdapter.Fill(DS_STOREDPROC.SPM4_PRINTSTICKER, QRTEXT)
            BS_DATA_TRANSFER_STICKERPREVIEW_DATA(SPM4_PRINTSTICKERBindingSource)
            rptDoc.SetDataSource(DS_STOREDPROC.StickerPreview.DataSet)
            CRV_PREVIEW.ReportSource = rptDoc

        ElseIf printPreview = "AssignItem" Then
            rptDoc = New RPT_ITEMS_ASSIGN
            SPM4_ASSIGN_ITEMSTableAdapter.Fill(DS_STOREDPROC.SPM4_ASSIGN_ITEMS, FRM_ASSIGN_ITEMS.WTXT_LIST_PREFERRED_ITEMS.Text)
            rptDoc.SetDataSource(DS_STOREDPROC.SPM4_ASSIGN_ITEMS.DataSet)
            With rptDoc
                .SetParameterValue(0, Trim(FRM_ASSIGN_ITEMS.WTXT_LIST_PREFERRED_ITEMS.Text))
            End With
            CRV_PREVIEW.ReportSource = rptDoc
        End If
    End Sub



    Private Sub FRM_PREVIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If printPreview = "" Then

        ElseIf printPreview = "StickerTag" Then
            SPM4_PRINTSTICKERTableAdapter.Fill(DS_STOREDPROC.SPM4_PRINTSTICKER, QRTEXT)
            BS_DATA_TRANSFER_STICKERPREVIEW_DATA(SPM4_PRINTSTICKERBindingSource)
        ElseIf printPreview = "AssignItem" Then
            rptDoc = New RPT_ITEMS_ASSIGN
            SPM4_ASSIGN_ITEMSTableAdapter.Fill(DS_STOREDPROC.SPM4_ASSIGN_ITEMS, FRM_ASSIGN_ITEMS.WTXT_LIST_PREFERRED_ITEMS.Text)
            rptDoc.SetDataSource(DS_STOREDPROC.SPM4_ASSIGN_ITEMS.DataSet)
            With rptDoc
                .SetParameterValue(0, Trim(FRM_ASSIGN_ITEMS.WTXT_LIST_PREFERRED_ITEMS.Text))
            End With
            CRV_PREVIEW.ReportSource = rptDoc
        End If
    End Sub


End Class