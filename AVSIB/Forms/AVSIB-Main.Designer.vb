<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hilfe_Button = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FehlerMelderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MainButtonConfiguration = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainButtonEnde = New System.Windows.Forms.Button()
        Me.MainButtonReset = New System.Windows.Forms.Button()
        Me.MainButtonDrucken = New System.Windows.Forms.Button()
        Me.MainButtonExport = New System.Windows.Forms.Button()
        Me.MainButtonBezirke = New System.Windows.Forms.Button()
        Me.MainButtonStraßen = New System.Windows.Forms.Button()
        Me.MainButtonOrte = New System.Windows.Forms.Button()
        Me.MainButtonAusträger = New System.Windows.Forms.Button()
        Me.MainButtonPersonen = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1512, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.DateToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(165, 30)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        Me.BeendenToolStripMenuItem.ToolTipText = "Beendet das Programm"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Hilfe_Button, Me.ToolStripSeparator1, Me.FehlerMelderToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripSeparator2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(60, 29)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'Hilfe_Button
        '
        Me.Hilfe_Button.Name = "Hilfe_Button"
        Me.Hilfe_Button.Size = New System.Drawing.Size(257, 30)
        Me.Hilfe_Button.Text = "Hilfe"
        Me.Hilfe_Button.ToolTipText = "Ruft eine Webiste auf, auf der Sie eine Anleitung zu dem Programm finden."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(254, 6)
        '
        'FehlerMelderToolStripMenuItem
        '
        Me.FehlerMelderToolStripMenuItem.Name = "FehlerMelderToolStripMenuItem"
        Me.FehlerMelderToolStripMenuItem.Size = New System.Drawing.Size(257, 30)
        Me.FehlerMelderToolStripMenuItem.Text = "Fehler-Melder"
        Me.FehlerMelderToolStripMenuItem.ToolTipText = "Öffnet eine Website, auf der Sie Probleme mit dem Programm oder Ihre Wünsche meld" &
    "en können"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(257, 30)
        Me.ToolStripMenuItem2.Text = "Änderungsprotokoll"
        Me.ToolStripMenuItem2.ToolTipText = "Ruft eine Website auf, auf der Sie die Änderungen der letzten Versionen einsehen " &
    "können."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(254, 6)
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(257, 30)
        Me.InfoToolStripMenuItem.Text = "Info"
        Me.InfoToolStripMenuItem.ToolTipText = "Zeigt Informationen über das Programm"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.MainButtonConfiguration)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MainButtonEnde)
        Me.GroupBox1.Controls.Add(Me.MainButtonReset)
        Me.GroupBox1.Controls.Add(Me.MainButtonDrucken)
        Me.GroupBox1.Controls.Add(Me.MainButtonExport)
        Me.GroupBox1.Controls.Add(Me.MainButtonBezirke)
        Me.GroupBox1.Controls.Add(Me.MainButtonStraßen)
        Me.GroupBox1.Controls.Add(Me.MainButtonOrte)
        Me.GroupBox1.Controls.Add(Me.MainButtonAusträger)
        Me.GroupBox1.Controls.Add(Me.MainButtonPersonen)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(130, 122)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(1200, 923)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1200, 923)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menü"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(662, 351)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Backup"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(603, 343)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 35)
        Me.Button1.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.Button1, "Erstellt ein Backup im Programm-Ordner")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(390, 351)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Einstellungen"
        '
        'MainButtonConfiguration
        '
        Me.MainButtonConfiguration.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonConfiguration.Location = New System.Drawing.Point(332, 343)
        Me.MainButtonConfiguration.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonConfiguration.Name = "MainButtonConfiguration"
        Me.MainButtonConfiguration.Size = New System.Drawing.Size(50, 35)
        Me.MainButtonConfiguration.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.MainButtonConfiguration, "Bietet Einstellungsmöglichkeiten zu Ihrer Organisation")
        Me.MainButtonConfiguration.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(104, 351)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Ende"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(920, 178)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Zurücksetzen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(920, 86)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Drucken"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(662, 178)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Im-/Export"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(662, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Bezirke"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(104, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Straßen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(104, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Orte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(390, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Austräger"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(390, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Personen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(254, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(257, 30)
        Me.ToolStripMenuItem3.Text = "Statistik"
        '
        'MainButtonEnde
        '
        Me.MainButtonEnde.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonEnde.Image = CType(resources.GetObject("MainButtonEnde.Image"), System.Drawing.Image)
        Me.MainButtonEnde.Location = New System.Drawing.Point(45, 343)
        Me.MainButtonEnde.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonEnde.Name = "MainButtonEnde"
        Me.MainButtonEnde.Size = New System.Drawing.Size(50, 35)
        Me.MainButtonEnde.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.MainButtonEnde, "Beendet das Programm")
        Me.MainButtonEnde.UseVisualStyleBackColor = False
        '
        'MainButtonReset
        '
        Me.MainButtonReset.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonReset.Image = CType(resources.GetObject("MainButtonReset.Image"), System.Drawing.Image)
        Me.MainButtonReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MainButtonReset.Location = New System.Drawing.Point(862, 171)
        Me.MainButtonReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonReset.Name = "MainButtonReset"
        Me.MainButtonReset.Size = New System.Drawing.Size(48, 35)
        Me.MainButtonReset.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.MainButtonReset, "Setzt das Programm auf Ursprungswerte zurück")
        Me.MainButtonReset.UseVisualStyleBackColor = False
        '
        'MainButtonDrucken
        '
        Me.MainButtonDrucken.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonDrucken.Image = CType(resources.GetObject("MainButtonDrucken.Image"), System.Drawing.Image)
        Me.MainButtonDrucken.Location = New System.Drawing.Point(862, 78)
        Me.MainButtonDrucken.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonDrucken.Name = "MainButtonDrucken"
        Me.MainButtonDrucken.Size = New System.Drawing.Size(48, 35)
        Me.MainButtonDrucken.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.MainButtonDrucken, "Druckt ausgewählte Listen für die Austräger")
        Me.MainButtonDrucken.UseVisualStyleBackColor = False
        '
        'MainButtonExport
        '
        Me.MainButtonExport.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonExport.Image = CType(resources.GetObject("MainButtonExport.Image"), System.Drawing.Image)
        Me.MainButtonExport.Location = New System.Drawing.Point(603, 171)
        Me.MainButtonExport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonExport.Name = "MainButtonExport"
        Me.MainButtonExport.Size = New System.Drawing.Size(50, 35)
        Me.MainButtonExport.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.MainButtonExport, "Bietet die Möglichkeit die Datenbank in einem selbstgewählten Ordner zu sichern")
        Me.MainButtonExport.UseVisualStyleBackColor = False
        '
        'MainButtonBezirke
        '
        Me.MainButtonBezirke.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonBezirke.Image = CType(resources.GetObject("MainButtonBezirke.Image"), System.Drawing.Image)
        Me.MainButtonBezirke.Location = New System.Drawing.Point(603, 78)
        Me.MainButtonBezirke.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonBezirke.Name = "MainButtonBezirke"
        Me.MainButtonBezirke.Size = New System.Drawing.Size(50, 35)
        Me.MainButtonBezirke.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.MainButtonBezirke, "Ordnet die Straßen den Austräger-Bezirken zu")
        Me.MainButtonBezirke.UseVisualStyleBackColor = False
        '
        'MainButtonStraßen
        '
        Me.MainButtonStraßen.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonStraßen.Image = CType(resources.GetObject("MainButtonStraßen.Image"), System.Drawing.Image)
        Me.MainButtonStraßen.Location = New System.Drawing.Point(45, 171)
        Me.MainButtonStraßen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonStraßen.Name = "MainButtonStraßen"
        Me.MainButtonStraßen.Size = New System.Drawing.Size(50, 35)
        Me.MainButtonStraßen.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.MainButtonStraßen, "Verwaltet die Straßen")
        Me.MainButtonStraßen.UseVisualStyleBackColor = False
        '
        'MainButtonOrte
        '
        Me.MainButtonOrte.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonOrte.Image = CType(resources.GetObject("MainButtonOrte.Image"), System.Drawing.Image)
        Me.MainButtonOrte.Location = New System.Drawing.Point(45, 78)
        Me.MainButtonOrte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonOrte.Name = "MainButtonOrte"
        Me.MainButtonOrte.Size = New System.Drawing.Size(50, 35)
        Me.MainButtonOrte.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.MainButtonOrte, "Verwaltet die Orte")
        Me.MainButtonOrte.UseVisualStyleBackColor = False
        '
        'MainButtonAusträger
        '
        Me.MainButtonAusträger.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonAusträger.Image = CType(resources.GetObject("MainButtonAusträger.Image"), System.Drawing.Image)
        Me.MainButtonAusträger.Location = New System.Drawing.Point(332, 171)
        Me.MainButtonAusträger.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonAusträger.Name = "MainButtonAusträger"
        Me.MainButtonAusträger.Size = New System.Drawing.Size(50, 35)
        Me.MainButtonAusträger.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.MainButtonAusträger, "Verwaltet die Austräger")
        Me.MainButtonAusträger.UseVisualStyleBackColor = False
        '
        'MainButtonPersonen
        '
        Me.MainButtonPersonen.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonPersonen.Image = CType(resources.GetObject("MainButtonPersonen.Image"), System.Drawing.Image)
        Me.MainButtonPersonen.Location = New System.Drawing.Point(332, 78)
        Me.MainButtonPersonen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainButtonPersonen.Name = "MainButtonPersonen"
        Me.MainButtonPersonen.Size = New System.Drawing.Size(50, 35)
        Me.MainButtonPersonen.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.MainButtonPersonen, "Verwaltet die Empfänger")
        Me.MainButtonPersonen.UseVisualStyleBackColor = False
        '
        'AVSIB_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1512, 1028)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1524, 1018)
        Me.Name = "AVSIB_Main"
        Me.Text = "AVSIB - Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MainButtonEnde As System.Windows.Forms.Button
    Friend WithEvents MainButtonReset As System.Windows.Forms.Button
    Friend WithEvents MainButtonDrucken As System.Windows.Forms.Button
    Friend WithEvents MainButtonExport As System.Windows.Forms.Button
    Friend WithEvents MainButtonBezirke As System.Windows.Forms.Button
    Friend WithEvents MainButtonStraßen As System.Windows.Forms.Button
    Friend WithEvents MainButtonOrte As System.Windows.Forms.Button
    Friend WithEvents MainButtonAusträger As System.Windows.Forms.Button
    Friend WithEvents MainButtonPersonen As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MainButtonConfiguration As System.Windows.Forms.Button
    Friend WithEvents HilfeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FehlerMelderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Hilfe_Button As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
End Class
