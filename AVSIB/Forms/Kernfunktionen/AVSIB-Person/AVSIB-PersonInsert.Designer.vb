<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_PersonInsert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_PersonInsert))
        Me.Vorname = New System.Windows.Forms.TextBox()
        Me.Nachname = New System.Windows.Forms.TextBox()
        Me.HausNr = New System.Windows.Forms.TextBox()
        Me.Zusatz = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.LabelErfolg = New System.Windows.Forms.Label()
        Me.OrtAuswahl = New System.Windows.Forms.ComboBox()
        Me.PLZAuswahl = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBStraße = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Vorname
        '
        resources.ApplyResources(Me.Vorname, "Vorname")
        Me.Vorname.Name = "Vorname"
        '
        'Nachname
        '
        resources.ApplyResources(Me.Nachname, "Nachname")
        Me.Nachname.Name = "Nachname"
        '
        'HausNr
        '
        resources.ApplyResources(Me.HausNr, "HausNr")
        Me.HausNr.Name = "HausNr"
        '
        'Zusatz
        '
        resources.ApplyResources(Me.Zusatz, "Zusatz")
        Me.Zusatz.Name = "Zusatz"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'ButtonBack
        '
        resources.ApplyResources(Me.ButtonBack, "ButtonBack")
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonInsert
        '
        resources.ApplyResources(Me.ButtonInsert, "ButtonInsert")
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'LabelErfolg
        '
        resources.ApplyResources(Me.LabelErfolg, "LabelErfolg")
        Me.LabelErfolg.Name = "LabelErfolg"
        '
        'OrtAuswahl
        '
        resources.ApplyResources(Me.OrtAuswahl, "OrtAuswahl")
        Me.OrtAuswahl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.OrtAuswahl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.OrtAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrtAuswahl.FormattingEnabled = True
        Me.OrtAuswahl.Name = "OrtAuswahl"
        '
        'PLZAuswahl
        '
        resources.ApplyResources(Me.PLZAuswahl, "PLZAuswahl")
        Me.PLZAuswahl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.PLZAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PLZAuswahl.FormattingEnabled = True
        Me.PLZAuswahl.Name = "PLZAuswahl"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'CBStraße
        '
        resources.ApplyResources(Me.CBStraße, "CBStraße")
        Me.CBStraße.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStraße.FormattingEnabled = True
        Me.CBStraße.Name = "CBStraße"
        '
        'AVSIB_PersonInsert
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CBStraße)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PLZAuswahl)
        Me.Controls.Add(Me.OrtAuswahl)
        Me.Controls.Add(Me.LabelErfolg)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Zusatz)
        Me.Controls.Add(Me.HausNr)
        Me.Controls.Add(Me.Nachname)
        Me.Controls.Add(Me.Vorname)
        Me.Name = "AVSIB_PersonInsert"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Vorname As System.Windows.Forms.TextBox
    Friend WithEvents Nachname As System.Windows.Forms.TextBox
    Friend WithEvents HausNr As System.Windows.Forms.TextBox
    Friend WithEvents Zusatz As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents ButtonInsert As System.Windows.Forms.Button
    Friend WithEvents LabelErfolg As System.Windows.Forms.Label
    Friend WithEvents OrtAuswahl As System.Windows.Forms.ComboBox
    Friend WithEvents PLZAuswahl As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CBStraße As System.Windows.Forms.ComboBox
End Class
