
Public Class Log
    Public Shared Function WriteLog(ByVal username As String, ByVal input As String)
        If IO.Directory.Exists(Application.StartupPath & "\logs") = False Then
            MkDir(Application.StartupPath & "\logs")
        End If
        Dim path As String = Application.StartupPath & "\logs\" & Now.Year & "-" & Now.Month & "-" & Now.Day & ".log"
        Dim datum As String = DateTime.Now.ToString
        Dim Text As String = "[" & datum & "]: " & username & ": " & input & vbCrLf
        My.Computer.FileSystem.WriteAllText(path, Text, True)
        Return 0
    End Function
End Class
