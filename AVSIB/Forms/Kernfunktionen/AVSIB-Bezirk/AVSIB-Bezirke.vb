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
Public Class AVSIB_Bezirke
    ' This form is used to combine the places and streets with the district numbers.
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(AVSIB_Bezirke).Assembly)
    Dim Straßen As String
    Dim Ort As String
    Dim PLZ As Integer
    Dim countort As Long
    Dim countstraße As Long
    Dim countBez As Long
    Dim BezAnz As Long
    Dim BezirkNr As Long

    Private Sub AVSIB_Bezirke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' At first it asks for the count of districts. After that it asks for the number of streets added to the 
        ' districts. Then it gets the streets, places and zip-codes and adds them to the ListView.
        ' Last, the places get added to the ComboBox CBOrt.
        BezAnz = Austräger.GetCount
        For i1 As Long = 1 To BezAnz
            BezirkNr = i1
            countBez = Bezirke.GetCount(BezirkNr)
            For i As Long = 0 To countBez - 1
                Straßen = Bezirke.GetStraßenByBezirk(BezirkNr, i)
                Ort = Bezirke.GetOrtByBezirk(BezirkNr, i)
                PLZ = Bezirke.GetPLZByBezirk(BezirkNr, i)
                Dim lvi As New ListViewItem
                lvi.Text = BezirkNr
                lvi.SubItems.Add(Straßen)
                lvi.SubItems.Add(PLZ)
                lvi.SubItems.Add(Ort)
                ListView1.Items.Add(lvi)
            Next
            CBBezirk.Items.Add(i1)
        Next
        countort = Orte.GetCount
        For i As Long = 0 To countort - 1
            CBOrt.Items.Add(Orte.GetOrtabc(i))
        Next
    End Sub

    Private Sub CBOrt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOrt.SelectedIndexChanged
        ' If a place is selected, the count of zip-codes assigned to the selected place will be read.
        ' After that, the zip-codes are added to the ComboBox CBPLZ.
        If CBOrt.SelectedItem <> Nothing Then
            countort = Orte.GetPLZCount(CBOrt.SelectedItem.ToString)
            CBPLZ.Enabled = True
            CBPLZ.Items.Clear()
            CBStraße.Items.Clear()
            For i As Long = 0 To countort - 1
                CBPLZ.Items.Add(Orte.GetPLZabc(i, CBOrt.SelectedItem.ToString))
            Next
            If countort = "1" Then
                CBPLZ.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub CBPLZ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPLZ.SelectedIndexChanged
        ' If a zip code is selected, it gets the number of streets assigned to the selected 
        ' place and zip-code and adds them to the ComboBox CBStraße.
        If CBPLZ.SelectedItem <> Nothing Then
            countstraße = Straße.getCount(CBOrt.SelectedItem.ToString, CBPLZ.SelectedItem.ToString)
            Dim ID As Long
            CBStraße.Enabled = True
            CBStraße.Items.Clear()
            For i As Long = 0 To countstraße - 1
                ID = Straße.getID(CBOrt.SelectedItem.ToString, CBPLZ.SelectedItem.ToString, i)
                CBStraße.Items.Add(Straße.GetStraßebyID(ID))
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' If Button1 (save) is clicked, it checks whether all required informations are selected.
        ' If they are, the informations get inserted into the database and the listView gets refreshed.
        If CBBezirk.SelectedItem <> Nothing And CBOrt.SelectedItem <> Nothing And CBPLZ.SelectedItem <> Nothing And CBStraße.SelectedItem <> Nothing Then
            Straßen = CBStraße.SelectedItem.ToString
            Ort = CBOrt.SelectedItem.ToString
            PLZ = CBPLZ.SelectedItem.ToString
            Dim strID As Long = Straße.GetIDbyStreet(Straßen, PLZ, Ort)
            If CBBezirk.SelectedItem.ToString <> Bezirke.GetIDByStraße(strID) And Bezirke.GetIDByStraße(strID) Then
                BezirkNr = CBBezirk.SelectedItem.ToString
                Bezirke.Update(strID, BezirkNr)
                Log.WriteLog(AVSIB_Main.user, AVSIB_Main.user & " added " & Straßen & " in " & PLZ & " " & Ort & " to district " & BezirkNr)
            Else
                Bezirke.Insert(strID, CBBezirk.SelectedItem.ToString)
                Log.WriteLog(AVSIB_Main.user, AVSIB_Main.user & " added " & Straßen & " in " & PLZ & " " & Ort & " to district " & BezirkNr)
            End If
            CBBezirk.Items.Clear()
            CBOrt.Items.Clear()
            CBPLZ.Items.Clear()
            CBStraße.Items.Clear()
            ListView1.Items.Clear()
            CBPLZ.Enabled = False
            CBStraße.Enabled = False
            For i1 As Long = 1 To BezAnz
                BezirkNr = i1
                countBez = Bezirke.GetCount(BezirkNr)
                For i As Long = 0 To countBez - 1
                    Straßen = Bezirke.GetStraßenByBezirk(BezirkNr, i)
                    Ort = Bezirke.GetOrtByBezirk(BezirkNr, i)
                    PLZ = Bezirke.GetPLZByBezirk(BezirkNr, i)
                    Dim lvi As New ListViewItem
                    lvi.Text = BezirkNr
                    lvi.SubItems.Add(Straßen)
                    lvi.SubItems.Add(PLZ)
                    lvi.SubItems.Add(Ort)
                    ListView1.Items.Add(lvi)
                Next
                CBBezirk.Items.Add(i1)
            Next
            countort = Orte.GetCount
            For i As Long = 0 To countort - 1
                CBOrt.Items.Add(Orte.GetOrtabc(i))
            Next
            CBBezirk.Focus()
        ElseIf CBBezirk.SelectedItem = Nothing Then
            MsgBox(LocRM.GetString("strNoDistrictNo"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
            CBBezirk.Focus()
        ElseIf CBOrt.SelectedItem = Nothing Then
            MsgBox(LocRM.GetString("strNoCitySelected"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
            CBOrt.Focus()
        ElseIf CBPLZ.SelectedItem = Nothing Then
            MsgBox(LocRM.GetString("strNoZIPSelected"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
            CBPLZ.Focus()
        ElseIf CBStraße.SelectedItem = Nothing Then
            MsgBox(LocRM.GetString("strNoStreetSelected"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
            CBStraße.Focus()
        End If
    End Sub

    Private Sub CBBezirk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBezirk.SelectedIndexChanged
        ' If another district gets selected,the ListView gets refreshed to show only the data
        ' for the selected district.
        ListView1.Items.Clear()
        BezirkNr = CBBezirk.SelectedItem.ToString
        countBez = Bezirke.GetCount(BezirkNr)
        For i As Long = 0 To countBez - 1
            Straßen = Bezirke.GetStraßenByBezirk(BezirkNr, i)
            Ort = Bezirke.GetOrtByBezirk(BezirkNr, i)
            PLZ = Bezirke.GetPLZByBezirk(BezirkNr, i)
            Dim lvi As New ListViewItem
            lvi.Text = BezirkNr
            lvi.SubItems.Add(Straßen)
            lvi.SubItems.Add(PLZ)
            lvi.SubItems.Add(Ort)
            ListView1.Items.Add(lvi)
        Next
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Me.Close()
    End Sub

    Private Sub AVSIB_Bezirke_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub SKeyDown(sender As Object, e As KeyEventArgs) Handles CBStraße.KeyDown
        ' If the enter key is pressed while at the combobox CBStraße, a click on Button1 (save) is performed
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

End Class