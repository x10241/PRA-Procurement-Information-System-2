Public Class FRM_ADDITIONAL_CATEGORIZATION
    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If ITEQUIPMENTBOOL Then
            If GRP_SUB_CATEGORY_ADMIN.Visible = True Then
                TblM4_INVENTORY_SUB_CATEGORYTableAdapter.IQ_INVENTORY_SUB_CATEGORY(RandomCode, CB_SUB_CATEGORY_CATEGORYNAME.SelectedValue, WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.Text, 1, EMP_NO)
            ElseIf GRP_BRANDS.Visible = True Then
                TblM4_INVENTORY_ITEMBRANDTableAdapter.IQ_INVENTORY_ITEMS_BRAND(RandomCode, WTXT_BRANDNAME.Text, EMP_NO, 1, "")
            ElseIf GRP_CATEGORY.Visible = True Then
                TblM4_INVENTORY_CATEGORYTableAdapter.IQ_INVENTORY_CATEGORY(RandomCode, WTXT_CATEGORY_NAME.Text, 1, EMP_NO, "")
            End If
        Else
            If GRP_SUB_CATEGORY_ADMIN.Visible = True Then
                TblM4_INVENTORY_SUB_CATEGORYTableAdapter.IQ_INVENTORY_SUB_CATEGORY(RandomCode, CB_SUB_CATEGORY_CATEGORYNAME.SelectedValue, WTXT_SUB_CATEGORY_SUBCATEGORY_NAME.Text, 1, EMP_NO)
            ElseIf GRP_BRAND_ADMIN.Visible = True Then
                TblM4_INVENTORY_ITEMBRANDTableAdapter.IQ_INVENTORY_ITEMS_BRAND(RandomCode, WTXT_BRAND_ADMIN_BRAND_NAME.Text, EMP_NO, 1, CB_BRAND_SUPPLY_TYPE.SelectedValue)
            ElseIf GRP_CATEGORY_ADMIN.Visible = True Then
                TblM4_INVENTORY_CATEGORYTableAdapter.IQ_INVENTORY_CATEGORY(RandomCode, WTXT_CATEGORY_CATEGORY_NAME_ADMIN.Text, 1, EMP_NO, CB_CATEGORY_SUPPLY_TYPE.SelectedValue)
            End If
        End If
        MsgBox("Successfully Added!", MsgBoxStyle.Information)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FRM_ADDITIONAL_CATEGORIZATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ITEQUIPMENTBOOL Then
            TblM4_INVENTORY_CATEGORYTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY)
        Else
            TblM4_INVENTORY_TYPETableAdapter.FillBY_NOT_ITQUIPMENT(DS_PROPERTYDB.tblM4_INVENTORY_TYPE)
            TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, CB_BRAND_SUPPLY_TYPE.SelectedValue)

        End If
    End Sub

    Private Sub DGV_CLOSE_Click(sender As Object, e As EventArgs) Handles DGV_CLOSE.Click
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub CB_SUB_CATEGORY_SUPPLY_TYPE_TextChanged(sender As Object, e As EventArgs) Handles CB_SUB_CATEGORY_SUPPLY_TYPE.TextChanged
        If CB_BRAND_SUPPLY_TYPE.Text.Length > 0 Then
            TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, CB_BRAND_SUPPLY_TYPE.SelectedValue)
        End If
    End Sub
End Class