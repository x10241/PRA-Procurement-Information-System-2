Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices

Public Module TextBoxExtensions

    Private Const ECM_FIRST As UInteger = &H1500
    Private Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1

    <DllImport("user32.dll", EntryPoint:="SendMessageW")>
    Private Function SendMessageW(hWnd As IntPtr, Msg As UInt32, wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As IntPtr
    End Function

    <Extension()>
    Public Sub SetWaterMark(tb As TextBox, watermark As String)
        SendMessageW(tb.Handle, EM_SETCUEBANNER, 0, watermark)
    End Sub

End Module