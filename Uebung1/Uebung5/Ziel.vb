Public Class Ziel

    Private Name As String
    Private Code As Integer
    Private Preis As Double

    Sub New(Name As String, Code As Integer, Preis As Double)
        Me.Name = Name
        Me.Code = Code
        Me.Preis = Preis
    End Sub

    Public Function getName()
        Return Name
    End Function

    Public Function getCode()
        Return Code
    End Function

    Public Function getPreis(Typ As String, Fahrer As String)

        'Unterscheidung der Fahrer
        Dim Preis As Double
        If String.Compare(Fahrer, "Kind") Then
            Preis = 0.5 * Me.Preis
        ElseIf String.Compare(Fahrer, "Azubi") Then
            Preis = 0.75 * Me.Preis
        ElseIf String.Compare(Fahrer, "SchwerBe") Then
            Preis = 0
        ElseIf String.Compare(Fahrer, "Fahrrad") Then
            Preis = 1.25 * Me.Preis
        ElseIf String.Compare(Fahrer, "Hund") Then
            Preis = 0.25 * Me.Preis
        Else
            Preis = Me.Preis
        End If

        'Unterscheidung Karten Typ
        If String.Compare(Typ, "Einfach") Then
            Preis = Preis
        ElseIf String.Compare(Typ, "HinRueck") Then
            Preis = 2 * Preis
        ElseIf String.Compare(Typ, "Tages") Then
            Preis = 3 * Preis
        ElseIf String.Compare(Typ, "Gruppe") Then
            Preis = 4 * Preis
        Else    'Wochen Karte
            Preis = 5 * Preis
        End If

        Return Preis

    End Function



End Class
