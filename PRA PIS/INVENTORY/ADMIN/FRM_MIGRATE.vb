Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_MIGRATE

    Dim PNL_CTR As Integer = 1
    Dim PC_LIST As New List(Of String)
    Dim sec As Integer

#Region "LOAD"
    Private Sub FRM_MIGRATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_STOREDPROC.SPM4_PHY_C_CODE' table. You can move, or remove it, as needed.
        Me.SPM4_PHY_C_CODETableAdapter.Fill(Me.DS_STOREDPROC.SPM4_PHY_C_CODE)
        'TODO: This line of code loads data into the 'DS_PROPERTYDB.TBLM4_INV_DR_ITEMS' table. You can move, or remove it, as needed.
        Me.TBLM4_INV_DR_ITEMSTableAdapter.Fill(Me.DS_PROPERTYDB.TBLM4_INV_DR_ITEMS)
        SPM4_CURRENTDATETIMETableAdapter.Fill(DS_STOREDPROC.SPM4_CURRENTDATETIME)
        PNL_1.Visible = True
        BTN_PREVIOUS.Visible = False
        Me.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter.FillByDATE_DIV_CODE(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_PCOUNT_MAIN, CDate(WTXT_DATE_FROM.Text), CDate(WTXT_DATE_TO.Text), "AP")
    End Sub
#End Region

#Region "CLICK"
    Private Sub BTN_DATE_FROM_Click(sender As Object, e As EventArgs) Handles BTN_DATE_FROM.Click,
                                                                                    BTN_DATE_TO.Click,
                                                                                    BTN_NEXT.Click,
                                                                                    BTN_PREVIOUS.Click,
                                                                                    WTXT_DATE_FROM.Click,
                                                                                    BTN_START_MIG.Click,
                                                                                    BTN_MIG_CLOSE.Click,
                                                                                    BTN_CLOSE_FINISHED.Click

        Try
            Dim pb As PictureBox = Nothing
            Dim btn As Button = Nothing
            llbl = Nothing
            rect = Nothing
            TXTGLOBAL = Nothing


            'If PNL_1.Visible Then
            '    PNL_CTR = 1
            'ElseIf PNL_2.Visible Then
            '    PNL_CTR = 2
            'ElseIf PNL_3.Visible Then
            '    PNL_CTR = 3
            'End If

            If TypeOf sender Is LinkLabel Then
                llbl = DirectCast(sender, LinkLabel)
            ElseIf TypeOf sender Is RectangleShape Then
                rect = DirectCast(sender, RectangleShape)
            ElseIf TypeOf sender Is PictureBox Then
                pb = CType(sender, PictureBox)
            ElseIf TypeOf sender Is Button Then
                btn = CType(sender, Button)
            ElseIf TypeOf sender Is TextBox Then
                TXTGLOBAL = CType(sender, TextBox)
            End If


#Region "DATE"
            If btn Is BTN_DATE_FROM Then
                TXTDATE = CType(WTXT_DATE_FROM, TextBox)
                FRM_DATAENTRY.ShowDialog()
                Me.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter.FillByDATE_DIV_CODE(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_PCOUNT_MAIN, CDate(WTXT_DATE_FROM.Text), CDate(WTXT_DATE_TO.Text), "AP")
            ElseIf btn Is BTN_DATE_TO Then
                TXTDATE = CType(WTXT_DATE_TO, TextBox)
                FRM_DATAENTRY.ShowDialog()
                Me.TBLM4_INV_ITEMS_PCOUNT_MAINTableAdapter.FillByDATE_DIV_CODE(Me.DS_PROPERTYDB.TBLM4_INV_ITEMS_PCOUNT_MAIN, WTXT_DATE_FROM.Text, WTXT_DATE_TO.Text, "AP")
#End Region

#Region "NEXT"
            ElseIf btn Is BTN_NEXT Then
                'GO TO STEP 2
                If PNL_CTR = 1 Then
                    PNL_HEAD_1.BackColor = Color.Gainsboro
                    PNL_HEAD_2.BackColor = Color.Silver
                    PC_LIST.Clear()
                    For Each row As DataGridViewRow In DGV_PC_LIST.Rows
                        'if check
                        If row.Cells(6).Value = True Then
                            PC_LIST.Add(row.Cells(5).Value)
                        End If
                    Next

                    If PC_LIST.Count = 0 Then
                        NotificationManager.Show(Me, "Please select at least one sources!", Color.Red, 3000)
                        Exit Sub
                    Else
                        SPM4_PC_DETAILS_ITEM_CODETableAdapter.FillByPCOM_ID(DS_STOREDPROC.SPM4_PC_DETAILS_ITEM_CODE, String.Join(",", PC_LIST.ToArray))
                        PNL_2.Visible = True
                        PNL_1.Visible = False
                        BTN_PREVIOUS.Visible = True
                        PB_1.Visible = True
                        BTN_NEXT.Visible = False
                        BTN_START_MIG.Visible = True
                    End If

                    'GO TO STEP 3
                ElseIf PNL_CTR = 2 Then
                    PNL_HEAD_2.BackColor = Color.Gainsboro
                    PNL_HEAD_3.BackColor = Color.Silver
                    PB_2.Visible = True
                    'SAVE MIGRATE
                ElseIf PNL_CTR = 3 Then
                    BTN_PREVIOUS.Visible = True
                End If
                'INCREMENT SLIDE CTR
                PNL_CTR += 1
