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
'This class handles everything concerning the cities-datatable
Public Class Orte
    ' Inserts a new zip-code and city into the datatable using the VB Table-Adapter
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

    ' Delete a city and zip-code from the datatable. First city and zip-code is used to get the ID, the the city ist deleted by ID and zip-code
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

    ' Looks up the zip-code using the ID
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

    ' Looks up the city-name using the ID
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

    ' Looks up the ID using the zip-code and city-name
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

    ' Retrieves the number of entries in the datatable
    Public Shared Function GetCount()
        ' SQLCon = everything needed to connect to the database-file, cmd = the sql-command used, DataAdapter = adapter between database and dataset, DataSet stores the retrieved data
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
            Dim DAdapter As New SqlDataAdapter
            Dim DataS As New DataSet
            Try
                ' Opens the connection
                SQLCon.Open()
            Catch ex As Exception
                MsgBox("Could not connect to the database", MsgBoxStyle.Critical)
            End Try
        Try
            ' sets the SQL-command
            cmd = New SqlCommand("SELECT Distinct Ort FROM Orte ORDER BY Ort;", SQLCon)
            ' opens a new adapter using the command
            DAdapter = New SqlDataAdapter(cmd)
            ' fills the DataSet using the data retrieved by the DataAdapter
            DAdapter.Fill(DataS, "Orte")
            ' SQL-Connection closed
            SQLCon.Close()
            ' returns the result
            Return DataS.Tables(0).Rows.Count
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' this function is used to get the cities sorted ascending alphabetically. For more Information have a look at GetCount
    Public Shared Function GetOrtabc(ByVal row As Long)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
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
            SQLCon.Close()
            Return DataS.Tables(0).Rows(row).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' this function is used to get the number of zip-codes stored in the database. For more Information have a look at GetCount
    Public Shared Function GetPLZCount(ByVal Ort As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
            Dim DAdapter As New SqlDataAdapter
            Dim DataS As New DataSet
            Try
                SQLCon.Open()
            Catch ex As Exception
                MsgBox("Could not connect to the database", MsgBoxStyle.Critical)
            End Try
        Try
            cmd = New SqlCommand("SELECT PLZ FROM Orte Where Ort=@ort;", SQLCon)
            cmd.Parameters.Add("@ort", SqlDbType.NChar).Value = Ort
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Orte")
            SQLCon.Close()
            Return DataS.Tables(0).Rows.Count
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' this function is used to get the zip-codes for a specific city sorted ascending. For more Information have a look at GetCount
    Public Shared Function GetPLZabc(ByVal row As Long, Ort As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
            Dim DAdapter As New SqlDataAdapter
            Dim DataS As New DataSet
            Try
                SQLCon.Open()
            Catch ex As Exception
                MsgBox("Could not connect to the database", MsgBoxStyle.Critical)
            End Try
        Try
            cmd = New SqlCommand("SELECT PLZ FROM Orte Where Ort=@ort ORDER BY PLZ;", SQLCon)
            cmd.Parameters.Add("@ort", SqlDbType.NChar).Value = Ort
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Orte")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(row).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

End Class
