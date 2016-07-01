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

Public Class AVSIB_PersonCheck
    Dim count As Long = Personen.GetCount
    Dim PersonenCount As Long = 0
    Dim ID As Long
    Dim nochange As Boolean = True
    Public SelectedOrder As String = "Nachname, Vorname, Straße, Hausnummer, Zusatz"
    Public sortchanged As Boolean = False

    Private Function UpdateText(ByVal ID2 As Long)
        Vorname.Text = Personen.GetVorname(ID2)
        Nachname.Text = Personen.GetNachname(ID2)
        Straße.Text = Personen.GetStraße(ID2)
        HausNr.Text = Personen.GetHausNr(ID2)
        Zusatz.Text = Personen.GetZusatz(ID2)
        PLZ.Text = Personen.GetPLZ(ID2)
        Ort.Text = Personen.GetOrt(ID2)
        Return 0
    End Function

    Private Sub AVSIB_Person_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingNavigatorCountItem.Text = "von " & count
        If count <> 0 Then
            ID = Personen.GetID(PersonenCount, SelectedOrder)
            UpdateText(ID)
            BindingNavigatorPositionItem.Text = 1
            nochange = False
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
        Else
            BindingNavigatorPositionItem.Text = 0
            MsgBox("Keine Daten in der Datenbank!", MsgBoxStyle.Information, "Keine Daten")
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click, BindingNavigatorDeleteItem.Click
        ID = Personen.GetID(PersonenCount, SelectedOrder)
        Personen.Delete(ID)
        count = count - 1
        If PersonenCount + 1 <= count Then
            ID = Personen.GetID(PersonenCount, SelectedOrder)
            UpdateText(ID)
        ElseIf PersonenCount + 1 > count And PersonenCount <> 0 Then
            PersonenCount = PersonenCount - 1
            ID = Personen.GetID(PersonenCount, SelectedOrder)
            UpdateText(ID)
            BindingNavigatorPositionItem.TextBox.Text = PersonenCount + 1
        ElseIf PersonenCount = 0 And count = 1 Then
            ID = Personen.GetID(PersonenCount, SelectedOrder)
            UpdateText(ID)
            MsgBox("Sie haben das Ende der Datenbank erreicht!", MsgBoxStyle.Information, "Ende der Datenbank")
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
        Else
            Vorname.Text = Nothing
            Nachname.Text = Nothing
            Straße.Text = Nothing
            HausNr.Text = Nothing
            Zusatz.Text = Nothing
            PLZ.Text = Nothing
            Ort.Text = Nothing
            MsgBox("Keine Datensätze in der Datenbank!", MsgBoxStyle.Information, "Leere Datenbank!")
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
        End If
        BindingNavigatorCountItem.Text = "von " & count
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        Else
            ToolStripProgressBar1.Value = 0
            BindingNavigatorDeleteItem.Enabled = False
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click, TSBNext.Click
        If PersonenCount + 1 < count Then
            PersonenCount = PersonenCount + 1
            ID = Personen.GetID(PersonenCount, SelectedOrder)
            UpdateText(ID)
            BindingNavigatorPositionItem.TextBox.Text = PersonenCount + 1
            BindingNavigatorMoveFirstItem.Enabled = True
            TSBBack.Enabled = True
        Else
            MsgBox("Sie sind am Ende der Datenbank angelangt!", MsgBoxStyle.Information, "Ende der Datenbank erreicht")
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
            BindingNavigatorMoveFirstItem.Enabled = True
            TSBBack.Enabled = True
        End If
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        End If

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click, TSBBack.Click
        If PersonenCount <> 0 Then
            PersonenCount = PersonenCount - 1
            ID = Personen.GetID(PersonenCount, SelectedOrder)
            UpdateText(ID)
            BindingNavigatorPositionItem.TextBox.Text = PersonenCount + 1
            BindingNavigatorMoveLastItem.Enabled = True
            TSBNext.Enabled = True
        Else
            BindingNavigatorMoveLastItem.Enabled = True
            TSBNext.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
        End If
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        End If
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        If count <> 0 Then
            PersonenCount = count - 1
            ID = Personen.GetID(PersonenCount, SelectedOrder)
            UpdateText(ID)
            BindingNavigatorPositionItem.TextBox.Text = PersonenCount + 1
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
            BindingNavigatorMoveFirstItem.Enabled = True
            TSBBack.Enabled = True
        Else
            MsgBox("Keine Daten in der Datenbank!", MsgBoxStyle.Information, "Keine Daten")
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
        End If
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        End If
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        If count <> 0 Then
            PersonenCount = 0
            ID = Personen.GetID(PersonenCount, SelectedOrder)
            UpdateText(ID)
            BindingNavigatorPositionItem.TextBox.Text = PersonenCount + 1
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
            BindingNavigatorMoveLastItem.Enabled = True
            TSBNext.Enabled = True
        Else
            MsgBox("Keine Daten in der Datenbank!", MsgBoxStyle.Information, "Keine Daten")
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
        End If
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        End If
    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        If nochange = False Then
            If count <> 0 And BindingNavigatorPositionItem.TextBox.Text < count - 1 Then
                Dim BNPI As Long = BindingNavigatorPositionItem.TextBox.Text
                PersonenCount = BNPI - 1
                ID = Personen.GetID(PersonenCount, SelectedOrder)
                UpdateText(ID)
            End If
        Else
        End If
    End Sub

    Private Sub BindingNavigatorPositionItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BindingNavigatorPositionItem.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub AVSIB_PersonCheck_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        nochange = True
        Me.Dispose()
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        AVSIB_PersonInsert.ShowDialog()
        Inserted_Persons()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        AVSIB_PersonSort.Show()
        Me.Hide()
    End Sub

    Private Sub AVSIB_PersonCheck_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If sortchanged = True Then
            If count <> 0 Then
                PersonenCount = 0
                ID = Personen.GetID(PersonenCount, SelectedOrder)
                UpdateText(ID)
                sortchanged = False
                BindingNavigatorPositionItem.Text = 1
                ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
            Else
                BindingNavigatorPositionItem.Text = 0
                MsgBox("Keine Daten in der Datenbank!", MsgBoxStyle.Information, "Keine Daten")
            End If
        End If
    End Sub

    Private Function Inserted_Persons()
        count = Personen.GetCount
        PersonenCount = 0
        BindingNavigatorCountItem.Text = "von " & count
        If count <> 0 Then
            ID = Personen.GetID(PersonenCount, SelectedOrder)
            UpdateText(ID)
            BindingNavigatorPositionItem.Text = 1
            nochange = False
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
            BindingNavigatorMoveLastItem.Enabled = True
            TSBNext.Enabled = True
            BindingNavigatorDeleteItem.Enabled = True
        Else
            BindingNavigatorPositionItem.Text = 0
            MsgBox("Keine Daten in der Datenbank!", MsgBoxStyle.Information, "Keine Daten")
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
        End If
        If count = 1 Then
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
        End If
        Return 0
    End Function
End Class