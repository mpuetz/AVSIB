<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_Configuration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_Configuration))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ConfigButtonForward = New System.Windows.Forms.Button()
        Me.ConfigButtonBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        resources.ApplyResources(Me.RichTextBox1, "RichTextBox1")
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        '
        'ConfigButtonForward
        '
        resources.ApplyResources(Me.ConfigButtonForward, "ConfigButtonForward")
        Me.ConfigButtonForward.Name = "ConfigButtonForward"
        Me.ConfigButtonForward.UseVisualStyleBackColor = True
        '
        'ConfigButtonBack
        '
        resources.ApplyResources(Me.ConfigButtonBack, "ConfigButtonBack")
        Me.ConfigButtonBack.Name = "ConfigButtonBack"
        Me.ConfigButtonBack.UseVisualStyleBackColor = True
        '
        'AVSIB_Configuration
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ConfigButtonBack)
        Me.Controls.Add(Me.ConfigButtonForward)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "AVSIB_Configuration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ConfigButtonForward As System.Windows.Forms.Button
    Friend WithEvents ConfigButtonBack As System.Windows.Forms.Button
End Class
