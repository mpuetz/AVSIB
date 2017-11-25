Imports System.Security.Cryptography
Imports System.Resources

Public Class LoginForm
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(LoginForm).Assembly)
    Public user As String
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click
        ' Checks if username and password were entered
        If UsernameTextBox.Text <> Nothing And PasswordTextBox.Text <> Nothing Then
            ' tries to get the hash of the entered username from the database
            Dim dbHash As String = Benutzer.getHash(UsernameTextBox.Text)
            ' If the username was not found ít is checked if one user in exists in the database
            If dbHash = "notFound" Then
                If Benutzer.GetCount() = 0 Then
                    ' If no user exists so far, a new user is added with the provided credentials after
                    ' confirmation of the password by retyping it. The password can not be recovered!
                    Dim salt As Byte() = Benutzer.CreateSalt()
                    Confirm_Password.salt = salt
                    Confirm_Password.ShowDialog()
                    Dim testhash As String = Confirm_Password.hash
                    If testhash = Benutzer.HashString(PasswordTextBox.Text, salt) Then
                        Confirm_Password.hash = Nothing
                        Benutzer.Insert(UsernameTextBox.Text, Benutzer.HashString(PasswordTextBox.Text, salt), salt, "admin")
                        MsgBox(LocRM.GetString("strAddedUser"), MsgBoxStyle.Information, LocRM.GetString("titAddedUser"))
                    Else
                        Confirm_Password.hash = Nothing
                        ' If the password is not entered correctly the second time a messagebox is shown and no user is created
                        MsgBox(LocRM.GetString("strWrongPassword"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
                    End If
                Else
                    MsgBox(LocRM.GetString("strUserNotFound"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
                End If
                'If a the user is found it checks if the hashes match. Each user has a individual salt which is retrieved from the database.
            ElseIf dbHash = Benutzer.HashString(PasswordTextBox.Text, Benutzer.getSalt(UsernameTextBox.Text)) Then
                dbHash = ""
                MsgBox(LocRM.GetString("strSuccess"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                ' If the checkbox is checked, the user is saved in the settings.ini file, else the line contaiing Username gets deleted.
                If CheckBox1.CheckState = CheckState.Checked Then
                    FileOperator.Save(Application.StartupPath + "\settings.ini", "Username", UsernameTextBox.Text)
                Else
                    Try
                        FileOperator.Delete(Application.StartupPath + "\settings.ini", "Username")
                    Catch ex As Exception
                    End Try
                End If
                ' In the end, the Main Menu is shown and the login prompt closed.
                user = UsernameTextBox.Text
                Log.WriteLog(user, user & " logged in!")
                AVSIB_Main.Show()
                Close()
            Else
                ' If none of the above matches the password has to be wrong.
                dbHash = ""
                MsgBox(LocRM.GetString("strWrongPassword"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
            End If
        ElseIf UsernameTextBox.Text = Nothing Then
            MsgBox(LocRM.GetString("strNoUsername"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        ElseIf PasswordTextBox.Text = Nothing Then
            MsgBox(LocRM.GetString("strNoPassword"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        Else
            MsgBox(LocRM.GetString("fieldsMissing"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' On load tries to load the latest username froms settings.ini
        Try
            UsernameTextBox.Text = FileOperator.Load(Application.StartupPath + "\settings.ini", "Username")
            If UsernameTextBox.Text <> Nothing Then
                CheckBox1.Checked = True
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
