<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_PersonCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_PersonCheck))
        Me.Vorname = New System.Windows.Forms.TextBox()
        Me.Nachname = New System.Windows.Forms.TextBox()
        Me.Straße = New System.Windows.Forms.TextBox()
        Me.HausNr = New System.Windows.Forms.TextBox()
        Me.Zusatz = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.PLZ = New System.Windows.Forms.TextBox()
        Me.Ort = New System.Windows.Forms.TextBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.TSBBack = New System.Windows.Forms.ToolStripButton()
        Me.TSBNext = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.oneSecButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.threeSecButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.fiveSecButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.tenSecButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.udSecButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Vorname
        '
        resources.ApplyResources(Me.Vorname, "Vorname")
        Me.Vorname.Name = "Vorname"
        Me.Vorname.ReadOnly = True
        '
        'Nachname
        '
        resources.ApplyResources(Me.Nachname, "Nachname")
        Me.Nachname.Name = "Nachname"
        Me.Nachname.ReadOnly = True
        '
        'Straße
        '
        resources.ApplyResources(Me.Straße, "Straße")
        Me.Straße.Name = "Straße"
        Me.Straße.ReadOnly = True
        '
        'HausNr
        '
        resources.ApplyResources(Me.HausNr, "HausNr")
        Me.HausNr.Name = "HausNr"
        Me.HausNr.ReadOnly = True
        '
        'Zusatz
        '
        resources.ApplyResources(Me.Zusatz, "Zusatz")
        Me.Zusatz.Name = "Zusatz"
        Me.Zusatz.ReadOnly = True
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
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.TSBBack, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.TSBNext, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripProgressBar1, Me.ToolStripDropDownButton1, Me.PauseButton})
        resources.ApplyResources(Me.BindingNavigator1, "BindingNavigator1")
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        resources.ApplyResources(Me.BindingNavigatorCountItem, "BindingNavigatorCountItem")
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        resources.ApplyResources(Me.BindingNavigatorSeparator, "BindingNavigatorSeparator")
        '
        'BindingNavigatorPositionItem
        '
        resources.ApplyResources(Me.BindingNavigatorPositionItem, "BindingNavigatorPositionItem")
        Me.BindingNavigatorPositionItem.HideSelection = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        resources.ApplyResources(Me.BindingNavigatorSeparator1, "BindingNavigatorSeparator1")
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        resources.ApplyResources(Me.BindingNavigatorSeparator2, "BindingNavigatorSeparator2")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        resources.ApplyResources(Me.ToolStripProgressBar1, "ToolStripProgressBar1")
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'PLZ
        '
        resources.ApplyResources(Me.PLZ, "PLZ")
        Me.PLZ.Name = "PLZ"
        Me.PLZ.ReadOnly = True
        '
        'Ort
        '
        resources.ApplyResources(Me.Ort, "Ort")
        Me.Ort.Name = "Ort"
        Me.Ort.ReadOnly = True
        '
        'ButtonDelete
        '
        resources.ApplyResources(Me.ButtonDelete, "ButtonDelete")
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonMenu
        '
        resources.ApplyResources(Me.ButtonMenu, "ButtonMenu")
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        resources.ApplyResources(Me.ButtonNext, "ButtonNext")
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        resources.ApplyResources(Me.ButtonBack, "ButtonBack")
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMoveFirstItem, "BindingNavigatorMoveFirstItem")
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        '
        'TSBBack
        '
        Me.TSBBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.TSBBack, "TSBBack")
        Me.TSBBack.Name = "TSBBack"
        '
        'TSBNext
        '
        Me.TSBNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.TSBNext, "TSBNext")
        Me.TSBNext.Name = "TSBNext"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorMoveLastItem, "BindingNavigatorMoveLastItem")
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.BindingNavigatorDeleteItem, "BindingNavigatorDeleteItem")
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
        Me.ToolStripButton1.Name = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.ToolStripButton2, "ToolStripButton2")
        Me.ToolStripButton2.Name = "ToolStripButton2"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.oneSecButton, Me.threeSecButton, Me.fiveSecButton, Me.tenSecButton, Me.udSecButton})
        Me.ToolStripDropDownButton1.Image = Global.AVSIB.My.Resources.Resources.Timer_709
        resources.ApplyResources(Me.ToolStripDropDownButton1, "ToolStripDropDownButton1")
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        '
        'oneSecButton
        '
        Me.oneSecButton.CheckOnClick = True
        Me.oneSecButton.Name = "oneSecButton"
        resources.ApplyResources(Me.oneSecButton, "oneSecButton")
        '
        'threeSecButton
        '
        Me.threeSecButton.CheckOnClick = True
        Me.threeSecButton.Name = "threeSecButton"
        resources.ApplyResources(Me.threeSecButton, "threeSecButton")
        '
        'fiveSecButton
        '
        Me.fiveSecButton.CheckOnClick = True
        Me.fiveSecButton.Name = "fiveSecButton"
        resources.ApplyResources(Me.fiveSecButton, "fiveSecButton")
        '
        'tenSecButton
        '
        Me.tenSecButton.CheckOnClick = True
        Me.tenSecButton.Name = "tenSecButton"
        resources.ApplyResources(Me.tenSecButton, "tenSecButton")
        '
        'udSecButton
        '
        Me.udSecButton.CheckOnClick = True
        Me.udSecButton.Name = "udSecButton"
        resources.ApplyResources(Me.udSecButton, "udSecButton")
        '
        'PauseButton
        '
        Me.PauseButton.Checked = True
        Me.PauseButton.CheckOnClick = True
        Me.PauseButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PauseButton.Image = Global.AVSIB.My.Resources.Resources.StartPause_16x
        resources.ApplyResources(Me.PauseButton, "PauseButton")
        Me.PauseButton.Name = "PauseButton"
        '
        'AVSIB_PersonCheck
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.Ort)
        Me.Controls.Add(Me.PLZ)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Zusatz)
        Me.Controls.Add(Me.HausNr)
        Me.Controls.Add(Me.Straße)
        Me.Controls.Add(Me.Nachname)
        Me.Controls.Add(Me.Vorname)
        Me.Name = "AVSIB_PersonCheck"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Vorname As System.Windows.Forms.TextBox
    Friend WithEvents Nachname As System.Windows.Forms.TextBox
    Friend WithEvents Straße As System.Windows.Forms.TextBox
    Friend WithEvents HausNr As System.Windows.Forms.TextBox
    Friend WithEvents Zusatz As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PLZ As System.Windows.Forms.TextBox
    Friend WithEvents Ort As System.Windows.Forms.TextBox
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonMenu As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents oneSecButton As ToolStripMenuItem
    Friend WithEvents threeSecButton As ToolStripMenuItem
    Friend WithEvents fiveSecButton As ToolStripMenuItem
    Friend WithEvents tenSecButton As ToolStripMenuItem
    Friend WithEvents udSecButton As ToolStripMenuItem
    Friend WithEvents PauseButton As ToolStripButton
End Class
