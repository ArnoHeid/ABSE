Public Class MainForm

    Private preise(5) As Double
    Private zutaten(3) As Double
    Private factor As Double
    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub

    Private Sub RadioButton_size_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_small.CheckedChanged, RadioButton_big.CheckedChanged, CheckBox_Freunde.CheckedChanged
        updatePreis()
    End Sub

    Private Sub updatePreis()

        If RadioButton_big.Checked Then
            factor = 2
        Else
            factor = 1
        End If

        If CheckBox_Freunde.Checked Then
            factor = factor / 2
        End If

        Label_Wasser.Text = (factor * preise(0)).ToString("f2")
        Label_Tee.Text = (factor * preise(1)).ToString("f2")
        Label_Kaffee.Text = (factor * preise(2)).ToString("f2")
        Label_Cappucino.Text = (factor * preise(3)).ToString("f2")
        Label_Espresso.Text = (factor * preise(4)).ToString("f2")

        Label_Milch.Text = (zutaten(0)).ToString("f2")
        Label_Zucker.Text = (zutaten(1)).ToString("f2")
        Label_Sahne.Text = (zutaten(2)).ToString("f2")

        upDateToPay()

    End Sub

    Private Sub upDateToPay()

        Dim total As Double

        total = factor * preise(getIndexGetraenk) + getZusatz()

        TextBox_toPay.Text = total.ToString("f2")

    End Sub

    Private Function getIndexGetraenk() As Integer
        If RadioButton_Wasser.Checked Then
            Return 0
        ElseIf RadioButton_Tee.Checked Then
            Return 1
        ElseIf RadioButton_Kaffee.Checked Then
            Return 2
        ElseIf RadioButton_Cappucino.Checked Then
            Return 3
        ElseIf RadioButton_Espresso.Checked Then
            Return 4
        End If

    End Function

    Private Function getZusatz() As Double
        Dim total As Double
        total = 0
        If CheckBox_Milch.Checked Then
            total += zutaten(0)
        End If

        If CheckBox_Zucker.Checked Then
            total += zutaten(1)
        End If

        If CheckBox_Sahne.Checked Then
            total += zutaten(2)
        End If
        Return total
    End Function

    Private Sub Button_pay_Click(sender As Object, e As EventArgs) Handles Button_pay.MouseClick

        GroupBox_Geld.Enabled = True
        GroupBox_getraenke.Enabled = False
        GroupBox_Zutaten.Enabled = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        factor = 1
        preise(0) = 0.8
        preise(1) = 1.1
        preise(2) = 1.2
        preise(3) = 1.9
        preise(4) = 1.5

        zutaten(0) = 0.3
        zutaten(1) = 0.2
        zutaten(2) = 0.5

        updatePreis()

    End Sub

    Private Sub RadioButton_forToPay_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Wasser.CheckedChanged, RadioButton_Tee.CheckedChanged, RadioButton_Kaffee.CheckedChanged, RadioButton_Espresso.CheckedChanged, RadioButton_Cappucino.CheckedChanged, CheckBox_Zucker.CheckedChanged, CheckBox_Sahne.CheckedChanged, CheckBox_Milch.CheckedChanged
        If RadioButton_Wasser.Checked Then
            GroupBox_Zutaten.Enabled = False
            CheckBox_Milch.Checked = False
            CheckBox_Sahne.Checked = False
            CheckBox_Zucker.Checked = False
        ElseIf RadioButton_Cappucino.Checked Or RadioButton_Espresso.Checked Then
            CheckBox_Milch.Checked = False
            CheckBox_Sahne.Checked = False
            CheckBox_Milch.Enabled = False
            CheckBox_Sahne.Enabled = False
        Else
            GroupBox_Zutaten.Enabled = True
            CheckBox_Milch.Enabled = True
            CheckBox_Sahne.Enabled = True
        End If

        upDateToPay()
    End Sub

    Private Sub pay(value As Double)
        Dim newToPay As Double
        Double.TryParse(TextBox_toPay.Text, newToPay)
        newToPay -= value
        TextBox_toPay.Text = newToPay.ToString("f2")

    End Sub

#Region "Pay Buttons"

    Private Sub Button_1Euro_Click(sender As Object, e As EventArgs) Handles Button_1Euro.Click
        pay(1)
    End Sub

    Private Sub Button_2Euro_Click(sender As Object, e As EventArgs) Handles Button_2Euro.Click
        pay(2)
    End Sub

    Private Sub Button_5Euro_Click(sender As Object, e As EventArgs) Handles Button_5Euro.Click
        pay(5)
    End Sub

    Private Sub Button_50Cent_Click(sender As Object, e As EventArgs) Handles Button_50Cent.Click
        pay(0.5)
    End Sub

    Private Sub Button_20Cent_Click(sender As Object, e As EventArgs) Handles Button_20Cent.Click
        pay(0.2)
    End Sub

    Private Sub Button_10Cent_Click(sender As Object, e As EventArgs) Handles Button_10Cent.Click
        pay(0.1)
    End Sub

    Private Sub Button_5Cent_Click(sender As Object, e As EventArgs) Handles Button_5Cent.Click
        pay(0.05)
    End Sub

#End Region

    Private Sub TextBox_toPay_TextChanged(sender As Object, e As EventArgs) Handles TextBox_toPay.TextChanged
        Dim newToPay As Double
        Double.TryParse(TextBox_toPay.Text, newToPay)
        If newToPay <= 1 And GroupBox_Geld.Focus Then
            newToPay = -newToPay
            TextBox_Back.Text = newToPay.ToString("f2")
            GroupBox_Geld.Enabled = False
            TextBox_toPay.Text = ""
            MessageBox.Show("Sie haben ein " & "Getränk" & " gekauft und bekommen " & TextBox_Back.Text & " Euro zurück")
            resetAll()
        End If


    End Sub

    Private Sub resetAll()
        GroupBox_Geld.Enabled = False
        GroupBox_getraenke.Enabled = True
        GroupBox_Zutaten.Enabled = True
        TextBox_Back.Text = ""
        TextBox_toPay.Text = ""
        RadioButton_Wasser.Checked = True

    End Sub
End Class
