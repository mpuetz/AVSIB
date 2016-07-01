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

Public Class AVSIB_Configuration
    Dim FirstRun As Integer
    Private Sub AVSIB_Configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FirstRun = CSettings.Load("FirstRun", Application.StartupPath + "\settings.ini")
        Catch ex As Exception
            FirstRun = 1
        End Try
    End Sub
    Private Sub ConfigButtonBack_Click(sender As Object, e As EventArgs) Handles ConfigButtonBack.Click
        Dim Running As Integer = CSettings.Load("ConfigRunning", Application.StartupPath + "\settings.ini")
        If FirstRun = "1" And Running = "1" Then
            Me.Close()
        Else
            Me.Close()
            AVSIB_Main.Show()
        End If
    End Sub

    Private Sub ConfigButtonForward_Click(sender As Object, e As EventArgs) Handles ConfigButtonForward.Click
        AVSIB_Configuration2.Show()
        Me.Close()
    End Sub

    Private Sub AVSIB_Configuration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Running As Integer = CSettings.Load("ConfigRunning", Application.StartupPath + "\settings.ini")
        If FirstRun = "1" And Running = "1" Then
            CSettings.Remove("ConfigRunning", Application.StartupPath + "\settings.ini")
            CSettings.Save("ConfigRunning", "0", Application.StartupPath + "\settings.ini")
            AVSIB_Main.Close()
        ElseIf FirstRun = "0" Then
            AVSIB_Main.Show()
        End If
        Me.Dispose()
    End Sub
End Class