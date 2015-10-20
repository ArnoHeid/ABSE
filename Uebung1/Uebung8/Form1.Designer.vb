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
        Me.GroupBox_Auswahl = New System.Windows.Forms.GroupBox()
        Me.RadioButton_ZKord = New System.Windows.Forms.RadioButton()
        Me.RadioButton_YKord = New System.Windows.Forms.RadioButton()
        Me.RadioButton_XKord = New System.Windows.Forms.RadioButton()
        Me.RadioButton_PunktNr = New System.Windows.Forms.RadioButton()
        Me.Button_FileOpen = New System.Windows.Forms.Button()
        Me.Button_ExportFile = New System.Windows.Forms.Button()
        Me.Button_export = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.GroupBox_Auswahl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Auswahl
        '
        Me.GroupBox_Auswahl.Controls.Add(Me.RadioButton_ZKord)
        Me.GroupBox_Auswahl.Controls.Add(Me.RadioButton_YKord)
        Me.GroupBox_Auswahl.Controls.Add(Me.RadioButton_XKord)
        Me.GroupBox_Auswahl.Controls.Add(Me.RadioButton_PunktNr)
        Me.GroupBox_Auswahl.Enabled = False
        Me.GroupBox_Auswahl.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_Auswahl.Name = "GroupBox_Auswahl"
        Me.GroupBox_Auswahl.Size = New System.Drawing.Size(98, 113)
        Me.GroupBox_Auswahl.TabIndex = 0
        Me.GroupBox_Auswahl.TabStop = False
        Me.GroupBox_Auswahl.Text = "Auswahl"
        '
        'RadioButton_ZKord
        '
        Me.RadioButton_ZKord.AutoSize = True
        Me.RadioButton_ZKord.Location = New System.Drawing.Point(6, 88)
        Me.RadioButton_ZKord.Name = "RadioButton_ZKord"
        Me.RadioButton_ZKord.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton_ZKord.TabIndex = 3
        Me.RadioButton_ZKord.TabStop = True
        Me.RadioButton_ZKord.Text = "Z-Koordinate"
        Me.RadioButton_ZKord.UseVisualStyleBackColor = True
        '
        'RadioButton_YKord
        '
        Me.RadioButton_YKord.AutoSize = True
        Me.RadioButton_YKord.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton_YKord.Name = "RadioButton_YKord"
        Me.RadioButton_YKord.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton_YKord.TabIndex = 2
        Me.RadioButton_YKord.TabStop = True
        Me.RadioButton_YKord.Text = "Y-Koordinate"
        Me.RadioButton_YKord.UseVisualStyleBackColor = True
        '
        'RadioButton_XKord
        '
        Me.RadioButton_XKord.AutoSize = True
        Me.RadioButton_XKord.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_XKord.Name = "RadioButton_XKord"
        Me.RadioButton_XKord.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton_XKord.TabIndex = 1
        Me.RadioButton_XKord.TabStop = True
        Me.RadioButton_XKord.Text = "X-Koordinate"
        Me.RadioButton_XKord.UseVisualStyleBackColor = True
        '
        'RadioButton_PunktNr
        '
        Me.RadioButton_PunktNr.AutoSize = True
        Me.RadioButton_PunktNr.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_PunktNr.Name = "RadioButton_PunktNr"
        Me.RadioButton_PunktNr.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton_PunktNr.TabIndex = 0
        Me.RadioButton_PunktNr.TabStop = True
        Me.RadioButton_PunktNr.Text = "Punkt Nr."
        Me.RadioButton_PunktNr.UseVisualStyleBackColor = True
        '
        'Button_FileOpen
        '
        Me.Button_FileOpen.Location = New System.Drawing.Point(116, 12)
        Me.Button_FileOpen.Name = "Button_FileOpen"
        Me.Button_FileOpen.Size = New System.Drawing.Size(134, 23)
        Me.Button_FileOpen.TabIndex = 1
        Me.Button_FileOpen.Text = "File Öffnen"
        Me.Button_FileOpen.UseVisualStyleBackColor = True
        '
        'Button_ExportFile
        '
        Me.Button_ExportFile.Enabled = False
        Me.Button_ExportFile.Location = New System.Drawing.Point(116, 41)
        Me.Button_ExportFile.Name = "Button_ExportFile"
        Me.Button_ExportFile.Size = New System.Drawing.Size(134, 23)
        Me.Button_ExportFile.TabIndex = 2
        Me.Button_ExportFile.Text = "Ausgabefile wählen"
        Me.Button_ExportFile.UseVisualStyleBackColor = True
        '
        'Button_export
        '
        Me.Button_export.Enabled = False
        Me.Button_export.Location = New System.Drawing.Point(116, 70)
        Me.Button_export.Name = "Button_export"
        Me.Button_export.Size = New System.Drawing.Size(134, 23)
        Me.Button_export.TabIndex = 3
        Me.Button_export.Text = "Daten extrahieren"
        Me.Button_export.UseVisualStyleBackColor = True
        '
        'Button_Exit
        '
        Me.Button_Exit.Location = New System.Drawing.Point(116, 99)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(134, 23)
        Me.Button_Exit.TabIndex = 4
        Me.Button_Exit.Text = "Ende"
        Me.Button_Exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 127)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.Button_export)
        Me.Controls.Add(Me.Button_ExportFile)
        Me.Controls.Add(Me.Button_FileOpen)
        Me.Controls.Add(Me.GroupBox_Auswahl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox_Auswahl.ResumeLayout(False)
        Me.GroupBox_Auswahl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_Auswahl As GroupBox
    Friend WithEvents RadioButton_ZKord As RadioButton
    Friend WithEvents RadioButton_YKord As RadioButton
    Friend WithEvents RadioButton_XKord As RadioButton
    Friend WithEvents RadioButton_PunktNr As RadioButton
    Friend WithEvents Button_FileOpen As Button
    Friend WithEvents Button_ExportFile As Button
    Friend WithEvents Button_export As Button
    Friend WithEvents Button_Exit As Button
End Class
