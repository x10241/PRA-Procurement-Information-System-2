Imports System.ComponentModel

Public Class MDI_Mainform


#Region "START ##### FORM DRAG AND DROP"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

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

    Private Sub BtnMaxOpen_Click(sender As Object, e As EventArgs) Handles BTNMAINMaximize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

    'Private Sub ABTNMAINHOME_Click(sender As Object, e As EventArgs) Handles ABTNMAINHOME.Click,
    '                                                                            ABTNMAINCRSA.Click,
    '                                                                            ABTNMAINVALIDATION.Click,
    '                                                                            ABTNMAINMONITORING.Click,
    '                                                                            ABTNMAINORDEROFPAYMENT.Click,
    '                                                                            ABTNMAINUDITTRAIL.Click,
    '                                                                            ABTNSYSTEMADMIN.Click,
    '                                                                            ABTNLOGOUT.Click

    '    Dim btn As Button = CType(sender, Button)

    '    If btn Is ABTNMAINHOME Then
    '        PNL_Home.Visible = True
    '        PNL_Home.BringToFront()
    '    Else
    '        PNL_Home.Visible = False
    '        If btn Is ABTNMAINCRSA Then
    '            'If FRM_CRSA_Validation.IsHandleCreated Then
    '            '    FRM_CRSA_Validation.Close()
    '            'End If
    '            TRANSCHK_BOOL = True
    '            Dim newApp As Form = FRM_CHECKLIST.OpenProgram(FRM_CHECKLIST)
    '            newApp.MdiParent = Me
    '            newApp.Show()

    '            'FRM_CHECKLIST.Show()
    '        ElseIf btn Is ABTNMAINVALIDATION Then
    '            TRANSCHK_BOOL = False
    '            CRSAEdit = 2
    '            FRM_MARKETINGVALIDATION.ShowDialog()
    '        ElseIf btn Is ABTNMAINMONITORING Then
    '            ' FRM_CHECKLISTMONITORING.ShowDialog()
    '        ElseIf btn Is ABTNMAINORDEROFPAYMENT Then
    '        ElseIf btn Is ABTNMAINUDITTRAIL Then
    '        ElseIf btn Is ABTNSYSTEMADMIN Then

    '        ElseIf btn Is ABTNLOGOUT Then
    '            If MsgBox("LOGGING OUT?" & vbNewLine & vbNewLine & "Do you want to close the program?", vbYesNo, "CONFIRM") = vbYes Then
    '                Try
    '                    Me.Close()
    '                Catch ex As Exception
    '                    MsgBox(ex.Message)
    '                End Try
    '            Else
    '                Exit Sub
    '            End If
    '        End If
    '    End If
    'End Sub


#Region "MAIN SLIDE BUTTON EVENTS"
    Private Sub BtnPnlSlide_Click(sender As Object, e As EventArgs) Handles ABTNMAINHOME.Click,
                                                                             ABTNMAINREQUEST.Click,
                                                                            ABTNSYSTEMADMIN.Click,
                                                                            ABTNMAININVENTORY.Click,
                                                                            ABTNLOGOUT.Click,
                                                                            ABTNSEL1.Click,
                                                                            ABTNSEL2.Click,
                                                                            ABTNSEL3.Click,
                                                                            ABTNSEL4.Click,
                                                                            ABTNSEL5.Click

        Dim btnSlidePanel As Button = CType(sender, Button)
        Dim btnSlidePanelflag As Boolean = True

        If btnSlidePanel Is ABTNMAINHOME Then
            PNL_Home.Visible = True
            PNL_Home.BringToFront()
        Else
            PNL_Home.Visible = False
#Region "PURCHASE REQUEST"
            If btnSlidePanel Is ABTNSEL1 And V1VW_USERACCESSSUBTableAdapter.SQ_USERHASACCESSSUB(FRM_LOGIN.TXT_USERNAME.Text, 31, 43) > 0 And ABTNMAINCTR = 31 Then
                Dim newApp As Form = FRM_PR.OpenProgram(FRM_PR)
                APNLSHOWSEL.Visible = False
                newApp.Location = New Point(0, 0)
                newApp.MdiParent = Me
                newApp.Text = "Purchase Request"
                newApp.Show()
#End Region

#Region "CHECK PR"
            ElseIf btnSlidePanel Is ABTNSEL2 And V1VW_USERACCESSSUBTableAdapter.SQ_USERHASACCESSSUB(FRM_LOGIN.TXT_USERNAME.Text, 31, 44) > 0 And ABTNMAINCTR = 31 Then
                Dim newApp As Form = FRM_PR.OpenProgram(FRM_CHECK_PR)
                APNLSHOWSEL.Visible = False
                newApp.Location = New Point(0, 0)
                newApp.MdiParent = Me
                newApp.Text = "Check Purchase Request"
                newApp.Show()
