
Namespace RimsClass

#Region "FROM FILE"

    Public Class FFILE
        Public Function FILEENCRYPT(ByVal FilePath As String) As String
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(FilePath & "\error.text")
            Dim str As String
            Dim sec As New SECURITY
            Do
                str = sec.ENCRYPT(sr.ReadLine)
            Loop Until sr.ReadLine Is Nothing
            sr.Close()
            sr = Nothing
            Return str
        End Function
    End Class

#End Region

#Region "ENCRYPTION"
    Public Class SECURITY
        Public Function ENCRYPT(ByVal Text As String) As String
            ' Encrypts/decrypts the passed string using 
            ' a simple ASCII value-swapping algorithm
            Dim TempChar As String = ""
            Dim x As Integer
            For x = 1 To Len(Text)
                If Asc(Mid$(Text, x, 1)) < 128 Then
                    TempChar = CType(Asc(Mid$(Text, x, 1)) + 128, String)
                ElseIf Asc(Mid$(Text, x, 1)) > 128 Then
                    TempChar = CType(Asc(Mid$(Text, x, 1)) - 128, String)
                End If
                Mid$(Text, x, 1) = Chr(CType(TempChar, Integer))
            Next x
            Return Text
        End Function
    End Class

#End Region

End Namespace