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
Imports System.Resources

Public Class AVSIB_PersonInsert
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(AVSIB_PersonInsert).Assembly)
    Dim count As Integer = Personen.GetCount
    Dim ortCount As Integer
    Public PersCheck As Boolean

    Private Sub AVSIB_Person_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populates the ComboBox for the places
        ortCount = Orte.GetCount
        For iOrt As Integer = 0 To ortCount - 1
            Dim Ort As String = Orte.GetOrtabc(iOrt)
            OrtAuswahl.Items.Add(Ort)
        Next
    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        ' Checks if all necessary informations are provided by the user and then adds the new person to the database. After that, the boxes form is resetted.
        If Nachname.Text <> Nothing And Vorname.Text <> Nothing And HausNr.Text <> Nothing Then
            Personen.Insert(Nachname.Text, Vorname.Text, CBStraße.SelectedItem.ToString, HausNr.Text, Zusatz.Text, PLZAuswahl.SelectedItem, OrtAuswahl.SelectedItem.ToString)
            Nachname.Text = Nothing
            Vorname.Text = Nothing
            HausNr.Text = Nothing
            Zusatz.Text = Nothing
            PLZAuswahl.SelectedItem = Nothing
            OrtAuswahl.SelectedItem = Nothing
            CBStraße.SelectedItem = Nothing
            PLZAuswahl.Enabled = False
            CBStraße.Enabled = False
            LabelErfolg.Visible = True
            count = count + 1
            Vorname.Focus()
        Else
            MsgBox(LocRM.GetString("strFieldsMissing"), MsgBoxStyle.Exclamation, LocRM.GetString("titCaution"))
        End If
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        AVSIB_PersonCheck.Show()
        Me.Close()
    End Sub

    Private Sub Vorname_TextChanged(sender As Object, e As EventArgs) Handles Vorname.TextChanged
        LabelErfolg.Visible = False
    End Sub

    Private Sub OrtAuswahl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrtAuswahl.SelectedIndexChanged
        ' When the user selects a place, the ComboBox for the zip-codes gets populated and enabled.
        If OrtAuswahl.SelectedItem <> Nothing Then
            PLZAuswahl.Enabled = True
            PLZAuswahl.Items.Clear()
            Dim PLZCount As Long = Orte.GetPLZCount(OrtAuswahl.SelectedItem.ToString)
            For iPLZ As Long = 0 To PLZCount - 1
                PLZAuswahl.Items.Add(Orte.GetPLZabc(iPLZ, OrtAuswahl.SelectedItem.ToString))
            Next
            If PLZCount = "1" Then
                PLZAuswahl.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub PLZAuswahl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PLZAuswahl.SelectedIndexChanged
        ' When the zip-code is selected, the ComboBox for the street is populated with the data from the database and the box gets
        'enabled.
        If PLZAuswahl.SelectedItem <> Nothing Then
            CBStraße.Enabled = True
            CBStraße.Items.Clear()
            Dim StraßeCount As Long = Straße.getCount(OrtAuswahl.SelectedItem.ToString, PLZAuswahl.SelectedItem.ToString)
            Dim StraßeID As Long
            For i As Long = 0 To StraßeCount - 1
                StraßeID = Straße.getID(OrtAuswahl.SelectedItem.ToString, PLZAuswahl.SelectedItem.ToString, i)
                CBStraße.Items.Add(Straße.GetStraßebyID(StraßeID))
            Next
            If StraßeCount = "1" Then
                CBStraße.SelectedIndex = "0"
            End If
        End If
    End Sub

    Private Sub AVSIB_PersonInsert_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub SKeyDown(sender As Object, e As KeyEventArgs) Handles Vorname.KeyDown, Zusatz.KeyDown, Nachname.KeyDown, HausNr.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonInsert.PerformClick()
        End If
    End Sub
End Class