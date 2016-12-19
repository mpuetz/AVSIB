Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Benutzer
    Public Shared Function getHash(ByVal username As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT password FROM Benutzer WHERE username=@username;", SQLCon)
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Benutzer")
            SQLCon.Close()
            If DataS.Tables(0).Rows.Count = 0 Then
                Return "notFound"
            Else
                Return DataS.Tables(0).Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function getSalt(ByVal username As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT salt FROM Benutzer WHERE username=@username;", SQLCon)
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Benutzer")
            SQLCon.Close()
            If DataS.Tables(0).Rows.Count = 0 Then
                Return "notFound"
            Else
                Return DataS.Tables(0).Rows(0).Item(0)
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetRole(ByVal username As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT role FROM Benutzer WHERE username=@username;", SQLCon)
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Benutzer")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetUsers(ByVal row As Long)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT username FROM Benutzer order by username;", SQLCon)
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Benutzer")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(row).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetCount()
        Try
            Dim BenutzerDataTable As New BenutzerDataSetTableAdapters.BenutzerTableAdapter
            Dim Count As Long = BenutzerDataTable.Count()
            Return Count
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function Update(ByVal username As String, ByVal password As String, ByVal salt As Byte(), ByVal role As String)
        Try
            Dim BenutzerDataTable As New BenutzerDataSetTableAdapters.BenutzerTableAdapter
            BenutzerDataTable.Update1(username, password, salt, role, username)
            Return 0
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function UserExists(ByVal username As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT username FROM Benutzer WHERE username=@username;", SQLCon)
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Benutzer")
            SQLCon.Close()
            Return DataS.Tables(0).Rows.Count

        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function Delete(ByVal username As String)
        Try
            Dim BenutzerDataTable As New BenutzerDataSetTableAdapters.BenutzerTableAdapter
            BenutzerDataTable.DeleteUser(username)
            Return 0
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function Insert(ByVal username As String, ByVal password As String, salt As Byte(), role As String)
        Try
            Dim BenutzerDataTable As New BenutzerDataSetTableAdapters.BenutzerTableAdapter
            Dim Count As Long = BenutzerDataTable.Insert(username, password, salt, role)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function


    Public Shared Function CreateSalt()
        Dim salt As Byte()
        ' Creates salt
        Dim rndlen As Random = New Random
        Dim rngcsp As RNGCryptoServiceProvider = New RNGCryptoServiceProvider
        salt = New Byte((rndlen.Next(4, 8) - 1)) {}
        rngcsp.GetNonZeroBytes(salt)
        Return salt
    End Function

    Public Shared Function HashString(ByVal inputString As String, ByVal salt As Byte())
        ' initialises sha-module and converts input to Byte-Array
        Dim sha512 As New SHA512CryptoServiceProvider
        Dim sha512input As Byte() = System.Text.Encoding.ASCII.GetBytes(inputString)
        inputString = ""

        ' combines salt and password
        Dim combined As Byte() = New Byte(sha512input.Length + (salt.Length - 1)) {}
        For i As Integer = 0 To sha512input.Length - 1
            combined(i) = sha512input(i)
        Next
        For i As Integer = 0 To salt.Length - 1
            combined(sha512input.Length + i) = salt(i)
        Next

        'create sha512-hash
        Dim sha512res As Byte() = sha512.ComputeHash(sha512input)

        'convert hash in Hex-String
        Dim tmpstr As String = ""
        Dim Result As String = ""
        For i As Integer = 0 To sha512res.Length - 1
            tmpstr = Hex(sha512res(i))
            If Len(tmpstr) = 1 Then tmpstr = "0" & tmpstr
            Result += tmpstr
        Next
        Return Result
    End Function

End Class
