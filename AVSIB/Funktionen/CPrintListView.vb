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
'Das Drucken der ListBox basiert auf einer Klassen von Matthias Zürn. Für weitere Informationen wenden Sie sich bitte an den Autor der 
'ursprünglichen Funktion
'http://www.vbarchiv.net/tipps/tipp_1473-listview-inhalt-drucken-vb-2005.html

Imports System.Drawing
Imports System.Windows.Forms

Public Class CPrintListView
    Private LV As ListView
    Private SpaltenBreite As New List(Of Integer)
    Private TextHöhe As Integer
    Private OffsetSpalte As Integer
    Private OffsetZeile As Integer
    Private MerkerSpalte As Integer
    Private MerkerZeile As Integer
    Public HeaderColor As System.Drawing.Color = Color.LightGray
    Private WithEvents PD As New System.Drawing.Printing.PrintDocument
    Private asc As SizeColumn = SizeColumn.None

    Public Enum SizeColumn
        None
        ScretchColumn
        AutoSitze
    End Enum

    Public Property AutoSizeColumn() As SizeColumn
        Get
            Return asc
        End Get
        Set(ByVal value As SizeColumn)
            asc = value
            SizeColums()
        End Set
    End Property

    Public Property Landscape() As Boolean
        Get
            Return PD.DefaultPageSettings.Landscape
        End Get
        Set(ByVal value As Boolean)
            PD.DefaultPageSettings.Landscape = value
            SizeColums()
        End Set
    End Property

    Private Sub SizeColums()
        Dim breite As Integer
        Dim g As Graphics = LV.CreateGraphics
        Dim zähler As Integer

        SpaltenBreite.Clear()
        Select Case asc
            Case SizeColumn.None, SizeColumn.ScretchColumn
                For Each CH As Windows.Forms.ColumnHeader In LV.Columns
                    SpaltenBreite.Add(CH.Width)
                Next
            Case SizeColumn.AutoSitze, SizeColumn.ScretchColumn
                If asc = SizeColumn.AutoSitze Then
                    For Each CH As Windows.Forms.ColumnHeader In LV.Columns
                        breite = g.MeasureString(CH.Text, LV.Font).Width + 20
                        SpaltenBreite.Add(breite)
                    Next
                End If
                For Each LVI As ListViewItem In LV.Items
                    zähler = 0
                    breite = g.MeasureString(LVI.Text, LV.Font).Width + 20
                    If asc = SizeColumn.AutoSitze Then SpaltenBreite.Add(breite)
                    If SpaltenBreite(zähler) + 20 < breite Then SpaltenBreite(zähler) = breite
                    For Each LVSI As ListViewItem.ListViewSubItem In LVI.SubItems
                        breite = g.MeasureString(LVSI.Text, LV.Font).Width + 20
                        If SpaltenBreite(zähler) + 20 < breite Then SpaltenBreite(zähler) = breite
                        zähler += 1
                    Next
                Next
        End Select
    End Sub

    Public Sub New()
    End Sub

    Public Sub New(ByVal ListViewToPrint As ListView)
        LV = ListViewToPrint
        Dim g As Graphics = LV.CreateGraphics
        TextHöhe = g.MeasureString("XyZ1!", LV.Font).Height + 5
        SizeColums()
        SpaltenBreite.Add(0)
        g.Dispose()
    End Sub

    Public Sub Print(ByVal PName As String)
        PD.PrinterSettings.PrinterName = PName
        PD.Print()
    End Sub

    Public Sub Preview()
        Dim PrintPrev As New System.Windows.Forms.PrintPreviewDialog
        Dim PDial As New System.Drawing.Printing.PrinterSettings
        PrintPrev.Document = PD
        PDial.PrinterName = PD.PrinterSettings.PrinterName
        PrintPrev.WindowState = FormWindowState.Maximized
        PrintPrev.ShowDialog()
        PrintPrev.Close()
    End Sub

    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

        Dim left As Decimal = PD.DefaultPageSettings.Margins.Left
        Dim right As Decimal = PD.DefaultPageSettings.Margins.Right
        Dim top As Decimal = PD.DefaultPageSettings.Margins.Top
        Dim bottom As Decimal = PD.DefaultPageSettings.Margins.Bottom
        Dim PageWidth As Integer = PD.DefaultPageSettings.Bounds.Width - (right + left)
        Dim PageHeight As Decimal = PD.DefaultPageSettings.Bounds.Height - (top + bottom)
        Dim sf As New StringFormat

        sf.Alignment = StringAlignment.Near
        sf.LineAlignment = StringAlignment.Center

        Dim rf As New Rectangle
        Dim br As SolidBrush
        Dim br1 As SolidBrush
        Dim PosX As Integer = left
        Dim PosY As Integer = top
        Dim OffsetSpalte As Integer
        Dim OffsetZeile As Integer

        PosX = left
        OffsetSpalte = 0
        OffsetZeile = 0
        Do
            OffsetZeile = 0
            PosY = top + TextHöhe
            Do
                If (LV.Items(OffsetZeile + MerkerZeile).SubItems.Count > OffsetSpalte + MerkerSpalte) Then
                    rf = New Rectangle(PosX, PosY, SpaltenBreite(OffsetSpalte + MerkerSpalte), TextHöhe)
                    If LV.Items(OffsetZeile + MerkerZeile).UseItemStyleForSubItems = True Then
                        br = New SolidBrush(LV.Items(OffsetZeile + MerkerZeile).BackColor)
                        br1 = New SolidBrush(LV.Items(OffsetZeile + MerkerZeile).ForeColor)
                    Else
                        br = New SolidBrush(LV.Items(OffsetZeile + MerkerZeile).SubItems(OffsetSpalte + MerkerSpalte).BackColor)
                        br1 = New SolidBrush(LV.Items(OffsetZeile + MerkerZeile).SubItems(OffsetSpalte + MerkerSpalte).ForeColor)
                    End If
                    e.Graphics.FillRectangle(br, rf)
                    If LV.GridLines Then e.Graphics.DrawRectangle(New Pen(LV.ForeColor), rf)

                    Select Case LV.Columns(OffsetSpalte + MerkerSpalte).TextAlign
                        Case HorizontalAlignment.Center
                            sf.Alignment = StringAlignment.Center
                        Case HorizontalAlignment.Left
                            sf.Alignment = StringAlignment.Near
                        Case HorizontalAlignment.Right
                            sf.Alignment = StringAlignment.Far
                    End Select
                    e.Graphics.DrawString(LV.Items(OffsetZeile + MerkerZeile).SubItems(OffsetSpalte + MerkerSpalte).Text, LV.Font, br1, rf, sf)
                End If

                PosY += TextHöhe
                OffsetZeile += 1
            Loop Until PageHeight + top < PosY + TextHöhe Or OffsetZeile + MerkerZeile >= LV.Items.Count

            PosX += SpaltenBreite(OffsetSpalte + MerkerSpalte)
            OffsetSpalte += 1
        Loop Until PageWidth + left < PosX + SpaltenBreite(OffsetSpalte + MerkerSpalte) Or OffsetSpalte + MerkerSpalte >= LV.Columns.Count

        If OffsetSpalte + MerkerSpalte = LV.Columns.Count And OffsetZeile + MerkerZeile = LV.Items.Count Then
            e.HasMorePages = False
            MerkerZeile = 0
            MerkerSpalte = 0
            OffsetSpalte = 0
            OffsetZeile = 0
            Exit Sub
        End If

        If OffsetZeile + MerkerZeile < LV.Items.Count Then
            MerkerZeile = OffsetZeile + MerkerZeile
            e.HasMorePages = True
            Exit Sub
        End If

        If MerkerSpalte = OffsetSpalte < LV.Columns.Count Then
            MerkerSpalte = OffsetSpalte + MerkerSpalte
            MerkerZeile = 0
            e.HasMorePages = True
            Exit Sub
        End If
    End Sub
End Class