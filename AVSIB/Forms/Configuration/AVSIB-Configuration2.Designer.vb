﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_Configuration2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_Configuration2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Config2ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBBackup = New System.Windows.Forms.ComboBox()
        Me.CBexport = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Config2ButtonNext
        '
        resources.ApplyResources(Me.Config2ButtonNext, "Config2ButtonNext")
        Me.Config2ButtonNext.Name = "Config2ButtonNext"
        Me.Config2ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        resources.ApplyResources(Me.ButtonBack, "ButtonBack")
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'CBBackup
        '
        resources.ApplyResources(Me.CBBackup, "CBBackup")
        Me.CBBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBackup.FormattingEnabled = True
        Me.CBBackup.Items.AddRange(New Object() {resources.GetString("CBBackup.Items"), resources.GetString("CBBackup.Items1")})
        Me.CBBackup.Name = "CBBackup"
        '
        'CBexport
        '
        resources.ApplyResources(Me.CBexport, "CBexport")
        Me.CBexport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBexport.FormattingEnabled = True
        Me.CBexport.Items.AddRange(New Object() {resources.GetString("CBexport.Items"), resources.GetString("CBexport.Items1")})
        Me.CBexport.Name = "CBexport"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'AVSIB_Configuration2
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CBexport)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBBackup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.Config2ButtonNext)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AVSIB_Configuration2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Config2ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CBBackup As ComboBox
    Friend WithEvents CBexport As ComboBox
    Friend WithEvents Label5 As Label
End Class
