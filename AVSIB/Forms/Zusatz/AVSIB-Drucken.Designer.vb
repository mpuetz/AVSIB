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
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.ToolTip1.SetToolTip(Me.Button2, resources.GetString("Button2.ToolTip"))
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        Me.ToolTip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'ListView1
        '
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.AutoArrange = False
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CNachname, Me.CVorname, Me.CStraße, Me.CHaus, Me.CZusatz})
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ToolTip1.SetToolTip(Me.ListView1, resources.GetString("ListView1.ToolTip"))
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CNachname
        '
        resources.ApplyResources(Me.CNachname, "CNachname")
        '
        'CVorname
        '
        resources.ApplyResources(Me.CVorname, "CVorname")
        '
        'CStraße
        '
        resources.ApplyResources(Me.CStraße, "CStraße")
        '
        'CHaus
        '
        resources.ApplyResources(Me.CHaus, "CHaus")
        '
        'CZusatz
        '
        resources.ApplyResources(Me.CZusatz, "CZusatz")
        '
        'B_Next
        '
        resources.ApplyResources(Me.B_Next, "B_Next")
        Me.B_Next.Image = Global.AVSIB.My.Resources.Resources.arrow_Next_16xLG_color
        Me.B_Next.Name = "B_Next"
        Me.ToolTip1.SetToolTip(Me.B_Next, resources.GetString("B_Next.ToolTip"))
        Me.B_Next.UseVisualStyleBackColor = True
        '
        'B_Previous
        '
        resources.ApplyResources(Me.B_Previous, "B_Previous")
        Me.B_Previous.Image = Global.AVSIB.My.Resources.Resources.arrow_Previous_16xLG_color
        Me.B_Previous.Name = "B_Previous"
        Me.ToolTip1.SetToolTip(Me.B_Previous, resources.GetString("B_Previous.ToolTip"))
        Me.B_Previous.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.ToolTip1.SetToolTip(Me.Button1, resources.GetString("Button1.ToolTip"))
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        resources.ApplyResources(Me.ListBox1, "ListBox1")
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Name = "ListBox1"
        Me.ToolTip1.SetToolTip(Me.ListBox1, resources.GetString("ListBox1.ToolTip"))
        '
        'ListBox2
        '
        resources.ApplyResources(Me.ListBox2, "ListBox2")
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ToolTip1.SetToolTip(Me.ListBox2, resources.GetString("ListBox2.ToolTip"))
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        Me.ToolTip1.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Image = Global.AVSIB.My.Resources.Resources.pdf32
        Me.Button3.Name = "Button3"
        Me.ToolTip1.SetToolTip(Me.Button3, resources.GetString("Button3.ToolTip"))
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AVSIB_Drucken
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Name = "AVSIB_Drucken"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
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
