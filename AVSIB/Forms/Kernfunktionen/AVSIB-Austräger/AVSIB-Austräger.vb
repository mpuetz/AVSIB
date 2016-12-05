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

Public Class AVSIB_Austräger
    ' This form provides the possibility to add roundsmen. They get assigned to district numbers.
    Dim Count As Long
    Dim Nachname As String
    Dim Vorname As String
    Dim Bezirk As Long
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(AVSIB_Austräger).Assembly)

    Private Sub AVSIB_Austräger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the form loads it asks for the number of roundsmen in the database and lists them
        ' in the listView and the combobox, in which the Item "New" gets listed in the first position.
        ' If there are no roundsmen added, yet, the Textboxes get disable and a messagebox will be shown.
        Count = Austräger.GetCount()
        CBBezirk.Items.Add("Neu")
        If Count <> 0 Then
            For i As Long = 1 To Count
                Nachname = Austräger.GetNameByBezirk(i)
                Vorname = Austräger.GetVornameByBezirk(i)
                CBBezirk.Items.Add(i)
                Dim lvi As New ListViewItem
                lvi.Text = i
                lvi.SubItems.Add(Vorname)
                lvi.SubItems.Add(Nachname)
                ListView1.Items.Add(lvi)
            Next
            CBBezirk.SelectedIndex = "1"
        Else
            MsgBox(LocRM.GetString("strRoundsmenMissing"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
            TBNachname.Enabled = False
            TBVorname.Enabled = False
        End If
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Me.Close()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        ' Checks whether the TextBoxes are filled. If they are and a district number is selected it stores the Name 
        ' of the roundsmen and reloads the list. Else a msgBox is shown.
        If CBBezirk.SelectedItem <> Nothing And CBBezirk.SelectedIndex.ToString IsNot "0" And TBNachname.Text <> Nothing _
            And TBVorname.Text <> Nothing Then
            Austräger.Update(CBBezirk.SelectedItem.ToString, TBNachname.Text, TBVorname.Text)
            TBNachname.Text = Nothing
            TBVorname.Text = Nothing
            CBBezirk.SelectedItem = Nothing
            CBBezirk.Items.Clear()
            CBBezirk.Items.Add("Neu")
            ListView1.Items.Clear()
            For i As Long = 1 To Count
                Nachname = Austräger.GetNameByBezirk(i)
                Vorname = Austräger.GetVornameByBezirk(i)
                CBBezirk.Items.Add(i)
                Dim lvi As New ListViewItem
                lvi.Text = i
                lvi.SubItems.Add(Vorname)
                lvi.SubItems.Add(Nachname)
                ListView1.Items.Add(lvi)
            Next
        ElseIf CBBezirk.SelectedItem = Nothing Then
            MsgBox(LocRM.GetString("strNoDistrictNo"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        ElseIf TBNachname.Text = Nothing Then
            MsgBox(LocRM.GetString("strNoLastName"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        ElseIf TBVorname.Text = Nothing Then
            MsgBox(LocRM.GetString("strNoSurname"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        ElseIf CBBezirk.SelectedIndex = "0" Or CBBezirk.SelectedIndex = "-1" Then
            MsgBox(LocRM.GetString("strNoDistrictNo"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        Else
            MsgBox(LocRM.GetString("strNoLastName"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        End If
    End Sub

    Private Sub CBBezirk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBezirk.SelectedIndexChanged
        ' When the selected item is "New" a new district-number will be added. Else the Textboxes get filled 
        ' with the stored name and surname of the roundsmen.
        If CBBezirk.SelectedIndex = "0" Then
            Count = Count + 1
            TBNachname.Text = Nothing
            TBNachname.Text = Nothing
            If TBNachname.Enabled = False Then
                TBNachname.Enabled = True
                TBVorname.Enabled = True
            End If
            Austräger.InsertNULL(Count)
            CBBezirk.Items.Clear()
            ListView1.Items.Clear()
            CBBezirk.Items.Add(LocRM.GetString("strNew"))
            For i As Long = 1 To Count
                Nachname = Austräger.GetNameByBezirk(i)
                Vorname = Austräger.GetVornameByBezirk(i)
                CBBezirk.Items.Add(i)
                Dim lvi As New ListViewItem
                lvi.Text = i
                lvi.SubItems.Add(Vorname)
                lvi.SubItems.Add(Nachname)
                ListView1.Items.Add(lvi)
            Next
            CBBezirk.SelectedIndex = Count
        Else
            If CBBezirk.SelectedItem <> Nothing Then
                TBNachname.Text = Austräger.GetNameByBezirk(CBBezirk.SelectedItem.ToString)
                TBVorname.Text = Austräger.GetVornameByBezirk(CBBezirk.SelectedItem.ToString)
            End If
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' If the selected Item is not "New" the name and surname of the roundsmen of the selected
        ' district with NULL. That is because the district number acts as the ID in the database.
        ' after that the list gets updated.
        If CBBezirk.SelectedIndex = "0" Or CBBezirk.SelectedIndex = "-1" Then
            MsgBox(LocRM.GetString("strNoDistrictNo"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        Else
            Bezirk = ListView1.FocusedItem.Text
            Austräger.Delete(Bezirk)
            CBBezirk.Items.Clear()
            CBBezirk.Items.Add("Neu")
            ListView1.Items.Clear()
            For i As Long = 1 To Count
                Nachname = Austräger.GetNameByBezirk(i)
                Vorname = Austräger.GetVornameByBezirk(i)
                CBBezirk.Items.Add(i)
                Dim lvi As New ListViewItem
                lvi.Text = i
                lvi.SubItems.Add(Vorname)
                lvi.SubItems.Add(Nachname)
                ListView1.Items.Add(lvi)
            Next
            CBBezirk.SelectedIndex = Count
        End If
    End Sub

    Private Sub AVSIB_Austräger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub SKeyDown(sender As Object, e As KeyEventArgs) Handles TBNachname.KeyDown, TBVorname.KeyDown
        ' If in one of the TextBoxes Enter is pressed, a click on ButtonSave is triggered.
        If e.KeyCode = Keys.Enter Then
            ButtonSave.PerformClick()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ' If a new Item is selected in the listView the district gets selected in the ComboBox
        ' because of that the selectedIndexChanged-function gets triggered.
        Try
            Bezirk = ListView1.FocusedItem.Text
        Catch ex As Exception
        End Try
        CBBezirk.SelectedIndex = Bezirk
    End Sub
End Class