Public Class Form1
    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Me.Close()
    End Sub

    Private Sub TextBox_clear_Click(sender As Object, e As EventArgs) Handles TextBox_input.Click, TextBox_para_c.Click, TextBox_para_b.Click, TextBox_para_a.Click, TextBox_insert.Click
        DirectCast(sender, TextBox).Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Sub init()
        ComboBox_method.Items.Add("String entnehmen")
        ComboBox_method.Items.Add("String einfügen")
        ComboBox_method.Items.Add("Buchstabenreihenfolge ändern")
        ComboBox_method.Items.Add("Wortreihenfolge ändern")
        ComboBox_method.Items.Add("Buchstaben in Zahlen umwandeln")
        ComboBox_method.Items.Add("Buchstaben codieren")

        ComboBox_funktion.Items.Add("x+a")
        ComboBox_funktion.Items.Add("b*x+a")
        ComboBox_funktion.Items.Add("x(Bitshift)")
        ComboBox_funktion.Items.Add("x(Bitumkehr)")

        Rest_Visi()

    End Sub

    Sub Rest_Visi()
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

        Button_Decode.Visible = False
        Button_Decode.Enabled = False

    End Sub


    Sub St_remove_Inter()
        TextBox_bis.Visible = True
        TextBox_bis.Enabled = True
        Label_bis.Visible = True

        TextBox_von.Visible = True
        TextBox_von.Enabled = True
        Label_von.Visible = True

        TextBox_result.Visible = True
        TextBox_result.Enabled = True
        Label_result.Visible = True

        Button_run.Visible = True
        Button_run.Enabled = True
    End Sub

    Sub St_Insert_Inter()
        St_remove_Inter()
        TextBox_insert.Visible = True
        TextBox_insert.Enabled = True
    End Sub

    Sub St_Invers_Inter()
        TextBox_result.Visible = True
        TextBox_result.Enabled = True
        Label_result.Visible = True

        Button_reset.Visible = True
        Button_reset.Enabled = True

        Button_run.Visible = True
        Button_run.Enabled = True
    End Sub

    Sub St_Numb_Inter()
        TextBox_result.Visible = True
        TextBox_result.Enabled = True
        Label_result.Visible = True

        Button_run.Visible = True
        Button_run.Enabled = True
    End Sub

    Sub St_Fun_Inter()
        ComboBox_funktion.Visible = True
        ComboBox_funktion.Enabled = True

    End Sub

    Sub St_Fun_1_Inter()
        ComboBox_funktion.Visible = True
        ComboBox_funktion.Enabled = True

        Button_Decode.Visible = True
        Button_Decode.Enabled = True

        TextBox_result.Visible = True
        TextBox_result.Enabled = True
        Label_result.Visible = True

        Button_run.Visible = True
        Button_run.Enabled = True

        Label_para_a.Visible = True
        TextBox_para_a.Visible = True
        TextBox_para_a.Enabled = True

    End Sub

    Sub St_Fun_2_Inter()
        St_Fun_1_Inter()

        Label_para_b.Visible = True
        TextBox_para_b.Visible = True
        TextBox_para_b.Enabled = True

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
                Dim code As ICodeString

                Select Case ComboBox_funktion.SelectedIndex
                    Case 0
                        code = New CodeOffset()
                    Case 1
                        code = New CodeOffsetAndMulti()
                    Case 2
                        code = New CodeBitshift()
                    Case 3
                        code = New CodeBitInvert()
                End Select
                TextBox_result.Text = code.code(TextBox_input.Text, ParaToInt(TextBox_para_a.Text), ParaToInt(TextBox_para_b.Text), ParaToInt(TextBox_para_c.Text))
        End Select
    End Sub

    Function ParaToInt(value As String) As Integer
        If value = "Wert" Then
            Return 0
        End If
        Return Integer.Parse(value)
    End Function


    Private Sub char_to_Num()
        For i As Integer = 0 To TextBox_input.Text.Length - 1
            TextBox_result.Text = TextBox_result.Text & Asc(TextBox_input.Text(i)) Mod 10
        Next
    End Sub


    Private Sub invert_word()
        Dim parts() As String = TextBox_input.Text.Split
        Dim St_revers As String = ""
        For i As Integer = 0 To parts.Length - 1
            St_revers = parts(i) & " " & St_revers
        Next
        TextBox_result.Text = St_revers
    End Sub

    Private Sub invert_char()
        Dim St_revers As String = ""
        For i As Integer = 0 To TextBox_input.Text.Length - 1
            St_revers = TextBox_input.Text(i) & St_revers
        Next
        TextBox_result.Text = St_revers
    End Sub

    Private Sub St_Insert()
        If TextBox_von.Text = "" Or TextBox_bis.Text = "" Then
            Exit Sub
        End If
        Dim st_array() As String = StSplitRemoveAndInsert()

        TextBox_result.Text = st_array(0) & TextBox_insert.Text & st_array(1)
    End Sub

    Private Sub St_remove()
        If TextBox_von.Text = "" Or TextBox_bis.Text = "" Then
            Exit Sub
        End If
        Dim st_array() As String = StSplitRemoveAndInsert()

        TextBox_result.Text = st_array(0) & st_array(1)
    End Sub

    Function StSplitRemoveAndInsert() As String()

        If TextBox_von.Text = "" Or TextBox_bis.Text = "" Then
            Exit Function
        End If

        Dim von_int As Integer = Integer.Parse(TextBox_von.Text)
        Dim bis_int As Integer = Integer.Parse(TextBox_bis.Text)

        Dim st_array(1) As String

        If von_int > bis_int Then
            MsgBox("Der Von-Wert muss kleiner als der Bis-Wert")
            Exit Function
        End If
        If bis_int > TextBox_input.Text.Length Then
            MsgBox("Der Bis-Wert darf nicht größer als die länge des Eingabe textes sein!")
            Exit Function
        End If

        st_array(0) = TextBox_input.Text.Substring(0, von_int - 1)
        st_array(1) = TextBox_input.Text.Substring(bis_int, TextBox_input.Text.Length - bis_int)
        Return st_array
    End Function

    Private Sub TextBox_Number_Only_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_von.KeyUp, TextBox_bis.KeyUp, TextBox_para_c.KeyUp, TextBox_para_b.KeyUp, TextBox_para_a.KeyUp
        Dim tBox As TextBox = DirectCast(sender, TextBox)
        While Not IsNumeric(tBox.Text) And tBox.Text.Length > 0
            tBox.Text = tBox.Text.Substring(0, tBox.Text.Length - 1)
            tBox.Select(tBox.Text.Length, 0)
        End While
    End Sub

    Private Sub ComboBox_method_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_method.SelectedIndexChanged
        Select Case ComboBox_method.SelectedIndex
            Case 0
                Rest_Visi()
                St_remove_Inter()
            Case 1
                Rest_Visi()
                St_Insert_Inter()
            Case 2
                Rest_Visi()
                St_Invers_Inter()
            Case 3
                Rest_Visi()
                St_Invers_Inter()
            Case 4
                Rest_Visi()
                St_Numb_Inter()
            Case 5
                Rest_Visi()
                St_Fun_Inter()
        End Select

    End Sub

    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click

    End Sub

    Private Sub ComboBox_funktion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_funktion.SelectedIndexChanged
        Select Case ComboBox_funktion.SelectedIndex
            Case 0
                Rest_Visi()
                St_Fun_1_Inter()
            Case 1
                Rest_Visi()
                St_Fun_2_Inter()
            Case 2
                Rest_Visi()
                St_Fun_1_Inter()
            Case 3
                Rest_Visi()
                St_Fun_1_Inter()
        End Select
    End Sub

    Private Sub Button_Decode_Click(sender As Object, e As EventArgs) Handles Button_Decode.Click
        Dim code As ICodeString

        Select Case ComboBox_funktion.SelectedIndex
            Case 0
                code = New CodeOffset()
            Case 1
                code = New CodeOffsetAndMulti()
            Case 2
                code = New CodeBitshift()
            Case 3
                code = New CodeBitInvert()
        End Select

        Dim str As String

        If TextBox_result.Text = "" Then
            str = TextBox_input.Text
        Else
            str = TextBox_result.Text
        End If

        TextBox_result.Text = code.decode(str, ParaToInt(TextBox_para_a.Text), ParaToInt(TextBox_para_b.Text), ParaToInt(TextBox_para_c.Text))
    End Sub

End Class
