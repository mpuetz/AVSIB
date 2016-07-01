<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Backup))
        Me.CBBackup = New System.Windows.Forms.CheckBox()
        Me.CBRestore = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BRestore = New System.Windows.Forms.Button()
        Me.BDelete = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'CBBackup
        '
        Me.CBBackup.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBBackup.AutoSize = True
        Me.CBBackup.Checked = True
        Me.CBBackup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBBackup.Location = New System.Drawing.Point(17, 16)
        Me.CBBackup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBackup.Name = "CBBackup"
        Me.CBBackup.Size = New System.Drawing.Size(123, 27)
        Me.CBBackup.TabIndex = 0
        Me.CBBackup.Text = "Backup erstellen"
        Me.CBBackup.UseVisualStyleBackColor = True
        '
        'CBRestore
        '
        Me.CBRestore.Appearance = System.Windows.Forms.Appearance.Button
        Me.CBRestore.AutoSize = True
        Me.CBRestore.Location = New System.Drawing.Point(153, 16)
        Me.CBRestore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBRestore.Name = "CBRestore"
        Me.CBRestore.Size = New System.Drawing.Size(164, 27)
        Me.CBRestore.TabIndex = 1
        Me.CBRestore.Text = "Backup widerherstellen"
        Me.CBRestore.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(17, 53)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(401, 275)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(429, 263)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Backup erstellen"
        Me.ToolTip1.SetToolTip(Me.Button1, "Erstellt ein Backup im Programm-Ordner")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(429, 299)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Menü"
        Me.ToolTip1.SetToolTip(Me.Button2, "Zurück zum Hauptmenü")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(17, 50)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(403, 276)
        Me.ListBox1.TabIndex = 5
        Me.ListBox1.Visible = False
        '
        'BRestore
        '
        Me.BRestore.Enabled = False
        Me.BRestore.Location = New System.Drawing.Point(428, 263)
        Me.BRestore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BRestore.Name = "BRestore"
        Me.BRestore.Size = New System.Drawing.Size(127, 28)
        Me.BRestore.TabIndex = 6
        Me.BRestore.Text = "Widerherstellen"
        Me.ToolTip1.SetToolTip(Me.BRestore, "Stellt das ausgewählte Backup wieder her")
        Me.BRestore.UseVisualStyleBackColor = True
        Me.BRestore.Visible = False
        '
        'BDelete
        '
        Me.BDelete.Enabled = False
        Me.BDelete.Image = CType(resources.GetObject("BDelete.Image"), System.Drawing.Image)
        Me.BDelete.Location = New System.Drawing.Point(429, 50)
        Me.BDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(39, 28)
        Me.BDelete.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.BDelete, "Löscht das ausgewählte Backup")
        Me.BDelete.UseVisualStyleBackColor = True
        Me.BDelete.Visible = False
        '
        'Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 348)
        Me.Controls.Add(Me.BDelete)
        Me.Controls.Add(Me.BRestore)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.CBRestore)
        Me.Controls.Add(Me.CBBackup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Backup"
        Me.Text = "Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBBackup As System.Windows.Forms.CheckBox
    Friend WithEvents CBRestore As System.Windows.Forms.CheckBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BRestore As System.Windows.Forms.Button
    Friend WithEvents BDelete As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
