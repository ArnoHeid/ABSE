Public Class Form1
    Private Sub Button_Ende_Click(sender As Object, e As EventArgs) Handles Button_Ende.Click
        Me.Close()
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        If RadioButton_Endlich.Checked Then
            Dim Form_endlich As Endlich = New Endlich()
            Form_endlich.Show()
        ElseIf RadioButton_Unendlich.Checked
            Dim Form_unendlich As Unendlich = New Unendlich()
            Form_unendlich.Show()
        End If
    End Sub
End Class
