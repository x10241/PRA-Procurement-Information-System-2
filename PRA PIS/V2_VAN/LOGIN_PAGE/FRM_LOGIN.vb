Public Class FRM_LOGIN

#Region "START ##### FORM DRAG AND DROP"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
#End Region

    Private Sub FRM_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_TABLES.tblV1_USERACCOUNTLOGS' table. You can move, or remove it, as needed.
        Me.TblV1_USERACCOUNTLOGSTableAdapter.Fill(Me.DS_TABLES.tblV1_USERACCOUNTLOGS)

    End Sub

    Private Sub BTNCLOSE_Click(sender As Object, e As EventArgs) Handles BTNCLOSE.Click, BTNLOGIN.Click
        Dim btn As Button = CType(sender, Button)
        If btn Is BTNLOGIN Then
            Dim GOLOGGED As Boolean = True
            Try
                If Me.TblV1_USERACCOUNTTableAdapter.SQ_IFUSERISACTIVE(enc.ENCRYPT(Trim(TXT_USERNAME.Text) & "$" & Trim(TXT_PASSWORD.Text))) > 0 Then
                    'If Me.TblV1_USERACCOUNTTableAdapter.SQ_IFUSERISLOGGED(enc.ENCRYPT(TXT_USERNAME.Text & "$" & TXT_PASSWORD.Text)) > 0 Then

                    If Me.TblV1_USERACCOUNTTableAdapter.SQ_GETUACPASSWORD(enc.ENCRYPT(Trim(TXT_USERNAME.Text) & "$" & Trim(TXT_PASSWORD.Text))) = enc.ENCRYPT(Trim(TXT_USERNAME.Text) & "$" & Trim(TXT_PASSWORD.Text)) Then
                        TblV1_USERACCOUNTLOGSTableAdapter.IQ_USERACCOUNTLOGS(Trim(TXT_USERNAME.Text), "IP ADDRESS: " & Net.Dns.GetHostEntry(Net.Dns.GetHostName).AddressList(0).ToString() & "  MACHINE: " & Net.Dns.GetHostName, True)
                        MDI_Mainform.LBLSystemUser.Text = Trim(TXT_USERNAME.Text).ToUpper
                        TblV1_USERACCOUNTTableAdapter.UQ_USERLOGSTATUS(1, Trim(TXT_USERNAME.Text))
                        'MDI_Mainform.TblV1_USERACCOUNTTableAdapter.UQ_ACTIVATE_REALTIME(10)
                        GBL_USERNAME = Trim(TXT_USERNAME.Text)
                        GBL_USERNPASS = enc.ENCRYPT(Trim(TXT_USERNAME.Text) & "$" & Trim(TXT_PASSWORD.Text))

                        EMP_NO = TblV1_USERACCOUNTTableAdapter.SQ_UHRIS_EMPNO(Trim(TXT_USERNAME.Text))
                        DIVISION_NO = TblV1_USERACCOUNTTableAdapter.SQ_DIVS_CODE(Trim(TXT_USERNAME.Text))

                        USERFULLNAME = TblV1_HRISEMPLOYEEDATATableAdapter1.SQ_GETFULLNAME(EMP_NO)
                        USERDIVISION = TblV1_HRISDIVISIONTableAdapter1.SQ_GETDIVISIONDESCRIPTION(DIVISION_NO)
                        USERDEPARTMENT = TblV1_HRISDEPARTMENTTableAdapter1.SQ_GETDEPARTMENTDESCRIPTION(TblV1_HRISDIVISIONTableAdapter1.SQ_GETHDPTCODE(DIVISION_NO))

                        MDI_Mainform.Show()
                        Me.Hide()
                    Else
                        NotificationManager.Show(Me, "INVALID USERNAME OR PASSWORD!", Color.Red, 3000)
                        ' MsgBox("INVALID USERNAME OR PASSWORD", vbCritical, "LOGIN FAILED")
                    End If
                    'Else
                    'MsgBox("ACCOUNT IS ALREADY LOG IN!" & vbNewLine & "IF THIS IS YOUR ACCOUNT." & vbNewLine & "PLEASE CONTACT SYSTEM ADMINISTRATOR FOR DETAILS.", vbInformation, "ACCOUNT LOG")
                    'End If
                Else
                    NotificationManager.Show(Me, "INVALID USERNAME OR PASSWORD!", Color.Red, 3000)
                    'NotificationManager.Show(Me, "INVALID USERNAME OR PASSWORD!" & vbNewLine & vbNewLine & "IF CAN'T REMEMBER." & vbNewLine & "PLEASE CONTACT SYSTEM ADMINISTRATOR FOR DETAILS.", Color.Red, 3000)
                    'MsgBox("INVALID USERNAME OR PASSWORD!" & vbNewLine & vbNewLine & "IF CAN'T REMEMBER." & vbNewLine & "PLEASE CONTACT SYSTEM ADMINISTRATOR FOR DETAILS.", vbInformation, "INVALID ACCOUNT")
                    ' MsgBox("ACCOUNT IS EITHER DEACTIVATED OR NOT EXIST!" & vbNewLine & vbNewLine & "PLEASE CONTACT SYSTEM ADMINISTRATOR FOR DETAILS.", vbInformation, "ACCOUNT STATUS")
                End If
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "FRM_LOGIN ERROR")
                NotificationManager.Show(Me, "AN ERROR OCCURED PLEASE CONTACT SYSTEM DEVELOPER!" & vbNewLine & My.Settings.PRADEV, Color.Red, 3000)
            End Try

        ElseIf btn Is BTNCLOSE Then
            Me.Close()
        End If
    End Sub
End Class