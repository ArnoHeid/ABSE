Public Class Ziel

    Private Name As String
    Private Code As Integer
    Private Preis As Double

    Sub New(Name As String, Code As Integer, Preis As Double)
        Me.Name = Name
        Me.Code = Code
        Me.Preis = Preis
    End Sub

    Public Function getName() As String
        Return Name
    End Function

    Public Function getCode() As Integer

        Return Code
    End Function

    Public Function getPreis(Typ As String, Fahrer As String) As Double

        'Unterscheidung der Fahrer
        Dim Preis As Double
        If String.Compare(Fahrer, "Kind") = 0 Then
            Preis = 0.5 * Me.Preis
        ElseIf String.Compare(Fahrer, "Azubi") = 0 Then
            Preis = 0.75 * Me.Preis
        ElseIf String.Compare(Fahrer, "SchwerBe") = 0 Then
            Preis = 0
        ElseIf String.Compare(Fahrer, "Fahrrad") = 0 Then
            Preis = 1.25 * Me.Preis
        ElseIf String.Compare(Fahrer, "Hund") = 0 Then
            Preis = 0.25 * Me.Preis
        Else
            Preis = Me.Preis
        End If

        'Unterscheidung Karten Typ
        If String.Compare(Typ, "Einfach") = 0 Then
            Preis = Preis
        ElseIf String.Compare(Typ, "HinRueck") = 0 Then
            Preis = 2 * Preis
        ElseIf String.Compare(Typ, "Tages") = 0 Then
            Preis = 3 * Preis
        ElseIf String.Compare(Typ, "Gruppe") = 0 Then
            Preis = 4 * Preis
        Else    'Wochen Karte
            Preis = 5 * Preis
        End If

        Return Preis

    End Function

    Overrides Function toString() As String
        Return Name & " (" & Code & ")"
    End Function

    Function isFitting(value As String) As Boolean
        If IsNumeric(value) Then


        Else
            Dim Name_Kurz As String
            Name_Kurz = UCase(Name.Substring(0, value.Length))
            Return UCase(value).Equals(Name_Kurz)
        End If



    End Function




End Class
