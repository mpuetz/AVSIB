<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_PersonFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_PersonFilter))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.BFilter = New System.Windows.Forms.Button()
        Me.LCity = New System.Windows.Forms.Label()
        Me.LZIP = New System.Windows.Forms.Label()
        Me.LStreet = New System.Windows.Forms.Label()
        Me.CBAdress = New System.Windows.Forms.CheckBox()
        Me.CBName = New System.Windows.Forms.CheckBox()
        Me.LFirstName = New System.Windows.Forms.Label()
        Me.LLastName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox2, "ComboBox2")
        Me.ComboBox2.Name = "ComboBox2"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox3, "ComboBox3")
        Me.ComboBox3.Name = "ComboBox3"
        '
        'BFilter
        '
        resources.ApplyResources(Me.BFilter, "BFilter")
        Me.BFilter.Name = "BFilter"
        Me.BFilter.UseVisualStyleBackColor = True
        '
        'LCity
        '
        resources.ApplyResources(Me.LCity, "LCity")
        Me.LCity.Name = "LCity"
        '
        'LZIP
        '
        resources.ApplyResources(Me.LZIP, "LZIP")
        Me.LZIP.Name = "LZIP"
        '
        'LStreet
        '
        resources.ApplyResources(Me.LStreet, "LStreet")
        Me.LStreet.Name = "LStreet"
        '
        'CBAdress
        '
        resources.ApplyResources(Me.CBAdress, "CBAdress")
        Me.CBAdress.Checked = True
        Me.CBAdress.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBAdress.Name = "CBAdress"
        Me.CBAdress.UseVisualStyleBackColor = True
        '
        'CBName
        '
        resources.ApplyResources(Me.CBName, "CBName")
        Me.CBName.Name = "CBName"
        Me.CBName.UseVisualStyleBackColor = True
        '
        'LFirstName
        '
        resources.ApplyResources(Me.LFirstName, "LFirstName")
        Me.LFirstName.Name = "LFirstName"
        '
        'LLastName
        '
        resources.ApplyResources(Me.LLastName, "LLastName")
        Me.LLastName.Name = "LLastName"
        '
        'AVSIB_PersonFilter
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LLastName)
        Me.Controls.Add(Me.LFirstName)
        Me.Controls.Add(Me.CBName)
        Me.Controls.Add(Me.CBAdress)
        Me.Controls.Add(Me.LStreet)
        Me.Controls.Add(Me.LZIP)
        Me.Controls.Add(Me.LCity)
        Me.Controls.Add(Me.BFilter)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "AVSIB_PersonFilter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents BFilter As Button
    Friend WithEvents LCity As Label
    Friend WithEvents LZIP As Label
    Friend WithEvents LStreet As Label
    Friend WithEvents CBAdress As CheckBox
    Friend WithEvents CBName As CheckBox
    Friend WithEvents LFirstName As Label
    Friend WithEvents LLastName As Label
End Class
