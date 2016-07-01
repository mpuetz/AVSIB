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

Public Class Austräger
    Public Shared Function GetBezirkByName(ByVal Nachname As String, Vorname As String)
        Try
            Dim AusträgerDataTable As New AusträgerTableAdapters.AusträgerTableAdapter
            Dim Bezirk As Long = AusträgerDataTable.GetBezirkByName(Nachname, Vorname)
            Return Bezirk
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetNameByBezirk(ByVal Bezirk As Long)
        Try
            Dim AusträgerDataTable As New AusträgerTableAdapters.AusträgerTableAdapter
            Dim Name As String = AusträgerDataTable.GetNameByBezirk(Bezirk)
            Return Name
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetVornameByBezirk(ByVal Bezirk As Long)
        Try
            Dim DataTable As New AusträgerTableAdapters.AusträgerTableAdapter
            Return DataTable.GetVornameByBezirk(Bezirk)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function InsertNULL(ByVal Bezirk As Long)
        Dim DataTable As New AusträgerTableAdapters.AusträgerTableAdapter
        DataTable.InsertNULL(Bezirk)
        Return 0
    End Function

    Public Shared Function Update(ByVal Bezirk As Long, Nachname As String, Vorname As String)
        Try
            Dim AusträgerDataTable As New AusträgerTableAdapters.AusträgerTableAdapter
            AusträgerDataTable.Update(Bezirk, Nachname, Vorname, Bezirk)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function Delete(ByVal Bezirk As Long)
        Try
            Dim AusträgerDataTable As New AusträgerTableAdapters.AusträgerTableAdapter
            AusträgerDataTable.Update(Bezirk, "NULL", "NULL", Bezirk)
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, "Fehler")
        End Try
        Return 0
    End Function

    Public Shared Function GetCount()
        Dim DataTable As New AusträgerTableAdapters.AusträgerTableAdapter
        Return DataTable.GetCount
        Return 0
    End Function

End Class
