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

Imports System.Deployment.Application
Public Class Import_Export
    Private Sub B_Export_Click(sender As Object, e As EventArgs) Handles B_Export.Click
        If FolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
        Else
            Dim path As String = FolderBrowserDialog.SelectedPath.ToString & "\" & Date.Today.Year & Date.Today.Month & Date.Today.Day
            If System.IO.Directory.Exists(path) = False Then
                System.IO.Directory.CreateDirectory(path)
            End If
            If System.IO.File.Exists(path & "\AVSIB_Data.mdf") Or System.IO.File.Exists(path & "\AVSIB_Data_log.ldf") = True Then
                If MsgBox("Am angegebenen Pfad existiert bereits diese Datei. Wenn Sie fortfahren wird diese Datei überschrieben. Sind Sie sicher?", MsgBoxStyle.YesNo, "Warnung") = MsgBoxResult.Yes Then
                    System.IO.File.Delete(path & "\AVSIB_Data.mdf")
                    System.IO.File.Delete(path & "\AVSIB_Data_log.ldf")
                    System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf", path & "\AVSIB_Data.mdf")
                    System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf", path & "\AVSIB_Data_log.ldf")
                    MsgBox("Erfolg!", MsgBoxStyle.Information, "Erfolg")
                Else
                    MsgBox("Abgebrochen", MsgBoxStyle.Information, "Information")
                End If
            Else
                System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf", path & "\AVSIB_Data.mdf")
                System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf", path & "\AVSIB_Data_log.ldf")
                MsgBox("Erfolg!", MsgBoxStyle.Information, "Erfolg")
            End If
        End If
    End Sub

    Private Sub B_Import_Click(sender As Object, e As EventArgs) Handles B_Import.Click
Start:
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
        Else
            Dim path As String = OpenFileDialog1.FileName
            Dim directory As String = System.IO.Path.GetDirectoryName(path)
            If System.IO.File.Exists(path) = False Then
                MsgBox("Die von Ihnen gewählte Datei scheint nicht zu existieren!", MsgBoxStyle.Critical)
                GoTo Start
            ElseIf System.IO.File.Exists(directory & "\AVSIB_Data.mdf") Or System.IO.File.Exists(directory & "\AVSIB_Data_log.ldf") = True Then
                System.IO.File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
                System.IO.File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
                System.IO.File.Copy(directory & "\AVSIB_Data.mdf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
                System.IO.File.Copy(directory & "\AVSIB_Data_log.ldf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
                MsgBox("Erfolg!", MsgBoxStyle.Information, "Erfolg")
            Else
                MsgBox("Die von Ihnen gewählte Datei scheint nicht zu existieren! Bitte überprüfen Sie, ob die Datei nicht umbenannt wurde.", MsgBoxStyle.Critical)
                GoTo Start
            End If
        End If
    End Sub

    Private Sub Import_Export_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FolderBrowserDialog.SelectedPath = Application.StartupPath
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        For Each proc In System.Diagnostics.Process.GetProcessesByName("sqlservr")
            proc.Kill()
        Next
    End Sub
End Class