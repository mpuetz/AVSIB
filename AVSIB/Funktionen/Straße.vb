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
' handles everything concerning the streets-datatable
Public Class Straße
    ' inserts street, zip-code and place into the datatable using an DataSetTableAdapter
    Public Shared Function Insert(ByVal Straße As String, PLZ As Integer, Ort As String)
        Try
            Dim StraßenDataTable As New StraßenDataSetTableAdapters.StraßenTableAdapter
            StraßenDataTable.Insert(Straße, PLZ, Ort)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' retrieves street by zip-code and city-name from the datatable using an DataSetTableAdapter
    Public Shared Function GetStraßebyOrt(ByVal PLZ As Integer, Ort As String)
        Try
            Dim StraßenDataTable As New StraßenDataSetTableAdapters.StraßenTableAdapter
            Dim Straße As String = StraßenDataTable.GetStraßeByOrtPLZ(PLZ, Ort)
            Return Straße
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' retrieves street by ID from the datatable using an DataSetTableAdapter
    Public Shared Function GetStraßebyID(ByVal ID As Long)
        Try
            Dim StraßenDataTable As New StraßenDataSetTableAdapters.StraßenTableAdapter
            Dim Straße As String = StraßenDataTable.GetStraßebyID(ID)
            Return Straße
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' retrieves ID by street, zip-code and city-name from the datatable using an DataSetTableAdapter
    Public Shared Function GetIDbyStreet(ByVal Straße As String, PLZ As Long, Ort As String)
        Try
            Dim StraßenDataTable As New StraßenDataSetTableAdapters.StraßenTableAdapter
            Dim ID As Long = StraßenDataTable.GetID(Straße, PLZ, Ort)
            Return ID
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' deletes a street by ID, zip-code and city-name from the datatable using an DataSetTableAdapter
    Public Shared Function Delete(ByVal ID As Long, PLZ As Long, Ort As String)
        Try
            Dim StraßeDataTable As New StraßenDataSetTableAdapters.StraßenTableAdapter
            StraßeDataTable.DeleteQuery(ID, PLZ, Ort)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    ' gets the number of streets in a specific city with a specific zip-code in the datatable using an DataSetTableAdapter
    Public Shared Function getCount(ByVal Ort As String, PLZ As Long)
        Dim TableAdapter As New StraßenDataSetTableAdapters.StraßenTableAdapter
        Return TableAdapter.GetCount(Ort, PLZ)
        Return 0
    End Function

    ' gets the number of streets in the datatable using an DataSetTableAdapter
    Public Shared Function CountAll()
        Dim TableAdapter As New StraßenDataSetTableAdapters.StraßenTableAdapter
        Return TableAdapter.CountAll()
        Return 0
    End Function

    ' retrieves ID by city-name and zip-code from the datatable using an DataSetTableAdapter for more information have a look at Orte -> GetCount
    Public Shared Function getID(ByVal Ort As String, plz As Long, row As Long)
        Dim SQLCon As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\AVSIB_Data.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim DAdapter As New SqlDataAdapter
        Dim DataS As New DataSet
        SQLCon.Open()
        Try
            cmd = New SqlCommand("SELECT Id FROM Straßen Where Ort=@ort AND PLZ=@plz ORDER BY Straße;", SQLCon)
            cmd.Parameters.Add("@ort", SqlDbType.NChar).Value = Ort
            cmd.Parameters.Add("@plz", SqlDbType.NChar).Value = plz
            DAdapter = New SqlDataAdapter(cmd)
            DAdapter.Fill(DataS, "Straßen")
            SQLCon.Close()
            Return DataS.Tables(0).Rows(row).Item(0)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

End Class
