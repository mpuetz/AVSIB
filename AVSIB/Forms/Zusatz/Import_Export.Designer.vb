<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Import_Export
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Import_Export))
        Me.B_Import = New System.Windows.Forms.Button()
        Me.B_Export = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'B_Import
        '
        Me.B_Import.Location = New System.Drawing.Point(12, 25)
        Me.B_Import.Name = "B_Import"
        Me.B_Import.Size = New System.Drawing.Size(75, 23)
        Me.B_Import.TabIndex = 0
        Me.B_Import.Text = "Importieren"
        Me.B_Import.UseVisualStyleBackColor = True
        '
        'B_Export
        '
        Me.B_Export.Location = New System.Drawing.Point(93, 25)
        Me.B_Export.Name = "B_Export"
        Me.B_Export.Size = New System.Drawing.Size(75, 23)
        Me.B_Export.TabIndex = 1
        Me.B_Export.Text = "Exportieren"
        Me.B_Export.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Datenbank"
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.Description = "Wählen Sie den Speicherort für die Datenbank aus. Diese wird in einem Ordner mit " & _
    "dem heutigen Datum (jjjjmmtt) gespeichert."
        Me.FolderBrowserDialog.ShowNewFolderButton = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "AVSIB_Data.mdf"
        '
        'Import_Export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 55)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_Export)
        Me.Controls.Add(Me.B_Import)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Import_Export"
        Me.Text = "Im-Export"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Import As System.Windows.Forms.Button
    Friend WithEvents B_Export As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
