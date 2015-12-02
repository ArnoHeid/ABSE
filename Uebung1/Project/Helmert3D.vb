Imports MathNet.Numerics.LinearAlgebra
Imports Project

Public Class Helmert3D
    Inherits ITransformation

    Public Overrides Sub generate(Ausgangssystem As Koordinaten, Zielsystem As Koordinaten)
        If Ausgangssystem.Typ <> 3 And Zielsystem.Typ <> 3 Then
            Throw New Exception("Koordinatensystem sind nicht gleich, oder sind keine 2D Systeme")
            Exit Sub
        End If

        Dim AList As New List(Of Double())
        Dim lList As New List(Of Double)
        PointsToTransform = New Koordinaten(3)
        Dim ZielPass As New Koordinaten(3)
        Dim AusgangPass As New Koordinaten(3)

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
            AList.Add({0, -AusgangPass.KoordinatenListe(i).Z, AusgangPass.KoordinatenListe(i).Y, AusgangPass.KoordinatenListe(i).X, 1, 0, 0})
            AList.Add({AusgangPass.KoordinatenListe(i).Z, 0, -AusgangPass.KoordinatenListe(i).X, AusgangPass.KoordinatenListe(i).Y, 0, 1, 0})
            AList.Add({-AusgangPass.KoordinatenListe(i).Y, AusgangPass.KoordinatenListe(i).X, 0, AusgangPass.KoordinatenListe(i).Z, 0, 0, 1})

            lList.Add(ZielPass.KoordinatenListe(i).X)
            lList.Add(ZielPass.KoordinatenListe(i).Y)
            lList.Add(ZielPass.KoordinatenListe(i).Z)
        Next



        l_Vektor = Vector(Of Double).Build.DenseOfArray(lList.ToArray)

        Dim AArray(AList.Count - 1, 6) As Double

        For i As Integer = 0 To AList.Count - 1
            AArray(i, 0) = AList(i)(0)
            AArray(i, 1) = AList(i)(1)
            AArray(i, 2) = AList(i)(2)
            AArray(i, 3) = AList(i)(3)
            AArray(i, 4) = AList(i)(4)
            AArray(i, 5) = AList(i)(5)
            AArray(i, 6) = AList(i)(6)

        Next

        A_Matrix = Matrix(Of Double).Build.DenseOfArray(AArray)


        transform()

        TMatrix = Matrix(Of Double).Build.DenseOfArray({{u_Vektor(0), -u_Vektor(1)}, {u_Vektor(1), u_Vektor(0)}})

        TVektor = Vector(Of Double).Build.DenseOfArray({u_Vektor(2) + ZielPass.XCenter, u_Vektor(3) + ZielPass.YCenter})

    End Sub

    Public Overrides Function getResiduen() As Koordinaten
        Throw New NotImplementedException()
    End Function

    Public Overrides Function getTyp() As Byte
        Return 3
    End Function

End Class
