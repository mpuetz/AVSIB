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
Public Class AVSIB_Configuration2
    ' asks for the company-name and the project-name
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(AVSIB_Configuration2).Assembly)
    Dim clicked As Integer = "0"
    Dim first As Integer = CSettings.Load("FirstRun", Application.StartupPath & "\settings.ini")

    Private Sub Config2ButtonNext_Click(sender As Object, e As EventArgs) Handles Config2ButtonNext.Click
        ' checks whether all required informations were entered and saves them to settings.ini, else displays a message to the user
        ' and tells him to enter all required informations.
        If TextBox2.Text <> Nothing And TextBox1.Text <> Nothing Then
            CSettings.Save("Organisation", TextBox1.Text, Application.StartupPath & "\settings.ini")
            CSettings.Save("Projekt", TextBox2.Text, Application.StartupPath & "\settings.ini")
            CSettings.Remove("FirstRun", Application.StartupPath & "\settings.ini")
            CSettings.Save("FirstRun", "0", Application.StartupPath & "\settings.ini")
            first = CSettings.Load("FirstRun", Application.StartupPath & "\settings.ini")
            Me.Close()
        ElseIf TextBox2.Text = Nothing Or TextBox1.Text = Nothing Then
            MsgBox(LocRM.GetString("strFieldsMissing"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
        End If

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        ' If the back-button is clicked and the configuration runs for the first time, it exits the program, else it closes the form.
        If first = "0" Then
            Me.Close()
        Else
            Dim Auswahl As Integer = MsgBox(LocRM.GetString("strConf2Close"), MsgBoxStyle.OkCancel, LocRM.GetString("titInformartion"))
            If Auswahl = "1" Then
                AVSIB_Main.Close()
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub AVSIB_Configuration2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If first = "0" Then
            AVSIB_Main.Show()
        Else
            AVSIB_Main.Close()
        End If
        Me.Dispose()
    End Sub

    Private Sub SKeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown, TextBox1.KeyDown
        ' pressing enter triggers click on ConfigButton2.
        If e.KeyCode = Keys.Enter Then
            Config2ButtonNext.PerformClick()
        End If
    End Sub
End Class