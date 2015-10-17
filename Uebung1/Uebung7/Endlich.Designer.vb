<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Endlich
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
        Me.TextBox_Iteration = New System.Windows.Forms.TextBox()
        Me.TextBox_Faktor_q = New System.Windows.Forms.TextBox()
        Me.TextBox_Faktor_a = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_back = New System.Windows.Forms.Button()
        Me.Button_start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_Iteration
        '
        Me.TextBox_Iteration.Location = New System.Drawing.Point(132, 58)
        Me.TextBox_Iteration.Name = "TextBox_Iteration"
        Me.TextBox_Iteration.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Iteration.TabIndex = 31
        '
        'TextBox_Faktor_q
        '
        Me.TextBox_Faktor_q.Location = New System.Drawing.Point(132, 32)
        Me.TextBox_Faktor_q.Name = "TextBox_Faktor_q"
        Me.TextBox_Faktor_q.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Faktor_q.TabIndex = 30
        '
        'TextBox_Faktor_a
        '
        Me.TextBox_Faktor_a.Location = New System.Drawing.Point(132, 6)
        Me.TextBox_Faktor_a.Name = "TextBox_Faktor_a"
        Me.TextBox_Faktor_a.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Faktor_a.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Anzahl der Iterationen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Faktor q"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Faktor a"
        '
        'Button_back
        '
        Me.Button_back.Location = New System.Drawing.Point(152, 110)
        Me.Button_back.Name = "Button_back"
        Me.Button_back.Size = New System.Drawing.Size(80, 40)
        Me.Button_back.TabIndex = 25
        Me.Button_back.Text = "zurück"
        Me.Button_back.UseVisualStyleBackColor = True
        '
        'Button_start
        '
        Me.Button_start.Location = New System.Drawing.Point(12, 110)
        Me.Button_start.Name = "Button_start"
        Me.Button_start.Size = New System.Drawing.Size(80, 40)
        Me.Button_start.TabIndex = 24
        Me.Button_start.Text = "Berechnung"
        Me.Button_start.UseVisualStyleBackColor = True
        '
        'Endlich
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 162)
        Me.Controls.Add(Me.TextBox_Iteration)
        Me.Controls.Add(Me.TextBox_Faktor_q)
        Me.Controls.Add(Me.TextBox_Faktor_a)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_back)
        Me.Controls.Add(Me.Button_start)
        Me.Name = "Endlich"
        Me.Text = "Endlich"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_Iteration As TextBox
    Friend WithEvents TextBox_Faktor_q As TextBox
    Friend WithEvents TextBox_Faktor_a As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_back As Button
    Friend WithEvents Button_start As Button
End Class
