Public Class MainForm
    Private desti(12) As Ziel


    Private Sub Init()
        desti(0) = New Ziel("Frankfurt Hbf", 10, 10)
        desti(1) = New Ziel("Frankfurt Niederrad", 11, 12)
        desti(2) = New Ziel("Frankfurt Süd", 12, 13)
        desti(3) = New Ziel("Gustavsburg", 103, 8)
        desti(4) = New Ziel("Mainz-Kastel", 33, 4)
        desti(5) = New Ziel("Mainz-Nord", 32, 5)
        desti(6) = New Ziel("Mainz Hbf", 30, 6)
        desti(7) = New Ziel("Mainz Römisches Theater", 31, 7)
        desti(8) = New Ziel("Offenbach Hbf", 20, 15)
        desti(9) = New Ziel("Rüsselsheim", 101, 14)
        desti(10) = New Ziel("Wiesbaden Hbf", 40, 2)
        desti(11) = New Ziel("Bischofsheim", 102, 3)

        ComboBox_Ziel.Items.AddRange(desti)

        ComboBox_Pay_Typ.Items.Add("Barzahlung")
        ComboBox_Pay_Typ.Items.Add("Kreditkarte")
        ComboBox_Pay_Typ.Items.Add("Paypal")


    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub TextBox_Eingabe_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Eingabe.KeyUp
        For Each ziel As Ziel In desti
            If ziel.isFitting(TextBox_Eingabe.Text) Then
                ComboBox_Ziel.SelectedItem = ziel
                Exit For
            End If
        Next
    End Sub
End Class
