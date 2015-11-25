Imports Project

Public Class Koordinaten

    Private _Typ As Byte
    Private _KoordinatenListe As List(Of Koordinate)
    Private _xCenter As Double
    Private _yCenter As Double
    Private _zCenter As Double
    Private _Passpunkte As Integer

#Region "Getter Setter"

    Public Sub New(Typ As Byte)
        _Typ = Typ
        _KoordinatenListe = New List(Of Koordinate)
    End Sub

    Public Property Typ As Byte
        Get
            Return _Typ
        End Get
        Set(value As Byte)
            _Typ = value
        End Set
    End Property

    Public Property KoordinatenListe As List(Of Koordinate)
        Get
            Return _KoordinatenListe
        End Get
        Set(value As List(Of Koordinate))
            _KoordinatenListe = value
        End Set
    End Property

    Public Property XCenter As Double
        Get
            Return _xCenter
        End Get
        Set(value As Double)
            _xCenter = value
        End Set
    End Property

    Public Property YCenter As Double
        Get
            Return _yCenter
        End Get
        Set(value As Double)
            _yCenter = value
        End Set
    End Property

    Public Property ZCenter As Double
        Get
            Return _zCenter
        End Get
        Set(value As Double)
            _zCenter = value
        End Set
    End Property

    Public Property Passpunkte As Integer
        Get
            Return _Passpunkte
        End Get
        Set(value As Integer)
            _Passpunkte = value
        End Set
    End Property
#End Region

    Public Sub add(PunktNr As Integer, x As Double, y As Double)
        _KoordinatenListe.Add(New Koordinate(PunktNr, x, y))
    End Sub

    Public Sub add(PunktNr As Integer, x As Double, y As Double, z As Double)
        _KoordinatenListe.Add(New Koordinate(PunktNr, x, y, z))
    End Sub

    Public Sub add(ByVal value As Koordinate)
        _KoordinatenListe.Add(value)
    End Sub

    Public Sub calculateCenter()
        XCenter = 0
        YCenter = 0
        ZCenter = 0
        For Each k As Koordinate In KoordinatenListe
            XCenter += k.X
            YCenter += k.Y
            If Typ = 3 Then
                ZCenter += k.Z
            End If

        Next

        XCenter /= KoordinatenListe.Count
        YCenter /= KoordinatenListe.Count
        ZCenter /= KoordinatenListe.Count

    End Sub

    Public Sub reduceCenter()
        For Each k As Koordinate In KoordinatenListe
            k.X -= XCenter
            k.Y -= YCenter
            If Typ = 3 Then
                k.Z -= ZCenter
            End If
        Next
    End Sub

    Public Sub fixCenter()
        For Each k As Koordinate In KoordinatenListe
            k.X += XCenter
            k.Y += YCenter
            If Typ = 3 Then
                k.Z += ZCenter
            End If
        Next
    End Sub
End Class
