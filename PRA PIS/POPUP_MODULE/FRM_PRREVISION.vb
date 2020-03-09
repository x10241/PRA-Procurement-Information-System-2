Public Class FRM_PRREVISION
    Private Sub FRM_PRREVISION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM' table. You can move, or remove it, as needed.
        Me.TblM4_PURCHASEREQUEST_ITEMTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST_ITEM)

    End Sub
End Class