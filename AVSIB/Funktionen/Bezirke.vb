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
' This class provides acces to the district-databse. Districts connect the roundsmen with the streets and cities (each one has a new table) in the database
Public Class Bezirke
    ' This function gets the number of districts in the database
    Public Shared Function GetCount(ByVal BezirkNr As Long)
        Dim DataTable As New BezirkDataSetTableAdapters.BezirkeTableAdapter
        Return DataTable.GetCountByBezirk(BezirkNr)
        Return 0
    End Function

    ' This function is used to look up the streets in a district using the district number
    Public Shared Function GetStraßenByBezirk(ByVal BezirkNr As Long, Row As Long)
        ' At first, a connection to the database-file is established. cmd holds the SQL-command, the DataAdapter is used to store the data retrieved
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            ' This command selects cities, zip code and street in a specific district number, sorted ascending by 1. city, 2. zip code and 3. street
            cmd = New SqlCommand("Select Straßen.Ort, Straßen.PLZ, Straßen.Straße  From Bezirke INNER JOIN Straßen ON Bezirke.StraßeID=Straßen.Id Where BezirkNr=" _
                                 & "@bezirknr Order By Straßen.Ort ASC, Straßen.PLZ ASC, Straßen.Straße ASC;", SQLCon)
            cmd.Parameters.Add("@bezirknr", SqlDbType.BigInt).Value = BezirkNr
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Bezirke")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(Row).Item(2)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' This function is used to look up the zip codes in a district using the district number. If you want to know what each comman does please look at GetStraßenByBezirk
    Public Shared Function GetPLZByBezirk(ByVal BezirkNr As Long, Row As Long)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("Select Straßen.Ort, Straßen.PLZ, Straßen.Straße From Bezirke INNER JOIN Straßen ON Bezirke.StraßeID=Straßen.Id Where BezirkNr = " _
                                 & "@bezirknr Order By Straßen.Ort ASC, Straßen.PLZ ASC, Straßen.Straße ASC;", SQLCon)
            cmd.Parameters.Add("@bezirknr", SqlDbType.BigInt).Value = BezirkNr
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Bezirke")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(Row).Item(1)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' This function is used to look up the cities in a district using the district number. If you want to know what each command does please have a look at GetStraßeByID
    Public Shared Function GetOrtByBezirk(ByVal BezirkNr As Long, Row As Long)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("Select Straßen.Ort, Straßen.PLZ, Straßen.Straße From Bezirke INNER JOIN Straßen ON Bezirke.StraßeID=Straßen.Id Where BezirkNr = " _
                                 & "@bezirknr Order By Straßen.Ort ASC, Straßen.PLZ ASC, Straßen.Straße ASC;", SQLCon)
            cmd.Parameters.Add("@bezirknr", SqlDbType.BigInt).Value = BezirkNr
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Bezirke")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(Row).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' This function is used to look up the district ID using the street-ID
    Public Shared Function GetIDByStraße(ByVal StraßenID As Long)
        Dim DataTable As New BezirkDataSetTableAdapters.BezirkeTableAdapter
        Return DataTable.GetBezirkByStraßeID(StraßenID)
        Return 0
    End Function

    ' This function is used to delete a connection between a street and district using the street-id
    Public Shared Function DeleteStraßeByID(ByVal StraßenID As Long)
        Try
            Dim DataTable As New BezirkDataSetTableAdapters.BezirkeTableAdapter
            DataTable.DeleteStraßeByID(StraßenID)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' This function is used to inset a new connection between street-id and district-id
    Public Shared Function Insert(ByVal StraßenID As Long, BezirkNr As Long)
        Dim DataTable As New BezirkDataSetTableAdapters.BezirkeTableAdapter
        DataTable.Insert(BezirkNr, StraßenID)
        Return 0
    End Function

    ' This function is used to update the connection between street-id and district-id
    Public Shared Function Update(ByVal StraßenID As Long, BezirkNr As Long)
        Dim DataTable As New BezirkDataSetTableAdapters.BezirkeTableAdapter
        DataTable.UpdateQuery(BezirkNr, StraßenID, StraßenID)
        Return 0
    End Function

End Class
