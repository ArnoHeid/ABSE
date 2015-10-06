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
        Me.ButtonShowMsBox = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(150, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Das ist ein Label"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonShowMsBox
        '
        Me.ButtonShowMsBox.Location = New System.Drawing.Point(300, 300)
        Me.ButtonShowMsBox.Name = "ButtonShowMsBox"
        Me.ButtonShowMsBox.Size = New System.Drawing.Size(50, 40)
        Me.ButtonShowMsBox.TabIndex = 1
        Me.ButtonShowMsBox.Text = "Drück mal"
        Me.ButtonShowMsBox.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(300, 400)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(50, 40)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "OK"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(384, 562)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonShowMsBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Uebung 2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonShowMsBox As Button
    Friend WithEvents ButtonClose As Button
End Class
