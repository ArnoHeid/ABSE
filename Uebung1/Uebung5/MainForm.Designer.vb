<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_Ziel = New System.Windows.Forms.ComboBox()
        Me.TextBox_Eingabe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Preis = New System.Windows.Forms.TextBox()
        Me.GroupBox_Fahrkarte = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Woche = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Gruppe = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Tages = New System.Windows.Forms.RadioButton()
        Me.RadioButton_HinRueck = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Einfach = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Reis = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Hund = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Fahrrad = New System.Windows.Forms.RadioButton()
        Me.RadioButton_SchweBi = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Azubi = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Erwachsen = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Kind = New System.Windows.Forms.RadioButton()
        Me.ComboBox_Pay_Typ = New System.Windows.Forms.ComboBox()
        Me.TextBox_KontNr = New System.Windows.Forms.TextBox()
        Me.TextBox_Check_Nr = New System.Windows.Forms.TextBox()
        Me.TextBox_PayPal = New System.Windows.Forms.TextBox()
        Me.TextBox_PayPal_Pw = New System.Windows.Forms.TextBox()
        Me.Button_OK_Order = New System.Windows.Forms.Button()
        Me.GroupBox_geld = New System.Windows.Forms.GroupBox()
        Me.Button_Geld_Kom = New System.Windows.Forms.Button()
        Me.Button_Geld_9 = New System.Windows.Forms.Button()
        Me.Button_Geld_6 = New System.Windows.Forms.Button()
        Me.Button_Geld_3 = New System.Windows.Forms.Button()
        Me.Button_Geld_0 = New System.Windows.Forms.Button()
        Me.Button_Geld_8 = New System.Windows.Forms.Button()
        Me.Button_Geld_5 = New System.Windows.Forms.Button()
        Me.Button_Geld_2 = New System.Windows.Forms.Button()
        Me.Button_Geld_Del = New System.Windows.Forms.Button()
        Me.Button_Geld_7 = New System.Windows.Forms.Button()
        Me.Button_Geld_4 = New System.Windows.Forms.Button()
        Me.Button_Geld_1 = New System.Windows.Forms.Button()
        Me.GroupBox_Fahrkarte.SuspendLayout()
        Me.GroupBox_Reis.SuspendLayout()
        Me.GroupBox_geld.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fahrkartautomat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ziel"
        '
        'ComboBox_Ziel
        '
        Me.ComboBox_Ziel.FormattingEnabled = True
        Me.ComboBox_Ziel.Location = New System.Drawing.Point(49, 92)
        Me.ComboBox_Ziel.Name = "ComboBox_Ziel"
        Me.ComboBox_Ziel.Size = New System.Drawing.Size(171, 21)
        Me.ComboBox_Ziel.TabIndex = 2
        Me.ComboBox_Ziel.Text = "Alle Ziele"
        '
        'TextBox_Eingabe
        '
        Me.TextBox_Eingabe.Location = New System.Drawing.Point(49, 66)
        Me.TextBox_Eingabe.Name = "TextBox_Eingabe"
        Me.TextBox_Eingabe.Size = New System.Drawing.Size(171, 20)
        Me.TextBox_Eingabe.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "zu zahlen"
        '
        'TextBox_Preis
        '
        Me.TextBox_Preis.Location = New System.Drawing.Point(500, 70)
        Me.TextBox_Preis.Name = "TextBox_Preis"
        Me.TextBox_Preis.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Preis.TabIndex = 5
        '
        'GroupBox_Fahrkarte
        '
        Me.GroupBox_Fahrkarte.Controls.Add(Me.RadioButton_Woche)
        Me.GroupBox_Fahrkarte.Controls.Add(Me.RadioButton_Gruppe)
        Me.GroupBox_Fahrkarte.Controls.Add(Me.RadioButton_Tages)
        Me.GroupBox_Fahrkarte.Controls.Add(Me.RadioButton_HinRueck)
        Me.GroupBox_Fahrkarte.Controls.Add(Me.RadioButton_Einfach)
        Me.GroupBox_Fahrkarte.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox_Fahrkarte.Name = "GroupBox_Fahrkarte"
        Me.GroupBox_Fahrkarte.Size = New System.Drawing.Size(134, 136)
        Me.GroupBox_Fahrkarte.TabIndex = 6
        Me.GroupBox_Fahrkarte.TabStop = False
        Me.GroupBox_Fahrkarte.Text = "Fahrkarte"
        '
        'RadioButton_Woche
        '
        Me.RadioButton_Woche.AutoSize = True
        Me.RadioButton_Woche.Location = New System.Drawing.Point(6, 111)
        Me.RadioButton_Woche.Name = "RadioButton_Woche"
        Me.RadioButton_Woche.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_Woche.TabIndex = 4
        Me.RadioButton_Woche.Text = "Wochenkarte"
        Me.RadioButton_Woche.UseVisualStyleBackColor = True
        '
        'RadioButton_Gruppe
        '
        Me.RadioButton_Gruppe.AutoSize = True
        Me.RadioButton_Gruppe.Location = New System.Drawing.Point(6, 88)
        Me.RadioButton_Gruppe.Name = "RadioButton_Gruppe"
        Me.RadioButton_Gruppe.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_Gruppe.TabIndex = 3
        Me.RadioButton_Gruppe.Text = "Gruppenkarte"
        Me.RadioButton_Gruppe.UseVisualStyleBackColor = True
        '
        'RadioButton_Tages
        '
        Me.RadioButton_Tages.AutoSize = True
        Me.RadioButton_Tages.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton_Tages.Name = "RadioButton_Tages"
        Me.RadioButton_Tages.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton_Tages.TabIndex = 2
        Me.RadioButton_Tages.Text = "Tageskarte"
        Me.RadioButton_Tages.UseVisualStyleBackColor = True
        '
        'RadioButton_HinRueck
        '
        Me.RadioButton_HinRueck.AutoSize = True
        Me.RadioButton_HinRueck.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_HinRueck.Name = "RadioButton_HinRueck"
        Me.RadioButton_HinRueck.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton_HinRueck.TabIndex = 1
        Me.RadioButton_HinRueck.Text = "Hin- und Rückfahrt"
        Me.RadioButton_HinRueck.UseVisualStyleBackColor = True
        '
        'RadioButton_Einfach
        '
        Me.RadioButton_Einfach.AutoSize = True
        Me.RadioButton_Einfach.Checked = True
        Me.RadioButton_Einfach.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_Einfach.Name = "RadioButton_Einfach"
        Me.RadioButton_Einfach.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton_Einfach.TabIndex = 0
        Me.RadioButton_Einfach.TabStop = True
        Me.RadioButton_Einfach.Text = "EinfachFahrt"
        Me.RadioButton_Einfach.UseVisualStyleBackColor = True
        '
        'GroupBox_Reis
        '
        Me.GroupBox_Reis.Controls.Add(Me.RadioButton_Hund)
        Me.GroupBox_Reis.Controls.Add(Me.RadioButton_Fahrrad)
        Me.GroupBox_Reis.Controls.Add(Me.RadioButton_SchweBi)
        Me.GroupBox_Reis.Controls.Add(Me.RadioButton_Azubi)
        Me.GroupBox_Reis.Controls.Add(Me.RadioButton_Erwachsen)
        Me.GroupBox_Reis.Controls.Add(Me.RadioButton_Kind)
        Me.GroupBox_Reis.Location = New System.Drawing.Point(152, 139)
        Me.GroupBox_Reis.Name = "GroupBox_Reis"
        Me.GroupBox_Reis.Size = New System.Drawing.Size(127, 161)
        Me.GroupBox_Reis.TabIndex = 7
        Me.GroupBox_Reis.TabStop = False
        Me.GroupBox_Reis.Text = "Reisende(r)"
        '
        'RadioButton_Hund
        '
        Me.RadioButton_Hund.AutoSize = True
        Me.RadioButton_Hund.Location = New System.Drawing.Point(7, 135)
        Me.RadioButton_Hund.Name = "RadioButton_Hund"
        Me.RadioButton_Hund.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton_Hund.TabIndex = 5
        Me.RadioButton_Hund.Text = "WauWau"
        Me.RadioButton_Hund.UseVisualStyleBackColor = True
        '
        'RadioButton_Fahrrad
        '
        Me.RadioButton_Fahrrad.AutoSize = True
        Me.RadioButton_Fahrrad.Location = New System.Drawing.Point(7, 111)
        Me.RadioButton_Fahrrad.Name = "RadioButton_Fahrrad"
        Me.RadioButton_Fahrrad.Size = New System.Drawing.Size(61, 17)
        Me.RadioButton_Fahrrad.TabIndex = 4
        Me.RadioButton_Fahrrad.Text = "Fahrrad"
        Me.RadioButton_Fahrrad.UseVisualStyleBackColor = True
        '
        'RadioButton_SchweBi
        '
        Me.RadioButton_SchweBi.AutoSize = True
        Me.RadioButton_SchweBi.Location = New System.Drawing.Point(7, 90)
        Me.RadioButton_SchweBi.Name = "RadioButton_SchweBi"
        Me.RadioButton_SchweBi.Size = New System.Drawing.Size(114, 17)
        Me.RadioButton_SchweBi.TabIndex = 3
        Me.RadioButton_SchweBi.Text = "Schwerbehinderter"
        Me.RadioButton_SchweBi.UseVisualStyleBackColor = True
        '
        'RadioButton_Azubi
        '
        Me.RadioButton_Azubi.AutoSize = True
        Me.RadioButton_Azubi.Location = New System.Drawing.Point(7, 66)
        Me.RadioButton_Azubi.Name = "RadioButton_Azubi"
        Me.RadioButton_Azubi.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton_Azubi.TabIndex = 2
        Me.RadioButton_Azubi.Text = "Auszubildender"
        Me.RadioButton_Azubi.UseVisualStyleBackColor = True
        '
        'RadioButton_Erwachsen
        '
        Me.RadioButton_Erwachsen.AutoSize = True
        Me.RadioButton_Erwachsen.Location = New System.Drawing.Point(7, 42)
        Me.RadioButton_Erwachsen.Name = "RadioButton_Erwachsen"
        Me.RadioButton_Erwachsen.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton_Erwachsen.TabIndex = 1
        Me.RadioButton_Erwachsen.Text = "Erwachsene"
        Me.RadioButton_Erwachsen.UseVisualStyleBackColor = True
        '
        'RadioButton_Kind
        '
        Me.RadioButton_Kind.AutoSize = True
        Me.RadioButton_Kind.Checked = True
        Me.RadioButton_Kind.Location = New System.Drawing.Point(7, 19)
        Me.RadioButton_Kind.Name = "RadioButton_Kind"
        Me.RadioButton_Kind.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton_Kind.TabIndex = 0
        Me.RadioButton_Kind.TabStop = True
        Me.RadioButton_Kind.Text = "Kind"
        Me.RadioButton_Kind.UseVisualStyleBackColor = True
        '
        'ComboBox_Pay_Typ
        '
        Me.ComboBox_Pay_Typ.FormattingEnabled = True
        Me.ComboBox_Pay_Typ.Location = New System.Drawing.Point(303, 158)
        Me.ComboBox_Pay_Typ.Name = "ComboBox_Pay_Typ"
        Me.ComboBox_Pay_Typ.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox_Pay_Typ.TabIndex = 8
        Me.ComboBox_Pay_Typ.Text = "Zahlungs Methoden"
        '
        'TextBox_KontNr
        '
        Me.TextBox_KontNr.Location = New System.Drawing.Point(303, 193)
        Me.TextBox_KontNr.Name = "TextBox_KontNr"
        Me.TextBox_KontNr.Size = New System.Drawing.Size(155, 20)
        Me.TextBox_KontNr.TabIndex = 9
        '
        'TextBox_Check_Nr
        '
        Me.TextBox_Check_Nr.Location = New System.Drawing.Point(303, 219)
        Me.TextBox_Check_Nr.Name = "TextBox_Check_Nr"
        Me.TextBox_Check_Nr.Size = New System.Drawing.Size(76, 20)
        Me.TextBox_Check_Nr.TabIndex = 10
        '
        'TextBox_PayPal
        '
        Me.TextBox_PayPal.Location = New System.Drawing.Point(303, 255)
        Me.TextBox_PayPal.Name = "TextBox_PayPal"
        Me.TextBox_PayPal.Size = New System.Drawing.Size(155, 20)
        Me.TextBox_PayPal.TabIndex = 11
        '
        'TextBox_PayPal_Pw
        '
        Me.TextBox_PayPal_Pw.Location = New System.Drawing.Point(303, 281)
        Me.TextBox_PayPal_Pw.Name = "TextBox_PayPal_Pw"
        Me.TextBox_PayPal_Pw.Size = New System.Drawing.Size(76, 20)
        Me.TextBox_PayPal_Pw.TabIndex = 12
        '
        'Button_OK_Order
        '
        Me.Button_OK_Order.Location = New System.Drawing.Point(385, 281)
        Me.Button_OK_Order.Name = "Button_OK_Order"
        Me.Button_OK_Order.Size = New System.Drawing.Size(75, 23)
        Me.Button_OK_Order.TabIndex = 13
        Me.Button_OK_Order.Text = "OK / Order"
        Me.Button_OK_Order.UseVisualStyleBackColor = True
        '
        'GroupBox_geld
        '
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_Kom)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_9)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_6)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_3)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_0)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_8)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_5)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_2)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_Del)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_7)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_4)
        Me.GroupBox_geld.Controls.Add(Me.Button_Geld_1)
        Me.GroupBox_geld.Location = New System.Drawing.Point(482, 139)
        Me.GroupBox_geld.Name = "GroupBox_geld"
        Me.GroupBox_geld.Size = New System.Drawing.Size(118, 165)
        Me.GroupBox_geld.TabIndex = 14
        Me.GroupBox_geld.TabStop = False
        Me.GroupBox_geld.Text = "GroupBox2"
        '
        'Button_Geld_Kom
        '
        Me.Button_Geld_Kom.Location = New System.Drawing.Point(78, 127)
        Me.Button_Geld_Kom.Name = "Button_Geld_Kom"
        Me.Button_Geld_Kom.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_Kom.TabIndex = 11
        Me.Button_Geld_Kom.Text = ","
        Me.Button_Geld_Kom.UseVisualStyleBackColor = True
        '
        'Button_Geld_9
        '
        Me.Button_Geld_9.Location = New System.Drawing.Point(78, 91)
        Me.Button_Geld_9.Name = "Button_Geld_9"
        Me.Button_Geld_9.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_9.TabIndex = 10
        Me.Button_Geld_9.Text = "9"
        Me.Button_Geld_9.UseVisualStyleBackColor = True
        '
        'Button_Geld_6
        '
        Me.Button_Geld_6.Location = New System.Drawing.Point(78, 55)
        Me.Button_Geld_6.Name = "Button_Geld_6"
        Me.Button_Geld_6.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_6.TabIndex = 9
        Me.Button_Geld_6.Text = "6"
        Me.Button_Geld_6.UseVisualStyleBackColor = True
        '
        'Button_Geld_3
        '
        Me.Button_Geld_3.Location = New System.Drawing.Point(78, 19)
        Me.Button_Geld_3.Name = "Button_Geld_3"
        Me.Button_Geld_3.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_3.TabIndex = 8
        Me.Button_Geld_3.Text = "3"
        Me.Button_Geld_3.UseVisualStyleBackColor = True
        '
        'Button_Geld_0
        '
        Me.Button_Geld_0.Location = New System.Drawing.Point(42, 127)
        Me.Button_Geld_0.Name = "Button_Geld_0"
        Me.Button_Geld_0.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_0.TabIndex = 7
        Me.Button_Geld_0.Text = "0"
        Me.Button_Geld_0.UseVisualStyleBackColor = True
        '
        'Button_Geld_8
        '
        Me.Button_Geld_8.Location = New System.Drawing.Point(42, 91)
        Me.Button_Geld_8.Name = "Button_Geld_8"
        Me.Button_Geld_8.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_8.TabIndex = 6
        Me.Button_Geld_8.Text = "8"
        Me.Button_Geld_8.UseVisualStyleBackColor = True
        '
        'Button_Geld_5
        '
        Me.Button_Geld_5.Location = New System.Drawing.Point(42, 55)
        Me.Button_Geld_5.Name = "Button_Geld_5"
        Me.Button_Geld_5.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_5.TabIndex = 5
        Me.Button_Geld_5.Text = "5"
        Me.Button_Geld_5.UseVisualStyleBackColor = True
        '
        'Button_Geld_2
        '
        Me.Button_Geld_2.Location = New System.Drawing.Point(42, 19)
        Me.Button_Geld_2.Name = "Button_Geld_2"
        Me.Button_Geld_2.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_2.TabIndex = 4
        Me.Button_Geld_2.Text = "2"
        Me.Button_Geld_2.UseVisualStyleBackColor = True
        '
        'Button_Geld_Del
        '
        Me.Button_Geld_Del.Location = New System.Drawing.Point(6, 127)
        Me.Button_Geld_Del.Name = "Button_Geld_Del"
        Me.Button_Geld_Del.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_Del.TabIndex = 3
        Me.Button_Geld_Del.Text = "del"
        Me.Button_Geld_Del.UseVisualStyleBackColor = True
        '
        'Button_Geld_7
        '
        Me.Button_Geld_7.Location = New System.Drawing.Point(6, 91)
        Me.Button_Geld_7.Name = "Button_Geld_7"
        Me.Button_Geld_7.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_7.TabIndex = 2
        Me.Button_Geld_7.Text = "7"
        Me.Button_Geld_7.UseVisualStyleBackColor = True
        '
        'Button_Geld_4
        '
        Me.Button_Geld_4.Location = New System.Drawing.Point(6, 55)
        Me.Button_Geld_4.Name = "Button_Geld_4"
        Me.Button_Geld_4.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_4.TabIndex = 1
        Me.Button_Geld_4.Text = "4"
        Me.Button_Geld_4.UseVisualStyleBackColor = True
        '
        'Button_Geld_1
        '
        Me.Button_Geld_1.Location = New System.Drawing.Point(6, 19)
        Me.Button_Geld_1.Name = "Button_Geld_1"
        Me.Button_Geld_1.Size = New System.Drawing.Size(30, 30)
        Me.Button_Geld_1.TabIndex = 0
        Me.Button_Geld_1.Text = "1"
        Me.Button_Geld_1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 329)
        Me.Controls.Add(Me.GroupBox_geld)
        Me.Controls.Add(Me.Button_OK_Order)
        Me.Controls.Add(Me.TextBox_PayPal_Pw)
        Me.Controls.Add(Me.TextBox_PayPal)
        Me.Controls.Add(Me.TextBox_Check_Nr)
        Me.Controls.Add(Me.TextBox_KontNr)
        Me.Controls.Add(Me.ComboBox_Pay_Typ)
        Me.Controls.Add(Me.GroupBox_Reis)
        Me.Controls.Add(Me.GroupBox_Fahrkarte)
        Me.Controls.Add(Me.TextBox_Preis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Eingabe)
        Me.Controls.Add(Me.ComboBox_Ziel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Aufgabe 5"
        Me.GroupBox_Fahrkarte.ResumeLayout(False)
        Me.GroupBox_Fahrkarte.PerformLayout()
        Me.GroupBox_Reis.ResumeLayout(False)
        Me.GroupBox_Reis.PerformLayout()
        Me.GroupBox_geld.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_Ziel As ComboBox
    Friend WithEvents TextBox_Eingabe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Preis As TextBox
    Friend WithEvents GroupBox_Fahrkarte As GroupBox
    Friend WithEvents RadioButton_Woche As RadioButton
    Friend WithEvents RadioButton_Gruppe As RadioButton
    Friend WithEvents RadioButton_Tages As RadioButton
    Friend WithEvents RadioButton_HinRueck As RadioButton
    Friend WithEvents RadioButton_Einfach As RadioButton
    Friend WithEvents GroupBox_Reis As GroupBox
    Friend WithEvents RadioButton_Hund As RadioButton
    Friend WithEvents RadioButton_Fahrrad As RadioButton
    Friend WithEvents RadioButton_SchweBi As RadioButton
    Friend WithEvents RadioButton_Azubi As RadioButton
    Friend WithEvents RadioButton_Erwachsen As RadioButton
    Friend WithEvents RadioButton_Kind As RadioButton
    Friend WithEvents ComboBox_Pay_Typ As ComboBox
    Friend WithEvents TextBox_KontNr As TextBox
    Friend WithEvents TextBox_Check_Nr As TextBox
    Friend WithEvents TextBox_PayPal As TextBox
    Friend WithEvents TextBox_PayPal_Pw As TextBox
    Friend WithEvents Button_OK_Order As Button
    Friend WithEvents GroupBox_geld As GroupBox
    Friend WithEvents Button_Geld_Kom As Button
    Friend WithEvents Button_Geld_9 As Button
    Friend WithEvents Button_Geld_6 As Button
    Friend WithEvents Button_Geld_3 As Button
    Friend WithEvents Button_Geld_0 As Button
    Friend WithEvents Button_Geld_8 As Button
    Friend WithEvents Button_Geld_5 As Button
    Friend WithEvents Button_Geld_2 As Button
    Friend WithEvents Button_Geld_Del As Button
    Friend WithEvents Button_Geld_7 As Button
    Friend WithEvents Button_Geld_4 As Button
    Friend WithEvents Button_Geld_1 As Button
End Class
