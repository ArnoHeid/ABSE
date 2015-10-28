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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_open = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnterToolStripMenuItem_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Show = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_SortUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_SortDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_search = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView_Adressen = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView_Adressen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatenToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(415, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_open, Me.ToolStripMenuItem_Save, Me.UnterToolStripMenuItem_SaveAs, Me.ToolStripMenuItem_exit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripMenuItem_open
        '
        Me.ToolStripMenuItem_open.Name = "ToolStripMenuItem_open"
        Me.ToolStripMenuItem_open.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem_open.Text = "öffnen"
        '
        'ToolStripMenuItem_Save
        '
        Me.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save"
        Me.ToolStripMenuItem_Save.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem_Save.Text = "speichern"
        '
        'UnterToolStripMenuItem_SaveAs
        '
        Me.UnterToolStripMenuItem_SaveAs.Name = "UnterToolStripMenuItem_SaveAs"
        Me.UnterToolStripMenuItem_SaveAs.Size = New System.Drawing.Size(156, 22)
        Me.UnterToolStripMenuItem_SaveAs.Text = "speichern unter"
        '
        'ToolStripMenuItem_exit
        '
        Me.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit"
        Me.ToolStripMenuItem_exit.Size = New System.Drawing.Size(156, 22)
        Me.ToolStripMenuItem_exit.Text = "beenden"
        '
        'DatenToolStripMenuItem
        '
        Me.DatenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Show, Me.ToolStripMenuItem_SortUp, Me.ToolStripMenuItem_SortDown, Me.ToolStripMenuItem_search})
        Me.DatenToolStripMenuItem.Name = "DatenToolStripMenuItem"
        Me.DatenToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.DatenToolStripMenuItem.Text = "Daten"
        '
        'ToolStripMenuItem_Show
        '
        Me.ToolStripMenuItem_Show.Name = "ToolStripMenuItem_Show"
        Me.ToolStripMenuItem_Show.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem_Show.Text = "anzeigen"
        '
        'ToolStripMenuItem_SortUp
        '
        Me.ToolStripMenuItem_SortUp.Name = "ToolStripMenuItem_SortUp"
        Me.ToolStripMenuItem_SortUp.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem_SortUp.Text = "aufsteigend sotieren"
        '
        'ToolStripMenuItem_SortDown
        '
        Me.ToolStripMenuItem_SortDown.Name = "ToolStripMenuItem_SortDown"
        Me.ToolStripMenuItem_SortDown.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem_SortDown.Text = "absteigend sotieren"
        '
        'ToolStripMenuItem_search
        '
        Me.ToolStripMenuItem_search.Name = "ToolStripMenuItem_search"
        Me.ToolStripMenuItem_search.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem_search.Text = "suchen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'DataGridView_Adressen
        '
        Me.DataGridView_Adressen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Adressen.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView_Adressen.Name = "DataGridView_Adressen"
        Me.DataGridView_Adressen.Size = New System.Drawing.Size(391, 332)
        Me.DataGridView_Adressen.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 371)
        Me.Controls.Add(Me.DataGridView_Adressen)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Adressverwaltung"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView_Adressen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_open As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Save As ToolStripMenuItem
    Friend WithEvents UnterToolStripMenuItem_SaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_exit As ToolStripMenuItem
    Friend WithEvents DatenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_Show As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_SortUp As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_SortDown As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_search As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView_Adressen As DataGridView
End Class
