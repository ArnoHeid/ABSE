Imports Project

Public Class Helmert3D
    Inherits ITransformation

    Public Overrides Sub generate(Ausgangssystem As Koordinaten, Zielsystem As Koordinaten)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function getTyp() As Byte
        Return 3
    End Function

End Class
