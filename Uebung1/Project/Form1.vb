Imports System.IO

Public Class Form1
    Private Koords As Koordinaten()

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click

    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click

    End Sub

    Private Sub einlesen()

        Dim openFD As New OpenFileDialog()


        openFD.InitialDirectory = "C:\Users\Arno\Desktop"
        openFD.Filter = "Korrdinaten files (*.adress)|*.adress"
        openFD.RestoreDirectory = True

        If openFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

        End If


    End Sub


End Class
