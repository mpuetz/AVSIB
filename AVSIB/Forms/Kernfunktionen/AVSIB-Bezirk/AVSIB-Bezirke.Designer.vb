<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_Bezirke
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_Bezirke))
        Me.CBBezirk = New System.Windows.Forms.ComboBox()
        Me.CBOrt = New System.Windows.Forms.ComboBox()
        Me.CBPLZ = New System.Windows.Forms.ComboBox()
        Me.CBStraße = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'CBBezirk
        '
        Me.CBBezirk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBezirk.FormattingEnabled = True
        Me.CBBezirk.Location = New System.Drawing.Point(879, 49)
        Me.CBBezirk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBBezirk.Name = "CBBezirk"
        Me.CBBezirk.Size = New System.Drawing.Size(55, 28)
        Me.CBBezirk.TabIndex = 1
        '
        'CBOrt
        '
        Me.CBOrt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOrt.FormattingEnabled = True
        Me.CBOrt.Location = New System.Drawing.Point(879, 91)
        Me.CBOrt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBOrt.Name = "CBOrt"
        Me.CBOrt.Size = New System.Drawing.Size(180, 28)
        Me.CBOrt.TabIndex = 2
        '
        'CBPLZ
        '
        Me.CBPLZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPLZ.Enabled = False
        Me.CBPLZ.FormattingEnabled = True
        Me.CBPLZ.Location = New System.Drawing.Point(879, 134)
        Me.CBPLZ.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBPLZ.Name = "CBPLZ"
        Me.CBPLZ.Size = New System.Drawing.Size(180, 28)
        Me.CBPLZ.TabIndex = 3
        '
        'CBStraße
        '
        Me.CBStraße.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStraße.Enabled = False
        Me.CBStraße.FormattingEnabled = True
        Me.CBStraße.Location = New System.Drawing.Point(879, 177)
        Me.CBStraße.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBStraße.Name = "CBStraße"
        Me.CBStraße.Size = New System.Drawing.Size(180, 28)
        Me.CBStraße.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1014, 220)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 35)
        Me.Button1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button1, "Fügt die ausgewählte Adresse dem ausgewählten Bezirk hinzu.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(717, 474)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(812, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bezirk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(812, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ort"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(812, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "PLZ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(812, 182)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Straße"
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Location = New System.Drawing.Point(948, 475)
        Me.ButtonMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(112, 35)
        Me.ButtonMenu.TabIndex = 15
        Me.ButtonMenu.Text = "Menü"
        Me.ToolTip1.SetToolTip(Me.ButtonMenu, "Zurück zum Hauptmenü")
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Location = New System.Drawing.Point(18, 18)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(688, 490)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Bezirk"
        Me.ColumnHeader1.Width = 46
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Straße"
        Me.ColumnHeader2.Width = 165
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PLZ"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ort"
        Me.ColumnHeader4.Width = 165
        '
        'AVSIB_Bezirke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 538)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBStraße)
        Me.Controls.Add(Me.CBPLZ)
        Me.Controls.Add(Me.CBOrt)
        Me.Controls.Add(Me.CBBezirk)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1117, 594)
        Me.MinimumSize = New System.Drawing.Size(1117, 594)
        Me.Name = "AVSIB_Bezirke"
        Me.Text = "AVSIB_Bezirke"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBBezirk As System.Windows.Forms.ComboBox
    Friend WithEvents CBOrt As System.Windows.Forms.ComboBox
    Friend WithEvents CBPLZ As System.Windows.Forms.ComboBox
    Friend WithEvents CBStraße As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonMenu As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
