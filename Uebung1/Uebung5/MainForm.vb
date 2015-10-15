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

    Private Sub TextBox_Enter(sender As Object, e As EventArgs) Handles TextBox_KontNr.Enter, TextBox_PayPal.Enter, TextBox_Check_Nr.Enter
        DirectCast(sender, TextBox).Text = ""
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles TextBox_KontNr.Leave, TextBox_PayPal.Leave, TextBox_Check_Nr.Leave
        If DirectCast(sender, TextBox).Text = "" Then
            DirectCast(sender, TextBox).Text = DirectCast(sender, TextBox).AccessibleName
        End If
    End Sub

    Private Sub Button_OK_Order_Click(sender As Object, e As EventArgs) Handles Button_OK_Order.Click
        Dim test As Boolean = isValidString(TextBox_PayPal_Pw.Text, "!§$%&/()=?+,.;:_+-")
        If ComboBox_Pay_Typ.SelectedIndex = 0 Then
            If (Double.Parse(TextBox_Geld_value.Text) - Double.Parse(TextBox_Preis.Text)) >= 0 Then
                MsgBox("Bargeld Zahlung Erfolgreich")
            Else
                MsgBox("Nicht Genug geld Eingezahlt")
            End If

        ElseIf ComboBox_Pay_Typ.SelectedIndex = 1 Then
            If TextBox_KontNr.Text.Length <> 13 Or Not IsNumeric(TextBox_KontNr.Text) Then
                MsgBox("Kontonummer Falsch")
            ElseIf TextBox_Check_Nr.Text.Length <> 3 Or Not IsNumeric(TextBox_Check_Nr.Text) Then
                MsgBox("Prüfziffer falsch")
            ElseIf Not isValidNumber() Then
                MsgBox("Prüfiffer passt nicht zur Kontonummer")
            Else
                MsgBox("Kredidkarten Zahlung erfolgreich")
            End If
        Else
            Dim sonderzeichen As String = "!§$%&/()=?+,.;:_+-"
            Dim Gro_Schrei As String = "QWERTZUIOPASDFGHJKLÖÄÜYXCVBNM"
            If TextBox_PayPal.Text = "" Or TextBox_PayPal.Text = TextBox_PayPal.AccessibleName Or Not TextBox_PayPal.Text.Contains("@") Or Not TextBox_PayPal.Text.Contains(".") Then
                MsgBox("Benutzer Name Falsch")
            ElseIf TextBox_PayPal_Pw.Text = "" Or TextBox_PayPal_Pw.Text = TextBox_PayPal_Pw.AccessibleName Or TextBox_PayPal_Pw.Text.Length < 10 Or Not isValidString(TextBox_PayPal_Pw.Text, sonderzeichen) Or Not isValidString(TextBox_PayPal_Pw.Text, Gro_Schrei) Then
                MsgBox("Passwort Falsch")
            Else
                MsgBox("Paypal Zahlung erfolgreich")
            End If
        End If
    End Sub

    Private Sub TextBox_PayPal_Pw_Enter(sender As Object, e As EventArgs) Handles TextBox_PayPal_Pw.Enter
        DirectCast(sender, TextBox).Text = ""
        DirectCast(sender, TextBox).PasswordChar = "*"c

    End Sub

    Private Sub TextBox_PayPal_Pw_Leave(sender As Object, e As EventArgs) Handles TextBox_PayPal_Pw.Leave
        If DirectCast(sender, TextBox).Text = "" Then
            DirectCast(sender, TextBox).Text = DirectCast(sender, TextBox).AccessibleName
            'DirectCast(sender, TextBox).PasswordChar = vbNullChar
        End If
    End Sub


    Function isValidString(ByVal txt As String, ByVal validChars As String) As Boolean
        For i As Integer = 0 To txt.Length - 1
            If validChars.Contains(txt.Chars(i)) Then
                Return True
                Exit Function
            End If
        Next
        Return False

    End Function

    Function isValidNumber() As Boolean

        Dim number As String = TextBox_KontNr.Text & TextBox_Check_Nr.Text

        Dim sum As Integer = 0
        Dim len = number.Length

        For i As Integer = 0 To len - 1

            Dim add As Integer = (Integer.Parse(number(i)) - 48) * (2 - (i + len) Mod 2)
            add -= If(add > 9, 9, 0)
            sum += add

        Next

        Return sum Mod 10 = 0

    End Function



    Private Sub upDateGeld(value As Integer)
        TextBox_Geld_value.Text = TextBox_Geld_value.Text & value.ToString
    End Sub

    Private Sub Button_Geld_1_Click(sender As Object, e As EventArgs) Handles Button_Geld_1.Click
        upDateGeld(1)
    End Sub

    Private Sub Button_Geld_2_Click(sender As Object, e As EventArgs) Handles Button_Geld_2.Click
        upDateGeld(2)
    End Sub

    Private Sub Button_Geld_3_Click(sender As Object, e As EventArgs) Handles Button_Geld_3.Click
        upDateGeld(3)
    End Sub

    Private Sub Button_Geld_4_Click(sender As Object, e As EventArgs) Handles Button_Geld_4.Click
        upDateGeld(4)
    End Sub

    Private Sub Button_Geld_5_Click(sender As Object, e As EventArgs) Handles Button_Geld_5.Click
        upDateGeld(5)
    End Sub

    Private Sub Button_Geld_6_Click(sender As Object, e As EventArgs) Handles Button_Geld_6.Click
        upDateGeld(6)
    End Sub

    Private Sub Button_Geld_7_Click(sender As Object, e As EventArgs) Handles Button_Geld_7.Click
        upDateGeld(7)
    End Sub

    Private Sub Button_Geld_8_Click(sender As Object, e As EventArgs) Handles Button_Geld_8.Click
        upDateGeld(8)
    End Sub

    Private Sub Button_Geld_9_Click(sender As Object, e As EventArgs) Handles Button_Geld_9.Click
        upDateGeld(9)
    End Sub

    Private Sub Button_Geld_Del_Click(sender As Object, e As EventArgs) Handles Button_Geld_Del.Click
        If TextBox_Geld_value.Text.Length > 0 Then
            TextBox_Geld_value.Text = TextBox_Geld_value.Text.Substring(0, TextBox_Geld_value.Text.Length - 1)

        End If
    End Sub

    Private Sub Button_Geld_0_Click(sender As Object, e As EventArgs) Handles Button_Geld_0.Click
        upDateGeld(0)
    End Sub

    Private Sub Button_Geld_Kom_Click(sender As Object, e As EventArgs) Handles Button_Geld_Kom.Click
        TextBox_Geld_value.Text = TextBox_Geld_value.Text & ","
    End Sub
End Class
