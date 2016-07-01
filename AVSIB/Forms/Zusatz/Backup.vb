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

Imports System.IO
Imports System.Deployment.Application

Public Class Backup
    Dim count As Integer
    Dim changed As Boolean = False

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Directory.Exists(Application.StartupPath & "\Data\Backup\") = False Then
            Directory.CreateDirectory(Application.StartupPath & "\Data\Backup\")
        End If
        Dim name As String = Today.Date.Year & "-" & Today.Date.Month & "-" & Today.Date.Day & "_" & System.DateTime.Now.Hour & "-" & System.DateTime.Now.Minute
        Try
            File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf", Application.StartupPath & "\Data\Backup\" & name & ".mdf")
            File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf", Application.StartupPath & "\Data\Backup\" & name & ".ldf")
            If File.Exists(Application.StartupPath & "\Data\Backup\Backups.ini") = False Then
                Using File.Create(Application.StartupPath & "\Data\Backup\Backups.ini")
                End Using
                count = 1
                CSettings.Save("Anzahl", count, Application.StartupPath & "\Data\Backup\Backups.ini")
                CSettings.Save(count, name, Application.StartupPath & "\Data\Backup\Backups.ini")
                MsgBox("Backup erfolgreich erstellt", MsgBoxStyle.Information, "Erfolg")
            Else
                count = CSettings.Load("Anzahl", Application.StartupPath & "\Data\Backup\Backups.ini") + 1
                CSettings.Remove("Anzahl", Application.StartupPath & "\Data\Backup\Backups.ini")
                CSettings.Save("Anzahl", count, Application.StartupPath & "\Data\Backup\Backups.ini")
                CSettings.Save(count, name, Application.StartupPath & "\Data\Backup\Backups.ini")
                MsgBox("Backup erfolgreich erstellt", MsgBoxStyle.Information, "Erfolg")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Fehler")
        End Try
    End Sub

    Private Sub CBRestore_CheckedChanged(sender As Object, e As EventArgs) Handles CBRestore.CheckedChanged
        If changed = False Then
            changed = True
            RichTextBox1.Visible = False
            CBBackup.CheckState = CheckState.Unchecked
            CBRestore.CheckState = CheckState.Checked
            Button1.Visible = False
            Button1.Enabled = False
            BRestore.Enabled = True
            BRestore.Visible = True
            ListBox1.Enabled = True
            ListBox1.Visible = True
            BDelete.Visible = True
            BDelete.Enabled = True
            Try
                count = CSettings.Load("Anzahl", Application.StartupPath & "\Data\Backup\Backups.ini")
            Catch ex As Exception
                MsgBox("Keine Backups gefunden", MsgBoxStyle.Critical, "Fehler")
                BRestore.Enabled = False
            End Try
            For i As Integer = 1 To count
                ListBox1.Items.Add(CSettings.Load(i, Application.StartupPath & "\Data\Backup\Backups.ini"))
            Next
            changed = False
        End If
    End Sub

    Private Sub CBBackup_CheckedChanged(sender As Object, e As EventArgs) Handles CBBackup.CheckedChanged
        If changed = False Then
            changed = True
            RichTextBox1.Visible = True
            CBBackup.CheckState = CheckState.Checked
            CBRestore.CheckState = CheckState.Unchecked
            BRestore.Visible = False
            BRestore.Enabled = False
            Button1.Enabled = True
            Button1.Visible = True
            ListBox1.Enabled = False
            ListBox1.Visible = False
            ListBox1.Items.Clear()
            BDelete.Visible = False
            BDelete.Enabled = False
            changed = False
        End If
    End Sub

    Private Sub BRestore_Click(sender As Object, e As EventArgs) Handles BRestore.Click
        If ListBox1.SelectedItem <> Nothing Then
            Dim name As String = CSettings.Load(ListBox1.SelectedIndex + 1, Application.StartupPath & "\Data\Backup\Backups.ini")
            File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
            File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
            File.Copy(Application.StartupPath & "\Data\Backup\" & name & ".mdf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
            File.Copy(Application.StartupPath & "\Data\Backup\" & name & ".ldf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
            MsgBox("Backup erfolgreich widerhergestellt!", MsgBoxStyle.Information, "Erfolg")
        Else
            MsgBox("Kein Backup ausgewählt", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Backup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each proc In System.Diagnostics.Process.GetProcessesByName("sqlservr")
            proc.Kill()
        Next
    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click
        If ListBox1.SelectedItem <> Nothing Then
            Dim name As String = CSettings.Load(ListBox1.SelectedIndex + 1, Application.StartupPath & "\Data\Backup\Backups.ini")
            File.Delete(Application.StartupPath & "\Data\Backup\" & name & ".mdf")
            File.Delete(Application.StartupPath & "\Data\Backup\" & name & ".ldf")
            count = CSettings.Load("Anzahl", Application.StartupPath & "\Data\Backup\Backups.ini")
            Dim copy As String
            For i As Integer = ListBox1.SelectedIndex + 1 To count
                CSettings.Remove(i, Application.StartupPath & "\Data\Backup\Backups.ini")
                If count - 1 <> 0 And count <> i Then
                    copy = CSettings.Load(i + 1, Application.StartupPath & "\Data\Backup\Backups.ini")
                    CSettings.Save(i, copy, Application.StartupPath & "\Data\Backup\Backups.ini")
                End If
            Next
            ListBox1.Items.Clear()
            count = count - 1
            If count = 0 Then
                MsgBox("Keine Backups gefunden", MsgBoxStyle.Critical, "Fehler")
                BRestore.Enabled = False
                BDelete.Enabled = False
            Else
                For i As Integer = 1 To count
                    ListBox1.Items.Add(CSettings.Load(i, Application.StartupPath & "\Data\Backup\Backups.ini"))
                Next
            End If
            CSettings.Remove("Anzahl", Application.StartupPath & "\Data\Backup\Backups.ini")
            CSettings.Save("Anzahl", count, Application.StartupPath & "\Data\Backup\Backups.ini")
        Else
            MsgBox("Kein Backup zum löschen ausgewählt!", MsgBoxStyle.Exclamation, "Warnung")
        End If
    End Sub
End Class