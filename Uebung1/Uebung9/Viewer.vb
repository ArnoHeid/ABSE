Public Class Viewer
    Private Adresse_List As List(Of Adressen)
    Private SelectedIndex As Integer
    Private isSaved As Boolean


    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        If isSaved = False Then
            save()
        End If
        Me.Close()
    End Sub
    Sub New(ByRef Adresse_List As List(Of Adressen))

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.Adresse_List = Adresse_List

    End Sub

    Private Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        insertAdress(0)
    End Sub

    Private Sub insertAdress(SelectedIndex As Integer)
        If Adresse_List.Count = SelectedIndex Or Adresse_List.Count < SelectedIndex Then
            Me.SelectedIndex = SelectedIndex
            TextBox_ID.Text = SelectedIndex.ToString
            TextBox_Vorname.Text = ""
            TextBox_Nachname.Text = ""
            TextBox_PLZ.Text = ""
            TextBox_Stadt.Text = ""
            TextBox_Strasse.Text = ""
            TextBox_HausNr.Text = ""
            isSaved = False
            Exit Sub
        End If
        Try
            Me.SelectedIndex = SelectedIndex
            TextBox_ID.Text = Adresse_List(SelectedIndex).ID.ToString
            TextBox_Vorname.Text = Adresse_List(SelectedIndex).Vorname
            TextBox_Nachname.Text = Adresse_List(SelectedIndex).Nachname
            TextBox_PLZ.Text = Adresse_List(SelectedIndex).PLZ.ToString
            TextBox_Stadt.Text = Adresse_List(SelectedIndex).Stadt
            TextBox_Strasse.Text = Adresse_List(SelectedIndex).Strasse
            TextBox_HausNr.Text = Adresse_List(SelectedIndex).HausNr.ToString
            isSaved = True
        Catch ex As Exception
            MsgBox("Fehler beim Laden der Daten")
        End Try
    End Sub

    Private Sub Button_first_Click(sender As Object, e As EventArgs) Handles Button_first.Click
        If isSaved = False Then
            save()
        End If
        insertAdress(0)
    End Sub

    Private Sub Button_last_Click(sender As Object, e As EventArgs) Handles Button_last.Click
        If isSaved = False Then
            save()
        End If
        insertAdress(Adresse_List.Count - 1)
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click
        If isSaved = False Then
            save()
        End If

        If SelectedIndex > 0 Then
            insertAdress(SelectedIndex - 1)
        End If

    End Sub

    Private Sub Button_next_Click(sender As Object, e As EventArgs) Handles Button_next.Click
        If isSaved = False Then
            save()
        End If
        If SelectedIndex + 2 > Adresse_List.Count Then
            Dim result As MsgBoxResult = MsgBox("Neuen Eintrag anglegen?", MsgBoxStyle.OkCancel)

            If result = MsgBoxResult.Ok Then
                insertAdress(SelectedIndex + 1)
            Else
                insertAdress(SelectedIndex)
            End If
        ElseIf SelectedIndex + 1 < Adresse_List.Count
            insertAdress(SelectedIndex + 1)
        Else
            insertAdress(SelectedIndex)
        End If

    End Sub

    Private Sub TextBox_Vorname_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Vorname.TextChanged, TextBox_Strasse.TextChanged, TextBox_Stadt.TextChanged, TextBox_PLZ.TextChanged, TextBox_Nachname.TextChanged, TextBox_HausNr.TextChanged
        isSaved = False
    End Sub


    Private Sub TextBox_NumbersOnly_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_PLZ.KeyPress, TextBox_HausNr.KeyPress

        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 32
                ' Zahlen, Backspace und Space zulassen

            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select
    End Sub

    Private Sub save()
        Dim result As MsgBoxResult = MsgBox("Daten speichern?", MsgBoxStyle.OkCancel)

        If result = MsgBoxResult.Ok Then

            If Adresse_List.Count = SelectedIndex Then
                Dim newAdress As New Adressen("", "", "", "", "", "")

                newAdress.Vorname = TextBox_Vorname.Text
                newAdress.Nachname = TextBox_Nachname.Text
                newAdress.PLZ = TextBox_PLZ.Text
                newAdress.Stadt = TextBox_Stadt.Text
                newAdress.Strasse = TextBox_Strasse.Text
                newAdress.HausNr = TextBox_HausNr.Text
                If newAdress.IsValied Then
                    Adresse_List.Add(newAdress)
                Else
                    MsgBox("Die Eingaben enthalten Fehler! Bitte korrigieren")
                End If

            Else

                Adresse_List(SelectedIndex).Vorname = TextBox_Vorname.Text
                Adresse_List(SelectedIndex).Nachname = TextBox_Nachname.Text
                Adresse_List(SelectedIndex).PLZ = TextBox_PLZ.Text
                Adresse_List(SelectedIndex).Stadt = TextBox_Stadt.Text
                Adresse_List(SelectedIndex).Strasse = TextBox_Strasse.Text
                Adresse_List(SelectedIndex).HausNr = TextBox_HausNr.Text
            End If

        End If


        isSaved = True

    End Sub

End Class