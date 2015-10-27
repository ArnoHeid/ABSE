Public Class Viewer
    Private Adresse_List As List(Of Adressen)
    Private SelectedIndex As Integer
    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
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
        Try
            Me.SelectedIndex = SelectedIndex
            TextBox_ID.Text = Adresse_List(SelectedIndex).ID.ToString
            TextBox_Vorname.Text = Adresse_List(SelectedIndex).Vorname
            TextBox_Nachname.Text = Adresse_List(SelectedIndex).Nachname
            TextBox_PLZ.Text = Adresse_List(SelectedIndex).PLZ.ToString
            TextBox_Stadt.Text = Adresse_List(SelectedIndex).Stadt
            TextBox_Strasse.Text = Adresse_List(SelectedIndex).Strasse
            TextBox_HausNr.Text = Adresse_List(SelectedIndex).HausNr.ToString
        Catch ex As Exception
            MsgBox("Fehler beim Laden der Daten")
        End Try
    End Sub

    Private Sub Button_first_Click(sender As Object, e As EventArgs) Handles Button_first.Click
        insertAdress(0)
    End Sub

    Private Sub Button_last_Click(sender As Object, e As EventArgs) Handles Button_last.Click
        insertAdress(Adresse_List.Count - 1)
    End Sub

    Private Sub Button_back_Click(sender As Object, e As EventArgs) Handles Button_back.Click

        If SelectedIndex > 0 Then
            insertAdress(SelectedIndex - 1)
        End If

    End Sub

    Private Sub Button_next_Click(sender As Object, e As EventArgs) Handles Button_next.Click

        If SelectedIndex + 2 > Adresse_List.Count Then
            Dim result As MsgBoxResult = MsgBox("Neuen Eintrag anglegen?", MsgBoxStyle.OkCancel)

            If result = MsgBoxResult.Ok Then
                Adresse_List.Add(New Adressen("", "", "", "", "", ""))
                insertAdress(SelectedIndex + 1)
            End If
        Else
            insertAdress(SelectedIndex + 1)
        End If

    End Sub

    Private Sub TextBox_Vorname_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Vorname.TextChanged, TextBox_Strasse.TextChanged, TextBox_Stadt.TextChanged, TextBox_PLZ.TextChanged, TextBox_Nachname.TextChanged, TextBox_HausNr.TextChanged
        If CType(sender, TextBox).Text.Count > 0 Then
            CType(sender, TextBox).Text = UCase(CType(sender, TextBox).Text.Substring(0, 1)) & CType(sender, TextBox).Text.Substring(1, CType(sender, TextBox).Text.Count - 1)
            CType(sender, TextBox).Select(CType(sender, TextBox).Text.Length, 0)
        End If

        Select Case CType(sender, TextBox).TabIndex
            Case 2
                Adresse_List(SelectedIndex).Vorname = CType(sender, TextBox).Text
            Case 3
                Adresse_List(SelectedIndex).Nachname = CType(sender, TextBox).Text
            Case 4
                Adresse_List(SelectedIndex).PLZ = CType(sender, TextBox).Text
            Case 5
                Adresse_List(Integer.Parse(TextBox_ID.Text) - 1).Stadt = CType(sender, TextBox).Text
            Case 6
                Adresse_List(Integer.Parse(TextBox_ID.Text) - 1).Strasse = CType(sender, TextBox).Text
            Case 7
                Adresse_List(SelectedIndex).HausNr = CType(sender, TextBox).Text

        End Select

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


End Class