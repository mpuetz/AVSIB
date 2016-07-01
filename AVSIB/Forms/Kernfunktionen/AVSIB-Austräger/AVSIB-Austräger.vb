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

Public Class AVSIB_Austräger
    Dim Count As Long
    Dim Nachname As String
    Dim Vorname As String
    Dim Bezirk As Long

    Private Sub AVSIB_Austräger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Count = Austräger.GetCount()
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
            CBBezirk.SelectedIndex = "0"
        Else
            MsgBox("Noch keine Austräger eingetragen", MsgBoxStyle.Information, "Keine Daten")
            CBBezirk.Enabled = False
            TBNachname.Enabled = False
            TBVorname.Enabled = False
        End If
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Me.Close()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Count = Count + 1
        TBNachname.Text = Nothing
        TBNachname.Text = Nothing
        If CBBezirk.Enabled = False Then
            CBBezirk.Enabled = True
            TBNachname.Enabled = True
            TBVorname.Enabled = True
        End If
        Austräger.InsertNULL(Count)
        CBBezirk.Items.Clear()
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
        CBBezirk.SelectedIndex = Count - 1
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If CBBezirk.SelectedItem <> Nothing And TBNachname.Text <> Nothing And TBVorname.Text <> Nothing Then
            Austräger.Update(CBBezirk.SelectedItem.ToString, TBNachname.Text, TBVorname.Text)
            TBNachname.Text = Nothing
            TBVorname.Text = Nothing
            CBBezirk.SelectedItem = Nothing
            CBBezirk.Items.Clear()
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
            MsgBox("Bitte Wählen Sie eine Bezirk-Nr. aus!", MsgBoxStyle.Critical, "Fehler")
        ElseIf TBNachname.Text = Nothing Then
            MsgBox("Bitte geben Sie einen Nachnamen ein!", MsgBoxStyle.Critical, "Fehler")
        Else
            MsgBox("Bitte geben Sie einen Nachnamen ein!", MsgBoxStyle.Critical, "Fehler!")
        End If
    End Sub

    Private Sub CBBezirk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBezirk.SelectedIndexChanged
        If CBBezirk.SelectedItem <> Nothing Then
            TBNachname.Text = Austräger.GetNameByBezirk(CBBezirk.SelectedItem.ToString)
            TBVorname.Text = Austräger.GetVornameByBezirk(CBBezirk.SelectedItem.ToString)
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Bezirk = ListView1.FocusedItem.Text
        Austräger.Delete(Bezirk)
        CBBezirk.Items.Clear()
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
        CBBezirk.SelectedIndex = Count - 1
    End Sub

    Private Sub AVSIB_Austräger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub SKeyDown(sender As Object, e As KeyEventArgs) Handles TBNachname.KeyDown, TBVorname.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonSave.PerformClick()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            Bezirk = ListView1.FocusedItem.Text
        Catch ex As Exception
        End Try
        CBBezirk.SelectedIndex = Bezirk - 1
    End Sub
End Class