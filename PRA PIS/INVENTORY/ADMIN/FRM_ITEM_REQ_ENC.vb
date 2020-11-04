Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_ITEM_REQ_ENC

    Private Sub FRM_ITEM_REQ_ENC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_VIEWS.VWM4_ITEM_LIST' table. You can move, or remove it, as needed.
        Me.VWM4_ITEM_LISTTableAdapter.FillByITEM_DESC(Me.DS_VIEWS.VWM4_ITEM_LIST, "", DIVISION_NO)

        '   TblM4_INVENTORY_ITEMSTableAdapter.FILLBY_ITEM_DESCRIPTION_LIST(DS_PROPERTYDB.tblM4_INVENTORY_ITEMS, "")
        Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
        Dim suggestions As New AutoCompleteStringCollection()
        If VWM4_ITEM_LISTBindingSource.Count > 0 Then
            For x = 0 To VWM4_ITEM_LISTBindingSource.Count - 1
                suggestions.Add(CStr(If(IsDBNull(CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17)), "", CType(VWM4_ITEM_LISTBindingSource.List(x), DataRowView).Item(17))))
            Next
            WTXT_ITEM_DESCRIPTION.AutoCompleteCustomSource = suggestions
        End If

    End Sub


    Private Sub LLBL_CANCEL_LinkClicked(sender As Object, e As EventArgs) Handles BTN_ADD_ITEM.Click


        Dim btn As Button = Nothing
        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

#Region "Add Item"
        If btn Is BTN_ADD_ITEM Then
            ISVALID = True
            If WTXT_QUANTITY.Text.Length > 0 Then
                ISVALID = True
                RECT_QUANTITY.BorderColor = Color.Gray
            Else
                ISVALID = False
                RECT_QUANTITY.BorderColor = Color.OrangeRed
            End If

            If WTXT_ITEM_DESCRIPTION.Text.Length > 0 Then
                ISVALID = True
                RECT_ITEM_DESCRIPTION.BorderColor = Color.Gray
            Else
                ISVALID = False
                RECT_ITEM_DESCRIPTION.BorderColor = Color.OrangeRed
            End If

            If ISVALID = True Then
                If VWM4_ITEM_LISTTableAdapter.SQ_CHECKIFFULLDESC_EXIST(WTXT_ITEM_DESCRIPTION.Text, DIVISION_NO) > 0 Then
                    FRM_ITEM_REQ.DGV_ITEM_LIST.Rows.Add(VWM4_ITEM_LISTTableAdapter.SQ_ITEM_CODE_ITEM_DESC(WTXT_ITEM_DESCRIPTION.Text, DIVISION_NO), Trim(WTXT_ITEM_DESCRIPTION.Text), Trim(WTXT_QUANTITY.Text), Trim(CB_UNIT_TYPE.Text))
                    WTXT_ITEM_DESCRIPTION.Clear()
                    WTXT_QUANTITY.Clear()
                Else
                    NotificationManager.Show(Me, "Item Not Exist! Please contact Admin Division or ICTD", Color.Red, 3000)
                    WTXT_ITEM_DESCRIPTION.Clear()
                End If
            Else
                NotificationManager.Show(Me, "Please provide required field!", Color.Red, 3000)
            End If
#End Region

        End If
    End Sub

    Private Sub WTXT_QUANTITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_QUANTITY.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BTN_ITEM_REQ_ENC_CANCEL_Click(sender As Object, e As EventArgs) Handles BTN_ITEM_REQ_ENC_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub BTN_ITEM_REQ_ENC_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_ITEM_REQ_ENC_CLOSE.Click
        Me.Close()
    End Sub
End Class