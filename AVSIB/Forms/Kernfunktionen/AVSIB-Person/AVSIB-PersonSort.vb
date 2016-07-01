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

Public Class AVSIB_PersonSort
    Dim SelectedOrder As String
    Dim Sort1 As String
    Dim Sort2 As String
    Dim Sort3 As String
    Dim Sort4 As String
    Dim Sort5 As String
    Dim Sort6 As String
    Dim Sort7 As String

    Private Sub AVSIB_PersonSort_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ComboBox6.SelectedIndex = 0 Then
            Sort1 = "asc"
        Else
            Sort1 = "desc"
        End If
        If ComboBox7.SelectedIndex = 0 Then
            Sort2 = "asc"
        Else
            Sort2 = "desc"
        End If
        If ComboBox8.SelectedIndex = 0 Then
            Sort3 = "asc"
        Else
            Sort3 = "desc"
        End If
        If ComboBox9.SelectedIndex = 0 Then
            Sort4 = "asc"
        Else
            Sort4 = "desc"
        End If
        If ComboBox10.SelectedIndex = 0 Then
            Sort5 = "asc"
        Else
            Sort5 = "desc"
        End If
        If ComboBox11.SelectedIndex = 0 Then
            Sort6 = "asc"
        Else
            Sort6 = "desc"
        End If
        If ComboBox13.SelectedIndex = 0 Then
            Sort7 = "asc"
        Else
            Sort7 = "desc"
        End If
        AVSIB_PersonCheck.sortchanged = True
        AVSIB_PersonCheck.SelectedOrder = ComboBox1.SelectedItem.ToString & " " & Sort1 & ", " & ComboBox2.SelectedItem.ToString & " " & Sort2 & ", " &
            ComboBox3.SelectedItem.ToString & " " & Sort3 & ", " & ComboBox4.SelectedItem.ToString & " " & Sort4 & ", " & ComboBox5.SelectedItem.ToString & " " & Sort5 _
        & ", " & ComboBox12.SelectedItem.ToString & " " & Sort6 & ", " & ComboBox14.SelectedItem.ToString & " " & Sort7
        AVSIB_PersonCheck.Show()
    End Sub

    Private Sub AVSIB_PersonSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 1
        ComboBox3.SelectedIndex = 2
        ComboBox4.SelectedIndex = 3
        ComboBox5.SelectedIndex = 4
        ComboBox12.SelectedIndex = 5
        ComboBox14.SelectedIndex = 6
        ComboBox6.SelectedIndex = 0
        ComboBox7.SelectedIndex = 0
        ComboBox8.SelectedIndex = 0
        ComboBox9.SelectedIndex = 0
        ComboBox10.SelectedIndex = 0
        ComboBox11.SelectedIndex = 0
        ComboBox13.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem.ToString = ComboBox2.SelectedItem.ToString Or ComboBox1.SelectedItem.ToString = ComboBox3.SelectedItem.ToString Or
            ComboBox1.SelectedItem.ToString = ComboBox4.SelectedItem.ToString Or ComboBox1.SelectedItem.ToString = ComboBox5.SelectedItem.ToString Or
            ComboBox1.SelectedItem.ToString = ComboBox12.SelectedItem.ToString Or ComboBox1.SelectedItem.ToString = ComboBox14.SelectedItem.ToString Or
            ComboBox2.SelectedItem.ToString = ComboBox3.SelectedItem.ToString Or ComboBox2.SelectedItem.ToString = ComboBox4.SelectedItem.ToString Or
            ComboBox2.SelectedItem.ToString = ComboBox5.SelectedItem.ToString Or ComboBox3.SelectedItem.ToString = ComboBox4.SelectedItem.ToString Or
            ComboBox2.SelectedItem.ToString = ComboBox12.SelectedItem.ToString Or ComboBox4.SelectedItem.ToString = ComboBox14.SelectedItem.ToString Or
            ComboBox3.SelectedItem.ToString = ComboBox5.SelectedItem.ToString Or ComboBox4.SelectedItem.ToString = ComboBox5.SelectedItem.ToString _
            Or ComboBox3.SelectedItem.ToString = ComboBox12.SelectedItem.ToString Or ComboBox3.SelectedItem.ToString = ComboBox14.SelectedItem.ToString _
            Or ComboBox4.SelectedItem.ToString = ComboBox12.SelectedItem.ToString Or ComboBox4.SelectedItem.ToString = ComboBox14.SelectedItem.ToString _
            Or ComboBox5.SelectedItem.ToString = ComboBox12.SelectedItem.ToString Or ComboBox5.SelectedItem.ToString = ComboBox14.SelectedItem.ToString _
            Or ComboBox12.SelectedItem.ToString = ComboBox14.SelectedItem.ToString Then
            MsgBox("Bitte achten Sie darauf, das jede Option nur EINMAL ausgewählt ist!", MsgBoxStyle.Critical, "Fehler!")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub AVSIB_PersonSort_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class