Imports System.IO

Public Class Form1
    Private Koord_List As List(Of Koordinaten)
    Private Export_File As String

    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub

    Private Sub Button_FileOpen_Click(sender As Object, e As EventArgs) Handles Button_FileOpen.Click

        Koord_List = New List(Of Koordinaten)
        Dim openFileDialog1 As New OpenFileDialog()


        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Korrdinaten files (*.kord)|*.kord"
        openFileDialog1.RestoreDirectory = True


        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Using sr As StreamReader = New StreamReader(openFileDialog1.FileName())
                Dim line As String
                line = sr.ReadLine()

                Do Until line Is Nothing

                    line = FixedLine(line) 'Fix Line mehrfach Zeichen

                    Dim value_Array() As String = line.Split(" ")

                    If lineIsValide(value_Array) Then 'check Line, Fehlerhafte Zeilen werden nicht eingelesen

                        Dim Nr As Integer = Integer.Parse(value_Array(0))
                        Dim X As Double = Double.Parse(value_Array(1))
                        Dim y As Double = Double.Parse(value_Array(2))
                        Dim z As Double = Double.Parse(value_Array(3))

                        Koord_List.Add(New Koordinaten(Nr, X, y, z))
                    End If
                    line = sr.ReadLine()
                Loop
            End Using

            Button_ExportFile.Enabled = True
            RadioButton_PunktNr.Checked = True
        End If

    End Sub

    Private Function FixedLine(line As String) As String

        line = line.Replace(vbTab, " ")
        While line.Contains("  ")
            line = line.Replace("  ", " ")
        End While

        Return line
    End Function

    Private Function lineIsValide(line_array() As String) As Boolean
        If (line_array.Length <> 4) Then
            Return False
        End If
        If Not IsNumeric(line_array(0)) Or Not IsNumeric(line_array(1)) Or Not IsNumeric(line_array(2)) Or Not IsNumeric(line_array(3)) Then
            Return False
        End If
        Return True
    End Function

    Private Sub Button_ExportFile_Click(sender As Object, e As EventArgs) Handles Button_ExportFile.Click
        Dim SaveDia As New SaveFileDialog()


        SaveDia.InitialDirectory = "c:\"
        SaveDia.Filter = "Korrdinaten files (*.kord)|*.kord"
        SaveDia.RestoreDirectory = True
        SaveDia.AddExtension = True

        If SaveDia.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Export_File = SaveDia.FileName()
            Button_export.Enabled = True
            GroupBox_Auswahl.Enabled = True
        End If

    End Sub

    Private Sub Button_export_Click(sender As Object, e As EventArgs) Handles Button_export.Click
        If Export_File IsNot Nothing Then

            Using sw As StreamWriter = New StreamWriter(Export_File)

                Dim counter As Integer = 0

                Dim i As Integer = getRadioIndex()

                For Each Ko As Koordinaten In Koord_List

                    Dim toWrite As String

                    Select Case i
                        Case 0
                            toWrite = Ko.GetNr()

                        Case 1
                            toWrite = Ko.GetX()

                        Case 2
                            toWrite = Ko.GetY()

                        Case Else
                            toWrite = Ko.GetZ()

                    End Select

                    sw.WriteLine(toWrite)
                    counter += 1

                Next
                MsgBox("Export Erfolgreich. " & counter.ToString & " Einträge geschrieben")
                RestProg()
            End Using
        Else
            MsgBox("Export Datei Fehlerhaft")
        End If

    End Sub

    Private Sub RestProg()
        Button_export.Enabled = False
        Button_ExportFile.Enabled = False
        GroupBox_Auswahl.Enabled = False

    End Sub

    Function getRadioIndex() As Integer
        If RadioButton_PunktNr.Checked = True Then
            Return 0
        ElseIf RadioButton_XKord.Checked = True Then
            Return 1
        ElseIf RadioButton_XKord.Checked = True Then
            Return 2
        Else
            Return 3
        End If
    End Function

End Class
