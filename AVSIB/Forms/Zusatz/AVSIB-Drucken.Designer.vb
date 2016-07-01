<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_Drucken
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_Drucken))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CNachname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CVorname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CStraße = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHaus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CZusatz = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.B_Next = New System.Windows.Forms.Button()
        Me.B_Previous = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1635, 672)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 43)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Menü"
        Me.ToolTip1.SetToolTip(Me.Button2, "Zurück zum Hauptmenü")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1424, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welche Bezirke sollen gedruckt werden?"
        '
        'ListView1
        '
        Me.ListView1.AutoArrange = False
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CNachname, Me.CVorname, Me.CStraße, Me.CHaus, Me.CZusatz})
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(18, 49)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.MaximumSize = New System.Drawing.Size(1398, 666)
        Me.ListView1.MinimumSize = New System.Drawing.Size(1398, 666)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(1398, 666)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CNachname
        '
        Me.CNachname.Text = "Nachname"
        Me.CNachname.Width = 200
        '
        'CVorname
        '
        Me.CVorname.Text = "Vorname"
        Me.CVorname.Width = 200
        '
        'CStraße
        '
        Me.CStraße.Text = "Straße"
        Me.CStraße.Width = 200
        '
        'CHaus
        '
        Me.CHaus.Text = "Hausnummer"
        Me.CHaus.Width = 80
        '
        'CZusatz
        '
        Me.CZusatz.Text = "Zusatz"
        Me.CZusatz.Width = 100
        '
        'B_Next
        '
        Me.B_Next.Image = Global.AVSIB.My.Resources.Resources.arrow_Next_16xLG_color
        Me.B_Next.Location = New System.Drawing.Point(1532, 672)
        Me.B_Next.Name = "B_Next"
        Me.B_Next.Size = New System.Drawing.Size(45, 43)
        Me.B_Next.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.B_Next, "Nächste Seite")
        Me.B_Next.UseVisualStyleBackColor = True
        '
        'B_Previous
        '
        Me.B_Previous.Image = Global.AVSIB.My.Resources.Resources.arrow_Previous_16xLG_color
        Me.B_Previous.Location = New System.Drawing.Point(1480, 672)
        Me.B_Previous.Name = "B_Previous"
        Me.B_Previous.Size = New System.Drawing.Size(45, 43)
        Me.B_Previous.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.B_Previous, "Vorherige Seite")
        Me.B_Previous.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1428, 672)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 43)
        Me.Button1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button1, "Druckt den/die ausgewählten Bezirk(e) aus.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(1550, 228)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(8, 4)
        Me.ListBox1.TabIndex = 7
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(1429, 74)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox2.Size = New System.Drawing.Size(290, 584)
        Me.ListBox2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Vorschau:"
        '
        'Button3
        '
        Me.Button3.Image = Global.AVSIB.My.Resources.Resources.pdf32
        Me.Button3.Location = New System.Drawing.Point(1583, 672)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 43)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AVSIB_Drucken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1724, 732)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_Previous)
        Me.Controls.Add(Me.B_Next)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1746, 791)
        Me.MinimumSize = New System.Drawing.Size(1746, 750)
        Me.Name = "AVSIB_Drucken"
        Me.Text = "AVSIB_Drucken"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents CNachname As System.Windows.Forms.ColumnHeader
    Friend WithEvents CVorname As System.Windows.Forms.ColumnHeader
    Friend WithEvents CStraße As System.Windows.Forms.ColumnHeader
    Friend WithEvents CHaus As System.Windows.Forms.ColumnHeader
    Friend WithEvents CZusatz As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents B_Next As Button
    Friend WithEvents B_Previous As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
End Class
