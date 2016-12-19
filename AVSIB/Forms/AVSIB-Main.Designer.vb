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
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonUserManagement = New System.Windows.Forms.Button()
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
        Me.MainButtonEnde = New System.Windows.Forms.Button()
        Me.MainButtonReset = New System.Windows.Forms.Button()
        Me.MainButtonDrucken = New System.Windows.Forms.Button()
        Me.MainButtonExport = New System.Windows.Forms.Button()
        Me.MainButtonBezirke = New System.Windows.Forms.Button()
        Me.MainButtonStraßen = New System.Windows.Forms.Button()
        Me.MainButtonOrte = New System.Windows.Forms.Button()
        Me.MainButtonAusträger = New System.Windows.Forms.Button()
        Me.MainButtonPersonen = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.ToolTip1.SetToolTip(Me.MenuStrip1, resources.GetString("MenuStrip1.ToolTip"))
        '
        'DateToolStripMenuItem
        '
        resources.ApplyResources(Me.DateToolStripMenuItem, "DateToolStripMenuItem")
        Me.DateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        '
        'BeendenToolStripMenuItem
        '
        resources.ApplyResources(Me.BeendenToolStripMenuItem, "BeendenToolStripMenuItem")
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        '
        'HilfeToolStripMenuItem
        '
        resources.ApplyResources(Me.HilfeToolStripMenuItem, "HilfeToolStripMenuItem")
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Hilfe_Button, Me.ToolStripSeparator1, Me.FehlerMelderToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripSeparator2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        '
        'Hilfe_Button
        '
        resources.ApplyResources(Me.Hilfe_Button, "Hilfe_Button")
        Me.Hilfe_Button.Name = "Hilfe_Button"
        '
        'ToolStripSeparator1
        '
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        '
        'FehlerMelderToolStripMenuItem
        '
        resources.ApplyResources(Me.FehlerMelderToolStripMenuItem, "FehlerMelderToolStripMenuItem")
        Me.FehlerMelderToolStripMenuItem.Name = "FehlerMelderToolStripMenuItem"
        '
        'ToolStripMenuItem2
        '
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        '
        'ToolStripSeparator2
        '
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        '
        'ToolStripMenuItem3
        '
        resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        '
        'ToolStripMenuItem1
        '
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        '
        'InfoToolStripMenuItem
        '
        resources.ApplyResources(Me.InfoToolStripMenuItem, "InfoToolStripMenuItem")
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ButtonUserManagement)
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
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip"))
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Name = "Label12"
        Me.ToolTip1.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip"))
        '
        'ButtonUserManagement
        '
        resources.ApplyResources(Me.ButtonUserManagement, "ButtonUserManagement")
        Me.ButtonUserManagement.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonUserManagement.Name = "ButtonUserManagement"
        Me.ToolTip1.SetToolTip(Me.ButtonUserManagement, resources.GetString("ButtonUserManagement.ToolTip"))
        Me.ButtonUserManagement.UseVisualStyleBackColor = False
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Name = "Label11"
        Me.ToolTip1.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip"))
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Name = "Button1"
        Me.ToolTip1.SetToolTip(Me.Button1, resources.GetString("Button1.ToolTip"))
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Name = "Label9"
        Me.ToolTip1.SetToolTip(Me.Label9, resources.GetString("Label9.ToolTip"))
        '
        'MainButtonConfiguration
        '
        resources.ApplyResources(Me.MainButtonConfiguration, "MainButtonConfiguration")
        Me.MainButtonConfiguration.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonConfiguration.Name = "MainButtonConfiguration"
        Me.ToolTip1.SetToolTip(Me.MainButtonConfiguration, resources.GetString("MainButtonConfiguration.ToolTip"))
        Me.MainButtonConfiguration.UseVisualStyleBackColor = False
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Name = "Label10"
        Me.ToolTip1.SetToolTip(Me.Label10, resources.GetString("Label10.ToolTip"))
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Name = "Label7"
        Me.ToolTip1.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip"))
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Name = "Label8"
        Me.ToolTip1.SetToolTip(Me.Label8, resources.GetString("Label8.ToolTip"))
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Name = "Label5"
        Me.ToolTip1.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Name = "Label6"
        Me.ToolTip1.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip"))
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Name = "Label3"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Name = "Label4"
        Me.ToolTip1.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Name = "Label2"
        Me.ToolTip1.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Name = "Label1"
        Me.ToolTip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'MainButtonEnde
        '
        resources.ApplyResources(Me.MainButtonEnde, "MainButtonEnde")
        Me.MainButtonEnde.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonEnde.Name = "MainButtonEnde"
        Me.ToolTip1.SetToolTip(Me.MainButtonEnde, resources.GetString("MainButtonEnde.ToolTip"))
        Me.MainButtonEnde.UseVisualStyleBackColor = False
        '
        'MainButtonReset
        '
        resources.ApplyResources(Me.MainButtonReset, "MainButtonReset")
        Me.MainButtonReset.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonReset.Name = "MainButtonReset"
        Me.ToolTip1.SetToolTip(Me.MainButtonReset, resources.GetString("MainButtonReset.ToolTip"))
        Me.MainButtonReset.UseVisualStyleBackColor = False
        '
        'MainButtonDrucken
        '
        resources.ApplyResources(Me.MainButtonDrucken, "MainButtonDrucken")
        Me.MainButtonDrucken.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonDrucken.Name = "MainButtonDrucken"
        Me.ToolTip1.SetToolTip(Me.MainButtonDrucken, resources.GetString("MainButtonDrucken.ToolTip"))
        Me.MainButtonDrucken.UseVisualStyleBackColor = False
        '
        'MainButtonExport
        '
        resources.ApplyResources(Me.MainButtonExport, "MainButtonExport")
        Me.MainButtonExport.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonExport.Name = "MainButtonExport"
        Me.ToolTip1.SetToolTip(Me.MainButtonExport, resources.GetString("MainButtonExport.ToolTip"))
        Me.MainButtonExport.UseVisualStyleBackColor = False
        '
        'MainButtonBezirke
        '
        resources.ApplyResources(Me.MainButtonBezirke, "MainButtonBezirke")
        Me.MainButtonBezirke.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonBezirke.Name = "MainButtonBezirke"
        Me.ToolTip1.SetToolTip(Me.MainButtonBezirke, resources.GetString("MainButtonBezirke.ToolTip"))
        Me.MainButtonBezirke.UseVisualStyleBackColor = False
        '
        'MainButtonStraßen
        '
        resources.ApplyResources(Me.MainButtonStraßen, "MainButtonStraßen")
        Me.MainButtonStraßen.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonStraßen.Name = "MainButtonStraßen"
        Me.ToolTip1.SetToolTip(Me.MainButtonStraßen, resources.GetString("MainButtonStraßen.ToolTip"))
        Me.MainButtonStraßen.UseVisualStyleBackColor = False
        '
        'MainButtonOrte
        '
        resources.ApplyResources(Me.MainButtonOrte, "MainButtonOrte")
        Me.MainButtonOrte.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonOrte.Name = "MainButtonOrte"
        Me.ToolTip1.SetToolTip(Me.MainButtonOrte, resources.GetString("MainButtonOrte.ToolTip"))
        Me.MainButtonOrte.UseVisualStyleBackColor = False
        '
        'MainButtonAusträger
        '
        resources.ApplyResources(Me.MainButtonAusträger, "MainButtonAusträger")
        Me.MainButtonAusträger.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonAusträger.Name = "MainButtonAusträger"
        Me.ToolTip1.SetToolTip(Me.MainButtonAusträger, resources.GetString("MainButtonAusträger.ToolTip"))
        Me.MainButtonAusträger.UseVisualStyleBackColor = False
        '
        'MainButtonPersonen
        '
        resources.ApplyResources(Me.MainButtonPersonen, "MainButtonPersonen")
        Me.MainButtonPersonen.BackColor = System.Drawing.SystemColors.Control
        Me.MainButtonPersonen.Name = "MainButtonPersonen"
        Me.ToolTip1.SetToolTip(Me.MainButtonPersonen, resources.GetString("MainButtonPersonen.ToolTip"))
        Me.MainButtonPersonen.UseVisualStyleBackColor = False
        '
        'AVSIB_Main
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AVSIB_Main"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
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
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonUserManagement As Button
End Class
