Public Class Endlich

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Visible = False
    End Sub

    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        If Not isAValied() And Not isQValied() And Not isDeltaValied() Then
            Exit Sub
        End If
        Dim Geo_Reihe = New List(Of Double)

        Dim a_D As Double
        Dim q_D As Double
        Dim Iter_int As Integer

        Try
            a_D = Double.Parse(TextBox_Faktor_a.Text)
            q_D = Double.Parse(TextBox_Faktor_q.Text)
            Iter_int = Integer.Parse(TextBox_Iteration.Text)

        Catch ex As Exception
            MsgBox("Fehler in der Eingabe")
        End Try

        Try
            If q_D = 1 Then
                For i As Integer = 1 To Iter_int
                    Dim sn As Double = a_D * (i + 1)
                    Geo_Reihe.Add(sn)
                Next
            Else
                For i As Integer = 0 To Integer.Parse(TextBox_Iteration.Text)
                    Dim sn As Double = a_D * (Math.Pow(q_D, i + 1) - 1) / (q_D - 1)
                    Geo_Reihe.Add(sn)
                Next
            End If
        Catch ex As Exception
            MsgBox("Fehler in der Reihen beerechnung")
        End Try


        DirectCast(Me.Owner, Form1).setResult(Geo_Reihe)

        MsgBox("Fertig")
    End Sub

    Function isAValied() As Boolean
        fixTextBox(TextBox_Faktor_a)
        If Not IsNumeric(TextBox_Faktor_a.Text) Then
            MsgBox("a muss eine Zahl sein")
            Return False
        Else
            Dim a_int As Double = Double.Parse(TextBox_Faktor_a.Text)
            If (a_int <> 0) Then
                Return True
            Else
                MsgBox("a muss ungleich 0 sein")
                Return False
            End If
        End If

    End Function

    Function isQValied() As Boolean
        fixTextBox(TextBox_Faktor_q)
        If Not IsNumeric(TextBox_Faktor_q.Text) Then
            MsgBox("q muss eine Zahl sein")
            Return False
        Else
            Return True
        End If
    End Function

    Function isDeltaValied() As Boolean
        fixTextBox(TextBox_Iteration)
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

    Sub fixTextBox(tBox As TextBox)
        tBox.Text = tBox.Text.Replace(".", ",")
    End Sub

End Class