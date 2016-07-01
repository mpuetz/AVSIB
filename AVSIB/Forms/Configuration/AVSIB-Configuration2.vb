﻿'Das Programm dient zum Aufbau und zur Pflege einer Datenbank, In welcher die Empfänger einer Informationsschrift den Austrägern zugeordnet werden. 
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

Public Class AVSIB_Configuration2
    Dim clicked As Integer = "0"
    Dim first As Integer = CSettings.Load("FirstRun", Application.StartupPath & "\settings.ini")

    Private Sub Config2ButtonNext_Click(sender As Object, e As EventArgs) Handles Config2ButtonNext.Click
        If TextBox2.Text <> Nothing And TextBox1.Text <> Nothing Then
            CSettings.Save("Organisation", TextBox1.Text, Application.StartupPath & "\settings.ini")
            CSettings.Save("Projekt", TextBox2.Text, Application.StartupPath & "\settings.ini")
            CSettings.Remove("FirstRun", Application.StartupPath & "\settings.ini")
            CSettings.Save("FirstRun", "0", Application.StartupPath & "\settings.ini")
            first = CSettings.Load("FirstRun", Application.StartupPath & "\settings.ini")
            Me.Close()
        ElseIf TextBox2.Text = Nothing Or TextBox1.Text = Nothing Then
            MsgBox("Bitte füllen Sie alle Felder aus!", MsgBoxStyle.Critical, "Fehler!")
        End If

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Dim First As Integer = CSettings.Load("FirstRun", Application.StartupPath & "\settings.ini")
        If First = "0" Then
            clicked = "0"
            Me.Close()
        Else
            Dim Auswahl As Integer = MsgBox("Dies beendet das Programm. Sind Sie sicher?", MsgBoxStyle.OkCancel, "Information")
            If Auswahl = "1" Then
                clicked = "1"
                AVSIB_Main.Close()
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub AVSIB_Configuration2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If first = "0" Then
        Else
            AVSIB_Main.Close()
        End If
        AVSIB_Main.Show()
        Me.Dispose()
    End Sub

    Private Sub SKeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown, TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Config2ButtonNext.PerformClick()
        End If
    End Sub
End Class