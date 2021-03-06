﻿Imports System.IO

Public Class MainForm
    Private _AusgangsSystem As Koordinaten
    Private _ZielSystem As Koordinaten
    Private _Transformation As ITransformation
    Private _ResultTable As DataTable
    Private _ResidualTable As DataTable

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
                    Do Until line Is Nothing
                        Try
                            Dim values2() As String = line.Split(" "c)
                            Dim Nr As Integer = Integer.Parse(values2(0))
                            Dim x As Double = Double.Parse(values2(1))
                            Dim y As Double = Double.Parse(values2(2))
                            Dim z As Double = Double.Parse(values2(3))
                            kordsystem.add(Nr, x, y, z)
                        Catch ex As Exception

                        End Try
                        line = sr.ReadLine()
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

    Private Sub Button_Transform_Click(sender As Object, e As EventArgs) Handles Button_Transform.Click
        Select Case ComboBox_TransformTyp.SelectedIndex
            Case -1
                MsgBox("Keine Transformation gewählt!")
                Exit Sub
            Case 0
                _Transformation = New Helmert2D
            Case 1
                _Transformation = New Helmert3D
        End Select

        Try
            _Transformation.generate(_AusgangsSystem, _ZielSystem)

            AddToTable()
            getInfo()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox_KoordAusgang_Click(sender As Object, e As EventArgs) Handles TextBox_KoordAusgang.Click
        einlesen("Start")
    End Sub

    Private Sub TextBox_ZielSys_Click(sender As Object, e As EventArgs) Handles TextBox_ZielSys.Click
        einlesen("Ziel")
    End Sub

    Private Sub Button_Report_Click(sender As Object, e As EventArgs) Handles Button_Report.Click
        Try
            MsgBox(_Transformation.getStatistic)

        Catch ex As Exception
            MsgBox("Keine Transformation durchgeführt")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_TransformTyp.Items.Add("2D - Helmert")
        ComboBox_TransformTyp.Items.Add("3D - Helmert")

        _ResultTable = New DataTable

        DataGridView_Result.DataSource = _ResultTable

        _ResidualTable = New DataTable

        DataGridView_resi.DataSource = _ResidualTable

        _ResultTable.Columns.Add("Punktnummer", GetType(Double))
        _ResultTable.Columns.Add("X-Koordinate", GetType(Double))
        _ResultTable.Columns.Add("Y-Koordinate", GetType(Double))
        _ResultTable.Columns.Add("Z-Koordinate", GetType(Double))

        _ResidualTable.Columns.Add("Punktnummer", GetType(Double))
        _ResidualTable.Columns.Add("X-Abweichung", GetType(Double))
        _ResidualTable.Columns.Add("Y-Abweichung", GetType(Double))
        _ResidualTable.Columns.Add("Z-Abweichung", GetType(Double))

    End Sub


    Private Sub AddToTable()

        _ResultTable.Clear()


        Dim resultKo As Koordinaten = _Transformation.transformPoins()

        For Each Ko As Koordinate In resultKo.KoordinatenListe
            If resultKo.Typ = 2 Then
                _ResultTable.Rows.Add(Ko.PunktNr, Math.Round(Ko.X, 3), Math.Round(Ko.Y, 3))
            Else
                _ResultTable.Rows.Add(Ko.PunktNr, Math.Round(Ko.X, 3), Math.Round(Ko.Y, 3), Math.Round(Ko.Z, 3))
            End If
        Next




        Dim residuen As Koordinaten = _Transformation.getResiduen()
        For Each k As Koordinate In residuen.KoordinatenListe
            If resultKo.Typ = 2 Then
                _ResidualTable.Rows.Add(k.PunktNr, Math.Round(k.X, 3), Math.Round(k.Y, 3))
            Else
                _ResidualTable.Rows.Add(k.PunktNr, Math.Round(k.X, 3), Math.Round(k.Y, 3), Math.Round(k.Z, 3))
            End If
        Next

    End Sub

    Private Sub getInfo()
        TextBox_NrNew.Text = _Transformation.PointsToTransform.KoordinatenListe.Count.ToString
        TextBox_Typ.Text = _Transformation.getTyp.ToString
        If _Transformation.getTyp.ToString = "2" Then
            TextBox_NrPass.Text = (_Transformation.l_Vektor.Count / 2).ToString
        ElseIf _Transformation.getTyp.ToString = "3"
            TextBox_NrPass.Text = (_Transformation.l_Vektor.Count / 3).ToString
        End If

    End Sub
End Class
