Imports Uebung6

Public Interface ICodeString
    Function code(value As String, a As Integer, b As Integer, c As Integer) As String
    Function decode(value As String, a As Integer, b As Integer, c As Integer) As String
End Interface


Public Class CodeOffset
    Implements ICodeString

    Public Function code(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.code
        Dim codedString As String = ""
        For Each ch As Char In value
            Dim Char_Asci As Integer = Asc(ch)
            Char_Asci += a
            If Char_Asci > 255 Then
                Char_Asci = Char_Asci Mod 255
            End If
            codedString = codedString & Chr(Char_Asci)
        Next
        Return codedString


    End Function

    Public Function decode(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.decode
        Dim codedString As String = ""
        For Each ch As Char In value
            Dim Char_Asci As Integer = Asc(ch)
            Char_Asci -= a
            While Char_Asci < 0
                Char_Asci = Char_Asci + 255
            End While
            codedString = codedString & Chr(Char_Asci)
        Next
        Return codedString

    End Function
End Class

Public Class CodeOffsetAndMulti
    Implements ICodeString

    Public Function code(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.code
        Dim codedString As String = ""
        For Each ch As Char In value
            Dim Char_Asci As Integer = Asc(ch)
            Char_Asci = b * Char_Asci + a
            If Char_Asci > 255 Then
                Char_Asci = Char_Asci Mod 255
            End If
            codedString = codedString & Chr(Char_Asci)
        Next
        Return codedString

    End Function

    Public Function decode(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.decode
        Dim codedString As String = ""
        For Each ch As Char In value
            Dim Char_Asci As Integer = Asc(ch)
            Char_Asci = CInt((Char_Asci - a) / b)
            While Char_Asci < 0
                Char_Asci = Char_Asci + 255
            End While
            codedString = codedString & Chr(Char_Asci)
        Next
        Return codedString
    End Function
End Class

Public Class CodeBitshift
    Implements ICodeString

    Public Function code(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.code
        Throw New NotImplementedException()
    End Function

    Public Function decode(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.decode
        Throw New NotImplementedException()
    End Function
End Class

Public Class CodeBitInvert
    Implements ICodeString

    Public Function code(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.code
        Throw New NotImplementedException()
    End Function

    Public Function decode(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.decode
        Throw New NotImplementedException()
    End Function

End Class