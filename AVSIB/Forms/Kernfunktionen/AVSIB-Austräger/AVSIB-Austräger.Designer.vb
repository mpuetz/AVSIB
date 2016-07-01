<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_Austräger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_Austräger))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBBezirk = New System.Windows.Forms.ComboBox()
        Me.TBNachname = New System.Windows.Forms.TextBox()
        Me.TBVorname = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(495, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bezirk-Nr"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(495, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nachname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vorname"
        '
        'CBBezirk
        '
        Me.CBBezirk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBezirk.FormattingEnabled = True
        Me.CBBezirk.Location = New System.Drawing.Point(592, 43)
        Me.CBBezirk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBBezirk.Name = "CBBezirk"
        Me.CBBezirk.Size = New System.Drawing.Size(76, 28)
        Me.CBBezirk.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CBBezirk, "Wählen Sie hier die Bezirk-Nr., der Sie einen Austräger zuweisen möchten.")
        '
        'TBNachname
        '
        Me.TBNachname.Location = New System.Drawing.Point(592, 125)
        Me.TBNachname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBNachname.Name = "TBNachname"
        Me.TBNachname.Size = New System.Drawing.Size(148, 26)
        Me.TBNachname.TabIndex = 2
        '
        'TBVorname
        '
        Me.TBVorname.Location = New System.Drawing.Point(592, 85)
        Me.TBVorname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBVorname.Name = "TBVorname"
        Me.TBVorname.Size = New System.Drawing.Size(148, 26)
        Me.TBVorname.TabIndex = 1
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Image = CType(resources.GetObject("ButtonAdd.Image"), System.Drawing.Image)
        Me.ButtonAdd.Location = New System.Drawing.Point(632, 165)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(51, 35)
        Me.ButtonAdd.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.ButtonAdd, "Fügt eine neue BEZIRK-NR. hinzu")
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Image = CType(resources.GetObject("ButtonDelete.Image"), System.Drawing.Image)
        Me.ButtonDelete.Location = New System.Drawing.Point(358, 306)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(51, 35)
        Me.ButtonDelete.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ButtonDelete, "Löscht den ausgewählten Austräger")
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.Location = New System.Drawing.Point(692, 165)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(51, 35)
        Me.ButtonSave.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ButtonSave, "Fügte der ausgewählten Bezirk-Nr. den eingetragenen Austräger hinzu")
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Location = New System.Drawing.Point(627, 306)
        Me.ButtonMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(112, 35)
        Me.ButtonMenu.TabIndex = 7
        Me.ButtonMenu.Text = "Menü"
        Me.ToolTip1.SetToolTip(Me.ButtonMenu, "Zurück zum Hauptmenü")
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(18, 18)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(330, 321)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Bezirk"
        Me.ColumnHeader1.Width = 44
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Vorname"
        Me.ColumnHeader2.Width = 78
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nachname"
        Me.ColumnHeader3.Width = 89
        '
        'AVSIB_Austräger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 334)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TBVorname)
        Me.Controls.Add(Me.TBNachname)
        Me.Controls.Add(Me.CBBezirk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(770, 390)
        Me.MinimumSize = New System.Drawing.Size(770, 390)
        Me.Name = "AVSIB_Austräger"
        Me.Text = "AVSIB_Austräger"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBBezirk As System.Windows.Forms.ComboBox
    Friend WithEvents TBNachname As System.Windows.Forms.TextBox
    Friend WithEvents TBVorname As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonMenu As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
