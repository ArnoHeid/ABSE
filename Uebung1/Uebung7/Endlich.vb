Public Class Endlich
    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Close()
    End Sub

    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        If Not isAValied() And Not isQValied() And Not isDeltaValied() Then
            Exit Sub
        End If

        Dim a_int As Integer = Integer.Parse(TextBox_Faktor_a.Text)
        Dim q_int As Integer = Integer.Parse(TextBox_Faktor_q.Text)
        Dim Iter_int As Integer = Integer.Parse(TextBox_Iteration.Text)

        If q_int = 1 Then
            For i As Integer = 1 To Iter_int
                Dim sn As Double = q_int * (i + 1)

            Next
        Else
            For i As Integer = 1 To Integer.Parse(TextBox_Iteration.Text)
                Dim sn As Double = q_int * (Math.Pow(q_int, i + 1) - 1) / (q_int - 1)

            Next
        End If



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