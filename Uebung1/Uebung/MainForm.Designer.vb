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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_ZKord = New System.Windows.Forms.CheckBox()
        Me.CheckBox_YKord = New System.Windows.Forms.CheckBox()
        Me.CheckBox_XKord = New System.Windows.Forms.CheckBox()
        Me.CheckBox_PunktNr = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Drucker = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Monitor = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Datei = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Target = New System.Windows.Forms.TextBox()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Ende = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox_ZKord)
        Me.GroupBox1.Controls.Add(Me.CheckBox_YKord)
        Me.GroupBox1.Controls.Add(Me.CheckBox_XKord)
        Me.GroupBox1.Controls.Add(Me.CheckBox_PunktNr)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ausgabe Optionen"
        '
        'CheckBox_ZKord
        '
        Me.CheckBox_ZKord.AutoSize = True
        Me.CheckBox_ZKord.Location = New System.Drawing.Point(6, 88)
        Me.CheckBox_ZKord.Name = "CheckBox_ZKord"
        Me.CheckBox_ZKord.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox_ZKord.TabIndex = 3
        Me.CheckBox_ZKord.Text = "Z-Koordinate"
        Me.CheckBox_ZKord.UseVisualStyleBackColor = True
        '
        'CheckBox_YKord
        '
        Me.CheckBox_YKord.AutoSize = True
        Me.CheckBox_YKord.Location = New System.Drawing.Point(6, 65)
        Me.CheckBox_YKord.Name = "CheckBox_YKord"
        Me.CheckBox_YKord.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox_YKord.TabIndex = 2
        Me.CheckBox_YKord.Text = "Y-Koordinate"
        Me.CheckBox_YKord.UseVisualStyleBackColor = True
        '
        'CheckBox_XKord
        '
        Me.CheckBox_XKord.AutoSize = True
        Me.CheckBox_XKord.Location = New System.Drawing.Point(6, 42)
        Me.CheckBox_XKord.Name = "CheckBox_XKord"
        Me.CheckBox_XKord.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox_XKord.TabIndex = 1
        Me.CheckBox_XKord.Text = "X-Koordinate"
        Me.CheckBox_XKord.UseVisualStyleBackColor = True
        '
        'CheckBox_PunktNr
        '
        Me.CheckBox_PunktNr.AutoSize = True
        Me.CheckBox_PunktNr.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox_PunktNr.Name = "CheckBox_PunktNr"
        Me.CheckBox_PunktNr.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox_PunktNr.TabIndex = 0
        Me.CheckBox_PunktNr.Text = "Punkt Nr."
        Me.CheckBox_PunktNr.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton_Drucker)
        Me.GroupBox2.Controls.Add(Me.RadioButton_Monitor)
        Me.GroupBox2.Controls.Add(Me.RadioButton_Datei)
        Me.GroupBox2.Location = New System.Drawing.Point(226, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 110)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ausgabeziel"
        '
        'RadioButton_Drucker
        '
        Me.RadioButton_Drucker.AutoSize = True
        Me.RadioButton_Drucker.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton_Drucker.Name = "RadioButton_Drucker"
        Me.RadioButton_Drucker.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton_Drucker.TabIndex = 2
        Me.RadioButton_Drucker.Text = "Drucker"
        Me.RadioButton_Drucker.UseVisualStyleBackColor = True
        '
        'RadioButton_Monitor
        '
        Me.RadioButton_Monitor.AutoSize = True
        Me.RadioButton_Monitor.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton_Monitor.Name = "RadioButton_Monitor"
        Me.RadioButton_Monitor.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton_Monitor.TabIndex = 1
        Me.RadioButton_Monitor.Text = "Monitor"
        Me.RadioButton_Monitor.UseVisualStyleBackColor = True
        '
        'RadioButton_Datei
        '
        Me.RadioButton_Datei.AutoSize = True
        Me.RadioButton_Datei.Checked = True
        Me.RadioButton_Datei.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_Datei.Name = "RadioButton_Datei"
        Me.RadioButton_Datei.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton_Datei.TabIndex = 0
        Me.RadioButton_Datei.TabStop = True
        Me.RadioButton_Datei.Text = "Datei"
        Me.RadioButton_Datei.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Auswahl der Datenausgabe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "gewähltes Ziel:"
        '
        'TextBox_Target
        '
        Me.TextBox_Target.Location = New System.Drawing.Point(99, 65)
        Me.TextBox_Target.Name = "TextBox_Target"
        Me.TextBox_Target.ReadOnly = True
        Me.TextBox_Target.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Target.TabIndex = 4
        Me.TextBox_Target.Text = "Ziel fehlt"
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(12, 243)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(75, 23)
        Me.Button_Start.TabIndex = 5
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Ende
        '
        Me.Button_Ende.Location = New System.Drawing.Point(226, 243)
        Me.Button_Ende.Name = "Button_Ende"
        Me.Button_Ende.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ende.TabIndex = 6
        Me.Button_Ende.Text = "Ende"
        Me.Button_Ende.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 282)
        Me.Controls.Add(Me.Button_Ende)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.TextBox_Target)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "Auswahlmaske"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox_ZKord As CheckBox
    Friend WithEvents CheckBox_YKord As CheckBox
    Friend WithEvents CheckBox_XKord As CheckBox
    Friend WithEvents CheckBox_PunktNr As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton_Drucker As RadioButton
    Friend WithEvents RadioButton_Monitor As RadioButton
    Friend WithEvents RadioButton_Datei As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Target As TextBox
    Friend WithEvents Button_Start As Button
    Friend WithEvents Button_Ende As Button
End Class
