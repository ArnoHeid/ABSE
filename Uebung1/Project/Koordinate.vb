
Public Class Koordinate

    Private _PunktNr As Integer
    Private _X As Double
    Private _Y As Double
    Private _Z As Double

#Region "Getter/Setter"

    Public Sub New(PunktNr As Integer, x As Double, y As Double)
        _PunktNr = PunktNr
        _X = x
        _Y = y

    End Sub

    Public Sub New(PunktNr As Integer, x As Double, y As Double, z As Double)
        _PunktNr = PunktNr
        _X = x
        _Y = y
        _Z = z
    End Sub

    Public Property PunktNr As Integer
        Get
            Return _PunktNr
        End Get
        Set(value As Integer)
            _PunktNr = value
        End Set
    End Property

    Public Property X As Double
        Get
            Return _X
        End Get
        Set(value As Double)
            _X = value
        End Set
    End Property

    Public Property Y As Double
        Get
            Return _Y
        End Get
        Set(value As Double)
            _Y = value
        End Set
    End Property

    Public Property Z As Double
        Get
            Return _Z
        End Get
        Set(value As Double)
            _Z = value
        End Set
    End Property
#End Region

    Public Function Contains(Value As Integer) As Boolean
        Return _PunktNr = Value
    End Function

End Class
