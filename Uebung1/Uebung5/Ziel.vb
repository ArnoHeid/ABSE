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

    Public Function getPreis(Typ As Integer, Fahrer As Integer) As Double

        'Unterscheidung der Fahrer
        Dim Preis As Double
        If Fahrer = 0 Then
            Preis = 0.5 * Me.Preis
        ElseIf Fahrer = 2 Then
            Preis = 0.75 * Me.Preis
        ElseIf Fahrer = 3 Then
            Preis = 0
        ElseIf Fahrer = 4 Then
            Preis = 1.25 * Me.Preis
        ElseIf Fahrer = 5 Then
            Preis = 0.25 * Me.Preis
        Else
            Preis = Me.Preis
        End If

        'Unterscheidung Karten Typ
        If Typ = 0 Then
            Preis = Preis
        ElseIf Typ = 1 Then
            Preis = 2 * Preis
        ElseIf Typ = 2 Then
            Preis = 3 * Preis
        ElseIf Typ = 3 Then
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
            Dim value_int As Integer = Integer.Parse(value)
            Dim Value_count = CountInt(value_int)
            Dim Code_count = CountInt(Code)
            If (Value_count > Code_count) Then
                Return False
            Else
                Dim code_kurz As Integer = CInt(Code / Math.Pow(10, Code_count - Value_count))
                Return value_int = code_kurz
            End If
        Else
            Dim Name_Kurz As String
            Name_Kurz = UCase(Name.Substring(0, value.Length))
            Return UCase(value).Equals(Name_Kurz)
        End If

    End Function

    Private Function CountInt(value As Integer) As Integer
        Dim value_String As String = value.ToString
        Return value_String.Length

    End Function






End Class
