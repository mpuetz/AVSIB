Imports System.Resources
Public Class AVSIB_PersonFilter
    Dim count As Long
    Dim place As String
    Dim zip As Integer
    Dim street As String
    Dim firstn As String
    Dim lastn As String
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(AVSIB_PersonFilter).Assembly)

    Private Sub AVSIB_PersonFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        count = Orte.GetCount - 1
        For i As Long = 0 To count
            ComboBox1.Items.Add(Orte.GetOrtabc(i))
        Next
    End Sub

    Private Sub CBName_CheckStateChanged(sender As Object, e As EventArgs) Handles CBName.CheckStateChanged
        If CBName.Checked = True Then
            LLastName.Visible = True
            LFirstName.Visible = True
            LCity.Visible = False
            LZIP.Visible = False
            LStreet.Visible = False
            ComboBox1.Text = Nothing
            ComboBox1.Items.Clear()
            ComboBox2.Text = Nothing
            ComboBox2.Enabled = False
            ComboBox2.Items.Clear()
            ComboBox3.Visible = False
            ComboBox3.Text = Nothing
            ComboBox3.Items.Clear()
            CBAdress.Checked = False
            count = Personen.GetCount - 1
            Dim id As Long
            For i As Long = 0 To count
                id = Personen.GetID(i, "Nachname, Vorname, Straße, Hausnummer, Zusatz")
                ComboBox1.Items.Add(Personen.GetNachname(id))
            Next
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub CBAdress_CheckStateChanged(sender As Object, e As EventArgs) Handles CBAdress.CheckStateChanged
        If CBAdress.Checked = True Then
            LLastName.Visible = False
            LFirstName.Visible = False
            LCity.Visible = True
            LZIP.Visible = True
            LStreet.Visible = True
            ComboBox1.Text = Nothing
            ComboBox1.Items.Clear()
            ComboBox2.Text = Nothing
            ComboBox2.Enabled = False
            ComboBox2.Items.Clear()
            ComboBox3.Enabled = False
            ComboBox3.Visible = True
            ComboBox3.Items.Clear()
            CBName.Checked = False
            count = Orte.GetCount - 1
            For i As Long = 0 To count
                ComboBox1.Items.Add(Orte.GetOrtabc(i))
            Next
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub BFilter_Click(sender As Object, e As EventArgs) Handles BFilter.Click
        AVSIB_PersonCheck.filtered = True
        If CBAdress.CheckState = CheckState.Checked Then
            If ComboBox1.Text = Nothing Then
                MsgBox(LocRM.GetString("strNoCitySelected"), MsgBoxStyle.Exclamation, LocRM.GetString("titCaution"))
                ComboBox1.Focus()
            ElseIf ComboBox2.Text = Nothing Then
                AVSIB_PersonCheck.filterby = "Ort='" & place & "'"
                Close()
            ElseIf ComboBox3.Text = Nothing Then
                AVSIB_PersonCheck.filterby = "Ort='" & place & "' AND PLZ=" & zip
                Close()
            Else
                AVSIB_PersonCheck.filterby = "Straße='" & street & "' AND Ort='" & place & "' AND PLZ='" & zip & "'"
                Close()
            End If
        Else
            If ComboBox1.Text = Nothing Then
                AVSIB_PersonCheck.filterby = "Vorname='" & firstn & "'"
                Close()
            ElseIf ComboBox2.Text = Nothing Then
                AVSIB_PersonCheck.filterby = "Nachname='" & lastn & "'"
                Close()
            Else
                AVSIB_PersonCheck.filterby = "Nachname='" & lastn & "' AND Vorname='" & firstn & "'"
                Close()
            End If
        End If
    End Sub

    Private Sub AVSIB_PersonFilter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        If CBAdress.Checked = True Then
            place = ComboBox1.Text.ToString
            count = Orte.GetPLZCount(place) - 1
            For i As Integer = 0 To count
                ComboBox2.Items.Add(Orte.GetPLZabc(i, place))
            Next
            ComboBox2.Enabled = True
            ComboBox2.Focus()
        Else
            lastn = ComboBox1.Text.ToString
            count = Personen.GetCountByLastName(lastn) - 1
            Dim id As Long
            For i As Long = 0 To count
                id = Personen.GetIDByLastName(lastn, i)
                ComboBox2.Items.Add(Personen.GetVorname(id))
            Next
            ComboBox2.Enabled = True
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()
        If CBAdress.Checked = True Then
            zip = ComboBox2.Text.ToString
            count = Straße.getCount(place, zip) - 1
            Dim id As Long
            For i As Integer = 0 To count
                id = Straße.getID(place, zip, i)
                ComboBox3.Items.Add(Straße.GetStraßebyID(id))
            Next
            ComboBox3.Enabled = True
            ComboBox3.Focus()
        Else
            firstn = ComboBox2.Text
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If CBAdress.CheckState = CheckState.Checked Then
            street = ComboBox3.Text.ToString
        End If
    End Sub
End Class