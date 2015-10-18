Public Class Endlich

    Dim Geo_Reihe As List(Of Double)

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Close()
    End Sub

    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        If Not isAValied() And Not isQValied() And Not isDeltaValied() Then
            Exit Sub
        End If
        Geo_Reihe = New List(Of Double)

        Dim a_int As Integer = Integer.Parse(TextBox_Faktor_a.Text)
        Dim q_int As Integer = Integer.Parse(TextBox_Faktor_q.Text)
        Dim Iter_int As Integer = Integer.Parse(TextBox_Iteration.Text)

        If q_int = 1 Then
            For i As Integer = 1 To Iter_int
                Dim sn As Double = a_int * (i + 1)
                Geo_Reihe.Add(sn)
            Next
        Else
            For i As Integer = 0 To Integer.Parse(TextBox_Iteration.Text)
                Dim sn As Double = a_int * (Math.Pow(q_int, i + 1) - 1) / (q_int - 1)
                Geo_Reihe.Add(sn)
            Next
        End If

        MsgBox("Fertig")


    End Sub

    Function isAValied() As Boolean
        If Not IsNumeric(TextBox_Faktor_a.Text) Then
            MsgBox("a muss eine Zahl sein")
            Return False
        Else
            Dim a_int As Integer = Integer.Parse(TextBox_Faktor_a.Text)
            If (a_int <> 0) Then
                Return True
            Else
                MsgBox("a muss ungleich 0 sein")
                Return False
            End If
        End If

    End Function

    Function isQValied() As Boolean
        If Not IsNumeric(TextBox_Faktor_q.Text) Then
            MsgBox("q muss eine Zahl sein")
            Return False
        Else
            Return True
        End If
    End Function

    Function isDeltaValied() As Boolean
        If Not IsNumeric(TextBox_Iteration.Text) Then
            MsgBox("Die Anzahl der Iterationen muss eine Zahl sein")
            Return False
        Else
            Dim Iter_int As Integer = Integer.Parse(TextBox_Iteration.Text)
            If (Iter_int > 1) Then
                Return True
            Else
                MsgBox("Die Anzahl der Iterationen muss größer als 0 sein")
                Return False
            End If
        End If
    End Function

End Class