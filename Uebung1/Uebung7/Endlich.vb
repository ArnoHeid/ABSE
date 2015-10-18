Public Class Endlich
    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        Me.Close()
    End Sub

    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        If Not isAValied() Then

        ElseIf Not isQValied() Then

        ElseIf Not isDeltaValied() Then


        End If


        For i As Integer = 1 To 2

        Next
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
        If Not IsNumeric(TextBox_Faktor_a.Text) Then
            MsgBox("a muss eine Zahl sein")
            Return False
        Else
            Dim a_int As Integer = Integer.Parse(TextBox_Faktor_a.Text)
            If (a_int > 1) Then
                Return True
            Else
                MsgBox("a muss größer als 1 sein")
                Return False
            End If
        End If

    End Function

    Function isDeltaValied() As Boolean

    End Function

End Class