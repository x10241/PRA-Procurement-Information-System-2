Public Class FRM_LOCATION

    Private Sub BTN_NEW_LOCATION_Click(sender As Object, e As EventArgs) Handles BTN_SELECTION_CLOSE.Click,
                                                                                    BTN_LOC_DONE.Click,
                                                                                    CHK_SHOW_ALL_ITEMS.Click,
                                                                                    BTN_ONE_PLUS.Click,
                                                                                    BTN_ONE_MINUS.Click,
                                                                                    BTN_ALL_PLUS.Click,
                                                                                    BTN_ALL_MINUS.Click,
                                                                                    BTN_ASSIGN_ITEM_LOCATION.Click,
                                                                                    BTN_LOCATION_LIST.Click


        Dim btn As Button = Nothing
        Dim chk As CheckBox = Nothing

        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        ElseIf TypeOf sender Is CheckBox Then
            chk = CType(sender, CheckBox)
        End If

#Region "Assign Item's Location"
        If btn Is BTN_ASSIGN_ITEM_LOCATION Then
            isNew = False
            PNL_LOCATION_MAIN.Enabled = True
            TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter.Fill(DS_PROPERTYDB.tblM4_INVENTORY_ITEMS_DEFLOCATION)
            SpM4_ITEMS_LOCATIONTableAdapter.Fill(DS_STOREDPROC.SPM4_ITEMS_LOCATION, True)
            SpM4_ITEMS_IN_LOCATIONTableAdapter.Fill(DS_STOREDPROC.SPM4_ITEMS_IN_LOCATION, CB_LOC_DEFAULT_LOC.SelectedValue, WTXT_LIST_PREFERRED_ITEMS.Text)
            EnableDisable(False)
#End Region

#Region "Close"
        ElseIf btn Is BTN_SELECTION_CLOSE Then
            Me.Close()
            Me.Dispose()
#End Region

#Region "Done"
        ElseIf btn Is BTN_LOC_DONE Then
            PNL_LOCATION_MAIN.Enabled = False
            EnableDisable(True)
            clearFields()
#End Region

#Region "Add one item to Location"
        ElseIf btn Is BTN_ONE_PLUS Then
            Try
                For Each row In DGV_ITEMS_LIST.SelectedRows
                    Dim newRow As DataRow
                    newRow = DS_STOREDPROC.SPM4_ITEMS_LOCATION.DataSet.Tables(2).NewRow
                    With newRow
                        .Item(1) = row.Cells(0).Value
                        .Item(2) = row.Cells(1).Value
                        .Item(3) = row.Cells(2).Value
                        .Item(4) = row.Cells(3).Value
                        .Item(5) = row.Cells(4).Value
                        .Item(6) = row.Cells(5).Value
                    End With
                    DS_STOREDPROC.SPM4_ITEMS_LOCATION.DataSet.Tables(2).Rows.Add(newRow)

                    TblM4_INVENTORY_ITEMS_LOCATIONTableAdapter.IQ_INVENTORY_ITEMS(row.Cells(0).Value, CB_LOC_DEFAULT_LOC.SelectedValue)
                    DGV_ITEMS_LIST.Rows.Remove(row)
                Next
                NotificationManager.Show(Me, "Successfully added.", Color.Green, 2000)
            Catch ex As Exception
                NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
            End Try
#End Region

#Region "Remove one Item from location"
        ElseIf btn Is BTN_ONE_MINUS Then
            Try
                For Each row In DGV_ITEMS_LOCATION.SelectedRows
                    Dim newRow As DataRow
                    newRow = DS_STOREDPROC.SPM4_ITEMS_LOCATION.DataSet.Tables(1).NewRow
                    With newRow
                        .Item(0) = row.Cells(0).Value
                        .Item(1) = row.Cells(1).Value
                        .Item(2) = row.Cells(2).Value
                        .Item(3) = row.Cells(3).Value
                        .Item(4) = row.Cells(4).Value
                        .Item(5) = row.Cells(5).Value
                    End With
                    DS_STOREDPROC.SPM4_ITEMS_LOCATION.DataSet.Tables(1).Rows.Add(newRow)
                    TblM4_INVENTORY_ITEMS_LOCATIONTableAdapter.DQ_ITEMS_IN_LOCATION(row.Cells(0).Value)
                    DGV_ITEMS_LOCATION.Rows.Remove(row)
                Next
                NotificationManager.Show(Me, "Successfully Removed.", Color.Green, 2000)
            Catch ex As Exception
                NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
            End Try
#End Region

