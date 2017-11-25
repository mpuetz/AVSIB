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
        resources.ApplyResources(Me.B_Import, "B_Import")
        Me.B_Import.Name = "B_Import"
        Me.B_Import.UseVisualStyleBackColor = True
        '
        'B_Export
        '
        resources.ApplyResources(Me.B_Export, "B_Export")
        Me.B_Export.Name = "B_Export"
        Me.B_Export.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'FolderBrowserDialog
        '
        resources.ApplyResources(Me.FolderBrowserDialog, "FolderBrowserDialog")
        Me.FolderBrowserDialog.ShowNewFolderButton = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "AVSIB_Data.mdf"
        '
        'Import_Export
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_Export)
        Me.Controls.Add(Me.B_Import)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Import_Export"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Import As System.Windows.Forms.Button
    Friend WithEvents B_Export As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
