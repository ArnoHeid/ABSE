Imports MathNet.Numerics.LinearAlgebra
Imports Project

Public Class Helmert2D
    Implements ITransformation
    Private _AMatrix As Matrix(Of Double)
    Private _lVektor As Vector(Of Double)
    Private _uVektor As Vector(Of Double)
    Private _PointsToTransform As New List(Of Vector(Of Double))
    Private _TMatrix As Matrix(Of Double)
    Private _TVektor As Vector(Of Double)

    Public Property A_Matrix As Matrix(Of Double) Implements ITransformation.A_Matrix
        Get
            Return _AMatrix
        End Get
        Set(value As Matrix(Of Double))
            _AMatrix = value
        End Set
    End Property

    Public Property l_Vektor As Vector(Of Double) Implements ITransformation.l_Vektor
        Get
            Return _lVektor
        End Get
        Set(value As Vector(Of Double))
            _lVektor = value
        End Set
    End Property

    Public Property u_Vektor As Vector(Of Double) Implements ITransformation.u_Vektor
        Get
            Return _uVektor
        End Get
        Set(value As Vector(Of Double))
            _uVektor = value
        End Set
    End Property

    Public Sub generate(Ausgangssystem As Koordinaten, Zielsystem As Koordinaten) Implements ITransformation.generate
        If Ausgangssystem.Typ <> 2 And Zielsystem.Typ <> 2 Then
            Throw New Exception("Koordinatensystem sind nicht gleich, oder sind keine 2D Systeme")
        End If

        Dim AList As New List(Of Double())
        Dim lList As New List(Of Double)

        For Each k As Koordinate In Ausgangssystem.KoordinatenListe
            Dim ko As List(Of Koordinate) = Zielsystem.KoordinatenListe.FindAll(Function(x) (x.Contains(k.PunktNr)))
            If ko.Count > 1 Then
                Throw New Exception("Punktnummer Doppelt!")
            ElseIf ko.Count = 1 Then
                AList.Add({k.X, -k.Y, 1, 0})
                AList.Add({k.Y, k.X, 0, 1})
                lList.Add(ko(0).X)
                lList.Add(ko(0).Y)
            ElseIf ko.Count = 0 Then
                Dim tmp_vec As Vector(Of Double) = Vector(Of Double).Build.DenseOfArray({k.X, k.Y})
                _PointsToTransform.Add(tmp_vec)
            End If
        Next

        l_Vektor = Vector(Of Double).Build.DenseOfArray(lList.ToArray)

        Dim AArray(AList.Count - 1, 3) As Double

        For i As Integer = 0 To AList.Count - 1
            AArray(i, 0) = AList(i)(0)
            AArray(i, 1) = AList(i)(1)
            AArray(i, 2) = AList(i)(2)
            AArray(i, 3) = AList(i)(3)
        Next

        A_Matrix = Matrix(Of Double).Build.DenseOfArray(AArray)

        Console.WriteLine(A_Matrix)

        transform()

        _TMatrix = Matrix(Of Double).Build.DenseOfArray({{_uVektor(0), -_uVektor(1)}, {_uVektor(1), _uVektor(0)}})

        _TVektor = Vector(Of Double).Build.DenseOfArray({_uVektor(2), _uVektor(3)})



    End Sub

    Private Sub transform() Implements ITransformation.transform

        u_Vektor = A_Matrix.TransposeThisAndMultiply(A_Matrix).Inverse().Multiply(A_Matrix.Transpose).Multiply(l_Vektor)

    End Sub

    Public Function transformPoins() As List(Of Vector(Of Double)) Implements ITransformation.transformPoins
        Dim resultVektors As New List(Of Vector(Of Double))

        For Each vec As Vector(Of Double) In _PointsToTransform
            resultVektors.Add(_TMatrix.Multiply(vec).Add(_TVektor))
        Next

        Return resultVektors
    End Function

    Public Function getStatistic() As String Implements ITransformation.getStatistic
        Dim Report As String = ""
        Dim vVector As Vector(Of Double) = _AMatrix.Multiply(_uVektor).Add(_lVektor.Negate)
        Dim Stabwa As Double
        If (_lVektor.Count >= 4) Then
            Stabwa = Math.Sqrt(vVector.DotProduct(vVector) / (_lVektor.Count - 4))
        Else
            Stabwa = 0
        End If


        Report += "Restklaffen Vektor" + vbCrLf
        Report += vVector.ToString + vbCrLf
        Report += "Mittlere Standardabweichung" + vbCrLf
        Report += Stabwa.ToString("f2") + vbCrLf


        Return Report
    End Function

End Class
