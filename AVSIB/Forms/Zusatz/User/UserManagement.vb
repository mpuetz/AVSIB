Imports System.Resources

Public Class UserManagement
    Dim count As Long
    Dim user As String
    Dim locRM As New ResourceManager("AVSIB.WinFormStrings", GetType(UserManagement).Assembly)
    Dim blockedUser As String
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blockedUser = AVSIB_Main.user
        CBrole.SelectedIndex = 0
        updateListView()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            TBusername.Text = ListView1.SelectedItems(0).Text
            CBrole.SelectedItem = Benutzer.GetRole(TBusername.Text)
        End If
    End Sub

    Private Sub Bdelete_Click(sender As Object, e As EventArgs) Handles Bdelete.Click
        If count > 1 Then
            If TBusername.Text <> Nothing Then
                If TBusername.Text = blockedUser Then
                    MsgBox(locRM.GetString("strDeleteYourself"), MsgBoxStyle.Critical, locRM.GetString("titError"))
                Else
                    If MsgBox(locRM.GetString("strSure"), MsgBoxStyle.YesNo, locRM.GetString("titSure")) = MsgBoxResult.Yes Then
                        Benutzer.Delete(TBusername.Text)
                        updateListView()
                    End If
                End If
            Else
                    MsgBox(locRM.GetString("strNoUsername"), MsgBoxStyle.Exclamation, locRM.GetString("titError"))
                TBusername.Focus()
            End If
        Else
            MsgBox(locRM.GetString("strLastUser"), MsgBoxStyle.Exclamation, locRM.GetString("titCaution"))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Bsave_Click(sender As Object, e As EventArgs) Handles Bsave.Click
        If Benutzer.UserExists(TBusername.Text) = 0 Then
            If TBusername.Text <> Nothing And TBpassword.Text <> Nothing Then
                Dim salt As Byte() = Benutzer.CreateSalt()
                Confirm_Password.salt = salt
                Confirm_Password.ShowDialog()
                Dim testhash As String = Confirm_Password.hash
                If testhash = Benutzer.HashString(TBpassword.Text, salt) Then
                    Confirm_Password.hash = Nothing
                    Benutzer.Insert(TBusername.Text, Benutzer.HashString(TBpassword.Text, salt), salt, CBrole.SelectedItem.ToString)
                    MsgBox(locRM.GetString("strAddedUser"), MsgBoxStyle.Information, locRM.GetString("titAddedUser"))
                    updateListView()
                End If
            ElseIf TBusername.Text = Nothing Then
                    MsgBox(locRM.GetString("strNoUsername"), MsgBoxStyle.Critical, locRM.GetString("titError"))
                    TBusername.Focus()
                ElseIf TBpassword.Text = Nothing Then
                    MsgBox(locRM.GetString("strNoPassword"), MsgBoxStyle.Critical, locRM.GetString("titError"))
                TBpassword.Focus()
            End If
        Else
            If TBusername.Text <> Nothing And TBpassword.Text <> Nothing Then
                If TBusername.Text = blockedUser Then
                    MsgBox(locRM.GetString("strChangeYourself"), MsgBoxStyle.Critical, locRM.GetString("titError"))
                Else
                    Dim salt As Byte() = Benutzer.CreateSalt()
                    Confirm_Password.salt = salt
                    Confirm_Password.ShowDialog()
                    Dim testhash As String = Confirm_Password.hash
                    If testhash = Benutzer.HashString(TBpassword.Text, salt) Then
                        Confirm_Password.hash = Nothing
                        Benutzer.Update(TBusername.Text, Benutzer.HashString(TBpassword.Text, salt), salt, CBrole.SelectedItem.ToString)
                        MsgBox(locRM.GetString("strUpdatedUser"), MsgBoxStyle.Information, locRM.GetString("titUpdatedUser"))
                        updateListView()
                    End If
                End If
                    ElseIf TBusername.Text = Nothing Then
                MsgBox(locRM.GetString("strNoUsername"), MsgBoxStyle.Critical, locRM.GetString("titError"))
                TBusername.Focus()
            ElseIf TBpassword.Text = Nothing Then
                MsgBox(locRM.GetString("strNoPassword"), MsgBoxStyle.Critical, locRM.GetString("titError"))
                TBpassword.Focus()
            End If
        End If
    End Sub

    Private Function updateListView()
        count = Benutzer.GetCount()
        ListView1.Items.Clear()
        For i As Long = 0 To count - 1
            Dim lvi As New ListViewItem
            user = Benutzer.GetUsers(i)
            lvi.Text = user
            lvi.SubItems.Add(Benutzer.GetRole(user))
            ListView1.Items.Add(lvi)
        Next
        Return 0
    End Function
End Class