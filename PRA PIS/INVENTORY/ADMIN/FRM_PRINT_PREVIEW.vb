Imports System.IO

Public Class FRM_PMD_PRINT_PREVIEW

    Public Sub _BS_DGV_TRANSFER(ByVal BSMAIN As BindingSource, BSTRANSFER As DataTable)
        For i = 0 To BSMAIN.Count - 1
            BSTRANSFER.Rows.Add(CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(0)), "", CType(BSMAIN.List(i), DataRowView).Item(0))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(1)), "", CType(BSMAIN.List(i), DataRowView).Item(1))),
                                                 CStr(If(IsDBNull(CType(BSMAIN.List(i), DataRowView).Item(2)), "", CType(BSMAIN.List(i), DataRowView).Item(2))))
        Next
    End Sub




#Region "CLICK"

    Private Sub BTN_INVENTORY_REPORT_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY_REPORT_CLOSE.Click,
                                                                                            BTN_INVENTORY_REPORT_MINIMIZE.Click,
                                                                                            BTN_GENERATE_REPORT.Click
        Dim btn As Button = Nothing

        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        End If

        If btn Is BTN_INVENTORY_REPORT_MINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
        ElseIf btn Is BTN_INVENTORY_REPORT_CLOSE Then
            Me.Close()
            Me.Dispose()
        ElseIf btn Is BTN_GENERATE_REPORT Then
            _GEN_REPORT()
        End If
    End Sub

#End Region

    Sub LoadREPORT()
        If REP_TYPE = "INV" Then
            rptDoc = New RPT_INVENTORY_REPORT
            'PCOUNT
        ElseIf REP_TYPE = "PCOUNT" Then
            rptDoc = New RPT_INVENTORY_REPORT
            'STOCK MASTERLIST
        ElseIf REP_TYPE = "STOCK_LIST" Then
            rptDoc = New RPT_STOCKMASTERLIST
            SPM4_ITEM_STOCKMASTERLIST_RPTTableAdapter.FillByORDER(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST_RPT, STK_ORDERBY, STK_SORTBY, STK_MONTH, STK_YEAR, DIVISION_NO, SYS_FULLNAME_FML, EMP_POSITION, STK_APPBY, STK_POS)
            rptDoc.SetDataSource(DS_STOREDPROC.SPM4_ITEM_STOCKMASTERLIST_RPT.DataSet)
            With rptDoc
                .SetParameterValue(0, STK_ORDERBY)
                .SetParameterValue(1, STK_SORTBY)
                .SetParameterValue(2, STK_MONTH)
                .SetParameterValue(3, STK_YEAR)
                .SetParameterValue(4, DIVISION_NO)
                .SetParameterValue(5, SYS_FULLNAME_FML)
                .SetParameterValue(6, EMP_POSITION)
                .SetParameterValue(7, STK_APPBY)
                .SetParameterValue(8, STK_POS)
            End With
            'DR MASTER LIST
        ElseIf REP_TYPE = "DR_ML" Then
            rptDoc = New RPT_DRMASTERLIST
            SPM4_ITEM_DR_LISTTableAdapter.FillByITEM_CODE(DS_STOREDPROC.SPM4_ITEM_DR_LIST, "", DR_SEARCH, DIVISION_NO)
            rptDoc.SetDataSource(DS_STOREDPROC.SPM4_ITEM_DR_LIST.DataSet)
            With rptDoc
                .SetParameterValue(0, "")
                .SetParameterValue(1, DR_SEARCH)
                .SetParameterValue(2, DIVISION_NO)
            End With
            'ISSUED MASTER LIST
        ElseIf REP_TYPE = "II_ML" Then
            rptDoc = New RPT_ISSUEDMASTERLIST
            SPM4_ITEM_ISSUED_LISTTableAdapter.FillBy(DS_STOREDPROC.SPM4_ITEM_ISSUED_LIST, "", II_SEARCH, DIVISION_NO)
            rptDoc.SetDataSource(DS_STOREDPROC.SPM4_ITEM_ISSUED_LIST.DataSet)
            With rptDoc
                .SetParameterValue(0, "")
                .SetParameterValue(1, II_SEARCH)
                .SetParameterValue(2, DIVISION_NO)
            End With
            'ITEM LIST FOR PCOUNT
        ElseIf REP_TYPE = "ITEM_LIST" Then
            rptDoc = New RPT_ITEM_LIST
            DS_CUSTOM.DT_ITEM_DESC.Clear()
            For Each row As DataGridViewRow In dgv.Rows
                If IsDBNull(row.Cells(26).Value) Then
                    PictureBox1.BackgroundImage = My.Resources._480px_No_image_available_svg
                Else
                    PictureBox1.BackgroundImage = Image.FromFile(row.Cells(26).Value)
                End If
                DS_CUSTOM.DT_ITEM_DESC.Rows.Add(row.Cells(1).Value, row.Cells(8).Value, IMGTOBYTE(PictureBox1))
            Next
            rptDoc.SetDataSource(DS_CUSTOM.DT_ITEM_DESC.DataSet)
        End If

        CRV_PREVIEW.ReportSource = rptDoc
        CRV_PREVIEW.Zoom(130)
    End Sub

#Region "LOAD"
    Private Sub FRM_PRINT_PREVIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPM4_CURRENTDATETIMETableAdapter.Fill(DS_STOREDPROC.SPM4_CURRENTDATETIME)
        LoadREPORT()
    End Sub

    Private Sub CRV_PREVIEW_Load(sender As Object, e As EventArgs) Handles CRV_PREVIEW.Load
        SPM4_CURRENTDATETIMETableAdapter.Fill(DS_STOREDPROC.SPM4_CURRENTDATETIME)
        LoadREPORT()
    End Sub
#End Region

#Region "GENERATE REPORT"
    Sub _GEN_REPORT()
        PrintDialog.Document = PrintDocument
        PrintDialog.PrinterSettings = PrintDocument.PrinterSettings
        If PrintDialog.ShowDialog = DialogResult.OK Then
            Try
                Dim PrinterName As String = PrintDocument.PrinterSettings.PrinterName
                rptDoc.PrintOptions.PrinterName = PrinterName
                rptDoc.PrintToPrinter(1, False, 0, 0)
                Me.Close()
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "_GEN_REPORT")
            End Try
        End If
    End Sub




#End Region

End Class