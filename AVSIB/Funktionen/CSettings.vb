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
'Das Speichern und Laden der Einstellungen In eine Datei basiert auf einer Klasse von "Animix"
'https://www.vb-paradise.de/index.php/Thread/24755-Settings-Speichern-Laden-und-L%C3%B6schen-in-einer-datei/

Public Class CSettings
    Public Shared Function Load(ByVal lpKey As String, ByVal lpPath As String)
        Dim Reader() As String = IO.File.ReadAllLines(lpPath)

        For i As Integer = 0 To Reader.Length - 1
            If Reader(i).StartsWith(";") Or Reader(i).StartsWith("#") Or Reader(i).StartsWith("//") Then Continue For
            If Reader(i).StartsWith(lpKey) Then
                Dim Splitter() As Object
                Splitter = Split(Reader(i), "=")
                Return Splitter(1).ToString
            End If
        Next
        Return 0
    End Function

    Public Shared Function Save(ByVal lpKey As String, ByVal lpValue As String, ByVal lpPath As String)
        If IO.File.Exists(lpPath) = False Then
            Dim FileSys As System.IO.FileStream
            FileSys = System.IO.File.Create(lpPath)
            FileSys.Close()
        End If

        Dim Reader() As String = IO.File.ReadAllLines(lpPath)
        Dim Writer As New System.IO.StreamWriter(lpPath)
        Const vbSpace As String = "="
        Dim KeyFound As Boolean

        If Reader.Length = 0 Then
            KeyFound = False
        End If

        For i As Integer = 0 To Reader.Length - 1
            If Reader(i).StartsWith(lpKey) Then
                KeyFound = True
                Exit For
            End If
        Next

        If KeyFound = False Then
            For i As Integer = 0 To Reader.Length - 1
                Writer.WriteLine(Reader(i))
            Next
            Writer.WriteLine(lpKey & vbSpace & lpValue)
        Else
            For i As Integer = 0 To Reader.Length - 1
                If Reader(i).StartsWith(lpKey) Then
                    Writer.WriteLine(lpKey & vbSpace & lpValue)
                End If
            Next
        End If
        Writer.Dispose()
        Writer.Close()
        Return 0
    End Function

    Public Shared Function Remove(ByVal lpKey As String, ByVal lpPath As String)
        Dim Reader() As String = System.IO.File.ReadAllLines(lpPath)
        Dim Writer As New System.IO.StreamWriter(lpPath)

        For i As Integer = 0 To Reader.Length - 1
            If Reader(i).StartsWith(lpKey) = False Then
                Writer.WriteLine(Reader(i))
            End If
        Next
        Writer.Dispose()
        Writer.Close()
        Return 0
    End Function
End Class