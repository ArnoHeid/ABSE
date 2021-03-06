﻿Imports System.IO

Public Class MainForm
    Private Adresse_List As New List(Of Adressen)
    Private CurrentFile As String
    Private Sub ToolStripMenuItem_exit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_exit.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem_Show_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Show.Click
        If String.IsNullOrEmpty(CurrentFile) Then
            MsgBox("Keine Daten geladen")
            Exit Sub
        End If
        Dim Viewer_Form As New Viewer(Adresse_List)
        Me.AddOwnedForm(Viewer_Form)
        Viewer_Form.Show()
    End Sub

    Private Sub ToolStripMenuItem_open_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_open.Click

        Adresse_List.Clear()

        Dim er_count As Integer = 0
        Dim count As Integer = 0
        Dim openFD As New OpenFileDialog()


        openFD.InitialDirectory = "C:\Users\Arno\Desktop"
        openFD.Filter = "Korrdinaten files (*.adress)|*.adress"
        openFD.RestoreDirectory = True


        If openFD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CurrentFile = openFD.FileName
            Using sr As StreamReader = New StreamReader(openFD.FileName())
                Dim line As String
                line = sr.ReadLine()
                Do Until line Is Nothing
                    count += 1
                    Dim value_Array() As String = line.Split(" "c)

                    Dim VorName As String = value_Array(0)
                    Dim NachName As String = value_Array(1)
                    Dim PLZ As String = value_Array(2)
                    Dim Stadt As String = value_Array(3)
                    Dim Strasse As String = value_Array(4)
                    Dim HausNr As String = value_Array(5)

                    Dim newAdress As New Adressen(VorName, NachName, PLZ, Stadt, Strasse, HausNr)
                    If newAdress.IsValied Then
                        Adresse_List.Add(newAdress)
                    End If
                    line = sr.ReadLine()


                    er_count += 1
                Loop
            End Using
            If count - er_count <> 0 Then
                MsgBox((count - er_count).ToString & " Fehlerhafte Einträge")
            End If
        End If

        upDateDataGrid()

    End Sub

    Private Sub ToolStripMenuItem_Save_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Save.Click
        If CurrentFile IsNot Nothing Then

            Using sw As StreamWriter = New StreamWriter(CurrentFile)

                For Each adress As Adressen In Adresse_List

                    sw.WriteLine(adress.getExport)

                Next
                'MsgBox("Export Erfolgreich")
            End Using
        Else
            MsgBox("Export Datei Fehlerhaft")
        End If
    End Sub

    Private Sub UnterToolStripMenuItem_SaveAs_Click(sender As Object, e As EventArgs) Handles UnterToolStripMenuItem_SaveAs.Click

        Dim SaveDia As New SaveFileDialog()

        SaveDia.InitialDirectory = "C:\Users\Arno\Desktop"
        SaveDia.Filter = "Korrdinaten files (*.adress)|*.adress"
        SaveDia.RestoreDirectory = True
        SaveDia.AddExtension = True

        If SaveDia.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


            Using sw As StreamWriter = New StreamWriter(SaveDia.FileName())

                For Each adress As Adressen In Adresse_List

                    sw.WriteLine(adress.getExport)

                Next
                'MsgBox("Export Erfolgreich")
            End Using

        End If
    End Sub

    Private Sub ToolStripMenuItem_SortUp_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_SortUp.Click
        Adresse_List.Sort()
        upDateDataGrid()
    End Sub

    Private Sub ToolStripMenuItem_SortDown_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_SortDown.Click
        Adresse_List.Sort()
        Adresse_List.Reverse()
        upDateDataGrid()
    End Sub

    Public Sub upDateDataGrid()
        DataGridView_Adressen.DataSource = Nothing
        DataGridView_Adressen.DataSource = Adresse_List
    End Sub


    Private Sub ToolStripMenuItem_search_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_search.Click
        Dim SearchValue As String = InputBox("Geben sie den Suchbegriff ein")

        If Not String.IsNullOrEmpty(SearchValue) Then
            Dim Ad As List(Of Adressen) = Adresse_List.FindAll(Function(x) (x.contains(SearchValue)))
            If Ad IsNot Nothing Then
                DataGridView_Adressen.DataSource = Ad
            Else
                MsgBox("Kein Eintrag Gefunden")
            End If
        ElseIf SearchValue = "" Then
            DataGridView_Adressen.DataSource = Adresse_List
        End If

    End Sub

End Class