#Region "Add all items to location"
        ElseIf btn Is BTN_ALL_PLUS Then
            DGV_ITEMS_LIST.SelectAll()
            Try
                For Each row In DGV_ITEMS_LIST.SelectedRows
                    Dim newRow As DataRow
                    newRow = DS_STOREDPROC.SPM4_ITEMS_LOCATION.DataSet.Tables(2).NewRow
                    With newRow
                        .Item(1) = row.Cells(0).Value
                        .Item(2) = row.Cells(1).Value
                        .Item(3) = row.Cells(2).Value
                        .Item(4) = row.Cells(3).Value
                        .Item(5) = row.Cells(4).Value
                        .Item(6) = row.Cells(5).Value
                    End With
                    DS_STOREDPROC.SPM4_ITEMS_LOCATION.DataSet.Tables(2).Rows.Add(newRow)
                    TblM4_INVENTORY_ITEMS_LOCATIONTableAdapter.IQ_INVENTORY_ITEMS(row.Cells(0).Value, CB_LOC_DEFAULT_LOC.SelectedValue)
                    DGV_ITEMS_LIST.Rows.Remove(row)
                Next
                NotificationManager.Show(Me, "Successfully added.", Color.Green, 2000)
            Catch ex As Exception
                NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
            End Try
#End Region

#Region "Remove all items from location"
        ElseIf btn Is BTN_ALL_MINUS Then
            Try
                DGV_ITEMS_LOCATION.SelectAll()
                For Each row As DataGridViewRow In DGV_ITEMS_LOCATION.SelectedRows
                    Dim newRow As DataRow
                    newRow = DS_STOREDPROC.SPM4_ITEMS_LOCATION.DataSet.Tables(1).NewRow
                    With newRow
                        .Item(0) = row.Cells(0).Value
                        .Item(1) = row.Cells(1).Value
                        .Item(2) = row.Cells(2).Value
                        .Item(3) = row.Cells(3).Value
                        .Item(4) = row.Cells(4).Value
                        .Item(5) = row.Cells(5).Value
                    End With
                    DS_STOREDPROC.SPM4_ITEMS_LOCATION.DataSet.Tables(1).Rows.Add(newRow)
                    TblM4_INVENTORY_ITEMS_LOCATIONTableAdapter.DQ_ITEMS_IN_LOCATION(row.Cells(0).Value)
                    DGV_ITEMS_LOCATION.Rows.Remove(row)
                Next
                NotificationManager.Show(Me, "Successfully Removed.", Color.Green, 2000)
            Catch ex As Exception
                NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
            End Try
#End Region

#Region "Location List"
        ElseIf btn Is BTN_LOCATION_LIST Then
            FRM_LOCATION_LIST.ShowDialog()
#End Region



        End If
    End Sub

    Sub SavePreferredItems()
        Try
            For Each row As DataGridViewRow In DGV_ITEMS_LOCATION.Rows
                TblM4_INVENTORY_ITEMS_LOCATIONTableAdapter.IQ_INVENTORY_ITEMS(row.Cells(0).Value, CB_LOC_DEFAULT_LOC.SelectedValue)
            Next
            NotificationManager.Show(Me, "Successfully Saved.", Color.Green, 4000)
            PNL_LOCATION_MAIN.Enabled = False
        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub

#Region "Clear"
    Sub clearFields()
        DGV_ITEMS_LIST.SelectAll()
        For Each row In DGV_ITEMS_LIST.SelectedRows
            DGV_ITEMS_LIST.Rows.Remove(row)
        Next

        DGV_ITEMS_LOCATION.SelectAll()
        For Each row In DGV_ITEMS_LOCATION.SelectedRows
            DGV_ITEMS_LOCATION.Rows.Remove(row)
        Next

        WTXT_LIST_PREFERRED_ITEMS.Clear()
        WTXT_LIST_ITEM_SEARCH.Clear()
        CB_LOC_DEFAULT_LOC.SelectedIndex = -1

    End Sub
#End Region

#Region "Enable/Disable"
    Sub EnableDisable(enableBool As Boolean)
        If enableBool Then

            BTN_ASSIGN_ITEM_LOCATION.Enabled = True
            BTN_LOCATION_LIST.Enabled = True
        Else

            BTN_ASSIGN_ITEM_LOCATION.Enabled = False
            BTN_LOCATION_LIST.Enabled = False
        End If

    End Sub

    Private Sub CB_LOC_DEFAULT_LOC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_LOC_DEFAULT_LOC.SelectedIndexChanged
        If CB_LOC_DEFAULT_LOC.SelectedIndex >= 0 Then
            DGV_ITEMS_LOCATION.SelectAll()
            For Each row In DGV_ITEMS_LOCATION.SelectedRows
                DGV_ITEMS_LOCATION.Rows.Remove(row)
            Next
            SpM4_ITEMS_LOCATIONTableAdapter.Fill(DS_STOREDPROC.SPM4_ITEMS_LOCATION, True)
            SpM4_ITEMS_IN_LOCATIONTableAdapter.Fill(DS_STOREDPROC.SPM4_ITEMS_IN_LOCATION, CB_LOC_DEFAULT_LOC.SelectedValue, WTXT_LIST_PREFERRED_ITEMS.Text)
            '
        End If
    End Sub

    Private Sub FRM_LOCATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_INVENTORY_ITEMS_DEFLOCATION' table. You can move, or remove it, as needed.
        ' Me.TblM4_INVENTORY_ITEMS_DEFLOCATIONTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_INVENTORY_ITEMS_DEFLOCATION)

    End Sub

#End Region
End Class