Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_DGV_ENCODING
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click,
                                                                        DGV_CLOSE.Click
        Dim btn As Button = Nothing
        llbl = Nothing
        rect = Nothing
        TXTGLOBAL = Nothing
        ISVALID = True

        If TypeOf sender Is RectangleShape Then
            rect = DirectCast(sender, RectangleShape)
        ElseIf TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If
        If btn Is BTN_SAVE Then
            If WTXT_QUANTITY.Text = "0" Then
                RECT_DGVQUANTITY.BorderColor = Color.OrangeRed
                NotificationManager.Show(Me, "PLEASE CHECK QUANTITY!", Color.Red, 3000)
                ISVALID = False
            Else
                RECT_DGVQUANTITY.BorderColor = Color.LightSeaGreen
            End If

            If WTXT_ESTIMATEDUNITCOST.Text = "0" Then
                RECT_DGESTIMATEDUNITCOST.BorderColor = Color.OrangeRed
                NotificationManager.Show(Me, "PLEASE CHECK ESTIMATED UNIT COST!", Color.Red, 3000)
                ISVALID = False
            Else
                RECT_DGESTIMATEDUNITCOST.BorderColor = Color.LightSeaGreen
            End If

            If ISVALID Then
                If BTN_SAVE.Text = "SAVE" Then
                    If MsgBox("ADD THIS?", vbYesNo, "CONFIRM") = vbYes Then
                        RECT_DGVQUANTITY.BorderColor = Color.LightSeaGreen
                        RECT_DGESTIMATEDUNITCOST.BorderColor = Color.LightSeaGreen
                        'If dgv Is FRM_PR.DGV_PR_ITEMLIST Then
                        dgv.Rows.Add(Trim(WTXT_DESCRIPTION.Text), Trim(WTXT_QUANTITY.Text), Trim(CB_UNITOFISSUE.Text), Trim(WTXT_STOCKNO.Text), Trim(WTXT_ESTIMATEDUNITCOST.Text), Trim(WTXT_ESTIMATEDCOST.Text))
                        'End If
                        WTXT_DESCRIPTION.Clear()
                        WTXT_ESTIMATEDUNITCOST.Text = 0
                        WTXT_QUANTITY.Text = 0
                        WTXT_STOCKNO.Clear()
                        CB_UNITOFISSUE.SelectedIndex = 0
                        WTXT_ESTIMATEDCOST.Text = 0
                        WTXT_STOCKNO.Select()

                    End If

                Else
                    If WTXT_QUANTITY.Text = "0" Then
                        RECT_DGVQUANTITY.BorderColor = Color.OrangeRed
                        NotificationManager.Show(Me, "PLEASE CHECK QUANTITY!", Color.Red, 3000)
                    ElseIf WTXT_ESTIMATEDUNITCOST.Text = "0" Then
                        RECT_DGESTIMATEDUNITCOST.BorderColor = Color.OrangeRed
                        NotificationManager.Show(Me, "PLEASE CHECK ESTIMATED UNIT COST!", Color.Red, 3000)
                    Else
                        If MsgBox("UPDATE THIS?", vbYesNo, "CONFIRM") = vbYes Then
                            dgv(0, dgv.CurrentRow.Index).Value = Trim(WTXT_DESCRIPTION.Text)
                            dgv(1, dgv.CurrentRow.Index).Value = Trim(WTXT_QUANTITY.Text)
                            dgv(2, dgv.CurrentRow.Index).Value = Trim(CB_UNITOFISSUE.Text)
                            dgv(3, dgv.CurrentRow.Index).Value = Trim(WTXT_STOCKNO.Text)
                            dgv(4, dgv.CurrentRow.Index).Value = Trim(WTXT_ESTIMATEDUNITCOST.Text.Replace(",", ""))
                            dgv(5, dgv.CurrentRow.Index).Value = Trim(WTXT_ESTIMATEDCOST.Text.Replace(",", ""))
                            WTXT_DESCRIPTION.Clear()
                            WTXT_ESTIMATEDUNITCOST.Text = 0
                            WTXT_QUANTITY.Text = 0
                            WTXT_STOCKNO.Clear()
                            CB_UNITOFISSUE.SelectedIndex = 0
                            WTXT_ESTIMATEDCOST.Text = 0
                            Me.Close()
                        End If
                    End If
                End If
            End If
        ElseIf btn Is DGV_CLOSE Then
            Me.Close()
        End If
    End Sub

    Private Sub FRM_DGV_ENCODING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLG3_UNITS' table. You can move, or remove it, as needed.
        Me.TBLG3_UNITSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLG3_UNITS)
        WTXT_STOCKNO.Select()

    End Sub

    Private Sub WTXT_QUANTITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_QUANTITY.KeyPress,
                                                                                            WTXT_ESTIMATEDUNITCOST.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace
    End Sub

    Private Sub WTXT_QUANTITY_Leave(sender As Object, e As EventArgs) Handles WTXT_QUANTITY.Leave,
                                                                                WTXT_ESTIMATEDUNITCOST.Leave
        Try
            TXTGLOBAL = Nothing
            If TypeOf sender Is TextBox Then
                TXTGLOBAL = DirectCast(sender, TextBox)
            End If
            If TXTGLOBAL Is WTXT_QUANTITY Or TXTGLOBAL Is WTXT_ESTIMATEDUNITCOST Then
                WTXT_ESTIMATEDCOST.Text = CInt(WTXT_QUANTITY.Text) * CDec(WTXT_ESTIMATEDUNITCOST.Text)
                WTXT_ESTIMATEDCOST.Text = TXTSETTO_0(WTXT_ESTIMATEDCOST, True)
            End If
        Catch ex As Exception
            NotificationManager.Show(Me, "PLEASE CHECK QUANTITY AND ESTIMATED UNIT COST!", Color.Red, 3000)
        End Try
    End Sub

End Class