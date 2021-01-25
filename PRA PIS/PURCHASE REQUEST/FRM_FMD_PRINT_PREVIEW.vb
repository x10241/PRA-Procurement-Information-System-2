Option Strict On
Option Explicit On

Public Class FRM_FMD_PRINT_PREVIEW

    Sub LoadREPORT()

        'If REP_TYPE = "INV" Then
        rptDoc = New RPT_AOQ
        'PCOUNT
        'ElseIf REP_TYPE = "PCOUNT" Then
        '    rptDoc = New RPT_INVENTORY_REPORT
        '    'STOCK MASTERLIST
        'ElseIf REP_TYPE = "STOCK_LIST" Then
        '    rptDoc = New RPT_STOCKMASTERLIST
        '    SPM4_ITEM_STOCKMASTERLIST_RPTTableAdapter.FillByORDER(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST_RPT, STK_ORDERBY, STK_SORTBY, STK_MONTH, STK_YEAR, DIVISION_NO, SYS_FULLNAME_FML, EMP_POSITION, STK_APPBY, STK_POS)
        '    rptDoc.SetDataSource(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST_RPT.DataSet)
        '    With rptDoc
        '        .SetParameterValue(0, STK_ORDERBY)
        '        .SetParameterValue(1, STK_SORTBY)
        '        .SetParameterValue(2, STK_MONTH)
        '        .SetParameterValue(3, STK_YEAR)
        '        .SetParameterValue(4, DIVISION_NO)
        '        .SetParameterValue(5, SYS_FULLNAME_FML)
        '        .SetParameterValue(6, EMP_POSITION)
        '        .SetParameterValue(7, STK_APPBY)
        '        .SetParameterValue(8, STK_POS)
        '    End With
        '    'DR MASTER LIST
        'ElseIf REP_TYPE = "DR_ML" Then
        '    rptDoc = New RPT_DRMASTERLIST
        '    SPM4_ITEM_DR_LISTTableAdapter.FillByITEM_CODE(DS_STOREDPROC.SPM4_ITEM_DR_LIST, "", DR_SEARCH, DIVISION_NO)
        '    rptDoc.SetDataSource(DS_STOREDPROC.SPM4_ITEM_DR_LIST.DataSet)
        '    With rptDoc
        '        .SetParameterValue(0, "")
        '        .SetParameterValue(1, DR_SEARCH)
        '        .SetParameterValue(2, DIVISION_NO)
        '    End With
        '    'ISSUED MASTER LIST
        'ElseIf REP_TYPE = "II_ML" Then
        '    rptDoc = New RPT_ISSUEDMASTERLIST
        '    SPM4_ITEM_ISSUED_LISTTableAdapter.FillBy(DS_STOREDPROC.SPM4_ITEM_ISSUED_LIST, "", II_SEARCH, DIVISION_NO)
        '    rptDoc.SetDataSource(DS_STOREDPROC.SPM4_ITEM_ISSUED_LIST.DataSet)
        '    With rptDoc
        '        .SetParameterValue(0, "")
        '        .SetParameterValue(1, II_SEARCH)
        '        .SetParameterValue(2, DIVISION_NO)
        '    End With
        '    'ITEM LIST FOR PCOUNT
        'ElseIf REP_TYPE = "ITEM_LIST" Then
        '    rptDoc = New RPT_ITEM_LIST
        '    DS_CUSTOM.DT_ITEM_DESC.Clear()
        '    For Each row As DataGridViewRow In dgv.Rows
        '        If IsDBNull(row.Cells(26).Value) Then
        '            PictureBox1.BackgroundImage = My.Resources._480px_No_image_available_svg
        '        Else
        '            PictureBox1.BackgroundImage = Image.FromFile(row.Cells(26).Value)
        '        End If
        '        DS_CUSTOM.DT_ITEM_DESC.Rows.Add(row.Cells(1).Value, row.Cells(8).Value, IMGTOBYTE(PictureBox1))
        '    Next
        '    rptDoc.SetDataSource(DS_CUSTOM.DT_ITEM_DESC.DataSet)
        '  End If

        DS_CUSTOM.DT_PART_LIST.Rows.Clear()
        DS_CUSTOM.DT_BID_LIST.Rows.Clear()
        'BID LIST
        For Each row As DataGridViewRow In dgv.Rows
            DS_CUSTOM.DT_BID_LIST.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(0).Value)
        Next

        'PART LIST
        For Each row As DataGridViewRow In dgv2.Rows
            DS_CUSTOM.DT_PART_LIST.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value)
        Next

        rptDoc.Database.Tables("DT_PART_LIST").SetDataSource(DS_CUSTOM.Tables(1))


        'Dim DS_P As DataSet = New DataSet
        'DS_CUSTOM.DT_BID_LIST.Merge(DS_CUSTOM.DT_PART_LIST)
        'rptDoc.Database.Tables("DT_PART_LIST").SetDataSource()
        'rptDoc.Database.Tables("DT_BID_LIST").SetDataSource()

        CRV_PREVIEW.ReportSource = rptDoc
        CRV_PREVIEW.Zoom(130)
    End Sub

    Private Sub CRV_PREVIEW_Load(sender As Object, e As EventArgs) Handles CRV_PREVIEW.Load
        LoadREPORT()
    End Sub

    Private Sub BTN_INVENTORY_REPORT_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_REPORT_CLOSE.Click
        Me.Close()
    End Sub
End Class