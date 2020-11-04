Public Class FRM_PRCANCELED
    Private Sub FRM_PRCANCELED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.tblM4_PURCHASEREQUEST' table. You can move, or remove it, as needed.
        Me.TblM4_PURCHASEREQUESTTableAdapter.Fill(Me.DS_PROPERTYDB.tblM4_PURCHASEREQUEST)
        WTXT_CANCELED_REMARKS.SelectAll()
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click, DGV_CLOSE.Click

        Dim btn As Button = Nothing

        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

        If btn Is BTN_SAVE Then
            TblM4_PURCHASEREQUESTTableAdapter.UQ_STATUSAPPCODE("3", EMP_NO, PR_APPCODE, PRNO)
            TblM4_PURCHASEREQUEST_CANCELEDTableAdapter.IQ_CANCELEDPR(PRNO, WTXT_CANCELED_REMARKS.Text, EMP_NO)
            MsgBox("Successfully Saved.", MsgBoxStyle.Information)
            PNL_SLIDE.Location = New Point(1095, 40)
            Me.Close()
        ElseIf btn Is DGV_CLOSE Then
            Me.Close()
        End If
    End Sub

    Private Sub TblM4_PURCHASEREQUEST_CANCELEDBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblM4_PURCHASEREQUEST_CANCELEDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS_PROPERTYDB)

    End Sub
End Class