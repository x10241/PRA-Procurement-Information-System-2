

Public Class FRM_ASSIGN
    Dim LocalEmpNo As String
#Region "START ##### FORM DRAG AND DROP, MINIMIZE, CLOSE"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PNL_DoubleClick(sender As Object, e As EventArgs) Handles PNL.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL.MouseUp
        drag = False
    End Sub
#End Region
    Public trans As String

    Public Sub BS_DGV_ASSIGN(ByVal BSMAIN As BindingSource, BSTRANSFER As DataTable)
        For i = 0 To BSMAIN.Count - 1
            BSTRANSFER.Rows.Add(CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(0)), "", CType(BSMAIN.List(i), DataRowView).Item(0))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(1)), "", CType(BSMAIN.List(i), DataRowView).Item(1))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(2)), "", CType(BSMAIN.List(i), DataRowView).Item(2))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(3)), "", CType(BSMAIN.List(i), DataRowView).Item(3))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(4)), "", CType(BSMAIN.List(i), DataRowView).Item(4))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(5)), "", CType(BSMAIN.List(i), DataRowView).Item(5))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(6)), "", CType(BSMAIN.List(i), DataRowView).Item(6))))
        Next
    End Sub

    Private Sub BTN_SELECTION_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_SELECTION_CLOSE.Click,
                                                                                        BTN_ONE_PLUS.Click,
                                                                                        BTN_ONE_MINUS.Click,
                                                                                        BTN_ALL_MINUS.Click,
                                                                                        BTN_ALL_PLUS.Click,
                                                                                        BTN_ASSIGN_SAVE.Click,
                                                                                        WTXT_ACC_EMP_NAME.Click,
                                                                                        WTXT_ACC_EMP_DIVISION.Click,
                                                                                        WTXT_ACC_EMP_NO.Click,
                                                                                        WTXT_ASS_PERSON_NAME.Click,
                                                                                        WTXT_ASS_PERSON_EMP_NO.Click,
                                                                                        WTXT_ASS_PERSON_DEPARTMENT.Click,
                                                                                        WTXT_ASS_PERSON_DIVISION.Click

        Dim btn As Button = Nothing
        Dim txt As WatermarkTextBox = Nothing
        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        ElseIf TypeOf sender Is WatermarkTextBox Then
            txt = CType(sender, WatermarkTextBox)
        End If

#Region "Close"
        If btn Is BTN_SELECTION_CLOSE Then
            Me.Close()
            Me.Dispose()
#End Region

#Region "Cancel Transaction"
            'ElseIf btn Is BTN_ASSIGN_CANCEL Then
            '    If MsgBox("Cancel this transaction?", vbYesNo, "Confirm") = vbYes Then
            '        enableDisable("Cancel")
            '        DS_CUSTOM.AssignItemsDataGridView.Rows.Clear()
            '        DS_CUSTOM.ItemsDataGridView.Rows.Clear()
            '    End If
#End Region

#Region "Reassign to User"
            'ElseIf btn Is BTN_REASSIGN_ITEM_TO_USER Then
            '    enableDisable("New")
            '    trans = "ReAssign"
            '    TblM4_INVENTORY_ITEMS1TableAdapter.FillByINAssign(DS_PROPERTYDB.tblM4_INVENTORY_ITEMS1, WTXT_SEARCH_ITEM_DETAIL.Text)
            '    BS_DGV_ASSIGN(TblM4_INVENTORY_ITEMS1BindingSource, DS_CUSTOM.ItemsDataGridView)
#End Region

#Region "Save"
        ElseIf btn Is BTN_ASSIGN_SAVE Then
            ISVALID = True
            'If REQFIELDVALIDATION(WTXT_ACC_EMP_NAME) Or REQFIELDVALIDATION(WTXT_ACC_EMP_DIVISION) Or REQFIELDVALIDATION(WTXT_ACC_EMP_DEPARTMENT) Or REQFIELDVALIDATION(WTXT_ACC_EMP_NO) Then
            '    ISVALID = False
            '    RECT_DEPARTMENT.BorderColor = Color.OrangeRed
            '    RECT_DIVISION.BorderColor = Color.OrangeRed
            '    RECT_NAME.BorderColor = Color.OrangeRed
            '    RECT_POSITION.BorderColor = Color.OrangeRed
            'Else
            '    RECT_DEPARTMENT.BorderColor = Color.LightSeaGreen
            '    RECT_DIVISION.BorderColor = Color.LightSeaGreen
            '    RECT_NAME.BorderColor = Color.LightSeaGreen
            '    RECT_POSITION.BorderColor = Color.LightSeaGreen
            'End If

            'If DGV_ASSIGN_ITEMS.Rows.Count = 0 Then
            '    ISVALID = False
            'End If

            'If ISVALID Then
            Save()
            Close()
            Dispose()
            FRM_ASSIGN_ITEMS.VWM4_ITEM_ASSTableAdapter.FillByITEM_CODE(DS_VIEWS.VWM4_ITEM_ASS)
            ' End If
