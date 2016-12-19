Imports System.Data.SqlClient

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

    Public Shared Function Insert(ByVal username As String, ByVal password As String)
        Try
            Dim BenutzerDataTable As New BenutzerDataSetTableAdapters.BenutzerTableAdapter
            Dim Count As Long = BenutzerDataTable.Insert1(username, password)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function
End Class
