Imports Uebung6

Public Interface ICodeString
    Function code(value As String) As String
    Function decode(value As String) As String
End Interface


Public Class Offset
    Implements ICodeString

    Public Function code(value As String) As String Implements ICodeString.code
        Throw New NotImplementedException()
    End Function

    Public Function decode(value As String) As String Implements ICodeString.decode
        Throw New NotImplementedException()
    End Function
End Class