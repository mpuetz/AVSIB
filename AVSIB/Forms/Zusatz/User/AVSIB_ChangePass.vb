Imports System.Resources

Public Class AVSIB_ChangePass
    Dim locRM As New ResourceManager("AVSIB.WinFormStrings", GetType(AVSIB_ChangePass).Assembly)
    Private Sub BViewC_MouseDown(sender As Object, e As MouseEventArgs) Handles BViewC.MouseDown
        TBCur.PasswordChar = ""
    End Sub
    Private Sub BViewC_MouseUp(sender As Object, e As MouseEventArgs) Handles BViewC.MouseUp
        TBCur.PasswordChar = "*"
    End Sub
    Private Sub BViewN_MouseDown(sender As Object, e As MouseEventArgs) Handles BViewN.MouseDown
        TBNew.PasswordChar = ""
    End Sub
    Private Sub BViewN_MouseUp(sender As Object, e As MouseEventArgs) Handles BViewN.MouseUp
        TBNew.PasswordChar = "*"
    End Sub
    Private Sub BViewR_MouseDown(sender As Object, e As MouseEventArgs) Handles BViewR.MouseDown
        TBRep.PasswordChar = ""
    End Sub
    Private Sub BViewR_MouseUp(sender As Object, e As MouseEventArgs) Handles BViewR.MouseUp
        TBRep.PasswordChar = "*"
    End Sub

    Private Sub BMenu_Click(sender As Object, e As EventArgs) Handles BMenu.Click
        Close()
    End Sub

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click
        If TBCur.Text <> Nothing And TBNew.Text <> Nothing And TBRep.Text <> Nothing Then

            If Benutzer.getHash(AVSIB_Main.user) = Benutzer.HashString(TBCur.Text, Benutzer.getSalt(AVSIB_Main.user)) Then
                Dim salt As Byte() = Benutzer.CreateSalt
                Dim hash1 As String = Benutzer.HashString(TBNew.Text, salt)
                Dim hash2 As String = Benutzer.HashString(TBRep.Text, salt)

                If hash1 = hash2 Then
                    Benutzer.Update(AVSIB_Main.user, hash1, salt, Benutzer.GetRole(AVSIB_Main.user))
                    MsgBox(locRM.GetString("strUpdatedUser"), MsgBoxStyle.Information, locRM.GetString("titUpdatedUser"))
                    hash1 = Nothing
                    hash2 = Nothing
                    Array.Clear(salt, 0, salt.Length)
                    TBCur.Text = Nothing
                    TBNew.Text = Nothing
                    TBRep.Text = Nothing
                Else
                    MsgBox(locRM.GetString("strWrongPassword"), MsgBoxStyle.Critical, locRM.GetString("titError"))
                    TBNew.Focus()
                End If

            Else
                MsgBox(locRM.GetString("strWrongPassword"), MsgBoxStyle.Critical, locRM.GetString("titError"))
                TBCur.Focus()
            End If

        ElseIf TBCur.Text = Nothing Then
            MsgBox(locRM.GetString("strNoPassword"), MsgBoxStyle.Exclamation, locRM.GetString("titError"))
            TBCur.Focus()
        ElseIf TBNew.Text = Nothing Then
            MsgBox(locRM.GetString("strNoPassword"), MsgBoxStyle.Exclamation, locRM.GetString("titError"))
            TBNew.Focus()
        ElseIf TBRep.Text = Nothing Then
            MsgBox(locRM.GetString("strNoPassword"), MsgBoxStyle.Exclamation, locRM.GetString("titError"))
            TBRep.Focus()
        End If
    End Sub
End Class