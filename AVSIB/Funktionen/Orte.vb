'Das Programm dient zum Aufbau und zur Pflege einer Datenbank, In welcher die Empfänger einer Informationsschrift den Austrägern zugeordnet werden. 
'Für die Austräger können entsprechende Adresslisten gedruckt werden. 
'    Copyright(C) 2016 Michael Pütz, E-Mail: software@mpuetzonline.de

'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    (at your option) any later version.

'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License For more details.

'    You should have received a copy Of the GNU General Public License
'    along with this program.  If Not, see < http: //www.gnu.org/licenses/>.

'____________________________________________________________________________

Imports System.Data.SqlClient
Public Class Orte
    Public Shared Function Insert(ByVal PLZ As Long, Ort As String)
        Try
            Using OrteTableAdapter As New OrteDataSetTableAdapters.OrteTableAdapter
                OrteTableAdapter.Insert(PLZ, Ort)
            End Using
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function Remove(ByVal PLZ As Integer, Ort As String)
        Try
            Using OrteTableAdapter As New OrteDataSetTableAdapters.OrteTableAdapter
                Dim ID As Integer = OrteTableAdapter.GetID(Ort, PLZ)
                OrteTableAdapter.Delete(ID, PLZ)
            End Using
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function ReadPLZ(ByVal ID As Long)
        Try
            Dim PLZ As Integer
            Using OrteTableAdapter As New OrteDataSetTableAdapters.OrteTableAdapter
                PLZ = OrteTableAdapter.GetPLZbyID(ID)
                Return PLZ
            End Using
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function ReadOrt(ByVal ID As Long)
        Try
            Dim Ort As String
            Using OrteTableAdapter As New OrteDataSetTableAdapters.OrteTableAdapter
                Ort = OrteTableAdapter.GetOrtbyID(ID)
                Return Ort
            End Using
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetID(ByVal PLZ As Integer, Ort As String)
        Try
            Dim ID As Long
            Using OrteTableAdapter As New OrteDataSetTableAdapters.OrteTableAdapter
                ID = OrteTableAdapter.GetID(Ort, PLZ)
                Return ID
            End Using
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetCount()
        Using SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
            Dim cmd As New SqlCommand
            Dim DAdapter As New SqlDataAdapter
            Dim DataS As New DataSet
            Try
                SQLCon.Open()
            Catch ex As Exception
                MsgBox("Could not connect to the database", MsgBoxStyle.Critical)
            End Try
            Try
                    cmd = New SqlCommand("SELECT Distinct Ort FROM Orte ORDER BY Ort;", SQLCon)
                    DAdapter = New SqlDataAdapter(cmd)
                    DAdapter.Fill(DataS, "Orte")
                    Return DataS.Tables(0).Rows.Count
                Catch ex As Exception
                    MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
            End Try
        End Using
        Return 0
    End Function

    Public Shared Function GetOrtabc(ByVal row As Long)
        Using SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
            Dim cmd As New SqlCommand
            Dim DAdapter As New SqlDataAdapter
            Dim DataS As New DataSet
            Try
                SQLCon.Open()
            Catch ex As Exception
                MsgBox("Could not connect to the database", MsgBoxStyle.Critical)
            End Try
            Try
                cmd = New SqlCommand("SELECT Distinct Ort FROM Orte ORDER BY Ort;", SQLCon)
                DAdapter = New SqlDataAdapter(cmd)
                DAdapter.Fill(DataS, "Orte")
                Return DataS.Tables(0).Rows(row).Item(0)
            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
            End Try
        End Using
        Return 0
    End Function

    Public Shared Function GetPLZCount(ByVal Ort As String)
        Using SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
            Dim cmd As New SqlCommand
            Dim DAdapter As New SqlDataAdapter
            Dim DataS As New DataSet
            Try
                SQLCon.Open()
            Catch ex As Exception
                MsgBox("Could not connect to the database", MsgBoxStyle.Critical)
            End Try
            Try
                cmd = New SqlCommand("SELECT PLZ FROM Orte Where Ort = " & "'" & Ort & "'" & " ;", SQLCon)
                DAdapter = New SqlDataAdapter(cmd)
                DAdapter.Fill(DataS, "Orte")
                Return DataS.Tables(0).Rows.Count
            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
            End Try
        End Using
        Return 0
    End Function

    Public Shared Function GetPLZabc(ByVal row As Long, Ort As String)
        Using SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
            Dim cmd As New SqlCommand
            Dim DAdapter As New SqlDataAdapter
            Dim DataS As New DataSet
            Try
                SQLCon.Open()
            Catch ex As Exception
                MsgBox("Could not connect to the database", MsgBoxStyle.Critical)
            End Try
            Try
                cmd = New SqlCommand("SELECT PLZ FROM Orte Where Ort = " & "'" & Ort & "'" & " ORDER BY PLZ;", SQLCon)
                DAdapter = New SqlDataAdapter(cmd)
                DAdapter.Fill(DataS, "Orte")
                Return DataS.Tables(0).Rows(row).Item(0)
            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
            End Try
        End Using
        Return 0
    End Function

End Class
