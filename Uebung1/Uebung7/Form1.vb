Public Class Form1

    Private Geo_Reihe As New List(Of Double)

    Private Sub Button_Ende_Click(sender As Object, e As EventArgs) Handles Button_Ende.Click
        Me.Close()
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        TextBox_Result.Text = ""
        'Geo_Reihe = New List(Of Double)
        If RadioButton_Endlich.Checked Then
            Dim Form_endlich As Endlich = New Endlich()
            Form_endlich.Owner = Me
            Form_endlich.Show()
        ElseIf RadioButton_Unendlich.Checked
            Dim Form_unendlich As Unendlich = New Unendlich()
            Form_unendlich.Owner = Me
            Form_unendlich.Show()
        End If

    End Sub

    Public Sub setResult(geoList As List(Of Double))
        If geoList IsNot Nothing Then
            Geo_Reihe = geoList
            For Each value As Double In Geo_Reihe
                TextBox_Result.Text = TextBox_Result.Text & value.ToString & vbCrLf
            Next

        End If
    End Sub

End Class


' http://www.codeproject.com/Articles/14122/Passing-Data-Between-Forms