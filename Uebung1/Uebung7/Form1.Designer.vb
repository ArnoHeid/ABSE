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
        Me.RadioButton_Unendlich = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Endlich = New System.Windows.Forms.RadioButton()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Ende = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Result = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(82, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Auswahlformular zur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Berechnung von Reihen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RadioButton_Unendlich
        '
        Me.RadioButton_Unendlich.AutoSize = True
        Me.RadioButton_Unendlich.Checked = True
        Me.RadioButton_Unendlich.Location = New System.Drawing.Point(28, 97)
        Me.RadioButton_Unendlich.Name = "RadioButton_Unendlich"
        Me.RadioButton_Unendlich.Size = New System.Drawing.Size(176, 17)
        Me.RadioButton_Unendlich.TabIndex = 1
        Me.RadioButton_Unendlich.TabStop = True
        Me.RadioButton_Unendlich.Text = "Unendliche geometrische Reihe"
        Me.RadioButton_Unendlich.UseVisualStyleBackColor = True
        '
        'RadioButton_Endlich
        '
        Me.RadioButton_Endlich.AutoSize = True
        Me.RadioButton_Endlich.Location = New System.Drawing.Point(28, 120)
        Me.RadioButton_Endlich.Name = "RadioButton_Endlich"
        Me.RadioButton_Endlich.Size = New System.Drawing.Size(163, 17)
        Me.RadioButton_Endlich.TabIndex = 2
        Me.RadioButton_Endlich.TabStop = True
        Me.RadioButton_Endlich.Text = "Endliche geometrische Reihe"
        Me.RadioButton_Endlich.UseVisualStyleBackColor = True
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(28, 171)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(75, 23)
        Me.Button_Start.TabIndex = 3
        Me.Button_Start.Text = "Start"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Ende
        '
        Me.Button_Ende.Location = New System.Drawing.Point(170, 171)
        Me.Button_Ende.Name = "Button_Ende"
        Me.Button_Ende.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ende.TabIndex = 4
        Me.Button_Ende.Text = "Ende"
        Me.Button_Ende.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rechenergebnis: "
        '
        'TextBox_Result
        '
        Me.TextBox_Result.Location = New System.Drawing.Point(122, 224)
        Me.TextBox_Result.Name = "TextBox_Result"
        Me.TextBox_Result.Size = New System.Drawing.Size(134, 20)
        Me.TextBox_Result.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox_Result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Ende)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.RadioButton_Endlich)
        Me.Controls.Add(Me.RadioButton_Unendlich)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton_Unendlich As RadioButton
    Friend WithEvents RadioButton_Endlich As RadioButton
    Friend WithEvents Button_Start As Button
    Friend WithEvents Button_Ende As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Result As TextBox
End Class
