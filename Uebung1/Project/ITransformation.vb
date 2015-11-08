Imports Project
Imports MathNet.Numerics.LinearAlgebra
Public Interface ITransformation

    Property A_Matrix As Matrix(Of Double)
    Property l_Vektor As Vector(Of Double)
    Property u_Vektor As Vector(Of Double)

    Sub transform()

End Interface
