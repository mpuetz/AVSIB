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
Public Class AVSIB_Ort
    ' Within this Form the user is able to add or remove places in which the brochure shall be delivered
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(AVSIB_Ort).Assembly)
    Dim PLZ As Long
    Dim Ort As String
    Dim PLZOrt As String
    Dim OrteCount As Long
    Dim PLZCount As Long

    Private Sub TBPLZ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPLZ.KeyPress
        ' Only allows the user to use numbers in the PLZ-Textbox (zip-code)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        ' Closes the form, Main menu will be shown.
        Me.Close()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        ' Checks if the TextBoxes are filled, if not it shows a msgBox, else it inserts the place and zip-code
        ' in the database and reloads the list of places.
        If TBPLZ.Text <> Nothing And TBOrt.Text <> Nothing Then
            Orte.Insert(TBPLZ.Text, TBOrt.Text)
            TBPLZ.Text = Nothing
            TBOrt.Text = Nothing
            ListView1.Items.Clear()
            OrteCount = Orte.GetCount()
            For i As Long = 0 To OrteCount - 1
                Ort = Orte.GetOrtabc(i)
                PLZCount = Orte.GetPLZCount(Ort)
                For iplz As Long = 0 To PLZCount - 1
                    PLZ = Orte.GetPLZabc(iplz, Ort)
                    PLZOrt = PLZ & ", " & Ort
                    Dim lvi As New ListViewItem
                    lvi.Text = PLZ
                    lvi.SubItems.Add(Ort)
                    ListView1.Items.Add(lvi)
                Next
            Next
            TBOrt.Focus()
        ElseIf TBOrt.Text = Nothing Then
            MsgBox(LocRM.GetString("strInsertCity"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        Else
            MsgBox(LocRM.GetString("strInsertZIP"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        End If
    End Sub

    Private Sub AVSIB_Ort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get's the count of places from the sql-database
        OrteCount = Orte.GetCount()
        ' as long as i is smaller than the count of places in the places-database,
        ' the places will get listed sorted alphabetically
        For i As Long = 0 To OrteCount - 1
            Ort = Orte.GetOrtabc(i)
            PLZCount = Orte.GetPLZCount(Ort)
            For iplz As Long = 0 To PLZCount - 1
                PLZ = Orte.GetPLZabc(iplz, Ort)
                PLZOrt = PLZ & ", " & Ort
                Dim lvi As New ListViewItem
                lvi.Text = PLZ
                lvi.SubItems.Add(Ort)
                ListView1.Items.Add(lvi)
            Next
        Next
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' When the delete button is clicked, it is checked whether there are any places selected.
        ' If not a msgBox is displayed.
        If ListView1.SelectedItems.Count = 0 Then
            MsgBox(LocRM.GetString("strNothingSelectedDelete"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        Else
            ' If there are streets located in this place or persons living in one of these streets
            ' these streets or persons get deleted from all databases.
            PLZ = ListView1.FocusedItem.Text
            Ort = ListView1.FocusedItem.SubItems(1).Text
            Dim straßencount As Long = Straße.getCount(Ort, PLZ)
            If straßencount <> 0 Then
                Dim ID As Long
                For i As Long = 0 To straßencount - 1
                    ID = Straße.getID(Ort, PLZ, 0)
                    Dim street As String = Straße.GetStraßebyID(ID)
                    Straße.Delete(ID, PLZ, Ort)
                    Bezirke.DeleteStraßeByID(ID)
                    Dim perscount As Long
                    Dim PersID As Long
                    perscount = Personen.GetCountByKnown(street, Ort, PLZ)
                    For i2 As Long = 0 To perscount - 1
                        PersID = Personen.GetIDByKnown(0, street, Ort, PLZ)
                        Personen.Delete(PersID)
                    Next
                Next
            End If
            ' after the streets and persons got deleted the place itself gets deleted from the database.
            Orte.Remove(PLZ, Ort)
            ListView1.Items.Clear()
            OrteCount = Orte.GetCount()
            For i As Long = 0 To OrteCount - 1
                Ort = Orte.GetOrtabc(i)
                PLZCount = Orte.GetPLZCount(Ort)
                For iplz As Long = 0 To PLZCount - 1
                    PLZ = Orte.GetPLZabc(iplz, Ort)
                    PLZOrt = PLZ & ", " & Ort
                    Dim lvi As New ListViewItem
                    lvi.Text = PLZ
                    lvi.SubItems.Add(Ort)
                    ListView1.Items.Add(lvi)
                Next
            Next
        End If
    End Sub

    Private Sub AVSIB_Ort_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub SKeyDown(sender As Object, e As KeyEventArgs) Handles TBOrt.KeyDown, TBPLZ.KeyDown
        ' When enter is pressed in the textboxes a click on ButtonAdd will be triggered
        If e.KeyCode = Keys.Enter Then
            ButtonAdd.PerformClick()
        End If
    End Sub
End Class