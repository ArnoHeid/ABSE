<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.TextBox_Vorname = New System.Windows.Forms.TextBox()
        Me.TextBox_Nachname = New System.Windows.Forms.TextBox()
        Me.TextBox_PLZ = New System.Windows.Forms.TextBox()
        Me.TextBox_Stadt = New System.Windows.Forms.TextBox()
        Me.TextBox_Strasse = New System.Windows.Forms.TextBox()
        Me.TextBox_HausNr = New System.Windows.Forms.TextBox()
        Me.Button_back = New System.Windows.Forms.Button()
        Me.Button_next = New System.Windows.Forms.Button()
        Me.Button_first = New System.Windows.Forms.Button()
        Me.Button_last = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vorname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nachname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PLZ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stadt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Straße"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hausnummer"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Enabled = False
        Me.TextBox_ID.Location = New System.Drawing.Point(194, 12)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(62, 20)
        Me.TextBox_ID.TabIndex = 1
        '
        'TextBox_Vorname
        '
        Me.TextBox_Vorname.Location = New System.Drawing.Point(99, 38)
        Me.TextBox_Vorname.Name = "TextBox_Vorname"
        Me.TextBox_Vorname.Size = New System.Drawing.Size(157, 20)
        Me.TextBox_Vorname.TabIndex = 2
        '
        'TextBox_Nachname
        '
        Me.TextBox_Nachname.Location = New System.Drawing.Point(99, 64)
        Me.TextBox_Nachname.Name = "TextBox_Nachname"
        Me.TextBox_Nachname.Size = New System.Drawing.Size(157, 20)
        Me.TextBox_Nachname.TabIndex = 3
        '
        'TextBox_PLZ
        '
        Me.TextBox_PLZ.Location = New System.Drawing.Point(194, 90)
        Me.TextBox_PLZ.Name = "TextBox_PLZ"
        Me.TextBox_PLZ.Size = New System.Drawing.Size(62, 20)
        Me.TextBox_PLZ.TabIndex = 4
        '
        'TextBox_Stadt
        '
        Me.TextBox_Stadt.Location = New System.Drawing.Point(99, 116)
        Me.TextBox_Stadt.Name = "TextBox_Stadt"
        Me.TextBox_Stadt.Size = New System.Drawing.Size(157, 20)
        Me.TextBox_Stadt.TabIndex = 5
        '
        'TextBox_Strasse
        '
        Me.TextBox_Strasse.Location = New System.Drawing.Point(99, 142)
        Me.TextBox_Strasse.Name = "TextBox_Strasse"
        Me.TextBox_Strasse.Size = New System.Drawing.Size(157, 20)
        Me.TextBox_Strasse.TabIndex = 6
        '
        'TextBox_HausNr
        '
        Me.TextBox_HausNr.Location = New System.Drawing.Point(194, 168)
        Me.TextBox_HausNr.Name = "TextBox_HausNr"
        Me.TextBox_HausNr.Size = New System.Drawing.Size(62, 20)
        Me.TextBox_HausNr.TabIndex = 7
        '
        'Button_back
        '
        Me.Button_back.Location = New System.Drawing.Point(298, 30)
        Me.Button_back.Name = "Button_back"
        Me.Button_back.Size = New System.Drawing.Size(50, 50)
        Me.Button_back.TabIndex = 15
        Me.Button_back.Text = "<"
        Me.Button_back.UseVisualStyleBackColor = True
        '
        'Button_next
        '
        Me.Button_next.Location = New System.Drawing.Point(354, 30)
        Me.Button_next.Name = "Button_next"
        Me.Button_next.Size = New System.Drawing.Size(50, 50)
        Me.Button_next.TabIndex = 16
        Me.Button_next.Text = ">"
        Me.Button_next.UseVisualStyleBackColor = True
        '
        'Button_first
        '
        Me.Button_first.Location = New System.Drawing.Point(298, 86)
        Me.Button_first.Name = "Button_first"
        Me.Button_first.Size = New System.Drawing.Size(50, 50)
        Me.Button_first.TabIndex = 17
        Me.Button_first.Text = "Erstes"
        Me.Button_first.UseVisualStyleBackColor = True
        '
        'Button_last
        '
        Me.Button_last.Location = New System.Drawing.Point(354, 85)
        Me.Button_last.Name = "Button_last"
        Me.Button_last.Size = New System.Drawing.Size(50, 50)
        Me.Button_last.TabIndex = 18
        Me.Button_last.Text = "Letztes"
        Me.Button_last.UseVisualStyleBackColor = True
        '
        'Button_Exit
        '
        Me.Button_Exit.Location = New System.Drawing.Point(310, 145)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Exit.TabIndex = 19
        Me.Button_Exit.Text = "Ende"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(329, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Blättern"
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 196)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.Button_last)
        Me.Controls.Add(Me.Button_first)
        Me.Controls.Add(Me.Button_next)
        Me.Controls.Add(Me.Button_back)
        Me.Controls.Add(Me.TextBox_HausNr)
        Me.Controls.Add(Me.TextBox_Strasse)
        Me.Controls.Add(Me.TextBox_Stadt)
        Me.Controls.Add(Me.TextBox_PLZ)
        Me.Controls.Add(Me.TextBox_Nachname)
        Me.Controls.Add(Me.TextBox_Vorname)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Viewer"
        Me.Text = "Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents TextBox_Vorname As TextBox
    Friend WithEvents TextBox_Nachname As TextBox
    Friend WithEvents TextBox_PLZ As TextBox
    Friend WithEvents TextBox_Stadt As TextBox
    Friend WithEvents TextBox_Strasse As TextBox
    Friend WithEvents TextBox_HausNr As TextBox
    Friend WithEvents Button_back As Button
    Friend WithEvents Button_next As Button
    Friend WithEvents Button_first As Button
    Friend WithEvents Button_last As Button
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Label8 As Label
End Class
