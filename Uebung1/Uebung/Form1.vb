Public Class MainForm
    Private Sub Button_Ende_Click(sender As Object, e As EventArgs) Handles Button_Ende.Click
        Me.Close()
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click

    End Sub

    Private Sub GetAndSetTarget()
        If RadioButton_Datei.Checked Then
            TextBox_Target.Text = "Datei"
        ElseIf RadioButton_Drucker.Checked Then
            TextBox_Target.Text = "Drucker"
        ElseIf RadioButton_Monitor.Checked Then
            TextBox_Target.Text = "Monitor"
        End If
    End Sub

    Private Sub RadioButton_Datei_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Datei.CheckedChanged
        GetAndSetTarget()
    End Sub

    Private Sub RadioButton_Monitor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Monitor.CheckedChanged
        GetAndSetTarget()
    End Sub

    Private Sub RadioButton_Drucker_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Drucker.CheckedChanged
        GetAndSetTarget()
    End Sub
End Class
