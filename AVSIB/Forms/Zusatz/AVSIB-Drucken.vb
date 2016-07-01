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
'
'Das Drucken der ListBox basiert auf einer Klassen von Matthias Zürn
'http://www.vbarchiv.net/tipps/tipp_1473-listview-inhalt-drucken-vb-2005.html


Public Class AVSIB_Drucken
    Dim Start As Boolean
    Dim AutoSelectRunning As Boolean
    Dim SelectedCount As Long
    Dim SelectedBezirk As Long
    Dim Page As Long
    Dim AusträgerCount As Long
    Dim BezirkeCount As Long
    Dim BezirkNr As Long
    Dim StraßenCount As Long
    Dim OrteCount As Long
    Dim PersonenCount As Long
    Dim count As Long
    Dim ID As Long
    Dim OrtStr As String
    Dim StraßenStr As String
    Dim PLZStr As Long
    Dim HausnummerStr As Long
    Dim ZusatzStr As String
    Dim VornameStr As String
    Dim NachnameStr As String
    Dim AusträgerVornameStr As String
    Dim AusträgerNachnameStr As String
    Dim combined As String
    Dim myTab As String
    Dim Organisation As String = CSettings.Load("Organisation", Application.StartupPath & "\settings.ini")
    Dim Projekt As String = CSettings.Load("Projekt", Application.StartupPath & "\settings.ini")

    Private PrintLV As New CPrintListView

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub AVSIB_Drucken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start = True
        ListBox2.Items.Add("Alle")
        AusträgerCount = Austräger.GetCount
        For i As Long = 1 To AusträgerCount
            ListBox2.Items.Add(i)
        Next
        ListBox2.SelectedIndex = 0
        B_Previous.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SelectedBezirk <> 0 And SelectedBezirk > 0 Then
            Dim SelectedObjects As New ListBox.SelectedObjectCollection(ListBox2)
            For i As Long = 1 To SelectedCount
                SelectedBezirk = SelectedObjects.Item(i - 1)
                ChangeListView()
                PrintLV = New CPrintListView(ListView1)
                PrintLV.AutoSizeColumn = CPrintListView.SizeColumn.AutoSitze
                PrintDialog1.Document = PrintDocument1
                PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
                If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                    PrintLV.Print(PrintDocument1.PrinterSettings.PrinterName.ToString)
                End If
            Next
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("a", New Font("New Courier", 12, FontStyle.Regular), Brushes.Black, 10, 10)
    End Sub

    Private Sub AVSIB_Drucken_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub SKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If Start = True Then
            Start = False
            SelectedBezirk = "1"
            Try
                ChangeListView()
            Catch ex As Exception
                MsgBox("Es scheint als wäre kein Bezirk angelegt worde. Bitte legen Sie zunächst die erforderlichen Daten an!", MsgBoxStyle.Critical)
                GoTo EndLine
            End Try
            MsgBox("Hier wird als Vorschau der Bezirk 1 angezeigt, es werden jedoch alle Bezirke gedruckt!", MsgBoxStyle.Information, "Information")
        End If
        If AutoSelectRunning = True Then
            GoTo EndLine
        End If
        If ListBox2.SelectedIndex = "0" Then
            B_Next.Enabled = True
            B_Previous.Enabled = False
            AutoSelectRunning = True
            For i As Long = 1 To AusträgerCount
                ListBox2.SetSelected(i, True)
            Next
            ListBox2.SetSelected(0, False)
            AutoSelectRunning = False
            Dim SelectedObjects As New ListBox.SelectedObjectCollection(ListBox2)
            SelectedCount = SelectedObjects.Count
            Try
                SelectedBezirk = SelectedObjects.Item(0)
            Catch ex As Exception
                MsgBox("Es scheint als wäre kein Bezirk angelegt worde. Bitte legen Sie zunächst die erforderlichen Daten an!", MsgBoxStyle.Critical)
                Me.Close()
                GoTo EndLine
            End Try
            Page = "0"
            If ListBox2.SelectedItem <> Nothing Then
                ChangeListView()
            End If
        Else
            Dim SelectedObjects As New ListBox.SelectedObjectCollection(ListBox2)
            SelectedCount = SelectedObjects.Count
            If SelectedCount > 1 Then B_Next.Enabled = True
            B_Previous.Enabled = False
            SelectedBezirk = SelectedObjects.Item(0)
            Page = "0"
            If ListBox2.SelectedItem <> Nothing Then
                ChangeListView()
            End If
        End If
