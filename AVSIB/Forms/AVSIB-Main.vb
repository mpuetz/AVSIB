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

Imports System.Deployment.Application
Imports System.Resources

' This class is mainly used to open the different forms and check, whether all settings are set.
Public Class AVSIB_Main
    Dim FirstRun As Integer
    Private LocRM As New ResourceManager("AVSIB.WinFormStrings", GetType(AVSIB_Main).Assembly)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Checks if the settings.txt exists and whether the settings were entered by the user. If not, it starts the configuration form.
        ' If the settings were not done yet, it replaces the database with a blank one.
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.WindowState = FormWindowState.Maximized
        If IO.File.Exists(Application.StartupPath + "\settings.ini") = False Then
            CSettings.Save("FirstRun", "1", Application.StartupPath + "\settings.ini")
            CSettings.Save("ConfigRunning", "0", Application.StartupPath + "\settings.ini")
            AVSIB_Configuration.Show()
            Me.Hide()
        ElseIf CSettings.Load("FirstRun", Application.StartupPath + "\settings.ini") = "1" Then
            For Each proc In System.Diagnostics.Process.GetProcessesByName("sqlservr")
                proc.Kill()
            Next
            System.Threading.Thread.Sleep(500)
            System.IO.File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
            System.IO.File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
            System.IO.File.Delete(Application.StartupPath & "\settings.ini")
            System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\Data\Reset\AVSIB_Data.mdf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
            System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\Data\Reset\AVSIB_Data_log.ldf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
            MsgBox(LocRM.GetString("strSuccess"), MsgBoxStyle.Information, LocRM.GetString("titSuccess"))
            CSettings.Save("FirstRun", "1", Application.StartupPath + "\settings.ini")
            CSettings.Save("ConfigRunning", "0", Application.StartupPath + "\settings.ini")
            AVSIB_Configuration.Show()
            Me.Hide()
        Else
            FirstRun = CSettings.Load("FirstRun", Application.StartupPath + "\settings.ini")
        End If
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MainButtonEnde_Click(sender As Object, e As EventArgs) Handles MainButtonEnde.Click
        Me.Close()
    End Sub

    Private Sub MainButtonPersonen_Click(sender As Object, e As EventArgs) Handles MainButtonPersonen.Click
        AVSIB_PersonCheck.ShowDialog()
    End Sub

    Private Sub MainButtonAusträger_Click(sender As Object, e As EventArgs) Handles MainButtonAusträger.Click
        AVSIB_Austräger.ShowDialog()
    End Sub

    Private Sub MainButtonOrte_Click(sender As Object, e As EventArgs) Handles MainButtonOrte.Click
        AVSIB_Ort.ShowDialog()
    End Sub

    Private Sub MainButtonStraßen_Click(sender As Object, e As EventArgs) Handles MainButtonStraßen.Click
        AVSIB_Straße.ShowDialog()
    End Sub

    Private Sub MainButtonBezirke_Click(sender As Object, e As EventArgs) Handles MainButtonBezirke.Click
        AVSIB_Bezirke.ShowDialog()
    End Sub

    Private Sub MainButtonExport_Click(sender As Object, e As EventArgs) Handles MainButtonExport.Click
        Import_Export.ShowDialog()
    End Sub

    Private Sub MainButtonDrucken_Click(sender As Object, e As EventArgs) Handles MainButtonDrucken.Click
        AVSIB_Drucken.ShowDialog()
    End Sub

    Private Sub MainButtonReset_Click(sender As Object, e As EventArgs) Handles MainButtonReset.Click
        ' When the reset-Button is clicked the database gets deleted and replaced by a new one.
        ' The settings.txt will be reset, too, and the configuration-form will be loaded.
        If MsgBox(LocRM.GetString("strCautionDelete"), MsgBoxStyle.YesNo, LocRM.GetString("titCaution")).ToString = "Yes" Then
            For Each proc In System.Diagnostics.Process.GetProcessesByName("sqlservr")
                proc.Kill()
            Next
            System.Threading.Thread.Sleep(500)
            System.IO.File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
            System.IO.File.Delete(ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
            System.IO.File.Delete(Application.StartupPath & "\settings.ini")
            System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\Data\Reset\AVSIB_Data.mdf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data.mdf")
            System.IO.File.Copy(ApplicationDeployment.CurrentDeployment.DataDirectory & "\Data\Reset\AVSIB_Data_log.ldf", ApplicationDeployment.CurrentDeployment.DataDirectory & "\AVSIB_Data_log.ldf")
            MsgBox(LocRM.GetString("strSuccess"), MsgBoxStyle.Information, LocRM.GetString("titSuccess"))
            CSettings.Save("FirstRun", "1", Application.StartupPath + "\settings.ini")
            CSettings.Save("ConfigRunning", "0", Application.StartupPath + "\settings.ini")
            AVSIB_Configuration.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub MainButtonConfiguration_Click(sender As Object, e As EventArgs) Handles MainButtonConfiguration.Click
        ' If the file settings.txt does not exist or FirstRun is set to 1 it starts the configuration-form, which displays
        ' a quick introduction. Else, the configuration2-from is shown, which asks for the settings needed.
        If IO.File.Exists(Application.StartupPath + "\settings.ini") = False Then
            CSettings.Save("FirstRun", "1", Application.StartupPath + "\settings.ini")
            CSettings.Save("ConfigRunning", "0", Application.StartupPath + "\settings.ini")
            AVSIB_Configuration.Show()
            Me.Hide()
        ElseIf CSettings.Load("FirstRun", Application.StartupPath + "\settings.ini") = "1" Then
            AVSIB_Configuration.Show()
            Me.Hide()
        Else
            FirstRun = CSettings.Load("FirstRun", Application.StartupPath + "\settings.ini")
            AVSIB_Configuration2.ShowDialog()
        End If
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub FehlerMelderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FehlerMelderToolStripMenuItem.Click
        Bugs.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Backup.ShowDialog()
    End Sub

    Private Sub Hilfe_Button_Click(sender As Object, e As EventArgs) Handles Hilfe_Button.Click
        Help.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Changelog.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Statistik.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
