Imports Uebung9

Public Class Adressen
    Implements IComparable
    Private Shared ID_Count As Integer = 1


    Private ReadOnly _ID As Integer
    Private _Vorname As String
    Private _Nachname As String
    Private _PLZ As String
    Private _Stadt As String
    Private _Strasse As String
    Private _HausNr As String

#Region "Setter Getter Constructor"

    Sub New(Vorname As String, Nachname As String, PLZ As String, Stadt As String, Strasse As String, HausNr As String)
        _ID = ID_Count
        ID_Count += 1
        _Vorname = Vorname
        _Nachname = Nachname
        _PLZ = PLZ
        _Stadt = Stadt
        _Strasse = Strasse
        _HausNr = HausNr

    End Sub


    Public ReadOnly Property ID() As Integer
        Get
            Return _ID
        End Get
    End Property

    Public Property Vorname As String
        Get
            Return _Vorname
        End Get
        Set(value As String)
            _Vorname = value
        End Set
    End Property

    Public Property Nachname As String
        Get
            Return _Nachname
        End Get
        Set(value As String)
            _Nachname = value
        End Set
    End Property

    Public Property PLZ As String
        Get
            Return _PLZ
        End Get
        Set(value As String)
            If value.Count = 5 Then
                _PLZ = value
            End If
        End Set
    End Property

    Public Property Stadt As String
        Get
            Return _Stadt
        End Get
        Set(value As String)
            _Stadt = value
        End Set
    End Property

    Public Property Strasse As String
        Get
            Return _Strasse
        End Get
        Set(value As String)
            _Strasse = value
        End Set
    End Property

    Public Property HausNr As String
        Get
            Return _HausNr
        End Get
        Set(value As String)
            _HausNr = value
        End Set
    End Property

#End Region

    Public Function getExport() As String
        Return _Vorname & " " & _Nachname & " " & _PLZ.ToString & " " & _Stadt & " " & _Strasse & " " & _HausNr.ToString
    End Function



    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return String.Compare(Me._Nachname, CType(obj, Adressen)._Nachname)
    End Function

    Public Function contains(Value As String) As Boolean
        Return Nachname.Contains(Value)
    End Function

End Class
