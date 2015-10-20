Public Class Koordinaten
    Private KoordinatenNr As Integer
    Private XKoordinate As Double
    Private YKoordinate As Double
    Private ZKoordinate As Double

    Sub New(Nr As Integer, x As Double, y As Double, z As Double)
        KoordinatenNr = Nr
        XKoordinate = x
        YKoordinate = y
        ZKoordinate = z
    End Sub

    Friend Function GetNr() As Integer
        Return KoordinatenNr
    End Function

    Friend Function GetX() As Double
        Return XKoordinate
    End Function

    Friend Function GetY() As Double
        Return YKoordinate
    End Function

    Friend Function GetZ() As Double
        Return ZKoordinate
    End Function
End Class
