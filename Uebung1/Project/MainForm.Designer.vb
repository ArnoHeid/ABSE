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
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AusgangssystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZielsystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_TransformTyp = New System.Windows.Forms.ComboBox()
        Me.TextBox_Typ = New System.Windows.Forms.TextBox()
        Me.TextBox_NrPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_Transform = New System.Windows.Forms.Button()
        Me.Button_Report = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_NrNew = New System.Windows.Forms.TextBox()
        Me.TextBox_KoordAusgang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_ZielSys = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView_Result = New System.Windows.Forms.DataGridView()
        Me.TabPage_Res = New System.Windows.Forms.TabPage()
        Me.DataGridView_resi = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView_Result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Res.SuspendLayout()
        CType(Me.DataGridView_resi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffnenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AusgangssystemToolStripMenuItem, Me.ZielsystemToolStripMenuItem})
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'AusgangssystemToolStripMenuItem
        '
        Me.AusgangssystemToolStripMenuItem.Name = "AusgangssystemToolStripMenuItem"
        Me.AusgangssystemToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AusgangssystemToolStripMenuItem.Text = "Ausgangssystem"
        '
        'ZielsystemToolStripMenuItem
        '
        Me.ZielsystemToolStripMenuItem.Name = "ZielsystemToolStripMenuItem"
        Me.ZielsystemToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ZielsystemToolStripMenuItem.Text = "Zielsystem"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.1544!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.8456!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(689, 421)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ComboBox_TransformTyp, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_Typ, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_NrPass, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button_Transform, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Button_Report, 3, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_NrNew, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_KoordAusgang, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox_ZielSys, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(683, 142)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transformation:"
        '
        'ComboBox_TransformTyp
        '
        Me.ComboBox_TransformTyp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_TransformTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_TransformTyp.FormattingEnabled = True
        Me.ComboBox_TransformTyp.Location = New System.Drawing.Point(173, 3)
        Me.ComboBox_TransformTyp.Name = "ComboBox_TransformTyp"
        Me.ComboBox_TransformTyp.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox_TransformTyp.TabIndex = 1
        '
        'TextBox_Typ
        '
        Me.TextBox_Typ.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Typ.Location = New System.Drawing.Point(513, 4)
        Me.TextBox_Typ.Name = "TextBox_Typ"
        Me.TextBox_Typ.ReadOnly = True
        Me.TextBox_Typ.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_Typ.TabIndex = 8
        '
        'TextBox_NrPass
        '
        Me.TextBox_NrPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NrPass.Location = New System.Drawing.Point(513, 32)
        Me.TextBox_NrPass.Name = "TextBox_NrPass"
        Me.TextBox_NrPass.ReadOnly = True
        Me.TextBox_NrPass.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_NrPass.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Koordinaten Dimension"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Anzahl Passpunkt"
        '
        'Button_Transform
        '
        Me.Button_Transform.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Transform.Location = New System.Drawing.Point(343, 115)
        Me.Button_Transform.Name = "Button_Transform"
        Me.Button_Transform.Size = New System.Drawing.Size(164, 23)
        Me.Button_Transform.TabIndex = 12
        Me.Button_Transform.Text = "Transformieren"
        Me.Button_Transform.UseVisualStyleBackColor = True
        '
        'Button_Report
        '
        Me.Button_Report.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Report.Location = New System.Drawing.Point(513, 115)
        Me.Button_Report.Name = "Button_Report"
        Me.Button_Report.Size = New System.Drawing.Size(167, 23)
        Me.Button_Report.TabIndex = 13
        Me.Button_Report.Text = "Report"
        Me.Button_Report.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Anzahl Neupunkte"
        '
        'TextBox_NrNew
        '
        Me.TextBox_NrNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_NrNew.Location = New System.Drawing.Point(513, 60)
        Me.TextBox_NrNew.Name = "TextBox_NrNew"
        Me.TextBox_NrNew.ReadOnly = True
        Me.TextBox_NrNew.Size = New System.Drawing.Size(167, 20)
        Me.TextBox_NrNew.TabIndex = 17
        '
        'TextBox_KoordAusgang
        '
        Me.TextBox_KoordAusgang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_KoordAusgang.Location = New System.Drawing.Point(173, 32)
        Me.TextBox_KoordAusgang.Name = "TextBox_KoordAusgang"
        Me.TextBox_KoordAusgang.ReadOnly = True
        Me.TextBox_KoordAusgang.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_KoordAusgang.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Koordinaten Ausgangssystem"
        '
        'TextBox_ZielSys
        '
        Me.TextBox_ZielSys.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ZielSys.Location = New System.Drawing.Point(173, 60)
        Me.TextBox_ZielSys.Name = "TextBox_ZielSys"
        Me.TextBox_ZielSys.ReadOnly = True
        Me.TextBox_ZielSys.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_ZielSys.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Koordinaten Zielsystem"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage_Res)
        Me.TabControl1.Location = New System.Drawing.Point(3, 151)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(683, 267)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView_Result)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(675, 241)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Neupunkt"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView_Result
        '
        Me.DataGridView_Result.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Result.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView_Result.Name = "DataGridView_Result"
        Me.DataGridView_Result.Size = New System.Drawing.Size(663, 229)
        Me.DataGridView_Result.TabIndex = 0
        '
        'TabPage_Res
        '
        Me.TabPage_Res.Controls.Add(Me.DataGridView_resi)
        Me.TabPage_Res.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Res.Name = "TabPage_Res"
        Me.TabPage_Res.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Res.Size = New System.Drawing.Size(675, 241)
        Me.TabPage_Res.TabIndex = 1
        Me.TabPage_Res.Text = "Residuen"
        Me.TabPage_Res.UseVisualStyleBackColor = True
        '
        'DataGridView_resi
        '
        Me.DataGridView_resi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_resi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_resi.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView_resi.Name = "DataGridView_resi"
        Me.DataGridView_resi.Size = New System.Drawing.Size(663, 229)
        Me.DataGridView_resi.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 460)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Koordinaten Transformationen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView_Result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Res.ResumeLayout(False)
        CType(Me.DataGridView_resi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_TransformTyp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_KoordAusgang As TextBox
    Friend WithEvents TextBox_Typ As TextBox
    Friend WithEvents TextBox_NrPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button_Transform As Button
    Friend WithEvents Button_Report As Button
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_ZielSys As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_NrNew As TextBox
    Friend WithEvents AusgangssystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZielsystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView_Result As DataGridView
    Friend WithEvents TabPage_Res As TabPage
    Friend WithEvents DataGridView_resi As DataGridView
End Class
