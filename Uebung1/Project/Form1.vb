Imports System.IO

Public Class Form1
    Private _AusgangsSystem As Koordinaten
    Private _ZielSystem As Koordinaten
    Private _Transformation As ITransformation
    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click

    End Sub

    Private Sub einlesen(KordSys As String)

        Dim kordsystem As Koordinaten

        Dim openFD As New OpenFileDialog()

        openFD.InitialDirectory = "C:\Users\Arno\Desktop"
        openFD.Filter = "Korrdinaten files (*.koord)|*.koord"
        openFD.RestoreDirectory = True

        If openFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim sr As StreamReader = New StreamReader(openFD.FileName())
            Try
                Dim line As String
                line = sr.ReadLine()
                Dim values() As String = line.Split(" "c)
                If values.Length <> 3 And values.Length <> 4 Then
                    MsgBox("Fehler in der Koordinaten Datei")
                    Exit Sub
                End If

                line = sr.ReadLine()

                If values.Length = 3 Then

                    kordsystem = New Koordinaten(2)

                    Do Until line Is Nothing

                        Try
                            Dim values2() As String = line.Split(" "c)
                            Dim Nr As Integer = Integer.Parse(values2(0))
                            Dim x As Double = Double.Parse(values2(1))
                            Dim y As Double = Double.Parse(values2(2))
                            kordsystem.add(Nr, x, y)
                        Catch ex As Exception

                        End Try


                        line = sr.ReadLine()
                    Loop


                ElseIf values.Length = 4 Then

                    kordsystem = New Koordinaten(3)
                    Do Until sr Is Nothing
                        Try
                            Dim values2() As String = line.Split(" "c)
                            Dim Nr As Integer = Integer.Parse(values2(0))
                            Dim x As Double = Double.Parse(values2(1))
                            Dim y As Double = Double.Parse(values2(2))
                            Dim z As Double = Double.Parse(values2(3))
                            kordsystem.add(Nr, x, y, z)
                        Catch ex As Exception

                        End Try
                        sr.ReadLine()
                    Loop

                End If

            Catch ex As Exception

            End Try

            If KordSys = "Ziel" Then
                _ZielSystem = kordsystem
                TextBox_ZielSys.Text = openFD.FileName

            ElseIf KordSys = "Start" Then
                _AusgangsSystem = kordsystem
                TextBox_KoordAusgang.Text = openFD.FileName
            End If
        End If

    End Sub

    Private Sub AusgangssystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusgangssystemToolStripMenuItem.Click
        einlesen("Start")
    End Sub

    Private Sub ZielsystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZielsystemToolStripMenuItem.Click
        einlesen("Ziel")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Transform.Click
        If _Transformation Is Nothing Then
            MsgBox("Keine Transformation gewählt!")
        Else
            _Transformation.generate(_AusgangsSystem, _ZielSystem)
            _Transformation.transformPoins()
        End If


    End Sub

    Private Sub TextBox_KoordAusgang_Click(sender As Object, e As EventArgs) Handles TextBox_KoordAusgang.Click
        einlesen("Start")
    End Sub

    Private Sub TextBox_ZielSys_Click(sender As Object, e As EventArgs) Handles TextBox_ZielSys.Click
        einlesen("Ziel")
    End Sub

    Private Sub Button_Report_Click(sender As Object, e As EventArgs) Handles Button_Report.Click
        MsgBox(_Transformation.getStatistic)
    End Sub
End Class
