Public Class FRM_LOCATION_LIST
    Private Sub BTN_SELECTION_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_SELECTION_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub FRM_LOCATION_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_INVENTORY_ITEMS_DEFLOCATION' table. You can move, or remove it, as needed.
        Me.TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMS_DEFLOCATION)
        SPM4_ITEMS_IN_LOCATIONTableAdapter.Fill(DS_STOREDPROC.SPM4_ITEMS_IN_LOCATION, CMB_DEFLOCATION.SelectedValue, WTXT_LIST_PREFERRED_ITEMS.Text)
    End Sub

    Private Sub CMB_DEFLOCATION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_DEFLOCATION.SelectedIndexChanged
        SPM4_ITEMS_IN_LOCATIONTableAdapter.Fill(DS_STOREDPROC.SPM4_ITEMS_IN_LOCATION, CMB_DEFLOCATION.SelectedValue, WTXT_LIST_PREFERRED_ITEMS.Text)
    End Sub

    Private Sub BTN_LOCATION_LIST_Click(sender As Object, e As EventArgs) Handles BTN_LOCATION_LIST.Click
        '  isPreviewClick = True
        printPreview = "ItemsInLocation"
        FRM_PREVIEW.ShowDialog()
    End Sub

    Private Sub WTXT_LIST_PREFERRED_ITEMS_TextChanged(sender As Object, e As EventArgs) Handles WTXT_LIST_PREFERRED_ITEMS.TextChanged
        SPM4_ITEMS_IN_LOCATIONTableAdapter.Fill(DS_STOREDPROC.SPM4_ITEMS_IN_LOCATION, CMB_DEFLOCATION.SelectedValue, WTXT_LIST_PREFERRED_ITEMS.Text)
    End Sub
End Class