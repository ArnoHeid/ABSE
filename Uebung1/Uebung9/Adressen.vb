Imports Uebung9

Public Class Adressen
    Implements IComparable
    Private Shared ID_Count As Integer = 1
    Private _isValied As Boolean = True

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
        Me.Vorname = Vorname
        Me.Nachname = Nachname
        Me.PLZ = PLZ
        Me.Stadt = Stadt
        Me.Strasse = Strasse
        Me.HausNr = HausNr

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
            _Vorname = MakeFirstBig(value)
        End Set
    End Property

    Public Property Nachname As String
        Get
            Return _Nachname
        End Get
        Set(value As String)
            _Nachname = MakeFirstBig(value)
        End Set
    End Property

    Public Property PLZ As String
        Get
            Return _PLZ
        End Get
        Set(value As String)
            If value.Count = 5 And IsNumeric(value) Then
                _PLZ = value
                _isValied = True
            Else
                _isValied = False
            End If
        End Set
    End Property

    Public Property Stadt As String
        Get
            Return _Stadt
        End Get
        Set(value As String)
            _Stadt = MakeFirstBig(value)
        End Set
    End Property

    Public Property Strasse As String
        Get
            Return _Strasse
        End Get
        Set(value As String)
            _Strasse = MakeFirstBig(value)
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

    Public ReadOnly Property IsValied As Boolean
        Get
            If _isValied Then
                Return _isValied
            Else
                ID_Count -= 1
                Return _isValied
            End If

        End Get
    End Property

#End Region

    Public Function getExport() As String
        Return _Vorname & " " & _Nachname & " " & _PLZ.ToString & " " & _Stadt & " " & _Strasse & " " & _HausNr.ToString
    End Function



    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return String.Compare(Me._Nachname, CType(obj, Adressen)._Nachname)
    End Function

    Public Function contains(Value As String) As Boolean
        Return Nachname.Contains(Value) Or Vorname.Contains(Value)
    End Function

    Public Function MakeFirstBig(value As String) As String

        If value.Length > 0 Then
            Try
                Return value.Substring(0, 1).ToUpper & value.Substring(1, value.Length - 1).ToLower
            Catch ex As Exception
                Return value
            End Try

        End If

        Return value

    End Function

End Class
