<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManagement))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TBusername = New System.Windows.Forms.TextBox()
        Me.TBpassword = New System.Windows.Forms.TextBox()
        Me.CBrole = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Bdelete = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(13, 13)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(431, 440)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "username"
        Me.ColumnHeader1.Width = 164
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "role"
        Me.ColumnHeader2.Width = 91
        '
        'TBusername
        '
        Me.TBusername.Location = New System.Drawing.Point(450, 33)
        Me.TBusername.Name = "TBusername"
        Me.TBusername.Size = New System.Drawing.Size(239, 22)
        Me.TBusername.TabIndex = 1
        '
        'TBpassword
        '
        Me.TBpassword.Location = New System.Drawing.Point(450, 90)
        Me.TBpassword.Name = "TBpassword"
        Me.TBpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBpassword.Size = New System.Drawing.Size(239, 22)
        Me.TBpassword.TabIndex = 2
        '
        'CBrole
        '
        Me.CBrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBrole.FormattingEnabled = True
        Me.CBrole.Items.AddRange(New Object() {"user", "admin"})
        Me.CBrole.Location = New System.Drawing.Point(450, 145)
        Me.CBrole.Name = "CBrole"
        Me.CBrole.Size = New System.Drawing.Size(239, 24)
        Me.CBrole.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(450, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(450, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Role"
        '
        'Bdelete
        '
        Me.Bdelete.Location = New System.Drawing.Point(448, 175)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(49, 39)
        Me.Bdelete.TabIndex = 7
        Me.Bdelete.Text = "del"
        Me.Bdelete.UseVisualStyleBackColor = True
        '
        'Bsave
        '
        Me.Bsave.Location = New System.Drawing.Point(503, 175)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(49, 39)
        Me.Bsave.TabIndex = 8
        Me.Bsave.Text = "sav"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(614, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 465)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bsave)
        Me.Controls.Add(Me.Bdelete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBrole)
        Me.Controls.Add(Me.TBpassword)
        Me.Controls.Add(Me.TBusername)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserManagement"
        Me.Text = "UserManagement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents TBusername As TextBox
    Friend WithEvents TBpassword As TextBox
    Friend WithEvents CBrole As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Bdelete As Button
    Friend WithEvents Bsave As Button
    Friend WithEvents Button1 As Button
End Class
