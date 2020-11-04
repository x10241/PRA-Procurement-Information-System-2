Public Class FRM_ADDITIONAL_CATEGORIZATION
    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Dim ID As String = Nothing
        'SUBCATEGORY
        If GRP_SUB_CATEGORY.Visible = True Then
            ID = SpM4_ITEM_SUB_CATEGORY_CODE_GENERATORTableAdapter.SPM4_ITEM_SUB_CATEGORY_CODE_GENERATOR
            TblM4_INVENTORY_SUB_CATEGORYTableAdapter.IQ_INVENTORY_SUB_CATEGORY(Trim(CStr(CB_GRP_SUB_CAT_NAME.SelectedValue)), Trim(WTXT_GRP_SUB_SUBCAT_NAME.Text), 1, EMP_NO, ID)
            INV_DEF_SUB_CAT = Trim(WTXT_GRP_SUB_SUBCAT_NAME.Text)
            'BRAND
        ElseIf GRP_BRAND.Visible = True Then
            ID = SpM4_ITEM_BRAND_CODE_GENERATORTableAdapter.SPM4_ITEM_BRAND_CODE_GENERATOR
            TblM4_INVENTORY_ITEMBRANDTableAdapter.IQ_INVENTORY_ITEMS_BRAND(Trim(WTXT_GRP_BRAND_BRANDNAME.Text), EMP_NO, 1, CODEHOLDER, ID)
            INV_DEF_BRAND = Trim(WTXT_GRP_BRAND_BRANDNAME.Text)
            'CATEGORY
        ElseIf GRP_CATEGORY.Visible = True Then
            ID = SpM4_ITEM_CATEGORY_CODE_GENERATORTableAdapter.SPM4_ITEM_CATEGORY_CODE_GENERATOR
            TblM4_INVENTORY_CATEGORYTableAdapter.IQ_INVENTORY_CATEGORY(Trim(WTXT_GRP_CAT_NAME.Text), 1, EMP_NO, CODEHOLDER, ID, DIVISION_NO)
            INV_DEF_CAT = Trim(WTXT_GRP_CAT_NAME.Text)
            'OTHER'S DESC
        ElseIf GRP_OTHER_DESC.Visible = True Then
            ID = SPM4_ITEM_OTHERS_CODE_GENERATORTableAdapter.SPM4_ITEM_OTHERS_CODE_GENERATOR
            TBLM4_INV_ITEMS_OTHERS_MAINTableAdapter.IQ_INV_ITEMS_OTHERS_MAIN(Trim(WTXT_GRP_OTHER_DESC.Text), 1, ID)
            INV_DEF_OTHER = Trim(WTXT_GRP_OTHER_DESC.Text)
            'LENGTH
        ElseIf GRP_LENGTH.Visible = True Then
            ID = SPM4_ITEM_LENG_CODE_GENERATORTableAdapter.SPM4_ITEM_LENG_CODE_GENERATOR
            TBLM4_INV_ITEMS_LENG_MAINTableAdapter.IQ_INV_ITEMS_LENG_MAIN(Trim(WTXT_GRP_LENGTH.Text), 1, ID)
            INV_DEF_LENG = Trim(WTXT_GRP_LENGTH.Text)
            'COLOR
        ElseIf GRP_COLOR.Visible = True Then
            ID = SPM4_ITEM_COLOR_CODE_GENERATORTableAdapter.SPM4_ITEM_COLOR_CODE_GENERATOR
            TBLM4_INV_ITEMS_COLOR_MAINTableAdapter.IQ_INV_ITEMS_COLOR(Trim(WTXT_GRP_COLOR.Text), ID)
            INV_DEF_COLOR = Trim(WTXT_GRP_COLOR.Text)
            'NAME
        ElseIf GRP_ITEM_NAME.Visible = True Then
            ID = SPM4_ITEM_NAME_CODE_GENERATORTableAdapter.SPM4_ITEM_NAME_CODE_GENERATOR
            TBLM4_INV_ITEMS_NAME_MAINTableAdapter.IQ_INV_ITEMS_NAME_MAIN(ID, CB_INV_SC.SelectedValue, Trim(WTXT_ITEM_NAME.Text))
            INV_DEF_NAME = Trim(WTXT_ITEM_NAME.Text)
            'SIZE
        ElseIf GRP_SIZE.Visible = True Then
            ID = SPM4_ITEM_SIZE_CODE_GENERATORTableAdapter.SPM4_ITEM_SIZE_CODE_GENERATOR
            TBLM4_INV_ITEMS_SIZE_MAINTableAdapter.IQ_INV_ITEMS_SIZE_MAIN(Trim(WTXT_GRP_SIZE.Text), ID)
            INV_DEF_SIZE = Trim(WTXT_GRP_SIZE.Text)
        End If
        MsgBox("Successfully Added!", MsgBoxStyle.Information)
        Close()
        Dispose()
    End Sub

    Private Sub CB_SUB_CATEGORY_SUPPLY_TYPE_TextChanged(sender As Object, e As EventArgs) Handles CB_SUB_CATEGORY_SUPPLY_TYPE.TextChanged
        If CB_BRAND_SUPPLY_TYPE.Text.Length > 0 Then
            TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, CB_BRAND_SUPPLY_TYPE.SelectedValue, DIVISION_NO)
        End If
    End Sub

    Private Sub BTN_CATEGORIZATION_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CATEGORIZATION_CLOSE.Click
        Close()
        Dispose()
    End Sub

    Private Sub FRM_ADDITIONAL_CATEGORIZATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_INVENTORY_ITEMS' table. You can move, or remove it, as needed.
        Me.TblM4_INVENTORY_ITEMSTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMS)
        Me.TBLM4_INV_ITEMS_SIZE_MAINTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_SIZE_MAIN)
        TblM4_INVENTORY_CATEGORYTableAdapter.FillByINV_CODE(DS_PROPERTYDB.tblM4_INVENTORY_CATEGORY, CODEHOLDER, DIVISION_NO)
        If CB_INV_CAT.Items.Count > 0 Then
            Try
                Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INV_CAT.SelectedValue), 0, CB_INV_CAT.SelectedValue)))
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "ITEM_CATEGORIZATION: CATEGORY SELECTED INDEX CHANGED")
            End Try
        End If
    End Sub

    Private Sub CB_INV_CAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_INV_CAT.SelectedIndexChanged
        If CB_INV_CAT.Items.Count > 0 Then
            Try
                Me.TblM4_INVENTORY_SUB_CATEGORYTableAdapter.FillByCAT_CODE(Me.DS_PROPERTYDB.tblM4_INVENTORY_SUB_CATEGORY, CInt(If(IsDBNull(CB_INV_CAT.SelectedValue), 0, CB_INV_CAT.SelectedValue)))
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "ITEM_CATEGORIZATION: CATEGORY SELECTED INDEX CHANGED")
            End Try
        End If
    End Sub
End Class