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

Public Class AVSIB_Straße
    'This form is used to add another street to the database.
    Dim ortcount As Long
    Dim ortselected As String
    Dim plzselected As Integer
    Dim straßencount As Long
    Dim ID As Long
    Dim nochange As Boolean = False

    Private Sub AVSIB_Straße_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the form loads, the ComboBox for the places will be populated with data from the database. If there are no places added yet,
        ' a message box will be shown.
        ortcount = Orte.GetCount
        If ortcount <> 0 Then
            For i As Long = 0 To ortcount - 1
                CBOrt.Items.Add(Orte.GetOrtabc(i))
            Next
        Else
            MsgBox("Keine Orte gefunden! Bitte fügen Sie zunächst einen Ort über 'Menü' -> 'Orte' hinzu!", MsgBoxStyle.Critical, "Fehler!")
            AVSIB_Main.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CBOrt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOrt.SelectedIndexChanged
        ' When the user selects a place, the ComboBox for the zip-code will be populated with data from the zip-codes corresponding to the
        ' selected place.
        If CBOrt.SelectedItem <> Nothing Then
            CBPLZ.Enabled = True
            CBPLZ.Items.Clear()
            ortselected = CBOrt.SelectedItem.ToString
            Dim plzcount As Long = Orte.GetPLZCount(ortselected)
            For i As Long = 0 To plzcount - 1
                CBPLZ.Items.Add(Orte.GetPLZabc(i, ortselected))
            Next
            If plzcount = "1" Then
                nochange = True
                CBPLZ.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub CBPLZ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPLZ.SelectedIndexChanged
        ' When the user selects a zip-code, the streets in the database matching zip-code and place are listed in the ListBox.
        ' The textbox for adding a new street gets enabled.
        If CBPLZ.SelectedItem.ToString <> Nothing Then
            plzselected = CBPLZ.SelectedItem.ToString
            ListBox1.Enabled = True
            ListBox1.Items.Clear()
            TextBox1.Enabled = True
            straßencount = Straße.getCount(ortselected, plzselected)
            If straßencount <> 0 Then
                For i As Long = 0 To straßencount - 1
                    ID = Straße.getID(ortselected, plzselected, i)
                    ListBox1.Items.Add(Straße.GetStraßebyID(ID))
                Next
            End If
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' When the user clicks on delete, the function checks if a street is selected in the ListBox. If so, the street and all persons 
        ' living in this street will be deleted and the list will be refreshed.
        If ListBox1.SelectedItem = Nothing Then
            MsgBox("Keine Straße zum löschen ausgewählt!", MsgBoxStyle.Critical)
        Else
            ID = Straße.GetIDbyStreet(ListBox1.SelectedItem.ToString, plzselected, ortselected)
            Bezirke.DeleteStraßeByID(ID)
            Straße.Delete(ID, plzselected, ortselected)
            Dim perscount As Long
            Dim PersID As Long
            perscount = Personen.GetCountByKnown(ListBox1.SelectedItem.ToString, ortselected, plzselected)
            For i2 As Long = 0 To perscount - 1
                PersID = Personen.GetIDByKnown(0, ListBox1.SelectedItem.ToString, ortselected, plzselected)
                Personen.Delete(PersID)
            Next
            ListBox1.Items.Clear()
            straßencount = Straße.getCount(ortselected, plzselected)
            If straßencount <> 0 Then
                For i As Long = 0 To straßencount - 1
                    ID = Straße.getID(ortselected, plzselected, i)
                    ListBox1.Items.Add(Straße.GetStraßebyID(ID))
                Next
            End If
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ' When the user clicks on the Add-Button and the TextBox is not empty, the new street will be added.
        If TextBox1.Text <> Nothing Then
            Straße.Insert(TextBox1.Text, plzselected, ortselected)
            TextBox1.Text = Nothing
            ListBox1.Items.Clear()
            straßencount = Straße.getCount(ortselected, plzselected)
            If straßencount <> 0 Then
                For i As Long = 0 To straßencount - 1
                    ID = Straße.getID(ortselected, plzselected, i)
                    ListBox1.Items.Add(Straße.GetStraßebyID(ID))
                Next
            End If
        Else
            MsgBox("Es scheint als wäre keine Straße zum hinzufügen eingetragen.", MsgBoxStyle.Critical, "Kein Straßennamen eingetragen")
        End If
    End Sub

    Private Sub AVSIB_Straße_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub SKeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonAdd.PerformClick()
        End If
    End Sub
End Class