#End Region

#Region "Add One"
        ElseIf btn Is BTN_ONE_PLUS Then
            If TblM4_INVENTORY_ITEMS1DataGridView.Rows.Count > 0 Then
                Try
                    DS_CUSTOM.AssignItemsDataGridView.Rows.Add(TblM4_INVENTORY_ITEMS1DataGridView(0, TblM4_INVENTORY_ITEMS1DataGridView.CurrentRow.Index).Value,
                                                         TblM4_INVENTORY_ITEMS1DataGridView(1, TblM4_INVENTORY_ITEMS1DataGridView.CurrentRow.Index).Value,
                                                         TblM4_INVENTORY_ITEMS1DataGridView(2, TblM4_INVENTORY_ITEMS1DataGridView.CurrentRow.Index).Value,
                                                         TblM4_INVENTORY_ITEMS1DataGridView(3, TblM4_INVENTORY_ITEMS1DataGridView.CurrentRow.Index).Value,
                                                         TblM4_INVENTORY_ITEMS1DataGridView(4, TblM4_INVENTORY_ITEMS1DataGridView.CurrentRow.Index).Value,
                                                         TblM4_INVENTORY_ITEMS1DataGridView(5, TblM4_INVENTORY_ITEMS1DataGridView.CurrentRow.Index).Value,
                                                         TblM4_INVENTORY_ITEMS1DataGridView(6, TblM4_INVENTORY_ITEMS1DataGridView.CurrentRow.Index).Value)
                    TblM4_INVENTORY_ITEMS1DataGridView.Rows.RemoveAt(DGV_ASSIGN_ITEMS.CurrentRow.Index)
                    DGV_ASSIGN_ITEMS.DataSource = AssignItemsDataGridViewBindingSource
                    LLBL_ITEM_DETAILS_COUNT.Text = TblM4_INVENTORY_ITEMS1DataGridView.Rows.Count
                    LLBL_ITEMS_ASSIGN_COUNT.Text = DGV_ASSIGN_ITEMS.Rows.Count
                Catch ex As Exception
                    NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
                End Try
            End If
#End Region

#Region "Add All"
        ElseIf btn Is BTN_ALL_PLUS Then
            If TblM4_INVENTORY_ITEMS1DataGridView.Rows.Count > 0 Then
                BS_DGV_ASSIGN(ItemsDataGridViewBindingSource, DS_CUSTOM.AssignItemsDataGridView)
                DGV_ASSIGN_ITEMS.DataSource = AssignItemsDataGridViewBindingSource
                DS_CUSTOM.ItemsDataGridView.Rows.Clear()
                LLBL_ITEM_DETAILS_COUNT.Text = TblM4_INVENTORY_ITEMS1DataGridView.Rows.Count
                LLBL_ITEMS_ASSIGN_COUNT.Text = DGV_ASSIGN_ITEMS.Rows.Count
            End If
#End Region

#Region "Minus One"
        ElseIf btn Is BTN_ONE_MINUS Then
            If DGV_ASSIGN_ITEMS.Rows.Count > 0 Then
                Try
                    DS_CUSTOM.ItemsDataGridView.Rows.Add(DGV_ASSIGN_ITEMS(0, DGV_ASSIGN_ITEMS.CurrentRow.Index).Value,
                                                         DGV_ASSIGN_ITEMS(1, DGV_ASSIGN_ITEMS.CurrentRow.Index).Value,
                                                         DGV_ASSIGN_ITEMS(2, DGV_ASSIGN_ITEMS.CurrentRow.Index).Value,
                                                         DGV_ASSIGN_ITEMS(3, DGV_ASSIGN_ITEMS.CurrentRow.Index).Value,
                                                         DGV_ASSIGN_ITEMS(4, DGV_ASSIGN_ITEMS.CurrentRow.Index).Value,
                                                         DGV_ASSIGN_ITEMS(5, DGV_ASSIGN_ITEMS.CurrentRow.Index).Value,
                                                         DGV_ASSIGN_ITEMS(6, DGV_ASSIGN_ITEMS.CurrentRow.Index).Value)
                    DGV_ASSIGN_ITEMS.Rows.RemoveAt(TblM4_INVENTORY_ITEMS1DataGridView.CurrentRow.Index)
                    TblM4_INVENTORY_ITEMS1DataGridView.DataSource = ItemsDataGridViewBindingSource
                    LLBL_ITEM_DETAILS_COUNT.Text = TblM4_INVENTORY_ITEMS1DataGridView.Rows.Count
                    LLBL_ITEMS_ASSIGN_COUNT.Text = DGV_ASSIGN_ITEMS.Rows.Count
                Catch ex As Exception
                    NotificationManager.Show(Me, ex.Message, Color.Red, 3000)
                End Try
            End If
