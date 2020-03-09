
Imports System.Globalization
Imports Microsoft.VisualBasic.PowerPacks

Public Class FRM_DATAENTRY
    Dim dtpTrue As Boolean
    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles LLBL_APPSave.Click,
                                                                            LLBL_APPClear.Click,
                                                                            RECT_APPSave.Click,
                                                                            RECT_APPClear.Click

        If TypeOf sender Is LinkLabel Then
            llbl = DirectCast(sender, LinkLabel)
        ElseIf TypeOf sender Is RectangleShape Then
            rect = DirectCast(sender, RectangleShape)
        End If


        If llbl Is LLBL_APPClear And rect Is RECT_APPClear Then
            TXTDATE.Text = ""
            Me.Close()
        ElseIf llbl Is LLBL_APPSave And rect Is RECT_APPSave Then
            Dim dtpp As DateTime
            Try
                dtpp = Nothing
                If DateTime.TryParseExact(MTB_DATEFrom.Text, "MM/dd/yyyy", Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, dtpp) Then
                    dtpDate.Value = dtpp
                    dtpTrue = True
                Else
                    dtpTrue = False
                End If
            Catch ex As Exception
                dtpTrue = False
            End Try
            If dtpTrue Then
                Dim dt As DateTime = dtpDate.Text
                TXTDATE.Text = dt.ToString("MMM dd, yyyy")
                '  TXTDATE.Text = dtpDate.Text
                Me.Close()
            Else
                MsgBox("Please check date format!" + vbNewLine + vbNewLine + "Date Format must be in (Month/Day/Year)", vbOKOnly, "INVALID DATE FORMAT")
                dtpTrue = False
                MTB_DATEFrom.SelectAll()
            End If
        End If

    End Sub

    Private Sub BTN_SAVE1_Click(sender As Object, e As EventArgs) Handles BTN_APPSave.Click

        Dim dtpp As DateTime
        Try
            dtpp = Nothing
            If DateTime.TryParseExact(MTB_DATEFrom.Text, "MM/dd/yyyy", Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, dtpp) Then
                dtpDate.Value = dtpp
                dtpTrue = True
            Else
                dtpTrue = False
            End If
        Catch ex As Exception
            dtpTrue = False
        End Try
        If dtpTrue Then
            Dim dt As DateTime = dtpDate.Text
            TXTDATE.Text = dt.ToString("MMM dd, yyyy")
            ' TXTDATE.Text = dtpDate.Text

            If Me.A_CLOSEPROGRAMTableAdapter.UDFV1_DOB_AGE(TXTDATE.Text) < 0 Then
                MsgBox("INVALID DATE" & vbNewLine & "DATE CANNOT BE GREATER THAN TODAY", vbCritical, "DATE INPUT")
                MTB_DATEFrom.Clear()
                MTB_DATEFrom.Select()
                Exit Sub
            End If

            'If TXTISDBATE Then
            '    If MEMTYPE = "P" And Me.A_CLOSEPROGRAMTableAdapter.UDFV1_DOB_AGE(TXTDATE.Text) < 35 Then
            '        MsgBox("AGE LIMIT: " & vbNewLine & vbNewLine & "PRINCIPAL MINIMUM AGE MUST BE 35 YEARS OLD OR HIGHER")
            '        MTB_DATEFrom.Clear()
            '        MTB_DATEFrom.Select()
            '        Exit Sub
            '    ElseIf MEMTYPE = "S" And Me.A_CLOSEPROGRAMTableAdapter.UDFV1_DOB_AGE(TXTDATE.Text) <= 17 Then
            '        MsgBox("AGE LIMIT: " & vbNewLine & vbNewLine & "SPOUSE MINIMUM AGE MUST BE 18 YEARS OLD OR HIGHER")
            '        MTB_DATEFrom.Clear()
            '        MTB_DATEFrom.Select()
            '        Exit Sub
            '    Else
            '        'FRM_CHECKLIST.WTXT_AGE.Text = Me.A_CLOSEPROGRAMTableAdapter.UDFV1_DOB_AGE(TXTDATE.Text)
            '    End If
            'End If
            Me.Close()
        Else
            MsgBox("Please check date format!" + vbNewLine + vbNewLine + "Date Format must be in (Month/Day/Year)", vbOKOnly, "INVALID DATE FORMAT")
            dtpTrue = False
            MTB_DATEFrom.SelectAll()
        End If

    End Sub

    Private Sub FRM_DATAENTRY_Load(sender As Object, e As EventArgs) Handles MyBase.Load, Me.Shown
        MTB_DATEFrom.Clear()
        MTB_DATEFrom.Select()
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub LLBL_APPSave_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLBL_APPSave.LinkClicked

    End Sub
End Class