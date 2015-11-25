Imports Project
Imports MathNet.Numerics.LinearAlgebra
Public MustInherit Class ITransformation

    Private _AMatrix As Matrix(Of Double)
    Private _lVektor As Vector(Of Double)
    Private _uVektor As Vector(Of Double)
    Private _PointsToTransform As Koordinaten
    Private _TMatrix As Matrix(Of Double)
    Private _TVektor As Vector(Of Double)

    Public Property A_Matrix As Matrix(Of Double)
        Get
            Return _AMatrix
        End Get
        Set(value As Matrix(Of Double))
            _AMatrix = value
        End Set
    End Property

    Public Property l_Vektor As Vector(Of Double)
        Get
            Return _lVektor
        End Get
        Set(value As Vector(Of Double))
            _lVektor = value
        End Set
    End Property

    Public Property u_Vektor As Vector(Of Double)
        Get
            Return _uVektor
        End Get
        Set(value As Vector(Of Double))
            _uVektor = value
        End Set
    End Property


    Public Property TMatrix As Matrix(Of Double)
        Get
            Return _TMatrix
        End Get
        Set(value As Matrix(Of Double))
            _TMatrix = value
        End Set
    End Property

    Public Property TVektor As Vector(Of Double)
        Get
            Return _TVektor
        End Get
        Set(value As Vector(Of Double))
            _TVektor = value
        End Set
    End Property

    Public Property PointsToTransform As Koordinaten
        Get
            Return _PointsToTransform
        End Get
        Set(value As Koordinaten)
            _PointsToTransform = value
        End Set
    End Property

    Sub transform()
        u_Vektor = A_Matrix.TransposeThisAndMultiply(A_Matrix).Inverse().Multiply(A_Matrix.Transpose).Multiply(l_Vektor)
    End Sub
    MustOverride Sub generate(Ausgangssystem As Koordinaten, Zielsystem As Koordinaten)


    Function getStatistic() As String
        Dim Report As String = ""
        Dim vVector As Vector(Of Double) = _AMatrix.Multiply(_uVektor).Add(_lVektor.Negate)

        Report += "Restklaffen Vektor" + vbCrLf
        Report += vVector.ToString + vbCrLf

        Return Report
    End Function
    Public MustOverride Function getTyp() As Byte

    Public Function transformPoins() As Koordinaten

        Dim resultKoordinaten As Koordinaten

        If getTyp() = 2 Then
            resultKoordinaten = New Koordinaten(2)

            For Each k As Koordinate In PointsToTransform.KoordinatenListe

                Dim tmp_vec As Vector(Of Double) = Vector(Of Double).Build.DenseOfArray({k.X, k.Y})


                Dim resultVektors As Vector(Of Double) = TMatrix.Multiply(tmp_vec).Add(TVektor)

                resultKoordinaten.add(k.PunktNr, resultVektors(0), resultVektors(1))

            Next
        ElseIf getTyp() = 3
            resultKoordinaten = New Koordinaten(3)

            For Each k As Koordinate In PointsToTransform.KoordinatenListe

                Dim tmp_vec As Vector(Of Double) = Vector(Of Double).Build.DenseOfArray({k.X, k.Y, k.Z})


                Dim resultVektors As Vector(Of Double) = TMatrix.Multiply(tmp_vec).Add(TVektor)

                resultKoordinaten.add(k.PunktNr, resultVektors(0), resultVektors(1), resultVektors(2))

            Next
        End If

        Return resultKoordinaten
    End Function

End Class
