Imports MathNet.Numerics.LinearAlgebra
Imports Project

Public Class Helmert2D

    Inherits ITransformation


    Public Overrides Sub generate(Ausgangssystem As Koordinaten, Zielsystem As Koordinaten)
        If Ausgangssystem.Typ <> 2 And Zielsystem.Typ <> 2 Then
            Throw New Exception("Koordinatensystem sind nicht gleich, oder sind keine 2D Systeme")
            Exit Sub
        End If

        Dim AList As New List(Of Double())
        Dim lList As New List(Of Double)
        PointsToTransform = New Koordinaten(2)
        Dim ZielPass As New Koordinaten(2)
        Dim AusgangPass As New Koordinaten(2)

        For Each k As Koordinate In Ausgangssystem.KoordinatenListe
            Dim ko As List(Of Koordinate) = Zielsystem.KoordinatenListe.FindAll(Function(x) (x.Contains(k.PunktNr)))
            If ko.Count > 1 Then
                Throw New Exception("Punktnummer Doppelt!")
            ElseIf ko.Count = 1 Then
                ZielPass.add(ko(0))
                AusgangPass.add(k)
                Passpunkte.Add(k.PunktNr)
            ElseIf ko.Count = 0 Then
                PointsToTransform.add(k)
            End If
        Next

        ZielPass.calculateCenter()
        ZielPass.reduceCenter()
        AusgangPass.calculateCenter()
        AusgangPass.reduceCenter()

        For Each k As Koordinate In PointsToTransform.KoordinatenListe
            k.X -= AusgangPass.XCenter
            k.Y -= AusgangPass.YCenter
        Next


        For i As Integer = 0 To ZielPass.KoordinatenListe.Count - 1
            AList.Add({AusgangPass.KoordinatenListe(i).X, -AusgangPass.KoordinatenListe(i).Y, 1, 0})
            AList.Add({AusgangPass.KoordinatenListe(i).Y, AusgangPass.KoordinatenListe(i).X, 0, 1})
            lList.Add(ZielPass.KoordinatenListe(i).X)
            lList.Add(ZielPass.KoordinatenListe(i).Y)
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


        transform()

        TMatrix = Matrix(Of Double).Build.DenseOfArray({{u_Vektor(0), -u_Vektor(1)}, {u_Vektor(1), u_Vektor(0)}})

        TVektor = Vector(Of Double).Build.DenseOfArray({u_Vektor(2) + ZielPass.XCenter, u_Vektor(3) + ZielPass.YCenter})

    End Sub

    Public Overrides Function getResiduen() As Koordinaten
        Dim Residuen As New Koordinaten(2)
        Dim vVector As Vector(Of Double) = A_Matrix.Multiply(u_Vektor).Add(l_Vektor.Negate)
        For i As Integer = 0 To vVector.Count - 1 Step 2
            Residuen.add(Passpunkte(CInt(Fix(i / 2))), vVector(i), vVector(i + 1))
        Next
        Return Residuen
    End Function

    Public Overrides Function getTyp() As Byte
        Return 2
    End Function



End Class
