Imports System.Security.Cryptography
Imports System.Resources
Public Class LoginForm
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(LoginForm).Assembly)

    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click
        If UsernameTextBox.Text <> Nothing And PasswordTextBox.Text <> Nothing Then
            Dim dbHash As String = Benutzer.getHash(UsernameTextBox.Text)
            If dbHash = HashString(PasswordTextBox.Text) Then
                dbHash = ""
                MsgBox(LocRM.GetString("strSuccess"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                AVSIB_Main.Show()
                Close()
            ElseIf dbHash = "notFound" Then
                If Benutzer.GetCount() = 0 Then
                    If InputBox(LocRM.GetString("strConfirmPassword"), LocRM.GetString("titConfirmPassword")).ToString = PasswordTextBox.Text Then
                        Benutzer.Insert(UsernameTextBox.Text, HashString(PasswordTextBox.Text))
                        MsgBox(LocRM.GetString("strAddedUser"), MsgBoxStyle.Information, LocRM.GetString("titAddedUser"))
                    Else
                        MsgBox(LocRM.GetString("strWrongPassword"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
                    End If
                Else
                        MsgBox(LocRM.GetString("strUserNotFound"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
                End If
            Else
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

    Public Function HashString(ByVal inputString As String)
        Dim md5 As New MD5CryptoServiceProvider
        Dim md5input As Byte() = System.Text.Encoding.ASCII.GetBytes(inputString)
        inputString = ""
        Dim md5res As Byte() = md5.ComputeHash(md5input)
        Dim tmpstr As String = ""
        Dim Result As String = ""
        For i As Integer = 0 To md5res.Length - 1
            tmpstr = Hex(md5res(i))
            If Len(tmpstr) = 1 Then tmpstr = "0" & tmpstr
            Result += tmpstr
        Next
        Return Result
    End Function

End Class
