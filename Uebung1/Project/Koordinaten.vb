Imports Project

Public Class Koordinaten

    Private _Typ As Byte
    Private _KoordinatenListe As List(Of Koordinate)

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
#End Region

    Public Sub add(PunktNr As Integer, x As Double, y As Double)
        _KoordinatenListe.Add(New Koordinate(PunktNr, x, y))
    End Sub
    Public Sub add(PunktNr As Integer, x As Double, y As Double, z As Double)
        _KoordinatenListe.Add(New Koordinate(PunktNr, x, y, z))
    End Sub




End Class
