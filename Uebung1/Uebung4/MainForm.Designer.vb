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
        Me.GroupBox_getraenke = New System.Windows.Forms.GroupBox()
        Me.GroupBox_auswahl = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Espresso = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Wasser = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Cappucino = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Tee = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Kaffee = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_big = New System.Windows.Forms.RadioButton()
        Me.RadioButton_small = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Preis = New System.Windows.Forms.GroupBox()
        Me.Label_Espresso = New System.Windows.Forms.Label()
        Me.Label_Cappucino = New System.Windows.Forms.Label()
        Me.Label_Kaffee = New System.Windows.Forms.Label()
        Me.Label_Tee = New System.Windows.Forms.Label()
        Me.Label_Wasser = New System.Windows.Forms.Label()
        Me.GroupBox_Zutaten = New System.Windows.Forms.GroupBox()
        Me.Label_Sahne = New System.Windows.Forms.Label()
        Me.Label_Zucker = New System.Windows.Forms.Label()
        Me.Label_Milch = New System.Windows.Forms.Label()
        Me.CheckBox_Sahne = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Zucker = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Milch = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Geld = New System.Windows.Forms.GroupBox()
        Me.Button_5Cent = New System.Windows.Forms.Button()
        Me.Button_10Cent = New System.Windows.Forms.Button()
        Me.Button_20Cent = New System.Windows.Forms.Button()
        Me.Button_50Cent = New System.Windows.Forms.Button()
        Me.Button_1Euro = New System.Windows.Forms.Button()
        Me.Button_2Euro = New System.Windows.Forms.Button()
        Me.Button_5Euro = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.TextBox_toPay = New System.Windows.Forms.TextBox()
        Me.TextBox_Back = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_pay = New System.Windows.Forms.Button()
        Me.CheckBox_Freunde = New System.Windows.Forms.CheckBox()
        Me.GroupBox_getraenke.SuspendLayout()
        Me.GroupBox_auswahl.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox_Preis.SuspendLayout()
        Me.GroupBox_Zutaten.SuspendLayout()
        Me.GroupBox_Geld.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_getraenke
        '
        Me.GroupBox_getraenke.Controls.Add(Me.CheckBox_Freunde)
        Me.GroupBox_getraenke.Controls.Add(Me.GroupBox_auswahl)
        Me.GroupBox_getraenke.Controls.Add(Me.GroupBox3)
        Me.GroupBox_getraenke.Controls.Add(Me.GroupBox_Preis)
        Me.GroupBox_getraenke.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox_getraenke.Name = "GroupBox_getraenke"
        Me.GroupBox_getraenke.Size = New System.Drawing.Size(192, 250)
        Me.GroupBox_getraenke.TabIndex = 0
        Me.GroupBox_getraenke.TabStop = False
        Me.GroupBox_getraenke.Text = "Getränke"
        '
        'GroupBox_auswahl
        '
        Me.GroupBox_auswahl.Controls.Add(Me.RadioButton_Espresso)
        Me.GroupBox_auswahl.Controls.Add(Me.RadioButton_Wasser)
        Me.GroupBox_auswahl.Controls.Add(Me.RadioButton_Cappucino)
        Me.GroupBox_auswahl.Controls.Add(Me.RadioButton_Tee)
        Me.GroupBox_auswahl.Controls.Add(Me.RadioButton_Kaffee)
        Me.GroupBox_auswahl.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox_auswahl.Name = "GroupBox_auswahl"
        Me.GroupBox_auswahl.Size = New System.Drawing.Size(115, 137)
        Me.GroupBox_auswahl.TabIndex = 7
        Me.GroupBox_auswahl.TabStop = False
        Me.GroupBox_auswahl.Text = "Auswahl"
        '
        'RadioButton_Espresso
        '
        Me.RadioButton_Espresso.AutoSize = True
        Me.RadioButton_Espresso.Location = New System.Drawing.Point(6, 111)
        Me.RadioButton_Espresso.Name = "RadioButton_Espresso"
        Me.RadioButton_Espresso.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton_Espresso.TabIndex = 6
        Me.RadioButton_Espresso.TabStop = True
        Me.RadioButton_Espresso.Text = "Espresso"
        Me.RadioButton_Espresso.UseVisualStyleBackColor = True
        '
        'RadioButton_Wasser
        '
        Me.RadioButton_Wasser.AutoSize = True
        Me.RadioButton_Wasser.Checked = True
        Me.RadioButton_Wasser.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_Wasser.Name = "RadioButton_Wasser"
        Me.RadioButton_Wasser.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton_Wasser.TabIndex = 2
        Me.RadioButton_Wasser.TabStop = True
        Me.RadioButton_Wasser.Text = "Mineralwasser"
        Me.RadioButton_Wasser.UseVisualStyleBackColor = True
        '
        'RadioButton_Cappucino
        '
        Me.RadioButton_Cappucino.AutoSize = True
        Me.RadioButton_Cappucino.Location = New System.Drawing.Point(6, 88)
        Me.RadioButton_Cappucino.Name = "RadioButton_Cappucino"
        Me.RadioButton_Cappucino.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton_Cappucino.TabIndex = 5
        Me.RadioButton_Cappucino.TabStop = True
        Me.RadioButton_Cappucino.Text = "Cappucino"
        Me.RadioButton_Cappucino.UseVisualStyleBackColor = True
        '
        'RadioButton_Tee
        '
        Me.RadioButton_Tee.AutoSize = True
        Me.RadioButton_Tee.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_Tee.Name = "RadioButton_Tee"
        Me.RadioButton_Tee.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton_Tee.TabIndex = 3
        Me.RadioButton_Tee.TabStop = True
        Me.RadioButton_Tee.Text = "Tee"
        Me.RadioButton_Tee.UseVisualStyleBackColor = True
        '
        'RadioButton_Kaffee
        '
        Me.RadioButton_Kaffee.AutoSize = True
        Me.RadioButton_Kaffee.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton_Kaffee.Name = "RadioButton_Kaffee"
        Me.RadioButton_Kaffee.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton_Kaffee.TabIndex = 4
        Me.RadioButton_Kaffee.TabStop = True
        Me.RadioButton_Kaffee.Text = "Kaffee"
        Me.RadioButton_Kaffee.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton_big)
        Me.GroupBox3.Controls.Add(Me.RadioButton_small)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 169)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 67)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Größe"
        '
        'RadioButton_big
        '
        Me.RadioButton_big.AutoSize = True
        Me.RadioButton_big.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_big.Name = "RadioButton_big"
        Me.RadioButton_big.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton_big.TabIndex = 1
        Me.RadioButton_big.Text = "groß"
        Me.RadioButton_big.UseVisualStyleBackColor = True
        '
        'RadioButton_small
        '
        Me.RadioButton_small.AutoSize = True
        Me.RadioButton_small.Checked = True
        Me.RadioButton_small.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_small.Name = "RadioButton_small"
        Me.RadioButton_small.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton_small.TabIndex = 0
        Me.RadioButton_small.TabStop = True
        Me.RadioButton_small.Text = "klein"
        Me.RadioButton_small.UseVisualStyleBackColor = True
        '
        'GroupBox_Preis
        '
        Me.GroupBox_Preis.Controls.Add(Me.Label_Espresso)
        Me.GroupBox_Preis.Controls.Add(Me.Label_Cappucino)
        Me.GroupBox_Preis.Controls.Add(Me.Label_Kaffee)
        Me.GroupBox_Preis.Controls.Add(Me.Label_Tee)
        Me.GroupBox_Preis.Controls.Add(Me.Label_Wasser)
        Me.GroupBox_Preis.Location = New System.Drawing.Point(126, 19)
        Me.GroupBox_Preis.Name = "GroupBox_Preis"
        Me.GroupBox_Preis.Size = New System.Drawing.Size(54, 137)
        Me.GroupBox_Preis.TabIndex = 0
        Me.GroupBox_Preis.TabStop = False
        Me.GroupBox_Preis.Text = "Preis"
        '
        'Label_Espresso
        '
        Me.Label_Espresso.AutoSize = True
        Me.Label_Espresso.Location = New System.Drawing.Point(6, 116)
        Me.Label_Espresso.Name = "Label_Espresso"
        Me.Label_Espresso.Size = New System.Drawing.Size(28, 13)
        Me.Label_Espresso.TabIndex = 4
        Me.Label_Espresso.Text = "1,50"
        '
        'Label_Cappucino
        '
        Me.Label_Cappucino.AutoSize = True
        Me.Label_Cappucino.Location = New System.Drawing.Point(6, 93)
        Me.Label_Cappucino.Name = "Label_Cappucino"
        Me.Label_Cappucino.Size = New System.Drawing.Size(28, 13)
        Me.Label_Cappucino.TabIndex = 3
        Me.Label_Cappucino.Text = "1,90"
        '
        'Label_Kaffee
        '
        Me.Label_Kaffee.AutoSize = True
        Me.Label_Kaffee.Location = New System.Drawing.Point(6, 70)
        Me.Label_Kaffee.Name = "Label_Kaffee"
        Me.Label_Kaffee.Size = New System.Drawing.Size(28, 13)
        Me.Label_Kaffee.TabIndex = 2
        Me.Label_Kaffee.Text = "1,20"
        '
        'Label_Tee
        '
        Me.Label_Tee.AutoSize = True
        Me.Label_Tee.Location = New System.Drawing.Point(6, 47)
        Me.Label_Tee.Name = "Label_Tee"
        Me.Label_Tee.Size = New System.Drawing.Size(28, 13)
        Me.Label_Tee.TabIndex = 1
        Me.Label_Tee.Text = "1,10"
        '
        'Label_Wasser
        '
        Me.Label_Wasser.AutoSize = True
        Me.Label_Wasser.Location = New System.Drawing.Point(6, 24)
        Me.Label_Wasser.Name = "Label_Wasser"
        Me.Label_Wasser.Size = New System.Drawing.Size(28, 13)
        Me.Label_Wasser.TabIndex = 0
        Me.Label_Wasser.Text = "0,80"
        '
        'GroupBox_Zutaten
        '
        Me.GroupBox_Zutaten.Controls.Add(Me.Label_Sahne)
        Me.GroupBox_Zutaten.Controls.Add(Me.Label_Zucker)
        Me.GroupBox_Zutaten.Controls.Add(Me.Label_Milch)
        Me.GroupBox_Zutaten.Controls.Add(Me.CheckBox_Sahne)
        Me.GroupBox_Zutaten.Controls.Add(Me.CheckBox_Zucker)
        Me.GroupBox_Zutaten.Controls.Add(Me.CheckBox_Milch)
        Me.GroupBox_Zutaten.Location = New System.Drawing.Point(210, 207)
        Me.GroupBox_Zutaten.Name = "GroupBox_Zutaten"
        Me.GroupBox_Zutaten.Size = New System.Drawing.Size(156, 92)
        Me.GroupBox_Zutaten.TabIndex = 1
        Me.GroupBox_Zutaten.TabStop = False
        Me.GroupBox_Zutaten.Text = "Zutaten"
        '
        'Label_Sahne
        '
        Me.Label_Sahne.AutoSize = True
        Me.Label_Sahne.Location = New System.Drawing.Point(87, 66)
        Me.Label_Sahne.Name = "Label_Sahne"
        Me.Label_Sahne.Size = New System.Drawing.Size(28, 13)
        Me.Label_Sahne.TabIndex = 5
        Me.Label_Sahne.Text = "0,50"
        '
        'Label_Zucker
        '
        Me.Label_Zucker.AutoSize = True
        Me.Label_Zucker.Location = New System.Drawing.Point(87, 43)
        Me.Label_Zucker.Name = "Label_Zucker"
        Me.Label_Zucker.Size = New System.Drawing.Size(28, 13)
        Me.Label_Zucker.TabIndex = 4
        Me.Label_Zucker.Text = "0,20"
        '
        'Label_Milch
        '
        Me.Label_Milch.AutoSize = True
        Me.Label_Milch.Location = New System.Drawing.Point(87, 20)
        Me.Label_Milch.Name = "Label_Milch"
        Me.Label_Milch.Size = New System.Drawing.Size(28, 13)
        Me.Label_Milch.TabIndex = 3
        Me.Label_Milch.Text = "0,30"
        '
        'CheckBox_Sahne
        '
        Me.CheckBox_Sahne.AutoSize = True
        Me.CheckBox_Sahne.Location = New System.Drawing.Point(6, 65)
        Me.CheckBox_Sahne.Name = "CheckBox_Sahne"
        Me.CheckBox_Sahne.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox_Sahne.TabIndex = 2
        Me.CheckBox_Sahne.Text = "Sahne"
        Me.CheckBox_Sahne.UseVisualStyleBackColor = True
        '
        'CheckBox_Zucker
        '
        Me.CheckBox_Zucker.AutoSize = True
        Me.CheckBox_Zucker.Location = New System.Drawing.Point(6, 42)
        Me.CheckBox_Zucker.Name = "CheckBox_Zucker"
        Me.CheckBox_Zucker.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox_Zucker.TabIndex = 1
        Me.CheckBox_Zucker.Text = "Zucker"
        Me.CheckBox_Zucker.UseVisualStyleBackColor = True
        '
        'CheckBox_Milch
        '
        Me.CheckBox_Milch.AutoSize = True
        Me.CheckBox_Milch.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox_Milch.Name = "CheckBox_Milch"
        Me.CheckBox_Milch.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox_Milch.TabIndex = 0
        Me.CheckBox_Milch.Text = "Milch"
        Me.CheckBox_Milch.UseVisualStyleBackColor = True
        '
        'GroupBox_Geld
        '
        Me.GroupBox_Geld.Controls.Add(Me.Button_5Cent)
        Me.GroupBox_Geld.Controls.Add(Me.Button_10Cent)
        Me.GroupBox_Geld.Controls.Add(Me.Button_20Cent)
        Me.GroupBox_Geld.Controls.Add(Me.Button_50Cent)
        Me.GroupBox_Geld.Controls.Add(Me.Button_1Euro)
        Me.GroupBox_Geld.Controls.Add(Me.Button_2Euro)
        Me.GroupBox_Geld.Controls.Add(Me.Button_5Euro)
        Me.GroupBox_Geld.Enabled = False
        Me.GroupBox_Geld.Location = New System.Drawing.Point(372, 162)
        Me.GroupBox_Geld.Name = "GroupBox_Geld"
        Me.GroupBox_Geld.Size = New System.Drawing.Size(172, 137)
        Me.GroupBox_Geld.TabIndex = 2
        Me.GroupBox_Geld.TabStop = False
        Me.GroupBox_Geld.Text = "Geldeingabe"
        '
        'Button_5Cent
        '
        Me.Button_5Cent.Location = New System.Drawing.Point(87, 106)
        Me.Button_5Cent.Name = "Button_5Cent"
        Me.Button_5Cent.Size = New System.Drawing.Size(75, 23)
        Me.Button_5Cent.TabIndex = 6
        Me.Button_5Cent.Text = "5 Cent"
        Me.Button_5Cent.UseVisualStyleBackColor = True
        '
        'Button_10Cent
        '
        Me.Button_10Cent.Location = New System.Drawing.Point(87, 77)
        Me.Button_10Cent.Name = "Button_10Cent"
        Me.Button_10Cent.Size = New System.Drawing.Size(75, 23)
        Me.Button_10Cent.TabIndex = 5
        Me.Button_10Cent.Text = "10 Cent"
        Me.Button_10Cent.UseVisualStyleBackColor = True
        '
        'Button_20Cent
        '
        Me.Button_20Cent.Location = New System.Drawing.Point(87, 48)
        Me.Button_20Cent.Name = "Button_20Cent"
        Me.Button_20Cent.Size = New System.Drawing.Size(75, 23)
        Me.Button_20Cent.TabIndex = 4
        Me.Button_20Cent.Text = "20 Cent"
        Me.Button_20Cent.UseVisualStyleBackColor = True
        '
        'Button_50Cent
        '
        Me.Button_50Cent.Location = New System.Drawing.Point(87, 19)
        Me.Button_50Cent.Name = "Button_50Cent"
        Me.Button_50Cent.Size = New System.Drawing.Size(75, 23)
        Me.Button_50Cent.TabIndex = 3
        Me.Button_50Cent.Text = "50 Cent"
        Me.Button_50Cent.UseVisualStyleBackColor = True
        '
        'Button_1Euro
        '
        Me.Button_1Euro.Location = New System.Drawing.Point(6, 77)
        Me.Button_1Euro.Name = "Button_1Euro"
        Me.Button_1Euro.Size = New System.Drawing.Size(75, 23)
        Me.Button_1Euro.TabIndex = 2
        Me.Button_1Euro.Text = "1 Euro"
        Me.Button_1Euro.UseVisualStyleBackColor = True
        '
        'Button_2Euro
        '
        Me.Button_2Euro.Location = New System.Drawing.Point(6, 48)
        Me.Button_2Euro.Name = "Button_2Euro"
        Me.Button_2Euro.Size = New System.Drawing.Size(75, 23)
        Me.Button_2Euro.TabIndex = 1
        Me.Button_2Euro.Text = "2 Euro"
        Me.Button_2Euro.UseVisualStyleBackColor = True
        '
        'Button_5Euro
        '
        Me.Button_5Euro.Location = New System.Drawing.Point(6, 19)
        Me.Button_5Euro.Name = "Button_5Euro"
        Me.Button_5Euro.Size = New System.Drawing.Size(75, 23)
        Me.Button_5Euro.TabIndex = 0
        Me.Button_5Euro.Text = "5 Euro"
        Me.Button_5Euro.UseVisualStyleBackColor = True
        '
        'Button_Exit
        '
        Me.Button_Exit.Location = New System.Drawing.Point(469, 305)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Exit.TabIndex = 3
        Me.Button_Exit.Text = "Ende"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'TextBox_toPay
        '
        Me.TextBox_toPay.Location = New System.Drawing.Point(444, 68)
        Me.TextBox_toPay.Name = "TextBox_toPay"
        Me.TextBox_toPay.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_toPay.TabIndex = 4
        '
        'TextBox_Back
        '
        Me.TextBox_Back.Enabled = False
        Me.TextBox_Back.Location = New System.Drawing.Point(444, 94)
        Me.TextBox_Back.Name = "TextBox_Back"
        Me.TextBox_Back.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Back.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "zu zahlender Betrag"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Rückgeld"
        '
        'Button_pay
        '
        Me.Button_pay.Location = New System.Drawing.Point(246, 148)
        Me.Button_pay.Name = "Button_pay"
        Me.Button_pay.Size = New System.Drawing.Size(75, 23)
        Me.Button_pay.TabIndex = 8
        Me.Button_pay.Text = "zur Kasse"
        Me.Button_pay.UseVisualStyleBackColor = True
        '
        'CheckBox_Freunde
        '
        Me.CheckBox_Freunde.AutoSize = True
        Me.CheckBox_Freunde.Location = New System.Drawing.Point(102, 188)
        Me.CheckBox_Freunde.Name = "CheckBox_Freunde"
        Me.CheckBox_Freunde.Size = New System.Drawing.Size(65, 30)
        Me.CheckBox_Freunde.TabIndex = 8
        Me.CheckBox_Freunde.Text = "Freunde" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rabat"
        Me.CheckBox_Freunde.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 339)
        Me.Controls.Add(Me.Button_pay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Back)
        Me.Controls.Add(Me.TextBox_toPay)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.GroupBox_Geld)
        Me.Controls.Add(Me.GroupBox_Zutaten)
        Me.Controls.Add(Me.GroupBox_getraenke)
        Me.Name = "MainForm"
        Me.Text = "Getränkeautomat"
        Me.GroupBox_getraenke.ResumeLayout(False)
        Me.GroupBox_getraenke.PerformLayout()
        Me.GroupBox_auswahl.ResumeLayout(False)
        Me.GroupBox_auswahl.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox_Preis.ResumeLayout(False)
        Me.GroupBox_Preis.PerformLayout()
        Me.GroupBox_Zutaten.ResumeLayout(False)
        Me.GroupBox_Zutaten.PerformLayout()
        Me.GroupBox_Geld.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_getraenke As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox_Preis As GroupBox
    Friend WithEvents GroupBox_Zutaten As GroupBox
    Friend WithEvents GroupBox_Geld As GroupBox
    Friend WithEvents Button_Exit As Button
    Friend WithEvents RadioButton_Espresso As RadioButton
    Friend WithEvents RadioButton_Cappucino As RadioButton
    Friend WithEvents RadioButton_Kaffee As RadioButton
    Friend WithEvents RadioButton_Tee As RadioButton
    Friend WithEvents RadioButton_Wasser As RadioButton
    Friend WithEvents RadioButton_big As RadioButton
    Friend WithEvents RadioButton_small As RadioButton
    Friend WithEvents Label_Espresso As Label
    Friend WithEvents Label_Cappucino As Label
    Friend WithEvents Label_Kaffee As Label
    Friend WithEvents Label_Tee As Label
    Friend WithEvents Label_Wasser As Label
    Friend WithEvents CheckBox_Sahne As CheckBox
    Friend WithEvents CheckBox_Zucker As CheckBox
    Friend WithEvents CheckBox_Milch As CheckBox
    Friend WithEvents Button_5Cent As Button
    Friend WithEvents Button_10Cent As Button
    Friend WithEvents Button_20Cent As Button
    Friend WithEvents Button_50Cent As Button
    Friend WithEvents Button_1Euro As Button
    Friend WithEvents Button_2Euro As Button
    Friend WithEvents Button_5Euro As Button
    Friend WithEvents TextBox_toPay As TextBox
    Friend WithEvents TextBox_Back As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_pay As Button
    Friend WithEvents Label_Sahne As Label
    Friend WithEvents Label_Zucker As Label
    Friend WithEvents Label_Milch As Label
    Friend WithEvents GroupBox_auswahl As GroupBox
    Friend WithEvents CheckBox_Freunde As CheckBox
End Class