#End Region

#Region "Minus All"
        ElseIf btn Is BTN_ALL_MINUS Then
            If DGV_ASSIGN_ITEMS.Rows.Count > 0 Then
                BS_DGV_ASSIGN(AssignItemsDataGridViewBindingSource, DS_CUSTOM.ItemsDataGridView)
                TblM4_INVENTORY_ITEMS1DataGridView.DataSource = ItemsDataGridViewBindingSource
                DS_CUSTOM.AssignItemsDataGridView.Rows.Clear()
                LLBL_ITEM_DETAILS_COUNT.Text = TblM4_INVENTORY_ITEMS1DataGridView.Rows.Count
                LLBL_ITEMS_ASSIGN_COUNT.Text = DGV_ASSIGN_ITEMS.Rows.Count
            End If
#End Region

#Region "GET EMPLOYEE INFO"
        ElseIf txt Is WTXT_ACC_EMP_NAME Or txt Is WTXT_ACC_EMP_DIVISION Or txt Is WTXT_ACC_EMP_NO Or txt Is WTXT_ASS_PERSON_NAME Or txt Is WTXT_ASS_PERSON_EMP_NO Or txt Is WTXT_ASS_PERSON_DEPARTMENT Or txt Is WTXT_ASS_PERSON_DIVISION Then
            If txt Is WTXT_ACC_EMP_NAME Or txt Is WTXT_ACC_EMP_DIVISION Or txt Is WTXT_ACC_EMP_NO Then
                empfullname = CType(WTXT_ACC_EMP_NAME, TextBox)
                department = CType(WTXT_ACC_EMP_DEPARTMENT, TextBox)
                division = CType(WTXT_ACC_EMP_DIVISION, TextBox)
                employee_no = CType(WTXT_ACC_EMP_NO, TextBox)
                ACCOUNTABLE_OFFICER = CType(WTXT_ACC_EMP_NO, TextBox)
                ACCOUNTABLE_CTR = True
                FRM_EMPLOYEE_LIST.ShowDialog()
            Else
                empfullname = CType(WTXT_ASS_PERSON_NAME, TextBox)
                department = CType(WTXT_ASS_PERSON_DEPARTMENT, TextBox)
                division = CType(WTXT_ASS_PERSON_DIVISION, TextBox)
                employee_no = CType(WTXT_ASS_PERSON_EMP_NO, TextBox)
                ACCOUNTABLE_OFFICER = CType(WTXT_ASS_PERSON_EMP_NO, TextBox)
                ACCOUNTABLE_CTR = True
                FRM_EMPLOYEE_LIST.ShowDialog()
            End If
#End Region

#Region "Show Report"
            'ElseIf btn Is BTN_LOCATION_LIST Then
            '    FRM_ASSIGN_ITEMS.ShowDialog()
