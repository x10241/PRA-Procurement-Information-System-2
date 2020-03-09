Public Class FRM_ADDITIONAL_CATEGORIZATION
    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If GRP_SUB_CATEGORY.Visible = True Then
            TblM4_INVENTORY_SUB_CATEGORYTableAdapter.IQ_INVENTORY_SUB_CATEGORY(RandomCode, CB_CATEGORYNAME.SelectedValue, WTXT_SUBCATEGORY_NAME.Text, 1, EMP_NO)
            MsgBox("Successfully Added!", MsgBoxStyle.Information)
            Me.Close()
            Me.Dispose()
        ElseIf GRP_BRANDS.Visible = True Then
            TblM4_INVENTORY_ITEMBRANDTableAdapter.IQ_INVENTORY_ITEMS_BRAND(RandomCode, WTXT_BRANDNAME.Text, EMP_NO, 1)
            MsgBox("Successfully Added!", MsgBoxStyle.Information)
            Me.Close()
            Me.Dispose()
        ElseIf GRP_CATEGORY.Visible = True Then
            TblM4_INVENTORY_CATEGORYTableAdapter.IQ_INVENTORY_CATEGORY(RandomCode, WTXT_CATEGORY_NAME.Text, 1, EMP_NO)
            MsgBox("Successfully Added!", MsgBoxStyle.Information)
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub FRM_ADDITIONAL_CATEGORIZATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TblM4_INVENTORY_CATEGORYTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
    End Sub

    Private Sub DGV_CLOSE_Click(sender As Object, e As EventArgs) Handles DGV_CLOSE.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class