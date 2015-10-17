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
                Char_Asci = Char_Asci Mod 256
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
                Char_Asci = Char_Asci + 256
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
            Char_Asci = (b * Char_Asci + a) Mod 256
            codedString = codedString & Chr(Char_Asci)
        Next
        If isParameterValied(b) Then
            Return codedString
        Else
            Return ""
        End If


    End Function

    Public Function decode(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.decode
        If isParameterValied(b) Then
            Dim decode_Dic As New Dictionary(Of Integer, Integer)
            For i As Integer = 0 To 255
                Dim dc_Int As Integer = (b * i + a) Mod 256
                decode_Dic.Add(dc_Int, i)
            Next
            Dim codedString As String = ""
            For Each ch As Char In value
                codedString = codedString & Chr(decode_Dic(Asc(ch)))
            Next
            Return codedString
        Else
            Return ""
        End If

    End Function

    Private Function isParameterValied(para As Integer) As Boolean

        If para Mod 2 = 0 Then
            MsgBox("Der Parameter b darf nicht Gerade sein")
            Return False
        End If
        Return True
    End Function

End Class

Public Class CodeBitshift
    Implements ICodeString

    Public Function code(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.code
        Dim codedString As String = ""
        Dim a_byte As Byte = Convert.ToByte(a)
        For Each ch As Char In value
            Dim chr_byte As Byte = Convert.ToByte(Asc(ch))
            codedString = codedString & Chr(rechtsShift(chr_byte, a_byte))
        Next
        Return codedString
    End Function

    Public Function decode(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.decode
        Dim codedString As String = ""
        Dim a_byte As Byte = Convert.ToByte(a)
        For Each ch As Char In value
            Dim chr_byte As Byte = Convert.ToByte(Asc(ch))
            codedString = codedString & Chr(linksShift(chr_byte, a_byte))
        Next
        Return codedString
    End Function

    Private Function rechtsShift(value As Byte, shift As Byte) As Byte
        Return CByte(value >> shift Or value << (8 - shift))
    End Function

    Private Function linksShift(value As Byte, shift As Byte) As Byte
        Return CByte(value << shift Or value >> (8 - shift))
    End Function

End Class

Public Class CodeBitInvert
    Implements ICodeString

    Public Function code(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.code
        Dim codedString As String = ""
        For Each ch As Char In value
            Dim Char_Asci As Integer = Asc(ch)
            Char_Asci = Char_Asci Xor 255
            If Char_Asci > 255 Then
                Char_Asci = Char_Asci Mod 256
            End If
            codedString = codedString & Chr(Char_Asci)
        Next
        Return codedString
    End Function

    Public Function decode(value As String, a As Integer, b As Integer, c As Integer) As String Implements ICodeString.decode
        Dim codedString As String = ""
        For Each ch As Char In value
            Dim Char_Asci As Integer = Asc(ch)
            Char_Asci = Char_Asci Xor 255
            If Char_Asci > 255 Then
                Char_Asci = Char_Asci Mod 256
            End If
            codedString = codedString & Chr(Char_Asci)
        Next
        Return codedString
    End Function

End Class