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
        Me.Vorname.Location = New System.Drawing.Point(129, 25)
        Me.Vorname.MaxLength = 20
        Me.Vorname.Name = "Vorname"
        Me.Vorname.Size = New System.Drawing.Size(132, 20)
        Me.Vorname.TabIndex = 1
        '
        'Nachname
        '
        Me.Nachname.Location = New System.Drawing.Point(267, 25)
        Me.Nachname.MaxLength = 20
        Me.Nachname.Name = "Nachname"
        Me.Nachname.Size = New System.Drawing.Size(144, 20)
        Me.Nachname.TabIndex = 2
        '
        'HausNr
        '
        Me.HausNr.Location = New System.Drawing.Point(267, 105)
        Me.HausNr.MaxLength = 5
        Me.HausNr.Name = "HausNr"
        Me.HausNr.Size = New System.Drawing.Size(53, 20)
        Me.HausNr.TabIndex = 6
        '
        'Zusatz
        '
        Me.Zusatz.Location = New System.Drawing.Point(344, 105)
        Me.Zusatz.MaxLength = 10
        Me.Zusatz.Name = "Zusatz"
        Me.Zusatz.Size = New System.Drawing.Size(43, 20)
        Me.Zusatz.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Vorname, Nachname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Straße, Hausnummer"
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(270, 165)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(71, 23)
        Me.ButtonBack.TabIndex = 15
        Me.ButtonBack.Text = "Zurück"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(347, 165)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInsert.TabIndex = 16
        Me.ButtonInsert.Text = "Einfügen"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'LabelErfolg
        '
        Me.LabelErfolg.AutoSize = True
        Me.LabelErfolg.Location = New System.Drawing.Point(377, 142)
        Me.LabelErfolg.Name = "LabelErfolg"
        Me.LabelErfolg.Size = New System.Drawing.Size(34, 13)
        Me.LabelErfolg.TabIndex = 17
        Me.LabelErfolg.Text = "Erfolg"
        Me.LabelErfolg.Visible = False
        '
        'OrtAuswahl
        '
        Me.OrtAuswahl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.OrtAuswahl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.OrtAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrtAuswahl.FormattingEnabled = True
        Me.OrtAuswahl.Location = New System.Drawing.Point(129, 51)
        Me.OrtAuswahl.Name = "OrtAuswahl"
        Me.OrtAuswahl.Size = New System.Drawing.Size(144, 21)
        Me.OrtAuswahl.TabIndex = 3
        '
        'PLZAuswahl
        '
        Me.PLZAuswahl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.PLZAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PLZAuswahl.Enabled = False
        Me.PLZAuswahl.FormattingEnabled = True
        Me.PLZAuswahl.Location = New System.Drawing.Point(129, 78)
        Me.PLZAuswahl.Name = "PLZAuswahl"
        Me.PLZAuswahl.Size = New System.Drawing.Size(86, 21)
        Me.PLZAuswahl.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Ort"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "PLZ"
        '
        'CBStraße
        '
        Me.CBStraße.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStraße.Enabled = False
        Me.CBStraße.FormattingEnabled = True
        Me.CBStraße.Location = New System.Drawing.Point(129, 105)
        Me.CBStraße.Name = "CBStraße"
        Me.CBStraße.Size = New System.Drawing.Size(132, 21)
        Me.CBStraße.TabIndex = 5
        '
        'AVSIB_PersonInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 200)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(450, 239)
        Me.MinimumSize = New System.Drawing.Size(450, 239)
        Me.Name = "AVSIB_PersonInsert"
        Me.Text = "AVSIB_Person"
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