EndLine:
    End Sub

    Private Function ChangeListView()
        BezirkNr = SelectedBezirk
        AusträgerVornameStr = Austräger.GetVornameByBezirk(BezirkNr)
        AusträgerNachnameStr = Austräger.GetNameByBezirk(BezirkNr)
        If AusträgerNachnameStr <> "NULL" And AusträgerVornameStr <> "NULL" Then
            ListView1.Items.Clear()
            ListView1.Items.Add(New ListViewItem({"Empfängerliste ", Organisation & " - ", Projekt, " vom ", Date.Today.ToShortDateString}))
            ListView1.Items.Add(New ListViewItem({"Bezirk-Nr.: " & BezirkNr, "Austräger: ", AusträgerNachnameStr & ",", AusträgerVornameStr}))
            ListView1.Items.Add("")
            BezirkeCount = Bezirke.GetCount(BezirkNr)
            For i As Long = 0 To BezirkeCount - 1
                StraßenStr = Bezirke.GetStraßenByBezirk(BezirkNr, i)
                OrtStr = Bezirke.GetOrtByBezirk(BezirkNr, i)
                PLZStr = Bezirke.GetPLZByBezirk(BezirkNr, i)
                PersonenCount = Personen.GetCountByKnown(StraßenStr, OrtStr, PLZStr)
                For i2 As Long = 0 To PersonenCount - 1
                    ID = Personen.GetIDByKnown(i2, StraßenStr, OrtStr, PLZStr)
                    VornameStr = Personen.GetVorname(ID)
                    NachnameStr = Personen.GetNachname(ID)
                    HausnummerStr = Personen.GetHausNr(ID)
                    ZusatzStr = Personen.GetZusatz(ID)
                    Dim lvi As New ListViewItem
                    lvi.Text = NachnameStr
                    lvi.SubItems.Add(VornameStr)
                    lvi.SubItems.Add(StraßenStr)
                    lvi.SubItems.Add(HausnummerStr)
                    lvi.SubItems.Add(ZusatzStr)
                    ListView1.Items.Add(lvi)
                Next
                ListView1.Items.Add("")
                ListView1.Items.Add(New ListViewItem({"Anzahl ", StraßenStr & ": ", PersonenCount}))
                ListView1.Items.Add("")
                ListView1.Items.Add("")
                count = count + PersonenCount
            Next
            ListView1.Items.Add("")
            ListView1.Items.Add("Gesamt: " & count)
            count = Nothing
        Else
            MsgBox("Der Austräger ist NULL, bitte ändern Sie dies im Menü 'Austräger'", MsgBoxStyle.Exclamation, "Achtung")
        End If
        Return 0
    End Function

    Private Sub B_Next_Click(sender As Object, e As EventArgs) Handles B_Next.Click
        Dim SelectedObjects As New ListBox.SelectedObjectCollection(ListBox2)
        SelectedCount = SelectedObjects.Count
        If SelectedCount - 1 > Page Then
            B_Previous.Enabled = True
            Page = Page + 1
            SelectedBezirk = SelectedObjects.Item(Page)
            If ListBox2.SelectedItem <> Nothing Then
                ChangeListView()
            End If
        End If
        If Page = SelectedCount - 1 Then
            B_Next.Enabled = False
        End If
    End Sub

    Private Sub B_Previous_Click(sender As Object, e As EventArgs) Handles B_Previous.Click
        Dim SelectedObjects As New ListBox.SelectedObjectCollection(ListBox2)
        SelectedCount = SelectedObjects.Count
        If 0 < Page Then
            B_Next.Enabled = True
            Page = Page - 1
            SelectedBezirk = SelectedObjects.Item(Page)
            If ListBox2.SelectedItem <> Nothing Then
                ChangeListView()
            End If
        End If
        If Page = 0 Then
            B_Previous.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SelectedBezirk <> 0 And SelectedBezirk > 0 Then
            Dim SelectedObjects As New ListBox.SelectedObjectCollection(ListBox2)
            For i As Long = 1 To SelectedCount
                SelectedBezirk = SelectedObjects.Item(i - 1)
                ChangeListView()
                PrintLV = New CPrintListView(ListView1)
                PrintLV.AutoSizeColumn = CPrintListView.SizeColumn.AutoSitze
                PrintDialog1.Document = PrintDocument1
                PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
                PrintDialog1.PrinterSettings.PrinterName = "Microsoft Print to PDF"
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                Try
                    PrintLV.Print(PrintDocument1.PrinterSettings.PrinterName.ToString)
                Catch ex As Exception
                    MsgBox("Da ist etwas schief gelaufen. Prüfen Sie bitte, ob der Drucker 'Microsoft Print to PDF' isntalliert ist.", MsgBoxStyle.Critical)
                End Try
            Next
        End If
    End Sub
End Class