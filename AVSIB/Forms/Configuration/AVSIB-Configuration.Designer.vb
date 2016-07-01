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
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(1008, 729)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'ConfigButtonForward
        '
        Me.ConfigButtonForward.Location = New System.Drawing.Point(921, 237)
        Me.ConfigButtonForward.Name = "ConfigButtonForward"
        Me.ConfigButtonForward.Size = New System.Drawing.Size(75, 23)
        Me.ConfigButtonForward.TabIndex = 1
        Me.ConfigButtonForward.Text = "Weiter"
        Me.ConfigButtonForward.UseVisualStyleBackColor = True
        '
        'ConfigButtonBack
        '
        Me.ConfigButtonBack.AutoSize = True
        Me.ConfigButtonBack.Location = New System.Drawing.Point(840, 237)
        Me.ConfigButtonBack.Name = "ConfigButtonBack"
        Me.ConfigButtonBack.Size = New System.Drawing.Size(75, 23)
        Me.ConfigButtonBack.TabIndex = 2
        Me.ConfigButtonBack.Text = "Zurück"
        Me.ConfigButtonBack.UseVisualStyleBackColor = True
        '
        'AVSIB_Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.ConfigButtonBack)
        Me.Controls.Add(Me.ConfigButtonForward)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "AVSIB_Configuration"
        Me.Text = "AVSIB_Configuration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ConfigButtonForward As System.Windows.Forms.Button
    Friend WithEvents ConfigButtonBack As System.Windows.Forms.Button
End Class
