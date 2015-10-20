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
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Using sr As StreamReader = New StreamReader(openFileDialog1.FileName())
                Dim line As String
                line = sr.ReadLine()

                Do Until line Is Nothing
                    Console.WriteLine(line)
                    line = sr.ReadLine()

                    'Check Line
                    'Fix Line
                    If line IsNot Nothing Then
                        Dim value_Array() As String = line.Split(" ")

                        'check Line

                        Dim Nr As Integer = Integer.Parse(value_Array(0))
                        Dim X As Double = Double.Parse(value_Array(1))
                        Dim y As Double = Double.Parse(value_Array(2))
                        Dim z As Double = Double.Parse(value_Array(3))

                        Koord_List.Add(New Koordinaten(Nr, X, y, z))
                    End If

                Loop
            End Using
        End If

    End Sub

    Private Sub Button_ExportFile_Click(sender As Object, e As EventArgs) Handles Button_ExportFile.Click
        Dim SaveDia As New SaveFileDialog()


        SaveDia.InitialDirectory = "c:\"
        SaveDia.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveDia.FilterIndex = 2
        SaveDia.RestoreDirectory = True

        If SaveDia.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Export_File = SaveDia.FileName()
        End If

    End Sub

    Private Sub Button_export_Click(sender As Object, e As EventArgs) Handles Button_export.Click
        If Not (Export_File = Nothing) Then

            Using sw As StreamWriter = New StreamWriter(Export_File)

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

                Next
            End Using
        End If

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
