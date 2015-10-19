Public Class Form1

    Dim Geo_Reihe As List(Of Double)

    Private Sub Button_Ende_Click(sender As Object, e As EventArgs) Handles Button_Ende.Click
        Me.Close()
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        TextBox_Result.Text = ""
        Geo_Reihe = New List(Of Double)
        If RadioButton_Endlich.Checked Then
            Dim Form_endlich As Endlich = New Endlich(TextBox_Result)
            Form_endlich.Show()
        ElseIf RadioButton_Unendlich.Checked
            Dim Form_unendlich As Unendlich = New Unendlich(TextBox_Result)
            Form_unendlich.Show()
        End If


    End Sub



End Class


' http://www.codeproject.com/Articles/14122/Passing-Data-Between-Forms