#End Region

#Region "ABSTRACT OF QUOTATION"
            ElseIf btnSlidePanel Is ABTNSEL3 And V1VW_USERACCESSSUBTableAdapter.SQ_USERHASACCESSSUB(FRM_LOGIN.TXT_USERNAME.Text, 31, 45) > 0 And ABTNMAINCTR = 31 Then
                Dim newApp As Form = FRM_PR.OpenProgram(FRM_CHECK_PR)
                APNLSHOWSEL.Visible = False
                newApp.Location = New Point(0, 0)
                newApp.MdiParent = Me
                newApp.Text = "Abstract Of Quotation"
                newApp.Show()
#End Region

#Region "PURCHASE ORDER"
            ElseIf btnSlidePanel Is ABTNSEL3 And V1VW_USERACCESSSUBTableAdapter.SQ_USERHASACCESSSUB(FRM_LOGIN.TXT_USERNAME.Text, 31, 46) > 0 And ABTNMAINCTR = 31 Then
                Dim newApp As Form = FRM_PR.OpenProgram(FRM_PURCHASE_ORDER)
                APNLSHOWSEL.Visible = False
                newApp.Location = New Point(0, 0)
                newApp.MdiParent = Me
                newApp.Text = "Purchase Order"
                newApp.Show()
#End Region

#Region "INVENTORY ENCODING"
            ElseIf btnSlidePanel Is ABTNSEL1 And V1VW_USERACCESSSUBTableAdapter.SQ_USERHASACCESSSUB(FRM_LOGIN.TXT_USERNAME.Text, 33, 47) > 0 And ABTNMAINCTR = 33 Then
                Dim newApp As Form = FRM_INVENTORY_ENCODING.OpenProgram(FRM_INVENTORY_ENCODING)
                APNLSHOWSEL.Visible = False
                newApp.Location = New Point(0, 0)
                newApp.MdiParent = Me
                newApp.Text = "Inventory Encoding"
                newApp.Show()
#End Region

#Region "Print Sticker"
            ElseIf btnSlidePanel Is ABTNSEL2 And V1VW_USERACCESSSUBTableAdapter.SQ_USERHASACCESSSUB(FRM_LOGIN.TXT_USERNAME.Text, 33, 48) > 0 And ABTNMAINCTR = 33 Then
                Dim newApp As Form = FRM_STICKER_TAG.OpenProgram(FRM_STICKER_TAG)
                APNLSHOWSEL.Visible = False
                newApp.Location = New Point(0, 0)
                newApp.MdiParent = Me
                newApp.Text = "Print Sticker"
                newApp.Show()
#End Region

#Region "MAINTENANCE"
            ElseIf btnSlidePanel Is ABTNSEL3 And V1VW_USERACCESSSUBTableAdapter.SQ_USERHASACCESSSUB(FRM_LOGIN.TXT_USERNAME.Text, 33, 49) > 0 And ABTNMAINCTR = 33 Then
                Dim newApp As Form = FRM_SETTINGS.OpenProgram(FRM_SETTINGS)
                APNLSHOWSEL.Visible = False
                newApp.Location = New Point(0, 0)
                newApp.MdiParent = Me
                newApp.Text = "Inventory Maintenance"
                newApp.Show()
#End Region

            ElseIf btnSlidePanel Is ABTNLOGOUT Then
                If MsgBox("LOGGING OUT?" & vbNewLine & vbNewLine & "Do you want to close the program?", vbYesNo, "CONFIRM") = vbYes Then
                    Try
                        Me.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    Exit Sub
                End If
                btnSlidePanelflag = False
            Else
                MsgBox("YOU DO NOT HAVE PERMISSION TO ACCESS THIS MODULE", vbInformation, "USER ACCESS")
                btnSlidePanelflag = False
            End If


        End If
    End Sub

#End Region


