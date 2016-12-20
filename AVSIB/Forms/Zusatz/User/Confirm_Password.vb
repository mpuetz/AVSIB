Public Class Confirm_Password
    Public Shared hash As String
    Public salt As Byte()
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hash = Benutzer.HashString(TextBox1.Text, salt)
        Array.Clear(salt, 0, salt.Length)
        TextBox1.Text = Nothing
        Close()
    End Sub
End Class