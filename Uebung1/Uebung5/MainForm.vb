Public Class MainForm
    Private desti(11) As Ziel


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

        DeAndAct()

    End Sub

    Private Sub DeAndAct()

        TextBox_Check_Nr.Visible = False
        TextBox_Check_Nr.Enabled = False
        TextBox_KontNr.Enabled = False
        TextBox_KontNr.Visible = False
        TextBox_PayPal.Visible = False
        TextBox_PayPal.Enabled = False
        TextBox_PayPal_Pw.Visible = False
        TextBox_PayPal_Pw.Enabled = False
        GroupBox_geld.Visible = False
        GroupBox_geld.Enabled = False
        Button_OK_Order.Visible = False
        Button_OK_Order.Enabled = False
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

    Private Sub ComboBox_Ziel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Ziel.SelectedIndexChanged
        TextBox_Preis.Text = DirectCast(DirectCast(sender, ComboBox).SelectedItem, Ziel).getPreis(getSelectedID(GroupBox_Fahrkarte), getSelectedID(GroupBox_Reis)).ToString
    End Sub

    Function getSelectedID(box As GroupBox) As Integer
        Dim count As Integer = 0
        For Each RBut As RadioButton In box.Controls
            If RBut.Checked = True Then
                Exit For
            End If
            count += 1
        Next
        Return count
    End Function

    Private Sub ComboBox_Pay_Typ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Pay_Typ.SelectedIndexChanged
        DeAndAct()
        If ComboBox_Pay_Typ.SelectedIndex = 0 Then
            GroupBox_geld.Enabled = True
            GroupBox_geld.Visible = True

        ElseIf ComboBox_Pay_Typ.SelectedIndex = 1 Then
            TextBox_Check_Nr.Visible = True
            TextBox_Check_Nr.Enabled = True
            TextBox_KontNr.Visible = True
            TextBox_KontNr.Enabled = True
        Else
            TextBox_PayPal.Visible = True
            TextBox_PayPal.Enabled = True
            TextBox_PayPal_Pw.Visible = True
            TextBox_PayPal_Pw.Enabled = True
        End If
        Button_OK_Order.Visible = True
        Button_OK_Order.Enabled = True
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBox_KontNr.Enter, TextBox_PayPal_Pw.Enter, TextBox_PayPal.Enter, TextBox_Check_Nr.Enter
        DirectCast(sender, TextBox).Text = ""
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBox_KontNr.Leave, TextBox_PayPal_Pw.Leave, TextBox_PayPal.Leave, TextBox_Check_Nr.Leave
        If DirectCast(sender, TextBox).Text = "" Then
            DirectCast(sender, TextBox).Text = DirectCast(sender, TextBox).AccessibleName
        End If
    End Sub
End Class
