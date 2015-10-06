Public Class MainForm
    Private Sub ButtonShowMsBox_Click(sender As Object, e As EventArgs) Handles ButtonShowMsBox.Click
        MessageBox.Show("Dies ist der Text eine MessageBox")
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class
