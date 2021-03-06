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

Imports System.Resources
Imports System.Deployment.Application
Public Class Import_Export
    Dim LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(Import_Export).Assembly)
    ' This form is used to ex- and import the database file to places the user selects, so a backup to an external drive becomes possible.
    Private Sub B_Export_Click(sender As Object, e As EventArgs) Handles B_Export.Click
        ' Whe Export is clicked, a FolderBrowser gets shown and the file will be saved at the location the user enters and with the name AVSIB_Data.
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
        Else
            Dim path As String = FolderBrowserDialog.SelectedPath.ToString & "\" & Date.Today.Year & Date.Today.Month & Date.Today.Day
            If System.IO.Directory.Exists(path) = False Then
                System.IO.Directory.CreateDirectory(path)
            End If
            If System.IO.File.Exists(path & "\AVSIB_Data.mdf") Or System.IO.File.Exists(path & "\AVSIB_Data_log.ldf") = True Then
                If MsgBox(LocRM.GetString("strFileExists"), MsgBoxStyle.YesNo, LocRM.GetString("titCaution")) = MsgBoxResult.Yes Then
                    System.IO.File.Delete(path & "\AVSIB_Data.mdf")
                    System.IO.File.Delete(path & "\AVSIB_Data_log.ldf")
                    System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf", path & "\AVSIB_Data.mdf")
                    System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf", path & "\AVSIB_Data_log.ldf")
                    MsgBox(LocRM.GetString("strSuccess"), MsgBoxStyle.Information, LocRM.GetString("titSuccess"))
                    Log.WriteLog(AVSIB_Main.user, AVSIB_Main.user & " exported database to " & path & "\AVSIB_Data.mdf")
                Else
                    MsgBox(LocRM.GetString("strAborted"), MsgBoxStyle.Information, LocRM.GetString("titInformation"))
                End If
            Else
                System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf", path & "\AVSIB_Data.mdf")
                System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf", path & "\AVSIB_Data_log.ldf")
                MsgBox(LocRM.GetString("strSuccess"), MsgBoxStyle.Information, LocRM.GetString("titSuccess"))
                Log.WriteLog(AVSIB_Main.user, AVSIB_Main.user & " exported database to " & path & "\AVSIB_Data.mdf")
            End If
        End If
    End Sub

    Private Sub B_Import_Click(sender As Object, e As EventArgs) Handles B_Import.Click
        ' Gets the name and location of a backup the user enters. If there exists a file named AVSIB_DATA the file will be copied as the new database.
Start:
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
        Else
            Dim path As String = OpenFileDialog1.FileName
            Dim directory As String = System.IO.Path.GetDirectoryName(path)
            If System.IO.File.Exists(path) = False Then
                MsgBox(LocRM.GetString("strFileDoesntExist"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
                GoTo Start
            ElseIf System.IO.File.Exists(directory & "\AVSIB_Data.mdf") Or System.IO.File.Exists(directory & "\AVSIB_Data_log.ldf") = True Then
                System.IO.File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
                System.IO.File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
                System.IO.File.Copy(directory & "\AVSIB_Data.mdf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
                System.IO.File.Copy(directory & "\AVSIB_Data_log.ldf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
                MsgBox(LocRM.GetString("strSuccess"), MsgBoxStyle.Information, LocRM.GetString("titSuccess"))
                Log.WriteLog(AVSIB_Main.user, AVSIB_Main.user & " imported database from " & path & "\AVSIB_Data.mdf")
            Else
                MsgBox(LocRM.GetString("strFileDoesntExist"), MsgBoxStyle.Critical, LocRM.GetString("titError"))
                GoTo Start
            End If
        End If
    End Sub

    Private Sub Import_Export_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the form is loaded, all SQL-processes get killed to make it able to work with the databse files.
        FolderBrowserDialog.SelectedPath = Application.StartupPath
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        For Each proc In System.Diagnostics.Process.GetProcessesByName("sqlservr")
            proc.Kill()
        Next
    End Sub
End Class