Public Class Form1
    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub

    Private Sub TextBox_clear_Click(sender As Object, e As EventArgs) Handles TextBox_input.Click, TextBox_para_c.Click, TextBox_para_b.Click, TextBox_para_a.Click, TextBox_insert.Click
        DirectCast(sender, TextBox).Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'init()
    End Sub

    Sub init()
        ComboBox_method.Items.Add("String entnehmen")
        ComboBox_method.Items.Add("String einfügen")
        ComboBox_method.Items.Add("Buchstabenreihenfolge ändern")
        ComboBox_method.Items.Add("Wortreihenfolge ändern")
        ComboBox_method.Items.Add("Buchstaben in Zahlen umwandeln")
        ComboBox_method.Items.Add("Buchstaben codieren")

        TextBox_insert.Visible = False
        TextBox_insert.Enabled = False

        TextBox_bis.Visible = False
        TextBox_bis.Enabled = False
        Label_bis.Visible = False

        TextBox_von.Visible = False
        TextBox_von.Enabled = False
        Label_von.Visible = False

        TextBox_result.Visible = False
        TextBox_result.Enabled = False
        Label_result.Visible = False

        Label_funktion.Visible = False
        ComboBox_funktion.Visible = False
        ComboBox_funktion.Enabled = False

        Label_para_a.Visible = False
        TextBox_para_a.Visible = False
        TextBox_para_a.Enabled = False

        Label_para_b.Visible = False
        TextBox_para_b.Visible = False
        TextBox_para_b.Enabled = False

        Label_para_c.Visible = False
        TextBox_para_c.Visible = False
        TextBox_para_c.Enabled = False

        Button_run.Visible = False
        Button_run.Enabled = False

    End Sub

    Private Sub Button_run_Click(sender As Object, e As EventArgs) Handles Button_run.Click
        Select Case ComboBox_method.SelectedIndex
            Case 0
                St_remove()
            Case 1
                St_Insert()
            Case 2
                invert_char()
            Case 3
                invert_word()
            Case 4
                char_to_Num()
            Case 5

            Case 6

        End Select
    End Sub

    Private Sub char_to_Num()
        Throw New NotImplementedException()
    End Sub

    Private Sub invert_word()
        Throw New NotImplementedException()
    End Sub

    Private Sub invert_char()
        Throw New NotImplementedException()
    End Sub

    Private Sub St_Insert()
        Throw New NotImplementedException()
    End Sub

    Private Sub St_remove()
        If Not IsNumeric(TextBox_bis.Text) Or Not IsNumeric(TextBox_von.Text) Then
            MsgBox("Von und Bis müssen Zahlen sein")
        End If

    End Sub
End Class
