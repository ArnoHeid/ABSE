Public Class MainForm
    Private Sub Button_Ende_Click(sender As Object, e As EventArgs) Handles Button_Ende.Click
        Me.Close()
    End Sub

    Private Sub Button_Start_Click(sender As Object, e As EventArgs) Handles Button_Start.Click
        MessageBox.Show(GenerateMessage())
    End Sub


    Private Function GenerateMessage() As String
        Dim myAL As New ArrayList()
        myAL.Add(CheckBox_PunktNr)
        myAL.Add(CheckBox_XKord)
        myAL.Add(CheckBox_YKord)
        myAL.Add(CheckBox_ZKord)

        Dim obj As Object
        Dim message As String
        message = "Ausgabe von "

        Dim isNotFirst As Boolean
        isNotFirst = False

        For Each obj In myAL
            Dim tbox As CheckBox
            tbox = CType(obj, CheckBox)
            If tbox.Checked Then
                If isNotFirst Then
                    message += " + "
                Else
                    isNotFirst = True
                End If
                message += tbox.Text
            End If
        Next
        Return message
    End Function



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

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAndSetTarget()
    End Sub
End Class
