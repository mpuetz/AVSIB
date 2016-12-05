<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_Austräger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_Austräger))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBBezirk = New System.Windows.Forms.ComboBox()
        Me.TBNachname = New System.Windows.Forms.TextBox()
        Me.TBVorname = New System.Windows.Forms.TextBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        Me.ToolTip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        Me.ToolTip1.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'CBBezirk
        '
        resources.ApplyResources(Me.CBBezirk, "CBBezirk")
        Me.CBBezirk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBezirk.FormattingEnabled = True
        Me.CBBezirk.Name = "CBBezirk"
        Me.ToolTip1.SetToolTip(Me.CBBezirk, resources.GetString("CBBezirk.ToolTip"))
        '
        'TBNachname
        '
        resources.ApplyResources(Me.TBNachname, "TBNachname")
        Me.TBNachname.Name = "TBNachname"
        Me.ToolTip1.SetToolTip(Me.TBNachname, resources.GetString("TBNachname.ToolTip"))
        '
        'TBVorname
        '
        resources.ApplyResources(Me.TBVorname, "TBVorname")
        Me.TBVorname.Name = "TBVorname"
        Me.ToolTip1.SetToolTip(Me.TBVorname, resources.GetString("TBVorname.ToolTip"))
        '
        'ButtonDelete
        '
        resources.ApplyResources(Me.ButtonDelete, "ButtonDelete")
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ToolTip1.SetToolTip(Me.ButtonDelete, resources.GetString("ButtonDelete.ToolTip"))
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        resources.ApplyResources(Me.ButtonSave, "ButtonSave")
        Me.ButtonSave.Name = "ButtonSave"
        Me.ToolTip1.SetToolTip(Me.ButtonSave, resources.GetString("ButtonSave.ToolTip"))
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonMenu
        '
        resources.ApplyResources(Me.ButtonMenu, "ButtonMenu")
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ToolTip1.SetToolTip(Me.ButtonMenu, resources.GetString("ButtonMenu.ToolTip"))
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        resources.ApplyResources(Me.ListView1, "ListView1")
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ToolTip1.SetToolTip(Me.ListView1, resources.GetString("ListView1.ToolTip"))
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        resources.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
        '
        'ColumnHeader2
        '
        resources.ApplyResources(Me.ColumnHeader2, "ColumnHeader2")
        '
        'ColumnHeader3
        '
        resources.ApplyResources(Me.ColumnHeader3, "ColumnHeader3")
        '
        'AVSIB_Austräger
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.TBVorname)
        Me.Controls.Add(Me.TBNachname)
        Me.Controls.Add(Me.CBBezirk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AVSIB_Austräger"
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBBezirk As System.Windows.Forms.ComboBox
    Friend WithEvents TBNachname As System.Windows.Forms.TextBox
    Friend WithEvents TBVorname As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonMenu As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
