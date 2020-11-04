Partial Class DS_PROPERTYDB
    Partial Public Class TBLM4_INV_ITEMS_NAME_MAINDataTable
        Private Sub TBLM4_INV_ITEMS_NAME_MAINDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ITM_NAMEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class tblM4_INVENTORY_CATEGORYDataTable
        Private Sub tblM4_INVENTORY_CATEGORYDataTable_tblM4_INVENTORY_CATEGORYRowChanging(sender As Object, e As tblM4_INVENTORY_CATEGORYRowChangeEvent) Handles Me.tblM4_INVENTORY_CATEGORYRowChanging

        End Sub

    End Class

    Partial Public Class TBLG3_PRIMARY_SIGNATORYDataTable
        Private Sub TBLG3_PRIMARY_SIGNATORYDataTable_TBLG3_PRIMARY_SIGNATORYRowChanging(sender As Object, e As TBLG3_PRIMARY_SIGNATORYRowChangeEvent) Handles Me.TBLG3_PRIMARY_SIGNATORYRowChanging

        End Sub

    End Class
End Class

Namespace DS_PROPERTYDBTableAdapters
    Partial Public Class tblM4_INVENTORY_SUB_CATEGORYTableAdapter
    End Class

    Partial Public Class TBLM4_INVENTORY_ITEM_REQUISITION1TableAdapter
    End Class

    Partial Public Class tblM4_INVENTORY_ITEMS_PROPERTYTableAdapter
    End Class
End Namespace