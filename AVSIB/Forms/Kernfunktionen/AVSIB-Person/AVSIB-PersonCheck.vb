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
Imports System.Data.SqlClient

Public Class AVSIB_PersonCheck
    ' This form is used to make the user able to check already added persons.
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(AVSIB_PersonCheck).Assembly)
    Dim count As Long = Personen.GetCount
    Dim PersonenCount As Long = 0
    Dim ID As Long
    Dim nochange As Boolean = True
    Dim waittime As Long
    Dim waitenabled As Boolean
    Public filtered As Boolean = False
    Public filterby As String
    Public SelectedOrder As String = "Nachname, Vorname, Straße, Hausnummer, Zusatz"
    Public sortchanged As Boolean = False

    Private Function UpdateText(ByVal ID2 As Long)
        ' This function is used to update the text with the data of the persons. The function needs the ID of the person.
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
        ' On load the form checks if there are persons in the database and how much. After that the form gets filled with the data of the first person
        ' or alternatively a messagebox will be shown.
        BindingNavigatorCountItem.Text = LocRM.GetString("strOF") & " " & count
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
            MsgBox(LocRM.GetString("strNoData"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
            BindingNavigatorMoveLastItem.Enabled = False
            TSBNext.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
        End If
        waitenabled = True
        threeSecButton.Checked = True
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click, BindingNavigatorDeleteItem.Click
        ' This function deletes the person from the database and updates the form.
        If filtered = False Then
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
                MsgBox(LocRM.GetString("strEndDatabase"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
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
                MsgBox(LocRM.GetString("strNoData"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                BindingNavigatorMoveFirstItem.Enabled = False
                TSBBack.Enabled = False
                BindingNavigatorMoveLastItem.Enabled = False
                TSBNext.Enabled = False
            End If
            BindingNavigatorCountItem.Text = LocRM.GetString("strOF") & " " & count
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
        ElseIf filtered = True Then
            ID = Personen.GetIDByString(PersonenCount, filterby, SelectedOrder)
            Personen.Delete(ID)
            count = count - 1
            If PersonenCount + 1 <= count Then
                ID = Personen.GetIDByString(PersonenCount, filterby, SelectedOrder)
                UpdateText(ID)
            ElseIf PersonenCount + 1 > count And PersonenCount <> 0 Then
                PersonenCount = PersonenCount - 1
                ID = Personen.GetIDByString(PersonenCount, filterby, SelectedOrder)
                UpdateText(ID)
                BindingNavigatorPositionItem.TextBox.Text = PersonenCount + 1
            ElseIf PersonenCount = 0 And count = 1 Then
                ID = Personen.GetIDByString(PersonenCount, filterby, SelectedOrder)
                UpdateText(ID)
                MsgBox(LocRM.GetString("strEndDatabase"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
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
                MsgBox(LocRM.GetString("strNoData"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                BindingNavigatorMoveFirstItem.Enabled = False
                TSBBack.Enabled = False
                BindingNavigatorMoveLastItem.Enabled = False
                TSBNext.Enabled = False
            End If
            BindingNavigatorCountItem.Text = LocRM.GetString("strOF") & " " & count
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
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click, TSBNext.Click
        ' This person checks  if there are more persons in the database. If there are, the form will be updated with the data 
        ' else, a messagebox is shown.
        If filtered = False Then
            If PersonenCount + 1 < count Then
                PersonenCount = PersonenCount + 1
                ID = Personen.GetID(PersonenCount, SelectedOrder)
                UpdateText(ID)
                BindingNavigatorPositionItem.TextBox.Text = PersonenCount + 1
                BindingNavigatorMoveFirstItem.Enabled = True
                TSBBack.Enabled = True
            Else
                MsgBox(LocRM.GetString("strEndDatabase"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                BindingNavigatorMoveLastItem.Enabled = False
                TSBNext.Enabled = False
                BindingNavigatorMoveFirstItem.Enabled = True
                TSBBack.Enabled = True
                PauseButton.Checked = True
            End If
        ElseIf filtered = True Then

        End If
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        End If

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click, TSBBack.Click
        'updates the form with the data from the previous person. If there are no more previous persons, a messagebox is shown.
        If filtered = False Then
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
        ElseIf filtered = True Then

        End If
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        End If
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        ' Same as ButtonBack.Click
        If filtered = False Then
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
                MsgBox(LocRM.GetString("strNoData"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                BindingNavigatorMoveLastItem.Enabled = False
                TSBNext.Enabled = False
            End If
        ElseIf filtered = True Then

        End If
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        End If
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        ' Updates the form with the data of the first person in the database or shows a messagebox
        If filtered = False Then
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
                MsgBox(LocRM.GetString("strNoData"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                BindingNavigatorMoveFirstItem.Enabled = False
                TSBBack.Enabled = False
            End If
        ElseIf filtered = True Then

        End If
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        End If
    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        ' Updates the form with the data from the person at the position entered by the user
        If nochange = False Then
            If filtered = False Then

                If count <> 0 And BindingNavigatorPositionItem.TextBox.Text < count - 1 Then
                    Dim BNPI As Long = BindingNavigatorPositionItem.TextBox.Text
                    PersonenCount = BNPI - 1
                    ID = Personen.GetID(PersonenCount, SelectedOrder)
                    UpdateText(ID)
                End If

            ElseIf filtered = True Then

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
        ' Shows the form PersonInsert for adding new persons.
        AVSIB_PersonInsert.ShowDialog()
        Inserted_Persons()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ' Shows the form PersonSort, which makes it possible to change the sorting of the persons.
        AVSIB_PersonSort.Show()
        Me.Hide()
    End Sub

    Private Sub AVSIB_PersonCheck_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If sortchanged = True Then
            If filtered = False Then
                If count <> 0 Then
                    PersonenCount = 0
                    ID = Personen.GetID(PersonenCount, SelectedOrder)
                    UpdateText(ID)
                    sortchanged = False
                    BindingNavigatorPositionItem.Text = 1
                    ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
                Else
                    BindingNavigatorPositionItem.Text = 0
                    MsgBox(LocRM.GetString("strNoData"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                End If
            ElseIf filtered = True Then

            End If
        End If
    End Sub

    Private Function Inserted_Persons()
        If filtered = False Then
            count = Personen.GetCount
            PersonenCount = 0
            BindingNavigatorCountItem.Text = LocRM.GetString("strOF") & " " & count
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
                MsgBox(LocRM.GetString("strNoData"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
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
        ElseIf filtered = True Then

        End If
        Return 0
    End Function

    Private Sub oneSecButton_Click(sender As Object, e As EventArgs) Handles oneSecButton.CheckStateChanged
        waittime = 1000
        Timer1.Interval = waittime
        If oneSecButton.Checked = True Then
            threeSecButton.Checked = False
            fiveSecButton.Checked = False
            tenSecButton.Checked = False
            udSecButton.Checked = False
            Timer1.Start()
        End If
    End Sub

    Private Sub threeSecButton_Click(sender As Object, e As EventArgs) Handles threeSecButton.CheckStateChanged
        waittime = 3000
        Timer1.Interval = waittime
        If threeSecButton.Checked = True And waitenabled = False Then
            oneSecButton.Checked = False
            fiveSecButton.Checked = False
            tenSecButton.Checked = False
            udSecButton.Checked = False
            Timer1.Start()
        Else
            waitenabled = False
        End If
    End Sub

    Private Sub fiveSecButton_Click(sender As Object, e As EventArgs) Handles fiveSecButton.CheckStateChanged
        waittime = 5000
        Timer1.Interval = waittime
        If fiveSecButton.Checked = True Then
            threeSecButton.Checked = False
            oneSecButton.Checked = False
            tenSecButton.Checked = False
            udSecButton.Checked = False
            Timer1.Start()
        End If
    End Sub

    Private Sub tenSecButton_Click(sender As Object, e As EventArgs) Handles tenSecButton.CheckStateChanged
        waittime = 10000
        Timer1.Interval = waittime
        If tenSecButton.Checked = True Then
            threeSecButton.Checked = False
            fiveSecButton.Checked = False
            oneSecButton.Checked = False
            udSecButton.Checked = False
            Timer1.Start()
        End If
    End Sub

    Private Sub udSecButton_Click(sender As Object, e As EventArgs) Handles udSecButton.CheckStateChanged
        waittime = InputBox(LocRM.GetString("strWaitInput"), LocRM.GetString("titInformation")).ToString * 1000
        Timer1.Interval = waittime
        If udSecButton.Checked = True Then
            threeSecButton.Checked = False
            fiveSecButton.Checked = False
            tenSecButton.Checked = False
            oneSecButton.Checked = False
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' This person checks  if there are more persons in the database. If there are, the form will be updated with the data 
        ' else, a messagebox is shown.
        If filtered = False Then
            If PersonenCount + 1 < count Then
                PersonenCount = PersonenCount + 1
                ID = Personen.GetID(PersonenCount, SelectedOrder)
                UpdateText(ID)
                BindingNavigatorPositionItem.TextBox.Text = PersonenCount + 1
                BindingNavigatorMoveFirstItem.Enabled = True
                TSBBack.Enabled = True
            Else
                PauseButton.Checked = True
                MsgBox(LocRM.GetString("strEndDatabase"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                BindingNavigatorMoveLastItem.Enabled = False
                TSBNext.Enabled = False
                BindingNavigatorMoveFirstItem.Enabled = True
                TSBBack.Enabled = True
            End If
            If count <> 0 Then
                ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
            End If
        ElseIf filtered = True Then

        End If
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.CheckStateChanged
        If PauseButton.Checked = True Then
            Timer1.Stop()
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Filter_Click(sender As Object, e As EventArgs) Handles Filter.Click
        AVSIB_PersonFilter.ShowDialog()
        If filtered = True Then
            BStopFilter.Enabled = True
        End If
    End Sub

    Private Sub BStopFilter_Click(sender As Object, e As EventArgs) Handles BStopFilter.Click
        filtered = False
        BStopFilter.Enabled = False
        filterby = ""
        ' Updates the form with the data of the first person in the database or shows a messagebox
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
            MsgBox(LocRM.GetString("strNoData"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
            BindingNavigatorMoveFirstItem.Enabled = False
            TSBBack.Enabled = False
        End If
        If count <> 0 Then
            ToolStripProgressBar1.Value = (PersonenCount + 1) / count * 100
        End If
    End Sub
End Class