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

Imports System.Resources
Public Class Statistik
    ' Adds the possibility to see some statistic about the databases.
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(Statistik).Assembly)
    Private Sub Statistik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = LocRM.GetString("strCitiesInDatabase") & Orte.GetCount
        Label2.Text = LocRM.GetString("strStreetsInDatabase") & Straße.CountAll
        Label3.Text = LocRM.GetString("strAddresseesInDatabase") & Personen.GetCount
        Label4.Text = LocRM.GetString("strThereAre") & Austräger.GetCount & LocRM.GetString("strDistrictsInDatabase")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class