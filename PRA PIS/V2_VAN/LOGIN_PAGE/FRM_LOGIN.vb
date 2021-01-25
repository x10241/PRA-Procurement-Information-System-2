Public Class FRM_LOGIN

#Region "START ##### FORM DRAG AND DROP, MINIMIZE, CLOSE"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PNL_DoubleClick(sender As Object, e As EventArgs) Handles PNL_MAINPANEL.DoubleClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL_MAINPANEL.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL_MAINPANEL.MouseMove
        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL_MAINPANEL.MouseUp
        drag = False
    End Sub

#End Region

    Private Sub FRM_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_VIEWS.V1VW_USERACCEMPLOYEE' table. You can move, or remove it, as needed.
    End Sub

    Private Sub BTNCLOSE_Click(sender As Object, e As EventArgs) Handles BTNCLOSE.Click, BTNLOGIN.Click

        Dim btn As Button = CType(sender, Button)
        If btn Is BTNLOGIN Then
            Dim GOLOGGED As Boolean = True
            Try
                If Me.TblV1_USERACCOUNTTableAdapter.SQ_IFUSERISACTIVE(enc.ENCRYPT(Trim(TXT_USERNAME.Text) & "$" & Trim(TXT_PASSWORD.Text))) > 0 Then

                    If Me.TblV1_USERACCOUNTTableAdapter.SQ_GETUACPASSWORD(enc.ENCRYPT(Trim(TXT_USERNAME.Text) & "$" & Trim(TXT_PASSWORD.Text))) = enc.ENCRYPT(Trim(TXT_USERNAME.Text) & "$" & Trim(TXT_PASSWORD.Text)) Then
                        TblV1_USERACCOUNTLOGSTableAdapter.IQ_USERACCOUNTLOGS(Trim(TXT_USERNAME.Text), "IP ADDRESS: " & Net.Dns.GetHostEntry(Net.Dns.GetHostName).AddressList(0).ToString() & "  MACHINE: " & Net.Dns.GetHostName, True)
                        MDI_Mainform.LBLSystemUser.Text = TXT_USERNAME.Text
                        TblV1_USERACCOUNTTableAdapter.UQ_USERLOGSTATUS(1, Trim(TXT_USERNAME.Text))
                        GBL_USERNAME = Trim(TXT_USERNAME.Text)
                        GBL_USERNPASS = enc.ENCRYPT(Trim(TXT_USERNAME.Text) & "$" & Trim(TXT_PASSWORD.Text))
                        EMP_NO = TblV1_USERACCOUNTTableAdapter.SQ_UHRIS_EMPNO(Trim(TXT_USERNAME.Text))
                        '   EMP_NO = SPM4_PDS_LISTTableAdapter.fill
                        EMP_DEPT_DIV = V1VW_USERACCEMPLOYEETableAdapter.SQ_EMP_DEPT_DIV(Trim(TXT_USERNAME.Text))
                        DIVISION_NO = TblV1_USERACCOUNTTableAdapter.SQ_DIVS_CODE(Trim(TXT_USERNAME.Text))
                        SYS_USER = Trim(TXT_USERNAME.Text)
                        SYS_FULLNAME_FML = TblV1_USERACCOUNTTableAdapter.SPV1_SQ_USER_FULLNAME_FML(Trim(TXT_USERNAME.Text))

                        '   EMP_POSITION = TblV1_USERACCOUNTTableAdapter.SQ_HRIS_GET_POSITION(Trim(TXT_USERNAME.Text))
                        EMP_POSITION = V1VW_USERACCEMPLOYEETableAdapter.SQ_POSITION(Trim(TXT_USERNAME.Text)).ToUpper
                        USER_DIVISION = V1VW_USERACCEMPLOYEETableAdapter.SQ_DIVISION_DESC(Trim(TXT_USERNAME.Text))
                        MDI_Mainform.Show()
                        Me.Hide()
                    Else
                        NotificationManager.Show(Me, "INVALID USERNAME OR PASSWORD!", Color.Red, 3000)
                    End If
                Else
                    NotificationManager.Show(Me, "INVALID USERNAME OR PASSWORD!", Color.Red, 3000)
                    TXT_PASSWORD.SelectAll()
                End If
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "FRM_LOGIN ERROR")
                FRM_DISCONNECTED.ShowDialog()
            End Try

        ElseIf btn Is BTNCLOSE Then
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = My.Application.Info.AssemblyName Then
                    prog.Kill()
                End If
            Next
            Me.Close()
        End If

    End Sub




#Region "WTXT_SEARCH"
    Private Sub WTXT_APPSearch_TextChanged(sender As Object, e As EventArgs) Handles TXT_USERNAME.TextChanged, TXT_PASSWORD.TextChanged
        Dim txt As TextBox = CType(sender, TextBox)
        If txt Is TXT_USERNAME Then
            LBL_USERCLEAR.Visible = If(Trim(txt.Text).Length = 0, False, True)
        ElseIf txt Is TXT_PASSWORD Then
            LBL_PASSCLEAR.Visible = If(Trim(txt.Text).Length = 0, False, True)
        End If

    End Sub

    Private Sub BTN_CLEARTEXT_Click(sender As Object, e As EventArgs) Handles LBL_USERCLEAR.Click, LBL_PASSCLEAR.Click
        Dim lbl As Label = CType(sender, Label)
        If lbl Is LBL_USERCLEAR Then
            TXT_USERNAME.Clear()
            TXT_USERNAME.Select()
        ElseIf lbl Is LBL_PASSCLEAR Then
            TXT_PASSWORD.Clear()
            TXT_PASSWORD.Select()
        End If

    End Sub

    Private Sub TXT_USERNAME_Enter(sender As Object, e As EventArgs) Handles TXT_USERNAME.Enter, TXT_PASSWORD.Enter, TXT_USERNAME.Click, TXT_PASSWORD.Click
        Dim txt As TextBox = CType(sender, TextBox)
        txt.SelectAll()
    End Sub
#End Region

    Private Sub FRM_LOGIN_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        LBL_VERSION.Text = "VERSION (" & My.Settings.APP_VER2 & ")"
    End Sub



End Class