#Region "MAIN SHOW SELECTION"
    Private Sub ABTN_MouseHover(sender As Object, e As EventArgs) Handles ABTNMAINHOME.MouseHover,
                                                                            ABTNSYSTEMADMIN.MouseHover,
                                                                            ABTNLOGOUT.MouseHover,
                                                                            ABTNMAINSUPPLIER.MouseHover,
                                                                            ABTNMAINREQUEST.MouseHover,
                                                                            ABTNMAININVENTORY.MouseHover

        Dim btnSlidePanel As Button = CType(sender, Button)
        APNLSHOWSEL.Visible = False
        If btnSlidePanel Is ABTNMAINHOME Then
            ABTNMAINCTR = 1
            If V1VW_USERACCESSMAINTableAdapter.SQ_IFUSERHASACCESSMAIN(FRM_LOGIN.TXT_USERNAME.Text, ABTNMAINCTR) > 0 Then
                '    ABTNSEL1.Text = "BUS (GENERAL)"
                '    ABTNSEL2.Text = "DV (GENERAL)"
                '    ABTNSEL3.Text = "SIGNATORY"
                '    APNLSHOWSEL.Height = 84
                '    APNLSHOWSEL.Visible = True
                '    APNLSHOWSEL.Location = New Point(38, 70)
            End If
            '  MsgBox("ABTNMAINHOME")
        ElseIf btnSlidePanel Is ABTNMAINREQUEST Then
            ABTNMAINCTR = 31
            If V1VW_USERACCESSMAINTableAdapter.SQ_IFUSERHASACCESSMAIN(FRM_LOGIN.TXT_USERNAME.Text, ABTNMAINCTR) > 0 Then
                ABTNSEL1.Text = "Purchase Request Encoding"
                ABTNSEL2.Text = "Check PR"
                '  ABTNSEL3.Text = "Purchase Order"
                APNLSHOWSEL.Height = 57
                '     APNLSHOWSEL.Height = 85
                '  APNLSHOWSEL.Height = 85
                APNLSHOWSEL.Visible = True
                APNLSHOWSEL.Location = New Point(39, 203)

            End If
        ElseIf btnSlidePanel Is ABTNMAINSUPPLIER Then
            If V1VW_USERACCESSMAINTableAdapter.SQ_IFUSERHASACCESSMAIN("von0030", ABTNMAINCTR) > 0 Then
                ABTNSEL1.Text = "Supplier's Info"
                ABTNSEL2.Text = "Delivery Receipt"
                ABTNSEL3.Text = "Invoice"
                APNLSHOWSEL.Height = 85
                APNLSHOWSEL.Visible = True
                APNLSHOWSEL.Location = New Point(39, 262)
            End If
        ElseIf btnSlidePanel Is ABTNMAININVENTORY Then
            ABTNMAINCTR = 33
            If V1VW_USERACCESSMAINTableAdapter.SQ_IFUSERHASACCESSMAIN(FRM_LOGIN.TXT_USERNAME.Text, ABTNMAINCTR) > 0 Then
                ABTNSEL1.Text = "Inventory Encoding"
                ABTNSEL2.Text = "Print Sticker"
                ABTNSEL3.Text = "Categorization"
                APNLSHOWSEL.BringToFront()
                APNLSHOWSEL.Height = 85
                APNLSHOWSEL.Visible = True
                APNLSHOWSEL.Location = New Point(39, 350)
            End If
        Else
            APNLSHOWSEL.Visible = False
        End If
    End Sub

    Private Sub APNLSHOWSEL_MouseLeave(sender As Object, e As EventArgs) Handles APNLSHOWSEL.MouseLeave
        APNLSHOWSEL.Visible = False
    End Sub
#End Region

    Private Sub MDI_Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TMR_MDIMAIN.Start()
    End Sub

    Private Sub MDI_Mainform_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            TblV1_USERACCOUNTLOGSTableAdapter.IQ_USERACCOUNTLOGS(FRM_LOGIN.TXT_USERNAME.Text, "IP ADDRESS: " & Net.Dns.GetHostEntry(Net.Dns.GetHostName).AddressList(0).ToString() & "  MACHINE: " & Net.Dns.GetHostName, False)
            TblV1_USERACCOUNTTableAdapter.UQ_USERLOGSTATUS(0, Trim(FRM_LOGIN.TXT_USERNAME.Text))
            'TblV1_USERACCOUNTTableAdapter.UQ_ACTIVATE_REALTIME(10)
            FRM_LOGIN.TXT_USERNAME.Clear()
            FRM_LOGIN.TXT_PASSWORD.Clear()
            FRM_LOGIN.Show()
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "MDI_Mainform ERROR - Me.Closing")
            NotificationManager.Show(Me, "AN ERROR OCCURED PLEASE CONTACT SYSTEM DEVELOPER!" & vbNewLine & My.Settings.PRADEV, Color.Red, 3000)
        End Try
    End Sub

    Private Sub TMR_MDIMAIN_Tick(sender As Object, e As EventArgs) Handles TMR_MDIMAIN.Tick
        Try
            LBLShowTime.Text = TblV1_USERACCOUNTTableAdapter.SP_SQ_SYSCURDATE()
            '   LBL_EXRATE.Text = TblV2_FINEXCHANGERATETableAdapter.GetExchangeRate()
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "MDI_Mainform ERROR - TMR_MDIMAIN.Tick")
            NotificationManager.Show(Me, "AN ERROR OCCURED PLEASE CONTACT SYSTEM DEVELOPER!" & vbNewLine & My.Settings.PRADEV, Color.Red, 3000)
            Me.Close()
        End Try
    End Sub
End Class