#End Region

        End If
    End Sub

    Sub Save()
        For Each row As DataGridViewRow In DGV_ASSIGN_ITEMS.Rows
            If REQFIELDVALIDATION(WTXT_ASS_PERSON_NAME) = False Then
                TblM4_INVENTORY_ASSIGN_PERSONTableAdapter.IQ_ASSIGN_PERSON(row.Cells(0).Value, WTXT_ASS_PERSON_EMP_NO.Text, vbNull, WTXT_ASS_PERSON_REMARKS.Text, EMP_NO)
            End If
            If REQFIELDVALIDATION(WTXT_ACC_EMP_NAME) = False Then
                TblM4_INVENTORY_ACCOUNTABLE_OFFICERTableAdapter.IQ_INV_ACC_OFF(row.Cells(0).Value, WTXT_ACC_EMP_NO.Text, vbNull, WTXT_ACC_REMARKS.Text, EMP_NO, WTXT_DATE_APPOINTED.Text)
            End If
        Next
        'End If



        MessageBox.Show(Me, "Successfully Save!")
        'ElseIf trans = "ReAssign" Then
        '    Dim emp_originated As String
        '    For Each row As DataGridViewRow In DGV_ASSIGN_ITEMS.Rows
        '        emp_originated = TblM4_INVENTORY_ASSIGN_PERSONTableAdapter.SQ_ORIGINATED(row.Cells(0).Value)
        '        TblM4_INVENTORY_ASSIGN_PERSONTableAdapter.IQ_ASSIGN_PERSON(row.Cells(0).Value, WTXT_ACC_EMP_NO.Text, If(emp_originated = CStr(0), Nothing, emp_originated), WTXT_ACC_REMARKS.Text, EMP_NO)
        '    Next
        '    NotificationManager.Show(Me, "Successfully Reassign!", Color.Green, 1000)
        'End If
        '    enableDisable("")
        WTXT_SEARCH_ITEM_DETAIL.Clear()
        WTXT_SEARCH_ASSIGN_ITEM.Clear()
        DS_CUSTOM.AssignItemsDataGridView.Rows.Clear()
        DS_CUSTOM.ItemsDataGridView.Rows.Clear()
    End Sub

    Private Sub WTXT_SEARCH_ITEM_DETAIL_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCH_ITEM_DETAIL.TextChanged
        ItemsDataGridViewBindingSource.Filter = "ItemCode Like '%" + WTXT_SEARCH_ITEM_DETAIL.Text + "%'"
        LLBL_ITEM_DETAILS_COUNT.Text = TblM4_INVENTORY_ITEMS1DataGridView.Rows.Count
        LLBL_ITEMS_ASSIGN_COUNT.Text = DGV_ASSIGN_ITEMS.Rows.Count
    End Sub

    Private Sub WTXT_SEARCH_ASSIGN_ITEM_TextChanged(sender As Object, e As EventArgs) Handles WTXT_SEARCH_ASSIGN_ITEM.TextChanged
        AssignItemsDataGridViewBindingSource.Filter = "ItemCode LIKE '%" + WTXT_SEARCH_ASSIGN_ITEM.Text + "%'"
        LLBL_ITEM_DETAILS_COUNT.Text = TblM4_INVENTORY_ITEMS1DataGridView.Rows.Count
        LLBL_ITEMS_ASSIGN_COUNT.Text = DGV_ASSIGN_ITEMS.Rows.Count
    End Sub
    Sub enableDisable(trans As String)
        If trans = "New" Then
            GB_ITEMDETAILS.Enabled = True
            GB_ITEM_DETAILS.Enabled = True
            GB_REMARKS.Enabled = True
            WTXT_SEARCH_ITEM_DETAIL.Clear()
            WTXT_SEARCH_ASSIGN_ITEM.Clear()
        Else
            GB_ITEMDETAILS.Enabled = False
            GB_ITEM_DETAILS.Enabled = False
            GB_REMARKS.Enabled = False
            WTXT_ACC_EMP_DEPARTMENT.Clear()
            WTXT_ACC_EMP_DIVISION.Clear()
            WTXT_ACC_EMP_NAME.Clear()
            WTXT_ACC_EMP_NO.Clear()
            WTXT_ACC_REMARKS.Clear()
            WTXT_SEARCH_ITEM_DETAIL.Clear()
            WTXT_SEARCH_ASSIGN_ITEM.Clear()
        End If
    End Sub

    Private Sub FRM_ASSIGN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VWM4_ITEM_ASS_IDGVTableAdapter.FillByITEM_CODE(Me.DS_VIEWS.VWM4_ITEM_ASS_IDGV)
        BS_DGV_ASSIGN(VWM4_ITEM_ASS_IDGVBindingSource, DS_CUSTOM.ItemsDataGridView)
        LLBL_ITEM_DETAILS_COUNT.Text = TblM4_INVENTORY_ITEMS1DataGridView.Rows.Count
        LLBL_ITEMS_ASSIGN_COUNT.Text = DGV_ASSIGN_ITEMS.Rows.Count
    End Sub

    Private Sub GB_ITEMDETAILS_Enter(sender As Object, e As EventArgs) Handles GB_ITEMDETAILS.Enter

    End Sub

    Private Sub WTXT_DATE_APPOINTED_Click(sender As Object, e As EventArgs) Handles WTXT_DATE_APPOINTED.Click
        TXTDATE = CType(sender, TextBox)
        FRM_DATAENTRY.ShowDialog()
    End Sub
End Class