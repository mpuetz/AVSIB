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
'This class handles everything concerning the persons-datatable
Public Class Personen
    'This function is used to get the number of persons in the database. For more information concerning the commands have a look at Orte -> GetCount
    Public Shared Function GetCount()
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT Id FROM Personen ORDER BY Nachname, Vorname, Straße, Hausnummer;", SQLCon)
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Personen")
            SQLCon.Close()
            Return DataS.Tables(0).Rows.Count
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    'This function is used to get the IDs of persons in the database sorted as given from the user. For more information concerning the commands have a look at Orte -> GetCount
    Public Shared Function GetID(ByVal Row As Long, SortOrder As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT Id FROM Personen ORDER BY " & SortOrder & ";", SQLCon)
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Personen")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(Row).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' this function is used to retrieve the name of a person by the ID, using a DataTableAdapter.
    Public Shared Function GetNachname(ByVal ID As Long)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        Return DataTable.NachnamebyID(ID)
        Return 0
    End Function

    ' this function is used to retrieve the surname of a person by the ID, using a DataTableAdapter.
    Public Shared Function GetVorname(ByVal ID As Long)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        Return DataTable.VornameByID(ID)
        Return 0
    End Function

    ' this function is used to retrieve the housenumber of a person by the ID, using a DataTableAdapter.
    Public Shared Function GetHausNr(ByVal ID As Long)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        Dim hnr As String = DataTable.HausNrByID(ID)
        While hnr.First = "0"
            hnr = hnr.Substring(1)
        End While
        Return hnr
        Return 0
    End Function

    ' this function is used to retrieve any addition to the house number of a person by the ID, using a DataTableAdapter.
    Public Shared Function GetZusatz(ByVal ID As Long)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        Return DataTable.ZusatzByID(ID)
        Return 0
    End Function

    ' this function is used to retrieve the city of a person by the ID, using a DataTableAdapter.
    Public Shared Function GetOrt(ByVal ID As Long)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        Return DataTable.OrtByID(ID)
        Return 0
    End Function

    ' this function is used to retrieve the zip-code of a person by the ID, using a DataTableAdapter.
    Public Shared Function GetPLZ(ByVal ID As Long)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        Return DataTable.PLZByID(ID)
        Return 0
    End Function

    ' this function is used to retrieve the street of a person by the ID, using a DataTableAdapter.
    Public Shared Function GetStraße(ByVal ID As Long)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        Return DataTable.StraßeByID(ID)
        Return 0
    End Function

    ' this function is used to delete a person by the ID, using a DataTableAdapter.
    Public Shared Function Delete(ByVal ID As Long)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        DataTable.DeletebyID(ID)
        Return 0
    End Function

    ' this function is used to update the name, surname, street, house number, addition, zip-code and city of a person by the ID, using a DataTableAdapter.
    Public Shared Function Update(ByVal ID As Long, Nachname As String, Vorname As String, Straße As String, Hausnummer As Integer, Zusatz As String, PLZ As Integer, Ort As String)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        DataTable.UpdateByID(Nachname, Vorname, Straße, Hausnummer, Zusatz, Ort, PLZ, ID)
        Return 0
    End Function

    ' this function is used to insert the name, surname, street, house number, addition,zip-code and place of a person, using a DataTableAdapter.
    Public Shared Function Insert(Nachname As String, Vorname As String, Straße As String, Hausnummer As String, Zusatz As String, PLZ As Integer, Ort As String)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        Dim hl As Integer = Hausnummer.ToString.Length
        For i As Integer = 0 To 5 - hl
            Hausnummer = "0" & Hausnummer
        Next
        DataTable.InsertQuery(Nachname, Vorname, Straße, Hausnummer, Zusatz, Ort, PLZ)
        Return 0
    End Function

    ' this function retrieves the number of persons living in a specific street, city and zip-code
    Public Shared Function GetCountByKnown(ByVal Straße As String, Ort As String, PLZ As Integer)
        Dim DataTable As New PersonenDataSetTableAdapters.PersonenTableAdapter
        Return DataTable.CountByStraßeOrt(Straße, Ort, PLZ)
        Return 0
    End Function

    'This function is used to get the ID of a person where street, place and zip-code is known in the database. For more information concerning the commands have a look at Orte -> GetCount
    Public Shared Function GetIDByKnown(ByVal Row As Long, Straßen As String, Ort As String, PLZ As Integer)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT Id FROM Personen WHERE (Straße =  " & "'" & Straßen & "'" & ") AND (Ort = " & "'" & Ort & "'" & ") AND (PLZ = " & "'" & PLZ & "'" & ") ORDER BY Straße, Hausnummer, Zusatz, Nachname, Vorname;", SQLCon)
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Personen")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(Row).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetCountByLastName(ByVal LastName As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT Id FROM Personen WHERE (Nachname =  " & "'" & LastName & "'" & ") ORDER BY Straße, Hausnummer, Zusatz, Nachname, Vorname;", SQLCon)
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Personen")
            SQLCon.Close()
            Return DataS.Tables(0).Rows.Count
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetIDByLastName(ByVal LastName As String, ByVal Row As Long)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT Id FROM Personen WHERE (Nachname =  " & "'" & LastName & "'" & ") ORDER BY Straße, Hausnummer, Zusatz, Nachname, Vorname;", SQLCon)
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Personen")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(Row).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetIDByString(ByVal Row As Long, ByVal Searchstring As String, ByVal Order As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT Id FROM Personen WHERE " & Searchstring & " ORDER BY " & Order & ";", SQLCon)
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Personen")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(Row).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetCountByString(ByVal Searchstring As String)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT Id FROM Personen WHERE " & Searchstring & ") ORDER BY Straße, Hausnummer, Zusatz, Nachname, Vorname;", SQLCon)
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Personen")
            SQLCon.Close()
            Return DataS.Tables(0).Rows.Count
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function
End Class