#End Region

#Region "PREV"
            ElseIf btn Is BTN_PREVIOUS Then
                'GO TO STEP 1
                If PNL_CTR = 2 Then
                    PNL_HEAD_2.BackColor = Color.Gainsboro
                    PNL_HEAD_1.BackColor = Color.Silver
                    BTN_PREVIOUS.Visible = False
                    PNL_2.Visible = False
                    PNL_1.Visible = True
                    PB_1.Visible = False
                    BTN_NEXT.Visible = True
                    BTN_START_MIG.Visible = False
                    'GO TO STEP 2
                ElseIf PNL_CTR = 3 Then
                    PNL_HEAD_2.BackColor = Color.Silver
                    PNL_HEAD_3.BackColor = Color.Gainsboro
                    BTN_PREVIOUS.Visible = True
                    PNL_2.Visible = True
                    PNL_3.Visible = False
                    PB_2.Visible = False
                End If
                'DECREMENT SLIDE CTR
                PNL_CTR -= 1

#End Region

#Region "START MIGRATE"
            ElseIf btn Is BTN_START_MIG Then
                If MsgBox("Are you sure? " & vbNewLine & vbNewLine & "You can't undo this action.", vbYesNo, "Start to migrate?") = vbYes Then
                    BTN_MIG_CLOSE.Enabled = False
                    PB_2.Visible = True
                    PNL_3.Visible = True
                    PNL_2.Visible = False
                    BTN_START_MIG.Visible = False
                    BTN_PREVIOUS.Visible = False
                    BTN_NEXT.Visible = False
                    'SAVE
                    Dim STOCK_NO As String = SPM4_PHY_C_CODETableAdapter.SPM4_PHY_C_CODE
                    Dim UNIT_COST As String = Nothing
                    Dim TOTAL_COST As String = Nothing
                    Dim UNIT_TYPE As String = Nothing
                    For Each row As DataGridViewRow In DGV_PC_ITEM_DETAILS.Rows
                        If IsDBNull(row.Cells(12).Value) Then
                            UNIT_COST = Nothing
                        Else
                            UNIT_COST = row.Cells(12).Value
                        End If

                        If IsDBNull(row.Cells(13).Value) Then
                            TOTAL_COST = Nothing
                        Else
                            TOTAL_COST = row.Cells(13).Value
                        End If

                        If IsDBNull(row.Cells(14).Value) Then
                            UNIT_TYPE = Nothing
                        Else
                            UNIT_TYPE = row.Cells(14).Value
                        End If


                        TBLM4_INV_ITEMS_MIGRATETableAdapter.IQ_INV_ITEMS_MIGRATE(row.Cells(7).Value, row.Cells(0).Value, EMP_NO)
                        TBLM4_INV_DR_ITEMSTableAdapter.IQ_INV_DR_ITEMS(row.Cells(7).Value, Nothing, UNIT_COST, TOTAL_COST, row.Cells(9).Value, EMP_NO, UNIT_TYPE, row.Cells(0).Value, STOCK_NO)
                    Next
                    'TIMER
                    TIM_LOAD.Interval = 1000
                    TIM_LOAD.Start()
                End If
#End Region

#Region "CLOSE"
            ElseIf btn Is BTN_MIG_CLOSE Or btn Is BTN_CLOSE_FINISHED Then
                Me.Close()
                Me.Dispose()
#End Region
            End If

        Catch ex As Exception
            NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
        End Try
    End Sub
#End Region

#Region "CELL EVENT"
    Private Sub DGV_PC_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PC_LIST.CellDoubleClick
        Dim cell As DataGridViewCheckBoxCell = DGV_PC_LIST.Rows(e.RowIndex).Cells(6)
        If cell.Value Then
            cell.Value = False
        Else
            cell.Value = True
        End If
    End Sub

#End Region

#Region "TIMER"
    Private Sub TIM_LOAD_Tick(sender As Object, e As EventArgs) Handles TIM_LOAD.Tick
        sec += 1
        If sec = 4 Then
            TIM_LOAD.Stop()
            sec = 0
            PNL_LOAD.Visible = False
            PNL_SAVED.Visible = True
            PB_3.Visible = True
            BTN_MIG_CLOSE.Enabled = False
        End If
    End Sub
#End Region

End Class