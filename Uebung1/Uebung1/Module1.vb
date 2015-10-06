Imports System.Console

Module Module1

    Sub Main()

        Dim name As String
        Dim matNr As String

        WriteLine("Hallo lieber Benutzer, bitte geben sie Ihren Namen ein.")
        name = ReadLine()
        WriteLine("Bitte geben sie nun Ihre Martrikelnummer ein")
        matNr = ReadLine()
        WriteLine("Liebe(r) " & name & " deine Matrikelnummer ist: " & matNr)
        WriteLine("Danke für die Info")
        ReadLine()


    End Sub

End Module
