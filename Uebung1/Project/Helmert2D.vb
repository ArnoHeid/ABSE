Imports MathNet.Numerics.LinearAlgebra
Imports Project

Public Class Helmert2D
    Implements ITransformation

    Public Property A_Matrix As Matrix(Of Double) Implements ITransformation.A_Matrix
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Matrix(Of Double))
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property l_Vektor As Vector(Of Double) Implements ITransformation.l_Vektor
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Vector(Of Double))
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property u_Vektor As Vector(Of Double) Implements ITransformation.u_Vektor
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Vector(Of Double))
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub transform() Implements ITransformation.transform

        u_Vektor = A_Matrix.TransposeThisAndMultiply(A_Matrix).Inverse().TransposeAndMultiply(A_Matrix).Multiply(l_Vektor)

    End Sub
End Class
