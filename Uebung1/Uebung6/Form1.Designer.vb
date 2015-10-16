<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_input = New System.Windows.Forms.TextBox()
        Me.TextBox_insert = New System.Windows.Forms.TextBox()
        Me.TextBox_bis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_von = New System.Windows.Forms.Label()
        Me.Label_bis = New System.Windows.Forms.Label()
        Me.Button_run = New System.Windows.Forms.Button()
        Me.Label_result = New System.Windows.Forms.Label()
        Me.TextBox_result = New System.Windows.Forms.TextBox()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_method = New System.Windows.Forms.ComboBox()
        Me.Label_funktion = New System.Windows.Forms.Label()
        Me.ComboBox_funktion = New System.Windows.Forms.ComboBox()
        Me.Label_para_a = New System.Windows.Forms.Label()
        Me.TextBox_para_a = New System.Windows.Forms.TextBox()
        Me.TextBox_para_b = New System.Windows.Forms.TextBox()
        Me.Label_para_b = New System.Windows.Forms.Label()
        Me.TextBox_para_c = New System.Windows.Forms.TextBox()
        Me.Label_para_c = New System.Windows.Forms.Label()
        Me.Button_invert = New System.Windows.Forms.Button()
        Me.TextBox_von = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tool zur Textmanipulation"
        '
        'TextBox_input
        '
        Me.TextBox_input.Location = New System.Drawing.Point(105, 51)
        Me.TextBox_input.Name = "TextBox_input"
        Me.TextBox_input.Size = New System.Drawing.Size(196, 20)
        Me.TextBox_input.TabIndex = 1
        Me.TextBox_input.Text = "Ausgangstext"
        '
        'TextBox_insert
        '
        Me.TextBox_insert.Location = New System.Drawing.Point(105, 83)
        Me.TextBox_insert.Name = "TextBox_insert"
        Me.TextBox_insert.Size = New System.Drawing.Size(196, 20)
        Me.TextBox_insert.TabIndex = 2
        Me.TextBox_insert.Text = "einzufügender Text"
        '
        'TextBox_bis
        '
        Me.TextBox_bis.Location = New System.Drawing.Point(105, 163)
        Me.TextBox_bis.Name = "TextBox_bis"
        Me.TextBox_bis.Size = New System.Drawing.Size(88, 20)
        Me.TextBox_bis.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Text:"
        '
        'Label_von
        '
        Me.Label_von.AutoSize = True
        Me.Label_von.Location = New System.Drawing.Point(33, 139)
        Me.Label_von.Name = "Label_von"
        Me.Label_von.Size = New System.Drawing.Size(28, 13)
        Me.Label_von.TabIndex = 6
        Me.Label_von.Text = "von:"
        '
        'Label_bis
        '
        Me.Label_bis.AutoSize = True
        Me.Label_bis.Location = New System.Drawing.Point(33, 171)
        Me.Label_bis.Name = "Label_bis"
        Me.Label_bis.Size = New System.Drawing.Size(23, 13)
        Me.Label_bis.TabIndex = 7
        Me.Label_bis.Text = "bis:"
        '
        'Button_run
        '
        Me.Button_run.Location = New System.Drawing.Point(225, 163)
        Me.Button_run.Name = "Button_run"
        Me.Button_run.Size = New System.Drawing.Size(75, 23)
        Me.Button_run.TabIndex = 8
        Me.Button_run.Text = "Ausführen"
        Me.Button_run.UseVisualStyleBackColor = True
        '
        'Label_result
        '
        Me.Label_result.AutoSize = True
        Me.Label_result.Location = New System.Drawing.Point(33, 219)
        Me.Label_result.Name = "Label_result"
        Me.Label_result.Size = New System.Drawing.Size(46, 13)
        Me.Label_result.TabIndex = 9
        Me.Label_result.Text = "Resultat"
        '
        'TextBox_result
        '
        Me.TextBox_result.Location = New System.Drawing.Point(33, 243)
        Me.TextBox_result.Name = "TextBox_result"
        Me.TextBox_result.Size = New System.Drawing.Size(264, 20)
        Me.TextBox_result.TabIndex = 10
        '
        'Button_Exit
        '
        Me.Button_Exit.Location = New System.Drawing.Point(33, 291)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Exit.TabIndex = 11
        Me.Button_Exit.Text = "Ende"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Methodenauswahl:"
        '
        'ComboBox_method
        '
        Me.ComboBox_method.FormattingEnabled = True
        Me.ComboBox_method.Location = New System.Drawing.Point(361, 83)
        Me.ComboBox_method.Name = "ComboBox_method"
        Me.ComboBox_method.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox_method.TabIndex = 13
        Me.ComboBox_method.Text = "Methoden"
        '
        'Label_funktion
        '
        Me.Label_funktion.AutoSize = True
        Me.Label_funktion.Location = New System.Drawing.Point(361, 147)
        Me.Label_funktion.Name = "Label_funktion"
        Me.Label_funktion.Size = New System.Drawing.Size(51, 13)
        Me.Label_funktion.TabIndex = 14
        Me.Label_funktion.Text = "Funktion:"
        '
        'ComboBox_funktion
        '
        Me.ComboBox_funktion.FormattingEnabled = True
        Me.ComboBox_funktion.Location = New System.Drawing.Point(433, 139)
        Me.ComboBox_funktion.Name = "ComboBox_funktion"
        Me.ComboBox_funktion.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_funktion.TabIndex = 15
        Me.ComboBox_funktion.Text = "Auswahl"
        '
        'Label_para_a
        '
        Me.Label_para_a.AutoSize = True
        Me.Label_para_a.Location = New System.Drawing.Point(361, 187)
        Me.Label_para_a.Name = "Label_para_a"
        Me.Label_para_a.Size = New System.Drawing.Size(67, 13)
        Me.Label_para_a.TabIndex = 16
        Me.Label_para_a.Text = "Parameter a:"
        '
        'TextBox_para_a
        '
        Me.TextBox_para_a.Location = New System.Drawing.Point(457, 179)
        Me.TextBox_para_a.Name = "TextBox_para_a"
        Me.TextBox_para_a.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_para_a.TabIndex = 17
        Me.TextBox_para_a.Text = "Wert"
        '
        'TextBox_para_b
        '
        Me.TextBox_para_b.Location = New System.Drawing.Point(457, 211)
        Me.TextBox_para_b.Name = "TextBox_para_b"
        Me.TextBox_para_b.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_para_b.TabIndex = 19
        Me.TextBox_para_b.Text = "Wert"
        '
        'Label_para_b
        '
        Me.Label_para_b.AutoSize = True
        Me.Label_para_b.Location = New System.Drawing.Point(361, 219)
        Me.Label_para_b.Name = "Label_para_b"
        Me.Label_para_b.Size = New System.Drawing.Size(67, 13)
        Me.Label_para_b.TabIndex = 18
        Me.Label_para_b.Text = "Parameter b:"
        '
        'TextBox_para_c
        '
        Me.TextBox_para_c.Location = New System.Drawing.Point(457, 243)
        Me.TextBox_para_c.Name = "TextBox_para_c"
        Me.TextBox_para_c.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_para_c.TabIndex = 21
        Me.TextBox_para_c.Text = "Wert"
        '
        'Label_para_c
        '
        Me.Label_para_c.AutoSize = True
        Me.Label_para_c.Location = New System.Drawing.Point(361, 251)
        Me.Label_para_c.Name = "Label_para_c"
        Me.Label_para_c.Size = New System.Drawing.Size(67, 13)
        Me.Label_para_c.TabIndex = 20
        Me.Label_para_c.Text = "Parameter c:"
        '
        'Button_invert
        '
        Me.Button_invert.Location = New System.Drawing.Point(481, 291)
        Me.Button_invert.Name = "Button_invert"
        Me.Button_invert.Size = New System.Drawing.Size(75, 23)
        Me.Button_invert.TabIndex = 22
        Me.Button_invert.Text = "invertieren"
        Me.Button_invert.UseVisualStyleBackColor = True
        '
        'TextBox_von
        '
        Me.TextBox_von.Location = New System.Drawing.Point(104, 136)
        Me.TextBox_von.Name = "TextBox_von"
        Me.TextBox_von.Size = New System.Drawing.Size(88, 20)
        Me.TextBox_von.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 345)
        Me.Controls.Add(Me.TextBox_von)
        Me.Controls.Add(Me.Button_invert)
        Me.Controls.Add(Me.TextBox_para_c)
        Me.Controls.Add(Me.Label_para_c)
        Me.Controls.Add(Me.TextBox_para_b)
        Me.Controls.Add(Me.Label_para_b)
        Me.Controls.Add(Me.TextBox_para_a)
        Me.Controls.Add(Me.Label_para_a)
        Me.Controls.Add(Me.ComboBox_funktion)
        Me.Controls.Add(Me.Label_funktion)
        Me.Controls.Add(Me.ComboBox_method)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.TextBox_result)
        Me.Controls.Add(Me.Label_result)
        Me.Controls.Add(Me.Button_run)
        Me.Controls.Add(Me.Label_bis)
        Me.Controls.Add(Me.Label_von)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_bis)
        Me.Controls.Add(Me.TextBox_insert)
        Me.Controls.Add(Me.TextBox_input)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_input As TextBox
    Friend WithEvents TextBox_insert As TextBox
    Friend WithEvents TextBox_bis As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_von As Label
    Friend WithEvents Label_bis As Label
    Friend WithEvents Button_run As Button
    Friend WithEvents Label_result As Label
    Friend WithEvents TextBox_result As TextBox
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_method As ComboBox
    Friend WithEvents Label_funktion As Label
    Friend WithEvents ComboBox_funktion As ComboBox
    Friend WithEvents Label_para_a As Label
    Friend WithEvents TextBox_para_a As TextBox
    Friend WithEvents TextBox_para_b As TextBox
    Friend WithEvents Label_para_b As Label
    Friend WithEvents TextBox_para_c As TextBox
    Friend WithEvents Label_para_c As Label
    Friend WithEvents Button_invert As Button
    Friend WithEvents TextBox_von As TextBox
End Class
