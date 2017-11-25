<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AVSIB_ChangePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVSIB_ChangePass))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNew = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBRep = New System.Windows.Forms.TextBox()
        Me.BMenu = New System.Windows.Forms.Button()
        Me.BViewN = New System.Windows.Forms.Button()
        Me.BViewR = New System.Windows.Forms.Button()
        Me.BViewC = New System.Windows.Forms.Button()
        Me.BSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TBCur
        '
        resources.ApplyResources(Me.TBCur, "TBCur")
        Me.TBCur.Name = "TBCur"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TBNew
        '
        resources.ApplyResources(Me.TBNew, "TBNew")
        Me.TBNew.Name = "TBNew"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'TBRep
        '
        resources.ApplyResources(Me.TBRep, "TBRep")
        Me.TBRep.Name = "TBRep"
        '
        'BMenu
        '
        resources.ApplyResources(Me.BMenu, "BMenu")
        Me.BMenu.Name = "BMenu"
        Me.BMenu.UseVisualStyleBackColor = True
        '
        'BViewN
        '
        resources.ApplyResources(Me.BViewN, "BViewN")
        Me.BViewN.Image = Global.AVSIB.My.Resources.Resources.eye_16xLG
        Me.BViewN.Name = "BViewN"
        Me.BViewN.UseVisualStyleBackColor = True
        '
        'BViewR
        '
        resources.ApplyResources(Me.BViewR, "BViewR")
        Me.BViewR.Image = Global.AVSIB.My.Resources.Resources.eye_16xLG
        Me.BViewR.Name = "BViewR"
        Me.BViewR.UseVisualStyleBackColor = True
        '
        'BViewC
        '
        resources.ApplyResources(Me.BViewC, "BViewC")
        Me.BViewC.Image = Global.AVSIB.My.Resources.Resources.eye_16xLG
        Me.BViewC.Name = "BViewC"
        Me.BViewC.UseVisualStyleBackColor = True
        '
        'BSave
        '
        resources.ApplyResources(Me.BSave, "BSave")
        Me.BSave.Image = Global.AVSIB.My.Resources.Resources.Save_32x
        Me.BSave.Name = "BSave"
        Me.BSave.UseVisualStyleBackColor = True
        '
        'AVSIB_ChangePass
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BViewR)
        Me.Controls.Add(Me.BViewN)
        Me.Controls.Add(Me.BViewC)
        Me.Controls.Add(Me.BMenu)
        Me.Controls.Add(Me.BSave)
        Me.Controls.Add(Me.TBRep)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBNew)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBCur)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AVSIB_ChangePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TBCur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBNew As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBRep As TextBox
    Friend WithEvents BSave As Button
    Friend WithEvents BMenu As Button
    Friend WithEvents BViewC As Button
    Friend WithEvents BViewN As Button
    Friend WithEvents BViewR As Button
End Class
